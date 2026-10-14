using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005CE RID: 1486
	[global::System.Serializable]
	public class TxOptions : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CDC3 RID: 52675 RVA: 0x00BF8D7C File Offset: 0x00BF6F7C
		public TxOptions(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x00BF8D98 File Offset: 0x00BF6F98
		protected TxOptions(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CDC5 RID: 52677 RVA: 0x00BF8DB0 File Offset: 0x00BF6FB0
		public override void Init()
		{
			int a_ = 9;
			short num = (short)98518405;
			short num2 = num;
			num = (short)1567769989;
			switch (num2 == num)
			{
			default:
			{
				num = (short)373161984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1241972737;
			if (num != 0)
			{
			}
			num = (short)166854656;
			if (num != 0)
			{
			}
			this.cnvPerTxOptionsAdaptivePower_A7405 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ苕ꃗ闙곛ꫝ觟跡諣闥ꧧ軩跫黭蓯鯱苳鏵ꣷ闹读鯽狿崁䔃ㄅ㰇㨉㤋", a_), global::CommonResources.AcgResources.ID_ADAPTIVEPOWER);
			this.cnvPerTxOptionsAdaptivePower_A7405.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerTxOptionsAdaptivePower_A7405.DataTransferOrder = 80;
			this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ苕ꃗ闙곛ꫝ觟跡諣闥뫧迩髫语苯臱釳듵跷裹迻諽哿省瘃栅䜇氉樋䴍缏瘑焓䤕夗∙┛⬝ሟ", a_), global::CommonResources.AcgResources.ID_REVERSEBURSTTURNOFFCODE);
			this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.DataTransferOrder = 77;
			this.cnvPerTxOptionsTimeOutTimersec_A9378 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ苕ꃗ闙곛ꫝ觟跡諣闥볧菩臫语뿯蟱胳ꋵ釷韹駻賽珿朁會夅䤇㌉㼋㤍⠏", a_), global::CommonResources.AcgResources.ID_TIMEOUTTIMERSEC, 0, 31, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 15);
			this.cnvPerTxOptionsTimeOutTimersec_A9378.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerTxOptionsTimeOutTimersec_A9378.DataTransferOrder = 91;
			this.cnvPerTxOptionsTimeOutTimersec_A9378.ShowHexValue = false;
			this.cnvPerTxOptionsTransmitPreEmphasis_A9411 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ苕ꃗ闙곛ꫝ觟跡諣闥볧飩跫胭華鿱鷳苵ꣷ裹駻믽淿爁氃朅笇按缋儍儏⬑–✕⤗", a_), global::CommonResources.AcgResources.ID_TRANSMITPREEMPHASIS);
			this.cnvPerTxOptionsTransmitPreEmphasis_A9411.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerTxOptionsTransmitPreEmphasis_A9411.DataTransferOrder = 92;
			this.cnvPerTxOptionsTransmitPowerLevel_A9420 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerTxOptionsTransmitPowerLevel_A9420LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerTxOptionsTransmitPowerLevel_A9420LovStrs), this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ苕ꃗ闙곛ꫝ觟跡諣闥볧飩跫胭華鿱鷳苵ꣷ闹读鯽狿丁愃瀅洇昉匋伍⤏☑☓☕", a_), global::CommonResources.AcgResources.ID_TRANSMITPOWERLEVEL, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerTxOptionsTransmitPowerLevel_A9420LovStrs);
			this.cnvPerTxOptionsTransmitPowerLevel_A9420.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerTxOptionsTransmitPowerLevel_A9420.DataTransferOrder = 9;
			this.cnvPerTxOptionsTxVoiceSignalType_A9574 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ苕ꃗ闙곛ꫝ觟跡諣闥볧鋩뫫臭駯釱釳ꗵ釷鷹鋻鿽泿嘁紃瘅洇唉䴋㜍┏┑–", a_), global::CommonResources.AcgResources.ID_TXVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerTxOptionsTxVoiceSignalType_A9574LovStrs);
			this.cnvPerTxOptionsTxVoiceSignalType_A9574.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerTxOptionsTxVoiceSignalType_A9574.DataTransferOrder = 6;
			this.cnvPerTxOptionsTalkPermitTone = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ苕ꃗ闙곛ꫝ觟跡諣闥볧诩胫藭ꃯ韱蛳鯵釷軹ꣻ釽滿朁", a_), global::CommonResources.AcgResources.ID_TXOPTIONSTALKPERMITTONE);
			this.cnvPerTxOptionsTalkPermitTone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerTxOptionsTalkPermitTone.DataTransferOrder = 82;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黉듋鿏ꋑꃓ뿕럗듙꿛", a_);
			base.Id = 10137;
			base.UIName = global::CommonResources.AcgResources.ID_TXOPTIONS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x00BF9054 File Offset: 0x00BF7254
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)1872101391;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvPerTxOptionsTimeOutTimersec_A9378 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠諢裤苦ꛨ黪駬믮飰黲郴藶諸黺黼ꃾ䀀㨂㘄〆ㄈ", a_), global::CommonResources.AcgResources.ID_TIMEOUTTIMERSEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 15);
					this.cnvPerTxOptionsTimeOutTimersec_A9378.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerTxOptionsTimeOutTimersec_A9378.DataTransferOrder = 91;
					this.cnvPerTxOptionsTimeOutTimersec_A9378.ShowHexValue = false;
					num = (short)134217745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1485635597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.cnvPerTxOptionsTransmitPreEmphasis_A9411 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠釢蓤触髨蛪蓬鯮ꇰ臲郴닶铸诺闼黾爀樂瘄堆䠈㈊㤌㸎‐", a_), global::CommonResources.AcgResources.ID_TRANSMITPREEMPHASIS);
					this.cnvPerTxOptionsTransmitPreEmphasis_A9411.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerTxOptionsTransmitPreEmphasis_A9411.DataTransferOrder = 92;
					num = (short)682754070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.cnvPerTxOptionsTransmitPowerLevel_A9420 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerTxOptionsTransmitPowerLevel_A9420LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerTxOptionsTransmitPowerLevel_A9420LovStrs), this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠釢蓤触髨蛪蓬鯮ꇰ鳲苴鋶诸럺飼觾搀漂娄䘆〈㼊㼌㼎", a_), global::CommonResources.AcgResources.ID_TRANSMITPOWERLEVEL, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerTxOptionsTransmitPowerLevel_A9420LovStrs);
					this.cnvPerTxOptionsTransmitPowerLevel_A9420.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerTxOptionsTransmitPowerLevel_A9420.DataTransferOrder = 9;
					num = (short)570621960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞돠蛢鏤苦鯨飪裬귮蓰臲蛴菶그軺迼釾一攂挄䐆昈漊栌倎倐⬒Ⱄ∖⬘", a_), global::CommonResources.AcgResources.ID_REVERSEBURSTTURNOFFCODE);
					this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.DataTransferOrder = 77;
					num = (short)1696989194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠釢蓤触髨蛪蓬鯮ꇰ臲郴닶铸诺闼黾爀樂瘄堆䠈㈊㤌㸎‐", a_)))
					{
						num = (short)1966538754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C5;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠苢觤賦맨軪鿬苮飰蟲ꇴ飶韸黺", a_)))
					{
						num = (short)713883664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_624;
				case 7:
					goto IL_3D3;
				case 8:
				{
					num = (short)1196818432;
					short num3 = num;
					num = (short)550633473;
					if (num != 0)
					{
					}
					goto IL_46C;
				}
				case 9:
					this.cnvPerTxOptionsAdaptivePower_A7405 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞ꃠ蟢蓤韦鷨苪鯬諮ꇰ鳲苴鋶诸ꓺ볼죾㔀㌂〄", a_), global::CommonResources.AcgResources.ID_ADAPTIVEPOWER);
					this.cnvPerTxOptionsAdaptivePower_A7405.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerTxOptionsAdaptivePower_A7405.DataTransferOrder = 80;
					num = (short)964558855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_58B;
				case 11:
					num = (short)566231060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠諢裤苦ꛨ黪駬믮飰黲郴藶諸黺黼ꃾ䀀㨂㘄〆ㄈ", a_)))
					{
						num = (short)589824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D6;
				case 13:
					goto IL_290;
				case 14:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠鯢돤裦胨裪裬볮飰铲鯴零闸꿺蓼迾搀専䐄㸆㰈㰊㤌", a_)))
					{
						goto IL_41F;
					}
					num = (short)142100401;
					short num4 = num;
					num = (short)944850865;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_290;
					default:
						num = (short)946405376;
						if (num != 0)
						{
						}
						num = (short)396754967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 16:
					this.cnvPerTxOptionsTalkPermitTone = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠苢觤賦맨軪鿬苮飰蟲ꇴ飶韸黺", a_), global::CommonResources.AcgResources.ID_TXOPTIONSTALKPERMITTONE);
					this.cnvPerTxOptionsTalkPermitTone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerTxOptionsTalkPermitTone.DataTransferOrder = 82;
					num = (short)1983774741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_5D6;
				case 18:
					goto IL_41F;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠釢蓤触髨蛪蓬鯮ꇰ鳲苴鋶诸럺飼觾搀漂娄䘆〈㼊㼌㼎", a_)))
					{
						num = (short)692256771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46C;
				case 20:
					if (producerFields != null)
					{
						num = (short)1500446721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_624;
				case 21:
					goto IL_363;
				case 22:
					goto IL_2C5;
				case 23:
					this.cnvPerTxOptionsTxVoiceSignalType_A9574 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞뗠鯢돤裦胨裪裬볮飰铲鯴零闸꿺蓼迾搀専䐄㸆㰈㰊㤌", a_), global::CommonResources.AcgResources.ID_TXVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerTxOptionsTxVoiceSignalType_A9574LovStrs);
					this.cnvPerTxOptionsTxVoiceSignalType_A9574.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerTxOptionsTxVoiceSignalType_A9574.DataTransferOrder = 6;
					num = (short)262602770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞돠蛢鏤苦鯨飪裬귮蓰臲蛴菶그軺迼釾一攂挄䐆昈漊栌倎倐⬒Ⱄ∖⬘", a_)))
					{
						num = (short)1308491780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58B;
				}
				IL_91:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1562443787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_290:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎꧐鳒ꗔꏖ냘듚돜곞ꃠ蟢蓤韦鷨苪鯬諮ꇰ鳲苴鋶诸ꓺ볼죾㔀㌂〄", a_)))
				{
					num = (short)56426505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3D3;
				IL_2C5:
				num = (short)1459945491;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D3:
				num = (short)195559448;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41F:
				num = (short)1054408710;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_46C:
				num = (short)267714574;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_58B:
				num = (short)2062614540;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D6:
				num = (short)1334837253;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_363:
			IL_624:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韂뷄蛈믊만ꛎ뻐뷒ꛔ", a_);
			base.Id = 10137;
			base.UIName = global::CommonResources.AcgResources.ID_TXOPTIONS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600CDC7 RID: 52679 RVA: 0x00BF96B8 File Offset: 0x00BF78B8
		public override void PopulateReferences()
		{
			short num = (short)304084580;
			short num2 = num;
			num = (short)1076622948;
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
			num = (short)559022080;
			if (num != 0)
			{
			}
			num = (short)1876819969;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CDC8 RID: 52680 RVA: 0x00BF9764 File Offset: 0x00BF7964
		public override void DropReferences()
		{
			short num = (short)1729152388;
			short num2 = num;
			num = (short)1259193732;
			switch (num2 == num)
			{
			default:
			{
				num = (short)423493632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1341259777;
			if (num != 0)
			{
			}
			num = (short)1569193984;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CDC9 RID: 52681 RVA: 0x00BF9810 File Offset: 0x00BF7A10
		public override void SetConstraints()
		{
			short num = (short)260809785;
			short num2 = num;
			num = (short)1439147065;
			switch (num2 == num)
			{
			default:
			{
				num = (short)78577664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)803405825;
			if (num != 0)
			{
			}
			num = (short)416088064;
			if (num != 0)
			{
			}
			this.cnvPerTxOptionsAdaptivePower_A7405.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxSigTypeIsNotNonAstroAndTxPwrLevelHigh);
			this.cnvPerTxOptionsAdaptivePower_A7405.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRSISystemIsDisabledAndAdaptivePower);
			this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conReceiveOnlyIsDisabled);
			this.cnvPerTxOptionsTimeOutTimersec_A9378.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conReceiveOnlyAndRSISysIsDisabled);
			this.cnvPerTxOptionsTimeOutTimersec_A9378.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvTimeOutTimerValid);
			this.cnvPerTxOptionsTransmitPreEmphasis_A9411.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAnalogFlatAudioIsEnabledAndRxOnlyIsDisabledAndIsMobielOrRxOnlyIsDisabledAndIsPortable);
			this.cnvPerTxOptionsTransmitPowerLevel_A9420.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conReceiveOnlyIsDisabled);
			this.cnvPerTxOptionsTxVoiceSignalType_A9574.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSetTxSigTypeWithDVRS);
			this.cnvPerTxOptionsTalkPermitTone.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTalkPermitToneIsApplicable);
		}

		// Token: 0x0600CDCA RID: 52682 RVA: 0x00BF9988 File Offset: 0x00BF7B88
		public override void SetupDependencies()
		{
			short num = (short)1724570122;
			short num2 = num;
			num = (short)1806293514;
			switch (num2 == num)
			{
			default:
			{
				num = (short)114556928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2010906625;
			if (num != 0)
			{
			}
			num = (short)1367277568;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			this.cnvPerTxOptionsTransmitPowerLevel_A9420.AddDependentObject(this.cnvPerTxOptionsAdaptivePower_A7405);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerTxOptionsAdaptivePower_A7405);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerTxOptionsTimeOutTimersec_A9378);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerTxOptionsTimeOutTimersec_A9378);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerTxOptionsTransmitPreEmphasis_A9411);
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogFlatAudio_A7443.AddDependentObject(this.cnvPerTxOptionsTransmitPreEmphasis_A9411);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerTxOptionsTransmitPowerLevel_A9420);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerTxOptionsTxVoiceSignalType_A9574);
			conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.AddDependentObject(this.cnvPerTxOptionsTxVoiceSignalType_A9574);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerTxOptionsTxVoiceSignalType_A9574);
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogWidebandData_A1994.AddDependentObject(this.cnvPerTxOptionsTransmitPreEmphasis_A9411);
		}

		// Token: 0x17006786 RID: 26502
		// (get) Token: 0x0600CDCB RID: 52683 RVA: 0x00BF9B48 File Offset: 0x00BF7D48
		public bool HasDiffs
		{
			get
			{
				short num = (short)1168572417;
				if (num != 0)
				{
				}
				num = (short)789774336;
				short num2 = num;
				num = (short)1790937079;
				short num3 = num;
				num = (short)703039479;
				switch (num3 == num)
				{
				}
				num = (short)1776287744;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17006787 RID: 26503
		// (get) Token: 0x0600CDCC RID: 52684 RVA: 0x00BF9BFC File Offset: 0x00BF7DFC
		// (set) Token: 0x0600CDCD RID: 52685 RVA: 0x00BF9CB0 File Offset: 0x00BF7EB0
		public bool CnvPerTxOptionsAdaptivePower_A7405Value
		{
			get
			{
				short num = (short)1563832107;
				short num2 = num;
				num = (short)2069049131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749862912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)683671552;
				if (num != 0)
				{
				}
				num = (short)348979201;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.Value;
			}
			set
			{
				short num = (short)2038693888;
				short num2 = num;
				num = (short)2042266740;
				short num3 = num;
				num = (short)330335348;
				switch (num3 == num)
				{
				}
				num = (short)1190854657;
				if (num != 0)
				{
				}
				num = (short)129368064;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsAdaptivePower_A7405.Value = value;
			}
		}

		// Token: 0x17006788 RID: 26504
		// (get) Token: 0x0600CDCE RID: 52686 RVA: 0x00BF9D68 File Offset: 0x00BF7F68
		public global::AcpBusinessLayer.AcpField<bool> CnvPerTxOptionsAdaptivePower_A7405
		{
			get
			{
				short num = (short)1001783296;
				short num2 = num;
				num = (short)1459391630;
				short num3 = num;
				num = (short)835619982;
				switch (num3 == num)
				{
				}
				num = (short)2012282880;
				if (num != 0)
				{
				}
				num = (short)1360855041;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405;
			}
		}

		// Token: 0x17006789 RID: 26505
		// (get) Token: 0x0600CDCF RID: 52687 RVA: 0x00BF9E18 File Offset: 0x00BF8018
		// (set) Token: 0x0600CDD0 RID: 52688 RVA: 0x00BF9ECC File Offset: 0x00BF80CC
		public bool CnvPerTxOptionsAdaptivePower_A7405_UIValue
		{
			get
			{
				short num = (short)851378176;
				short num2 = num;
				num = (short)280991665;
				short num3 = num;
				num = (short)1309054897;
				switch (num3 == num)
				{
				}
				num = (short)903741441;
				if (num != 0)
				{
				}
				num = (short)582615040;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.Value;
			}
			set
			{
				short num = (short)868417536;
				short num2 = num;
				num = (short)399679801;
				short num3 = num;
				num = (short)1281466681;
				switch (num3 == num)
				{
				}
				num = (short)449904641;
				if (num != 0)
				{
				}
				num = (short)1437728768;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsAdaptivePower_A7405.Value = value;
			}
		}

		// Token: 0x1700678A RID: 26506
		// (get) Token: 0x0600CDD1 RID: 52689 RVA: 0x00BF9F84 File Offset: 0x00BF8184
		// (set) Token: 0x0600CDD2 RID: 52690 RVA: 0x00BFA038 File Offset: 0x00BF8238
		public bool CnvPerTxOptionsAdaptivePower_A7405_Applicable
		{
			get
			{
				short num = (short)637534208;
				short num2 = num;
				num = (short)2106864864;
				short num3 = num;
				num = (short)608318688;
				switch (num3 == num)
				{
				}
				num = (short)921108481;
				if (num != 0)
				{
				}
				num = (short)624099328;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.Applicable;
			}
			set
			{
				short num = (short)1105461248;
				short num2 = num;
				num = (short)2131952938;
				short num3 = num;
				num = (short)1111557418;
				switch (num3 == num)
				{
				}
				num = (short)1652490241;
				if (num != 0)
				{
				}
				num = (short)1201209344;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsAdaptivePower_A7405.Applicable = value;
			}
		}

		// Token: 0x1700678B RID: 26507
		// (get) Token: 0x0600CDD3 RID: 52691 RVA: 0x00BFA0EC File Offset: 0x00BF82EC
		// (set) Token: 0x0600CDD4 RID: 52692 RVA: 0x00BFA19C File Offset: 0x00BF839C
		public bool CnvPerTxOptionsAdaptivePower_A7405_Valid
		{
			get
			{
				short num = (short)1746862080;
				short num2 = num;
				num = (short)552974323;
				short num3 = num;
				num = (short)1683732467;
				switch (num3 == num)
				{
				}
				num = (short)1482752001;
				if (num != 0)
				{
				}
				num = (short)349306880;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.Valid;
			}
			set
			{
				short num = (short)1746010112;
				short num2 = num;
				num = (short)1129775236;
				short num3 = num;
				num = (short)1106182276;
				switch (num3 == num)
				{
				}
				num = (short)1926168576;
				if (num != 0)
				{
				}
				num = (short)1841823745;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsAdaptivePower_A7405.Valid = value;
			}
		}

		// Token: 0x1700678C RID: 26508
		// (get) Token: 0x0600CDD5 RID: 52693 RVA: 0x00BFA254 File Offset: 0x00BF8454
		// (set) Token: 0x0600CDD6 RID: 52694 RVA: 0x00BFA308 File Offset: 0x00BF8508
		public bool CnvPerTxOptionsAdaptivePower_A7405_Visible
		{
			get
			{
				short num = (short)1835008000;
				short num2 = num;
				num = (short)1576775448;
				short num3 = num;
				num = (short)2082713368;
				switch (num3 == num)
				{
				}
				num = (short)1822687233;
				if (num != 0)
				{
				}
				num = (short)2120482816;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.Visible;
			}
			set
			{
				short num = (short)1868759040;
				short num2 = num;
				num = (short)1843760687;
				short num3 = num;
				num = (short)1513131567;
				switch (num3 == num)
				{
				}
				num = (short)522387457;
				if (num != 0)
				{
				}
				num = (short)1500315648;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsAdaptivePower_A7405.Visible = value;
			}
		}

		// Token: 0x1700678D RID: 26509
		// (get) Token: 0x0600CDD7 RID: 52695 RVA: 0x00BFA3C0 File Offset: 0x00BF85C0
		// (set) Token: 0x0600CDD8 RID: 52696 RVA: 0x00BFA474 File Offset: 0x00BF8674
		public bool CnvPerTxOptionsAdaptivePower_A7405_Editable
		{
			get
			{
				short num = (short)2101673984;
				short num2 = num;
				num = (short)130651797;
				short num3 = num;
				num = (short)159422101;
				switch (num3 == num)
				{
				}
				num = (short)430899201;
				if (num != 0)
				{
				}
				num = (short)444596224;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.Editable;
			}
			set
			{
				short num = (short)2095906816;
				short num2 = num;
				num = (short)1353917404;
				short num3 = num;
				num = (short)1610621916;
				switch (num3 == num)
				{
				}
				num = (short)2018115585;
				if (num != 0)
				{
				}
				num = (short)196935680;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsAdaptivePower_A7405.Editable = value;
			}
		}

		// Token: 0x1700678E RID: 26510
		// (get) Token: 0x0600CDD9 RID: 52697 RVA: 0x00BFA528 File Offset: 0x00BF8728
		internal string CnvPerTxOptionsAdaptivePower_A7405_UILabel
		{
			get
			{
				short num = (short)2131820544;
				short num2 = num;
				num = (short)1014430614;
				short num3 = num;
				num = (short)135527318;
				switch (num3 == num)
				{
				}
				num = (short)539295744;
				if (num != 0)
				{
				}
				num = (short)2092957697;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.UIName;
			}
		}

		// Token: 0x1700678F RID: 26511
		// (get) Token: 0x0600CDDA RID: 52698 RVA: 0x00BFA5DC File Offset: 0x00BF87DC
		// (set) Token: 0x0600CDDB RID: 52699 RVA: 0x00BFA690 File Offset: 0x00BF8890
		internal bool CnvPerTxOptionsAdaptivePower_A7405_HiddenStatic
		{
			get
			{
				short num = (short)1571684352;
				short num2 = num;
				num = (short)945510870;
				short num3 = num;
				num = (short)634411478;
				switch (num3 == num)
				{
				}
				num = (short)2144403456;
				if (num != 0)
				{
				}
				num = (short)545718273;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.HiddenStatic;
			}
			set
			{
				short num = (short)1861025792;
				short num2 = num;
				num = (short)1257353625;
				short num3 = num;
				num = (short)1126216089;
				switch (num3 == num)
				{
				}
				num = (short)764936193;
				if (num != 0)
				{
				}
				num = (short)1247019008;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsAdaptivePower_A7405.HiddenStatic = value;
			}
		}

		// Token: 0x17006790 RID: 26512
		// (get) Token: 0x0600CDDC RID: 52700 RVA: 0x00BFA748 File Offset: 0x00BF8948
		// (set) Token: 0x0600CDDD RID: 52701 RVA: 0x00BFA800 File Offset: 0x00BF8A00
		internal bool CnvPerTxOptionsAdaptivePower_A7405_HiddenDynamic
		{
			get
			{
				short num = (short)624033792;
				short num2 = num;
				num = (short)114376299;
				short num3 = num;
				num = (short)1323646571;
				switch (num3 == num)
				{
				}
				num = (short)1198587905;
				if (num != 0)
				{
				}
				num = (short)741867520;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405.HiddenDynamic;
			}
			set
			{
				short num = (short)233439232;
				short num2 = num;
				num = (short)1676279809;
				if (num != 0)
				{
				}
				num = (short)1213511893;
				short num3 = num;
				num = (short)1187821781;
				switch (num3 == num)
				{
				}
				num = (short)800129024;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsAdaptivePower_A7405.HiddenDynamic = value;
			}
		}

		// Token: 0x17006791 RID: 26513
		// (get) Token: 0x0600CDDE RID: 52702 RVA: 0x00BFA8B4 File Offset: 0x00BF8AB4
		public bool CnvPerTxOptionsAdaptivePower_A7405_HasDiffs
		{
			get
			{
				short num = (short)852688896;
				short num2 = num;
				num = (short)542399651;
				short num3 = num;
				num = (short)1322867875;
				switch (num3 == num)
				{
				}
				num = (short)1147273217;
				if (num != 0)
				{
				}
				num = (short)1609302016;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsAdaptivePower_A7405._HasDiffs;
			}
		}

		// Token: 0x17006792 RID: 26514
		// (get) Token: 0x0600CDDF RID: 52703 RVA: 0x00BFA968 File Offset: 0x00BF8B68
		// (set) Token: 0x0600CDE0 RID: 52704 RVA: 0x00BFAA20 File Offset: 0x00BF8C20
		public bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952Value
		{
			get
			{
				short num = (short)531103744;
				short num2 = num;
				num = (short)167903233;
				if (num != 0)
				{
				}
				num = (short)122275002;
				short num3 = num;
				num = (short)1139262650;
				switch (num3 == num)
				{
				}
				num = (short)743047168;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Value;
			}
			set
			{
				short num = (short)797442048;
				short num2 = num;
				num = (short)1904410625;
				if (num != 0)
				{
				}
				num = (short)1408206693;
				short num3 = num;
				num = (short)1184466789;
				switch (num3 == num)
				{
				}
				num = (short)1509818368;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Value = value;
			}
		}

		// Token: 0x17006793 RID: 26515
		// (get) Token: 0x0600CDE1 RID: 52705 RVA: 0x00BFAAD8 File Offset: 0x00BF8CD8
		public global::AcpBusinessLayer.AcpField<bool> CnvPerTxOptionsReverseBurstTurnOffCode_A8952
		{
			get
			{
				short num = (short)1857421312;
				short num2 = num;
				num = (short)542088197;
				short num3 = num;
				num = (short)979016709;
				switch (num3 == num)
				{
				}
				num = (short)1404698625;
				if (num != 0)
				{
				}
				num = (short)1599864832;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952;
			}
		}

		// Token: 0x17006794 RID: 26516
		// (get) Token: 0x0600CDE2 RID: 52706 RVA: 0x00BFAB8C File Offset: 0x00BF8D8C
		// (set) Token: 0x0600CDE3 RID: 52707 RVA: 0x00BFAC40 File Offset: 0x00BF8E40
		public bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952_UIValue
		{
			get
			{
				short num = (short)732299264;
				short num2 = num;
				num = (short)516960649;
				short num3 = num;
				num = (short)663105929;
				switch (num3 == num)
				{
				}
				num = (short)1622343680;
				if (num != 0)
				{
				}
				num = (short)1658257409;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Value;
			}
			set
			{
				short num = (short)1670643712;
				short num2 = num;
				num = (short)1126865987;
				short num3 = num;
				num = (short)2097454147;
				switch (num3 == num)
				{
				}
				num = (short)276037633;
				if (num != 0)
				{
				}
				num = (short)215810048;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Value = value;
			}
		}

		// Token: 0x17006795 RID: 26517
		// (get) Token: 0x0600CDE4 RID: 52708 RVA: 0x00BFACF4 File Offset: 0x00BF8EF4
		// (set) Token: 0x0600CDE5 RID: 52709 RVA: 0x00BFADA8 File Offset: 0x00BF8FA8
		public bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952_Applicable
		{
			get
			{
				short num = (short)1217921024;
				short num2 = num;
				num = (short)517434113;
				short num3 = num;
				num = (short)1210018561;
				switch (num3 == num)
				{
				}
				num = (short)1914437633;
				if (num != 0)
				{
				}
				num = (short)188481536;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Applicable;
			}
			set
			{
				short num = (short)2030698496;
				short num2 = num;
				num = (short)1654380735;
				short num3 = num;
				num = (short)1446762687;
				switch (num3 == num)
				{
				}
				num = (short)793116672;
				if (num != 0)
				{
				}
				num = (short)838533121;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Applicable = value;
			}
		}

		// Token: 0x17006796 RID: 26518
		// (get) Token: 0x0600CDE6 RID: 52710 RVA: 0x00BFAE5C File Offset: 0x00BF905C
		// (set) Token: 0x0600CDE7 RID: 52711 RVA: 0x00BFAF10 File Offset: 0x00BF9110
		public bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952_Valid
		{
			get
			{
				short num = (short)33161216;
				short num2 = num;
				num = (short)1114866457;
				short num3 = num;
				num = (short)1769964313;
				switch (num3 == num)
				{
				}
				num = (short)1314848768;
				if (num != 0)
				{
				}
				num = (short)571801601;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Valid;
			}
			set
			{
				short num = (short)1411448832;
				short num2 = num;
				num = (short)1097934630;
				short num3 = num;
				num = (short)198321958;
				switch (num3 == num)
				{
				}
				num = (short)2083454977;
				if (num != 0)
				{
				}
				num = (short)440467456;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Valid = value;
			}
		}

		// Token: 0x17006797 RID: 26519
		// (get) Token: 0x0600CDE8 RID: 52712 RVA: 0x00BFAFC4 File Offset: 0x00BF91C4
		// (set) Token: 0x0600CDE9 RID: 52713 RVA: 0x00BFB078 File Offset: 0x00BF9278
		public bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952_Visible
		{
			get
			{
				short num = (short)1899757568;
				short num2 = num;
				num = (short)537100216;
				short num3 = num;
				num = (short)376668088;
				switch (num3 == num)
				{
				}
				num = (short)514523137;
				if (num != 0)
				{
				}
				num = (short)1594490880;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Visible;
			}
			set
			{
				short num = (short)1033043968;
				short num2 = num;
				num = (short)361758721;
				if (num != 0)
				{
				}
				num = (short)1659028272;
				short num3 = num;
				num = (short)290243376;
				switch (num3 == num)
				{
				}
				num = (short)1158742016;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Visible = value;
			}
		}

		// Token: 0x17006798 RID: 26520
		// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x00BFB12C File Offset: 0x00BF932C
		// (set) Token: 0x0600CDEB RID: 52715 RVA: 0x00BFB1E4 File Offset: 0x00BF93E4
		public bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952_Editable
		{
			get
			{
				short num = (short)302448640;
				short num2 = num;
				num = (short)428332799;
				short num3 = num;
				num = (short)1206376191;
				switch (num3 == num)
				{
				}
				num = (short)1894383617;
				if (num != 0)
				{
				}
				num = (short)2818048;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Editable;
			}
			set
			{
				short num = (short)393281536;
				short num2 = num;
				num = (short)47579137;
				if (num != 0)
				{
				}
				num = (short)2070973194;
				short num3 = num;
				num = (short)1437305610;
				switch (num3 == num)
				{
				}
				num = (short)718405632;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.Editable = value;
			}
		}

		// Token: 0x17006799 RID: 26521
		// (get) Token: 0x0600CDEC RID: 52716 RVA: 0x00BFB29C File Offset: 0x00BF949C
		internal string CnvPerTxOptionsReverseBurstTurnOffCode_A8952_UILabel
		{
			get
			{
				short num = (short)1653604352;
				short num2 = num;
				num = (short)2090454148;
				short num3 = num;
				num = (short)549112964;
				switch (num3 == num)
				{
				}
				num = (short)1152450561;
				if (num != 0)
				{
				}
				num = (short)1103822848;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.UIName;
			}
		}

		// Token: 0x1700679A RID: 26522
		// (get) Token: 0x0600CDED RID: 52717 RVA: 0x00BFB350 File Offset: 0x00BF9550
		// (set) Token: 0x0600CDEE RID: 52718 RVA: 0x00BFB404 File Offset: 0x00BF9604
		internal bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952_HiddenStatic
		{
			get
			{
				short num = (short)590807040;
				short num2 = num;
				num = (short)1462501377;
				if (num != 0)
				{
				}
				num = (short)863578814;
				short num3 = num;
				num = (short)493431486;
				switch (num3 == num)
				{
				}
				num = (short)1569521664;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.HiddenStatic;
			}
			set
			{
				short num = (short)1178140672;
				short num2 = num;
				num = (short)2037337277;
				short num3 = num;
				num = (short)1497648317;
				switch (num3 == num)
				{
				}
				num = (short)1982922752;
				if (num != 0)
				{
				}
				num = (short)1079050241;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.HiddenStatic = value;
			}
		}

		// Token: 0x1700679B RID: 26523
		// (get) Token: 0x0600CDEF RID: 52719 RVA: 0x00BFB4B8 File Offset: 0x00BF96B8
		// (set) Token: 0x0600CDF0 RID: 52720 RVA: 0x00BFB570 File Offset: 0x00BF9770
		internal bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952_HiddenDynamic
		{
			get
			{
				short num = (short)947060736;
				short num2 = num;
				num = (short)2038104065;
				if (num != 0)
				{
				}
				num = (short)642565918;
				short num3 = num;
				num = (short)1929627422;
				switch (num3 == num)
				{
				}
				num = (short)818085888;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.HiddenDynamic;
			}
			set
			{
				short num = (short)802881536;
				short num2 = num;
				num = (short)251437549;
				short num3 = num;
				num = (short)1357357549;
				switch (num3 == num)
				{
				}
				num = (short)982056961;
				if (num != 0)
				{
				}
				num = (short)194052096;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952.HiddenDynamic = value;
			}
		}

		// Token: 0x1700679C RID: 26524
		// (get) Token: 0x0600CDF1 RID: 52721 RVA: 0x00BFB628 File Offset: 0x00BF9828
		public bool CnvPerTxOptionsReverseBurstTurnOffCode_A8952_HasDiffs
		{
			get
			{
				short num = (short)1524695040;
				short num2 = num;
				num = (short)1815381263;
				short num3 = num;
				num = (short)2146731279;
				switch (num3 == num)
				{
				}
				num = (short)1026424833;
				if (num != 0)
				{
				}
				num = (short)1516371968;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsReverseBurstTurnOffCode_A8952._HasDiffs;
			}
		}

		// Token: 0x1700679D RID: 26525
		// (get) Token: 0x0600CDF2 RID: 52722 RVA: 0x00BFB6DC File Offset: 0x00BF98DC
		// (set) Token: 0x0600CDF3 RID: 52723 RVA: 0x00BFB790 File Offset: 0x00BF9990
		public int CnvPerTxOptionsTimeOutTimersec_A9378Value
		{
			get
			{
				short num = (short)1646395392;
				short num2 = num;
				num = (short)1647594853;
				short num3 = num;
				num = (short)1044467045;
				switch (num3 == num)
				{
				}
				num = (short)1051918337;
				if (num != 0)
				{
				}
				num = (short)352256000;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.Value;
			}
			set
			{
				short num = (short)1920008192;
				short num2 = num;
				num = (short)56696290;
				short num3 = num;
				num = (short)1115168226;
				switch (num3 == num)
				{
				}
				num = (short)1174667265;
				if (num != 0)
				{
				}
				num = (short)1026097152;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.Value = value;
			}
		}

		// Token: 0x1700679E RID: 26526
		// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x00BFB844 File Offset: 0x00BF9A44
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerTxOptionsTimeOutTimersec_A9378
		{
			get
			{
				short num = (short)1321795584;
				short num2 = num;
				num = (short)835296460;
				short num3 = num;
				num = (short)236625100;
				switch (num3 == num)
				{
				}
				num = (short)213385217;
				if (num != 0)
				{
				}
				num = (short)887488512;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378;
			}
		}

		// Token: 0x1700679F RID: 26527
		// (get) Token: 0x0600CDF5 RID: 52725 RVA: 0x00BFB8F4 File Offset: 0x00BF9AF4
		// (set) Token: 0x0600CDF6 RID: 52726 RVA: 0x00BFB9A8 File Offset: 0x00BF9BA8
		public string CnvPerTxOptionsTimeOutTimersec_A9378_UIValue
		{
			get
			{
				short num = (short)839843840;
				short num2 = num;
				num = (short)933790406;
				short num3 = num;
				num = (short)1218413254;
				switch (num3 == num)
				{
				}
				num = (short)431685633;
				if (num != 0)
				{
				}
				num = (short)491126784;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.UIValue;
			}
			set
			{
				short num = (short)821362688;
				short num2 = num;
				num = (short)60050439;
				short num3 = num;
				num = (short)289754119;
				switch (num3 == num)
				{
				}
				num = (short)406978561;
				if (num != 0)
				{
				}
				num = (short)1747648512;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.UIValue = value;
			}
		}

		// Token: 0x170067A0 RID: 26528
		// (get) Token: 0x0600CDF7 RID: 52727 RVA: 0x00BFBA5C File Offset: 0x00BF9C5C
		// (set) Token: 0x0600CDF8 RID: 52728 RVA: 0x00BFBB10 File Offset: 0x00BF9D10
		internal int CnvPerTxOptionsTimeOutTimersec_A9378Min
		{
			get
			{
				short num = (short)1507786752;
				short num2 = num;
				num = (short)1273215326;
				short num3 = num;
				num = (short)859421022;
				switch (num3 == num)
				{
				}
				num = (short)1440022529;
				if (num != 0)
				{
				}
				num = (short)1599406080;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.Min;
			}
			set
			{
				short num = (short)508755968;
				short num2 = num;
				num = (short)1381092229;
				short num3 = num;
				num = (short)1289472901;
				switch (num3 == num)
				{
				}
				num = (short)663879681;
				if (num != 0)
				{
				}
				num = (short)1321074688;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.Min = value;
			}
		}

		// Token: 0x170067A1 RID: 26529
		// (get) Token: 0x0600CDF9 RID: 52729 RVA: 0x00BFBBC4 File Offset: 0x00BF9DC4
		// (set) Token: 0x0600CDFA RID: 52730 RVA: 0x00BFBC7C File Offset: 0x00BF9E7C
		internal int CnvPerTxOptionsTimeOutTimersec_A9378Max
		{
			get
			{
				short num = (short)362545152;
				short num2 = num;
				num = (short)1339704182;
				short num3 = num;
				num = (short)346899318;
				switch (num3 == num)
				{
				}
				num = (short)1364459521;
				if (num != 0)
				{
				}
				num = (short)1509031936;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.Max;
			}
			set
			{
				short num = (short)922222592;
				short num2 = num;
				num = (short)508444087;
				short num3 = num;
				num = (short)115752375;
				switch (num3 == num)
				{
				}
				num = (short)909443072;
				if (num != 0)
				{
				}
				num = (short)802095105;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.Max = value;
			}
		}

		// Token: 0x170067A2 RID: 26530
		// (get) Token: 0x0600CDFB RID: 52731 RVA: 0x00BFBD30 File Offset: 0x00BF9F30
		// (set) Token: 0x0600CDFC RID: 52732 RVA: 0x00BFBDE4 File Offset: 0x00BF9FE4
		internal int CnvPerTxOptionsTimeOutTimersec_A9378Step
		{
			get
			{
				short num = (short)466944000;
				short num2 = num;
				num = (short)1261061190;
				short num3 = num;
				num = (short)995312710;
				switch (num3 == num)
				{
				}
				num = (short)1610350593;
				if (num != 0)
				{
				}
				num = (short)626262016;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.StepSize;
			}
			set
			{
				short num = (short)1766391808;
				short num2 = num;
				num = (short)1948773295;
				short num3 = num;
				num = (short)819391407;
				switch (num3 == num)
				{
				}
				num = (short)1320026113;
				if (num != 0)
				{
				}
				num = (short)355598336;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.StepSize = value;
			}
		}

		// Token: 0x170067A3 RID: 26531
		// (get) Token: 0x0600CDFD RID: 52733 RVA: 0x00BFBE9C File Offset: 0x00BFA09C
		// (set) Token: 0x0600CDFE RID: 52734 RVA: 0x00BFBF54 File Offset: 0x00BFA154
		public bool CnvPerTxOptionsTimeOutTimersec_A9378_Applicable
		{
			get
			{
				short num = (short)174194688;
				short num2 = num;
				num = (short)544577048;
				short num3 = num;
				num = (short)1855428120;
				switch (num3 == num)
				{
				}
				num = (short)276168705;
				if (num != 0)
				{
				}
				num = (short)749076480;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.Applicable;
			}
			set
			{
				short num = (short)64862201;
				short num2 = num;
				num = (short)443398137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)893386752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1708654593;
				if (num != 0)
				{
				}
				num = (short)736296960;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.Applicable = value;
			}
		}

		// Token: 0x170067A4 RID: 26532
		// (get) Token: 0x0600CDFF RID: 52735 RVA: 0x00BFC008 File Offset: 0x00BFA208
		// (set) Token: 0x0600CE00 RID: 52736 RVA: 0x00BFC0BC File Offset: 0x00BFA2BC
		public bool CnvPerTxOptionsTimeOutTimersec_A9378_Valid
		{
			get
			{
				short num = (short)1967197359;
				short num2 = num;
				num = (short)1664486575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1431568384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1407647745;
				if (num != 0)
				{
				}
				num = (short)1560215552;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.Valid;
			}
			set
			{
				short num = (short)2108508054;
				short num2 = num;
				num = (short)816662422;
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
				num = (short)591200257;
				if (num != 0)
				{
				}
				num = (short)1862926336;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.Valid = value;
			}
		}

		// Token: 0x170067A5 RID: 26533
		// (get) Token: 0x0600CE01 RID: 52737 RVA: 0x00BFC170 File Offset: 0x00BFA370
		// (set) Token: 0x0600CE02 RID: 52738 RVA: 0x00BFC224 File Offset: 0x00BFA424
		public bool CnvPerTxOptionsTimeOutTimersec_A9378_Visible
		{
			get
			{
				short num = (short)1488655696;
				short num2 = num;
				num = (short)185996624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1057292288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1956118529;
				if (num != 0)
				{
				}
				num = (short)700973056;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.Visible;
			}
			set
			{
				short num = (short)718733313;
				if (num != 0)
				{
				}
				num = (short)635830272;
				short num2 = num;
				num = (short)864223377;
				short num3 = num;
				num = (short)1330512017;
				switch (num3 == num)
				{
				}
				num = (short)261881856;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.Visible = value;
			}
		}

		// Token: 0x170067A6 RID: 26534
		// (get) Token: 0x0600CE03 RID: 52739 RVA: 0x00BFC2D8 File Offset: 0x00BFA4D8
		// (set) Token: 0x0600CE04 RID: 52740 RVA: 0x00BFC38C File Offset: 0x00BFA58C
		public bool CnvPerTxOptionsTimeOutTimersec_A9378_Editable
		{
			get
			{
				short num = (short)170693414;
				short num2 = num;
				num = (short)472748838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)975372288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)269746177;
				if (num != 0)
				{
				}
				num = (short)816447488;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.Editable;
			}
			set
			{
				short num = (short)1736921834;
				short num2 = num;
				num = (short)843600618;
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
				num = (short)1811283968;
				if (num != 0)
				{
				}
				num = (short)579207169;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.Editable = value;
			}
		}

		// Token: 0x170067A7 RID: 26535
		// (get) Token: 0x0600CE05 RID: 52741 RVA: 0x00BFC440 File Offset: 0x00BFA640
		internal string CnvPerTxOptionsTimeOutTimersec_A9378_UILabel
		{
			get
			{
				short num = (short)1560801355;
				short num2 = num;
				num = (short)1008005195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1725235200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1925644289;
				if (num != 0)
				{
				}
				num = (short)1984823296;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.UIName;
			}
		}

		// Token: 0x170067A8 RID: 26536
		// (get) Token: 0x0600CE06 RID: 52742 RVA: 0x00BFC4F8 File Offset: 0x00BFA6F8
		// (set) Token: 0x0600CE07 RID: 52743 RVA: 0x00BFC5AC File Offset: 0x00BFA7AC
		internal bool CnvPerTxOptionsTimeOutTimersec_A9378_HiddenStatic
		{
			get
			{
				short num = (short)1653932033;
				if (num != 0)
				{
				}
				num = (short)1754005504;
				short num2 = num;
				num = (short)17706159;
				short num3 = num;
				num = (short)41823407;
				switch (num3 == num)
				{
				}
				num = (short)959381504;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.HiddenStatic;
			}
			set
			{
				short num = (short)562022521;
				short num2 = num;
				num = (short)1681246329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1856372736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)563609601;
				if (num != 0)
				{
				}
				num = (short)1045954560;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.HiddenStatic = value;
			}
		}

		// Token: 0x170067A9 RID: 26537
		// (get) Token: 0x0600CE08 RID: 52744 RVA: 0x00BFC664 File Offset: 0x00BFA864
		// (set) Token: 0x0600CE09 RID: 52745 RVA: 0x00BFC71C File Offset: 0x00BFA91C
		internal bool CnvPerTxOptionsTimeOutTimersec_A9378_HiddenDynamic
		{
			get
			{
				short num = (short)1432924615;
				short num2 = num;
				num = (short)26259911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874329600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1874853889;
				if (num != 0)
				{
				}
				num = (short)1880621056;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378.HiddenDynamic;
			}
			set
			{
				short num = (short)1550573059;
				short num2 = num;
				num = (short)5299715;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1340735488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1170276353;
				if (num != 0)
				{
				}
				num = (short)1510670336;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTimeOutTimersec_A9378.HiddenDynamic = value;
			}
		}

		// Token: 0x170067AA RID: 26538
		// (get) Token: 0x0600CE0A RID: 52746 RVA: 0x00BFC7D4 File Offset: 0x00BFA9D4
		public bool CnvPerTxOptionsTimeOutTimersec_A9378_HasDiffs
		{
			get
			{
				short num = (short)1512454203;
				short num2 = num;
				num = (short)192624699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282263552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)529334273;
				if (num != 0)
				{
				}
				num = (short)621281280;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTimeOutTimersec_A9378._HasDiffs;
			}
		}

		// Token: 0x170067AB RID: 26539
		// (get) Token: 0x0600CE0B RID: 52747 RVA: 0x00BFC88C File Offset: 0x00BFAA8C
		// (set) Token: 0x0600CE0C RID: 52748 RVA: 0x00BFC940 File Offset: 0x00BFAB40
		public bool CnvPerTxOptionsTransmitPreEmphasis_A9411Value
		{
			get
			{
				short num = (short)1452490067;
				short num2 = num;
				num = (short)991771987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)273219584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1998258177;
				if (num != 0)
				{
				}
				num = (short)49872896;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Value;
			}
			set
			{
				short num = (short)314300441;
				short num2 = num;
				num = (short)632870937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2047934464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163905537;
				if (num != 0)
				{
				}
				num = (short)266862592;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Value = value;
			}
		}

		// Token: 0x170067AC RID: 26540
		// (get) Token: 0x0600CE0D RID: 52749 RVA: 0x00BFC9F4 File Offset: 0x00BFABF4
		public global::AcpBusinessLayer.AcpField<bool> CnvPerTxOptionsTransmitPreEmphasis_A9411
		{
			get
			{
				short num = (short)2033779492;
				short num2 = num;
				num = (short)217842468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)52101120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753205249;
				if (num != 0)
				{
				}
				num = (short)510001152;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411;
			}
		}

		// Token: 0x170067AD RID: 26541
		// (get) Token: 0x0600CE0E RID: 52750 RVA: 0x00BFCAA4 File Offset: 0x00BFACA4
		// (set) Token: 0x0600CE0F RID: 52751 RVA: 0x00BFCB5C File Offset: 0x00BFAD5C
		public bool CnvPerTxOptionsTransmitPreEmphasis_A9411_UIValue
		{
			get
			{
				short num = (short)848022032;
				short num2 = num;
				num = (short)1208404496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1587675136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1008664576;
				if (num != 0)
				{
				}
				num = (short)2146435073;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Value;
			}
			set
			{
				short num = (short)952301854;
				short num2 = num;
				num = (short)169998622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532742144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)396558337;
				if (num != 0)
				{
				}
				num = (short)1212284928;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Value = value;
			}
		}

		// Token: 0x170067AE RID: 26542
		// (get) Token: 0x0600CE10 RID: 52752 RVA: 0x00BFCC10 File Offset: 0x00BFAE10
		// (set) Token: 0x0600CE11 RID: 52753 RVA: 0x00BFCCC8 File Offset: 0x00BFAEC8
		public bool CnvPerTxOptionsTransmitPreEmphasis_A9411_Applicable
		{
			get
			{
				short num = (short)362458841;
				short num2 = num;
				num = (short)737849049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)341901312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)229572609;
				if (num != 0)
				{
				}
				num = (short)308346880;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Applicable;
			}
			set
			{
				short num = (short)1690931895;
				short num2 = num;
				num = (short)1418564279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1565720576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1650065408;
				if (num != 0)
				{
				}
				num = (short)1434189825;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Applicable = value;
			}
		}

		// Token: 0x170067AF RID: 26543
		// (get) Token: 0x0600CE12 RID: 52754 RVA: 0x00BFCD7C File Offset: 0x00BFAF7C
		// (set) Token: 0x0600CE13 RID: 52755 RVA: 0x00BFCE30 File Offset: 0x00BFB030
		public bool CnvPerTxOptionsTransmitPreEmphasis_A9411_Valid
		{
			get
			{
				short num = (short)1469714348;
				short num2 = num;
				num = (short)1906708396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)219086848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)621281281;
				if (num != 0)
				{
				}
				num = (short)2117730304;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Valid;
			}
			set
			{
				short num = (short)1796079617;
				if (num != 0)
				{
				}
				num = (short)1513357312;
				short num2 = num;
				num = (short)992786779;
				short num3 = num;
				num = (short)1860680027;
				switch (num3 == num)
				{
				}
				num = (short)2144141312;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Valid = value;
			}
		}

		// Token: 0x170067B0 RID: 26544
		// (get) Token: 0x0600CE14 RID: 52756 RVA: 0x00BFCEE8 File Offset: 0x00BFB0E8
		// (set) Token: 0x0600CE15 RID: 52757 RVA: 0x00BFCF98 File Offset: 0x00BFB198
		public bool CnvPerTxOptionsTransmitPreEmphasis_A9411_Visible
		{
			get
			{
				short num = (short)538405743;
				short num2 = num;
				num = (short)847604591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231800832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1028521985;
				if (num != 0)
				{
				}
				num = (short)71303168;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Visible;
			}
			set
			{
				short num = (short)1845444288;
				short num2 = num;
				num = (short)1353989824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1062731776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1271595009;
				if (num != 0)
				{
				}
				num = (short)157548544;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Visible = value;
			}
		}

		// Token: 0x170067B1 RID: 26545
		// (get) Token: 0x0600CE16 RID: 52758 RVA: 0x00BFD04C File Offset: 0x00BFB24C
		// (set) Token: 0x0600CE17 RID: 52759 RVA: 0x00BFD100 File Offset: 0x00BFB300
		public bool CnvPerTxOptionsTransmitPreEmphasis_A9411_Editable
		{
			get
			{
				short num = (short)2044078061;
				short num2 = num;
				num = (short)99035117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071972352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1558511617;
				if (num != 0)
				{
				}
				num = (short)211943424;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Editable;
			}
			set
			{
				short num = (short)908788894;
				short num2 = num;
				num = (short)328336542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1003290624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109734913;
				if (num != 0)
				{
				}
				num = (short)1201602560;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPreEmphasis_A9411.Editable = value;
			}
		}

		// Token: 0x170067B2 RID: 26546
		// (get) Token: 0x0600CE18 RID: 52760 RVA: 0x00BFD1B8 File Offset: 0x00BFB3B8
		internal string CnvPerTxOptionsTransmitPreEmphasis_A9411_UILabel
		{
			get
			{
				short num = (short)2112245758;
				short num2 = num;
				num = (short)812863486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144993280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1705771008;
				if (num != 0)
				{
				}
				num = (short)1925513217;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.UIName;
			}
		}

		// Token: 0x170067B3 RID: 26547
		// (get) Token: 0x0600CE19 RID: 52761 RVA: 0x00BFD26C File Offset: 0x00BFB46C
		// (set) Token: 0x0600CE1A RID: 52762 RVA: 0x00BFD320 File Offset: 0x00BFB520
		internal bool CnvPerTxOptionsTransmitPreEmphasis_A9411_HiddenStatic
		{
			get
			{
				short num = (short)1590655019;
				short num2 = num;
				num = (short)1964996651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)355401728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1365114881;
				if (num != 0)
				{
				}
				num = (short)1306525696;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.HiddenStatic;
			}
			set
			{
				short num = (short)957075646;
				short num2 = num;
				num = (short)1470877886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)297009152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)235208704;
				if (num != 0)
				{
				}
				num = (short)565641217;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPreEmphasis_A9411.HiddenStatic = value;
			}
		}

		// Token: 0x170067B4 RID: 26548
		// (get) Token: 0x0600CE1B RID: 52763 RVA: 0x00BFD3D8 File Offset: 0x00BFB5D8
		// (set) Token: 0x0600CE1C RID: 52764 RVA: 0x00BFD490 File Offset: 0x00BFB690
		internal bool CnvPerTxOptionsTransmitPreEmphasis_A9411_HiddenDynamic
		{
			get
			{
				short num = (short)607715329;
				if (num != 0)
				{
				}
				num = (short)1574961152;
				short num2 = num;
				num = (short)1572022155;
				short num3 = num;
				num = (short)1393960843;
				switch (num3 == num)
				{
				}
				num = (short)1983774720;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411.HiddenDynamic;
			}
			set
			{
				short num = (short)690264839;
				short num2 = num;
				num = (short)1433180935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2111438848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463667200;
				if (num != 0)
				{
				}
				num = (short)1969750017;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPreEmphasis_A9411.HiddenDynamic = value;
			}
		}

		// Token: 0x170067B5 RID: 26549
		// (get) Token: 0x0600CE1D RID: 52765 RVA: 0x00BFD544 File Offset: 0x00BFB744
		public bool CnvPerTxOptionsTransmitPreEmphasis_A9411_HasDiffs
		{
			get
			{
				short num = (short)620248786;
				short num2 = num;
				num = (short)166411986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1424228352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)640811009;
				if (num != 0)
				{
				}
				num = (short)983695360;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPreEmphasis_A9411._HasDiffs;
			}
		}

		// Token: 0x170067B6 RID: 26550
		// (get) Token: 0x0600CE1E RID: 52766 RVA: 0x00BFD5F8 File Offset: 0x00BFB7F8
		// (set) Token: 0x0600CE1F RID: 52767 RVA: 0x00BFD6B0 File Offset: 0x00BFB8B0
		public int CnvPerTxOptionsTransmitPowerLevel_A9420Value
		{
			get
			{
				short num = (short)647183223;
				short num2 = num;
				num = (short)422984567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)82968576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756168193;
				if (num != 0)
				{
				}
				num = (short)1925644288;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.Value;
			}
			set
			{
				short num = (short)1693444512;
				short num2 = num;
				num = (short)1946085792;
				switch (num2 == num)
				{
				default:
				{
					num = (short)821362688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1066663937;
				if (num != 0)
				{
				}
				num = (short)2030829568;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPowerLevel_A9420.Value = value;
			}
		}

		// Token: 0x170067B7 RID: 26551
		// (get) Token: 0x0600CE20 RID: 52768 RVA: 0x00BFD76C File Offset: 0x00BFB96C
		// (set) Token: 0x0600CE21 RID: 52769 RVA: 0x00BFD824 File Offset: 0x00BFBA24
		public string CnvPerTxOptionsTransmitPowerLevel_A9420_UIValue
		{
			get
			{
				short num = (short)268307255;
				short num2 = num;
				num = (short)137431863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536884736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)580386817;
				if (num != 0)
				{
				}
				num = (short)737869824;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.UIValue;
			}
			set
			{
				short num = (short)416533071;
				short num2 = num;
				num = (short)712559183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1443430400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270663680;
				if (num != 0)
				{
				}
				num = (short)1632698369;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPowerLevel_A9420.UIValue = value;
			}
		}

		// Token: 0x170067B8 RID: 26552
		// (get) Token: 0x0600CE22 RID: 52770 RVA: 0x00BFD8D8 File Offset: 0x00BFBAD8
		public global::AcpBusinessLayer.AcpListField CnvPerTxOptionsTransmitPowerLevel_A9420
		{
			get
			{
				short num = (short)759907188;
				short num2 = num;
				num = (short)780157812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562640384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)901709824;
				if (num != 0)
				{
				}
				num = (short)850264065;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420;
			}
		}

		// Token: 0x170067B9 RID: 26553
		// (get) Token: 0x0600CE23 RID: 52771 RVA: 0x00BFD988 File Offset: 0x00BFBB88
		// (set) Token: 0x0600CE24 RID: 52772 RVA: 0x00BFDA3C File Offset: 0x00BFBC3C
		public bool CnvPerTxOptionsTransmitPowerLevel_A9420_Applicable
		{
			get
			{
				short num = (short)451983155;
				short num2 = num;
				num = (short)592623411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295187968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2026962945;
				if (num != 0)
				{
				}
				num = (short)233373696;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.Applicable;
			}
			set
			{
				short num = (short)164364289;
				if (num != 0)
				{
				}
				num = (short)475201536;
				short num2 = num;
				num = (short)1161570860;
				short num3 = num;
				num = (short)712911404;
				switch (num3 == num)
				{
				}
				num = (short)300351488;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPowerLevel_A9420.Applicable = value;
			}
		}

		// Token: 0x170067BA RID: 26554
		// (get) Token: 0x0600CE25 RID: 52773 RVA: 0x00BFDAF0 File Offset: 0x00BFBCF0
		// (set) Token: 0x0600CE26 RID: 52774 RVA: 0x00BFDBA4 File Offset: 0x00BFBDA4
		public bool CnvPerTxOptionsTransmitPowerLevel_A9420_Valid
		{
			get
			{
				short num = (short)2068494743;
				short num2 = num;
				num = (short)308394391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)185335808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)677183489;
				if (num != 0)
				{
				}
				num = (short)488505344;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.Valid;
			}
			set
			{
				short num = (short)497382452;
				short num2 = num;
				num = (short)790787124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)333709312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)108396545;
				if (num != 0)
				{
				}
				num = (short)2010841088;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPowerLevel_A9420.Valid = value;
			}
		}

		// Token: 0x170067BB RID: 26555
		// (get) Token: 0x0600CE27 RID: 52775 RVA: 0x00BFDC58 File Offset: 0x00BFBE58
		// (set) Token: 0x0600CE28 RID: 52776 RVA: 0x00BFDD0C File Offset: 0x00BFBF0C
		public bool CnvPerTxOptionsTransmitPowerLevel_A9420_Visible
		{
			get
			{
				short num = (short)1514844577;
				short num2 = num;
				num = (short)587510177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046085632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)193658880;
				if (num != 0)
				{
				}
				num = (short)744488961;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.Visible;
			}
			set
			{
				short num = (short)1044338783;
				short num2 = num;
				num = (short)166287455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15269888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)256573441;
				if (num != 0)
				{
				}
				num = (short)848166912;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPowerLevel_A9420.Visible = value;
			}
		}

		// Token: 0x170067BC RID: 26556
		// (get) Token: 0x0600CE29 RID: 52777 RVA: 0x00BFDDC4 File Offset: 0x00BFBFC4
		// (set) Token: 0x0600CE2A RID: 52778 RVA: 0x00BFDE78 File Offset: 0x00BFC078
		public bool CnvPerTxOptionsTransmitPowerLevel_A9420_Editable
		{
			get
			{
				short num = (short)1917648897;
				if (num != 0)
				{
				}
				num = (short)1626341376;
				short num2 = num;
				num = (short)1807385835;
				short num3 = num;
				num = (short)810124523;
				switch (num3 == num)
				{
				}
				num = (short)1431306240;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.Editable;
			}
			set
			{
				short num = (short)170814490;
				short num2 = num;
				num = (short)1374120986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1822490624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1069416449;
				if (num != 0)
				{
				}
				num = (short)1031536640;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPowerLevel_A9420.Editable = value;
			}
		}

		// Token: 0x170067BD RID: 26557
		// (get) Token: 0x0600CE2B RID: 52779 RVA: 0x00BFDF2C File Offset: 0x00BFC12C
		internal string CnvPerTxOptionsTransmitPowerLevel_A9420_UILabel
		{
			get
			{
				short num = (short)912982017;
				if (num != 0)
				{
				}
				num = (short)1099104256;
				short num2 = num;
				num = (short)1213578952;
				short num3 = num;
				num = (short)642760392;
				switch (num3 == num)
				{
				}
				num = (short)933298176;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.UIName;
			}
		}

		// Token: 0x170067BE RID: 26558
		// (get) Token: 0x0600CE2C RID: 52780 RVA: 0x00BFDFE4 File Offset: 0x00BFC1E4
		// (set) Token: 0x0600CE2D RID: 52781 RVA: 0x00BFE098 File Offset: 0x00BFC298
		internal bool CnvPerTxOptionsTransmitPowerLevel_A9420_HiddenStatic
		{
			get
			{
				short num = (short)2086292107;
				short num2 = num;
				num = (short)183716491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872101376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1828061185;
				if (num != 0)
				{
				}
				num = (short)322371584;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.HiddenStatic;
			}
			set
			{
				short num = (short)759234561;
				if (num != 0)
				{
				}
				num = (short)285999104;
				short num2 = num;
				num = (short)1608388275;
				short num3 = num;
				num = (short)672927411;
				switch (num3 == num)
				{
				}
				num = (short)1252917248;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPowerLevel_A9420.HiddenStatic = value;
			}
		}

		// Token: 0x170067BF RID: 26559
		// (get) Token: 0x0600CE2E RID: 52782 RVA: 0x00BFE154 File Offset: 0x00BFC354
		// (set) Token: 0x0600CE2F RID: 52783 RVA: 0x00BFE204 File Offset: 0x00BFC404
		internal bool CnvPerTxOptionsTransmitPowerLevel_A9420_HiddenDynamic
		{
			get
			{
				short num = (short)1903223109;
				short num2 = num;
				num = (short)960160069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1316552704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)293666817;
				if (num != 0)
				{
				}
				num = (short)1442971648;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420.HiddenDynamic;
			}
			set
			{
				short num = (short)543148128;
				short num2 = num;
				num = (short)1505282144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666121728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)70320128;
				if (num != 0)
				{
				}
				num = (short)1360068609;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTransmitPowerLevel_A9420.HiddenDynamic = value;
			}
		}

		// Token: 0x170067C0 RID: 26560
		// (get) Token: 0x0600CE30 RID: 52784 RVA: 0x00BFE2B4 File Offset: 0x00BFC4B4
		public bool CnvPerTxOptionsTransmitPowerLevel_A9420_HasDiffs
		{
			get
			{
				short num = (short)549353829;
				short num2 = num;
				num = (short)1258387813;
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
				num = (short)1639120896;
				if (num != 0)
				{
				}
				num = (short)1231486977;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTransmitPowerLevel_A9420._HasDiffs;
			}
		}

		// Token: 0x170067C1 RID: 26561
		// (get) Token: 0x0600CE31 RID: 52785 RVA: 0x00BFE368 File Offset: 0x00BFC568
		// (set) Token: 0x0600CE32 RID: 52786 RVA: 0x00BFE420 File Offset: 0x00BFC620
		public int CnvPerTxOptionsTxVoiceSignalType_A9574Value
		{
			get
			{
				short num = (short)299713689;
				short num2 = num;
				num = (short)1906721945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1672085504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)747962369;
				if (num != 0)
				{
				}
				num = (short)1987903488;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.Value;
			}
			set
			{
				short num = (short)2110887277;
				short num2 = num;
				num = (short)2117506413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)114622464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)122683393;
				if (num != 0)
				{
				}
				num = (short)950730752;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTxVoiceSignalType_A9574.Value = value;
			}
		}

		// Token: 0x170067C2 RID: 26562
		// (get) Token: 0x0600CE33 RID: 52787 RVA: 0x00BFE4D8 File Offset: 0x00BFC6D8
		// (set) Token: 0x0600CE34 RID: 52788 RVA: 0x00BFE588 File Offset: 0x00BFC788
		public string CnvPerTxOptionsTxVoiceSignalType_A9574_UIValue
		{
			get
			{
				short num = (short)463886583;
				short num2 = num;
				num = (short)430921975;
				switch (num2 == num)
				{
				}
				num = (short)226689025;
				if (num != 0)
				{
				}
				num = (short)1932394496;
				short num3 = num;
				num = (short)1312423936;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.UIValue;
			}
			set
			{
				short num = (short)803374699;
				short num2 = num;
				num = (short)887326315;
				switch (num2 == num)
				{
				}
				num = (short)187695105;
				if (num != 0)
				{
				}
				num = (short)938475520;
				short num3 = num;
				num = (short)2085814272;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTxVoiceSignalType_A9574.UIValue = value;
			}
		}

		// Token: 0x170067C3 RID: 26563
		// (get) Token: 0x0600CE35 RID: 52789 RVA: 0x00BFE63C File Offset: 0x00BFC83C
		public global::AcpBusinessLayer.AcpListField CnvPerTxOptionsTxVoiceSignalType_A9574
		{
			get
			{
				short num = (short)1458568861;
				short num2 = num;
				num = (short)1698692765;
				switch (num2 == num)
				{
				}
				num = (short)1861091329;
				if (num != 0)
				{
				}
				num = (short)2129002496;
				short num3 = num;
				num = (short)1165819904;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574;
			}
		}

		// Token: 0x170067C4 RID: 26564
		// (get) Token: 0x0600CE36 RID: 52790 RVA: 0x00BFE6E8 File Offset: 0x00BFC8E8
		// (set) Token: 0x0600CE37 RID: 52791 RVA: 0x00BFE79C File Offset: 0x00BFC99C
		public bool CnvPerTxOptionsTxVoiceSignalType_A9574_Applicable
		{
			get
			{
				short num = (short)1657602049;
				if (num != 0)
				{
				}
				num = (short)172728639;
				short num2 = num;
				num = (short)230859071;
				switch (num2 == num)
				{
				}
				num = (short)1781334016;
				short num3 = num;
				num = (short)78512128;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.Applicable;
			}
			set
			{
				short num = (short)1721501909;
				short num2 = num;
				num = (short)98109653;
				switch (num2 == num)
				{
				}
				num = (short)282787841;
				if (num != 0)
				{
				}
				num = (short)1685454848;
				short num3 = num;
				num = (short)1086390272;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTxVoiceSignalType_A9574.Applicable = value;
			}
		}

		// Token: 0x170067C5 RID: 26565
		// (get) Token: 0x0600CE38 RID: 52792 RVA: 0x00BFE850 File Offset: 0x00BFCA50
		// (set) Token: 0x0600CE39 RID: 52793 RVA: 0x00BFE904 File Offset: 0x00BFCB04
		public bool CnvPerTxOptionsTxVoiceSignalType_A9574_Valid
		{
			get
			{
				short num = (short)621407586;
				short num2 = num;
				num = (short)646966626;
				switch (num2 == num)
				{
				}
				num = (short)628228097;
				if (num != 0)
				{
				}
				num = (short)1009385472;
				short num3 = num;
				num = (short)1391853568;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.Valid;
			}
			set
			{
				short num = (short)1484717042;
				short num2 = num;
				num = (short)523828210;
				switch (num2 == num)
				{
				}
				num = (short)726597633;
				if (num != 0)
				{
				}
				num = (short)1699807232;
				short num3 = num;
				num = (short)573440000;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTxVoiceSignalType_A9574.Valid = value;
			}
		}

		// Token: 0x170067C6 RID: 26566
		// (get) Token: 0x0600CE3A RID: 52794 RVA: 0x00BFE9BC File Offset: 0x00BFCBBC
		// (set) Token: 0x0600CE3B RID: 52795 RVA: 0x00BFEA74 File Offset: 0x00BFCC74
		public bool CnvPerTxOptionsTxVoiceSignalType_A9574_Visible
		{
			get
			{
				short num = (short)526402344;
				short num2 = num;
				num = (short)1240744744;
				switch (num2 == num)
				{
				}
				num = (short)807337985;
				if (num != 0)
				{
				}
				num = (short)1490812928;
				short num3 = num;
				num = (short)1279852544;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.Visible;
			}
			set
			{
				short num = (short)1667488446;
				short num2 = num;
				num = (short)1578556094;
				switch (num2 == num)
				{
				}
				num = (short)1503920129;
				if (num != 0)
				{
				}
				num = (short)1453719552;
				short num3 = num;
				num = (short)1811611648;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTxVoiceSignalType_A9574.Visible = value;
			}
		}

		// Token: 0x170067C7 RID: 26567
		// (get) Token: 0x0600CE3C RID: 52796 RVA: 0x00BFEB28 File Offset: 0x00BFCD28
		// (set) Token: 0x0600CE3D RID: 52797 RVA: 0x00BFEBDC File Offset: 0x00BFCDDC
		public bool CnvPerTxOptionsTxVoiceSignalType_A9574_Editable
		{
			get
			{
				short num = (short)971841421;
				short num2 = num;
				num = (short)342564749;
				switch (num2 == num)
				{
				}
				num = (short)361299969;
				if (num != 0)
				{
				}
				num = (short)755630080;
				short num3 = num;
				num = (short)764674048;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.Editable;
			}
			set
			{
				short num = (short)1294271780;
				short num2 = num;
				num = (short)2111178020;
				switch (num2 == num)
				{
				}
				num = (short)1626669056;
				if (num != 0)
				{
				}
				num = (short)1771765760;
				short num3 = num;
				num = (short)417857537;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTxVoiceSignalType_A9574.Editable = value;
			}
		}

		// Token: 0x170067C8 RID: 26568
		// (get) Token: 0x0600CE3E RID: 52798 RVA: 0x00BFEC90 File Offset: 0x00BFCE90
		internal string CnvPerTxOptionsTxVoiceSignalType_A9574_UILabel
		{
			get
			{
				short num = (short)1969630577;
				short num2 = num;
				num = (short)2034576753;
				switch (num2 == num)
				{
				}
				num = (short)1166999553;
				if (num != 0)
				{
				}
				num = (short)196083712;
				short num3 = num;
				num = (short)1743126528;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.UIName;
			}
		}

		// Token: 0x170067C9 RID: 26569
		// (get) Token: 0x0600CE3F RID: 52799 RVA: 0x00BFED44 File Offset: 0x00BFCF44
		// (set) Token: 0x0600CE40 RID: 52800 RVA: 0x00BFEDF8 File Offset: 0x00BFCFF8
		internal bool CnvPerTxOptionsTxVoiceSignalType_A9574_HiddenStatic
		{
			get
			{
				short num = (short)1185510132;
				short num2 = num;
				num = (short)912093940;
				switch (num2 == num)
				{
				}
				num = (short)318439424;
				if (num != 0)
				{
				}
				num = (short)881000448;
				short num3 = num;
				num = (short)202440705;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.HiddenStatic;
			}
			set
			{
				short num = (short)1975231116;
				short num2 = num;
				num = (short)1114481292;
				switch (num2 == num)
				{
				}
				num = (short)1755709441;
				if (num != 0)
				{
				}
				num = (short)941621248;
				short num3 = num;
				num = (short)648478720;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTxVoiceSignalType_A9574.HiddenStatic = value;
			}
		}

		// Token: 0x170067CA RID: 26570
		// (get) Token: 0x0600CE41 RID: 52801 RVA: 0x00BFEEAC File Offset: 0x00BFD0AC
		// (set) Token: 0x0600CE42 RID: 52802 RVA: 0x00BFEF64 File Offset: 0x00BFD164
		internal bool CnvPerTxOptionsTxVoiceSignalType_A9574_HiddenDynamic
		{
			get
			{
				short num = (short)414273178;
				short num2 = num;
				num = (short)2121944730;
				switch (num2 == num)
				{
				}
				num = (short)1623523329;
				if (num != 0)
				{
				}
				num = (short)1804271616;
				short num3 = num;
				num = (short)1534525440;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574.HiddenDynamic;
			}
			set
			{
				short num = (short)560542236;
				short num2 = num;
				num = (short)1350119964;
				switch (num2 == num)
				{
				}
				num = (short)1869414401;
				if (num != 0)
				{
				}
				num = (short)1832517632;
				short num3 = num;
				num = (short)148766720;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTxVoiceSignalType_A9574.HiddenDynamic = value;
			}
		}

		// Token: 0x170067CB RID: 26571
		// (get) Token: 0x0600CE43 RID: 52803 RVA: 0x00BFF01C File Offset: 0x00BFD21C
		public bool CnvPerTxOptionsTxVoiceSignalType_A9574_HasDiffs
		{
			get
			{
				short num = (short)457641417;
				short num2 = num;
				num = (short)989007305;
				switch (num2 == num)
				{
				}
				num = (short)1497890817;
				if (num != 0)
				{
				}
				num = (short)1369374720;
				short num3 = num;
				num = (short)523894784;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTxVoiceSignalType_A9574._HasDiffs;
			}
		}

		// Token: 0x170067CC RID: 26572
		// (get) Token: 0x0600CE44 RID: 52804 RVA: 0x00BFF0D0 File Offset: 0x00BFD2D0
		// (set) Token: 0x0600CE45 RID: 52805 RVA: 0x00BFF184 File Offset: 0x00BFD384
		public bool CnvPerTxOptionsTalkPermitToneValue
		{
			get
			{
				short num = (short)274579376;
				short num2 = num;
				num = (short)1009631152;
				switch (num2 == num)
				{
				}
				num = (short)1110441985;
				if (num != 0)
				{
				}
				num = (short)46661632;
				short num3 = num;
				num = (short)119013376;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTalkPermitTone.Value;
			}
			set
			{
				short num = (short)1648366301;
				short num2 = num;
				num = (short)428610269;
				switch (num2 == num)
				{
				}
				num = (short)903544833;
				if (num != 0)
				{
				}
				num = (short)1984495616;
				short num3 = num;
				num = (short)16449536;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTalkPermitTone.Value = value;
			}
		}

		// Token: 0x170067CD RID: 26573
		// (get) Token: 0x0600CE46 RID: 52806 RVA: 0x00BFF238 File Offset: 0x00BFD438
		public global::AcpBusinessLayer.AcpField<bool> CnvPerTxOptionsTalkPermitTone
		{
			get
			{
				short num = (short)1860357873;
				short num2 = num;
				num = (short)191942385;
				switch (num2 == num)
				{
				}
				num = (short)915734529;
				if (num != 0)
				{
				}
				num = (short)824639488;
				short num3 = num;
				num = (short)236584960;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTalkPermitTone;
			}
		}

		// Token: 0x170067CE RID: 26574
		// (get) Token: 0x0600CE47 RID: 52807 RVA: 0x00BFF2EC File Offset: 0x00BFD4EC
		// (set) Token: 0x0600CE48 RID: 52808 RVA: 0x00BFF3A0 File Offset: 0x00BFD5A0
		public bool CnvPerTxOptionsTalkPermitTone_UIValue
		{
			get
			{
				short num = (short)1052505409;
				short num2 = num;
				num = (short)1931932993;
				switch (num2 == num)
				{
				}
				num = (short)1615396864;
				if (num != 0)
				{
				}
				num = (short)1505951744;
				short num3 = num;
				num = (short)1766653953;
				if (num != 0)
				{
				}
				return this.cnvPerTxOptionsTalkPermitTone.Value;
			}
			set
			{
				short num = (short)1437474434;
				short num2 = num;
				num = (short)109780610;
				switch (num2 == num)
				{
				}
				num = (short)1694826497;
				if (num != 0)
				{
				}
				num = (short)837746688;
				short num3 = num;
				num = (short)270729216;
				if (num != 0)
				{
				}
				this.cnvPerTxOptionsTalkPermitTone.Value = value;
			}
		}

		// Token: 0x170067CF RID: 26575
		// (get) Token: 0x0600CE49 RID: 52809 RVA: 0x00BFF454 File Offset: 0x00BFD654
		// (set) Token: 0x0600CE4A RID: 52810 RVA: 0x00BFF508 File Offset: 0x00BFD708
		public bool CnvPerTxOptionsTalkPermitTone_Applicable
		{
			get
			{
				short num = (short)464477706;
				short num2 = num;
				num = (short)1799511562;
				switch (num2 == num)
				{
				}
				num = (short)1310392321;
				if (num != 0)
				{
				}
				num = (short)878706688;
				short num3 = num;
				num = (short)270991360;
				if (num != 0)
				{
				}
				return this.CnvPerTxOptionsTalkPermitTone.Applicable;
			}
			set
			{
				short num = (short)2048155899;
				short num2 = num;
				num = (short)767320315;
				switch (num2 == num)
				{
				}
				num = (short)115867648;
				if (num != 0)
				{
				}
				num = (short)502267904;
				short num3 = num;
				num = (short)1649606657;
				if (num != 0)
				{
				}
				this.CnvPerTxOptionsTalkPermitTone.Applicable = value;
			}
		}

		// Token: 0x170067D0 RID: 26576
		// (get) Token: 0x0600CE4B RID: 52811 RVA: 0x00BFF5C0 File Offset: 0x00BFD7C0
		// (set) Token: 0x0600CE4C RID: 52812 RVA: 0x00BFF674 File Offset: 0x00BFD874
		public bool CnvPerTxOptionsTalkPermitTone_Valid
		{
			get
			{
				short num = (short)1686890116;
				short num2 = num;
				num = (short)143189636;
				switch (num2 == num)
				{
				}
				num = (short)424673281;
				if (num != 0)
				{
				}
				num = (short)1025179648;
				short num3 = num;
				num = (short)1489764352;
				if (num != 0)
				{
				}
				return this.CnvPerTxOptionsTalkPermitTone.Valid;
			}
			set
			{
				short num = (short)218747557;
				short num2 = num;
				num = (short)1651167909;
				switch (num2 == num)
				{
				}
				num = (short)257884161;
				if (num != 0)
				{
				}
				num = (short)1937375232;
				short num3 = num;
				num = (short)1963065344;
				if (num != 0)
				{
				}
				this.CnvPerTxOptionsTalkPermitTone.Valid = value;
			}
		}

		// Token: 0x170067D1 RID: 26577
		// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x00BFF728 File Offset: 0x00BFD928
		// (set) Token: 0x0600CE4E RID: 52814 RVA: 0x00BFF7DC File Offset: 0x00BFD9DC
		public bool CnvPerTxOptionsTalkPermitTone_Visible
		{
			get
			{
				short num = (short)1630890277;
				short num2 = num;
				num = (short)1006987557;
				switch (num2 == num)
				{
				}
				num = (short)1124007937;
				if (num != 0)
				{
				}
				num = (short)534446080;
				short num3 = num;
				num = (short)1921515520;
				if (num != 0)
				{
				}
				return this.CnvPerTxOptionsTalkPermitTone.Visible;
			}
			set
			{
				short num = (short)1513011731;
				short num2 = num;
				num = (short)288733715;
				switch (num2 == num)
				{
				}
				num = (short)622264321;
				if (num != 0)
				{
				}
				num = (short)1984233472;
				short num3 = num;
				num = (short)900005888;
				if (num != 0)
				{
				}
				this.CnvPerTxOptionsTalkPermitTone.Visible = value;
			}
		}

		// Token: 0x170067D2 RID: 26578
		// (get) Token: 0x0600CE4F RID: 52815 RVA: 0x00BFF890 File Offset: 0x00BFDA90
		// (set) Token: 0x0600CE50 RID: 52816 RVA: 0x00BFF944 File Offset: 0x00BFDB44
		public bool CnvPerTxOptionsTalkPermitTone_Editable
		{
			get
			{
				short num = (short)540950858;
				short num2 = num;
				num = (short)630341962;
				switch (num2 == num)
				{
				}
				num = (short)922484736;
				if (num != 0)
				{
				}
				num = (short)860553216;
				short num3 = num;
				num = (short)1934163969;
				if (num != 0)
				{
				}
				return this.CnvPerTxOptionsTalkPermitTone.Editable;
			}
			set
			{
				short num = (short)1466040321;
				if (num != 0)
				{
				}
				num = (short)964138726;
				short num2 = num;
				num = (short)1479841510;
				switch (num2 == num)
				{
				}
				num = (short)1422852096;
				short num3 = num;
				num = (short)1766064128;
				if (num != 0)
				{
				}
				this.CnvPerTxOptionsTalkPermitTone.Editable = value;
			}
		}

		// Token: 0x170067D3 RID: 26579
		// (get) Token: 0x0600CE51 RID: 52817 RVA: 0x00BFF9FC File Offset: 0x00BFDBFC
		internal string CnvPerTxOptionsTalkPermitTone_UILabel
		{
			get
			{
				short num = (short)445906945;
				if (num != 0)
				{
				}
				num = (short)1325664350;
				short num2 = num;
				num = (short)302647390;
				switch (num2 == num)
				{
				}
				num = (short)375652352;
				short num3 = num;
				num = (short)563740672;
				if (num != 0)
				{
				}
				return this.CnvPerTxOptionsTalkPermitTone.UIName;
			}
		}

		// Token: 0x170067D4 RID: 26580
		// (get) Token: 0x0600CE52 RID: 52818 RVA: 0x00BFFAB4 File Offset: 0x00BFDCB4
		// (set) Token: 0x0600CE53 RID: 52819 RVA: 0x00BFFB68 File Offset: 0x00BFDD68
		internal bool CnvPerTxOptionsTalkPermitTone_HiddenStatic
		{
			get
			{
				short num = (short)238267941;
				short num2 = num;
				num = (short)2083827237;
				switch (num2 == num)
				{
				}
				num = (short)1775239169;
				if (num != 0)
				{
				}
				num = (short)1392115712;
				short num3 = num;
				num = (short)366280704;
				if (num != 0)
				{
				}
				return this.CnvPerTxOptionsTalkPermitTone.HiddenStatic;
			}
			set
			{
				short num = (short)590435950;
				short num2 = num;
				num = (short)1940018798;
				switch (num2 == num)
				{
				}
				num = (short)721747969;
				if (num != 0)
				{
				}
				num = (short)1271988224;
				short num3 = num;
				num = (short)1493041152;
				if (num != 0)
				{
				}
				this.CnvPerTxOptionsTalkPermitTone.HiddenStatic = value;
			}
		}

		// Token: 0x170067D5 RID: 26581
		// (get) Token: 0x0600CE54 RID: 52820 RVA: 0x00BFFC20 File Offset: 0x00BFDE20
		// (set) Token: 0x0600CE55 RID: 52821 RVA: 0x00BFFCD8 File Offset: 0x00BFDED8
		internal bool CnvPerTxOptionsTalkPermitTone_HiddenDynamic
		{
			get
			{
				short num = (short)1634271233;
				if (num != 0)
				{
				}
				num = (short)17934693;
				short num2 = num;
				num = (short)1768728933;
				switch (num2 == num)
				{
				}
				num = (short)570294272;
				short num3 = num;
				num = (short)848429056;
				if (num != 0)
				{
				}
				return this.CnvPerTxOptionsTalkPermitTone.HiddenDynamic;
			}
			set
			{
				short num = (short)1313596032;
				short num2 = num;
				num = (short)2008408704;
				switch (num2 == num)
				{
				}
				num = (short)1698889729;
				if (num != 0)
				{
				}
				num = (short)1858142208;
				short num3 = num;
				num = (short)817561600;
				if (num != 0)
				{
				}
				this.CnvPerTxOptionsTalkPermitTone.HiddenDynamic = value;
			}
		}

		// Token: 0x170067D6 RID: 26582
		// (get) Token: 0x0600CE56 RID: 52822 RVA: 0x00BFFD8C File Offset: 0x00BFDF8C
		public bool CnvPerTxOptionsTalkPermitTone_HasDiffs
		{
			get
			{
				short num = (short)574907188;
				short num2 = num;
				num = (short)26764084;
				switch (num2 == num)
				{
				}
				num = (short)1247674369;
				if (num != 0)
				{
				}
				num = (short)2082013184;
				short num3 = num;
				num = (short)1509752832;
				if (num != 0)
				{
				}
				return this.CnvPerTxOptionsTalkPermitTone._HasDiffs;
			}
		}

		// Token: 0x0600CE57 RID: 52823 RVA: 0x00BFFE44 File Offset: 0x00BFE044
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
					num2 = (short)1382878361;
					short num3 = num2;
					num2 = (short)941821081;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15F;
					default:
						num2 = (short)636616704;
						if (num2 != 0)
						{
						}
						num2 = (short)1348468737;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1553530882;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
				{
					num2 = (short)518324224;
					short num4 = num2;
					num2 = (short)1848049664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_15F;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)375259137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_15F:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)513998851;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)341180420;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04006501 RID: 25857
		private global::AcpBusinessLayer.AcpField<bool> cnvPerTxOptionsAdaptivePower_A7405;

		// Token: 0x04006502 RID: 25858
		private global::AcpBusinessLayer.AcpField<bool> cnvPerTxOptionsReverseBurstTurnOffCode_A8952;

		// Token: 0x04006503 RID: 25859
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerTxOptionsTimeOutTimersec_A9378;

		// Token: 0x04006504 RID: 25860
		private global::AcpBusinessLayer.AcpField<bool> cnvPerTxOptionsTransmitPreEmphasis_A9411;

		// Token: 0x04006505 RID: 25861
		private global::AcpBusinessLayer.AcpListField cnvPerTxOptionsTransmitPowerLevel_A9420;

		// Token: 0x04006506 RID: 25862
		private global::AcpBusinessLayer.AcpListField cnvPerTxOptionsTxVoiceSignalType_A9574;

		// Token: 0x04006507 RID: 25863
		private global::AcpBusinessLayer.AcpField<bool> cnvPerTxOptionsTalkPermitTone;
	}
}
