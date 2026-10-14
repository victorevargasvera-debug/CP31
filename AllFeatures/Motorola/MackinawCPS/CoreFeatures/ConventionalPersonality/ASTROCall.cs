using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x02000579 RID: 1401
	[global::System.Serializable]
	public class ASTROCall : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600BFEA RID: 49130 RVA: 0x00B11888 File Offset: 0x00B0FA88
		public ASTROCall(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x00B118A4 File Offset: 0x00B0FAA4
		protected ASTROCall(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x00B118BC File Offset: 0x00B0FABC
		public override void Init()
		{
			int a_ = 8;
			short num = (short)856358912;
			short num2 = num;
			num = (short)1509359617;
			if (num != 0)
			{
			}
			num = (short)2070654739;
			short num3 = num;
			num = (short)814853907;
			switch (num3 == num)
			{
			}
			num = (short)574554112;
			if (num != 0)
			{
			}
			this.cnvPerASTROCallASTROCallHotList_A7488 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤ꛦ뫨뿪뿬ꃮ닰鋲駴鯶뇸铺觼돾栀瀂焄堆䠈㰊㤌㜎⤐", a_), global::CommonResources.AcgResources.ID_ASTROCALLHOTLIST, null, null, true, false);
			this.cnvPerASTROCallASTROCallHotList_A7488.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROCallASTROCallHotList_A7488.DataTransferOrder = 81;
			this.cnvPerASTROCallASTROUnlimitedCalling_A7501 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤ꛦ뫨뿪뿬ꃮꓰ鷲駴黶铸鋺觼髾攀䀂搄欆攈戊挌栎丐划∔∖⤘⨚", a_), global::CommonResources.AcgResources.ID_ASTROUNLIMITEDCALLING);
			this.cnvPerASTROCallASTROUnlimitedCalling_A7501.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROCallASTROUnlimitedCalling_A7501.DataTransferOrder = 113;
			this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤ꛦ鳨鿪苬볮铰鿲郴银跸鋺诼髾䈀戂椄欆崈礊氌愎成縒簔挖䘘娚⨜⨞ဠᬢ", a_), global::CommonResources.AcgResources.ID_SELECTIVECALLAUTOSELECTIVECALLTRANSMIT);
			this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.DataTransferOrder = 83;
			this.cnvPerASTROCallCallAlertRxTx_A7586 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤ꓦ裨蟪臬껮鷰雲蟴菶꯸菺ꧼ蟾帀䈂㈄㈆ㄈ㴊", a_), global::CommonResources.AcgResources.ID_CALLALERTCALLALERTRXTX, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerASTROCallCallAlertRxTx_A7586LovStrs);
			this.cnvPerASTROCallCallAlertRxTx_A7586.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROCallCallAlertRxTx_A7586.DataTransferOrder = 21;
			this.cnvPerASTROCallInCallUserAlertEnable_A8250 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤껦蟨꣪賬菮鷰꛲蛴鋶诸뫺釼髾猀眂䀄椆栈椊愌樎丐划ⴔ┖Ⱈ⬚", a_), global::CommonResources.AcgResources.ID_CALLALERTINCALLUSERALERTENABLE);
			this.cnvPerASTROCallInCallUserAlertEnable_A8250.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROCallInCallUserAlertEnable_A8250.DataTransferOrder = 86;
			this.cnvPerASTROCallSelectiveCallRxTx_A9114 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤듦賨蟪裬賮藰髲菴鋶뫸髺釼鏾匀笂億缆嘈䨊㐌㸎‐✒", a_), global::CommonResources.AcgResources.ID_SELECTIVECALLSELECTIVECALLRXTX, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerASTROCallSelectiveCallRxTx_A9114LovStrs);
			this.cnvPerASTROCallSelectiveCallRxTx_A9114.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROCallSelectiveCallRxTx_A9114.DataTransferOrder = 51;
			this.cnvPerTacticalInhibitKillOperation_A41553 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ臔뛖뫘꿚드볞胠迢곤触臨苪迬蛮藰룲鳴鯶闸듺跼髾猀戂焄渆昈攊刌与┐−—∖⨘", a_), global::CommonResources.AcgResources.ID_TACTICALINHIBITKILLOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerTacticalInhibitKillOperation_A41553LovStrs);
			this.cnvPerTacticalInhibitKillOperation_A41553.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerTacticalInhibitKillOperation_A41553.DataTransferOrder = 67;
			this.cnvPerTacticalInhibitStunOperation_A41557 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ臔뛖뫘꿚드볞胠迢곤触臨苪迬蛮藰ꃲ致苶韸듺跼髾猀戂焄渆昈攊刌与┐−—∖⸘", a_), global::CommonResources.AcgResources.ID_TACTICALINHIBITSTUNOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerTacticalInhibitStunOperation_A41557LovStrs);
			this.cnvPerTacticalInhibitStunOperation_A41557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerTacticalInhibitStunOperation_A41557.DataTransferOrder = 68;
			this.cnvPerASTROCallTacticalServicesOperation = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤돦裨裪駬蛮鋰鋲駴ꓶ鳸觺诼雾戀昂瘄䠆礈渊缌渎攐稒稔礖", a_), global::CommonResources.AcgResources.ID_TACTICALSERVICESOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerASTROCallTacticalServicesOperationLovStrs);
			this.cnvPerASTROCallTacticalServicesOperation.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerASTROCallTacticalServicesOperation.DataTransferOrder = 114;
			this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤뗦裨迪蓬胮ꓰ鷲鳴駶釸鋺鿼雾甀䜂怄搆昈漊栌与爐朒簔砖眘䐚尜☞ᄠᜢဤ", a_), global::CommonResources.AcgResources.ID_RADIOUNINHIBITDECODEACTION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.cnvPerASTROCallRadioUninhibitDecodeAction_A9045LovStrs);
			this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.DataTransferOrder = 115;
			this.cnvPerASTROCallRemotemonitorfrequencyoption = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤뗦賨蛪苬鯮铰黲髴駶郸迺鋼跾最焂怄瘆簈渊挌氎栐簒攔挖瀘琚猜", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORFREQUENCYOPTION, null, null, false, true);
			this.cnvPerASTROCallRemotemonitorfrequencyoption.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerASTROCallRemotemonitorfrequencyoption.DataTransferOrder = 116;
			this.cnvPerASTROCallRemoteMonitorTxRxTime = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ铔蓖跘觚鋜鳞胠迢觤뗦賨蛪苬鯮铰뻲髴駶郸迺鋼跾唀笂圄缆崈戊怌樎", a_), global::CommonResources.AcgResources.ID_RemoteMonitorTxRxTimer, 10, 120, 5);
			this.cnvPerASTROCallRemoteMonitorTxRxTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerASTROCallRemoteMonitorTxRxTime.DataTransferOrder = 118;
			this.cnvPerASTROCallRemoteMonitorTxRxTime.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裈飊駌鷎黐雔뛖뗘럚", a_);
			base.Id = 10141;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROCALL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x00B11C84 File Offset: 0x00B0FE84
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)113049630;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_51A;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡뛣菥藧藩飫语뷯鷱髳鿵賷闹軻꫽磿倁簃刅愇有椋", a_)))
					{
						num = (short)1865416720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99D;
				case 2:
					goto IL_799;
				case 3:
					this.cnvPerASTROCallRemotemonitorfrequencyoption = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡뛣菥藧藩飫语鷯鷱髳鿵賷闹軻飽狿朁甃猅洇搉漋眍缏我怓缕眗琙", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORFREQUENCYOPTION, null, null, false, true);
					this.cnvPerASTROCallRemotemonitorfrequencyoption.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerASTROCallRemotemonitorfrequencyoption.DataTransferOrder = 116;
					num = (short)567017484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡ꗣ뗥볧룩ꏫ믭黯黱鷳鯵釷軹駻髽䏿持栃樅愇搉欋儍儏┑ℓ☕⤗", a_)))
					{
						num = (short)1751449606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A3;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡귣裥ꯧ诩胫苭ꗯ臱釳蓵맷雹駻賽瓿䜁樃朅樇昉椋儍儏⨑☓⌕⠗", a_)))
					{
						num = (short)1688076327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_799;
				case 6:
					this.cnvPerASTROCallASTROUnlimitedCalling_A7501 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡ꗣ뗥볧룩ꏫ믭黯黱鷳鯵釷軹駻髽䏿持栃樅愇搉欋儍儏┑ℓ☕⤗", a_), global::CommonResources.AcgResources.ID_ASTROUNLIMITEDCALLING);
					this.cnvPerASTROCallASTROUnlimitedCalling_A7501.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROCallASTROUnlimitedCalling_A7501.DataTransferOrder = 113;
					num = (short)628293641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡뛣菥藧藩飫语鷯鷱髳鿵賷闹軻飽狿朁甃猅洇搉漋眍缏我怓缕眗琙", a_)))
					{
						num = (short)211746819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_341;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡꟣蟥蓧蛩귫苭闯胱胳ꓵ胷껹蓻ꇽ䇿㔁㄃㸅㸇", a_)))
					{
						num = (short)104267799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51A;
				case 9:
					goto IL_5A3;
				case 10:
					goto IL_F5;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ蛑뗓뗕곗동뿛뿝賟ꯡ諣軥臧裩藫髭ꏯ蛱至飵럷諹駻賽懿瘁洃椅昇唉䴋㨍ℏ✑ℓℕ", a_)))
					{
						num = (short)1360265230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F5;
				case 12:
					goto IL_341;
				case 13:
					this.cnvPerASTROCallTacticalServicesOperation = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡냣蟥诧黩藫跭釯黱ꟳ鏵諷賹闻鷽旿焁䬃瘅洇砉洋稍礏紑稓", a_), global::CommonResources.AcgResources.ID_TACTICALSERVICESOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerASTROCallTacticalServicesOperationLovStrs);
					this.cnvPerASTROCallTacticalServicesOperation.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerASTROCallTacticalServicesOperation.DataTransferOrder = 114;
					num = (short)158924827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.cnvPerTacticalInhibitStunOperation_A41557 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ蛑뗓뗕곗동뿛뿝賟ꯡ諣軥臧裩藫髭ꏯ蛱至飵럷諹駻賽懿瘁洃椅昇唉䴋㨍ℏ✑ℓℕ", a_), global::CommonResources.AcgResources.ID_TACTICALINHIBITSTUNOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerTacticalInhibitStunOperation_A41557LovStrs);
					this.cnvPerTacticalInhibitStunOperation_A41557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerTacticalInhibitStunOperation_A41557.DataTransferOrder = 68;
					num = (short)2146304010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡냣蟥诧黩藫跭釯黱ꟳ鏵諷賹闻鷽旿焁䬃瘅洇砉洋稍礏紑稓", a_)))
					{
						num = (short)2052521997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8CE;
				case 16:
					this.cnvPerASTROCallRemoteMonitorTxRxTime = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡뛣菥藧藩飫语뷯鷱髳鿵賷闹軻꫽磿倁簃刅愇有椋", a_), global::CommonResources.AcgResources.ID_RemoteMonitorTxRxTimer);
					this.cnvPerASTROCallRemoteMonitorTxRxTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerASTROCallRemoteMonitorTxRxTime.DataTransferOrder = 118;
					this.cnvPerASTROCallRemoteMonitorTxRxTime.ShowHexValue = false;
					num = (short)2139357222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields != null)
					{
						num = (short)863961116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99D;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ蛑뗓뗕곗동뿛뿝賟ꯡ諣軥臧裩藫髭믯鯱飳髵럷諹駻賽懿瘁洃椅昇唉䴋㨍ℏ✑ℓ┕", a_)))
					{
						num = (short)1677787155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E7;
				case 19:
					num = (short)1740111873;
					if (num != 0)
					{
					}
					this.cnvPerTacticalInhibitKillOperation_A41553 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ蛑뗓뗕곗동뿛뿝賟ꯡ諣軥臧裩藫髭믯鯱飳髵럷諹駻賽懿瘁洃椅昇唉䴋㨍ℏ✑ℓ┕", a_), global::CommonResources.AcgResources.ID_TACTICALINHIBITKILLOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerTacticalInhibitKillOperation_A41553LovStrs);
					this.cnvPerTacticalInhibitKillOperation_A41553.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerTacticalInhibitKillOperation_A41553.DataTransferOrder = 67;
					num = (short)256507928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡ꗣ뗥볧룩ꏫ귭釯黱飳뻵韷軹냻韽珿瘁嬃䜅㼇㸉㐋㘍", a_)))
					{
						num = (short)1466171421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5EF;
				case 21:
				{
					num = (short)295370752;
					short num3 = num;
					goto IL_144;
				}
				case 22:
					this.cnvPerASTROCallSelectiveCallRxTx_A9114 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡럣菥蓧迩迫髭駯蓱釳뗵駷雹郻곽磿嘁簃夅䤇㌉㴋㼍␏", a_), global::CommonResources.AcgResources.ID_SELECTIVECALLSELECTIVECALLRXTX, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerASTROCallSelectiveCallRxTx_A9114LovStrs);
					this.cnvPerASTROCallSelectiveCallRxTx_A9114.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROCallSelectiveCallRxTx_A9114.DataTransferOrder = 51;
					num = (short)1110573077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					this.cnvPerASTROCallCallAlertRxTx_A7586 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡꟣蟥蓧蛩귫苭闯胱胳ꓵ胷껹蓻ꇽ䇿㔁㄃㸅㸇", a_), global::CommonResources.AcgResources.ID_CALLALERTCALLALERTRXTX, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerASTROCallCallAlertRxTx_A7586LovStrs);
					this.cnvPerASTROCallCallAlertRxTx_A7586.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROCallCallAlertRxTx_A7586.DataTransferOrder = 21;
					num = (short)396754944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_7E7;
				case 25:
					goto IL_467;
				case 26:
					goto IL_462;
				case 27:
					goto IL_8CE;
				case 28:
					num = (short)1875247124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					this.cnvPerASTROCallASTROCallHotList_A7488 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡ꗣ뗥볧룩ꏫ귭釯黱飳뻵韷軹냻韽珿瘁嬃䜅㼇㸉㐋㘍", a_), global::CommonResources.AcgResources.ID_ASTROCALLHOTLIST, null, null, true, false);
					this.cnvPerASTROCallASTROCallHotList_A7488.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROCallASTROCallHotList_A7488.DataTransferOrder = 81;
					num = (short)1794506785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				case 31:
				{
					num = (short)1742126007;
					short num4 = num;
					num = (short)668056503;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_462;
					default:
						num = (short)432406528;
						if (num != 0)
						{
						}
						this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡뛣蟥賧菩菫믭黯鯱髳黵釷飹闻諽䓿朁會椅氇漉䴋洍搏笑笓砕䜗嬙┛⸝ᐟᜡ", a_), global::CommonResources.AcgResources.ID_RADIOUNINHIBITDECODEACTION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.cnvPerASTROCallRadioUninhibitDecodeAction_A9045LovStrs);
						this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.DataTransferOrder = 115;
						num = (short)842072089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡ꗣ鏥鳧藩뿫语鳯韱音苵釷賹駻뷽懿渁栃刅稇欉戋納紏笑怓䤕夗ⴙ⤛⼝᠟", a_)))
					{
						num = (short)1755709475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_834;
				case 33:
					goto IL_5EF;
				case 34:
					num = (short)609419281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡ꗣ鏥鳧藩뿫语鳯韱音苵釷賹駻뷽懿渁栃刅稇欉戋納紏笑怓䤕夗ⴙ⤛⼝᠟", a_), global::CommonResources.AcgResources.ID_SELECTIVECALLAUTOSELECTIVECALLTRANSMIT);
					this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.DataTransferOrder = 83;
					num = (short)2081095706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡뛣蟥賧菩菫믭黯鯱髳黵釷飹闻諽䓿朁會椅氇漉䴋洍搏笑笓砕䜗嬙┛⸝ᐟᜡ", a_)))
					{
						num = (short)1532297247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_467;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡럣菥蓧迩迫髭駯蓱釳뗵駷雹郻곽磿嘁簃夅䤇㌉㴋㼍␏", a_)))
					{
						num = (short)1436483606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				case 38:
					goto IL_515;
				case 39:
					this.cnvPerASTROCallInCallUserAlertEnable_A8250 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙鿛뿝賟軡귣裥ꯧ诩胫苭ꗯ臱釳蓵맷雹駻賽瓿䜁樃朅樇昉椋儍儏⨑☓⌕⠗", a_), global::CommonResources.AcgResources.ID_CALLALERTINCALLUSERALERTENABLE);
					this.cnvPerASTROCallInCallUserAlertEnable_A8250.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROCallInCallUserAlertEnable_A8250.DataTransferOrder = 86;
					num = (short)1229520898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CD:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1035075618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F5:
				num = (short)1935540239;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_144:
				num = (short)1125515282;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_341:
				num = (short)2109472769;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_467:
				num = (short)1423769607;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51A:
				num = (short)1692663813;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A3:
				num = (short)1956380704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5EF:
				num = (short)1265106948;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_799:
				num = (short)1846542373;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7E7:
				num = (short)1284505611;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_834:
				num = (short)155320328;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_462:
				goto IL_834;
				IL_8CE:
				num = (short)1443299364;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_515:
			IL_99D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟅鯇黉黋臍金뗓뫕듗", a_);
			base.Id = 10141;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROCALL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x00B12660 File Offset: 0x00B10860
		public override void PopulateReferences()
		{
			short num = (short)791805952;
			short num2 = num;
			num = (short)1151860737;
			if (num != 0)
			{
			}
			num = (short)1961465904;
			short num3 = num;
			num = (short)1506908208;
			switch (num3 == num)
			{
			}
			num = (short)1024131072;
			if (num != 0)
			{
			}
			this.cnvPerASTROCallASTROCallHotList_A7488.SetRecset(this.a(2210));
			global::AcpCommonLib.IAcpRecordset acpRecordset = this.a(2059);
			global::AcpCommonLib.IAcpRecordset embeddedRecset = acpRecordset[acpRecordset.Count - 1][10148].EmbeddedRecset;
			this.cnvPerASTROCallRemotemonitorfrequencyoption.SetRecset(embeddedRecset);
		}

		// Token: 0x0600BFEF RID: 49135 RVA: 0x00B12754 File Offset: 0x00B10954
		public override void DropReferences()
		{
			short num = (short)2065629184;
			short num2 = num;
			num = (short)319436232;
			short num3 = num;
			num = (short)1148663240;
			switch (num3 == num)
			{
			}
			num = (short)167182337;
			if (num != 0)
			{
			}
			num = (short)842858496;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x00B12800 File Offset: 0x00B10A00
		public override void SetConstraints()
		{
			short num = (short)1389101056;
			short num2 = num;
			num = (short)982253569;
			if (num != 0)
			{
			}
			num = (short)329023422;
			short num3 = num;
			num = (short)1595178942;
			switch (num3 == num)
			{
			}
			num = (short)791478272;
			if (num != 0)
			{
			}
			this.cnvPerASTROCallASTROCallHotList_A7488.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conConventionalSignallingIsNotNonAstro);
			this.cnvPerASTROCallASTROUnlimitedCalling_A7501.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerAstroRxSigIsEnaAndCnvPerAstroCaEncIsEnaOrCnvPerAstroBasicScEncIsEna);
			this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conAstroBasicSelCallEncIsEnabled);
			this.cnvPerASTROCallCallAlertRxTx_A7586.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvAstroDVRSActViaCallAlertApp);
			this.cnvPerASTROCallCallAlertRxTx_A7586.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvAstroDVRSActViaCallAlertValid);
			this.cnvPerASTROCallInCallUserAlertEnable_A8250.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conAstroCallAllertIsEncodeORDecodeEncodeANDCnvPerASTROOrWithUnmuteEnable);
			this.cnvPerASTROCallSelectiveCallRxTx_A9114.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conConventionalSignallingIsNotNonAstroAndRSI);
			this.cnvPerASTROCallSelectiveCallRxTx_A9114.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerTacticalInhibitKillOperation_A41553.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTacticalInhibitEnAndTxSignalTypeIsAstro);
			this.cnvPerTacticalInhibitKillOperation_A41553.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConKillEncodeDecodeBasedOnRxTxOption);
			this.cnvPerTacticalInhibitStunOperation_A41557.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTacticalInhibitEnAndTxSignalTypeIsAstro);
			this.cnvPerTacticalInhibitStunOperation_A41557.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConStunEncodeDecodeBasedOnRxTxOption);
			this.cnvPerASTROCallTacticalServicesOperation.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTacticalServicesOperationIsValid);
			this.cnvPerASTROCallTacticalServicesOperation.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTacticalServicesOperationIsApplicable);
			this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRadioUninhibitDecodeActionIsValid);
			this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRadioUninhibitDecodeActionIsApplicable);
			this.cnvPerASTROCallRemotemonitorfrequencyoption.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.cnvPerASTROCallRemotemonitorfrequencyoptionIsApplicable);
			this.cnvPerASTROCallRemotemonitorfrequencyoption.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerASTROCallRemotemonitorfrequencyoptionValueSetter);
			this.cnvPerASTROCallRemoteMonitorTxRxTime.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.cnvPerASTROCallRemoteMonitorTxRxTimeIsApplicable);
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x00B12A60 File Offset: 0x00B10C60
		public override void SetupDependencies()
		{
			short num = (short)425132032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset remoteSpeakerMicRecset;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1538260993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)1201209344;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_47A;
									}
									continue;
								case 2:
									goto IL_511;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1586298884;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection rsmbuttonInnerSection = enumerator.Current[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection;
									this.CnvPerASTROCallTacticalServicesOperation.AddDependentObject(rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640);
									num = (short)1469579265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)67108866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_47C:
								num = (short)543424515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_47A:
								goto IL_47C;
							}
							IL_511:
							return;
						}
						finally
						{
							num = (short)1359478785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_582;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_54A;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)284426240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_54A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)294584322;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_582:;
						}
						goto IL_585;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)301989894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_585;
					case 4:
						if (buttonsRecset != null)
						{
							num = (short)77004803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CE;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
						if (rsmbuttonInnerRecset != null)
						{
							num = (short)826605568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						try
						{
							num = (short)584908802;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_731;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1739259907;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection = enumerator.Current[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection;
									this.CnvPerASTROCallTacticalServicesOperation.AddDependentObject(portableButtonInnerSection.BtnGeneralConventionalFeature_A19544);
									num = (short)2141061124;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_69B;
									}
									continue;
								case 3:
									num = (short)1887764480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6E0:
								num = (short)1092812801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_69B:
								goto IL_6E0;
							}
							IL_731:
							goto IL_3CE;
						}
						finally
						{
							num = (short)91422722;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)332872685;
									short num3 = num;
									num = (short)191773677;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_788;
									default:
										goto IL_7DD;
									}
									break;
								}
								case 1:
									goto IL_788;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_76A;
									}
									continue;
								}
								IL_76A:
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (enumerator != null)
								{
									num = (short)1936588801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7F5;
								IL_788:
								enumerator.Dispose();
								num = (short)1580204032;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7DD:
							num = (short)606470144;
							if (num != 0)
							{
							}
							IL_7F5:;
						}
						return;
					case 7:
						if (portableButtonInnerRecset != null)
						{
							num = (short)82968578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CE;
					case 8:
						if (remoteSpeakerMicRecset != null)
						{
							num = (short)1155334153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset = remoteSpeakerMicRecset[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset;
						num = (short)1906311169;
						if (num != 0)
						{
						}
						num = (short)179240965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_57;
					IL_3CE:
					remoteSpeakerMicRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset);
					num = (short)1893072904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_585:
					portableButtonInnerRecset = (buttonsRecset[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
					num = (short)577175559;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_57:
				num = (short)1982726144;
				short num4 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROCallASTROCallHotList_A7488);
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.AddDependentObject(this.cnvPerASTROCallASTROUnlimitedCalling_A7501);
				this.cnvPerASTROCallCallAlertRxTx_A7586.AddDependentObject(this.cnvPerASTROCallASTROUnlimitedCalling_A7501);
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROCallASTROUnlimitedCalling_A7501);
				this.cnvPerTacticalInhibitKillOperation_A41553.AddDependentObject(this.cnvPerASTROCallASTROUnlimitedCalling_A7501);
				this.cnvPerTacticalInhibitStunOperation_A41557.AddDependentObject(this.cnvPerASTROCallASTROUnlimitedCalling_A7501);
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.AddDependentObject(this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518);
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518);
				conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518);
				this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerASTROCallCallAlertRxTx_A7586);
				conventionalPersonality.General.CnvPerFeaturesDVRSProf_A41794.AddDependentObject(this.cnvPerASTROCallCallAlertRxTx_A7586);
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROCallCallAlertRxTx_A7586);
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROCallInCallUserAlertEnable_A8250);
				this.cnvPerASTROCallCallAlertRxTx_A7586.AddDependentObject(this.cnvPerASTROCallInCallUserAlertEnable_A8250);
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROCallSelectiveCallRxTx_A9114);
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerTacticalInhibitKillOperation_A41553);
				this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.cnvPerTacticalInhibitKillOperation_A41553);
				conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerTacticalInhibitKillOperation_A41553);
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerTacticalInhibitStunOperation_A41557);
				this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.cnvPerTacticalInhibitStunOperation_A41557);
				conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerTacticalInhibitStunOperation_A41557);
				this.RefRadioLock.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045);
				this.RefRadioLock.UserInformationAndPasswords.RadWideUserInformationandPasswordsMandatoryPassword_A8461.AddDependentObject(this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045);
				this.RefRadioLock.UserInformationAndPasswords.RadWideUserInformationandPasswordsUnlockPassword_A8690.AddDependentObject(this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045);
				conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROCallTacticalServicesOperation);
				conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerASTROCallTacticalServicesOperation);
				conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerASTROCallTacticalServicesOperation);
				conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044);
				conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044);
				this.CnvPerASTROCallTacticalServicesOperation.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuConventionalSelectedMenuItems_A21736);
				buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
				num = (short)1436352516;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x17006066 RID: 24678
		// (get) Token: 0x0600BFF2 RID: 49138 RVA: 0x00B13280 File Offset: 0x00B11480
		public bool HasDiffs
		{
			get
			{
				short num = (short)174556730;
				short num2 = num;
				num = (short)335054394;
				switch (num2 == num)
				{
				}
				num = (short)386269185;
				if (num != 0)
				{
				}
				num = (short)1967718400;
				if (num != 0)
				{
				}
				num = (short)52101120;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17006067 RID: 24679
		// (get) Token: 0x0600BFF3 RID: 49139 RVA: 0x00B13330 File Offset: 0x00B11530
		// (set) Token: 0x0600BFF4 RID: 49140 RVA: 0x00B133E4 File Offset: 0x00B115E4
		public int CnvPerASTROCallASTROCallHotList_A7488Value
		{
			get
			{
				short num = (short)750843016;
				short num2 = num;
				num = (short)377746568;
				switch (num2 == num)
				{
				}
				num = (short)648806401;
				if (num != 0)
				{
				}
				num = (short)376373248;
				if (num != 0)
				{
				}
				num = (short)1603731456;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.Value;
			}
			set
			{
				short num = (short)771211503;
				short num2 = num;
				num = (short)2075640047;
				switch (num2 == num)
				{
				}
				num = (short)1346961408;
				if (num != 0)
				{
				}
				num = (short)2046492673;
				if (num != 0)
				{
				}
				num = (short)467927040;
				short num3 = num;
				this.cnvPerASTROCallASTROCallHotList_A7488.Value = value;
			}
		}

		// Token: 0x17006068 RID: 24680
		// (get) Token: 0x0600BFF5 RID: 49141 RVA: 0x00B1349C File Offset: 0x00B1169C
		// (set) Token: 0x0600BFF6 RID: 49142 RVA: 0x00B13554 File Offset: 0x00B11754
		public string CnvPerASTROCallASTROCallHotList_A7488_UIValue
		{
			get
			{
				short num = (short)1476422109;
				short num2 = num;
				num = (short)873949661;
				switch (num2 == num)
				{
				}
				num = (short)1814888449;
				if (num != 0)
				{
				}
				num = (short)239468544;
				if (num != 0)
				{
				}
				num = (short)901054464;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.UIValue;
			}
			set
			{
				short num = (short)242941953;
				if (num != 0)
				{
				}
				num = (short)1982068608;
				short num2 = num;
				num = (short)820443008;
				switch (num2 == num)
				{
				}
				num = (short)1689518080;
				if (num != 0)
				{
				}
				num = (short)731906048;
				short num3 = num;
				this.cnvPerASTROCallASTROCallHotList_A7488.UIValue = value;
			}
		}

		// Token: 0x17006069 RID: 24681
		// (get) Token: 0x0600BFF7 RID: 49143 RVA: 0x00B13608 File Offset: 0x00B11808
		public global::AcpBusinessLayer.AcpRecRefField CnvPerASTROCallASTROCallHotList_A7488
		{
			get
			{
				short num = (short)1304636012;
				short num2 = num;
				num = (short)647834220;
				switch (num2 == num)
				{
				}
				num = (short)585826305;
				if (num != 0)
				{
				}
				num = (short)568655872;
				if (num != 0)
				{
				}
				num = (short)125566976;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488;
			}
		}

		// Token: 0x1700606A RID: 24682
		// (get) Token: 0x0600BFF8 RID: 49144 RVA: 0x00B136B8 File Offset: 0x00B118B8
		// (set) Token: 0x0600BFF9 RID: 49145 RVA: 0x00B1376C File Offset: 0x00B1196C
		public bool CnvPerASTROCallASTROCallHotList_A7488_Applicable
		{
			get
			{
				short num = (short)1301707515;
				short num2 = num;
				num = (short)1461287675;
				switch (num2 == num)
				{
				}
				num = (short)1222508544;
				if (num != 0)
				{
				}
				num = (short)1672871937;
				if (num != 0)
				{
				}
				num = (short)464257024;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.Applicable;
			}
			set
			{
				short num = (short)1932936797;
				short num2 = num;
				num = (short)1426867805;
				switch (num2 == num)
				{
				}
				num = (short)1893662721;
				if (num != 0)
				{
				}
				num = (short)1610678272;
				if (num != 0)
				{
				}
				num = (short)252903424;
				short num3 = num;
				this.cnvPerASTROCallASTROCallHotList_A7488.Applicable = value;
			}
		}

		// Token: 0x1700606B RID: 24683
		// (get) Token: 0x0600BFFA RID: 49146 RVA: 0x00B13820 File Offset: 0x00B11A20
		// (set) Token: 0x0600BFFB RID: 49147 RVA: 0x00B138D4 File Offset: 0x00B11AD4
		public bool CnvPerASTROCallASTROCallHotList_A7488_Valid
		{
			get
			{
				short num = (short)100803021;
				short num2 = num;
				num = (short)1883251149;
				switch (num2 == num)
				{
				}
				num = (short)1769078784;
				if (num != 0)
				{
				}
				num = (short)656408577;
				if (num != 0)
				{
				}
				num = (short)1009319936;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.Valid;
			}
			set
			{
				short num = (short)1951490847;
				short num2 = num;
				num = (short)1297113887;
				switch (num2 == num)
				{
				}
				num = (short)1156382721;
				if (num != 0)
				{
				}
				num = (short)200081408;
				if (num != 0)
				{
				}
				num = (short)1338834944;
				short num3 = num;
				this.cnvPerASTROCallASTROCallHotList_A7488.Valid = value;
			}
		}

		// Token: 0x1700606C RID: 24684
		// (get) Token: 0x0600BFFC RID: 49148 RVA: 0x00B1398C File Offset: 0x00B11B8C
		// (set) Token: 0x0600BFFD RID: 49149 RVA: 0x00B13A40 File Offset: 0x00B11C40
		public bool CnvPerASTROCallASTROCallHotList_A7488_Visible
		{
			get
			{
				short num = (short)1807637491;
				short num2 = num;
				num = (short)1137662963;
				switch (num2 == num)
				{
				}
				num = (short)1736900609;
				if (num != 0)
				{
				}
				num = (short)1522597888;
				if (num != 0)
				{
				}
				num = (short)103088128;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.Visible;
			}
			set
			{
				short num = (short)2089735159;
				short num2 = num;
				num = (short)702141431;
				switch (num2 == num)
				{
				}
				num = (short)1456603137;
				if (num != 0)
				{
				}
				num = (short)610271232;
				if (num != 0)
				{
				}
				num = (short)611516416;
				short num3 = num;
				this.cnvPerASTROCallASTROCallHotList_A7488.Visible = value;
			}
		}

		// Token: 0x1700606D RID: 24685
		// (get) Token: 0x0600BFFE RID: 49150 RVA: 0x00B13AF4 File Offset: 0x00B11CF4
		// (set) Token: 0x0600BFFF RID: 49151 RVA: 0x00B13BA8 File Offset: 0x00B11DA8
		public bool CnvPerASTROCallASTROCallHotList_A7488_Editable
		{
			get
			{
				short num = (short)1708392449;
				if (num != 0)
				{
				}
				num = (short)1207817201;
				short num2 = num;
				num = (short)406180849;
				switch (num2 == num)
				{
				}
				num = (short)1761738752;
				if (num != 0)
				{
				}
				num = (short)2111373312;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.Editable;
			}
			set
			{
				short num = (short)1862778885;
				short num2 = num;
				num = (short)405782533;
				switch (num2 == num)
				{
				}
				num = (short)1192034304;
				if (num != 0)
				{
				}
				num = (short)1064042497;
				if (num != 0)
				{
				}
				num = (short)1364000768;
				short num3 = num;
				this.cnvPerASTROCallASTROCallHotList_A7488.Editable = value;
			}
		}

		// Token: 0x1700606E RID: 24686
		// (get) Token: 0x0600C000 RID: 49152 RVA: 0x00B13C5C File Offset: 0x00B11E5C
		internal string CnvPerASTROCallASTROCallHotList_A7488_UILabel
		{
			get
			{
				short num = (short)1567398544;
				short num2 = num;
				num = (short)960141968;
				switch (num2 == num)
				{
				}
				num = (short)846004224;
				if (num != 0)
				{
				}
				num = (short)631308289;
				if (num != 0)
				{
				}
				num = (short)308150272;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.UIName;
			}
		}

		// Token: 0x1700606F RID: 24687
		// (get) Token: 0x0600C001 RID: 49153 RVA: 0x00B13D10 File Offset: 0x00B11F10
		// (set) Token: 0x0600C002 RID: 49154 RVA: 0x00B13DC4 File Offset: 0x00B11FC4
		internal bool CnvPerASTROCallASTROCallHotList_A7488_HiddenStatic
		{
			get
			{
				short num = (short)1188538804;
				short num2 = num;
				num = (short)1707321780;
				switch (num2 == num)
				{
				}
				num = (short)1976303616;
				if (num != 0)
				{
				}
				num = (short)1528692737;
				if (num != 0)
				{
				}
				num = (short)414973952;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.HiddenStatic;
			}
			set
			{
				short num = (short)1789625579;
				short num2 = num;
				num = (short)81954027;
				switch (num2 == num)
				{
				}
				num = (short)1710555137;
				if (num != 0)
				{
				}
				num = (short)1266417664;
				if (num != 0)
				{
				}
				num = (short)1550581760;
				short num3 = num;
				this.cnvPerASTROCallASTROCallHotList_A7488.HiddenStatic = value;
			}
		}

		// Token: 0x17006070 RID: 24688
		// (get) Token: 0x0600C003 RID: 49155 RVA: 0x00B13E78 File Offset: 0x00B12078
		// (set) Token: 0x0600C004 RID: 49156 RVA: 0x00B13F2C File Offset: 0x00B1212C
		internal bool CnvPerASTROCallASTROCallHotList_A7488_HiddenDynamic
		{
			get
			{
				short num = (short)1887418417;
				short num2 = num;
				num = (short)1398126641;
				switch (num2 == num)
				{
				}
				num = (short)480772097;
				if (num != 0)
				{
				}
				num = (short)586940416;
				if (num != 0)
				{
				}
				num = (short)334495744;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488.HiddenDynamic;
			}
			set
			{
				short num = (short)762088825;
				short num2 = num;
				num = (short)833326457;
				switch (num2 == num)
				{
				}
				num = (short)1429471233;
				if (num != 0)
				{
				}
				num = (short)2026766336;
				if (num != 0)
				{
				}
				num = (short)116129792;
				short num3 = num;
				this.cnvPerASTROCallASTROCallHotList_A7488.HiddenDynamic = value;
			}
		}

		// Token: 0x17006071 RID: 24689
		// (get) Token: 0x0600C005 RID: 49157 RVA: 0x00B13FE0 File Offset: 0x00B121E0
		public bool CnvPerASTROCallASTROCallHotList_A7488_HasDiffs
		{
			get
			{
				short num = (short)653657133;
				short num2 = num;
				num = (short)1680737325;
				switch (num2 == num)
				{
				}
				num = (short)315949057;
				if (num != 0)
				{
				}
				num = (short)85852160;
				if (num != 0)
				{
				}
				num = (short)430374912;
				short num3 = num;
				return this.cnvPerASTROCallASTROCallHotList_A7488._HasDiffs;
			}
		}

		// Token: 0x17006072 RID: 24690
		// (get) Token: 0x0600C006 RID: 49158 RVA: 0x00B14098 File Offset: 0x00B12298
		// (set) Token: 0x0600C007 RID: 49159 RVA: 0x00B1414C File Offset: 0x00B1234C
		public bool CnvPerASTROCallASTROUnlimitedCalling_A7501Value
		{
			get
			{
				short num = (short)574839028;
				short num2 = num;
				num = (short)2141411572;
				switch (num2 == num)
				{
				}
				num = (short)461504512;
				if (num != 0)
				{
				}
				num = (short)1097990145;
				if (num != 0)
				{
				}
				num = (short)2055798784;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Value;
			}
			set
			{
				short num = (short)1084162049;
				if (num != 0)
				{
				}
				num = (short)238574458;
				short num2 = num;
				num = (short)1963678586;
				switch (num2 == num)
				{
				}
				num = (short)1405157376;
				if (num != 0)
				{
				}
				num = (short)1118699520;
				short num3 = num;
				this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Value = value;
			}
		}

		// Token: 0x17006073 RID: 24691
		// (get) Token: 0x0600C008 RID: 49160 RVA: 0x00B14200 File Offset: 0x00B12400
		public global::AcpBusinessLayer.AcpField<bool> CnvPerASTROCallASTROUnlimitedCalling_A7501
		{
			get
			{
				short num = (short)42532865;
				if (num != 0)
				{
				}
				num = (short)296341743;
				short num2 = num;
				num = (short)1220006127;
				switch (num2 == num)
				{
				}
				num = (short)1860763648;
				if (num != 0)
				{
				}
				num = (short)1286406144;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501;
			}
		}

		// Token: 0x17006074 RID: 24692
		// (get) Token: 0x0600C009 RID: 49161 RVA: 0x00B142B0 File Offset: 0x00B124B0
		// (set) Token: 0x0600C00A RID: 49162 RVA: 0x00B14360 File Offset: 0x00B12560
		public bool CnvPerASTROCallASTROUnlimitedCalling_A7501_UIValue
		{
			get
			{
				short num = (short)124837053;
				short num2 = num;
				num = (short)266656957;
				switch (num2 == num)
				{
				}
				num = (short)1189019649;
				if (num != 0)
				{
				}
				num = (short)877133824;
				if (num != 0)
				{
				}
				num = (short)2089877504;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Value;
			}
			set
			{
				short num = (short)807754623;
				short num2 = num;
				num = (short)981752703;
				switch (num2 == num)
				{
				}
				num = (short)2112028673;
				if (num != 0)
				{
				}
				num = (short)1203896320;
				if (num != 0)
				{
				}
				num = (short)1555496960;
				short num3 = num;
				this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Value = value;
			}
		}

		// Token: 0x17006075 RID: 24693
		// (get) Token: 0x0600C00B RID: 49163 RVA: 0x00B14414 File Offset: 0x00B12614
		// (set) Token: 0x0600C00C RID: 49164 RVA: 0x00B144CC File Offset: 0x00B126CC
		public bool CnvPerASTROCallASTROUnlimitedCalling_A7501_Applicable
		{
			get
			{
				short num = (short)787787249;
				short num2 = num;
				num = (short)68857329;
				switch (num2 == num)
				{
				}
				num = (short)737214465;
				if (num != 0)
				{
				}
				num = (short)1979580416;
				if (num != 0)
				{
				}
				num = (short)465043456;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Applicable;
			}
			set
			{
				short num = (short)854161572;
				short num2 = num;
				num = (short)1734244516;
				switch (num2 == num)
				{
				}
				num = (short)965148672;
				if (num != 0)
				{
				}
				num = (short)1788936193;
				if (num != 0)
				{
				}
				num = (short)1897070592;
				short num3 = num;
				this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Applicable = value;
			}
		}

		// Token: 0x17006076 RID: 24694
		// (get) Token: 0x0600C00D RID: 49165 RVA: 0x00B14580 File Offset: 0x00B12780
		// (set) Token: 0x0600C00E RID: 49166 RVA: 0x00B14638 File Offset: 0x00B12838
		public bool CnvPerASTROCallASTROUnlimitedCalling_A7501_Valid
		{
			get
			{
				short num = (short)160833911;
				short num2 = num;
				num = (short)449323383;
				switch (num2 == num)
				{
				}
				num = (short)651689984;
				if (num != 0)
				{
				}
				num = (short)269549569;
				if (num != 0)
				{
				}
				num = (short)1733492736;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Valid;
			}
			set
			{
				short num = (short)1345768937;
				short num2 = num;
				num = (short)1089261033;
				switch (num2 == num)
				{
				}
				num = (short)906166273;
				if (num != 0)
				{
				}
				num = (short)1919811584;
				if (num != 0)
				{
				}
				num = (short)1022033920;
				short num3 = num;
				this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Valid = value;
			}
		}

		// Token: 0x17006077 RID: 24695
		// (get) Token: 0x0600C00F RID: 49167 RVA: 0x00B146EC File Offset: 0x00B128EC
		// (set) Token: 0x0600C010 RID: 49168 RVA: 0x00B147A0 File Offset: 0x00B129A0
		public bool CnvPerASTROCallASTROUnlimitedCalling_A7501_Visible
		{
			get
			{
				short num = (short)1099259206;
				short num2 = num;
				num = (short)1180654918;
				switch (num2 == num)
				{
				}
				num = (short)1296171009;
				if (num != 0)
				{
				}
				num = (short)986578944;
				if (num != 0)
				{
				}
				num = (short)1817706496;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Visible;
			}
			set
			{
				short num = (short)1132055995;
				short num2 = num;
				num = (short)662818235;
				switch (num2 == num)
				{
				}
				num = (short)1607139329;
				if (num != 0)
				{
				}
				num = (short)349372416;
				if (num != 0)
				{
				}
				num = (short)1368915968;
				short num3 = num;
				this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Visible = value;
			}
		}

		// Token: 0x17006078 RID: 24696
		// (get) Token: 0x0600C011 RID: 49169 RVA: 0x00B14858 File Offset: 0x00B12A58
		// (set) Token: 0x0600C012 RID: 49170 RVA: 0x00B1490C File Offset: 0x00B12B0C
		public bool CnvPerASTROCallASTROUnlimitedCalling_A7501_Editable
		{
			get
			{
				short num = (short)1837720044;
				short num2 = num;
				num = (short)257909228;
				switch (num2 == num)
				{
				}
				num = (short)949354496;
				if (num != 0)
				{
				}
				num = (short)1350696961;
				if (num != 0)
				{
				}
				num = (short)1260322816;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Editable;
			}
			set
			{
				short num = (short)472513287;
				short num2 = num;
				num = (short)2120743687;
				switch (num2 == num)
				{
				}
				num = (short)1864630273;
				if (num != 0)
				{
				}
				num = (short)1533280256;
				if (num != 0)
				{
				}
				num = (short)1232732160;
				short num3 = num;
				this.cnvPerASTROCallASTROUnlimitedCalling_A7501.Editable = value;
			}
		}

		// Token: 0x17006079 RID: 24697
		// (get) Token: 0x0600C013 RID: 49171 RVA: 0x00B149C0 File Offset: 0x00B12BC0
		internal string CnvPerASTROCallASTROUnlimitedCalling_A7501_UILabel
		{
			get
			{
				short num = (short)16384001;
				if (num != 0)
				{
				}
				num = (short)1480156149;
				short num2 = num;
				num = (short)563504117;
				switch (num2 == num)
				{
				}
				num = (short)359137280;
				if (num != 0)
				{
				}
				num = (short)1373569024;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.UIName;
			}
		}

		// Token: 0x1700607A RID: 24698
		// (get) Token: 0x0600C014 RID: 49172 RVA: 0x00B14A74 File Offset: 0x00B12C74
		// (set) Token: 0x0600C015 RID: 49173 RVA: 0x00B14B2C File Offset: 0x00B12D2C
		internal bool CnvPerASTROCallASTROUnlimitedCalling_A7501_HiddenStatic
		{
			get
			{
				short num = (short)1911917200;
				short num2 = num;
				num = (short)364546704;
				switch (num2 == num)
				{
				}
				num = (short)694026241;
				if (num != 0)
				{
				}
				num = (short)438173696;
				if (num != 0)
				{
				}
				num = (short)481558528;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.HiddenStatic;
			}
			set
			{
				short num = (short)1076663855;
				short num2 = num;
				num = (short)2067174959;
				switch (num2 == num)
				{
				}
				num = (short)2094268417;
				if (num != 0)
				{
				}
				num = (short)623902720;
				if (num != 0)
				{
				}
				num = (short)651427840;
				short num3 = num;
				this.cnvPerASTROCallASTROUnlimitedCalling_A7501.HiddenStatic = value;
			}
		}

		// Token: 0x1700607B RID: 24699
		// (get) Token: 0x0600C016 RID: 49174 RVA: 0x00B14BE4 File Offset: 0x00B12DE4
		// (set) Token: 0x0600C017 RID: 49175 RVA: 0x00B14C94 File Offset: 0x00B12E94
		internal bool CnvPerASTROCallASTROUnlimitedCalling_A7501_HiddenDynamic
		{
			get
			{
				short num = (short)959512577;
				if (num != 0)
				{
				}
				num = (short)264138744;
				short num2 = num;
				num = (short)1409839096;
				switch (num2 == num)
				{
				}
				num = (short)1271136256;
				if (num != 0)
				{
				}
				num = (short)1038286848;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501.HiddenDynamic;
			}
			set
			{
				short num = (short)573181810;
				short num2 = num;
				num = (short)1657999218;
				switch (num2 == num)
				{
				}
				num = (short)872284161;
				if (num != 0)
				{
				}
				num = (short)501219328;
				if (num != 0)
				{
				}
				num = (short)1990852608;
				short num3 = num;
				this.cnvPerASTROCallASTROUnlimitedCalling_A7501.HiddenDynamic = value;
			}
		}

		// Token: 0x1700607C RID: 24700
		// (get) Token: 0x0600C018 RID: 49176 RVA: 0x00B14D48 File Offset: 0x00B12F48
		public bool CnvPerASTROCallASTROUnlimitedCalling_A7501_HasDiffs
		{
			get
			{
				short num = (short)1937598098;
				short num2 = num;
				num = (short)1445357202;
				switch (num2 == num)
				{
				}
				num = (short)1354760193;
				if (num != 0)
				{
				}
				num = (short)639565824;
				if (num != 0)
				{
				}
				num = (short)1296367616;
				short num3 = num;
				return this.cnvPerASTROCallASTROUnlimitedCalling_A7501._HasDiffs;
			}
		}

		// Token: 0x1700607D RID: 24701
		// (get) Token: 0x0600C019 RID: 49177 RVA: 0x00B14E00 File Offset: 0x00B13000
		// (set) Token: 0x0600C01A RID: 49178 RVA: 0x00B14EB4 File Offset: 0x00B130B4
		public bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518Value
		{
			get
			{
				short num = (short)1210271401;
				short num2 = num;
				num = (short)269567657;
				switch (num2 == num)
				{
				}
				num = (short)986841089;
				if (num != 0)
				{
				}
				num = (short)1275002880;
				if (num != 0)
				{
				}
				num = (short)1540489216;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Value;
			}
			set
			{
				short num = (short)281845638;
				short num2 = num;
				num = (short)381853574;
				switch (num2 == num)
				{
				}
				num = (short)128122881;
				if (num != 0)
				{
				}
				num = (short)1925447680;
				if (num != 0)
				{
				}
				num = (short)2058616832;
				short num3 = num;
				this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Value = value;
			}
		}

		// Token: 0x1700607E RID: 24702
		// (get) Token: 0x0600C01B RID: 49179 RVA: 0x00B14F68 File Offset: 0x00B13168
		public global::AcpBusinessLayer.AcpField<bool> CnvPerASTROCallAutoSelectiveCallTransmit_A7518
		{
			get
			{
				short num = (short)152724301;
				short num2 = num;
				num = (short)652239693;
				switch (num2 == num)
				{
				}
				num = (short)679215105;
				if (num != 0)
				{
				}
				num = (short)304939008;
				if (num != 0)
				{
				}
				num = (short)1384316928;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518;
			}
		}

		// Token: 0x1700607F RID: 24703
		// (get) Token: 0x0600C01C RID: 49180 RVA: 0x00B15018 File Offset: 0x00B13218
		// (set) Token: 0x0600C01D RID: 49181 RVA: 0x00B150C8 File Offset: 0x00B132C8
		public bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518_UIValue
		{
			get
			{
				short num = (short)616117653;
				short num2 = num;
				num = (short)756757909;
				switch (num2 == num)
				{
				}
				num = (short)1832386561;
				if (num != 0)
				{
				}
				num = (short)565444608;
				if (num != 0)
				{
				}
				num = (short)426377216;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Value;
			}
			set
			{
				short num = (short)2077239467;
				short num2 = num;
				num = (short)1089349803;
				switch (num2 == num)
				{
				}
				num = (short)1476591617;
				if (num != 0)
				{
				}
				num = (short)1222770688;
				if (num != 0)
				{
				}
				num = (short)1612972032;
				short num3 = num;
				this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Value = value;
			}
		}

		// Token: 0x17006080 RID: 24704
		// (get) Token: 0x0600C01E RID: 49182 RVA: 0x00B15180 File Offset: 0x00B13380
		// (set) Token: 0x0600C01F RID: 49183 RVA: 0x00B15234 File Offset: 0x00B13434
		public bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518_Applicable
		{
			get
			{
				short num = (short)477646861;
				short num2 = num;
				num = (short)1596411917;
				switch (num2 == num)
				{
				}
				num = (short)1662976000;
				if (num != 0)
				{
				}
				num = (short)801177601;
				if (num != 0)
				{
				}
				num = (short)2025652224;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Applicable;
			}
			set
			{
				short num = (short)715297746;
				short num2 = num;
				num = (short)2101777362;
				switch (num2 == num)
				{
				}
				num = (short)69271552;
				if (num != 0)
				{
				}
				num = (short)1410138113;
				if (num != 0)
				{
				}
				num = (short)2059075584;
				short num3 = num;
				this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Applicable = value;
			}
		}

		// Token: 0x17006081 RID: 24705
		// (get) Token: 0x0600C020 RID: 49184 RVA: 0x00B152EC File Offset: 0x00B134EC
		// (set) Token: 0x0600C021 RID: 49185 RVA: 0x00B153A4 File Offset: 0x00B135A4
		public bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518_Valid
		{
			get
			{
				short num = (short)1968594619;
				short num2 = num;
				num = (short)266428091;
				switch (num2 == num)
				{
				}
				num = (short)350093313;
				if (num != 0)
				{
				}
				num = (short)1292500992;
				if (num != 0)
				{
				}
				num = (short)50921472;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Valid;
			}
			set
			{
				short num = (short)473366529;
				if (num != 0)
				{
				}
				num = (short)1990590691;
				short num2 = num;
				num = (short)1019478243;
				switch (num2 == num)
				{
				}
				num = (short)178651136;
				if (num != 0)
				{
				}
				num = (short)307167232;
				short num3 = num;
				this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Valid = value;
			}
		}

		// Token: 0x17006082 RID: 24706
		// (get) Token: 0x0600C022 RID: 49186 RVA: 0x00B1545C File Offset: 0x00B1365C
		// (set) Token: 0x0600C023 RID: 49187 RVA: 0x00B15510 File Offset: 0x00B13710
		public bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518_Visible
		{
			get
			{
				short num = (short)137778781;
				short num2 = num;
				num = (short)273765981;
				switch (num2 == num)
				{
				}
				num = (short)1197932545;
				if (num != 0)
				{
				}
				num = (short)559742976;
				if (num != 0)
				{
				}
				num = (short)1437401088;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Visible;
			}
			set
			{
				short num = (short)472319326;
				short num2 = num;
				num = (short)147588446;
				switch (num2 == num)
				{
				}
				num = (short)951517185;
				if (num != 0)
				{
				}
				num = (short)36306944;
				if (num != 0)
				{
				}
				num = (short)1740898304;
				short num3 = num;
				this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Visible = value;
			}
		}

		// Token: 0x17006083 RID: 24707
		// (get) Token: 0x0600C024 RID: 49188 RVA: 0x00B155C4 File Offset: 0x00B137C4
		// (set) Token: 0x0600C025 RID: 49189 RVA: 0x00B15678 File Offset: 0x00B13878
		public bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518_Editable
		{
			get
			{
				short num = (short)2085828299;
				short num2 = num;
				num = (short)1356412619;
				switch (num2 == num)
				{
				}
				num = (short)449904641;
				if (num != 0)
				{
				}
				num = (short)1219035136;
				if (num != 0)
				{
				}
				num = (short)1776025600;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Editable;
			}
			set
			{
				short num = (short)889315326;
				short num2 = num;
				num = (short)1277616126;
				switch (num2 == num)
				{
				}
				num = (short)788004864;
				if (num != 0)
				{
				}
				num = (short)840105985;
				if (num != 0)
				{
				}
				num = (short)2147024896;
				short num3 = num;
				this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.Editable = value;
			}
		}

		// Token: 0x17006084 RID: 24708
		// (get) Token: 0x0600C026 RID: 49190 RVA: 0x00B15730 File Offset: 0x00B13930
		internal string CnvPerASTROCallAutoSelectiveCallTransmit_A7518_UILabel
		{
			get
			{
				short num = (short)1708369998;
				short num2 = num;
				num = (short)1693558862;
				switch (num2 == num)
				{
				}
				num = (short)1697710081;
				if (num != 0)
				{
				}
				num = (short)1879244800;
				if (num != 0)
				{
				}
				num = (short)476446720;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.UIName;
			}
		}

		// Token: 0x17006085 RID: 24709
		// (get) Token: 0x0600C027 RID: 49191 RVA: 0x00B157E4 File Offset: 0x00B139E4
		// (set) Token: 0x0600C028 RID: 49192 RVA: 0x00B1589C File Offset: 0x00B13A9C
		internal bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518_HiddenStatic
		{
			get
			{
				short num = (short)70613905;
				short num2 = num;
				num = (short)613317521;
				switch (num2 == num)
				{
				}
				num = (short)958398465;
				if (num != 0)
				{
				}
				num = (short)521863168;
				if (num != 0)
				{
				}
				num = (short)1912143872;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.HiddenStatic;
			}
			set
			{
				short num = (short)22078200;
				short num2 = num;
				num = (short)1226236664;
				switch (num2 == num)
				{
				}
				num = (short)954728448;
				if (num != 0)
				{
				}
				num = (short)1169555457;
				if (num != 0)
				{
				}
				num = (short)1988296704;
				short num3 = num;
				this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.HiddenStatic = value;
			}
		}

		// Token: 0x17006086 RID: 24710
		// (get) Token: 0x0600C029 RID: 49193 RVA: 0x00B15950 File Offset: 0x00B13B50
		// (set) Token: 0x0600C02A RID: 49194 RVA: 0x00B15A04 File Offset: 0x00B13C04
		internal bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518_HiddenDynamic
		{
			get
			{
				short num = (short)1980377792;
				short num2 = num;
				num = (short)38283968;
				switch (num2 == num)
				{
				}
				num = (short)1296105473;
				if (num != 0)
				{
				}
				num = (short)1992949760;
				if (num != 0)
				{
				}
				num = (short)2883584;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.HiddenDynamic;
			}
			set
			{
				short num = (short)1108943768;
				short num2 = num;
				num = (short)1756898200;
				switch (num2 == num)
				{
				}
				num = (short)364576769;
				if (num != 0)
				{
				}
				num = (short)1218969600;
				if (num != 0)
				{
				}
				num = (short)1679097856;
				short num3 = num;
				this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518.HiddenDynamic = value;
			}
		}

		// Token: 0x17006087 RID: 24711
		// (get) Token: 0x0600C02B RID: 49195 RVA: 0x00B15ABC File Offset: 0x00B13CBC
		public bool CnvPerASTROCallAutoSelectiveCallTransmit_A7518_HasDiffs
		{
			get
			{
				short num = (short)1451549746;
				short num2 = num;
				num = (short)856876082;
				switch (num2 == num)
				{
				}
				num = (short)1060438017;
				if (num != 0)
				{
				}
				num = (short)750714880;
				if (num != 0)
				{
				}
				num = (short)795279360;
				short num3 = num;
				return this.cnvPerASTROCallAutoSelectiveCallTransmit_A7518._HasDiffs;
			}
		}

		// Token: 0x17006088 RID: 24712
		// (get) Token: 0x0600C02C RID: 49196 RVA: 0x00B15B70 File Offset: 0x00B13D70
		// (set) Token: 0x0600C02D RID: 49197 RVA: 0x00B15C28 File Offset: 0x00B13E28
		public int CnvPerASTROCallCallAlertRxTx_A7586Value
		{
			get
			{
				short num = (short)1905266269;
				short num2 = num;
				num = (short)1678642781;
				switch (num2 == num)
				{
				}
				num = (short)1699807233;
				if (num != 0)
				{
				}
				num = (short)1338900480;
				if (num != 0)
				{
				}
				num = (short)1248395264;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.Value;
			}
			set
			{
				short num = (short)96946575;
				short num2 = num;
				num = (short)1007045007;
				switch (num2 == num)
				{
				}
				num = (short)1486094337;
				if (num != 0)
				{
				}
				num = (short)270925824;
				if (num != 0)
				{
				}
				num = (short)2108817408;
				short num3 = num;
				this.cnvPerASTROCallCallAlertRxTx_A7586.Value = value;
			}
		}

		// Token: 0x17006089 RID: 24713
		// (get) Token: 0x0600C02E RID: 49198 RVA: 0x00B15CDC File Offset: 0x00B13EDC
		// (set) Token: 0x0600C02F RID: 49199 RVA: 0x00B15D90 File Offset: 0x00B13F90
		public string CnvPerASTROCallCallAlertRxTx_A7586_UIValue
		{
			get
			{
				short num = (short)497594824;
				short num2 = num;
				num = (short)1847046600;
				switch (num2 == num)
				{
				}
				num = (short)18808833;
				if (num != 0)
				{
				}
				num = (short)1838874624;
				if (num != 0)
				{
				}
				num = (short)1980891136;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.UIValue;
			}
			set
			{
				short num = (short)1447755777;
				if (num != 0)
				{
				}
				num = (short)759191940;
				short num2 = num;
				num = (short)1255954820;
				switch (num2 == num)
				{
				}
				num = (short)357892096;
				if (num != 0)
				{
				}
				num = (short)1165426688;
				short num3 = num;
				this.cnvPerASTROCallCallAlertRxTx_A7586.UIValue = value;
			}
		}

		// Token: 0x1700608A RID: 24714
		// (get) Token: 0x0600C030 RID: 49200 RVA: 0x00B15E44 File Offset: 0x00B14044
		public global::AcpBusinessLayer.AcpListField CnvPerASTROCallCallAlertRxTx_A7586
		{
			get
			{
				short num = (short)1523873908;
				short num2 = num;
				num = (short)764835956;
				switch (num2 == num)
				{
				}
				num = (short)1461256193;
				if (num != 0)
				{
				}
				num = (short)899219456;
				if (num != 0)
				{
				}
				num = (short)1821966336;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586;
			}
		}

		// Token: 0x1700608B RID: 24715
		// (get) Token: 0x0600C031 RID: 49201 RVA: 0x00B15EF4 File Offset: 0x00B140F4
		// (set) Token: 0x0600C032 RID: 49202 RVA: 0x00B15FA8 File Offset: 0x00B141A8
		public bool CnvPerASTROCallCallAlertRxTx_A7586_Applicable
		{
			get
			{
				short num = (short)1829487750;
				short num2 = num;
				num = (short)2095498374;
				switch (num2 == num)
				{
				}
				num = (short)2107965441;
				if (num != 0)
				{
				}
				num = (short)1138294784;
				if (num != 0)
				{
				}
				num = (short)1866661888;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.Applicable;
			}
			set
			{
				short num = (short)801767425;
				if (num != 0)
				{
				}
				num = (short)1147835748;
				short num2 = num;
				num = (short)1397265764;
				switch (num2 == num)
				{
				}
				num = (short)1476067328;
				if (num != 0)
				{
				}
				num = (short)1879113728;
				short num3 = num;
				this.cnvPerASTROCallCallAlertRxTx_A7586.Applicable = value;
			}
		}

		// Token: 0x1700608C RID: 24716
		// (get) Token: 0x0600C033 RID: 49203 RVA: 0x00B1605C File Offset: 0x00B1425C
		// (set) Token: 0x0600C034 RID: 49204 RVA: 0x00B16110 File Offset: 0x00B14310
		public bool CnvPerASTROCallCallAlertRxTx_A7586_Valid
		{
			get
			{
				short num = (short)2014247431;
				short num2 = num;
				num = (short)954726919;
				switch (num2 == num)
				{
				}
				num = (short)670433281;
				if (num != 0)
				{
				}
				num = (short)1591869440;
				if (num != 0)
				{
				}
				num = (short)121241600;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.Valid;
			}
			set
			{
				short num = (short)272947440;
				short num2 = num;
				num = (short)2111363312;
				switch (num2 == num)
				{
				}
				num = (short)1108934656;
				if (num != 0)
				{
				}
				num = (short)199098369;
				if (num != 0)
				{
				}
				num = (short)650051584;
				short num3 = num;
				this.cnvPerASTROCallCallAlertRxTx_A7586.Valid = value;
			}
		}

		// Token: 0x1700608D RID: 24717
		// (get) Token: 0x0600C035 RID: 49205 RVA: 0x00B161C4 File Offset: 0x00B143C4
		// (set) Token: 0x0600C036 RID: 49206 RVA: 0x00B1627C File Offset: 0x00B1447C
		public bool CnvPerASTROCallCallAlertRxTx_A7586_Visible
		{
			get
			{
				short num = (short)1868103681;
				if (num != 0)
				{
				}
				num = (short)972713979;
				short num2 = num;
				num = (short)1036283899;
				switch (num2 == num)
				{
				}
				num = (short)723714048;
				if (num != 0)
				{
				}
				num = (short)531628032;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.Visible;
			}
			set
			{
				short num = (short)1514812789;
				short num2 = num;
				num = (short)1170879861;
				switch (num2 == num)
				{
				}
				num = (short)799932417;
				if (num != 0)
				{
				}
				num = (short)508428288;
				if (num != 0)
				{
				}
				num = (short)264830976;
				short num3 = num;
				this.cnvPerASTROCallCallAlertRxTx_A7586.Visible = value;
			}
		}

		// Token: 0x1700608E RID: 24718
		// (get) Token: 0x0600C037 RID: 49207 RVA: 0x00B16334 File Offset: 0x00B14534
		// (set) Token: 0x0600C038 RID: 49208 RVA: 0x00B163E8 File Offset: 0x00B145E8
		public bool CnvPerASTROCallCallAlertRxTx_A7586_Editable
		{
			get
			{
				short num = (short)540607584;
				short num2 = num;
				num = (short)267977824;
				switch (num2 == num)
				{
				}
				num = (short)335478785;
				if (num != 0)
				{
				}
				num = (short)651755520;
				if (num != 0)
				{
				}
				num = (short)610402304;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.Editable;
			}
			set
			{
				short num = (short)1788099004;
				short num2 = num;
				num = (short)1822177724;
				switch (num2 == num)
				{
				}
				num = (short)182386688;
				if (num != 0)
				{
				}
				num = (short)3801089;
				if (num != 0)
				{
				}
				num = (short)463929344;
				short num3 = num;
				this.cnvPerASTROCallCallAlertRxTx_A7586.Editable = value;
			}
		}

		// Token: 0x1700608F RID: 24719
		// (get) Token: 0x0600C039 RID: 49209 RVA: 0x00B1649C File Offset: 0x00B1469C
		internal string CnvPerASTROCallCallAlertRxTx_A7586_UILabel
		{
			get
			{
				short num = (short)270824825;
				short num2 = num;
				num = (short)422212985;
				switch (num2 == num)
				{
				}
				num = (short)752812033;
				if (num != 0)
				{
				}
				num = (short)435224576;
				if (num != 0)
				{
				}
				num = (short)1775304704;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.UIName;
			}
		}

		// Token: 0x17006090 RID: 24720
		// (get) Token: 0x0600C03A RID: 49210 RVA: 0x00B16550 File Offset: 0x00B14750
		// (set) Token: 0x0600C03B RID: 49211 RVA: 0x00B16604 File Offset: 0x00B14804
		internal bool CnvPerASTROCallCallAlertRxTx_A7586_HiddenStatic
		{
			get
			{
				short num = (short)1453085087;
				short num2 = num;
				num = (short)380719519;
				switch (num2 == num)
				{
				}
				num = (short)304087040;
				if (num != 0)
				{
				}
				num = (short)777519105;
				if (num != 0)
				{
				}
				num = (short)837222400;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.HiddenStatic;
			}
			set
			{
				short num = (short)1573847041;
				if (num != 0)
				{
				}
				num = (short)1812022992;
				short num2 = num;
				num = (short)760891088;
				switch (num2 == num)
				{
				}
				num = (short)409600000;
				if (num != 0)
				{
				}
				num = (short)415432704;
				short num3 = num;
				this.cnvPerASTROCallCallAlertRxTx_A7586.HiddenStatic = value;
			}
		}

		// Token: 0x17006091 RID: 24721
		// (get) Token: 0x0600C03C RID: 49212 RVA: 0x00B166B8 File Offset: 0x00B148B8
		// (set) Token: 0x0600C03D RID: 49213 RVA: 0x00B16770 File Offset: 0x00B14970
		internal bool CnvPerASTROCallCallAlertRxTx_A7586_HiddenDynamic
		{
			get
			{
				short num = (short)1453326337;
				if (num != 0)
				{
				}
				num = (short)599876774;
				short num2 = num;
				num = (short)804086950;
				switch (num2 == num)
				{
				}
				num = (short)194707456;
				if (num != 0)
				{
				}
				num = (short)143458304;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586.HiddenDynamic;
			}
			set
			{
				short num = (short)1335686567;
				short num2 = num;
				num = (short)1783362983;
				switch (num2 == num)
				{
				}
				num = (short)195887105;
				if (num != 0)
				{
				}
				num = (short)544866304;
				if (num != 0)
				{
				}
				num = (short)1507852288;
				short num3 = num;
				this.cnvPerASTROCallCallAlertRxTx_A7586.HiddenDynamic = value;
			}
		}

		// Token: 0x17006092 RID: 24722
		// (get) Token: 0x0600C03E RID: 49214 RVA: 0x00B16828 File Offset: 0x00B14A28
		public bool CnvPerASTROCallCallAlertRxTx_A7586_HasDiffs
		{
			get
			{
				short num = (short)485303780;
				short num2 = num;
				num = (short)1650861540;
				switch (num2 == num)
				{
				}
				num = (short)2084241409;
				if (num != 0)
				{
				}
				num = (short)1336672256;
				if (num != 0)
				{
				}
				num = (short)1270087680;
				short num3 = num;
				return this.cnvPerASTROCallCallAlertRxTx_A7586._HasDiffs;
			}
		}

		// Token: 0x17006093 RID: 24723
		// (get) Token: 0x0600C03F RID: 49215 RVA: 0x00B168DC File Offset: 0x00B14ADC
		// (set) Token: 0x0600C040 RID: 49216 RVA: 0x00B16990 File Offset: 0x00B14B90
		public bool CnvPerASTROCallInCallUserAlertEnable_A8250Value
		{
			get
			{
				short num = (short)525117508;
				short num2 = num;
				num = (short)388278340;
				switch (num2 == num)
				{
				}
				num = (short)1019412481;
				if (num != 0)
				{
				}
				num = (short)469499904;
				if (num != 0)
				{
				}
				num = (short)758448128;
				short num3 = num;
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.Value;
			}
			set
			{
				short num = (short)1265470639;
				short num2 = num;
				num = (short)1301187759;
				switch (num2 == num)
				{
				}
				num = (short)1686831105;
				if (num != 0)
				{
				}
				num = (short)549584896;
				if (num != 0)
				{
				}
				num = (short)664666112;
				short num3 = num;
				this.cnvPerASTROCallInCallUserAlertEnable_A8250.Value = value;
			}
		}

		// Token: 0x17006094 RID: 24724
		// (get) Token: 0x0600C041 RID: 49217 RVA: 0x00B16A44 File Offset: 0x00B14C44
		public global::AcpBusinessLayer.AcpField<bool> CnvPerASTROCallInCallUserAlertEnable_A8250
		{
			get
			{
				short num = (short)567723949;
				short num2 = num;
				num = (short)630048685;
				switch (num2 == num)
				{
				}
				num = (short)770637824;
				if (num != 0)
				{
				}
				num = (short)1678311425;
				if (num != 0)
				{
				}
				num = (short)1187381248;
				short num3 = num;
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250;
			}
		}

		// Token: 0x17006095 RID: 24725
		// (get) Token: 0x0600C042 RID: 49218 RVA: 0x00B16AF8 File Offset: 0x00B14CF8
		// (set) Token: 0x0600C043 RID: 49219 RVA: 0x00B16BAC File Offset: 0x00B14DAC
		public bool CnvPerASTROCallInCallUserAlertEnable_A8250_UIValue
		{
			get
			{
				short num = (short)503598902;
				short num2 = num;
				num = (short)1510887222;
				switch (num2 == num)
				{
				}
				num = (short)1407320064;
				if (num != 0)
				{
				}
				num = (short)1930166273;
				if (num != 0)
				{
				}
				num = (short)31391744;
				short num3 = num;
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.Value;
			}
			set
			{
				short num = (short)903772097;
				short num2 = num;
				num = (short)499873729;
				switch (num2 == num)
				{
				}
				num = (short)657522688;
				if (num != 0)
				{
				}
				num = (short)1721499649;
				if (num != 0)
				{
				}
				num = (short)327680;
				short num3 = num;
				this.cnvPerASTROCallInCallUserAlertEnable_A8250.Value = value;
			}
		}

		// Token: 0x17006096 RID: 24726
		// (get) Token: 0x0600C044 RID: 49220 RVA: 0x00B16C64 File Offset: 0x00B14E64
		// (set) Token: 0x0600C045 RID: 49221 RVA: 0x00B16D18 File Offset: 0x00B14F18
		public bool CnvPerASTROCallInCallUserAlertEnable_A8250_Applicable
		{
			get
			{
				short num = (short)1244711706;
				short num2 = num;
				num = (short)1873333018;
				switch (num2 == num)
				{
				}
				num = (short)1758527489;
				if (num != 0)
				{
				}
				num = (short)1255538688;
				if (num != 0)
				{
				}
				num = (short)478609408;
				short num3 = num;
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.Applicable;
			}
			set
			{
				short num = (short)703383690;
				short num2 = num;
				num = (short)903727242;
				switch (num2 == num)
				{
				}
				num = (short)1767899137;
				if (num != 0)
				{
				}
				num = (short)1956577280;
				if (num != 0)
				{
				}
				num = (short)918683648;
				short num3 = num;
				this.cnvPerASTROCallInCallUserAlertEnable_A8250.Applicable = value;
			}
		}

		// Token: 0x17006097 RID: 24727
		// (get) Token: 0x0600C046 RID: 49222 RVA: 0x00B16DD0 File Offset: 0x00B14FD0
		// (set) Token: 0x0600C047 RID: 49223 RVA: 0x00B16E84 File Offset: 0x00B15084
		public bool CnvPerASTROCallInCallUserAlertEnable_A8250_Valid
		{
			get
			{
				short num = (short)1259087483;
				short num2 = num;
				num = (short)2106599035;
				switch (num2 == num)
				{
				}
				num = (short)33751040;
				if (num != 0)
				{
				}
				num = (short)2052587521;
				if (num != 0)
				{
				}
				num = (short)1483079680;
				short num3 = num;
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.Valid;
			}
			set
			{
				short num = (short)1511058876;
				short num2 = num;
				num = (short)116321724;
				switch (num2 == num)
				{
				}
				num = (short)758579201;
				if (num != 0)
				{
				}
				num = (short)445186048;
				if (num != 0)
				{
				}
				num = (short)545914880;
				short num3 = num;
				this.cnvPerASTROCallInCallUserAlertEnable_A8250.Valid = value;
			}
		}

		// Token: 0x17006098 RID: 24728
		// (get) Token: 0x0600C048 RID: 49224 RVA: 0x00B16F3C File Offset: 0x00B1513C
		// (set) Token: 0x0600C049 RID: 49225 RVA: 0x00B16FF0 File Offset: 0x00B151F0
		public bool CnvPerASTROCallInCallUserAlertEnable_A8250_Visible
		{
			get
			{
				short num = (short)1030928797;
				short num2 = num;
				num = (short)1503115677;
				switch (num2 == num)
				{
				}
				num = (short)1950613504;
				if (num != 0)
				{
				}
				num = (short)204603393;
				if (num != 0)
				{
				}
				num = (short)99680256;
				short num3 = num;
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.Visible;
			}
			set
			{
				short num = (short)483917825;
				if (num != 0)
				{
				}
				num = (short)2099543925;
				short num2 = num;
				num = (short)1855160181;
				switch (num2 == num)
				{
				}
				num = (short)1834745856;
				if (num != 0)
				{
				}
				num = (short)1622540288;
				short num3 = num;
				this.cnvPerASTROCallInCallUserAlertEnable_A8250.Visible = value;
			}
		}

		// Token: 0x17006099 RID: 24729
		// (get) Token: 0x0600C04A RID: 49226 RVA: 0x00B170A4 File Offset: 0x00B152A4
		// (set) Token: 0x0600C04B RID: 49227 RVA: 0x00B17158 File Offset: 0x00B15358
		public bool CnvPerASTROCallInCallUserAlertEnable_A8250_Editable
		{
			get
			{
				short num = (short)874545405;
				short num2 = num;
				num = (short)1486061821;
				switch (num2 == num)
				{
				}
				num = (short)1054081025;
				if (num != 0)
				{
				}
				num = (short)1933705216;
				if (num != 0)
				{
				}
				num = (short)338493440;
				short num3 = num;
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.Editable;
			}
			set
			{
				short num = (short)1095499776;
				short num2 = num;
				num = (short)1813864399;
				short num3 = num;
				num = (short)494755791;
				switch (num3 == num)
				{
				}
				num = (short)31653888;
				if (num != 0)
				{
				}
				num = (short)619118593;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallInCallUserAlertEnable_A8250.Editable = value;
			}
		}

		// Token: 0x1700609A RID: 24730
		// (get) Token: 0x0600C04C RID: 49228 RVA: 0x00B1720C File Offset: 0x00B1540C
		internal string CnvPerASTROCallInCallUserAlertEnable_A8250_UILabel
		{
			get
			{
				short num = (short)671875072;
				short num2 = num;
				num = (short)581268118;
				short num3 = num;
				num = (short)642216598;
				switch (num3 == num)
				{
				}
				num = (short)1632174080;
				if (num != 0)
				{
				}
				num = (short)1495334913;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.UIName;
			}
		}

		// Token: 0x1700609B RID: 24731
		// (get) Token: 0x0600C04D RID: 49229 RVA: 0x00B172C4 File Offset: 0x00B154C4
		// (set) Token: 0x0600C04E RID: 49230 RVA: 0x00B17378 File Offset: 0x00B15578
		internal bool CnvPerASTROCallInCallUserAlertEnable_A8250_HiddenStatic
		{
			get
			{
				short num = (short)1320157184;
				short num2 = num;
				num = (short)567380933;
				short num3 = num;
				num = (short)488147909;
				switch (num3 == num)
				{
				}
				num = (short)1044840449;
				if (num != 0)
				{
				}
				num = (short)522649600;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.HiddenStatic;
			}
			set
			{
				short num = (short)464584704;
				short num2 = num;
				num = (short)229572884;
				short num3 = num;
				num = (short)124322068;
				switch (num3 == num)
				{
				}
				num = (short)633208833;
				if (num != 0)
				{
				}
				num = (short)633929728;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallInCallUserAlertEnable_A8250.HiddenStatic = value;
			}
		}

		// Token: 0x1700609C RID: 24732
		// (get) Token: 0x0600C04F RID: 49231 RVA: 0x00B17430 File Offset: 0x00B15630
		// (set) Token: 0x0600C050 RID: 49232 RVA: 0x00B174E4 File Offset: 0x00B156E4
		internal bool CnvPerASTROCallInCallUserAlertEnable_A8250_HiddenDynamic
		{
			get
			{
				short num = (short)683868160;
				short num2 = num;
				num = (short)972299523;
				short num3 = num;
				num = (short)327752963;
				switch (num3 == num)
				{
				}
				num = (short)1545994240;
				if (num != 0)
				{
				}
				num = (short)331612161;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250.HiddenDynamic;
			}
			set
			{
				short num = (short)1464532992;
				short num2 = num;
				num = (short)314938593;
				short num3 = num;
				num = (short)257266913;
				switch (num3 == num)
				{
				}
				num = (short)246808576;
				if (num != 0)
				{
				}
				num = (short)1544290305;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallInCallUserAlertEnable_A8250.HiddenDynamic = value;
			}
		}

		// Token: 0x1700609D RID: 24733
		// (get) Token: 0x0600C051 RID: 49233 RVA: 0x00B17598 File Offset: 0x00B15798
		public bool CnvPerASTROCallInCallUserAlertEnable_A8250_HasDiffs
		{
			get
			{
				short num = (short)1078132736;
				short num2 = num;
				num = (short)1265583617;
				short num3 = num;
				num = (short)132466177;
				switch (num3 == num)
				{
				}
				num = (short)893976577;
				if (num != 0)
				{
				}
				num = (short)1643839488;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallInCallUserAlertEnable_A8250._HasDiffs;
			}
		}

		// Token: 0x1700609E RID: 24734
		// (get) Token: 0x0600C052 RID: 49234 RVA: 0x00B1764C File Offset: 0x00B1584C
		// (set) Token: 0x0600C053 RID: 49235 RVA: 0x00B17704 File Offset: 0x00B15904
		public int CnvPerASTROCallSelectiveCallRxTx_A9114Value
		{
			get
			{
				short num = (short)2074738688;
				short num2 = num;
				num = (short)662825689;
				short num3 = num;
				num = (short)1129245401;
				switch (num3 == num)
				{
				}
				num = (short)957939713;
				if (num != 0)
				{
				}
				num = (short)1571422208;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.Value;
			}
			set
			{
				short num = (short)1181745152;
				short num2 = num;
				num = (short)1187446785;
				if (num != 0)
				{
				}
				num = (short)249655566;
				short num3 = num;
				num = (short)1809871118;
				switch (num3 == num)
				{
				}
				num = (short)270139392;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.Value = value;
			}
		}

		// Token: 0x1700609F RID: 24735
		// (get) Token: 0x0600C054 RID: 49236 RVA: 0x00B177B8 File Offset: 0x00B159B8
		// (set) Token: 0x0600C055 RID: 49237 RVA: 0x00B1786C File Offset: 0x00B15A6C
		public string CnvPerASTROCallSelectiveCallRxTx_A9114_UIValue
		{
			get
			{
				short num = (short)339738624;
				short num2 = num;
				num = (short)1249874758;
				short num3 = num;
				num = (short)1164415814;
				switch (num3 == num)
				{
				}
				num = (short)1602551809;
				if (num != 0)
				{
				}
				num = (short)2008875008;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.UIValue;
			}
			set
			{
				short num = (short)1119944704;
				short num2 = num;
				num = (short)2062767622;
				short num3 = num;
				num = (short)1839552006;
				switch (num3 == num)
				{
				}
				num = (short)483262465;
				if (num != 0)
				{
				}
				num = (short)473235456;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.UIValue = value;
			}
		}

		// Token: 0x170060A0 RID: 24736
		// (get) Token: 0x0600C056 RID: 49238 RVA: 0x00B17920 File Offset: 0x00B15B20
		public global::AcpBusinessLayer.AcpListField CnvPerASTROCallSelectiveCallRxTx_A9114
		{
			get
			{
				short num = (short)21823488;
				short num2 = num;
				num = (short)1961081569;
				short num3 = num;
				num = (short)1204861665;
				switch (num3 == num)
				{
				}
				num = (short)1572732928;
				if (num != 0)
				{
				}
				num = (short)2113404929;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114;
			}
		}

		// Token: 0x170060A1 RID: 24737
		// (get) Token: 0x0600C057 RID: 49239 RVA: 0x00B179D0 File Offset: 0x00B15BD0
		// (set) Token: 0x0600C058 RID: 49240 RVA: 0x00B17A84 File Offset: 0x00B15C84
		public bool CnvPerASTROCallSelectiveCallRxTx_A9114_Applicable
		{
			get
			{
				short num = (short)1826750464;
				short num2 = num;
				num = (short)76345023;
				short num3 = num;
				num = (short)616689343;
				switch (num3 == num)
				{
				}
				num = (short)2100756481;
				if (num != 0)
				{
				}
				num = (short)1978269696;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.Applicable;
			}
			set
			{
				short num = (short)425263104;
				short num2 = num;
				num = (short)180996973;
				short num3 = num;
				num = (short)603966317;
				switch (num3 == num)
				{
				}
				num = (short)433913857;
				if (num != 0)
				{
				}
				num = (short)1799553024;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.Applicable = value;
			}
		}

		// Token: 0x170060A2 RID: 24738
		// (get) Token: 0x0600C059 RID: 49241 RVA: 0x00B17B38 File Offset: 0x00B15D38
		// (set) Token: 0x0600C05A RID: 49242 RVA: 0x00B17BEC File Offset: 0x00B15DEC
		public bool CnvPerASTROCallSelectiveCallRxTx_A9114_Valid
		{
			get
			{
				short num = (short)509280256;
				short num2 = num;
				num = (short)1918652924;
				short num3 = num;
				num = (short)1004556796;
				switch (num3 == num)
				{
				}
				num = (short)1119354880;
				if (num != 0)
				{
				}
				num = (short)582156289;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.Valid;
			}
			set
			{
				short num = (short)199360512;
				short num2 = num;
				num = (short)1084279713;
				short num3 = num;
				num = (short)1605421985;
				switch (num3 == num)
				{
				}
				num = (short)31195137;
				if (num != 0)
				{
				}
				num = (short)1064894464;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.Valid = value;
			}
		}

		// Token: 0x170060A3 RID: 24739
		// (get) Token: 0x0600C05B RID: 49243 RVA: 0x00B17CA4 File Offset: 0x00B15EA4
		// (set) Token: 0x0600C05C RID: 49244 RVA: 0x00B17D54 File Offset: 0x00B15F54
		public bool CnvPerASTROCallSelectiveCallRxTx_A9114_Visible
		{
			get
			{
				short num = (short)336068608;
				short num2 = num;
				num = (short)382714194;
				short num3 = num;
				num = (short)757842258;
				switch (num3 == num)
				{
				}
				num = (short)1915944961;
				if (num != 0)
				{
				}
				num = (short)1547304960;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.Visible;
			}
			set
			{
				short num = (short)1606942720;
				short num2 = num;
				num = (short)369921631;
				short num3 = num;
				num = (short)1237225055;
				switch (num3 == num)
				{
				}
				num = (short)200933376;
				if (num != 0)
				{
				}
				num = (short)1716060161;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.Visible = value;
			}
		}

		// Token: 0x170060A4 RID: 24740
		// (get) Token: 0x0600C05D RID: 49245 RVA: 0x00B17E0C File Offset: 0x00B1600C
		// (set) Token: 0x0600C05E RID: 49246 RVA: 0x00B17EC0 File Offset: 0x00B160C0
		public bool CnvPerASTROCallSelectiveCallRxTx_A9114_Editable
		{
			get
			{
				short num = (short)1243807744;
				short num2 = num;
				num = (short)1823080449;
				if (num != 0)
				{
				}
				num = (short)117924222;
				short num3 = num;
				num = (short)1285841278;
				switch (num3 == num)
				{
				}
				num = (short)179568640;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.Editable;
			}
			set
			{
				short num = (short)1547173888;
				short num2 = num;
				num = (short)1549670122;
				short num3 = num;
				num = (short)1075779306;
				switch (num3 == num)
				{
				}
				num = (short)146669569;
				if (num != 0)
				{
				}
				num = (short)332529664;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.Editable = value;
			}
		}

		// Token: 0x170060A5 RID: 24741
		// (get) Token: 0x0600C05F RID: 49247 RVA: 0x00B17F78 File Offset: 0x00B16178
		internal string CnvPerASTROCallSelectiveCallRxTx_A9114_UILabel
		{
			get
			{
				short num = (short)1066663936;
				short num2 = num;
				num = (short)451603793;
				short num3 = num;
				num = (short)278785361;
				switch (num3 == num)
				{
				}
				num = (short)1974009857;
				if (num != 0)
				{
				}
				num = (short)1009123328;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.UIName;
			}
		}

		// Token: 0x170060A6 RID: 24742
		// (get) Token: 0x0600C060 RID: 49248 RVA: 0x00B18030 File Offset: 0x00B16230
		// (set) Token: 0x0600C061 RID: 49249 RVA: 0x00B180E4 File Offset: 0x00B162E4
		internal bool CnvPerASTROCallSelectiveCallRxTx_A9114_HiddenStatic
		{
			get
			{
				short num = (short)279773184;
				short num2 = num;
				num = (short)1808334849;
				if (num != 0)
				{
				}
				num = (short)1066403035;
				short num3 = num;
				num = (short)6096091;
				switch (num3 == num)
				{
				}
				num = (short)121438208;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.HiddenStatic;
			}
			set
			{
				short num = (short)1803550720;
				short num2 = num;
				num = (short)1424259924;
				short num3 = num;
				num = (short)1776646996;
				switch (num3 == num)
				{
				}
				num = (short)1306066944;
				if (num != 0)
				{
				}
				num = (short)1536557057;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.HiddenStatic = value;
			}
		}

		// Token: 0x170060A7 RID: 24743
		// (get) Token: 0x0600C062 RID: 49250 RVA: 0x00B18198 File Offset: 0x00B16398
		// (set) Token: 0x0600C063 RID: 49251 RVA: 0x00B1824C File Offset: 0x00B1644C
		internal bool CnvPerASTROCallSelectiveCallRxTx_A9114_HiddenDynamic
		{
			get
			{
				short num = (short)2027290624;
				short num2 = num;
				num = (short)2060146562;
				short num3 = num;
				num = (short)1102534530;
				switch (num3 == num)
				{
				}
				num = (short)1640300544;
				if (num != 0)
				{
				}
				num = (short)279248897;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114.HiddenDynamic;
			}
			set
			{
				short num = (short)462553088;
				short num2 = num;
				num = (short)321734320;
				short num3 = num;
				num = (short)1501316784;
				switch (num3 == num)
				{
				}
				num = (short)173146112;
				if (num != 0)
				{
				}
				num = (short)1542782977;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallSelectiveCallRxTx_A9114.HiddenDynamic = value;
			}
		}

		// Token: 0x170060A8 RID: 24744
		// (get) Token: 0x0600C064 RID: 49252 RVA: 0x00B18300 File Offset: 0x00B16500
		public bool CnvPerASTROCallSelectiveCallRxTx_A9114_HasDiffs
		{
			get
			{
				short num = (short)379715584;
				short num2 = num;
				num = (short)1439824473;
				short num3 = num;
				num = (short)348322393;
				switch (num3 == num)
				{
				}
				num = (short)86376448;
				if (num != 0)
				{
				}
				num = (short)959315969;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallSelectiveCallRxTx_A9114._HasDiffs;
			}
		}

		// Token: 0x170060A9 RID: 24745
		// (get) Token: 0x0600C065 RID: 49253 RVA: 0x00B183B4 File Offset: 0x00B165B4
		// (set) Token: 0x0600C066 RID: 49254 RVA: 0x00B18468 File Offset: 0x00B16668
		public int CnvPerTacticalInhibitKillOperation_A41553Value
		{
			get
			{
				short num = (short)977469440;
				short num2 = num;
				num = (short)1682782727;
				short num3 = num;
				num = (short)1149581831;
				switch (num3 == num)
				{
				}
				num = (short)1580007425;
				if (num != 0)
				{
				}
				num = (short)1897594880;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.Value;
			}
			set
			{
				short num = (short)826015744;
				short num2 = num;
				num = (short)1481739881;
				short num3 = num;
				num = (short)1305120361;
				switch (num3 == num)
				{
				}
				num = (short)1018494976;
				if (num != 0)
				{
				}
				num = (short)1189478401;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitKillOperation_A41553.Value = value;
			}
		}

		// Token: 0x170060AA RID: 24746
		// (get) Token: 0x0600C067 RID: 49255 RVA: 0x00B18520 File Offset: 0x00B16720
		// (set) Token: 0x0600C068 RID: 49256 RVA: 0x00B185D8 File Offset: 0x00B167D8
		public string CnvPerTacticalInhibitKillOperation_A41553_UIValue
		{
			get
			{
				short num = (short)1779957760;
				short num2 = num;
				num = (short)1774714881;
				if (num != 0)
				{
				}
				num = (short)773369833;
				short num3 = num;
				num = (short)454930409;
				switch (num3 == num)
				{
				}
				num = (short)191299584;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.UIValue;
			}
			set
			{
				short num = (short)1444020224;
				short num2 = num;
				num = (short)354786827;
				short num3 = num;
				num = (short)296328715;
				switch (num3 == num)
				{
				}
				num = (short)510132224;
				if (num != 0)
				{
				}
				num = (short)1279918081;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitKillOperation_A41553.UIValue = value;
			}
		}

		// Token: 0x170060AB RID: 24747
		// (get) Token: 0x0600C069 RID: 49257 RVA: 0x00B18690 File Offset: 0x00B16890
		public global::AcpBusinessLayer.AcpListField CnvPerTacticalInhibitKillOperation_A41553
		{
			get
			{
				short num = (short)305266688;
				short num2 = num;
				num = (short)937666471;
				short num3 = num;
				num = (short)823895975;
				switch (num3 == num)
				{
				}
				num = (short)130613249;
				if (num != 0)
				{
				}
				num = (short)836042752;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553;
			}
		}

		// Token: 0x170060AC RID: 24748
		// (get) Token: 0x0600C06A RID: 49258 RVA: 0x00B18740 File Offset: 0x00B16940
		// (set) Token: 0x0600C06B RID: 49259 RVA: 0x00B187F4 File Offset: 0x00B169F4
		public bool CnvPerTacticalInhibitKillOperation_A41553_Applicable
		{
			get
			{
				short num = (short)277151744;
				short num2 = num;
				num = (short)424493161;
				short num3 = num;
				num = (short)1475035241;
				switch (num3 == num)
				{
				}
				num = (short)137822209;
				if (num != 0)
				{
				}
				num = (short)1955659776;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.Applicable;
			}
			set
			{
				short num = (short)937426944;
				short num2 = num;
				num = (short)558061946;
				short num3 = num;
				num = (short)907368826;
				switch (num3 == num)
				{
				}
				num = (short)168165376;
				if (num != 0)
				{
				}
				num = (short)919732225;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitKillOperation_A41553.Applicable = value;
			}
		}

		// Token: 0x170060AD RID: 24749
		// (get) Token: 0x0600C06C RID: 49260 RVA: 0x00B188AC File Offset: 0x00B16AAC
		// (set) Token: 0x0600C06D RID: 49261 RVA: 0x00B18960 File Offset: 0x00B16B60
		public bool CnvPerTacticalInhibitKillOperation_A41553_Valid
		{
			get
			{
				short num = (short)1855717376;
				short num2 = num;
				num = (short)1550118653;
				short num3 = num;
				num = (short)1674768125;
				switch (num3 == num)
				{
				}
				num = (short)122617856;
				if (num != 0)
				{
				}
				num = (short)1346764801;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.Valid;
			}
			set
			{
				short num = (short)2055536640;
				short num2 = num;
				num = (short)1032443301;
				short num3 = num;
				num = (short)776918437;
				switch (num3 == num)
				{
				}
				num = (short)1816395776;
				if (num != 0)
				{
				}
				num = (short)1919156225;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitKillOperation_A41553.Valid = value;
			}
		}

		// Token: 0x170060AE RID: 24750
		// (get) Token: 0x0600C06E RID: 49262 RVA: 0x00B18A14 File Offset: 0x00B16C14
		// (set) Token: 0x0600C06F RID: 49263 RVA: 0x00B18AC8 File Offset: 0x00B16CC8
		public bool CnvPerTacticalInhibitKillOperation_A41553_Visible
		{
			get
			{
				short num = (short)1885208576;
				short num2 = num;
				num = (short)1833603530;
				short num3 = num;
				num = (short)51745226;
				switch (num3 == num)
				{
				}
				num = (short)1176502273;
				if (num != 0)
				{
				}
				num = (short)1785331712;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.Visible;
			}
			set
			{
				short num = (short)2017394688;
				short num2 = num;
				num = (short)1251147777;
				if (num != 0)
				{
				}
				num = (short)1061072374;
				short num3 = num;
				num = (short)40545782;
				switch (num3 == num)
				{
				}
				num = (short)1595604992;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitKillOperation_A41553.Visible = value;
			}
		}

		// Token: 0x170060AF RID: 24751
		// (get) Token: 0x0600C070 RID: 49264 RVA: 0x00B18B80 File Offset: 0x00B16D80
		// (set) Token: 0x0600C071 RID: 49265 RVA: 0x00B18C38 File Offset: 0x00B16E38
		public bool CnvPerTacticalInhibitKillOperation_A41553_Editable
		{
			get
			{
				short num = (short)942407680;
				short num2 = num;
				num = (short)657159268;
				short num3 = num;
				num = (short)87782500;
				switch (num3 == num)
				{
				}
				num = (short)1566113793;
				if (num != 0)
				{
				}
				num = (short)841744384;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.Editable;
			}
			set
			{
				short num = (short)1330708480;
				short num2 = num;
				num = (short)313720833;
				if (num != 0)
				{
				}
				num = (short)1543582875;
				short num3 = num;
				num = (short)1969566875;
				switch (num3 == num)
				{
				}
				num = (short)149946368;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitKillOperation_A41553.Editable = value;
			}
		}

		// Token: 0x170060B0 RID: 24752
		// (get) Token: 0x0600C072 RID: 49266 RVA: 0x00B18CF0 File Offset: 0x00B16EF0
		internal string CnvPerTacticalInhibitKillOperation_A41553_UILabel
		{
			get
			{
				short num = (short)47841280;
				short num2 = num;
				num = (short)787722735;
				short num3 = num;
				num = (short)705737199;
				switch (num3 == num)
				{
				}
				num = (short)1878261761;
				if (num != 0)
				{
				}
				num = (short)1293090816;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.UIName;
			}
		}

		// Token: 0x170060B1 RID: 24753
		// (get) Token: 0x0600C073 RID: 49267 RVA: 0x00B18DA4 File Offset: 0x00B16FA4
		// (set) Token: 0x0600C074 RID: 49268 RVA: 0x00B18E5C File Offset: 0x00B1705C
		internal bool CnvPerTacticalInhibitKillOperation_A41553_HiddenStatic
		{
			get
			{
				short num = (short)1234698240;
				short num2 = num;
				num = (short)279518885;
				short num3 = num;
				num = (short)751836837;
				switch (num3 == num)
				{
				}
				num = (short)1420820480;
				if (num != 0)
				{
				}
				num = (short)732823553;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.HiddenStatic;
			}
			set
			{
				short num = (short)1181220864;
				short num2 = num;
				num = (short)2030963405;
				short num3 = num;
				num = (short)1534003917;
				switch (num3 == num)
				{
				}
				num = (short)447152128;
				if (num != 0)
				{
				}
				num = (short)603914241;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitKillOperation_A41553.HiddenStatic = value;
			}
		}

		// Token: 0x170060B2 RID: 24754
		// (get) Token: 0x0600C075 RID: 49269 RVA: 0x00B18F10 File Offset: 0x00B17110
		// (set) Token: 0x0600C076 RID: 49270 RVA: 0x00B18FC4 File Offset: 0x00B171C4
		internal bool CnvPerTacticalInhibitKillOperation_A41553_HiddenDynamic
		{
			get
			{
				short num = (short)69186774;
				short num2 = num;
				num = (short)1533195478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675296768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2073165825;
				if (num != 0)
				{
				}
				num = (short)97648640;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553.HiddenDynamic;
			}
			set
			{
				short num = (short)1826624765;
				short num2 = num;
				num = (short)1799361789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010054656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417726465;
				if (num != 0)
				{
				}
				num = (short)1896022016;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitKillOperation_A41553.HiddenDynamic = value;
			}
		}

		// Token: 0x170060B3 RID: 24755
		// (get) Token: 0x0600C077 RID: 49271 RVA: 0x00B1907C File Offset: 0x00B1727C
		public bool CnvPerTacticalInhibitKillOperation_A41553_HasDiffs
		{
			get
			{
				short num = (short)664024745;
				short num2 = num;
				num = (short)2013869737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)296812544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)365887489;
				if (num != 0)
				{
				}
				num = (short)1059651584;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitKillOperation_A41553._HasDiffs;
			}
		}

		// Token: 0x170060B4 RID: 24756
		// (get) Token: 0x0600C078 RID: 49272 RVA: 0x00B19130 File Offset: 0x00B17330
		// (set) Token: 0x0600C079 RID: 49273 RVA: 0x00B191E4 File Offset: 0x00B173E4
		public int CnvPerTacticalInhibitStunOperation_A41557Value
		{
			get
			{
				short num = (short)1223888075;
				short num2 = num;
				num = (short)1396968651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555810816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1176502272;
				if (num != 0)
				{
				}
				num = (short)1256914945;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.Value;
			}
			set
			{
				short num = (short)1475633270;
				short num2 = num;
				num = (short)1378639990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)315031552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1255866369;
				if (num != 0)
				{
				}
				num = (short)1888681984;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitStunOperation_A41557.Value = value;
			}
		}

		// Token: 0x170060B5 RID: 24757
		// (get) Token: 0x0600C07A RID: 49274 RVA: 0x00B1929C File Offset: 0x00B1749C
		// (set) Token: 0x0600C07B RID: 49275 RVA: 0x00B19350 File Offset: 0x00B17550
		public string CnvPerTacticalInhibitStunOperation_A41557_UIValue
		{
			get
			{
				short num = (short)2095361107;
				short num2 = num;
				num = (short)1217702995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1220673536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1521156097;
				if (num != 0)
				{
				}
				num = (short)708116480;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.UIValue;
			}
			set
			{
				short num = (short)1246066974;
				short num2 = num;
				num = (short)1372616990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1458372608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)429326337;
				if (num != 0)
				{
				}
				num = (short)671481856;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitStunOperation_A41557.UIValue = value;
			}
		}

		// Token: 0x170060B6 RID: 24758
		// (get) Token: 0x0600C07C RID: 49276 RVA: 0x00B19408 File Offset: 0x00B17608
		public global::AcpBusinessLayer.AcpListField CnvPerTacticalInhibitStunOperation_A41557
		{
			get
			{
				short num = (short)1387789544;
				short num2 = num;
				num = (short)429718760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1288830976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402273792;
				if (num != 0)
				{
				}
				num = (short)527892481;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557;
			}
		}

		// Token: 0x170060B7 RID: 24759
		// (get) Token: 0x0600C07D RID: 49277 RVA: 0x00B194B8 File Offset: 0x00B176B8
		// (set) Token: 0x0600C07E RID: 49278 RVA: 0x00B19570 File Offset: 0x00B17770
		public bool CnvPerTacticalInhibitStunOperation_A41557_Applicable
		{
			get
			{
				short num = (short)928605480;
				short num2 = num;
				num = (short)43017512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80281600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1844314113;
				if (num != 0)
				{
				}
				num = (short)1964507136;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.Applicable;
			}
			set
			{
				short num = (short)1203396444;
				short num2 = num;
				num = (short)1962106716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817364992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772145153;
				if (num != 0)
				{
				}
				num = (short)858849280;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitStunOperation_A41557.Applicable = value;
			}
		}

		// Token: 0x170060B8 RID: 24760
		// (get) Token: 0x0600C07F RID: 49279 RVA: 0x00B19624 File Offset: 0x00B17824
		// (set) Token: 0x0600C080 RID: 49280 RVA: 0x00B196D4 File Offset: 0x00B178D4
		public bool CnvPerTacticalInhibitStunOperation_A41557_Valid
		{
			get
			{
				short num = (short)1747736607;
				short num2 = num;
				num = (short)338712607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)221118464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858469889;
				if (num != 0)
				{
				}
				num = (short)846200832;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.Valid;
			}
			set
			{
				short num = (short)1695312010;
				short num2 = num;
				num = (short)972777610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)949420032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567672833;
				if (num != 0)
				{
				}
				num = (short)1940062208;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitStunOperation_A41557.Valid = value;
			}
		}

		// Token: 0x170060B9 RID: 24761
		// (get) Token: 0x0600C081 RID: 49281 RVA: 0x00B1978C File Offset: 0x00B1798C
		// (set) Token: 0x0600C082 RID: 49282 RVA: 0x00B19840 File Offset: 0x00B17A40
		public bool CnvPerTacticalInhibitStunOperation_A41557_Visible
		{
			get
			{
				short num = (short)1478267820;
				short num2 = num;
				num = (short)808620972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030619136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1734344705;
				if (num != 0)
				{
				}
				num = (short)643563520;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.Visible;
			}
			set
			{
				short num = (short)1925470964;
				short num2 = num;
				num = (short)1709791988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1011220480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2094530560;
				if (num != 0)
				{
				}
				num = (short)761593857;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitStunOperation_A41557.Visible = value;
			}
		}

		// Token: 0x170060BA RID: 24762
		// (get) Token: 0x0600C083 RID: 49283 RVA: 0x00B198F4 File Offset: 0x00B17AF4
		// (set) Token: 0x0600C084 RID: 49284 RVA: 0x00B199A8 File Offset: 0x00B17BA8
		public bool CnvPerTacticalInhibitStunOperation_A41557_Editable
		{
			get
			{
				short num = (short)505018177;
				short num2 = num;
				num = (short)1784543041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2098987008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)149880832;
				if (num != 0)
				{
				}
				num = (short)1063714817;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.Editable;
			}
			set
			{
				short num = (short)19412035;
				short num2 = num;
				num = (short)1186673731;
				switch (num2 == num)
				{
				}
				num = (short)279904256;
				short num3 = num;
				num = (short)1523056640;
				if (num != 0)
				{
				}
				num = (short)1839857665;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitStunOperation_A41557.Editable = value;
			}
		}

		// Token: 0x170060BB RID: 24763
		// (get) Token: 0x0600C085 RID: 49285 RVA: 0x00B19A60 File Offset: 0x00B17C60
		internal string CnvPerTacticalInhibitStunOperation_A41557_UILabel
		{
			get
			{
				short num = (short)771865187;
				short num2 = num;
				num = (short)690469475;
				switch (num2 == num)
				{
				}
				num = (short)1165950976;
				short num3 = num;
				num = (short)1555365888;
				if (num != 0)
				{
				}
				num = (short)113639425;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.UIName;
			}
		}

		// Token: 0x170060BC RID: 24764
		// (get) Token: 0x0600C086 RID: 49286 RVA: 0x00B19B14 File Offset: 0x00B17D14
		// (set) Token: 0x0600C087 RID: 49287 RVA: 0x00B19BC8 File Offset: 0x00B17DC8
		internal bool CnvPerTacticalInhibitStunOperation_A41557_HiddenStatic
		{
			get
			{
				short num = (short)691806890;
				short num2 = num;
				num = (short)622600874;
				switch (num2 == num)
				{
				}
				num = (short)1143078912;
				short num3 = num;
				num = (short)1179648;
				if (num != 0)
				{
				}
				num = (short)120651777;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.HiddenStatic;
			}
			set
			{
				short num = (short)1267597313;
				if (num != 0)
				{
				}
				num = (short)1050368729;
				short num2 = num;
				num = (short)1560632025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554644992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1259798528;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitStunOperation_A41557.HiddenStatic = value;
			}
		}

		// Token: 0x170060BD RID: 24765
		// (get) Token: 0x0600C088 RID: 49288 RVA: 0x00B19C7C File Offset: 0x00B17E7C
		// (set) Token: 0x0600C089 RID: 49289 RVA: 0x00B19D30 File Offset: 0x00B17F30
		internal bool CnvPerTacticalInhibitStunOperation_A41557_HiddenDynamic
		{
			get
			{
				short num = (short)700823448;
				short num2 = num;
				num = (short)1557510040;
				switch (num2 == num)
				{
				}
				num = (short)1943404544;
				short num3 = num;
				num = (short)1971388417;
				if (num != 0)
				{
				}
				num = (short)1139867648;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557.HiddenDynamic;
			}
			set
			{
				short num = (short)1823423215;
				short num2 = num;
				num = (short)506084079;
				switch (num2 == num)
				{
				}
				num = (short)1993867264;
				short num3 = num;
				num = (short)1851326465;
				if (num != 0)
				{
				}
				num = (short)1728774144;
				if (num != 0)
				{
				}
				this.cnvPerTacticalInhibitStunOperation_A41557.HiddenDynamic = value;
			}
		}

		// Token: 0x170060BE RID: 24766
		// (get) Token: 0x0600C08A RID: 49290 RVA: 0x00B19DE4 File Offset: 0x00B17FE4
		public bool CnvPerTacticalInhibitStunOperation_A41557_HasDiffs
		{
			get
			{
				short num = (short)96523010;
				short num2 = num;
				num = (short)336843522;
				switch (num2 == num)
				{
				}
				num = (short)180813824;
				short num3 = num;
				num = (short)136773633;
				if (num != 0)
				{
				}
				num = (short)995164160;
				if (num != 0)
				{
				}
				return this.cnvPerTacticalInhibitStunOperation_A41557._HasDiffs;
			}
		}

		// Token: 0x170060BF RID: 24767
		// (get) Token: 0x0600C08B RID: 49291 RVA: 0x00B19E9C File Offset: 0x00B1809C
		// (set) Token: 0x0600C08C RID: 49292 RVA: 0x00B19F50 File Offset: 0x00B18150
		public int CnvPerASTROCallTacticalServicesOperationValue
		{
			get
			{
				short num = (short)1680534431;
				short num2 = num;
				num = (short)1068690335;
				switch (num2 == num)
				{
				}
				num = (short)1892352000;
				short num3 = num;
				num = (short)192020480;
				if (num != 0)
				{
				}
				num = (short)1085014017;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.Value;
			}
			set
			{
				short num = (short)867440028;
				short num2 = num;
				num = (short)48305564;
				switch (num2 == num)
				{
				}
				num = (short)1016135680;
				short num3 = num;
				num = (short)464846848;
				if (num != 0)
				{
				}
				num = (short)1548353537;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallTacticalServicesOperation.Value = value;
			}
		}

		// Token: 0x170060C0 RID: 24768
		// (get) Token: 0x0600C08D RID: 49293 RVA: 0x00B1A004 File Offset: 0x00B18204
		// (set) Token: 0x0600C08E RID: 49294 RVA: 0x00B1A0BC File Offset: 0x00B182BC
		public string CnvPerASTROCallTacticalServicesOperation_UIValue
		{
			get
			{
				short num = (short)62849025;
				if (num != 0)
				{
				}
				num = (short)1747607910;
				short num2 = num;
				num = (short)1105355110;
				switch (num2 == num)
				{
				default:
				{
					num = (short)105775104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)863502336;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.UIValue;
			}
			set
			{
				short num = (short)406519746;
				short num2 = num;
				num = (short)363462594;
				switch (num2 == num)
				{
				}
				num = (short)372375552;
				short num3 = num;
				num = (short)29622272;
				if (num != 0)
				{
				}
				num = (short)1506344961;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallTacticalServicesOperation.UIValue = value;
			}
		}

		// Token: 0x170060C1 RID: 24769
		// (get) Token: 0x0600C08F RID: 49295 RVA: 0x00B1A174 File Offset: 0x00B18374
		public global::AcpBusinessLayer.AcpListField CnvPerASTROCallTacticalServicesOperation
		{
			get
			{
				short num = (short)669840840;
				short num2 = num;
				num = (short)521008584;
				switch (num2 == num)
				{
				}
				num = (short)748879872;
				short num3 = num;
				num = (short)1815609344;
				if (num != 0)
				{
				}
				num = (short)564920321;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation;
			}
		}

		// Token: 0x170060C2 RID: 24770
		// (get) Token: 0x0600C090 RID: 49296 RVA: 0x00B1A224 File Offset: 0x00B18424
		// (set) Token: 0x0600C091 RID: 49297 RVA: 0x00B1A2D8 File Offset: 0x00B184D8
		public bool CnvPerASTROCallTacticalServicesOperation_Applicable
		{
			get
			{
				short num = (short)1401012274;
				short num2 = num;
				num = (short)624738354;
				switch (num2 == num)
				{
				}
				num = (short)231014400;
				short num3 = num;
				num = (short)751763457;
				if (num != 0)
				{
				}
				num = (short)1117847552;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.Applicable;
			}
			set
			{
				short num = (short)1516969386;
				short num2 = num;
				num = (short)465575338;
				switch (num2 == num)
				{
				}
				num = (short)340656128;
				short num3 = num;
				num = (short)1897398273;
				if (num != 0)
				{
				}
				num = (short)854327296;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallTacticalServicesOperation.Applicable = value;
			}
		}

		// Token: 0x170060C3 RID: 24771
		// (get) Token: 0x0600C092 RID: 49298 RVA: 0x00B1A390 File Offset: 0x00B18590
		// (set) Token: 0x0600C093 RID: 49299 RVA: 0x00B1A444 File Offset: 0x00B18644
		public bool CnvPerASTROCallTacticalServicesOperation_Valid
		{
			get
			{
				short num = (short)33115373;
				short num2 = num;
				num = (short)515919085;
				switch (num2 == num)
				{
				}
				num = (short)716177408;
				short num3 = num;
				num = (short)799277057;
				if (num != 0)
				{
				}
				num = (short)1445068800;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.Valid;
			}
			set
			{
				short num = (short)242768323;
				short num2 = num;
				num = (short)860445123;
				switch (num2 == num)
				{
				}
				num = (short)797048832;
				short num3 = num;
				num = (short)1559166977;
				if (num != 0)
				{
				}
				num = (short)734068736;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallTacticalServicesOperation.Valid = value;
			}
		}

		// Token: 0x170060C4 RID: 24772
		// (get) Token: 0x0600C094 RID: 49300 RVA: 0x00B1A4F8 File Offset: 0x00B186F8
		// (set) Token: 0x0600C095 RID: 49301 RVA: 0x00B1A5AC File Offset: 0x00B187AC
		public bool CnvPerASTROCallTacticalServicesOperation_Visible
		{
			get
			{
				short num = (short)1815261071;
				short num2 = num;
				num = (short)1269739407;
				switch (num2 == num)
				{
				}
				num = (short)80281600;
				short num3 = num;
				num = (short)1728053248;
				if (num != 0)
				{
				}
				num = (short)523698177;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.Visible;
			}
			set
			{
				short num = (short)869922885;
				short num2 = num;
				num = (short)809629765;
				switch (num2 == num)
				{
				}
				num = (short)1654063104;
				short num3 = num;
				num = (short)72548353;
				if (num != 0)
				{
				}
				num = (short)391774208;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallTacticalServicesOperation.Visible = value;
			}
		}

		// Token: 0x170060C5 RID: 24773
		// (get) Token: 0x0600C096 RID: 49302 RVA: 0x00B1A660 File Offset: 0x00B18860
		// (set) Token: 0x0600C097 RID: 49303 RVA: 0x00B1A714 File Offset: 0x00B18914
		public bool CnvPerASTROCallTacticalServicesOperation_Editable
		{
			get
			{
				short num = (short)1940906627;
				short num2 = num;
				num = (short)1555751555;
				switch (num2 == num)
				{
				}
				num = (short)1820983296;
				short num3 = num;
				num = (short)1488125952;
				if (num != 0)
				{
				}
				num = (short)1564999681;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.Editable;
			}
			set
			{
				short num = (short)191713285;
				short num2 = num;
				num = (short)2119979013;
				switch (num2 == num)
				{
				}
				num = (short)851312640;
				short num3 = num;
				num = (short)9961472;
				if (num != 0)
				{
				}
				num = (short)994967553;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallTacticalServicesOperation.Editable = value;
			}
		}

		// Token: 0x170060C6 RID: 24774
		// (get) Token: 0x0600C098 RID: 49304 RVA: 0x00B1A7CC File Offset: 0x00B189CC
		internal string CnvPerASTROCallTacticalServicesOperation_UILabel
		{
			get
			{
				short num = (short)549021271;
				short num2 = num;
				num = (short)107767383;
				switch (num2 == num)
				{
				}
				num = (short)966721536;
				short num3 = num;
				num = (short)1589772289;
				if (num != 0)
				{
				}
				num = (short)1206386688;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.UIName;
			}
		}

		// Token: 0x170060C7 RID: 24775
		// (get) Token: 0x0600C099 RID: 49305 RVA: 0x00B1A884 File Offset: 0x00B18A84
		// (set) Token: 0x0600C09A RID: 49306 RVA: 0x00B1A938 File Offset: 0x00B18B38
		internal bool CnvPerASTROCallTacticalServicesOperation_HiddenStatic
		{
			get
			{
				short num = (short)457646296;
				short num2 = num;
				num = (short)908861656;
				switch (num2 == num)
				{
				}
				num = (short)1683947520;
				short num3 = num;
				num = (short)1027538945;
				if (num != 0)
				{
				}
				num = (short)2083848192;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.HiddenStatic;
			}
			set
			{
				short num = (short)1230060005;
				short num2 = num;
				num = (short)698431973;
				switch (num2 == num)
				{
				}
				num = (short)91226112;
				short num3 = num;
				num = (short)1338114048;
				if (num != 0)
				{
				}
				num = (short)472055809;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallTacticalServicesOperation.HiddenStatic = value;
			}
		}

		// Token: 0x170060C8 RID: 24776
		// (get) Token: 0x0600C09B RID: 49307 RVA: 0x00B1A9F4 File Offset: 0x00B18BF4
		// (set) Token: 0x0600C09C RID: 49308 RVA: 0x00B1AAA4 File Offset: 0x00B18CA4
		internal bool CnvPerASTROCallTacticalServicesOperation_HiddenDynamic
		{
			get
			{
				short num = (short)1787861475;
				short num2 = num;
				num = (short)1613928931;
				switch (num2 == num)
				{
				}
				num = (short)622657536;
				short num3 = num;
				num = (short)1737031681;
				if (num != 0)
				{
				}
				num = (short)2146828288;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation.HiddenDynamic;
			}
			set
			{
				short num = (short)1721273780;
				short num2 = num;
				num = (short)1756335540;
				switch (num2 == num)
				{
				}
				num = (short)1457455104;
				short num3 = num;
				num = (short)1198456833;
				if (num != 0)
				{
				}
				num = (short)859111424;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallTacticalServicesOperation.HiddenDynamic = value;
			}
		}

		// Token: 0x170060C9 RID: 24777
		// (get) Token: 0x0600C09D RID: 49309 RVA: 0x00B1AB5C File Offset: 0x00B18D5C
		public bool CnvPerASTROCallTacticalServicesOperation_HasDiffs
		{
			get
			{
				short num = (short)972952907;
				short num2 = num;
				num = (short)372446539;
				switch (num2 == num)
				{
				}
				num = (short)1873215488;
				short num3 = num;
				num = (short)1393688577;
				if (num != 0)
				{
				}
				num = (short)381485056;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallTacticalServicesOperation._HasDiffs;
			}
		}

		// Token: 0x170060CA RID: 24778
		// (get) Token: 0x0600C09E RID: 49310 RVA: 0x00B1AC10 File Offset: 0x00B18E10
		// (set) Token: 0x0600C09F RID: 49311 RVA: 0x00B1ACC4 File Offset: 0x00B18EC4
		public int CnvPerASTROCallRadioUninhibitDecodeAction_A9045Value
		{
			get
			{
				short num = (short)184136448;
				short num2 = num;
				num = (short)1092596480;
				switch (num2 == num)
				{
				}
				num = (short)1895694336;
				short num3 = num;
				num = (short)994115585;
				if (num != 0)
				{
				}
				num = (short)294649856;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Value;
			}
			set
			{
				short num = (short)1160984803;
				short num2 = num;
				num = (short)918763747;
				switch (num2 == num)
				{
				}
				num = (short)1224212480;
				short num3 = num;
				num = (short)1046085633;
				if (num != 0)
				{
				}
				num = (short)644022272;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Value = value;
			}
		}

		// Token: 0x170060CB RID: 24779
		// (get) Token: 0x0600C0A0 RID: 49312 RVA: 0x00B1AD7C File Offset: 0x00B18F7C
		// (set) Token: 0x0600C0A1 RID: 49313 RVA: 0x00B1AE34 File Offset: 0x00B19034
		public string CnvPerASTROCallRadioUninhibitDecodeAction_A9045_UIValue
		{
			get
			{
				short num = (short)1756514378;
				short num2 = num;
				num = (short)1977239626;
				switch (num2 == num)
				{
				}
				num = (short)128843776;
				short num3 = num;
				num = (short)1438121984;
				if (num != 0)
				{
				}
				num = (short)1070792705;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.UIValue;
			}
			set
			{
				short num = (short)1558112329;
				short num2 = num;
				num = (short)1576003657;
				switch (num2 == num)
				{
				}
				num = (short)899547136;
				short num3 = num;
				num = (short)889651200;
				if (num != 0)
				{
				}
				num = (short)575340545;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.UIValue = value;
			}
		}

		// Token: 0x170060CC RID: 24780
		// (get) Token: 0x0600C0A2 RID: 49314 RVA: 0x00B1AEEC File Offset: 0x00B190EC
		public global::AcpBusinessLayer.AcpListField CnvPerASTROCallRadioUninhibitDecodeAction_A9045
		{
			get
			{
				short num = (short)540471535;
				short num2 = num;
				num = (short)437121263;
				switch (num2 == num)
				{
				}
				num = (short)785580032;
				short num3 = num;
				num = (short)2011430913;
				if (num != 0)
				{
				}
				num = (short)36831232;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045;
			}
		}

		// Token: 0x170060CD RID: 24781
		// (get) Token: 0x0600C0A3 RID: 49315 RVA: 0x00B1AF9C File Offset: 0x00B1919C
		// (set) Token: 0x0600C0A4 RID: 49316 RVA: 0x00B1B050 File Offset: 0x00B19250
		public bool CnvPerASTROCallRadioUninhibitDecodeAction_A9045_Applicable
		{
			get
			{
				short num = (short)852515664;
				short num2 = num;
				num = (short)101538640;
				switch (num2 == num)
				{
				}
				num = (short)122028032;
				short num3 = num;
				num = (short)117833729;
				if (num != 0)
				{
				}
				num = (short)924975104;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Applicable;
			}
			set
			{
				short num = (short)867631105;
				if (num != 0)
				{
				}
				num = (short)306543281;
				short num2 = num;
				num = (short)614496945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)789381120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)423821312;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Applicable = value;
			}
		}

		// Token: 0x170060CE RID: 24782
		// (get) Token: 0x0600C0A5 RID: 49317 RVA: 0x00B1B108 File Offset: 0x00B19308
		// (set) Token: 0x0600C0A6 RID: 49318 RVA: 0x00B1B1BC File Offset: 0x00B193BC
		public bool CnvPerASTROCallRadioUninhibitDecodeAction_A9045_Valid
		{
			get
			{
				short num = (short)750623368;
				short num2 = num;
				num = (short)1069456008;
				switch (num2 == num)
				{
				}
				num = (short)889323520;
				short num3 = num;
				num = (short)296288257;
				if (num != 0)
				{
				}
				num = (short)427229184;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Valid;
			}
			set
			{
				short num = (short)1345323009;
				if (num != 0)
				{
				}
				num = (short)76708275;
				short num2 = num;
				num = (short)368081331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)858390528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)800784384;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Valid = value;
			}
		}

		// Token: 0x170060CF RID: 24783
		// (get) Token: 0x0600C0A7 RID: 49319 RVA: 0x00B1B274 File Offset: 0x00B19474
		// (set) Token: 0x0600C0A8 RID: 49320 RVA: 0x00B1B328 File Offset: 0x00B19528
		public bool CnvPerASTROCallRadioUninhibitDecodeAction_A9045_Visible
		{
			get
			{
				short num = (short)499694080;
				short num2 = num;
				num = (short)650295808;
				switch (num2 == num)
				{
				}
				num = (short)371392512;
				short num3 = num;
				num = (short)749862913;
				if (num != 0)
				{
				}
				num = (short)1012137984;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Visible;
			}
			set
			{
				short num = (short)1656426993;
				short num2 = num;
				num = (short)912003569;
				switch (num2 == num)
				{
				}
				num = (short)287834112;
				short num3 = num;
				num = (short)1974992897;
				if (num != 0)
				{
				}
				num = (short)177864704;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Visible = value;
			}
		}

		// Token: 0x170060D0 RID: 24784
		// (get) Token: 0x0600C0A9 RID: 49321 RVA: 0x00B1B3DC File Offset: 0x00B195DC
		// (set) Token: 0x0600C0AA RID: 49322 RVA: 0x00B1B490 File Offset: 0x00B19690
		public bool CnvPerASTROCallRadioUninhibitDecodeAction_A9045_Editable
		{
			get
			{
				short num = (short)521557781;
				short num2 = num;
				num = (short)489117461;
				switch (num2 == num)
				{
				}
				num = (short)1174274048;
				short num3 = num;
				num = (short)1021509633;
				if (num != 0)
				{
				}
				num = (short)1113849856;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Editable;
			}
			set
			{
				short num = (short)90924812;
				short num2 = num;
				num = (short)247162636;
				switch (num2 == num)
				{
				}
				num = (short)1402994688;
				short num3 = num;
				num = (short)1621032961;
				if (num != 0)
				{
				}
				num = (short)327155712;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.Editable = value;
			}
		}

		// Token: 0x170060D1 RID: 24785
		// (get) Token: 0x0600C0AB RID: 49323 RVA: 0x00B1B544 File Offset: 0x00B19744
		internal string CnvPerASTROCallRadioUninhibitDecodeAction_A9045_UILabel
		{
			get
			{
				short num = (short)1380700126;
				short num2 = num;
				num = (short)879153118;
				switch (num2 == num)
				{
				}
				num = (short)1498087424;
				short num3 = num;
				num = (short)1574830081;
				if (num != 0)
				{
				}
				num = (short)23265280;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.UIName;
			}
		}

		// Token: 0x170060D2 RID: 24786
		// (get) Token: 0x0600C0AC RID: 49324 RVA: 0x00B1B5FC File Offset: 0x00B197FC
		// (set) Token: 0x0600C0AD RID: 49325 RVA: 0x00B1B6B4 File Offset: 0x00B198B4
		internal bool CnvPerASTROCallRadioUninhibitDecodeAction_A9045_HiddenStatic
		{
			get
			{
				short num = (short)295698433;
				if (num != 0)
				{
				}
				num = (short)1471341011;
				short num2 = num;
				num = (short)100262355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497956352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2012545024;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.HiddenStatic;
			}
			set
			{
				short num = (short)997992797;
				short num2 = num;
				num = (short)1761749341;
				switch (num2 == num)
				{
				}
				num = (short)581304320;
				short num3 = num;
				num = (short)1982791681;
				if (num != 0)
				{
				}
				num = (short)1773862912;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.HiddenStatic = value;
			}
		}

		// Token: 0x170060D3 RID: 24787
		// (get) Token: 0x0600C0AE RID: 49326 RVA: 0x00B1B76C File Offset: 0x00B1996C
		// (set) Token: 0x0600C0AF RID: 49327 RVA: 0x00B1B820 File Offset: 0x00B19A20
		internal bool CnvPerASTROCallRadioUninhibitDecodeAction_A9045_HiddenDynamic
		{
			get
			{
				short num = (short)162078989;
				short num2 = num;
				num = (short)390603021;
				switch (num2 == num)
				{
				}
				num = (short)2067529728;
				short num3 = num;
				num = (short)1409351681;
				if (num != 0)
				{
				}
				num = (short)1363542016;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.HiddenDynamic;
			}
			set
			{
				short num = (short)2144578404;
				short num2 = num;
				num = (short)1974578020;
				switch (num2 == num)
				{
				}
				num = (short)849346560;
				short num3 = num;
				num = (short)1464532993;
				if (num != 0)
				{
				}
				num = (short)1136132096;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045.HiddenDynamic = value;
			}
		}

		// Token: 0x170060D4 RID: 24788
		// (get) Token: 0x0600C0B0 RID: 49328 RVA: 0x00B1B8D8 File Offset: 0x00B19AD8
		public bool CnvPerASTROCallRadioUninhibitDecodeAction_A9045_HasDiffs
		{
			get
			{
				short num = (short)2063556787;
				short num2 = num;
				num = (short)878469299;
				switch (num2 == num)
				{
				}
				num = (short)583467008;
				short num3 = num;
				num = (short)1042350081;
				if (num != 0)
				{
				}
				num = (short)193396736;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRadioUninhibitDecodeAction_A9045._HasDiffs;
			}
		}

		// Token: 0x170060D5 RID: 24789
		// (get) Token: 0x0600C0B1 RID: 49329 RVA: 0x00B1B98C File Offset: 0x00B19B8C
		// (set) Token: 0x0600C0B2 RID: 49330 RVA: 0x00B1BA40 File Offset: 0x00B19C40
		public int CnvPerASTROCallRemotemonitorfrequencyoptionValue
		{
			get
			{
				short num = (short)218871434;
				short num2 = num;
				num = (short)197310090;
				switch (num2 == num)
				{
				}
				num = (short)862912512;
				short num3 = num;
				num = (short)1932263425;
				if (num != 0)
				{
				}
				num = (short)164888576;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.Value;
			}
			set
			{
				short num = (short)1401075947;
				short num2 = num;
				num = (short)1025947883;
				switch (num2 == num)
				{
				}
				num = (short)1546977280;
				short num3 = num;
				num = (short)1889075201;
				if (num != 0)
				{
				}
				num = (short)732102656;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemotemonitorfrequencyoption.Value = value;
			}
		}

		// Token: 0x170060D6 RID: 24790
		// (get) Token: 0x0600C0B3 RID: 49331 RVA: 0x00B1BAF8 File Offset: 0x00B19CF8
		// (set) Token: 0x0600C0B4 RID: 49332 RVA: 0x00B1BBAC File Offset: 0x00B19DAC
		public string CnvPerASTROCallRemotemonitorfrequencyoption_UIValue
		{
			get
			{
				short num = (short)430235454;
				short num2 = num;
				num = (short)1748754238;
				switch (num2 == num)
				{
				}
				num = (short)2112618496;
				short num3 = num;
				num = (short)305463297;
				if (num != 0)
				{
				}
				num = (short)1917386752;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.UIValue;
			}
			set
			{
				short num = (short)717297723;
				short num2 = num;
				num = (short)503912507;
				switch (num2 == num)
				{
				}
				num = (short)520224768;
				short num3 = num;
				num = (short)1248264192;
				if (num != 0)
				{
				}
				num = (short)1318060033;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemotemonitorfrequencyoption.UIValue = value;
			}
		}

		// Token: 0x170060D7 RID: 24791
		// (get) Token: 0x0600C0B5 RID: 49333 RVA: 0x00B1BC64 File Offset: 0x00B19E64
		public global::AcpBusinessLayer.AcpRecRefField CnvPerASTROCallRemotemonitorfrequencyoption
		{
			get
			{
				short num = (short)2060780953;
				short num2 = num;
				num = (short)1677788569;
				switch (num2 == num)
				{
				}
				num = (short)520552448;
				if (num != 0)
				{
				}
				num = (short)1668743168;
				short num3 = num;
				num = (short)627376129;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption;
			}
		}

		// Token: 0x170060D8 RID: 24792
		// (get) Token: 0x0600C0B6 RID: 49334 RVA: 0x00B1BD14 File Offset: 0x00B19F14
		// (set) Token: 0x0600C0B7 RID: 49335 RVA: 0x00B1BDC8 File Offset: 0x00B19FC8
		public bool CnvPerASTROCallRemotemonitorfrequencyoption_Applicable
		{
			get
			{
				short num = (short)361408656;
				short num2 = num;
				num = (short)174696592;
				switch (num2 == num)
				{
				}
				num = (short)765526016;
				if (num != 0)
				{
				}
				num = (short)1999503360;
				short num3 = num;
				num = (short)402718721;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.Applicable;
			}
			set
			{
				short num = (short)104689733;
				short num2 = num;
				num = (short)2047897669;
				switch (num2 == num)
				{
				}
				num = (short)806748160;
				if (num != 0)
				{
				}
				num = (short)1216741376;
				short num3 = num;
				num = (short)1212022785;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemotemonitorfrequencyoption.Applicable = value;
			}
		}

		// Token: 0x170060D9 RID: 24793
		// (get) Token: 0x0600C0B8 RID: 49336 RVA: 0x00B1BE7C File Offset: 0x00B1A07C
		// (set) Token: 0x0600C0B9 RID: 49337 RVA: 0x00B1BF30 File Offset: 0x00B1A130
		public bool CnvPerASTROCallRemotemonitorfrequencyoption_Valid
		{
			get
			{
				short num = (short)549105961;
				short num2 = num;
				num = (short)1594077481;
				switch (num2 == num)
				{
				}
				num = (short)1374093312;
				if (num != 0)
				{
				}
				num = (short)603258880;
				short num3 = num;
				num = (short)451674113;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.Valid;
			}
			set
			{
				short num = (short)197069551;
				short num2 = num;
				num = (short)803277551;
				switch (num2 == num)
				{
				}
				num = (short)450035712;
				if (num != 0)
				{
				}
				num = (short)152043520;
				short num3 = num;
				num = (short)1490616321;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemotemonitorfrequencyoption.Valid = value;
			}
		}

		// Token: 0x170060DA RID: 24794
		// (get) Token: 0x0600C0BA RID: 49338 RVA: 0x00B1BFE4 File Offset: 0x00B1A1E4
		// (set) Token: 0x0600C0BB RID: 49339 RVA: 0x00B1C098 File Offset: 0x00B1A298
		public bool CnvPerASTROCallRemotemonitorfrequencyoption_Visible
		{
			get
			{
				short num = (short)2010484970;
				short num2 = num;
				num = (short)124162282;
				switch (num2 == num)
				{
				}
				num = (short)1794637825;
				if (num != 0)
				{
				}
				num = (short)1630732288;
				short num3 = num;
				num = (short)1278803968;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.Visible;
			}
			set
			{
				short num = (short)1334645611;
				short num2 = num;
				num = (short)437916523;
				switch (num2 == num)
				{
				}
				num = (short)1621884929;
				if (num != 0)
				{
				}
				num = (short)524222464;
				short num3 = num;
				num = (short)410124288;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemotemonitorfrequencyoption.Visible = value;
			}
		}

		// Token: 0x170060DB RID: 24795
		// (get) Token: 0x0600C0BC RID: 49340 RVA: 0x00B1C14C File Offset: 0x00B1A34C
		// (set) Token: 0x0600C0BD RID: 49341 RVA: 0x00B1C204 File Offset: 0x00B1A404
		public bool CnvPerASTROCallRemotemonitorfrequencyoption_Editable
		{
			get
			{
				short num = (short)1946845310;
				short num2 = num;
				num = (short)2093252734;
				switch (num2 == num)
				{
				}
				num = (short)808124416;
				if (num != 0)
				{
				}
				num = (short)1673723904;
				short num3 = num;
				num = (short)1873608705;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.Editable;
			}
			set
			{
				short num = (short)2033682631;
				short num2 = num;
				num = (short)1836157127;
				switch (num2 == num)
				{
				}
				num = (short)2053505025;
				if (num != 0)
				{
				}
				num = (short)1944453120;
				short num3 = num;
				num = (short)1355415552;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemotemonitorfrequencyoption.Editable = value;
			}
		}

		// Token: 0x170060DC RID: 24796
		// (get) Token: 0x0600C0BE RID: 49342 RVA: 0x00B1C2BC File Offset: 0x00B1A4BC
		internal string CnvPerASTROCallRemotemonitorfrequencyoption_UILabel
		{
			get
			{
				short num = (short)635292965;
				short num2 = num;
				num = (short)94883109;
				switch (num2 == num)
				{
				}
				num = (short)826081281;
				if (num != 0)
				{
				}
				num = (short)1994915840;
				short num3 = num;
				num = (short)1042087936;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.UIName;
			}
		}

		// Token: 0x170060DD RID: 24797
		// (get) Token: 0x0600C0BF RID: 49343 RVA: 0x00B1C370 File Offset: 0x00B1A570
		// (set) Token: 0x0600C0C0 RID: 49344 RVA: 0x00B1C424 File Offset: 0x00B1A624
		internal bool CnvPerASTROCallRemotemonitorfrequencyoption_HiddenStatic
		{
			get
			{
				short num = (short)1945674316;
				short num2 = num;
				num = (short)2003739212;
				switch (num2 == num)
				{
				}
				num = (short)62521345;
				if (num != 0)
				{
				}
				num = (short)2138112000;
				short num3 = num;
				num = (short)120455168;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.HiddenStatic;
			}
			set
			{
				short num = (short)1373603822;
				short num2 = num;
				num = (short)1570408430;
				switch (num2 == num)
				{
				}
				num = (short)967114752;
				if (num != 0)
				{
				}
				num = (short)914161664;
				short num3 = num;
				num = (short)1009516545;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemotemonitorfrequencyoption.HiddenStatic = value;
			}
		}

		// Token: 0x170060DE RID: 24798
		// (get) Token: 0x0600C0C1 RID: 49345 RVA: 0x00B1C4D8 File Offset: 0x00B1A6D8
		// (set) Token: 0x0600C0C2 RID: 49346 RVA: 0x00B1C58C File Offset: 0x00B1A78C
		internal bool CnvPerASTROCallRemotemonitorfrequencyoption_HiddenDynamic
		{
			get
			{
				short num = (short)719519745;
				if (num != 0)
				{
				}
				num = (short)40999455;
				short num2 = num;
				num = (short)69114399;
				switch (num2 == num)
				{
				}
				num = (short)539951104;
				short num3 = num;
				num = (short)1675755520;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption.HiddenDynamic;
			}
			set
			{
				short num = (short)734307156;
				short num2 = num;
				num = (short)1324786516;
				switch (num2 == num)
				{
				}
				num = (short)967507968;
				if (num != 0)
				{
				}
				num = (short)1565327360;
				short num3 = num;
				num = (short)585039873;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemotemonitorfrequencyoption.HiddenDynamic = value;
			}
		}

		// Token: 0x170060DF RID: 24799
		// (get) Token: 0x0600C0C3 RID: 49347 RVA: 0x00B1C640 File Offset: 0x00B1A840
		public bool CnvPerASTROCallRemotemonitorfrequencyoption_HasDiffs
		{
			get
			{
				short num = (short)1406468097;
				if (num != 0)
				{
				}
				num = (short)1607609682;
				short num2 = num;
				num = (short)1477193042;
				switch (num2 == num)
				{
				}
				num = (short)42401792;
				short num3 = num;
				num = (short)96993280;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemotemonitorfrequencyoption._HasDiffs;
			}
		}

		// Token: 0x170060E0 RID: 24800
		// (get) Token: 0x0600C0C4 RID: 49348 RVA: 0x00B1C6F4 File Offset: 0x00B1A8F4
		// (set) Token: 0x0600C0C5 RID: 49349 RVA: 0x00B1C7A4 File Offset: 0x00B1A9A4
		public int CnvPerASTROCallRemoteMonitorTxRxTimeValue
		{
			get
			{
				short num = (short)310276215;
				short num2 = num;
				num = (short)706965623;
				switch (num2 == num)
				{
				}
				num = (short)1317863424;
				if (num != 0)
				{
				}
				num = (short)2084044800;
				short num3 = num;
				num = (short)2099642369;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.Value;
			}
			set
			{
				short num = (short)1982375025;
				short num2 = num;
				num = (short)1236509809;
				switch (num2 == num)
				{
				}
				num = (short)1416626177;
				if (num != 0)
				{
				}
				num = (short)548274176;
				short num3 = num;
				num = (short)40173568;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.Value = value;
			}
		}

		// Token: 0x170060E1 RID: 24801
		// (get) Token: 0x0600C0C6 RID: 49350 RVA: 0x00B1C85C File Offset: 0x00B1AA5C
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvPerASTROCallRemoteMonitorTxRxTime
		{
			get
			{
				short num = (short)1716288279;
				short num2 = num;
				num = (short)2135849751;
				switch (num2 == num)
				{
				}
				num = (short)2062221312;
				if (num != 0)
				{
				}
				num = (short)543424512;
				short num3 = num;
				num = (short)120979457;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime;
			}
		}

		// Token: 0x170060E2 RID: 24802
		// (get) Token: 0x0600C0C7 RID: 49351 RVA: 0x00B1C90C File Offset: 0x00B1AB0C
		// (set) Token: 0x0600C0C8 RID: 49352 RVA: 0x00B1C9C0 File Offset: 0x00B1ABC0
		public string CnvPerASTROCallRemoteMonitorTxRxTime_UIValue
		{
			get
			{
				short num = (short)4793770;
				short num2 = num;
				num = (short)1245193642;
				switch (num2 == num)
				{
				}
				num = (short)604372993;
				if (num != 0)
				{
				}
				num = (short)650510336;
				short num3 = num;
				num = (short)493617152;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.UIValue;
			}
			set
			{
				short num = (short)1548461047;
				short num2 = num;
				num = (short)1518314487;
				switch (num2 == num)
				{
				}
				num = (short)597360641;
				if (num != 0)
				{
				}
				num = (short)547749888;
				short num3 = num;
				num = (short)1232994304;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.UIValue = value;
			}
		}

		// Token: 0x170060E3 RID: 24803
		// (get) Token: 0x0600C0C9 RID: 49353 RVA: 0x00B1CA78 File Offset: 0x00B1AC78
		// (set) Token: 0x0600C0CA RID: 49354 RVA: 0x00B1CB30 File Offset: 0x00B1AD30
		internal int CnvPerASTROCallRemoteMonitorTxRxTimeMin
		{
			get
			{
				short num = (short)242679809;
				if (num != 0)
				{
				}
				num = (short)971412204;
				short num2 = num;
				num = (short)265523948;
				switch (num2 == num)
				{
				}
				num = (short)638386176;
				short num3 = num;
				num = (short)1173749760;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.Min;
			}
			set
			{
				short num = (short)1653360594;
				short num2 = num;
				num = (short)469583826;
				switch (num2 == num)
				{
				}
				num = (short)991428609;
				if (num != 0)
				{
				}
				num = (short)1960574976;
				short num3 = num;
				num = (short)1965490176;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.Min = value;
			}
		}

		// Token: 0x170060E4 RID: 24804
		// (get) Token: 0x0600C0CB RID: 49355 RVA: 0x00B1CBE4 File Offset: 0x00B1ADE4
		// (set) Token: 0x0600C0CC RID: 49356 RVA: 0x00B1CC9C File Offset: 0x00B1AE9C
		internal int CnvPerASTROCallRemoteMonitorTxRxTimeMax
		{
			get
			{
				short num = (short)451631225;
				short num2 = num;
				num = (short)1246845049;
				switch (num2 == num)
				{
				}
				num = (short)846528513;
				if (num != 0)
				{
				}
				num = (short)640548864;
				short num3 = num;
				num = (short)279773184;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.Max;
			}
			set
			{
				short num = (short)1128501560;
				short num2 = num;
				num = (short)190878008;
				switch (num2 == num)
				{
				}
				num = (short)345243649;
				if (num != 0)
				{
				}
				num = (short)357236736;
				short num3 = num;
				num = (short)2086141952;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.Max = value;
			}
		}

		// Token: 0x170060E5 RID: 24805
		// (get) Token: 0x0600C0CD RID: 49357 RVA: 0x00B1CD54 File Offset: 0x00B1AF54
		// (set) Token: 0x0600C0CE RID: 49358 RVA: 0x00B1CE0C File Offset: 0x00B1B00C
		internal int CnvPerASTROCallRemoteMonitorTxRxTimeStep
		{
			get
			{
				short num = (short)1857622692;
				short num2 = num;
				num = (short)924193444;
				switch (num2 == num)
				{
				}
				num = (short)1398865921;
				if (num != 0)
				{
				}
				num = (short)1610088448;
				short num3 = num;
				num = (short)814350336;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.StepSize;
			}
			set
			{
				short num = (short)1558015537;
				short num2 = num;
				num = (short)21524017;
				switch (num2 == num)
				{
				}
				num = (short)97124352;
				if (num != 0)
				{
				}
				num = (short)270204928;
				short num3 = num;
				num = (short)826212353;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.StepSize = value;
			}
		}

		// Token: 0x170060E6 RID: 24806
		// (get) Token: 0x0600C0CF RID: 49359 RVA: 0x00B1CEC4 File Offset: 0x00B1B0C4
		// (set) Token: 0x0600C0D0 RID: 49360 RVA: 0x00B1CF7C File Offset: 0x00B1B17C
		public bool CnvPerASTROCallRemoteMonitorTxRxTime_Applicable
		{
			get
			{
				short num = (short)1412513017;
				short num2 = num;
				num = (short)1691827449;
				switch (num2 == num)
				{
				}
				num = (short)596312064;
				if (num != 0)
				{
				}
				num = (short)157024256;
				short num3 = num;
				num = (short)580386817;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.Applicable;
			}
			set
			{
				short num = (short)376176587;
				short num2 = num;
				num = (short)2085289931;
				switch (num2 == num)
				{
				}
				num = (short)1635319809;
				if (num != 0)
				{
				}
				num = (short)1899823104;
				short num3 = num;
				num = (short)130875392;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.Applicable = value;
			}
		}

		// Token: 0x170060E7 RID: 24807
		// (get) Token: 0x0600C0D1 RID: 49361 RVA: 0x00B1D030 File Offset: 0x00B1B230
		// (set) Token: 0x0600C0D2 RID: 49362 RVA: 0x00B1D0E4 File Offset: 0x00B1B2E4
		public bool CnvPerASTROCallRemoteMonitorTxRxTime_Valid
		{
			get
			{
				short num = (short)244551296;
				short num2 = num;
				num = (short)249859712;
				switch (num2 == num)
				{
				}
				num = (short)1247608833;
				if (num != 0)
				{
				}
				num = (short)728956928;
				short num3 = num;
				num = (short)1821573120;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.Valid;
			}
			set
			{
				short num = (short)186843137;
				if (num != 0)
				{
				}
				num = (short)1631926575;
				short num2 = num;
				num = (short)1160722735;
				switch (num2 == num)
				{
				}
				num = (short)581894144;
				short num3 = num;
				num = (short)504627200;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.Valid = value;
			}
		}

		// Token: 0x170060E8 RID: 24808
		// (get) Token: 0x0600C0D3 RID: 49363 RVA: 0x00B1D198 File Offset: 0x00B1B398
		// (set) Token: 0x0600C0D4 RID: 49364 RVA: 0x00B1D24C File Offset: 0x00B1B44C
		public bool CnvPerASTROCallRemoteMonitorTxRxTime_Visible
		{
			get
			{
				short num = (short)1599133481;
				short num2 = num;
				num = (short)1669977897;
				switch (num2 == num)
				{
				}
				num = (short)1586495488;
				if (num != 0)
				{
				}
				num = (short)1595080704;
				short num3 = num;
				num = (short)1821179905;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.Visible;
			}
			set
			{
				short num = (short)1789657089;
				if (num != 0)
				{
				}
				num = (short)1768971359;
				short num2 = num;
				num = (short)1056726111;
				switch (num2 == num)
				{
				}
				num = (short)2006908928;
				short num3 = num;
				num = (short)897646592;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.Visible = value;
			}
		}

		// Token: 0x170060E9 RID: 24809
		// (get) Token: 0x0600C0D5 RID: 49365 RVA: 0x00B1D300 File Offset: 0x00B1B500
		// (set) Token: 0x0600C0D6 RID: 49366 RVA: 0x00B1D3B8 File Offset: 0x00B1B5B8
		public bool CnvPerASTROCallRemoteMonitorTxRxTime_Editable
		{
			get
			{
				short num = (short)1093599233;
				if (num != 0)
				{
				}
				num = (short)733336514;
				short num2 = num;
				num = (short)826266562;
				switch (num2 == num)
				{
				}
				num = (short)253952000;
				short num3 = num;
				num = (short)1175584768;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.Editable;
			}
			set
			{
				short num = (short)1083580583;
				short num2 = num;
				num = (short)837034151;
				switch (num2 == num)
				{
				}
				num = (short)1884487681;
				if (num != 0)
				{
				}
				num = (short)1515585536;
				short num3 = num;
				num = (short)1769013248;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.Editable = value;
			}
		}

		// Token: 0x170060EA RID: 24810
		// (get) Token: 0x0600C0D7 RID: 49367 RVA: 0x00B1D46C File Offset: 0x00B1B66C
		internal string CnvPerASTROCallRemoteMonitorTxRxTime_UILabel
		{
			get
			{
				short num = (short)2099397297;
				short num2 = num;
				num = (short)1247101617;
				switch (num2 == num)
				{
				}
				num = (short)1911750656;
				if (num != 0)
				{
				}
				num = (short)1963786240;
				short num3 = num;
				num = (short)1018298369;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.UIName;
			}
		}

		// Token: 0x170060EB RID: 24811
		// (get) Token: 0x0600C0D8 RID: 49368 RVA: 0x00B1D520 File Offset: 0x00B1B720
		// (set) Token: 0x0600C0D9 RID: 49369 RVA: 0x00B1D5D8 File Offset: 0x00B1B7D8
		internal bool CnvPerASTROCallRemoteMonitorTxRxTime_HiddenStatic
		{
			get
			{
				short num = (short)1935818681;
				short num2 = num;
				num = (short)721371065;
				switch (num2 == num)
				{
				}
				num = (short)84213760;
				if (num != 0)
				{
				}
				num = (short)1606942720;
				short num3 = num;
				num = (short)141033473;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.HiddenStatic;
			}
			set
			{
				short num = (short)402489514;
				short num2 = num;
				num = (short)591954090;
				switch (num2 == num)
				{
				}
				num = (short)1615200257;
				if (num != 0)
				{
				}
				num = (short)453115904;
				short num3 = num;
				num = (short)409600000;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.HiddenStatic = value;
			}
		}

		// Token: 0x170060EC RID: 24812
		// (get) Token: 0x0600C0DA RID: 49370 RVA: 0x00B1D690 File Offset: 0x00B1B890
		// (set) Token: 0x0600C0DB RID: 49371 RVA: 0x00B1D744 File Offset: 0x00B1B944
		internal bool CnvPerASTROCallRemoteMonitorTxRxTime_HiddenDynamic
		{
			get
			{
				short num = (short)2056497703;
				short num2 = num;
				num = (short)894609959;
				switch (num2 == num)
				{
				}
				num = (short)1727660033;
				if (num != 0)
				{
				}
				num = (short)829751296;
				short num3 = num;
				num = (short)1863122944;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime.HiddenDynamic;
			}
			set
			{
				short num = (short)831913985;
				if (num != 0)
				{
				}
				num = (short)1364684738;
				short num2 = num;
				num = (short)1882288066;
				switch (num2 == num)
				{
				}
				num = (short)149225472;
				short num3 = num;
				num = (short)1949827072;
				if (num != 0)
				{
				}
				this.cnvPerASTROCallRemoteMonitorTxRxTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170060ED RID: 24813
		// (get) Token: 0x0600C0DC RID: 49372 RVA: 0x00B1D7F8 File Offset: 0x00B1B9F8
		public bool CnvPerASTROCallRemoteMonitorTxRxTime_HasDiffs
		{
			get
			{
				short num = (short)1278544285;
				short num2 = num;
				num = (short)1364199837;
				switch (num2 == num)
				{
				}
				num = (short)1348993025;
				if (num != 0)
				{
				}
				num = (short)1844248576;
				short num3 = num;
				num = (short)984154112;
				if (num != 0)
				{
				}
				return this.cnvPerASTROCallRemoteMonitorTxRxTime._HasDiffs;
			}
		}

		// Token: 0x170060EE RID: 24814
		// (get) Token: 0x0600C0DD RID: 49373 RVA: 0x00B1D8AC File Offset: 0x00B1BAAC
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)934569544;
				short num2 = num;
				num = (short)422405704;
				switch (num2 == num)
				{
				}
				num = (short)321585153;
				if (num != 0)
				{
				}
				num = (short)283574272;
				short num3 = num;
				num = (short)1873870848;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x170060EF RID: 24815
		// (get) Token: 0x0600C0DE RID: 49374 RVA: 0x00B1D96C File Offset: 0x00B1BB6C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioLock
		{
			get
			{
				short num = (short)1526675842;
				short num2 = num;
				num = (short)1251293570;
				switch (num2 == num)
				{
				}
				num = (short)947781633;
				if (num != 0)
				{
				}
				num = (short)515506176;
				short num3 = num;
				num = (short)347209728;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170060F0 RID: 24816
		// (get) Token: 0x0600C0DF RID: 49375 RVA: 0x00B1DA30 File Offset: 0x00B1BC30
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1450871082;
				short num2 = num;
				num = (short)1162578218;
				switch (num2 == num)
				{
				}
				num = (short)1547960320;
				if (num != 0)
				{
				}
				num = (short)2097414144;
				short num3 = num;
				num = (short)317456385;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x00B1DAEC File Offset: 0x00B1BCEC
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
					num2 = (short)1764919791;
					short num3 = num2;
					num2 = (short)162630127;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
					{
						num2 = (short)18022400;
						if (num2 != 0)
						{
						}
						num2 = (short)1941831680;
						short num4 = num2;
						num2 = (short)168427521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)936837122;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_85;
				case 3:
					num2 = (short)1947598848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)762707971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_85:
			num2 = (short)311427073;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1623326724;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005C45 RID: 23621
		private global::AcpBusinessLayer.AcpRecRefField cnvPerASTROCallASTROCallHotList_A7488;

		// Token: 0x04005C46 RID: 23622
		private global::AcpBusinessLayer.AcpField<bool> cnvPerASTROCallASTROUnlimitedCalling_A7501;

		// Token: 0x04005C47 RID: 23623
		private global::AcpBusinessLayer.AcpField<bool> cnvPerASTROCallAutoSelectiveCallTransmit_A7518;

		// Token: 0x04005C48 RID: 23624
		private global::AcpBusinessLayer.AcpListField cnvPerASTROCallCallAlertRxTx_A7586;

		// Token: 0x04005C49 RID: 23625
		private global::AcpBusinessLayer.AcpField<bool> cnvPerASTROCallInCallUserAlertEnable_A8250;

		// Token: 0x04005C4A RID: 23626
		private global::AcpBusinessLayer.AcpListField cnvPerASTROCallSelectiveCallRxTx_A9114;

		// Token: 0x04005C4B RID: 23627
		private global::AcpBusinessLayer.AcpListField cnvPerTacticalInhibitKillOperation_A41553;

		// Token: 0x04005C4C RID: 23628
		private global::AcpBusinessLayer.AcpListField cnvPerTacticalInhibitStunOperation_A41557;

		// Token: 0x04005C4D RID: 23629
		private global::AcpBusinessLayer.AcpListField cnvPerASTROCallTacticalServicesOperation;

		// Token: 0x04005C4E RID: 23630
		private global::AcpBusinessLayer.AcpListField cnvPerASTROCallRadioUninhibitDecodeAction_A9045;

		// Token: 0x04005C4F RID: 23631
		private global::AcpBusinessLayer.AcpRecRefField cnvPerASTROCallRemotemonitorfrequencyoption;

		// Token: 0x04005C50 RID: 23632
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvPerASTROCallRemoteMonitorTxRxTime;
	}
}
