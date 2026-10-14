using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000ED RID: 237
	[global::System.Serializable]
	public class ASTROOTARInformation : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060022F8 RID: 8952 RVA: 0x002247AC File Offset: 0x002229AC
		public ASTROOTARInformation(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x002247C8 File Offset: 0x002229C8
		protected ASTROOTARInformation(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x002247E0 File Offset: 0x002229E0
		public override void Init()
		{
			int a_ = 9;
			short num = (short)410106410;
			short num2 = num;
			num = (short)2022554154;
			switch (num2 == num)
			{
			default:
			{
				num = (short)320208896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)660799489;
			if (num != 0)
			{
			}
			num = (short)631046144;
			if (num != 0)
			{
			}
			this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃䌅稇欉缋欍䀏怑焓怕焗甙椛洝欟䜡崣唥䴧帩䌫䀭缯昱申搵笷刹崻倽✿❁⭃ぅⵇ㡉ፋཌྷ杏歑捓湕", a_), global::CommonResources.AcgResources.ID_ERASEPREVIOUSKEYSETONOTARCHANGEOVER);
			this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.DataTransferOrder = 9;
			this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃伅昇渉攋砍礏瘑愓眕琗嬙伛䨝爟洡欣爥椧砩縫伭启嬱嬳缵簷改紻ؽ爿穁煃", a_), global::CommonResources.AcgResources.ID_INDIVIDUALASTROOTARRADIOID, 0, 9999999, null, null, 0, 1);
			this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.DataTransferOrder = 99;
			this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.ShowHexValue = false;
			this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃䤅將䬉帋對栏䄑焓甕洗栙甛樝够渡䄣倥䴧䘩猫漭࠯б̳ȵ", a_), global::CommonResources.AcgResources.ID_OTARRXSECURITYLEVEL, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LOVs.SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674LovStrs);
			this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.DataTransferOrder = 7;
			this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃䤅將䬉帋娍栏䄑焓甕洗栙甛樝够渡䄣倥䴧䘩猫漭࠯б̳ĵ", a_), global::CommonResources.AcgResources.ID_OTARTXSECURITYLEVEL, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LOVs.SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677LovStrs);
			this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.DataTransferOrder = 8;
			this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃吅洇愉椋眍䈏眑攓挕紗椙栛䴝吟䌡倣匥嬧欩䀫䬭䈯䘱怳夵嘷弹挻缽砿筁癃繅", a_), global::CommonResources.AcgResources.ID_REKEYREQUESTSTATUSALERTTONE);
			this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.DataTransferOrder = 10;
			this.secKmfProfASTROOTARInformationResponseKind_A8947 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃吅洇礉簋愍縏愑焓崕焗琙砛䄝感ᨡᴣሥἧ", a_), global::CommonResources.AcgResources.ID_RESPONSEKIND, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LOVs.SecKmfProfASTROOTARInformationResponseKind_A8947LovStrs);
			this.secKmfProfASTROOTARInformationResponseKind_A8947.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationResponseKind_A8947.DataTransferOrder = 2;
			this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃包笇漉縋崍甏縑焓甕気笙縛爝䔟瀡䄣䴥䴧匩縫䬭䄯䜱儳䔵䰷改紻ܽ瘿牁籃", a_), global::CommonResources.AcgResources.ID_USERSELECTABLEREKEYREQUEST);
			this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.DataTransferOrder = 11;
			this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃䴅洇猉挋栍䌏眑眓挕樗缙圛匝星爡嘣䤥丧䌩䀫䬭漯猱Գеืహ༻", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILE, 14, new string[]
			{
				global::CommonResources.AcgResources.ID_SECUREKMFPROFILE
			});
			this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.DataTransferOrder = 3;
			this.secKmfProfASTROOTARInformationNumberofAttempts_A8576 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃䠅紇有渋欍戏紑爓圕気渙礛猝借嘡圣礥椧ሩᤫ᤭د", a_), global::CommonResources.AcgResources.ID_NUMBEROFATTEMPTS, 1, 10, null, null, 0, 1);
			this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.DataTransferOrder = 5;
			this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.ShowHexValue = false;
			this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673 = new global::AcpBusinessLayer.AcpSimpleRangeField(72, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃䤅將䬉帋䜍縏猑眓戕焗氙甛樝够瘡䴣䬥䴧堩䐫尭漯猱ళ5༷ह", a_), global::CommonResources.AcgResources.ID_OTARINACTIVITYTIMERHRS, 1, 168, null, null, 0, 1);
			this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.DataTransferOrder = 6;
			this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.ShowHexValue = false;
			this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375 = new global::AcpBusinessLayer.AcpRangeField<int, string>(15, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鿝돟뛡뛣ꧥ꟧뻩귫볭맯鳱鋳駵諷韹鷻諽槿洁樃刅愇有椋䰍甏昑挓猕紗琙崛樝吟䜡䤣嘥尧天弫䬭匯洱申༵ଷഹऻ", a_), global::CommonResources.AcgResources.ID_TIMEBETWEENATTEMPTSSEC, 5, 90, 5);
			this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.DataTransferOrder = 15;
			this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.ShowHexValue = false;
			this.secKmfProfRadioInhibitViaASTROOTAR_43690 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛賝臟蛡跣觥ꇧ蓩蓫蟭鋯鯱胳ꃵ釷鯹뷻귽哿倁䬃䤅將䬉帋儍␏ℑ∓⼕⠗", a_), global::CommonResources.AcgResources.ID_RADIOINHIBITVIAASTROOTAR);
			this.secKmfProfRadioInhibitViaASTROOTAR_43690.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfRadioInhibitViaASTROOTAR_43690.DataTransferOrder = 94;
			this.kMFRSI = new global::AcpBusinessLayer.AcpSimpleRangeField(9999999, this, global::AllFeatures.CodeplugGuid.b("臉臋裍苏臑鷓", a_), global::CommonResources.AcgResources.ID_KMF_RSI, 1, 9999999, null, null, 0, 1);
			this.kMFRSI.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.kMFRSI.DataTransferOrder = -1;
			this.messageNumberPeriod = new global::AcpBusinessLayer.AcpSimpleRangeField(65535, this, global::AllFeatures.CodeplugGuid.b("蟉꧋뷍ꏏ돑돓돕雗꿙뇛볝藟郡듣菥髧菩菫諭", a_), global::CommonResources.AcgResources.ID_MNP, 2, 65535, null, null, 0, 1);
			this.messageNumberPeriod.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.messageNumberPeriod.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诉鿋髍苏鷑駕賗鯙軛ﻝ꧟賡苣觥髧蟩跫髭駯鷱髳", a_);
			base.Id = 10124;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTARINFORMATION;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00224C68 File Offset: 0x00222E68
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)121307156;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䐌愎甐稒挔縖紘渚簜猞怠瀢焤甦昨搪礬渮挰愲吴匶倸吺琼笾Ṁɂ組畆煈繊", a_), global::CommonResources.AcgResources.ID_INDIVIDUALASTROOTARRADIOID, null, null, 0, 1);
					this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.DataTransferOrder = 99;
					this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.ShowHexValue = false;
					num = (short)1778057230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䐌愎甐稒挔縖紘渚簜猞怠瀢焤甦昨搪礬渮挰愲吴匶倸吺琼笾Ṁɂ組畆煈繊", a_)))
					{
						num = (short)1818886144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_564;
				case 2:
					this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673 = new global::AcpBusinessLayer.AcpSimpleRangeField(72, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䈌嬎倐䄒尔礖砘砚検瘞圠䨢儤带紨䈪䀬䨮䌰嬲䜴栶砸଼̺࠾牀", a_), global::CommonResources.AcgResources.ID_OTARINACTIVITYTIMERHRS, null, null, 0, 1);
					this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.DataTransferOrder = 6;
					this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.ShowHexValue = false;
					num = (short)603127826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_4D9;
				case 4:
					this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䘌樎栐簒猔䐖簘砚栜洞䐠栢栤愦礨太䈬䤮堰弲倴栶砸਺༼ा着灂", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILE, 14, new string[]
					{
						global::CommonResources.AcgResources.ID_SECUREKMFPROFILE
					});
					this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.DataTransferOrder = 3;
					num = (short)1023475743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䈌嬎倐䄒䄔漖䨘縚縜樞匠䨢儤带攨个嬬䨮崰氲琴༶༸఺਼", a_), global::CommonResources.AcgResources.ID_OTARTXSECURITYLEVEL, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LOVs.SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677LovStrs);
					this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.DataTransferOrder = 8;
					num = (short)683409446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)805371905;
					if (num != 0)
					{
					}
					goto IL_91A;
				case 7:
					this.secKmfProfASTROOTARInformationResponseKind_A8947 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊弌樎成挒稔礖樘縚嘜瘞传䜢稤昦ᄨሪ᤬ᠮ", a_), global::CommonResources.AcgResources.ID_RESPONSEKIND, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LOVs.SecKmfProfASTROOTARInformationResponseKind_A8947LovStrs);
					this.secKmfProfASTROOTARInformationResponseKind_A8947.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationResponseKind_A8947.DataTransferOrder = 2;
					num = (short)1719009290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_87F;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䌌税簐焒瀔攖瘘級尜欞唠䘢䠤圦崨堪爬渮रزȴĶ", a_)))
					{
						num = (short)1437794316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_91A;
				case 10:
				{
					num = (short)540606464;
					short num3 = num;
					goto IL_140;
				}
				case 11:
					this.secKmfProfRadioInhibitViaASTROOTAR_43690 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢럤蛦跨苪苬ꛮ鿰鯲鳴闶郸迺꯼雾怀䈂嘄匆嬈䐊䈌嬎倐䄒䨔⌖⨘ⴚ␜⼞", a_), global::CommonResources.AcgResources.ID_RADIOINHIBITVIAASTROOTAR);
					this.secKmfProfRadioInhibitViaASTROOTAR_43690.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfRadioInhibitViaASTROOTAR_43690.DataTransferOrder = 94;
					num = (short)1209270275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.secKmfProfASTROOTARInformationNumberofAttempts_A8576 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䌌税簐焒瀔攖瘘級尜欞唠䘢䠤圦崨堪爬渮रزȴĶ", a_), global::CommonResources.AcgResources.ID_NUMBEROFATTEMPTS, null, null, 0, 1);
					this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.DataTransferOrder = 5;
					this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.ShowHexValue = false;
					num = (short)1037434886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)237386396;
					short num4 = num;
					num = (short)1282488988;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_798;
					default:
						num = (short)888799232;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊弌樎成挒稔礖樘縚嘜瘞传䜢稤昦ᄨሪ᤬ᠮ", a_)))
						{
							num = (short)1270153223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140;
					}
					break;
				}
				case 14:
					goto IL_564;
				case 15:
					this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䈌嬎倐䄒䜔漖䨘縚縜樞匠䨢儤带攨个嬬䨮崰氲琴༶༸఺़", a_), global::CommonResources.AcgResources.ID_OTARRXSECURITYLEVEL, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LOVs.SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674LovStrs);
					this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.DataTransferOrder = 7;
					num = (short)445448200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_5B1;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䈌嬎倐䄒䄔漖䨘縚縜樞匠䨢儤带攨个嬬䨮崰氲琴༶༸఺਼", a_)))
					{
						num = (short)1925120005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4DE;
				case 18:
					goto IL_43B;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䈌嬎倐䄒尔礖砘砚検瘞圠䨢儤带紨䈪䀬䨮䌰嬲䜴栶砸଼̺࠾牀", a_)))
					{
						num = (short)1902837762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43B;
				case 20:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢럤蛦跨苪苬ꛮ鿰鯲鳴闶郸迺꯼雾怀䈂嘄匆嬈䐊䈌嬎倐䄒䨔⌖⨘ⴚ␜⼞", a_)))
					{
						num = (short)111411211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9BD;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊夌明簐瘒圔爖洘氚砜稞传戢儤匦䰨䘪崬嬮䈰䀲倴吶昸稺мా癀療", a_)))
					{
						num = (short)655228952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_313;
				case 23:
					num = (short)2112618528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375 = new global::AcpBusinessLayer.AcpRangeField<int, string>(15, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊夌明簐瘒圔爖洘氚砜稞传戢儤匦䰨䘪崬嬮䈰䀲倴吶昸稺мా癀療", a_), global::CommonResources.AcgResources.ID_TIMEBETWEENATTEMPTSSEC);
					this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.DataTransferOrder = 15;
					this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.ShowHexValue = false;
					num = (short)518389786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_831;
				case 26:
					goto IL_313;
				case 27:
					this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊堌簎琐愒䘔爖甘縚縜欞䀠䄢䤤䈦笨个䘬䨮䠰愲倴䘶䰸帺丼䬾Ṁɂ籄煆祈獊", a_), global::CommonResources.AcgResources.ID_USERSELECTABLEREKEYREQUEST);
					this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.DataTransferOrder = 11;
					num = (short)1271726105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					num = (short)1618542627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䘌樎栐簒猔䐖簘砚栜洞䐠栢栤愦礨太䈬䤮堰弲倴栶砸਺༼ा着灂", a_)))
					{
						num = (short)239534084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F3;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䈌嬎倐䄒䜔漖䨘縚縜樞匠䨢儤带攨个嬬䨮崰氲琴༶༸఺़", a_)))
					{
						num = (short)153419791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_87F;
				case 31:
					goto IL_F3;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䠌紎瀐怒瀔䜖欘縚欜瘞丠嘢嘤氦䰨刪帬䨮䔰尲嬴砶洸稺漼簾⥀≂⭄⁆ⱈ⑊㭌⩎⍐౒ᑔ恖恘汚敜", a_)))
					{
						num = (short)291831847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B1;
				case 33:
					goto IL_798;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊弌樎稐瘒气䔖簘樚栜稞删圢瘤匦䠨弪堬尮瀰弲倴䔶䴸漺刼儾⑀᱂ф罆灈祊界", a_)))
					{
						num = (short)623116324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79A;
				case 35:
					if (producerFields != null)
					{
						num = (short)939982871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9BD;
				case 36:
					this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊弌樎稐瘒气䔖簘樚栜稞删圢瘤匦䠨弪堬尮瀰弲倴䔶䴸漺刼儾⑀᱂ф罆灈祊界", a_), global::CommonResources.AcgResources.ID_REKEYREQUESTSTATUSALERTTONE);
					this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.DataTransferOrder = 10;
					num = (short)226885665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊堌簎琐愒䘔爖甘縚縜欞䀠䄢䤤䈦笨个䘬䨮䠰愲倴䘶䰸帺丼䬾Ṁɂ籄煆祈獊", a_)))
					{
						num = (short)571736091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_831;
				case 38:
					goto IL_4DE;
				case 39:
					this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苐뛒뛔鳖듘뷚跜귞軠藢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴ뻶韸鷺鋼跾氀戂焄渆昈攊䠌紎瀐怒瀔䜖欘縚欜瘞丠嘢嘤氦䰨刪帬䨮䔰尲嬴砶洸稺漼簾⥀≂⭄⁆ⱈ⑊㭌⩎⍐౒ᑔ恖恘汚敜", a_), global::CommonResources.AcgResources.ID_ERASEPREVIOUSKEYSETONOTARCHANGEOVER);
					this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.DataTransferOrder = 9;
					num = (short)163119120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CD:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1396047900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F3:
				num = (short)322371593;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_140:
				num = (short)669253669;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_313:
				num = (short)69533717;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43B:
				num = (short)337117206;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4DE:
				num = (short)1077936162;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_564:
				num = (short)547094558;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5B1:
				num = (short)2081226753;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_79A:
				num = (short)1799618573;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_798:
				goto IL_79A;
				IL_831:
				num = (short)448331805;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_87F:
				num = (short)818741265;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_91A:
				num = (short)1232928787;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4D9:
			IL_9BD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郐胒臔藖雘ﯚ鋜诞ꃠ뇢엤껦蟨跪苬鷮鳰鋲致黶雸闺", a_);
			base.Id = 10124;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTARINFORMATION;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00225664 File Offset: 0x00223864
		public override void PopulateReferences()
		{
			short num = (short)857731159;
			short num2 = num;
			num = (short)1370026071;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1683095552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)251592705;
			if (num != 0)
			{
			}
			num = (short)1043136512;
			if (num != 0)
			{
			}
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00225710 File Offset: 0x00223910
		public override void DropReferences()
		{
			short num = (short)1159331841;
			if (num != 0)
			{
			}
			num = (short)396296192;
			short num2 = num;
			num = (short)1272040943;
			short num3 = num;
			num = (short)331795951;
			switch (num3 == num)
			{
			}
			num = (short)1842413568;
			if (num != 0)
			{
			}
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x002257BC File Offset: 0x002239BC
		public override void SetConstraints()
		{
			short num = (short)1394168154;
			short num2 = num;
			num = (short)324686170;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1915092992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)938803200;
			if (num != 0)
			{
			}
			num = (short)201326593;
			if (num != 0)
			{
			}
			this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConErasePrevKeysetOnOTARChangeoverApp);
			this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConIndividualAstroOtarRadioIdIsValid);
			this.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConNonVisibleWhenOpenFromRMC);
			this.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConSecKmfIndOtarRadioIdEditable);
			this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConOTARRxSecurityLevelValid);
			this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConOTARTxSecurityLevelValid);
			this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secKmfProfASTROOTARInformationResponseKind_A8947.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConAstroOtarEnAndOtarEnAndSecOperIsHwareAndRespKindIsConfirmed);
			this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConAstroOtarEnAndOtarEnAndSecOperIsHwareAndRespKindIsConfirmed);
			this.SecKmfProfRadioInhibitViaASTROOTAR_43690.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadioInhibitViaAstroOtarIsApplicable);
			this.SecKmfProfRadioInhibitViaASTROOTAR_43690.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadioInhibitViaAstroOtarIsValid);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x002259EC File Offset: 0x00223BEC
		public override void SetupDependencies()
		{
			short num = (short)1481709356;
			short num2 = num;
			num = (short)640751404;
			switch (num2 == num)
			{
			}
			num = (short)580452352;
			short num3 = num;
			num = (short)732299264;
			if (num != 0)
			{
			}
			num = (short)2006056961;
			if (num != 0)
			{
			}
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationResponseKind_A8947);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationResponseKind_A8947);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationResponseKind_A8947);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationResponseKind_A8947);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationNumberofAttempts_A8576);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationNumberofAttempts_A8576);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationNumberofAttempts_A8576);
			this.secKmfProfASTROOTARInformationResponseKind_A8947.AddDependentObject(this.secKmfProfASTROOTARInformationNumberofAttempts_A8576);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationNumberofAttempts_A8576);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375);
			this.secKmfProfASTROOTARInformationResponseKind_A8947.AddDependentObject(this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375);
			this.RefSecureWide.General.SecWideGeneralOTAROperation_43700.AddDependentObject(this.SecKmfProfRadioInhibitViaASTROOTAR_43690);
			this.RefSecureWide.General.SecWideGeneralOTAROperation_43700.AddDependentObject(this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfRadioInhibitViaASTROOTAR_43690);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285);
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x00225F6C File Offset: 0x0022416C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1212326409;
				short num2 = num;
				num = (short)791847433;
				switch (num2 == num)
				{
				}
				num = (short)1456865280;
				short num3 = num;
				num = (short)1636433920;
				if (num != 0)
				{
				}
				num = (short)1460076545;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x0022601C File Offset: 0x0022421C
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x002260D0 File Offset: 0x002242D0
		public bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978Value
		{
			get
			{
				short num = (short)323327088;
				short num2 = num;
				num = (short)1304663152;
				switch (num2 == num)
				{
				}
				num = (short)189202432;
				short num3 = num;
				num = (short)101122049;
				if (num != 0)
				{
				}
				num = (short)694026240;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Value;
			}
			set
			{
				short num = (short)1363452605;
				short num2 = num;
				num = (short)1620550333;
				switch (num2 == num)
				{
				}
				num = (short)936837120;
				short num3 = num;
				num = (short)395968513;
				if (num != 0)
				{
				}
				num = (short)1444741120;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Value = value;
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x00226184 File Offset: 0x00224384
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978
		{
			get
			{
				short num = (short)1604294076;
				short num2 = num;
				num = (short)1297847740;
				switch (num2 == num)
				{
				}
				num = (short)1549729792;
				short num3 = num;
				num = (short)71434240;
				if (num != 0)
				{
				}
				num = (short)404291585;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978;
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x00226234 File Offset: 0x00224434
		// (set) Token: 0x06002305 RID: 8965 RVA: 0x002262E8 File Offset: 0x002244E8
		public bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_UIValue
		{
			get
			{
				short num = (short)727973889;
				if (num != 0)
				{
				}
				num = (short)719131979;
				short num2 = num;
				num = (short)2130842955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2017853440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)355860480;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Value;
			}
			set
			{
				short num = (short)1612382209;
				if (num != 0)
				{
				}
				num = (short)654144608;
				short num2 = num;
				num = (short)413430880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)914489344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)552730624;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Value = value;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x002263A0 File Offset: 0x002245A0
		// (set) Token: 0x06002307 RID: 8967 RVA: 0x00226454 File Offset: 0x00224654
		public bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_Applicable
		{
			get
			{
				short num = (short)1384365486;
				short num2 = num;
				num = (short)872857006;
				switch (num2 == num)
				{
				}
				num = (short)1112211456;
				short num3 = num;
				num = (short)128122880;
				if (num != 0)
				{
				}
				num = (short)1847721985;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Applicable;
			}
			set
			{
				short num = (short)1781006337;
				if (num != 0)
				{
				}
				num = (short)332283400;
				short num2 = num;
				num = (short)334249480;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1308491776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1310851072;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Applicable = value;
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x00226508 File Offset: 0x00224708
		// (set) Token: 0x06002309 RID: 8969 RVA: 0x002265BC File Offset: 0x002247BC
		public bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_Valid
		{
			get
			{
				short num = (short)2072362523;
				short num2 = num;
				num = (short)1564655131;
				switch (num2 == num)
				{
				}
				num = (short)1603731456;
				short num3 = num;
				num = (short)576585729;
				if (num != 0)
				{
				}
				num = (short)1987903488;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Valid;
			}
			set
			{
				short num = (short)957743105;
				if (num != 0)
				{
				}
				num = (short)1619422185;
				short num2 = num;
				num = (short)1799908329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2007105536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1663959040;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Valid = value;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x00226678 File Offset: 0x00224878
		// (set) Token: 0x0600230B RID: 8971 RVA: 0x0022672C File Offset: 0x0022492C
		public bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_Visible
		{
			get
			{
				short num = (short)2086587704;
				short num2 = num;
				num = (short)1061342520;
				switch (num2 == num)
				{
				}
				num = (short)1423376384;
				short num3 = num;
				num = (short)1562378241;
				if (num != 0)
				{
				}
				num = (short)1894383616;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Visible;
			}
			set
			{
				short num = (short)2026759424;
				short num2 = num;
				num = (short)617932032;
				switch (num2 == num)
				{
				}
				num = (short)67895296;
				short num3 = num;
				num = (short)352452609;
				if (num != 0)
				{
				}
				num = (short)419889152;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Visible = value;
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x002267E0 File Offset: 0x002249E0
		// (set) Token: 0x0600230D RID: 8973 RVA: 0x00226894 File Offset: 0x00224A94
		public bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_Editable
		{
			get
			{
				short num = (short)549139213;
				short num2 = num;
				num = (short)1762145037;
				switch (num2 == num)
				{
				}
				num = (short)429522944;
				short num3 = num;
				num = (short)1623982080;
				if (num != 0)
				{
				}
				num = (short)1931083777;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Editable;
			}
			set
			{
				short num = (short)646089908;
				short num2 = num;
				num = (short)884313268;
				switch (num2 == num)
				{
				}
				num = (short)929497088;
				short num3 = num;
				num = (short)2003304449;
				if (num != 0)
				{
				}
				num = (short)1918697472;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.Editable = value;
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x0022694C File Offset: 0x00224B4C
		internal string SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_UILabel
		{
			get
			{
				short num = (short)1985682426;
				short num2 = num;
				num = (short)1444813818;
				switch (num2 == num)
				{
				}
				num = (short)457441280;
				short num3 = num;
				num = (short)268369920;
				if (num != 0)
				{
				}
				num = (short)1458569217;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.UIName;
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x00226A00 File Offset: 0x00224C00
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x00226AB8 File Offset: 0x00224CB8
		internal bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_HiddenStatic
		{
			get
			{
				short num = (short)2135744845;
				short num2 = num;
				num = (short)768401741;
				switch (num2 == num)
				{
				}
				num = (short)13107200;
				short num3 = num;
				num = (short)1126891520;
				if (num != 0)
				{
				}
				num = (short)42926081;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.HiddenStatic;
			}
			set
			{
				short num = (short)1906362393;
				short num2 = num;
				num = (short)638961689;
				switch (num2 == num)
				{
				}
				num = (short)102498304;
				short num3 = num;
				num = (short)1758658560;
				if (num != 0)
				{
				}
				num = (short)1331232769;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.HiddenStatic = value;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x00226B6C File Offset: 0x00224D6C
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x00226C20 File Offset: 0x00224E20
		internal bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_HiddenDynamic
		{
			get
			{
				short num = (short)1591926069;
				short num2 = num;
				num = (short)480107829;
				switch (num2 == num)
				{
				}
				num = (short)1456144384;
				short num3 = num;
				num = (short)1446510593;
				if (num != 0)
				{
				}
				num = (short)1482686464;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.HiddenDynamic;
			}
			set
			{
				short num = (short)1000392739;
				short num2 = num;
				num = (short)331860003;
				switch (num2 == num)
				{
				}
				num = (short)1231814656;
				short num3 = num;
				num = (short)342687744;
				if (num != 0)
				{
				}
				num = (short)1695350785;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978.HiddenDynamic = value;
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x00226CD4 File Offset: 0x00224ED4
		public bool SecKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978_HasDiffs
		{
			get
			{
				short num = (short)1566375937;
				if (num != 0)
				{
				}
				num = (short)1610930938;
				short num2 = num;
				num = (short)1991105274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)327614464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909325824;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978._HasDiffs;
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00226D8C File Offset: 0x00224F8C
		// (set) Token: 0x06002315 RID: 8981 RVA: 0x00226E40 File Offset: 0x00225040
		public int SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285Value
		{
			get
			{
				short num = (short)462894720;
				short num2 = num;
				num = (short)1146893952;
				switch (num2 == num)
				{
				}
				num = (short)543490048;
				short num3 = num;
				num = (short)1726742528;
				if (num != 0)
				{
				}
				num = (short)594280449;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value;
			}
			set
			{
				short num = (short)730595329;
				if (num != 0)
				{
				}
				num = (short)890465583;
				short num2 = num;
				num = (short)1859677487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1141112832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)579665920;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value = value;
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x00226EF4 File Offset: 0x002250F4
		public global::AcpBusinessLayer.AcpSimpleRangeField SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285
		{
			get
			{
				short num = (short)1922713912;
				short num2 = num;
				num = (short)1003178296;
				switch (num2 == num)
				{
				}
				num = (short)1117192192;
				short num3 = num;
				num = (short)894173184;
				if (num != 0)
				{
				}
				num = (short)626720769;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285;
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00226FA4 File Offset: 0x002251A4
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x00227058 File Offset: 0x00225258
		public string SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_UIValue
		{
			get
			{
				short num = (short)206327562;
				short num2 = num;
				num = (short)1704021770;
				switch (num2 == num)
				{
				}
				num = (short)285409280;
				short num3 = num;
				num = (short)1332150273;
				if (num != 0)
				{
				}
				num = (short)254345216;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.UIValue;
			}
			set
			{
				short num = (short)1314918369;
				short num2 = num;
				num = (short)1694896097;
				switch (num2 == num)
				{
				}
				num = (short)243728384;
				short num3 = num;
				num = (short)524812288;
				if (num != 0)
				{
				}
				num = (short)749338625;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.UIValue = value;
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x0022710C File Offset: 0x0022530C
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x002271C4 File Offset: 0x002253C4
		internal int SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285Min
		{
			get
			{
				short num = (short)1660880281;
				short num2 = num;
				num = (short)1911948697;
				switch (num2 == num)
				{
				}
				num = (short)1520828416;
				short num3 = num;
				num = (short)646381568;
				if (num != 0)
				{
				}
				num = (short)2094923777;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Min;
			}
			set
			{
				short num = (short)968619359;
				short num2 = num;
				num = (short)1881142623;
				switch (num2 == num)
				{
				}
				num = (short)1787625472;
				short num3 = num;
				num = (short)539164672;
				if (num != 0)
				{
				}
				num = (short)1157300225;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Min = value;
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x0022727C File Offset: 0x0022547C
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x00227334 File Offset: 0x00225534
		internal int SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285Max
		{
			get
			{
				short num = (short)1986507596;
				short num2 = num;
				num = (short)1714533196;
				switch (num2 == num)
				{
				}
				num = (short)725745664;
				short num3 = num;
				num = (short)1709047808;
				if (num != 0)
				{
				}
				num = (short)757530625;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Max;
			}
			set
			{
				short num = (short)1307027998;
				short num2 = num;
				num = (short)438938142;
				switch (num2 == num)
				{
				}
				num = (short)1266876416;
				short num3 = num;
				num = (short)307888129;
				if (num != 0)
				{
				}
				num = (short)1929904128;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Max = value;
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x002273EC File Offset: 0x002255EC
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x002274A4 File Offset: 0x002256A4
		internal int SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285Step
		{
			get
			{
				short num = (short)993396189;
				short num2 = num;
				num = (short)1056638429;
				switch (num2 == num)
				{
				}
				num = (short)27852800;
				short num3 = num;
				num = (short)1071775744;
				if (num != 0)
				{
				}
				num = (short)742064129;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.StepSize;
			}
			set
			{
				short num = (short)1032641059;
				short num2 = num;
				num = (short)1531370019;
				switch (num2 == num)
				{
				}
				num = (short)269746176;
				short num3 = num;
				num = (short)925171712;
				if (num != 0)
				{
				}
				num = (short)1902116865;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.StepSize = value;
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x00227558 File Offset: 0x00225758
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x0022760C File Offset: 0x0022580C
		public bool SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_Applicable
		{
			get
			{
				short num = (short)585192684;
				short num2 = num;
				num = (short)1305302252;
				switch (num2 == num)
				{
				}
				num = (short)1174011904;
				short num3 = num;
				num = (short)1626079232;
				if (num != 0)
				{
				}
				num = (short)1180041217;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Applicable;
			}
			set
			{
				short num = (short)34174049;
				short num2 = num;
				num = (short)869495905;
				switch (num2 == num)
				{
				}
				num = (short)1187840000;
				short num3 = num;
				num = (short)847183873;
				if (num != 0)
				{
				}
				num = (short)1778843648;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Applicable = value;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x002276C0 File Offset: 0x002258C0
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x00227774 File Offset: 0x00225974
		public bool SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_Valid
		{
			get
			{
				short num = (short)666326591;
				short num2 = num;
				num = (short)837834303;
				switch (num2 == num)
				{
				}
				num = (short)2142765056;
				short num3 = num;
				num = (short)1783889921;
				if (num != 0)
				{
				}
				num = (short)570687488;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Valid;
			}
			set
			{
				short num = (short)880423316;
				short num2 = num;
				num = (short)1778659732;
				switch (num2 == num)
				{
				}
				num = (short)1974796288;
				short num3 = num;
				num = (short)684064768;
				if (num != 0)
				{
				}
				num = (short)680198145;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Valid = value;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x0022782C File Offset: 0x00225A2C
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x002278E0 File Offset: 0x00225AE0
		public bool SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_Visible
		{
			get
			{
				short num = (short)599995071;
				short num2 = num;
				num = (short)608776895;
				switch (num2 == num)
				{
				}
				num = (short)327614464;
				short num3 = num;
				num = (short)189136897;
				if (num != 0)
				{
				}
				num = (short)1547632640;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Visible;
			}
			set
			{
				short num = (short)412286977;
				if (num != 0)
				{
				}
				num = (short)1581488944;
				short num2 = num;
				num = (short)1213766448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486670336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)339542016;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Visible = value;
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x00227998 File Offset: 0x00225B98
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x00227A4C File Offset: 0x00225C4C
		public bool SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_Editable
		{
			get
			{
				short num = (short)30827681;
				short num2 = num;
				num = (short)299918497;
				switch (num2 == num)
				{
				}
				num = (short)1422983168;
				short num3 = num;
				num = (short)366411776;
				if (num != 0)
				{
				}
				num = (short)1717305345;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Editable;
			}
			set
			{
				short num = (short)1833125098;
				short num2 = num;
				num = (short)1087194346;
				switch (num2 == num)
				{
				}
				num = (short)469893120;
				short num3 = num;
				num = (short)1717043200;
				if (num != 0)
				{
				}
				num = (short)1238761473;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Editable = value;
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x00227B00 File Offset: 0x00225D00
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x00227BB0 File Offset: 0x00225DB0
		public bool SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_CloneEditable
		{
			get
			{
				short num = (short)694062966;
				short num2 = num;
				num = (short)1321832310;
				switch (num2 == num)
				{
				}
				num = (short)581304320;
				short num3 = num;
				num = (short)800784384;
				if (num != 0)
				{
				}
				num = (short)838139905;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware(this);
			}
			set
			{
				short num = (short)505439565;
				short num2 = num;
				num = (short)1735484749;
				switch (num2 == num)
				{
				}
				num = (short)1208287232;
				short num3 = num;
				num = (short)162856961;
				if (num != 0)
				{
				}
				num = (short)1068892160;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Editable = value;
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x00227C68 File Offset: 0x00225E68
		internal string SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_UILabel
		{
			get
			{
				short num = (short)1585588198;
				short num2 = num;
				num = (short)1030236134;
				switch (num2 == num)
				{
				}
				num = (short)1164640256;
				short num3 = num;
				num = (short)1750925312;
				if (num != 0)
				{
				}
				num = (short)1219035137;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.UIName;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x00227D1C File Offset: 0x00225F1C
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x00227DD0 File Offset: 0x00225FD0
		internal bool SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_HiddenStatic
		{
			get
			{
				short num = (short)431356001;
				short num2 = num;
				num = (short)1225717857;
				switch (num2 == num)
				{
				}
				num = (short)2021195776;
				short num3 = num;
				num = (short)1073348608;
				if (num != 0)
				{
				}
				num = (short)2037776385;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.HiddenStatic;
			}
			set
			{
				short num = (short)1517173760;
				short num2 = num;
				num = (short)1144142848;
				switch (num2 == num)
				{
				}
				num = (short)1959198720;
				short num3 = num;
				num = (short)1312882688;
				if (num != 0)
				{
				}
				num = (short)833552385;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.HiddenStatic = value;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x00227E84 File Offset: 0x00226084
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x00227F3C File Offset: 0x0022613C
		internal bool SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_HiddenDynamic
		{
			get
			{
				short num = (short)1005387777;
				if (num != 0)
				{
				}
				num = (short)1497549776;
				short num2 = num;
				num = (short)829541328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1538260992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)910753792;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.HiddenDynamic;
			}
			set
			{
				short num = (short)1713811368;
				short num2 = num;
				num = (short)142127016;
				switch (num2 == num)
				{
				}
				num = (short)1801781248;
				short num3 = num;
				num = (short)1134166017;
				if (num != 0)
				{
				}
				num = (short)802291712;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.HiddenDynamic = value;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x00227FF0 File Offset: 0x002261F0
		public bool SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285_HasDiffs
		{
			get
			{
				short num = (short)738866595;
				short num2 = num;
				num = (short)138753443;
				switch (num2 == num)
				{
				}
				num = (short)581304320;
				short num3 = num;
				num = (short)1964441600;
				if (num != 0)
				{
				}
				num = (short)1253244929;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285._HasDiffs;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x002280A0 File Offset: 0x002262A0
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x00228154 File Offset: 0x00226354
		public int SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674Value
		{
			get
			{
				short num = (short)1141374977;
				if (num != 0)
				{
				}
				num = (short)800326697;
				short num2 = num;
				num = (short)656016425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1965817856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1268711424;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Value;
			}
			set
			{
				short num = (short)1775322151;
				short num2 = num;
				num = (short)828589095;
				switch (num2 == num)
				{
				}
				num = (short)301334528;
				short num3 = num;
				num = (short)503578624;
				if (num != 0)
				{
				}
				num = (short)1607008257;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Value = value;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00228208 File Offset: 0x00226408
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x002282BC File Offset: 0x002264BC
		public string SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_UIValue
		{
			get
			{
				short num = (short)1872156893;
				short num2 = num;
				num = (short)341498077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2134441984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239796225;
				if (num != 0)
				{
				}
				num = (short)205324288;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.UIValue;
			}
			set
			{
				short num = (short)983069315;
				short num2 = num;
				num = (short)1909355139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)446824448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2119106560;
				if (num != 0)
				{
				}
				num = (short)591659009;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.UIValue = value;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00228370 File Offset: 0x00226570
		public global::AcpBusinessLayer.AcpListField SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674
		{
			get
			{
				short num = (short)552604449;
				short num2 = num;
				num = (short)14684961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)930283520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)332005377;
				if (num != 0)
				{
				}
				num = (short)1775304704;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x00228420 File Offset: 0x00226620
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x002284D8 File Offset: 0x002266D8
		public bool SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_Applicable
		{
			get
			{
				short num = (short)284231116;
				short num2 = num;
				num = (short)791021004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313603584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1914699777;
				if (num != 0)
				{
				}
				num = (short)1508769792;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Applicable;
			}
			set
			{
				short num = (short)742815327;
				short num2 = num;
				num = (short)1523414623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876937216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1401225216;
				if (num != 0)
				{
				}
				num = (short)1421737985;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Applicable = value;
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x0022858C File Offset: 0x0022678C
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x00228640 File Offset: 0x00226840
		public bool SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_Valid
		{
			get
			{
				short num = (short)62128129;
				if (num != 0)
				{
				}
				num = (short)1388052480;
				short num2 = num;
				num = (short)1692000428;
				short num3 = num;
				num = (short)614260908;
				switch (num3 == num)
				{
				}
				num = (short)1507786752;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Valid;
			}
			set
			{
				short num = (short)54605018;
				short num2 = num;
				num = (short)102446298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)298778624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1981743104;
				if (num != 0)
				{
				}
				num = (short)2126118913;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Valid = value;
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x002286F4 File Offset: 0x002268F4
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x002287A8 File Offset: 0x002269A8
		public bool SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_Visible
		{
			get
			{
				short num = (short)485706551;
				short num2 = num;
				num = (short)1076710199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1908932608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)822542336;
				if (num != 0)
				{
				}
				num = (short)1330905089;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Visible;
			}
			set
			{
				short num = (short)363680690;
				short num2 = num;
				num = (short)1481266098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1164836864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)84541440;
				if (num != 0)
				{
				}
				num = (short)1106247681;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Visible = value;
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x0022885C File Offset: 0x00226A5C
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x00228910 File Offset: 0x00226B10
		public bool SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_Editable
		{
			get
			{
				short num = (short)356777985;
				if (num != 0)
				{
				}
				num = (short)994181120;
				short num2 = num;
				num = (short)954369498;
				short num3 = num;
				num = (short)1429964250;
				switch (num3 == num)
				{
				}
				num = (short)116064256;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Editable;
			}
			set
			{
				short num = (short)1560940466;
				short num2 = num;
				num = (short)903679922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1040908288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)421265409;
				if (num != 0)
				{
				}
				num = (short)1630601216;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.Editable = value;
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x002289C4 File Offset: 0x00226BC4
		internal string SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_UILabel
		{
			get
			{
				short num = (short)1361641473;
				if (num != 0)
				{
				}
				num = (short)46071808;
				short num2 = num;
				num = (short)1167884033;
				short num3 = num;
				num = (short)1705737985;
				switch (num3 == num)
				{
				}
				num = (short)1708457984;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.UIName;
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x00228A78 File Offset: 0x00226C78
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00228B30 File Offset: 0x00226D30
		internal bool SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_HiddenStatic
		{
			get
			{
				short num = (short)246221409;
				short num2 = num;
				num = (short)1671039585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)246611968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)948109313;
				if (num != 0)
				{
				}
				num = (short)2067136512;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.HiddenStatic;
			}
			set
			{
				short num = (short)1494586345;
				short num2 = num;
				num = (short)580359145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324023808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)175177729;
				if (num != 0)
				{
				}
				num = (short)1554907136;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.HiddenStatic = value;
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x00228BE4 File Offset: 0x00226DE4
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00228C9C File Offset: 0x00226E9C
		internal bool SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_HiddenDynamic
		{
			get
			{
				short num = (short)1104656445;
				short num2 = num;
				num = (short)871544893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192558592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)294780929;
				if (num != 0)
				{
				}
				num = (short)436076544;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.HiddenDynamic;
			}
			set
			{
				short num = (short)1818165249;
				if (num != 0)
				{
				}
				num = (short)469565440;
				short num2 = num;
				num = (short)1349751237;
				short num3 = num;
				num = (short)502305221;
				switch (num3 == num)
				{
				}
				num = (short)2082996224;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674.HiddenDynamic = value;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00228D54 File Offset: 0x00226F54
		public bool SecKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674_HasDiffs
		{
			get
			{
				short num = (short)1551333451;
				short num2 = num;
				num = (short)480278603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2092564480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2012086272;
				if (num != 0)
				{
				}
				num = (short)213909505;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674._HasDiffs;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x00228E08 File Offset: 0x00227008
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x00228EBC File Offset: 0x002270BC
		public int SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677Value
		{
			get
			{
				short num = (short)941096961;
				if (num != 0)
				{
				}
				num = (short)1478754304;
				short num2 = num;
				num = (short)1905225886;
				short num3 = num;
				num = (short)2109763742;
				switch (num3 == num)
				{
				}
				num = (short)1551826944;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Value;
			}
			set
			{
				short num = (short)785308878;
				short num2 = num;
				num = (short)716430542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1971519488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1059127297;
				if (num != 0)
				{
				}
				num = (short)1010958336;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Value = value;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x00228F70 File Offset: 0x00227170
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x00229024 File Offset: 0x00227224
		public string SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_UIValue
		{
			get
			{
				short num = (short)588667679;
				short num2 = num;
				num = (short)384981791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1423900672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1765539840;
				if (num != 0)
				{
				}
				num = (short)151715841;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.UIValue;
			}
			set
			{
				short num = (short)1335748922;
				short num2 = num;
				num = (short)976546106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1707212800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1533345793;
				if (num != 0)
				{
				}
				num = (short)77987840;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.UIValue = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x002290D8 File Offset: 0x002272D8
		public global::AcpBusinessLayer.AcpListField SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677
		{
			get
			{
				short num = (short)1167410717;
				short num2 = num;
				num = (short)682771997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029505024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1983250432;
				if (num != 0)
				{
				}
				num = (short)1089208321;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x00229188 File Offset: 0x00227388
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00229238 File Offset: 0x00227438
		public bool SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_Applicable
		{
			get
			{
				short num = (short)529203201;
				if (num != 0)
				{
				}
				num = (short)1584857088;
				short num2 = num;
				num = (short)691823479;
				short num3 = num;
				num = (short)887382903;
				switch (num3 == num)
				{
				}
				num = (short)204865536;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Applicable;
			}
			set
			{
				short num = (short)304781387;
				short num2 = num;
				num = (short)28678219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1335230464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307639808;
				if (num != 0)
				{
				}
				num = (short)1837432833;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Applicable = value;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x002292EC File Offset: 0x002274EC
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x002293A0 File Offset: 0x002275A0
		public bool SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_Valid
		{
			get
			{
				short num = (short)1724201133;
				short num2 = num;
				num = (short)393164973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1706688512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)581173248;
				if (num != 0)
				{
				}
				num = (short)1359872001;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Valid;
			}
			set
			{
				short num = (short)1205892525;
				short num2 = num;
				num = (short)1889433005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244004352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1696530433;
				if (num != 0)
				{
				}
				num = (short)818544640;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Valid = value;
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x00229458 File Offset: 0x00227658
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x0022950C File Offset: 0x0022770C
		public bool SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_Visible
		{
			get
			{
				short num = (short)1768492697;
				short num2 = num;
				num = (short)389287577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1908932608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056781824;
				if (num != 0)
				{
				}
				num = (short)1893859329;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Visible;
			}
			set
			{
				short num = (short)637009921;
				if (num != 0)
				{
				}
				num = (short)1496186880;
				short num2 = num;
				num = (short)212432078;
				short num3 = num;
				num = (short)549811406;
				switch (num3 == num)
				{
				}
				num = (short)1633812480;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Visible = value;
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x002295C4 File Offset: 0x002277C4
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00229678 File Offset: 0x00227878
		public bool SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_Editable
		{
			get
			{
				short num = (short)1781927224;
				short num2 = num;
				num = (short)209456440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1905065984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2068971520;
				if (num != 0)
				{
				}
				num = (short)1536425985;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Editable;
			}
			set
			{
				short num = (short)1240892218;
				short num2 = num;
				num = (short)1454408506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1541996544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1514733569;
				if (num != 0)
				{
				}
				num = (short)1974337536;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.Editable = value;
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x00229730 File Offset: 0x00227930
		internal string SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_UILabel
		{
			get
			{
				short num = (short)1507614777;
				short num2 = num;
				num = (short)210001977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)587005952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660733953;
				if (num != 0)
				{
				}
				num = (short)709558272;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.UIName;
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x002297E4 File Offset: 0x002279E4
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x00229898 File Offset: 0x00227A98
		internal bool SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_HiddenStatic
		{
			get
			{
				short num = (short)758972417;
				if (num != 0)
				{
				}
				num = (short)1379729408;
				short num2 = num;
				num = (short)1209192437;
				short num3 = num;
				num = (short)1251004405;
				switch (num3 == num)
				{
				}
				num = (short)48955392;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.HiddenStatic;
			}
			set
			{
				short num = (short)1451749685;
				short num2 = num;
				num = (short)1126166837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)187957248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1607532544;
				if (num != 0)
				{
				}
				num = (short)670367745;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.HiddenStatic = value;
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0022994C File Offset: 0x00227B4C
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x00229A04 File Offset: 0x00227C04
		internal bool SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_HiddenDynamic
		{
			get
			{
				short num = (short)1092579109;
				short num2 = num;
				num = (short)1948348197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1076101120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)496173056;
				if (num != 0)
				{
				}
				num = (short)898498561;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.HiddenDynamic;
			}
			set
			{
				short num = (short)390058305;
				short num2 = num;
				num = (short)320655681;
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
				num = (short)2119892993;
				if (num != 0)
				{
				}
				num = (short)1615593472;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677.HiddenDynamic = value;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x00229AB8 File Offset: 0x00227CB8
		public bool SecKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677_HasDiffs
		{
			get
			{
				short num = (short)1056805722;
				short num2 = num;
				num = (short)1607635802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1043333120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1659568128;
				if (num != 0)
				{
				}
				num = (short)1316356097;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677._HasDiffs;
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00229B70 File Offset: 0x00227D70
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x00229C24 File Offset: 0x00227E24
		public bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928Value
		{
			get
			{
				short num = (short)86427393;
				short num2 = num;
				num = (short)2083899137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)67174400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)393216001;
				if (num != 0)
				{
				}
				num = (short)72876032;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Value;
			}
			set
			{
				short num = (short)1853312800;
				short num2 = num;
				num = (short)1253592864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)356974592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)83951617;
				if (num != 0)
				{
				}
				num = (short)1495924736;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Value = value;
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x00229CD8 File Offset: 0x00227ED8
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928
		{
			get
			{
				short num = (short)1779891714;
				short num2 = num;
				num = (short)1677917698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)393674752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)222560257;
				if (num != 0)
				{
				}
				num = (short)497745920;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928;
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x00229D84 File Offset: 0x00227F84
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x00229E38 File Offset: 0x00228038
		public bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_UIValue
		{
			get
			{
				short num = (short)3896722;
				short num2 = num;
				num = (short)294679954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)59637760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)407240705;
				if (num != 0)
				{
				}
				num = (short)1785462784;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Value;
			}
			set
			{
				short num = (short)1620180154;
				short num2 = num;
				num = (short)1148320954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)518782976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79429632;
				if (num != 0)
				{
				}
				num = (short)1449852929;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Value = value;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x00229EEC File Offset: 0x002280EC
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x00229FA4 File Offset: 0x002281A4
		public bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_Applicable
		{
			get
			{
				short num = (short)116713352;
				short num2 = num;
				num = (short)517990280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097531392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1912602625;
				if (num != 0)
				{
				}
				num = (short)1546715136;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Applicable;
			}
			set
			{
				short num = (short)1013710849;
				if (num != 0)
				{
				}
				num = (short)2058092544;
				short num2 = num;
				num = (short)393561981;
				short num3 = num;
				num = (short)327763837;
				switch (num3 == num)
				{
				}
				num = (short)1435566080;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Applicable = value;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x0022A058 File Offset: 0x00228258
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x0022A10C File Offset: 0x0022830C
		public bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_Valid
		{
			get
			{
				short num = (short)2004082374;
				short num2 = num;
				num = (short)862510790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)878968832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1861877760;
				if (num != 0)
				{
				}
				num = (short)1385824257;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Valid;
			}
			set
			{
				short num = (short)1873687863;
				short num2 = num;
				num = (short)361575735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2049572864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)978780161;
				if (num != 0)
				{
				}
				num = (short)1002438656;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Valid = value;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x0022A1C0 File Offset: 0x002283C0
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x0022A274 File Offset: 0x00228474
		public bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_Visible
		{
			get
			{
				short num = (short)759107701;
				short num2 = num;
				num = (short)1576734837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1531117568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)304283648;
				if (num != 0)
				{
				}
				num = (short)630456321;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Visible;
			}
			set
			{
				short num = (short)475290347;
				short num2 = num;
				num = (short)1151884011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1683226624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17432577;
				if (num != 0)
				{
				}
				num = (short)143261696;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Visible = value;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x0022A328 File Offset: 0x00228528
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x0022A3DC File Offset: 0x002285DC
		public bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_Editable
		{
			get
			{
				short num = (short)166499325;
				short num2 = num;
				num = (short)299602941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)479461376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495597057;
				if (num != 0)
				{
				}
				num = (short)34209792;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Editable;
			}
			set
			{
				short num = (short)1838563363;
				short num2 = num;
				num = (short)495468579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1532035072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2074738689;
				if (num != 0)
				{
				}
				num = (short)1823539200;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.Editable = value;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0022A494 File Offset: 0x00228694
		internal string SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_UILabel
		{
			get
			{
				short num = (short)463252027;
				short num2 = num;
				num = (short)1899145787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1725104128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)706609152;
				if (num != 0)
				{
				}
				num = (short)1300103169;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.UIName;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x0022A548 File Offset: 0x00228748
		// (set) Token: 0x06002364 RID: 9060 RVA: 0x0022A5FC File Offset: 0x002287FC
		internal bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_HiddenStatic
		{
			get
			{
				short num = (short)467096452;
				short num2 = num;
				num = (short)334648196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)121634816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1234567169;
				if (num != 0)
				{
				}
				num = (short)1477312512;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.HiddenStatic;
			}
			set
			{
				short num = (short)1996373769;
				short num2 = num;
				num = (short)550518537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639841792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)210829313;
				if (num != 0)
				{
				}
				num = (short)1972371456;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.HiddenStatic = value;
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x0022A6B4 File Offset: 0x002288B4
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x0022A76C File Offset: 0x0022896C
		internal bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_HiddenDynamic
		{
			get
			{
				short num = (short)147282133;
				short num2 = num;
				num = (short)1648711893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1204682752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1356136449;
				if (num != 0)
				{
				}
				num = (short)1734803456;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.HiddenDynamic;
			}
			set
			{
				short num = (short)1037674762;
				short num2 = num;
				num = (short)1134668042;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1115029504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)607059969;
				if (num != 0)
				{
				}
				num = (short)1111949312;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928.HiddenDynamic = value;
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x0022A820 File Offset: 0x00228A20
		public bool SecKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928_HasDiffs
		{
			get
			{
				short num = (short)842029804;
				short num2 = num;
				num = (short)688872172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1865547776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338703873;
				if (num != 0)
				{
				}
				num = (short)842399744;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928._HasDiffs;
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0022A8D4 File Offset: 0x00228AD4
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x0022A984 File Offset: 0x00228B84
		public int SecKmfProfASTROOTARInformationResponseKind_A8947Value
		{
			get
			{
				short num = (short)1048482495;
				short num2 = num;
				num = (short)438473407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366739456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1331888128;
				if (num != 0)
				{
				}
				num = (short)186056705;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.Value;
			}
			set
			{
				short num = (short)1077280768;
				short num2 = num;
				num = (short)1065815819;
				short num3 = num;
				num = (short)470748939;
				switch (num3 == num)
				{
				}
				num = (short)1891827712;
				if (num != 0)
				{
				}
				num = (short)1656750081;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationResponseKind_A8947.Value = value;
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x0022AA3C File Offset: 0x00228C3C
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x0022AAF0 File Offset: 0x00228CF0
		public string SecKmfProfASTROOTARInformationResponseKind_A8947_UIValue
		{
			get
			{
				short num = (short)890961920;
				short num2 = num;
				num = (short)1682668246;
				short num3 = num;
				num = (short)1585674966;
				switch (num3 == num)
				{
				}
				num = (short)1374945280;
				if (num != 0)
				{
				}
				num = (short)1017249793;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.UIValue;
			}
			set
			{
				short num = (short)142278656;
				short num2 = num;
				num = (short)601607454;
				short num3 = num;
				num = (short)322751774;
				switch (num3 == num)
				{
				}
				num = (short)2112028673;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationResponseKind_A8947.UIValue = value;
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x0022ABA8 File Offset: 0x00228DA8
		public global::AcpBusinessLayer.AcpListField SecKmfProfASTROOTARInformationResponseKind_A8947
		{
			get
			{
				short num = (short)1169555456;
				short num2 = num;
				num = (short)539754673;
				short num3 = num;
				num = (short)109379761;
				switch (num3 == num)
				{
				}
				num = (short)932184065;
				if (num != 0)
				{
				}
				num = (short)418512896;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947;
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x0022AC58 File Offset: 0x00228E58
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x0022AD10 File Offset: 0x00228F10
		public bool SecKmfProfASTROOTARInformationResponseKind_A8947_Applicable
		{
			get
			{
				short num = (short)274268160;
				short num2 = num;
				num = (short)1576194578;
				short num3 = num;
				num = (short)704565778;
				switch (num3 == num)
				{
				}
				num = (short)1052114945;
				if (num != 0)
				{
				}
				num = (short)1197867008;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.Applicable;
			}
			set
			{
				short num = (short)623509504;
				short num2 = num;
				num = (short)1921105932;
				short num3 = num;
				num = (short)549568524;
				switch (num3 == num)
				{
				}
				num = (short)1646526464;
				if (num != 0)
				{
				}
				num = (short)336461825;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationResponseKind_A8947.Applicable = value;
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x0022ADC4 File Offset: 0x00228FC4
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x0022AE78 File Offset: 0x00229078
		public bool SecKmfProfASTROOTARInformationResponseKind_A8947_Valid
		{
			get
			{
				short num = (short)1441792;
				short num2 = num;
				num = (short)1066221055;
				short num3 = num;
				num = (short)177290751;
				switch (num3 == num)
				{
				}
				num = (short)612827136;
				if (num != 0)
				{
				}
				num = (short)955252737;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.Valid;
			}
			set
			{
				short num = (short)750387200;
				short num2 = num;
				num = (short)291033208;
				short num3 = num;
				num = (short)544198776;
				switch (num3 == num)
				{
				}
				num = (short)48758785;
				if (num != 0)
				{
				}
				num = (short)1626275840;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationResponseKind_A8947.Valid = value;
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x0022AF30 File Offset: 0x00229130
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x0022AFE4 File Offset: 0x002291E4
		public bool SecKmfProfASTROOTARInformationResponseKind_A8947_Visible
		{
			get
			{
				short num = (short)20381696;
				short num2 = num;
				num = (short)1822434721;
				short num3 = num;
				num = (short)1985029537;
				switch (num3 == num)
				{
				}
				num = (short)2038628353;
				if (num != 0)
				{
				}
				num = (short)1534066688;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.Visible;
			}
			set
			{
				short num = (short)1896022016;
				short num2 = num;
				num = (short)326909885;
				short num3 = num;
				num = (short)1510686653;
				switch (num3 == num)
				{
				}
				num = (short)2129920001;
				if (num != 0)
				{
				}
				num = (short)1444413440;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationResponseKind_A8947.Visible = value;
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0022B09C File Offset: 0x0022929C
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0022B154 File Offset: 0x00229354
		public bool SecKmfProfASTROOTARInformationResponseKind_A8947_Editable
		{
			get
			{
				short num = (short)356450304;
				short num2 = num;
				num = (short)1820102091;
				short num3 = num;
				num = (short)808553931;
				switch (num3 == num)
				{
				}
				num = (short)626786305;
				if (num != 0)
				{
				}
				num = (short)1077936128;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.Editable;
			}
			set
			{
				short num = (short)1004929024;
				short num2 = num;
				num = (short)628005692;
				short num3 = num;
				num = (short)635280188;
				switch (num3 == num)
				{
				}
				num = (short)1423835137;
				if (num != 0)
				{
				}
				num = (short)1456078848;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationResponseKind_A8947.Editable = value;
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x0022B20C File Offset: 0x0022940C
		internal string SecKmfProfASTROOTARInformationResponseKind_A8947_UILabel
		{
			get
			{
				short num = (short)486014976;
				short num2 = num;
				num = (short)2116797096;
				short num3 = num;
				num = (short)1925956264;
				switch (num3 == num)
				{
				}
				num = (short)470876160;
				if (num != 0)
				{
				}
				num = (short)1727463425;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.UIName;
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x0022B2C0 File Offset: 0x002294C0
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x0022B378 File Offset: 0x00229578
		internal bool SecKmfProfASTROOTARInformationResponseKind_A8947_HiddenStatic
		{
			get
			{
				short num = (short)1987510272;
				short num2 = num;
				num = (short)1585784035;
				short num3 = num;
				num = (short)612771043;
				switch (num3 == num)
				{
				}
				num = (short)2055602177;
				if (num != 0)
				{
				}
				num = (short)1807745024;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.HiddenStatic;
			}
			set
			{
				short num = (short)1330642944;
				short num2 = num;
				num = (short)1081723587;
				short num3 = num;
				num = (short)214944451;
				switch (num3 == num)
				{
				}
				num = (short)1234763776;
				if (num != 0)
				{
				}
				num = (short)610467841;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationResponseKind_A8947.HiddenStatic = value;
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x0022B42C File Offset: 0x0022962C
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x0022B4E0 File Offset: 0x002296E0
		internal bool SecKmfProfASTROOTARInformationResponseKind_A8947_HiddenDynamic
		{
			get
			{
				short num = (short)462225408;
				short num2 = num;
				num = (short)1592928555;
				short num3 = num;
				num = (short)1230252331;
				switch (num3 == num)
				{
				}
				num = (short)641400833;
				if (num != 0)
				{
				}
				num = (short)1454571520;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947.HiddenDynamic;
			}
			set
			{
				short num = (short)1164640256;
				short num2 = num;
				num = (short)911372956;
				short num3 = num;
				num = (short)425751196;
				switch (num3 == num)
				{
				}
				num = (short)980418561;
				if (num != 0)
				{
				}
				num = (short)2048393216;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationResponseKind_A8947.HiddenDynamic = value;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x0022B598 File Offset: 0x00229798
		public bool SecKmfProfASTROOTARInformationResponseKind_A8947_HasDiffs
		{
			get
			{
				short num = (short)623837184;
				short num2 = num;
				num = (short)1086285627;
				short num3 = num;
				num = (short)2077714235;
				switch (num3 == num)
				{
				}
				num = (short)1801977856;
				if (num != 0)
				{
				}
				num = (short)783876097;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationResponseKind_A8947._HasDiffs;
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x0022B64C File Offset: 0x0022984C
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x0022B700 File Offset: 0x00229900
		public bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608Value
		{
			get
			{
				short num = (short)82116608;
				short num2 = num;
				num = (short)1215454820;
				short num3 = num;
				num = (short)475881060;
				switch (num3 == num)
				{
				}
				num = (short)1339424768;
				if (num != 0)
				{
				}
				num = (short)330366977;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Value;
			}
			set
			{
				short num = (short)127926272;
				short num2 = num;
				num = (short)15990785;
				if (num != 0)
				{
				}
				num = (short)1858863538;
				short num3 = num;
				num = (short)1761018290;
				switch (num3 == num)
				{
				}
				num = (short)135200768;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Value = value;
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x0022B7B8 File Offset: 0x002299B8
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608
		{
			get
			{
				short num = (short)1269301248;
				short num2 = num;
				num = (short)1357250207;
				short num3 = num;
				num = (short)23330463;
				switch (num3 == num)
				{
				}
				num = (short)924909569;
				if (num != 0)
				{
				}
				num = (short)1707474944;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608;
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x0022B868 File Offset: 0x00229A68
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x0022B920 File Offset: 0x00229B20
		public bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_UIValue
		{
			get
			{
				short num = (short)1178271744;
				short num2 = num;
				num = (short)1410499761;
				short num3 = num;
				num = (short)1389855921;
				switch (num3 == num)
				{
				}
				num = (short)986775553;
				if (num != 0)
				{
				}
				num = (short)1683881984;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Value;
			}
			set
			{
				short num = (short)354222080;
				short num2 = num;
				num = (short)425419539;
				short num3 = num;
				num = (short)1032807187;
				switch (num3 == num)
				{
				}
				num = (short)643694593;
				if (num != 0)
				{
				}
				num = (short)361365504;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Value = value;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x0022B9D4 File Offset: 0x00229BD4
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x0022BA88 File Offset: 0x00229C88
		public bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_Applicable
		{
			get
			{
				short num = (short)1211170816;
				short num2 = num;
				num = (short)1886791735;
				short num3 = num;
				num = (short)1687496759;
				switch (num3 == num)
				{
				}
				num = (short)946274304;
				if (num != 0)
				{
				}
				num = (short)1703870465;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Applicable;
			}
			set
			{
				short num = (short)2010513408;
				short num2 = num;
				num = (short)457179137;
				if (num != 0)
				{
				}
				num = (short)972102338;
				short num3 = num;
				num = (short)2058296002;
				switch (num3 == num)
				{
				}
				num = (short)571539456;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Applicable = value;
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x0022BB3C File Offset: 0x00229D3C
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x0022BBF0 File Offset: 0x00229DF0
		public bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_Valid
		{
			get
			{
				short num = (short)1081475072;
				short num2 = num;
				num = (short)1852013212;
				short num3 = num;
				num = (short)446134940;
				switch (num3 == num)
				{
				}
				num = (short)269090817;
				if (num != 0)
				{
				}
				num = (short)473956352;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Valid;
			}
			set
			{
				short num = (short)71106560;
				short num2 = num;
				num = (short)1345139882;
				short num3 = num;
				num = (short)2102867114;
				switch (num3 == num)
				{
				}
				num = (short)1869217793;
				if (num != 0)
				{
				}
				num = (short)501219328;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Valid = value;
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x0022BCA8 File Offset: 0x00229EA8
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x0022BD5C File Offset: 0x00229F5C
		public bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_Visible
		{
			get
			{
				short num = (short)1331494912;
				short num2 = num;
				num = (short)2087281404;
				short num3 = num;
				num = (short)1720673020;
				switch (num3 == num)
				{
				}
				num = (short)208404481;
				if (num != 0)
				{
				}
				num = (short)1409548288;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Visible;
			}
			set
			{
				short num = (short)882049024;
				short num2 = num;
				num = (short)1345585153;
				if (num != 0)
				{
				}
				num = (short)1508978614;
				short num3 = num;
				num = (short)522989494;
				switch (num3 == num)
				{
				}
				num = (short)1076232192;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Visible = value;
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x0022BE14 File Offset: 0x0022A014
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x0022BEC8 File Offset: 0x0022A0C8
		public bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_Editable
		{
			get
			{
				short num = (short)282787840;
				short num2 = num;
				num = (short)1110778159;
				short num3 = num;
				num = (short)1805787439;
				switch (num3 == num)
				{
				}
				num = (short)1028259840;
				if (num != 0)
				{
				}
				num = (short)170131457;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Editable;
			}
			set
			{
				short num = (short)1499201536;
				short num2 = num;
				num = (short)80377631;
				short num3 = num;
				num = (short)1274378015;
				switch (num3 == num)
				{
				}
				num = (short)55312385;
				if (num != 0)
				{
				}
				num = (short)1253244928;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.Editable = value;
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x0022BF7C File Offset: 0x0022A17C
		internal string SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_UILabel
		{
			get
			{
				short num = (short)798162944;
				short num2 = num;
				num = (short)1267812395;
				short num3 = num;
				num = (short)50743339;
				switch (num3 == num)
				{
				}
				num = (short)572784641;
				if (num != 0)
				{
				}
				num = (short)1777008640;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.UIName;
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x0022C02C File Offset: 0x0022A22C
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x0022C0DC File Offset: 0x0022A2DC
		internal bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_HiddenStatic
		{
			get
			{
				short num = (short)43122688;
				short num2 = num;
				num = (short)767956024;
				short num3 = num;
				num = (short)561648696;
				switch (num3 == num)
				{
				}
				num = (short)373751808;
				if (num != 0)
				{
				}
				num = (short)232914945;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.HiddenStatic;
			}
			set
			{
				short num = (short)2144534528;
				short num2 = num;
				num = (short)1597259393;
				short num3 = num;
				num = (short)1473592961;
				switch (num3 == num)
				{
				}
				num = (short)1977286656;
				if (num != 0)
				{
				}
				num = (short)742326273;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.HiddenStatic = value;
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0022C190 File Offset: 0x0022A390
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x0022C244 File Offset: 0x0022A444
		internal bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_HiddenDynamic
		{
			get
			{
				short num = (short)154599424;
				short num2 = num;
				num = (short)1135379534;
				short num3 = num;
				num = (short)695895118;
				switch (num3 == num)
				{
				}
				num = (short)367001600;
				if (num != 0)
				{
				}
				num = (short)377290753;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.HiddenDynamic;
			}
			set
			{
				short num = (short)534183936;
				short num2 = num;
				num = (short)1893485611;
				short num3 = num;
				num = (short)1830964267;
				switch (num3 == num)
				{
				}
				num = (short)596705281;
				if (num != 0)
				{
				}
				num = (short)1584136192;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608.HiddenDynamic = value;
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x0022C2F8 File Offset: 0x0022A4F8
		public bool SecKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608_HasDiffs
		{
			get
			{
				short num = (short)502202368;
				short num2 = num;
				num = (short)1268023809;
				short num3 = num;
				num = (short)1319469569;
				switch (num3 == num)
				{
				}
				num = (short)564068352;
				if (num != 0)
				{
				}
				num = (short)1352597505;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608._HasDiffs;
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x0022C3AC File Offset: 0x0022A5AC
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x0022C460 File Offset: 0x0022A660
		public string SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663Value
		{
			get
			{
				short num = (short)2126315520;
				short num2 = num;
				num = (short)212401488;
				short num3 = num;
				num = (short)89324880;
				switch (num3 == num)
				{
				}
				num = (short)286392321;
				if (num != 0)
				{
				}
				num = (short)147259392;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Value;
			}
			set
			{
				short num = (short)375521281;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1538654209;
						if (num != 0)
						{
						}
						num = (short)1172939647;
						short num3 = num;
						num = (short)179676031;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_EF;
						default:
						{
							num = (short)563478528;
							short num4 = num;
							num = (short)1929248768;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CD;
							}
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_EF;
					}
					IL_CD:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)929169410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_EF:
					this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Value = value;
					num = (short)1468268544;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x0022C584 File Offset: 0x0022A784
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x0022C63C File Offset: 0x0022A83C
		public string SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_UIValue
		{
			get
			{
				short num = (short)859897856;
				short num2 = num;
				num = (short)876085249;
				if (num != 0)
				{
				}
				num = (short)1133132974;
				short num3 = num;
				num = (short)249183406;
				switch (num3 == num)
				{
				}
				num = (short)910819328;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Value;
			}
			set
			{
				short num = (short)1483735040;
				short num2 = num;
				num = (short)1263839624;
				short num3 = num;
				num = (short)986294664;
				switch (num3 == num)
				{
				}
				num = (short)582090753;
				if (num != 0)
				{
				}
				num = (short)1981808640;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Value = value;
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x0022C6F0 File Offset: 0x0022A8F0
		public global::AcpBusinessLayer.AcpKeyField SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663
		{
			get
			{
				short num = (short)1485635584;
				short num2 = num;
				num = (short)449476357;
				short num3 = num;
				num = (short)1410889477;
				switch (num3 == num)
				{
				}
				num = (short)491847681;
				if (num != 0)
				{
				}
				num = (short)1284112384;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663;
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x0022C7A4 File Offset: 0x0022A9A4
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x0022C858 File Offset: 0x0022AA58
		public bool SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_Applicable
		{
			get
			{
				short num = (short)1233256448;
				short num2 = num;
				num = (short)1358036993;
				if (num != 0)
				{
				}
				num = (short)1502787877;
				short num3 = num;
				num = (short)914536741;
				switch (num3 == num)
				{
				}
				num = (short)1239285760;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Applicable;
			}
			set
			{
				short num = (short)1893203968;
				short num2 = num;
				num = (short)1292891514;
				short num3 = num;
				num = (short)742913402;
				switch (num3 == num)
				{
				}
				num = (short)1856962561;
				if (num != 0)
				{
				}
				num = (short)1244069888;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Applicable = value;
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x0022C90C File Offset: 0x0022AB0C
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x0022C9C0 File Offset: 0x0022ABC0
		public bool SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_Valid
		{
			get
			{
				short num = (short)1474822144;
				short num2 = num;
				num = (short)1965785770;
				short num3 = num;
				num = (short)1909293738;
				switch (num3 == num)
				{
				}
				num = (short)1134362625;
				if (num != 0)
				{
				}
				num = (short)1600585728;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Valid;
			}
			set
			{
				short num = (short)1492779008;
				short num2 = num;
				num = (short)615563183;
				short num3 = num;
				num = (short)1589231535;
				switch (num3 == num)
				{
				}
				num = (short)2044854273;
				if (num != 0)
				{
				}
				num = (short)65208320;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Valid = value;
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0022CA78 File Offset: 0x0022AC78
		// (set) Token: 0x06002398 RID: 9112 RVA: 0x0022CB2C File Offset: 0x0022AD2C
		public bool SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_Visible
		{
			get
			{
				short num = (short)1426653184;
				short num2 = num;
				num = (short)962515284;
				short num3 = num;
				num = (short)966250836;
				switch (num3 == num)
				{
				}
				num = (short)881459201;
				if (num != 0)
				{
				}
				num = (short)1337065472;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Visible;
			}
			set
			{
				short num = (short)489357312;
				short num2 = num;
				num = (short)1899109183;
				short num3 = num;
				num = (short)1079909183;
				switch (num3 == num)
				{
				}
				num = (short)1938948097;
				if (num != 0)
				{
				}
				num = (short)956628992;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Visible = value;
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x0022CBE4 File Offset: 0x0022ADE4
		// (set) Token: 0x0600239A RID: 9114 RVA: 0x0022CC98 File Offset: 0x0022AE98
		public bool SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_Editable
		{
			get
			{
				short num = (short)303169536;
				short num2 = num;
				num = (short)419815287;
				short num3 = num;
				num = (short)1682890615;
				switch (num3 == num)
				{
				}
				num = (short)886308864;
				if (num != 0)
				{
				}
				num = (short)1997930497;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Editable;
			}
			set
			{
				short num = (short)662700032;
				short num2 = num;
				num = (short)417999449;
				short num3 = num;
				num = (short)1460939353;
				switch (num3 == num)
				{
				}
				num = (short)1015808000;
				if (num != 0)
				{
				}
				num = (short)827981825;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Editable = value;
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x0022CD50 File Offset: 0x0022AF50
		internal string SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_UILabel
		{
			get
			{
				short num = (short)682229760;
				short num2 = num;
				num = (short)1223150701;
				short num3 = num;
				num = (short)189647981;
				switch (num3 == num)
				{
				}
				num = (short)377028608;
				if (num != 0)
				{
				}
				num = (short)462684161;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.UIName;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x0022CE04 File Offset: 0x0022B004
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x0022CEBC File Offset: 0x0022B0BC
		internal bool SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_HiddenStatic
		{
			get
			{
				short num = (short)1767702528;
				short num2 = num;
				num = (short)420802969;
				short num3 = num;
				num = (short)281670041;
				switch (num3 == num)
				{
				}
				num = (short)676003841;
				if (num != 0)
				{
				}
				num = (short)2011430912;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.HiddenStatic;
			}
			set
			{
				short num = (short)312279040;
				short num2 = num;
				num = (short)363088549;
				short num3 = num;
				num = (short)1519995557;
				switch (num3 == num)
				{
				}
				num = (short)1122172929;
				if (num != 0)
				{
				}
				num = (short)495910912;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.HiddenStatic = value;
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x0022CF70 File Offset: 0x0022B170
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x0022D028 File Offset: 0x0022B228
		internal bool SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_HiddenDynamic
		{
			get
			{
				short num = (short)2036334592;
				short num2 = num;
				num = (short)1912012801;
				if (num != 0)
				{
				}
				num = (short)1169316153;
				short num3 = num;
				num = (short)1562204473;
				switch (num3 == num)
				{
				}
				num = (short)1121976320;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.HiddenDynamic;
			}
			set
			{
				short num = (short)1007026176;
				short num2 = num;
				num = (short)299668512;
				short num3 = num;
				num = (short)1898746912;
				switch (num3 == num)
				{
				}
				num = (short)434831361;
				if (num != 0)
				{
				}
				num = (short)2039939072;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.HiddenDynamic = value;
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x0022D0E0 File Offset: 0x0022B2E0
		public bool SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663_HasDiffs
		{
			get
			{
				short num = (short)2140143616;
				short num2 = num;
				num = (short)164923994;
				short num3 = num;
				num = (short)188254810;
				switch (num3 == num)
				{
				}
				num = (short)2044919809;
				if (num != 0)
				{
				}
				num = (short)1341915136;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663._HasDiffs;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x0022D190 File Offset: 0x0022B390
		// (set) Token: 0x060023A2 RID: 9122 RVA: 0x0022D244 File Offset: 0x0022B444
		public int SecKmfProfASTROOTARInformationNumberofAttempts_A8576Value
		{
			get
			{
				short num = (short)867368960;
				short num2 = num;
				num = (short)739383234;
				short num3 = num;
				num = (short)481826754;
				switch (num3 == num)
				{
				}
				num = (short)226230273;
				if (num != 0)
				{
				}
				num = (short)2120220672;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Value;
			}
			set
			{
				short num = (short)1582825472;
				short num2 = num;
				num = (short)2083824871;
				short num3 = num;
				num = (short)943957223;
				switch (num3 == num)
				{
				}
				num = (short)3538945;
				if (num != 0)
				{
				}
				num = (short)2082078720;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Value = value;
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x0022D2F8 File Offset: 0x0022B4F8
		public global::AcpBusinessLayer.AcpSimpleRangeField SecKmfProfASTROOTARInformationNumberofAttempts_A8576
		{
			get
			{
				short num = (short)435224576;
				short num2 = num;
				num = (short)1635575279;
				short num3 = num;
				num = (short)829548015;
				switch (num3 == num)
				{
				}
				num = (short)1862336513;
				if (num != 0)
				{
				}
				num = (short)877133824;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576;
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x0022D3A8 File Offset: 0x0022B5A8
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x0022D460 File Offset: 0x0022B660
		public string SecKmfProfASTROOTARInformationNumberofAttempts_A8576_UIValue
		{
			get
			{
				short num = (short)746913792;
				short num2 = num;
				num = (short)1989367670;
				short num3 = num;
				num = (short)269768566;
				switch (num3 == num)
				{
				}
				num = (short)822935552;
				if (num != 0)
				{
				}
				num = (short)994050049;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.UIValue;
			}
			set
			{
				short num = (short)240713728;
				short num2 = num;
				num = (short)1639811937;
				short num3 = num;
				num = (short)1154714465;
				switch (num3 == num)
				{
				}
				num = (short)2106130433;
				if (num != 0)
				{
				}
				num = (short)1489633280;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.UIValue = value;
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0022D514 File Offset: 0x0022B714
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x0022D5C8 File Offset: 0x0022B7C8
		internal int SecKmfProfASTROOTARInformationNumberofAttempts_A8576Min
		{
			get
			{
				short num = (short)1504378880;
				short num2 = num;
				num = (short)1397021442;
				short num3 = num;
				num = (short)2137971458;
				switch (num3 == num)
				{
				}
				num = (short)318767105;
				if (num != 0)
				{
				}
				num = (short)628752384;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Min;
			}
			set
			{
				short num = (short)1715011584;
				short num2 = num;
				num = (short)1302700226;
				short num3 = num;
				num = (short)1122672834;
				switch (num3 == num)
				{
				}
				num = (short)1684799489;
				if (num != 0)
				{
				}
				num = (short)296484864;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Min = value;
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x0022D680 File Offset: 0x0022B880
		// (set) Token: 0x060023A9 RID: 9129 RVA: 0x0022D734 File Offset: 0x0022B934
		internal int SecKmfProfASTROOTARInformationNumberofAttempts_A8576Max
		{
			get
			{
				short num = (short)84410368;
				short num2 = num;
				num = (short)1857619058;
				short num3 = num;
				num = (short)367527026;
				switch (num3 == num)
				{
				}
				num = (short)1640497152;
				if (num != 0)
				{
				}
				num = (short)196345857;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Max;
			}
			set
			{
				short num = (short)1992163328;
				short num2 = num;
				num = (short)1680525469;
				short num3 = num;
				num = (short)1352648861;
				switch (num3 == num)
				{
				}
				num = (short)59637761;
				if (num != 0)
				{
				}
				num = (short)1161822208;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Max = value;
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x0022D7EC File Offset: 0x0022B9EC
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x0022D8A0 File Offset: 0x0022BAA0
		internal int SecKmfProfASTROOTARInformationNumberofAttempts_A8576Step
		{
			get
			{
				short num = (short)625278976;
				short num2 = num;
				num = (short)607864223;
				short num3 = num;
				num = (short)820856223;
				switch (num3 == num)
				{
				}
				num = (short)1003225088;
				if (num != 0)
				{
				}
				num = (short)1951989761;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.StepSize;
			}
			set
			{
				short num = (short)1959329792;
				short num2 = num;
				num = (short)129337091;
				short num3 = num;
				num = (short)1581287171;
				switch (num3 == num)
				{
				}
				num = (short)458883073;
				if (num != 0)
				{
				}
				num = (short)1749942272;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.StepSize = value;
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x0022D954 File Offset: 0x0022BB54
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x0022DA08 File Offset: 0x0022BC08
		public bool SecKmfProfASTROOTARInformationNumberofAttempts_A8576_Applicable
		{
			get
			{
				short num = (short)847511552;
				short num2 = num;
				num = (short)991331366;
				short num3 = num;
				num = (short)798524454;
				switch (num3 == num)
				{
				}
				num = (short)35454977;
				if (num != 0)
				{
				}
				num = (short)950009856;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Applicable;
			}
			set
			{
				short num = (short)1823932416;
				short num2 = num;
				num = (short)532586644;
				short num3 = num;
				num = (short)702259348;
				switch (num3 == num)
				{
				}
				num = (short)1206321153;
				if (num != 0)
				{
				}
				num = (short)1690042368;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Applicable = value;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0022DABC File Offset: 0x0022BCBC
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x0022DB70 File Offset: 0x0022BD70
		public bool SecKmfProfASTROOTARInformationNumberofAttempts_A8576_Valid
		{
			get
			{
				short num = (short)536543232;
				short num2 = num;
				num = (short)1388805784;
				short num3 = num;
				num = (short)1742831256;
				switch (num3 == num)
				{
				}
				num = (short)1451163649;
				if (num != 0)
				{
				}
				num = (short)914489344;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Valid;
			}
			set
			{
				short num = (short)457834496;
				short num2 = num;
				num = (short)2029561641;
				short num3 = num;
				num = (short)892643113;
				switch (num3 == num)
				{
				}
				num = (short)2094792705;
				if (num != 0)
				{
				}
				num = (short)291766272;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Valid = value;
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0022DC24 File Offset: 0x0022BE24
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0022DCD8 File Offset: 0x0022BED8
		public bool SecKmfProfASTROOTARInformationNumberofAttempts_A8576_Visible
		{
			get
			{
				short num = (short)627179520;
				short num2 = num;
				num = (short)802357249;
				if (num != 0)
				{
				}
				num = (short)563443020;
				short num3 = num;
				num = (short)1377269068;
				switch (num3 == num)
				{
				}
				num = (short)1354825728;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Visible;
			}
			set
			{
				short num = (short)497614848;
				short num2 = num;
				num = (short)110740411;
				short num3 = num;
				num = (short)1981531067;
				switch (num3 == num)
				{
				}
				num = (short)50462720;
				if (num != 0)
				{
				}
				num = (short)1489174529;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Visible = value;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0022DD8C File Offset: 0x0022BF8C
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x0022DE40 File Offset: 0x0022C040
		public bool SecKmfProfASTROOTARInformationNumberofAttempts_A8576_Editable
		{
			get
			{
				short num = (short)631439360;
				short num2 = num;
				num = (short)1752441269;
				short num3 = num;
				num = (short)1174544821;
				switch (num3 == num)
				{
				}
				num = (short)999489536;
				if (num != 0)
				{
				}
				num = (short)898564097;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Editable;
			}
			set
			{
				short num = (short)1206779904;
				short num2 = num;
				num = (short)208033834;
				short num3 = num;
				num = (short)13457450;
				switch (num3 == num)
				{
				}
				num = (short)1926692865;
				if (num != 0)
				{
				}
				num = (short)1880489984;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.Editable = value;
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x0022DEF8 File Offset: 0x0022C0F8
		internal string SecKmfProfASTROOTARInformationNumberofAttempts_A8576_UILabel
		{
			get
			{
				short num = (short)224788480;
				short num2 = num;
				num = (short)378994689;
				if (num != 0)
				{
				}
				num = (short)351373210;
				short num3 = num;
				num = (short)158893978;
				switch (num3 == num)
				{
				}
				num = (short)1807351808;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.UIName;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x0022DFAC File Offset: 0x0022C1AC
		// (set) Token: 0x060023B6 RID: 9142 RVA: 0x0022E060 File Offset: 0x0022C260
		internal bool SecKmfProfASTROOTARInformationNumberofAttempts_A8576_HiddenStatic
		{
			get
			{
				short num = (short)2107047936;
				short num2 = num;
				num = (short)1778502540;
				short num3 = num;
				num = (short)1169476492;
				switch (num3 == num)
				{
				}
				num = (short)819068929;
				if (num != 0)
				{
				}
				num = (short)452788224;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.HiddenStatic;
			}
			set
			{
				short num = (short)828833792;
				short num2 = num;
				num = (short)1126788505;
				short num3 = num;
				num = (short)1808297369;
				switch (num3 == num)
				{
				}
				num = (short)891420672;
				if (num != 0)
				{
				}
				num = (short)1828388865;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.HiddenStatic = value;
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x0022E114 File Offset: 0x0022C314
		// (set) Token: 0x060023B8 RID: 9144 RVA: 0x0022E1C8 File Offset: 0x0022C3C8
		internal bool SecKmfProfASTROOTARInformationNumberofAttempts_A8576_HiddenDynamic
		{
			get
			{
				short num = (short)112394240;
				short num2 = num;
				num = (short)738436493;
				short num3 = num;
				num = (short)585147789;
				switch (num3 == num)
				{
				}
				num = (short)1002176513;
				if (num != 0)
				{
				}
				num = (short)1242300416;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.HiddenDynamic;
			}
			set
			{
				short num = (short)641073152;
				short num2 = num;
				num = (short)480860947;
				short num3 = num;
				num = (short)1518361363;
				switch (num3 == num)
				{
				}
				num = (short)888537088;
				if (num != 0)
				{
				}
				num = (short)921829377;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationNumberofAttempts_A8576.HiddenDynamic = value;
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0022E280 File Offset: 0x0022C480
		public bool SecKmfProfASTROOTARInformationNumberofAttempts_A8576_HasDiffs
		{
			get
			{
				short num = (short)404684800;
				short num2 = num;
				num = (short)1553793025;
				if (num != 0)
				{
				}
				num = (short)1012902215;
				short num3 = num;
				num = (short)219720007;
				switch (num3 == num)
				{
				}
				num = (short)2132213760;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationNumberofAttempts_A8576._HasDiffs;
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0022E338 File Offset: 0x0022C538
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x0022E3EC File Offset: 0x0022C5EC
		public int SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673Value
		{
			get
			{
				short num = (short)1615069184;
				short num2 = num;
				num = (short)1793464682;
				short num3 = num;
				num = (short)1378228586;
				switch (num3 == num)
				{
				}
				num = (short)471465985;
				if (num != 0)
				{
				}
				num = (short)2068381696;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Value;
			}
			set
			{
				short num = (short)250544128;
				short num2 = num;
				num = (short)2121302917;
				short num3 = num;
				num = (short)570459013;
				switch (num3 == num)
				{
				}
				num = (short)1609629697;
				if (num != 0)
				{
				}
				num = (short)589561856;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Value = value;
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0022E4A4 File Offset: 0x0022C6A4
		public global::AcpBusinessLayer.AcpSimpleRangeField SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673
		{
			get
			{
				short num = (short)1381236736;
				short num2 = num;
				num = (short)1325401436;
				short num3 = num;
				num = (short)1819280732;
				switch (num3 == num)
				{
				}
				num = (short)2000224257;
				if (num != 0)
				{
				}
				num = (short)2140078080;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673;
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x0022E554 File Offset: 0x0022C754
		// (set) Token: 0x060023BE RID: 9150 RVA: 0x0022E604 File Offset: 0x0022C804
		public string SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_UIValue
		{
			get
			{
				short num = (short)1598226432;
				short num2 = num;
				num = (short)1081365697;
				short num3 = num;
				num = (short)261444801;
				switch (num3 == num)
				{
				}
				num = (short)1348861952;
				if (num != 0)
				{
				}
				num = (short)1779892225;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.UIValue;
			}
			set
			{
				short num = (short)971177984;
				short num2 = num;
				num = (short)39190529;
				if (num != 0)
				{
				}
				num = (short)460293510;
				short num3 = num;
				num = (short)806716806;
				switch (num3 == num)
				{
				}
				num = (short)2044133376;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.UIValue = value;
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x0022E6BC File Offset: 0x0022C8BC
		// (set) Token: 0x060023C0 RID: 9152 RVA: 0x0022E774 File Offset: 0x0022C974
		internal int SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673Min
		{
			get
			{
				short num = (short)972750848;
				short num2 = num;
				num = (short)735248385;
				if (num != 0)
				{
				}
				num = (short)1882783110;
				short num3 = num;
				num = (short)484244870;
				switch (num3 == num)
				{
				}
				num = (short)2075000832;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Min;
			}
			set
			{
				short num = (short)451608576;
				short num2 = num;
				num = (short)1066646270;
				short num3 = num;
				num = (short)1410841342;
				switch (num3 == num)
				{
				}
				num = (short)795279361;
				if (num != 0)
				{
				}
				num = (short)226689024;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Min = value;
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0022E82C File Offset: 0x0022CA2C
		// (set) Token: 0x060023C2 RID: 9154 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
		internal int SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673Max
		{
			get
			{
				short num = (short)245760000;
				short num2 = num;
				num = (short)8497761;
				short num3 = num;
				num = (short)1009494625;
				switch (num3 == num)
				{
				}
				num = (short)960102401;
				if (num != 0)
				{
				}
				num = (short)660930560;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Max;
			}
			set
			{
				short num = (short)1235943424;
				short num2 = num;
				num = (short)337836532;
				short num3 = num;
				num = (short)2001926644;
				switch (num3 == num)
				{
				}
				num = (short)1904082945;
				if (num != 0)
				{
				}
				num = (short)1738801152;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Max = value;
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0022E994 File Offset: 0x0022CB94
		// (set) Token: 0x060023C4 RID: 9156 RVA: 0x0022EA48 File Offset: 0x0022CC48
		internal int SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673Step
		{
			get
			{
				short num = (short)1609170944;
				short num2 = num;
				num = (short)1036268649;
				short num3 = num;
				num = (short)2063938665;
				switch (num3 == num)
				{
				}
				num = (short)1393950720;
				if (num != 0)
				{
				}
				num = (short)1990524929;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.StepSize;
			}
			set
			{
				short num = (short)1196687360;
				short num2 = num;
				num = (short)583064858;
				short num3 = num;
				num = (short)1029102874;
				switch (num3 == num)
				{
				}
				num = (short)1813118977;
				if (num != 0)
				{
				}
				num = (short)1966997504;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.StepSize = value;
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x0022EAFC File Offset: 0x0022CCFC
		// (set) Token: 0x060023C6 RID: 9158 RVA: 0x0022EBB0 File Offset: 0x0022CDB0
		public bool SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_Applicable
		{
			get
			{
				short num = (short)155320320;
				short num2 = num;
				num = (short)860755808;
				short num3 = num;
				num = (short)1542985568;
				switch (num3 == num)
				{
				}
				num = (short)622395393;
				if (num != 0)
				{
				}
				num = (short)2107899904;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Applicable;
			}
			set
			{
				short num = (short)1064894464;
				short num2 = num;
				num = (short)1495616521;
				short num3 = num;
				num = (short)699681801;
				switch (num3 == num)
				{
				}
				num = (short)408485889;
				if (num != 0)
				{
				}
				num = (short)406585344;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Applicable = value;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0022EC64 File Offset: 0x0022CE64
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0022ED18 File Offset: 0x0022CF18
		public bool SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_Valid
		{
			get
			{
				short num = (short)489684992;
				short num2 = num;
				num = (short)353546573;
				short num3 = num;
				num = (short)656978253;
				switch (num3 == num)
				{
				}
				num = (short)1704394753;
				if (num != 0)
				{
				}
				num = (short)1806434304;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Valid;
			}
			set
			{
				short num = (short)1541079040;
				short num2 = num;
				num = (short)569442305;
				if (num != 0)
				{
				}
				num = (short)533909125;
				short num3 = num;
				num = (short)1957875333;
				switch (num3 == num)
				{
				}
				num = (short)1596588032;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Valid = value;
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x0022EDD0 File Offset: 0x0022CFD0
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x0022EE84 File Offset: 0x0022D084
		public bool SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_Visible
		{
			get
			{
				short num = (short)1688535040;
				short num2 = num;
				num = (short)687461954;
				short num3 = num;
				num = (short)1738724930;
				switch (num3 == num)
				{
				}
				num = (short)494272513;
				if (num != 0)
				{
				}
				num = (short)1454899200;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Visible;
			}
			set
			{
				short num = (short)1170997248;
				short num2 = num;
				num = (short)415610034;
				short num3 = num;
				num = (short)1961473202;
				switch (num3 == num)
				{
				}
				num = (short)37355521;
				if (num != 0)
				{
				}
				num = (short)384040960;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Visible = value;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x0022EF38 File Offset: 0x0022D138
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x0022EFEC File Offset: 0x0022D1EC
		public bool SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_Editable
		{
			get
			{
				short num = (short)1200947200;
				short num2 = num;
				num = (short)68431069;
				short num3 = num;
				num = (short)1770794205;
				switch (num3 == num)
				{
				}
				num = (short)1865482240;
				if (num != 0)
				{
				}
				num = (short)1150091265;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Editable;
			}
			set
			{
				short num = (short)1738735616;
				short num2 = num;
				num = (short)1795439882;
				short num3 = num;
				num = (short)1241857290;
				switch (num3 == num)
				{
				}
				num = (short)857735168;
				if (num != 0)
				{
				}
				num = (short)1250426881;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.Editable = value;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x0022F0A4 File Offset: 0x0022D2A4
		internal string SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_UILabel
		{
			get
			{
				short num = (short)313589760;
				short num2 = num;
				num = (short)43202731;
				short num3 = num;
				num = (short)1726036139;
				switch (num3 == num)
				{
				}
				num = (short)1447886849;
				if (num != 0)
				{
				}
				num = (short)1005453312;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.UIName;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x0022F158 File Offset: 0x0022D358
		// (set) Token: 0x060023CF RID: 9167 RVA: 0x0022F20C File Offset: 0x0022D40C
		internal bool SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_HiddenStatic
		{
			get
			{
				short num = (short)1742209024;
				short num2 = num;
				num = (short)1194282285;
				short num3 = num;
				num = (short)303713581;
				switch (num3 == num)
				{
				}
				num = (short)1722744833;
				if (num != 0)
				{
				}
				num = (short)1803288576;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.HiddenStatic;
			}
			set
			{
				short num = (short)955056128;
				short num2 = num;
				num = (short)1377467051;
				short num3 = num;
				num = (short)914979499;
				switch (num3 == num)
				{
				}
				num = (short)1860763649;
				if (num != 0)
				{
				}
				num = (short)1593180160;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.HiddenStatic = value;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x0022F2C0 File Offset: 0x0022D4C0
		// (set) Token: 0x060023D1 RID: 9169 RVA: 0x0022F374 File Offset: 0x0022D574
		internal bool SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_HiddenDynamic
		{
			get
			{
				short num = (short)575864832;
				short num2 = num;
				num = (short)681992415;
				short num3 = num;
				num = (short)403136735;
				switch (num3 == num)
				{
				}
				num = (short)53870593;
				if (num != 0)
				{
				}
				num = (short)1552875520;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.HiddenDynamic;
			}
			set
			{
				short num = (short)1783627776;
				short num2 = num;
				num = (short)1735033647;
				short num3 = num;
				num = (short)783516463;
				switch (num3 == num)
				{
				}
				num = (short)668270593;
				if (num != 0)
				{
				}
				num = (short)2055602176;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673.HiddenDynamic = value;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x0022F42C File Offset: 0x0022D62C
		public bool SecKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673_HasDiffs
		{
			get
			{
				short num = (short)1385103360;
				short num2 = num;
				num = (short)161437473;
				short num3 = num;
				num = (short)785995553;
				switch (num3 == num)
				{
				}
				num = (short)37683200;
				if (num != 0)
				{
				}
				num = (short)255918081;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673._HasDiffs;
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x0022F4E0 File Offset: 0x0022D6E0
		// (set) Token: 0x060023D4 RID: 9172 RVA: 0x0022F594 File Offset: 0x0022D794
		public int SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375Value
		{
			get
			{
				short num = (short)2049900544;
				short num2 = num;
				num = (short)1332751838;
				short num3 = num;
				num = (short)1799106014;
				switch (num3 == num)
				{
				}
				num = (short)1511587840;
				if (num != 0)
				{
				}
				num = (short)1729495041;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Value;
			}
			set
			{
				short num = (short)1007157248;
				short num2 = num;
				num = (short)1238903023;
				short num3 = num;
				num = (short)935340271;
				switch (num3 == num)
				{
				}
				num = (short)596377601;
				if (num != 0)
				{
				}
				num = (short)1444544512;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Value = value;
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x0022F648 File Offset: 0x0022D848
		public global::AcpBusinessLayer.AcpRangeField<int, string> SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375
		{
			get
			{
				short num = (short)627179520;
				short num2 = num;
				num = (short)673251599;
				short num3 = num;
				num = (short)1114439951;
				switch (num3 == num)
				{
				}
				num = (short)630718465;
				if (num != 0)
				{
				}
				num = (short)404226048;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375;
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x0022F6F8 File Offset: 0x0022D8F8
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x0022F7AC File Offset: 0x0022D9AC
		public string SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_UIValue
		{
			get
			{
				short num = (short)931921920;
				short num2 = num;
				num = (short)481889413;
				short num3 = num;
				num = (short)1548160133;
				switch (num3 == num)
				{
				}
				num = (short)851836929;
				if (num != 0)
				{
				}
				num = (short)2019950592;
				if (num != 0)
				{
				}
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.UIValue;
			}
			set
			{
				short num = (short)420872192;
				short num2 = num;
				num = (short)153534157;
				short num3 = num;
				num = (short)873184973;
				switch (num3 == num)
				{
				}
				num = (short)1976893441;
				if (num != 0)
				{
				}
				num = (short)475267072;
				if (num != 0)
				{
				}
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.UIValue = value;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x0022F864 File Offset: 0x0022DA64
		// (set) Token: 0x060023D9 RID: 9177 RVA: 0x0022F918 File Offset: 0x0022DB18
		internal int SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375Min
		{
			get
			{
				short num = (short)702851625;
				short num2 = num;
				num = (short)46836265;
				switch (num2 == num)
				{
				}
				num = (short)287047681;
				if (num != 0)
				{
				}
				num = (short)971833344;
				if (num != 0)
				{
				}
				num = (short)1897594880;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Min;
			}
			set
			{
				short num = (short)968490841;
				short num2 = num;
				num = (short)2037645145;
				switch (num2 == num)
				{
				}
				num = (short)258473985;
				if (num != 0)
				{
				}
				num = (short)341704704;
				if (num != 0)
				{
				}
				num = (short)1367474176;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Min = value;
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x0022F9CC File Offset: 0x0022DBCC
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x0022FA80 File Offset: 0x0022DC80
		internal int SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375Max
		{
			get
			{
				short num = (short)1685949148;
				short num2 = num;
				num = (short)45779676;
				switch (num2 == num)
				{
				}
				num = (short)1849294849;
				if (num != 0)
				{
				}
				num = (short)303955968;
				if (num != 0)
				{
				}
				num = (short)1488846848;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Max;
			}
			set
			{
				short num = (short)756592174;
				short num2 = num;
				num = (short)371633710;
				switch (num2 == num)
				{
				}
				num = (short)627376128;
				if (num != 0)
				{
				}
				num = (short)493092865;
				if (num != 0)
				{
				}
				num = (short)1721892864;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Max = value;
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x0022FB30 File Offset: 0x0022DD30
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x0022FBE8 File Offset: 0x0022DDE8
		internal int SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375Step
		{
			get
			{
				short num = (short)125661686;
				short num2 = num;
				num = (short)941388278;
				switch (num2 == num)
				{
				}
				num = (short)2028666881;
				if (num != 0)
				{
				}
				num = (short)8847360;
				if (num != 0)
				{
				}
				num = (short)1752825856;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.StepSize;
			}
			set
			{
				short num = (short)20797309;
				short num2 = num;
				num = (short)1530484605;
				switch (num2 == num)
				{
				}
				num = (short)2085552129;
				if (num != 0)
				{
				}
				num = (short)986513408;
				if (num != 0)
				{
				}
				num = (short)1326317568;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.StepSize = value;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x0022FC9C File Offset: 0x0022DE9C
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x0022FD50 File Offset: 0x0022DF50
		public bool SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_Applicable
		{
			get
			{
				short num = (short)2056559461;
				short num2 = num;
				num = (short)633052005;
				switch (num2 == num)
				{
				}
				num = (short)575012865;
				if (num != 0)
				{
				}
				num = (short)181338112;
				if (num != 0)
				{
				}
				num = (short)1351811072;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Applicable;
			}
			set
			{
				short num = (short)204844976;
				short num2 = num;
				num = (short)1706405808;
				switch (num2 == num)
				{
				}
				num = (short)1302462464;
				if (num != 0)
				{
				}
				num = (short)1528889345;
				if (num != 0)
				{
				}
				num = (short)740229120;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Applicable = value;
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x0022FE04 File Offset: 0x0022E004
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x0022FEC0 File Offset: 0x0022E0C0
		public bool SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_Valid
		{
			get
			{
				short num = (short)1880965911;
				short num2 = num;
				num = (short)260260631;
				switch (num2 == num)
				{
				}
				num = (short)1263796225;
				if (num != 0)
				{
				}
				num = (short)959840256;
				if (num != 0)
				{
				}
				num = (short)629866496;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Valid;
			}
			set
			{
				short num = (short)1701988377;
				short num2 = num;
				num = (short)1008093209;
				switch (num2 == num)
				{
				}
				num = (short)919863297;
				if (num != 0)
				{
				}
				num = (short)1462894592;
				if (num != 0)
				{
				}
				num = (short)1049231360;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Valid = value;
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0022FF78 File Offset: 0x0022E178
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x0023002C File Offset: 0x0022E22C
		public bool SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_Visible
		{
			get
			{
				short num = (short)354012165;
				short num2 = num;
				num = (short)644402181;
				switch (num2 == num)
				{
				}
				num = (short)1564409856;
				if (num != 0)
				{
				}
				num = (short)1422000129;
				if (num != 0)
				{
				}
				num = (short)1784872960;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Visible;
			}
			set
			{
				short num = (short)1589303749;
				short num2 = num;
				num = (short)2140658117;
				switch (num2 == num)
				{
				}
				num = (short)778960897;
				if (num != 0)
				{
				}
				num = (short)792854528;
				if (num != 0)
				{
				}
				num = (short)1551958016;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Visible = value;
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x002300E4 File Offset: 0x0022E2E4
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x0023019C File Offset: 0x0022E39C
		public bool SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_Editable
		{
			get
			{
				short num = (short)352691872;
				short num2 = num;
				num = (short)115648160;
				switch (num2 == num)
				{
				}
				num = (short)2086338561;
				if (num != 0)
				{
				}
				num = (short)67305472;
				if (num != 0)
				{
				}
				num = (short)310771712;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Editable;
			}
			set
			{
				short num = (short)1812285999;
				short num2 = num;
				num = (short)528173615;
				switch (num2 == num)
				{
				}
				num = (short)1989279745;
				if (num != 0)
				{
				}
				num = (short)1203109888;
				if (num != 0)
				{
				}
				num = (short)1396899840;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.Editable = value;
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x00230254 File Offset: 0x0022E454
		internal string SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_UILabel
		{
			get
			{
				short num = (short)335727119;
				short num2 = num;
				num = (short)739625487;
				switch (num2 == num)
				{
				}
				num = (short)874250240;
				if (num != 0)
				{
				}
				num = (short)1780154369;
				if (num != 0)
				{
				}
				num = (short)1713373184;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.UIName;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x00230304 File Offset: 0x0022E504
		// (set) Token: 0x060023E8 RID: 9192 RVA: 0x002303B8 File Offset: 0x0022E5B8
		internal bool SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_HiddenStatic
		{
			get
			{
				short num = (short)522345963;
				short num2 = num;
				num = (short)1268473323;
				switch (num2 == num)
				{
				}
				num = (short)298188800;
				if (num != 0)
				{
				}
				num = (short)1114046465;
				if (num != 0)
				{
				}
				num = (short)1104084992;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.HiddenStatic;
			}
			set
			{
				short num = (short)1780185010;
				short num2 = num;
				num = (short)1960998834;
				switch (num2 == num)
				{
				}
				num = (short)1610219521;
				if (num != 0)
				{
				}
				num = (short)1158152192;
				if (num != 0)
				{
				}
				num = (short)135659520;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.HiddenStatic = value;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x00230470 File Offset: 0x0022E670
		// (set) Token: 0x060023EA RID: 9194 RVA: 0x00230528 File Offset: 0x0022E728
		internal bool SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_HiddenDynamic
		{
			get
			{
				short num = (short)1135542273;
				if (num != 0)
				{
				}
				num = (short)1769042024;
				short num2 = num;
				num = (short)527331432;
				switch (num2 == num)
				{
				}
				num = (short)1797455872;
				if (num != 0)
				{
				}
				num = (short)1319108608;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.HiddenDynamic;
			}
			set
			{
				short num = (short)173836709;
				short num2 = num;
				num = (short)1149798821;
				switch (num2 == num)
				{
				}
				num = (short)1541472257;
				if (num != 0)
				{
				}
				num = (short)1675624448;
				if (num != 0)
				{
				}
				num = (short)1055719424;
				short num3 = num;
				this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375.HiddenDynamic = value;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x002305DC File Offset: 0x0022E7DC
		public bool SecKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375_HasDiffs
		{
			get
			{
				short num = (short)74428759;
				short num2 = num;
				num = (short)191017303;
				switch (num2 == num)
				{
				}
				num = (short)606273536;
				if (num != 0)
				{
				}
				num = (short)1335033857;
				if (num != 0)
				{
				}
				num = (short)1016266752;
				short num3 = num;
				return this.secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375._HasDiffs;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x0023068C File Offset: 0x0022E88C
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x00230744 File Offset: 0x0022E944
		public bool SecKmfProfRadioInhibitViaASTROOTAR_43690Value
		{
			get
			{
				short num = (short)333053953;
				if (num != 0)
				{
				}
				num = (short)1133057753;
				short num2 = num;
				num = (short)751703769;
				switch (num2 == num)
				{
				}
				num = (short)684064768;
				if (num != 0)
				{
				}
				num = (short)2071658496;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.Value;
			}
			set
			{
				short num = (short)933101569;
				if (num != 0)
				{
				}
				num = (short)985940155;
				short num2 = num;
				num = (short)227295419;
				switch (num2 == num)
				{
				}
				num = (short)1088880640;
				if (num != 0)
				{
				}
				num = (short)152961024;
				short num3 = num;
				this.secKmfProfRadioInhibitViaASTROOTAR_43690.Value = value;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x002307F8 File Offset: 0x0022E9F8
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfRadioInhibitViaASTROOTAR_43690
		{
			get
			{
				short num = (short)118974594;
				short num2 = num;
				num = (short)592472194;
				switch (num2 == num)
				{
				}
				num = (short)1564934145;
				if (num != 0)
				{
				}
				num = (short)567803904;
				if (num != 0)
				{
				}
				num = (short)1312751616;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x002308A8 File Offset: 0x0022EAA8
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x0023095C File Offset: 0x0022EB5C
		public bool SecKmfProfRadioInhibitViaASTROOTAR_43690_UIValue
		{
			get
			{
				short num = (short)469705320;
				short num2 = num;
				num = (short)2134057576;
				switch (num2 == num)
				{
				}
				num = (short)18087937;
				if (num != 0)
				{
				}
				num = (short)1263861760;
				if (num != 0)
				{
				}
				num = (short)1850081280;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.Value;
			}
			set
			{
				short num = (short)554785818;
				short num2 = num;
				num = (short)1041325082;
				switch (num2 == num)
				{
				}
				num = (short)1964310528;
				if (num != 0)
				{
				}
				num = (short)1866072065;
				if (num != 0)
				{
				}
				num = (short)1613889536;
				short num3 = num;
				this.secKmfProfRadioInhibitViaASTROOTAR_43690.Value = value;
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x00230A14 File Offset: 0x0022EC14
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x00230AC8 File Offset: 0x0022ECC8
		public int KMFRSIValue
		{
			get
			{
				short num = (short)2134941375;
				short num2 = num;
				num = (short)54304447;
				switch (num2 == num)
				{
				}
				num = (short)2106327041;
				if (num != 0)
				{
				}
				num = (short)421199872;
				if (num != 0)
				{
				}
				num = (short)1547304960;
				short num3 = num;
				return this.kMFRSI.Value;
			}
			set
			{
				short num = (short)1274028710;
				short num2 = num;
				num = (short)1670390438;
				switch (num2 == num)
				{
				}
				num = (short)1251999744;
				if (num != 0)
				{
				}
				num = (short)815136769;
				if (num != 0)
				{
				}
				num = (short)2113011712;
				short num3 = num;
				this.kMFRSI.Value = value;
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x00230B80 File Offset: 0x0022ED80
		public global::AcpBusinessLayer.AcpSimpleRangeField KMFRSI
		{
			get
			{
				short num = (short)879264300;
				short num2 = num;
				num = (short)422216236;
				switch (num2 == num)
				{
				}
				num = (short)84869121;
				if (num != 0)
				{
				}
				num = (short)627900416;
				if (num != 0)
				{
				}
				num = (short)76611584;
				short num3 = num;
				return this.kMFRSI;
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x00230C2C File Offset: 0x0022EE2C
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x00230CE0 File Offset: 0x0022EEE0
		public int MessageNumberPeriodValue
		{
			get
			{
				short num = (short)250674592;
				short num2 = num;
				num = (short)55115168;
				switch (num2 == num)
				{
				}
				num = (short)1315504128;
				if (num != 0)
				{
				}
				num = (short)1355743233;
				if (num != 0)
				{
				}
				num = (short)596180992;
				short num3 = num;
				return this.messageNumberPeriod.Value;
			}
			set
			{
				short num = (short)1443977127;
				short num2 = num;
				num = (short)979261351;
				switch (num2 == num)
				{
				}
				num = (short)1974796289;
				if (num != 0)
				{
				}
				num = (short)1275199488;
				if (num != 0)
				{
				}
				num = (short)729088000;
				short num3 = num;
				this.messageNumberPeriod.Value = value;
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x00230D94 File Offset: 0x0022EF94
		public global::AcpBusinessLayer.AcpSimpleRangeField MessageNumberPeriod
		{
			get
			{
				short num = (short)1930417302;
				short num2 = num;
				num = (short)1359139990;
				switch (num2 == num)
				{
				}
				num = (short)734003201;
				if (num != 0)
				{
				}
				num = (short)1541734400;
				if (num != 0)
				{
				}
				num = (short)1174142976;
				short num3 = num;
				return this.messageNumberPeriod;
			}
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x00230E44 File Offset: 0x0022F044
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x00230EFC File Offset: 0x0022F0FC
		public bool SecKmfProfRadioInhibitViaASTROOTAR_43690_Applicable
		{
			get
			{
				short num = (short)2137700847;
				short num2 = num;
				num = (short)172276207;
				switch (num2 == num)
				{
				}
				num = (short)155910144;
				if (num != 0)
				{
				}
				num = (short)590872577;
				if (num != 0)
				{
				}
				num = (short)1919680512;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.Applicable;
			}
			set
			{
				short num = (short)328900059;
				short num2 = num;
				num = (short)575512027;
				switch (num2 == num)
				{
				}
				num = (short)518914049;
				if (num != 0)
				{
				}
				num = (short)1550319616;
				if (num != 0)
				{
				}
				num = (short)1026424832;
				short num3 = num;
				this.secKmfProfRadioInhibitViaASTROOTAR_43690.Applicable = value;
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x00230FB4 File Offset: 0x0022F1B4
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x00231068 File Offset: 0x0022F268
		public bool SecKmfProfRadioInhibitViaASTROOTAR_43690_Valid
		{
			get
			{
				short num = (short)1201093414;
				short num2 = num;
				num = (short)1128217382;
				switch (num2 == num)
				{
				}
				num = (short)730857472;
				if (num != 0)
				{
				}
				num = (short)671219713;
				if (num != 0)
				{
				}
				num = (short)1235681280;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.Valid;
			}
			set
			{
				short num = (short)950503999;
				short num2 = num;
				num = (short)942639679;
				switch (num2 == num)
				{
				}
				num = (short)1673723905;
				if (num != 0)
				{
				}
				num = (short)909901824;
				if (num != 0)
				{
				}
				num = (short)916062208;
				short num3 = num;
				this.secKmfProfRadioInhibitViaASTROOTAR_43690.Valid = value;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x00231120 File Offset: 0x0022F320
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x002311D4 File Offset: 0x0022F3D4
		public bool SecKmfProfRadioInhibitViaASTROOTAR_43690_Visible
		{
			get
			{
				short num = (short)478609409;
				if (num != 0)
				{
				}
				num = (short)600890817;
				short num2 = num;
				num = (short)1425071553;
				switch (num2 == num)
				{
				}
				num = (short)261881856;
				if (num != 0)
				{
				}
				num = (short)1994457088;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.Visible;
			}
			set
			{
				short num = (short)1613073540;
				short num2 = num;
				num = (short)186748036;
				switch (num2 == num)
				{
				}
				num = (short)399638528;
				if (num != 0)
				{
				}
				num = (short)1739587585;
				if (num != 0)
				{
				}
				num = (short)1715994624;
				short num3 = num;
				this.secKmfProfRadioInhibitViaASTROOTAR_43690.Visible = value;
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x0023128C File Offset: 0x0022F48C
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x00231344 File Offset: 0x0022F544
		public bool SecKmfProfRadioInhibitViaASTROOTAR_43690_Editable
		{
			get
			{
				short num = (short)2019925466;
				short num2 = num;
				num = (short)499031514;
				switch (num2 == num)
				{
				}
				num = (short)1149173761;
				if (num != 0)
				{
				}
				num = (short)985792512;
				if (num != 0)
				{
				}
				num = (short)891617280;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.Editable;
			}
			set
			{
				short num = (short)1493188438;
				short num2 = num;
				num = (short)1438531414;
				switch (num2 == num)
				{
				}
				num = (short)2138243073;
				if (num != 0)
				{
				}
				num = (short)1686372352;
				if (num != 0)
				{
				}
				num = (short)247070720;
				short num3 = num;
				this.secKmfProfRadioInhibitViaASTROOTAR_43690.Editable = value;
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x002313F8 File Offset: 0x0022F5F8
		internal string SecKmfProfRadioInhibitViaASTROOTAR_43690_UILabel
		{
			get
			{
				short num = (short)435123976;
				short num2 = num;
				num = (short)891385608;
				switch (num2 == num)
				{
				}
				num = (short)725680128;
				if (num != 0)
				{
				}
				num = (short)1369767937;
				if (num != 0)
				{
				}
				num = (short)2141323264;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.UIName;
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x002314AC File Offset: 0x0022F6AC
		// (set) Token: 0x06002401 RID: 9217 RVA: 0x00231560 File Offset: 0x0022F760
		internal bool SecKmfProfRadioInhibitViaASTROOTAR_43690_HiddenStatic
		{
			get
			{
				short num = (short)467548893;
				short num2 = num;
				num = (short)847002333;
				switch (num2 == num)
				{
				}
				num = (short)417857536;
				if (num != 0)
				{
				}
				num = (short)408223745;
				if (num != 0)
				{
				}
				num = (short)1590099968;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.HiddenStatic;
			}
			set
			{
				short num = (short)967181570;
				short num2 = num;
				num = (short)1857422594;
				switch (num2 == num)
				{
				}
				num = (short)1558380545;
				if (num != 0)
				{
				}
				num = (short)826015744;
				if (num != 0)
				{
				}
				num = (short)1511981056;
				short num3 = num;
				this.secKmfProfRadioInhibitViaASTROOTAR_43690.HiddenStatic = value;
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x00231618 File Offset: 0x0022F818
		// (set) Token: 0x06002403 RID: 9219 RVA: 0x002316D0 File Offset: 0x0022F8D0
		internal bool SecKmfProfRadioInhibitViaASTROOTAR_43690_HiddenDynamic
		{
			get
			{
				short num = (short)1869539782;
				short num2 = num;
				num = (short)1415768518;
				switch (num2 == num)
				{
				}
				num = (short)222298113;
				if (num != 0)
				{
				}
				num = (short)663355392;
				if (num != 0)
				{
				}
				num = (short)294453248;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690.HiddenDynamic;
			}
			set
			{
				short num = (short)1386807297;
				if (num != 0)
				{
				}
				num = (short)826733809;
				short num2 = num;
				num = (short)1709044977;
				switch (num2 == num)
				{
				}
				num = (short)61079552;
				if (num != 0)
				{
				}
				num = (short)1221525504;
				short num3 = num;
				this.secKmfProfRadioInhibitViaASTROOTAR_43690.HiddenDynamic = value;
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x0023178C File Offset: 0x0022F98C
		public bool SecKmfProfRadioInhibitViaASTROOTAR_43690_HasDiffs
		{
			get
			{
				short num = (short)823094437;
				short num2 = num;
				num = (short)1051487397;
				switch (num2 == num)
				{
				}
				num = (short)1975779328;
				if (num != 0)
				{
				}
				num = (short)839122945;
				if (num != 0)
				{
				}
				num = (short)33095680;
				short num3 = num;
				return this.secKmfProfRadioInhibitViaASTROOTAR_43690._HasDiffs;
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x00231844 File Offset: 0x0022FA44
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)440365927;
				short num2 = num;
				num = (short)1966240615;
				switch (num2 == num)
				{
				}
				num = (short)269287425;
				if (num != 0)
				{
				}
				num = (short)89325568;
				if (num != 0)
				{
				}
				num = (short)118882304;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00231904 File Offset: 0x0022FB04
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)826081280;
			short num2 = num;
			num = (short)1949094922;
			short num3 = num;
			num = (short)450024458;
			global::AcpCommonLib.IAcpRecordset result;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13C:
				if (base.ParentRecset.ContainerDoc == null)
				{
					return result;
				}
				num = (short)323944448;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1187840000;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_99;
				}
				break;
			}
			for (;;)
			{
				IL_7F:
				switch (num4)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1085734915;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)2027159553;
					if (num != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num = (short)2035351554;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)1521025028;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_122;
				case 4:
					goto IL_13C;
				}
				goto IL_99;
			}
			IL_122:
			return result;
			IL_99:
			result = null;
			num = (short)1839005697;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x04000D37 RID: 3383
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfASTROOTARInformationErasePreviousKeysetonOTARChangeover_A7978;

		// Token: 0x04000D38 RID: 3384
		private global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285;

		// Token: 0x04000D39 RID: 3385
		private global::AcpBusinessLayer.AcpListField secKmfProfASTROOTARInformationOTARRxSecurityLevel_A8674;

		// Token: 0x04000D3A RID: 3386
		private global::AcpBusinessLayer.AcpListField secKmfProfASTROOTARInformationOTARTxSecurityLevel_A8677;

		// Token: 0x04000D3B RID: 3387
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfASTROOTARInformationRekeyRequestStatusAlertTone_A8928;

		// Token: 0x04000D3C RID: 3388
		private global::AcpBusinessLayer.AcpListField secKmfProfASTROOTARInformationResponseKind_A8947;

		// Token: 0x04000D3D RID: 3389
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfASTROOTARInformationUserSelectableRekeyRequest_A9608;

		// Token: 0x04000D3E RID: 3390
		private global::AcpBusinessLayer.AcpKeyField secKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663;

		// Token: 0x04000D3F RID: 3391
		private global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfASTROOTARInformationNumberofAttempts_A8576;

		// Token: 0x04000D40 RID: 3392
		private global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfASTROOTARInformationOTARInactivityTimerhr_A8673;

		// Token: 0x04000D41 RID: 3393
		private global::AcpBusinessLayer.AcpRangeField<int, string> secKmfProfASTROOTARInformationTimeBetweenAttemptssec_A9375;

		// Token: 0x04000D42 RID: 3394
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfRadioInhibitViaASTROOTAR_43690;

		// Token: 0x04000D43 RID: 3395
		private global::AcpBusinessLayer.AcpSimpleRangeField kMFRSI;

		// Token: 0x04000D44 RID: 3396
		private global::AcpBusinessLayer.AcpSimpleRangeField messageNumberPeriod;
	}
}
