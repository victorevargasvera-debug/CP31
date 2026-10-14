using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005CB RID: 1483
	[global::System.Serializable]
	public class RxOptions : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C9FE RID: 51710 RVA: 0x00BC90E4 File Offset: 0x00BC72E4
		public RxOptions(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C9FF RID: 51711 RVA: 0x00BC9100 File Offset: 0x00BC7300
		protected RxOptions(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x00BC9118 File Offset: 0x00BC7318
		public override void Init()
		{
			int a_ = 9;
			short num = (short)363266048;
			short num2 = num;
			num = (short)1613763180;
			short num3 = num;
			num = (short)1599541868;
			switch (num3 == num)
			{
			}
			num = (short)2052194304;
			if (num != 0)
			{
			}
			num = (short)1091436545;
			if (num != 0)
			{
			}
			this.cnvPerRxOptionsBusyLED_A7570 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥ꫧ鿩鿫韭볯럱냳꧵맷췹짻짽ヿ", a_), global::CommonResources.AcgResources.ID_BUSYLED);
			this.cnvPerRxOptionsBusyLED_A7570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerRxOptionsBusyLED_A7570.DataTransferOrder = 61;
			this.cnvPerRxOptionsReceiveOnlyPersonality_A8916 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥뫧迩迫语駯蓱釳맵雷雹藻껽旿瀁眃椅昇欉怋服搏欑䬓圕‗⌙ⴛ⠝", a_), global::CommonResources.AcgResources.ID_RECEIVEONLYPERSONALITY);
			this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.DataTransferOrder = 1;
			this.cnvPerRxOptionsRxDeEmphasis_A9010 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥뫧鋩꣫语뗯鿱蓳黵駷觹闻跽忿䌁㴃㘅㤇㨉", a_), global::CommonResources.AcgResources.ID_RXDEEMPHASIS);
			this.cnvPerRxOptionsRxDeEmphasis_A9010.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRxOptionsRxDeEmphasis_A9010.DataTransferOrder = 78;
			this.cnvPerRxOptionsRxUnmuteDelayms_A9033 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥뫧鋩맫胭鷯蟱胳鏵볷鿹郻鿽秿漁眃夅䤇㌉㰋㴍⌏", a_), global::CommonResources.AcgResources.ID_RXUNMUTEDELAYMS, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsRxUnmuteDelayms_A9033LovStrs);
			this.cnvPerRxOptionsRxUnmuteDelayms_A9033.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRxOptionsRxUnmuteDelayms_A9033.DataTransferOrder = 62;
			this.cnvPerRxOptionsRxVoiceSignalType_A9044 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥뫧鋩뫫臭駯釱釳ꗵ釷鷹鋻鿽泿嘁紃瘅洇唉䴋㜍‏☑–", a_), global::CommonResources.AcgResources.ID_RXVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsRxVoiceSignalType_A9044LovStrs);
			this.cnvPerRxOptionsRxVoiceSignalType_A9044.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerRxOptionsRxVoiceSignalType_A9044.DataTransferOrder = 3;
			this.cnvPerRxOptionsRxVoiceSignalType_A9044.EvaluateRecRefs = true;
			this.cnvPerRxOptionsSquelchFineTune_A9176 = new global::AcpBusinessLayer.AcpSparseLOVField(20, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerRxOptionsSquelchFineTune_A9176LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerRxOptionsSquelchFineTune_A9176LovStrs), this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥믧鯩駫语鳯釱鳳냵釷铹駻꫽痿氁愃夅䤇㌉㴋㤍☏", a_), global::CommonResources.AcgResources.ID_SQUELCHFINETUNE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsSquelchFineTune_A9176LovStrs);
			this.cnvPerRxOptionsSquelchFineTune_A9176.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerRxOptionsSquelchFineTune_A9176.DataTransferOrder = 79;
			this.cnvPerRxOptionsUnmuteMuteType_A9602 = new global::AcpBusinessLayer.AcpSparseLOVField(3, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerRxOptionsUnmuteMuteType_A9602LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerRxOptionsUnmuteMuteType_A9602LovStrs), this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥뷧蓩臫鯭蓯韱맳菵賷鿹ꣻ蟽烿朁嬃䜅ㄇ㰉㰋㰍", a_), global::CommonResources.AcgResources.ID_UNMUTEMUTETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsUnmuteMuteType_A9602LovStrs);
			this.cnvPerRxOptionsUnmuteMuteType_A9602.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerRxOptionsUnmuteMuteType_A9602.DataTransferOrder = 65;
			this.cnvPerRxOptionsHearClear_A36408 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥ꃧ迩跫鳭돯黱釳韵諷ꗹ뷻췽㛿㘁㐃㸅", a_), global::CommonResources.AcgResources.ID_HEARCLEAR, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsHearClear_A36408LovStrs);
			this.cnvPerRxOptionsHearClear_A36408.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerRxOptionsHearClear_A36408.DataTransferOrder = 150;
			this.cnvPerRxOptionsConcurrentRXEnable = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍胏럑ꛓ蓕ꃗ闙곛ꫝ觟跡諣闥ꯧ藩苫跭藯胱蛳鏵雷軹껻꛽䗿氁攃搅搇漉", a_), global::CommonResources.AcgResources.ID_CONCURRENTRXENABLE);
			this.cnvPerRxOptionsConcurrentRXEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerRxOptionsConcurrentRXEnable.DataTransferOrder = 151;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飉듋鿏ꋑꃓ뿕럗듙꿛", a_);
			base.Id = 10136;
			base.UIName = global::CommonResources.AcgResources.ID_RXOPTIONS;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600CA01 RID: 51713 RVA: 0x00BC9444 File Offset: 0x00BC7644
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1140064256;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				case 1:
					num = (short)218693638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤꿦賨諪鿬곮鷰雲铴藶꛸뫺컼짾㔀㌂㴄", a_)))
					{
						num = (short)805830680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_305;
				case 3:
					goto IL_E8;
				case 4:
					goto IL_1F8;
				case 5:
					this.cnvPerRxOptionsUnmuteMuteType_A9602 = new global::AcpBusinessLayer.AcpSparseLOVField(3, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerRxOptionsUnmuteMuteType_A9602LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerRxOptionsUnmuteMuteType_A9602LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤닦蟨蛪飬鯮铰뻲胴菶鳸꿺蓼迾搀専䐄㸆㼈㬊㼌", a_), global::CommonResources.AcgResources.ID_UNMUTEMUTETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsUnmuteMuteType_A9602LovStrs);
					this.cnvPerRxOptionsUnmuteMuteType_A9602.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerRxOptionsUnmuteMuteType_A9602.DataTransferOrder = 65;
					num = (short)1275133956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)826736662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A1;
				case 7:
					goto IL_6AB;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤듦飨黪裬菮鋰鯲돴黶韸黺ꧼ諾漀昂娄䘆〈㨊㨌㤎", a_)))
					{
						num = (short)613089298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 9:
					goto IL_4CA;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤ꓦ蛨藪軬髮菰臲郴駶跸ꧺꗼ뫾漀戂朄欆氈", a_)))
					{
						num = (short)1735262222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A1;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤뗦釨뻪菬苮蓰蟲郴돶鳸韺鳼蛾氀瀂娄䘆〈㬊㸌㰎", a_)))
					{
						num = (short)231407646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_351;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤ꗦ鳨飪铬ꏮ듰럲ꫴ뛶컸컺쫼쿾", a_)))
					{
						num = (short)1422393373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 13:
					goto IL_351;
				case 14:
					this.cnvPerRxOptionsConcurrentRXEnable = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤ꓦ蛨藪軬髮菰臲郴駶跸ꧺꗼ뫾漀戂朄欆氈", a_), global::CommonResources.AcgResources.ID_CONCURRENTRXENABLE);
					this.cnvPerRxOptionsConcurrentRXEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerRxOptionsConcurrentRXEnable.DataTransferOrder = 151;
					num = (short)143392777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤뗦釨뷪苬蛮鋰雲꛴黶黸闺鳼鏾唀稂甄戆嘈䨊㐌㼎┐✒", a_)))
					{
						num = (short)1172307969;
						if (num != 0)
						{
						}
						num = (short)670433305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6AB;
				case 16:
					this.cnvPerRxOptionsReceiveOnlyPersonality_A8916 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤뗦賨裪裬蛮蟰雲뫴駶闸苺근髾猀瀂樄椆栈朊搌笎栐䰒吔⼖‘⨚⬜", a_), global::CommonResources.AcgResources.ID_RECEIVEONLYPERSONALITY);
					this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.DataTransferOrder = 1;
					num = (short)1496252444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_5F3;
				case 18:
				{
					num = (short)1690691918;
					short num3 = num;
					num = (short)234940750;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E8;
					default:
						num = (short)383909888;
						if (num != 0)
						{
						}
						this.cnvPerRxOptionsSquelchFineTune_A9176 = new global::AcpBusinessLayer.AcpSparseLOVField(20, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerRxOptionsSquelchFineTune_A9176LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerRxOptionsSquelchFineTune_A9176LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤듦飨黪裬菮鋰鯲돴黶韸黺ꧼ諾漀昂娄䘆〈㨊㨌㤎", a_), global::CommonResources.AcgResources.ID_SQUELCHFINETUNE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsSquelchFineTune_A9176LovStrs);
						this.cnvPerRxOptionsSquelchFineTune_A9176.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.cnvPerRxOptionsSquelchFineTune_A9176.DataTransferOrder = 79;
						num = (short)1178861594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 19:
					goto IL_305;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤뗦賨裪裬蛮蟰雲뫴駶闸苺근髾猀瀂樄椆栈朊搌笎栐䰒吔⼖‘⨚⬜", a_)))
					{
						num = (short)644546560;
						short num4 = num;
						num = (short)1918238736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_55D;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤뗦釨꿪裬ꫮ鳰菲鷴零諸鋺軼ꃾ䀀㨂㔄㘆㤈", a_)))
					{
						num = (short)328531995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F3;
				case 22:
					num = (short)575733772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_183;
				case 24:
					this.cnvPerRxOptionsHearClear_A36408 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤꿦賨諪鿬곮鷰雲铴藶꛸뫺컼짾㔀㌂㴄", a_), global::CommonResources.AcgResources.ID_HEARCLEAR, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsHearClear_A36408LovStrs);
					this.cnvPerRxOptionsHearClear_A36408.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerRxOptionsHearClear_A36408.DataTransferOrder = 150;
					num = (short)536215571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.cnvPerRxOptionsRxVoiceSignalType_A9044 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤뗦釨뷪苬蛮鋰雲꛴黶黸闺鳼鏾唀稂甄戆嘈䨊㐌㼎┐✒", a_), global::CommonResources.AcgResources.ID_RXVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsRxVoiceSignalType_A9044LovStrs);
					this.cnvPerRxOptionsRxVoiceSignalType_A9044.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerRxOptionsRxVoiceSignalType_A9044.DataTransferOrder = 3;
					this.cnvPerRxOptionsRxVoiceSignalType_A9044.EvaluateRecRefs = true;
					num = (short)169410567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_D0;
				case 27:
					this.cnvPerRxOptionsRxDeEmphasis_A9010 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤뗦釨꿪裬ꫮ鳰菲鷴零諸鋺軼ꃾ䀀㨂㔄㘆㤈", a_), global::CommonResources.AcgResources.ID_RXDEEMPHASIS);
					this.cnvPerRxOptionsRxDeEmphasis_A9010.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRxOptionsRxDeEmphasis_A9010.DataTransferOrder = 78;
					num = (short)1452277777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_55D;
				case 29:
					this.cnvPerRxOptionsBusyLED_A7570 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤ꗦ鳨飪铬ꏮ듰럲ꫴ뛶컸컺쫼쿾", a_), global::CommonResources.AcgResources.ID_BUSYLED);
					this.cnvPerRxOptionsBusyLED_A7570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerRxOptionsBusyLED_A7570.DataTransferOrder = 61;
					num = (short)282918935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					this.cnvPerRxOptionsRxUnmuteDelayms_A9033 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤뗦釨뻪菬苮蓰蟲郴돶鳸韺鳼蛾氀瀂娄䘆〈㬊㸌㰎", a_), global::CommonResources.AcgResources.ID_RXUNMUTEDELAYMS, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRxOptionsRxUnmuteDelayms_A9033LovStrs);
					this.cnvPerRxOptionsRxUnmuteDelayms_A9033.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRxOptionsRxUnmuteDelayms_A9033.DataTransferOrder = 62;
					num = (short)2007040013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AA:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)289079297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D0:
				num = (short)687341571;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E8:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ蟔꿖雘ꯚ꧜뛞軠跢雤닦蟨蛪飬鯮铰뻲胴菶鳸꿺蓼迾搀専䐄㸆㼈㬊㼌", a_)))
				{
					num = (short)228196357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1F8;
				IL_183:
				num = (short)1474953236;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F8:
				num = (short)1528627202;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_305:
				num = (short)1605697546;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_351:
				num = (short)1277165583;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_55D:
				num = (short)1531772949;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F3:
				num = (short)1136066571;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6AB:
				num = (short)343080968;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4CA:
			IL_7A1:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯈돊胎ꇐ꟒볔룖럘꣚", a_);
			base.Id = 10136;
			base.UIName = global::CommonResources.AcgResources.ID_RXOPTIONS;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600CA02 RID: 51714 RVA: 0x00BC9C24 File Offset: 0x00BC7E24
		public override void PopulateReferences()
		{
			short num = (short)689411450;
			short num2 = num;
			num = (short)1941083514;
			switch (num2 == num)
			{
			}
			num = (short)859701248;
			short num3 = num;
			num = (short)1764098049;
			if (num != 0)
			{
			}
			num = (short)1140195328;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CA03 RID: 51715 RVA: 0x00BC9CD0 File Offset: 0x00BC7ED0
		public override void DropReferences()
		{
			short num = (short)368390863;
			short num2 = num;
			num = (short)1364669135;
			switch (num2 == num)
			{
			}
			num = (short)1170014208;
			short num3 = num;
			num = (short)1980170240;
			if (num != 0)
			{
			}
			num = (short)956760065;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CA04 RID: 51716 RVA: 0x00BC9D78 File Offset: 0x00BC7F78
		public override void SetConstraints()
		{
			short num = (short)1392094599;
			short num2 = num;
			num = (short)928624007;
			switch (num2 == num)
			{
			}
			num = (short)102629376;
			short num3 = num;
			num = (short)2019753984;
			if (num != 0)
			{
			}
			num = (short)989659137;
			if (num != 0)
			{
			}
			this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerRxOptionReceiveOnlyPerValid);
			this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSetDirectTalkaroudToFalseWhileRxOnly);
			this.cnvPerRxOptionsRxDeEmphasis_A9010.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAnalogFlatAudioIsDisabled);
			this.cnvPerRxOptionsRxVoiceSignalType_A9044.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxVoiceSignalTypeValidity);
			this.cnvPerRxOptionsRxVoiceSignalType_A9044.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSetCnvAstroOtarValue);
			this.cnvPerRxOptionsSquelchFineTune_A9176.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSquelchPerPerIsEn);
			this.cnvPerRxOptionsHearClear_A36408.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerRxSigTypeIsNotAstroAndCnvPerSysTypeIsNotDVRS);
			this.cnvPerRxOptionsHearClear_A36408.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDVRSIsEnAndCnvHearClearValid);
			this.CnvPerRxOptionsConcurrentRXEnable.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerRxOptionsConcurrentRXEnableApplicable);
		}

		// Token: 0x0600CA05 RID: 51717 RVA: 0x00BC9F08 File Offset: 0x00BC8108
		public override void SetupDependencies()
		{
			short num = (short)730900799;
			short num2 = num;
			num = (short)2061281599;
			switch (num2 == num)
			{
			}
			num = (short)433782784;
			short num3 = num;
			num = (short)1136590849;
			if (num != 0)
			{
			}
			num = (short)1075249152;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogFlatAudio_A7443.AddDependentObject(this.cnvPerRxOptionsRxDeEmphasis_A9010);
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogFlatAudio_A7443.AddDependentObject(this.cnvPerRxOptionsRxVoiceSignalType_A9044);
			conventionalPersonality.Features.CnvPerFeaturesMixedVoteScanEnable_A38723.AddDependentObject(this.cnvPerRxOptionsRxVoiceSignalType_A9044);
			conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerRxOptionsRxVoiceSignalType_A9044);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRxOptionsRxVoiceSignalType_A9044);
			this.RefConventionalWide.General.CnvWideGeneralSquelchPerPersonality_A19313.AddDependentObject(this.cnvPerRxOptionsSquelchFineTune_A9176);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRxOptionsHearClear_A36408);
			this.cnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRxOptionsHearClear_A36408);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerRxOptionsHearClear_A36408);
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogWidebandData_A1994.AddDependentObject(this.cnvPerRxOptionsRxDeEmphasis_A9010);
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogWidebandData_A1994.AddDependentObject(this.cnvPerRxOptionsRxVoiceSignalType_A9044);
			this.RefRadioWide.DigitalAudioOptions.RadWideLabtoolMultipleConversationDisable_A19552.AddDependentObject(this.cnvPerRxOptionsConcurrentRXEnable);
		}

		// Token: 0x17006561 RID: 25953
		// (get) Token: 0x0600CA06 RID: 51718 RVA: 0x00BCA0DC File Offset: 0x00BC82DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)535567658;
				short num2 = num;
				num = (short)676732202;
				switch (num2 == num)
				{
				}
				num = (short)123600896;
				short num3 = num;
				num = (short)961609729;
				if (num != 0)
				{
				}
				num = (short)87359488;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17006562 RID: 25954
		// (get) Token: 0x0600CA07 RID: 51719 RVA: 0x00BCA18C File Offset: 0x00BC838C
		// (set) Token: 0x0600CA08 RID: 51720 RVA: 0x00BCA244 File Offset: 0x00BC8444
		public bool CnvPerRxOptionsBusyLED_A7570Value
		{
			get
			{
				short num = (short)1720102332;
				short num2 = num;
				num = (short)25406908;
				switch (num2 == num)
				{
				}
				num = (short)976814080;
				short num3 = num;
				num = (short)1024786433;
				if (num != 0)
				{
				}
				num = (short)741277696;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.Value;
			}
			set
			{
				short num = (short)833356440;
				short num2 = num;
				num = (short)2089157272;
				switch (num2 == num)
				{
				}
				num = (short)610664448;
				short num3 = num;
				num = (short)1882456065;
				if (num != 0)
				{
				}
				num = (short)1222705152;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsBusyLED_A7570.Value = value;
			}
		}

		// Token: 0x17006563 RID: 25955
		// (get) Token: 0x0600CA09 RID: 51721 RVA: 0x00BCA2FC File Offset: 0x00BC84FC
		public global::AcpBusinessLayer.AcpField<bool> CnvPerRxOptionsBusyLED_A7570
		{
			get
			{
				short num = (short)2086338561;
				if (num != 0)
				{
				}
				num = (short)944197119;
				short num2 = num;
				num = (short)127684095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675624448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1009975296;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570;
			}
		}

		// Token: 0x17006564 RID: 25956
		// (get) Token: 0x0600CA0A RID: 51722 RVA: 0x00BCA3AC File Offset: 0x00BC85AC
		// (set) Token: 0x0600CA0B RID: 51723 RVA: 0x00BCA460 File Offset: 0x00BC8660
		public bool CnvPerRxOptionsBusyLED_A7570_UIValue
		{
			get
			{
				short num = (short)1903796494;
				short num2 = num;
				num = (short)1698275598;
				switch (num2 == num)
				{
				}
				num = (short)1311768576;
				short num3 = num;
				num = (short)879951873;
				if (num != 0)
				{
				}
				num = (short)778108928;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.Value;
			}
			set
			{
				short num = (short)339343874;
				short num2 = num;
				num = (short)277215746;
				switch (num2 == num)
				{
				}
				num = (short)2064842752;
				short num3 = num;
				num = (short)1880948737;
				if (num != 0)
				{
				}
				num = (short)657129472;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsBusyLED_A7570.Value = value;
			}
		}

		// Token: 0x17006565 RID: 25957
		// (get) Token: 0x0600CA0C RID: 51724 RVA: 0x00BCA518 File Offset: 0x00BC8718
		// (set) Token: 0x0600CA0D RID: 51725 RVA: 0x00BCA5CC File Offset: 0x00BC87CC
		public bool CnvPerRxOptionsBusyLED_A7570_Applicable
		{
			get
			{
				short num = (short)1251729282;
				short num2 = num;
				num = (short)1709825922;
				switch (num2 == num)
				{
				}
				num = (short)1132658688;
				short num3 = num;
				num = (short)1066795008;
				if (num != 0)
				{
				}
				num = (short)290979841;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.Applicable;
			}
			set
			{
				short num = (short)1494717408;
				short num2 = num;
				num = (short)1722323936;
				switch (num2 == num)
				{
				}
				num = (short)152371200;
				short num3 = num;
				num = (short)1872560129;
				if (num != 0)
				{
				}
				num = (short)2110652416;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsBusyLED_A7570.Applicable = value;
			}
		}

		// Token: 0x17006566 RID: 25958
		// (get) Token: 0x0600CA0E RID: 51726 RVA: 0x00BCA680 File Offset: 0x00BC8880
		// (set) Token: 0x0600CA0F RID: 51727 RVA: 0x00BCA738 File Offset: 0x00BC8938
		public bool CnvPerRxOptionsBusyLED_A7570_Valid
		{
			get
			{
				short num = (short)1576754558;
				short num2 = num;
				num = (short)1930255742;
				switch (num2 == num)
				{
				}
				num = (short)805830656;
				short num3 = num;
				num = (short)1200750593;
				if (num != 0)
				{
				}
				num = (short)346619904;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.Valid;
			}
			set
			{
				short num = (short)1933589235;
				short num2 = num;
				num = (short)1152596723;
				switch (num2 == num)
				{
				}
				num = (short)274726912;
				short num3 = num;
				num = (short)2059272192;
				if (num != 0)
				{
				}
				num = (short)526778369;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsBusyLED_A7570.Valid = value;
			}
		}

		// Token: 0x17006567 RID: 25959
		// (get) Token: 0x0600CA10 RID: 51728 RVA: 0x00BCA7EC File Offset: 0x00BC89EC
		// (set) Token: 0x0600CA11 RID: 51729 RVA: 0x00BCA8A4 File Offset: 0x00BC8AA4
		public bool CnvPerRxOptionsBusyLED_A7570_Visible
		{
			get
			{
				short num = (short)1483083855;
				short num2 = num;
				num = (short)231411791;
				switch (num2 == num)
				{
				}
				num = (short)1718943744;
				short num3 = num;
				num = (short)1630273537;
				if (num != 0)
				{
				}
				num = (short)1344602112;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.Visible;
			}
			set
			{
				short num = (short)1800732879;
				short num2 = num;
				num = (short)1316356303;
				switch (num2 == num)
				{
				}
				num = (short)1032126464;
				short num3 = num;
				num = (short)862453760;
				if (num != 0)
				{
				}
				num = (short)235405313;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsBusyLED_A7570.Visible = value;
			}
		}

		// Token: 0x17006568 RID: 25960
		// (get) Token: 0x0600CA12 RID: 51730 RVA: 0x00BCA958 File Offset: 0x00BC8B58
		// (set) Token: 0x0600CA13 RID: 51731 RVA: 0x00BCAA0C File Offset: 0x00BC8C0C
		public bool CnvPerRxOptionsBusyLED_A7570_Editable
		{
			get
			{
				short num = (short)1091107730;
				short num2 = num;
				num = (short)215153554;
				switch (num2 == num)
				{
				}
				num = (short)2124087296;
				short num3 = num;
				num = (short)1221525505;
				if (num != 0)
				{
				}
				num = (short)1256980480;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.Editable;
			}
			set
			{
				short num = (short)1486887276;
				short num2 = num;
				num = (short)73472364;
				switch (num2 == num)
				{
				}
				num = (short)2060517376;
				short num3 = num;
				num = (short)691863552;
				if (num != 0)
				{
				}
				num = (short)276365313;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsBusyLED_A7570.Editable = value;
			}
		}

		// Token: 0x17006569 RID: 25961
		// (get) Token: 0x0600CA14 RID: 51732 RVA: 0x00BCAAC0 File Offset: 0x00BC8CC0
		internal string CnvPerRxOptionsBusyLED_A7570_UILabel
		{
			get
			{
				short num = (short)271080419;
				short num2 = num;
				num = (short)160979939;
				switch (num2 == num)
				{
				}
				num = (short)285278208;
				short num3 = num;
				num = (short)571473921;
				if (num != 0)
				{
				}
				num = (short)1512833024;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.UIName;
			}
		}

		// Token: 0x1700656A RID: 25962
		// (get) Token: 0x0600CA15 RID: 51733 RVA: 0x00BCAB74 File Offset: 0x00BC8D74
		// (set) Token: 0x0600CA16 RID: 51734 RVA: 0x00BCAC2C File Offset: 0x00BC8E2C
		internal bool CnvPerRxOptionsBusyLED_A7570_HiddenStatic
		{
			get
			{
				short num = (short)1253943184;
				short num2 = num;
				num = (short)35956624;
				switch (num2 == num)
				{
				}
				num = (short)1073217536;
				short num3 = num;
				num = (short)1400897537;
				if (num != 0)
				{
				}
				num = (short)1417347072;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.HiddenStatic;
			}
			set
			{
				short num = (short)383865777;
				short num2 = num;
				num = (short)1069700017;
				switch (num2 == num)
				{
				}
				num = (short)1389101056;
				short num3 = num;
				num = (short)1968242688;
				if (num != 0)
				{
				}
				num = (short)370933761;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsBusyLED_A7570.HiddenStatic = value;
			}
		}

		// Token: 0x1700656B RID: 25963
		// (get) Token: 0x0600CA17 RID: 51735 RVA: 0x00BCACE0 File Offset: 0x00BC8EE0
		// (set) Token: 0x0600CA18 RID: 51736 RVA: 0x00BCAD9C File Offset: 0x00BC8F9C
		internal bool CnvPerRxOptionsBusyLED_A7570_HiddenDynamic
		{
			get
			{
				short num = (short)1175503364;
				short num2 = num;
				num = (short)2071511556;
				switch (num2 == num)
				{
				}
				num = (short)982712320;
				short num3 = num;
				num = (short)945750017;
				if (num != 0)
				{
				}
				num = (short)1162477568;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570.HiddenDynamic;
			}
			set
			{
				short num = (short)1782452233;
				short num2 = num;
				num = (short)815599625;
				switch (num2 == num)
				{
				}
				num = (short)1873543168;
				short num3 = num;
				num = (short)1920598017;
				if (num != 0)
				{
				}
				num = (short)1059127296;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsBusyLED_A7570.HiddenDynamic = value;
			}
		}

		// Token: 0x1700656C RID: 25964
		// (get) Token: 0x0600CA19 RID: 51737 RVA: 0x00BCAE50 File Offset: 0x00BC9050
		public bool CnvPerRxOptionsBusyLED_A7570_HasDiffs
		{
			get
			{
				short num = (short)2050269476;
				short num2 = num;
				num = (short)704553252;
				switch (num2 == num)
				{
				}
				num = (short)1197801472;
				short num3 = num;
				num = (short)2027094017;
				if (num != 0)
				{
				}
				num = (short)1798373376;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsBusyLED_A7570._HasDiffs;
			}
		}

		// Token: 0x1700656D RID: 25965
		// (get) Token: 0x0600CA1A RID: 51738 RVA: 0x00BCAF08 File Offset: 0x00BC9108
		// (set) Token: 0x0600CA1B RID: 51739 RVA: 0x00BCAFC0 File Offset: 0x00BC91C0
		public bool CnvPerRxOptionsReceiveOnlyPersonality_A8916Value
		{
			get
			{
				short num = (short)323950751;
				short num2 = num;
				num = (short)1935546527;
				switch (num2 == num)
				{
				}
				num = (short)1312948224;
				short num3 = num;
				num = (short)781910017;
				if (num != 0)
				{
				}
				num = (short)1641873408;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Value;
			}
			set
			{
				short num = (short)501802435;
				short num2 = num;
				num = (short)1415833027;
				switch (num2 == num)
				{
				}
				num = (short)418775040;
				short num3 = num;
				num = (short)1424031745;
				if (num != 0)
				{
				}
				num = (short)1521156096;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Value = value;
			}
		}

		// Token: 0x1700656E RID: 25966
		// (get) Token: 0x0600CA1C RID: 51740 RVA: 0x00BCB074 File Offset: 0x00BC9274
		public global::AcpBusinessLayer.AcpField<bool> CnvPerRxOptionsReceiveOnlyPersonality_A8916
		{
			get
			{
				short num = (short)759169025;
				if (num != 0)
				{
				}
				num = (short)1648654578;
				short num2 = num;
				num = (short)1504475378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843331072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)177274880;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916;
			}
		}

		// Token: 0x1700656F RID: 25967
		// (get) Token: 0x0600CA1D RID: 51741 RVA: 0x00BCB124 File Offset: 0x00BC9324
		// (set) Token: 0x0600CA1E RID: 51742 RVA: 0x00BCB1D8 File Offset: 0x00BC93D8
		public bool CnvPerRxOptionsReceiveOnlyPersonality_A8916_UIValue
		{
			get
			{
				short num = (short)1468195503;
				short num2 = num;
				num = (short)2031084207;
				switch (num2 == num)
				{
				}
				num = (short)1315569664;
				short num3 = num;
				num = (short)5439489;
				if (num != 0)
				{
				}
				num = (short)991232000;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Value;
			}
			set
			{
				short num = (short)1218208679;
				short num2 = num;
				num = (short)462644135;
				switch (num2 == num)
				{
				}
				num = (short)1394606080;
				short num3 = num;
				num = (short)1482948609;
				if (num != 0)
				{
				}
				num = (short)657653760;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Value = value;
			}
		}

		// Token: 0x17006570 RID: 25968
		// (get) Token: 0x0600CA1F RID: 51743 RVA: 0x00BCB290 File Offset: 0x00BC9490
		// (set) Token: 0x0600CA20 RID: 51744 RVA: 0x00BCB344 File Offset: 0x00BC9544
		public bool CnvPerRxOptionsReceiveOnlyPersonality_A8916_Applicable
		{
			get
			{
				short num = (short)1438253057;
				if (num != 0)
				{
				}
				num = (short)485023489;
				short num2 = num;
				num = (short)400744193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)865337344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403111936;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Applicable;
			}
			set
			{
				short num = (short)1515651073;
				if (num != 0)
				{
				}
				num = (short)1360800639;
				short num2 = num;
				num = (short)324348799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1411514368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758986240;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Applicable = value;
			}
		}

		// Token: 0x17006571 RID: 25969
		// (get) Token: 0x0600CA21 RID: 51745 RVA: 0x00BCB3FC File Offset: 0x00BC95FC
		// (set) Token: 0x0600CA22 RID: 51746 RVA: 0x00BCB4B0 File Offset: 0x00BC96B0
		public bool CnvPerRxOptionsReceiveOnlyPersonality_A8916_Valid
		{
			get
			{
				short num = (short)1087994947;
				short num2 = num;
				num = (short)455834691;
				switch (num2 == num)
				{
				}
				num = (short)1675165696;
				short num3 = num;
				num = (short)1174798337;
				if (num != 0)
				{
				}
				num = (short)186712064;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Valid;
			}
			set
			{
				short num = (short)1298626215;
				short num2 = num;
				num = (short)1283159719;
				switch (num2 == num)
				{
				}
				num = (short)1022558208;
				short num3 = num;
				num = (short)1460600833;
				if (num != 0)
				{
				}
				num = (short)824770560;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Valid = value;
			}
		}

		// Token: 0x17006572 RID: 25970
		// (get) Token: 0x0600CA23 RID: 51747 RVA: 0x00BCB564 File Offset: 0x00BC9764
		// (set) Token: 0x0600CA24 RID: 51748 RVA: 0x00BCB618 File Offset: 0x00BC9818
		public bool CnvPerRxOptionsReceiveOnlyPersonality_A8916_Visible
		{
			get
			{
				short num = (short)1209340892;
				short num2 = num;
				num = (short)352261084;
				switch (num2 == num)
				{
				}
				num = (short)1244069888;
				short num3 = num;
				num = (short)1937375233;
				if (num != 0)
				{
				}
				num = (short)913571840;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Visible;
			}
			set
			{
				short num = (short)244711425;
				if (num != 0)
				{
				}
				num = (short)1176959540;
				short num2 = num;
				num = (short)1215232564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)754909184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068171264;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Visible = value;
			}
		}

		// Token: 0x17006573 RID: 25971
		// (get) Token: 0x0600CA25 RID: 51749 RVA: 0x00BCB6CC File Offset: 0x00BC98CC
		// (set) Token: 0x0600CA26 RID: 51750 RVA: 0x00BCB784 File Offset: 0x00BC9984
		public bool CnvPerRxOptionsReceiveOnlyPersonality_A8916_Editable
		{
			get
			{
				short num = (short)1213357908;
				short num2 = num;
				num = (short)2031378260;
				switch (num2 == num)
				{
				}
				num = (short)1723990016;
				short num3 = num;
				num = (short)1598357505;
				if (num != 0)
				{
				}
				num = (short)1384972288;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Editable;
			}
			set
			{
				short num = (short)269507959;
				short num2 = num;
				num = (short)2136497527;
				switch (num2 == num)
				{
				}
				num = (short)1502937088;
				short num3 = num;
				num = (short)562429953;
				if (num != 0)
				{
				}
				num = (short)972750848;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.Editable = value;
			}
		}

		// Token: 0x17006574 RID: 25972
		// (get) Token: 0x0600CA27 RID: 51751 RVA: 0x00BCB83C File Offset: 0x00BC9A3C
		internal string CnvPerRxOptionsReceiveOnlyPersonality_A8916_UILabel
		{
			get
			{
				short num = (short)1040602753;
				short num2 = num;
				num = (short)1074288257;
				switch (num2 == num)
				{
				}
				num = (short)1895432192;
				short num3 = num;
				num = (short)649658368;
				if (num != 0)
				{
				}
				num = (short)2027421697;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.UIName;
			}
		}

		// Token: 0x17006575 RID: 25973
		// (get) Token: 0x0600CA28 RID: 51752 RVA: 0x00BCB8F0 File Offset: 0x00BC9AF0
		// (set) Token: 0x0600CA29 RID: 51753 RVA: 0x00BCB9A0 File Offset: 0x00BC9BA0
		internal bool CnvPerRxOptionsReceiveOnlyPersonality_A8916_HiddenStatic
		{
			get
			{
				short num = (short)776445133;
				short num2 = num;
				num = (short)1017814221;
				switch (num2 == num)
				{
				}
				num = (short)1885339648;
				short num3 = num;
				num = (short)1617231872;
				if (num != 0)
				{
				}
				num = (short)2057961473;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.HiddenStatic;
			}
			set
			{
				short num = (short)364239330;
				short num2 = num;
				num = (short)1283840482;
				switch (num2 == num)
				{
				}
				num = (short)1496252416;
				short num3 = num;
				num = (short)1222311936;
				if (num != 0)
				{
				}
				num = (short)1690894337;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.HiddenStatic = value;
			}
		}

		// Token: 0x17006576 RID: 25974
		// (get) Token: 0x0600CA2A RID: 51754 RVA: 0x00BCBA58 File Offset: 0x00BC9C58
		// (set) Token: 0x0600CA2B RID: 51755 RVA: 0x00BCBB10 File Offset: 0x00BC9D10
		internal bool CnvPerRxOptionsReceiveOnlyPersonality_A8916_HiddenDynamic
		{
			get
			{
				short num = (short)1672481897;
				short num2 = num;
				num = (short)824511593;
				switch (num2 == num)
				{
				}
				num = (short)1478230016;
				short num3 = num;
				num = (short)417988609;
				if (num != 0)
				{
				}
				num = (short)1969750016;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.HiddenDynamic;
			}
			set
			{
				short num = (short)2037369224;
				short num2 = num;
				num = (short)927582600;
				switch (num2 == num)
				{
				}
				num = (short)508821504;
				short num3 = num;
				num = (short)1036517377;
				if (num != 0)
				{
				}
				num = (short)894304256;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsReceiveOnlyPersonality_A8916.HiddenDynamic = value;
			}
		}

		// Token: 0x17006577 RID: 25975
		// (get) Token: 0x0600CA2C RID: 51756 RVA: 0x00BCBBC4 File Offset: 0x00BC9DC4
		public bool CnvPerRxOptionsReceiveOnlyPersonality_A8916_HasDiffs
		{
			get
			{
				short num = (short)1748540280;
				short num2 = num;
				num = (short)559127416;
				switch (num2 == num)
				{
				}
				num = (short)1680801792;
				short num3 = num;
				num = (short)1207631872;
				if (num != 0)
				{
				}
				num = (short)1263992833;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsReceiveOnlyPersonality_A8916._HasDiffs;
			}
		}

		// Token: 0x17006578 RID: 25976
		// (get) Token: 0x0600CA2D RID: 51757 RVA: 0x00BCBC74 File Offset: 0x00BC9E74
		// (set) Token: 0x0600CA2E RID: 51758 RVA: 0x00BCBD28 File Offset: 0x00BC9F28
		public bool CnvPerRxOptionsRxDeEmphasis_A9010Value
		{
			get
			{
				short num = (short)832884915;
				short num2 = num;
				num = (short)1475203251;
				switch (num2 == num)
				{
				}
				num = (short)2143354880;
				short num3 = num;
				num = (short)62849025;
				if (num != 0)
				{
				}
				num = (short)572784640;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.Value;
			}
			set
			{
				short num = (short)1680854951;
				short num2 = num;
				num = (short)1886310311;
				switch (num2 == num)
				{
				}
				num = (short)1879834624;
				short num3 = num;
				num = (short)2142765057;
				if (num != 0)
				{
				}
				num = (short)1195900928;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxDeEmphasis_A9010.Value = value;
			}
		}

		// Token: 0x17006579 RID: 25977
		// (get) Token: 0x0600CA2F RID: 51759 RVA: 0x00BCBDDC File Offset: 0x00BC9FDC
		public global::AcpBusinessLayer.AcpField<bool> CnvPerRxOptionsRxDeEmphasis_A9010
		{
			get
			{
				short num = (short)1122178913;
				short num2 = num;
				num = (short)1594955617;
				switch (num2 == num)
				{
				}
				num = (short)2122252288;
				short num3 = num;
				num = (short)322306049;
				if (num != 0)
				{
				}
				num = (short)1672740864;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010;
			}
		}

		// Token: 0x1700657A RID: 25978
		// (get) Token: 0x0600CA30 RID: 51760 RVA: 0x00BCBE88 File Offset: 0x00BCA088
		// (set) Token: 0x0600CA31 RID: 51761 RVA: 0x00BCBF3C File Offset: 0x00BCA13C
		public bool CnvPerRxOptionsRxDeEmphasis_A9010_UIValue
		{
			get
			{
				short num = (short)1547918804;
				short num2 = num;
				num = (short)199712212;
				switch (num2 == num)
				{
				}
				num = (short)9961472;
				short num3 = num;
				num = (short)1597833216;
				if (num != 0)
				{
				}
				num = (short)958529537;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.Value;
			}
			set
			{
				short num = (short)2089418753;
				if (num != 0)
				{
				}
				num = (short)705725314;
				short num2 = num;
				num = (short)1744733058;
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
				num = (short)1949892608;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxDeEmphasis_A9010.Value = value;
			}
		}

		// Token: 0x1700657B RID: 25979
		// (get) Token: 0x0600CA32 RID: 51762 RVA: 0x00BCBFF0 File Offset: 0x00BCA1F0
		// (set) Token: 0x0600CA33 RID: 51763 RVA: 0x00BCC0A4 File Offset: 0x00BCA2A4
		public bool CnvPerRxOptionsRxDeEmphasis_A9010_Applicable
		{
			get
			{
				short num = (short)819658753;
				if (num != 0)
				{
				}
				num = (short)902519246;
				short num2 = num;
				num = (short)1649760718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2052390912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)846200832;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.Applicable;
			}
			set
			{
				short num = (short)1076565204;
				short num2 = num;
				num = (short)1391662292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240713728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)878051329;
				if (num != 0)
				{
				}
				num = (short)2105409536;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxDeEmphasis_A9010.Applicable = value;
			}
		}

		// Token: 0x1700657C RID: 25980
		// (get) Token: 0x0600CA34 RID: 51764 RVA: 0x00BCC15C File Offset: 0x00BCA35C
		// (set) Token: 0x0600CA35 RID: 51765 RVA: 0x00BCC214 File Offset: 0x00BCA414
		public bool CnvPerRxOptionsRxDeEmphasis_A9010_Valid
		{
			get
			{
				short num = (short)1737176504;
				short num2 = num;
				num = (short)1853568440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)197394432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920598017;
				if (num != 0)
				{
				}
				num = (short)2058682368;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.Valid;
			}
			set
			{
				short num = (short)1006232323;
				short num2 = num;
				num = (short)572580611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)929497088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)584974337;
				if (num != 0)
				{
				}
				num = (short)262930432;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxDeEmphasis_A9010.Valid = value;
			}
		}

		// Token: 0x1700657D RID: 25981
		// (get) Token: 0x0600CA36 RID: 51766 RVA: 0x00BCC2CC File Offset: 0x00BCA4CC
		// (set) Token: 0x0600CA37 RID: 51767 RVA: 0x00BCC380 File Offset: 0x00BCA580
		public bool CnvPerRxOptionsRxDeEmphasis_A9010_Visible
		{
			get
			{
				short num = (short)1986015969;
				short num2 = num;
				num = (short)2004366049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1183055872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)126418945;
				if (num != 0)
				{
				}
				num = (short)2145452032;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.Visible;
			}
			set
			{
				short num = (short)1434413787;
				short num2 = num;
				num = (short)971401947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1094582272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1877016577;
				if (num != 0)
				{
				}
				num = (short)1888092160;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxDeEmphasis_A9010.Visible = value;
			}
		}

		// Token: 0x1700657E RID: 25982
		// (get) Token: 0x0600CA38 RID: 51768 RVA: 0x00BCC434 File Offset: 0x00BCA634
		// (set) Token: 0x0600CA39 RID: 51769 RVA: 0x00BCC4E8 File Offset: 0x00BCA6E8
		public bool CnvPerRxOptionsRxDeEmphasis_A9010_Editable
		{
			get
			{
				short num = (short)590910876;
				short num2 = num;
				num = (short)1944688028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942931968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2059796481;
				if (num != 0)
				{
				}
				num = (short)667418624;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.Editable;
			}
			set
			{
				short num = (short)133550965;
				short num2 = num;
				num = (short)1366086517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)435224576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1562902528;
				if (num != 0)
				{
				}
				num = (short)128385025;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxDeEmphasis_A9010.Editable = value;
			}
		}

		// Token: 0x1700657F RID: 25983
		// (get) Token: 0x0600CA3A RID: 51770 RVA: 0x00BCC59C File Offset: 0x00BCA79C
		internal string CnvPerRxOptionsRxDeEmphasis_A9010_UILabel
		{
			get
			{
				short num = (short)405152454;
				short num2 = num;
				num = (short)1376133830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429719552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1390936065;
				if (num != 0)
				{
				}
				num = (short)133431296;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.UIName;
			}
		}

		// Token: 0x17006580 RID: 25984
		// (get) Token: 0x0600CA3B RID: 51771 RVA: 0x00BCC654 File Offset: 0x00BCA854
		// (set) Token: 0x0600CA3C RID: 51772 RVA: 0x00BCC708 File Offset: 0x00BCA908
		internal bool CnvPerRxOptionsRxDeEmphasis_A9010_HiddenStatic
		{
			get
			{
				short num = (short)1644498019;
				short num2 = num;
				num = (short)1188432995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)891420672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)614334465;
				if (num != 0)
				{
				}
				num = (short)1062338560;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.HiddenStatic;
			}
			set
			{
				short num = (short)1440284673;
				if (num != 0)
				{
				}
				num = (short)3342336;
				short num2 = num;
				num = (short)607096991;
				short num3 = num;
				num = (short)1136038047;
				switch (num3 == num)
				{
				}
				num = (short)1323302912;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxDeEmphasis_A9010.HiddenStatic = value;
			}
		}

		// Token: 0x17006581 RID: 25985
		// (get) Token: 0x0600CA3D RID: 51773 RVA: 0x00BCC7C0 File Offset: 0x00BCA9C0
		// (set) Token: 0x0600CA3E RID: 51774 RVA: 0x00BCC874 File Offset: 0x00BCAA74
		internal bool CnvPerRxOptionsRxDeEmphasis_A9010_HiddenDynamic
		{
			get
			{
				short num = (short)526595942;
				short num2 = num;
				num = (short)829568870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915486208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195231744;
				if (num != 0)
				{
				}
				num = (short)1554251777;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010.HiddenDynamic;
			}
			set
			{
				short num = (short)624243914;
				short num2 = num;
				num = (short)1740977354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1240596480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1926365185;
				if (num != 0)
				{
				}
				num = (short)611188736;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxDeEmphasis_A9010.HiddenDynamic = value;
			}
		}

		// Token: 0x17006582 RID: 25986
		// (get) Token: 0x0600CA3F RID: 51775 RVA: 0x00BCC928 File Offset: 0x00BCAB28
		public bool CnvPerRxOptionsRxDeEmphasis_A9010_HasDiffs
		{
			get
			{
				short num = (short)163520489;
				short num2 = num;
				num = (short)549789673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301282816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1734410241;
				if (num != 0)
				{
				}
				num = (short)1430454272;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxDeEmphasis_A9010._HasDiffs;
			}
		}

		// Token: 0x17006583 RID: 25987
		// (get) Token: 0x0600CA40 RID: 51776 RVA: 0x00BCC9DC File Offset: 0x00BCABDC
		// (set) Token: 0x0600CA41 RID: 51777 RVA: 0x00BCCA90 File Offset: 0x00BCAC90
		public int CnvPerRxOptionsRxUnmuteDelayms_A9033Value
		{
			get
			{
				short num = (short)2078009943;
				short num2 = num;
				num = (short)1264511575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2141257728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1328873473;
				if (num != 0)
				{
				}
				num = (short)522584064;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Value;
			}
			set
			{
				short num = (short)1901773325;
				short num2 = num;
				num = (short)1802093069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)368312320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)402653185;
				if (num != 0)
				{
				}
				num = (short)919732224;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Value = value;
			}
		}

		// Token: 0x17006584 RID: 25988
		// (get) Token: 0x0600CA42 RID: 51778 RVA: 0x00BCCB48 File Offset: 0x00BCAD48
		// (set) Token: 0x0600CA43 RID: 51779 RVA: 0x00BCCBFC File Offset: 0x00BCADFC
		public string CnvPerRxOptionsRxUnmuteDelayms_A9033_UIValue
		{
			get
			{
				short num = (short)698417153;
				if (num != 0)
				{
				}
				num = (short)87293952;
				short num2 = num;
				num = (short)385732226;
				short num3 = num;
				num = (short)602787458;
				switch (num3 == num)
				{
				}
				num = (short)1268318208;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.UIValue;
			}
			set
			{
				short num = (short)1314480958;
				short num2 = num;
				num = (short)502162238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1856110592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)618987521;
				if (num != 0)
				{
				}
				num = (short)301334528;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxUnmuteDelayms_A9033.UIValue = value;
			}
		}

		// Token: 0x17006585 RID: 25989
		// (get) Token: 0x0600CA44 RID: 51780 RVA: 0x00BCCCB0 File Offset: 0x00BCAEB0
		public global::AcpBusinessLayer.AcpListField CnvPerRxOptionsRxUnmuteDelayms_A9033
		{
			get
			{
				short num = (short)1646592001;
				if (num != 0)
				{
				}
				num = (short)745734144;
				short num2 = num;
				num = (short)1177558329;
				short num3 = num;
				num = (short)881335609;
				switch (num3 == num)
				{
				}
				num = (short)390660096;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033;
			}
		}

		// Token: 0x17006586 RID: 25990
		// (get) Token: 0x0600CA45 RID: 51781 RVA: 0x00BCCD60 File Offset: 0x00BCAF60
		// (set) Token: 0x0600CA46 RID: 51782 RVA: 0x00BCCE14 File Offset: 0x00BCB014
		public bool CnvPerRxOptionsRxUnmuteDelayms_A9033_Applicable
		{
			get
			{
				short num = (short)1670859169;
				short num2 = num;
				num = (short)1938049441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306525696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1784086528;
				if (num != 0)
				{
				}
				num = (short)1589248001;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Applicable;
			}
			set
			{
				short num = (short)199508159;
				short num2 = num;
				num = (short)2030715071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1932984320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)174718976;
				if (num != 0)
				{
				}
				num = (short)665387009;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Applicable = value;
			}
		}

		// Token: 0x17006587 RID: 25991
		// (get) Token: 0x0600CA47 RID: 51783 RVA: 0x00BCCEC8 File Offset: 0x00BCB0C8
		// (set) Token: 0x0600CA48 RID: 51784 RVA: 0x00BCCF7C File Offset: 0x00BCB17C
		public bool CnvPerRxOptionsRxUnmuteDelayms_A9033_Valid
		{
			get
			{
				short num = (short)1833742586;
				short num2 = num;
				num = (short)1685827834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2113863680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981270529;
				if (num != 0)
				{
				}
				num = (short)116129792;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Valid;
			}
			set
			{
				short num = (short)1774887768;
				short num2 = num;
				num = (short)549692248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1488453632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1692598273;
				if (num != 0)
				{
				}
				num = (short)1314193408;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Valid = value;
			}
		}

		// Token: 0x17006588 RID: 25992
		// (get) Token: 0x0600CA49 RID: 51785 RVA: 0x00BCD034 File Offset: 0x00BCB234
		// (set) Token: 0x0600CA4A RID: 51786 RVA: 0x00BCD0E4 File Offset: 0x00BCB2E4
		public bool CnvPerRxOptionsRxUnmuteDelayms_A9033_Visible
		{
			get
			{
				short num = (short)443655441;
				short num2 = num;
				num = (short)532260113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)986120192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127953921;
				if (num != 0)
				{
				}
				num = (short)1244069888;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Visible;
			}
			set
			{
				short num = (short)1535377409;
				if (num != 0)
				{
				}
				num = (short)1917124608;
				short num2 = num;
				num = (short)776633502;
				short num3 = num;
				num = (short)1037859998;
				switch (num3 == num)
				{
				}
				num = (short)2027028480;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Visible = value;
			}
		}

		// Token: 0x17006589 RID: 25993
		// (get) Token: 0x0600CA4B RID: 51787 RVA: 0x00BCD198 File Offset: 0x00BCB398
		// (set) Token: 0x0600CA4C RID: 51788 RVA: 0x00BCD24C File Offset: 0x00BCB44C
		public bool CnvPerRxOptionsRxUnmuteDelayms_A9033_Editable
		{
			get
			{
				short num = (short)1901822464;
				short num2 = num;
				num = (short)1801093632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)614858752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1127677953;
				if (num != 0)
				{
				}
				num = (short)1249902592;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Editable;
			}
			set
			{
				short num = (short)1294991361;
				if (num != 0)
				{
				}
				num = (short)1524629504;
				short num2 = num;
				num = (short)789289766;
				short num3 = num;
				num = (short)682269478;
				switch (num3 == num)
				{
				}
				num = (short)188809216;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxUnmuteDelayms_A9033.Editable = value;
			}
		}

		// Token: 0x1700658A RID: 25994
		// (get) Token: 0x0600CA4D RID: 51789 RVA: 0x00BCD300 File Offset: 0x00BCB500
		internal string CnvPerRxOptionsRxUnmuteDelayms_A9033_UILabel
		{
			get
			{
				short num = (short)292981288;
				short num2 = num;
				num = (short)1477806632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360986112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1341718529;
				if (num != 0)
				{
				}
				num = (short)1531904000;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.UIName;
			}
		}

		// Token: 0x1700658B RID: 25995
		// (get) Token: 0x0600CA4E RID: 51790 RVA: 0x00BCD3B4 File Offset: 0x00BCB5B4
		// (set) Token: 0x0600CA4F RID: 51791 RVA: 0x00BCD468 File Offset: 0x00BCB668
		internal bool CnvPerRxOptionsRxUnmuteDelayms_A9033_HiddenStatic
		{
			get
			{
				short num = (short)1878402700;
				short num2 = num;
				num = (short)2105616012;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045626880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)781451265;
				if (num != 0)
				{
				}
				num = (short)1932591104;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.HiddenStatic;
			}
			set
			{
				short num = (short)718683989;
				short num2 = num;
				num = (short)1449017173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1372848128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1008599041;
				if (num != 0)
				{
				}
				num = (short)491061248;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxUnmuteDelayms_A9033.HiddenStatic = value;
			}
		}

		// Token: 0x1700658C RID: 25996
		// (get) Token: 0x0600CA50 RID: 51792 RVA: 0x00BCD51C File Offset: 0x00BCB71C
		// (set) Token: 0x0600CA51 RID: 51793 RVA: 0x00BCD5D4 File Offset: 0x00BCB7D4
		internal bool CnvPerRxOptionsRxUnmuteDelayms_A9033_HiddenDynamic
		{
			get
			{
				short num = (short)2065825793;
				if (num != 0)
				{
				}
				num = (short)2054619136;
				short num2 = num;
				num = (short)741593469;
				short num3 = num;
				num = (short)1119342973;
				switch (num3 == num)
				{
				}
				num = (short)377159680;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033.HiddenDynamic;
			}
			set
			{
				short num = (short)116129793;
				if (num != 0)
				{
				}
				num = (short)305070080;
				short num2 = num;
				num = (short)1540686142;
				short num3 = num;
				num = (short)1897136446;
				switch (num3 == num)
				{
				}
				num = (short)194838528;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxUnmuteDelayms_A9033.HiddenDynamic = value;
			}
		}

		// Token: 0x1700658D RID: 25997
		// (get) Token: 0x0600CA52 RID: 51794 RVA: 0x00BCD68C File Offset: 0x00BCB88C
		public bool CnvPerRxOptionsRxUnmuteDelayms_A9033_HasDiffs
		{
			get
			{
				short num = (short)102860783;
				short num2 = num;
				num = (short)24283119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1861877760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1322909696;
				if (num != 0)
				{
				}
				num = (short)646971393;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxUnmuteDelayms_A9033._HasDiffs;
			}
		}

		// Token: 0x1700658E RID: 25998
		// (get) Token: 0x0600CA53 RID: 51795 RVA: 0x00BCD744 File Offset: 0x00BCB944
		// (set) Token: 0x0600CA54 RID: 51796 RVA: 0x00BCD7F8 File Offset: 0x00BCB9F8
		public int CnvPerRxOptionsRxVoiceSignalType_A9044Value
		{
			get
			{
				short num = (short)1811283969;
				if (num != 0)
				{
				}
				num = (short)894107648;
				short num2 = num;
				num = (short)1912206704;
				short num3 = num;
				num = (short)1714353520;
				switch (num3 == num)
				{
				}
				num = (short)327745536;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.Value;
			}
			set
			{
				short num = (short)149291009;
				if (num != 0)
				{
				}
				num = (short)1589641216;
				short num2 = num;
				num = (short)352880864;
				short num3 = num;
				num = (short)976062688;
				switch (num3 == num)
				{
				}
				num = (short)1542586368;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxVoiceSignalType_A9044.Value = value;
			}
		}

		// Token: 0x1700658F RID: 25999
		// (get) Token: 0x0600CA55 RID: 51797 RVA: 0x00BCD8AC File Offset: 0x00BCBAAC
		// (set) Token: 0x0600CA56 RID: 51798 RVA: 0x00BCD960 File Offset: 0x00BCBB60
		public string CnvPerRxOptionsRxVoiceSignalType_A9044_UIValue
		{
			get
			{
				short num = (short)940396243;
				short num2 = num;
				num = (short)815746771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1318322176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)669581312;
				if (num != 0)
				{
				}
				num = (short)1168834561;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.UIValue;
			}
			set
			{
				short num = (short)719497545;
				short num2 = num;
				num = (short)366258505;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197735936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307181056;
				if (num != 0)
				{
				}
				num = (short)423821313;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxVoiceSignalType_A9044.UIValue = value;
			}
		}

		// Token: 0x17006590 RID: 26000
		// (get) Token: 0x0600CA57 RID: 51799 RVA: 0x00BCDA14 File Offset: 0x00BCBC14
		public global::AcpBusinessLayer.AcpListField CnvPerRxOptionsRxVoiceSignalType_A9044
		{
			get
			{
				short num = (short)144984188;
				short num2 = num;
				num = (short)1407207548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)206766080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)94306305;
				if (num != 0)
				{
				}
				num = (short)1296171008;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044;
			}
		}

		// Token: 0x17006591 RID: 26001
		// (get) Token: 0x0600CA58 RID: 51800 RVA: 0x00BCDAC4 File Offset: 0x00BCBCC4
		// (set) Token: 0x0600CA59 RID: 51801 RVA: 0x00BCDB78 File Offset: 0x00BCBD78
		public bool CnvPerRxOptionsRxVoiceSignalType_A9044_Applicable
		{
			get
			{
				short num = (short)366889314;
				short num2 = num;
				num = (short)334907746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042284544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)667156481;
				if (num != 0)
				{
				}
				num = (short)328531968;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.Applicable;
			}
			set
			{
				short num = (short)165415883;
				short num2 = num;
				num = (short)862522315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)492109824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1095041025;
				if (num != 0)
				{
				}
				num = (short)605224960;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxVoiceSignalType_A9044.Applicable = value;
			}
		}

		// Token: 0x17006592 RID: 26002
		// (get) Token: 0x0600CA5A RID: 51802 RVA: 0x00BCDC2C File Offset: 0x00BCBE2C
		// (set) Token: 0x0600CA5B RID: 51803 RVA: 0x00BCDCE4 File Offset: 0x00BCBEE4
		public bool CnvPerRxOptionsRxVoiceSignalType_A9044_Valid
		{
			get
			{
				short num = (short)1182269441;
				if (num != 0)
				{
				}
				num = (short)1689845760;
				short num2 = num;
				num = (short)1895333439;
				short num3 = num;
				num = (short)67403327;
				switch (num3 == num)
				{
				}
				num = (short)923533312;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.Valid;
			}
			set
			{
				short num = (short)1052911295;
				short num2 = num;
				num = (short)984622783;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1596325888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1277362177;
				if (num != 0)
				{
				}
				num = (short)2006777856;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxVoiceSignalType_A9044.Valid = value;
			}
		}

		// Token: 0x17006593 RID: 26003
		// (get) Token: 0x0600CA5C RID: 51804 RVA: 0x00BCDD98 File Offset: 0x00BCBF98
		// (set) Token: 0x0600CA5D RID: 51805 RVA: 0x00BCDE4C File Offset: 0x00BCC04C
		public bool CnvPerRxOptionsRxVoiceSignalType_A9044_Visible
		{
			get
			{
				short num = (short)714685581;
				short num2 = num;
				num = (short)372194445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881590272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852506112;
				if (num != 0)
				{
				}
				num = (short)1569390593;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.Visible;
			}
			set
			{
				short num = (short)1433534465;
				if (num != 0)
				{
				}
				num = (short)2013790208;
				short num2 = num;
				num = (short)1367101716;
				short num3 = num;
				num = (short)1995198740;
				switch (num3 == num)
				{
				}
				num = (short)394330112;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxVoiceSignalType_A9044.Visible = value;
			}
		}

		// Token: 0x17006594 RID: 26004
		// (get) Token: 0x0600CA5E RID: 51806 RVA: 0x00BCDF00 File Offset: 0x00BCC100
		// (set) Token: 0x0600CA5F RID: 51807 RVA: 0x00BCDFB4 File Offset: 0x00BCC1B4
		public bool CnvPerRxOptionsRxVoiceSignalType_A9044_Editable
		{
			get
			{
				short num = (short)857916897;
				short num2 = num;
				num = (short)1306772961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2124611584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1218576384;
				if (num != 0)
				{
				}
				num = (short)671678465;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.Editable;
			}
			set
			{
				short num = (short)508650854;
				short num2 = num;
				num = (short)1722770790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)232194048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)405667840;
				if (num != 0)
				{
				}
				num = (short)558366721;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxVoiceSignalType_A9044.Editable = value;
			}
		}

		// Token: 0x17006595 RID: 26005
		// (get) Token: 0x0600CA60 RID: 51808 RVA: 0x00BCE068 File Offset: 0x00BCC268
		internal string CnvPerRxOptionsRxVoiceSignalType_A9044_UILabel
		{
			get
			{
				short num = (short)726115608;
				short num2 = num;
				num = (short)2102502680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)408354816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2005663745;
				if (num != 0)
				{
				}
				num = (short)1626144768;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.UIName;
			}
		}

		// Token: 0x17006596 RID: 26006
		// (get) Token: 0x0600CA61 RID: 51809 RVA: 0x00BCE11C File Offset: 0x00BCC31C
		// (set) Token: 0x0600CA62 RID: 51810 RVA: 0x00BCE1D0 File Offset: 0x00BCC3D0
		internal bool CnvPerRxOptionsRxVoiceSignalType_A9044_HiddenStatic
		{
			get
			{
				short num = (short)301596673;
				if (num != 0)
				{
				}
				num = (short)961150976;
				short num2 = num;
				num = (short)486599808;
				short num3 = num;
				num = (short)295169152;
				switch (num3 == num)
				{
				}
				num = (short)138674176;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.HiddenStatic;
			}
			set
			{
				short num = (short)1711464240;
				short num2 = num;
				num = (short)1849810736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1105592320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)822083584;
				if (num != 0)
				{
				}
				num = (short)2032271361;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxVoiceSignalType_A9044.HiddenStatic = value;
			}
		}

		// Token: 0x17006597 RID: 26007
		// (get) Token: 0x0600CA63 RID: 51811 RVA: 0x00BCE284 File Offset: 0x00BCC484
		// (set) Token: 0x0600CA64 RID: 51812 RVA: 0x00BCE33C File Offset: 0x00BCC53C
		internal bool CnvPerRxOptionsRxVoiceSignalType_A9044_HiddenDynamic
		{
			get
			{
				short num = (short)943577451;
				short num2 = num;
				num = (short)502847851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)596443136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111963137;
				if (num != 0)
				{
				}
				num = (short)490078208;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044.HiddenDynamic;
			}
			set
			{
				short num = (short)2029519409;
				short num2 = num;
				num = (short)1966641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1864499200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)933232641;
				if (num != 0)
				{
				}
				num = (short)337051648;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsRxVoiceSignalType_A9044.HiddenDynamic = value;
			}
		}

		// Token: 0x17006598 RID: 26008
		// (get) Token: 0x0600CA65 RID: 51813 RVA: 0x00BCE3F4 File Offset: 0x00BCC5F4
		public bool CnvPerRxOptionsRxVoiceSignalType_A9044_HasDiffs
		{
			get
			{
				short num = (short)1771531368;
				short num2 = num;
				num = (short)1389849704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)449773568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1818492928;
				if (num != 0)
				{
				}
				num = (short)158400513;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsRxVoiceSignalType_A9044._HasDiffs;
			}
		}

		// Token: 0x17006599 RID: 26009
		// (get) Token: 0x0600CA66 RID: 51814 RVA: 0x00BCE4A8 File Offset: 0x00BCC6A8
		// (set) Token: 0x0600CA67 RID: 51815 RVA: 0x00BCE560 File Offset: 0x00BCC760
		public int CnvPerRxOptionsSquelchFineTune_A9176Value
		{
			get
			{
				short num = (short)640088615;
				short num2 = num;
				num = (short)1021377063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1631649792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1829437441;
				if (num != 0)
				{
				}
				num = (short)382271488;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.Value;
			}
			set
			{
				short num = (short)1102976050;
				short num2 = num;
				num = (short)873075762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1931476992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1297874944;
				if (num != 0)
				{
				}
				num = (short)286130177;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsSquelchFineTune_A9176.Value = value;
			}
		}

		// Token: 0x1700659A RID: 26010
		// (get) Token: 0x0600CA68 RID: 51816 RVA: 0x00BCE614 File Offset: 0x00BCC814
		// (set) Token: 0x0600CA69 RID: 51817 RVA: 0x00BCE6CC File Offset: 0x00BCC8CC
		public string CnvPerRxOptionsSquelchFineTune_A9176_UIValue
		{
			get
			{
				short num = (short)487325696;
				short num2 = num;
				num = (short)873874115;
				short num3 = num;
				num = (short)1754940099;
				switch (num3 == num)
				{
				}
				num = (short)127991809;
				if (num != 0)
				{
				}
				num = (short)929103872;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.UIValue;
			}
			set
			{
				short num = (short)1420820480;
				short num2 = num;
				num = (short)1461364947;
				short num3 = num;
				num = (short)1529129171;
				switch (num3 == num)
				{
				}
				num = (short)476184576;
				if (num != 0)
				{
				}
				num = (short)2112225281;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsSquelchFineTune_A9176.UIValue = value;
			}
		}

		// Token: 0x1700659B RID: 26011
		// (get) Token: 0x0600CA6A RID: 51818 RVA: 0x00BCE784 File Offset: 0x00BCC984
		public global::AcpBusinessLayer.AcpListField CnvPerRxOptionsSquelchFineTune_A9176
		{
			get
			{
				short num = (short)362217472;
				short num2 = num;
				num = (short)745107835;
				short num3 = num;
				num = (short)1245540731;
				switch (num3 == num)
				{
				}
				num = (short)1545338881;
				if (num != 0)
				{
				}
				num = (short)177537024;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176;
			}
		}

		// Token: 0x1700659C RID: 26012
		// (get) Token: 0x0600CA6B RID: 51819 RVA: 0x00BCE838 File Offset: 0x00BCCA38
		// (set) Token: 0x0600CA6C RID: 51820 RVA: 0x00BCE8EC File Offset: 0x00BCCAEC
		public bool CnvPerRxOptionsSquelchFineTune_A9176_Applicable
		{
			get
			{
				short num = (short)491454464;
				short num2 = num;
				num = (short)1162580135;
				short num3 = num;
				num = (short)94343335;
				switch (num3 == num)
				{
				}
				num = (short)1466433536;
				if (num != 0)
				{
				}
				num = (short)247529473;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.Applicable;
			}
			set
			{
				short num = (short)364249088;
				short num2 = num;
				num = (short)409298533;
				short num3 = num;
				num = (short)1334011493;
				switch (num3 == num)
				{
				}
				num = (short)333053953;
				if (num != 0)
				{
				}
				num = (short)2143879168;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsSquelchFineTune_A9176.Applicable = value;
			}
		}

		// Token: 0x1700659D RID: 26013
		// (get) Token: 0x0600CA6D RID: 51821 RVA: 0x00BCE9A4 File Offset: 0x00BCCBA4
		// (set) Token: 0x0600CA6E RID: 51822 RVA: 0x00BCEA58 File Offset: 0x00BCCC58
		public bool CnvPerRxOptionsSquelchFineTune_A9176_Valid
		{
			get
			{
				short num = (short)1021968384;
				short num2 = num;
				num = (short)941142241;
				short num3 = num;
				num = (short)519614689;
				switch (num3 == num)
				{
				}
				num = (short)1937965057;
				if (num != 0)
				{
				}
				num = (short)177471488;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.Valid;
			}
			set
			{
				short num = (short)494534656;
				short num2 = num;
				num = (short)1082064897;
				if (num != 0)
				{
				}
				num = (short)392875957;
				short num3 = num;
				num = (short)1152438197;
				switch (num3 == num)
				{
				}
				num = (short)1025638400;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsSquelchFineTune_A9176.Valid = value;
			}
		}

		// Token: 0x1700659E RID: 26014
		// (get) Token: 0x0600CA6F RID: 51823 RVA: 0x00BCEB08 File Offset: 0x00BCCD08
		// (set) Token: 0x0600CA70 RID: 51824 RVA: 0x00BCEBBC File Offset: 0x00BCCDBC
		public bool CnvPerRxOptionsSquelchFineTune_A9176_Visible
		{
			get
			{
				short num = (short)1630142464;
				short num2 = num;
				num = (short)1886456692;
				short num3 = num;
				num = (short)2102201204;
				switch (num3 == num)
				{
				}
				num = (short)929562624;
				if (num != 0)
				{
				}
				num = (short)1601110017;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.Visible;
			}
			set
			{
				short num = (short)1916600320;
				short num2 = num;
				num = (short)603455489;
				if (num != 0)
				{
				}
				num = (short)1411362024;
				short num3 = num;
				num = (short)1713548520;
				switch (num3 == num)
				{
				}
				num = (short)1546649600;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsSquelchFineTune_A9176.Visible = value;
			}
		}

		// Token: 0x1700659F RID: 26015
		// (get) Token: 0x0600CA71 RID: 51825 RVA: 0x00BCEC74 File Offset: 0x00BCCE74
		// (set) Token: 0x0600CA72 RID: 51826 RVA: 0x00BCED28 File Offset: 0x00BCCF28
		public bool CnvPerRxOptionsSquelchFineTune_A9176_Editable
		{
			get
			{
				short num = (short)1523712000;
				short num2 = num;
				num = (short)498270209;
				if (num != 0)
				{
				}
				num = (short)543220592;
				short num3 = num;
				num = (short)232907632;
				switch (num3 == num)
				{
				}
				num = (short)1727135744;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.Editable;
			}
			set
			{
				short num = (short)1058275328;
				short num2 = num;
				num = (short)1628781286;
				short num3 = num;
				num = (short)460471014;
				switch (num3 == num)
				{
				}
				num = (short)660406273;
				if (num != 0)
				{
				}
				num = (short)788922368;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsSquelchFineTune_A9176.Editable = value;
			}
		}

		// Token: 0x170065A0 RID: 26016
		// (get) Token: 0x0600CA73 RID: 51827 RVA: 0x00BCEDE0 File Offset: 0x00BCCFE0
		internal string CnvPerRxOptionsSquelchFineTune_A9176_UILabel
		{
			get
			{
				short num = (short)1033437184;
				short num2 = num;
				num = (short)1528205153;
				short num3 = num;
				num = (short)152407905;
				switch (num3 == num)
				{
				}
				num = (short)536084480;
				if (num != 0)
				{
				}
				num = (short)1546649601;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.UIName;
			}
		}

		// Token: 0x170065A1 RID: 26017
		// (get) Token: 0x0600CA74 RID: 51828 RVA: 0x00BCEE94 File Offset: 0x00BCD094
		// (set) Token: 0x0600CA75 RID: 51829 RVA: 0x00BCEF48 File Offset: 0x00BCD148
		internal bool CnvPerRxOptionsSquelchFineTune_A9176_HiddenStatic
		{
			get
			{
				short num = (short)990117888;
				short num2 = num;
				num = (short)1256456193;
				if (num != 0)
				{
				}
				num = (short)1447538551;
				short num3 = num;
				num = (short)2089332599;
				switch (num3 == num)
				{
				}
				num = (short)1960116224;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.HiddenStatic;
			}
			set
			{
				short num = (short)376373248;
				short num2 = num;
				num = (short)1648492545;
				if (num != 0)
				{
				}
				num = (short)1334525786;
				short num3 = num;
				num = (short)1642282842;
				switch (num3 == num)
				{
				}
				num = (short)891486208;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsSquelchFineTune_A9176.HiddenStatic = value;
			}
		}

		// Token: 0x170065A2 RID: 26018
		// (get) Token: 0x0600CA76 RID: 51830 RVA: 0x00BCF000 File Offset: 0x00BCD200
		// (set) Token: 0x0600CA77 RID: 51831 RVA: 0x00BCF0B8 File Offset: 0x00BCD2B8
		internal bool CnvPerRxOptionsSquelchFineTune_A9176_HiddenDynamic
		{
			get
			{
				short num = (short)960430080;
				short num2 = num;
				num = (short)1966774025;
				short num3 = num;
				num = (short)1214420745;
				switch (num3 == num)
				{
				}
				num = (short)1488650241;
				if (num != 0)
				{
				}
				num = (short)1719074816;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176.HiddenDynamic;
			}
			set
			{
				short num = (short)897908736;
				short num2 = num;
				num = (short)1496030084;
				short num3 = num;
				num = (short)1988008836;
				switch (num3 == num)
				{
				}
				num = (short)1537343489;
				if (num != 0)
				{
				}
				num = (short)1078984704;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsSquelchFineTune_A9176.HiddenDynamic = value;
			}
		}

		// Token: 0x170065A3 RID: 26019
		// (get) Token: 0x0600CA78 RID: 51832 RVA: 0x00BCF170 File Offset: 0x00BCD370
		public bool CnvPerRxOptionsSquelchFineTune_A9176_HasDiffs
		{
			get
			{
				short num = (short)337444864;
				short num2 = num;
				num = (short)875305156;
				short num3 = num;
				num = (short)767039684;
				switch (num3 == num)
				{
				}
				num = (short)1843200001;
				if (num != 0)
				{
				}
				num = (short)1347092480;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsSquelchFineTune_A9176._HasDiffs;
			}
		}

		// Token: 0x170065A4 RID: 26020
		// (get) Token: 0x0600CA79 RID: 51833 RVA: 0x00BCF224 File Offset: 0x00BCD424
		// (set) Token: 0x0600CA7A RID: 51834 RVA: 0x00BCF2D8 File Offset: 0x00BCD4D8
		public int CnvPerRxOptionsUnmuteMuteType_A9602Value
		{
			get
			{
				short num = (short)1675689984;
				short num2 = num;
				num = (short)2086962694;
				short num3 = num;
				num = (short)161973766;
				switch (num3 == num)
				{
				}
				num = (short)716111873;
				if (num != 0)
				{
				}
				num = (short)1394802688;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.Value;
			}
			set
			{
				short num = (short)98566144;
				short num2 = num;
				num = (short)300816860;
				short num3 = num;
				num = (short)1725962716;
				switch (num3 == num)
				{
				}
				num = (short)2009071617;
				if (num != 0)
				{
				}
				num = (short)680919040;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsUnmuteMuteType_A9602.Value = value;
			}
		}

		// Token: 0x170065A5 RID: 26021
		// (get) Token: 0x0600CA7B RID: 51835 RVA: 0x00BCF38C File Offset: 0x00BCD58C
		// (set) Token: 0x0600CA7C RID: 51836 RVA: 0x00BCF444 File Offset: 0x00BCD644
		public string CnvPerRxOptionsUnmuteMuteType_A9602_UIValue
		{
			get
			{
				short num = (short)1897594880;
				short num2 = num;
				num = (short)2143162734;
				short num3 = num;
				num = (short)1243550062;
				switch (num3 == num)
				{
				}
				num = (short)169803776;
				if (num != 0)
				{
				}
				num = (short)1910636545;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.UIValue;
			}
			set
			{
				short num = (short)881065984;
				short num2 = num;
				num = (short)660523874;
				short num3 = num;
				num = (short)104319842;
				switch (num3 == num)
				{
				}
				num = (short)1560412160;
				if (num != 0)
				{
				}
				num = (short)833552385;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsUnmuteMuteType_A9602.UIValue = value;
			}
		}

		// Token: 0x170065A6 RID: 26022
		// (get) Token: 0x0600CA7D RID: 51837 RVA: 0x00BCF4F8 File Offset: 0x00BCD6F8
		public global::AcpBusinessLayer.AcpListField CnvPerRxOptionsUnmuteMuteType_A9602
		{
			get
			{
				short num = (short)292814848;
				short num2 = num;
				num = (short)688265727;
				short num3 = num;
				num = (short)1489836543;
				switch (num3 == num)
				{
				}
				num = (short)463601665;
				if (num != 0)
				{
				}
				num = (short)1228931072;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602;
			}
		}

		// Token: 0x170065A7 RID: 26023
		// (get) Token: 0x0600CA7E RID: 51838 RVA: 0x00BCF5A8 File Offset: 0x00BCD7A8
		// (set) Token: 0x0600CA7F RID: 51839 RVA: 0x00BCF658 File Offset: 0x00BCD858
		public bool CnvPerRxOptionsUnmuteMuteType_A9602_Applicable
		{
			get
			{
				short num = (short)1036845056;
				short num2 = num;
				num = (short)1376941164;
				short num3 = num;
				num = (short)1897624684;
				switch (num3 == num)
				{
				}
				num = (short)801112065;
				if (num != 0)
				{
				}
				num = (short)1772093440;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.Applicable;
			}
			set
			{
				short num = (short)1650327552;
				short num2 = num;
				num = (short)97014340;
				short num3 = num;
				num = (short)1804423748;
				switch (num3 == num)
				{
				}
				num = (short)745537537;
				if (num != 0)
				{
				}
				num = (short)828833792;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsUnmuteMuteType_A9602.Applicable = value;
			}
		}

		// Token: 0x170065A8 RID: 26024
		// (get) Token: 0x0600CA80 RID: 51840 RVA: 0x00BCF710 File Offset: 0x00BCD910
		// (set) Token: 0x0600CA81 RID: 51841 RVA: 0x00BCF7C8 File Offset: 0x00BCD9C8
		public bool CnvPerRxOptionsUnmuteMuteType_A9602_Valid
		{
			get
			{
				short num = (short)365166592;
				short num2 = num;
				num = (short)2112806703;
				short num3 = num;
				num = (short)287498031;
				switch (num3 == num)
				{
				}
				num = (short)1445462017;
				if (num != 0)
				{
				}
				num = (short)1986134016;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.Valid;
			}
			set
			{
				short num = (short)179109888;
				short num2 = num;
				num = (short)1473642497;
				if (num != 0)
				{
				}
				num = (short)1017845559;
				short num3 = num;
				num = (short)1577785143;
				switch (num3 == num)
				{
				}
				num = (short)1538785280;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsUnmuteMuteType_A9602.Valid = value;
			}
		}

		// Token: 0x170065A9 RID: 26025
		// (get) Token: 0x0600CA82 RID: 51842 RVA: 0x00BCF880 File Offset: 0x00BCDA80
		// (set) Token: 0x0600CA83 RID: 51843 RVA: 0x00BCF934 File Offset: 0x00BCDB34
		public bool CnvPerRxOptionsUnmuteMuteType_A9602_Visible
		{
			get
			{
				short num = (short)1175781376;
				short num2 = num;
				num = (short)1202576615;
				short num3 = num;
				num = (short)330816743;
				switch (num3 == num)
				{
				}
				num = (short)1034289152;
				if (num != 0)
				{
				}
				num = (short)1667825665;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.Visible;
			}
			set
			{
				short num = (short)1181548544;
				short num2 = num;
				num = (short)1172373505;
				if (num != 0)
				{
				}
				num = (short)1589096102;
				short num3 = num;
				num = (short)897822374;
				switch (num3 == num)
				{
				}
				num = (short)691666944;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsUnmuteMuteType_A9602.Visible = value;
			}
		}

		// Token: 0x170065AA RID: 26026
		// (get) Token: 0x0600CA84 RID: 51844 RVA: 0x00BCF9E8 File Offset: 0x00BCDBE8
		// (set) Token: 0x0600CA85 RID: 51845 RVA: 0x00BCFAA0 File Offset: 0x00BCDCA0
		public bool CnvPerRxOptionsUnmuteMuteType_A9602_Editable
		{
			get
			{
				short num = (short)1089273856;
				short num2 = num;
				num = (short)1594141431;
				short num3 = num;
				num = (short)571190007;
				switch (num3 == num)
				{
				}
				num = (short)1818165248;
				if (num != 0)
				{
				}
				num = (short)1187053569;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.Editable;
			}
			set
			{
				short num = (short)1719664640;
				short num2 = num;
				num = (short)542723361;
				short num3 = num;
				num = (short)1444695329;
				switch (num3 == num)
				{
				}
				num = (short)386662401;
				if (num != 0)
				{
				}
				num = (short)219676672;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsUnmuteMuteType_A9602.Editable = value;
			}
		}

		// Token: 0x170065AB RID: 26027
		// (get) Token: 0x0600CA86 RID: 51846 RVA: 0x00BCFB58 File Offset: 0x00BCDD58
		internal string CnvPerRxOptionsUnmuteMuteType_A9602_UILabel
		{
			get
			{
				short num = (short)813170688;
				short num2 = num;
				num = (short)1981732;
				short num3 = num;
				num = (short)2047032612;
				switch (num3 == num)
				{
				}
				num = (short)1821507584;
				if (num != 0)
				{
				}
				num = (short)1882259457;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.UIName;
			}
		}

		// Token: 0x170065AC RID: 26028
		// (get) Token: 0x0600CA87 RID: 51847 RVA: 0x00BCFC0C File Offset: 0x00BCDE0C
		// (set) Token: 0x0600CA88 RID: 51848 RVA: 0x00BCFCBC File Offset: 0x00BCDEBC
		internal bool CnvPerRxOptionsUnmuteMuteType_A9602_HiddenStatic
		{
			get
			{
				short num = (short)1464532992;
				short num2 = num;
				num = (short)1535599892;
				short num3 = num;
				num = (short)1093231892;
				switch (num3 == num)
				{
				}
				num = (short)1591214081;
				if (num != 0)
				{
				}
				num = (short)2080243712;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.HiddenStatic;
			}
			set
			{
				short num = (short)7340032;
				short num2 = num;
				num = (short)1420822294;
				short num3 = num;
				num = (short)1081214742;
				switch (num3 == num)
				{
				}
				num = (short)121044992;
				if (num != 0)
				{
				}
				num = (short)520290305;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsUnmuteMuteType_A9602.HiddenStatic = value;
			}
		}

		// Token: 0x170065AD RID: 26029
		// (get) Token: 0x0600CA89 RID: 51849 RVA: 0x00BCFD74 File Offset: 0x00BCDF74
		// (set) Token: 0x0600CA8A RID: 51850 RVA: 0x00BCFE28 File Offset: 0x00BCE028
		internal bool CnvPerRxOptionsUnmuteMuteType_A9602_HiddenDynamic
		{
			get
			{
				short num = (short)213581824;
				short num2 = num;
				num = (short)1670935485;
				short num3 = num;
				num = (short)481260477;
				switch (num3 == num)
				{
				}
				num = (short)1775501312;
				if (num != 0)
				{
				}
				num = (short)203751425;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602.HiddenDynamic;
			}
			set
			{
				short num = (short)1078132736;
				short num2 = num;
				num = (short)1417523885;
				short num3 = num;
				num = (short)325628589;
				switch (num3 == num)
				{
				}
				num = (short)578879488;
				if (num != 0)
				{
				}
				num = (short)492765185;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsUnmuteMuteType_A9602.HiddenDynamic = value;
			}
		}

		// Token: 0x170065AE RID: 26030
		// (get) Token: 0x0600CA8B RID: 51851 RVA: 0x00BCFEDC File Offset: 0x00BCE0DC
		public bool CnvPerRxOptionsUnmuteMuteType_A9602_HasDiffs
		{
			get
			{
				short num = (short)1223491584;
				short num2 = num;
				num = (short)1493164044;
				short num3 = num;
				num = (short)2090917900;
				switch (num3 == num)
				{
				}
				num = (short)374210561;
				if (num != 0)
				{
				}
				num = (short)1853816832;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsUnmuteMuteType_A9602._HasDiffs;
			}
		}

		// Token: 0x170065AF RID: 26031
		// (get) Token: 0x0600CA8C RID: 51852 RVA: 0x00BCFF90 File Offset: 0x00BCE190
		// (set) Token: 0x0600CA8D RID: 51853 RVA: 0x00BD0044 File Offset: 0x00BCE244
		public int CnvPerRxOptionsHearClear_A36408Value
		{
			get
			{
				short num = (short)1038483456;
				short num2 = num;
				num = (short)251780439;
				short num3 = num;
				num = (short)1276697943;
				switch (num3 == num)
				{
				}
				num = (short)48562177;
				if (num != 0)
				{
				}
				num = (short)2092236800;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.Value;
			}
			set
			{
				short num = (short)1211629568;
				short num2 = num;
				num = (short)1108541441;
				if (num != 0)
				{
				}
				num = (short)246487201;
				short num3 = num;
				num = (short)1232738465;
				switch (num3 == num)
				{
				}
				num = (short)1992491008;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsHearClear_A36408.Value = value;
			}
		}

		// Token: 0x170065B0 RID: 26032
		// (get) Token: 0x0600CA8E RID: 51854 RVA: 0x00BD00F8 File Offset: 0x00BCE2F8
		// (set) Token: 0x0600CA8F RID: 51855 RVA: 0x00BD01A8 File Offset: 0x00BCE3A8
		public string CnvPerRxOptionsHearClear_A36408_UIValue
		{
			get
			{
				short num = (short)2032074752;
				short num2 = num;
				num = (short)525795329;
				if (num != 0)
				{
				}
				num = (short)35512855;
				short num3 = num;
				num = (short)1112531479;
				switch (num3 == num)
				{
				}
				num = (short)53018624;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.UIValue;
			}
			set
			{
				short num = (short)1394212864;
				short num2 = num;
				num = (short)1502713984;
				short num3 = num;
				num = (short)2052757632;
				switch (num3 == num)
				{
				}
				num = (short)1972305921;
				if (num != 0)
				{
				}
				num = (short)1872756736;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsHearClear_A36408.UIValue = value;
			}
		}

		// Token: 0x170065B1 RID: 26033
		// (get) Token: 0x0600CA90 RID: 51856 RVA: 0x00BD0264 File Offset: 0x00BCE464
		public global::AcpBusinessLayer.AcpListField CnvPerRxOptionsHearClear_A36408
		{
			get
			{
				short num = (short)2001862656;
				short num2 = num;
				num = (short)1793670166;
				short num3 = num;
				num = (short)1555577878;
				switch (num3 == num)
				{
				}
				num = (short)313982977;
				if (num != 0)
				{
				}
				num = (short)647561216;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408;
			}
		}

		// Token: 0x170065B2 RID: 26034
		// (get) Token: 0x0600CA91 RID: 51857 RVA: 0x00BD0314 File Offset: 0x00BCE514
		// (set) Token: 0x0600CA92 RID: 51858 RVA: 0x00BD03C8 File Offset: 0x00BCE5C8
		public bool CnvPerRxOptionsHearClear_A36408_Applicable
		{
			get
			{
				short num = (short)1262092288;
				short num2 = num;
				num = (short)149880833;
				if (num != 0)
				{
				}
				num = (short)1537831627;
				short num3 = num;
				num = (short)727347915;
				switch (num3 == num)
				{
				}
				num = (short)1259929600;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.Applicable;
			}
			set
			{
				short num = (short)742588416;
				short num2 = num;
				num = (short)1529117142;
				short num3 = num;
				num = (short)557414870;
				switch (num3 == num)
				{
				}
				num = (short)1371996161;
				if (num != 0)
				{
				}
				num = (short)1536360448;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsHearClear_A36408.Applicable = value;
			}
		}

		// Token: 0x170065B3 RID: 26035
		// (get) Token: 0x0600CA93 RID: 51859 RVA: 0x00BD0480 File Offset: 0x00BCE680
		// (set) Token: 0x0600CA94 RID: 51860 RVA: 0x00BD0534 File Offset: 0x00BCE734
		public bool CnvPerRxOptionsHearClear_A36408_Valid
		{
			get
			{
				short num = (short)1388445696;
				short num2 = num;
				num = (short)1656183069;
				short num3 = num;
				num = (short)1146444061;
				switch (num3 == num)
				{
				}
				num = (short)1549205504;
				if (num != 0)
				{
				}
				num = (short)1720582145;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.Valid;
			}
			set
			{
				short num = (short)1724776448;
				short num2 = num;
				num = (short)377296430;
				short num3 = num;
				num = (short)133895726;
				switch (num3 == num)
				{
				}
				num = (short)979042304;
				if (num != 0)
				{
				}
				num = (short)582615041;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsHearClear_A36408.Valid = value;
			}
		}

		// Token: 0x170065B4 RID: 26036
		// (get) Token: 0x0600CA95 RID: 51861 RVA: 0x00BD05EC File Offset: 0x00BCE7EC
		// (set) Token: 0x0600CA96 RID: 51862 RVA: 0x00BD06A0 File Offset: 0x00BCE8A0
		public bool CnvPerRxOptionsHearClear_A36408_Visible
		{
			get
			{
				short num = (short)815726592;
				short num2 = num;
				num = (short)1894725248;
				short num3 = num;
				num = (short)241120896;
				switch (num3 == num)
				{
				}
				num = (short)352190464;
				if (num != 0)
				{
				}
				num = (short)1517748225;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.Visible;
			}
			set
			{
				short num = (short)24969216;
				short num2 = num;
				num = (short)1074247151;
				short num3 = num;
				num = (short)1513403887;
				switch (num3 == num)
				{
				}
				num = (short)243204096;
				if (num != 0)
				{
				}
				num = (short)1129578497;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsHearClear_A36408.Visible = value;
			}
		}

		// Token: 0x170065B5 RID: 26037
		// (get) Token: 0x0600CA97 RID: 51863 RVA: 0x00BD0754 File Offset: 0x00BCE954
		// (set) Token: 0x0600CA98 RID: 51864 RVA: 0x00BD0808 File Offset: 0x00BCEA08
		public bool CnvPerRxOptionsHearClear_A36408_Editable
		{
			get
			{
				short num = (short)1768357888;
				short num2 = num;
				num = (short)1193960893;
				short num3 = num;
				num = (short)1209755069;
				switch (num3 == num)
				{
				}
				num = (short)262733825;
				if (num != 0)
				{
				}
				num = (short)1820327936;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.Editable;
			}
			set
			{
				short num = (short)708116480;
				short num2 = num;
				num = (short)695948663;
				short num3 = num;
				num = (short)761550199;
				switch (num3 == num)
				{
				}
				num = (short)2081357824;
				if (num != 0)
				{
				}
				num = (short)1881473025;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsHearClear_A36408.Editable = value;
			}
		}

		// Token: 0x170065B6 RID: 26038
		// (get) Token: 0x0600CA99 RID: 51865 RVA: 0x00BD08C0 File Offset: 0x00BCEAC0
		internal string CnvPerRxOptionsHearClear_A36408_UILabel
		{
			get
			{
				short num = (short)1212284928;
				short num2 = num;
				num = (short)1238647724;
				short num3 = num;
				num = (short)1459110828;
				switch (num3 == num)
				{
				}
				num = (short)1812594689;
				if (num != 0)
				{
				}
				num = (short)1229127680;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.UIName;
			}
		}

		// Token: 0x170065B7 RID: 26039
		// (get) Token: 0x0600CA9A RID: 51866 RVA: 0x00BD0974 File Offset: 0x00BCEB74
		// (set) Token: 0x0600CA9B RID: 51867 RVA: 0x00BD0A28 File Offset: 0x00BCEC28
		internal bool CnvPerRxOptionsHearClear_A36408_HiddenStatic
		{
			get
			{
				short num = (short)653393920;
				short num2 = num;
				num = (short)104333313;
				if (num != 0)
				{
				}
				num = (short)1765654695;
				short num3 = num;
				num = (short)1645199527;
				switch (num3 == num)
				{
				}
				num = (short)279052288;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.HiddenStatic;
			}
			set
			{
				short num = (short)1728446464;
				short num2 = num;
				num = (short)605683713;
				if (num != 0)
				{
				}
				num = (short)749042731;
				short num3 = num;
				num = (short)927956011;
				switch (num3 == num)
				{
				}
				num = (short)248250368;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsHearClear_A36408.HiddenStatic = value;
			}
		}

		// Token: 0x170065B8 RID: 26040
		// (get) Token: 0x0600CA9C RID: 51868 RVA: 0x00BD0ADC File Offset: 0x00BCECDC
		// (set) Token: 0x0600CA9D RID: 51869 RVA: 0x00BD0B90 File Offset: 0x00BCED90
		internal bool CnvPerRxOptionsHearClear_A36408_HiddenDynamic
		{
			get
			{
				short num = (short)359596032;
				short num2 = num;
				num = (short)85152396;
				short num3 = num;
				num = (short)1076712076;
				switch (num3 == num)
				{
				}
				num = (short)1965293569;
				if (num != 0)
				{
				}
				num = (short)52822016;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408.HiddenDynamic;
			}
			set
			{
				short num = (short)1798242304;
				short num2 = num;
				num = (short)419621049;
				short num3 = num;
				num = (short)1374021817;
				switch (num3 == num)
				{
				}
				num = (short)127467521;
				if (num != 0)
				{
				}
				num = (short)44302336;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsHearClear_A36408.HiddenDynamic = value;
			}
		}

		// Token: 0x170065B9 RID: 26041
		// (get) Token: 0x0600CA9E RID: 51870 RVA: 0x00BD0C48 File Offset: 0x00BCEE48
		public bool CnvPerRxOptionsHearClear_A36408_HasDiffs
		{
			get
			{
				short num = (short)708116480;
				short num2 = num;
				num = (short)205605072;
				short num3 = num;
				num = (short)528566480;
				switch (num3 == num)
				{
				}
				num = (short)1232338944;
				if (num != 0)
				{
				}
				num = (short)943587329;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsHearClear_A36408._HasDiffs;
			}
		}

		// Token: 0x170065BA RID: 26042
		// (get) Token: 0x0600CA9F RID: 51871 RVA: 0x00BD0D00 File Offset: 0x00BCEF00
		// (set) Token: 0x0600CAA0 RID: 51872 RVA: 0x00BD0DB8 File Offset: 0x00BCEFB8
		public bool CnvPerRxOptionsConcurrentRXEnableValue
		{
			get
			{
				short num = (short)1312096256;
				short num2 = num;
				num = (short)291383491;
				short num3 = num;
				num = (short)766257347;
				switch (num3 == num)
				{
				}
				num = (short)738852864;
				if (num != 0)
				{
				}
				num = (short)964296705;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.Value;
			}
			set
			{
				short num = (short)839385088;
				short num2 = num;
				num = (short)985543782;
				short num3 = num;
				num = (short)1855796326;
				switch (num3 == num)
				{
				}
				num = (short)115671041;
				if (num != 0)
				{
				}
				num = (short)1160380416;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsConcurrentRXEnable.Value = value;
			}
		}

		// Token: 0x170065BB RID: 26043
		// (get) Token: 0x0600CAA1 RID: 51873 RVA: 0x00BD0E70 File Offset: 0x00BCF070
		public global::AcpBusinessLayer.AcpField<bool> CnvPerRxOptionsConcurrentRXEnable
		{
			get
			{
				short num = (short)1436024832;
				short num2 = num;
				num = (short)742072119;
				short num3 = num;
				num = (short)70524727;
				switch (num3 == num)
				{
				}
				num = (short)361103361;
				if (num != 0)
				{
				}
				num = (short)1251606528;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable;
			}
		}

		// Token: 0x170065BC RID: 26044
		// (get) Token: 0x0600CAA2 RID: 51874 RVA: 0x00BD0F20 File Offset: 0x00BCF120
		// (set) Token: 0x0600CAA3 RID: 51875 RVA: 0x00BD0FD4 File Offset: 0x00BCF1D4
		public bool CnvPerRxOptionsConcurrentRXEnable_UIValue
		{
			get
			{
				short num = (short)1179516928;
				short num2 = num;
				num = (short)1351659895;
				short num3 = num;
				num = (short)1119990135;
				switch (num3 == num)
				{
				}
				num = (short)1770323969;
				if (num != 0)
				{
				}
				num = (short)1399717888;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.Value;
			}
			set
			{
				short num = (short)2046230528;
				short num2 = num;
				num = (short)809389869;
				short num3 = num;
				num = (short)2031439661;
				switch (num3 == num)
				{
				}
				num = (short)1925775361;
				if (num != 0)
				{
				}
				num = (short)1373831168;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsConcurrentRXEnable.Value = value;
			}
		}

		// Token: 0x170065BD RID: 26045
		// (get) Token: 0x0600CAA4 RID: 51876 RVA: 0x00BD108C File Offset: 0x00BCF28C
		// (set) Token: 0x0600CAA5 RID: 51877 RVA: 0x00BD1140 File Offset: 0x00BCF340
		public bool CnvPerRxOptionsConcurrentRXEnable_Applicable
		{
			get
			{
				short num = (short)2141519872;
				short num2 = num;
				num = (short)258331641;
				short num3 = num;
				num = (short)1979044857;
				switch (num3 == num)
				{
				}
				num = (short)202768385;
				if (num != 0)
				{
				}
				num = (short)808058880;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.Applicable;
			}
			set
			{
				short num = (short)2081488896;
				short num2 = num;
				num = (short)1500839937;
				if (num != 0)
				{
				}
				num = (short)1393565966;
				short num3 = num;
				num = (short)1557537038;
				switch (num3 == num)
				{
				}
				num = (short)1389953024;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsConcurrentRXEnable.Applicable = value;
			}
		}

		// Token: 0x170065BE RID: 26046
		// (get) Token: 0x0600CAA6 RID: 51878 RVA: 0x00BD11F4 File Offset: 0x00BCF3F4
		// (set) Token: 0x0600CAA7 RID: 51879 RVA: 0x00BD12A8 File Offset: 0x00BCF4A8
		public bool CnvPerRxOptionsConcurrentRXEnable_Valid
		{
			get
			{
				short num = (short)273743872;
				short num2 = num;
				num = (short)977928193;
				if (num != 0)
				{
				}
				num = (short)1362845820;
				short num3 = num;
				num = (short)733765756;
				switch (num3 == num)
				{
				}
				num = (short)97910784;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.Valid;
			}
			set
			{
				short num = (short)683016192;
				short num2 = num;
				num = (short)833707975;
				short num3 = num;
				num = (short)434986951;
				switch (num3 == num)
				{
				}
				num = (short)1144193024;
				if (num != 0)
				{
				}
				num = (short)254083073;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsConcurrentRXEnable.Valid = value;
			}
		}

		// Token: 0x170065BF RID: 26047
		// (get) Token: 0x0600CAA8 RID: 51880 RVA: 0x00BD1360 File Offset: 0x00BCF560
		// (set) Token: 0x0600CAA9 RID: 51881 RVA: 0x00BD1414 File Offset: 0x00BCF614
		public bool CnvPerRxOptionsConcurrentRXEnable_Visible
		{
			get
			{
				short num = (short)1439105024;
				short num2 = num;
				num = (short)1047986177;
				if (num != 0)
				{
				}
				num = (short)1487054411;
				short num3 = num;
				num = (short)1466279499;
				switch (num3 == num)
				{
				}
				num = (short)669253632;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.Visible;
			}
			set
			{
				short num = (short)345505792;
				short num2 = num;
				num = (short)1075107281;
				short num3 = num;
				num = (short)801428945;
				switch (num3 == num)
				{
				}
				num = (short)1379205120;
				if (num != 0)
				{
				}
				num = (short)654245889;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsConcurrentRXEnable.Visible = value;
			}
		}

		// Token: 0x170065C0 RID: 26048
		// (get) Token: 0x0600CAAA RID: 51882 RVA: 0x00BD14C8 File Offset: 0x00BCF6C8
		// (set) Token: 0x0600CAAB RID: 51883 RVA: 0x00BD157C File Offset: 0x00BCF77C
		public bool CnvPerRxOptionsConcurrentRXEnable_Editable
		{
			get
			{
				short num = (short)297271296;
				short num2 = num;
				num = (short)485722187;
				short num3 = num;
				num = (short)1828816971;
				switch (num3 == num)
				{
				}
				num = (short)1847656448;
				if (num != 0)
				{
				}
				num = (short)2080440321;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.Editable;
			}
			set
			{
				short num = (short)97779712;
				short num2 = num;
				num = (short)452657153;
				if (num != 0)
				{
				}
				num = (short)2090744762;
				short num3 = num;
				num = (short)374356922;
				switch (num3 == num)
				{
				}
				num = (short)891092992;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsConcurrentRXEnable.Editable = value;
			}
		}

		// Token: 0x170065C1 RID: 26049
		// (get) Token: 0x0600CAAC RID: 51884 RVA: 0x00BD1630 File Offset: 0x00BCF830
		internal string CnvPerRxOptionsConcurrentRXEnable_UILabel
		{
			get
			{
				short num = (short)17694720;
				short num2 = num;
				num = (short)41585837;
				short num3 = num;
				num = (short)1831636141;
				switch (num3 == num)
				{
				}
				num = (short)1558118401;
				if (num != 0)
				{
				}
				num = (short)1047330816;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.UIName;
			}
		}

		// Token: 0x170065C2 RID: 26050
		// (get) Token: 0x0600CAAD RID: 51885 RVA: 0x00BD16E4 File Offset: 0x00BCF8E4
		// (set) Token: 0x0600CAAE RID: 51886 RVA: 0x00BD179C File Offset: 0x00BCF99C
		internal bool CnvPerRxOptionsConcurrentRXEnable_HiddenStatic
		{
			get
			{
				short num = (short)682688512;
				short num2 = num;
				num = (short)1505539836;
				short num3 = num;
				num = (short)185513724;
				switch (num3 == num)
				{
				}
				num = (short)1208877057;
				if (num != 0)
				{
				}
				num = (short)1624375296;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.HiddenStatic;
			}
			set
			{
				short num = (short)1048576000;
				short num2 = num;
				num = (short)477347372;
				short num3 = num;
				num = (short)1753202220;
				switch (num3 == num)
				{
				}
				num = (short)1608187904;
				if (num != 0)
				{
				}
				num = (short)1428160513;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsConcurrentRXEnable.HiddenStatic = value;
			}
		}

		// Token: 0x170065C3 RID: 26051
		// (get) Token: 0x0600CAAF RID: 51887 RVA: 0x00BD1854 File Offset: 0x00BCFA54
		// (set) Token: 0x0600CAB0 RID: 51888 RVA: 0x00BD1908 File Offset: 0x00BCFB08
		internal bool CnvPerRxOptionsConcurrentRXEnable_HiddenDynamic
		{
			get
			{
				short num = (short)1724776448;
				short num2 = num;
				num = (short)1615527970;
				short num3 = num;
				num = (short)1914765346;
				switch (num3 == num)
				{
				}
				num = (short)439156737;
				if (num != 0)
				{
				}
				num = (short)1630601216;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable.HiddenDynamic;
			}
			set
			{
				short num = (short)2104229888;
				short num2 = num;
				num = (short)1973330927;
				short num3 = num;
				num = (short)588620783;
				switch (num3 == num)
				{
				}
				num = (short)2020147201;
				if (num != 0)
				{
				}
				num = (short)463208448;
				if (num != 0)
				{
				}
				this.cnvPerRxOptionsConcurrentRXEnable.HiddenDynamic = value;
			}
		}

		// Token: 0x170065C4 RID: 26052
		// (get) Token: 0x0600CAB1 RID: 51889 RVA: 0x00BD19C0 File Offset: 0x00BCFBC0
		public bool CnvPerRxOptionsConcurrentRXEnable_HasDiffs
		{
			get
			{
				short num = (short)1472724992;
				short num2 = num;
				num = (short)854622555;
				short num3 = num;
				num = (short)1545503067;
				switch (num3 == num)
				{
				}
				num = (short)308609024;
				if (num != 0)
				{
				}
				num = (short)2010710017;
				if (num != 0)
				{
				}
				return this.cnvPerRxOptionsConcurrentRXEnable._HasDiffs;
			}
		}

		// Token: 0x170065C5 RID: 26053
		// (get) Token: 0x0600CAB2 RID: 51890 RVA: 0x00BD1A74 File Offset: 0x00BCFC74
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide RefConventionalWide
		{
			get
			{
				short num = (short)191102976;
				short num2 = num;
				num = (short)535418200;
				short num3 = num;
				num = (short)2063062360;
				switch (num3 == num)
				{
				}
				num = (short)634454017;
				if (num != 0)
				{
				}
				num = (short)1431568384;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2024)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide;
			}
		}

		// Token: 0x170065C6 RID: 26054
		// (get) Token: 0x0600CAB3 RID: 51891 RVA: 0x00BD1B30 File Offset: 0x00BCFD30
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1834549248;
				short num2 = num;
				num = (short)791500950;
				short num3 = num;
				num = (short)609179798;
				switch (num3 == num)
				{
				}
				num = (short)514850816;
				if (num != 0)
				{
				}
				num = (short)1583939585;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x170065C7 RID: 26055
		// (get) Token: 0x0600CAB4 RID: 51892 RVA: 0x00BD1BEC File Offset: 0x00BCFDEC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)108593152;
				short num2 = num;
				num = (short)447193128;
				short num3 = num;
				num = (short)1892458536;
				switch (num3 == num)
				{
				}
				num = (short)1557659649;
				if (num != 0)
				{
				}
				num = (short)700252160;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x00BD1CB0 File Offset: 0x00BCFEB0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)542645071;
			short num2 = num;
			num = (short)613751631;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_90:
				num = (short)1511063554;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1092026368;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					goto IL_85;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1535770627;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
				{
					num = (short)1626603520;
					short num4 = num;
					num = (short)1099038721;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)993984513;
					if (num != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)401211396;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return result;
				}
				goto IL_6F;
			}
			IL_85:
			if (base.ParentRecset != null)
			{
				goto IL_90;
			}
			return result;
			IL_6F:
			result = null;
			num = (short)947388416;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x040064D3 RID: 25811
		private global::AcpBusinessLayer.AcpField<bool> cnvPerRxOptionsBusyLED_A7570;

		// Token: 0x040064D4 RID: 25812
		private global::AcpBusinessLayer.AcpField<bool> cnvPerRxOptionsReceiveOnlyPersonality_A8916;

		// Token: 0x040064D5 RID: 25813
		private global::AcpBusinessLayer.AcpField<bool> cnvPerRxOptionsRxDeEmphasis_A9010;

		// Token: 0x040064D6 RID: 25814
		private global::AcpBusinessLayer.AcpListField cnvPerRxOptionsRxUnmuteDelayms_A9033;

		// Token: 0x040064D7 RID: 25815
		private global::AcpBusinessLayer.AcpListField cnvPerRxOptionsRxVoiceSignalType_A9044;

		// Token: 0x040064D8 RID: 25816
		private global::AcpBusinessLayer.AcpListField cnvPerRxOptionsSquelchFineTune_A9176;

		// Token: 0x040064D9 RID: 25817
		private global::AcpBusinessLayer.AcpListField cnvPerRxOptionsUnmuteMuteType_A9602;

		// Token: 0x040064DA RID: 25818
		private global::AcpBusinessLayer.AcpListField cnvPerRxOptionsHearClear_A36408;

		// Token: 0x040064DB RID: 25819
		private global::AcpBusinessLayer.AcpField<bool> cnvPerRxOptionsConcurrentRXEnable;
	}
}
