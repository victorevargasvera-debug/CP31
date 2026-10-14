using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x0200053E RID: 1342
	[global::System.Serializable]
	public class MPLListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B237 RID: 45623 RVA: 0x00A58224 File Offset: 0x00A56424
		public MPLListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x00A58240 File Offset: 0x00A56440
		protected MPLListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x00A58258 File Offset: 0x00A56458
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1217546406;
			short num2 = num;
			num = (short)1547913382;
			switch (num2 == num)
			{
			}
			num = (short)92471297;
			if (num != 0)
			{
			}
			num = (short)2116288512;
			short num3 = num;
			num = (short)1222311936;
			if (num != 0)
			{
			}
			this.mplCfgMPLListMPLAlias_A8548 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠껢뗤ꯦ꣨蟪蓬軮苰곲듴쿶쳸쿺염", a_), global::CommonResources.AcgResources.ID_MPLALIAS, 14);
			this.mplCfgMPLListMPLAlias_A8548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mplCfgMPLListMPLAlias_A8548.DataTransferOrder = 11;
			this.mplCfgMPLListRxDPLCode_A9008 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListRxDPLCode_A9008LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListRxDPLCode_A9008LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠뇢鷤ꏦ맨꟪껬胮闰雲ꫴ뛶샸쯺췼쟾", a_), global::CommonResources.AcgResources.ID_RXTADPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxDPLCode_A9008LovStrs);
			this.mplCfgMPLListRxDPLCode_A9008.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListRxDPLCode_A9008.DataTransferOrder = 10;
			this.mplCfgMPLListRxDPLInvert_A9009 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠뇢鷤ꏦ맨꟪ꓬ臮蟰雲蟴菶꛸뫺쓼쿾㄀㨂", a_), global::CommonResources.AcgResources.ID_RXTADPLINVERT, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxDPLInvert_A9009LovStrs);
			this.mplCfgMPLListRxDPLInvert_A9009.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListRxDPLInvert_A9009.DataTransferOrder = 18;
			this.mplCfgMPLListRxPLCode_A9026 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListRxPLCode_A9026LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListRxPLCode_A9026LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠뇢鷤럦ꗨ꣪苬诮铰곲듴컶째짺쯼", a_), global::CommonResources.AcgResources.ID_RXTAPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxPLCode_A9026LovStrs);
			this.mplCfgMPLListRxPLCode_A9026.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListRxPLCode_A9026.DataTransferOrder = 5;
			this.mplCfgMPLListRxPLFreq_A9027 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListRxPLFreq_A9027LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListRxPLFreq_A9027LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠뇢鷤럦ꗨ귪鿬諮胰곲듴컶째짺쫼", a_), global::CommonResources.AcgResources.ID_RXTAPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxPLFreq_A9027LovStrs);
			this.mplCfgMPLListRxPLFreq_A9027.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListRxPLFreq_A9027.DataTransferOrder = 4;
			this.mplCfgMPLListRxSquelchType_A9028 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListRxSquelchType_A9028LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListRxSquelchType_A9028LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠뇢鷤듦飨黪裬菮鋰鯲ꇴ軶觸黺ꋼ뻾㠀㌂㜄㼆", a_), global::CommonResources.AcgResources.ID_RXTASQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxSquelchType_A9028LovStrs);
			this.mplCfgMPLListRxSquelchType_A9028.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListRxSquelchType_A9028.DataTransferOrder = 1;
			this.mplCfgMPLListTADPLCode_A9257 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTADPLCode_A9257LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTADPLCode_A9257LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢ꓤꏦ맨꟪껬胮闰雲ꫴ뛶샸짺주죾", a_), global::CommonResources.AcgResources.ID_DIRECTDPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTADPLCode_A9257LovStrs);
			this.mplCfgMPLListTADPLCode_A9257.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTADPLCode_A9257.DataTransferOrder = 14;
			this.mplCfgMPLListTADPLInvert_A9258 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢ꓤꏦ맨꟪ꓬ臮蟰雲蟴菶꛸뫺쓼췾㐀㬂", a_), global::CommonResources.AcgResources.ID_DIRECTDPLINVERT, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTADPLInvert_A9258LovStrs);
			this.mplCfgMPLListTADPLInvert_A9258.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTADPLInvert_A9258.DataTransferOrder = 15;
			this.mplCfgMPLListTAPLCode_A9262 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTAPLCode_A9262LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTAPLCode_A9262LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢ꓤ럦ꗨ꣪苬诮铰곲듴컶쯸췺쿼", a_), global::CommonResources.AcgResources.ID_DIRECTPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTAPLCode_A9262LovStrs);
			this.mplCfgMPLListTAPLCode_A9262.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTAPLCode_A9262.DataTransferOrder = 9;
			this.mplCfgMPLListTAPLFreq_A9263 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTAPLFreq_A9263LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTAPLFreq_A9263LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢ꓤ럦ꗨ귪鿬諮胰곲듴컶쯸췺컼", a_), global::CommonResources.AcgResources.ID_DIRECTPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTAPLFreq_A9263LovStrs);
			this.mplCfgMPLListTAPLFreq_A9263.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTAPLFreq_A9263.DataTransferOrder = 8;
			this.mplCfgMPLListTASquelchType_A9266 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTASquelchType_A9266LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTASquelchType_A9266LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢ꓤ듦飨黪裬菮鋰鯲ꇴ軶觸黺ꋼ뻾㠀㄂㌄ㄆ", a_), global::CommonResources.AcgResources.ID_DIRECTSQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTASquelchType_A9266LovStrs);
			this.mplCfgMPLListTASquelchType_A9266.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTASquelchType_A9266.DataTransferOrder = 3;
			this.mplCfgMPLListTxDPLCode_A9527 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTxDPLCode_A9527LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTxDPLCode_A9527LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢鷤ꏦ맨꟪껬胮闰雲ꫴ뛶샸컺쿼죾", a_), global::CommonResources.AcgResources.ID_TXDPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxDPLCode_A9527LovStrs);
			this.mplCfgMPLListTxDPLCode_A9527.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTxDPLCode_A9527.DataTransferOrder = 16;
			this.mplCfgMPLListTxDPLInvert_A9528 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢鷤ꏦ맨꟪ꓬ臮蟰雲蟴菶꛸뫺쓼쫾㌀㬂", a_), global::CommonResources.AcgResources.ID_TXDPLINVERT, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxDPLInvert_A9528LovStrs);
			this.mplCfgMPLListTxDPLInvert_A9528.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTxDPLInvert_A9528.DataTransferOrder = 17;
			this.mplCfgMPLListTxPLCode_A9555 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTxPLCode_A9555LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTxPLCode_A9555LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢鷤럦ꗨ꣪苬诮铰곲듴컶쳸컺주", a_), global::CommonResources.AcgResources.ID_TXPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxPLCode_A9555LovStrs);
			this.mplCfgMPLListTxPLCode_A9555.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTxPLCode_A9555.DataTransferOrder = 7;
			this.mplCfgMPLListTxPLFreq_A9556 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTxPLFreq_A9556LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTxPLFreq_A9556LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢鷤럦ꗨ귪鿬諮胰곲듴컶쳸컺쯼", a_), global::CommonResources.AcgResources.ID_TXPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxPLFreq_A9556LovStrs);
			this.mplCfgMPLListTxPLFreq_A9556.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTxPLFreq_A9556.DataTransferOrder = 6;
			this.mplCfgMPLListTxSquelchType_A9567 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTxSquelchType_A9567LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTxSquelchType_A9567LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓈믊ꇌ賎럐듒飔蟖闘韚드곞闠럢鷤듦飨黪裬菮鋰鯲ꇴ軶觸黺ꋼ뻾㠀㘂㌄〆", a_), global::CommonResources.AcgResources.ID_TXSQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxSquelchType_A9567LovStrs);
			this.mplCfgMPLListTxSquelchType_A9567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.mplCfgMPLListTxSquelchType_A9567.DataTransferOrder = 2;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓈鯊臌鷐뫒ꛔꏖ", a_);
			base.Id = 10193;
			base.UIName = global::CommonResources.AcgResources.ID_MPLLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x00A587C4 File Offset: 0x00A569C4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)609222665;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_93A;
				case 1:
					goto IL_123;
				case 2:
					num = (short)1892352001;
					if (num != 0)
					{
					}
					this.mplCfgMPLListTADPLInvert_A9258 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬꯮ꇰ뿲보駶迸黺迼课帀䈂㰄㔆㰈㌊", a_), global::CommonResources.AcgResources.ID_DIRECTDPLINVERT, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTADPLInvert_A9258LovStrs);
					this.mplCfgMPLListTADPLInvert_A9258.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTADPLInvert_A9258.DataTransferOrder = 15;
					num = (short)1864761378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬볮胰蛲郴鯶髸鏺ꧼ蛾焀昂娄䘆〈㤊㬌㤎", a_)))
					{
						num = (short)736100371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_123;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬볮胰蛲郴鯶髸鏺ꧼ蛾焀昂娄䘆〈㬊㼌㜎", a_)))
					{
						num = (short)103022634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_575;
				case 5:
					this.mplCfgMPLListTxDPLInvert_A9528 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬꯮ꇰ뿲보駶迸黺迼课帀䈂㰄㈆㬈㌊", a_), global::CommonResources.AcgResources.ID_TXDPLINVERT, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxDPLInvert_A9528LovStrs);
					this.mplCfgMPLListTxDPLInvert_A9528.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTxDPLInvert_A9528.DataTransferOrder = 17;
					num = (short)335478825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_AF4;
				case 7:
					this.mplCfgMPLListRxPLCode_A9026 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListRxPLCode_A9026LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListRxPLCode_A9026LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬뿮뷰냲髴鏶鳸ꓺ볼웾㄀㄂㌄", a_), global::CommonResources.AcgResources.ID_RXTAPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxPLCode_A9026LovStrs);
					this.mplCfgMPLListRxPLCode_A9026.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListRxPLCode_A9026.DataTransferOrder = 5;
					num = (short)1886715942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.mplCfgMPLListRxDPLInvert_A9009 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬꯮ꇰ뿲보駶迸黺迼课帀䈂㰄㜆㤈㈊", a_), global::CommonResources.AcgResources.ID_RXTADPLINVERT, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxDPLInvert_A9009LovStrs);
					this.mplCfgMPLListRxDPLInvert_A9009.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListRxDPLInvert_A9009.DataTransferOrder = 18;
					num = (short)27787287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_FD;
					}
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬꯮ꇰ뿲뛴飶鷸黺ꋼ뻾㠀㄂〄〆", a_)))
					{
						num = (short)347275286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A51;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬꯮ꇰ뿲뛴飶鷸黺ꋼ뻾㠀㘂㜄〆", a_)))
					{
						num = (short)892338213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD4;
				case 12:
					goto IL_A51;
				case 13:
				{
					this.mplCfgMPLListTAPLCode_A9262 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTAPLCode_A9262LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTAPLCode_A9262LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬뿮뷰냲髴鏶鳸ꓺ볼웾㌀㔂㜄", a_), global::CommonResources.AcgResources.ID_DIRECTPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTAPLCode_A9262LovStrs);
					this.mplCfgMPLListTAPLCode_A9262.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTAPLCode_A9262.DataTransferOrder = 9;
					num = (short)2140424485;
					short num3 = num;
					num = (short)597772581;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_93A;
					default:
						num = (short)1405878272;
						if (num != 0)
						{
						}
						num = (short)1430781985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬뿮뷰냲髴鏶鳸ꓺ볼웾㄀㄂㌄", a_)))
					{
						num = (short)547749895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_694;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨ꛪ뷬ꏮ냰鿲鳴零諸ꓺ볼쟾㐀㜂㴄", a_)))
					{
						num = (short)1756495908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CC;
				case 16:
					this.mplCfgMPLListRxPLFreq_A9027 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListRxPLFreq_A9027LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListRxPLFreq_A9027LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬뿮뷰뗲蟴鋶裸ꓺ볼웾㄀㄂㈄", a_), global::CommonResources.AcgResources.ID_RXTAPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxPLFreq_A9027LovStrs);
					this.mplCfgMPLListRxPLFreq_A9027.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListRxPLFreq_A9027.DataTransferOrder = 4;
					num = (short)1935474688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.mplCfgMPLListTxPLFreq_A9556 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTxPLFreq_A9556LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTxPLFreq_A9556LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬뿮뷰뗲蟴鋶裸ꓺ볼웾㐀㘂㌄", a_), global::CommonResources.AcgResources.ID_TXPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxPLFreq_A9556LovStrs);
					this.mplCfgMPLListTxPLFreq_A9556.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTxPLFreq_A9556.DataTransferOrder = 6;
					num = (short)449183771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬뿮뷰냲髴鏶鳸ꓺ볼웾㐀㘂〄", a_)))
					{
						num = (short)1454702632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E1;
				case 19:
					this.mplCfgMPLListTASquelchType_A9266 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTASquelchType_A9266LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTASquelchType_A9266LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬볮胰蛲郴鯶髸鏺ꧼ蛾焀昂娄䘆〈㤊㬌㤎", a_), global::CommonResources.AcgResources.ID_DIRECTSQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTASquelchType_A9266LovStrs);
					this.mplCfgMPLListTASquelchType_A9266.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTASquelchType_A9266.DataTransferOrder = 3;
					num = (short)74252289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬뿮뷰뗲蟴鋶裸ꓺ볼웾㌀㔂㘄", a_)))
					{
						num = (short)1960706048;
						short num4 = num;
						num = (short)725024800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF4;
				case 21:
					goto IL_575;
				case 22:
					this.mplCfgMPLListTADPLCode_A9257 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTADPLCode_A9257LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTADPLCode_A9257LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬꯮ꇰ뿲뛴飶鷸黺ꋼ뻾㠀㄂〄〆", a_), global::CommonResources.AcgResources.ID_DIRECTDPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTADPLCode_A9257LovStrs);
					this.mplCfgMPLListTADPLCode_A9257.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTADPLCode_A9257.DataTransferOrder = 14;
					num = (short)1186267148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_64A;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬꯮ꇰ뿲보駶迸黺迼课帀䈂㰄㜆㤈㈊", a_)))
					{
						num = (short)1865547784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64A;
				case 25:
					goto IL_2CC;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬볮胰蛲郴鯶髸鏺ꧼ蛾焀昂娄䘆〈㸊㬌㠎", a_)))
					{
						num = (short)1988624429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D20;
				case 27:
					goto IL_C89;
				case 28:
					num = (short)1306263567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬뿮뷰뗲蟴鋶裸ꓺ볼웾㐀㘂㌄", a_)))
					{
						num = (short)1818951697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C89;
				case 30:
					goto IL_570;
				case 31:
					this.mplCfgMPLListRxDPLCode_A9008 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListRxDPLCode_A9008LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListRxDPLCode_A9008LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬꯮ꇰ뿲뛴飶鷸黺ꋼ뻾㠀㌂㔄㼆", a_), global::CommonResources.AcgResources.ID_RXTADPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxDPLCode_A9008LovStrs);
					this.mplCfgMPLListRxDPLCode_A9008.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListRxDPLCode_A9008.DataTransferOrder = 10;
					num = (short)752812071;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					this.mplCfgMPLListTAPLFreq_A9263 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTAPLFreq_A9263LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTAPLFreq_A9263LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬뿮뷰뗲蟴鋶裸ꓺ볼웾㌀㔂㘄", a_), global::CommonResources.AcgResources.ID_DIRECTPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTAPLFreq_A9263LovStrs);
					this.mplCfgMPLListTAPLFreq_A9263.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTAPLFreq_A9263.DataTransferOrder = 8;
					num = (short)611516422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					goto IL_B8F;
				case 34:
					goto IL_3EC;
				case 35:
					goto IL_6E1;
				case 36:
					this.mplCfgMPLListMPLAlias_A8548 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨ꛪ뷬ꏮ냰鿲鳴零諸ꓺ볼쟾㐀㜂㴄", a_), global::CommonResources.AcgResources.ID_MPLALIAS, 14);
					this.mplCfgMPLListMPLAlias_A8548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mplCfgMPLListMPLAlias_A8548.DataTransferOrder = 11;
					num = (short)1716518937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					this.mplCfgMPLListTxDPLCode_A9527 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTxDPLCode_A9527LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTxDPLCode_A9527LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬꯮ꇰ뿲뛴飶鷸黺ꋼ뻾㠀㘂㜄〆", a_), global::CommonResources.AcgResources.ID_TXDPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxDPLCode_A9527LovStrs);
					this.mplCfgMPLListTxDPLCode_A9527.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTxDPLCode_A9527.DataTransferOrder = 16;
					num = (short)1933377586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_694;
				case 39:
					goto IL_5FE;
				case 40:
					this.mplCfgMPLListTxPLCode_A9555 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTxPLCode_A9555LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTxPLCode_A9555LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬뿮뷰냲髴鏶鳸ꓺ볼웾㐀㘂〄", a_), global::CommonResources.AcgResources.ID_TXPLCODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxPLCode_A9555LovStrs);
					this.mplCfgMPLListTxPLCode_A9555.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTxPLCode_A9555.DataTransferOrder = 7;
					num = (short)1630470179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					goto IL_27F;
				case 42:
					this.mplCfgMPLListRxSquelchType_A9028 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListRxSquelchType_A9028LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListRxSquelchType_A9028LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬볮胰蛲郴鯶髸鏺ꧼ蛾焀昂娄䘆〈㬊㼌㜎", a_), global::CommonResources.AcgResources.ID_RXTASQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListRxSquelchType_A9028LovStrs);
					this.mplCfgMPLListRxSquelchType_A9028.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListRxSquelchType_A9028.DataTransferOrder = 1;
					num = (short)871956501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬꯮ꇰ뿲보駶迸黺迼课帀䈂㰄㔆㰈㌊", a_)))
					{
						num = (short)357236738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EC;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪곬뿮뷰냲髴鏶鳸ꓺ볼웾㌀㔂㜄", a_)))
					{
						num = (short)2032205837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8F;
				case 45:
					this.mplCfgMPLListTxSquelchType_A9567 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.indexMplCfgMPLListTxSquelchType_A9567LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.idMplCfgMPLListTxSquelchType_A9567LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬볮胰蛲郴鯶髸鏺ꧼ蛾焀昂娄䘆〈㸊㬌㠎", a_), global::CommonResources.AcgResources.ID_TXSQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgMPLListTxSquelchType_A9567LovStrs);
					this.mplCfgMPLListTxSquelchType_A9567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.mplCfgMPLListTxSquelchType_A9567.DataTransferOrder = 2;
					num = (short)441909278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					if (producerFields != null)
					{
						num = (short)910229532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D20;
				case 47:
					num = (short)501940270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬꯮ꇰ뿲뛴飶鷸黺ꋼ뻾㠀㌂㔄㼆", a_)))
					{
						num = (short)1858666527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5FE;
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨뿪闬꯮ꇰ뿲보駶迸黺迼课帀䈂㰄㈆㬈㌊", a_)))
					{
						num = (short)263782405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27F;
				case 50:
					goto IL_CD4;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳐ꏒ맔铖뿘볚郜连균꿢賤铦鷨맪闬뿮뷰뗲蟴鋶裸ꓺ볼웾㄀㄂㈄", a_)))
					{
						num = (short)1688666128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A02;
				}
				IL_FD:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1947992111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_123:
				num = (short)916652043;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27F:
				num = (short)194445330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CC:
				num = (short)1147928624;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EC:
				num = (short)608174124;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_575:
				num = (short)67174410;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5FE:
				num = (short)1082916888;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64A:
				num = (short)1189150734;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_694:
				num = (short)1072627763;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6E1:
				num = (short)1183711261;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A02:
				num = (short)1121124356;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_93A:
				goto IL_A02;
				IL_A51:
				num = (short)1347747883;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AF4:
				num = (short)1614479363;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B8F:
				num = (short)1717239828;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C89:
				num = (short)1956446234;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD4:
				num = (short)4784177;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_570:
			IL_D20:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳐菒駔闘닚껜ꯞ", a_);
			base.Id = 10193;
			base.UIName = global::CommonResources.AcgResources.ID_MPLLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x00A59524 File Offset: 0x00A57724
		public override void PopulateReferences()
		{
			short num = (short)64290816;
			short num2 = num;
			num = (short)1646751296;
			short num3 = num;
			num = (short)966159936;
			switch (num3 == num)
			{
			}
			num = (short)954728448;
			if (num != 0)
			{
			}
			num = (short)83820545;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x00A595CC File Offset: 0x00A577CC
		public override void DropReferences()
		{
			short num = (short)985792512;
			short num2 = num;
			num = (short)580850211;
			short num3 = num;
			num = (short)482415139;
			switch (num3 == num)
			{
			}
			num = (short)263716865;
			if (num != 0)
			{
			}
			num = (short)1560018944;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x00A59674 File Offset: 0x00A57874
		public override void SetConstraints()
		{
			short num = (short)312934400;
			short num2 = num;
			num = (short)1778412222;
			short num3 = num;
			num = (short)1973381822;
			switch (num3 == num)
			{
			}
			num = (short)390856705;
			if (num != 0)
			{
			}
			num = (short)144441344;
			if (num != 0)
			{
			}
			this.mplCfgMPLListRxDPLCode_A9008.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplRxSqTypeIsDpl);
			this.mplCfgMPLListRxDPLInvert_A9009.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplRxSqTypeIsDpl);
			this.mplCfgMPLListRxPLCode_A9026.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplRxTASqTypeIsPl);
			this.mplCfgMPLListRxPLCode_A9026.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplRxTASqTypeIsPlEditbl);
			this.mplCfgMPLListRxPLCode_A9026.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conSetRxPlFreqBasedOnRxTAPlCode);
			this.mplCfgMPLListRxPLFreq_A9027.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplRxTASqTypeIsPl);
			this.mplCfgMPLListRxPLFreq_A9027.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplRxTASqTypeIsPlEditbl);
			this.mplCfgMPLListRxPLFreq_A9027.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conSetRxPlCodeBasedOnRxTAPlFreqValue);
			this.mplCfgMPLListTADPLCode_A9257.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conMPLDirectFreqEnAndDirectSqlchIsDPL);
			this.mplCfgMPLListTADPLCode_A9257.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conIsDirectFreqEn);
			this.mplCfgMPLListTADPLInvert_A9258.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conMPLDirectFreqEnAndDirectSqlchIsDPL);
			this.mplCfgMPLListTADPLInvert_A9258.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conIsDirectFreqEn);
			this.mplCfgMPLListTAPLCode_A9262.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplDirectSqTypeIsPl);
			this.mplCfgMPLListTAPLCode_A9262.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conIsDirectFreqEn);
			this.mplCfgMPLListTAPLCode_A9262.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplDirectSqTypeIsPlEditbl);
			this.mplCfgMPLListTAPLCode_A9262.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conSetTaPlFreqBasedOnTAPlCode);
			this.mplCfgMPLListTAPLFreq_A9263.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplDirectSqTypeIsPl);
			this.mplCfgMPLListTAPLFreq_A9263.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conIsDirectFreqEn);
			this.mplCfgMPLListTAPLFreq_A9263.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplDirectSqTypeIsPlEditbl);
			this.mplCfgMPLListTAPLFreq_A9263.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conSetTaPlCodeBasedOnTAPlFreqValue);
			this.mplCfgMPLListTASquelchType_A9266.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conIsDirectFreqEn);
			this.mplCfgMPLListTxDPLCode_A9527.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplTxSqTypeIsDpl);
			this.mplCfgMPLListTxDPLInvert_A9528.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMplTxSqTypeIsDpl);
			this.mplCfgMPLListTxPLCode_A9555.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMPLTxSquelchTypeIsPL);
			this.mplCfgMPLListTxPLCode_A9555.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMPLTxSquelchTypeIsPLEditbl);
			this.mplCfgMPLListTxPLCode_A9555.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conSetTxPlFreqBasedOnTxPlCode);
			this.mplCfgMPLListTxPLFreq_A9556.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMPLTxSquelchTypeIsPL);
			this.mplCfgMPLListTxPLFreq_A9556.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.ConMPLTxSquelchTypeIsPLEditbl);
			this.mplCfgMPLListTxPLFreq_A9556.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationConstraints.conSetTxPlCodeBasedOnTxPlFreqValue);
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x00A599B8 File Offset: 0x00A57BB8
		public override void SetupDependencies()
		{
			short num = (short)1101725696;
			short num2 = num;
			num = (short)706969508;
			short num3 = num;
			num = (short)1487830948;
			switch (num3 == num)
			{
			}
			num = (short)1716781056;
			if (num != 0)
			{
			}
			num = (short)717488129;
			if (num != 0)
			{
			}
			this.mplCfgMPLListRxSquelchType_A9028.AddDependentObject(this.mplCfgMPLListRxDPLCode_A9008);
			this.mplCfgMPLListRxSquelchType_A9028.AddDependentObject(this.mplCfgMPLListRxDPLInvert_A9009);
			this.mplCfgMPLListRxSquelchType_A9028.AddDependentObject(this.mplCfgMPLListRxPLCode_A9026);
			this.mplCfgMPLListRxSquelchType_A9028.AddDependentObject(this.mplCfgMPLListRxPLFreq_A9027);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.mplCfgMPLListTADPLCode_A9257);
			this.mplCfgMPLListTASquelchType_A9266.AddDependentObject(this.mplCfgMPLListTADPLCode_A9257);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.mplCfgMPLListTADPLInvert_A9258);
			this.mplCfgMPLListTASquelchType_A9266.AddDependentObject(this.mplCfgMPLListTADPLInvert_A9258);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.mplCfgMPLListTAPLCode_A9262);
			this.mplCfgMPLListTASquelchType_A9266.AddDependentObject(this.mplCfgMPLListTAPLCode_A9262);
			this.mplCfgMPLListTAPLFreq_A9263.AddDependentObject(this.mplCfgMPLListTAPLCode_A9262);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.mplCfgMPLListTAPLFreq_A9263);
			this.mplCfgMPLListTASquelchType_A9266.AddDependentObject(this.mplCfgMPLListTAPLFreq_A9263);
			this.mplCfgMPLListTAPLCode_A9262.AddDependentObject(this.mplCfgMPLListTAPLFreq_A9263);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.mplCfgMPLListTASquelchType_A9266);
			this.mplCfgMPLListTxSquelchType_A9567.AddDependentObject(this.mplCfgMPLListTxDPLCode_A9527);
			this.mplCfgMPLListTxSquelchType_A9567.AddDependentObject(this.mplCfgMPLListTxDPLInvert_A9528);
			this.mplCfgMPLListTxSquelchType_A9567.AddDependentObject(this.mplCfgMPLListTxPLCode_A9555);
			this.mplCfgMPLListTxPLFreq_A9556.AddDependentObject(this.mplCfgMPLListTxPLCode_A9555);
			this.mplCfgMPLListTxSquelchType_A9567.AddDependentObject(this.mplCfgMPLListTxPLFreq_A9556);
			this.mplCfgMPLListTxPLCode_A9555.AddDependentObject(this.mplCfgMPLListTxPLFreq_A9556);
		}

		// Token: 0x17005945 RID: 22853
		// (get) Token: 0x0600B23F RID: 45631 RVA: 0x00A59C0C File Offset: 0x00A57E0C
		public bool HasDiffs
		{
			get
			{
				short num = (short)2018050048;
				short num2 = num;
				num = (short)1735757311;
				short num3 = num;
				num = (short)667061759;
				switch (num3 == num)
				{
				}
				num = (short)905379841;
				if (num != 0)
				{
				}
				num = (short)1700200448;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005946 RID: 22854
		// (get) Token: 0x0600B240 RID: 45632 RVA: 0x00A59CC0 File Offset: 0x00A57EC0
		// (set) Token: 0x0600B241 RID: 45633 RVA: 0x00A59D74 File Offset: 0x00A57F74
		public string MplCfgMPLListMPLAlias_A8548Value
		{
			get
			{
				short num = (short)1154220032;
				short num2 = num;
				num = (short)1860206751;
				short num3 = num;
				num = (short)41517215;
				switch (num3 == num)
				{
				}
				num = (short)2103902209;
				if (num != 0)
				{
				}
				num = (short)1307836416;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.Value;
			}
			set
			{
				short num = (short)1938948096;
				short num2 = num;
				num = (short)857014273;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						for (;;)
						{
							this.mplCfgMPLListMPLAlias_A8548.Value = value;
							num = (short)1802580652;
							short num4 = num;
							num = (short)831795884;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_C2;
							}
						}
						IL_C2:
						num = (short)278593536;
						if (num != 0)
						{
						}
						num = (short)944177153;
						if (num != 0)
						{
						}
						num = (short)1157824514;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 2:
						return;
					}
					IL_59:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1746206720;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17005947 RID: 22855
		// (get) Token: 0x0600B242 RID: 45634 RVA: 0x00A59E98 File Offset: 0x00A58098
		// (set) Token: 0x0600B243 RID: 45635 RVA: 0x00A59F4C File Offset: 0x00A5814C
		public string MplCfgMPLListMPLAlias_A8548_UIValue
		{
			get
			{
				short num = (short)18350080;
				short num2 = num;
				num = (short)63699142;
				short num3 = num;
				num = (short)1648425158;
				switch (num3 == num)
				{
				}
				num = (short)1609695232;
				if (num != 0)
				{
				}
				num = (short)1479999489;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.Value;
			}
			set
			{
				short num = (short)725614592;
				short num2 = num;
				num = (short)890662493;
				short num3 = num;
				num = (short)1090809437;
				switch (num3 == num)
				{
				}
				num = (short)1159593985;
				if (num != 0)
				{
				}
				num = (short)1605173248;
				if (num != 0)
				{
				}
				this.mplCfgMPLListMPLAlias_A8548.Value = value;
			}
		}

		// Token: 0x17005948 RID: 22856
		// (get) Token: 0x0600B244 RID: 45636 RVA: 0x00A5A000 File Offset: 0x00A58200
		public global::AcpBusinessLayer.AcpKeyField MplCfgMPLListMPLAlias_A8548
		{
			get
			{
				short num = (short)1080623104;
				short num2 = num;
				num = (short)1023279105;
				if (num != 0)
				{
				}
				num = (short)1060151446;
				short num3 = num;
				num = (short)1963827350;
				switch (num3 == num)
				{
				}
				num = (short)724303872;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548;
			}
		}

		// Token: 0x17005949 RID: 22857
		// (get) Token: 0x0600B245 RID: 45637 RVA: 0x00A5A0B4 File Offset: 0x00A582B4
		// (set) Token: 0x0600B246 RID: 45638 RVA: 0x00A5A168 File Offset: 0x00A58368
		public bool MplCfgMPLListMPLAlias_A8548_Applicable
		{
			get
			{
				short num = (short)2100822016;
				short num2 = num;
				num = (short)1509063108;
				short num3 = num;
				num = (short)734689732;
				switch (num3 == num)
				{
				}
				num = (short)2110980096;
				if (num != 0)
				{
				}
				num = (short)233308161;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.Applicable;
			}
			set
			{
				short num = (short)336265216;
				short num2 = num;
				num = (short)557449217;
				if (num != 0)
				{
				}
				num = (short)1483534559;
				short num3 = num;
				num = (short)1255469279;
				switch (num3 == num)
				{
				}
				num = (short)428802048;
				if (num != 0)
				{
				}
				this.mplCfgMPLListMPLAlias_A8548.Applicable = value;
			}
		}

		// Token: 0x1700594A RID: 22858
		// (get) Token: 0x0600B247 RID: 45639 RVA: 0x00A5A21C File Offset: 0x00A5841C
		// (set) Token: 0x0600B248 RID: 45640 RVA: 0x00A5A2D8 File Offset: 0x00A584D8
		public bool MplCfgMPLListMPLAlias_A8548_Valid
		{
			get
			{
				short num = (short)2137849856;
				short num2 = num;
				num = (short)470702334;
				short num3 = num;
				num = (short)542136574;
				switch (num3 == num)
				{
				}
				num = (short)400228352;
				if (num != 0)
				{
				}
				num = (short)1670905857;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.Valid;
			}
			set
			{
				short num = (short)45613056;
				short num2 = num;
				num = (short)1220608001;
				if (num != 0)
				{
				}
				num = (short)940163401;
				short num3 = num;
				num = (short)1412415817;
				switch (num3 == num)
				{
				}
				num = (short)1980432384;
				if (num != 0)
				{
				}
				this.mplCfgMPLListMPLAlias_A8548.Valid = value;
			}
		}

		// Token: 0x1700594B RID: 22859
		// (get) Token: 0x0600B249 RID: 45641 RVA: 0x00A5A390 File Offset: 0x00A58590
		// (set) Token: 0x0600B24A RID: 45642 RVA: 0x00A5A444 File Offset: 0x00A58644
		public bool MplCfgMPLListMPLAlias_A8548_Visible
		{
			get
			{
				short num = (short)1962541056;
				short num2 = num;
				num = (short)1694008348;
				short num3 = num;
				num = (short)1734902812;
				switch (num3 == num)
				{
				}
				num = (short)924254209;
				if (num != 0)
				{
				}
				num = (short)1327562752;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.Visible;
			}
			set
			{
				short num = (short)1826488320;
				short num2 = num;
				num = (short)886057352;
				short num3 = num;
				num = (short)271985032;
				switch (num3 == num)
				{
				}
				num = (short)599064577;
				if (num != 0)
				{
				}
				num = (short)436338688;
				if (num != 0)
				{
				}
				this.mplCfgMPLListMPLAlias_A8548.Visible = value;
			}
		}

		// Token: 0x1700594C RID: 22860
		// (get) Token: 0x0600B24B RID: 45643 RVA: 0x00A5A4FC File Offset: 0x00A586FC
		// (set) Token: 0x0600B24C RID: 45644 RVA: 0x00A5A5B0 File Offset: 0x00A587B0
		public bool MplCfgMPLListMPLAlias_A8548_Editable
		{
			get
			{
				short num = (short)332267520;
				short num2 = num;
				num = (short)1943555344;
				short num3 = num;
				num = (short)1919044880;
				switch (num3 == num)
				{
				}
				num = (short)1248854017;
				if (num != 0)
				{
				}
				num = (short)2113536000;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.Editable;
			}
			set
			{
				short num = (short)1032192000;
				short num2 = num;
				num = (short)736177012;
				short num3 = num;
				num = (short)885926772;
				switch (num3 == num)
				{
				}
				num = (short)1108934656;
				if (num != 0)
				{
				}
				num = (short)548601857;
				if (num != 0)
				{
				}
				this.mplCfgMPLListMPLAlias_A8548.Editable = value;
			}
		}

		// Token: 0x1700594D RID: 22861
		// (get) Token: 0x0600B24D RID: 45645 RVA: 0x00A5A668 File Offset: 0x00A58868
		internal string MplCfgMPLListMPLAlias_A8548_UILabel
		{
			get
			{
				short num = (short)1817772032;
				short num2 = num;
				num = (short)755948271;
				short num3 = num;
				num = (short)1677581039;
				switch (num3 == num)
				{
				}
				num = (short)1789526017;
				if (num != 0)
				{
				}
				num = (short)1310523392;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.UIName;
			}
		}

		// Token: 0x1700594E RID: 22862
		// (get) Token: 0x0600B24E RID: 45646 RVA: 0x00A5A720 File Offset: 0x00A58920
		// (set) Token: 0x0600B24F RID: 45647 RVA: 0x00A5A7D4 File Offset: 0x00A589D4
		internal bool MplCfgMPLListMPLAlias_A8548_HiddenStatic
		{
			get
			{
				short num = (short)87031808;
				short num2 = num;
				num = (short)1670997848;
				short num3 = num;
				num = (short)1268475736;
				switch (num3 == num)
				{
				}
				num = (short)843776001;
				if (num != 0)
				{
				}
				num = (short)1947533312;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.HiddenStatic;
			}
			set
			{
				short num = (short)549781504;
				short num2 = num;
				num = (short)1213875526;
				short num3 = num;
				num = (short)344868166;
				switch (num3 == num)
				{
				}
				num = (short)1216217089;
				if (num != 0)
				{
				}
				num = (short)2048131072;
				if (num != 0)
				{
				}
				this.mplCfgMPLListMPLAlias_A8548.HiddenStatic = value;
			}
		}

		// Token: 0x1700594F RID: 22863
		// (get) Token: 0x0600B250 RID: 45648 RVA: 0x00A5A888 File Offset: 0x00A58A88
		// (set) Token: 0x0600B251 RID: 45649 RVA: 0x00A5A93C File Offset: 0x00A58B3C
		internal bool MplCfgMPLListMPLAlias_A8548_HiddenDynamic
		{
			get
			{
				short num = (short)1937702912;
				short num2 = num;
				num = (short)611527002;
				short num3 = num;
				num = (short)1263741274;
				switch (num3 == num)
				{
				}
				num = (short)225968128;
				if (num != 0)
				{
				}
				num = (short)50790401;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548.HiddenDynamic;
			}
			set
			{
				short num = (short)1154023424;
				short num2 = num;
				num = (short)1440481281;
				if (num != 0)
				{
				}
				num = (short)1793390429;
				short num3 = num;
				num = (short)113506141;
				switch (num3 == num)
				{
				}
				num = (short)1300692992;
				if (num != 0)
				{
				}
				this.mplCfgMPLListMPLAlias_A8548.HiddenDynamic = value;
			}
		}

		// Token: 0x17005950 RID: 22864
		// (get) Token: 0x0600B252 RID: 45650 RVA: 0x00A5A9F4 File Offset: 0x00A58BF4
		public bool MplCfgMPLListMPLAlias_A8548_HasDiffs
		{
			get
			{
				short num = (short)1358626816;
				short num2 = num;
				num = (short)32641498;
				short num3 = num;
				num = (short)679088602;
				switch (num3 == num)
				{
				}
				num = (short)2129920001;
				if (num != 0)
				{
				}
				num = (short)1788149760;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListMPLAlias_A8548._HasDiffs;
			}
		}

		// Token: 0x17005951 RID: 22865
		// (get) Token: 0x0600B253 RID: 45651 RVA: 0x00A5AAAC File Offset: 0x00A58CAC
		// (set) Token: 0x0600B254 RID: 45652 RVA: 0x00A5AB64 File Offset: 0x00A58D64
		public int MplCfgMPLListRxDPLCode_A9008Value
		{
			get
			{
				short num = (short)1018691584;
				short num2 = num;
				num = (short)1227495191;
				short num3 = num;
				num = (short)2103645975;
				switch (num3 == num)
				{
				}
				num = (short)1353973760;
				if (num != 0)
				{
				}
				num = (short)1194852353;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.Value;
			}
			set
			{
				short num = (short)1691877376;
				short num2 = num;
				num = (short)2145152261;
				short num3 = num;
				num = (short)1293118725;
				switch (num3 == num)
				{
				}
				num = (short)1002176513;
				if (num != 0)
				{
				}
				num = (short)261029888;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLCode_A9008.Value = value;
			}
		}

		// Token: 0x17005952 RID: 22866
		// (get) Token: 0x0600B255 RID: 45653 RVA: 0x00A5AC1C File Offset: 0x00A58E1C
		// (set) Token: 0x0600B256 RID: 45654 RVA: 0x00A5ACD0 File Offset: 0x00A58ED0
		public string MplCfgMPLListRxDPLCode_A9008_UIValue
		{
			get
			{
				short num = (short)55705600;
				short num2 = num;
				num = (short)121704876;
				short num3 = num;
				num = (short)222302636;
				switch (num3 == num)
				{
				}
				num = (short)1548419072;
				if (num != 0)
				{
				}
				num = (short)1838809089;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.UIValue;
			}
			set
			{
				short num = (short)1894252544;
				short num2 = num;
				num = (short)1801087222;
				short num3 = num;
				num = (short)809265398;
				switch (num3 == num)
				{
				}
				num = (short)986513408;
				if (num != 0)
				{
				}
				num = (short)1395523585;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLCode_A9008.UIValue = value;
			}
		}

		// Token: 0x17005953 RID: 22867
		// (get) Token: 0x0600B257 RID: 45655 RVA: 0x00A5AD84 File Offset: 0x00A58F84
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListRxDPLCode_A9008
		{
			get
			{
				short num = (short)2041249792;
				short num2 = num;
				num = (short)268611022;
				short num3 = num;
				num = (short)1010478542;
				switch (num3 == num)
				{
				}
				num = (short)1362952193;
				if (num != 0)
				{
				}
				num = (short)1901133824;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008;
			}
		}

		// Token: 0x17005954 RID: 22868
		// (get) Token: 0x0600B258 RID: 45656 RVA: 0x00A5AE34 File Offset: 0x00A59034
		// (set) Token: 0x0600B259 RID: 45657 RVA: 0x00A5AEEC File Offset: 0x00A590EC
		public bool MplCfgMPLListRxDPLCode_A9008_Applicable
		{
			get
			{
				short num = (short)651689984;
				short num2 = num;
				num = (short)135653473;
				short num3 = num;
				num = (short)2104289377;
				switch (num3 == num)
				{
				}
				num = (short)1289748480;
				if (num != 0)
				{
				}
				num = (short)59113473;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.Applicable;
			}
			set
			{
				short num = (short)874315776;
				short num2 = num;
				num = (short)6946817;
				if (num != 0)
				{
				}
				num = (short)1324923081;
				short num3 = num;
				num = (short)739424457;
				switch (num3 == num)
				{
				}
				num = (short)1201733632;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLCode_A9008.Applicable = value;
			}
		}

		// Token: 0x17005955 RID: 22869
		// (get) Token: 0x0600B25A RID: 45658 RVA: 0x00A5AFA4 File Offset: 0x00A591A4
		// (set) Token: 0x0600B25B RID: 45659 RVA: 0x00A5B058 File Offset: 0x00A59258
		public bool MplCfgMPLListRxDPLCode_A9008_Valid
		{
			get
			{
				short num = (short)439484416;
				short num2 = num;
				num = (short)2006454180;
				short num3 = num;
				num = (short)995561380;
				switch (num3 == num)
				{
				}
				num = (short)1489371137;
				if (num != 0)
				{
				}
				num = (short)1336803328;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.Valid;
			}
			set
			{
				short num = (short)361299968;
				short num2 = num;
				num = (short)330145421;
				short num3 = num;
				num = (short)1864277645;
				switch (num3 == num)
				{
				}
				num = (short)13041664;
				if (num != 0)
				{
				}
				num = (short)686292993;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLCode_A9008.Valid = value;
			}
		}

		// Token: 0x17005956 RID: 22870
		// (get) Token: 0x0600B25C RID: 45660 RVA: 0x00A5B10C File Offset: 0x00A5930C
		// (set) Token: 0x0600B25D RID: 45661 RVA: 0x00A5B1C0 File Offset: 0x00A593C0
		public bool MplCfgMPLListRxDPLCode_A9008_Visible
		{
			get
			{
				short num = (short)479068160;
				short num2 = num;
				num = (short)1378831788;
				short num3 = num;
				num = (short)116805036;
				switch (num3 == num)
				{
				}
				num = (short)1301413889;
				if (num != 0)
				{
				}
				num = (short)1640628224;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.Visible;
			}
			set
			{
				short num = (short)1625358336;
				short num2 = num;
				num = (short)722688613;
				short num3 = num;
				num = (short)1167088229;
				switch (num3 == num)
				{
				}
				num = (short)683802624;
				if (num != 0)
				{
				}
				num = (short)1224409089;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLCode_A9008.Visible = value;
			}
		}

		// Token: 0x17005957 RID: 22871
		// (get) Token: 0x0600B25E RID: 45662 RVA: 0x00A5B274 File Offset: 0x00A59474
		// (set) Token: 0x0600B25F RID: 45663 RVA: 0x00A5B328 File Offset: 0x00A59528
		public bool MplCfgMPLListRxDPLCode_A9008_Editable
		{
			get
			{
				short num = (short)1644167168;
				short num2 = num;
				num = (short)1196013650;
				short num3 = num;
				num = (short)1286387794;
				switch (num3 == num)
				{
				}
				num = (short)1198391297;
				if (num != 0)
				{
				}
				num = (short)1300824064;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.Editable;
			}
			set
			{
				short num = (short)1499529216;
				short num2 = num;
				num = (short)2118957972;
				short num3 = num;
				num = (short)423213972;
				switch (num3 == num)
				{
				}
				num = (short)240517121;
				if (num != 0)
				{
				}
				num = (short)1144127488;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLCode_A9008.Editable = value;
			}
		}

		// Token: 0x17005958 RID: 22872
		// (get) Token: 0x0600B260 RID: 45664 RVA: 0x00A5B3E0 File Offset: 0x00A595E0
		internal string MplCfgMPLListRxDPLCode_A9008_UILabel
		{
			get
			{
				short num = (short)1624309760;
				short num2 = num;
				num = (short)611984960;
				short num3 = num;
				num = (short)1781081664;
				switch (num3 == num)
				{
				}
				num = (short)1176240129;
				if (num != 0)
				{
				}
				num = (short)1608581120;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.UIName;
			}
		}

		// Token: 0x17005959 RID: 22873
		// (get) Token: 0x0600B261 RID: 45665 RVA: 0x00A5B494 File Offset: 0x00A59694
		// (set) Token: 0x0600B262 RID: 45666 RVA: 0x00A5B544 File Offset: 0x00A59744
		internal bool MplCfgMPLListRxDPLCode_A9008_HiddenStatic
		{
			get
			{
				short num = (short)1026949120;
				short num2 = num;
				num = (short)742561599;
				short num3 = num;
				num = (short)166041407;
				switch (num3 == num)
				{
				}
				num = (short)1526792192;
				if (num != 0)
				{
				}
				num = (short)1358626817;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.HiddenStatic;
			}
			set
			{
				short num = (short)2130903040;
				short num2 = num;
				num = (short)1194067986;
				short num3 = num;
				num = (short)1423312914;
				switch (num3 == num)
				{
				}
				num = (short)660996097;
				if (num != 0)
				{
				}
				num = (short)743178240;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLCode_A9008.HiddenStatic = value;
			}
		}

		// Token: 0x1700595A RID: 22874
		// (get) Token: 0x0600B263 RID: 45667 RVA: 0x00A5B5FC File Offset: 0x00A597FC
		// (set) Token: 0x0600B264 RID: 45668 RVA: 0x00A5B6B4 File Offset: 0x00A598B4
		internal bool MplCfgMPLListRxDPLCode_A9008_HiddenDynamic
		{
			get
			{
				short num = (short)473694208;
				short num2 = num;
				num = (short)586809345;
				if (num != 0)
				{
				}
				num = (short)2073252151;
				short num3 = num;
				num = (short)1958826295;
				switch (num3 == num)
				{
				}
				num = (short)1885732864;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008.HiddenDynamic;
			}
			set
			{
				short num = (short)552730624;
				short num2 = num;
				num = (short)818891628;
				short num3 = num;
				num = (short)750734188;
				switch (num3 == num)
				{
				}
				num = (short)44892161;
				if (num != 0)
				{
				}
				num = (short)1421672448;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLCode_A9008.HiddenDynamic = value;
			}
		}

		// Token: 0x1700595B RID: 22875
		// (get) Token: 0x0600B265 RID: 45669 RVA: 0x00A5B76C File Offset: 0x00A5996C
		public bool MplCfgMPLListRxDPLCode_A9008_HasDiffs
		{
			get
			{
				short num = (short)597426176;
				short num2 = num;
				num = (short)1079335430;
				short num3 = num;
				num = (short)758929926;
				switch (num3 == num)
				{
				}
				num = (short)147193857;
				if (num != 0)
				{
				}
				num = (short)1480523776;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLCode_A9008._HasDiffs;
			}
		}

		// Token: 0x1700595C RID: 22876
		// (get) Token: 0x0600B266 RID: 45670 RVA: 0x00A5B820 File Offset: 0x00A59A20
		// (set) Token: 0x0600B267 RID: 45671 RVA: 0x00A5B8D4 File Offset: 0x00A59AD4
		public int MplCfgMPLListRxDPLInvert_A9009Value
		{
			get
			{
				short num = (short)733609984;
				short num2 = num;
				num = (short)1413053086;
				short num3 = num;
				num = (short)526285470;
				switch (num3 == num)
				{
				}
				num = (short)2125398017;
				if (num != 0)
				{
				}
				num = (short)122814464;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.Value;
			}
			set
			{
				short num = (short)1306853376;
				short num2 = num;
				num = (short)737546155;
				short num3 = num;
				num = (short)607981483;
				switch (num3 == num)
				{
				}
				num = (short)1275854849;
				if (num != 0)
				{
				}
				num = (short)1433796608;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLInvert_A9009.Value = value;
			}
		}

		// Token: 0x1700595D RID: 22877
		// (get) Token: 0x0600B268 RID: 45672 RVA: 0x00A5B988 File Offset: 0x00A59B88
		// (set) Token: 0x0600B269 RID: 45673 RVA: 0x00A5BA3C File Offset: 0x00A59C3C
		public string MplCfgMPLListRxDPLInvert_A9009_UIValue
		{
			get
			{
				short num = (short)1024065536;
				short num2 = num;
				num = (short)697696857;
				short num3 = num;
				num = (short)1345847897;
				switch (num3 == num)
				{
				}
				num = (short)181141505;
				if (num != 0)
				{
				}
				num = (short)391184384;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.UIValue;
			}
			set
			{
				short num = (short)1289289728;
				short num2 = num;
				num = (short)2075965819;
				short num3 = num;
				num = (short)857913723;
				switch (num3 == num)
				{
				}
				num = (short)1011679233;
				if (num != 0)
				{
				}
				num = (short)1925316608;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLInvert_A9009.UIValue = value;
			}
		}

		// Token: 0x1700595E RID: 22878
		// (get) Token: 0x0600B26A RID: 45674 RVA: 0x00A5BAF0 File Offset: 0x00A59CF0
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListRxDPLInvert_A9009
		{
			get
			{
				short num = (short)517144576;
				short num2 = num;
				num = (short)1061617665;
				if (num != 0)
				{
				}
				num = (short)24767221;
				short num3 = num;
				num = (short)1049553653;
				switch (num3 == num)
				{
				}
				num = (short)91947008;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009;
			}
		}

		// Token: 0x1700595F RID: 22879
		// (get) Token: 0x0600B26B RID: 45675 RVA: 0x00A5BBA4 File Offset: 0x00A59DA4
		// (set) Token: 0x0600B26C RID: 45676 RVA: 0x00A5BC58 File Offset: 0x00A59E58
		public bool MplCfgMPLListRxDPLInvert_A9009_Applicable
		{
			get
			{
				short num = (short)490012672;
				short num2 = num;
				num = (short)761243566;
				short num3 = num;
				num = (short)1806280622;
				switch (num3 == num)
				{
				}
				num = (short)551878656;
				if (num != 0)
				{
				}
				num = (short)483065857;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.Applicable;
			}
			set
			{
				short num = (short)1033109504;
				short num2 = num;
				num = (short)880450793;
				short num3 = num;
				num = (short)1813159145;
				switch (num3 == num)
				{
				}
				num = (short)1062862848;
				if (num != 0)
				{
				}
				num = (short)746061825;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLInvert_A9009.Applicable = value;
			}
		}

		// Token: 0x17005960 RID: 22880
		// (get) Token: 0x0600B26D RID: 45677 RVA: 0x00A5BD0C File Offset: 0x00A59F0C
		// (set) Token: 0x0600B26E RID: 45678 RVA: 0x00A5BDC4 File Offset: 0x00A59FC4
		public bool MplCfgMPLListRxDPLInvert_A9009_Valid
		{
			get
			{
				short num = (short)1796603904;
				short num2 = num;
				num = (short)1196231828;
				short num3 = num;
				num = (short)1839598740;
				switch (num3 == num)
				{
				}
				num = (short)576716801;
				if (num != 0)
				{
				}
				num = (short)2059075584;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.Valid;
			}
			set
			{
				short num = (short)1243086848;
				short num2 = num;
				num = (short)1021161909;
				short num3 = num;
				num = (short)326742453;
				switch (num3 == num)
				{
				}
				num = (short)809107456;
				if (num != 0)
				{
				}
				num = (short)2017263617;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLInvert_A9009.Valid = value;
			}
		}

		// Token: 0x17005961 RID: 22881
		// (get) Token: 0x0600B26F RID: 45679 RVA: 0x00A5BE78 File Offset: 0x00A5A078
		// (set) Token: 0x0600B270 RID: 45680 RVA: 0x00A5BF2C File Offset: 0x00A5A12C
		public bool MplCfgMPLListRxDPLInvert_A9009_Visible
		{
			get
			{
				short num = (short)449642496;
				short num2 = num;
				num = (short)156137354;
				short num3 = num;
				num = (short)258570122;
				switch (num3 == num)
				{
				}
				num = (short)229703680;
				if (num != 0)
				{
				}
				num = (short)378732545;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.Visible;
			}
			set
			{
				short num = (short)1542782976;
				short num2 = num;
				num = (short)1024713038;
				short num3 = num;
				num = (short)2011160910;
				switch (num3 == num)
				{
				}
				num = (short)116719617;
				if (num != 0)
				{
				}
				num = (short)360841216;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLInvert_A9009.Visible = value;
			}
		}

		// Token: 0x17005962 RID: 22882
		// (get) Token: 0x0600B271 RID: 45681 RVA: 0x00A5BFE0 File Offset: 0x00A5A1E0
		// (set) Token: 0x0600B272 RID: 45682 RVA: 0x00A5C094 File Offset: 0x00A5A294
		public bool MplCfgMPLListRxDPLInvert_A9009_Editable
		{
			get
			{
				short num = (short)1554251776;
				short num2 = num;
				num = (short)1938752479;
				short num3 = num;
				num = (short)823460831;
				switch (num3 == num)
				{
				}
				num = (short)1461452801;
				if (num != 0)
				{
				}
				num = (short)1941241856;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.Editable;
			}
			set
			{
				short num = (short)276496384;
				short num2 = num;
				num = (short)800802021;
				short num3 = num;
				num = (short)789398757;
				switch (num3 == num)
				{
				}
				num = (short)909901825;
				if (num != 0)
				{
				}
				num = (short)467861504;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLInvert_A9009.Editable = value;
			}
		}

		// Token: 0x17005963 RID: 22883
		// (get) Token: 0x0600B273 RID: 45683 RVA: 0x00A5C14C File Offset: 0x00A5A34C
		internal string MplCfgMPLListRxDPLInvert_A9009_UILabel
		{
			get
			{
				short num = (short)975896576;
				short num2 = num;
				num = (short)2029460166;
				short num3 = num;
				num = (short)1786649286;
				switch (num3 == num)
				{
				}
				num = (short)2012217345;
				if (num != 0)
				{
				}
				num = (short)244252672;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.UIName;
			}
		}

		// Token: 0x17005964 RID: 22884
		// (get) Token: 0x0600B274 RID: 45684 RVA: 0x00A5C200 File Offset: 0x00A5A400
		// (set) Token: 0x0600B275 RID: 45685 RVA: 0x00A5C2B4 File Offset: 0x00A5A4B4
		internal bool MplCfgMPLListRxDPLInvert_A9009_HiddenStatic
		{
			get
			{
				short num = (short)1940062208;
				short num2 = num;
				num = (short)1702451427;
				short num3 = num;
				num = (short)94787811;
				switch (num3 == num)
				{
				}
				num = (short)1771896833;
				if (num != 0)
				{
				}
				num = (short)294060032;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.HiddenStatic;
			}
			set
			{
				short num = (short)1586561024;
				short num2 = num;
				num = (short)524091393;
				if (num != 0)
				{
				}
				num = (short)1931831436;
				short num3 = num;
				num = (short)1595107468;
				switch (num3 == num)
				{
				}
				num = (short)1558118400;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLInvert_A9009.HiddenStatic = value;
			}
		}

		// Token: 0x17005965 RID: 22885
		// (get) Token: 0x0600B276 RID: 45686 RVA: 0x00A5C36C File Offset: 0x00A5A56C
		// (set) Token: 0x0600B277 RID: 45687 RVA: 0x00A5C420 File Offset: 0x00A5A620
		internal bool MplCfgMPLListRxDPLInvert_A9009_HiddenDynamic
		{
			get
			{
				short num = (short)979566592;
				short num2 = num;
				num = (short)322511097;
				short num3 = num;
				num = (short)1577197817;
				switch (num3 == num)
				{
				}
				num = (short)1361051648;
				if (num != 0)
				{
				}
				num = (short)875233281;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009.HiddenDynamic;
			}
			set
			{
				short num = (short)641466368;
				short num2 = num;
				num = (short)2033413875;
				short num3 = num;
				num = (short)324103923;
				switch (num3 == num)
				{
				}
				num = (short)1829109761;
				if (num != 0)
				{
				}
				num = (short)191430656;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxDPLInvert_A9009.HiddenDynamic = value;
			}
		}

		// Token: 0x17005966 RID: 22886
		// (get) Token: 0x0600B278 RID: 45688 RVA: 0x00A5C4D4 File Offset: 0x00A5A6D4
		public bool MplCfgMPLListRxDPLInvert_A9009_HasDiffs
		{
			get
			{
				short num = (short)384892928;
				short num2 = num;
				num = (short)124438966;
				short num3 = num;
				num = (short)1191365046;
				switch (num3 == num)
				{
				}
				num = (short)573308928;
				if (num != 0)
				{
				}
				num = (short)40763393;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxDPLInvert_A9009._HasDiffs;
			}
		}

		// Token: 0x17005967 RID: 22887
		// (get) Token: 0x0600B279 RID: 45689 RVA: 0x00A5C588 File Offset: 0x00A5A788
		// (set) Token: 0x0600B27A RID: 45690 RVA: 0x00A5C63C File Offset: 0x00A5A83C
		public int MplCfgMPLListRxPLCode_A9026Value
		{
			get
			{
				short num = (short)1438384128;
				short num2 = num;
				num = (short)1993886456;
				short num3 = num;
				num = (short)679168760;
				switch (num3 == num)
				{
				}
				num = (short)1059979265;
				if (num != 0)
				{
				}
				num = (short)1269563392;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.Value;
			}
			set
			{
				short num = (short)582483968;
				short num2 = num;
				num = (short)522552828;
				short num3 = num;
				num = (short)1479443964;
				switch (num3 == num)
				{
				}
				num = (short)1730674688;
				if (num != 0)
				{
				}
				num = (short)832962561;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLCode_A9026.Value = value;
			}
		}

		// Token: 0x17005968 RID: 22888
		// (get) Token: 0x0600B27B RID: 45691 RVA: 0x00A5C6F0 File Offset: 0x00A5A8F0
		// (set) Token: 0x0600B27C RID: 45692 RVA: 0x00A5C7A4 File Offset: 0x00A5A9A4
		public string MplCfgMPLListRxPLCode_A9026_UIValue
		{
			get
			{
				short num = (short)842399744;
				short num2 = num;
				num = (short)1212213196;
				short num3 = num;
				num = (short)1978197964;
				switch (num3 == num)
				{
				}
				num = (short)2040201216;
				if (num != 0)
				{
				}
				num = (short)1601634305;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.UIValue;
			}
			set
			{
				short num = (short)58523648;
				short num2 = num;
				num = (short)567962143;
				short num3 = num;
				num = (short)1933994527;
				switch (num3 == num)
				{
				}
				num = (short)1199243265;
				if (num != 0)
				{
				}
				num = (short)1523056640;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLCode_A9026.UIValue = value;
			}
		}

		// Token: 0x17005969 RID: 22889
		// (get) Token: 0x0600B27D RID: 45693 RVA: 0x00A5C858 File Offset: 0x00A5AA58
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListRxPLCode_A9026
		{
			get
			{
				short num = (short)1351352320;
				short num2 = num;
				num = (short)1803309650;
				short num3 = num;
				num = (short)430068306;
				switch (num3 == num)
				{
				}
				num = (short)1254293505;
				if (num != 0)
				{
				}
				num = (short)1177550848;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026;
			}
		}

		// Token: 0x1700596A RID: 22890
		// (get) Token: 0x0600B27E RID: 45694 RVA: 0x00A5C90C File Offset: 0x00A5AB0C
		// (set) Token: 0x0600B27F RID: 45695 RVA: 0x00A5C9C4 File Offset: 0x00A5ABC4
		public bool MplCfgMPLListRxPLCode_A9026_Applicable
		{
			get
			{
				short num = (short)1158545408;
				short num2 = num;
				num = (short)1842678609;
				short num3 = num;
				num = (short)132975441;
				switch (num3 == num)
				{
				}
				num = (short)578813953;
				if (num != 0)
				{
				}
				num = (short)930742272;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.Applicable;
			}
			set
			{
				short num = (short)1534132224;
				short num2 = num;
				num = (short)1466001123;
				short num3 = num;
				num = (short)1746233059;
				switch (num3 == num)
				{
				}
				num = (short)318963713;
				if (num != 0)
				{
				}
				num = (short)1637416960;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLCode_A9026.Applicable = value;
			}
		}

		// Token: 0x1700596B RID: 22891
		// (get) Token: 0x0600B280 RID: 45696 RVA: 0x00A5CA78 File Offset: 0x00A5AC78
		// (set) Token: 0x0600B281 RID: 45697 RVA: 0x00A5CB30 File Offset: 0x00A5AD30
		public bool MplCfgMPLListRxPLCode_A9026_Valid
		{
			get
			{
				short num = (short)1581187072;
				short num2 = num;
				num = (short)104267777;
				if (num != 0)
				{
				}
				num = (short)687262666;
				short num3 = num;
				num = (short)620481482;
				switch (num3 == num)
				{
				}
				num = (short)1818558464;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.Valid;
			}
			set
			{
				short num = (short)1489567744;
				short num2 = num;
				num = (short)1245605364;
				short num3 = num;
				num = (short)965832180;
				switch (num3 == num)
				{
				}
				num = (short)884015104;
				if (num != 0)
				{
				}
				num = (short)1452343297;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLCode_A9026.Valid = value;
			}
		}

		// Token: 0x1700596C RID: 22892
		// (get) Token: 0x0600B282 RID: 45698 RVA: 0x00A5CBE8 File Offset: 0x00A5ADE8
		// (set) Token: 0x0600B283 RID: 45699 RVA: 0x00A5CC9C File Offset: 0x00A5AE9C
		public bool MplCfgMPLListRxPLCode_A9026_Visible
		{
			get
			{
				short num = (short)737345536;
				short num2 = num;
				num = (short)1930110672;
				short num3 = num;
				num = (short)1632118480;
				switch (num3 == num)
				{
				}
				num = (short)926679040;
				if (num != 0)
				{
				}
				num = (short)2113601537;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.Visible;
			}
			set
			{
				short num = (short)1466761216;
				short num2 = num;
				num = (short)2000589877;
				short num3 = num;
				num = (short)1640862773;
				switch (num3 == num)
				{
				}
				num = (short)1505689600;
				if (num != 0)
				{
				}
				num = (short)1370161153;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLCode_A9026.Visible = value;
			}
		}

		// Token: 0x1700596D RID: 22893
		// (get) Token: 0x0600B284 RID: 45700 RVA: 0x00A5CD54 File Offset: 0x00A5AF54
		// (set) Token: 0x0600B285 RID: 45701 RVA: 0x00A5CE08 File Offset: 0x00A5B008
		public bool MplCfgMPLListRxPLCode_A9026_Editable
		{
			get
			{
				short num = (short)1643249664;
				short num2 = num;
				num = (short)1827721949;
				short num3 = num;
				num = (short)2042155741;
				switch (num3 == num)
				{
				}
				num = (short)1169424384;
				if (num != 0)
				{
				}
				num = (short)940507137;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.Editable;
			}
			set
			{
				short num = (short)417202176;
				short num2 = num;
				num = (short)601560608;
				short num3 = num;
				num = (short)13506080;
				switch (num3 == num)
				{
				}
				num = (short)1217200129;
				if (num != 0)
				{
				}
				num = (short)142606336;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLCode_A9026.Editable = value;
			}
		}

		// Token: 0x1700596E RID: 22894
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x00A5CEC0 File Offset: 0x00A5B0C0
		internal string MplCfgMPLListRxPLCode_A9026_UILabel
		{
			get
			{
				short num = (short)407502848;
				short num2 = num;
				num = (short)2064646145;
				if (num != 0)
				{
				}
				num = (short)895941082;
				short num3 = num;
				num = (short)256702938;
				switch (num3 == num)
				{
				}
				num = (short)344064000;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.UIName;
			}
		}

		// Token: 0x1700596F RID: 22895
		// (get) Token: 0x0600B287 RID: 45703 RVA: 0x00A5CF78 File Offset: 0x00A5B178
		// (set) Token: 0x0600B288 RID: 45704 RVA: 0x00A5D02C File Offset: 0x00A5B22C
		internal bool MplCfgMPLListRxPLCode_A9026_HiddenStatic
		{
			get
			{
				short num = (short)755630080;
				short num2 = num;
				num = (short)2105344001;
				if (num != 0)
				{
				}
				num = (short)1658441556;
				short num3 = num;
				num = (short)22794068;
				switch (num3 == num)
				{
				}
				num = (short)1405550592;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.HiddenStatic;
			}
			set
			{
				short num = (short)1751908352;
				short num2 = num;
				num = (short)793017534;
				short num3 = num;
				num = (short)1398963390;
				switch (num3 == num)
				{
				}
				num = (short)1594556416;
				if (num != 0)
				{
				}
				num = (short)964820993;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLCode_A9026.HiddenStatic = value;
			}
		}

		// Token: 0x17005970 RID: 22896
		// (get) Token: 0x0600B289 RID: 45705 RVA: 0x00A5D0E0 File Offset: 0x00A5B2E0
		// (set) Token: 0x0600B28A RID: 45706 RVA: 0x00A5D194 File Offset: 0x00A5B394
		internal bool MplCfgMPLListRxPLCode_A9026_HiddenDynamic
		{
			get
			{
				short num = (short)63504384;
				short num2 = num;
				num = (short)108266030;
				short num3 = num;
				num = (short)1385497134;
				switch (num3 == num)
				{
				}
				num = (short)1747910656;
				if (num != 0)
				{
				}
				num = (short)1246101505;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026.HiddenDynamic;
			}
			set
			{
				short num = (short)2036334592;
				short num2 = num;
				num = (short)258282686;
				short num3 = num;
				num = (short)743183550;
				switch (num3 == num)
				{
				}
				num = (short)1024524289;
				if (num != 0)
				{
				}
				num = (short)206110720;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLCode_A9026.HiddenDynamic = value;
			}
		}

		// Token: 0x17005971 RID: 22897
		// (get) Token: 0x0600B28B RID: 45707 RVA: 0x00A5D24C File Offset: 0x00A5B44C
		public bool MplCfgMPLListRxPLCode_A9026_HasDiffs
		{
			get
			{
				short num = (short)1876951040;
				short num2 = num;
				num = (short)1080144777;
				short num3 = num;
				num = (short)1326953353;
				switch (num3 == num)
				{
				}
				num = (short)414777345;
				if (num != 0)
				{
				}
				num = (short)1782448128;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLCode_A9026._HasDiffs;
			}
		}

		// Token: 0x17005972 RID: 22898
		// (get) Token: 0x0600B28C RID: 45708 RVA: 0x00A5D300 File Offset: 0x00A5B500
		// (set) Token: 0x0600B28D RID: 45709 RVA: 0x00A5D3B0 File Offset: 0x00A5B5B0
		public int MplCfgMPLListRxPLFreq_A9027Value
		{
			get
			{
				short num = (short)1421672448;
				short num2 = num;
				num = (short)386475702;
				short num3 = num;
				num = (short)644490934;
				switch (num3 == num)
				{
				}
				num = (short)1018298368;
				if (num != 0)
				{
				}
				num = (short)334233601;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.Value;
			}
			set
			{
				short num = (short)561119232;
				short num2 = num;
				num = (short)1775828993;
				if (num != 0)
				{
				}
				num = (short)797098311;
				short num3 = num;
				num = (short)522043719;
				switch (num3 == num)
				{
				}
				num = (short)876544000;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLFreq_A9027.Value = value;
			}
		}

		// Token: 0x17005973 RID: 22899
		// (get) Token: 0x0600B28E RID: 45710 RVA: 0x00A5D464 File Offset: 0x00A5B664
		// (set) Token: 0x0600B28F RID: 45711 RVA: 0x00A5D51C File Offset: 0x00A5B71C
		public string MplCfgMPLListRxPLFreq_A9027_UIValue
		{
			get
			{
				short num = (short)2071396352;
				short num2 = num;
				num = (short)719982820;
				short num3 = num;
				num = (short)539627748;
				switch (num3 == num)
				{
				}
				num = (short)1177878528;
				if (num != 0)
				{
				}
				num = (short)529530881;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.UIValue;
			}
			set
			{
				short num = (short)1562116096;
				short num2 = num;
				num = (short)559537100;
				short num3 = num;
				num = (short)1241111500;
				switch (num3 == num)
				{
				}
				num = (short)773455873;
				if (num != 0)
				{
				}
				num = (short)951320576;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLFreq_A9027.UIValue = value;
			}
		}

		// Token: 0x17005974 RID: 22900
		// (get) Token: 0x0600B290 RID: 45712 RVA: 0x00A5D5D4 File Offset: 0x00A5B7D4
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListRxPLFreq_A9027
		{
			get
			{
				short num = (short)1297483540;
				short num2 = num;
				num = (short)933889812;
				switch (num2 == num)
				{
				}
				num = (short)322240512;
				short num3 = num;
				num = (short)1301217281;
				if (num != 0)
				{
				}
				num = (short)659161088;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027;
			}
		}

		// Token: 0x17005975 RID: 22901
		// (get) Token: 0x0600B291 RID: 45713 RVA: 0x00A5D680 File Offset: 0x00A5B880
		// (set) Token: 0x0600B292 RID: 45714 RVA: 0x00A5D734 File Offset: 0x00A5B934
		public bool MplCfgMPLListRxPLFreq_A9027_Applicable
		{
			get
			{
				short num = (short)193566746;
				short num2 = num;
				num = (short)1808177178;
				switch (num2 == num)
				{
				}
				num = (short)1005387776;
				short num3 = num;
				num = (short)572194817;
				if (num != 0)
				{
				}
				num = (short)329383936;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.Applicable;
			}
			set
			{
				short num = (short)677428542;
				short num2 = num;
				num = (short)2033827134;
				switch (num2 == num)
				{
				}
				num = (short)667025408;
				short num3 = num;
				num = (short)1300824065;
				if (num != 0)
				{
				}
				num = (short)284491776;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLFreq_A9027.Applicable = value;
			}
		}

		// Token: 0x17005976 RID: 22902
		// (get) Token: 0x0600B293 RID: 45715 RVA: 0x00A5D7E8 File Offset: 0x00A5B9E8
		// (set) Token: 0x0600B294 RID: 45716 RVA: 0x00A5D89C File Offset: 0x00A5BA9C
		public bool MplCfgMPLListRxPLFreq_A9027_Valid
		{
			get
			{
				short num = (short)902646221;
				short num2 = num;
				num = (short)1118390733;
				switch (num2 == num)
				{
				}
				num = (short)17039360;
				short num3 = num;
				num = (short)518520832;
				if (num != 0)
				{
				}
				num = (short)918487041;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.Valid;
			}
			set
			{
				short num = (short)1994921344;
				short num2 = num;
				num = (short)1370756480;
				switch (num2 == num)
				{
				}
				num = (short)1052770304;
				short num3 = num;
				num = (short)613548033;
				if (num != 0)
				{
				}
				num = (short)901709824;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLFreq_A9027.Valid = value;
			}
		}

		// Token: 0x17005977 RID: 22903
		// (get) Token: 0x0600B295 RID: 45717 RVA: 0x00A5D954 File Offset: 0x00A5BB54
		// (set) Token: 0x0600B296 RID: 45718 RVA: 0x00A5DA08 File Offset: 0x00A5BC08
		public bool MplCfgMPLListRxPLFreq_A9027_Visible
		{
			get
			{
				short num = (short)1898421643;
				short num2 = num;
				num = (short)1784323467;
				switch (num2 == num)
				{
				}
				num = (short)2018115584;
				short num3 = num;
				num = (short)526581761;
				if (num != 0)
				{
				}
				num = (short)220397568;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.Visible;
			}
			set
			{
				short num = (short)190800560;
				short num2 = num;
				num = (short)1077109424;
				switch (num2 == num)
				{
				}
				num = (short)467075072;
				short num3 = num;
				num = (short)713752577;
				if (num != 0)
				{
				}
				num = (short)1348272128;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLFreq_A9027.Visible = value;
			}
		}

		// Token: 0x17005978 RID: 22904
		// (get) Token: 0x0600B297 RID: 45719 RVA: 0x00A5DABC File Offset: 0x00A5BCBC
		// (set) Token: 0x0600B298 RID: 45720 RVA: 0x00A5DB74 File Offset: 0x00A5BD74
		public bool MplCfgMPLListRxPLFreq_A9027_Editable
		{
			get
			{
				short num = (short)905231795;
				short num2 = num;
				num = (short)10468787;
				switch (num2 == num)
				{
				}
				num = (short)818282496;
				short num3 = num;
				num = (short)1451032577;
				if (num != 0)
				{
				}
				num = (short)2032467968;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.Editable;
			}
			set
			{
				short num = (short)1849325125;
				short num2 = num;
				num = (short)379549253;
				switch (num2 == num)
				{
				}
				num = (short)1915027456;
				short num3 = num;
				num = (short)2092826624;
				if (num != 0)
				{
				}
				num = (short)260636673;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLFreq_A9027.Editable = value;
			}
		}

		// Token: 0x17005979 RID: 22905
		// (get) Token: 0x0600B299 RID: 45721 RVA: 0x00A5DC28 File Offset: 0x00A5BE28
		internal string MplCfgMPLListRxPLFreq_A9027_UILabel
		{
			get
			{
				short num = (short)356751646;
				short num2 = num;
				num = (short)920819998;
				switch (num2 == num)
				{
				}
				num = (short)1868431360;
				short num3 = num;
				num = (short)1851981824;
				if (num != 0)
				{
				}
				num = (short)782368769;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.UIName;
			}
		}

		// Token: 0x1700597A RID: 22906
		// (get) Token: 0x0600B29A RID: 45722 RVA: 0x00A5DCDC File Offset: 0x00A5BEDC
		// (set) Token: 0x0600B29B RID: 45723 RVA: 0x00A5DD90 File Offset: 0x00A5BF90
		internal bool MplCfgMPLListRxPLFreq_A9027_HiddenStatic
		{
			get
			{
				short num = (short)494045056;
				short num2 = num;
				num = (short)1707575168;
				switch (num2 == num)
				{
				}
				num = (short)2123956224;
				short num3 = num;
				num = (short)1524170753;
				if (num != 0)
				{
				}
				num = (short)1715535872;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.HiddenStatic;
			}
			set
			{
				short num = (short)2057109620;
				short num2 = num;
				num = (short)2006188148;
				switch (num2 == num)
				{
				}
				num = (short)887947264;
				short num3 = num;
				num = (short)1873608704;
				if (num != 0)
				{
				}
				num = (short)995622913;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLFreq_A9027.HiddenStatic = value;
			}
		}

		// Token: 0x1700597B RID: 22907
		// (get) Token: 0x0600B29C RID: 45724 RVA: 0x00A5DE44 File Offset: 0x00A5C044
		// (set) Token: 0x0600B29D RID: 45725 RVA: 0x00A5DF00 File Offset: 0x00A5C100
		internal bool MplCfgMPLListRxPLFreq_A9027_HiddenDynamic
		{
			get
			{
				short num = (short)408802313;
				short num2 = num;
				num = (short)1879299081;
				switch (num2 == num)
				{
				}
				num = (short)1801846784;
				short num3 = num;
				num = (short)709885952;
				if (num != 0)
				{
				}
				num = (short)1005977601;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027.HiddenDynamic;
			}
			set
			{
				short num = (short)492016337;
				short num2 = num;
				num = (short)1212912337;
				switch (num2 == num)
				{
				}
				num = (short)1068826624;
				short num3 = num;
				num = (short)565772289;
				if (num != 0)
				{
				}
				num = (short)848297984;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxPLFreq_A9027.HiddenDynamic = value;
			}
		}

		// Token: 0x1700597C RID: 22908
		// (get) Token: 0x0600B29E RID: 45726 RVA: 0x00A5DFB8 File Offset: 0x00A5C1B8
		public bool MplCfgMPLListRxPLFreq_A9027_HasDiffs
		{
			get
			{
				short num = (short)1326032267;
				short num2 = num;
				num = (short)331326859;
				switch (num2 == num)
				{
				}
				num = (short)2045575168;
				short num3 = num;
				num = (short)171114496;
				if (num != 0)
				{
				}
				num = (short)460849153;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxPLFreq_A9027._HasDiffs;
			}
		}

		// Token: 0x1700597D RID: 22909
		// (get) Token: 0x0600B29F RID: 45727 RVA: 0x00A5E06C File Offset: 0x00A5C26C
		// (set) Token: 0x0600B2A0 RID: 45728 RVA: 0x00A5E120 File Offset: 0x00A5C320
		public int MplCfgMPLListRxSquelchType_A9028Value
		{
			get
			{
				short num = (short)1611726849;
				if (num != 0)
				{
				}
				num = (short)341487623;
				short num2 = num;
				num = (short)732672007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432420352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)994836480;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.Value;
			}
			set
			{
				short num = (short)362065450;
				short num2 = num;
				num = (short)138587690;
				switch (num2 == num)
				{
				}
				num = (short)639827968;
				short num3 = num;
				num = (short)1967325184;
				if (num != 0)
				{
				}
				num = (short)81526785;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxSquelchType_A9028.Value = value;
			}
		}

		// Token: 0x1700597E RID: 22910
		// (get) Token: 0x0600B2A1 RID: 45729 RVA: 0x00A5E1D4 File Offset: 0x00A5C3D4
		// (set) Token: 0x0600B2A2 RID: 45730 RVA: 0x00A5E288 File Offset: 0x00A5C488
		public string MplCfgMPLListRxSquelchType_A9028_UIValue
		{
			get
			{
				short num = (short)1736999954;
				short num2 = num;
				num = (short)170558482;
				switch (num2 == num)
				{
				}
				num = (short)588644352;
				short num3 = num;
				num = (short)645136384;
				if (num != 0)
				{
				}
				num = (short)1061683201;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.UIValue;
			}
			set
			{
				short num = (short)1879497700;
				short num2 = num;
				num = (short)976018404;
				switch (num2 == num)
				{
				}
				num = (short)1777270784;
				short num3 = num;
				num = (short)1118830592;
				if (num != 0)
				{
				}
				num = (short)784859137;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxSquelchType_A9028.UIValue = value;
			}
		}

		// Token: 0x1700597F RID: 22911
		// (get) Token: 0x0600B2A3 RID: 45731 RVA: 0x00A5E33C File Offset: 0x00A5C53C
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListRxSquelchType_A9028
		{
			get
			{
				short num = (short)859766785;
				if (num != 0)
				{
				}
				num = (short)686305013;
				short num2 = num;
				num = (short)322907893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)863043584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)489095168;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028;
			}
		}

		// Token: 0x17005980 RID: 22912
		// (get) Token: 0x0600B2A4 RID: 45732 RVA: 0x00A5E3E8 File Offset: 0x00A5C5E8
		// (set) Token: 0x0600B2A5 RID: 45733 RVA: 0x00A5E49C File Offset: 0x00A5C69C
		public bool MplCfgMPLListRxSquelchType_A9028_Applicable
		{
			get
			{
				short num = (short)675210692;
				short num2 = num;
				num = (short)917366212;
				switch (num2 == num)
				{
				}
				num = (short)1840316416;
				short num3 = num;
				num = (short)1313406977;
				if (num != 0)
				{
				}
				num = (short)1935540224;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.Applicable;
			}
			set
			{
				short num = (short)149691776;
				short num2 = num;
				num = (short)1979653504;
				switch (num2 == num)
				{
				}
				num = (short)2048786432;
				short num3 = num;
				num = (short)1336672256;
				if (num != 0)
				{
				}
				num = (short)323158017;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxSquelchType_A9028.Applicable = value;
			}
		}

		// Token: 0x17005981 RID: 22913
		// (get) Token: 0x0600B2A6 RID: 45734 RVA: 0x00A5E550 File Offset: 0x00A5C750
		// (set) Token: 0x0600B2A7 RID: 45735 RVA: 0x00A5E604 File Offset: 0x00A5C804
		public bool MplCfgMPLListRxSquelchType_A9028_Valid
		{
			get
			{
				short num = (short)489923756;
				short num2 = num;
				num = (short)64791724;
				switch (num2 == num)
				{
				}
				num = (short)246677504;
				short num3 = num;
				num = (short)442826752;
				if (num != 0)
				{
				}
				num = (short)1259143169;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.Valid;
			}
			set
			{
				short num = (short)1611647789;
				short num2 = num;
				num = (short)1855900461;
				switch (num2 == num)
				{
				}
				num = (short)1964769280;
				short num3 = num;
				num = (short)603258880;
				if (num != 0)
				{
				}
				num = (short)938672129;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxSquelchType_A9028.Valid = value;
			}
		}

		// Token: 0x17005982 RID: 22914
		// (get) Token: 0x0600B2A8 RID: 45736 RVA: 0x00A5E6B8 File Offset: 0x00A5C8B8
		// (set) Token: 0x0600B2A9 RID: 45737 RVA: 0x00A5E76C File Offset: 0x00A5C96C
		public bool MplCfgMPLListRxSquelchType_A9028_Visible
		{
			get
			{
				short num = (short)1863846405;
				short num2 = num;
				num = (short)1284377093;
				switch (num2 == num)
				{
				}
				num = (short)1490288640;
				short num3 = num;
				num = (short)1369899009;
				if (num != 0)
				{
				}
				num = (short)2027683840;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.Visible;
			}
			set
			{
				short num = (short)1956672913;
				short num2 = num;
				num = (short)1589212561;
				switch (num2 == num)
				{
				}
				num = (short)1790246912;
				short num3 = num;
				num = (short)452919297;
				if (num != 0)
				{
				}
				num = (short)866844672;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxSquelchType_A9028.Visible = value;
			}
		}

		// Token: 0x17005983 RID: 22915
		// (get) Token: 0x0600B2AA RID: 45738 RVA: 0x00A5E824 File Offset: 0x00A5CA24
		// (set) Token: 0x0600B2AB RID: 45739 RVA: 0x00A5E8D8 File Offset: 0x00A5CAD8
		public bool MplCfgMPLListRxSquelchType_A9028_Editable
		{
			get
			{
				short num = (short)1541840391;
				short num2 = num;
				num = (short)1798348295;
				switch (num2 == num)
				{
				}
				num = (short)2128019456;
				short num3 = num;
				num = (short)1573453825;
				if (num != 0)
				{
				}
				num = (short)767295488;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.Editable;
			}
			set
			{
				short num = (short)1207916212;
				short num2 = num;
				num = (short)740775604;
				switch (num2 == num)
				{
				}
				num = (short)1692532736;
				short num3 = num;
				num = (short)1582170113;
				if (num != 0)
				{
				}
				num = (short)174456832;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxSquelchType_A9028.Editable = value;
			}
		}

		// Token: 0x17005984 RID: 22916
		// (get) Token: 0x0600B2AC RID: 45740 RVA: 0x00A5E990 File Offset: 0x00A5CB90
		internal string MplCfgMPLListRxSquelchType_A9028_UILabel
		{
			get
			{
				short num = (short)945771470;
				short num2 = num;
				num = (short)1578390478;
				switch (num2 == num)
				{
				}
				num = (short)497418240;
				short num3 = num;
				num = (short)2116812801;
				if (num != 0)
				{
				}
				num = (short)826277888;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.UIName;
			}
		}

		// Token: 0x17005985 RID: 22917
		// (get) Token: 0x0600B2AD RID: 45741 RVA: 0x00A5EA44 File Offset: 0x00A5CC44
		// (set) Token: 0x0600B2AE RID: 45742 RVA: 0x00A5EAF8 File Offset: 0x00A5CCF8
		internal bool MplCfgMPLListRxSquelchType_A9028_HiddenStatic
		{
			get
			{
				short num = (short)1678798192;
				short num2 = num;
				num = (short)1445621104;
				switch (num2 == num)
				{
				}
				num = (short)683802624;
				short num3 = num;
				num = (short)1827012609;
				if (num != 0)
				{
				}
				num = (short)219086848;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.HiddenStatic;
			}
			set
			{
				short num = (short)1441286205;
				short num2 = num;
				num = (short)1890207805;
				switch (num2 == num)
				{
				}
				num = (short)1654784000;
				short num3 = num;
				num = (short)2129461248;
				if (num != 0)
				{
				}
				num = (short)66322433;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxSquelchType_A9028.HiddenStatic = value;
			}
		}

		// Token: 0x17005986 RID: 22918
		// (get) Token: 0x0600B2AF RID: 45743 RVA: 0x00A5EBAC File Offset: 0x00A5CDAC
		// (set) Token: 0x0600B2B0 RID: 45744 RVA: 0x00A5EC5C File Offset: 0x00A5CE5C
		internal bool MplCfgMPLListRxSquelchType_A9028_HiddenDynamic
		{
			get
			{
				short num = (short)1611008111;
				short num2 = num;
				num = (short)1957038191;
				switch (num2 == num)
				{
				}
				num = (short)157679616;
				short num3 = num;
				num = (short)1755971584;
				if (num != 0)
				{
				}
				num = (short)820248577;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028.HiddenDynamic;
			}
			set
			{
				short num = (short)1111439891;
				short num2 = num;
				num = (short)909589011;
				switch (num2 == num)
				{
				}
				num = (short)188350464;
				short num3 = num;
				num = (short)1219887105;
				if (num != 0)
				{
				}
				num = (short)339804160;
				if (num != 0)
				{
				}
				this.mplCfgMPLListRxSquelchType_A9028.HiddenDynamic = value;
			}
		}

		// Token: 0x17005987 RID: 22919
		// (get) Token: 0x0600B2B1 RID: 45745 RVA: 0x00A5ED14 File Offset: 0x00A5CF14
		public bool MplCfgMPLListRxSquelchType_A9028_HasDiffs
		{
			get
			{
				short num = (short)1260628528;
				short num2 = num;
				num = (short)22915632;
				switch (num2 == num)
				{
				}
				num = (short)2105540608;
				short num3 = num;
				num = (short)1290010625;
				if (num != 0)
				{
				}
				num = (short)1774321664;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListRxSquelchType_A9028._HasDiffs;
			}
		}

		// Token: 0x17005988 RID: 22920
		// (get) Token: 0x0600B2B2 RID: 45746 RVA: 0x00A5EDC8 File Offset: 0x00A5CFC8
		// (set) Token: 0x0600B2B3 RID: 45747 RVA: 0x00A5EE80 File Offset: 0x00A5D080
		public int MplCfgMPLListTADPLCode_A9257Value
		{
			get
			{
				short num = (short)1759699128;
				short num2 = num;
				num = (short)1960304824;
				switch (num2 == num)
				{
				}
				num = (short)872480768;
				short num3 = num;
				num = (short)153944065;
				if (num != 0)
				{
				}
				num = (short)721616896;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.Value;
			}
			set
			{
				short num = (short)898957313;
				if (num != 0)
				{
				}
				num = (short)711053829;
				short num2 = num;
				num = (short)1191825925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825950208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)773849088;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLCode_A9257.Value = value;
			}
		}

		// Token: 0x17005989 RID: 22921
		// (get) Token: 0x0600B2B4 RID: 45748 RVA: 0x00A5EF34 File Offset: 0x00A5D134
		// (set) Token: 0x0600B2B5 RID: 45749 RVA: 0x00A5EFE8 File Offset: 0x00A5D1E8
		public string MplCfgMPLListTADPLCode_A9257_UIValue
		{
			get
			{
				short num = (short)1626510611;
				short num2 = num;
				num = (short)1735890195;
				switch (num2 == num)
				{
				}
				num = (short)1799946240;
				short num3 = num;
				num = (short)228196353;
				if (num != 0)
				{
				}
				num = (short)1974337536;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.UIValue;
			}
			set
			{
				short num = (short)1073594756;
				short num2 = num;
				num = (short)2014101892;
				switch (num2 == num)
				{
				}
				num = (short)1334116352;
				short num3 = num;
				num = (short)157548545;
				if (num != 0)
				{
				}
				num = (short)861208576;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLCode_A9257.UIValue = value;
			}
		}

		// Token: 0x1700598A RID: 22922
		// (get) Token: 0x0600B2B6 RID: 45750 RVA: 0x00A5F09C File Offset: 0x00A5D29C
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTADPLCode_A9257
		{
			get
			{
				short num = (short)607867235;
				short num2 = num;
				num = (short)468406627;
				switch (num2 == num)
				{
				}
				num = (short)1414725632;
				short num3 = num;
				num = (short)336461824;
				if (num != 0)
				{
				}
				num = (short)1222115329;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257;
			}
		}

		// Token: 0x1700598B RID: 22923
		// (get) Token: 0x0600B2B7 RID: 45751 RVA: 0x00A5F14C File Offset: 0x00A5D34C
		// (set) Token: 0x0600B2B8 RID: 45752 RVA: 0x00A5F200 File Offset: 0x00A5D400
		public bool MplCfgMPLListTADPLCode_A9257_Applicable
		{
			get
			{
				short num = (short)1604529726;
				short num2 = num;
				num = (short)1153969726;
				switch (num2 == num)
				{
				}
				num = (short)438566912;
				short num3 = num;
				num = (short)1448542209;
				if (num != 0)
				{
				}
				num = (short)719519744;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.Applicable;
			}
			set
			{
				short num = (short)1243745091;
				short num2 = num;
				num = (short)1750666051;
				switch (num2 == num)
				{
				}
				num = (short)356188160;
				short num3 = num;
				num = (short)671219713;
				if (num != 0)
				{
				}
				num = (short)369229824;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLCode_A9257.Applicable = value;
			}
		}

		// Token: 0x1700598C RID: 22924
		// (get) Token: 0x0600B2B9 RID: 45753 RVA: 0x00A5F2B4 File Offset: 0x00A5D4B4
		// (set) Token: 0x0600B2BA RID: 45754 RVA: 0x00A5F368 File Offset: 0x00A5D568
		public bool MplCfgMPLListTADPLCode_A9257_Valid
		{
			get
			{
				short num = (short)1294100765;
				short num2 = num;
				num = (short)150169885;
				switch (num2 == num)
				{
				}
				num = (short)2818048;
				short num3 = num;
				num = (short)1050935297;
				if (num != 0)
				{
				}
				num = (short)1242234880;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.Valid;
			}
			set
			{
				short num = (short)339804161;
				if (num != 0)
				{
				}
				num = (short)1117527536;
				short num2 = num;
				num = (short)1496915440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2124414976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1406795776;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLCode_A9257.Valid = value;
			}
		}

		// Token: 0x1700598D RID: 22925
		// (get) Token: 0x0600B2BB RID: 45755 RVA: 0x00A5F41C File Offset: 0x00A5D61C
		// (set) Token: 0x0600B2BC RID: 45756 RVA: 0x00A5F4D4 File Offset: 0x00A5D6D4
		public bool MplCfgMPLListTADPLCode_A9257_Visible
		{
			get
			{
				short num = (short)2128674817;
				if (num != 0)
				{
				}
				num = (short)266549695;
				short num2 = num;
				num = (short)99891647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295253504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)663158784;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.Visible;
			}
			set
			{
				short num = (short)1260257281;
				if (num != 0)
				{
				}
				num = (short)1811517088;
				short num2 = num;
				num = (short)1153011360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1531707392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)611713024;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLCode_A9257.Visible = value;
			}
		}

		// Token: 0x1700598E RID: 22926
		// (get) Token: 0x0600B2BD RID: 45757 RVA: 0x00A5F588 File Offset: 0x00A5D788
		// (set) Token: 0x0600B2BE RID: 45758 RVA: 0x00A5F63C File Offset: 0x00A5D83C
		public bool MplCfgMPLListTADPLCode_A9257_Editable
		{
			get
			{
				short num = (short)1271726081;
				if (num != 0)
				{
				}
				num = (short)1507981670;
				short num2 = num;
				num = (short)1774975334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1530331136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027211264;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.Editable;
			}
			set
			{
				short num = (short)1586364417;
				if (num != 0)
				{
				}
				num = (short)900528970;
				short num2 = num;
				num = (short)381287242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1111556096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)13565952;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLCode_A9257.Editable = value;
			}
		}

		// Token: 0x1700598F RID: 22927
		// (get) Token: 0x0600B2BF RID: 45759 RVA: 0x00A5F6F0 File Offset: 0x00A5D8F0
		internal string MplCfgMPLListTADPLCode_A9257_UILabel
		{
			get
			{
				short num = (short)1714612717;
				short num2 = num;
				num = (short)1918888429;
				switch (num2 == num)
				{
				}
				num = (short)1741553664;
				short num3 = num;
				num = (short)1148583937;
				if (num != 0)
				{
				}
				num = (short)331612160;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.UIName;
			}
		}

		// Token: 0x17005990 RID: 22928
		// (get) Token: 0x0600B2C0 RID: 45760 RVA: 0x00A5F7A4 File Offset: 0x00A5D9A4
		// (set) Token: 0x0600B2C1 RID: 45761 RVA: 0x00A5F858 File Offset: 0x00A5DA58
		internal bool MplCfgMPLListTADPLCode_A9257_HiddenStatic
		{
			get
			{
				short num = (short)1854889122;
				short num2 = num;
				num = (short)908418210;
				switch (num2 == num)
				{
				}
				num = (short)1203634176;
				if (num != 0)
				{
				}
				num = (short)465108992;
				short num3 = num;
				num = (short)584712193;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.HiddenStatic;
			}
			set
			{
				short num = (short)1297573046;
				short num2 = num;
				num = (short)1164403894;
				switch (num2 == num)
				{
				}
				num = (short)1244528641;
				if (num != 0)
				{
				}
				num = (short)638255104;
				short num3 = num;
				num = (short)1696464896;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLCode_A9257.HiddenStatic = value;
			}
		}

		// Token: 0x17005991 RID: 22929
		// (get) Token: 0x0600B2C2 RID: 45762 RVA: 0x00A5F910 File Offset: 0x00A5DB10
		// (set) Token: 0x0600B2C3 RID: 45763 RVA: 0x00A5F9C4 File Offset: 0x00A5DBC4
		internal bool MplCfgMPLListTADPLCode_A9257_HiddenDynamic
		{
			get
			{
				short num = (short)1944192351;
				short num2 = num;
				num = (short)267781471;
				switch (num2 == num)
				{
				}
				num = (short)2117992449;
				if (num != 0)
				{
				}
				num = (short)292880384;
				short num3 = num;
				num = (short)1893400576;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257.HiddenDynamic;
			}
			set
			{
				short num = (short)877199361;
				if (num != 0)
				{
				}
				num = (short)1639752356;
				short num2 = num;
				num = (short)78946980;
				switch (num2 == num)
				{
				}
				num = (short)2057502720;
				short num3 = num;
				num = (short)2094661632;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLCode_A9257.HiddenDynamic = value;
			}
		}

		// Token: 0x17005992 RID: 22930
		// (get) Token: 0x0600B2C4 RID: 45764 RVA: 0x00A5FA7C File Offset: 0x00A5DC7C
		public bool MplCfgMPLListTADPLCode_A9257_HasDiffs
		{
			get
			{
				short num = (short)210756963;
				short num2 = num;
				num = (short)593225059;
				switch (num2 == num)
				{
				}
				num = (short)495452161;
				if (num != 0)
				{
				}
				num = (short)638189568;
				short num3 = num;
				num = (short)154664960;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLCode_A9257._HasDiffs;
			}
		}

		// Token: 0x17005993 RID: 22931
		// (get) Token: 0x0600B2C5 RID: 45765 RVA: 0x00A5FB30 File Offset: 0x00A5DD30
		// (set) Token: 0x0600B2C6 RID: 45766 RVA: 0x00A5FBE4 File Offset: 0x00A5DDE4
		public int MplCfgMPLListTADPLInvert_A9258Value
		{
			get
			{
				short num = (short)2086265327;
				short num2 = num;
				num = (short)105505263;
				switch (num2 == num)
				{
				}
				num = (short)1933770752;
				if (num != 0)
				{
				}
				num = (short)1736179712;
				short num3 = num;
				num = (short)941817857;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.Value;
			}
			set
			{
				short num = (short)890697224;
				short num2 = num;
				num = (short)417723912;
				switch (num2 == num)
				{
				}
				num = (short)1107034113;
				if (num != 0)
				{
				}
				num = (short)1449656320;
				short num3 = num;
				num = (short)1946746880;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLInvert_A9258.Value = value;
			}
		}

		// Token: 0x17005994 RID: 22932
		// (get) Token: 0x0600B2C7 RID: 45767 RVA: 0x00A5FC9C File Offset: 0x00A5DE9C
		// (set) Token: 0x0600B2C8 RID: 45768 RVA: 0x00A5FD50 File Offset: 0x00A5DF50
		public string MplCfgMPLListTADPLInvert_A9258_UIValue
		{
			get
			{
				short num = (short)726067604;
				short num2 = num;
				num = (short)924576148;
				switch (num2 == num)
				{
				}
				num = (short)2048983041;
				if (num != 0)
				{
				}
				num = (short)1727594496;
				short num3 = num;
				num = (short)1383202816;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.UIValue;
			}
			set
			{
				short num = (short)974910317;
				short num2 = num;
				num = (short)952169325;
				switch (num2 == num)
				{
				}
				num = (short)1025310721;
				if (num != 0)
				{
				}
				num = (short)1603534848;
				short num3 = num;
				num = (short)716570624;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLInvert_A9258.UIValue = value;
			}
		}

		// Token: 0x17005995 RID: 22933
		// (get) Token: 0x0600B2C9 RID: 45769 RVA: 0x00A5FE04 File Offset: 0x00A5E004
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTADPLInvert_A9258
		{
			get
			{
				short num = (short)397668881;
				short num2 = num;
				num = (short)2045899281;
				switch (num2 == num)
				{
				}
				num = (short)1275199488;
				if (num != 0)
				{
				}
				num = (short)608436224;
				short num3 = num;
				num = (short)583401473;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258;
			}
		}

		// Token: 0x17005996 RID: 22934
		// (get) Token: 0x0600B2CA RID: 45770 RVA: 0x00A5FEB8 File Offset: 0x00A5E0B8
		// (set) Token: 0x0600B2CB RID: 45771 RVA: 0x00A5FF6C File Offset: 0x00A5E16C
		public bool MplCfgMPLListTADPLInvert_A9258_Applicable
		{
			get
			{
				short num = (short)780287943;
				short num2 = num;
				num = (short)1713651655;
				switch (num2 == num)
				{
				}
				num = (short)1943928833;
				if (num != 0)
				{
				}
				num = (short)1026752512;
				short num3 = num;
				num = (short)2061762560;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.Applicable;
			}
			set
			{
				short num = (short)289513454;
				short num2 = num;
				num = (short)2081857518;
				switch (num2 == num)
				{
				}
				num = (short)1483997185;
				if (num != 0)
				{
				}
				num = (short)104136704;
				short num3 = num;
				num = (short)1306329088;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLInvert_A9258.Applicable = value;
			}
		}

		// Token: 0x17005997 RID: 22935
		// (get) Token: 0x0600B2CC RID: 45772 RVA: 0x00A60020 File Offset: 0x00A5E220
		// (set) Token: 0x0600B2CD RID: 45773 RVA: 0x00A600D8 File Offset: 0x00A5E2D8
		public bool MplCfgMPLListTADPLInvert_A9258_Valid
		{
			get
			{
				short num = (short)1698365441;
				if (num != 0)
				{
				}
				num = (short)1250164612;
				short num2 = num;
				num = (short)1330380676;
				switch (num2 == num)
				{
				}
				num = (short)1979908096;
				short num3 = num;
				num = (short)259719168;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.Valid;
			}
			set
			{
				short num = (short)2100690945;
				if (num != 0)
				{
				}
				num = (short)700124155;
				short num2 = num;
				num = (short)618335227;
				switch (num2 == num)
				{
				}
				num = (short)1056899072;
				short num3 = num;
				num = (short)308740096;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLInvert_A9258.Valid = value;
			}
		}

		// Token: 0x17005998 RID: 22936
		// (get) Token: 0x0600B2CE RID: 45774 RVA: 0x00A6018C File Offset: 0x00A5E38C
		// (set) Token: 0x0600B2CF RID: 45775 RVA: 0x00A60240 File Offset: 0x00A5E440
		public bool MplCfgMPLListTADPLInvert_A9258_Visible
		{
			get
			{
				short num = (short)1523083748;
				short num2 = num;
				num = (short)1086417380;
				switch (num2 == num)
				{
				}
				num = (short)1137836032;
				if (num != 0)
				{
				}
				num = (short)1005518848;
				short num3 = num;
				num = (short)958922753;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.Visible;
			}
			set
			{
				short num = (short)288295125;
				short num2 = num;
				num = (short)321980629;
				switch (num2 == num)
				{
				}
				num = (short)1247084545;
				if (num != 0)
				{
				}
				num = (short)432340992;
				short num3 = num;
				num = (short)1505099776;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLInvert_A9258.Visible = value;
			}
		}

		// Token: 0x17005999 RID: 22937
		// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x00A602F4 File Offset: 0x00A5E4F4
		// (set) Token: 0x0600B2D1 RID: 45777 RVA: 0x00A603AC File Offset: 0x00A5E5AC
		public bool MplCfgMPLListTADPLInvert_A9258_Editable
		{
			get
			{
				short num = (short)1119289345;
				if (num != 0)
				{
				}
				num = (short)2088718561;
				short num2 = num;
				num = (short)1366511841;
				switch (num2 == num)
				{
				}
				num = (short)1348861952;
				short num3 = num;
				num = (short)1916993536;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.Editable;
			}
			set
			{
				short num = (short)1131970321;
				short num2 = num;
				num = (short)1426489105;
				switch (num2 == num)
				{
				}
				num = (short)1471938561;
				if (num != 0)
				{
				}
				num = (short)773062656;
				short num3 = num;
				num = (short)2016608256;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLInvert_A9258.Editable = value;
			}
		}

		// Token: 0x1700599A RID: 22938
		// (get) Token: 0x0600B2D2 RID: 45778 RVA: 0x00A60460 File Offset: 0x00A5E660
		internal string MplCfgMPLListTADPLInvert_A9258_UILabel
		{
			get
			{
				short num = (short)1927595616;
				short num2 = num;
				num = (short)2118633056;
				switch (num2 == num)
				{
				}
				num = (short)1360658433;
				if (num != 0)
				{
				}
				num = (short)1218183168;
				short num3 = num;
				num = (short)381812736;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.UIName;
			}
		}

		// Token: 0x1700599B RID: 22939
		// (get) Token: 0x0600B2D3 RID: 45779 RVA: 0x00A60514 File Offset: 0x00A5E714
		// (set) Token: 0x0600B2D4 RID: 45780 RVA: 0x00A605CC File Offset: 0x00A5E7CC
		internal bool MplCfgMPLListTADPLInvert_A9258_HiddenStatic
		{
			get
			{
				short num = (short)1322002905;
				short num2 = num;
				num = (short)2017274329;
				switch (num2 == num)
				{
				}
				num = (short)1004994561;
				if (num != 0)
				{
				}
				num = (short)1671757824;
				short num3 = num;
				num = (short)1024655360;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.HiddenStatic;
			}
			set
			{
				short num = (short)1060483608;
				short num2 = num;
				num = (short)1865724440;
				switch (num2 == num)
				{
				}
				num = (short)1656553473;
				if (num != 0)
				{
				}
				num = (short)1442381824;
				short num3 = num;
				num = (short)709361664;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLInvert_A9258.HiddenStatic = value;
			}
		}

		// Token: 0x1700599C RID: 22940
		// (get) Token: 0x0600B2D5 RID: 45781 RVA: 0x00A60684 File Offset: 0x00A5E884
		// (set) Token: 0x0600B2D6 RID: 45782 RVA: 0x00A60738 File Offset: 0x00A5E938
		internal bool MplCfgMPLListTADPLInvert_A9258_HiddenDynamic
		{
			get
			{
				short num = (short)1401017222;
				short num2 = num;
				num = (short)553767814;
				switch (num2 == num)
				{
				}
				num = (short)99287040;
				if (num != 0)
				{
				}
				num = (short)1550778368;
				short num3 = num;
				num = (short)1730084865;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258.HiddenDynamic;
			}
			set
			{
				short num = (short)1776818932;
				short num2 = num;
				num = (short)1819417332;
				switch (num2 == num)
				{
				}
				num = (short)1023541249;
				if (num != 0)
				{
				}
				num = (short)1734803456;
				short num3 = num;
				num = (short)1419378688;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTADPLInvert_A9258.HiddenDynamic = value;
			}
		}

		// Token: 0x1700599D RID: 22941
		// (get) Token: 0x0600B2D7 RID: 45783 RVA: 0x00A607EC File Offset: 0x00A5E9EC
		public bool MplCfgMPLListTADPLInvert_A9258_HasDiffs
		{
			get
			{
				short num = (short)1006431397;
				short num2 = num;
				num = (short)1680534693;
				switch (num2 == num)
				{
				}
				num = (short)1563885569;
				if (num != 0)
				{
				}
				num = (short)372244480;
				short num3 = num;
				num = (short)738787328;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTADPLInvert_A9258._HasDiffs;
			}
		}

		// Token: 0x1700599E RID: 22942
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x00A608A0 File Offset: 0x00A5EAA0
		// (set) Token: 0x0600B2D9 RID: 45785 RVA: 0x00A60954 File Offset: 0x00A5EB54
		public int MplCfgMPLListTAPLCode_A9262Value
		{
			get
			{
				short num = (short)1649029807;
				short num2 = num;
				num = (short)229061295;
				switch (num2 == num)
				{
				}
				num = (short)1588854784;
				if (num != 0)
				{
				}
				num = (short)550895616;
				short num3 = num;
				num = (short)123076609;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.Value;
			}
			set
			{
				short num = (short)445230502;
				short num2 = num;
				num = (short)1249488294;
				switch (num2 == num)
				{
				}
				num = (short)1485832193;
				if (num != 0)
				{
				}
				num = (short)3407872;
				short num3 = num;
				num = (short)116916224;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLCode_A9262.Value = value;
			}
		}

		// Token: 0x1700599F RID: 22943
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x00A60A08 File Offset: 0x00A5EC08
		// (set) Token: 0x0600B2DB RID: 45787 RVA: 0x00A60ABC File Offset: 0x00A5ECBC
		public string MplCfgMPLListTAPLCode_A9262_UIValue
		{
			get
			{
				short num = (short)1248469937;
				short num2 = num;
				num = (short)1611080625;
				switch (num2 == num)
				{
				}
				num = (short)180158465;
				if (num != 0)
				{
				}
				num = (short)1278803968;
				short num3 = num;
				num = (short)307101696;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.UIValue;
			}
			set
			{
				short num = (short)389840038;
				short num2 = num;
				num = (short)1838447782;
				switch (num2 == num)
				{
				}
				num = (short)551747585;
				if (num != 0)
				{
				}
				num = (short)1099104256;
				short num3 = num;
				num = (short)247726080;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLCode_A9262.UIValue = value;
			}
		}

		// Token: 0x170059A0 RID: 22944
		// (get) Token: 0x0600B2DC RID: 45788 RVA: 0x00A60B70 File Offset: 0x00A5ED70
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTAPLCode_A9262
		{
			get
			{
				short num = (short)2038562703;
				short num2 = num;
				num = (short)1895694223;
				switch (num2 == num)
				{
				}
				num = (short)1966931968;
				if (num != 0)
				{
				}
				num = (short)1278738432;
				short num3 = num;
				num = (short)836501505;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262;
			}
		}

		// Token: 0x170059A1 RID: 22945
		// (get) Token: 0x0600B2DD RID: 45789 RVA: 0x00A60C20 File Offset: 0x00A5EE20
		// (set) Token: 0x0600B2DE RID: 45790 RVA: 0x00A60CD4 File Offset: 0x00A5EED4
		public bool MplCfgMPLListTAPLCode_A9262_Applicable
		{
			get
			{
				short num = (short)393112301;
				short num2 = num;
				num = (short)1125083885;
				switch (num2 == num)
				{
				}
				num = (short)1100808192;
				if (num != 0)
				{
				}
				num = (short)933429248;
				short num3 = num;
				num = (short)1254948865;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.Applicable;
			}
			set
			{
				short num = (short)364526733;
				short num2 = num;
				num = (short)1787116685;
				switch (num2 == num)
				{
				}
				num = (short)1032585216;
				if (num != 0)
				{
				}
				num = (short)266076160;
				short num3 = num;
				num = (short)1925316609;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLCode_A9262.Applicable = value;
			}
		}

		// Token: 0x170059A2 RID: 22946
		// (get) Token: 0x0600B2DF RID: 45791 RVA: 0x00A60D88 File Offset: 0x00A5EF88
		// (set) Token: 0x0600B2E0 RID: 45792 RVA: 0x00A60E3C File Offset: 0x00A5F03C
		public bool MplCfgMPLListTAPLCode_A9262_Valid
		{
			get
			{
				short num = (short)1765937311;
				short num2 = num;
				num = (short)615059615;
				switch (num2 == num)
				{
				}
				num = (short)431882241;
				if (num != 0)
				{
				}
				num = (short)379191296;
				short num3 = num;
				num = (short)1791557632;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.Valid;
			}
			set
			{
				short num = (short)1936457729;
				if (num != 0)
				{
				}
				num = (short)1370651207;
				short num2 = num;
				num = (short)813660743;
				switch (num2 == num)
				{
				}
				num = (short)2020540416;
				short num3 = num;
				num = (short)526843904;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLCode_A9262.Valid = value;
			}
		}

		// Token: 0x170059A3 RID: 22947
		// (get) Token: 0x0600B2E1 RID: 45793 RVA: 0x00A60EF0 File Offset: 0x00A5F0F0
		// (set) Token: 0x0600B2E2 RID: 45794 RVA: 0x00A60FA8 File Offset: 0x00A5F1A8
		public bool MplCfgMPLListTAPLCode_A9262_Visible
		{
			get
			{
				short num = (short)1770828825;
				short num2 = num;
				num = (short)513455129;
				switch (num2 == num)
				{
				}
				num = (short)1352794113;
				if (num != 0)
				{
				}
				num = (short)2101542912;
				short num3 = num;
				num = (short)41025536;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.Visible;
			}
			set
			{
				short num = (short)446691857;
				short num2 = num;
				num = (short)436861457;
				switch (num2 == num)
				{
				}
				num = (short)1511391233;
				if (num != 0)
				{
				}
				num = (short)1834811392;
				short num3 = num;
				num = (short)1625423872;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLCode_A9262.Visible = value;
			}
		}

		// Token: 0x170059A4 RID: 22948
		// (get) Token: 0x0600B2E3 RID: 45795 RVA: 0x00A6105C File Offset: 0x00A5F25C
		// (set) Token: 0x0600B2E4 RID: 45796 RVA: 0x00A61114 File Offset: 0x00A5F314
		public bool MplCfgMPLListTAPLCode_A9262_Editable
		{
			get
			{
				short num = (short)1831530263;
				short num2 = num;
				num = (short)1386934039;
				switch (num2 == num)
				{
				}
				num = (short)1298464769;
				if (num != 0)
				{
				}
				num = (short)1268908032;
				short num3 = num;
				num = (short)1961361408;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.Editable;
			}
			set
			{
				short num = (short)633929729;
				if (num != 0)
				{
				}
				num = (short)1052862480;
				short num2 = num;
				num = (short)1623287824;
				switch (num2 == num)
				{
				}
				num = (short)734134272;
				short num3 = num;
				num = (short)2147287040;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLCode_A9262.Editable = value;
			}
		}

		// Token: 0x170059A5 RID: 22949
		// (get) Token: 0x0600B2E5 RID: 45797 RVA: 0x00A611CC File Offset: 0x00A5F3CC
		internal string MplCfgMPLListTAPLCode_A9262_UILabel
		{
			get
			{
				short num = (short)188261784;
				short num2 = num;
				num = (short)2014422424;
				switch (num2 == num)
				{
				}
				num = (short)1880948736;
				if (num != 0)
				{
				}
				num = (short)372768768;
				short num3 = num;
				num = (short)1772552193;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.UIName;
			}
		}

		// Token: 0x170059A6 RID: 22950
		// (get) Token: 0x0600B2E6 RID: 45798 RVA: 0x00A61280 File Offset: 0x00A5F480
		// (set) Token: 0x0600B2E7 RID: 45799 RVA: 0x00A61334 File Offset: 0x00A5F534
		internal bool MplCfgMPLListTAPLCode_A9262_HiddenStatic
		{
			get
			{
				short num = (short)1654137612;
				short num2 = num;
				num = (short)695149324;
				switch (num2 == num)
				{
				}
				num = (short)1708785665;
				if (num != 0)
				{
				}
				num = (short)595525632;
				short num3 = num;
				num = (short)1056374784;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.HiddenStatic;
			}
			set
			{
				short num = (short)1028479012;
				short num2 = num;
				num = (short)1408981028;
				switch (num2 == num)
				{
				}
				num = (short)10682369;
				if (num != 0)
				{
				}
				num = (short)2122317824;
				short num3 = num;
				num = (short)788529152;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLCode_A9262.HiddenStatic = value;
			}
		}

		// Token: 0x170059A7 RID: 22951
		// (get) Token: 0x0600B2E8 RID: 45800 RVA: 0x00A613E8 File Offset: 0x00A5F5E8
		// (set) Token: 0x0600B2E9 RID: 45801 RVA: 0x00A6149C File Offset: 0x00A5F69C
		internal bool MplCfgMPLListTAPLCode_A9262_HiddenDynamic
		{
			get
			{
				short num = (short)1018737703;
				short num2 = num;
				num = (short)623031335;
				switch (num2 == num)
				{
				}
				num = (short)130547712;
				if (num != 0)
				{
				}
				num = (short)1298137088;
				short num3 = num;
				num = (short)430571521;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262.HiddenDynamic;
			}
			set
			{
				short num = (short)81000228;
				short num2 = num;
				num = (short)1695807268;
				switch (num2 == num)
				{
				}
				num = (short)2142306305;
				if (num != 0)
				{
				}
				num = (short)662700032;
				short num3 = num;
				num = (short)1858928640;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLCode_A9262.HiddenDynamic = value;
			}
		}

		// Token: 0x170059A8 RID: 22952
		// (get) Token: 0x0600B2EA RID: 45802 RVA: 0x00A61550 File Offset: 0x00A5F750
		public bool MplCfgMPLListTAPLCode_A9262_HasDiffs
		{
			get
			{
				short num = (short)216653463;
				short num2 = num;
				num = (short)175758999;
				switch (num2 == num)
				{
				}
				num = (short)408158209;
				if (num != 0)
				{
				}
				num = (short)1597571072;
				short num3 = num;
				num = (short)220528640;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLCode_A9262._HasDiffs;
			}
		}

		// Token: 0x170059A9 RID: 22953
		// (get) Token: 0x0600B2EB RID: 45803 RVA: 0x00A61608 File Offset: 0x00A5F808
		// (set) Token: 0x0600B2EC RID: 45804 RVA: 0x00A616C0 File Offset: 0x00A5F8C0
		public int MplCfgMPLListTAPLFreq_A9263Value
		{
			get
			{
				short num = (short)1320526593;
				short num2 = num;
				num = (short)524002049;
				switch (num2 == num)
				{
				}
				num = (short)1552678912;
				if (num != 0)
				{
				}
				num = (short)1166278656;
				short num3 = num;
				num = (short)1329528833;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.Value;
			}
			set
			{
				short num = (short)1689321473;
				if (num != 0)
				{
				}
				num = (short)1730773436;
				short num2 = num;
				num = (short)466452924;
				switch (num2 == num)
				{
				}
				num = (short)1911357440;
				short num3 = num;
				num = (short)607584256;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLFreq_A9263.Value = value;
			}
		}

		// Token: 0x170059AA RID: 22954
		// (get) Token: 0x0600B2ED RID: 45805 RVA: 0x00A61778 File Offset: 0x00A5F978
		// (set) Token: 0x0600B2EE RID: 45806 RVA: 0x00A61830 File Offset: 0x00A5FA30
		public string MplCfgMPLListTAPLFreq_A9263_UIValue
		{
			get
			{
				short num = (short)227193204;
				short num2 = num;
				num = (short)1901965684;
				switch (num2 == num)
				{
				}
				num = (short)1229651969;
				if (num != 0)
				{
				}
				num = (short)350552064;
				short num3 = num;
				num = (short)2044854272;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.UIValue;
			}
			set
			{
				short num = (short)725233337;
				short num2 = num;
				num = (short)1916546745;
				switch (num2 == num)
				{
				}
				num = (short)1504444417;
				if (num != 0)
				{
				}
				num = (short)2041905152;
				short num3 = num;
				num = (short)1557856256;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLFreq_A9263.UIValue = value;
			}
		}

		// Token: 0x170059AB RID: 22955
		// (get) Token: 0x0600B2EF RID: 45807 RVA: 0x00A618E4 File Offset: 0x00A5FAE4
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTAPLFreq_A9263
		{
			get
			{
				short num = (short)1044578120;
				short num2 = num;
				num = (short)357826376;
				switch (num2 == num)
				{
				}
				num = (short)1496186881;
				if (num != 0)
				{
				}
				num = (short)146210816;
				short num3 = num;
				num = (short)574619648;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263;
			}
		}

		// Token: 0x170059AC RID: 22956
		// (get) Token: 0x0600B2F0 RID: 45808 RVA: 0x00A61990 File Offset: 0x00A5FB90
		// (set) Token: 0x0600B2F1 RID: 45809 RVA: 0x00A61A44 File Offset: 0x00A5FC44
		public bool MplCfgMPLListTAPLFreq_A9263_Applicable
		{
			get
			{
				short num = (short)1950547768;
				short num2 = num;
				num = (short)2060123960;
				switch (num2 == num)
				{
				}
				num = (short)1429995521;
				if (num != 0)
				{
				}
				num = (short)1714814976;
				short num3 = num;
				num = (short)2000814080;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.Applicable;
			}
			set
			{
				short num = (short)1115428123;
				short num2 = num;
				num = (short)356455707;
				switch (num2 == num)
				{
				}
				num = (short)1450508289;
				if (num != 0)
				{
				}
				num = (short)1668743168;
				short num3 = num;
				num = (short)523370496;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLFreq_A9263.Applicable = value;
			}
		}

		// Token: 0x170059AD RID: 22957
		// (get) Token: 0x0600B2F2 RID: 45810 RVA: 0x00A61AF8 File Offset: 0x00A5FCF8
		// (set) Token: 0x0600B2F3 RID: 45811 RVA: 0x00A61BA8 File Offset: 0x00A5FDA8
		public bool MplCfgMPLListTAPLFreq_A9263_Valid
		{
			get
			{
				short num = (short)1705574401;
				if (num != 0)
				{
				}
				num = (short)518252765;
				short num2 = num;
				num = (short)816376029;
				switch (num2 == num)
				{
				}
				num = (short)957939712;
				short num3 = num;
				num = (short)452460544;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.Valid;
			}
			set
			{
				short num = (short)1721962382;
				short num2 = num;
				num = (short)1683296142;
				switch (num2 == num)
				{
				}
				num = (short)404226049;
				if (num != 0)
				{
				}
				num = (short)119996416;
				short num3 = num;
				num = (short)2030895104;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLFreq_A9263.Valid = value;
			}
		}

		// Token: 0x170059AE RID: 22958
		// (get) Token: 0x0600B2F4 RID: 45812 RVA: 0x00A61C5C File Offset: 0x00A5FE5C
		// (set) Token: 0x0600B2F5 RID: 45813 RVA: 0x00A61D10 File Offset: 0x00A5FF10
		public bool MplCfgMPLListTAPLFreq_A9263_Visible
		{
			get
			{
				short num = (short)1749496581;
				short num2 = num;
				num = (short)838415109;
				switch (num2 == num)
				{
				}
				num = (short)1466302465;
				if (num != 0)
				{
				}
				num = (short)1030750208;
				short num3 = num;
				num = (short)2099249152;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.Visible;
			}
			set
			{
				short num = (short)1712050544;
				short num2 = num;
				num = (short)1982910832;
				switch (num2 == num)
				{
				}
				num = (short)1598095361;
				if (num != 0)
				{
				}
				num = (short)1976238080;
				short num3 = num;
				num = (short)2064515072;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLFreq_A9263.Visible = value;
			}
		}

		// Token: 0x170059AF RID: 22959
		// (get) Token: 0x0600B2F6 RID: 45814 RVA: 0x00A61DC4 File Offset: 0x00A5FFC4
		// (set) Token: 0x0600B2F7 RID: 45815 RVA: 0x00A61E74 File Offset: 0x00A60074
		public bool MplCfgMPLListTAPLFreq_A9263_Editable
		{
			get
			{
				short num = (short)1997930497;
				if (num != 0)
				{
				}
				num = (short)432289748;
				short num2 = num;
				num = (short)184235988;
				switch (num2 == num)
				{
				}
				num = (short)2080702464;
				short num3 = num;
				num = (short)1015545856;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.Editable;
			}
			set
			{
				short num = (short)2110586881;
				if (num != 0)
				{
				}
				num = (short)595888412;
				short num2 = num;
				num = (short)334792988;
				switch (num2 == num)
				{
				}
				num = (short)1121648640;
				short num3 = num;
				num = (short)733872128;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLFreq_A9263.Editable = value;
			}
		}

		// Token: 0x170059B0 RID: 22960
		// (get) Token: 0x0600B2F8 RID: 45816 RVA: 0x00A61F2C File Offset: 0x00A6012C
		internal string MplCfgMPLListTAPLFreq_A9263_UILabel
		{
			get
			{
				short num = (short)307775938;
				short num2 = num;
				num = (short)1884113346;
				switch (num2 == num)
				{
				}
				num = (short)392560640;
				if (num != 0)
				{
				}
				num = (short)433520640;
				short num3 = num;
				num = (short)723124225;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.UIName;
			}
		}

		// Token: 0x170059B1 RID: 22961
		// (get) Token: 0x0600B2F9 RID: 45817 RVA: 0x00A61FE4 File Offset: 0x00A601E4
		// (set) Token: 0x0600B2FA RID: 45818 RVA: 0x00A62094 File Offset: 0x00A60294
		internal bool MplCfgMPLListTAPLFreq_A9263_HiddenStatic
		{
			get
			{
				short num = (short)421599417;
				short num2 = num;
				num = (short)2136348857;
				switch (num2 == num)
				{
				}
				num = (short)791937024;
				if (num != 0)
				{
				}
				num = (short)602996736;
				short num3 = num;
				num = (short)1350172673;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.HiddenStatic;
			}
			set
			{
				short num = (short)2132242421;
				short num2 = num;
				num = (short)1238200309;
				switch (num2 == num)
				{
				}
				num = (short)1366884353;
				if (num != 0)
				{
				}
				num = (short)163381248;
				short num3 = num;
				num = (short)861339648;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLFreq_A9263.HiddenStatic = value;
			}
		}

		// Token: 0x170059B2 RID: 22962
		// (get) Token: 0x0600B2FB RID: 45819 RVA: 0x00A62148 File Offset: 0x00A60348
		// (set) Token: 0x0600B2FC RID: 45820 RVA: 0x00A621FC File Offset: 0x00A603FC
		internal bool MplCfgMPLListTAPLFreq_A9263_HiddenDynamic
		{
			get
			{
				short num = (short)28573697;
				if (num != 0)
				{
				}
				num = (short)664876988;
				short num2 = num;
				num = (short)790640572;
				switch (num2 == num)
				{
				}
				num = (short)1759969280;
				short num3 = num;
				num = (short)683737088;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263.HiddenDynamic;
			}
			set
			{
				short num = (short)408944641;
				if (num != 0)
				{
				}
				num = (short)1666825789;
				short num2 = num;
				num = (short)191413821;
				switch (num2 == num)
				{
				}
				num = (short)1920335872;
				short num3 = num;
				num = (short)1369702400;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTAPLFreq_A9263.HiddenDynamic = value;
			}
		}

		// Token: 0x170059B3 RID: 22963
		// (get) Token: 0x0600B2FD RID: 45821 RVA: 0x00A622B4 File Offset: 0x00A604B4
		public bool MplCfgMPLListTAPLFreq_A9263_HasDiffs
		{
			get
			{
				short num = (short)2040101217;
				short num2 = num;
				num = (short)2102491489;
				switch (num2 == num)
				{
				}
				num = (short)252772353;
				if (num != 0)
				{
				}
				num = (short)1353711616;
				short num3 = num;
				num = (short)107347968;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTAPLFreq_A9263._HasDiffs;
			}
		}

		// Token: 0x170059B4 RID: 22964
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x00A6236C File Offset: 0x00A6056C
		// (set) Token: 0x0600B2FF RID: 45823 RVA: 0x00A62420 File Offset: 0x00A60620
		public int MplCfgMPLListTASquelchType_A9266Value
		{
			get
			{
				short num = (short)1103096324;
				short num2 = num;
				num = (short)838199812;
				switch (num2 == num)
				{
				}
				num = (short)409337857;
				if (num != 0)
				{
				}
				num = (short)1156775936;
				short num3 = num;
				num = (short)2064515072;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.Value;
			}
			set
			{
				short num = (short)961382527;
				short num2 = num;
				num = (short)1425705087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119879168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1779040256;
				if (num != 0)
				{
				}
				num = (short)57999361;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTASquelchType_A9266.Value = value;
			}
		}

		// Token: 0x170059B5 RID: 22965
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x00A624D4 File Offset: 0x00A606D4
		// (set) Token: 0x0600B301 RID: 45825 RVA: 0x00A62588 File Offset: 0x00A60788
		public string MplCfgMPLListTASquelchType_A9266_UIValue
		{
			get
			{
				short num = (short)820295044;
				short num2 = num;
				num = (short)354989444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413480448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239337472;
				if (num != 0)
				{
				}
				num = (short)611909633;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.UIValue;
			}
			set
			{
				short num = (short)812003112;
				short num2 = num;
				num = (short)1897148200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1517879296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1196032001;
				if (num != 0)
				{
				}
				num = (short)341442560;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTASquelchType_A9266.UIValue = value;
			}
		}

		// Token: 0x170059B6 RID: 22966
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x00A6263C File Offset: 0x00A6083C
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTASquelchType_A9266
		{
			get
			{
				short num = (short)1260332454;
				short num2 = num;
				num = (short)1439311270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)616497152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2087387137;
				if (num != 0)
				{
				}
				num = (short)1386283008;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266;
			}
		}

		// Token: 0x170059B7 RID: 22967
		// (get) Token: 0x0600B303 RID: 45827 RVA: 0x00A626F0 File Offset: 0x00A608F0
		// (set) Token: 0x0600B304 RID: 45828 RVA: 0x00A627A0 File Offset: 0x00A609A0
		public bool MplCfgMPLListTASquelchType_A9266_Applicable
		{
			get
			{
				short num = (short)1159744363;
				short num2 = num;
				num = (short)2128235371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1991901184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)322895873;
				if (num != 0)
				{
				}
				num = (short)1240793088;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.Applicable;
			}
			set
			{
				short num = (short)581898729;
				short num2 = num;
				num = (short)298389993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)587595776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1978531840;
				if (num != 0)
				{
				}
				num = (short)1229389825;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTASquelchType_A9266.Applicable = value;
			}
		}

		// Token: 0x170059B8 RID: 22968
		// (get) Token: 0x0600B305 RID: 45829 RVA: 0x00A62854 File Offset: 0x00A60A54
		// (set) Token: 0x0600B306 RID: 45830 RVA: 0x00A62908 File Offset: 0x00A60B08
		public bool MplCfgMPLListTASquelchType_A9266_Valid
		{
			get
			{
				short num = (short)1464105676;
				short num2 = num;
				num = (short)83524300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)125763584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)388562945;
				if (num != 0)
				{
				}
				num = (short)1600978944;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.Valid;
			}
			set
			{
				short num = (short)1496293572;
				short num2 = num;
				num = (short)1040818372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1642659840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)603586561;
				if (num != 0)
				{
				}
				num = (short)2050818048;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTASquelchType_A9266.Valid = value;
			}
		}

		// Token: 0x170059B9 RID: 22969
		// (get) Token: 0x0600B307 RID: 45831 RVA: 0x00A629BC File Offset: 0x00A60BBC
		// (set) Token: 0x0600B308 RID: 45832 RVA: 0x00A62A70 File Offset: 0x00A60C70
		public bool MplCfgMPLListTASquelchType_A9266_Visible
		{
			get
			{
				short num = (short)444574536;
				short num2 = num;
				num = (short)1926474568;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2033582080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1261502465;
				if (num != 0)
				{
				}
				num = (short)1978073088;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.Visible;
			}
			set
			{
				short num = (short)1204378629;
				short num2 = num;
				num = (short)630217733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)600571904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)617349120;
				if (num != 0)
				{
				}
				num = (short)456851457;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTASquelchType_A9266.Visible = value;
			}
		}

		// Token: 0x170059BA RID: 22970
		// (get) Token: 0x0600B309 RID: 45833 RVA: 0x00A62B28 File Offset: 0x00A60D28
		// (set) Token: 0x0600B30A RID: 45834 RVA: 0x00A62BDC File Offset: 0x00A60DDC
		public bool MplCfgMPLListTASquelchType_A9266_Editable
		{
			get
			{
				short num = (short)1521352705;
				if (num != 0)
				{
				}
				num = (short)2053636096;
				short num2 = num;
				num = (short)582315580;
				short num3 = num;
				num = (short)1075146300;
				switch (num3 == num)
				{
				}
				num = (short)2058223616;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.Editable;
			}
			set
			{
				short num = (short)873428401;
				short num2 = num;
				num = (short)1733653937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)920059904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1823408129;
				if (num != 0)
				{
				}
				num = (short)1137115136;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTASquelchType_A9266.Editable = value;
			}
		}

		// Token: 0x170059BB RID: 22971
		// (get) Token: 0x0600B30B RID: 45835 RVA: 0x00A62C94 File Offset: 0x00A60E94
		internal string MplCfgMPLListTASquelchType_A9266_UILabel
		{
			get
			{
				short num = (short)1077918452;
				short num2 = num;
				num = (short)1771944692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1689649152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32374785;
				if (num != 0)
				{
				}
				num = (short)1051721728;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.UIName;
			}
		}

		// Token: 0x170059BC RID: 22972
		// (get) Token: 0x0600B30C RID: 45836 RVA: 0x00A62D48 File Offset: 0x00A60F48
		// (set) Token: 0x0600B30D RID: 45837 RVA: 0x00A62DFC File Offset: 0x00A60FFC
		internal bool MplCfgMPLListTASquelchType_A9266_HiddenStatic
		{
			get
			{
				short num = (short)534836463;
				short num2 = num;
				num = (short)1201927407;
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
				num = (short)460324865;
				if (num != 0)
				{
				}
				num = (short)663945216;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.HiddenStatic;
			}
			set
			{
				short num = (short)841644018;
				short num2 = num;
				num = (short)1463973874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1023213568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1087700993;
				if (num != 0)
				{
				}
				num = (short)1398407168;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTASquelchType_A9266.HiddenStatic = value;
			}
		}

		// Token: 0x170059BD RID: 22973
		// (get) Token: 0x0600B30E RID: 45838 RVA: 0x00A62EB4 File Offset: 0x00A610B4
		// (set) Token: 0x0600B30F RID: 45839 RVA: 0x00A62F68 File Offset: 0x00A61168
		internal bool MplCfgMPLListTASquelchType_A9266_HiddenDynamic
		{
			get
			{
				short num = (short)1002990313;
				short num2 = num;
				num = (short)263219945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)974192640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609039873;
				if (num != 0)
				{
				}
				num = (short)308477952;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266.HiddenDynamic;
			}
			set
			{
				short num = (short)475300154;
				short num2 = num;
				num = (short)121143610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)295763968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896873985;
				if (num != 0)
				{
				}
				num = (short)1308753920;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTASquelchType_A9266.HiddenDynamic = value;
			}
		}

		// Token: 0x170059BE RID: 22974
		// (get) Token: 0x0600B310 RID: 45840 RVA: 0x00A63020 File Offset: 0x00A61220
		public bool MplCfgMPLListTASquelchType_A9266_HasDiffs
		{
			get
			{
				short num = (short)608730860;
				short num2 = num;
				num = (short)831094508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)213057536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1694498817;
				if (num != 0)
				{
				}
				num = (short)1825177600;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTASquelchType_A9266._HasDiffs;
			}
		}

		// Token: 0x170059BF RID: 22975
		// (get) Token: 0x0600B311 RID: 45841 RVA: 0x00A630D4 File Offset: 0x00A612D4
		// (set) Token: 0x0600B312 RID: 45842 RVA: 0x00A63188 File Offset: 0x00A61388
		public int MplCfgMPLListTxDPLCode_A9527Value
		{
			get
			{
				short num = (short)695805033;
				short num2 = num;
				num = (short)512828521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)424738816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)560267265;
				if (num != 0)
				{
				}
				num = (short)349044736;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.Value;
			}
			set
			{
				short num = (short)55868782;
				short num2 = num;
				num = (short)460946798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)898957312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)890634241;
				if (num != 0)
				{
				}
				num = (short)1913716736;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLCode_A9527.Value = value;
			}
		}

		// Token: 0x170059C0 RID: 22976
		// (get) Token: 0x0600B313 RID: 45843 RVA: 0x00A63240 File Offset: 0x00A61440
		// (set) Token: 0x0600B314 RID: 45844 RVA: 0x00A632F8 File Offset: 0x00A614F8
		public string MplCfgMPLListTxDPLCode_A9527_UIValue
		{
			get
			{
				short num = (short)2029513332;
				short num2 = num;
				num = (short)1355541108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)811204608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307901953;
				if (num != 0)
				{
				}
				num = (short)2091515904;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.UIValue;
			}
			set
			{
				short num = (short)633766416;
				short num2 = num;
				num = (short)508068368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)279117824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1075445760;
				if (num != 0)
				{
				}
				num = (short)1163657217;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLCode_A9527.UIValue = value;
			}
		}

		// Token: 0x170059C1 RID: 22977
		// (get) Token: 0x0600B315 RID: 45845 RVA: 0x00A633B0 File Offset: 0x00A615B0
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTxDPLCode_A9527
		{
			get
			{
				short num = (short)234892542;
				short num2 = num;
				num = (short)1836199166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)116588544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1461518337;
				if (num != 0)
				{
				}
				num = (short)14090240;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527;
			}
		}

		// Token: 0x170059C2 RID: 22978
		// (get) Token: 0x0600B316 RID: 45846 RVA: 0x00A63460 File Offset: 0x00A61660
		// (set) Token: 0x0600B317 RID: 45847 RVA: 0x00A63514 File Offset: 0x00A61714
		public bool MplCfgMPLListTxDPLCode_A9527_Applicable
		{
			get
			{
				short num = (short)1936982017;
				if (num != 0)
				{
				}
				num = (short)933101568;
				short num2 = num;
				num = (short)155770265;
				short num3 = num;
				num = (short)1889131929;
				switch (num3 == num)
				{
				}
				num = (short)619773952;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.Applicable;
			}
			set
			{
				short num = (short)494184663;
				short num2 = num;
				num = (short)1285466327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)696123392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120796673;
				if (num != 0)
				{
				}
				num = (short)1868103680;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLCode_A9527.Applicable = value;
			}
		}

		// Token: 0x170059C3 RID: 22979
		// (get) Token: 0x0600B318 RID: 45848 RVA: 0x00A635C8 File Offset: 0x00A617C8
		// (set) Token: 0x0600B319 RID: 45849 RVA: 0x00A63680 File Offset: 0x00A61880
		public bool MplCfgMPLListTxDPLCode_A9527_Valid
		{
			get
			{
				short num = (short)1583316036;
				short num2 = num;
				num = (short)326401092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)952041472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)65601537;
				if (num != 0)
				{
				}
				num = (short)1639841792;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.Valid;
			}
			set
			{
				short num = (short)1103524085;
				short num2 = num;
				num = (short)1223586037;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2129788928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1439760385;
				if (num != 0)
				{
				}
				num = (short)1377763328;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLCode_A9527.Valid = value;
			}
		}

		// Token: 0x170059C4 RID: 22980
		// (get) Token: 0x0600B31A RID: 45850 RVA: 0x00A63738 File Offset: 0x00A61938
		// (set) Token: 0x0600B31B RID: 45851 RVA: 0x00A637F0 File Offset: 0x00A619F0
		public bool MplCfgMPLListTxDPLCode_A9527_Visible
		{
			get
			{
				short num = (short)1413064021;
				short num2 = num;
				num = (short)963421525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1762656256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1724710913;
				if (num != 0)
				{
				}
				num = (short)2066284544;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.Visible;
			}
			set
			{
				short num = (short)299257686;
				short num2 = num;
				num = (short)1394888534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)490668032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1406205953;
				if (num != 0)
				{
				}
				num = (short)160628736;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLCode_A9527.Visible = value;
			}
		}

		// Token: 0x170059C5 RID: 22981
		// (get) Token: 0x0600B31C RID: 45852 RVA: 0x00A638A4 File Offset: 0x00A61AA4
		// (set) Token: 0x0600B31D RID: 45853 RVA: 0x00A63958 File Offset: 0x00A61B58
		public bool MplCfgMPLListTxDPLCode_A9527_Editable
		{
			get
			{
				short num = (short)852899235;
				short num2 = num;
				num = (short)1303786915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093875200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)36241409;
				if (num != 0)
				{
				}
				num = (short)1307901952;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.Editable;
			}
			set
			{
				short num = (short)1504766799;
				short num2 = num;
				num = (short)972286799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)772079616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609564161;
				if (num != 0)
				{
				}
				num = (short)1468203008;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLCode_A9527.Editable = value;
			}
		}

		// Token: 0x170059C6 RID: 22982
		// (get) Token: 0x0600B31E RID: 45854 RVA: 0x00A63A0C File Offset: 0x00A61C0C
		internal string MplCfgMPLListTxDPLCode_A9527_UILabel
		{
			get
			{
				short num = (short)1515428327;
				short num2 = num;
				num = (short)2047056359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1743650816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1053753345;
				if (num != 0)
				{
				}
				num = (short)878968832;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.UIName;
			}
		}

		// Token: 0x170059C7 RID: 22983
		// (get) Token: 0x0600B31F RID: 45855 RVA: 0x00A63AC0 File Offset: 0x00A61CC0
		// (set) Token: 0x0600B320 RID: 45856 RVA: 0x00A63B78 File Offset: 0x00A61D78
		internal bool MplCfgMPLListTxDPLCode_A9527_HiddenStatic
		{
			get
			{
				short num = (short)1684880070;
				short num2 = num;
				num = (short)992885446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1672544256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1749155841;
				if (num != 0)
				{
				}
				num = (short)1877213184;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.HiddenStatic;
			}
			set
			{
				short num = (short)805178656;
				short num2 = num;
				num = (short)498470176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)803995648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)708771841;
				if (num != 0)
				{
				}
				num = (short)1066074112;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLCode_A9527.HiddenStatic = value;
			}
		}

		// Token: 0x170059C8 RID: 22984
		// (get) Token: 0x0600B321 RID: 45857 RVA: 0x00A63C2C File Offset: 0x00A61E2C
		// (set) Token: 0x0600B322 RID: 45858 RVA: 0x00A63CE4 File Offset: 0x00A61EE4
		internal bool MplCfgMPLListTxDPLCode_A9527_HiddenDynamic
		{
			get
			{
				short num = (short)655447576;
				short num2 = num;
				num = (short)1666995736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)456523776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173211649;
				if (num != 0)
				{
				}
				num = (short)1822883840;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527.HiddenDynamic;
			}
			set
			{
				short num = (short)180944897;
				if (num != 0)
				{
				}
				num = (short)1916076032;
				short num2 = num;
				num = (short)695659901;
				short num3 = num;
				num = (short)84929917;
				switch (num3 == num)
				{
				}
				num = (short)1718353920;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLCode_A9527.HiddenDynamic = value;
			}
		}

		// Token: 0x170059C9 RID: 22985
		// (get) Token: 0x0600B323 RID: 45859 RVA: 0x00A63D9C File Offset: 0x00A61F9C
		public bool MplCfgMPLListTxDPLCode_A9527_HasDiffs
		{
			get
			{
				short num = (short)1556894355;
				short num2 = num;
				num = (short)499602067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)233897984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1995964417;
				if (num != 0)
				{
				}
				num = (short)214171648;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLCode_A9527._HasDiffs;
			}
		}

		// Token: 0x170059CA RID: 22986
		// (get) Token: 0x0600B324 RID: 45860 RVA: 0x00A63E54 File Offset: 0x00A62054
		// (set) Token: 0x0600B325 RID: 45861 RVA: 0x00A63F08 File Offset: 0x00A62108
		public int MplCfgMPLListTxDPLInvert_A9528Value
		{
			get
			{
				short num = (short)689867726;
				short num2 = num;
				num = (short)1544129486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786432000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1799421953;
				if (num != 0)
				{
				}
				num = (short)1670840320;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.Value;
			}
			set
			{
				short num = (short)662831105;
				if (num != 0)
				{
				}
				num = (short)1029439488;
				short num2 = num;
				num = (short)205251406;
				short num3 = num;
				num = (short)2088231758;
				switch (num3 == num)
				{
				}
				num = (short)591593472;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLInvert_A9528.Value = value;
			}
		}

		// Token: 0x170059CB RID: 22987
		// (get) Token: 0x0600B326 RID: 45862 RVA: 0x00A63FBC File Offset: 0x00A621BC
		// (set) Token: 0x0600B327 RID: 45863 RVA: 0x00A64074 File Offset: 0x00A62274
		public string MplCfgMPLListTxDPLInvert_A9528_UIValue
		{
			get
			{
				short num = (short)1906896222;
				short num2 = num;
				num = (short)1162931550;
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
				num = (short)350224385;
				if (num != 0)
				{
				}
				num = (short)1122631680;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.UIValue;
			}
			set
			{
				short num = (short)1797424235;
				short num2 = num;
				num = (short)982942827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497235456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)653918208;
				if (num != 0)
				{
				}
				num = (short)1308426241;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLInvert_A9528.UIValue = value;
			}
		}

		// Token: 0x170059CC RID: 22988
		// (get) Token: 0x0600B328 RID: 45864 RVA: 0x00A64128 File Offset: 0x00A62328
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTxDPLInvert_A9528
		{
			get
			{
				short num = (short)925660246;
				short num2 = num;
				num = (short)2143712342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1945370624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1086914561;
				if (num != 0)
				{
				}
				num = (short)920649728;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528;
			}
		}

		// Token: 0x170059CD RID: 22989
		// (get) Token: 0x0600B329 RID: 45865 RVA: 0x00A641D4 File Offset: 0x00A623D4
		// (set) Token: 0x0600B32A RID: 45866 RVA: 0x00A64288 File Offset: 0x00A62488
		public bool MplCfgMPLListTxDPLInvert_A9528_Applicable
		{
			get
			{
				short num = (short)133840277;
				short num2 = num;
				num = (short)856833429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188153856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)304087041;
				if (num != 0)
				{
				}
				num = (short)319422464;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.Applicable;
			}
			set
			{
				short num = (short)208122761;
				short num2 = num;
				num = (short)119714697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816788992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)601817088;
				if (num != 0)
				{
				}
				num = (short)547291137;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLInvert_A9528.Applicable = value;
			}
		}

		// Token: 0x170059CE RID: 22990
		// (get) Token: 0x0600B32B RID: 45867 RVA: 0x00A64340 File Offset: 0x00A62540
		// (set) Token: 0x0600B32C RID: 45868 RVA: 0x00A643F8 File Offset: 0x00A625F8
		public bool MplCfgMPLListTxDPLInvert_A9528_Valid
		{
			get
			{
				short num = (short)1485554889;
				short num2 = num;
				num = (short)1744618697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1161101312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1969815553;
				if (num != 0)
				{
				}
				num = (short)884736000;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.Valid;
			}
			set
			{
				short num = (short)1848377345;
				if (num != 0)
				{
				}
				num = (short)745996288;
				short num2 = num;
				num = (short)572349374;
				short num3 = num;
				num = (short)2098813886;
				switch (num3 == num)
				{
				}
				num = (short)1230372864;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLInvert_A9528.Valid = value;
			}
		}

		// Token: 0x170059CF RID: 22991
		// (get) Token: 0x0600B32D RID: 45869 RVA: 0x00A644AC File Offset: 0x00A626AC
		// (set) Token: 0x0600B32E RID: 45870 RVA: 0x00A64560 File Offset: 0x00A62760
		public bool MplCfgMPLListTxDPLInvert_A9528_Visible
		{
			get
			{
				short num = (short)1057193184;
				short num2 = num;
				num = (short)1417968864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)182779904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)450822145;
				if (num != 0)
				{
				}
				num = (short)1076953088;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.Visible;
			}
			set
			{
				short num = (short)856265772;
				short num2 = num;
				num = (short)840930348;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1626800128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)801767425;
				if (num != 0)
				{
				}
				num = (short)1088487424;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLInvert_A9528.Visible = value;
			}
		}

		// Token: 0x170059D0 RID: 22992
		// (get) Token: 0x0600B32F RID: 45871 RVA: 0x00A64614 File Offset: 0x00A62814
		// (set) Token: 0x0600B330 RID: 45872 RVA: 0x00A646C8 File Offset: 0x00A628C8
		public bool MplCfgMPLListTxDPLInvert_A9528_Editable
		{
			get
			{
				short num = (short)356766160;
				short num2 = num;
				num = (short)250073552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)179699712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2055995393;
				if (num != 0)
				{
				}
				num = (short)1774125056;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.Editable;
			}
			set
			{
				short num = (short)1537584592;
				short num2 = num;
				num = (short)797289936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)18612224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)362151937;
				if (num != 0)
				{
				}
				num = (short)1093664768;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLInvert_A9528.Editable = value;
			}
		}

		// Token: 0x170059D1 RID: 22993
		// (get) Token: 0x0600B331 RID: 45873 RVA: 0x00A6477C File Offset: 0x00A6297C
		internal string MplCfgMPLListTxDPLInvert_A9528_UILabel
		{
			get
			{
				short num = (short)1710747322;
				short num2 = num;
				num = (short)274656954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1201602560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1903820800;
				if (num != 0)
				{
				}
				num = (short)575930369;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.UIName;
			}
		}

		// Token: 0x170059D2 RID: 22994
		// (get) Token: 0x0600B332 RID: 45874 RVA: 0x00A64830 File Offset: 0x00A62A30
		// (set) Token: 0x0600B333 RID: 45875 RVA: 0x00A648E4 File Offset: 0x00A62AE4
		internal bool MplCfgMPLListTxDPLInvert_A9528_HiddenStatic
		{
			get
			{
				short num = (short)2112534735;
				short num2 = num;
				num = (short)621590735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)830341120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262668289;
				if (num != 0)
				{
				}
				num = (short)1226309632;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.HiddenStatic;
			}
			set
			{
				short num = (short)1780324819;
				short num2 = num;
				num = (short)1177393619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)859373568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)508559361;
				if (num != 0)
				{
				}
				num = (short)2136145920;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLInvert_A9528.HiddenStatic = value;
			}
		}

		// Token: 0x170059D3 RID: 22995
		// (get) Token: 0x0600B334 RID: 45876 RVA: 0x00A6499C File Offset: 0x00A62B9C
		// (set) Token: 0x0600B335 RID: 45877 RVA: 0x00A64A50 File Offset: 0x00A62C50
		internal bool MplCfgMPLListTxDPLInvert_A9528_HiddenDynamic
		{
			get
			{
				short num = (short)1679948787;
				short num2 = num;
				num = (short)876608499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)130809856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1570242561;
				if (num != 0)
				{
				}
				num = (short)1195180032;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528.HiddenDynamic;
			}
			set
			{
				short num = (short)377225103;
				short num2 = num;
				num = (short)62979983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286864896;
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
				num = (short)707330048;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxDPLInvert_A9528.HiddenDynamic = value;
			}
		}

		// Token: 0x170059D4 RID: 22996
		// (get) Token: 0x0600B336 RID: 45878 RVA: 0x00A64B04 File Offset: 0x00A62D04
		public bool MplCfgMPLListTxDPLInvert_A9528_HasDiffs
		{
			get
			{
				short num = (short)863700591;
				short num2 = num;
				num = (short)847775343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131623936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)668532737;
				if (num != 0)
				{
				}
				num = (short)845938688;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxDPLInvert_A9528._HasDiffs;
			}
		}

		// Token: 0x170059D5 RID: 22997
		// (get) Token: 0x0600B337 RID: 45879 RVA: 0x00A64BB8 File Offset: 0x00A62DB8
		// (set) Token: 0x0600B338 RID: 45880 RVA: 0x00A64C70 File Offset: 0x00A62E70
		public int MplCfgMPLListTxPLCode_A9555Value
		{
			get
			{
				short num = (short)187271301;
				short num2 = num;
				num = (short)472090757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1056571392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2030043137;
				if (num != 0)
				{
				}
				num = (short)1715732480;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.Value;
			}
			set
			{
				short num = (short)8278414;
				short num2 = num;
				num = (short)719671694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1534590976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1316552705;
				if (num != 0)
				{
				}
				num = (short)2012413952;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLCode_A9555.Value = value;
			}
		}

		// Token: 0x170059D6 RID: 22998
		// (get) Token: 0x0600B339 RID: 45881 RVA: 0x00A64D28 File Offset: 0x00A62F28
		// (set) Token: 0x0600B33A RID: 45882 RVA: 0x00A64DD8 File Offset: 0x00A62FD8
		public string MplCfgMPLListTxPLCode_A9555_UIValue
		{
			get
			{
				short num = (short)1929018575;
				short num2 = num;
				num = (short)34110671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1930821632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909850112;
				if (num != 0)
				{
				}
				num = (short)1448869889;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.UIValue;
			}
			set
			{
				short num = (short)1575604006;
				short num2 = num;
				num = (short)783142694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)814415872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686175744;
				if (num != 0)
				{
				}
				num = (short)2012217345;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLCode_A9555.UIValue = value;
			}
		}

		// Token: 0x170059D7 RID: 22999
		// (get) Token: 0x0600B33B RID: 45883 RVA: 0x00A64E94 File Offset: 0x00A63094
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTxPLCode_A9555
		{
			get
			{
				short num = (short)1541578995;
				short num2 = num;
				num = (short)196649203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889257984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)897056769;
				if (num != 0)
				{
				}
				num = (short)1665466368;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555;
			}
		}

		// Token: 0x170059D8 RID: 23000
		// (get) Token: 0x0600B33C RID: 45884 RVA: 0x00A64F40 File Offset: 0x00A63140
		// (set) Token: 0x0600B33D RID: 45885 RVA: 0x00A64FF4 File Offset: 0x00A631F4
		public bool MplCfgMPLListTxPLCode_A9555_Applicable
		{
			get
			{
				short num = (short)1446565239;
				short num2 = num;
				num = (short)1305138551;
				switch (num2 == num)
				{
				default:
				{
					num = (short)846790656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348192769;
				if (num != 0)
				{
				}
				num = (short)1513160704;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.Applicable;
			}
			set
			{
				short num = (short)430395757;
				short num2 = num;
				num = (short)1696223597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)300941312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)18743296;
				if (num != 0)
				{
				}
				num = (short)150863873;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLCode_A9555.Applicable = value;
			}
		}

		// Token: 0x170059D9 RID: 23001
		// (get) Token: 0x0600B33E RID: 45886 RVA: 0x00A650A8 File Offset: 0x00A632A8
		// (set) Token: 0x0600B33F RID: 45887 RVA: 0x00A6515C File Offset: 0x00A6335C
		public bool MplCfgMPLListTxPLCode_A9555_Valid
		{
			get
			{
				short num = (short)513570212;
				short num2 = num;
				num = (short)357201316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)600440832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)861732864;
				if (num != 0)
				{
				}
				num = (short)2043215873;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.Valid;
			}
			set
			{
				short num = (short)490696885;
				short num2 = num;
				num = (short)1048211637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1289158656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1892810753;
				if (num != 0)
				{
				}
				num = (short)726204416;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLCode_A9555.Valid = value;
			}
		}

		// Token: 0x170059DA RID: 23002
		// (get) Token: 0x0600B340 RID: 45888 RVA: 0x00A65214 File Offset: 0x00A63414
		// (set) Token: 0x0600B341 RID: 45889 RVA: 0x00A652CC File Offset: 0x00A634CC
		public bool MplCfgMPLListTxPLCode_A9555_Visible
		{
			get
			{
				short num = (short)483775573;
				short num2 = num;
				num = (short)677237845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326645248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068040193;
				if (num != 0)
				{
				}
				num = (short)234553344;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.Visible;
			}
			set
			{
				short num = (short)861158123;
				short num2 = num;
				num = (short)1443379947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1025507328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375797248;
				if (num != 0)
				{
				}
				num = (short)819003393;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLCode_A9555.Visible = value;
			}
		}

		// Token: 0x170059DB RID: 23003
		// (get) Token: 0x0600B342 RID: 45890 RVA: 0x00A65384 File Offset: 0x00A63584
		// (set) Token: 0x0600B343 RID: 45891 RVA: 0x00A65438 File Offset: 0x00A63638
		public bool MplCfgMPLListTxPLCode_A9555_Editable
		{
			get
			{
				short num = (short)157199827;
				short num2 = num;
				num = (short)725462483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)907345920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)866189313;
				if (num != 0)
				{
				}
				num = (short)1949696000;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.Editable;
			}
			set
			{
				short num = (short)497287169;
				if (num != 0)
				{
				}
				num = (short)1812267008;
				short num2 = num;
				num = (short)1143971542;
				short num3 = num;
				num = (short)1607442134;
				switch (num3 == num)
				{
				}
				num = (short)78446592;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLCode_A9555.Editable = value;
			}
		}

		// Token: 0x170059DC RID: 23004
		// (get) Token: 0x0600B344 RID: 45892 RVA: 0x00A654EC File Offset: 0x00A636EC
		internal string MplCfgMPLListTxPLCode_A9555_UILabel
		{
			get
			{
				short num = (short)958237300;
				short num2 = num;
				num = (short)2008517236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119472128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1590689793;
				if (num != 0)
				{
				}
				num = (short)608305152;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.UIName;
			}
		}

		// Token: 0x170059DD RID: 23005
		// (get) Token: 0x0600B345 RID: 45893 RVA: 0x00A655A0 File Offset: 0x00A637A0
		// (set) Token: 0x0600B346 RID: 45894 RVA: 0x00A65654 File Offset: 0x00A63854
		internal bool MplCfgMPLListTxPLCode_A9555_HiddenStatic
		{
			get
			{
				short num = (short)1704853505;
				if (num != 0)
				{
				}
				num = (short)1373044736;
				short num2 = num;
				num = (short)343808085;
				short num3 = num;
				num = (short)1971066965;
				switch (num3 == num)
				{
				}
				num = (short)336003072;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.HiddenStatic;
			}
			set
			{
				short num = (short)370341228;
				short num2 = num;
				num = (short)838727020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1441005568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)927531009;
				if (num != 0)
				{
				}
				num = (short)1222639616;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLCode_A9555.HiddenStatic = value;
			}
		}

		// Token: 0x170059DE RID: 23006
		// (get) Token: 0x0600B347 RID: 45895 RVA: 0x00A6570C File Offset: 0x00A6390C
		// (set) Token: 0x0600B348 RID: 45896 RVA: 0x00A657C0 File Offset: 0x00A639C0
		internal bool MplCfgMPLListTxPLCode_A9555_HiddenDynamic
		{
			get
			{
				short num = (short)1258462110;
				short num2 = num;
				num = (short)115841950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947191808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)392626177;
				if (num != 0)
				{
				}
				num = (short)510918656;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555.HiddenDynamic;
			}
			set
			{
				short num = (short)1259419402;
				short num2 = num;
				num = (short)987903754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)752484352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1520566273;
				if (num != 0)
				{
				}
				num = (short)1181679616;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLCode_A9555.HiddenDynamic = value;
			}
		}

		// Token: 0x170059DF RID: 23007
		// (get) Token: 0x0600B349 RID: 45897 RVA: 0x00A65874 File Offset: 0x00A63A74
		public bool MplCfgMPLListTxPLCode_A9555_HasDiffs
		{
			get
			{
				short num = (short)1611266306;
				short num2 = num;
				num = (short)1136720130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)956628992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)190054401;
				if (num != 0)
				{
				}
				num = (short)518324224;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLCode_A9555._HasDiffs;
			}
		}

		// Token: 0x170059E0 RID: 23008
		// (get) Token: 0x0600B34A RID: 45898 RVA: 0x00A6592C File Offset: 0x00A63B2C
		// (set) Token: 0x0600B34B RID: 45899 RVA: 0x00A659E4 File Offset: 0x00A63BE4
		public int MplCfgMPLListTxPLFreq_A9556Value
		{
			get
			{
				short num = (short)183268893;
				short num2 = num;
				num = (short)1598780957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588461568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1760886784;
				if (num != 0)
				{
				}
				num = (short)505872385;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.Value;
			}
			set
			{
				short num = (short)221904897;
				if (num != 0)
				{
				}
				num = (short)264634368;
				short num2 = num;
				num = (short)1303266427;
				short num3 = num;
				num = (short)8930427;
				switch (num3 == num)
				{
				}
				num = (short)2014576640;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLFreq_A9556.Value = value;
			}
		}

		// Token: 0x170059E1 RID: 23009
		// (get) Token: 0x0600B34C RID: 45900 RVA: 0x00A65A9C File Offset: 0x00A63C9C
		// (set) Token: 0x0600B34D RID: 45901 RVA: 0x00A65B50 File Offset: 0x00A63D50
		public string MplCfgMPLListTxPLFreq_A9556_UIValue
		{
			get
			{
				short num = (short)114391412;
				short num2 = num;
				num = (short)241858932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1670250496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2035482625;
				if (num != 0)
				{
				}
				num = (short)500236288;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.UIValue;
			}
			set
			{
				short num = (short)1253120208;
				short num2 = num;
				num = (short)404166864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)375652352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2070740993;
				if (num != 0)
				{
				}
				num = (short)1556938752;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLFreq_A9556.UIValue = value;
			}
		}

		// Token: 0x170059E2 RID: 23010
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x00A65C04 File Offset: 0x00A63E04
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTxPLFreq_A9556
		{
			get
			{
				short num = (short)856116504;
				short num2 = num;
				num = (short)173231384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1231355904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1948909569;
				if (num != 0)
				{
				}
				num = (short)1014497280;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556;
			}
		}

		// Token: 0x170059E3 RID: 23011
		// (get) Token: 0x0600B34F RID: 45903 RVA: 0x00A65CB8 File Offset: 0x00A63EB8
		// (set) Token: 0x0600B350 RID: 45904 RVA: 0x00A65D6C File Offset: 0x00A63F6C
		public bool MplCfgMPLListTxPLFreq_A9556_Applicable
		{
			get
			{
				short num = (short)699662179;
				short num2 = num;
				num = (short)72089443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)112394240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1126957056;
				if (num != 0)
				{
				}
				num = (short)1902706689;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.Applicable;
			}
			set
			{
				short num = (short)301194441;
				short num2 = num;
				num = (short)621075657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)8847360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027211265;
				if (num != 0)
				{
				}
				num = (short)2014314496;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLFreq_A9556.Applicable = value;
			}
		}

		// Token: 0x170059E4 RID: 23012
		// (get) Token: 0x0600B351 RID: 45905 RVA: 0x00A65E24 File Offset: 0x00A64024
		// (set) Token: 0x0600B352 RID: 45906 RVA: 0x00A65ED8 File Offset: 0x00A640D8
		public bool MplCfgMPLListTxPLFreq_A9556_Valid
		{
			get
			{
				short num = (short)454480772;
				short num2 = num;
				num = (short)1618924420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)772538368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1797193728;
				if (num != 0)
				{
				}
				num = (short)1607598081;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.Valid;
			}
			set
			{
				short num = (short)1081671681;
				if (num != 0)
				{
				}
				num = (short)2051866624;
				short num2 = num;
				num = (short)40345990;
				short num3 = num;
				num = (short)1081057670;
				switch (num3 == num)
				{
				}
				num = (short)1338048512;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLFreq_A9556.Valid = value;
			}
		}

		// Token: 0x170059E5 RID: 23013
		// (get) Token: 0x0600B353 RID: 45907 RVA: 0x00A65F8C File Offset: 0x00A6418C
		// (set) Token: 0x0600B354 RID: 45908 RVA: 0x00A66040 File Offset: 0x00A64240
		public bool MplCfgMPLListTxPLFreq_A9556_Visible
		{
			get
			{
				short num = (short)413222632;
				short num2 = num;
				num = (short)984827624;
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
				num = (short)1892614144;
				if (num != 0)
				{
				}
				num = (short)771293185;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.Visible;
			}
			set
			{
				short num = (short)1698640511;
				short num2 = num;
				num = (short)1387213439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2072903680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1389428736;
				if (num != 0)
				{
				}
				num = (short)1182531585;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLFreq_A9556.Visible = value;
			}
		}

		// Token: 0x170059E6 RID: 23014
		// (get) Token: 0x0600B355 RID: 45909 RVA: 0x00A660F8 File Offset: 0x00A642F8
		// (set) Token: 0x0600B356 RID: 45910 RVA: 0x00A661B0 File Offset: 0x00A643B0
		public bool MplCfgMPLListTxPLFreq_A9556_Editable
		{
			get
			{
				short num = (short)2051211283;
				short num2 = num;
				num = (short)1148125203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1568014336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)515375104;
				if (num != 0)
				{
				}
				num = (short)2082799617;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.Editable;
			}
			set
			{
				short num = (short)1848721107;
				short num2 = num;
				num = (short)181550803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988624384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1629224960;
				if (num != 0)
				{
				}
				num = (short)806420481;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLFreq_A9556.Editable = value;
			}
		}

		// Token: 0x170059E7 RID: 23015
		// (get) Token: 0x0600B357 RID: 45911 RVA: 0x00A66268 File Offset: 0x00A64468
		internal string MplCfgMPLListTxPLFreq_A9556_UILabel
		{
			get
			{
				short num = (short)495652240;
				short num2 = num;
				num = (short)1020071312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)580386816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)154533889;
				if (num != 0)
				{
				}
				num = (short)642383872;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.UIName;
			}
		}

		// Token: 0x170059E8 RID: 23016
		// (get) Token: 0x0600B358 RID: 45912 RVA: 0x00A66320 File Offset: 0x00A64520
		// (set) Token: 0x0600B359 RID: 45913 RVA: 0x00A663D4 File Offset: 0x00A645D4
		internal bool MplCfgMPLListTxPLFreq_A9556_HiddenStatic
		{
			get
			{
				short num = (short)1145261993;
				short num2 = num;
				num = (short)598953897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246101504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1944453121;
				if (num != 0)
				{
				}
				num = (short)1599864832;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.HiddenStatic;
			}
			set
			{
				short num = (short)406545655;
				short num2 = num;
				num = (short)39937271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1955004416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)658046977;
				if (num != 0)
				{
				}
				num = (short)1000800256;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLFreq_A9556.HiddenStatic = value;
			}
		}

		// Token: 0x170059E9 RID: 23017
		// (get) Token: 0x0600B35A RID: 45914 RVA: 0x00A66488 File Offset: 0x00A64688
		// (set) Token: 0x0600B35B RID: 45915 RVA: 0x00A6653C File Offset: 0x00A6473C
		internal bool MplCfgMPLListTxPLFreq_A9556_HiddenDynamic
		{
			get
			{
				short num = (short)340656128;
				short num2 = num;
				num = (short)1396506885;
				short num3 = num;
				num = (short)1402863877;
				switch (num3 == num)
				{
				}
				num = (short)2009399296;
				if (num != 0)
				{
				}
				num = (short)1024327681;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556.HiddenDynamic;
			}
			set
			{
				short num = (short)402325504;
				short num2 = num;
				num = (short)450563838;
				short num3 = num;
				num = (short)1941835518;
				switch (num3 == num)
				{
				}
				num = (short)2067988481;
				if (num != 0)
				{
				}
				num = (short)1730936832;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxPLFreq_A9556.HiddenDynamic = value;
			}
		}

		// Token: 0x170059EA RID: 23018
		// (get) Token: 0x0600B35C RID: 45916 RVA: 0x00A665F0 File Offset: 0x00A647F0
		public bool MplCfgMPLListTxPLFreq_A9556_HasDiffs
		{
			get
			{
				short num = (short)415956992;
				short num2 = num;
				num = (short)1189286951;
				short num3 = num;
				num = (short)1827476519;
				switch (num3 == num)
				{
				}
				num = (short)864288769;
				if (num != 0)
				{
				}
				num = (short)857538560;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxPLFreq_A9556._HasDiffs;
			}
		}

		// Token: 0x170059EB RID: 23019
		// (get) Token: 0x0600B35D RID: 45917 RVA: 0x00A666A8 File Offset: 0x00A648A8
		// (set) Token: 0x0600B35E RID: 45918 RVA: 0x00A6675C File Offset: 0x00A6495C
		public int MplCfgMPLListTxSquelchType_A9567Value
		{
			get
			{
				short num = (short)316014592;
				short num2 = num;
				num = (short)1820413035;
				short num3 = num;
				num = (short)1488735339;
				switch (num3 == num)
				{
				}
				num = (short)571146240;
				if (num != 0)
				{
				}
				num = (short)695140353;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.Value;
			}
			set
			{
				short num = (short)1143472128;
				short num2 = num;
				num = (short)252882675;
				short num3 = num;
				num = (short)1962585843;
				switch (num3 == num)
				{
				}
				num = (short)764280833;
				if (num != 0)
				{
				}
				num = (short)793313280;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxSquelchType_A9567.Value = value;
			}
		}

		// Token: 0x170059EC RID: 23020
		// (get) Token: 0x0600B35F RID: 45919 RVA: 0x00A66810 File Offset: 0x00A64A10
		// (set) Token: 0x0600B360 RID: 45920 RVA: 0x00A668C4 File Offset: 0x00A64AC4
		public string MplCfgMPLListTxSquelchType_A9567_UIValue
		{
			get
			{
				short num = (short)660865024;
				short num2 = num;
				num = (short)1664033513;
				short num3 = num;
				num = (short)1554391785;
				switch (num3 == num)
				{
				}
				num = (short)831651841;
				if (num != 0)
				{
				}
				num = (short)792788992;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.UIValue;
			}
			set
			{
				short num = (short)1267007488;
				short num2 = num;
				num = (short)1889322992;
				short num3 = num;
				num = (short)1283311600;
				switch (num3 == num)
				{
				}
				num = (short)1330839552;
				if (num != 0)
				{
				}
				num = (short)1509752833;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxSquelchType_A9567.UIValue = value;
			}
		}

		// Token: 0x170059ED RID: 23021
		// (get) Token: 0x0600B361 RID: 45921 RVA: 0x00A6697C File Offset: 0x00A64B7C
		public global::AcpBusinessLayer.AcpListField MplCfgMPLListTxSquelchType_A9567
		{
			get
			{
				short num = (short)1403584512;
				short num2 = num;
				num = (short)2012037843;
				short num3 = num;
				num = (short)282346195;
				switch (num3 == num)
				{
				}
				num = (short)426508289;
				if (num != 0)
				{
				}
				num = (short)1212874752;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567;
			}
		}

		// Token: 0x170059EE RID: 23022
		// (get) Token: 0x0600B362 RID: 45922 RVA: 0x00A66A2C File Offset: 0x00A64C2C
		// (set) Token: 0x0600B363 RID: 45923 RVA: 0x00A66AE0 File Offset: 0x00A64CE0
		public bool MplCfgMPLListTxSquelchType_A9567_Applicable
		{
			get
			{
				short num = (short)1078394880;
				short num2 = num;
				num = (short)1936388212;
				short num3 = num;
				num = (short)1875964020;
				switch (num3 == num)
				{
				}
				num = (short)2138177536;
				if (num != 0)
				{
				}
				num = (short)992935937;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.Applicable;
			}
			set
			{
				short num = (short)1322844160;
				short num2 = num;
				num = (short)428810451;
				short num3 = num;
				num = (short)1582702803;
				switch (num3 == num)
				{
				}
				num = (short)1767833601;
				if (num != 0)
				{
				}
				num = (short)282132480;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxSquelchType_A9567.Applicable = value;
			}
		}

		// Token: 0x170059EF RID: 23023
		// (get) Token: 0x0600B364 RID: 45924 RVA: 0x00A66B94 File Offset: 0x00A64D94
		// (set) Token: 0x0600B365 RID: 45925 RVA: 0x00A66C48 File Offset: 0x00A64E48
		public bool MplCfgMPLListTxSquelchType_A9567_Valid
		{
			get
			{
				short num = (short)1510211584;
				short num2 = num;
				num = (short)570884097;
				if (num != 0)
				{
				}
				num = (short)295030540;
				short num3 = num;
				num = (short)990891788;
				switch (num3 == num)
				{
				}
				num = (short)916914176;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.Valid;
			}
			set
			{
				short num = (short)610402304;
				short num2 = num;
				num = (short)1071510870;
				short num3 = num;
				num = (short)149878102;
				switch (num3 == num)
				{
				}
				num = (short)1269694465;
				if (num != 0)
				{
				}
				num = (short)503578624;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxSquelchType_A9567.Valid = value;
			}
		}

		// Token: 0x170059F0 RID: 23024
		// (get) Token: 0x0600B366 RID: 45926 RVA: 0x00A66D00 File Offset: 0x00A64F00
		// (set) Token: 0x0600B367 RID: 45927 RVA: 0x00A66DB4 File Offset: 0x00A64FB4
		public bool MplCfgMPLListTxSquelchType_A9567_Visible
		{
			get
			{
				short num = (short)736493568;
				short num2 = num;
				num = (short)439877633;
				if (num != 0)
				{
				}
				num = (short)428558171;
				short num3 = num;
				num = (short)1181435739;
				switch (num3 == num)
				{
				}
				num = (short)1853882368;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.Visible;
			}
			set
			{
				short num = (short)2097807360;
				short num2 = num;
				num = (short)2144966010;
				short num3 = num;
				num = (short)1405982074;
				switch (num3 == num)
				{
				}
				num = (short)1194590209;
				if (num != 0)
				{
				}
				num = (short)1797390336;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxSquelchType_A9567.Visible = value;
			}
		}

		// Token: 0x170059F1 RID: 23025
		// (get) Token: 0x0600B368 RID: 45928 RVA: 0x00A66E6C File Offset: 0x00A6506C
		// (set) Token: 0x0600B369 RID: 45929 RVA: 0x00A66F20 File Offset: 0x00A65120
		public bool MplCfgMPLListTxSquelchType_A9567_Editable
		{
			get
			{
				short num = (short)477691904;
				short num2 = num;
				num = (short)1936652622;
				short num3 = num;
				num = (short)294123854;
				switch (num3 == num)
				{
				}
				num = (short)824705025;
				if (num != 0)
				{
				}
				num = (short)1074266112;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.Editable;
			}
			set
			{
				short num = (short)1586429952;
				short num2 = num;
				num = (short)454696241;
				short num3 = num;
				num = (short)1058544945;
				switch (num3 == num)
				{
				}
				num = (short)1659830272;
				if (num != 0)
				{
				}
				num = (short)2100822017;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxSquelchType_A9567.Editable = value;
			}
		}

		// Token: 0x170059F2 RID: 23026
		// (get) Token: 0x0600B36A RID: 45930 RVA: 0x00A66FD8 File Offset: 0x00A651D8
		internal string MplCfgMPLListTxSquelchType_A9567_UILabel
		{
			get
			{
				short num = (short)1875312640;
				short num2 = num;
				num = (short)478110408;
				short num3 = num;
				num = (short)1667850952;
				switch (num3 == num)
				{
				}
				num = (short)1412497409;
				if (num != 0)
				{
				}
				num = (short)1171718144;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.UIName;
			}
		}

		// Token: 0x170059F3 RID: 23027
		// (get) Token: 0x0600B36B RID: 45931 RVA: 0x00A6708C File Offset: 0x00A6528C
		// (set) Token: 0x0600B36C RID: 45932 RVA: 0x00A67140 File Offset: 0x00A65340
		internal bool MplCfgMPLListTxSquelchType_A9567_HiddenStatic
		{
			get
			{
				short num = (short)613220352;
				short num2 = num;
				num = (short)2023949040;
				short num3 = num;
				num = (short)1636565744;
				switch (num3 == num)
				{
				}
				num = (short)1852375040;
				if (num != 0)
				{
				}
				num = (short)764280833;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.HiddenStatic;
			}
			set
			{
				short num = (short)1910374400;
				short num2 = num;
				num = (short)1222805874;
				short num3 = num;
				num = (short)1697810802;
				switch (num3 == num)
				{
				}
				num = (short)1852833793;
				if (num != 0)
				{
				}
				num = (short)1219887104;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxSquelchType_A9567.HiddenStatic = value;
			}
		}

		// Token: 0x170059F4 RID: 23028
		// (get) Token: 0x0600B36D RID: 45933 RVA: 0x00A671F8 File Offset: 0x00A653F8
		// (set) Token: 0x0600B36E RID: 45934 RVA: 0x00A672B0 File Offset: 0x00A654B0
		internal bool MplCfgMPLListTxSquelchType_A9567_HiddenDynamic
		{
			get
			{
				short num = (short)246480896;
				short num2 = num;
				num = (short)726712819;
				short num3 = num;
				num = (short)780124659;
				switch (num3 == num)
				{
				}
				num = (short)2067202049;
				if (num != 0)
				{
				}
				num = (short)871563264;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567.HiddenDynamic;
			}
			set
			{
				short num = (short)235143168;
				short num2 = num;
				num = (short)1036320769;
				if (num != 0)
				{
				}
				num = (short)190910225;
				short num3 = num;
				num = (short)1842745105;
				switch (num3 == num)
				{
				}
				num = (short)1773404160;
				if (num != 0)
				{
				}
				this.mplCfgMPLListTxSquelchType_A9567.HiddenDynamic = value;
			}
		}

		// Token: 0x170059F5 RID: 23029
		// (get) Token: 0x0600B36F RID: 45935 RVA: 0x00A67364 File Offset: 0x00A65564
		public bool MplCfgMPLListTxSquelchType_A9567_HasDiffs
		{
			get
			{
				short num = (short)883884032;
				short num2 = num;
				num = (short)979253437;
				short num3 = num;
				num = (short)232339645;
				switch (num3 == num)
				{
				}
				num = (short)1226244096;
				if (num != 0)
				{
				}
				num = (short)974192641;
				if (num != 0)
				{
				}
				return this.mplCfgMPLListTxSquelchType_A9567._HasDiffs;
			}
		}

		// Token: 0x170059F6 RID: 23030
		// (get) Token: 0x0600B370 RID: 45936 RVA: 0x00A6741C File Offset: 0x00A6561C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide RefConventionalWide
		{
			get
			{
				short num = (short)811466752;
				short num2 = num;
				num = (short)27275190;
				short num3 = num;
				num = (short)1869492150;
				switch (num3 == num)
				{
				}
				num = (short)1530920961;
				if (num != 0)
				{
				}
				num = (short)449314816;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2024)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide;
			}
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x00A674DC File Offset: 0x00A656DC
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
						num2 = (short)369164290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_144;
				case 1:
					goto IL_B3;
				case 2:
					num2 = (short)2019753987;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						goto IL_144;
					}
					num2 = (short)1986777026;
					short num3 = num2;
					num2 = (short)808701890;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B3;
					default:
						num2 = (short)1762590720;
						if (num2 != 0)
						{
						}
						num2 = (short)1094057988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1865940993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_B3:
			IL_144:
			num2 = (short)780992513;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			num2 = (short)15466496;
			short num4 = num2;
			result = null;
			num2 = (short)1298726912;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005798 RID: 22424
		private global::AcpBusinessLayer.AcpKeyField mplCfgMPLListMPLAlias_A8548;

		// Token: 0x04005799 RID: 22425
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListRxDPLCode_A9008;

		// Token: 0x0400579A RID: 22426
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListRxDPLInvert_A9009;

		// Token: 0x0400579B RID: 22427
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListRxPLCode_A9026;

		// Token: 0x0400579C RID: 22428
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListRxPLFreq_A9027;

		// Token: 0x0400579D RID: 22429
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListRxSquelchType_A9028;

		// Token: 0x0400579E RID: 22430
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTADPLCode_A9257;

		// Token: 0x0400579F RID: 22431
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTADPLInvert_A9258;

		// Token: 0x040057A0 RID: 22432
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTAPLCode_A9262;

		// Token: 0x040057A1 RID: 22433
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTAPLFreq_A9263;

		// Token: 0x040057A2 RID: 22434
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTASquelchType_A9266;

		// Token: 0x040057A3 RID: 22435
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTxDPLCode_A9527;

		// Token: 0x040057A4 RID: 22436
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTxDPLInvert_A9528;

		// Token: 0x040057A5 RID: 22437
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTxPLCode_A9555;

		// Token: 0x040057A6 RID: 22438
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTxPLFreq_A9556;

		// Token: 0x040057A7 RID: 22439
		private global::AcpBusinessLayer.AcpListField mplCfgMPLListTxSquelchType_A9567;
	}
}
