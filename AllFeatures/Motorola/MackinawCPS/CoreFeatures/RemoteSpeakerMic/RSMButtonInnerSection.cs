using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Switches;

namespace Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic
{
	// Token: 0x020002DD RID: 733
	[global::System.Serializable]
	public class RSMButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007818 RID: 30744 RVA: 0x006D0EF0 File Offset: 0x006CF0F0
		public RSMButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x006D0F0C File Offset: 0x006CF10C
		protected RSMButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x006D0F24 File Offset: 0x006CF124
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1415347058;
			short num2 = num;
			num = (short)668367730;
			switch (num2 == num)
			{
			}
			num = (short)1782513665;
			if (num != 0)
			{
			}
			num = (short)249495552;
			short num3 = num;
			num = (short)882311168;
			if (num != 0)
			{
			}
			this.radErgoCfgRSMConventionalBCO_A19639 = new global::AcpBusinessLayer.AcpSparseLOVField(151, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.indexRadErgoCfgRSMConventionalBCO_A19639LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.idRadErgoCfgRSMConventionalBCO_A19639LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚远賞고ꃢ諤触鿨軪菬鯮飰鳲鯴零闸맺뻼냾帀䈂㐄㸆㼈㠊㐌", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.RadErgoCfgRSMConventionalBCO_A19639LovStrs);
			this.radErgoCfgRSMConventionalBCO_A19639.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgRSMConventionalBCO_A19639.DataTransferOrder = 1;
			this.radErgoCfgRSMTrunkingBCO_A19741 = new global::AcpBusinessLayer.AcpSparseLOVField(151, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.indexRadErgoCfgRSMTrunkingBCO_A19741LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.idRadErgoCfgRSMTrunkingBCO_A19741LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚远賞고럢韤鋦蟨胪蓬臮雰뇲뛴룶꛸뫺쳼웾㘀㜂㐄", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.RadErgoCfgRSMTrunkingBCO_A19741LovStrs);
			this.radErgoCfgRSMTrunkingBCO_A19741.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgRSMTrunkingBCO_A19741.DataTransferOrder = 3;
			this.radErgoCfgRSMButtonKey_A22526 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚远賞고ꇢ郤鏦鷨蓪菬ꓮ铰諲ꫴ뛶쯸짺주췾㜀", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.radErgoCfgRSMButtonKey_A22526.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgRSMButtonKey_A22526.DataTransferOrder = -1;
			this.radErgoCfgRSMButtonName_A22527 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ACCYORANGE, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚远賞고ꇢ郤鏦鷨蓪菬ꇮ郰黲郴ꣶ룸짺쿼쫾㌀㐂", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoCfgRSMButtonName_A22527.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgRSMButtonName_A22527.DataTransferOrder = -1;
			this.radErgoCfgRSMlConventionalFeature_A19640 = new global::AcpBusinessLayer.AcpSparseLOVField(35, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.indexRadErgoCfgRSMlConventionalFeature_A19640LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.idRadErgoCfgRSMlConventionalFeature_A19640LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚远賞고迢ꛤ裦蟨鷪裬臮藰髲髴駶飸韺민髾怀眂瀄甆氈吊䰌㸎⠐┒℔✖", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.RadErgoCfgRSMlConventionalFeature_A19640LovStrs);
			this.radErgoCfgRSMlConventionalFeature_A19640.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgRSMlConventionalFeature_A19640.DataTransferOrder = 2;
			this.radErgoCfgRSMlConventionalFeature_A19640.ValidateAcrossRecset = true;
			this.radErgoCfgRSMlTrunkingFeature_A19742 = new global::AcpBusinessLayer.AcpSparseLOVField(35, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.indexRadErgoCfgRSMlTrunkingFeature_A19742LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.idRadErgoCfgRSMlTrunkingFeature_A19742LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚远賞고迢뇤闦鳨藪蛬蛮鿰铲돴鋶飸迺裼跾搀専䐄㘆〈㰊㤌㴎", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.RadErgoCfgRSMlTrunkingFeature_A19742LovStrs);
			this.radErgoCfgRSMlTrunkingFeature_A19742.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgRSMlTrunkingFeature_A19742.DataTransferOrder = 4;
			this.radErgoCfgRSMlTrunkingFeature_A19742.ValidateAcrossRecset = true;
			this.radErgoCfgRSMlTopButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚远賞고迢뇤裦駨ꧪ飬鯮藰鳲鯴믶雸闺髼꿾猀昂瘄理崈戊怌樎", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radErgoCfgRSMlTopButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgRSMlTopButtonLongPressTime.DataTransferOrder = 6;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgoCfgRSMlTopButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgRSMlTopButtonLongPressTime.ShowHexValue = false;
			this.radErgoCfgRSMlTopButtonLongPressTime.ValidateAcrossRecset = true;
			this.radErgoCfgRSMlTopButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚远賞고迢뇤裦駨ꧪ飬鯮藰鳲鯴ꓶ釸铺迼课儀焂怄理稈弊搌戎琐", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radErgoCfgRSMlTopButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgRSMlTopButtonShortPressTime.DataTransferOrder = 5;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgoCfgRSMlTopButtonShortPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgRSMlTopButtonShortPressTime.ShowHexValue = false;
			this.radErgoCfgRSMlTopButtonShortPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裈꣊껌꫎ꋐꃒ뫔ꗖꃘﯚ鿜꫞闠韢諤触髨쯪맬軮鏰鿲郴", a_);
			base.Id = 10080;
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYBUTTONSTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x006D12C4 File Offset: 0x006CF4C4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)114229275;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝賟ꇡ诣裥黧迩苫髭駯鷱髳韵铷볹駻鿽瓿省瘃挅圇䬉㴋㜍☏☑␓", a_)))
					{
						num = (short)1018953746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C4;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝듟郡釣裥菧菩苫觭닯뇱믳꧵맷쯹엻짽㓿㌁", a_)))
					{
						num = (short)1649934348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58E;
				case 2:
					goto IL_330;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝賟뛡诣雥ꫧ鿩飫髭鿯鳱룳駵雷鷹곻賽旿焁眃刅愇有椋", a_)))
					{
						num = (short)541261834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_330;
				case 4:
					num = (short)1778712595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_138;
				case 6:
					goto IL_589;
				case 7:
					this.radErgoCfgRSMConventionalBCO_A19639 = new global::AcpBusinessLayer.AcpSparseLOVField(151, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.indexRadErgoCfgRSMConventionalBCO_A19639LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.idRadErgoCfgRSMConventionalBCO_A19639LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵뫷맹돻ꇽ䇿㌁㴃々㬇㌉", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.RadErgoCfgRSMConventionalBCO_A19639LovStrs);
					this.radErgoCfgRSMConventionalBCO_A19639.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgRSMConventionalBCO_A19639.DataTransferOrder = 1;
					num = (short)312410135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)778442479;
					short num3 = num;
					num = (short)1874859759;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5D6;
					case 1:
						break;
					default:
					{
						num = (short)1849360384;
						short num4 = num;
						break;
					}
					}
					num = (short)458031104;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝賟뛡诣雥ꫧ鿩飫髭鿯鳱ꟳ黵韷裹裻껽狿朁眃甅將按愋欍", a_)))
					{
						num = (short)1155137545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A7;
				}
				case 9:
					this.radErgoCfgRSMlTopButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝賟뛡诣雥ꫧ鿩飫髭鿯鳱ꟳ黵韷裹裻껽狿朁眃甅將按愋欍", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.radErgoCfgRSMlTopButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgRSMlTopButtonShortPressTime.DataTransferOrder = 5;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgoCfgRSMlTopButtonShortPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgRSMlTopButtonShortPressTime.ShowHexValue = false;
					this.radErgoCfgRSMlTopButtonShortPressTime.ValidateAcrossRecset = true;
					num = (short)1722023942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.radErgoCfgRSMlTopButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝賟뛡诣雥ꫧ鿩飫髭鿯鳱룳駵雷鷹곻賽旿焁眃刅愇有椋", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radErgoCfgRSMlTopButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgRSMlTopButtonLongPressTime.DataTransferOrder = 6;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgoCfgRSMlTopButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgRSMlTopButtonLongPressTime.ShowHexValue = false;
					this.radErgoCfgRSMlTopButtonLongPressTime.ValidateAcrossRecset = true;
					num = (short)1066336258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_3F2;
				case 12:
					this.radErgoCfgRSMTrunkingBCO_A19741 = new global::AcpBusinessLayer.AcpSparseLOVField(151, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.indexRadErgoCfgRSMTrunkingBCO_A19741LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.idRadErgoCfgRSMTrunkingBCO_A19741LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝듟郡釣裥菧菩苫觭닯뇱믳꧵맷쯹엻짽㓿㌁", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.RadErgoCfgRSMTrunkingBCO_A19741LovStrs);
					this.radErgoCfgRSMTrunkingBCO_A19741.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgRSMTrunkingBCO_A19741.DataTransferOrder = 3;
					num = (short)773128218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_4AC;
				case 14:
					if (producerFields != null)
					{
						num = (short)227082244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A7;
				case 15:
					goto IL_5D6;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝ꋟ韡郣鋥蟧蓩ꋫ迭鷯韱꯳럵쫷죹짻쳽㟿", a_)))
					{
						num = (short)1821245465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝ꋟ韡郣鋥蟧蓩꟫语觯귱뗳쓵쫷쿹컻죽", a_)))
					{
						num = (short)167575567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F2;
				case 18:
					this.radErgoCfgRSMlConventionalFeature_A19640 = new global::AcpBusinessLayer.AcpSparseLOVField(35, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.indexRadErgoCfgRSMlConventionalFeature_A19640LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.idRadErgoCfgRSMlConventionalFeature_A19640LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝賟ꇡ诣裥黧迩苫髭駯鷱髳韵铷볹駻鿽瓿省瘃挅圇䬉㴋㜍☏☑␓", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.RadErgoCfgRSMlConventionalFeature_A19640LovStrs);
					this.radErgoCfgRSMlConventionalFeature_A19640.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgRSMlConventionalFeature_A19640.DataTransferOrder = 2;
					this.radErgoCfgRSMlConventionalFeature_A19640.ValidateAcrossRecset = true;
					num = (short)704249876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵뫷맹돻ꇽ䇿㌁㴃々㬇㌉", a_)))
					{
						num = (short)1909456903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_185;
				case 20:
					goto IL_C4;
				case 21:
					this.radErgoCfgRSMlTrunkingFeature_A19742 = new global::AcpBusinessLayer.AcpSparseLOVField(35, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.indexRadErgoCfgRSMlTrunkingFeature_A19742LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.idRadErgoCfgRSMlTrunkingFeature_A19742LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝賟뛡難鏥蛧臩藫胭韯등釳韵賷迹軻鯽忿䌁㔃㼅㼇㸉㸋", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.LOVs.RadErgoCfgRSMlTrunkingFeature_A19742LovStrs);
					this.radErgoCfgRSMlTrunkingFeature_A19742.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgRSMlTrunkingFeature_A19742.DataTransferOrder = 4;
					this.radErgoCfgRSMlTrunkingFeature_A19742.ValidateAcrossRecset = true;
					num = (short)1833500685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)594935822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_185;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝賟뛡難鏥蛧臩藫胭韯등釳韵賷迹軻鯽忿䌁㔃㼅㼇㸉㸋", a_)))
					{
						num = (short)1979252737;
						if (num != 0)
						{
						}
						num = (short)788856853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AC;
				case 25:
					this.radErgoCfgRSMButtonName_A22527 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ACCYORANGE, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝ꋟ韡郣鋥蟧蓩ꋫ迭鷯韱꯳럵쫷죹짻쳽㟿", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgoCfgRSMButtonName_A22527.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgRSMButtonName_A22527.DataTransferOrder = -1;
					num = (short)1121910789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_58E;
				case 27:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1374748694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C4:
				num = (short)1926758424;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_138:
				num = (short)589299712;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_185:
				num = (short)2073559041;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_330:
				num = (short)1339555848;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F2:
				num = (short)1833828368;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4AC:
				num = (short)1142685699;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_58E:
				num = (short)2138898449;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D6:
				this.radErgoCfgRSMButtonKey_A22526 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗裙进鏝ꋟ韡郣鋥蟧蓩꟫语觯귱뗳쓵쫷쿹컻죽", a_), global::CommonResources.AcgResources.ID_KEY, 14);
				this.radErgoCfgRSMButtonKey_A22526.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.radErgoCfgRSMButtonKey_A22526.DataTransferOrder = -1;
				num = (short)479199243;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_589:
			IL_7A7:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟅ꯇ꧉꧋뷍ꏏ뷑ꛓ꿕飙꧛ꫝ铟跡諣闥죧뻩跫賭鳯韱", a_);
			base.Id = 10080;
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYBUTTONSTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x006D1AAC File Offset: 0x006CFCAC
		public override void PopulateReferences()
		{
			short num = (short)1136525313;
			if (num != 0)
			{
			}
			num = (short)1736242455;
			short num2 = num;
			num = (short)604501271;
			switch (num2 == num)
			{
			}
			num = (short)1609105408;
			short num3 = num;
			num = (short)909312000;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x006D1B58 File Offset: 0x006CFD58
		public override void DropReferences()
		{
			short num = (short)25744065;
			short num2 = num;
			num = (short)1849610945;
			switch (num2 == num)
			{
			}
			num = (short)581042177;
			if (num != 0)
			{
			}
			num = (short)326500352;
			short num3 = num;
			num = (short)1335164928;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x006D1C04 File Offset: 0x006CFE04
		public override void SetConstraints()
		{
			short num = (short)2072551012;
			short num2 = num;
			num = (short)563846756;
			switch (num2 == num)
			{
			}
			num = (short)221642753;
			if (num != 0)
			{
			}
			num = (short)1400700928;
			short num3 = num;
			num = (short)524419072;
			if (num != 0)
			{
			}
			this.radErgoCfgRSMButtonName_A22527.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoCfgRSMlConventionalFeature_A19640.ValidateAcrossRecset = true;
			this.radErgoCfgRSMlConventionalFeature_A19640.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conRSMConventionalTriggerProButTableFeature);
			this.radErgoCfgRSMlConventionalFeature_A19640.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.ConConventionalRSMFeaturesSelect);
			this.radErgoCfgRSMlConventionalFeature_A19640.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conSetEditabilityRSMCnvFeature);
			this.radErgoCfgRSMlConventionalFeature_A19640.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conSetRSMTrkFeature);
			this.radErgoCfgRSMlTrunkingFeature_A19742.ValidateAcrossRecset = true;
			this.radErgoCfgRSMlTrunkingFeature_A19742.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conRSMTrunkingTriggerProButTableFeature);
			this.radErgoCfgRSMlTrunkingFeature_A19742.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.ConTrunkingRSMFeaturesSelect);
			this.radErgoCfgRSMlTrunkingFeature_A19742.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conSetEditabilityRsmTrkFeature);
			this.radErgoCfgRSMlTopButtonShortPressTime.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conRadErgoCfgRSMlTopButtonShortPressandLongPressTimeApplicable);
			this.radErgoCfgRSMlTopButtonShortPressTime.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conRadErgoCfgRSMlTopButtonShortPressTimeIsValid);
			this.radErgoCfgRSMlTopButtonLongPressTime.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conRadErgoCfgRSMlTopButtonShortPressandLongPressTimeApplicable);
			this.radErgoCfgRSMlTopButtonLongPressTime.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicConstraints.conRadErgoCfgRSMlTopButtonLongPressTimeIsValid);
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x006D1DD8 File Offset: 0x006CFFD8
		public override void SetupDependencies()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B3A;
				case 1:
					goto IL_B14;
				case 2:
				{
					global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
					if (feature == null)
					{
						goto IL_AD5;
					}
					acpFeatureNode = feature[0];
					if (acpFeatureNode == null)
					{
						num2 = (short)615383040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B3D;
				}
				}
				goto IL_1C;
			}
			IL_B14:
			object obj = null;
			goto IL_B49;
			IL_B3A:
			obj = null;
			goto IL_B49;
			IL_B3D:
			obj = acpFeatureNode[10105];
			IL_B49:
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = obj as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
			if (features != null)
			{
				features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			}
			if (features == null)
			{
				return;
			}
			features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			return;
			IL_1C:
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.radErgoCfgRSMlConventionalFeature_A19640);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.radErgoCfgRSMButtonName_A22527.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.radErgoCfgRSMlTrunkingFeature_A19742);
			this.radErgoCfgRSMConventionalBCO_A19639.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.radErgoCfgRSMConventionalBCO_A19639.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition2_A7735);
			this.radErgoCfgRSMConventionalBCO_A19639.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.radErgoCfgRSMConventionalBCO_A19639.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition4_A21530);
			this.radErgoCfgRSMConventionalBCO_A19639.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition5_A21531);
			this.radErgoCfgRSMTrunkingBCO_A19741.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.radErgoCfgRSMTrunkingBCO_A19741.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.radErgoCfgRSMTrunkingBCO_A19741.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.radErgoCfgRSMTrunkingBCO_A19741.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.radErgoCfgRSMTrunkingBCO_A19741.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition2_A7735);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10100] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationUserSelectableLocationEnable_A9605);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition4_A21530);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition5_A21531);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuTrunkingSelectedMenuItems_A21735);
			this.radErgoCfgRSMlConventionalFeature_A19640.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuConventionalSelectedMenuItems_A21736);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition2_A7735);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10100] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationUserSelectableLocationEnable_A9605);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition4_A21530);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition5_A21531);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuTrunkingSelectedMenuItems_A21735);
			this.radErgoCfgRSMlTrunkingFeature_A19742.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuConventionalSelectedMenuItems_A21736);
			num2 = (short)1502392087;
			short num3 = num2;
			num2 = (short)635809559;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_AD5:
				num2 = (short)305201152;
				short num4 = num2;
				num2 = (short)2036465665;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1347813377;
				if (num2 != 0)
				{
				}
				num2 = (short)1287979008;
				if (num2 != 0)
				{
				}
				num2 = (short)1230045186;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x06007820 RID: 30752 RVA: 0x006D2968 File Offset: 0x006D0B68
		public bool HasDiffs
		{
			get
			{
				short num = (short)1560254620;
				short num2 = num;
				num = (short)1502517404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1385693184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)100925441;
				if (num != 0)
				{
				}
				num = (short)400490496;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x06007821 RID: 30753 RVA: 0x006D2A18 File Offset: 0x006D0C18
		// (set) Token: 0x06007822 RID: 30754 RVA: 0x006D2ACC File Offset: 0x006D0CCC
		public int RadErgoCfgRSMConventionalBCO_A19639Value
		{
			get
			{
				short num = (short)466569221;
				short num2 = num;
				num = (short)1233733637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)937426944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333788673;
				if (num != 0)
				{
				}
				num = (short)382468096;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.Value;
			}
			set
			{
				short num = (short)1657138313;
				short num2 = num;
				num = (short)2075585673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1851195392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1586888704;
				if (num != 0)
				{
				}
				num = (short)1998848001;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMConventionalBCO_A19639.Value = value;
			}
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x06007823 RID: 30755 RVA: 0x006D2B84 File Offset: 0x006D0D84
		// (set) Token: 0x06007824 RID: 30756 RVA: 0x006D2C3C File Offset: 0x006D0E3C
		public string RadErgoCfgRSMConventionalBCO_A19639_UIValue
		{
			get
			{
				short num = (short)1109046970;
				short num2 = num;
				num = (short)211072698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)598016000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17170433;
				if (num != 0)
				{
				}
				num = (short)453246976;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.UIValue;
			}
			set
			{
				short num = (short)636758816;
				short num2 = num;
				num = (short)2116627232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)146145280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)848297985;
				if (num != 0)
				{
				}
				num = (short)1740242944;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMConventionalBCO_A19639.UIValue = value;
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x06007825 RID: 30757 RVA: 0x006D2CF0 File Offset: 0x006D0EF0
		public global::AcpBusinessLayer.AcpListField RadErgoCfgRSMConventionalBCO_A19639
		{
			get
			{
				short num = (short)1388436977;
				short num2 = num;
				num = (short)1825496561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)471007232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)65208320;
				if (num != 0)
				{
				}
				num = (short)1623457793;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639;
			}
		}

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x06007826 RID: 30758 RVA: 0x006D2DA0 File Offset: 0x006D0FA0
		// (set) Token: 0x06007827 RID: 30759 RVA: 0x006D2E54 File Offset: 0x006D1054
		public bool RadErgoCfgRSMConventionalBCO_A19639_Applicable
		{
			get
			{
				short num = (short)1422578118;
				short num2 = num;
				num = (short)1741476294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)35782656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1703870465;
				if (num != 0)
				{
				}
				num = (short)622854144;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.Applicable;
			}
			set
			{
				short num = (short)1035497094;
				short num2 = num;
				num = (short)1288793734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1709441024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2075983872;
				if (num != 0)
				{
				}
				num = (short)1496055809;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMConventionalBCO_A19639.Applicable = value;
			}
		}

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x06007828 RID: 30760 RVA: 0x006D2F08 File Offset: 0x006D1108
		// (set) Token: 0x06007829 RID: 30761 RVA: 0x006D2FBC File Offset: 0x006D11BC
		public bool RadErgoCfgRSMConventionalBCO_A19639_Valid
		{
			get
			{
				short num = (short)760633951;
				short num2 = num;
				num = (short)2113362527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)569966592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)222298113;
				if (num != 0)
				{
				}
				num = (short)181207040;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.Valid;
			}
			set
			{
				short num = (short)2135730722;
				short num2 = num;
				num = (short)1516612130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1860108288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1389297665;
				if (num != 0)
				{
				}
				num = (short)680001536;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMConventionalBCO_A19639.Valid = value;
			}
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x0600782A RID: 30762 RVA: 0x006D3070 File Offset: 0x006D1270
		// (set) Token: 0x0600782B RID: 30763 RVA: 0x006D3128 File Offset: 0x006D1328
		public bool RadErgoCfgRSMConventionalBCO_A19639_Visible
		{
			get
			{
				short num = (short)1081901699;
				short num2 = num;
				num = (short)1268548227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1958215680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)833159169;
				if (num != 0)
				{
				}
				num = (short)786956288;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.Visible;
			}
			set
			{
				short num = (short)1739150414;
				short num2 = num;
				num = (short)387535950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)126287872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2023030785;
				if (num != 0)
				{
				}
				num = (short)1076953088;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMConventionalBCO_A19639.Visible = value;
			}
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x006D31DC File Offset: 0x006D13DC
		// (set) Token: 0x0600782D RID: 30765 RVA: 0x006D3298 File Offset: 0x006D1498
		public bool RadErgoCfgRSMConventionalBCO_A19639_Editable
		{
			get
			{
				short num = (short)179879934;
				short num2 = num;
				num = (short)1982316542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282198016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)559087617;
				if (num != 0)
				{
				}
				num = (short)64618496;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.Editable;
			}
			set
			{
				short num = (short)984802462;
				short num2 = num;
				num = (short)746710174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1574764544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1158873088;
				if (num != 0)
				{
				}
				num = (short)1466236929;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMConventionalBCO_A19639.Editable = value;
			}
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x0600782E RID: 30766 RVA: 0x006D334C File Offset: 0x006D154C
		internal string RadErgoCfgRSMConventionalBCO_A19639_UILabel
		{
			get
			{
				short num = (short)250391418;
				short num2 = num;
				num = (short)1516678010;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1036189696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)942800896;
				if (num != 0)
				{
				}
				num = (short)597557249;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.UIName;
			}
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x0600782F RID: 30767 RVA: 0x006D3400 File Offset: 0x006D1600
		// (set) Token: 0x06007830 RID: 30768 RVA: 0x006D34B8 File Offset: 0x006D16B8
		internal bool RadErgoCfgRSMConventionalBCO_A19639_HiddenStatic
		{
			get
			{
				short num = (short)843186177;
				if (num != 0)
				{
				}
				num = (short)585564160;
				short num2 = num;
				num = (short)1485116724;
				short num3 = num;
				num = (short)2053575988;
				switch (num3 == num)
				{
				}
				num = (short)447741952;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.HiddenStatic;
			}
			set
			{
				short num = (short)461464651;
				short num2 = num;
				num = (short)1411933259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96141312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1946025984;
				if (num != 0)
				{
				}
				num = (short)838139905;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMConventionalBCO_A19639.HiddenStatic = value;
			}
		}

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x06007831 RID: 30769 RVA: 0x006D3570 File Offset: 0x006D1770
		// (set) Token: 0x06007832 RID: 30770 RVA: 0x006D3624 File Offset: 0x006D1824
		internal bool RadErgoCfgRSMConventionalBCO_A19639_HiddenDynamic
		{
			get
			{
				short num = (short)1247814671;
				short num2 = num;
				num = (short)672015375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188350464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415315456;
				if (num != 0)
				{
				}
				num = (short)154009601;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639.HiddenDynamic;
			}
			set
			{
				short num = (short)1404707858;
				short num2 = num;
				num = (short)1743070226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1815609344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1845952512;
				if (num != 0)
				{
				}
				num = (short)279445505;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMConventionalBCO_A19639.HiddenDynamic = value;
			}
		}

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x06007833 RID: 30771 RVA: 0x006D36D8 File Offset: 0x006D18D8
		public bool RadErgoCfgRSMConventionalBCO_A19639_HasDiffs
		{
			get
			{
				short num = (short)58667121;
				short num2 = num;
				num = (short)1011101809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745092608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)915013633;
				if (num != 0)
				{
				}
				num = (short)1993015296;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMConventionalBCO_A19639._HasDiffs;
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x06007834 RID: 30772 RVA: 0x006D378C File Offset: 0x006D198C
		// (set) Token: 0x06007835 RID: 30773 RVA: 0x006D3844 File Offset: 0x006D1A44
		public int RadErgoCfgRSMTrunkingBCO_A19741Value
		{
			get
			{
				short num = (short)892676800;
				short num2 = num;
				num = (short)1654663872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1858273280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467992576;
				if (num != 0)
				{
				}
				num = (short)1244200961;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.Value;
			}
			set
			{
				short num = (short)1537277953;
				if (num != 0)
				{
				}
				num = (short)1370095616;
				short num2 = num;
				num = (short)582968007;
				short num3 = num;
				num = (short)1118003911;
				switch (num3 == num)
				{
				}
				num = (short)758906880;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMTrunkingBCO_A19741.Value = value;
			}
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x06007836 RID: 30774 RVA: 0x006D38F8 File Offset: 0x006D1AF8
		// (set) Token: 0x06007837 RID: 30775 RVA: 0x006D39AC File Offset: 0x006D1BAC
		public string RadErgoCfgRSMTrunkingBCO_A19741_UIValue
		{
			get
			{
				short num = (short)1265669412;
				short num2 = num;
				num = (short)239179044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1644101632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1245773824;
				if (num != 0)
				{
				}
				num = (short)1121189889;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.UIValue;
			}
			set
			{
				short num = (short)969102596;
				short num2 = num;
				num = (short)302208260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270204928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1582366721;
				if (num != 0)
				{
				}
				num = (short)1602879488;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMTrunkingBCO_A19741.UIValue = value;
			}
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x06007838 RID: 30776 RVA: 0x006D3A60 File Offset: 0x006D1C60
		public global::AcpBusinessLayer.AcpListField RadErgoCfgRSMTrunkingBCO_A19741
		{
			get
			{
				short num = (short)10733211;
				short num2 = num;
				num = (short)26199707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1928200192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)47448065;
				if (num != 0)
				{
				}
				num = (short)766246912;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741;
			}
		}

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x06007839 RID: 30777 RVA: 0x006D3B10 File Offset: 0x006D1D10
		// (set) Token: 0x0600783A RID: 30778 RVA: 0x006D3BC4 File Offset: 0x006D1DC4
		public bool RadErgoCfgRSMTrunkingBCO_A19741_Applicable
		{
			get
			{
				short num = (short)958269376;
				short num2 = num;
				num = (short)1982924736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)84672512;
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
				num = (short)840761345;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.Applicable;
			}
			set
			{
				short num = (short)2025785989;
				short num2 = num;
				num = (short)68229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)419299328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1787166721;
				if (num != 0)
				{
				}
				num = (short)1252851712;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMTrunkingBCO_A19741.Applicable = value;
			}
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x0600783B RID: 30779 RVA: 0x006D3C78 File Offset: 0x006D1E78
		// (set) Token: 0x0600783C RID: 30780 RVA: 0x006D3D2C File Offset: 0x006D1F2C
		public bool RadErgoCfgRSMTrunkingBCO_A19741_Valid
		{
			get
			{
				short num = (short)135142843;
				short num2 = num;
				num = (short)588979643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)981860352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391512065;
				if (num != 0)
				{
				}
				num = (short)545783808;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.Valid;
			}
			set
			{
				short num = (short)371392513;
				if (num != 0)
				{
				}
				num = (short)1656619008;
				short num2 = num;
				num = (short)1721665642;
				short num3 = num;
				num = (short)1001162858;
				switch (num3 == num)
				{
				}
				num = (short)769720320;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMTrunkingBCO_A19741.Valid = value;
			}
		}

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x0600783D RID: 30781 RVA: 0x006D3DE0 File Offset: 0x006D1FE0
		// (set) Token: 0x0600783E RID: 30782 RVA: 0x006D3E94 File Offset: 0x006D2094
		public bool RadErgoCfgRSMTrunkingBCO_A19741_Visible
		{
			get
			{
				short num = (short)1997669625;
				short num2 = num;
				num = (short)37750009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2018115584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1440415745;
				if (num != 0)
				{
				}
				num = (short)76021760;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.Visible;
			}
			set
			{
				short num = (short)1339629578;
				short num2 = num;
				num = (short)204546058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)545390592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)754515968;
				if (num != 0)
				{
				}
				num = (short)1713242113;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMTrunkingBCO_A19741.Visible = value;
			}
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x0600783F RID: 30783 RVA: 0x006D3F48 File Offset: 0x006D2148
		// (set) Token: 0x06007840 RID: 30784 RVA: 0x006D3FF8 File Offset: 0x006D21F8
		public bool RadErgoCfgRSMTrunkingBCO_A19741_Editable
		{
			get
			{
				short num = (short)1968774938;
				short num2 = num;
				num = (short)1604460314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432734208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)259981313;
				if (num != 0)
				{
				}
				num = (short)960626688;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.Editable;
			}
			set
			{
				short num = (short)1581609118;
				short num2 = num;
				num = (short)698183838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1625554944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)741081089;
				if (num != 0)
				{
				}
				num = (short)1336213504;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMTrunkingBCO_A19741.Editable = value;
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x06007841 RID: 30785 RVA: 0x006D40AC File Offset: 0x006D22AC
		internal string RadErgoCfgRSMTrunkingBCO_A19741_UILabel
		{
			get
			{
				short num = (short)1181286401;
				if (num != 0)
				{
				}
				num = (short)1159266304;
				short num2 = num;
				num = (short)1516078014;
				short num3 = num;
				num = (short)695894974;
				switch (num3 == num)
				{
				}
				num = (short)1850081280;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.UIName;
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x06007842 RID: 30786 RVA: 0x006D4160 File Offset: 0x006D2360
		// (set) Token: 0x06007843 RID: 30787 RVA: 0x006D4214 File Offset: 0x006D2414
		internal bool RadErgoCfgRSMTrunkingBCO_A19741_HiddenStatic
		{
			get
			{
				short num = (short)867762177;
				if (num != 0)
				{
				}
				num = (short)388562944;
				short num2 = num;
				num = (short)1820327274;
				short num3 = num;
				num = (short)276495722;
				switch (num3 == num)
				{
				}
				num = (short)1061027840;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.HiddenStatic;
			}
			set
			{
				short num = (short)825676337;
				short num2 = num;
				num = (short)1254609457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)190709760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1111162880;
				if (num != 0)
				{
				}
				num = (short)1033568257;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMTrunkingBCO_A19741.HiddenStatic = value;
			}
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x06007844 RID: 30788 RVA: 0x006D42C8 File Offset: 0x006D24C8
		// (set) Token: 0x06007845 RID: 30789 RVA: 0x006D437C File Offset: 0x006D257C
		internal bool RadErgoCfgRSMTrunkingBCO_A19741_HiddenDynamic
		{
			get
			{
				short num = (short)1611201540;
				short num2 = num;
				num = (short)1789656068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)855113728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)306970624;
				if (num != 0)
				{
				}
				num = (short)1927086081;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741.HiddenDynamic;
			}
			set
			{
				short num = (short)402653185;
				if (num != 0)
				{
				}
				num = (short)1131216896;
				short num2 = num;
				num = (short)832126548;
				short num3 = num;
				num = (short)747978324;
				switch (num3 == num)
				{
				}
				num = (short)831127552;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMTrunkingBCO_A19741.HiddenDynamic = value;
			}
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x006D4430 File Offset: 0x006D2630
		public bool RadErgoCfgRSMTrunkingBCO_A19741_HasDiffs
		{
			get
			{
				short num = (short)2040639363;
				short num2 = num;
				num = (short)444444547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1470365696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1223622657;
				if (num != 0)
				{
				}
				num = (short)277020672;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMTrunkingBCO_A19741._HasDiffs;
			}
		}

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x06007847 RID: 30791 RVA: 0x006D44E8 File Offset: 0x006D26E8
		// (set) Token: 0x06007848 RID: 30792 RVA: 0x006D459C File Offset: 0x006D279C
		public string RadErgoCfgRSMButtonKey_A22526Value
		{
			get
			{
				short num = (short)131456516;
				short num2 = num;
				num = (short)1877794308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2071396352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2143813632;
				if (num != 0)
				{
				}
				num = (short)50462721;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.Value;
			}
			set
			{
				short num = (short)27590657;
				if (num != 0)
				{
				}
				num = (short)307888129;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1478557696;
						short num3 = num;
						num = (short)450102875;
						short num4 = num;
						num = (short)1731855963;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_68;
						default:
							num = (short)1099694080;
							if (num != 0)
							{
							}
							this.radErgoCfgRSMButtonKey_A22526.Value = value;
							num = (short)1246232578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
						return;
					}
					goto IL_58;
					IL_68:
					num = (short)1912537088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						goto IL_68;
					}
					break;
				}
			}
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x06007849 RID: 30793 RVA: 0x006D46C4 File Offset: 0x006D28C4
		// (set) Token: 0x0600784A RID: 30794 RVA: 0x006D4778 File Offset: 0x006D2978
		public string RadErgoCfgRSMButtonKey_A22526_UIValue
		{
			get
			{
				short num = (short)1660185108;
				short num2 = num;
				num = (short)1713662484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616117760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896480769;
				if (num != 0)
				{
				}
				num = (short)2005204992;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.Value;
			}
			set
			{
				short num = (short)1174410868;
				short num2 = num;
				num = (short)405870196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234553344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1503461377;
				if (num != 0)
				{
				}
				num = (short)145424384;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonKey_A22526.Value = value;
			}
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0600784B RID: 30795 RVA: 0x006D482C File Offset: 0x006D2A2C
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgRSMButtonKey_A22526
		{
			get
			{
				short num = (short)633705746;
				short num2 = num;
				num = (short)1380816146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)305790976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1315110913;
				if (num != 0)
				{
				}
				num = (short)426442752;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526;
			}
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x0600784C RID: 30796 RVA: 0x006D48DC File Offset: 0x006D2ADC
		// (set) Token: 0x0600784D RID: 30797 RVA: 0x006D498C File Offset: 0x006D2B8C
		public bool RadErgoCfgRSMButtonKey_A22526_Applicable
		{
			get
			{
				short num = (short)1190938203;
				short num2 = num;
				num = (short)113985115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727987712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)904396801;
				if (num != 0)
				{
				}
				num = (short)1667956736;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.Applicable;
			}
			set
			{
				short num = (short)161077476;
				short num2 = num;
				num = (short)345168100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1946943488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1087438848;
				if (num != 0)
				{
				}
				num = (short)140574721;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonKey_A22526.Applicable = value;
			}
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x0600784E RID: 30798 RVA: 0x006D4A40 File Offset: 0x006D2C40
		// (set) Token: 0x0600784F RID: 30799 RVA: 0x006D4AF0 File Offset: 0x006D2CF0
		public bool RadErgoCfgRSMButtonKey_A22526_Valid
		{
			get
			{
				short num = (short)484314383;
				short num2 = num;
				num = (short)889195791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1614544896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1431502849;
				if (num != 0)
				{
				}
				num = (short)1920663552;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.Valid;
			}
			set
			{
				short num = (short)1159446096;
				short num2 = num;
				num = (short)636337744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1287454720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)253034496;
				if (num != 0)
				{
				}
				num = (short)1904017409;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonKey_A22526.Valid = value;
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x06007850 RID: 30800 RVA: 0x006D4BA4 File Offset: 0x006D2DA4
		// (set) Token: 0x06007851 RID: 30801 RVA: 0x006D4C5C File Offset: 0x006D2E5C
		public bool RadErgoCfgRSMButtonKey_A22526_Visible
		{
			get
			{
				short num = (short)573964289;
				if (num != 0)
				{
				}
				num = (short)1036255232;
				short num2 = num;
				num = (short)1185929859;
				short num3 = num;
				num = (short)848288387;
				switch (num3 == num)
				{
				}
				num = (short)1377828864;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.Visible;
			}
			set
			{
				short num = (short)36634625;
				if (num != 0)
				{
				}
				num = (short)1560215552;
				short num2 = num;
				num = (short)1691379262;
				short num3 = num;
				num = (short)832988734;
				switch (num3 == num)
				{
				}
				num = (short)1617756160;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonKey_A22526.Visible = value;
			}
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x06007852 RID: 30802 RVA: 0x006D4D14 File Offset: 0x006D2F14
		// (set) Token: 0x06007853 RID: 30803 RVA: 0x006D4DC8 File Offset: 0x006D2FC8
		public bool RadErgoCfgRSMButtonKey_A22526_Editable
		{
			get
			{
				short num = (short)1965011620;
				short num2 = num;
				num = (short)353284772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)171966464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)105316353;
				if (num != 0)
				{
				}
				num = (short)409731072;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.Editable;
			}
			set
			{
				short num = (short)1893912840;
				short num2 = num;
				num = (short)1167511816;
				switch (num2 == num)
				{
				}
				num = (short)1089536001;
				if (num != 0)
				{
				}
				num = (short)322633728;
				short num3 = num;
				num = (short)546635776;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonKey_A22526.Editable = value;
			}
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x006D4E7C File Offset: 0x006D307C
		internal string RadErgoCfgRSMButtonKey_A22526_UILabel
		{
			get
			{
				short num = (short)192392878;
				short num2 = num;
				num = (short)152022702;
				switch (num2 == num)
				{
				}
				num = (short)65339393;
				if (num != 0)
				{
				}
				num = (short)1748172800;
				short num3 = num;
				num = (short)1722613760;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.UIName;
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x06007855 RID: 30805 RVA: 0x006D4F30 File Offset: 0x006D3130
		// (set) Token: 0x06007856 RID: 30806 RVA: 0x006D4FE4 File Offset: 0x006D31E4
		internal bool RadErgoCfgRSMButtonKey_A22526_HiddenStatic
		{
			get
			{
				short num = (short)826306035;
				short num2 = num;
				num = (short)696872435;
				switch (num2 == num)
				{
				}
				num = (short)812122112;
				if (num != 0)
				{
				}
				num = (short)363462656;
				short num3 = num;
				num = (short)2083848193;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.HiddenStatic;
			}
			set
			{
				short num = (short)858621015;
				short num2 = num;
				num = (short)719881303;
				switch (num2 == num)
				{
				}
				num = (short)1721827329;
				if (num != 0)
				{
				}
				num = (short)1164771328;
				short num3 = num;
				num = (short)855506944;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonKey_A22526.HiddenStatic = value;
			}
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x06007857 RID: 30807 RVA: 0x006D509C File Offset: 0x006D329C
		// (set) Token: 0x06007858 RID: 30808 RVA: 0x006D5150 File Offset: 0x006D3350
		internal bool RadErgoCfgRSMButtonKey_A22526_HiddenDynamic
		{
			get
			{
				short num = (short)1387738581;
				short num2 = num;
				num = (short)38548949;
				switch (num2 == num)
				{
				}
				num = (short)108331009;
				if (num != 0)
				{
				}
				num = (short)587268096;
				short num3 = num;
				num = (short)1734213632;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526.HiddenDynamic;
			}
			set
			{
				short num = (short)1476506336;
				short num2 = num;
				num = (short)1303032544;
				switch (num2 == num)
				{
				}
				num = (short)1651965953;
				if (num != 0)
				{
				}
				num = (short)1314652160;
				short num3 = num;
				num = (short)1983447040;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonKey_A22526.HiddenDynamic = value;
			}
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x06007859 RID: 30809 RVA: 0x006D5204 File Offset: 0x006D3404
		public bool RadErgoCfgRSMButtonKey_A22526_HasDiffs
		{
			get
			{
				short num = (short)1589811076;
				short num2 = num;
				num = (short)1053792132;
				switch (num2 == num)
				{
				}
				num = (short)1166999553;
				if (num != 0)
				{
				}
				num = (short)276430848;
				short num3 = num;
				num = (short)1692532736;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonKey_A22526._HasDiffs;
			}
		}

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x0600785A RID: 30810 RVA: 0x006D52B8 File Offset: 0x006D34B8
		// (set) Token: 0x0600785B RID: 30811 RVA: 0x006D5370 File Offset: 0x006D3570
		public int RadErgoCfgRSMlTopButtonShortPressTimeValue
		{
			get
			{
				short num = (short)1554247711;
				short num2 = num;
				num = (short)1623453727;
				switch (num2 == num)
				{
				}
				num = (short)703397888;
				if (num != 0)
				{
				}
				num = (short)1128005632;
				short num3 = num;
				num = (short)1702232065;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)1310401376;
				short num2 = num;
				num = (short)642327392;
				switch (num2 == num)
				{
				}
				num = (short)1131610113;
				if (num != 0)
				{
				}
				num = (short)1576534016;
				short num3 = num;
				num = (short)1264582656;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonShortPressTime.Value = value;
			}
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x0600785C RID: 30812 RVA: 0x006D5424 File Offset: 0x006D3624
		// (set) Token: 0x0600785D RID: 30813 RVA: 0x006D54D8 File Offset: 0x006D36D8
		public string RadErgoCfgRSMlTopButtonShortPressTime_UIValue
		{
			get
			{
				short num = (short)1142215531;
				short num2 = num;
				num = (short)1679479659;
				switch (num2 == num)
				{
				}
				num = (short)1841364993;
				if (num != 0)
				{
				}
				num = (short)681574400;
				short num3 = num;
				num = (short)355598336;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.UIValue;
			}
			set
			{
				short num = (short)448115722;
				short num2 = num;
				num = (short)1275048970;
				switch (num2 == num)
				{
				}
				num = (short)1212547073;
				if (num != 0)
				{
				}
				num = (short)1349910528;
				short num3 = num;
				num = (short)1770323968;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x0600785E RID: 30814 RVA: 0x006D5590 File Offset: 0x006D3790
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgoCfgRSMlTopButtonShortPressTime
		{
			get
			{
				short num = (short)838985244;
				short num2 = num;
				num = (short)1975838236;
				switch (num2 == num)
				{
				}
				num = (short)1639972864;
				if (num != 0)
				{
				}
				num = (short)1916665856;
				short num3 = num;
				num = (short)1286078465;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime;
			}
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x0600785F RID: 30815 RVA: 0x006D5640 File Offset: 0x006D3840
		// (set) Token: 0x06007860 RID: 30816 RVA: 0x006D56F4 File Offset: 0x006D38F4
		public bool RadErgoCfgRSMlTopButtonShortPressTime_Applicable
		{
			get
			{
				short num = (short)1899888641;
				if (num != 0)
				{
				}
				num = (short)1365661030;
				short num2 = num;
				num = (short)892556646;
				switch (num2 == num)
				{
				}
				num = (short)917700608;
				short num3 = num;
				num = (short)1865089024;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.Applicable;
			}
			set
			{
				short num = (short)2048559639;
				short num2 = num;
				num = (short)103189015;
				switch (num2 == num)
				{
				}
				num = (short)2078146561;
				if (num != 0)
				{
				}
				num = (short)1854472192;
				short num3 = num;
				num = (short)650903552;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x06007861 RID: 30817 RVA: 0x006D57A8 File Offset: 0x006D39A8
		// (set) Token: 0x06007862 RID: 30818 RVA: 0x006D585C File Offset: 0x006D3A5C
		public bool RadErgoCfgRSMlTopButtonShortPressTime_Valid
		{
			get
			{
				short num = (short)168256360;
				short num2 = num;
				num = (short)836920168;
				switch (num2 == num)
				{
				}
				num = (short)735903744;
				if (num != 0)
				{
				}
				num = (short)1337917440;
				short num3 = num;
				num = (short)2124677121;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.Valid;
			}
			set
			{
				short num = (short)62455809;
				if (num != 0)
				{
				}
				num = (short)1114432431;
				short num2 = num;
				num = (short)262661039;
				switch (num2 == num)
				{
				}
				num = (short)1817837568;
				short num3 = num;
				num = (short)1519452160;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonShortPressTime.Valid = value;
			}
		}

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x06007863 RID: 30819 RVA: 0x006D5910 File Offset: 0x006D3B10
		// (set) Token: 0x06007864 RID: 30820 RVA: 0x006D59C4 File Offset: 0x006D3BC4
		public bool RadErgoCfgRSMlTopButtonShortPressTime_Visible
		{
			get
			{
				short num = (short)215039039;
				short num2 = num;
				num = (short)200031295;
				switch (num2 == num)
				{
				}
				num = (short)2031747073;
				if (num != 0)
				{
				}
				num = (short)182583296;
				short num3 = num;
				num = (short)2093350912;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.Visible;
			}
			set
			{
				short num = (short)301983539;
				short num2 = num;
				num = (short)631629619;
				switch (num2 == num)
				{
				}
				num = (short)1194328064;
				if (num != 0)
				{
				}
				num = (short)869335040;
				short num3 = num;
				num = (short)418775041;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonShortPressTime.Visible = value;
			}
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x06007865 RID: 30821 RVA: 0x006D5A7C File Offset: 0x006D3C7C
		// (set) Token: 0x06007866 RID: 30822 RVA: 0x006D5B30 File Offset: 0x006D3D30
		public bool RadErgoCfgRSMlTopButtonShortPressTime_Editable
		{
			get
			{
				short num = (short)523304961;
				if (num != 0)
				{
				}
				num = (short)529586505;
				short num2 = num;
				num = (short)1548998985;
				switch (num2 == num)
				{
				}
				num = (short)1165950976;
				short num3 = num;
				num = (short)209780736;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.Editable;
			}
			set
			{
				short num = (short)840630273;
				if (num != 0)
				{
				}
				num = (short)472455471;
				short num2 = num;
				num = (short)2009602351;
				switch (num2 == num)
				{
				}
				num = (short)912850944;
				short num3 = num;
				num = (short)473628672;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonShortPressTime.Editable = value;
			}
		}

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x06007867 RID: 30823 RVA: 0x006D5BE4 File Offset: 0x006D3DE4
		internal string RadErgoCfgRSMlTopButtonShortPressTime_UILabel
		{
			get
			{
				short num = (short)1265247734;
				short num2 = num;
				num = (short)407447030;
				switch (num2 == num)
				{
				}
				num = (short)377815040;
				if (num != 0)
				{
				}
				num = (short)664076288;
				short num3 = num;
				num = (short)1655635969;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.UIName;
			}
		}

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x06007868 RID: 30824 RVA: 0x006D5C98 File Offset: 0x006D3E98
		// (set) Token: 0x06007869 RID: 30825 RVA: 0x006D5D4C File Offset: 0x006D3F4C
		internal bool RadErgoCfgRSMlTopButtonShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1122858124;
				short num2 = num;
				num = (short)889943180;
				switch (num2 == num)
				{
				}
				num = (short)1259405313;
				if (num != 0)
				{
				}
				num = (short)137560064;
				short num3 = num;
				num = (short)1578041344;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)795559438;
				short num2 = num;
				num = (short)1309689358;
				switch (num2 == num)
				{
				}
				num = (short)1004929024;
				if (num != 0)
				{
				}
				num = (short)1299185664;
				short num3 = num;
				num = (short)1571684353;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x0600786A RID: 30826 RVA: 0x006D5E00 File Offset: 0x006D4000
		// (set) Token: 0x0600786B RID: 30827 RVA: 0x006D5EB8 File Offset: 0x006D40B8
		internal bool RadErgoCfgRSMlTopButtonShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1873357333;
				short num2 = num;
				num = (short)1147808277;
				switch (num2 == num)
				{
				}
				num = (short)1896284161;
				if (num != 0)
				{
				}
				num = (short)171114496;
				short num3 = num;
				num = (short)1113260032;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)347979947;
				short num2 = num;
				num = (short)1582940331;
				switch (num2 == num)
				{
				}
				num = (short)1338179585;
				if (num != 0)
				{
				}
				num = (short)522649600;
				short num3 = num;
				num = (short)2017525760;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x0600786C RID: 30828 RVA: 0x006D5F6C File Offset: 0x006D416C
		public bool RadErgoCfgRSMlTopButtonShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)83709010;
				short num2 = num;
				num = (short)24202322;
				switch (num2 == num)
				{
				}
				num = (short)1879048192;
				if (num != 0)
				{
				}
				num = (short)1433468928;
				short num3 = num;
				num = (short)1910308865;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x0600786D RID: 30829 RVA: 0x006D6020 File Offset: 0x006D4220
		// (set) Token: 0x0600786E RID: 30830 RVA: 0x006D60D4 File Offset: 0x006D42D4
		public string RadErgoCfgRSMButtonName_A22527Value
		{
			get
			{
				short num = (short)659947538;
				short num2 = num;
				num = (short)2949138;
				switch (num2 == num)
				{
				}
				num = (short)587137025;
				if (num != 0)
				{
				}
				num = (short)794099712;
				short num3 = num;
				num = (short)341245952;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.Value;
			}
			set
			{
				short num = (short)1760366248;
				short num2 = num;
				num = (short)4591272;
				switch (num2 == num)
				{
				}
				num = (short)1517879296;
				if (num != 0)
				{
				}
				num = (short)1117061120;
				short num3 = num;
				num = (short)420937729;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonName_A22527.Value = value;
			}
		}

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x0600786F RID: 30831 RVA: 0x006D618C File Offset: 0x006D438C
		public global::AcpBusinessLayer.AcpField<string> RadErgoCfgRSMButtonName_A22527
		{
			get
			{
				short num = (short)856092086;
				short num2 = num;
				num = (short)149941686;
				switch (num2 == num)
				{
				}
				num = (short)1004208129;
				if (num != 0)
				{
				}
				num = (short)960823296;
				short num3 = num;
				num = (short)182386688;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527;
			}
		}

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x06007870 RID: 30832 RVA: 0x006D6240 File Offset: 0x006D4440
		// (set) Token: 0x06007871 RID: 30833 RVA: 0x006D62F4 File Offset: 0x006D44F4
		public string RadErgoCfgRSMButtonName_A22527_UIValue
		{
			get
			{
				short num = (short)513145520;
				short num2 = num;
				num = (short)335936176;
				switch (num2 == num)
				{
				}
				num = (short)1277100033;
				if (num != 0)
				{
				}
				num = (short)559480832;
				short num3 = num;
				num = (short)1619722240;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.Value;
			}
			set
			{
				short num = (short)457067573;
				short num2 = num;
				num = (short)80104501;
				switch (num2 == num)
				{
				}
				num = (short)1798635520;
				if (num != 0)
				{
				}
				num = (short)1495990272;
				short num3 = num;
				num = (short)1144520705;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonName_A22527.Value = value;
			}
		}

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x06007872 RID: 30834 RVA: 0x006D63A8 File Offset: 0x006D45A8
		// (set) Token: 0x06007873 RID: 30835 RVA: 0x006D645C File Offset: 0x006D465C
		public bool RadErgoCfgRSMButtonName_A22527_Applicable
		{
			get
			{
				short num = (short)2115257144;
				short num2 = num;
				num = (short)591872824;
				switch (num2 == num)
				{
				}
				num = (short)44302337;
				if (num != 0)
				{
				}
				num = (short)1101594624;
				short num3 = num;
				num = (short)1071579136;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.Applicable;
			}
			set
			{
				short num = (short)881730091;
				short num2 = num;
				num = (short)905585195;
				switch (num2 == num)
				{
				}
				num = (short)2017787904;
				if (num != 0)
				{
				}
				num = (short)1085800448;
				short num3 = num;
				num = (short)1459027969;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonName_A22527.Applicable = value;
			}
		}

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x06007874 RID: 30836 RVA: 0x006D6514 File Offset: 0x006D4714
		// (set) Token: 0x06007875 RID: 30837 RVA: 0x006D65CC File Offset: 0x006D47CC
		public bool RadErgoCfgRSMButtonName_A22527_Valid
		{
			get
			{
				short num = (short)234771029;
				short num2 = num;
				num = (short)1623741013;
				switch (num2 == num)
				{
				}
				num = (short)324272129;
				if (num != 0)
				{
				}
				num = (short)1758199808;
				short num3 = num;
				num = (short)1150746624;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.Valid;
			}
			set
			{
				short num = (short)459886338;
				short num2 = num;
				num = (short)781209346;
				switch (num2 == num)
				{
				}
				num = (short)358481921;
				if (num != 0)
				{
				}
				num = (short)63242240;
				short num3 = num;
				num = (short)169541632;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonName_A22527.Valid = value;
			}
		}

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x06007876 RID: 30838 RVA: 0x006D6684 File Offset: 0x006D4884
		// (set) Token: 0x06007877 RID: 30839 RVA: 0x006D673C File Offset: 0x006D493C
		public bool RadErgoCfgRSMButtonName_A22527_Visible
		{
			get
			{
				short num = (short)1363112044;
				short num2 = num;
				num = (short)994275436;
				switch (num2 == num)
				{
				}
				num = (short)1127612416;
				if (num != 0)
				{
				}
				num = (short)1275723776;
				short num3 = num;
				num = (short)81395713;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.Visible;
			}
			set
			{
				short num = (short)269157034;
				short num2 = num;
				num = (short)1275200170;
				switch (num2 == num)
				{
				}
				num = (short)1962082305;
				if (num != 0)
				{
				}
				num = (short)713424896;
				short num3 = num;
				num = (short)2108686336;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonName_A22527.Visible = value;
			}
		}

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x06007878 RID: 30840 RVA: 0x006D67F0 File Offset: 0x006D49F0
		// (set) Token: 0x06007879 RID: 30841 RVA: 0x006D68A8 File Offset: 0x006D4AA8
		public bool RadErgoCfgRSMButtonName_A22527_Editable
		{
			get
			{
				short num = (short)328466279;
				short num2 = num;
				num = (short)1138360167;
				switch (num2 == num)
				{
				}
				num = (short)498597889;
				if (num != 0)
				{
				}
				num = (short)620363776;
				short num3 = num;
				num = (short)616890368;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.Editable;
			}
			set
			{
				short num = (short)125749141;
				short num2 = num;
				num = (short)1417529237;
				switch (num2 == num)
				{
				}
				num = (short)370540545;
				if (num != 0)
				{
				}
				num = (short)1507590144;
				short num3 = num;
				num = (short)1171652608;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonName_A22527.Editable = value;
			}
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x0600787A RID: 30842 RVA: 0x006D695C File Offset: 0x006D4B5C
		internal string RadErgoCfgRSMButtonName_A22527_UILabel
		{
			get
			{
				short num = (short)337715024;
				short num2 = num;
				num = (short)240131920;
				switch (num2 == num)
				{
				}
				num = (short)718340097;
				if (num != 0)
				{
				}
				num = (short)1125908480;
				short num3 = num;
				num = (short)135069696;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.UIName;
			}
		}

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x0600787B RID: 30843 RVA: 0x006D6A10 File Offset: 0x006D4C10
		// (set) Token: 0x0600787C RID: 30844 RVA: 0x006D6AC4 File Offset: 0x006D4CC4
		internal bool RadErgoCfgRSMButtonName_A22527_HiddenStatic
		{
			get
			{
				short num = (short)601777279;
				short num2 = num;
				num = (short)1368417407;
				switch (num2 == num)
				{
				}
				num = (short)1015218177;
				if (num != 0)
				{
				}
				num = (short)1583677440;
				short num3 = num;
				num = (short)788594688;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.HiddenStatic;
			}
			set
			{
				short num = (short)1215385141;
				short num2 = num;
				num = (short)569527861;
				switch (num2 == num)
				{
				}
				num = (short)1471348737;
				if (num != 0)
				{
				}
				num = (short)1360003072;
				short num3 = num;
				num = (short)571211776;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonName_A22527.HiddenStatic = value;
			}
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x0600787D RID: 30845 RVA: 0x006D6B7C File Offset: 0x006D4D7C
		// (set) Token: 0x0600787E RID: 30846 RVA: 0x006D6C30 File Offset: 0x006D4E30
		internal bool RadErgoCfgRSMButtonName_A22527_HiddenDynamic
		{
			get
			{
				short num = (short)1817938978;
				short num2 = num;
				num = (short)890539042;
				switch (num2 == num)
				{
				}
				num = (short)916389889;
				if (num != 0)
				{
				}
				num = (short)2143748096;
				short num3 = num;
				num = (short)1852899328;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527.HiddenDynamic;
			}
			set
			{
				short num = (short)1361054360;
				short num2 = num;
				num = (short)1182272152;
				switch (num2 == num)
				{
				}
				num = (short)986710017;
				if (num != 0)
				{
				}
				num = (short)1960771584;
				short num3 = num;
				num = (short)1502609408;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMButtonName_A22527.HiddenDynamic = value;
			}
		}

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x0600787F RID: 30847 RVA: 0x006D6CE4 File Offset: 0x006D4EE4
		public bool RadErgoCfgRSMButtonName_A22527_HasDiffs
		{
			get
			{
				short num = (short)453399120;
				short num2 = num;
				num = (short)929452624;
				switch (num2 == num)
				{
				}
				num = (short)855638016;
				if (num != 0)
				{
				}
				num = (short)550174720;
				short num3 = num;
				num = (short)1139802113;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMButtonName_A22527._HasDiffs;
			}
		}

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x06007880 RID: 30848 RVA: 0x006D6D98 File Offset: 0x006D4F98
		// (set) Token: 0x06007881 RID: 30849 RVA: 0x006D6E4C File Offset: 0x006D504C
		public int RadErgoCfgRSMlConventionalFeature_A19640Value
		{
			get
			{
				short num = (short)178619384;
				short num2 = num;
				num = (short)2129298424;
				switch (num2 == num)
				{
				}
				num = (short)1127546881;
				if (num != 0)
				{
				}
				num = (short)1719402496;
				short num3 = num;
				num = (short)444727296;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.Value;
			}
			set
			{
				short num = (short)1521336590;
				short num2 = num;
				num = (short)1597096206;
				switch (num2 == num)
				{
				}
				num = (short)2103312385;
				if (num != 0)
				{
				}
				num = (short)186056704;
				short num3 = num;
				num = (short)542507008;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlConventionalFeature_A19640.Value = value;
			}
		}

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x06007882 RID: 30850 RVA: 0x006D6F04 File Offset: 0x006D5104
		// (set) Token: 0x06007883 RID: 30851 RVA: 0x006D6FB8 File Offset: 0x006D51B8
		public string RadErgoCfgRSMlConventionalFeature_A19640_UIValue
		{
			get
			{
				short num = (short)987630331;
				short num2 = num;
				num = (short)1102777083;
				switch (num2 == num)
				{
				}
				num = (short)519962625;
				if (num != 0)
				{
				}
				num = (short)669188096;
				short num3 = num;
				num = (short)1634664448;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.UIValue;
			}
			set
			{
				short num = (short)1008591602;
				short num2 = num;
				num = (short)188015346;
				switch (num2 == num)
				{
				}
				num = (short)2103508993;
				if (num != 0)
				{
				}
				num = (short)1841627136;
				short num3 = num;
				num = (short)885522432;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlConventionalFeature_A19640.UIValue = value;
			}
		}

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x006D7070 File Offset: 0x006D5270
		public global::AcpBusinessLayer.AcpListField RadErgoCfgRSMlConventionalFeature_A19640
		{
			get
			{
				short num = (short)1072756020;
				short num2 = num;
				num = (short)1298462004;
				switch (num2 == num)
				{
				}
				num = (short)1280770048;
				if (num != 0)
				{
				}
				num = (short)1821114368;
				short num3 = num;
				num = (short)2032795649;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640;
			}
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x06007885 RID: 30853 RVA: 0x006D711C File Offset: 0x006D531C
		// (set) Token: 0x06007886 RID: 30854 RVA: 0x006D71D0 File Offset: 0x006D53D0
		public bool RadErgoCfgRSMlConventionalFeature_A19640_Applicable
		{
			get
			{
				short num = (short)1216479233;
				if (num != 0)
				{
				}
				num = (short)2132791504;
				short num2 = num;
				num = (short)114086096;
				switch (num2 == num)
				{
				}
				num = (short)2090795008;
				short num3 = num;
				num = (short)1199374336;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.Applicable;
			}
			set
			{
				short num = (short)2105136924;
				short num2 = num;
				num = (short)469227292;
				switch (num2 == num)
				{
				}
				num = (short)473038848;
				if (num != 0)
				{
				}
				num = (short)1033371648;
				short num3 = num;
				num = (short)989069313;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlConventionalFeature_A19640.Applicable = value;
			}
		}

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x06007887 RID: 30855 RVA: 0x006D7284 File Offset: 0x006D5484
		// (set) Token: 0x06007888 RID: 30856 RVA: 0x006D7334 File Offset: 0x006D5534
		public bool RadErgoCfgRSMlConventionalFeature_A19640_Valid
		{
			get
			{
				short num = (short)1768358201;
				short num2 = num;
				num = (short)884932921;
				switch (num2 == num)
				{
				}
				num = (short)1998192640;
				if (num != 0)
				{
				}
				num = (short)614137856;
				short num3 = num;
				num = (short)627179521;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.Valid;
			}
			set
			{
				short num = (short)94784783;
				short num2 = num;
				num = (short)978144527;
				switch (num2 == num)
				{
				}
				num = (short)305856512;
				if (num != 0)
				{
				}
				num = (short)1974272000;
				short num3 = num;
				num = (short)668139521;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlConventionalFeature_A19640.Valid = value;
			}
		}

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x06007889 RID: 30857 RVA: 0x006D73EC File Offset: 0x006D55EC
		// (set) Token: 0x0600788A RID: 30858 RVA: 0x006D74A0 File Offset: 0x006D56A0
		public bool RadErgoCfgRSMlConventionalFeature_A19640_Visible
		{
			get
			{
				short num = (short)940608685;
				short num2 = num;
				num = (short)898337965;
				switch (num2 == num)
				{
				}
				num = (short)1708392449;
				if (num != 0)
				{
				}
				num = (short)1764491264;
				short num3 = num;
				num = (short)1238171648;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.Visible;
			}
			set
			{
				short num = (short)2057699329;
				if (num != 0)
				{
				}
				num = (short)672160892;
				short num2 = num;
				num = (short)2090294396;
				switch (num2 == num)
				{
				}
				num = (short)70123520;
				short num3 = num;
				num = (short)75300864;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlConventionalFeature_A19640.Visible = value;
			}
		}

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x0600788B RID: 30859 RVA: 0x006D7558 File Offset: 0x006D5758
		// (set) Token: 0x0600788C RID: 30860 RVA: 0x006D760C File Offset: 0x006D580C
		public bool RadErgoCfgRSMlConventionalFeature_A19640_Editable
		{
			get
			{
				short num = (short)777611423;
				short num2 = num;
				num = (short)1144219807;
				switch (num2 == num)
				{
				}
				num = (short)1757216769;
				if (num != 0)
				{
				}
				num = (short)1602420736;
				short num3 = num;
				num = (short)1038548992;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.Editable;
			}
			set
			{
				short num = (short)665469918;
				short num2 = num;
				num = (short)1219511262;
				switch (num2 == num)
				{
				}
				num = (short)1947402241;
				if (num != 0)
				{
				}
				num = (short)812580864;
				short num3 = num;
				num = (short)1394868224;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlConventionalFeature_A19640.Editable = value;
			}
		}

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0600788D RID: 30861 RVA: 0x006D76C0 File Offset: 0x006D58C0
		internal string RadErgoCfgRSMlConventionalFeature_A19640_UILabel
		{
			get
			{
				short num = (short)2006631340;
				short num2 = num;
				num = (short)2015609772;
				switch (num2 == num)
				{
				}
				num = (short)330694657;
				if (num != 0)
				{
				}
				num = (short)1405943808;
				short num3 = num;
				num = (short)1070727168;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.UIName;
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0600788E RID: 30862 RVA: 0x006D7774 File Offset: 0x006D5974
		// (set) Token: 0x0600788F RID: 30863 RVA: 0x006D7828 File Offset: 0x006D5A28
		internal bool RadErgoCfgRSMlConventionalFeature_A19640_HiddenStatic
		{
			get
			{
				short num = (short)2053368194;
				short num2 = num;
				num = (short)70773122;
				switch (num2 == num)
				{
				}
				num = (short)337117185;
				if (num != 0)
				{
				}
				num = (short)2001862656;
				short num3 = num;
				num = (short)1039335424;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.HiddenStatic;
			}
			set
			{
				short num = (short)1245491917;
				short num2 = num;
				num = (short)1993781965;
				switch (num2 == num)
				{
				}
				num = (short)1311178753;
				if (num != 0)
				{
				}
				num = (short)1270874112;
				short num3 = num;
				num = (short)423100416;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlConventionalFeature_A19640.HiddenStatic = value;
			}
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x06007890 RID: 30864 RVA: 0x006D78DC File Offset: 0x006D5ADC
		// (set) Token: 0x06007891 RID: 30865 RVA: 0x006D7990 File Offset: 0x006D5B90
		internal bool RadErgoCfgRSMlConventionalFeature_A19640_HiddenDynamic
		{
			get
			{
				short num = (short)1527679196;
				short num2 = num;
				num = (short)1509722332;
				switch (num2 == num)
				{
				}
				num = (short)1440612352;
				if (num != 0)
				{
				}
				num = (short)342032384;
				short num3 = num;
				num = (short)547160065;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640.HiddenDynamic;
			}
			set
			{
				short num = (short)723911272;
				short num2 = num;
				num = (short)935461480;
				switch (num2 == num)
				{
				}
				num = (short)1865809921;
				if (num != 0)
				{
				}
				num = (short)63569920;
				short num3 = num;
				num = (short)1034158080;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlConventionalFeature_A19640.HiddenDynamic = value;
			}
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x06007892 RID: 30866 RVA: 0x006D7A44 File Offset: 0x006D5C44
		public bool RadErgoCfgRSMlConventionalFeature_A19640_HasDiffs
		{
			get
			{
				short num = (short)1405036720;
				short num2 = num;
				num = (short)808396976;
				switch (num2 == num)
				{
				}
				num = (short)1522532353;
				if (num != 0)
				{
				}
				num = (short)1997078528;
				short num3 = num;
				num = (short)500957184;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlConventionalFeature_A19640._HasDiffs;
			}
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x06007893 RID: 30867 RVA: 0x006D7AF8 File Offset: 0x006D5CF8
		// (set) Token: 0x06007894 RID: 30868 RVA: 0x006D7BAC File Offset: 0x006D5DAC
		public int RadErgoCfgRSMlTrunkingFeature_A19742Value
		{
			get
			{
				short num = (short)1260488502;
				short num2 = num;
				num = (short)263817014;
				switch (num2 == num)
				{
				}
				num = (short)900333569;
				if (num != 0)
				{
				}
				num = (short)2085552128;
				short num3 = num;
				num = (short)1820983296;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.Value;
			}
			set
			{
				short num = (short)1434320897;
				if (num != 0)
				{
				}
				num = (short)601977042;
				short num2 = num;
				num = (short)203518162;
				switch (num2 == num)
				{
				}
				num = (short)1042219008;
				short num3 = num;
				num = (short)1377697792;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTrunkingFeature_A19742.Value = value;
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x06007895 RID: 30869 RVA: 0x006D7C64 File Offset: 0x006D5E64
		// (set) Token: 0x06007896 RID: 30870 RVA: 0x006D7D14 File Offset: 0x006D5F14
		public string RadErgoCfgRSMlTrunkingFeature_A19742_UIValue
		{
			get
			{
				short num = (short)1406125040;
				short num2 = num;
				num = (short)1596572656;
				switch (num2 == num)
				{
				}
				num = (short)2033319936;
				if (num != 0)
				{
				}
				num = (short)1205731328;
				short num3 = num;
				num = (short)1282473985;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.UIValue;
			}
			set
			{
				short num = (short)1803682577;
				short num2 = num;
				num = (short)691667729;
				switch (num2 == num)
				{
				}
				num = (short)1047789568;
				if (num != 0)
				{
				}
				num = (short)723517440;
				short num3 = num;
				num = (short)1471021057;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTrunkingFeature_A19742.UIValue = value;
			}
		}

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x06007897 RID: 30871 RVA: 0x006D7DD0 File Offset: 0x006D5FD0
		public global::AcpBusinessLayer.AcpListField RadErgoCfgRSMlTrunkingFeature_A19742
		{
			get
			{
				short num = (short)106758145;
				if (num != 0)
				{
				}
				num = (short)1635662612;
				short num2 = num;
				num = (short)687815444;
				switch (num2 == num)
				{
				}
				num = (short)1709047808;
				short num3 = num;
				num = (short)786956288;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742;
			}
		}

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x06007898 RID: 30872 RVA: 0x006D7E7C File Offset: 0x006D607C
		// (set) Token: 0x06007899 RID: 30873 RVA: 0x006D7F34 File Offset: 0x006D6134
		public bool RadErgoCfgRSMlTrunkingFeature_A19742_Applicable
		{
			get
			{
				short num = (short)431685633;
				if (num != 0)
				{
				}
				num = (short)1842344700;
				short num2 = num;
				num = (short)72348412;
				switch (num2 == num)
				{
				}
				num = (short)194117632;
				short num3 = num;
				num = (short)1002700800;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.Applicable;
			}
			set
			{
				short num = (short)1438834949;
				short num2 = num;
				num = (short)1311432965;
				switch (num2 == num)
				{
				}
				num = (short)1026359297;
				if (num != 0)
				{
				}
				num = (short)325189632;
				short num3 = num;
				num = (short)1064435712;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTrunkingFeature_A19742.Applicable = value;
			}
		}

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x006D7FE8 File Offset: 0x006D61E8
		// (set) Token: 0x0600789B RID: 30875 RVA: 0x006D809C File Offset: 0x006D629C
		public bool RadErgoCfgRSMlTrunkingFeature_A19742_Valid
		{
			get
			{
				short num = (short)1738751191;
				short num2 = num;
				num = (short)1357397207;
				switch (num2 == num)
				{
				}
				num = (short)692977665;
				if (num != 0)
				{
				}
				num = (short)67633152;
				short num3 = num;
				num = (short)1566507008;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.Valid;
			}
			set
			{
				short num = (short)1650991005;
				short num2 = num;
				num = (short)1737760669;
				switch (num2 == num)
				{
				}
				num = (short)475070465;
				if (num != 0)
				{
				}
				num = (short)1482948608;
				short num3 = num;
				num = (short)1345519616;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTrunkingFeature_A19742.Valid = value;
			}
		}

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x0600789C RID: 30876 RVA: 0x006D8150 File Offset: 0x006D6350
		// (set) Token: 0x0600789D RID: 30877 RVA: 0x006D8208 File Offset: 0x006D6408
		public bool RadErgoCfgRSMlTrunkingFeature_A19742_Visible
		{
			get
			{
				short num = (short)758102520;
				short num2 = num;
				num = (short)1009367544;
				switch (num2 == num)
				{
				}
				num = (short)1374158848;
				if (num != 0)
				{
				}
				num = (short)1100152832;
				short num3 = num;
				num = (short)554958849;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.Visible;
			}
			set
			{
				short num = (short)184530095;
				short num2 = num;
				num = (short)1421063343;
				switch (num2 == num)
				{
				}
				num = (short)696713216;
				if (num != 0)
				{
				}
				num = (short)2135490560;
				short num3 = num;
				num = (short)132579329;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTrunkingFeature_A19742.Visible = value;
			}
		}

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x0600789E RID: 30878 RVA: 0x006D82C0 File Offset: 0x006D64C0
		// (set) Token: 0x0600789F RID: 30879 RVA: 0x006D8374 File Offset: 0x006D6574
		public bool RadErgoCfgRSMlTrunkingFeature_A19742_Editable
		{
			get
			{
				short num = (short)190371777;
				short num2 = num;
				num = (short)1518917569;
				switch (num2 == num)
				{
				}
				num = (short)788463617;
				if (num != 0)
				{
				}
				num = (short)2115960832;
				short num3 = num;
				num = (short)312082432;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.Editable;
			}
			set
			{
				short num = (short)1144979457;
				if (num != 0)
				{
				}
				num = (short)476113001;
				short num2 = num;
				num = (short)477685865;
				switch (num2 == num)
				{
				}
				num = (short)2115764224;
				short num3 = num;
				num = (short)479199232;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTrunkingFeature_A19742.Editable = value;
			}
		}

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x006D842C File Offset: 0x006D662C
		internal string RadErgoCfgRSMlTrunkingFeature_A19742_UILabel
		{
			get
			{
				short num = (short)877199361;
				if (num != 0)
				{
				}
				num = (short)1024015222;
				short num2 = num;
				num = (short)767376246;
				switch (num2 == num)
				{
				}
				num = (short)559939584;
				short num3 = num;
				num = (short)1571422208;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.UIName;
			}
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x060078A1 RID: 30881 RVA: 0x006D84E4 File Offset: 0x006D66E4
		// (set) Token: 0x060078A2 RID: 30882 RVA: 0x006D8598 File Offset: 0x006D6798
		internal bool RadErgoCfgRSMlTrunkingFeature_A19742_HiddenStatic
		{
			get
			{
				short num = (short)182441925;
				short num2 = num;
				num = (short)1436669893;
				switch (num2 == num)
				{
				}
				num = (short)1668874241;
				if (num != 0)
				{
				}
				num = (short)304218112;
				short num3 = num;
				num = (short)665649152;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.HiddenStatic;
			}
			set
			{
				short num = (short)724909234;
				short num2 = num;
				num = (short)1393900722;
				switch (num2 == num)
				{
				}
				num = (short)1254948864;
				if (num != 0)
				{
				}
				num = (short)670892032;
				short num3 = num;
				num = (short)529334273;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTrunkingFeature_A19742.HiddenStatic = value;
			}
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x060078A3 RID: 30883 RVA: 0x006D8650 File Offset: 0x006D6850
		// (set) Token: 0x060078A4 RID: 30884 RVA: 0x006D8708 File Offset: 0x006D6908
		internal bool RadErgoCfgRSMlTrunkingFeature_A19742_HiddenDynamic
		{
			get
			{
				short num = (short)1282378564;
				short num2 = num;
				num = (short)1185450820;
				switch (num2 == num)
				{
				}
				num = (short)1298464769;
				if (num != 0)
				{
				}
				num = (short)504102912;
				short num3 = num;
				num = (short)1172766720;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742.HiddenDynamic;
			}
			set
			{
				short num = (short)1172239638;
				short num2 = num;
				num = (short)307623190;
				switch (num2 == num)
				{
				}
				num = (short)308936705;
				if (num != 0)
				{
				}
				num = (short)1989148672;
				short num3 = num;
				num = (short)255131648;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTrunkingFeature_A19742.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x060078A5 RID: 30885 RVA: 0x006D87C0 File Offset: 0x006D69C0
		public bool RadErgoCfgRSMlTrunkingFeature_A19742_HasDiffs
		{
			get
			{
				short num = (short)687156150;
				short num2 = num;
				num = (short)370355126;
				switch (num2 == num)
				{
				}
				num = (short)1546059777;
				if (num != 0)
				{
				}
				num = (short)777650176;
				short num3 = num;
				num = (short)1822359552;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTrunkingFeature_A19742._HasDiffs;
			}
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x006D8874 File Offset: 0x006D6A74
		// (set) Token: 0x060078A7 RID: 30887 RVA: 0x006D892C File Offset: 0x006D6B2C
		public int RadErgoCfgRSMlTopButtonLongPressTimeValue
		{
			get
			{
				short num = (short)1940715650;
				short num2 = num;
				num = (short)685308034;
				switch (num2 == num)
				{
				}
				num = (short)823263232;
				if (num != 0)
				{
				}
				num = (short)2029453312;
				short num3 = num;
				num = (short)1256980481;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.Value;
			}
			set
			{
				short num = (short)1231694303;
				short num2 = num;
				num = (short)29960671;
				switch (num2 == num)
				{
				}
				num = (short)1142947841;
				if (num != 0)
				{
				}
				num = (short)740950016;
				short num3 = num;
				num = (short)1165754368;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x060078A8 RID: 30888 RVA: 0x006D89E0 File Offset: 0x006D6BE0
		// (set) Token: 0x060078A9 RID: 30889 RVA: 0x006D8A98 File Offset: 0x006D6C98
		public string RadErgoCfgRSMlTopButtonLongPressTime_UIValue
		{
			get
			{
				short num = (short)1423275288;
				short num2 = num;
				num = (short)1194161432;
				switch (num2 == num)
				{
				}
				num = (short)686817280;
				if (num != 0)
				{
				}
				num = (short)133955584;
				short num3 = num;
				num = (short)1943928833;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.UIValue;
			}
			set
			{
				short num = (short)1190871550;
				short num2 = num;
				num = (short)453591550;
				switch (num2 == num)
				{
				}
				num = (short)17629185;
				if (num != 0)
				{
				}
				num = (short)1355087872;
				short num3 = num;
				num = (short)2040922112;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x060078AA RID: 30890 RVA: 0x006D8B50 File Offset: 0x006D6D50
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgoCfgRSMlTopButtonLongPressTime
		{
			get
			{
				short num = (short)1266406684;
				short num2 = num;
				num = (short)793040156;
				switch (num2 == num)
				{
				}
				num = (short)1131151360;
				if (num != 0)
				{
				}
				num = (short)2115829760;
				short num3 = num;
				num = (short)1837563905;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime;
			}
		}

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x060078AB RID: 30891 RVA: 0x006D8C00 File Offset: 0x006D6E00
		// (set) Token: 0x060078AC RID: 30892 RVA: 0x006D8CB4 File Offset: 0x006D6EB4
		public bool RadErgoCfgRSMlTopButtonLongPressTime_Applicable
		{
			get
			{
				short num = (short)1772340647;
				short num2 = num;
				num = (short)1072416167;
				switch (num2 == num)
				{
				}
				num = (short)1862860800;
				if (num != 0)
				{
				}
				num = (short)1248329728;
				short num3 = num;
				num = (short)98697217;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.Applicable;
			}
			set
			{
				short num = (short)304345734;
				short num2 = num;
				num = (short)1322316422;
				switch (num2 == num)
				{
				}
				num = (short)1894580225;
				if (num != 0)
				{
				}
				num = (short)1162936320;
				short num3 = num;
				num = (short)1756168192;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x060078AD RID: 30893 RVA: 0x006D8D68 File Offset: 0x006D6F68
		// (set) Token: 0x060078AE RID: 30894 RVA: 0x006D8E1C File Offset: 0x006D701C
		public bool RadErgoCfgRSMlTopButtonLongPressTime_Valid
		{
			get
			{
				short num = (short)920324044;
				short num2 = num;
				num = (short)1350174668;
				switch (num2 == num)
				{
				}
				num = (short)868417537;
				if (num != 0)
				{
				}
				num = (short)1154875392;
				short num3 = num;
				num = (short)1204682752;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.Valid;
			}
			set
			{
				short num = (short)148832257;
				if (num != 0)
				{
				}
				num = (short)1375321804;
				short num2 = num;
				num = (short)1555545804;
				switch (num2 == num)
				{
				}
				num = (short)171704320;
				short num3 = num;
				num = (short)1921449984;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonLongPressTime.Valid = value;
			}
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x060078AF RID: 30895 RVA: 0x006D8ED0 File Offset: 0x006D70D0
		// (set) Token: 0x060078B0 RID: 30896 RVA: 0x006D8F88 File Offset: 0x006D7188
		public bool RadErgoCfgRSMlTopButtonLongPressTime_Visible
		{
			get
			{
				short num = (short)325729211;
				short num2 = num;
				num = (short)1402682299;
				switch (num2 == num)
				{
				}
				num = (short)1209204737;
				if (num != 0)
				{
				}
				num = (short)309264384;
				short num3 = num;
				num = (short)606470144;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.Visible;
			}
			set
			{
				short num = (short)2019164161;
				if (num != 0)
				{
				}
				num = (short)1457708563;
				short num2 = num;
				num = (short)121167379;
				switch (num2 == num)
				{
				}
				num = (short)1142423552;
				short num3 = num;
				num = (short)2012545024;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonLongPressTime.Visible = value;
			}
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x060078B1 RID: 30897 RVA: 0x006D903C File Offset: 0x006D723C
		// (set) Token: 0x060078B2 RID: 30898 RVA: 0x006D90F0 File Offset: 0x006D72F0
		public bool RadErgoCfgRSMlTopButtonLongPressTime_Editable
		{
			get
			{
				short num = (short)1153133698;
				short num2 = num;
				num = (short)630811778;
				switch (num2 == num)
				{
				}
				num = (short)1766850560;
				if (num != 0)
				{
				}
				num = (short)633929728;
				short num3 = num;
				num = (short)886571009;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.Editable;
			}
			set
			{
				short num = (short)871816099;
				short num2 = num;
				num = (short)955636643;
				switch (num2 == num)
				{
				}
				num = (short)1993146369;
				if (num != 0)
				{
				}
				num = (short)546308096;
				short num3 = num;
				num = (short)481558528;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonLongPressTime.Editable = value;
			}
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x006D91A4 File Offset: 0x006D73A4
		internal string RadErgoCfgRSMlTopButtonLongPressTime_UILabel
		{
			get
			{
				short num = (short)1279019980;
				short num2 = num;
				num = (short)1768246220;
				switch (num2 == num)
				{
				}
				num = (short)542113793;
				if (num != 0)
				{
				}
				num = (short)772079616;
				short num3 = num;
				num = (short)307167232;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.UIName;
			}
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x060078B4 RID: 30900 RVA: 0x006D925C File Offset: 0x006D745C
		// (set) Token: 0x060078B5 RID: 30901 RVA: 0x006D9310 File Offset: 0x006D7510
		internal bool RadErgoCfgRSMlTopButtonLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1149920114;
				short num2 = num;
				num = (short)241918834;
				switch (num2 == num)
				{
				}
				num = (short)1679163393;
				if (num != 0)
				{
				}
				num = (short)469762048;
				short num3 = num;
				num = (short)637140992;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1787069282;
				short num2 = num;
				num = (short)641565538;
				switch (num2 == num)
				{
				}
				num = (short)1585053697;
				if (num != 0)
				{
				}
				num = (short)1681850368;
				short num3 = num;
				num = (short)1604386816;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x060078B6 RID: 30902 RVA: 0x006D93C8 File Offset: 0x006D75C8
		// (set) Token: 0x060078B7 RID: 30903 RVA: 0x006D947C File Offset: 0x006D767C
		internal bool RadErgoCfgRSMlTopButtonLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1513021821;
				short num2 = num;
				num = (short)323215741;
				switch (num2 == num)
				{
				}
				num = (short)430637056;
				if (num != 0)
				{
				}
				num = (short)2022113280;
				short num3 = num;
				num = (short)1002504193;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)225427463;
				short num2 = num;
				num = (short)1716830215;
				switch (num2 == num)
				{
				}
				num = (short)1643249665;
				if (num != 0)
				{
				}
				num = (short)1672675328;
				short num3 = num;
				num = (short)627703808;
				if (num != 0)
				{
				}
				this.radErgoCfgRSMlTopButtonLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x060078B8 RID: 30904 RVA: 0x006D9530 File Offset: 0x006D7730
		public bool RadErgoCfgRSMlTopButtonLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)1030340093;
				short num2 = num;
				num = (short)232701437;
				switch (num2 == num)
				{
				}
				num = (short)1335361537;
				if (num != 0)
				{
				}
				num = (short)1035403264;
				short num3 = num;
				num = (short)2062548992;
				if (num != 0)
				{
				}
				return this.radErgoCfgRSMlTopButtonLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x060078B9 RID: 30905 RVA: 0x006D95E4 File Offset: 0x006D77E4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)933351398;
				short num2 = num;
				num = (short)1222037478;
				switch (num2 == num)
				{
				}
				num = (short)924844033;
				if (num != 0)
				{
				}
				num = (short)802291712;
				short num3 = num;
				num = (short)136511488;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x060078BA RID: 30906 RVA: 0x006D96A4 File Offset: 0x006D78A4
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches RefSwitches
		{
			get
			{
				short num = (short)1813049334;
				short num2 = num;
				num = (short)1227943926;
				switch (num2 == num)
				{
				}
				num = (short)1625292801;
				if (num != 0)
				{
				}
				num = (short)1592262656;
				short num3 = num;
				num = (short)1186988032;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			}
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x060078BB RID: 30907 RVA: 0x006D9764 File Offset: 0x006D7964
		public global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems RefMenuItems
		{
			get
			{
				short num = (short)662377519;
				short num2 = num;
				num = (short)1424430127;
				switch (num2 == num)
				{
				}
				num = (short)1980432385;
				if (num != 0)
				{
				}
				num = (short)1979383808;
				short num3 = num;
				num = (short)317390848;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2088)[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
			}
		}

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x060078BC RID: 30908 RVA: 0x006D9820 File Offset: 0x006D7A20
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)660116473;
				short num2 = num;
				num = (short)1279693817;
				switch (num2 == num)
				{
				}
				num = (short)583139329;
				if (num != 0)
				{
				}
				num = (short)40370176;
				short num3 = num;
				num = (short)1215365120;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x060078BD RID: 30909 RVA: 0x006D98E0 File Offset: 0x006D7AE0
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)637122430;
				short num2 = num;
				num = (short)1275574142;
				switch (num2 == num)
				{
				}
				num = (short)1122959361;
				if (num != 0)
				{
				}
				num = (short)77463552;
				short num3 = num;
				num = (short)355860480;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x006D99A0 File Offset: 0x006D7BA0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)19464192;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_35:
				switch (num3)
				{
				case 0:
					num = (short)1773600771;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)382551872;
					short num4 = num;
					num = (short)1676560192;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)1804402688;
						if (num != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num = (short)506068992;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1193869316;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1295581186;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_4F;
			}
			return result;
			IL_4F:
			num = (short)344981505;
			if (num != 0)
			{
			}
			result = null;
			num = (short)1549074433;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x040032FB RID: 13051
		private global::AcpBusinessLayer.AcpListField radErgoCfgRSMConventionalBCO_A19639;

		// Token: 0x040032FC RID: 13052
		private global::AcpBusinessLayer.AcpListField radErgoCfgRSMTrunkingBCO_A19741;

		// Token: 0x040032FD RID: 13053
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgRSMButtonKey_A22526;

		// Token: 0x040032FE RID: 13054
		private global::AcpBusinessLayer.AcpCustomRangeField radErgoCfgRSMlTopButtonShortPressTime;

		// Token: 0x040032FF RID: 13055
		private global::AcpBusinessLayer.AcpField<string> radErgoCfgRSMButtonName_A22527;

		// Token: 0x04003300 RID: 13056
		private global::AcpBusinessLayer.AcpListField radErgoCfgRSMlConventionalFeature_A19640;

		// Token: 0x04003301 RID: 13057
		private global::AcpBusinessLayer.AcpListField radErgoCfgRSMlTrunkingFeature_A19742;

		// Token: 0x04003302 RID: 13058
		private global::AcpBusinessLayer.AcpCustomRangeField radErgoCfgRSMlTopButtonLongPressTime;
	}
}
