using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003BE RID: 958
	[global::System.Serializable]
	public class DataButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060089A7 RID: 35239 RVA: 0x0080C7F0 File Offset: 0x0080A9F0
		public DataButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x0080C80C File Offset: 0x0080AA0C
		protected DataButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x0080C824 File Offset: 0x0080AA24
		public override void Init()
		{
			int a_ = 16;
			short num = (short)1611534160;
			short num2 = num;
			num = (short)1832128336;
			switch (num2 == num)
			{
			}
			num = (short)1710882817;
			if (num != 0)
			{
			}
			num = (short)772276224;
			if (num != 0)
			{
			}
			num = (short)1338048512;
			short num3 = num;
			this.cntrlHeadO3DataButtonKey_A22590 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꇔꗖ뗘鏚룜뻞藠곢훤ꏦ裨鿪賬귮蓰蟲致飶韸냺飼蛾帀䈂㜄㔆㰈㈊㴌", a_), global::CommonResources.AcgResources.ID_KEY, 20);
			this.cntrlHeadO3DataButtonKey_A22590.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cntrlHeadO3DataButtonKey_A22590.DataTransferOrder = -1;
			this.cntrlHeadO3DataButtonName_A22591 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꇔꗖ뗘鏚룜뻞藠곢훤ꏦ裨鿪賬귮蓰蟲致飶韸뗺鳼鋾搀専䐄㔆㬈㸊㐌㸎", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cntrlHeadO3DataButtonName_A22591.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cntrlHeadO3DataButtonName_A22591.DataTransferOrder = -1;
			this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3ConventionalO3DataButtonBCO_A22592LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3ConventionalO3DataButtonBCO_A22592LovStrs), this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꇔꗖ뗘鏚룜뻞藠곢훤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼냾㈀䜂搄猆栈䤊砌笎攐簒笔唖娘吚䈜帞ጠᄢဤḦᬨ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3ConventionalO3DataButtonBCO_A22592LovStrs);
			this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.DataTransferOrder = -1;
			this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3ConventionalO3DatatButtonFeature_A22595LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3ConventionalO3DatatButtonFeature_A22595LovStrs), this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꇔꗖ뗘鏚룜뻞藠곢훤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼냾㈀䜂搄猆栈缊伌税攐朒稔礖弘縚簜欞吠儢䀤砦栨ᤪἬᨮ࠰ز", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595LovStrs);
			this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.DataTransferOrder = 10;
			this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3TrunkingO3DataButtonBCO_A22596LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3TrunkingO3DataButtonBCO_A22596LovStrs), this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꇔꗖ뗘鏚룜뻞藠곢훤돦鯨黪菬蓮飰鷲鋴룶쫸뿺鳼课怀䄂瀄猆紈搊挌䴎刐尒䨔嘖⬘⤚⠜☞ᜠ", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3TrunkingO3DataButtonBCO_A22596LovStrs);
			this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.DataTransferOrder = -1;
			this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3TrunkingO3DatatButtonFeature_A22597LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3TrunkingO3DatatButtonFeature_A22597LovStrs), this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꇔꗖ뗘鏚룜뻞藠곢훤돦鯨黪菬蓮飰鷲鋴룶쫸뿺鳼课怀眂䜄爆紈缊戌愎圐瘒琔挖氘椚砜䀞怠ᄢᜤሦဨᰪ", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597LovStrs);
			this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.DataTransferOrder = 12;
			this.cHO3DataButtonConvIndex_A41419 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鋐鯒體鷘뫚꧜뻞ꏠ離釤鏦蛨藪껬胮鿰藲보駶鷸黺藼ꃾ䀀㜂㐄㌆㠈㈊", a_), global::CommonResources.AcgResources.ID_CONVENTIONALINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO3DataButtonConvIndex_A41419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO3DataButtonConvIndex_A41419.DataTransferOrder = 11;
			this.cHO3DataButtonTrkIndex_A41420 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鋐鯒體鷘뫚꧜뻞ꏠ離釤鏦蛨藪맬鷮髰뫲鯴鏶鳸菺ꋼ뻾㔀㈂㄄㔆㤈", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO3DataButtonTrkIndex_A41420.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO3DataButtonTrkIndex_A41420.DataTransferOrder = 13;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黐鏖룘꿚볜￞ꏠ離釤鏦蛨藪", a_);
			base.Id = 10212;
			base.UIName = global::CommonResources.AcgResources.ID_O3DATABUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x0080CB5C File Offset: 0x0080AD5C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)112918553;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cHO3DataButtonConvIndex_A41419 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金鳓駕黙뷛ꫝ臟ꃡ釣鋥鳧藩苫귭鿯鳱苳뿵雷黹駻蛽忿䌁〃㜅㰇㬉㔋", a_), global::CommonResources.AcgResources.ID_CONVENTIONALINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO3DataButtonConvIndex_A41419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO3DataButtonConvIndex_A41419.DataTransferOrder = 11;
					num = (short)709885978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_C6;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥ꯧ藩苫飭闯鳱胳鿵韷铹鷻鋽俿㄁䀃朅簇欉下笍搏昑笓砕娗夙匛䄝感အᘣጥᄧᠩ", a_)))
					{
						num = (short)1731264539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36C;
				case 3:
					this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3ConventionalO3DatatButtonFeature_A22595LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3ConventionalO3DatatButtonFeature_A22595LovStrs), this, global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥ꯧ藩苫飭闯鳱胳鿵韷铹鷻鋽俿㄁䀃朅簇欉砋䰍攏昑怓礕瘗尙礛缝吟圡嘣䌥眧欩ḫᰭԯ଱ĳ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595LovStrs);
					this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.DataTransferOrder = 10;
					num = (short)130088968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)92982036;
					short num3 = num;
					num = (short)1381550868;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_514;
					default:
						num = (short)491782144;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥ꯧ藩苫飭闯鳱胳鿵韷铹鷻鋽俿㄁䀃朅簇欉砋䰍攏昑怓礕瘗尙礛缝吟圡嘣䌥眧欩ḫᰭԯ଱ĳ", a_)))
						{
							num = (short)1491140611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_113;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金鳓駕黙뷛ꫝ臟ꃡ釣鋥鳧藩苫귭鿯鳱苳뿵雷黹駻蛽忿䌁〃㜅㰇㬉㔋", a_)))
					{
						num = (short)847446016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F9;
				case 6:
					num = (short)609812498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields != null)
					{
						num = (short)462684166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73A;
				case 8:
					goto IL_113;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥볧飩駫胭鯯鯱髳釵럷짹룻鿽瓿持瀃䐅紇縉砋愍縏向焓眕気漙減笝缟挡ᘣᐥᴧጩᬫ", a_)))
					{
						num = (short)1906507787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45E;
				case 10:
				{
					num = (short)1347289088;
					short num4 = num;
					this.cntrlHeadO3DataButtonKey_A22590 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥곧诩飫迭닯蟱胳苵韷铹럻鯽秿崁䔃㐅㨇㼉㔋㸍", a_), global::CommonResources.AcgResources.ID_KEY, 20);
					this.cntrlHeadO3DataButtonKey_A22590.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cntrlHeadO3DataButtonKey_A22590.DataTransferOrder = -1;
					num = (short)1355874323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3TrunkingO3DatatButtonFeature_A22597LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3TrunkingO3DatatButtonFeature_A22597LovStrs), this, global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥볧飩駫胭鯯鯱髳釵럷짹룻鿽瓿持瀃䐅紇縉砋愍縏向焓眕気漙減笝缟挡ᘣᐥᴧጩᬫ", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597LovStrs);
					this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.DataTransferOrder = 12;
					num = (short)28508173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3TrunkingO3DataButtonBCO_A22596LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3TrunkingO3DataButtonBCO_A22596LovStrs), this, global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥볧飩駫胭鯯鯱髳釵럷짹룻鿽瓿持䘃猅簇縉挋怍刏儑嬓䤕夗⠙⸛⬝᤟ᐡ", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3TrunkingO3DataButtonBCO_A22596LovStrs);
					this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.DataTransferOrder = -1;
					num = (short)643235841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_45E;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金鳓駕黙뷛ꫝ臟ꃡ釣鋥鳧藩苫뫭苯駱뷳飵鳷鿹蓻ꇽ䇿㘁㔃㈅㨇㨉", a_)))
					{
						num = (short)550371345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73A;
				case 15:
					goto IL_50F;
				case 16:
					num = (short)1505689607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.cHO3DataButtonTrkIndex_A41420 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金鳓駕黙뷛ꫝ臟ꃡ釣鋥鳧藩苫뫭苯駱뷳飵鳷鿹蓻ꇽ䇿㘁㔃㈅㨇㨉", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO3DataButtonTrkIndex_A41420.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO3DataButtonTrkIndex_A41420.DataTransferOrder = 13;
					num = (short)1144520719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥곧诩飫迭닯蟱胳苵韷铹럻鯽秿崁䔃㐅㨇㼉㔋㸍", a_)))
					{
						num = (short)823394314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				case 19:
					goto IL_15C;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥곧诩飫迭닯蟱胳苵韷铹닻鿽淿朁嬃䜅㨇㠉㤋㜍ℏ", a_)))
					{
						num = (short)817496086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_514;
				case 21:
					goto IL_514;
				case 22:
					this.cntrlHeadO3DataButtonName_A22591 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥곧诩飫迭닯蟱胳苵韷铹닻鿽淿朁嬃䜅㨇㠉㤋㜍ℏ", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cntrlHeadO3DataButtonName_A22591.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cntrlHeadO3DataButtonName_A22591.DataTransferOrder = -1;
					num = (short)1272709141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_36C;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥볧飩駫胭鯯鯱髳釵럷짹룻鿽瓿持䘃猅簇縉挋怍刏儑嬓䤕夗⠙⸛⬝᤟ᐡ", a_)))
					{
						num = (short)1843265548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C6;
				case 25:
					switch (0)
					{
					case 0:
						goto IL_9E;
					}
					continue;
				case 26:
					goto IL_2F9;
				case 27:
					this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3ConventionalO3DataButtonBCO_A22592LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3ConventionalO3DataButtonBCO_A22592LovStrs), this, global::AllFeatures.CodeplugGuid.b("金뫓ꋕ꫗뛙铛믝臟蛡ꯣ헥ꯧ藩苫飭闯鳱胳鿵韷铹鷻鋽俿㄁䀃朅簇欉下笍搏昑笓砕娗夙匛䄝感အᘣጥᄧᠩ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3ConventionalO3DataButtonBCO_A22592LovStrs);
					this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.DataTransferOrder = -1;
					num = (short)438108183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)378404880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C6:
				num = (short)377225225;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_113:
				num = (short)471334936;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15C:
				num = (short)2010251284;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F9:
				num = (short)28835841;
				if (num != 0)
				{
				}
				num = (short)235470862;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36C:
				num = (short)1682046980;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45E:
				num = (short)1446903813;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_514:
				num = (short)1644363778;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_50F:
			IL_73A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷑鳗믙꣛뿝샟ꃡ釣鋥鳧藩苫", a_);
			base.Id = 10212;
			base.UIName = global::CommonResources.AcgResources.ID_O3DATABUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x0080D2D4 File Offset: 0x0080B4D4
		public override void PopulateReferences()
		{
			short num = (short)2016870401;
			if (num != 0)
			{
			}
			num = (short)1807140818;
			short num2 = num;
			num = (short)1923598290;
			switch (num2 == num)
			{
			}
			num = (short)553320448;
			if (num != 0)
			{
			}
			num = (short)141361152;
			short num3 = num;
			this.cHO3DataButtonConvIndex_A41419.SetRecset(this.a(4008));
			this.cHO3DataButtonTrkIndex_A41420.SetRecset(this.a(4008));
		}

		// Token: 0x060089AC RID: 35244 RVA: 0x0080D3AC File Offset: 0x0080B5AC
		public override void DropReferences()
		{
			short num = (short)1901939104;
			short num2 = num;
			num = (short)357714336;
			switch (num2 == num)
			{
			}
			num = (short)1727594496;
			if (num != 0)
			{
			}
			num = (short)1438449665;
			if (num != 0)
			{
			}
			num = (short)502857728;
			short num3 = num;
		}

		// Token: 0x060089AD RID: 35245 RVA: 0x0080D458 File Offset: 0x0080B658
		public override void SetConstraints()
		{
			short num = (short)889781633;
			short num2 = num;
			num = (short)617414017;
			switch (num2 == num)
			{
			}
			num = (short)585236481;
			if (num != 0)
			{
			}
			num = (short)1424490496;
			if (num != 0)
			{
			}
			num = (short)332398592;
			short num3 = num;
			this.cntrlHeadO3DataButtonName_A22591.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConStandaloneRadioSystemEnableApp);
			this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.conDataBtnConvFeatureValid);
			this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConSyncCnvDataBtnFeature);
			this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConStandaloneRadioSystemEnableApp);
			this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.conDataBtnTrkFeatureValid);
			this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConSyncTrkDataBtnFeature);
			this.cHO3DataButtonConvIndex_A41419.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConO3DataButtonConvIndexApplicable);
			this.cHO3DataButtonConvIndex_A41419.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConDataButtonIndexValid);
			this.cHO3DataButtonConvIndex_A41419.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConValueSetIfDataCnvIndexChanged);
			this.cHO3DataButtonTrkIndex_A41420.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConO3DataButtonTrkIndexApplicable);
			this.cHO3DataButtonTrkIndex_A41420.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConDataButtonIndexValid);
			this.cHO3DataButtonTrkIndex_A41420.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConValueSetIfDataTrkIndexChanged);
		}

		// Token: 0x060089AE RID: 35246 RVA: 0x0080D62C File Offset: 0x0080B82C
		public override void SetupDependencies()
		{
			short num = (short)1022581631;
			short num2 = num;
			num = (short)722951039;
			switch (num2 == num)
			{
			}
			num = (short)179765248;
			if (num != 0)
			{
			}
			num = (short)1473052673;
			if (num != 0)
			{
			}
			num = (short)1449918464;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597);
			this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.AddDependentObject(this.cHO3DataButtonConvIndex_A41419);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO3DataButtonConvIndex_A41419);
			this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.AddDependentObject(this.cHO3DataButtonTrkIndex_A41420);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO3DataButtonTrkIndex_A41420);
		}

		// Token: 0x170045CB RID: 17867
		// (get) Token: 0x060089AF RID: 35247 RVA: 0x0080D768 File Offset: 0x0080B968
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForCHO3DataButtonConvIndex_A41419
		{
			get
			{
				short num = (short)1244910038;
				short num2 = num;
				num = (short)509661654;
				switch (num2 == num)
				{
				}
				num = (short)486932481;
				if (num != 0)
				{
				}
				num = (short)568918016;
				if (num != 0)
				{
				}
				num = (short)1562705920;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x170045CC RID: 17868
		// (get) Token: 0x060089B0 RID: 35248 RVA: 0x0080D820 File Offset: 0x0080BA20
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForCHO3DataButtonTrkIndex_A41420
		{
			get
			{
				short num = (short)1377542394;
				short num2 = num;
				num = (short)1470865658;
				switch (num2 == num)
				{
				}
				num = (short)117309441;
				if (num != 0)
				{
				}
				num = (short)93454336;
				if (num != 0)
				{
				}
				num = (short)1691353088;
				short num3 = num;
				return this.cHO3DataButtonTrkIndex_A41420.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x170045CD RID: 17869
		// (get) Token: 0x060089B1 RID: 35249 RVA: 0x0080D8D8 File Offset: 0x0080BAD8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1175361240;
				short num2 = num;
				num = (short)1014798040;
				switch (num2 == num)
				{
				}
				num = (short)1718747137;
				if (num != 0)
				{
				}
				num = (short)501874688;
				if (num != 0)
				{
				}
				num = (short)331808768;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170045CE RID: 17870
		// (get) Token: 0x060089B2 RID: 35250 RVA: 0x0080D988 File Offset: 0x0080BB88
		// (set) Token: 0x060089B3 RID: 35251 RVA: 0x0080DA3C File Offset: 0x0080BC3C
		public string CntrlHeadO3DataButtonKey_A22590Value
		{
			get
			{
				short num = (short)1365192073;
				short num2 = num;
				num = (short)1597910409;
				switch (num2 == num)
				{
				}
				num = (short)958136321;
				if (num != 0)
				{
				}
				num = (short)99287040;
				if (num != 0)
				{
				}
				num = (short)449314816;
				short num3 = num;
				return this.cntrlHeadO3DataButtonKey_A22590.Value;
			}
			set
			{
				short num = (short)1034878978;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)241512740;
						short num3 = num;
						num = (short)2074882340;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1427570688;
							if (num != 0)
							{
							}
							num = (short)1449656321;
							if (num != 0)
							{
							}
							this.cntrlHeadO3DataButtonKey_A22590.Value = value;
							num = (short)293863425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1723662336;
					short num4 = num;
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1910898688;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170045CF RID: 17871
		// (get) Token: 0x060089B4 RID: 35252 RVA: 0x0080DB64 File Offset: 0x0080BD64
		// (set) Token: 0x060089B5 RID: 35253 RVA: 0x0080DC1C File Offset: 0x0080BE1C
		public string CntrlHeadO3DataButtonKey_A22590_UIValue
		{
			get
			{
				short num = (short)637887942;
				short num2 = num;
				num = (short)848455110;
				switch (num2 == num)
				{
				}
				num = (short)1925251072;
				short num3 = num;
				num = (short)355729408;
				if (num != 0)
				{
				}
				num = (short)2133131265;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590.Value;
			}
			set
			{
				short num = (short)832500183;
				short num2 = num;
				num = (short)1476719063;
				switch (num2 == num)
				{
				}
				num = (short)741539840;
				short num3 = num;
				num = (short)925958144;
				if (num != 0)
				{
				}
				num = (short)898367489;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonKey_A22590.Value = value;
			}
		}

		// Token: 0x170045D0 RID: 17872
		// (get) Token: 0x060089B6 RID: 35254 RVA: 0x0080DCD4 File Offset: 0x0080BED4
		public global::AcpBusinessLayer.AcpKeyField CntrlHeadO3DataButtonKey_A22590
		{
			get
			{
				short num = (short)3670317;
				short num2 = num;
				num = (short)61800749;
				switch (num2 == num)
				{
				}
				num = (short)1698365440;
				short num3 = num;
				num = (short)493027329;
				if (num != 0)
				{
				}
				num = (short)1182334976;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590;
			}
		}

		// Token: 0x170045D1 RID: 17873
		// (get) Token: 0x060089B7 RID: 35255 RVA: 0x0080DD84 File Offset: 0x0080BF84
		// (set) Token: 0x060089B8 RID: 35256 RVA: 0x0080DE3C File Offset: 0x0080C03C
		public bool CntrlHeadO3DataButtonKey_A22590_Applicable
		{
			get
			{
				short num = (short)1634037073;
				short num2 = num;
				num = (short)720530769;
				switch (num2 == num)
				{
				}
				num = (short)496893952;
				short num3 = num;
				num = (short)799735808;
				if (num != 0)
				{
				}
				num = (short)860160001;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590.Applicable;
			}
			set
			{
				short num = (short)800421044;
				short num2 = num;
				num = (short)642806964;
				switch (num2 == num)
				{
				}
				num = (short)994967552;
				short num3 = num;
				num = (short)2014969856;
				if (num != 0)
				{
				}
				num = (short)1880096769;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonKey_A22590.Applicable = value;
			}
		}

		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x060089B9 RID: 35257 RVA: 0x0080DEF0 File Offset: 0x0080C0F0
		// (set) Token: 0x060089BA RID: 35258 RVA: 0x0080DFA4 File Offset: 0x0080C1A4
		public bool CntrlHeadO3DataButtonKey_A22590_Valid
		{
			get
			{
				short num = (short)1790312449;
				if (num != 0)
				{
				}
				num = (short)1328820727;
				short num2 = num;
				num = (short)2120298999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)841154560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348848128;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590.Valid;
			}
			set
			{
				short num = (short)823809267;
				short num2 = num;
				num = (short)598496499;
				switch (num2 == num)
				{
				}
				num = (short)1935867904;
				short num3 = num;
				num = (short)1080098816;
				if (num != 0)
				{
				}
				num = (short)568262657;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonKey_A22590.Valid = value;
			}
		}

		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x060089BB RID: 35259 RVA: 0x0080E060 File Offset: 0x0080C260
		// (set) Token: 0x060089BC RID: 35260 RVA: 0x0080E118 File Offset: 0x0080C318
		public bool CntrlHeadO3DataButtonKey_A22590_Visible
		{
			get
			{
				short num = (short)1001142230;
				short num2 = num;
				num = (short)92682198;
				switch (num2 == num)
				{
				}
				num = (short)376242176;
				short num3 = num;
				num = (short)551878656;
				if (num != 0)
				{
				}
				num = (short)828637185;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590.Visible;
			}
			set
			{
				short num = (short)1171183792;
				short num2 = num;
				num = (short)534239408;
				switch (num2 == num)
				{
				}
				num = (short)184942592;
				short num3 = num;
				num = (short)1830289409;
				if (num != 0)
				{
				}
				num = (short)73007104;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonKey_A22590.Visible = value;
			}
		}

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x060089BD RID: 35261 RVA: 0x0080E1D0 File Offset: 0x0080C3D0
		// (set) Token: 0x060089BE RID: 35262 RVA: 0x0080E284 File Offset: 0x0080C484
		public bool CntrlHeadO3DataButtonKey_A22590_Editable
		{
			get
			{
				short num = (short)1303143645;
				short num2 = num;
				num = (short)1849779421;
				switch (num2 == num)
				{
				}
				num = (short)607715328;
				short num3 = num;
				num = (short)1868169217;
				if (num != 0)
				{
				}
				num = (short)318767104;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590.Editable;
			}
			set
			{
				short num = (short)77210151;
				short num2 = num;
				num = (short)564929063;
				switch (num2 == num)
				{
				}
				num = (short)178716672;
				short num3 = num;
				num = (short)1678311425;
				if (num != 0)
				{
				}
				num = (short)1711210496;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonKey_A22590.Editable = value;
			}
		}

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x060089BF RID: 35263 RVA: 0x0080E33C File Offset: 0x0080C53C
		internal string CntrlHeadO3DataButtonKey_A22590_UILabel
		{
			get
			{
				short num = (short)1943507925;
				short num2 = num;
				num = (short)2117374933;
				switch (num2 == num)
				{
				}
				num = (short)1991770112;
				short num3 = num;
				num = (short)463863809;
				if (num != 0)
				{
				}
				num = (short)415105024;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590.UIName;
			}
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x060089C0 RID: 35264 RVA: 0x0080E3F0 File Offset: 0x0080C5F0
		// (set) Token: 0x060089C1 RID: 35265 RVA: 0x0080E4A8 File Offset: 0x0080C6A8
		internal bool CntrlHeadO3DataButtonKey_A22590_HiddenStatic
		{
			get
			{
				short num = (short)1852839269;
				short num2 = num;
				num = (short)2078741861;
				switch (num2 == num)
				{
				}
				num = (short)2010120192;
				short num3 = num;
				num = (short)160956417;
				if (num != 0)
				{
				}
				num = (short)1896218624;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590.HiddenStatic;
			}
			set
			{
				short num = (short)1885165615;
				short num2 = num;
				num = (short)608852015;
				switch (num2 == num)
				{
				}
				num = (short)1946746880;
				short num3 = num;
				num = (short)327745536;
				if (num != 0)
				{
				}
				num = (short)1699020801;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonKey_A22590.HiddenStatic = value;
			}
		}

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x060089C2 RID: 35266 RVA: 0x0080E558 File Offset: 0x0080C758
		// (set) Token: 0x060089C3 RID: 35267 RVA: 0x0080E60C File Offset: 0x0080C80C
		internal bool CntrlHeadO3DataButtonKey_A22590_HiddenDynamic
		{
			get
			{
				short num = (short)581554580;
				short num2 = num;
				num = (short)1297994132;
				switch (num2 == num)
				{
				}
				num = (short)594870272;
				short num3 = num;
				num = (short)209453057;
				if (num != 0)
				{
				}
				num = (short)1726808064;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590.HiddenDynamic;
			}
			set
			{
				short num = (short)426720666;
				short num2 = num;
				num = (short)1477918106;
				switch (num2 == num)
				{
				}
				num = (short)1179779072;
				short num3 = num;
				num = (short)910753792;
				if (num != 0)
				{
				}
				num = (short)1228406785;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonKey_A22590.HiddenDynamic = value;
			}
		}

		// Token: 0x170045D8 RID: 17880
		// (get) Token: 0x060089C4 RID: 35268 RVA: 0x0080E6C4 File Offset: 0x0080C8C4
		public bool CntrlHeadO3DataButtonKey_A22590_HasDiffs
		{
			get
			{
				short num = (short)1940162548;
				short num2 = num;
				num = (short)2028046324;
				switch (num2 == num)
				{
				}
				num = (short)1255407616;
				short num3 = num;
				num = (short)1883111425;
				if (num != 0)
				{
				}
				num = (short)1084948480;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonKey_A22590._HasDiffs;
			}
		}

		// Token: 0x170045D9 RID: 17881
		// (get) Token: 0x060089C5 RID: 35269 RVA: 0x0080E778 File Offset: 0x0080C978
		// (set) Token: 0x060089C6 RID: 35270 RVA: 0x0080E82C File Offset: 0x0080CA2C
		public string CntrlHeadO3DataButtonName_A22591Value
		{
			get
			{
				short num = (short)1725317395;
				short num2 = num;
				num = (short)1573011731;
				switch (num2 == num)
				{
				}
				num = (short)1198850048;
				short num3 = num;
				num = (short)421462017;
				if (num != 0)
				{
				}
				num = (short)1024262144;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.Value;
			}
			set
			{
				short num = (short)280113474;
				short num2 = num;
				num = (short)1216033090;
				switch (num2 == num)
				{
				}
				num = (short)2018705408;
				short num3 = num;
				num = (short)1352269825;
				if (num != 0)
				{
				}
				num = (short)2050818048;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonName_A22591.Value = value;
			}
		}

		// Token: 0x170045DA RID: 17882
		// (get) Token: 0x060089C7 RID: 35271 RVA: 0x0080E8E4 File Offset: 0x0080CAE4
		public global::AcpBusinessLayer.AcpField<string> CntrlHeadO3DataButtonName_A22591
		{
			get
			{
				short num = (short)899169882;
				short num2 = num;
				num = (short)102121050;
				switch (num2 == num)
				{
				}
				num = (short)471924736;
				short num3 = num;
				num = (short)1867907072;
				if (num != 0)
				{
				}
				num = (short)384761857;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591;
			}
		}

		// Token: 0x170045DB RID: 17883
		// (get) Token: 0x060089C8 RID: 35272 RVA: 0x0080E994 File Offset: 0x0080CB94
		// (set) Token: 0x060089C9 RID: 35273 RVA: 0x0080EA4C File Offset: 0x0080CC4C
		public string CntrlHeadO3DataButtonName_A22591_UIValue
		{
			get
			{
				short num = (short)224449325;
				short num2 = num;
				num = (short)1828442925;
				switch (num2 == num)
				{
				}
				num = (short)787415040;
				short num3 = num;
				num = (short)842006529;
				if (num != 0)
				{
				}
				num = (short)1860632576;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.Value;
			}
			set
			{
				short num = (short)433985256;
				short num2 = num;
				num = (short)1100814056;
				switch (num2 == num)
				{
				}
				num = (short)735051776;
				short num3 = num;
				num = (short)2086404097;
				if (num != 0)
				{
				}
				num = (short)35782656;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonName_A22591.Value = value;
			}
		}

		// Token: 0x170045DC RID: 17884
		// (get) Token: 0x060089CA RID: 35274 RVA: 0x0080EB04 File Offset: 0x0080CD04
		// (set) Token: 0x060089CB RID: 35275 RVA: 0x0080EBB8 File Offset: 0x0080CDB8
		public bool CntrlHeadO3DataButtonName_A22591_Applicable
		{
			get
			{
				short num = (short)310837249;
				if (num != 0)
				{
				}
				num = (short)948709767;
				short num2 = num;
				num = (short)1807427975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1025245184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882049024;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.Applicable;
			}
			set
			{
				short num = (short)1076559873;
				if (num != 0)
				{
				}
				num = (short)1107939259;
				short num2 = num;
				num = (short)2061750203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1007747072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)881524736;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonName_A22591.Applicable = value;
			}
		}

		// Token: 0x170045DD RID: 17885
		// (get) Token: 0x060089CC RID: 35276 RVA: 0x0080EC74 File Offset: 0x0080CE74
		// (set) Token: 0x060089CD RID: 35277 RVA: 0x0080ED28 File Offset: 0x0080CF28
		public bool CntrlHeadO3DataButtonName_A22591_Valid
		{
			get
			{
				short num = (short)630399807;
				short num2 = num;
				num = (short)923149119;
				switch (num2 == num)
				{
				}
				num = (short)1142095872;
				short num3 = num;
				num = (short)412549120;
				if (num != 0)
				{
				}
				num = (short)605028353;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.Valid;
			}
			set
			{
				short num = (short)1543897089;
				if (num != 0)
				{
				}
				num = (short)1220685126;
				short num2 = num;
				num = (short)781921606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1944387584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758448128;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonName_A22591.Valid = value;
			}
		}

		// Token: 0x170045DE RID: 17886
		// (get) Token: 0x060089CE RID: 35278 RVA: 0x0080EDE0 File Offset: 0x0080CFE0
		// (set) Token: 0x060089CF RID: 35279 RVA: 0x0080EE94 File Offset: 0x0080D094
		public bool CntrlHeadO3DataButtonName_A22591_Visible
		{
			get
			{
				short num = (short)1189460901;
				short num2 = num;
				num = (short)371243941;
				switch (num2 == num)
				{
				}
				num = (short)1291845632;
				short num3 = num;
				num = (short)1172701184;
				if (num != 0)
				{
				}
				num = (short)1014038529;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.Visible;
			}
			set
			{
				short num = (short)1682117947;
				short num2 = num;
				num = (short)926160187;
				switch (num2 == num)
				{
				}
				num = (short)1466695680;
				short num3 = num;
				num = (short)353763329;
				if (num != 0)
				{
				}
				num = (short)1570701312;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonName_A22591.Visible = value;
			}
		}

		// Token: 0x170045DF RID: 17887
		// (get) Token: 0x060089D0 RID: 35280 RVA: 0x0080EF48 File Offset: 0x0080D148
		// (set) Token: 0x060089D1 RID: 35281 RVA: 0x0080EFFC File Offset: 0x0080D1FC
		public bool CntrlHeadO3DataButtonName_A22591_Editable
		{
			get
			{
				short num = (short)1708916737;
				if (num != 0)
				{
				}
				num = (short)1846574265;
				short num2 = num;
				num = (short)1951825081;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1647312896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1849294848;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.Editable;
			}
			set
			{
				short num = (short)348643934;
				short num2 = num;
				num = (short)2118115934;
				switch (num2 == num)
				{
				}
				num = (short)1554776064;
				short num3 = num;
				num = (short)1939734529;
				if (num != 0)
				{
				}
				num = (short)372244480;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonName_A22591.Editable = value;
			}
		}

		// Token: 0x170045E0 RID: 17888
		// (get) Token: 0x060089D2 RID: 35282 RVA: 0x0080F0B0 File Offset: 0x0080D2B0
		internal string CntrlHeadO3DataButtonName_A22591_UILabel
		{
			get
			{
				short num = (short)324337665;
				if (num != 0)
				{
				}
				num = (short)440428840;
				short num2 = num;
				num = (short)891316520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1116733440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)719978496;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.UIName;
			}
		}

		// Token: 0x170045E1 RID: 17889
		// (get) Token: 0x060089D3 RID: 35283 RVA: 0x0080F164 File Offset: 0x0080D364
		// (set) Token: 0x060089D4 RID: 35284 RVA: 0x0080F214 File Offset: 0x0080D414
		internal bool CntrlHeadO3DataButtonName_A22591_HiddenStatic
		{
			get
			{
				short num = (short)1752521386;
				short num2 = num;
				num = (short)1632000682;
				switch (num2 == num)
				{
				}
				num = (short)1384120320;
				short num3 = num;
				num = (short)1385824257;
				if (num != 0)
				{
				}
				num = (short)1872035840;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.HiddenStatic;
			}
			set
			{
				short num = (short)1703745115;
				short num2 = num;
				num = (short)187766363;
				switch (num2 == num)
				{
				}
				num = (short)1606090752;
				short num3 = num;
				num = (short)1803419648;
				if (num != 0)
				{
				}
				num = (short)1138622465;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonName_A22591.HiddenStatic = value;
			}
		}

		// Token: 0x170045E2 RID: 17890
		// (get) Token: 0x060089D5 RID: 35285 RVA: 0x0080F2C8 File Offset: 0x0080D4C8
		// (set) Token: 0x060089D6 RID: 35286 RVA: 0x0080F37C File Offset: 0x0080D57C
		internal bool CntrlHeadO3DataButtonName_A22591_HiddenDynamic
		{
			get
			{
				short num = (short)562319170;
				short num2 = num;
				num = (short)274091842;
				switch (num2 == num)
				{
				}
				num = (short)987299840;
				short num3 = num;
				num = (short)703528960;
				if (num != 0)
				{
				}
				num = (short)1720582145;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591.HiddenDynamic;
			}
			set
			{
				short num = (short)2130916965;
				short num2 = num;
				num = (short)697972325;
				switch (num2 == num)
				{
				}
				num = (short)254476288;
				short num3 = num;
				num = (short)582287361;
				if (num != 0)
				{
				}
				num = (short)1959591936;
				if (num != 0)
				{
				}
				this.cntrlHeadO3DataButtonName_A22591.HiddenDynamic = value;
			}
		}

		// Token: 0x170045E3 RID: 17891
		// (get) Token: 0x060089D7 RID: 35287 RVA: 0x0080F430 File Offset: 0x0080D630
		public bool CntrlHeadO3DataButtonName_A22591_HasDiffs
		{
			get
			{
				short num = (short)1224746645;
				short num2 = num;
				num = (short)417801877;
				switch (num2 == num)
				{
				}
				num = (short)1064828928;
				short num3 = num;
				num = (short)1823866880;
				if (num != 0)
				{
				}
				num = (short)731578369;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3DataButtonName_A22591._HasDiffs;
			}
		}

		// Token: 0x170045E4 RID: 17892
		// (get) Token: 0x060089D8 RID: 35288 RVA: 0x0080F4E8 File Offset: 0x0080D6E8
		// (set) Token: 0x060089D9 RID: 35289 RVA: 0x0080F59C File Offset: 0x0080D79C
		public int CntrlHeadO3ConventionalO3DataButtonBCO_A22592Value
		{
			get
			{
				short num = (short)316925008;
				short num2 = num;
				num = (short)1902306384;
				switch (num2 == num)
				{
				}
				num = (short)1519779840;
				short num3 = num;
				num = (short)1901985793;
				if (num != 0)
				{
				}
				num = (short)64618496;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Value;
			}
			set
			{
				short num = (short)1410596865;
				if (num != 0)
				{
				}
				num = (short)43167789;
				short num2 = num;
				num = (short)1008513069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)830799872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)558825472;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Value = value;
			}
		}

		// Token: 0x170045E5 RID: 17893
		// (get) Token: 0x060089DA RID: 35290 RVA: 0x0080F650 File Offset: 0x0080D850
		// (set) Token: 0x060089DB RID: 35291 RVA: 0x0080F704 File Offset: 0x0080D904
		public string CntrlHeadO3ConventionalO3DataButtonBCO_A22592_UIValue
		{
			get
			{
				short num = (short)330597612;
				short num2 = num;
				num = (short)948339948;
				switch (num2 == num)
				{
				}
				num = (short)587268096;
				short num3 = num;
				num = (short)1534328833;
				if (num != 0)
				{
				}
				num = (short)1784414208;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.UIValue;
			}
			set
			{
				short num = (short)1025310721;
				if (num != 0)
				{
				}
				num = (short)520710524;
				short num2 = num;
				num = (short)832924028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1969881088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051131904;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.UIValue = value;
			}
		}

		// Token: 0x170045E6 RID: 17894
		// (get) Token: 0x060089DC RID: 35292 RVA: 0x0080F7B8 File Offset: 0x0080D9B8
		public global::AcpBusinessLayer.AcpListField CntrlHeadO3ConventionalO3DataButtonBCO_A22592
		{
			get
			{
				short num = (short)206920271;
				short num2 = num;
				num = (short)553605711;
				switch (num2 == num)
				{
				}
				num = (short)1246101504;
				short num3 = num;
				num = (short)1517289473;
				if (num != 0)
				{
				}
				num = (short)397410304;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592;
			}
		}

		// Token: 0x170045E7 RID: 17895
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x0080F864 File Offset: 0x0080DA64
		// (set) Token: 0x060089DE RID: 35294 RVA: 0x0080F918 File Offset: 0x0080DB18
		public bool CntrlHeadO3ConventionalO3DataButtonBCO_A22592_Applicable
		{
			get
			{
				short num = (short)657151331;
				short num2 = num;
				num = (short)1358189923;
				switch (num2 == num)
				{
				}
				num = (short)281739264;
				short num3 = num;
				num = (short)1973682176;
				if (num != 0)
				{
				}
				num = (short)1246822401;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Applicable;
			}
			set
			{
				short num = (short)55513899;
				short num2 = num;
				num = (short)1861292843;
				switch (num2 == num)
				{
				}
				num = (short)1572143104;
				short num3 = num;
				num = (short)1224474624;
				if (num != 0)
				{
				}
				num = (short)349503489;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Applicable = value;
			}
		}

		// Token: 0x170045E8 RID: 17896
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x0080F9CC File Offset: 0x0080DBCC
		// (set) Token: 0x060089E0 RID: 35296 RVA: 0x0080FA80 File Offset: 0x0080DC80
		public bool CntrlHeadO3ConventionalO3DataButtonBCO_A22592_Valid
		{
			get
			{
				short num = (short)823707453;
				short num2 = num;
				num = (short)1711785789;
				switch (num2 == num)
				{
				}
				num = (short)463142912;
				short num3 = num;
				num = (short)415236097;
				if (num != 0)
				{
				}
				num = (short)43319296;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Valid;
			}
			set
			{
				short num = (short)1358556456;
				short num2 = num;
				num = (short)957738280;
				switch (num2 == num)
				{
				}
				num = (short)1415774208;
				short num3 = num;
				num = (short)255852544;
				if (num != 0)
				{
				}
				num = (short)1967718401;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Valid = value;
			}
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x0080FB38 File Offset: 0x0080DD38
		// (set) Token: 0x060089E2 RID: 35298 RVA: 0x0080FBEC File Offset: 0x0080DDEC
		public bool CntrlHeadO3ConventionalO3DataButtonBCO_A22592_Visible
		{
			get
			{
				short num = (short)170932031;
				short num2 = num;
				num = (short)392967999;
				switch (num2 == num)
				{
				}
				num = (short)956104704;
				short num3 = num;
				num = (short)823197696;
				if (num != 0)
				{
				}
				num = (short)593690625;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Visible;
			}
			set
			{
				short num = (short)1842197101;
				short num2 = num;
				num = (short)1326953069;
				switch (num2 == num)
				{
				}
				num = (short)641138688;
				short num3 = num;
				num = (short)1070268417;
				if (num != 0)
				{
				}
				num = (short)75759616;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Visible = value;
			}
		}

		// Token: 0x170045EA RID: 17898
		// (get) Token: 0x060089E3 RID: 35299 RVA: 0x0080FCA4 File Offset: 0x0080DEA4
		// (set) Token: 0x060089E4 RID: 35300 RVA: 0x0080FD54 File Offset: 0x0080DF54
		public bool CntrlHeadO3ConventionalO3DataButtonBCO_A22592_Editable
		{
			get
			{
				short num = (short)1603072368;
				short num2 = num;
				num = (short)1442836848;
				switch (num2 == num)
				{
				}
				num = (short)599261184;
				short num3 = num;
				num = (short)1310916609;
				if (num != 0)
				{
				}
				num = (short)356843520;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Editable;
			}
			set
			{
				short num = (short)477047789;
				short num2 = num;
				num = (short)1312631789;
				switch (num2 == num)
				{
				}
				num = (short)1739259904;
				short num3 = num;
				num = (short)84082689;
				if (num != 0)
				{
				}
				num = (short)461897728;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.Editable = value;
			}
		}

		// Token: 0x170045EB RID: 17899
		// (get) Token: 0x060089E5 RID: 35301 RVA: 0x0080FE0C File Offset: 0x0080E00C
		internal string CntrlHeadO3ConventionalO3DataButtonBCO_A22592_UILabel
		{
			get
			{
				short num = (short)1100750309;
				short num2 = num;
				num = (short)248454629;
				switch (num2 == num)
				{
				}
				num = (short)977207296;
				short num3 = num;
				num = (short)1025179648;
				if (num != 0)
				{
				}
				num = (short)549060609;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.UIName;
			}
		}

		// Token: 0x170045EC RID: 17900
		// (get) Token: 0x060089E6 RID: 35302 RVA: 0x0080FEC0 File Offset: 0x0080E0C0
		// (set) Token: 0x060089E7 RID: 35303 RVA: 0x0080FF74 File Offset: 0x0080E174
		internal bool CntrlHeadO3ConventionalO3DataButtonBCO_A22592_HiddenStatic
		{
			get
			{
				short num = (short)597051874;
				short num2 = num;
				num = (short)1340164578;
				switch (num2 == num)
				{
				}
				num = (short)1379794944;
				short num3 = num;
				num = (short)1791885313;
				if (num != 0)
				{
				}
				num = (short)1529675776;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.HiddenStatic;
			}
			set
			{
				short num = (short)1513291776;
				short num2 = num;
				num = (short)1691181031;
				short num3 = num;
				num = (short)2027118567;
				switch (num3 == num)
				{
				}
				num = (short)2092695553;
				if (num != 0)
				{
				}
				num = (short)1810432000;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.HiddenStatic = value;
			}
		}

		// Token: 0x170045ED RID: 17901
		// (get) Token: 0x060089E8 RID: 35304 RVA: 0x00810028 File Offset: 0x0080E228
		// (set) Token: 0x060089E9 RID: 35305 RVA: 0x008100DC File Offset: 0x0080E2DC
		internal bool CntrlHeadO3ConventionalO3DataButtonBCO_A22592_HiddenDynamic
		{
			get
			{
				short num = (short)32505856;
				short num2 = num;
				num = (short)1397424129;
				if (num != 0)
				{
				}
				num = (short)2052875669;
				short num3 = num;
				num = (short)1233020309;
				switch (num3 == num)
				{
				}
				num = (short)1134755840;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.HiddenDynamic;
			}
			set
			{
				short num = (short)1101725696;
				short num2 = num;
				num = (short)432205614;
				short num3 = num;
				num = (short)2048323374;
				switch (num3 == num)
				{
				}
				num = (short)783548417;
				if (num != 0)
				{
				}
				num = (short)166068224;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592.HiddenDynamic = value;
			}
		}

		// Token: 0x170045EE RID: 17902
		// (get) Token: 0x060089EA RID: 35306 RVA: 0x00810190 File Offset: 0x0080E390
		public bool CntrlHeadO3ConventionalO3DataButtonBCO_A22592_HasDiffs
		{
			get
			{
				short num = (short)1192361984;
				short num2 = num;
				num = (short)1764318710;
				short num3 = num;
				num = (short)1064525302;
				switch (num3 == num)
				{
				}
				num = (short)1951268865;
				if (num != 0)
				{
				}
				num = (short)406454272;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DataButtonBCO_A22592._HasDiffs;
			}
		}

		// Token: 0x170045EF RID: 17903
		// (get) Token: 0x060089EB RID: 35307 RVA: 0x00810244 File Offset: 0x0080E444
		// (set) Token: 0x060089EC RID: 35308 RVA: 0x008102F8 File Offset: 0x0080E4F8
		public int CntrlHeadO3ConventionalO3DatatButtonFeature_A22595Value
		{
			get
			{
				short num = (short)1751842816;
				short num2 = num;
				num = (short)2019577565;
				short num3 = num;
				num = (short)55070429;
				switch (num3 == num)
				{
				}
				num = (short)1709309953;
				if (num != 0)
				{
				}
				num = (short)665583616;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value;
			}
			set
			{
				short num = (short)853475328;
				short num2 = num;
				num = (short)321833040;
				short num3 = num;
				num = (short)660129872;
				switch (num3 == num)
				{
				}
				num = (short)675938304;
				if (num != 0)
				{
				}
				num = (short)1472987137;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value = value;
			}
		}

		// Token: 0x170045F0 RID: 17904
		// (get) Token: 0x060089ED RID: 35309 RVA: 0x008103AC File Offset: 0x0080E5AC
		// (set) Token: 0x060089EE RID: 35310 RVA: 0x00810460 File Offset: 0x0080E660
		public string CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_UIValue
		{
			get
			{
				short num = (short)645857280;
				short num2 = num;
				num = (short)212140033;
				if (num != 0)
				{
				}
				num = (short)457126257;
				short num3 = num;
				num = (short)904278385;
				switch (num3 == num)
				{
				}
				num = (short)899219456;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.UIValue;
			}
			set
			{
				short num = (short)358154240;
				short num2 = num;
				num = (short)1783843346;
				short num3 = num;
				num = (short)921455122;
				switch (num3 == num)
				{
				}
				num = (short)1797128193;
				if (num != 0)
				{
				}
				num = (short)613285888;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.UIValue = value;
			}
		}

		// Token: 0x170045F1 RID: 17905
		// (get) Token: 0x060089EF RID: 35311 RVA: 0x00810514 File Offset: 0x0080E714
		public global::AcpBusinessLayer.AcpListField CntrlHeadO3ConventionalO3DatatButtonFeature_A22595
		{
			get
			{
				short num = (short)1333657600;
				short num2 = num;
				num = (short)2115258221;
				short num3 = num;
				num = (short)210585453;
				switch (num3 == num)
				{
				}
				num = (short)1885011968;
				if (num != 0)
				{
				}
				num = (short)436142081;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
			}
		}

		// Token: 0x170045F2 RID: 17906
		// (get) Token: 0x060089F0 RID: 35312 RVA: 0x008105C4 File Offset: 0x0080E7C4
		// (set) Token: 0x060089F1 RID: 35313 RVA: 0x00810678 File Offset: 0x0080E878
		public bool CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_Applicable
		{
			get
			{
				short num = (short)1131020288;
				short num2 = num;
				num = (short)359464961;
				if (num != 0)
				{
				}
				num = (short)316569170;
				short num3 = num;
				num = (short)1555265106;
				switch (num3 == num)
				{
				}
				num = (short)759496704;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Applicable;
			}
			set
			{
				short num = (short)1188691968;
				short num2 = num;
				num = (short)607010744;
				short num3 = num;
				num = (short)1009336248;
				switch (num3 == num)
				{
				}
				num = (short)2024472577;
				if (num != 0)
				{
				}
				num = (short)1681063936;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Applicable = value;
			}
		}

		// Token: 0x170045F3 RID: 17907
		// (get) Token: 0x060089F2 RID: 35314 RVA: 0x00810730 File Offset: 0x0080E930
		// (set) Token: 0x060089F3 RID: 35315 RVA: 0x008107E4 File Offset: 0x0080E9E4
		public bool CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_Valid
		{
			get
			{
				short num = (short)1952448512;
				short num2 = num;
				num = (short)1271642909;
				short num3 = num;
				num = (short)2001451805;
				switch (num3 == num)
				{
				}
				num = (short)789184512;
				if (num != 0)
				{
				}
				num = (short)2050555905;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Valid;
			}
			set
			{
				short num = (short)937033728;
				short num2 = num;
				num = (short)1775302226;
				short num3 = num;
				num = (short)769586770;
				switch (num3 == num)
				{
				}
				num = (short)635830272;
				if (num != 0)
				{
				}
				num = (short)1253441537;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Valid = value;
			}
		}

		// Token: 0x170045F4 RID: 17908
		// (get) Token: 0x060089F4 RID: 35316 RVA: 0x00810898 File Offset: 0x0080EA98
		// (set) Token: 0x060089F5 RID: 35317 RVA: 0x0081094C File Offset: 0x0080EB4C
		public bool CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_Visible
		{
			get
			{
				short num = (short)2038235136;
				short num2 = num;
				num = (short)888930305;
				if (num != 0)
				{
				}
				num = (short)1721236405;
				short num3 = num;
				num = (short)1896676277;
				switch (num3 == num)
				{
				}
				num = (short)424542208;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Visible;
			}
			set
			{
				short num = (short)862912512;
				short num2 = num;
				num = (short)2001600513;
				if (num != 0)
				{
				}
				num = (short)745785212;
				short num3 = num;
				num = (short)255510396;
				switch (num3 == num)
				{
				}
				num = (short)1831469056;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Visible = value;
			}
		}

		// Token: 0x170045F5 RID: 17909
		// (get) Token: 0x060089F6 RID: 35318 RVA: 0x00810A04 File Offset: 0x0080EC04
		// (set) Token: 0x060089F7 RID: 35319 RVA: 0x00810AB8 File Offset: 0x0080ECB8
		public bool CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_Editable
		{
			get
			{
				short num = (short)962002944;
				short num2 = num;
				num = (short)707362169;
				short num3 = num;
				num = (short)437943673;
				switch (num3 == num)
				{
				}
				num = (short)1904082944;
				if (num != 0)
				{
				}
				num = (short)1700200449;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Editable;
			}
			set
			{
				short num = (short)1927479296;
				short num2 = num;
				num = (short)1659029027;
				short num3 = num;
				num = (short)1578026531;
				switch (num3 == num)
				{
				}
				num = (short)452722689;
				if (num != 0)
				{
				}
				num = (short)898367488;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Editable = value;
			}
		}

		// Token: 0x170045F6 RID: 17910
		// (get) Token: 0x060089F8 RID: 35320 RVA: 0x00810B74 File Offset: 0x0080ED74
		internal string CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_UILabel
		{
			get
			{
				short num = (short)861077504;
				short num2 = num;
				num = (short)932192714;
				short num3 = num;
				num = (short)1611080138;
				switch (num3 == num)
				{
				}
				num = (short)2045181953;
				if (num != 0)
				{
				}
				num = (short)2048196608;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.UIName;
			}
		}

		// Token: 0x170045F7 RID: 17911
		// (get) Token: 0x060089F9 RID: 35321 RVA: 0x00810C2C File Offset: 0x0080EE2C
		// (set) Token: 0x060089FA RID: 35322 RVA: 0x00810CE0 File Offset: 0x0080EEE0
		internal bool CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_HiddenStatic
		{
			get
			{
				short num = (short)1030422528;
				short num2 = num;
				num = (short)1616685822;
				short num3 = num;
				num = (short)770091774;
				switch (num3 == num)
				{
				}
				num = (short)2090663937;
				if (num != 0)
				{
				}
				num = (short)1914961920;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenStatic;
			}
			set
			{
				short num = (short)865468416;
				short num2 = num;
				num = (short)477976906;
				short num3 = num;
				num = (short)905140554;
				switch (num3 == num)
				{
				}
				num = (short)1441988609;
				if (num != 0)
				{
				}
				num = (short)734199808;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenStatic = value;
			}
		}

		// Token: 0x170045F8 RID: 17912
		// (get) Token: 0x060089FB RID: 35323 RVA: 0x00810D94 File Offset: 0x0080EF94
		// (set) Token: 0x060089FC RID: 35324 RVA: 0x00810E48 File Offset: 0x0080F048
		internal bool CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_HiddenDynamic
		{
			get
			{
				short num = (short)35717120;
				short num2 = num;
				num = (short)1112397767;
				short num3 = num;
				num = (short)1955387335;
				switch (num3 == num)
				{
				}
				num = (short)519176193;
				if (num != 0)
				{
				}
				num = (short)1671168000;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenDynamic;
			}
			set
			{
				short num = (short)1425604608;
				short num2 = num;
				num = (short)169869313;
				if (num != 0)
				{
				}
				num = (short)1668922407;
				short num3 = num;
				num = (short)617987111;
				switch (num3 == num)
				{
				}
				num = (short)479592448;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenDynamic = value;
			}
		}

		// Token: 0x170045F9 RID: 17913
		// (get) Token: 0x060089FD RID: 35325 RVA: 0x00810F00 File Offset: 0x0080F100
		public bool CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_HasDiffs
		{
			get
			{
				short num = (short)907411456;
				short num2 = num;
				num = (short)2075641798;
				short num3 = num;
				num = (short)368953286;
				switch (num3 == num)
				{
				}
				num = (short)1262419969;
				if (num != 0)
				{
				}
				num = (short)1685258240;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3DatatButtonFeature_A22595._HasDiffs;
			}
		}

		// Token: 0x170045FA RID: 17914
		// (get) Token: 0x060089FE RID: 35326 RVA: 0x00810FB8 File Offset: 0x0080F1B8
		// (set) Token: 0x060089FF RID: 35327 RVA: 0x0081106C File Offset: 0x0080F26C
		public int CntrlHeadO3TrunkingO3DataButtonBCO_A22596Value
		{
			get
			{
				short num = (short)1096286208;
				short num2 = num;
				num = (short)416474122;
				short num3 = num;
				num = (short)1892213770;
				switch (num3 == num)
				{
				}
				num = (short)1573322753;
				if (num != 0)
				{
				}
				num = (short)895287296;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Value;
			}
			set
			{
				short num = (short)157548544;
				short num2 = num;
				num = (short)1482718666;
				short num3 = num;
				num = (short)1786543562;
				switch (num3 == num)
				{
				}
				num = (short)160038913;
				if (num != 0)
				{
				}
				num = (short)388825088;
				if (num != 0)
				{
				}
				this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Value = value;
			}
		}

		// Token: 0x170045FB RID: 17915
		// (get) Token: 0x06008A00 RID: 35328 RVA: 0x00811120 File Offset: 0x0080F320
		// (set) Token: 0x06008A01 RID: 35329 RVA: 0x008111D4 File Offset: 0x0080F3D4
		public string CntrlHeadO3TrunkingO3DataButtonBCO_A22596_UIValue
		{
			get
			{
				short num = (short)1386217472;
				short num2 = num;
				num = (short)926352317;
				short num3 = num;
				num = (short)717226941;
				switch (num3 == num)
				{
				}
				num = (short)1683881985;
				if (num != 0)
				{
				}
				num = (short)1961230336;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.UIValue;
			}
			set
			{
				short num = (short)243335168;
				short num2 = num;
				num = (short)1605395017;
				short num3 = num;
				num = (short)1516331593;
				switch (num3 == num)
				{
				}
				num = (short)1180303361;
				if (num != 0)
				{
				}
				num = (short)1641283584;
				if (num != 0)
				{
				}
				this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.UIValue = value;
			}
		}

		// Token: 0x170045FC RID: 17916
		// (get) Token: 0x06008A02 RID: 35330 RVA: 0x00811288 File Offset: 0x0080F488
		public global::AcpBusinessLayer.AcpListField CntrlHeadO3TrunkingO3DataButtonBCO_A22596
		{
			get
			{
				short num = (short)925958144;
				short num2 = num;
				num = (short)421585555;
				short num3 = num;
				num = (short)142271123;
				switch (num3 == num)
				{
				}
				num = (short)1537015809;
				if (num != 0)
				{
				}
				num = (short)1165950976;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596;
			}
		}

		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x06008A03 RID: 35331 RVA: 0x0081133C File Offset: 0x0080F53C
		// (set) Token: 0x06008A04 RID: 35332 RVA: 0x008113F0 File Offset: 0x0080F5F0
		public bool CntrlHeadO3TrunkingO3DataButtonBCO_A22596_Applicable
		{
			get
			{
				short num = (short)1917386752;
				short num2 = num;
				num = (short)1826352127;
				short num3 = num;
				num = (short)453700607;
				switch (num3 == num)
				{
				}
				num = (short)591593472;
				if (num != 0)
				{
				}
				num = (short)2001600513;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Applicable;
			}
			set
			{
				short num = (short)463142912;
				short num2 = num;
				num = (short)132283097;
				short num3 = num;
				num = (short)967408345;
				switch (num3 == num)
				{
				}
				num = (short)33292289;
				if (num != 0)
				{
				}
				num = (short)1939865600;
				if (num != 0)
				{
				}
				this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Applicable = value;
			}
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x06008A05 RID: 35333 RVA: 0x008114A8 File Offset: 0x0080F6A8
		// (set) Token: 0x06008A06 RID: 35334 RVA: 0x0081155C File Offset: 0x0080F75C
		public bool CntrlHeadO3TrunkingO3DataButtonBCO_A22596_Valid
		{
			get
			{
				short num = (short)126746624;
				short num2 = num;
				num = (short)2052311604;
				short num3 = num;
				num = (short)2028063284;
				switch (num3 == num)
				{
				}
				num = (short)708968448;
				if (num != 0)
				{
				}
				num = (short)1919811585;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Valid;
			}
			set
			{
				short num = (short)397017088;
				short num2 = num;
				num = (short)1317666817;
				if (num != 0)
				{
				}
				num = (short)659351886;
				short num3 = num;
				num = (short)1628105038;
				switch (num3 == num)
				{
				}
				num = (short)309854208;
				if (num != 0)
				{
				}
				this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Valid = value;
			}
		}

		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x06008A07 RID: 35335 RVA: 0x00811610 File Offset: 0x0080F810
		// (set) Token: 0x06008A08 RID: 35336 RVA: 0x008116C4 File Offset: 0x0080F8C4
		public bool CntrlHeadO3TrunkingO3DataButtonBCO_A22596_Visible
		{
			get
			{
				short num = (short)1657339904;
				short num2 = num;
				num = (short)1793130497;
				if (num != 0)
				{
				}
				num = (short)539909843;
				short num3 = num;
				num = (short)1710513875;
				switch (num3 == num)
				{
				}
				num = (short)1127677952;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Visible;
			}
			set
			{
				short num = (short)1548877824;
				short num2 = num;
				num = (short)1233688699;
				short num3 = num;
				num = (short)1817811067;
				switch (num3 == num)
				{
				}
				num = (short)881786881;
				if (num != 0)
				{
				}
				num = (short)268238848;
				if (num != 0)
				{
				}
				this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Visible = value;
			}
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x06008A09 RID: 35337 RVA: 0x00811780 File Offset: 0x0080F980
		// (set) Token: 0x06008A0A RID: 35338 RVA: 0x00811838 File Offset: 0x0080FA38
		public bool CntrlHeadO3TrunkingO3DataButtonBCO_A22596_Editable
		{
			get
			{
				short num = (short)49283072;
				short num2 = num;
				num = (short)140183873;
				short num3 = num;
				num = (short)925305153;
				switch (num3 == num)
				{
				}
				num = (short)218759168;
				if (num != 0)
				{
				}
				num = (short)523567105;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Editable;
			}
			set
			{
				short num = (short)307494912;
				short num2 = num;
				num = (short)1906046228;
				short num3 = num;
				num = (short)749663508;
				switch (num3 == num)
				{
				}
				num = (short)2030829569;
				if (num != 0)
				{
				}
				num = (short)1261633536;
				if (num != 0)
				{
				}
				this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.Editable = value;
			}
		}

		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x06008A0B RID: 35339 RVA: 0x008118EC File Offset: 0x0080FAEC
		internal string CntrlHeadO3TrunkingO3DataButtonBCO_A22596_UILabel
		{
			get
			{
				short num = (short)1428357120;
				short num2 = num;
				num = (short)692725549;
				short num3 = num;
				num = (short)276375341;
				switch (num3 == num)
				{
				}
				num = (short)1545601025;
				if (num != 0)
				{
				}
				num = (short)1563885568;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.UIName;
			}
		}

		// Token: 0x17004602 RID: 17922
		// (get) Token: 0x06008A0C RID: 35340 RVA: 0x008119A0 File Offset: 0x0080FBA0
		// (set) Token: 0x06008A0D RID: 35341 RVA: 0x00811A54 File Offset: 0x0080FC54
		internal bool CntrlHeadO3TrunkingO3DataButtonBCO_A22596_HiddenStatic
		{
			get
			{
				short num = (short)760283136;
				short num2 = num;
				num = (short)434893131;
				short num3 = num;
				num = (short)1099886923;
				switch (num3 == num)
				{
				}
				num = (short)1782054913;
				if (num != 0)
				{
				}
				num = (short)86441984;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.HiddenStatic;
			}
			set
			{
				short num = (short)493289472;
				short num2 = num;
				num = (short)928442248;
				short num3 = num;
				num = (short)954591112;
				switch (num3 == num)
				{
				}
				num = (short)823721984;
				if (num != 0)
				{
				}
				num = (short)388562945;
				if (num != 0)
				{
				}
				this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.HiddenStatic = value;
			}
		}

		// Token: 0x17004603 RID: 17923
		// (get) Token: 0x06008A0E RID: 35342 RVA: 0x00811B08 File Offset: 0x0080FD08
		// (set) Token: 0x06008A0F RID: 35343 RVA: 0x00811BBC File Offset: 0x0080FDBC
		internal bool CntrlHeadO3TrunkingO3DataButtonBCO_A22596_HiddenDynamic
		{
			get
			{
				short num = (short)1597964288;
				short num2 = num;
				num = (short)1152015941;
				short num3 = num;
				num = (short)171400773;
				switch (num3 == num)
				{
				}
				num = (short)94502913;
				if (num != 0)
				{
				}
				num = (short)2096955392;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.HiddenDynamic;
			}
			set
			{
				short num = (short)1157627904;
				short num2 = num;
				num = (short)120959710;
				short num3 = num;
				num = (short)237286110;
				switch (num3 == num)
				{
				}
				num = (short)1327366145;
				if (num != 0)
				{
				}
				num = (short)431489024;
				if (num != 0)
				{
				}
				this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596.HiddenDynamic = value;
			}
		}

		// Token: 0x17004604 RID: 17924
		// (get) Token: 0x06008A10 RID: 35344 RVA: 0x00811C70 File Offset: 0x0080FE70
		public bool CntrlHeadO3TrunkingO3DataButtonBCO_A22596_HasDiffs
		{
			get
			{
				short num = (short)759496704;
				short num2 = num;
				num = (short)1631282714;
				short num3 = num;
				num = (short)584607258;
				switch (num3 == num)
				{
				}
				num = (short)1364656128;
				if (num != 0)
				{
				}
				num = (short)1428946945;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DataButtonBCO_A22596._HasDiffs;
			}
		}

		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x06008A11 RID: 35345 RVA: 0x00811D28 File Offset: 0x0080FF28
		// (set) Token: 0x06008A12 RID: 35346 RVA: 0x00811DDC File Offset: 0x0080FFDC
		public int CntrlHeadO3TrunkingO3DatatButtonFeature_A22597Value
		{
			get
			{
				short num = (short)525664256;
				short num2 = num;
				num = (short)70270334;
				short num3 = num;
				num = (short)1253588350;
				switch (num3 == num)
				{
				}
				num = (short)526712833;
				if (num != 0)
				{
				}
				num = (short)1832648704;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value;
			}
			set
			{
				short num = (short)263189290;
				short num2 = num;
				num = (short)1244197674;
				switch (num2 == num)
				{
				}
				num = (short)139001856;
				if (num != 0)
				{
				}
				num = (short)1907818497;
				if (num != 0)
				{
				}
				num = (short)1685716992;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value = value;
			}
		}

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x06008A13 RID: 35347 RVA: 0x00811E94 File Offset: 0x00810094
		// (set) Token: 0x06008A14 RID: 35348 RVA: 0x00811F48 File Offset: 0x00810148
		public string CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_UIValue
		{
			get
			{
				short num = (short)1328028311;
				short num2 = num;
				num = (short)530193047;
				switch (num2 == num)
				{
				}
				num = (short)136970240;
				if (num != 0)
				{
				}
				num = (short)685375489;
				if (num != 0)
				{
				}
				num = (short)2087649280;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.UIValue;
			}
			set
			{
				short num = (short)1383963205;
				short num2 = num;
				num = (short)2044893765;
				switch (num2 == num)
				{
				}
				num = (short)556662784;
				if (num != 0)
				{
				}
				num = (short)1019084801;
				if (num != 0)
				{
				}
				num = (short)514785280;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.UIValue = value;
			}
		}

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x06008A15 RID: 35349 RVA: 0x00812000 File Offset: 0x00810200
		public global::AcpBusinessLayer.AcpListField CntrlHeadO3TrunkingO3DatatButtonFeature_A22597
		{
			get
			{
				short num = (short)61283544;
				short num2 = num;
				num = (short)1331567832;
				switch (num2 == num)
				{
				}
				num = (short)553975809;
				if (num != 0)
				{
				}
				num = (short)2140078080;
				if (num != 0)
				{
				}
				num = (short)1847066624;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
			}
		}

		// Token: 0x17004608 RID: 17928
		// (get) Token: 0x06008A16 RID: 35350 RVA: 0x008120B0 File Offset: 0x008102B0
		// (set) Token: 0x06008A17 RID: 35351 RVA: 0x00812164 File Offset: 0x00810364
		public bool CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_Applicable
		{
			get
			{
				short num = (short)65325960;
				short num2 = num;
				num = (short)320195464;
				switch (num2 == num)
				{
				}
				num = (short)328400897;
				if (num != 0)
				{
				}
				num = (short)876216320;
				if (num != 0)
				{
				}
				num = (short)442499072;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Applicable;
			}
			set
			{
				short num = (short)1165632939;
				short num2 = num;
				num = (short)2142250411;
				switch (num2 == num)
				{
				}
				num = (short)1914503168;
				if (num != 0)
				{
				}
				num = (short)1307705345;
				if (num != 0)
				{
				}
				num = (short)1795358720;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Applicable = value;
			}
		}

		// Token: 0x17004609 RID: 17929
		// (get) Token: 0x06008A18 RID: 35352 RVA: 0x00812218 File Offset: 0x00810418
		// (set) Token: 0x06008A19 RID: 35353 RVA: 0x008122CC File Offset: 0x008104CC
		public bool CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_Valid
		{
			get
			{
				short num = (short)159955398;
				short num2 = num;
				num = (short)324712902;
				switch (num2 == num)
				{
				}
				num = (short)169345024;
				if (num != 0)
				{
				}
				num = (short)161742849;
				if (num != 0)
				{
				}
				num = (short)816644096;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Valid;
			}
			set
			{
				short num = (short)1252846665;
				short num2 = num;
				num = (short)374205513;
				switch (num2 == num)
				{
				}
				num = (short)349700097;
				if (num != 0)
				{
				}
				num = (short)802553856;
				if (num != 0)
				{
				}
				num = (short)1306656768;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Valid = value;
			}
		}

		// Token: 0x1700460A RID: 17930
		// (get) Token: 0x06008A1A RID: 35354 RVA: 0x00812380 File Offset: 0x00810580
		// (set) Token: 0x06008A1B RID: 35355 RVA: 0x00812434 File Offset: 0x00810634
		public bool CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_Visible
		{
			get
			{
				short num = (short)1218891686;
				short num2 = num;
				num = (short)854904742;
				switch (num2 == num)
				{
				}
				num = (short)159580161;
				if (num != 0)
				{
				}
				num = (short)1765605376;
				if (num != 0)
				{
				}
				num = (short)1357053952;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Visible;
			}
			set
			{
				short num = (short)190840833;
				if (num != 0)
				{
				}
				num = (short)395739374;
				short num2 = num;
				num = (short)284459246;
				switch (num2 == num)
				{
				}
				num = (short)709427200;
				if (num != 0)
				{
				}
				num = (short)238747648;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Visible = value;
			}
		}

		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x06008A1C RID: 35356 RVA: 0x008124E8 File Offset: 0x008106E8
		// (set) Token: 0x06008A1D RID: 35357 RVA: 0x008125A0 File Offset: 0x008107A0
		public bool CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_Editable
		{
			get
			{
				short num = (short)667665563;
				short num2 = num;
				num = (short)1737868443;
				switch (num2 == num)
				{
				}
				num = (short)1676804097;
				if (num != 0)
				{
				}
				num = (short)197787648;
				if (num != 0)
				{
				}
				num = (short)460128256;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Editable;
			}
			set
			{
				short num = (short)1898708993;
				if (num != 0)
				{
				}
				num = (short)1122464282;
				short num2 = num;
				num = (short)60191258;
				switch (num2 == num)
				{
				}
				num = (short)1807417344;
				if (num != 0)
				{
				}
				num = (short)918421504;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Editable = value;
			}
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x06008A1E RID: 35358 RVA: 0x00812654 File Offset: 0x00810854
		internal string CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_UILabel
		{
			get
			{
				short num = (short)1988338623;
				short num2 = num;
				num = (short)783655871;
				switch (num2 == num)
				{
				}
				num = (short)2054815745;
				if (num != 0)
				{
				}
				num = (short)1106771968;
				if (num != 0)
				{
				}
				num = (short)668336128;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.UIName;
			}
		}

		// Token: 0x1700460D RID: 17933
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x0081270C File Offset: 0x0081090C
		// (set) Token: 0x06008A20 RID: 35360 RVA: 0x008127C0 File Offset: 0x008109C0
		internal bool CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_HiddenStatic
		{
			get
			{
				short num = (short)1704304079;
				short num2 = num;
				num = (short)1344576975;
				switch (num2 == num)
				{
				}
				num = (short)1806106625;
				if (num != 0)
				{
				}
				num = (short)796065792;
				if (num != 0)
				{
				}
				num = (short)1807679488;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic;
			}
			set
			{
				short num = (short)123994113;
				if (num != 0)
				{
				}
				num = (short)1874529059;
				short num2 = num;
				num = (short)395184931;
				switch (num2 == num)
				{
				}
				num = (short)669712384;
				if (num != 0)
				{
				}
				num = (short)1841430528;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic = value;
			}
		}

		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x06008A21 RID: 35361 RVA: 0x00812874 File Offset: 0x00810A74
		// (set) Token: 0x06008A22 RID: 35362 RVA: 0x00812928 File Offset: 0x00810B28
		internal bool CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_HiddenDynamic
		{
			get
			{
				short num = (short)858382380;
				short num2 = num;
				num = (short)1887625260;
				switch (num2 == num)
				{
				}
				num = (short)2136932353;
				if (num != 0)
				{
				}
				num = (short)1647771648;
				if (num != 0)
				{
				}
				num = (short)155516928;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenDynamic;
			}
			set
			{
				short num = (short)1905197057;
				if (num != 0)
				{
				}
				num = (short)142494495;
				short num2 = num;
				num = (short)155011871;
				switch (num2 == num)
				{
				}
				num = (short)1635319808;
				if (num != 0)
				{
				}
				num = (short)60620800;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenDynamic = value;
			}
		}

		// Token: 0x1700460F RID: 17935
		// (get) Token: 0x06008A23 RID: 35363 RVA: 0x008129E0 File Offset: 0x00810BE0
		public bool CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_HasDiffs
		{
			get
			{
				short num = (short)502792193;
				if (num != 0)
				{
				}
				num = (short)1588356614;
				short num2 = num;
				num = (short)1764976134;
				switch (num2 == num)
				{
				}
				num = (short)831520768;
				if (num != 0)
				{
				}
				num = (short)1772093440;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3DatatButtonFeature_A22597._HasDiffs;
			}
		}

		// Token: 0x17004610 RID: 17936
		// (get) Token: 0x06008A24 RID: 35364 RVA: 0x00812A94 File Offset: 0x00810C94
		// (set) Token: 0x06008A25 RID: 35365 RVA: 0x00812B48 File Offset: 0x00810D48
		public int CHO3DataButtonConvIndex_A41419Value
		{
			get
			{
				short num = (short)2107461342;
				short num2 = num;
				num = (short)655511262;
				switch (num2 == num)
				{
				}
				num = (short)1245577216;
				if (num != 0)
				{
				}
				num = (short)401866753;
				if (num != 0)
				{
				}
				num = (short)127270912;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.Value;
			}
			set
			{
				short num = (short)805395986;
				short num2 = num;
				num = (short)356146706;
				switch (num2 == num)
				{
				}
				num = (short)174718977;
				if (num != 0)
				{
				}
				num = (short)315031552;
				if (num != 0)
				{
				}
				num = (short)1230635008;
				short num3 = num;
				this.cHO3DataButtonConvIndex_A41419.Value = value;
			}
		}

		// Token: 0x17004611 RID: 17937
		// (get) Token: 0x06008A26 RID: 35366 RVA: 0x00812BFC File Offset: 0x00810DFC
		// (set) Token: 0x06008A27 RID: 35367 RVA: 0x00812CB0 File Offset: 0x00810EB0
		public string CHO3DataButtonConvIndex_A41419_UIValue
		{
			get
			{
				short num = (short)1589300372;
				short num2 = num;
				num = (short)1932577940;
				switch (num2 == num)
				{
				}
				num = (short)1313275905;
				if (num != 0)
				{
				}
				num = (short)206176256;
				if (num != 0)
				{
				}
				num = (short)1254883328;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.UIValue;
			}
			set
			{
				short num = (short)1007397917;
				short num2 = num;
				num = (short)1978182685;
				switch (num2 == num)
				{
				}
				num = (short)67633153;
				if (num != 0)
				{
				}
				num = (short)1682898944;
				if (num != 0)
				{
				}
				num = (short)86638592;
				short num3 = num;
				this.cHO3DataButtonConvIndex_A41419.UIValue = value;
			}
		}

		// Token: 0x17004612 RID: 17938
		// (get) Token: 0x06008A28 RID: 35368 RVA: 0x00812D68 File Offset: 0x00810F68
		public global::AcpBusinessLayer.AcpRecRefField CHO3DataButtonConvIndex_A41419
		{
			get
			{
				short num = (short)1153062505;
				short num2 = num;
				num = (short)1983731305;
				switch (num2 == num)
				{
				}
				num = (short)924712961;
				if (num != 0)
				{
				}
				num = (short)1464729600;
				if (num != 0)
				{
				}
				num = (short)299958272;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419;
			}
		}

		// Token: 0x17004613 RID: 17939
		// (get) Token: 0x06008A29 RID: 35369 RVA: 0x00812E18 File Offset: 0x00811018
		// (set) Token: 0x06008A2A RID: 35370 RVA: 0x00812ED0 File Offset: 0x008110D0
		public bool CHO3DataButtonConvIndex_A41419_Applicable
		{
			get
			{
				short num = (short)1321425993;
				short num2 = num;
				num = (short)1903582281;
				switch (num2 == num)
				{
				}
				num = (short)1622671360;
				if (num != 0)
				{
				}
				num = (short)79888385;
				if (num != 0)
				{
				}
				num = (short)1286995968;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.Applicable;
			}
			set
			{
				short num = (short)621764054;
				short num2 = num;
				num = (short)1579507158;
				switch (num2 == num)
				{
				}
				num = (short)1701314561;
				if (num != 0)
				{
				}
				num = (short)479264768;
				if (num != 0)
				{
				}
				num = (short)2030043136;
				short num3 = num;
				this.cHO3DataButtonConvIndex_A41419.Applicable = value;
			}
		}

		// Token: 0x17004614 RID: 17940
		// (get) Token: 0x06008A2B RID: 35371 RVA: 0x00812F88 File Offset: 0x00811188
		// (set) Token: 0x06008A2C RID: 35372 RVA: 0x00813040 File Offset: 0x00811240
		public bool CHO3DataButtonConvIndex_A41419_Valid
		{
			get
			{
				short num = (short)37552129;
				if (num != 0)
				{
				}
				num = (short)678883955;
				short num2 = num;
				num = (short)90960499;
				switch (num2 == num)
				{
				}
				num = (short)648609792;
				if (num != 0)
				{
				}
				num = (short)724107264;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.Valid;
			}
			set
			{
				short num = (short)891736680;
				short num2 = num;
				num = (short)560452200;
				switch (num2 == num)
				{
				}
				num = (short)1437663232;
				if (num != 0)
				{
				}
				num = (short)508100609;
				if (num != 0)
				{
				}
				num = (short)388038656;
				short num3 = num;
				this.cHO3DataButtonConvIndex_A41419.Valid = value;
			}
		}

		// Token: 0x17004615 RID: 17941
		// (get) Token: 0x06008A2D RID: 35373 RVA: 0x008130F4 File Offset: 0x008112F4
		// (set) Token: 0x06008A2E RID: 35374 RVA: 0x008131A8 File Offset: 0x008113A8
		public bool CHO3DataButtonConvIndex_A41419_Visible
		{
			get
			{
				short num = (short)633034315;
				short num2 = num;
				num = (short)1727419979;
				switch (num2 == num)
				{
				}
				num = (short)439156737;
				if (num != 0)
				{
				}
				num = (short)1817509888;
				if (num != 0)
				{
				}
				num = (short)1581645824;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.Visible;
			}
			set
			{
				short num = (short)1706819585;
				if (num != 0)
				{
				}
				num = (short)502715608;
				short num2 = num;
				num = (short)28300504;
				switch (num2 == num)
				{
				}
				num = (short)1509621760;
				if (num != 0)
				{
				}
				num = (short)2083913728;
				short num3 = num;
				this.cHO3DataButtonConvIndex_A41419.Visible = value;
			}
		}

		// Token: 0x17004616 RID: 17942
		// (get) Token: 0x06008A2F RID: 35375 RVA: 0x00813260 File Offset: 0x00811460
		// (set) Token: 0x06008A30 RID: 35376 RVA: 0x00813314 File Offset: 0x00811514
		public bool CHO3DataButtonConvIndex_A41419_Editable
		{
			get
			{
				short num = (short)933771842;
				short num2 = num;
				num = (short)1828928066;
				switch (num2 == num)
				{
				}
				num = (short)1414070272;
				if (num != 0)
				{
				}
				num = (short)1932328961;
				if (num != 0)
				{
				}
				num = (short)1405616128;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.Editable;
			}
			set
			{
				short num = (short)151145657;
				short num2 = num;
				num = (short)953502905;
				switch (num2 == num)
				{
				}
				num = (short)1532362753;
				if (num != 0)
				{
				}
				num = (short)1539178496;
				if (num != 0)
				{
				}
				num = (short)1119158272;
				short num3 = num;
				this.cHO3DataButtonConvIndex_A41419.Editable = value;
			}
		}

		// Token: 0x17004617 RID: 17943
		// (get) Token: 0x06008A31 RID: 35377 RVA: 0x008133C8 File Offset: 0x008115C8
		internal string CHO3DataButtonConvIndex_A41419_UILabel
		{
			get
			{
				short num = (short)658155115;
				short num2 = num;
				num = (short)1284548203;
				switch (num2 == num)
				{
				}
				num = (short)1497628672;
				if (num != 0)
				{
				}
				num = (short)1186922497;
				if (num != 0)
				{
				}
				num = (short)1923481600;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.UIName;
			}
		}

		// Token: 0x17004618 RID: 17944
		// (get) Token: 0x06008A32 RID: 35378 RVA: 0x00813480 File Offset: 0x00811680
		// (set) Token: 0x06008A33 RID: 35379 RVA: 0x00813534 File Offset: 0x00811734
		internal bool CHO3DataButtonConvIndex_A41419_HiddenStatic
		{
			get
			{
				short num = (short)474902956;
				short num2 = num;
				num = (short)1967681964;
				switch (num2 == num)
				{
				}
				num = (short)1883373569;
				if (num != 0)
				{
				}
				num = (short)1458569216;
				if (num != 0)
				{
				}
				num = (short)1829437440;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.HiddenStatic;
			}
			set
			{
				short num = (short)1230732969;
				short num2 = num;
				num = (short)2065399465;
				switch (num2 == num)
				{
				}
				num = (short)455540736;
				if (num != 0)
				{
				}
				num = (short)1451098113;
				if (num != 0)
				{
				}
				num = (short)1588133888;
				short num3 = num;
				this.cHO3DataButtonConvIndex_A41419.HiddenStatic = value;
			}
		}

		// Token: 0x17004619 RID: 17945
		// (get) Token: 0x06008A34 RID: 35380 RVA: 0x008135E8 File Offset: 0x008117E8
		// (set) Token: 0x06008A35 RID: 35381 RVA: 0x008136A0 File Offset: 0x008118A0
		internal bool CHO3DataButtonConvIndex_A41419_HiddenDynamic
		{
			get
			{
				short num = (short)2003752091;
				short num2 = num;
				num = (short)336254107;
				switch (num2 == num)
				{
				}
				num = (short)268763137;
				if (num != 0)
				{
				}
				num = (short)1549205504;
				if (num != 0)
				{
				}
				num = (short)1161953280;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419.HiddenDynamic;
			}
			set
			{
				short num = (short)87738739;
				short num2 = num;
				num = (short)538888563;
				switch (num2 == num)
				{
				}
				num = (short)41549825;
				if (num != 0)
				{
				}
				num = (short)899088384;
				if (num != 0)
				{
				}
				num = (short)1461583872;
				short num3 = num;
				this.cHO3DataButtonConvIndex_A41419.HiddenDynamic = value;
			}
		}

		// Token: 0x1700461A RID: 17946
		// (get) Token: 0x06008A36 RID: 35382 RVA: 0x00813754 File Offset: 0x00811954
		public bool CHO3DataButtonConvIndex_A41419_HasDiffs
		{
			get
			{
				short num = (short)699392900;
				short num2 = num;
				num = (short)392881028;
				switch (num2 == num)
				{
				}
				num = (short)1908408321;
				if (num != 0)
				{
				}
				num = (short)705101824;
				if (num != 0)
				{
				}
				num = (short)1490223104;
				short num3 = num;
				return this.cHO3DataButtonConvIndex_A41419._HasDiffs;
			}
		}

		// Token: 0x1700461B RID: 17947
		// (get) Token: 0x06008A37 RID: 35383 RVA: 0x0081380C File Offset: 0x00811A0C
		// (set) Token: 0x06008A38 RID: 35384 RVA: 0x008138C0 File Offset: 0x00811AC0
		public int CHO3DataButtonTrkIndex_A41420Value
		{
			get
			{
				short num = (short)1180100325;
				short num2 = num;
				num = (short)1744496357;
				switch (num2 == num)
				{
				}
				num = (short)476250113;
				if (num != 0)
				{
				}
				num = (short)944570368;
				if (num != 0)
				{
				}
				num = (short)1568014336;
				short num3 = num;
				return this.cHO3DataButtonTrkIndex_A41420.Value;
			}
			set
			{
				short num = (short)520328897;
				short num2 = num;
				num = (short)1139906241;
				switch (num2 == num)
				{
				}
				num = (short)107741185;
				if (num != 0)
				{
				}
				num = (short)1184890880;
				if (num != 0)
				{
				}
				num = (short)738459648;
				short num3 = num;
				this.cHO3DataButtonTrkIndex_A41420.Value = value;
			}
		}

		// Token: 0x1700461C RID: 17948
		// (get) Token: 0x06008A39 RID: 35385 RVA: 0x00813978 File Offset: 0x00811B78
		// (set) Token: 0x06008A3A RID: 35386 RVA: 0x00813A2C File Offset: 0x00811C2C
		public string CHO3DataButtonTrkIndex_A41420_UIValue
		{
			get
			{
				short num = (short)2095889639;
				short num2 = num;
				num = (short)1409006823;
				switch (num2 == num)
				{
				}
				num = (short)1755840513;
				if (num != 0)
				{
				}
				num = (short)405864448;
				if (num != 0)
				{
				}
				num = (short)404357120;
				short num3 = num;
				return this.cHO3DataButtonTrkIndex_A41420.UIValue;
			}
			set
			{
				short num = (short)805896193;
				if (num != 0)
				{
				}
				num = (short)1726820921;
				short num2 = num;
				num = (short)390279737;
				switch (num2 == num)
				{
				}
				num = (short)674693120;
				if (num != 0)
				{
				}
				num = (short)1525219328;
				short num3 = num;
				this.cHO3DataButtonTrkIndex_A41420.UIValue = value;
			}
		}

		// Token: 0x1700461D RID: 17949
		// (get) Token: 0x06008A3B RID: 35387 RVA: 0x00813ADC File Offset: 0x00811CDC
		public global::AcpBusinessLayer.AcpRecRefField CHO3DataButtonTrkIndex_A41420
		{
			get
			{
				short num = (short)1911095297;
				if (num != 0)
				{
				}
				num = (short)596807312;
				short num2 = num;
				num = (short)1022529168;
				switch (num2 == num)
				{
				}
				num = (short)1595408384;
				if (num != 0)
				{
				}
				num = (short)415563776;
				short num3 = num;
				return this.cHO3DataButtonTrkIndex_A41420;
			}
		}

		// Token: 0x1700461E RID: 17950
		// (get) Token: 0x06008A3C RID: 35388 RVA: 0x00813B90 File Offset: 0x00811D90
		// (set) Token: 0x06008A3D RID: 35389 RVA: 0x00813C44 File Offset: 0x00811E44
		public bool CHO3DataButtonTrkIndex_A41420_Applicable
		{
			get
			{
				short num = (short)634978305;
				if (num != 0)
				{
				}
				num = (short)2112617101;
				short num2 = num;
				num = (short)1639840397;
				switch (num2 == num)
				{
				}
				num = (short)65470464;
				if (num != 0)
				{
				}
				num = (short)815136768;
				short num3 = num;
				return this.cHO3DataButtonTrkIndex_A41420.Applicable;
			}
			set
			{
				short num = (short)1764753409;
				if (num != 0)
				{
				}
				num = (short)1829529696;
				short num2 = num;
				num = (short)1666279520;
				switch (num2 == num)
				{
				}
				num = (short)571867136;
				if (num != 0)
				{
				}
				num = (short)728301568;
				short num3 = num;
				this.cHO3DataButtonTrkIndex_A41420.Applicable = value;
			}
		}

		// Token: 0x1700461F RID: 17951
		// (get) Token: 0x06008A3E RID: 35390 RVA: 0x00813CF8 File Offset: 0x00811EF8
		// (set) Token: 0x06008A3F RID: 35391 RVA: 0x00813DAC File Offset: 0x00811FAC
		public bool CHO3DataButtonTrkIndex_A41420_Valid
		{
			get
			{
				short num = (short)1410964024;
				short num2 = num;
				num = (short)239966776;
				switch (num2 == num)
				{
				}
				num = (short)1610809345;
				if (num != 0)
				{
				}
				num = (short)1789788160;
				if (num != 0)
				{
				}
				num = (short)2096103424;
				short num3 = num;
				return this.cHO3DataButtonTrkIndex_A41420.Valid;
			}
			set
			{
				short num = (short)994125409;
				short num2 = num;
				num = (short)1233462881;
				switch (num2 == num)
				{
				}
				num = (short)155713537;
				if (num != 0)
				{
				}
				num = (short)1886912512;
				if (num != 0)
				{
				}
				num = (short)1828192256;
				short num3 = num;
				this.cHO3DataButtonTrkIndex_A41420.Valid = value;
			}
		}

		// Token: 0x17004620 RID: 17952
		// (get) Token: 0x06008A40 RID: 35392 RVA: 0x00813E64 File Offset: 0x00812064
		// (set) Token: 0x06008A41 RID: 35393 RVA: 0x00813F18 File Offset: 0x00812118
		public bool CHO3DataButtonTrkIndex_A41420_Visible
		{
			get
			{
				short num = (short)301753729;
				short num2 = num;
				num = (short)979133825;
				switch (num2 == num)
				{
				}
				num = (short)1587740672;
				short num3 = num;
				num = (short)2005139456;
				if (num != 0)
				{
				}
				num = (short)429981697;
				if (num != 0)
				{
				}
				return this.cHO3DataButtonTrkIndex_A41420.Visible;
			}
			set
			{
				short num = (short)781473605;
				short num2 = num;
				num = (short)1492408133;
				switch (num2 == num)
				{
				}
				num = (short)1646067712;
				short num3 = num;
				num = (short)469762049;
				if (num != 0)
				{
				}
				num = (short)901054464;
				if (num != 0)
				{
				}
				this.cHO3DataButtonTrkIndex_A41420.Visible = value;
			}
		}

		// Token: 0x17004621 RID: 17953
		// (get) Token: 0x06008A42 RID: 35394 RVA: 0x00813FCC File Offset: 0x008121CC
		// (set) Token: 0x06008A43 RID: 35395 RVA: 0x00814080 File Offset: 0x00812280
		public bool CHO3DataButtonTrkIndex_A41420_Editable
		{
			get
			{
				short num = (short)598212609;
				if (num != 0)
				{
				}
				num = (short)419240969;
				short num2 = num;
				num = (short)1147935753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1081409536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)327286784;
				if (num != 0)
				{
				}
				return this.cHO3DataButtonTrkIndex_A41420.Editable;
			}
			set
			{
				short num = (short)759566622;
				short num2 = num;
				num = (short)1916342558;
				switch (num2 == num)
				{
				}
				num = (short)32309248;
				short num3 = num;
				num = (short)51773441;
				if (num != 0)
				{
				}
				num = (short)368377856;
				if (num != 0)
				{
				}
				this.cHO3DataButtonTrkIndex_A41420.Editable = value;
			}
		}

		// Token: 0x17004622 RID: 17954
		// (get) Token: 0x06008A44 RID: 35396 RVA: 0x00814138 File Offset: 0x00812338
		internal string CHO3DataButtonTrkIndex_A41420_UILabel
		{
			get
			{
				short num = (short)497327208;
				short num2 = num;
				num = (short)192453736;
				switch (num2 == num)
				{
				}
				num = (short)1029570560;
				short num3 = num;
				num = (short)985071616;
				if (num != 0)
				{
				}
				num = (short)31260673;
				if (num != 0)
				{
				}
				return this.cHO3DataButtonTrkIndex_A41420.UIName;
			}
		}

		// Token: 0x17004623 RID: 17955
		// (get) Token: 0x06008A45 RID: 35397 RVA: 0x008141EC File Offset: 0x008123EC
		// (set) Token: 0x06008A46 RID: 35398 RVA: 0x008142A4 File Offset: 0x008124A4
		internal bool CHO3DataButtonTrkIndex_A41420_HiddenStatic
		{
			get
			{
				short num = (short)564330497;
				if (num != 0)
				{
				}
				num = (short)608499774;
				short num2 = num;
				num = (short)1159723070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)255393792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1728577536;
				if (num != 0)
				{
				}
				return this.cHO3DataButtonTrkIndex_A41420.HiddenStatic;
			}
			set
			{
				short num = (short)1380869119;
				short num2 = num;
				num = (short)191587327;
				switch (num2 == num)
				{
				}
				num = (short)1540685824;
				short num3 = num;
				num = (short)2005794817;
				if (num != 0)
				{
				}
				num = (short)1678311424;
				if (num != 0)
				{
				}
				this.cHO3DataButtonTrkIndex_A41420.HiddenStatic = value;
			}
		}

		// Token: 0x17004624 RID: 17956
		// (get) Token: 0x06008A47 RID: 35399 RVA: 0x0081435C File Offset: 0x0081255C
		// (set) Token: 0x06008A48 RID: 35400 RVA: 0x00814410 File Offset: 0x00812610
		internal bool CHO3DataButtonTrkIndex_A41420_HiddenDynamic
		{
			get
			{
				short num = (short)649660424;
				short num2 = num;
				num = (short)816252936;
				switch (num2 == num)
				{
				}
				num = (short)1660485632;
				short num3 = num;
				num = (short)1989738497;
				if (num != 0)
				{
				}
				num = (short)1319501824;
				if (num != 0)
				{
				}
				return this.cHO3DataButtonTrkIndex_A41420.HiddenDynamic;
			}
			set
			{
				short num = (short)1426944234;
				short num2 = num;
				num = (short)1823371498;
				switch (num2 == num)
				{
				}
				num = (short)1585446912;
				short num3 = num;
				num = (short)388694017;
				if (num != 0)
				{
				}
				num = (short)1813184512;
				if (num != 0)
				{
				}
				this.cHO3DataButtonTrkIndex_A41420.HiddenDynamic = value;
			}
		}

		// Token: 0x17004625 RID: 17957
		// (get) Token: 0x06008A49 RID: 35401 RVA: 0x008144C4 File Offset: 0x008126C4
		public bool CHO3DataButtonTrkIndex_A41420_HasDiffs
		{
			get
			{
				short num = (short)1794066188;
				short num2 = num;
				num = (short)1075660556;
				switch (num2 == num)
				{
				}
				num = (short)1922760704;
				short num3 = num;
				num = (short)1243545601;
				if (num != 0)
				{
				}
				num = (short)602537984;
				if (num != 0)
				{
				}
				return this.cHO3DataButtonTrkIndex_A41420._HasDiffs;
			}
		}

		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x06008A4A RID: 35402 RVA: 0x00814578 File Offset: 0x00812778
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)286114861;
				short num2 = num;
				num = (short)1404552237;
				switch (num2 == num)
				{
				}
				num = (short)148570112;
				short num3 = num;
				num = (short)1580138497;
				if (num != 0)
				{
				}
				num = (short)863305728;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x00814638 File Offset: 0x00812838
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)752222209;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_D9;
				case 1:
					num = (short)1283850244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (base.ParentRecset != null)
					{
						num = (short)1411973121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11D;
				case 3:
				{
					num = (short)1286733824;
					short num3 = num;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)2086010880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)2128871427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11D;
				}
				goto IL_4C;
			}
			IL_D9:
			IL_11D:
			num = (short)597114364;
			short num4 = num;
			num = (short)331365884;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_4C:
				result = null;
				num = (short)450428930;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
				num = (short)1285160960;
				if (num != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x04004185 RID: 16773
		private global::AcpBusinessLayer.AcpKeyField cntrlHeadO3DataButtonKey_A22590;

		// Token: 0x04004186 RID: 16774
		private global::AcpBusinessLayer.AcpField<string> cntrlHeadO3DataButtonName_A22591;

		// Token: 0x04004187 RID: 16775
		private global::AcpBusinessLayer.AcpListField cntrlHeadO3ConventionalO3DataButtonBCO_A22592;

		// Token: 0x04004188 RID: 16776
		private global::AcpBusinessLayer.AcpListField cntrlHeadO3ConventionalO3DatatButtonFeature_A22595;

		// Token: 0x04004189 RID: 16777
		private global::AcpBusinessLayer.AcpListField cntrlHeadO3TrunkingO3DataButtonBCO_A22596;

		// Token: 0x0400418A RID: 16778
		private global::AcpBusinessLayer.AcpListField cntrlHeadO3TrunkingO3DatatButtonFeature_A22597;

		// Token: 0x0400418B RID: 16779
		private global::AcpBusinessLayer.AcpRecRefField cHO3DataButtonConvIndex_A41419;

		// Token: 0x0400418C RID: 16780
		private global::AcpBusinessLayer.AcpRecRefField cHO3DataButtonTrkIndex_A41420;
	}
}
