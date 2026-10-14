using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005CC RID: 1484
	[global::System.Serializable]
	public class Secure : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CAB6 RID: 51894 RVA: 0x00BD1E24 File Offset: 0x00BD0024
		public Secure(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x00BD1E40 File Offset: 0x00BD0040
		protected Secure(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x00BD1E58 File Offset: 0x00BD0058
		public override void Init()
		{
			int a_ = 0;
			short num = (short)116669461;
			short num2 = num;
			num = (short)1351433237;
			switch (num2 == num)
			{
			}
			num = (short)222232577;
			if (num != 0)
			{
			}
			num = (short)749273088;
			short num3 = num;
			num = (short)1840906240;
			if (num != 0)
			{
			}
			this.cnvPerSecureDESXLTxDefault_A7831 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖鷘黚軜蟞균럢鷤ꏦ賨跪賬髮鷰蟲ꫴ뛶컸쏺컼컾", a_), global::CommonResources.AcgResources.ID_DESXLTXDEFAULT);
			this.cnvPerSecureDESXLTxDefault_A7831.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSecureDESXLTxDefault_A7831.DataTransferOrder = 108;
			this.cnvPerSecureEchoMuteTimems_A7919 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖鳘룚뗜냞고離釤苦뷨苪胬諮鳰胲ꫴ뛶컸싺쳼웾", a_), global::CommonResources.AcgResources.ID_ECHOMUTETIMEMS, 0, 30, null, null, 0, 50);
			this.cnvPerSecureEchoMuteTimems_A7919.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerSecureEchoMuteTimems_A7919.DataTransferOrder = 118;
			this.cnvPerSecureEchoMuteTimems_A7919.ShowHexValue = false;
			this.cnvPerSecureKeyID_A8361 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖鋘뻚ꓜ雞ꗠ볢ꓤ\udfe6\udae8\uddea\udcec", a_), global::CommonResources.AcgResources.ID_KEYID, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureKeyID_A8361LovStrs);
			this.cnvPerSecureKeyID_A8361.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerSecureKeyID_A8361.DataTransferOrder = 48;
			this.cnvPerSecureKeySelection1_A8368 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖鋘뻚ꓜ賞蓠迢胤蓦鷨苪苬臮샰곲듴쿶쫸췺염", a_), global::CommonResources.AcgResources.ID_PACKETDATAKEYSELECT, null, null, true, false);
			this.cnvPerSecureKeySelection1_A8368.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSecureKeySelection1_A8368.DataTransferOrder = 115;
			this.cnvPerSecureKeySelection2_A8369 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖鋘뻚ꓜ賞蓠迢胤蓦鷨苪苬臮쏰곲듴쿶쫸췺쓼", a_), global::CommonResources.AcgResources.ID_VOICEKEYSELECT, null, null, true, false);
			this.cnvPerSecureKeySelection2_A8369.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSecureKeySelection2_A8369.DataTransferOrder = 111;
			this.cnvPerSecureKeyStrapping_A8370 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖鋘뻚ꓜ賞闠釢蓤韦駨苪菬裮껰닲췴쓶컸쯺", a_), global::CommonResources.AcgResources.ID_VOICEKEYSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureKeyStrapping_A8370LovStrs);
			this.cnvPerSecureKeyStrapping_A8370.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSecureKeyStrapping_A8370.DataTransferOrder = 99;
			this.cnvPerSecureKMFProfileIndex_A8381 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖鋘雚鯜连鏠賢菤軦藨軪ꓬ臮闰雲跴ꣶ룸쏺컼쟾\u3000", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false, new string[]
			{
				global::CommonResources.AcgResources.ID_KMFPROFILEINDEX
			});
			this.cnvPerSecureKMFProfileIndex_A8381.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSecureKMFProfileIndex_A8381.DataTransferOrder = 103;
			this.cnvPerSecureBroadbandASTROOTAR = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖鯘꧚닜뻞藠臢蓤触跨ꫪ뻬믮ꏰ볲뫴ꏶ룸ꧺ", a_), global::CommonResources.AcgResources.ID_BROADBANDASTROOTAR);
			this.cnvPerSecureBroadbandASTROOTAR.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSecureBroadbandASTROOTAR.DataTransferOrder = 127;
			this.cnvPerSecureOTARTx_A8675 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖雘迚鳜跞뗠鯢뫤ꛦ퇨\uddea\udaec\udaee", a_), global::CommonResources.AcgResources.ID_OTARTX);
			this.cnvPerSecureOTARTx_A8675.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSecureOTARTx_A8675.DataTransferOrder = 43;
			this.cnvPerSecureProperCodeDetect_A8762 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖觘꧚닜꿞蓠釢ꛤ裦跨軪ꧬ諮藰雲雴菶꛸뫺염죾㜀㄂", a_), global::CommonResources.AcgResources.ID_PROPERCODEDETECT);
			this.cnvPerSecureProperCodeDetect_A8762.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSecureProperCodeDetect_A8762.DataTransferOrder = 88;
			this.cnvPerSecureScanHoldoffStrapping_A9050 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖諘룚볜뇞ꧠ賢觤菦蛨跪诬볮藰臲铴蟶觸鋺鏼飾帀䈂㰄㜆㰈㬊", a_), global::CommonResources.AcgResources.ID_SCANHOLDOFFSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureScanHoldoffStrapping_A9050LovStrs);
			this.cnvPerSecureScanHoldoffStrapping_A9050.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerSecureScanHoldoffStrapping_A9050.DataTransferOrder = 90;
			this.cnvPerSecureScanSelect_A9056 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖諘룚볜뇞닠蛢觤苦諨鿪달껮죰쏲샴쇶", a_), global::CommonResources.AcgResources.ID_SCANSELECT, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureScanSelect_A9056LovStrs);
			this.cnvPerSecureScanSelect_A9056.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerSecureScanSelect_A9056.DataTransferOrder = 101;
			this.cnvPerSecureSecureVoiceSignalType_A9086 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖諘뻚뻜꫞鏠蛢돤裦胨裪裬볮飰铲鯴零闸꿺蓼迾搀専䐄㸆㤈㌊㬌", a_), global::CommonResources.AcgResources.ID_SECUREVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureSecureVoiceSignalType_A9086LovStrs);
			this.cnvPerSecureSecureVoiceSignalType_A9086.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSecureSecureVoiceSignalType_A9086.DataTransferOrder = 5;
			this.cnvPerSecureSecureClearStrapping2_A9091 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖諘뻚뻜꫞鏠蛢ꛤ详賨諪鿬볮藰臲铴蟶觸鋺鏼飾㌀専䐄㸆㤈㈊㰌", a_), global::CommonResources.AcgResources.ID_PACKETDATASECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureSecureClearStrapping2_A9091LovStrs);
			this.cnvPerSecureSecureClearStrapping2_A9091.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSecureSecureClearStrapping2_A9091.DataTransferOrder = 41;
			this.cnvPerSecureXLDelayFollowingKeyID_A9680 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖臘韚駜뫞跠苢鳤ꇦ蛨蟪臬胮蛰髲鯴郶닸黺蓼뛾䔀専䐄㸆㼈㌊㴌", a_), global::CommonResources.AcgResources.ID_XLDELAYFOLLOWINGKEYID, 0, 4, null, null, 0, 50);
			this.cnvPerSecureXLDelayFollowingKeyID_A9680.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerSecureXLDelayFollowingKeyID_A9680.DataTransferOrder = 126;
			this.cnvPerSecureXLDelayFollowingKeyID_A9680.ShowHexValue = false;
			this.cnvPerSecureXLTransmit_A9683 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖臘韚觜귞胠跢雤諦胨鿪달껮죰엲췴쓶", a_), global::CommonResources.AcgResources.ID_XLTRANSMIT);
			this.cnvPerSecureXLTransmit_A9683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSecureXLTransmit_A9683.DataTransferOrder = 57;
			this.cnvPerSecureIgnoreRxClearPacketData_A19310 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖郘볚돜냞鏠蛢럤鿦ꫨ蟪裬軮菰ꏲ铴银鋸黺觼믾怀眂搄堆䠈㨊㐌㰎‐⌒", a_), global::CommonResources.AcgResources.ID_PACKETDATAIGNORERXCLEARPACKETDATA);
			this.cnvPerSecureIgnoreRxClearPacketData_A19310.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSecureIgnoreRxClearPacketData_A19310.DataTransferOrder = 121;
			this.cnvPerSecureSecureClearStrapping1_A9090 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖諘뻚뻜꫞鏠蛢ꛤ详賨諪鿬볮藰臲铴蟶觸鋺鏼飾\u3000専䐄㸆㤈㈊㴌", a_), global::CommonResources.AcgResources.ID_VOICESECURECLEARSTRAPPING_1, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureSecureClearStrapping1_A9090LovStrs);
			this.cnvPerSecureSecureClearStrapping1_A9090.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerSecureSecureClearStrapping1_A9090.DataTransferOrder = 50;
			this.cnvPerSecureASTROOTAR_A7493 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊黌꫎닐ꛒ꟔닖飘裚觜跞껠곢뇤ꛦ믨듪곬\ud8ee연쫲웴", a_), global::CommonResources.AcgResources.ID_ASTROOTAR);
			this.cnvPerSecureASTROOTAR_A7493.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerSecureASTROOTAR_A7493.DataTransferOrder = 45;
			this.cnvPerIgnoreRxClearVoice_A41617 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苀귂도韆곈맊蓌꣎뿐볒꟔닖诘ꏚ黜돞蓠苢韤뇦蛨苪軬諮껰닲쇴웶쿸쫺쫼", a_), global::CommonResources.AcgResources.ID_VOICEIGNORERXCLEARVOICE);
			this.cnvPerIgnoreRxClearVoice_A41617.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerIgnoreRxClearVoice_A41617.DataTransferOrder = 49;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋀ꛂꛄ닆믈껊", a_);
			base.Id = 10142;
			base.UIName = global::CommonResources.AcgResources.ID_SECURE;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600CAB9 RID: 51897 RVA: 0x00BD2420 File Offset: 0x00BD0620
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1655963675;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3FD;
				case 1:
					this.cnvPerSecureBroadbandASTROOTAR = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢꟤闦蛨諪觬跮郰鷲釴뛶꫸꿺꿼냾一圂䐄唆", a_), global::CommonResources.AcgResources.ID_BROADBANDASTROOTAR);
					this.cnvPerSecureBroadbandASTROOTAR.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSecureBroadbandASTROOTAR.DataTransferOrder = 127;
					num = (short)159711249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢ꇤꋦ뫨돪ꇬ믮觰럲郴釶飸軺釼课帀䈂㈄㼆㨈㨊", a_)))
					{
						num = (short)2145976362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CF5;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢곤胦蟨蓪鿬諮ꏰ诲뛴鯶鳸髺迼꿾怀怂渄戆紈伊氌笎瀐䰒吔☖‘⠚Ⱌ⼞", a_)))
					{
						num = (short)2028142608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44A;
				case 4:
					num = (short)240123905;
					if (num != 0)
					{
					}
					goto IL_365;
				case 5:
					goto IL_B60;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢ꃤ蓦臨蓪ꃬ髮藰雲ꇴ黶铸黺郼賾帀䈂㈄㸆㠈㈊", a_)))
					{
						num = (short)821297165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3E;
				case 7:
					goto IL_870;
				case 8:
					this.cnvPerSecureSecureClearStrapping2_A9091 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤苦諨黪鿬諮닰鿲郴零诸꣺觼跾怀猂甄渆月氊㼌倎倐⨒└⸖⠘", a_), global::CommonResources.AcgResources.ID_PACKETDATASECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureSecureClearStrapping2_A9091LovStrs);
					this.cnvPerSecureSecureClearStrapping2_A9091.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSecureSecureClearStrapping2_A9091.DataTransferOrder = 41;
					num = (short)1984233525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.cnvPerSecureXLDelayFollowingKeyID_A9680 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뷤ꯦ귨軪臬軮裰뗲髴鯶闸铺諼雾漀搂丄戆瀈䈊䤌倎倐⨒⌔⼖⤘", a_), global::CommonResources.AcgResources.ID_XLDELAYFOLLOWINGKEYID, null, null, 0, 50);
					this.cnvPerSecureXLDelayFollowingKeyID_A9680.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerSecureXLDelayFollowingKeyID_A9680.DataTransferOrder = 126;
					this.cnvPerSecureXLDelayFollowingKeyID_A9680.ShowHexValue = false;
					num = (short)667615281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.cnvPerSecureScanHoldoffStrapping_A9050 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤蓦裨藪ꗬ胮鷰韲髴釶鿸꣺觼跾怀猂甄渆月氊刌与⠐⌒—✖", a_), global::CommonResources.AcgResources.ID_SCANHOLDOFFSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureScanHoldoffStrapping_A9050LovStrs);
					this.cnvPerSecureScanHoldoffStrapping_A9050.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerSecureScanHoldoffStrapping_A9050.DataTransferOrder = 90;
					num = (short)1515192353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_D99;
				case 12:
				{
					num = (short)409600000;
					short num3 = num;
					goto IL_7D8;
				}
				case 13:
					this.cnvPerSecureEchoMuteTimems_A7919 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢ꃤ蓦臨蓪ꃬ髮藰雲ꇴ黶铸黺郼賾帀䈂㈄㸆㠈㈊", a_), global::CommonResources.AcgResources.ID_ECHOMUTETIMEMS, null, null, 0, 50);
					this.cnvPerSecureEchoMuteTimems_A7919.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerSecureEchoMuteTimems_A7919.DataTransferOrder = 118;
					this.cnvPerSecureEchoMuteTimems_A7919.ShowHexValue = false;
					num = (short)2071658553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ郘볚돜냞鏠蛢럤鿦ꫨ蟪裬軮菰ꗲ髴黶髸黺ꋼ뻾㔀㈂㌄㘆㸈", a_)))
					{
						num = (short)2116354087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4C;
				case 15:
					goto IL_57D;
				case 16:
					this.cnvPerSecureIgnoreRxClearPacketData_A19310 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢곤胦蟨蓪鿬諮ꏰ诲뛴鯶鳸髺迼꿾怀怂渄戆紈伊氌笎瀐䰒吔☖‘⠚Ⱌ⼞", a_), global::CommonResources.AcgResources.ID_PACKETDATAIGNORERXCLEARPACKETDATA);
					this.cnvPerSecureIgnoreRxClearPacketData_A19310.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSecureIgnoreRxClearPacketData_A19310.DataTransferOrder = 121;
					num = (short)1949302838;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_741;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤苦部룪駬鷮郰菲藴黶韸鳺ꋼ뻾㤀。㈄㜆", a_)))
					{
						num = (short)603258905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_870;
				case 19:
					goto IL_BAE;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢ꫤ돦꣨맪맬韮껰닲췴쇶컸컺", a_)))
					{
						num = (short)1485963310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BAE;
				case 21:
					this.cnvPerSecureScanSelect_A9056 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤蓦裨藪뻬諮鷰雲雴菶꛸뫺쓼쿾㐀㔂", a_), global::CommonResources.AcgResources.ID_SCANSELECT, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureScanSelect_A9056LovStrs);
					this.cnvPerSecureScanSelect_A9056.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerSecureScanSelect_A9056.DataTransferOrder = 101;
					num = (short)376700940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤苦諨黪鿬諮닰鿲郴零诸꣺觼跾怀猂甄渆月氊㰌倎倐⨒└⸖⤘", a_)))
					{
						num = (short)2162722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_365;
				case 23:
					goto IL_78E;
				case 24:
					this.cnvPerSecureKeySelection1_A8368 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤苦部룪裬菮铰郲致黶雸闺쳼ꃾ䀀㬂㘄ㄆㄈ", a_), global::CommonResources.AcgResources.ID_PACKETDATAKEYSELECT, null, null, true, false);
					this.cnvPerSecureKeySelection1_A8368.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSecureKeySelection1_A8368.DataTransferOrder = 115;
					num = (short)940703744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.cnvPerSecureKeyStrapping_A8370 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤苦部룪駬鷮郰菲藴黶韸鳺ꋼ뻾㤀。㈄㜆", a_), global::CommonResources.AcgResources.ID_VOICEKEYSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureKeyStrapping_A8370LovStrs);
					this.cnvPerSecureKeyStrapping_A8370.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerSecureKeyStrapping_A8370.DataTransferOrder = 99;
					num = (short)1244594183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					num = (short)17367042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					switch (0)
					{
					case 0:
						goto IL_12E;
					}
					continue;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뷤ꯦ뷨駪賬臮苰黲鳴菶꛸뫺쓼짾㤀。", a_)))
					{
						num = (short)745996331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_264;
				case 29:
					this.cnvPerSecureKMFProfileIndex_A8381 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤ꫦ꿨믪鿬胮韰髲駴鋶냸闺駼髾礀専䐄㼆㨈㌊㰌", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false, new string[]
					{
						global::CommonResources.AcgResources.ID_KMFPROFILEINDEX
					});
					this.cnvPerSecureKMFProfileIndex_A8381.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSecureKMFProfileIndex_A8381.DataTransferOrder = 103;
					num = (short)1471086615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤蓦裨藪ꗬ胮鷰韲髴釶鿸꣺觼跾怀猂甄渆月氊刌与⠐⌒—✖", a_)))
					{
						num = (short)200212490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B1;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤苦諨黪鿬諮닰鿲郴零诸꣺觼跾怀猂甄渆月氊㼌倎倐⨒└⸖⠘", a_)))
					{
						num = (short)1789132808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EFC;
				case 32:
				{
					num = (short)1870702767;
					short num4 = num;
					num = (short)1226746031;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD9;
					default:
						num = (short)879820800;
						if (num != 0)
						{
						}
						this.cnvPerSecureSecureVoiceSignalType_A9086 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤苦諨黪鿬諮꟰鳲鳴银鳸꣺铼飾漀戂椄匆瀈笊栌倎倐⨒└⼖⼘", a_), global::CommonResources.AcgResources.ID_SECUREVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureSecureVoiceSignalType_A9086LovStrs);
						this.cnvPerSecureSecureVoiceSignalType_A9086.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.cnvPerSecureSecureVoiceSignalType_A9086.DataTransferOrder = 5;
						num = (short)1510080550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 33:
					goto IL_3B1;
				case 34:
					this.cnvPerSecureSecureClearStrapping1_A9090 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤苦諨黪鿬諮닰鿲郴零诸꣺觼跾怀猂甄渆月氊㰌倎倐⨒└⸖⤘", a_), global::CommonResources.AcgResources.ID_VOICESECURECLEARSTRAPPING_1, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureSecureClearStrapping1_A9090LovStrs);
					this.cnvPerSecureSecureClearStrapping1_A9090.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerSecureSecureClearStrapping1_A9090.DataTransferOrder = 50;
					num = (short)1374486532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤蓦裨藪뻬諮鷰雲雴菶꛸뫺쓼쿾㐀㔂", a_)))
					{
						num = (short)721485845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7D8;
				case 36:
					goto IL_4E7;
				case 37:
					this.cnvPerSecureKeySelection2_A8369 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤苦部룪裬菮铰郲致黶雸闺쿼ꃾ䀀㬂㘄ㄆ〈", a_), global::CommonResources.AcgResources.ID_VOICEKEYSELECT, null, null, true, false);
					this.cnvPerSecureKeySelection2_A8369.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerSecureKeySelection2_A8369.DataTransferOrder = 111;
					num = (short)80347181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_317;
				case 39:
					this.cnvPerIgnoreRxClearVoice_A41617 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ郘볚돜냞鏠蛢럤鿦ꫨ蟪裬軮菰ꗲ髴黶髸黺ꋼ뻾㔀㈂㌄㘆㸈", a_), global::CommonResources.AcgResources.ID_VOICEIGNORERXCLEARVOICE);
					this.cnvPerIgnoreRxClearVoice_A41617.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerIgnoreRxClearVoice_A41617.DataTransferOrder = 49;
					num = (short)1184956452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤ꫦ꿨믪鿬胮韰髲駴鋶냸闺駼髾礀専䐄㼆㨈㌊㰌", a_)))
					{
						num = (short)1040384029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78E;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤苦部룪裬菮铰郲致黶雸闺쳼ꃾ䀀㬂㘄ㄆㄈ", a_)))
					{
						num = (short)1731461144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3FD;
				case 42:
					this.cnvPerSecureDESXLTxDefault_A7831 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢ꇤꋦ뫨돪ꇬ믮觰럲郴釶飸軺釼课帀䈂㈄㼆㨈㨊", a_), global::CommonResources.AcgResources.ID_DESXLTXDEFAULT);
					this.cnvPerSecureDESXLTxDefault_A7831.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerSecureDESXLTxDefault_A7831.DataTransferOrder = 108;
					num = (short)1804861498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					this.cnvPerSecureXLTransmit_A9683 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뷤ꯦ뷨駪賬臮苰黲鳴菶꛸뫺쓼짾㤀。", a_), global::CommonResources.AcgResources.ID_XLTRANSMIT);
					this.cnvPerSecureXLTransmit_A9683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerSecureXLTransmit_A9683.DataTransferOrder = 57;
					num = (short)1722548274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴꣶ룸쳺짼웾㈀", a_)))
					{
						num = (short)1815412792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D99;
				case 45:
					goto IL_625;
				case 46:
					this.cnvPerSecureOTARTx_A8675 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢ꫤ돦꣨맪맬韮껰닲췴쇶컸컺", a_), global::CommonResources.AcgResources.ID_OTARTX);
					this.cnvPerSecureOTARTx_A8675.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSecureOTARTx_A8675.DataTransferOrder = 43;
					num = (short)2008875027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					if (producerFields != null)
					{
						num = (short)100139034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4C;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢꟤闦蛨諪觬跮郰鷲釴뛶꫸꿺꿼냾一圂䐄唆", a_)))
					{
						num = (short)1475084289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_741;
				case 49:
					goto IL_6F3;
				case 50:
					goto IL_264;
				case 51:
					this.cnvPerSecureProperCodeDetect_A8762 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뗤闦蛨鯪裬鷮닰鳲釴鋶뷸黺觼髾戀眂娄䘆ㄈ㰊㬌㴎", a_), global::CommonResources.AcgResources.ID_PROPERCODEDETECT);
					this.cnvPerSecureProperCodeDetect_A8762.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSecureProperCodeDetect_A8762.DataTransferOrder = 88;
					num = (short)1145503749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뷤ꯦ귨軪臬軮裰뗲髴鯶闸铺諼雾漀搂丄戆瀈䈊䤌倎倐⨒⌔⼖⤘", a_)))
					{
						num = (short)2010185737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F3;
				case 53:
					goto IL_EFC;
				case 54:
					goto IL_44A;
				case 55:
					num = (short)1391591471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					this.cnvPerSecureASTROOTAR_A7493 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢ꓤ듦뷨맪ꋬꃮꗰ닲ꟴꣶ룸쳺짼웾㈀", a_), global::CommonResources.AcgResources.ID_ASTROOTAR);
					this.cnvPerSecureASTROOTAR_A7493.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerSecureASTROOTAR_A7493.DataTransferOrder = 45;
					goto IL_CD9;
				case 57:
					goto IL_A3E;
				case 58:
					goto IL_CF5;
				case 59:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뗤闦蛨鯪裬鷮닰鳲釴鋶뷸黺觼髾戀眂娄䘆ㄈ㰊㬌㴎", a_)))
					{
						num = (short)938016819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B60;
				case 60:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤苦部ꋪꧬ냮냰쯲웴쇶죸", a_)))
					{
						num = (short)824442942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_57D;
				case 61:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤苦部룪裬菮铰郲致黶雸闺쿼ꃾ䀀㬂㘄ㄆ〈", a_)))
					{
						num = (short)440795173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_625;
				case 62:
					this.cnvPerSecureKeyID_A8361 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢껤苦部ꋪꧬ냮냰쯲웴쇶죸", a_), global::CommonResources.AcgResources.ID_KEYID, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerSecureKeyID_A8361LovStrs);
					this.cnvPerSecureKeyID_A8361.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerSecureKeyID_A8361.DataTransferOrder = 48;
					num = (short)1929576463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ菒냔ꗖ諘뻚뻜꫞鏠蛢뛤苦諨黪鿬諮꟰鳲鳴银鳸꣺铼飾漀戂椄匆瀈笊栌倎倐⨒└⼖⼘", a_)))
					{
						num = (short)118095904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_317;
				}
				IL_12E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1646002231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_264:
				num = (short)15138819;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_317:
				num = (short)2127167519;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_365:
				num = (short)1244004396;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B1:
				num = (short)1678573603;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3FD:
				num = (short)1648099389;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44A:
				num = (short)1967128598;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_57D:
				num = (short)326303785;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_625:
				num = (short)1947467794;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6F3:
				num = (short)180158492;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_741:
				num = (short)481296404;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_78E:
				num = (short)1510211632;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7D8:
				num = (short)1391525951;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_870:
				num = (short)1058340904;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A3E:
				num = (short)2053570620;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B60:
				num = (short)54460446;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BAE:
				num = (short)1325989947;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD9:
				num = (short)2028077067;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CF5:
				num = (short)1081868294;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D99:
				num = (short)1353842702;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EFC:
				num = (short)98697268;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4E7:
			IL_F4C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黌꫎닐ꛒ꟔닖", a_);
			base.Id = 10142;
			base.UIName = global::CommonResources.AcgResources.ID_SECURE;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x00BD33AC File Offset: 0x00BD15AC
		public override void PopulateReferences()
		{
			short num = (short)950206464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				for (;;)
				{
					IL_27:
					bool? flag2;
					bool? flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
					{
						num = (short)2088304641;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = secureKMFProfile.General;
						if (general == null)
						{
							bool? flag = null;
							num = (short)1200816131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = new bool?(general.SecKmfProfGenIndependentKeyList_43597.Value);
						goto IL_293;
					}
					case 1:
						goto IL_D7;
					case 2:
					{
						num = (short)680264;
						short num3 = num;
						num = (short)199450952;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D7;
						case 1:
							break;
						default:
						{
							num = (short)2001797120;
							short num4 = num;
							break;
						}
						}
						num = (short)891420672;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = this.cnvPerSecureKMFProfileIndex_A8381.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)1219166217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						bool? flag;
						flag2 = flag;
						goto IL_293;
					}
					case 4:
						num = (short)1875443718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_197;
					case 6:
						if (this.cnvPerSecureKMFProfileIndex_A8381.ReferencedNode != null)
						{
							num = (short)1698627586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF;
					case 7:
						if (this.cnvPerSecureKMFProfileIndex_A8381.Value > 0)
						{
							num = (short)1741553668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						embeddedRecset = secureKMFProfile.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
						num = (short)1288896517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)1496514561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF;
					}
					case 10:
						if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
						{
							num = (short)316014600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF;
					}
					goto IL_5A;
					IL_D7:
					num = (short)918880256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_293:
					flag3 = flag2;
					flag4 = true;
					num = (short)2128543754;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_197:
				IL_2DF:
				this.cnvPerSecureKeySelection1_A8368.SetRecset(embeddedRecset);
				this.cnvPerSecureKeySelection2_A8369.SetRecset(embeddedRecset);
				return;
				IL_5A:
				this.cnvPerSecureKMFProfileIndex_A8381.SetRecset(this.a(2055));
				embeddedRecset = this.a(2021)[0][10040].EmbeddedRecset;
				num = (short)1381695495;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x00BD36B0 File Offset: 0x00BD18B0
		public override void DropReferences()
		{
			short num = (short)1905358634;
			short num2 = num;
			num = (short)1373140778;
			switch (num2 == num)
			{
			}
			num = (short)509214720;
			short num3 = num;
			num = (short)917307393;
			if (num != 0)
			{
			}
			num = (short)1299447808;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CABC RID: 51900 RVA: 0x00BD3758 File Offset: 0x00BD1958
		public override void SetConstraints()
		{
			short num = (short)895047983;
			short num2 = num;
			num = (short)1981897007;
			switch (num2 == num)
			{
			}
			num = (short)177537024;
			short num3 = num;
			num = (short)308543489;
			if (num != 0)
			{
			}
			num = (short)646184960;
			if (num != 0)
			{
			}
			this.cnvPerSecureDESXLTxDefault_A7831.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvperNotNonAstroAndSecureHardwareAndTalkgroupStrappedNotClear);
			this.cnvPerSecureEchoMuteTimems_A7919.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConEchoMuteTimeFormulaConstraint);
			this.cnvPerSecureKeyID_A8361.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSecOperHWAndCnvPerCnvPerSelIsSecurenetAndCnvPerTypeIsMDC);
			this.cnvPerSecureKeySelection1_A8368.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerSecureKeySelectionApp);
			this.cnvPerSecureKeySelection1_A8368.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConKeySelect8368IsValid);
			this.cnvPerSecureKeySelection2_A8369.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDependOnSecureAndSecureII);
			this.cnvPerSecureKeySelection2_A8369.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConKeySelect8369IsValid);
			this.cnvPerSecureKeyStrapping_A8370.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSecureAdpAndNotNonAstroOrHwAndCnvChanStrappedNotClear);
			this.cnvPerSecureKMFProfileIndex_A8381.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSetValueAstroOTAR);
			this.cnvPerSecureKMFProfileIndex_A8381.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDependOnAstroOTARAndSecure);
			this.cnvPerSecureKMFProfileIndex_A8381.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerSecKMFProfIndexIsValid);
			this.cnvPerSecureOTARTx_A8675.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConOtarTxIsApplicable);
			this.cnvPerSecureOTARTx_A8675.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvOtarTxValidity);
			this.cnvPerSecureProperCodeDetect_A8762.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerSelIsSecurenetAndSecTypeIsHwAndDependOnSecure);
			this.cnvPerSecureScanHoldoffStrapping_A9050.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvRxSignalTypeIsNonASTROAndSecureOperIsHW);
			this.cnvPerSecureScanSelect_A9056.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConNotCnvXlTxAndCnvPerSelIsSecurenetAndDependOnSecure);
			this.cnvPerSecureScanSelect_A9056.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSecCfgXlicPrsntExtSetZeroCnvPerCnvXlTxSetOne);
			this.cnvPerSecureSecureVoiceSignalType_A9086.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSecureOperIsHWOrAdvancedDigitalPrivacyAndCnvRxSigTypeIsNotNonASTRO);
			this.cnvPerSecureSecureVoiceSignalType_A9086.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIfRxSigTypeIsNonASTROAndEmcEqpdExtThenSetSecurenetElseSetASTRO);
			this.cnvPerSecureSecureClearStrapping2_A9091.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSecureHardwareEnabledAndCnvPerSignallingAstroAndCnvPerTermDataEnabledAndPacketDataNotDisabled);
			this.cnvPerSecureSecureClearStrapping2_A9091.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerSecureXLDelayFollowingKeyID_A9680.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConConvKeyIdDoAppAndNotAPCOAndDependOnSecure);
			this.cnvPerSecureXLTransmit_A9683.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerIsSecurenetAndCnvTGDisabledAndCnvChanNotStrappedClear);
			this.cnvPerSecureIgnoreRxClearPacketData_A19310.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSecureHardwareAndCnvPerDataEnabledAndStrappedSecure);
			this.cnvPerSecureSecureClearStrapping1_A9090.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSecurenetEnableAndAstroTlkgrpDisableAndRxVoiceSignalTypeDependence);
			this.cnvPerSecureSecureClearStrapping1_A9090.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConStrpIsClearOrAnalogFlatAudioDisabled);
			this.cnvPerSecureSecureClearStrapping1_A9090.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerSecureASTROOTAR_A7493.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSetValueKMFProfileIndex);
			this.cnvPerSecureASTROOTAR_A7493.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvAstroOtarAvailable);
			this.cnvPerSecureASTROOTAR_A7493.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvAstroOtarValidity);
			this.cnvPerSecureASTROOTAR_A7493.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvAstroOtarAvailableEditbl);
			this.cnvPerIgnoreRxClearVoice_A41617.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSecureOperationIsNotDisabledForConPer);
			this.cnvPerSecureBroadbandASTROOTAR.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerSecureBroadbandASTROOTARIsApplicable);
			this.cnvPerSecureBroadbandASTROOTAR.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerSecureBroadbandASTROOTARValueSetter);
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x00BD3B10 File Offset: 0x00BD1D10
		public override void SetupDependencies()
		{
			short num = (short)1095264075;
			short num2 = num;
			num = (short)1805608779;
			switch (num2 == num)
			{
			}
			num = (short)682491905;
			if (num != 0)
			{
			}
			num = (short)1683161088;
			short num3 = num;
			num = (short)1806696448;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureDESXLTxDefault_A7831);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureDESXLTxDefault_A7831);
			this.cnvPerSecureSecureVoiceSignalType_A9086.AddDependentObject(this.cnvPerSecureDESXLTxDefault_A7831);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSecureDESXLTxDefault_A7831);
			this.cnvPerSecureSecureClearStrapping1_A9090.AddDependentObject(this.cnvPerSecureDESXLTxDefault_A7831);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSecureDESXLTxDefault_A7831);
			this.cnvPerSecureSecureClearStrapping2_A9091.AddDependentObject(this.cnvPerSecureDESXLTxDefault_A7831);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSecureEchoMuteTimems_A7919);
			this.cnvPerSecureSecureClearStrapping1_A9090.AddDependentObject(this.cnvPerSecureEchoMuteTimems_A7919);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureEchoMuteTimems_A7919);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureEchoMuteTimems_A7919);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureKeyID_A8361);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSecureKeyID_A8361);
			this.cnvPerSecureSecureVoiceSignalType_A9086.AddDependentObject(this.cnvPerSecureKeyID_A8361);
			this.cnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			this.cnvPerSecureKMFProfileIndex_A8381.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			this.cnvPerSecureSecureClearStrapping2_A9091.AddDependentObject(this.cnvPerSecureKeySelection1_A8368);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureKeySelection2_A8369);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSecureKeySelection2_A8369);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureKeySelection2_A8369);
			this.cnvPerSecureSecureClearStrapping1_A9090.AddDependentObject(this.cnvPerSecureKeySelection2_A8369);
			this.cnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerSecureKeySelection2_A8369);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerSecureKeySelection2_A8369);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerSecureKeySelection2_A8369);
			this.cnvPerSecureKMFProfileIndex_A8381.AddDependentObject(this.cnvPerSecureKeySelection2_A8369);
			this.cnvPerSecureSecureClearStrapping1_A9090.AddDependentObject(this.cnvPerSecureKeyStrapping_A8370);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSecureKeyStrapping_A8370);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureKeyStrapping_A8370);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureKeyStrapping_A8370);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			this.cnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			conventionalPersonality.Features.CnvPerFeaturesTacticalRekeyEnable_A19309.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			this.RefsecureKMFProfile.DataTransport.SecKmfProfDataTransportOTARTransport.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSecureKMFProfileIndex_A8381);
			conventionalPersonality.Features.CnvPerFeaturesTacticalRekeyEnable_A19309.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			this.RefSecureWide.MDCOTAR.SecWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			this.cnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSecureOTARTx_A8675);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureProperCodeDetect_A8762);
			this.cnvPerSecureSecureVoiceSignalType_A9086.AddDependentObject(this.cnvPerSecureProperCodeDetect_A8762);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureScanHoldoffStrapping_A9050);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureScanHoldoffStrapping_A9050);
			this.cnvPerSecureXLTransmit_A9683.AddDependentObject(this.cnvPerSecureScanSelect_A9056);
			this.cnvPerSecureSecureVoiceSignalType_A9086.AddDependentObject(this.cnvPerSecureScanSelect_A9056);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureScanSelect_A9056);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureSecureVoiceSignalType_A9086);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureSecureVoiceSignalType_A9086);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureSecureClearStrapping2_A9091);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSecureSecureClearStrapping2_A9091);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureSecureClearStrapping2_A9091);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.cnvPerSecureSecureClearStrapping2_A9091);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSecureSecureClearStrapping2_A9091);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvPerSecureSecureClearStrapping2_A9091);
			this.cnvPerSecureXLTransmit_A9683.AddDependentObject(this.cnvPerSecureXLDelayFollowingKeyID_A9680);
			this.cnvPerSecureKeyID_A8361.AddDependentObject(this.cnvPerSecureXLDelayFollowingKeyID_A9680);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureXLDelayFollowingKeyID_A9680);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureXLDelayFollowingKeyID_A9680);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerSecureXLDelayFollowingKeyID_A9680);
			this.cnvPerSecureSecureVoiceSignalType_A9086.AddDependentObject(this.cnvPerSecureXLDelayFollowingKeyID_A9680);
			this.cnvPerSecureSecureClearStrapping1_A9090.AddDependentObject(this.cnvPerSecureXLDelayFollowingKeyID_A9680);
			this.cnvPerSecureSecureVoiceSignalType_A9086.AddDependentObject(this.cnvPerSecureXLTransmit_A9683);
			this.cnvPerSecureSecureClearStrapping1_A9090.AddDependentObject(this.cnvPerSecureXLTransmit_A9683);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureXLTransmit_A9683);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureXLTransmit_A9683);
			this.cnvPerSecureSecureClearStrapping2_A9091.AddDependentObject(this.cnvPerSecureIgnoreRxClearPacketData_A19310);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureIgnoreRxClearPacketData_A19310);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureIgnoreRxClearPacketData_A19310);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerSecureIgnoreRxClearPacketData_A19310);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSecureIgnoreRxClearPacketData_A19310);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvPerSecureIgnoreRxClearPacketData_A19310);
			this.cnvPerSecureSecureVoiceSignalType_A9086.AddDependentObject(this.cnvPerSecureSecureClearStrapping1_A9090);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerSecureSecureClearStrapping1_A9090);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureSecureClearStrapping1_A9090);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureSecureClearStrapping1_A9090);
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogFlatAudio_A7443.AddDependentObject(this.cnvPerSecureSecureClearStrapping1_A9090);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548.AddDependentObject(this.cnvPerSecureSecureClearStrapping1_A9090);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerSecureASTROOTAR_A7493);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerSecureASTROOTAR_A7493);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerSecureASTROOTAR_A7493);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureASTROOTAR_A7493);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSecureASTROOTAR_A7493);
			conventionalPersonality.Features.CnvPerFeaturesTacticalRekeyEnable_A19309.AddDependentObject(this.cnvPerSecureASTROOTAR_A7493);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerIgnoreRxClearVoice_A41617);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerIgnoreRxClearVoice_A41617);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerSecureBroadbandASTROOTAR);
			this.RefSecureWide.General.SecWideGeneralOTAROperation_43700.AddDependentObject(this.cnvPerSecureBroadbandASTROOTAR);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerSecureBroadbandASTROOTAR);
			this.RefDataWide.LTE.DataWideLTEHWEnable.AddDependentObject(this.cnvPerSecureBroadbandASTROOTAR);
			this.RefDataWide.WIFI.DataWideWIFIEnable_42506.AddDependentObject(this.cnvPerSecureBroadbandASTROOTAR);
		}

		// Token: 0x170065C8 RID: 26056
		// (get) Token: 0x0600CABE RID: 51902 RVA: 0x00BD45EC File Offset: 0x00BD27EC
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvPerSecureKeySelection1_A8368
		{
			get
			{
				short num = (short)1193774202;
				short num2 = num;
				num = (short)10587258;
				switch (num2 == num)
				{
				}
				num = (short)664731649;
				if (num != 0)
				{
				}
				num = (short)1516306432;
				short num3 = num;
				num = (short)1447559168;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x170065C9 RID: 26057
		// (get) Token: 0x0600CABF RID: 51903 RVA: 0x00BD46A4 File Offset: 0x00BD28A4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvPerSecureKeySelection2_A8369
		{
			get
			{
				short num = (short)1603715321;
				short num2 = num;
				num = (short)136298745;
				switch (num2 == num)
				{
				}
				num = (short)843055104;
				if (num != 0)
				{
				}
				num = (short)2120286208;
				short num3 = num;
				num = (short)8847361;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x170065CA RID: 26058
		// (get) Token: 0x0600CAC0 RID: 51904 RVA: 0x00BD4760 File Offset: 0x00BD2960
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile SecureKMFProfileForCnvPerSecureKMFProfileIndex_A8381
		{
			get
			{
				short num = (short)1148129928;
				short num2 = num;
				num = (short)1201279624;
				switch (num2 == num)
				{
				}
				num = (short)146931713;
				if (num != 0)
				{
				}
				num = (short)1360330752;
				short num3 = num;
				num = (short)600309760;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			}
		}

		// Token: 0x170065CB RID: 26059
		// (get) Token: 0x0600CAC1 RID: 51905 RVA: 0x00BD481C File Offset: 0x00BD2A1C
		public bool HasDiffs
		{
			get
			{
				short num = (short)958537308;
				short num2 = num;
				num = (short)2119573084;
				switch (num2 == num)
				{
				}
				num = (short)809304065;
				if (num != 0)
				{
				}
				num = (short)603717632;
				short num3 = num;
				num = (short)1554644992;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170065CC RID: 26060
		// (get) Token: 0x0600CAC2 RID: 51906 RVA: 0x00BD48D0 File Offset: 0x00BD2AD0
		// (set) Token: 0x0600CAC3 RID: 51907 RVA: 0x00BD4984 File Offset: 0x00BD2B84
		public bool CnvPerSecureDESXLTxDefault_A7831Value
		{
			get
			{
				short num = (short)1693723372;
				short num2 = num;
				num = (short)2112301804;
				switch (num2 == num)
				{
				}
				num = (short)571342848;
				if (num != 0)
				{
				}
				num = (short)1925513216;
				short num3 = num;
				num = (short)1316159489;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.Value;
			}
			set
			{
				short num = (short)290949609;
				short num2 = num;
				num = (short)514689513;
				switch (num2 == num)
				{
				}
				num = (short)783220736;
				if (num != 0)
				{
				}
				num = (short)1718550528;
				short num3 = num;
				num = (short)833093633;
				if (num != 0)
				{
				}
				this.cnvPerSecureDESXLTxDefault_A7831.Value = value;
			}
		}

		// Token: 0x170065CD RID: 26061
		// (get) Token: 0x0600CAC4 RID: 51908 RVA: 0x00BD4A38 File Offset: 0x00BD2C38
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSecureDESXLTxDefault_A7831
		{
			get
			{
				short num = (short)1101769637;
				short num2 = num;
				num = (short)782543781;
				switch (num2 == num)
				{
				}
				num = (short)116195329;
				if (num != 0)
				{
				}
				num = (short)646447104;
				short num3 = num;
				num = (short)961871872;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831;
			}
		}

		// Token: 0x170065CE RID: 26062
		// (get) Token: 0x0600CAC5 RID: 51909 RVA: 0x00BD4AE4 File Offset: 0x00BD2CE4
		// (set) Token: 0x0600CAC6 RID: 51910 RVA: 0x00BD4B98 File Offset: 0x00BD2D98
		public bool CnvPerSecureDESXLTxDefault_A7831_UIValue
		{
			get
			{
				short num = (short)1462091295;
				short num2 = num;
				num = (short)2124135967;
				switch (num2 == num)
				{
				}
				num = (short)1483210753;
				if (num != 0)
				{
				}
				num = (short)1761935360;
				short num3 = num;
				num = (short)1728708608;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.Value;
			}
			set
			{
				short num = (short)1564501802;
				short num2 = num;
				num = (short)739993386;
				switch (num2 == num)
				{
				}
				num = (short)1317404673;
				if (num != 0)
				{
				}
				num = (short)385351680;
				short num3 = num;
				num = (short)1256325120;
				if (num != 0)
				{
				}
				this.cnvPerSecureDESXLTxDefault_A7831.Value = value;
			}
		}

		// Token: 0x170065CF RID: 26063
		// (get) Token: 0x0600CAC7 RID: 51911 RVA: 0x00BD4C4C File Offset: 0x00BD2E4C
		// (set) Token: 0x0600CAC8 RID: 51912 RVA: 0x00BD4D00 File Offset: 0x00BD2F00
		public bool CnvPerSecureDESXLTxDefault_A7831_Applicable
		{
			get
			{
				short num = (short)32805609;
				short num2 = num;
				num = (short)1625002729;
				switch (num2 == num)
				{
				}
				num = (short)1195442177;
				if (num != 0)
				{
				}
				num = (short)1392312320;
				short num3 = num;
				num = (short)125960192;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.Applicable;
			}
			set
			{
				short num = (short)1490288641;
				if (num != 0)
				{
				}
				num = (short)1927726215;
				short num2 = num;
				num = (short)1260766343;
				switch (num2 == num)
				{
				}
				num = (short)1718812672;
				short num3 = num;
				num = (short)778764288;
				if (num != 0)
				{
				}
				this.cnvPerSecureDESXLTxDefault_A7831.Applicable = value;
			}
		}

		// Token: 0x170065D0 RID: 26064
		// (get) Token: 0x0600CAC9 RID: 51913 RVA: 0x00BD4DB4 File Offset: 0x00BD2FB4
		// (set) Token: 0x0600CACA RID: 51914 RVA: 0x00BD4E6C File Offset: 0x00BD306C
		public bool CnvPerSecureDESXLTxDefault_A7831_Valid
		{
			get
			{
				short num = (short)2035548161;
				if (num != 0)
				{
				}
				num = (short)1572739847;
				short num2 = num;
				num = (short)2046368519;
				switch (num2 == num)
				{
				}
				num = (short)1397882880;
				short num3 = num;
				num = (short)480968704;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.Valid;
			}
			set
			{
				short num = (short)1562645070;
				short num2 = num;
				num = (short)1595740750;
				switch (num2 == num)
				{
				}
				num = (short)562954240;
				if (num != 0)
				{
				}
				num = (short)786497536;
				short num3 = num;
				num = (short)1433403393;
				if (num != 0)
				{
				}
				this.cnvPerSecureDESXLTxDefault_A7831.Valid = value;
			}
		}

		// Token: 0x170065D1 RID: 26065
		// (get) Token: 0x0600CACB RID: 51915 RVA: 0x00BD4F24 File Offset: 0x00BD3124
		// (set) Token: 0x0600CACC RID: 51916 RVA: 0x00BD4FD8 File Offset: 0x00BD31D8
		public bool CnvPerSecureDESXLTxDefault_A7831_Visible
		{
			get
			{
				short num = (short)516168207;
				short num2 = num;
				num = (short)1919490575;
				switch (num2 == num)
				{
				}
				num = (short)196280321;
				if (num != 0)
				{
				}
				num = (short)2008023040;
				short num3 = num;
				num = (short)2140733440;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.Visible;
			}
			set
			{
				short num = (short)305115857;
				short num2 = num;
				num = (short)606778065;
				switch (num2 == num)
				{
				}
				num = (short)605618177;
				if (num != 0)
				{
				}
				num = (short)229703680;
				short num3 = num;
				num = (short)1658585088;
				if (num != 0)
				{
				}
				this.cnvPerSecureDESXLTxDefault_A7831.Visible = value;
			}
		}

		// Token: 0x170065D2 RID: 26066
		// (get) Token: 0x0600CACD RID: 51917 RVA: 0x00BD5090 File Offset: 0x00BD3290
		// (set) Token: 0x0600CACE RID: 51918 RVA: 0x00BD5144 File Offset: 0x00BD3344
		public bool CnvPerSecureDESXLTxDefault_A7831_Editable
		{
			get
			{
				short num = (short)2111389788;
				short num2 = num;
				num = (short)1708802140;
				switch (num2 == num)
				{
				}
				num = (short)817561600;
				if (num != 0)
				{
				}
				num = (short)262537216;
				short num3 = num;
				num = (short)1715273729;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.Editable;
			}
			set
			{
				short num = (short)1169272373;
				short num2 = num;
				num = (short)698396213;
				switch (num2 == num)
				{
				}
				num = (short)1554513920;
				if (num != 0)
				{
				}
				num = (short)2024013824;
				short num3 = num;
				num = (short)896532481;
				if (num != 0)
				{
				}
				this.cnvPerSecureDESXLTxDefault_A7831.Editable = value;
			}
		}

		// Token: 0x170065D3 RID: 26067
		// (get) Token: 0x0600CACF RID: 51919 RVA: 0x00BD51FC File Offset: 0x00BD33FC
		internal string CnvPerSecureDESXLTxDefault_A7831_UILabel
		{
			get
			{
				short num = (short)1520532020;
				short num2 = num;
				num = (short)1052539444;
				switch (num2 == num)
				{
				}
				num = (short)280625152;
				if (num != 0)
				{
				}
				num = (short)786694144;
				short num3 = num;
				num = (short)1716125697;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.UIName;
			}
		}

		// Token: 0x170065D4 RID: 26068
		// (get) Token: 0x0600CAD0 RID: 51920 RVA: 0x00BD52B0 File Offset: 0x00BD34B0
		// (set) Token: 0x0600CAD1 RID: 51921 RVA: 0x00BD5364 File Offset: 0x00BD3564
		internal bool CnvPerSecureDESXLTxDefault_A7831_HiddenStatic
		{
			get
			{
				short num = (short)939710735;
				short num2 = num;
				num = (short)1981143311;
				switch (num2 == num)
				{
				}
				num = (short)510722049;
				if (num != 0)
				{
				}
				num = (short)1369243648;
				short num3 = num;
				num = (short)583401472;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.HiddenStatic;
			}
			set
			{
				short num = (short)540122746;
				short num2 = num;
				num = (short)44080762;
				switch (num2 == num)
				{
				}
				num = (short)1725562881;
				if (num != 0)
				{
				}
				num = (short)287506432;
				short num3 = num;
				num = (short)903282688;
				if (num != 0)
				{
				}
				this.cnvPerSecureDESXLTxDefault_A7831.HiddenStatic = value;
			}
		}

		// Token: 0x170065D5 RID: 26069
		// (get) Token: 0x0600CAD2 RID: 51922 RVA: 0x00BD5418 File Offset: 0x00BD3618
		// (set) Token: 0x0600CAD3 RID: 51923 RVA: 0x00BD54CC File Offset: 0x00BD36CC
		internal bool CnvPerSecureDESXLTxDefault_A7831_HiddenDynamic
		{
			get
			{
				short num = (short)909870463;
				short num2 = num;
				num = (short)723551615;
				switch (num2 == num)
				{
				}
				num = (short)719060993;
				if (num != 0)
				{
				}
				num = (short)289538048;
				short num3 = num;
				num = (short)898564096;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831.HiddenDynamic;
			}
			set
			{
				short num = (short)1683079300;
				short num2 = num;
				num = (short)649904260;
				switch (num2 == num)
				{
				}
				num = (short)1339817985;
				if (num != 0)
				{
				}
				num = (short)1645936640;
				short num3 = num;
				num = (short)1391656960;
				if (num != 0)
				{
				}
				this.cnvPerSecureDESXLTxDefault_A7831.HiddenDynamic = value;
			}
		}

		// Token: 0x170065D6 RID: 26070
		// (get) Token: 0x0600CAD4 RID: 51924 RVA: 0x00BD5584 File Offset: 0x00BD3784
		public bool CnvPerSecureDESXLTxDefault_A7831_HasDiffs
		{
			get
			{
				short num = (short)164419644;
				short num2 = num;
				num = (short)487184444;
				switch (num2 == num)
				{
				}
				num = (short)46596097;
				if (num != 0)
				{
				}
				num = (short)941228032;
				short num3 = num;
				num = (short)1696595968;
				if (num != 0)
				{
				}
				return this.cnvPerSecureDESXLTxDefault_A7831._HasDiffs;
			}
		}

		// Token: 0x170065D7 RID: 26071
		// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x00BD5638 File Offset: 0x00BD3838
		// (set) Token: 0x0600CAD6 RID: 51926 RVA: 0x00BD56EC File Offset: 0x00BD38EC
		public int CnvPerSecureEchoMuteTimems_A7919Value
		{
			get
			{
				short num = (short)287297840;
				short num2 = num;
				num = (short)205181232;
				switch (num2 == num)
				{
				}
				num = (short)301006848;
				if (num != 0)
				{
				}
				num = (short)268828672;
				short num3 = num;
				num = (short)501153793;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.Value;
			}
			set
			{
				short num = (short)542774113;
				short num2 = num;
				num = (short)1456542561;
				switch (num2 == num)
				{
				}
				num = (short)223805441;
				if (num != 0)
				{
				}
				num = (short)1058013184;
				short num3 = num;
				num = (short)138936320;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.Value = value;
			}
		}

		// Token: 0x170065D8 RID: 26072
		// (get) Token: 0x0600CAD7 RID: 51927 RVA: 0x00BD57A4 File Offset: 0x00BD39A4
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerSecureEchoMuteTimems_A7919
		{
			get
			{
				short num = (short)1692266553;
				short num2 = num;
				num = (short)1192554553;
				switch (num2 == num)
				{
				}
				num = (short)1466302465;
				if (num != 0)
				{
				}
				num = (short)1388707840;
				short num3 = num;
				num = (short)2132410368;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919;
			}
		}

		// Token: 0x170065D9 RID: 26073
		// (get) Token: 0x0600CAD8 RID: 51928 RVA: 0x00BD5858 File Offset: 0x00BD3A58
		// (set) Token: 0x0600CAD9 RID: 51929 RVA: 0x00BD590C File Offset: 0x00BD3B0C
		public string CnvPerSecureEchoMuteTimems_A7919_UIValue
		{
			get
			{
				short num = (short)1500743834;
				short num2 = num;
				num = (short)499943578;
				switch (num2 == num)
				{
				}
				num = (short)34603009;
				if (num != 0)
				{
				}
				num = (short)1333264384;
				short num3 = num;
				num = (short)1403584512;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.UIValue;
			}
			set
			{
				short num = (short)1989744919;
				short num2 = num;
				num = (short)1899239703;
				switch (num2 == num)
				{
				}
				num = (short)1846149120;
				if (num != 0)
				{
				}
				num = (short)1244266496;
				short num3 = num;
				num = (short)1841823745;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.UIValue = value;
			}
		}

		// Token: 0x170065DA RID: 26074
		// (get) Token: 0x0600CADA RID: 51930 RVA: 0x00BD59C4 File Offset: 0x00BD3BC4
		// (set) Token: 0x0600CADB RID: 51931 RVA: 0x00BD5A78 File Offset: 0x00BD3C78
		internal int CnvPerSecureEchoMuteTimems_A7919Min
		{
			get
			{
				short num = (short)1810359074;
				short num2 = num;
				num = (short)1852039970;
				switch (num2 == num)
				{
				}
				num = (short)26869760;
				if (num != 0)
				{
				}
				num = (short)159776768;
				short num3 = num;
				num = (short)839450625;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.Min;
			}
			set
			{
				short num = (short)524419073;
				if (num != 0)
				{
				}
				num = (short)1442515144;
				short num2 = num;
				num = (short)1243744456;
				switch (num2 == num)
				{
				}
				num = (short)1896939520;
				short num3 = num;
				num = (short)103612416;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.Min = value;
			}
		}

		// Token: 0x170065DB RID: 26075
		// (get) Token: 0x0600CADC RID: 51932 RVA: 0x00BD5B2C File Offset: 0x00BD3D2C
		// (set) Token: 0x0600CADD RID: 51933 RVA: 0x00BD5BE0 File Offset: 0x00BD3DE0
		internal int CnvPerSecureEchoMuteTimems_A7919Max
		{
			get
			{
				short num = (short)1335296001;
				if (num != 0)
				{
				}
				num = (short)1348464100;
				short num2 = num;
				num = (short)699854308;
				switch (num2 == num)
				{
				}
				num = (short)2099773440;
				short num3 = num;
				num = (short)593166336;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.Max;
			}
			set
			{
				short num = (short)566951937;
				if (num != 0)
				{
				}
				num = (short)714300622;
				short num2 = num;
				num = (short)1828740302;
				switch (num2 == num)
				{
				}
				num = (short)1719599104;
				short num3 = num;
				num = (short)933691392;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.Max = value;
			}
		}

		// Token: 0x170065DC RID: 26076
		// (get) Token: 0x0600CADE RID: 51934 RVA: 0x00BD5C98 File Offset: 0x00BD3E98
		// (set) Token: 0x0600CADF RID: 51935 RVA: 0x00BD5D50 File Offset: 0x00BD3F50
		internal int CnvPerSecureEchoMuteTimems_A7919Step
		{
			get
			{
				short num = (short)1793705951;
				short num2 = num;
				num = (short)1481230303;
				switch (num2 == num)
				{
				}
				num = (short)1021050880;
				if (num != 0)
				{
				}
				num = (short)1774452736;
				short num3 = num;
				num = (short)2046164993;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.StepSize;
			}
			set
			{
				short num = (short)1676736817;
				short num2 = num;
				num = (short)1765144881;
				switch (num2 == num)
				{
				}
				num = (short)567410689;
				if (num != 0)
				{
				}
				num = (short)502267904;
				short num3 = num;
				num = (short)1713111040;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.StepSize = value;
			}
		}

		// Token: 0x170065DD RID: 26077
		// (get) Token: 0x0600CAE0 RID: 51936 RVA: 0x00BD5E08 File Offset: 0x00BD4008
		// (set) Token: 0x0600CAE1 RID: 51937 RVA: 0x00BD5EC0 File Offset: 0x00BD40C0
		public bool CnvPerSecureEchoMuteTimems_A7919_Applicable
		{
			get
			{
				short num = (short)603968333;
				short num2 = num;
				num = (short)1991168845;
				switch (num2 == num)
				{
				}
				num = (short)1050542081;
				if (num != 0)
				{
				}
				num = (short)1765343232;
				short num3 = num;
				num = (short)121700352;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.Applicable;
			}
			set
			{
				short num = (short)743630162;
				short num2 = num;
				num = (short)631235922;
				switch (num2 == num)
				{
				}
				num = (short)467009537;
				if (num != 0)
				{
				}
				num = (short)1313079296;
				short num3 = num;
				num = (short)1255866368;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.Applicable = value;
			}
		}

		// Token: 0x170065DE RID: 26078
		// (get) Token: 0x0600CAE2 RID: 51938 RVA: 0x00BD5F74 File Offset: 0x00BD4174
		// (set) Token: 0x0600CAE3 RID: 51939 RVA: 0x00BD6028 File Offset: 0x00BD4228
		public bool CnvPerSecureEchoMuteTimems_A7919_Valid
		{
			get
			{
				short num = (short)724616009;
				short num2 = num;
				num = (short)1942143817;
				switch (num2 == num)
				{
				}
				num = (short)1908867073;
				if (num != 0)
				{
				}
				num = (short)1711472640;
				short num3 = num;
				num = (short)404226048;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.Valid;
			}
			set
			{
				short num = (short)660498926;
				short num2 = num;
				num = (short)1092446702;
				switch (num2 == num)
				{
				}
				num = (short)1916665857;
				if (num != 0)
				{
				}
				num = (short)1798176768;
				short num3 = num;
				num = (short)378732544;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.Valid = value;
			}
		}

		// Token: 0x170065DF RID: 26079
		// (get) Token: 0x0600CAE4 RID: 51940 RVA: 0x00BD60E0 File Offset: 0x00BD42E0
		// (set) Token: 0x0600CAE5 RID: 51941 RVA: 0x00BD6194 File Offset: 0x00BD4394
		public bool CnvPerSecureEchoMuteTimems_A7919_Visible
		{
			get
			{
				short num = (short)145293313;
				if (num != 0)
				{
				}
				num = (short)2103316685;
				short num2 = num;
				num = (short)272437453;
				switch (num2 == num)
				{
				}
				num = (short)1105461248;
				short num3 = num;
				num = (short)628228096;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.Visible;
			}
			set
			{
				short num = (short)1583153860;
				short num2 = num;
				num = (short)699335364;
				switch (num2 == num)
				{
				}
				num = (short)86835201;
				if (num != 0)
				{
				}
				num = (short)1545535488;
				short num3 = num;
				num = (short)1416888320;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.Visible = value;
			}
		}

		// Token: 0x170065E0 RID: 26080
		// (get) Token: 0x0600CAE6 RID: 51942 RVA: 0x00BD6248 File Offset: 0x00BD4448
		// (set) Token: 0x0600CAE7 RID: 51943 RVA: 0x00BD62F8 File Offset: 0x00BD44F8
		public bool CnvPerSecureEchoMuteTimems_A7919_Editable
		{
			get
			{
				short num = (short)1351027542;
				short num2 = num;
				num = (short)1446579030;
				switch (num2 == num)
				{
				}
				num = (short)837025793;
				if (num != 0)
				{
				}
				num = (short)75694080;
				short num3 = num;
				num = (short)503054336;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.Editable;
			}
			set
			{
				short num = (short)1142226957;
				short num2 = num;
				num = (short)1178271757;
				switch (num2 == num)
				{
				}
				num = (short)1001324545;
				if (num != 0)
				{
				}
				num = (short)1952972800;
				short num3 = num;
				num = (short)1690435584;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.Editable = value;
			}
		}

		// Token: 0x170065E1 RID: 26081
		// (get) Token: 0x0600CAE8 RID: 51944 RVA: 0x00BD63AC File Offset: 0x00BD45AC
		internal string CnvPerSecureEchoMuteTimems_A7919_UILabel
		{
			get
			{
				short num = (short)179149047;
				short num2 = num;
				num = (short)1777244407;
				switch (num2 == num)
				{
				}
				num = (short)2490368;
				if (num != 0)
				{
				}
				num = (short)1739063296;
				short num3 = num;
				num = (short)1294073857;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.UIName;
			}
		}

		// Token: 0x170065E2 RID: 26082
		// (get) Token: 0x0600CAE9 RID: 51945 RVA: 0x00BD6464 File Offset: 0x00BD4664
		// (set) Token: 0x0600CAEA RID: 51946 RVA: 0x00BD6518 File Offset: 0x00BD4718
		internal bool CnvPerSecureEchoMuteTimems_A7919_HiddenStatic
		{
			get
			{
				short num = (short)76747013;
				short num2 = num;
				num = (short)1826820357;
				switch (num2 == num)
				{
				}
				num = (short)1530527744;
				if (num != 0)
				{
				}
				num = (short)2050097152;
				short num3 = num;
				num = (short)1618935809;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.HiddenStatic;
			}
			set
			{
				short num = (short)634502356;
				short num2 = num;
				num = (short)211467476;
				switch (num2 == num)
				{
				}
				num = (short)783220736;
				if (num != 0)
				{
				}
				num = (short)1134821376;
				short num3 = num;
				num = (short)2094399489;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.HiddenStatic = value;
			}
		}

		// Token: 0x170065E3 RID: 26083
		// (get) Token: 0x0600CAEB RID: 51947 RVA: 0x00BD65CC File Offset: 0x00BD47CC
		// (set) Token: 0x0600CAEC RID: 51948 RVA: 0x00BD6680 File Offset: 0x00BD4880
		internal bool CnvPerSecureEchoMuteTimems_A7919_HiddenDynamic
		{
			get
			{
				short num = (short)1329707601;
				short num2 = num;
				num = (short)526367313;
				switch (num2 == num)
				{
				}
				num = (short)614334465;
				if (num != 0)
				{
				}
				num = (short)5767168;
				short num3 = num;
				num = (short)918880256;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919.HiddenDynamic;
			}
			set
			{
				short num = (short)1231177288;
				short num2 = num;
				num = (short)1027819080;
				switch (num2 == num)
				{
				}
				num = (short)678297600;
				if (num != 0)
				{
				}
				num = (short)1215758336;
				short num3 = num;
				num = (short)180944897;
				if (num != 0)
				{
				}
				this.cnvPerSecureEchoMuteTimems_A7919.HiddenDynamic = value;
			}
		}

		// Token: 0x170065E4 RID: 26084
		// (get) Token: 0x0600CAED RID: 51949 RVA: 0x00BD6738 File Offset: 0x00BD4938
		public bool CnvPerSecureEchoMuteTimems_A7919_HasDiffs
		{
			get
			{
				short num = (short)1593148953;
				short num2 = num;
				num = (short)154830361;
				switch (num2 == num)
				{
				}
				num = (short)395509760;
				if (num != 0)
				{
				}
				num = (short)1129971712;
				short num3 = num;
				num = (short)706019329;
				if (num != 0)
				{
				}
				return this.cnvPerSecureEchoMuteTimems_A7919._HasDiffs;
			}
		}

		// Token: 0x170065E5 RID: 26085
		// (get) Token: 0x0600CAEE RID: 51950 RVA: 0x00BD67EC File Offset: 0x00BD49EC
		// (set) Token: 0x0600CAEF RID: 51951 RVA: 0x00BD68A0 File Offset: 0x00BD4AA0
		public int CnvPerSecureKeyID_A8361Value
		{
			get
			{
				short num = (short)1202743422;
				short num2 = num;
				num = (short)2063427710;
				switch (num2 == num)
				{
				}
				num = (short)511836160;
				if (num != 0)
				{
				}
				num = (short)435748864;
				short num3 = num;
				num = (short)722993153;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.Value;
			}
			set
			{
				short num = (short)139525049;
				short num2 = num;
				num = (short)1731394489;
				switch (num2 == num)
				{
				}
				num = (short)2087256065;
				if (num != 0)
				{
				}
				num = (short)1346830336;
				short num3 = num;
				num = (short)492371968;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyID_A8361.Value = value;
			}
		}

		// Token: 0x170065E6 RID: 26086
		// (get) Token: 0x0600CAF0 RID: 51952 RVA: 0x00BD6958 File Offset: 0x00BD4B58
		// (set) Token: 0x0600CAF1 RID: 51953 RVA: 0x00BD6A0C File Offset: 0x00BD4C0C
		public string CnvPerSecureKeyID_A8361_UIValue
		{
			get
			{
				short num = (short)2117270137;
				short num2 = num;
				num = (short)2094660217;
				switch (num2 == num)
				{
				}
				num = (short)1614413825;
				if (num != 0)
				{
				}
				num = (short)2085289984;
				short num3 = num;
				num = (short)834011136;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.UIValue;
			}
			set
			{
				short num = (short)1331160851;
				short num2 = num;
				num = (short)2112087827;
				switch (num2 == num)
				{
				}
				num = (short)1541275649;
				if (num != 0)
				{
				}
				num = (short)786038784;
				short num3 = num;
				num = (short)345571328;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyID_A8361.UIValue = value;
			}
		}

		// Token: 0x170065E7 RID: 26087
		// (get) Token: 0x0600CAF2 RID: 51954 RVA: 0x00BD6AC0 File Offset: 0x00BD4CC0
		public global::AcpBusinessLayer.AcpListField CnvPerSecureKeyID_A8361
		{
			get
			{
				short num = (short)896401409;
				if (num != 0)
				{
				}
				num = (short)41393690;
				short num2 = num;
				num = (short)396008986;
				switch (num2 == num)
				{
				}
				num = (short)1727397888;
				short num3 = num;
				num = (short)1315241984;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361;
			}
		}

		// Token: 0x170065E8 RID: 26088
		// (get) Token: 0x0600CAF3 RID: 51955 RVA: 0x00BD6B70 File Offset: 0x00BD4D70
		// (set) Token: 0x0600CAF4 RID: 51956 RVA: 0x00BD6C24 File Offset: 0x00BD4E24
		public bool CnvPerSecureKeyID_A8361_Applicable
		{
			get
			{
				short num = (short)2086124212;
				short num2 = num;
				num = (short)1311161012;
				switch (num2 == num)
				{
				}
				num = (short)312016897;
				if (num != 0)
				{
				}
				num = (short)394592256;
				short num3 = num;
				num = (short)103153664;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.Applicable;
			}
			set
			{
				short num = (short)2033115595;
				short num2 = num;
				num = (short)1689575883;
				switch (num2 == num)
				{
				}
				num = (short)1523318785;
				if (num != 0)
				{
				}
				num = (short)1390739456;
				short num3 = num;
				num = (short)1329856512;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyID_A8361.Applicable = value;
			}
		}

		// Token: 0x170065E9 RID: 26089
		// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x00BD6CDC File Offset: 0x00BD4EDC
		// (set) Token: 0x0600CAF6 RID: 51958 RVA: 0x00BD6D90 File Offset: 0x00BD4F90
		public bool CnvPerSecureKeyID_A8361_Valid
		{
			get
			{
				short num = (short)1561906165;
				short num2 = num;
				num = (short)731368437;
				switch (num2 == num)
				{
				}
				num = (short)1614872577;
				if (num != 0)
				{
				}
				num = (short)1949564928;
				short num3 = num;
				num = (short)609878016;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.Valid;
			}
			set
			{
				short num = (short)77260989;
				short num2 = num;
				num = (short)1731979453;
				switch (num2 == num)
				{
				}
				num = (short)1795489793;
				if (num != 0)
				{
				}
				num = (short)1168441344;
				short num3 = num;
				num = (short)112132096;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyID_A8361.Valid = value;
			}
		}

		// Token: 0x170065EA RID: 26090
		// (get) Token: 0x0600CAF7 RID: 51959 RVA: 0x00BD6E48 File Offset: 0x00BD5048
		// (set) Token: 0x0600CAF8 RID: 51960 RVA: 0x00BD6EFC File Offset: 0x00BD50FC
		public bool CnvPerSecureKeyID_A8361_Visible
		{
			get
			{
				short num = (short)1531920727;
				short num2 = num;
				num = (short)1797210455;
				switch (num2 == num)
				{
				}
				num = (short)240779264;
				if (num != 0)
				{
				}
				num = (short)1161822208;
				short num3 = num;
				num = (short)1210712065;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.Visible;
			}
			set
			{
				short num = (short)653328385;
				if (num != 0)
				{
				}
				num = (short)1702169338;
				short num2 = num;
				num = (short)1264061178;
				switch (num2 == num)
				{
				}
				num = (short)1992359936;
				short num3 = num;
				num = (short)2104033280;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyID_A8361.Visible = value;
			}
		}

		// Token: 0x170065EB RID: 26091
		// (get) Token: 0x0600CAF9 RID: 51961 RVA: 0x00BD6FB4 File Offset: 0x00BD51B4
		// (set) Token: 0x0600CAFA RID: 51962 RVA: 0x00BD7068 File Offset: 0x00BD5268
		public bool CnvPerSecureKeyID_A8361_Editable
		{
			get
			{
				short num = (short)1689926322;
				short num2 = num;
				num = (short)1204239026;
				switch (num2 == num)
				{
				}
				num = (short)1771241472;
				short num3 = num;
				num = (short)2038562816;
				if (num != 0)
				{
				}
				num = (short)1534918657;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.Editable;
			}
			set
			{
				short num = (short)1629421902;
				short num2 = num;
				num = (short)1379729742;
				switch (num2 == num)
				{
				}
				num = (short)591396864;
				short num3 = num;
				num = (short)1495203841;
				if (num != 0)
				{
				}
				num = (short)827129856;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyID_A8361.Editable = value;
			}
		}

		// Token: 0x170065EC RID: 26092
		// (get) Token: 0x0600CAFB RID: 51963 RVA: 0x00BD7120 File Offset: 0x00BD5320
		internal string CnvPerSecureKeyID_A8361_UILabel
		{
			get
			{
				short num = (short)1479381646;
				short num2 = num;
				num = (short)1853592206;
				switch (num2 == num)
				{
				}
				num = (short)108003328;
				short num3 = num;
				num = (short)373424129;
				if (num != 0)
				{
				}
				num = (short)2015363072;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.UIName;
			}
		}

		// Token: 0x170065ED RID: 26093
		// (get) Token: 0x0600CAFC RID: 51964 RVA: 0x00BD71D4 File Offset: 0x00BD53D4
		// (set) Token: 0x0600CAFD RID: 51965 RVA: 0x00BD728C File Offset: 0x00BD548C
		internal bool CnvPerSecureKeyID_A8361_HiddenStatic
		{
			get
			{
				short num = (short)233495293;
				short num2 = num;
				num = (short)677960445;
				switch (num2 == num)
				{
				}
				num = (short)1890385920;
				short num3 = num;
				num = (short)202178561;
				if (num != 0)
				{
				}
				num = (short)961150976;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.HiddenStatic;
			}
			set
			{
				short num = (short)602300001;
				short num2 = num;
				num = (short)565993057;
				switch (num2 == num)
				{
				}
				num = (short)1232601088;
				short num3 = num;
				num = (short)49741825;
				if (num != 0)
				{
				}
				num = (short)1382875136;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyID_A8361.HiddenStatic = value;
			}
		}

		// Token: 0x170065EE RID: 26094
		// (get) Token: 0x0600CAFE RID: 51966 RVA: 0x00BD7344 File Offset: 0x00BD5544
		// (set) Token: 0x0600CAFF RID: 51967 RVA: 0x00BD73FC File Offset: 0x00BD55FC
		internal bool CnvPerSecureKeyID_A8361_HiddenDynamic
		{
			get
			{
				short num = (short)1054778628;
				short num2 = num;
				num = (short)1568646404;
				switch (num2 == num)
				{
				}
				num = (short)1758068736;
				short num3 = num;
				num = (short)891355137;
				if (num != 0)
				{
				}
				num = (short)2101739520;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361.HiddenDynamic;
			}
			set
			{
				short num = (short)61171640;
				short num2 = num;
				num = (short)909273016;
				switch (num2 == num)
				{
				}
				num = (short)1910702080;
				short num3 = num;
				num = (short)124715008;
				if (num != 0)
				{
				}
				num = (short)916193281;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyID_A8361.HiddenDynamic = value;
			}
		}

		// Token: 0x170065EF RID: 26095
		// (get) Token: 0x0600CB00 RID: 51968 RVA: 0x00BD74B0 File Offset: 0x00BD56B0
		public bool CnvPerSecureKeyID_A8361_HasDiffs
		{
			get
			{
				short num = (short)1643533095;
				short num2 = num;
				num = (short)2005947175;
				switch (num2 == num)
				{
				}
				num = (short)2055864320;
				short num3 = num;
				num = (short)1091239937;
				if (num != 0)
				{
				}
				num = (short)1772683264;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyID_A8361._HasDiffs;
			}
		}

		// Token: 0x170065F0 RID: 26096
		// (get) Token: 0x0600CB01 RID: 51969 RVA: 0x00BD7564 File Offset: 0x00BD5764
		// (set) Token: 0x0600CB02 RID: 51970 RVA: 0x00BD7618 File Offset: 0x00BD5818
		public int CnvPerSecureKeySelection1_A8368Value
		{
			get
			{
				short num = (short)1573460253;
				short num2 = num;
				num = (short)2049186077;
				switch (num2 == num)
				{
				}
				num = (short)1864564736;
				short num3 = num;
				num = (short)1863057409;
				if (num != 0)
				{
				}
				num = (short)2136801280;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.Value;
			}
			set
			{
				short num = (short)934364865;
				short num2 = num;
				num = (short)2051229377;
				switch (num2 == num)
				{
				}
				num = (short)1968832512;
				short num3 = num;
				num = (short)494731265;
				if (num != 0)
				{
				}
				num = (short)855375872;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection1_A8368.Value = value;
			}
		}

		// Token: 0x170065F1 RID: 26097
		// (get) Token: 0x0600CB03 RID: 51971 RVA: 0x00BD76CC File Offset: 0x00BD58CC
		// (set) Token: 0x0600CB04 RID: 51972 RVA: 0x00BD7780 File Offset: 0x00BD5980
		public string CnvPerSecureKeySelection1_A8368_UIValue
		{
			get
			{
				short num = (short)1295895935;
				short num2 = num;
				num = (short)1799867775;
				switch (num2 == num)
				{
				}
				num = (short)86835200;
				short num3 = num;
				num = (short)396034049;
				if (num != 0)
				{
				}
				num = (short)1613758464;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.UIValue;
			}
			set
			{
				short num = (short)1048673555;
				short num2 = num;
				num = (short)1853521171;
				switch (num2 == num)
				{
				}
				num = (short)652738560;
				short num3 = num;
				num = (short)1966669825;
				if (num != 0)
				{
				}
				num = (short)1525415936;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection1_A8368.UIValue = value;
			}
		}

		// Token: 0x170065F2 RID: 26098
		// (get) Token: 0x0600CB05 RID: 51973 RVA: 0x00BD7838 File Offset: 0x00BD5A38
		public global::AcpBusinessLayer.AcpRecRefField CnvPerSecureKeySelection1_A8368
		{
			get
			{
				short num = (short)1724400710;
				short num2 = num;
				num = (short)1923040326;
				switch (num2 == num)
				{
				}
				num = (short)946601984;
				short num3 = num;
				num = (short)1271988225;
				if (num != 0)
				{
				}
				num = (short)1314521088;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368;
			}
		}

		// Token: 0x170065F3 RID: 26099
		// (get) Token: 0x0600CB06 RID: 51974 RVA: 0x00BD78E8 File Offset: 0x00BD5AE8
		// (set) Token: 0x0600CB07 RID: 51975 RVA: 0x00BD799C File Offset: 0x00BD5B9C
		public bool CnvPerSecureKeySelection1_A8368_Applicable
		{
			get
			{
				short num = (short)711092583;
				short num2 = num;
				num = (short)1590847847;
				switch (num2 == num)
				{
				}
				num = (short)536543232;
				short num3 = num;
				num = (short)870514689;
				if (num != 0)
				{
				}
				num = (short)1742274560;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.Applicable;
			}
			set
			{
				short num = (short)1714017867;
				short num2 = num;
				num = (short)395171403;
				switch (num2 == num)
				{
				}
				num = (short)149422080;
				short num3 = num;
				num = (short)2111700992;
				if (num != 0)
				{
				}
				num = (short)1685651457;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection1_A8368.Applicable = value;
			}
		}

		// Token: 0x170065F4 RID: 26100
		// (get) Token: 0x0600CB08 RID: 51976 RVA: 0x00BD7A50 File Offset: 0x00BD5C50
		// (set) Token: 0x0600CB09 RID: 51977 RVA: 0x00BD7B04 File Offset: 0x00BD5D04
		public bool CnvPerSecureKeySelection1_A8368_Valid
		{
			get
			{
				short num = (short)746127361;
				if (num != 0)
				{
				}
				num = (short)1118868260;
				short num2 = num;
				num = (short)1786745636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1457979392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1831010304;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.Valid;
			}
			set
			{
				short num = (short)1591182706;
				short num2 = num;
				num = (short)1267369330;
				switch (num2 == num)
				{
				}
				num = (short)1444151296;
				short num3 = num;
				num = (short)2145058816;
				if (num != 0)
				{
				}
				num = (short)620036097;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection1_A8368.Valid = value;
			}
		}

		// Token: 0x170065F5 RID: 26101
		// (get) Token: 0x0600CB0A RID: 51978 RVA: 0x00BD7BB8 File Offset: 0x00BD5DB8
		// (set) Token: 0x0600CB0B RID: 51979 RVA: 0x00BD7C6C File Offset: 0x00BD5E6C
		public bool CnvPerSecureKeySelection1_A8368_Visible
		{
			get
			{
				short num = (short)1675372428;
				short num2 = num;
				num = (short)1798776716;
				switch (num2 == num)
				{
				}
				num = (short)1338245120;
				short num3 = num;
				num = (short)419037184;
				if (num != 0)
				{
				}
				num = (short)1210122241;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.Visible;
			}
			set
			{
				short num = (short)2097792822;
				short num2 = num;
				num = (short)337430326;
				switch (num2 == num)
				{
				}
				num = (short)1610219520;
				short num3 = num;
				num = (short)372899840;
				if (num != 0)
				{
				}
				num = (short)49217537;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection1_A8368.Visible = value;
			}
		}

		// Token: 0x170065F6 RID: 26102
		// (get) Token: 0x0600CB0C RID: 51980 RVA: 0x00BD7D20 File Offset: 0x00BD5F20
		// (set) Token: 0x0600CB0D RID: 51981 RVA: 0x00BD7DD4 File Offset: 0x00BD5FD4
		public bool CnvPerSecureKeySelection1_A8368_Editable
		{
			get
			{
				short num = (short)884347996;
				short num2 = num;
				num = (short)823661660;
				switch (num2 == num)
				{
				}
				num = (short)1893859328;
				short num3 = num;
				num = (short)1588592640;
				if (num != 0)
				{
				}
				num = (short)1203044353;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.Editable;
			}
			set
			{
				short num = (short)575209473;
				if (num != 0)
				{
				}
				num = (short)732322064;
				short num2 = num;
				num = (short)1434278160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187184640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349962240;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection1_A8368.Editable = value;
			}
		}

		// Token: 0x170065F7 RID: 26103
		// (get) Token: 0x0600CB0E RID: 51982 RVA: 0x00BD7E8C File Offset: 0x00BD608C
		internal string CnvPerSecureKeySelection1_A8368_UILabel
		{
			get
			{
				short num = (short)2107812337;
				short num2 = num;
				num = (short)382839281;
				switch (num2 == num)
				{
				}
				num = (short)943980544;
				short num3 = num;
				num = (short)789839873;
				if (num != 0)
				{
				}
				num = (short)548601856;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.UIName;
			}
		}

		// Token: 0x170065F8 RID: 26104
		// (get) Token: 0x0600CB0F RID: 51983 RVA: 0x00BD7F3C File Offset: 0x00BD613C
		// (set) Token: 0x0600CB10 RID: 51984 RVA: 0x00BD7FF0 File Offset: 0x00BD61F0
		internal bool CnvPerSecureKeySelection1_A8368_HiddenStatic
		{
			get
			{
				short num = (short)1563755137;
				short num2 = num;
				num = (short)367985281;
				switch (num2 == num)
				{
				}
				num = (short)203292672;
				short num3 = num;
				num = (short)1363083264;
				if (num != 0)
				{
				}
				num = (short)196673537;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.HiddenStatic;
			}
			set
			{
				short num = (short)679870465;
				if (num != 0)
				{
				}
				num = (short)1420603544;
				short num2 = num;
				num = (short)897953944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)869859328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1721237504;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection1_A8368.HiddenStatic = value;
			}
		}

		// Token: 0x170065F9 RID: 26105
		// (get) Token: 0x0600CB11 RID: 51985 RVA: 0x00BD80A8 File Offset: 0x00BD62A8
		// (set) Token: 0x0600CB12 RID: 51986 RVA: 0x00BD815C File Offset: 0x00BD635C
		internal bool CnvPerSecureKeySelection1_A8368_HiddenDynamic
		{
			get
			{
				short num = (short)1805903720;
				short num2 = num;
				num = (short)1711335272;
				switch (num2 == num)
				{
				}
				num = (short)1319567360;
				short num3 = num;
				num = (short)703070209;
				if (num != 0)
				{
				}
				num = (short)157614080;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368.HiddenDynamic;
			}
			set
			{
				short num = (short)163581518;
				short num2 = num;
				num = (short)2123959886;
				switch (num2 == num)
				{
				}
				num = (short)719519744;
				short num3 = num;
				num = (short)1523318785;
				if (num != 0)
				{
				}
				num = (short)1746731008;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection1_A8368.HiddenDynamic = value;
			}
		}

		// Token: 0x170065FA RID: 26106
		// (get) Token: 0x0600CB13 RID: 51987 RVA: 0x00BD8214 File Offset: 0x00BD6414
		public bool CnvPerSecureKeySelection1_A8368_HasDiffs
		{
			get
			{
				short num = (short)1092880081;
				short num2 = num;
				num = (short)1470105297;
				switch (num2 == num)
				{
				}
				num = (short)2078998528;
				short num3 = num;
				num = (short)250150913;
				if (num != 0)
				{
				}
				num = (short)1614807040;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection1_A8368._HasDiffs;
			}
		}

		// Token: 0x170065FB RID: 26107
		// (get) Token: 0x0600CB14 RID: 51988 RVA: 0x00BD82C8 File Offset: 0x00BD64C8
		// (set) Token: 0x0600CB15 RID: 51989 RVA: 0x00BD8380 File Offset: 0x00BD6580
		public int CnvPerSecureKeySelection2_A8369Value
		{
			get
			{
				short num = (short)927924225;
				if (num != 0)
				{
				}
				num = (short)6471348;
				short num2 = num;
				num = (short)52477620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)979697664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)25952256;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.Value;
			}
			set
			{
				short num = (short)1603210539;
				short num2 = num;
				num = (short)309660971;
				switch (num2 == num)
				{
				}
				num = (short)2121465856;
				short num3 = num;
				num = (short)1461452801;
				if (num != 0)
				{
				}
				num = (short)2037186560;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection2_A8369.Value = value;
			}
		}

		// Token: 0x170065FC RID: 26108
		// (get) Token: 0x0600CB16 RID: 51990 RVA: 0x00BD8438 File Offset: 0x00BD6638
		// (set) Token: 0x0600CB17 RID: 51991 RVA: 0x00BD84EC File Offset: 0x00BD66EC
		public string CnvPerSecureKeySelection2_A8369_UIValue
		{
			get
			{
				short num = (short)1620639745;
				if (num != 0)
				{
				}
				num = (short)324212581;
				short num2 = num;
				num = (short)423761765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1828585472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1694105600;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.UIValue;
			}
			set
			{
				short num = (short)1113980929;
				if (num != 0)
				{
				}
				num = (short)280692567;
				short num2 = num;
				num = (short)1305347927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1407844352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)726401024;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection2_A8369.UIValue = value;
			}
		}

		// Token: 0x170065FD RID: 26109
		// (get) Token: 0x0600CB18 RID: 51992 RVA: 0x00BD85A4 File Offset: 0x00BD67A4
		public global::AcpBusinessLayer.AcpRecRefField CnvPerSecureKeySelection2_A8369
		{
			get
			{
				short num = (short)1186790548;
				short num2 = num;
				num = (short)754318484;
				switch (num2 == num)
				{
				}
				num = (short)1264975872;
				short num3 = num;
				num = (short)939655168;
				if (num != 0)
				{
				}
				num = (short)1008861185;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369;
			}
		}

		// Token: 0x170065FE RID: 26110
		// (get) Token: 0x0600CB19 RID: 51993 RVA: 0x00BD8654 File Offset: 0x00BD6854
		// (set) Token: 0x0600CB1A RID: 51994 RVA: 0x00BD8708 File Offset: 0x00BD6908
		public bool CnvPerSecureKeySelection2_A8369_Applicable
		{
			get
			{
				short num = (short)1570275825;
				short num2 = num;
				num = (short)1182630385;
				switch (num2 == num)
				{
				}
				num = (short)396296192;
				short num3 = num;
				num = (short)1684602881;
				if (num != 0)
				{
				}
				num = (short)1074724864;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.Applicable;
			}
			set
			{
				short num = (short)1747017459;
				short num2 = num;
				num = (short)1481334515;
				switch (num2 == num)
				{
				}
				num = (short)1336999936;
				short num3 = num;
				num = (short)1436155905;
				if (num != 0)
				{
				}
				num = (short)1638858752;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection2_A8369.Applicable = value;
			}
		}

		// Token: 0x170065FF RID: 26111
		// (get) Token: 0x0600CB1B RID: 51995 RVA: 0x00BD87C0 File Offset: 0x00BD69C0
		// (set) Token: 0x0600CB1C RID: 51996 RVA: 0x00BD8870 File Offset: 0x00BD6A70
		public bool CnvPerSecureKeySelection2_A8369_Valid
		{
			get
			{
				short num = (short)1517278746;
				short num2 = num;
				num = (short)1780012570;
				switch (num2 == num)
				{
				}
				num = (short)940834816;
				short num3 = num;
				num = (short)1258684417;
				if (num != 0)
				{
				}
				num = (short)1611923456;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.Valid;
			}
			set
			{
				short num = (short)1558905205;
				short num2 = num;
				num = (short)417988981;
				switch (num2 == num)
				{
				}
				num = (short)1951203328;
				short num3 = num;
				num = (short)1246298113;
				if (num != 0)
				{
				}
				num = (short)1827471360;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection2_A8369.Valid = value;
			}
		}

		// Token: 0x17006600 RID: 26112
		// (get) Token: 0x0600CB1D RID: 51997 RVA: 0x00BD8924 File Offset: 0x00BD6B24
		// (set) Token: 0x0600CB1E RID: 51998 RVA: 0x00BD89D8 File Offset: 0x00BD6BD8
		public bool CnvPerSecureKeySelection2_A8369_Visible
		{
			get
			{
				short num = (short)337051649;
				if (num != 0)
				{
				}
				num = (short)477722824;
				short num2 = num;
				num = (short)230652104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1400897536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109314048;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.Visible;
			}
			set
			{
				short num = (short)715400463;
				short num2 = num;
				num = (short)586360079;
				switch (num2 == num)
				{
				}
				num = (short)838205440;
				short num3 = num;
				num = (short)1381826560;
				if (num != 0)
				{
				}
				num = (short)16842753;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection2_A8369.Visible = value;
			}
		}

		// Token: 0x17006601 RID: 26113
		// (get) Token: 0x0600CB1F RID: 51999 RVA: 0x00BD8A8C File Offset: 0x00BD6C8C
		// (set) Token: 0x0600CB20 RID: 52000 RVA: 0x00BD8B40 File Offset: 0x00BD6D40
		public bool CnvPerSecureKeySelection2_A8369_Editable
		{
			get
			{
				short num = (short)147470997;
				short num2 = num;
				num = (short)1718827669;
				switch (num2 == num)
				{
				}
				num = (short)1172307968;
				short num3 = num;
				num = (short)564789249;
				if (num != 0)
				{
				}
				num = (short)1949761536;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.Editable;
			}
			set
			{
				short num = (short)980839424;
				short num2 = num;
				num = (short)2096983040;
				switch (num2 == num)
				{
				}
				num = (short)432996352;
				short num3 = num;
				num = (short)489226241;
				if (num != 0)
				{
				}
				num = (short)1874067456;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection2_A8369.Editable = value;
			}
		}

		// Token: 0x17006602 RID: 26114
		// (get) Token: 0x0600CB21 RID: 52001 RVA: 0x00BD8BF8 File Offset: 0x00BD6DF8
		internal string CnvPerSecureKeySelection2_A8369_UILabel
		{
			get
			{
				short num = (short)1211323675;
				short num2 = num;
				num = (short)1334859035;
				switch (num2 == num)
				{
				}
				num = (short)339410944;
				short num3 = num;
				num = (short)442695680;
				if (num != 0)
				{
				}
				num = (short)1388314625;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.UIName;
			}
		}

		// Token: 0x17006603 RID: 26115
		// (get) Token: 0x0600CB22 RID: 52002 RVA: 0x00BD8CB0 File Offset: 0x00BD6EB0
		// (set) Token: 0x0600CB23 RID: 52003 RVA: 0x00BD8D64 File Offset: 0x00BD6F64
		internal bool CnvPerSecureKeySelection2_A8369_HiddenStatic
		{
			get
			{
				short num = (short)67659561;
				short num2 = num;
				num = (short)1898080041;
				switch (num2 == num)
				{
				}
				num = (short)1282670592;
				short num3 = num;
				num = (short)1124007937;
				if (num != 0)
				{
				}
				num = (short)373620736;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.HiddenStatic;
			}
			set
			{
				short num = (short)1952918826;
				short num2 = num;
				num = (short)1027943722;
				switch (num2 == num)
				{
				}
				num = (short)426049536;
				short num3 = num;
				num = (short)204668929;
				if (num != 0)
				{
				}
				num = (short)1909850112;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection2_A8369.HiddenStatic = value;
			}
		}

		// Token: 0x17006604 RID: 26116
		// (get) Token: 0x0600CB24 RID: 52004 RVA: 0x00BD8E1C File Offset: 0x00BD701C
		// (set) Token: 0x0600CB25 RID: 52005 RVA: 0x00BD8ED0 File Offset: 0x00BD70D0
		internal bool CnvPerSecureKeySelection2_A8369_HiddenDynamic
		{
			get
			{
				short num = (short)2052472663;
				short num2 = num;
				num = (short)636698455;
				switch (num2 == num)
				{
				}
				num = (short)1480720384;
				short num3 = num;
				num = (short)1790443521;
				if (num != 0)
				{
				}
				num = (short)927268864;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369.HiddenDynamic;
			}
			set
			{
				short num = (short)619944703;
				short num2 = num;
				num = (short)178232063;
				switch (num2 == num)
				{
				}
				num = (short)1184038912;
				short num3 = num;
				num = (short)126418945;
				if (num != 0)
				{
				}
				num = (short)467337216;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeySelection2_A8369.HiddenDynamic = value;
			}
		}

		// Token: 0x17006605 RID: 26117
		// (get) Token: 0x0600CB26 RID: 52006 RVA: 0x00BD8F88 File Offset: 0x00BD7188
		public bool CnvPerSecureKeySelection2_A8369_HasDiffs
		{
			get
			{
				short num = (short)648707749;
				short num2 = num;
				num = (short)556433061;
				switch (num2 == num)
				{
				}
				num = (short)962985984;
				short num3 = num;
				num = (short)583467008;
				if (num != 0)
				{
				}
				num = (short)1085800449;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeySelection2_A8369._HasDiffs;
			}
		}

		// Token: 0x17006606 RID: 26118
		// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x00BD903C File Offset: 0x00BD723C
		// (set) Token: 0x0600CB28 RID: 52008 RVA: 0x00BD90F0 File Offset: 0x00BD72F0
		public int CnvPerSecureKeyStrapping_A8370Value
		{
			get
			{
				short num = (short)287094323;
				short num2 = num;
				num = (short)1491777075;
				switch (num2 == num)
				{
				}
				num = (short)432472064;
				short num3 = num;
				num = (short)1252196352;
				if (num != 0)
				{
				}
				num = (short)1615921153;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.Value;
			}
			set
			{
				short num = (short)1315143084;
				short num2 = num;
				num = (short)2044558764;
				switch (num2 == num)
				{
				}
				num = (short)994967552;
				short num3 = num;
				num = (short)688259072;
				if (num != 0)
				{
				}
				num = (short)643301377;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyStrapping_A8370.Value = value;
			}
		}

		// Token: 0x17006607 RID: 26119
		// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x00BD91A8 File Offset: 0x00BD73A8
		// (set) Token: 0x0600CB2A RID: 52010 RVA: 0x00BD9260 File Offset: 0x00BD7460
		public string CnvPerSecureKeyStrapping_A8370_UIValue
		{
			get
			{
				short num = (short)1702873038;
				short num2 = num;
				num = (short)1398720462;
				switch (num2 == num)
				{
				}
				num = (short)159383552;
				short num3 = num;
				num = (short)1453457409;
				if (num != 0)
				{
				}
				num = (short)1124466688;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.UIValue;
			}
			set
			{
				short num = (short)1110189968;
				short num2 = num;
				num = (short)436479888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2133196800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660092417;
				if (num != 0)
				{
				}
				num = (short)1149173760;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyStrapping_A8370.UIValue = value;
			}
		}

		// Token: 0x17006608 RID: 26120
		// (get) Token: 0x0600CB2B RID: 52011 RVA: 0x00BD9314 File Offset: 0x00BD7514
		public global::AcpBusinessLayer.AcpListField CnvPerSecureKeyStrapping_A8370
		{
			get
			{
				short num = (short)1962302552;
				short num2 = num;
				num = (short)1446927448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1665204224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1281753089;
				if (num != 0)
				{
				}
				num = (short)1030684672;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370;
			}
		}

		// Token: 0x17006609 RID: 26121
		// (get) Token: 0x0600CB2C RID: 52012 RVA: 0x00BD93C4 File Offset: 0x00BD75C4
		// (set) Token: 0x0600CB2D RID: 52013 RVA: 0x00BD9478 File Offset: 0x00BD7678
		public bool CnvPerSecureKeyStrapping_A8370_Applicable
		{
			get
			{
				short num = (short)983213160;
				short num2 = num;
				num = (short)398304360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)899416064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968228864;
				if (num != 0)
				{
				}
				num = (short)1908998145;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.Applicable;
			}
			set
			{
				short num = (short)1691885958;
				short num2 = num;
				num = (short)1730617734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373686272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1820065793;
				if (num != 0)
				{
				}
				num = (short)2013462528;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyStrapping_A8370.Applicable = value;
			}
		}

		// Token: 0x1700660A RID: 26122
		// (get) Token: 0x0600CB2E RID: 52014 RVA: 0x00BD9530 File Offset: 0x00BD7730
		// (set) Token: 0x0600CB2F RID: 52015 RVA: 0x00BD95E4 File Offset: 0x00BD77E4
		public bool CnvPerSecureKeyStrapping_A8370_Valid
		{
			get
			{
				short num = (short)1487219963;
				short num2 = num;
				num = (short)267070715;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1398538240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1662517248;
				if (num != 0)
				{
				}
				num = (short)1346371585;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.Valid;
			}
			set
			{
				short num = (short)1444131306;
				short num2 = num;
				num = (short)428257770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1453129728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)8519680;
				if (num != 0)
				{
				}
				num = (short)946995201;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyStrapping_A8370.Valid = value;
			}
		}

		// Token: 0x1700660B RID: 26123
		// (get) Token: 0x0600CB30 RID: 52016 RVA: 0x00BD969C File Offset: 0x00BD789C
		// (set) Token: 0x0600CB31 RID: 52017 RVA: 0x00BD9750 File Offset: 0x00BD7950
		public bool CnvPerSecureKeyStrapping_A8370_Visible
		{
			get
			{
				short num = (short)2030276801;
				short num2 = num;
				num = (short)1464635585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1057488896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)957808641;
				if (num != 0)
				{
				}
				num = (short)763494400;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.Visible;
			}
			set
			{
				short num = (short)1116143308;
				short num2 = num;
				num = (short)415366860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)369819648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)273612801;
				if (num != 0)
				{
				}
				num = (short)748027904;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyStrapping_A8370.Visible = value;
			}
		}

		// Token: 0x1700660C RID: 26124
		// (get) Token: 0x0600CB32 RID: 52018 RVA: 0x00BD9808 File Offset: 0x00BD7A08
		// (set) Token: 0x0600CB33 RID: 52019 RVA: 0x00BD98BC File Offset: 0x00BD7ABC
		public bool CnvPerSecureKeyStrapping_A8370_Editable
		{
			get
			{
				short num = (short)1727324661;
				short num2 = num;
				num = (short)1637212661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)257163264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1183776769;
				if (num != 0)
				{
				}
				num = (short)118554624;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.Editable;
			}
			set
			{
				short num = (short)626389908;
				short num2 = num;
				num = (short)1406268308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291373056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717357057;
				if (num != 0)
				{
				}
				num = (short)982056960;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyStrapping_A8370.Editable = value;
			}
		}

		// Token: 0x1700660D RID: 26125
		// (get) Token: 0x0600CB34 RID: 52020 RVA: 0x00BD9974 File Offset: 0x00BD7B74
		internal string CnvPerSecureKeyStrapping_A8370_UILabel
		{
			get
			{
				short num = (short)1544245267;
				short num2 = num;
				num = (short)368267283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)670171136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2135752704;
				if (num != 0)
				{
				}
				num = (short)624230401;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.UIName;
			}
		}

		// Token: 0x1700660E RID: 26126
		// (get) Token: 0x0600CB35 RID: 52021 RVA: 0x00BD9A2C File Offset: 0x00BD7C2C
		// (set) Token: 0x0600CB36 RID: 52022 RVA: 0x00BD9AE4 File Offset: 0x00BD7CE4
		internal bool CnvPerSecureKeyStrapping_A8370_HiddenStatic
		{
			get
			{
				short num = (short)486579763;
				short num2 = num;
				num = (short)640720435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)863371264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1959985152;
				if (num != 0)
				{
				}
				num = (short)1636958209;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.HiddenStatic;
			}
			set
			{
				short num = (short)676440324;
				short num2 = num;
				num = (short)784967940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1331822592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141257728;
				if (num != 0)
				{
				}
				num = (short)973996033;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyStrapping_A8370.HiddenStatic = value;
			}
		}

		// Token: 0x1700660F RID: 26127
		// (get) Token: 0x0600CB37 RID: 52023 RVA: 0x00BD9B9C File Offset: 0x00BD7D9C
		// (set) Token: 0x0600CB38 RID: 52024 RVA: 0x00BD9C50 File Offset: 0x00BD7E50
		internal bool CnvPerSecureKeyStrapping_A8370_HiddenDynamic
		{
			get
			{
				short num = (short)371017212;
				short num2 = num;
				num = (short)229000700;
				switch (num2 == num)
				{
				default:
				{
					num = (short)390791168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)996802560;
				if (num != 0)
				{
				}
				num = (short)791871489;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370.HiddenDynamic;
			}
			set
			{
				short num = (short)808649143;
				short num2 = num;
				num = (short)365429175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438777344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1810169857;
				if (num != 0)
				{
				}
				num = (short)636878848;
				if (num != 0)
				{
				}
				this.cnvPerSecureKeyStrapping_A8370.HiddenDynamic = value;
			}
		}

		// Token: 0x17006610 RID: 26128
		// (get) Token: 0x0600CB39 RID: 52025 RVA: 0x00BD9D08 File Offset: 0x00BD7F08
		public bool CnvPerSecureKeyStrapping_A8370_HasDiffs
		{
			get
			{
				short num = (short)1467301737;
				short num2 = num;
				num = (short)130760553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1211957248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)695730177;
				if (num != 0)
				{
				}
				num = (short)839909376;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKeyStrapping_A8370._HasDiffs;
			}
		}

		// Token: 0x17006611 RID: 26129
		// (get) Token: 0x0600CB3A RID: 52026 RVA: 0x00BD9DBC File Offset: 0x00BD7FBC
		// (set) Token: 0x0600CB3B RID: 52027 RVA: 0x00BD9E74 File Offset: 0x00BD8074
		public int CnvPerSecureKMFProfileIndex_A8381Value
		{
			get
			{
				short num = (short)1754910954;
				short num2 = num;
				num = (short)1637208298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685913600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)199163905;
				if (num != 0)
				{
				}
				num = (short)2060189696;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.Value;
			}
			set
			{
				short num = (short)367655713;
				short num2 = num;
				num = (short)1044380449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)58064896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)972685313;
				if (num != 0)
				{
				}
				num = (short)1628176384;
				if (num != 0)
				{
				}
				this.cnvPerSecureKMFProfileIndex_A8381.Value = value;
			}
		}

		// Token: 0x17006612 RID: 26130
		// (get) Token: 0x0600CB3C RID: 52028 RVA: 0x00BD9F2C File Offset: 0x00BD812C
		// (set) Token: 0x0600CB3D RID: 52029 RVA: 0x00BD9FE0 File Offset: 0x00BD81E0
		public string CnvPerSecureKMFProfileIndex_A8381_UIValue
		{
			get
			{
				short num = (short)1555227986;
				short num2 = num;
				num = (short)1541530962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2110390272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1479933953;
				if (num != 0)
				{
				}
				num = (short)1340211200;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.UIValue;
			}
			set
			{
				short num = (short)89887564;
				short num2 = num;
				num = (short)896570188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2072576000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)698417153;
				if (num != 0)
				{
				}
				num = (short)1736966144;
				if (num != 0)
				{
				}
				this.cnvPerSecureKMFProfileIndex_A8381.UIValue = value;
			}
		}

		// Token: 0x17006613 RID: 26131
		// (get) Token: 0x0600CB3E RID: 52030 RVA: 0x00BDA098 File Offset: 0x00BD8298
		public global::AcpBusinessLayer.AcpRecRefField CnvPerSecureKMFProfileIndex_A8381
		{
			get
			{
				short num = (short)1449252054;
				short num2 = num;
				num = (short)1399510230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2097283072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1966800897;
				if (num != 0)
				{
				}
				num = (short)2018574336;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381;
			}
		}

		// Token: 0x17006614 RID: 26132
		// (get) Token: 0x0600CB3F RID: 52031 RVA: 0x00BDA148 File Offset: 0x00BD8348
		// (set) Token: 0x0600CB40 RID: 52032 RVA: 0x00BDA1FC File Offset: 0x00BD83FC
		public bool CnvPerSecureKMFProfileIndex_A8381_Applicable
		{
			get
			{
				short num = (short)75831899;
				short num2 = num;
				num = (short)1990924891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)516292608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)412024832;
				if (num != 0)
				{
				}
				num = (short)1559429121;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.Applicable;
			}
			set
			{
				short num = (short)1927307362;
				short num2 = num;
				num = (short)836722786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499974144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)805109760;
				if (num != 0)
				{
				}
				num = (short)1153040385;
				if (num != 0)
				{
				}
				this.cnvPerSecureKMFProfileIndex_A8381.Applicable = value;
			}
		}

		// Token: 0x17006615 RID: 26133
		// (get) Token: 0x0600CB41 RID: 52033 RVA: 0x00BDA2B4 File Offset: 0x00BD84B4
		// (set) Token: 0x0600CB42 RID: 52034 RVA: 0x00BDA368 File Offset: 0x00BD8568
		public bool CnvPerSecureKMFProfileIndex_A8381_Valid
		{
			get
			{
				short num = (short)470871286;
				short num2 = num;
				num = (short)1969810678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1814691840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438646273;
				if (num != 0)
				{
				}
				num = (short)1538981888;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.Valid;
			}
			set
			{
				short num = (short)1203723062;
				short num2 = num;
				num = (short)956717878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1069285376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1510211585;
				if (num != 0)
				{
				}
				num = (short)1241513984;
				if (num != 0)
				{
				}
				this.cnvPerSecureKMFProfileIndex_A8381.Valid = value;
			}
		}

		// Token: 0x17006616 RID: 26134
		// (get) Token: 0x0600CB43 RID: 52035 RVA: 0x00BDA41C File Offset: 0x00BD861C
		// (set) Token: 0x0600CB44 RID: 52036 RVA: 0x00BDA4D0 File Offset: 0x00BD86D0
		public bool CnvPerSecureKMFProfileIndex_A8381_Visible
		{
			get
			{
				short num = (short)1527513089;
				if (num != 0)
				{
				}
				num = (short)2005991424;
				short num2 = num;
				num = (short)997375808;
				short num3 = num;
				num = (short)2069151552;
				switch (num3 == num)
				{
				}
				num = (short)849805312;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.Visible;
			}
			set
			{
				short num = (short)572191206;
				short num2 = num;
				num = (short)917238246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1343815680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028404736;
				if (num != 0)
				{
				}
				num = (short)1620312065;
				if (num != 0)
				{
				}
				this.cnvPerSecureKMFProfileIndex_A8381.Visible = value;
			}
		}

		// Token: 0x17006617 RID: 26135
		// (get) Token: 0x0600CB45 RID: 52037 RVA: 0x00BDA588 File Offset: 0x00BD8788
		// (set) Token: 0x0600CB46 RID: 52038 RVA: 0x00BDA63C File Offset: 0x00BD883C
		public bool CnvPerSecureKMFProfileIndex_A8381_Editable
		{
			get
			{
				short num = (short)1849032705;
				if (num != 0)
				{
				}
				num = (short)404291584;
				short num2 = num;
				num = (short)1705934022;
				short num3 = num;
				num = (short)1217363142;
				switch (num3 == num)
				{
				}
				num = (short)484376576;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.Editable;
			}
			set
			{
				short num = (short)1882964778;
				short num2 = num;
				num = (short)807060266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527840768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1003356161;
				if (num != 0)
				{
				}
				num = (short)955514880;
				if (num != 0)
				{
				}
				this.cnvPerSecureKMFProfileIndex_A8381.Editable = value;
			}
		}

		// Token: 0x17006618 RID: 26136
		// (get) Token: 0x0600CB47 RID: 52039 RVA: 0x00BDA6F4 File Offset: 0x00BD88F4
		internal string CnvPerSecureKMFProfileIndex_A8381_UILabel
		{
			get
			{
				short num = (short)649794969;
				short num2 = num;
				num = (short)1248859545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1522860032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2116157441;
				if (num != 0)
				{
				}
				num = (short)1057488896;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.UIName;
			}
		}

		// Token: 0x17006619 RID: 26137
		// (get) Token: 0x0600CB48 RID: 52040 RVA: 0x00BDA7AC File Offset: 0x00BD89AC
		// (set) Token: 0x0600CB49 RID: 52041 RVA: 0x00BDA860 File Offset: 0x00BD8A60
		internal bool CnvPerSecureKMFProfileIndex_A8381_HiddenStatic
		{
			get
			{
				short num = (short)1468754114;
				short num2 = num;
				num = (short)444229826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1778122752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)813957121;
				if (num != 0)
				{
				}
				num = (short)746848256;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.HiddenStatic;
			}
			set
			{
				short num = (short)29513755;
				short num2 = num;
				num = (short)468473883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)680329216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1352269824;
				if (num != 0)
				{
				}
				num = (short)1970077697;
				if (num != 0)
				{
				}
				this.cnvPerSecureKMFProfileIndex_A8381.HiddenStatic = value;
			}
		}

		// Token: 0x1700661A RID: 26138
		// (get) Token: 0x0600CB4A RID: 52042 RVA: 0x00BDA914 File Offset: 0x00BD8B14
		// (set) Token: 0x0600CB4B RID: 52043 RVA: 0x00BDA9CC File Offset: 0x00BD8BCC
		internal bool CnvPerSecureKMFProfileIndex_A8381_HiddenDynamic
		{
			get
			{
				short num = (short)1623951652;
				short num2 = num;
				num = (short)1394379044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)374865920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1513488385;
				if (num != 0)
				{
				}
				num = (short)2132344832;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381.HiddenDynamic;
			}
			set
			{
				short num = (short)993457893;
				short num2 = num;
				num = (short)1128134373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1663959040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)851836928;
				if (num != 0)
				{
				}
				num = (short)331546625;
				if (num != 0)
				{
				}
				this.cnvPerSecureKMFProfileIndex_A8381.HiddenDynamic = value;
			}
		}

		// Token: 0x1700661B RID: 26139
		// (get) Token: 0x0600CB4C RID: 52044 RVA: 0x00BDAA80 File Offset: 0x00BD8C80
		public bool CnvPerSecureKMFProfileIndex_A8381_HasDiffs
		{
			get
			{
				short num = (short)463070619;
				short num2 = num;
				num = (short)1814291867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1226833920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)164102144;
				if (num != 0)
				{
				}
				num = (short)972488705;
				if (num != 0)
				{
				}
				return this.cnvPerSecureKMFProfileIndex_A8381._HasDiffs;
			}
		}

		// Token: 0x1700661C RID: 26140
		// (get) Token: 0x0600CB4D RID: 52045 RVA: 0x00BDAB34 File Offset: 0x00BD8D34
		// (set) Token: 0x0600CB4E RID: 52046 RVA: 0x00BDABE4 File Offset: 0x00BD8DE4
		public bool CnvPerSecureBroadbandASTROOTARValue
		{
			get
			{
				short num = (short)214022925;
				short num2 = num;
				num = (short)329956109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)16777216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)740622337;
				if (num != 0)
				{
				}
				num = (short)7864320;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.Value;
			}
			set
			{
				short num = (short)1069441775;
				short num2 = num;
				num = (short)1467900655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)527630336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)933101569;
				if (num != 0)
				{
				}
				num = (short)487129088;
				if (num != 0)
				{
				}
				this.cnvPerSecureBroadbandASTROOTAR.Value = value;
			}
		}

		// Token: 0x1700661D RID: 26141
		// (get) Token: 0x0600CB4F RID: 52047 RVA: 0x00BDAC98 File Offset: 0x00BD8E98
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSecureBroadbandASTROOTAR
		{
			get
			{
				short num = (short)245816077;
				short num2 = num;
				num = (short)1623579405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1906180096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)278462465;
				if (num != 0)
				{
				}
				num = (short)1773469696;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR;
			}
		}

		// Token: 0x1700661E RID: 26142
		// (get) Token: 0x0600CB50 RID: 52048 RVA: 0x00BDAD48 File Offset: 0x00BD8F48
		// (set) Token: 0x0600CB51 RID: 52049 RVA: 0x00BDADFC File Offset: 0x00BD8FFC
		public bool CnvPerSecureBroadbandASTROOTAR_UIValue
		{
			get
			{
				short num = (short)119559414;
				short num2 = num;
				num = (short)1923437814;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1761869824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)852492289;
				if (num != 0)
				{
				}
				num = (short)298188800;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.Value;
			}
			set
			{
				short num = (short)477998345;
				short num2 = num;
				num = (short)1979231497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)757071872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)658178049;
				if (num != 0)
				{
				}
				num = (short)1237843968;
				if (num != 0)
				{
				}
				this.cnvPerSecureBroadbandASTROOTAR.Value = value;
			}
		}

		// Token: 0x1700661F RID: 26143
		// (get) Token: 0x0600CB52 RID: 52050 RVA: 0x00BDAEB0 File Offset: 0x00BD90B0
		// (set) Token: 0x0600CB53 RID: 52051 RVA: 0x00BDAF68 File Offset: 0x00BD9168
		public bool CnvPerSecureBroadbandASTROOTAR_Applicable
		{
			get
			{
				short num = (short)1393902937;
				short num2 = num;
				num = (short)792347993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)361365504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1117913088;
				if (num != 0)
				{
				}
				num = (short)748421121;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.Applicable;
			}
			set
			{
				short num = (short)1005257384;
				short num2 = num;
				num = (short)1249510056;
				switch (num2 == num)
				{
				default:
				{
					num = (short)541261824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1345454080;
				if (num != 0)
				{
				}
				num = (short)1910177793;
				if (num != 0)
				{
				}
				this.cnvPerSecureBroadbandASTROOTAR.Applicable = value;
			}
		}

		// Token: 0x17006620 RID: 26144
		// (get) Token: 0x0600CB54 RID: 52052 RVA: 0x00BDB020 File Offset: 0x00BD9220
		// (set) Token: 0x0600CB55 RID: 52053 RVA: 0x00BDB0D4 File Offset: 0x00BD92D4
		public bool CnvPerSecureBroadbandASTROOTAR_Valid
		{
			get
			{
				short num = (short)1779603154;
				short num2 = num;
				num = (short)1693685458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)395444224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1073938433;
				if (num != 0)
				{
				}
				num = (short)8519680;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.Valid;
			}
			set
			{
				short num = (short)1605054843;
				short num2 = num;
				num = (short)517747067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)528875520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263075329;
				if (num != 0)
				{
				}
				num = (short)1506803712;
				if (num != 0)
				{
				}
				this.cnvPerSecureBroadbandASTROOTAR.Valid = value;
			}
		}

		// Token: 0x17006621 RID: 26145
		// (get) Token: 0x0600CB56 RID: 52054 RVA: 0x00BDB188 File Offset: 0x00BD9388
		// (set) Token: 0x0600CB57 RID: 52055 RVA: 0x00BDB240 File Offset: 0x00BD9440
		public bool CnvPerSecureBroadbandASTROOTAR_Visible
		{
			get
			{
				short num = (short)821947010;
				short num2 = num;
				num = (short)706210434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1016201216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)997916673;
				if (num != 0)
				{
				}
				num = (short)2030043136;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.Visible;
			}
			set
			{
				short num = (short)1972555212;
				short num2 = num;
				num = (short)866700748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1215234048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239927297;
				if (num != 0)
				{
				}
				num = (short)1446313984;
				if (num != 0)
				{
				}
				this.cnvPerSecureBroadbandASTROOTAR.Visible = value;
			}
		}

		// Token: 0x17006622 RID: 26146
		// (get) Token: 0x0600CB58 RID: 52056 RVA: 0x00BDB2F4 File Offset: 0x00BD94F4
		// (set) Token: 0x0600CB59 RID: 52057 RVA: 0x00BDB3A8 File Offset: 0x00BD95A8
		public bool CnvPerSecureBroadbandASTROOTAR_Editable
		{
			get
			{
				short num = (short)293732353;
				if (num != 0)
				{
				}
				num = (short)398458880;
				short num2 = num;
				num = (short)393260055;
				short num3 = num;
				num = (short)1910615063;
				switch (num3 == num)
				{
				}
				num = (short)1444085760;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.Editable;
			}
			set
			{
				short num = (short)134226221;
				short num2 = num;
				num = (short)362029357;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1579548672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)454623233;
				if (num != 0)
				{
				}
				num = (short)1283850240;
				if (num != 0)
				{
				}
				this.cnvPerSecureBroadbandASTROOTAR.Editable = value;
			}
		}

		// Token: 0x17006623 RID: 26147
		// (get) Token: 0x0600CB5A RID: 52058 RVA: 0x00BDB45C File Offset: 0x00BD965C
		internal string CnvPerSecureBroadbandASTROOTAR_UILabel
		{
			get
			{
				short num = (short)1603873651;
				short num2 = num;
				num = (short)1962748787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1844445184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1992228864;
				if (num != 0)
				{
				}
				num = (short)661979137;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.UIName;
			}
		}

		// Token: 0x17006624 RID: 26148
		// (get) Token: 0x0600CB5B RID: 52059 RVA: 0x00BDB514 File Offset: 0x00BD9714
		// (set) Token: 0x0600CB5C RID: 52060 RVA: 0x00BDB5C8 File Offset: 0x00BD97C8
		internal bool CnvPerSecureBroadbandASTROOTAR_HiddenStatic
		{
			get
			{
				short num = (short)649134061;
				short num2 = num;
				num = (short)981467117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1098121216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)700317697;
				if (num != 0)
				{
				}
				num = (short)1031602176;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.HiddenStatic;
			}
			set
			{
				short num = (short)874433044;
				short num2 = num;
				num = (short)1975634452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)23592960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526057472;
				if (num != 0)
				{
				}
				num = (short)1272774657;
				if (num != 0)
				{
				}
				this.cnvPerSecureBroadbandASTROOTAR.HiddenStatic = value;
			}
		}

		// Token: 0x17006625 RID: 26149
		// (get) Token: 0x0600CB5D RID: 52061 RVA: 0x00BDB680 File Offset: 0x00BD9880
		// (set) Token: 0x0600CB5E RID: 52062 RVA: 0x00BDB734 File Offset: 0x00BD9934
		internal bool CnvPerSecureBroadbandASTROOTAR_HiddenDynamic
		{
			get
			{
				short num = (short)622887812;
				short num2 = num;
				num = (short)1417708420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770048000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435959297;
				if (num != 0)
				{
				}
				num = (short)1310392320;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR.HiddenDynamic;
			}
			set
			{
				short num = (short)69521632;
				short num2 = num;
				num = (short)634376416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1780809728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2006384641;
				if (num != 0)
				{
				}
				num = (short)1291190272;
				if (num != 0)
				{
				}
				this.cnvPerSecureBroadbandASTROOTAR.HiddenDynamic = value;
			}
		}

		// Token: 0x17006626 RID: 26150
		// (get) Token: 0x0600CB5F RID: 52063 RVA: 0x00BDB7E8 File Offset: 0x00BD99E8
		public bool CnvPerSecureBroadbandASTROOTAR_HasDiffs
		{
			get
			{
				short num = (short)1974397536;
				short num2 = num;
				num = (short)608168544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1054277632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)957218817;
				if (num != 0)
				{
				}
				num = (short)363659264;
				if (num != 0)
				{
				}
				return this.cnvPerSecureBroadbandASTROOTAR._HasDiffs;
			}
		}

		// Token: 0x17006627 RID: 26151
		// (get) Token: 0x0600CB60 RID: 52064 RVA: 0x00BDB89C File Offset: 0x00BD9A9C
		// (set) Token: 0x0600CB61 RID: 52065 RVA: 0x00BDB950 File Offset: 0x00BD9B50
		public bool CnvPerSecureOTARTx_A8675Value
		{
			get
			{
				short num = (short)1446900472;
				short num2 = num;
				num = (short)1906897656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)274857984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1832189953;
				if (num != 0)
				{
				}
				num = (short)1502347264;
				if (num != 0)
				{
				}
				return this.cnvPerSecureOTARTx_A8675.Value;
			}
			set
			{
				short num = (short)1796214068;
				short num2 = num;
				num = (short)1114770740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640614400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)279904257;
				if (num != 0)
				{
				}
				num = (short)1283063808;
				if (num != 0)
				{
				}
				this.cnvPerSecureOTARTx_A8675.Value = value;
			}
		}

		// Token: 0x17006628 RID: 26152
		// (get) Token: 0x0600CB62 RID: 52066 RVA: 0x00BDBA08 File Offset: 0x00BD9C08
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSecureOTARTx_A8675
		{
			get
			{
				short num = (short)226950134;
				short num2 = num;
				num = (short)434502646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)356581376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1437466625;
				if (num != 0)
				{
				}
				num = (short)2105802752;
				if (num != 0)
				{
				}
				return this.cnvPerSecureOTARTx_A8675;
			}
		}

		// Token: 0x17006629 RID: 26153
		// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x00BDBABC File Offset: 0x00BD9CBC
		// (set) Token: 0x0600CB64 RID: 52068 RVA: 0x00BDBB70 File Offset: 0x00BD9D70
		public bool CnvPerSecureOTARTx_A8675_UIValue
		{
			get
			{
				short num = (short)877901681;
				short num2 = num;
				num = (short)97433457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)339542016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)554762241;
				if (num != 0)
				{
				}
				num = (short)1000865792;
				if (num != 0)
				{
				}
				return this.cnvPerSecureOTARTx_A8675.Value;
			}
			set
			{
				short num = (short)1657864193;
				if (num != 0)
				{
				}
				num = (short)965658192;
				short num2 = num;
				num = (short)77055568;
				switch (num2 == num)
				{
				}
				num = (short)1311375360;
				if (num != 0)
				{
				}
				num = (short)1856765952;
				short num3 = num;
				this.cnvPerSecureOTARTx_A8675.Value = value;
			}
		}

		// Token: 0x1700662A RID: 26154
		// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x00BDBC24 File Offset: 0x00BD9E24
		// (set) Token: 0x0600CB66 RID: 52070 RVA: 0x00BDBCD8 File Offset: 0x00BD9ED8
		public bool CnvPerSecureOTARTx_A8675_Applicable
		{
			get
			{
				short num = (short)1007775162;
				short num2 = num;
				num = (short)659582394;
				switch (num2 == num)
				{
				}
				num = (short)1278869504;
				if (num != 0)
				{
				}
				num = (short)35848193;
				if (num != 0)
				{
				}
				num = (short)259457024;
				short num3 = num;
				return this.cnvPerSecureOTARTx_A8675.Applicable;
			}
			set
			{
				short num = (short)560332801;
				if (num != 0)
				{
				}
				num = (short)577093635;
				short num2 = num;
				num = (short)1886896131;
				switch (num2 == num)
				{
				}
				num = (short)94044160;
				if (num != 0)
				{
				}
				num = (short)175439872;
				short num3 = num;
				this.cnvPerSecureOTARTx_A8675.Applicable = value;
			}
		}

		// Token: 0x1700662B RID: 26155
		// (get) Token: 0x0600CB67 RID: 52071 RVA: 0x00BDBD8C File Offset: 0x00BD9F8C
		// (set) Token: 0x0600CB68 RID: 52072 RVA: 0x00BDBE44 File Offset: 0x00BDA044
		public bool CnvPerSecureOTARTx_A8675_Valid
		{
			get
			{
				short num = (short)1310921722;
				short num2 = num;
				num = (short)310907898;
				switch (num2 == num)
				{
				}
				num = (short)1360527361;
				if (num != 0)
				{
				}
				num = (short)1495138304;
				if (num != 0)
				{
				}
				num = (short)246874112;
				short num3 = num;
				return this.cnvPerSecureOTARTx_A8675.Valid;
			}
			set
			{
				short num = (short)307772322;
				short num2 = num;
				num = (short)423377826;
				switch (num2 == num)
				{
				}
				num = (short)1098711041;
				if (num != 0)
				{
				}
				num = (short)1406402560;
				if (num != 0)
				{
				}
				num = (short)1002831872;
				short num3 = num;
				this.cnvPerSecureOTARTx_A8675.Valid = value;
			}
		}

		// Token: 0x1700662C RID: 26156
		// (get) Token: 0x0600CB69 RID: 52073 RVA: 0x00BDBEF8 File Offset: 0x00BDA0F8
		// (set) Token: 0x0600CB6A RID: 52074 RVA: 0x00BDBFAC File Offset: 0x00BDA1AC
		public bool CnvPerSecureOTARTx_A8675_Visible
		{
			get
			{
				short num = (short)233032796;
				short num2 = num;
				num = (short)370068572;
				switch (num2 == num)
				{
				}
				num = (short)811991040;
				if (num != 0)
				{
				}
				num = (short)2108162049;
				if (num != 0)
				{
				}
				num = (short)312999936;
				short num3 = num;
				return this.cnvPerSecureOTARTx_A8675.Visible;
			}
			set
			{
				short num = (short)542048257;
				if (num != 0)
				{
				}
				num = (short)565545681;
				short num2 = num;
				num = (short)1923779281;
				switch (num2 == num)
				{
				}
				num = (short)1404305408;
				if (num != 0)
				{
				}
				num = (short)2073165824;
				short num3 = num;
				this.cnvPerSecureOTARTx_A8675.Visible = value;
			}
		}

		// Token: 0x1700662D RID: 26157
		// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x00BDC064 File Offset: 0x00BDA264
		// (set) Token: 0x0600CB6C RID: 52076 RVA: 0x00BDC11C File Offset: 0x00BDA31C
		public bool CnvPerSecureOTARTx_A8675_Editable
		{
			get
			{
				short num = (short)891486209;
				if (num != 0)
				{
				}
				num = (short)443545592;
				short num2 = num;
				num = (short)953808888;
				switch (num2 == num)
				{
				}
				num = (short)894566400;
				if (num != 0)
				{
				}
				num = (short)1791033344;
				short num3 = num;
				return this.cnvPerSecureOTARTx_A8675.Editable;
			}
			set
			{
				short num = (short)485823759;
				short num2 = num;
				num = (short)499979535;
				switch (num2 == num)
				{
				}
				num = (short)1481113601;
				if (num != 0)
				{
				}
				num = (short)1827209216;
				if (num != 0)
				{
				}
				num = (short)117506048;
				short num3 = num;
				this.cnvPerSecureOTARTx_A8675.Editable = value;
			}
		}

		// Token: 0x1700662E RID: 26158
		// (get) Token: 0x0600CB6D RID: 52077 RVA: 0x00BDC1D0 File Offset: 0x00BDA3D0
		internal string CnvPerSecureOTARTx_A8675_UILabel
		{
			get
			{
				short num = (short)30670849;
				if (num != 0)
				{
				}
				num = (short)1713287710;
				short num2 = num;
				num = (short)466924062;
				switch (num2 == num)
				{
				}
				num = (short)1389887488;
				if (num != 0)
				{
				}
				num = (short)1710948352;
				short num3 = num;
				return this.cnvPerSecureOTARTx_A8675.UIName;
			}
		}

		// Token: 0x1700662F RID: 26159
		// (get) Token: 0x0600CB6E RID: 52078 RVA: 0x00BDC284 File Offset: 0x00BDA484
		// (set) Token: 0x0600CB6F RID: 52079 RVA: 0x00BDC338 File Offset: 0x00BDA538
		internal bool CnvPerSecureOTARTx_A8675_HiddenStatic
		{
			get
			{
				short num = (short)1452957792;
				short num2 = num;
				num = (short)1858297952;
				switch (num2 == num)
				{
				}
				num = (short)1584594945;
				if (num != 0)
				{
				}
				num = (short)553713664;
				if (num != 0)
				{
				}
				num = (short)441843712;
				short num3 = num;
				return this.cnvPerSecureOTARTx_A8675.HiddenStatic;
			}
			set
			{
				short num = (short)368592554;
				short num2 = num;
				num = (short)1710638762;
				switch (num2 == num)
				{
				}
				num = (short)1947664384;
				if (num != 0)
				{
				}
				num = (short)1759510529;
				if (num != 0)
				{
				}
				num = (short)569245696;
				short num3 = num;
				this.cnvPerSecureOTARTx_A8675.HiddenStatic = value;
			}
		}

		// Token: 0x17006630 RID: 26160
		// (get) Token: 0x0600CB70 RID: 52080 RVA: 0x00BDC3F0 File Offset: 0x00BDA5F0
		// (set) Token: 0x0600CB71 RID: 52081 RVA: 0x00BDC4A4 File Offset: 0x00BDA6A4
		internal bool CnvPerSecureOTARTx_A8675_HiddenDynamic
		{
			get
			{
				short num = (short)164945018;
				short num2 = num;
				num = (short)630185082;
				switch (num2 == num)
				{
				}
				num = (short)62783489;
				if (num != 0)
				{
				}
				num = (short)1961230336;
				if (num != 0)
				{
				}
				num = (short)194314240;
				short num3 = num;
				return this.cnvPerSecureOTARTx_A8675.HiddenDynamic;
			}
			set
			{
				short num = (short)1942615517;
				short num2 = num;
				num = (short)536278493;
				switch (num2 == num)
				{
				}
				num = (short)38141953;
				if (num != 0)
				{
				}
				num = (short)1658060800;
				if (num != 0)
				{
				}
				num = (short)1049165824;
				short num3 = num;
				this.cnvPerSecureOTARTx_A8675.HiddenDynamic = value;
			}
		}

		// Token: 0x17006631 RID: 26161
		// (get) Token: 0x0600CB72 RID: 52082 RVA: 0x00BDC554 File Offset: 0x00BDA754
		public bool CnvPerSecureOTARTx_A8675_HasDiffs
		{
			get
			{
				short num = (short)1820632619;
				short num2 = num;
				num = (short)241542699;
				switch (num2 == num)
				{
				}
				num = (short)1929314304;
				if (num != 0)
				{
				}
				num = (short)98041857;
				if (num != 0)
				{
				}
				num = (short)1773207552;
				short num3 = num;
				return this.cnvPerSecureOTARTx_A8675._HasDiffs;
			}
		}

		// Token: 0x17006632 RID: 26162
		// (get) Token: 0x0600CB73 RID: 52083 RVA: 0x00BDC608 File Offset: 0x00BDA808
		// (set) Token: 0x0600CB74 RID: 52084 RVA: 0x00BDC6BC File Offset: 0x00BDA8BC
		public bool CnvPerSecureProperCodeDetect_A8762Value
		{
			get
			{
				short num = (short)2136881225;
				short num2 = num;
				num = (short)851195977;
				switch (num2 == num)
				{
				}
				num = (short)851968000;
				if (num != 0)
				{
				}
				num = (short)1173028865;
				if (num != 0)
				{
				}
				num = (short)1793523712;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.Value;
			}
			set
			{
				short num = (short)503270898;
				short num2 = num;
				num = (short)94260722;
				switch (num2 == num)
				{
				}
				num = (short)1345257473;
				if (num != 0)
				{
				}
				num = (short)1419575296;
				if (num != 0)
				{
				}
				num = (short)468189184;
				short num3 = num;
				this.cnvPerSecureProperCodeDetect_A8762.Value = value;
			}
		}

		// Token: 0x17006633 RID: 26163
		// (get) Token: 0x0600CB75 RID: 52085 RVA: 0x00BDC770 File Offset: 0x00BDA970
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSecureProperCodeDetect_A8762
		{
			get
			{
				short num = (short)1915212333;
				short num2 = num;
				num = (short)1448661549;
				switch (num2 == num)
				{
				}
				num = (short)993394688;
				if (num != 0)
				{
				}
				num = (short)275054593;
				if (num != 0)
				{
				}
				num = (short)2096365568;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762;
			}
		}

		// Token: 0x17006634 RID: 26164
		// (get) Token: 0x0600CB76 RID: 52086 RVA: 0x00BDC81C File Offset: 0x00BDAA1C
		// (set) Token: 0x0600CB77 RID: 52087 RVA: 0x00BDC8D0 File Offset: 0x00BDAAD0
		public bool CnvPerSecureProperCodeDetect_A8762_UIValue
		{
			get
			{
				short num = (short)763397001;
				short num2 = num;
				num = (short)14713737;
				switch (num2 == num)
				{
				}
				num = (short)472907777;
				if (num != 0)
				{
				}
				num = (short)840761344;
				if (num != 0)
				{
				}
				num = (short)7536640;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.Value;
			}
			set
			{
				short num = (short)290860775;
				short num2 = num;
				num = (short)508309223;
				switch (num2 == num)
				{
				}
				num = (short)1868300289;
				if (num != 0)
				{
				}
				num = (short)1631518720;
				if (num != 0)
				{
				}
				num = (short)1807876096;
				short num3 = num;
				this.cnvPerSecureProperCodeDetect_A8762.Value = value;
			}
		}

		// Token: 0x17006635 RID: 26165
		// (get) Token: 0x0600CB78 RID: 52088 RVA: 0x00BDC984 File Offset: 0x00BDAB84
		// (set) Token: 0x0600CB79 RID: 52089 RVA: 0x00BDCA38 File Offset: 0x00BDAC38
		public bool CnvPerSecureProperCodeDetect_A8762_Applicable
		{
			get
			{
				short num = (short)1895826036;
				short num2 = num;
				num = (short)262537844;
				switch (num2 == num)
				{
				}
				num = (short)804651009;
				if (num != 0)
				{
				}
				num = (short)1825046528;
				if (num != 0)
				{
				}
				num = (short)1785069568;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.Applicable;
			}
			set
			{
				short num = (short)1587711337;
				short num2 = num;
				num = (short)1647676777;
				switch (num2 == num)
				{
				}
				num = (short)478216192;
				if (num != 0)
				{
				}
				num = (short)503119873;
				if (num != 0)
				{
				}
				num = (short)980877312;
				short num3 = num;
				this.cnvPerSecureProperCodeDetect_A8762.Applicable = value;
			}
		}

		// Token: 0x17006636 RID: 26166
		// (get) Token: 0x0600CB7A RID: 52090 RVA: 0x00BDCAEC File Offset: 0x00BDACEC
		// (set) Token: 0x0600CB7B RID: 52091 RVA: 0x00BDCBA0 File Offset: 0x00BDADA0
		public bool CnvPerSecureProperCodeDetect_A8762_Valid
		{
			get
			{
				short num = (short)1685782529;
				if (num != 0)
				{
				}
				num = (short)2035421993;
				short num2 = num;
				num = (short)1039799081;
				switch (num2 == num)
				{
				}
				num = (short)1938882560;
				if (num != 0)
				{
				}
				num = (short)465436672;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.Valid;
			}
			set
			{
				short num = (short)2032390329;
				short num2 = num;
				num = (short)540987577;
				switch (num2 == num)
				{
				}
				num = (short)56819713;
				if (num != 0)
				{
				}
				num = (short)2063663104;
				if (num != 0)
				{
				}
				num = (short)815923200;
				short num3 = num;
				this.cnvPerSecureProperCodeDetect_A8762.Valid = value;
			}
		}

		// Token: 0x17006637 RID: 26167
		// (get) Token: 0x0600CB7C RID: 52092 RVA: 0x00BDCC54 File Offset: 0x00BDAE54
		// (set) Token: 0x0600CB7D RID: 52093 RVA: 0x00BDCD0C File Offset: 0x00BDAF0C
		public bool CnvPerSecureProperCodeDetect_A8762_Visible
		{
			get
			{
				short num = (short)1922453843;
				short num2 = num;
				num = (short)680350035;
				switch (num2 == num)
				{
				}
				num = (short)791150593;
				if (num != 0)
				{
				}
				num = (short)1552941056;
				if (num != 0)
				{
				}
				num = (short)745603072;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.Visible;
			}
			set
			{
				short num = (short)873332737;
				if (num != 0)
				{
				}
				num = (short)667861820;
				short num2 = num;
				num = (short)53461820;
				switch (num2 == num)
				{
				}
				num = (short)1498480640;
				if (num != 0)
				{
				}
				num = (short)711458816;
				short num3 = num;
				this.cnvPerSecureProperCodeDetect_A8762.Visible = value;
			}
		}

		// Token: 0x17006638 RID: 26168
		// (get) Token: 0x0600CB7E RID: 52094 RVA: 0x00BDCDC0 File Offset: 0x00BDAFC0
		// (set) Token: 0x0600CB7F RID: 52095 RVA: 0x00BDCE74 File Offset: 0x00BDB074
		public bool CnvPerSecureProperCodeDetect_A8762_Editable
		{
			get
			{
				short num = (short)1648839557;
				short num2 = num;
				num = (short)575425413;
				switch (num2 == num)
				{
				}
				num = (short)1452933120;
				if (num != 0)
				{
				}
				num = (short)613482497;
				if (num != 0)
				{
				}
				num = (short)21168128;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.Editable;
			}
			set
			{
				short num = (short)1944642878;
				short num2 = num;
				num = (short)1934353726;
				switch (num2 == num)
				{
				}
				num = (short)1370947585;
				if (num != 0)
				{
				}
				num = (short)1809383424;
				if (num != 0)
				{
				}
				num = (short)1852112896;
				short num3 = num;
				this.cnvPerSecureProperCodeDetect_A8762.Editable = value;
			}
		}

		// Token: 0x17006639 RID: 26169
		// (get) Token: 0x0600CB80 RID: 52096 RVA: 0x00BDCF2C File Offset: 0x00BDB12C
		internal string CnvPerSecureProperCodeDetect_A8762_UILabel
		{
			get
			{
				short num = (short)2138374145;
				if (num != 0)
				{
				}
				num = (short)1998423866;
				short num2 = num;
				num = (short)836339514;
				switch (num2 == num)
				{
				}
				num = (short)6815744;
				if (num != 0)
				{
				}
				num = (short)648544256;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.UIName;
			}
		}

		// Token: 0x1700663A RID: 26170
		// (get) Token: 0x0600CB81 RID: 52097 RVA: 0x00BDCFE4 File Offset: 0x00BDB1E4
		// (set) Token: 0x0600CB82 RID: 52098 RVA: 0x00BDD09C File Offset: 0x00BDB29C
		internal bool CnvPerSecureProperCodeDetect_A8762_HiddenStatic
		{
			get
			{
				short num = (short)2103050241;
				if (num != 0)
				{
				}
				num = (short)2061475523;
				short num2 = num;
				num = (short)1065459395;
				switch (num2 == num)
				{
				}
				num = (short)1327759360;
				if (num != 0)
				{
				}
				num = (short)521666560;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.HiddenStatic;
			}
			set
			{
				short num = (short)1206911981;
				short num2 = num;
				num = (short)1068696557;
				switch (num2 == num)
				{
				}
				num = (short)1437597697;
				if (num != 0)
				{
				}
				num = (short)7798784;
				if (num != 0)
				{
				}
				num = (short)1282801664;
				short num3 = num;
				this.cnvPerSecureProperCodeDetect_A8762.HiddenStatic = value;
			}
		}

		// Token: 0x1700663B RID: 26171
		// (get) Token: 0x0600CB83 RID: 52099 RVA: 0x00BDD150 File Offset: 0x00BDB350
		// (set) Token: 0x0600CB84 RID: 52100 RVA: 0x00BDD208 File Offset: 0x00BDB408
		internal bool CnvPerSecureProperCodeDetect_A8762_HiddenDynamic
		{
			get
			{
				short num = (short)281073766;
				short num2 = num;
				num = (short)877779046;
				switch (num2 == num)
				{
				}
				num = (short)269680641;
				if (num != 0)
				{
				}
				num = (short)586022912;
				if (num != 0)
				{
				}
				num = (short)1703215104;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762.HiddenDynamic;
			}
			set
			{
				short num = (short)1069481985;
				if (num != 0)
				{
				}
				num = (short)330874646;
				short num2 = num;
				num = (short)1989852950;
				switch (num2 == num)
				{
				}
				num = (short)1315700736;
				if (num != 0)
				{
				}
				num = (short)1387003904;
				short num3 = num;
				this.cnvPerSecureProperCodeDetect_A8762.HiddenDynamic = value;
			}
		}

		// Token: 0x1700663C RID: 26172
		// (get) Token: 0x0600CB85 RID: 52101 RVA: 0x00BDD2C0 File Offset: 0x00BDB4C0
		public bool CnvPerSecureProperCodeDetect_A8762_HasDiffs
		{
			get
			{
				short num = (short)315730813;
				short num2 = num;
				num = (short)99396477;
				switch (num2 == num)
				{
				}
				num = (short)2097217537;
				if (num != 0)
				{
				}
				num = (short)102301696;
				if (num != 0)
				{
				}
				num = (short)1433862144;
				short num3 = num;
				return this.cnvPerSecureProperCodeDetect_A8762._HasDiffs;
			}
		}

		// Token: 0x1700663D RID: 26173
		// (get) Token: 0x0600CB86 RID: 52102 RVA: 0x00BDD378 File Offset: 0x00BDB578
		// (set) Token: 0x0600CB87 RID: 52103 RVA: 0x00BDD42C File Offset: 0x00BDB62C
		public int CnvPerSecureScanHoldoffStrapping_A9050Value
		{
			get
			{
				short num = (short)1593054396;
				short num2 = num;
				num = (short)674567356;
				switch (num2 == num)
				{
				}
				num = (short)989528065;
				if (num != 0)
				{
				}
				num = (short)1949696000;
				if (num != 0)
				{
				}
				num = (short)6029312;
				short num3 = num;
				return this.cnvPerSecureScanHoldoffStrapping_A9050.Value;
			}
			set
			{
				short num = (short)1317267260;
				short num2 = num;
				num = (short)1306322748;
				switch (num2 == num)
				{
				}
				num = (short)1169293313;
				if (num != 0)
				{
				}
				num = (short)579796992;
				if (num != 0)
				{
				}
				num = (short)1297940480;
				short num3 = num;
				this.cnvPerSecureScanHoldoffStrapping_A9050.Value = value;
			}
		}

		// Token: 0x1700663E RID: 26174
		// (get) Token: 0x0600CB88 RID: 52104 RVA: 0x00BDD4E4 File Offset: 0x00BDB6E4
		// (set) Token: 0x0600CB89 RID: 52105 RVA: 0x00BDD598 File Offset: 0x00BDB798
		public string CnvPerSecureScanHoldoffStrapping_A9050_UIValue
		{
			get
			{
				short num = (short)753134853;
				short num2 = num;
				num = (short)1004137733;
				switch (num2 == num)
				{
				}
				num = (short)1157562369;
				if (num != 0)
				{
				}
				num = (short)1225261056;
				if (num != 0)
				{
				}
				num = (short)1150353408;
				short num3 = num;
				return this.cnvPerSecureScanHoldoffStrapping_A9050.UIValue;
			}
			set
			{
				short num = (short)381759839;
				short num2 = num;
				num = (short)565915999;
				switch (num2 == num)
				{
				}
				num = (short)1232142337;
				if (num != 0)
				{
				}
				num = (short)1675689984;
				if (num != 0)
				{
				}
				num = (short)1007091712;
				short num3 = num;
				this.cnvPerSecureScanHoldoffStrapping_A9050.UIValue = value;
			}
		}

		// Token: 0x1700663F RID: 26175
		// (get) Token: 0x0600CB8A RID: 52106 RVA: 0x00BDD64C File Offset: 0x00BDB84C
		public global::AcpBusinessLayer.AcpListField CnvPerSecureScanHoldoffStrapping_A9050
		{
			get
			{
				short num = (short)1314062337;
				if (num != 0)
				{
				}
				num = (short)343131910;
				short num2 = num;
				num = (short)520275718;
				switch (num2 == num)
				{
				}
				num = (short)1538392064;
				if (num != 0)
				{
				}
				num = (short)2029518848;
				short num3 = num;
				return this.cnvPerSecureScanHoldoffStrapping_A9050;
			}
		}

		// Token: 0x17006640 RID: 26176
		// (get) Token: 0x0600CB8B RID: 52107 RVA: 0x00BDD6FC File Offset: 0x00BDB8FC
		// (set) Token: 0x0600CB8C RID: 52108 RVA: 0x00BDD7B4 File Offset: 0x00BDB9B4
		public bool CnvPerSecureScanHoldoffStrapping_A9050_Applicable
		{
			get
			{
				short num = (short)1664666230;
				short num2 = num;
				num = (short)717539958;
				switch (num2 == num)
				{
				}
				num = (short)907280385;
				if (num != 0)
				{
				}
				num = (short)1029963776;
				if (num != 0)
				{
				}
				num = (short)2017656832;
				short num3 = num;
				return this.cnvPerSecureScanHoldoffStrapping_A9050.Applicable;
			}
			set
			{
				short num = (short)873899689;
				short num2 = num;
				num = (short)933537449;
				switch (num2 == num)
				{
				}
				num = (short)396361729;
				if (num != 0)
				{
				}
				num = (short)983695360;
				if (num != 0)
				{
				}
				num = (short)582418432;
				short num3 = num;
				this.cnvPerSecureScanHoldoffStrapping_A9050.Applicable = value;
			}
		}

		// Token: 0x17006641 RID: 26177
		// (get) Token: 0x0600CB8D RID: 52109 RVA: 0x00BDD86C File Offset: 0x00BDBA6C
		// (set) Token: 0x0600CB8E RID: 52110 RVA: 0x00BDD920 File Offset: 0x00BDBB20
		public bool CnvPerSecureScanHoldoffStrapping_A9050_Valid
		{
			get
			{
				short num = (short)67891850;
				short num2 = num;
				num = (short)381809290;
				switch (num2 == num)
				{
				}
				num = (short)1013645313;
				if (num != 0)
				{
				}
				num = (short)981991424;
				if (num != 0)
				{
				}
				num = (short)1150812160;
				short num3 = num;
				return this.cnvPerSecureScanHoldoffStrapping_A9050.Valid;
			}
			set
			{
				short num = (short)1066973373;
				short num2 = num;
				num = (short)2136520893;
				switch (num2 == num)
				{
				}
				num = (short)70975489;
				if (num != 0)
				{
				}
				num = (short)1529085952;
				if (num != 0)
				{
				}
				num = (short)1570308096;
				short num3 = num;
				this.cnvPerSecureScanHoldoffStrapping_A9050.Valid = value;
			}
		}

		// Token: 0x17006642 RID: 26178
		// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x00BDD9D8 File Offset: 0x00BDBBD8
		// (set) Token: 0x0600CB90 RID: 52112 RVA: 0x00BDDA8C File Offset: 0x00BDBC8C
		public bool CnvPerSecureScanHoldoffStrapping_A9050_Visible
		{
			get
			{
				short num = (short)528480761;
				short num2 = num;
				num = (short)1491859961;
				switch (num2 == num)
				{
				}
				num = (short)1086193664;
				if (num != 0)
				{
				}
				num = (short)1950416897;
				if (num != 0)
				{
				}
				num = (short)670433280;
				short num3 = num;
				return this.cnvPerSecureScanHoldoffStrapping_A9050.Visible;
			}
			set
			{
				short num = (short)2053767169;
				if (num != 0)
				{
				}
				num = (short)1506525388;
				short num2 = num;
				num = (short)1645920460;
				switch (num2 == num)
				{
				}
				num = (short)1828978688;
				if (num != 0)
				{
				}
				num = (short)1460207616;
				short num3 = num;
				this.cnvPerSecureScanHoldoffStrapping_A9050.Visible = value;
			}
		}

		// Token: 0x17006643 RID: 26179
		// (get) Token: 0x0600CB91 RID: 52113 RVA: 0x00BDDB44 File Offset: 0x00BDBD44
		// (set) Token: 0x0600CB92 RID: 52114 RVA: 0x00BDDBF8 File Offset: 0x00BDBDF8
		public bool CnvPerSecureScanHoldoffStrapping_A9050_Editable
		{
			get
			{
				short num = (short)824508416;
				short num2 = num;
				num = (short)1175971016;
				short num3 = num;
				num = (short)417916104;
				switch (num3 == num)
				{
				}
				num = (short)241893376;
				if (num != 0)
				{
				}
				num = (short)1786183681;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanHoldoffStrapping_A9050.Editable;
			}
			set
			{
				short num = (short)1370750976;
				short num2 = num;
				num = (short)1215767410;
				short num3 = num;
				num = (short)1712792434;
				switch (num3 == num)
				{
				}
				num = (short)1792999425;
				if (num != 0)
				{
				}
				num = (short)113836032;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanHoldoffStrapping_A9050.Editable = value;
			}
		}

		// Token: 0x17006644 RID: 26180
		// (get) Token: 0x0600CB93 RID: 52115 RVA: 0x00BDDCB0 File Offset: 0x00BDBEB0
		internal string CnvPerSecureScanHoldoffStrapping_A9050_UILabel
		{
			get
			{
				short num = (short)1769144320;
				short num2 = num;
				num = (short)329438263;
				short num3 = num;
				num = (short)996463671;
				switch (num3 == num)
				{
				}
				num = (short)1724121089;
				if (num != 0)
				{
				}
				num = (short)1652686848;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanHoldoffStrapping_A9050.UIName;
			}
		}

		// Token: 0x17006645 RID: 26181
		// (get) Token: 0x0600CB94 RID: 52116 RVA: 0x00BDDD64 File Offset: 0x00BDBF64
		// (set) Token: 0x0600CB95 RID: 52117 RVA: 0x00BDDE1C File Offset: 0x00BDC01C
		internal bool CnvPerSecureScanHoldoffStrapping_A9050_HiddenStatic
		{
			get
			{
				short num = (short)1438646272;
				short num2 = num;
				num = (short)1895095640;
				short num3 = num;
				num = (short)778100056;
				switch (num3 == num)
				{
				}
				num = (short)569704448;
				if (num != 0)
				{
				}
				num = (short)1489829889;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanHoldoffStrapping_A9050.HiddenStatic;
			}
			set
			{
				short num = (short)401473536;
				short num2 = num;
				num = (short)1673500823;
				short num3 = num;
				num = (short)1353619607;
				switch (num3 == num)
				{
				}
				num = (short)1559691264;
				if (num != 0)
				{
				}
				num = (short)1278214145;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanHoldoffStrapping_A9050.HiddenStatic = value;
			}
		}

		// Token: 0x17006646 RID: 26182
		// (get) Token: 0x0600CB96 RID: 52118 RVA: 0x00BDDED4 File Offset: 0x00BDC0D4
		// (set) Token: 0x0600CB97 RID: 52119 RVA: 0x00BDDF88 File Offset: 0x00BDC188
		internal bool CnvPerSecureScanHoldoffStrapping_A9050_HiddenDynamic
		{
			get
			{
				short num = (short)597819392;
				short num2 = num;
				num = (short)1444191342;
				short num3 = num;
				num = (short)788175982;
				switch (num3 == num)
				{
				}
				num = (short)41418753;
				if (num != 0)
				{
				}
				num = (short)151257088;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanHoldoffStrapping_A9050.HiddenDynamic;
			}
			set
			{
				short num = (short)164364288;
				short num2 = num;
				num = (short)860954826;
				short num3 = num;
				num = (short)2086674634;
				switch (num3 == num)
				{
				}
				num = (short)711655425;
				if (num != 0)
				{
				}
				num = (short)478347264;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanHoldoffStrapping_A9050.HiddenDynamic = value;
			}
		}

		// Token: 0x17006647 RID: 26183
		// (get) Token: 0x0600CB98 RID: 52120 RVA: 0x00BDE03C File Offset: 0x00BDC23C
		public bool CnvPerSecureScanHoldoffStrapping_A9050_HasDiffs
		{
			get
			{
				short num = (short)1690566656;
				short num2 = num;
				num = (short)2038628353;
				if (num != 0)
				{
				}
				num = (short)99649962;
				short num3 = num;
				num = (short)917211562;
				switch (num3 == num)
				{
				}
				num = (short)1441267712;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanHoldoffStrapping_A9050._HasDiffs;
			}
		}

		// Token: 0x17006648 RID: 26184
		// (get) Token: 0x0600CB99 RID: 52121 RVA: 0x00BDE0F4 File Offset: 0x00BDC2F4
		// (set) Token: 0x0600CB9A RID: 52122 RVA: 0x00BDE1A8 File Offset: 0x00BDC3A8
		public int CnvPerSecureScanSelect_A9056Value
		{
			get
			{
				short num = (short)1894776832;
				short num2 = num;
				num = (short)546635777;
				if (num != 0)
				{
				}
				num = (short)939642126;
				short num3 = num;
				num = (short)1724435726;
				switch (num3 == num)
				{
				}
				num = (short)526974976;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.Value;
			}
			set
			{
				short num = (short)991952896;
				short num2 = num;
				num = (short)745996289;
				if (num != 0)
				{
				}
				num = (short)350401789;
				short num3 = num;
				num = (short)2135995645;
				switch (num3 == num)
				{
				}
				num = (short)1871118336;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanSelect_A9056.Value = value;
			}
		}

		// Token: 0x17006649 RID: 26185
		// (get) Token: 0x0600CB9B RID: 52123 RVA: 0x00BDE25C File Offset: 0x00BDC45C
		// (set) Token: 0x0600CB9C RID: 52124 RVA: 0x00BDE314 File Offset: 0x00BDC514
		public string CnvPerSecureScanSelect_A9056_UIValue
		{
			get
			{
				short num = (short)41222144;
				short num2 = num;
				num = (short)942997505;
				if (num != 0)
				{
				}
				num = (short)257636582;
				short num3 = num;
				num = (short)1361328358;
				switch (num3 == num)
				{
				}
				num = (short)1910833152;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.UIValue;
			}
			set
			{
				short num = (short)1840316416;
				short num2 = num;
				num = (short)481974928;
				short num3 = num;
				num = (short)1287215760;
				switch (num3 == num)
				{
				}
				num = (short)515964928;
				if (num != 0)
				{
				}
				num = (short)251789313;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanSelect_A9056.UIValue = value;
			}
		}

		// Token: 0x1700664A RID: 26186
		// (get) Token: 0x0600CB9D RID: 52125 RVA: 0x00BDE3CC File Offset: 0x00BDC5CC
		public global::AcpBusinessLayer.AcpListField CnvPerSecureScanSelect_A9056
		{
			get
			{
				short num = (short)1853816832;
				short num2 = num;
				num = (short)1537142602;
				short num3 = num;
				num = (short)574549834;
				switch (num3 == num)
				{
				}
				num = (short)683999233;
				if (num != 0)
				{
				}
				num = (short)1849229312;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056;
			}
		}

		// Token: 0x1700664B RID: 26187
		// (get) Token: 0x0600CB9E RID: 52126 RVA: 0x00BDE47C File Offset: 0x00BDC67C
		// (set) Token: 0x0600CB9F RID: 52127 RVA: 0x00BDE534 File Offset: 0x00BDC734
		public bool CnvPerSecureScanSelect_A9056_Applicable
		{
			get
			{
				short num = (short)324337664;
				short num2 = num;
				num = (short)953286657;
				if (num != 0)
				{
				}
				num = (short)2029830822;
				short num3 = num;
				num = (short)1167966886;
				switch (num3 == num)
				{
				}
				num = (short)1269039104;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.Applicable;
			}
			set
			{
				short num = (short)1647312896;
				short num2 = num;
				num = (short)1660581989;
				short num3 = num;
				num = (short)1434351717;
				switch (num3 == num)
				{
				}
				num = (short)1878261761;
				if (num != 0)
				{
				}
				num = (short)1544355840;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanSelect_A9056.Applicable = value;
			}
		}

		// Token: 0x1700664C RID: 26188
		// (get) Token: 0x0600CBA0 RID: 52128 RVA: 0x00BDE5EC File Offset: 0x00BDC7EC
		// (set) Token: 0x0600CBA1 RID: 52129 RVA: 0x00BDE6A0 File Offset: 0x00BDC8A0
		public bool CnvPerSecureScanSelect_A9056_Valid
		{
			get
			{
				short num = (short)348913664;
				short num2 = num;
				num = (short)2043019265;
				if (num != 0)
				{
				}
				num = (short)472875222;
				short num3 = num;
				num = (short)1238466774;
				switch (num3 == num)
				{
				}
				num = (short)1505361920;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.Valid;
			}
			set
			{
				short num = (short)554106880;
				short num2 = num;
				num = (short)1745790354;
				short num3 = num;
				num = (short)151692690;
				switch (num3 == num)
				{
				}
				num = (short)1924792321;
				if (num != 0)
				{
				}
				num = (short)89653248;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanSelect_A9056.Valid = value;
			}
		}

		// Token: 0x1700664D RID: 26189
		// (get) Token: 0x0600CBA2 RID: 52130 RVA: 0x00BDE758 File Offset: 0x00BDC958
		// (set) Token: 0x0600CBA3 RID: 52131 RVA: 0x00BDE80C File Offset: 0x00BDCA0C
		public bool CnvPerSecureScanSelect_A9056_Visible
		{
			get
			{
				short num = (short)1131151360;
				short num2 = num;
				num = (short)2098688189;
				short num3 = num;
				num = (short)1170960573;
				switch (num3 == num)
				{
				}
				num = (short)1058340864;
				if (num != 0)
				{
				}
				num = (short)575275009;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.Visible;
			}
			set
			{
				short num = (short)681115648;
				short num2 = num;
				num = (short)977565259;
				short num3 = num;
				num = (short)637040203;
				switch (num3 == num)
				{
				}
				num = (short)1469186049;
				if (num != 0)
				{
				}
				num = (short)310181888;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanSelect_A9056.Visible = value;
			}
		}

		// Token: 0x1700664E RID: 26190
		// (get) Token: 0x0600CBA4 RID: 52132 RVA: 0x00BDE8C0 File Offset: 0x00BDCAC0
		// (set) Token: 0x0600CBA5 RID: 52133 RVA: 0x00BDE974 File Offset: 0x00BDCB74
		public bool CnvPerSecureScanSelect_A9056_Editable
		{
			get
			{
				short num = (short)503709696;
				short num2 = num;
				num = (short)541634096;
				short num3 = num;
				num = (short)112045616;
				switch (num3 == num)
				{
				}
				num = (short)186646528;
				if (num != 0)
				{
				}
				num = (short)1936326657;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.Editable;
			}
			set
			{
				short num = (short)2025127936;
				short num2 = num;
				num = (short)718340097;
				if (num != 0)
				{
				}
				num = (short)1081968634;
				short num3 = num;
				num = (short)389580794;
				switch (num3 == num)
				{
				}
				num = (short)243990528;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanSelect_A9056.Editable = value;
			}
		}

		// Token: 0x1700664F RID: 26191
		// (get) Token: 0x0600CBA6 RID: 52134 RVA: 0x00BDEA28 File Offset: 0x00BDCC28
		internal string CnvPerSecureScanSelect_A9056_UILabel
		{
			get
			{
				short num = (short)753270784;
				short num2 = num;
				num = (short)129402771;
				short num3 = num;
				num = (short)978028435;
				switch (num3 == num)
				{
				}
				num = (short)1931083776;
				if (num != 0)
				{
				}
				num = (short)468123649;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.UIName;
			}
		}

		// Token: 0x17006650 RID: 26192
		// (get) Token: 0x0600CBA7 RID: 52135 RVA: 0x00BDEADC File Offset: 0x00BDCCDC
		// (set) Token: 0x0600CBA8 RID: 52136 RVA: 0x00BDEB94 File Offset: 0x00BDCD94
		internal bool CnvPerSecureScanSelect_A9056_HiddenStatic
		{
			get
			{
				short num = (short)1351876608;
				short num2 = num;
				num = (short)1814835452;
				short num3 = num;
				num = (short)1622880508;
				switch (num3 == num)
				{
				}
				num = (short)933101569;
				if (num != 0)
				{
				}
				num = (short)1921449984;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.HiddenStatic;
			}
			set
			{
				short num = (short)1460535296;
				short num2 = num;
				num = (short)526049568;
				short num3 = num;
				num = (short)948560160;
				switch (num3 == num)
				{
				}
				num = (short)2076049408;
				if (num != 0)
				{
				}
				num = (short)1789526017;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanSelect_A9056.HiddenStatic = value;
			}
		}

		// Token: 0x17006651 RID: 26193
		// (get) Token: 0x0600CBA9 RID: 52137 RVA: 0x00BDEC48 File Offset: 0x00BDCE48
		// (set) Token: 0x0600CBAA RID: 52138 RVA: 0x00BDECFC File Offset: 0x00BDCEFC
		internal bool CnvPerSecureScanSelect_A9056_HiddenDynamic
		{
			get
			{
				short num = (short)999096320;
				short num2 = num;
				num = (short)272023279;
				short num3 = num;
				num = (short)814989039;
				switch (num3 == num)
				{
				}
				num = (short)918290433;
				if (num != 0)
				{
				}
				num = (short)1046675456;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056.HiddenDynamic;
			}
			set
			{
				short num = (short)1394802688;
				short num2 = num;
				num = (short)1082608451;
				short num3 = num;
				num = (short)1659456323;
				switch (num3 == num)
				{
				}
				num = (short)2019229697;
				if (num != 0)
				{
				}
				num = (short)1002176512;
				if (num != 0)
				{
				}
				this.cnvPerSecureScanSelect_A9056.HiddenDynamic = value;
			}
		}

		// Token: 0x17006652 RID: 26194
		// (get) Token: 0x0600CBAB RID: 52139 RVA: 0x00BDEDB4 File Offset: 0x00BDCFB4
		public bool CnvPerSecureScanSelect_A9056_HasDiffs
		{
			get
			{
				short num = (short)848166912;
				short num2 = num;
				num = (short)80944274;
				short num3 = num;
				num = (short)737811602;
				switch (num3 == num)
				{
				}
				num = (short)9830400;
				if (num != 0)
				{
				}
				num = (short)1259012097;
				if (num != 0)
				{
				}
				return this.cnvPerSecureScanSelect_A9056._HasDiffs;
			}
		}

		// Token: 0x17006653 RID: 26195
		// (get) Token: 0x0600CBAC RID: 52140 RVA: 0x00BDEE6C File Offset: 0x00BDD06C
		// (set) Token: 0x0600CBAD RID: 52141 RVA: 0x00BDEF20 File Offset: 0x00BDD120
		public int CnvPerSecureSecureVoiceSignalType_A9086Value
		{
			get
			{
				short num = (short)690421760;
				short num2 = num;
				num = (short)1907034919;
				short num3 = num;
				num = (short)899353383;
				switch (num3 == num)
				{
				}
				num = (short)804782080;
				if (num != 0)
				{
				}
				num = (short)1647312897;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.Value;
			}
			set
			{
				short num = (short)917241856;
				short num2 = num;
				num = (short)1091614995;
				short num3 = num;
				num = (short)1962260755;
				switch (num3 == num)
				{
				}
				num = (short)71630848;
				if (num != 0)
				{
				}
				num = (short)557776897;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureVoiceSignalType_A9086.Value = value;
			}
		}

		// Token: 0x17006654 RID: 26196
		// (get) Token: 0x0600CBAE RID: 52142 RVA: 0x00BDEFD8 File Offset: 0x00BDD1D8
		// (set) Token: 0x0600CBAF RID: 52143 RVA: 0x00BDF088 File Offset: 0x00BDD288
		public string CnvPerSecureSecureVoiceSignalType_A9086_UIValue
		{
			get
			{
				short num = (short)1419116544;
				short num2 = num;
				num = (short)1111359489;
				if (num != 0)
				{
				}
				num = (short)1833666621;
				short num3 = num;
				num = (short)600410173;
				switch (num3 == num)
				{
				}
				num = (short)133496832;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.UIValue;
			}
			set
			{
				short num = (short)500367360;
				short num2 = num;
				num = (short)1645285354;
				short num3 = num;
				num = (short)373297130;
				switch (num3 == num)
				{
				}
				num = (short)99221504;
				if (num != 0)
				{
				}
				num = (short)98172929;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureVoiceSignalType_A9086.UIValue = value;
			}
		}

		// Token: 0x17006655 RID: 26197
		// (get) Token: 0x0600CBB0 RID: 52144 RVA: 0x00BDF13C File Offset: 0x00BDD33C
		public global::AcpBusinessLayer.AcpListField CnvPerSecureSecureVoiceSignalType_A9086
		{
			get
			{
				short num = (short)1126760448;
				short num2 = num;
				num = (short)1232655532;
				short num3 = num;
				num = (short)1031591084;
				switch (num3 == num)
				{
				}
				num = (short)1561133056;
				if (num != 0)
				{
				}
				num = (short)1985282049;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086;
			}
		}

		// Token: 0x17006656 RID: 26198
		// (get) Token: 0x0600CBB1 RID: 52145 RVA: 0x00BDF1E8 File Offset: 0x00BDD3E8
		// (set) Token: 0x0600CBB2 RID: 52146 RVA: 0x00BDF29C File Offset: 0x00BDD49C
		public bool CnvPerSecureSecureVoiceSignalType_A9086_Applicable
		{
			get
			{
				short num = (short)1208156160;
				short num2 = num;
				num = (short)447610881;
				if (num != 0)
				{
				}
				num = (short)991041840;
				short num3 = num;
				num = (short)1828198704;
				switch (num3 == num)
				{
				}
				num = (short)659030016;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.Applicable;
			}
			set
			{
				short num = (short)1492058112;
				short num2 = num;
				num = (short)789319660;
				short num3 = num;
				num = (short)742723564;
				switch (num3 == num)
				{
				}
				num = (short)259784705;
				if (num != 0)
				{
				}
				num = (short)1055260672;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureVoiceSignalType_A9086.Applicable = value;
			}
		}

		// Token: 0x17006657 RID: 26199
		// (get) Token: 0x0600CBB3 RID: 52147 RVA: 0x00BDF354 File Offset: 0x00BDD554
		// (set) Token: 0x0600CBB4 RID: 52148 RVA: 0x00BDF40C File Offset: 0x00BDD60C
		public bool CnvPerSecureSecureVoiceSignalType_A9086_Valid
		{
			get
			{
				short num = (short)2054422528;
				short num2 = num;
				num = (short)1607101578;
				short num3 = num;
				num = (short)754019466;
				switch (num3 == num)
				{
				}
				num = (short)1896677377;
				if (num != 0)
				{
				}
				num = (short)2146762752;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.Valid;
			}
			set
			{
				short num = (short)610795520;
				short num2 = num;
				num = (short)9936841;
				short num3 = num;
				num = (short)340959177;
				switch (num3 == num)
				{
				}
				num = (short)2094006273;
				if (num != 0)
				{
				}
				num = (short)324861952;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureVoiceSignalType_A9086.Valid = value;
			}
		}

		// Token: 0x17006658 RID: 26200
		// (get) Token: 0x0600CBB5 RID: 52149 RVA: 0x00BDF4C0 File Offset: 0x00BDD6C0
		// (set) Token: 0x0600CBB6 RID: 52150 RVA: 0x00BDF570 File Offset: 0x00BDD770
		public bool CnvPerSecureSecureVoiceSignalType_A9086_Visible
		{
			get
			{
				short num = (short)1095237632;
				short num2 = num;
				num = (short)1995505665;
				if (num != 0)
				{
				}
				num = (short)907704142;
				short num3 = num;
				num = (short)143423310;
				switch (num3 == num)
				{
				}
				num = (short)1724841984;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.Visible;
			}
			set
			{
				short num = (short)1200029696;
				short num2 = num;
				num = (short)1455753189;
				short num3 = num;
				num = (short)605816805;
				switch (num3 == num)
				{
				}
				num = (short)1332477953;
				if (num != 0)
				{
				}
				num = (short)1754660864;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureVoiceSignalType_A9086.Visible = value;
			}
		}

		// Token: 0x17006659 RID: 26201
		// (get) Token: 0x0600CBB7 RID: 52151 RVA: 0x00BDF628 File Offset: 0x00BDD828
		// (set) Token: 0x0600CBB8 RID: 52152 RVA: 0x00BDF6DC File Offset: 0x00BDD8DC
		public bool CnvPerSecureSecureVoiceSignalType_A9086_Editable
		{
			get
			{
				short num = (short)1226440704;
				short num2 = num;
				num = (short)883486371;
				short num3 = num;
				num = (short)103476899;
				switch (num3 == num)
				{
				}
				num = (short)679346177;
				if (num != 0)
				{
				}
				num = (short)236519424;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.Editable;
			}
			set
			{
				short num = (short)2044657664;
				short num2 = num;
				num = (short)435683925;
				short num3 = num;
				num = (short)2073231957;
				switch (num3 == num)
				{
				}
				num = (short)814350337;
				if (num != 0)
				{
				}
				num = (short)1410465792;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureVoiceSignalType_A9086.Editable = value;
			}
		}

		// Token: 0x1700665A RID: 26202
		// (get) Token: 0x0600CBB9 RID: 52153 RVA: 0x00BDF790 File Offset: 0x00BDD990
		internal string CnvPerSecureSecureVoiceSignalType_A9086_UILabel
		{
			get
			{
				short num = (short)1395916800;
				short num2 = num;
				num = (short)492561186;
				short num3 = num;
				num = (short)700769058;
				switch (num3 == num)
				{
				}
				num = (short)4784129;
				if (num != 0)
				{
				}
				num = (short)1536884736;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.UIName;
			}
		}

		// Token: 0x1700665B RID: 26203
		// (get) Token: 0x0600CBBA RID: 52154 RVA: 0x00BDF848 File Offset: 0x00BDDA48
		// (set) Token: 0x0600CBBB RID: 52155 RVA: 0x00BDF900 File Offset: 0x00BDDB00
		internal bool CnvPerSecureSecureVoiceSignalType_A9086_HiddenStatic
		{
			get
			{
				short num = (short)785121280;
				short num2 = num;
				num = (short)487653377;
				if (num != 0)
				{
				}
				num = (short)708267708;
				short num3 = num;
				num = (short)1290817212;
				switch (num3 == num)
				{
				}
				num = (short)143589376;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.HiddenStatic;
			}
			set
			{
				short num = (short)470351872;
				short num2 = num;
				num = (short)1165816327;
				short num3 = num;
				num = (short)1033695751;
				switch (num3 == num)
				{
				}
				num = (short)82903040;
				if (num != 0)
				{
				}
				num = (short)392298497;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureVoiceSignalType_A9086.HiddenStatic = value;
			}
		}

		// Token: 0x1700665C RID: 26204
		// (get) Token: 0x0600CBBC RID: 52156 RVA: 0x00BDF9B4 File Offset: 0x00BDDBB4
		// (set) Token: 0x0600CBBD RID: 52157 RVA: 0x00BDFA68 File Offset: 0x00BDDC68
		internal bool CnvPerSecureSecureVoiceSignalType_A9086_HiddenDynamic
		{
			get
			{
				short num = (short)1001652224;
				short num2 = num;
				num = (short)425784960;
				short num3 = num;
				num = (short)121370240;
				switch (num3 == num)
				{
				}
				num = (short)89522177;
				if (num != 0)
				{
				}
				num = (short)1644888064;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086.HiddenDynamic;
			}
			set
			{
				short num = (short)1702887424;
				short num2 = num;
				num = (short)148954070;
				short num3 = num;
				num = (short)1975573462;
				switch (num3 == num)
				{
				}
				num = (short)274595841;
				if (num != 0)
				{
				}
				num = (short)900595712;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureVoiceSignalType_A9086.HiddenDynamic = value;
			}
		}

		// Token: 0x1700665D RID: 26205
		// (get) Token: 0x0600CBBE RID: 52158 RVA: 0x00BDFB1C File Offset: 0x00BDDD1C
		public bool CnvPerSecureSecureVoiceSignalType_A9086_HasDiffs
		{
			get
			{
				short num = (short)1809514496;
				short num2 = num;
				num = (short)1442876587;
				short num3 = num;
				num = (short)832343211;
				switch (num3 == num)
				{
				}
				num = (short)1612644352;
				if (num != 0)
				{
				}
				num = (short)115998721;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureVoiceSignalType_A9086._HasDiffs;
			}
		}

		// Token: 0x1700665E RID: 26206
		// (get) Token: 0x0600CBBF RID: 52159 RVA: 0x00BDFBD4 File Offset: 0x00BDDDD4
		// (set) Token: 0x0600CBC0 RID: 52160 RVA: 0x00BDFC84 File Offset: 0x00BDDE84
		public int CnvPerSecureSecureClearStrapping2_A9091Value
		{
			get
			{
				short num = (short)1600585728;
				short num2 = num;
				num = (short)172424635;
				short num3 = num;
				num = (short)1425997243;
				switch (num3 == num)
				{
				}
				num = (short)1802174465;
				if (num != 0)
				{
				}
				num = (short)1326579712;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.Value;
			}
			set
			{
				short num = (short)1571225600;
				short num2 = num;
				num = (short)288386745;
				short num3 = num;
				num = (short)1418227385;
				switch (num3 == num)
				{
				}
				num = (short)1468923905;
				if (num != 0)
				{
				}
				num = (short)1840447488;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping2_A9091.Value = value;
			}
		}

		// Token: 0x1700665F RID: 26207
		// (get) Token: 0x0600CBC1 RID: 52161 RVA: 0x00BDFD38 File Offset: 0x00BDDF38
		// (set) Token: 0x0600CBC2 RID: 52162 RVA: 0x00BDFDF0 File Offset: 0x00BDDFF0
		public string CnvPerSecureSecureClearStrapping2_A9091_UIValue
		{
			get
			{
				short num = (short)126287872;
				short num2 = num;
				num = (short)278875808;
				short num3 = num;
				num = (short)1601982112;
				switch (num3 == num)
				{
				}
				num = (short)1377370113;
				if (num != 0)
				{
				}
				num = (short)901447680;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.UIValue;
			}
			set
			{
				short num = (short)1742340096;
				short num2 = num;
				num = (short)1496861087;
				short num3 = num;
				num = (short)962415007;
				switch (num3 == num)
				{
				}
				num = (short)345505793;
				if (num != 0)
				{
				}
				num = (short)1954021376;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping2_A9091.UIValue = value;
			}
		}

		// Token: 0x17006660 RID: 26208
		// (get) Token: 0x0600CBC3 RID: 52163 RVA: 0x00BDFEA4 File Offset: 0x00BDE0A4
		public global::AcpBusinessLayer.AcpListField CnvPerSecureSecureClearStrapping2_A9091
		{
			get
			{
				short num = (short)476643328;
				short num2 = num;
				num = (short)322306049;
				if (num != 0)
				{
				}
				num = (short)1755185431;
				short num3 = num;
				num = (short)2084045079;
				switch (num3 == num)
				{
				}
				num = (short)89260032;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091;
			}
		}

		// Token: 0x17006661 RID: 26209
		// (get) Token: 0x0600CBC4 RID: 52164 RVA: 0x00BDFF50 File Offset: 0x00BDE150
		// (set) Token: 0x0600CBC5 RID: 52165 RVA: 0x00BE0008 File Offset: 0x00BDE208
		public bool CnvPerSecureSecureClearStrapping2_A9091_Applicable
		{
			get
			{
				short num = (short)215416832;
				short num2 = num;
				num = (short)140935628;
				short num3 = num;
				num = (short)1570603468;
				switch (num3 == num)
				{
				}
				num = (short)1286012929;
				if (num != 0)
				{
				}
				num = (short)1425539072;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.Applicable;
			}
			set
			{
				short num = (short)216596480;
				short num2 = num;
				num = (short)575488625;
				short num3 = num;
				num = (short)317211249;
				switch (num3 == num)
				{
				}
				num = (short)912261120;
				if (num != 0)
				{
				}
				num = (short)1750073345;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping2_A9091.Applicable = value;
			}
		}

		// Token: 0x17006662 RID: 26210
		// (get) Token: 0x0600CBC6 RID: 52166 RVA: 0x00BE00C0 File Offset: 0x00BDE2C0
		// (set) Token: 0x0600CBC7 RID: 52167 RVA: 0x00BE0174 File Offset: 0x00BDE374
		public bool CnvPerSecureSecureClearStrapping2_A9091_Valid
		{
			get
			{
				short num = (short)1714421761;
				if (num != 0)
				{
				}
				num = (short)1657864192;
				short num2 = num;
				num = (short)1891650504;
				short num3 = num;
				num = (short)641223624;
				switch (num3 == num)
				{
				}
				num = (short)1873543168;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.Valid;
			}
			set
			{
				short num = (short)734527489;
				if (num != 0)
				{
				}
				num = (short)1506738176;
				short num2 = num;
				num = (short)1978415314;
				short num3 = num;
				num = (short)1018575058;
				switch (num3 == num)
				{
				}
				num = (short)185073664;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping2_A9091.Valid = value;
			}
		}

		// Token: 0x17006663 RID: 26211
		// (get) Token: 0x0600CBC8 RID: 52168 RVA: 0x00BE0228 File Offset: 0x00BDE428
		// (set) Token: 0x0600CBC9 RID: 52169 RVA: 0x00BE02E0 File Offset: 0x00BDE4E0
		public bool CnvPerSecureSecureClearStrapping2_A9091_Visible
		{
			get
			{
				short num = (short)988348417;
				if (num != 0)
				{
				}
				num = (short)1475805184;
				short num2 = num;
				num = (short)1496866101;
				short num3 = num;
				num = (short)541809973;
				switch (num3 == num)
				{
				}
				num = (short)1833172992;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.Visible;
			}
			set
			{
				short num = (short)1301148278;
				short num2 = num;
				num = (short)1161556598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7667712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1419247616;
				if (num != 0)
				{
				}
				num = (short)512819201;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping2_A9091.Visible = value;
			}
		}

		// Token: 0x17006664 RID: 26212
		// (get) Token: 0x0600CBCA RID: 52170 RVA: 0x00BE0398 File Offset: 0x00BDE598
		// (set) Token: 0x0600CBCB RID: 52171 RVA: 0x00BE044C File Offset: 0x00BDE64C
		public bool CnvPerSecureSecureClearStrapping2_A9091_Editable
		{
			get
			{
				short num = (short)340390678;
				short num2 = num;
				num = (short)44626710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954400768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)340197376;
				if (num != 0)
				{
				}
				num = (short)136118273;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.Editable;
			}
			set
			{
				short num = (short)313400937;
				short num2 = num;
				num = (short)1053498985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1131020288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1141964800;
				if (num != 0)
				{
				}
				num = (short)1214054401;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping2_A9091.Editable = value;
			}
		}

		// Token: 0x17006665 RID: 26213
		// (get) Token: 0x0600CBCC RID: 52172 RVA: 0x00BE0504 File Offset: 0x00BDE704
		internal string CnvPerSecureSecureClearStrapping2_A9091_UILabel
		{
			get
			{
				short num = (short)1342131539;
				short num2 = num;
				num = (short)840715603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1035927552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672006145;
				if (num != 0)
				{
				}
				num = (short)787218432;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.UIName;
			}
		}

		// Token: 0x17006666 RID: 26214
		// (get) Token: 0x0600CBCD RID: 52173 RVA: 0x00BE05BC File Offset: 0x00BDE7BC
		// (set) Token: 0x0600CBCE RID: 52174 RVA: 0x00BE0670 File Offset: 0x00BDE870
		internal bool CnvPerSecureSecureClearStrapping2_A9091_HiddenStatic
		{
			get
			{
				short num = (short)2135523291;
				short num2 = num;
				num = (short)1305903067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536557056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)138936321;
				if (num != 0)
				{
				}
				num = (short)503316480;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.HiddenStatic;
			}
			set
			{
				short num = (short)482022819;
				short num2 = num;
				num = (short)890312099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)838533120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)964689920;
				if (num != 0)
				{
				}
				num = (short)1326972929;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping2_A9091.HiddenStatic = value;
			}
		}

		// Token: 0x17006667 RID: 26215
		// (get) Token: 0x0600CBCF RID: 52175 RVA: 0x00BE0724 File Offset: 0x00BDE924
		// (set) Token: 0x0600CBD0 RID: 52176 RVA: 0x00BE07D8 File Offset: 0x00BDE9D8
		internal bool CnvPerSecureSecureClearStrapping2_A9091_HiddenDynamic
		{
			get
			{
				short num = (short)1573834903;
				short num2 = num;
				num = (short)1475989655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)64749568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1142358017;
				if (num != 0)
				{
				}
				num = (short)344195072;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091.HiddenDynamic;
			}
			set
			{
				short num = (short)327745537;
				if (num != 0)
				{
				}
				num = (short)2068709376;
				short num2 = num;
				num = (short)269239505;
				short num3 = num;
				num = (short)391791825;
				switch (num3 == num)
				{
				}
				num = (short)780599296;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping2_A9091.HiddenDynamic = value;
			}
		}

		// Token: 0x17006668 RID: 26216
		// (get) Token: 0x0600CBD1 RID: 52177 RVA: 0x00BE088C File Offset: 0x00BDEA8C
		public bool CnvPerSecureSecureClearStrapping2_A9091_HasDiffs
		{
			get
			{
				short num = (short)529638675;
				short num2 = num;
				num = (short)2090116371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)946012160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173080577;
				if (num != 0)
				{
				}
				num = (short)302448640;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping2_A9091._HasDiffs;
			}
		}

		// Token: 0x17006669 RID: 26217
		// (get) Token: 0x0600CBD2 RID: 52178 RVA: 0x00BE0940 File Offset: 0x00BDEB40
		// (set) Token: 0x0600CBD3 RID: 52179 RVA: 0x00BE09F4 File Offset: 0x00BDEBF4
		public int CnvPerSecureXLDelayFollowingKeyID_A9680Value
		{
			get
			{
				short num = (short)410018874;
				short num2 = num;
				num = (short)1664574522;
				switch (num2 == num)
				{
				default:
				{
					num = (short)725942272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493172225;
				if (num != 0)
				{
				}
				num = (short)1345257472;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.Value;
			}
			set
			{
				short num = (short)1219117408;
				short num2 = num;
				num = (short)943669600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1492713472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1507983361;
				if (num != 0)
				{
				}
				num = (short)463273984;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.Value = value;
			}
		}

		// Token: 0x1700666A RID: 26218
		// (get) Token: 0x0600CBD4 RID: 52180 RVA: 0x00BE0AA8 File Offset: 0x00BDECA8
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerSecureXLDelayFollowingKeyID_A9680
		{
			get
			{
				short num = (short)1059184477;
				short num2 = num;
				num = (short)1681645405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292304384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145896961;
				if (num != 0)
				{
				}
				num = (short)1959854080;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680;
			}
		}

		// Token: 0x1700666B RID: 26219
		// (get) Token: 0x0600CBD5 RID: 52181 RVA: 0x00BE0B58 File Offset: 0x00BDED58
		// (set) Token: 0x0600CBD6 RID: 52182 RVA: 0x00BE0C0C File Offset: 0x00BDEE0C
		public string CnvPerSecureXLDelayFollowingKeyID_A9680_UIValue
		{
			get
			{
				short num = (short)1928222235;
				short num2 = num;
				num = (short)1535661595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874067456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235091457;
				if (num != 0)
				{
				}
				num = (short)1843331072;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.UIValue;
			}
			set
			{
				short num = (short)2115557532;
				short num2 = num;
				num = (short)733141148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1271791616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)73400320;
				if (num != 0)
				{
				}
				num = (short)1824194561;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.UIValue = value;
			}
		}

		// Token: 0x1700666C RID: 26220
		// (get) Token: 0x0600CBD7 RID: 52183 RVA: 0x00BE0CC0 File Offset: 0x00BDEEC0
		// (set) Token: 0x0600CBD8 RID: 52184 RVA: 0x00BE0D74 File Offset: 0x00BDEF74
		internal int CnvPerSecureXLDelayFollowingKeyID_A9680Min
		{
			get
			{
				short num = (short)1819869185;
				if (num != 0)
				{
				}
				num = (short)34996224;
				short num2 = num;
				num = (short)1201670536;
				short num3 = num;
				num = (short)748685704;
				switch (num3 == num)
				{
				}
				num = (short)2017853440;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.Min;
			}
			set
			{
				short num = (short)251043244;
				short num2 = num;
				num = (short)1779604908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)886833152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)940507136;
				if (num != 0)
				{
				}
				num = (short)183762945;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.Min = value;
			}
		}

		// Token: 0x1700666D RID: 26221
		// (get) Token: 0x0600CBD9 RID: 52185 RVA: 0x00BE0E2C File Offset: 0x00BDF02C
		// (set) Token: 0x0600CBDA RID: 52186 RVA: 0x00BE0EE0 File Offset: 0x00BDF0E0
		internal int CnvPerSecureXLDelayFollowingKeyID_A9680Max
		{
			get
			{
				short num = (short)1219396121;
				short num2 = num;
				num = (short)861176345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784086528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2017198081;
				if (num != 0)
				{
				}
				num = (short)1286406144;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.Max;
			}
			set
			{
				short num = (short)931165173;
				short num2 = num;
				num = (short)1336505333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1825308672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1575354369;
				if (num != 0)
				{
				}
				num = (short)627703808;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.Max = value;
			}
		}

		// Token: 0x1700666E RID: 26222
		// (get) Token: 0x0600CBDB RID: 52187 RVA: 0x00BE0F98 File Offset: 0x00BDF198
		// (set) Token: 0x0600CBDC RID: 52188 RVA: 0x00BE1050 File Offset: 0x00BDF250
		internal int CnvPerSecureXLDelayFollowingKeyID_A9680Step
		{
			get
			{
				short num = (short)1267059470;
				short num2 = num;
				num = (short)696437518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117847552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)254541825;
				if (num != 0)
				{
				}
				num = (short)672202752;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.StepSize;
			}
			set
			{
				short num = (short)259602750;
				short num2 = num;
				num = (short)1143421246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)764936192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2046820352;
				if (num != 0)
				{
				}
				num = (short)907935745;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.StepSize = value;
			}
		}

		// Token: 0x1700666F RID: 26223
		// (get) Token: 0x0600CBDD RID: 52189 RVA: 0x00BE1104 File Offset: 0x00BDF304
		// (set) Token: 0x0600CBDE RID: 52190 RVA: 0x00BE11BC File Offset: 0x00BDF3BC
		public bool CnvPerSecureXLDelayFollowingKeyID_A9680_Applicable
		{
			get
			{
				short num = (short)1994429835;
				short num2 = num;
				num = (short)1568511371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046478848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1878065152;
				if (num != 0)
				{
				}
				num = (short)643891201;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.Applicable;
			}
			set
			{
				short num = (short)2083863164;
				short num2 = num;
				num = (short)285555324;
				switch (num2 == num)
				{
				default:
				{
					num = (short)807075840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)745209856;
				if (num != 0)
				{
				}
				num = (short)1926103041;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.Applicable = value;
			}
		}

		// Token: 0x17006670 RID: 26224
		// (get) Token: 0x0600CBDF RID: 52191 RVA: 0x00BE1274 File Offset: 0x00BDF474
		// (set) Token: 0x0600CBE0 RID: 52192 RVA: 0x00BE132C File Offset: 0x00BDF52C
		public bool CnvPerSecureXLDelayFollowingKeyID_A9680_Valid
		{
			get
			{
				short num = (short)526320970;
				short num2 = num;
				num = (short)278725962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1226309632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)53411841;
				if (num != 0)
				{
				}
				num = (short)723189760;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.Valid;
			}
			set
			{
				short num = (short)1256600131;
				short num2 = num;
				num = (short)10236483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)649068544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1801846785;
				if (num != 0)
				{
				}
				num = (short)1383661568;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.Valid = value;
			}
		}

		// Token: 0x17006671 RID: 26225
		// (get) Token: 0x0600CBE1 RID: 52193 RVA: 0x00BE13E0 File Offset: 0x00BDF5E0
		// (set) Token: 0x0600CBE2 RID: 52194 RVA: 0x00BE1494 File Offset: 0x00BDF694
		public bool CnvPerSecureXLDelayFollowingKeyID_A9680_Visible
		{
			get
			{
				short num = (short)1608928648;
				short num2 = num;
				num = (short)592465288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)259522560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)296943616;
				if (num != 0)
				{
				}
				num = (short)610271233;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.Visible;
			}
			set
			{
				short num = (short)404205017;
				short num2 = num;
				num = (short)220900825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1755906048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1042284545;
				if (num != 0)
				{
				}
				num = (short)1404633088;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.Visible = value;
			}
		}

		// Token: 0x17006672 RID: 26226
		// (get) Token: 0x0600CBE3 RID: 52195 RVA: 0x00BE154C File Offset: 0x00BDF74C
		// (set) Token: 0x0600CBE4 RID: 52196 RVA: 0x00BE1600 File Offset: 0x00BDF800
		public bool CnvPerSecureXLDelayFollowingKeyID_A9680_Editable
		{
			get
			{
				short num = (short)2018098311;
				short num2 = num;
				num = (short)1136311431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)465895424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2082668545;
				if (num != 0)
				{
				}
				num = (short)631832576;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.Editable;
			}
			set
			{
				short num = (short)1324773235;
				short num2 = num;
				num = (short)1210281843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1103364096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192937985;
				if (num != 0)
				{
				}
				num = (short)258670592;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.Editable = value;
			}
		}

		// Token: 0x17006673 RID: 26227
		// (get) Token: 0x0600CBE5 RID: 52197 RVA: 0x00BE16B8 File Offset: 0x00BDF8B8
		internal string CnvPerSecureXLDelayFollowingKeyID_A9680_UILabel
		{
			get
			{
				short num = (short)416153601;
				if (num != 0)
				{
				}
				num = (short)582483968;
				short num2 = num;
				num = (short)1287030566;
				short num3 = num;
				num = (short)577341222;
				switch (num3 == num)
				{
				}
				num = (short)165543936;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.UIName;
			}
		}

		// Token: 0x17006674 RID: 26228
		// (get) Token: 0x0600CBE6 RID: 52198 RVA: 0x00BE176C File Offset: 0x00BDF96C
		// (set) Token: 0x0600CBE7 RID: 52199 RVA: 0x00BE1820 File Offset: 0x00BDFA20
		internal bool CnvPerSecureXLDelayFollowingKeyID_A9680_HiddenStatic
		{
			get
			{
				short num = (short)927043101;
				short num2 = num;
				num = (short)434867741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)818675712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)651362305;
				if (num != 0)
				{
				}
				num = (short)2025127936;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.HiddenStatic;
			}
			set
			{
				short num = (short)1229296186;
				short num2 = num;
				num = (short)497586746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)588972032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334168064;
				if (num != 0)
				{
				}
				num = (short)1855062017;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.HiddenStatic = value;
			}
		}

		// Token: 0x17006675 RID: 26229
		// (get) Token: 0x0600CBE8 RID: 52200 RVA: 0x00BE18D4 File Offset: 0x00BDFAD4
		// (set) Token: 0x0600CBE9 RID: 52201 RVA: 0x00BE1988 File Offset: 0x00BDFB88
		internal bool CnvPerSecureXLDelayFollowingKeyID_A9680_HiddenDynamic
		{
			get
			{
				short num = (short)1381957633;
				if (num != 0)
				{
				}
				num = (short)1626537984;
				short num2 = num;
				num = (short)867552616;
				short num3 = num;
				num = (short)744803688;
				switch (num3 == num)
				{
				}
				num = (short)633667584;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680.HiddenDynamic;
			}
			set
			{
				short num = (short)23648026;
				short num2 = num;
				num = (short)1441978138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1529806848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1089601537;
				if (num != 0)
				{
				}
				num = (short)1508573184;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLDelayFollowingKeyID_A9680.HiddenDynamic = value;
			}
		}

		// Token: 0x17006676 RID: 26230
		// (get) Token: 0x0600CBEA RID: 52202 RVA: 0x00BE1A3C File Offset: 0x00BDFC3C
		public bool CnvPerSecureXLDelayFollowingKeyID_A9680_HasDiffs
		{
			get
			{
				short num = (short)2130382677;
				short num2 = num;
				num = (short)778637141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)607977472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1028784129;
				if (num != 0)
				{
				}
				num = (short)1641873408;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLDelayFollowingKeyID_A9680._HasDiffs;
			}
		}

		// Token: 0x17006677 RID: 26231
		// (get) Token: 0x0600CBEB RID: 52203 RVA: 0x00BE1AF0 File Offset: 0x00BDFCF0
		// (set) Token: 0x0600CBEC RID: 52204 RVA: 0x00BE1BA4 File Offset: 0x00BDFDA4
		public bool CnvPerSecureXLTransmit_A9683Value
		{
			get
			{
				short num = (short)1603906899;
				short num2 = num;
				num = (short)927968595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1753350144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)797376512;
				if (num != 0)
				{
				}
				num = (short)1199112193;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.Value;
			}
			set
			{
				short num = (short)1375044663;
				short num2 = num;
				num = (short)848987191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1690697728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1652293633;
				if (num != 0)
				{
				}
				num = (short)1554317312;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLTransmit_A9683.Value = value;
			}
		}

		// Token: 0x17006678 RID: 26232
		// (get) Token: 0x0600CBED RID: 52205 RVA: 0x00BE1C5C File Offset: 0x00BDFE5C
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSecureXLTransmit_A9683
		{
			get
			{
				short num = (short)612428156;
				short num2 = num;
				num = (short)1378937212;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1979121664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1565589504;
				if (num != 0)
				{
				}
				num = (short)1418067969;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683;
			}
		}

		// Token: 0x17006679 RID: 26233
		// (get) Token: 0x0600CBEE RID: 52206 RVA: 0x00BE1D0C File Offset: 0x00BDFF0C
		// (set) Token: 0x0600CBEF RID: 52207 RVA: 0x00BE1DC0 File Offset: 0x00BDFFC0
		public bool CnvPerSecureXLTransmit_A9683_UIValue
		{
			get
			{
				short num = (short)1368064001;
				if (num != 0)
				{
				}
				num = (short)1456537600;
				short num2 = num;
				num = (short)1352638800;
				short num3 = num;
				num = (short)24748368;
				switch (num3 == num)
				{
				}
				num = (short)1595277312;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.Value;
			}
			set
			{
				short num = (short)1456046714;
				short num2 = num;
				num = (short)228557434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)54329344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1908146177;
				if (num != 0)
				{
				}
				num = (short)1093140480;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLTransmit_A9683.Value = value;
			}
		}

		// Token: 0x1700667A RID: 26234
		// (get) Token: 0x0600CBF0 RID: 52208 RVA: 0x00BE1E74 File Offset: 0x00BE0074
		// (set) Token: 0x0600CBF1 RID: 52209 RVA: 0x00BE1F2C File Offset: 0x00BE012C
		public bool CnvPerSecureXLTransmit_A9683_Applicable
		{
			get
			{
				short num = (short)666684799;
				short num2 = num;
				num = (short)918343039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30998528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993853441;
				if (num != 0)
				{
				}
				num = (short)428867584;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.Applicable;
			}
			set
			{
				short num = (short)2003861028;
				short num2 = num;
				num = (short)678395428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)250150912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1101529088;
				if (num != 0)
				{
				}
				num = (short)103940097;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLTransmit_A9683.Applicable = value;
			}
		}

		// Token: 0x1700667B RID: 26235
		// (get) Token: 0x0600CBF2 RID: 52210 RVA: 0x00BE1FE4 File Offset: 0x00BE01E4
		// (set) Token: 0x0600CBF3 RID: 52211 RVA: 0x00BE2098 File Offset: 0x00BE0298
		public bool CnvPerSecureXLTransmit_A9683_Valid
		{
			get
			{
				short num = (short)29863222;
				short num2 = num;
				num = (short)2044177718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)127860736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645595136;
				if (num != 0)
				{
				}
				num = (short)1440088065;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.Valid;
			}
			set
			{
				short num = (short)656232813;
				short num2 = num;
				num = (short)960319853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)562364416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068433409;
				if (num != 0)
				{
				}
				num = (short)1941307392;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLTransmit_A9683.Valid = value;
			}
		}

		// Token: 0x1700667C RID: 26236
		// (get) Token: 0x0600CBF4 RID: 52212 RVA: 0x00BE214C File Offset: 0x00BE034C
		// (set) Token: 0x0600CBF5 RID: 52213 RVA: 0x00BE2200 File Offset: 0x00BE0400
		public bool CnvPerSecureXLTransmit_A9683_Visible
		{
			get
			{
				short num = (short)1895462811;
				short num2 = num;
				num = (short)1620866971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432537600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1477312512;
				if (num != 0)
				{
				}
				num = (short)213712897;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.Visible;
			}
			set
			{
				short num = (short)1128745802;
				short num2 = num;
				num = (short)1494567754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)32178176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697775617;
				if (num != 0)
				{
				}
				num = (short)1301151744;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLTransmit_A9683.Visible = value;
			}
		}

		// Token: 0x1700667D RID: 26237
		// (get) Token: 0x0600CBF6 RID: 52214 RVA: 0x00BE22B8 File Offset: 0x00BE04B8
		// (set) Token: 0x0600CBF7 RID: 52215 RVA: 0x00BE236C File Offset: 0x00BE056C
		public bool CnvPerSecureXLTransmit_A9683_Editable
		{
			get
			{
				short num = (short)1549147742;
				short num2 = num;
				num = (short)286137950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)769916928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46137345;
				if (num != 0)
				{
				}
				num = (short)1822621696;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.Editable;
			}
			set
			{
				short num = (short)30283933;
				short num2 = num;
				num = (short)232069277;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1651310592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1745944576;
				if (num != 0)
				{
				}
				num = (short)781254657;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLTransmit_A9683.Editable = value;
			}
		}

		// Token: 0x1700667E RID: 26238
		// (get) Token: 0x0600CBF8 RID: 52216 RVA: 0x00BE2424 File Offset: 0x00BE0624
		internal string CnvPerSecureXLTransmit_A9683_UILabel
		{
			get
			{
				short num = (short)2107733508;
				short num2 = num;
				num = (short)467170820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1764163584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1225588737;
				if (num != 0)
				{
				}
				num = (short)443285504;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.UIName;
			}
		}

		// Token: 0x1700667F RID: 26239
		// (get) Token: 0x0600CBF9 RID: 52217 RVA: 0x00BE24D8 File Offset: 0x00BE06D8
		// (set) Token: 0x0600CBFA RID: 52218 RVA: 0x00BE258C File Offset: 0x00BE078C
		internal bool CnvPerSecureXLTransmit_A9683_HiddenStatic
		{
			get
			{
				short num = (short)1700216855;
				short num2 = num;
				num = (short)2022785047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)655097856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1647116289;
				if (num != 0)
				{
				}
				num = (short)1388904448;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.HiddenStatic;
			}
			set
			{
				short num = (short)1111909226;
				short num2 = num;
				num = (short)639918954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)938868736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270204929;
				if (num != 0)
				{
				}
				num = (short)1361575936;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLTransmit_A9683.HiddenStatic = value;
			}
		}

		// Token: 0x17006680 RID: 26240
		// (get) Token: 0x0600CBFB RID: 52219 RVA: 0x00BE2644 File Offset: 0x00BE0844
		// (set) Token: 0x0600CBFC RID: 52220 RVA: 0x00BE26F8 File Offset: 0x00BE08F8
		internal bool CnvPerSecureXLTransmit_A9683_HiddenDynamic
		{
			get
			{
				short num = (short)1269563393;
				if (num != 0)
				{
				}
				num = (short)230621184;
				short num2 = num;
				num = (short)1092812723;
				short num3 = num;
				num = (short)1579286451;
				switch (num3 == num)
				{
				}
				num = (short)1258487808;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683.HiddenDynamic;
			}
			set
			{
				short num = (short)312528508;
				short num2 = num;
				num = (short)1285017212;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825032704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)885587969;
				if (num != 0)
				{
				}
				num = (short)1961623552;
				if (num != 0)
				{
				}
				this.cnvPerSecureXLTransmit_A9683.HiddenDynamic = value;
			}
		}

		// Token: 0x17006681 RID: 26241
		// (get) Token: 0x0600CBFD RID: 52221 RVA: 0x00BE27AC File Offset: 0x00BE09AC
		public bool CnvPerSecureXLTransmit_A9683_HasDiffs
		{
			get
			{
				short num = (short)455442617;
				short num2 = num;
				num = (short)925532345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105212928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)481230848;
				if (num != 0)
				{
				}
				num = (short)395640833;
				if (num != 0)
				{
				}
				return this.cnvPerSecureXLTransmit_A9683._HasDiffs;
			}
		}

		// Token: 0x17006682 RID: 26242
		// (get) Token: 0x0600CBFE RID: 52222 RVA: 0x00BE2860 File Offset: 0x00BE0A60
		// (set) Token: 0x0600CBFF RID: 52223 RVA: 0x00BE2918 File Offset: 0x00BE0B18
		public bool CnvPerSecureIgnoreRxClearPacketData_A19310Value
		{
			get
			{
				short num = (short)1882193921;
				if (num != 0)
				{
				}
				num = (short)1634729984;
				short num2 = num;
				num = (short)1051000724;
				short num3 = num;
				num = (short)678494100;
				switch (num3 == num)
				{
				}
				num = (short)1506213888;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.Value;
			}
			set
			{
				short num = (short)36438017;
				if (num != 0)
				{
				}
				num = (short)1988034560;
				short num2 = num;
				num = (short)259049385;
				short num3 = num;
				num = (short)512018345;
				switch (num3 == num)
				{
				}
				num = (short)1748828160;
				if (num != 0)
				{
				}
				this.cnvPerSecureIgnoreRxClearPacketData_A19310.Value = value;
			}
		}

		// Token: 0x17006683 RID: 26243
		// (get) Token: 0x0600CC00 RID: 52224 RVA: 0x00BE29D0 File Offset: 0x00BE0BD0
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSecureIgnoreRxClearPacketData_A19310
		{
			get
			{
				short num = (short)1476179962;
				short num2 = num;
				num = (short)635090938;
				switch (num2 == num)
				{
				}
				num = (short)1797455872;
				short num3 = num;
				num = (short)2143944704;
				if (num != 0)
				{
				}
				num = (short)2083061761;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310;
			}
		}

		// Token: 0x17006684 RID: 26244
		// (get) Token: 0x0600CC01 RID: 52225 RVA: 0x00BE2A84 File Offset: 0x00BE0C84
		// (set) Token: 0x0600CC02 RID: 52226 RVA: 0x00BE2B38 File Offset: 0x00BE0D38
		public bool CnvPerSecureIgnoreRxClearPacketData_A19310_UIValue
		{
			get
			{
				short num = (short)83357132;
				short num2 = num;
				num = (short)385740236;
				switch (num2 == num)
				{
				}
				num = (short)168034304;
				short num3 = num;
				num = (short)619446273;
				if (num != 0)
				{
				}
				num = (short)1038221312;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.Value;
			}
			set
			{
				short num = (short)1708190757;
				short num2 = num;
				num = (short)1895689253;
				switch (num2 == num)
				{
				}
				num = (short)1153957888;
				short num3 = num;
				num = (short)871956481;
				if (num != 0)
				{
				}
				num = (short)148307968;
				if (num != 0)
				{
				}
				this.cnvPerSecureIgnoreRxClearPacketData_A19310.Value = value;
			}
		}

		// Token: 0x17006685 RID: 26245
		// (get) Token: 0x0600CC03 RID: 52227 RVA: 0x00BE2BEC File Offset: 0x00BE0DEC
		// (set) Token: 0x0600CC04 RID: 52228 RVA: 0x00BE2CA0 File Offset: 0x00BE0EA0
		public bool CnvPerSecureIgnoreRxClearPacketData_A19310_Applicable
		{
			get
			{
				short num = (short)680722378;
				short num2 = num;
				num = (short)1768882122;
				switch (num2 == num)
				{
				}
				num = (short)1169686528;
				short num3 = num;
				num = (short)1077084161;
				if (num != 0)
				{
				}
				num = (short)268107776;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.Applicable;
			}
			set
			{
				short num = (short)1328337409;
				short num2 = num;
				num = (short)1271190017;
				switch (num2 == num)
				{
				}
				num = (short)1490485248;
				short num3 = num;
				num = (short)1859780609;
				if (num != 0)
				{
				}
				num = (short)1284374528;
				if (num != 0)
				{
				}
				this.cnvPerSecureIgnoreRxClearPacketData_A19310.Applicable = value;
			}
		}

		// Token: 0x17006686 RID: 26246
		// (get) Token: 0x0600CC05 RID: 52229 RVA: 0x00BE2D54 File Offset: 0x00BE0F54
		// (set) Token: 0x0600CC06 RID: 52230 RVA: 0x00BE2E08 File Offset: 0x00BE1008
		public bool CnvPerSecureIgnoreRxClearPacketData_A19310_Valid
		{
			get
			{
				short num = (short)832657691;
				short num2 = num;
				num = (short)1215781147;
				switch (num2 == num)
				{
				}
				num = (short)1417216000;
				short num3 = num;
				num = (short)446955521;
				if (num != 0)
				{
				}
				num = (short)227278848;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.Valid;
			}
			set
			{
				short num = (short)1604608292;
				short num2 = num;
				num = (short)405889316;
				switch (num2 == num)
				{
				}
				num = (short)227999744;
				short num3 = num;
				num = (short)1532821505;
				if (num != 0)
				{
				}
				num = (short)2059141120;
				if (num != 0)
				{
				}
				this.cnvPerSecureIgnoreRxClearPacketData_A19310.Valid = value;
			}
		}

		// Token: 0x17006687 RID: 26247
		// (get) Token: 0x0600CC07 RID: 52231 RVA: 0x00BE2EC0 File Offset: 0x00BE10C0
		// (set) Token: 0x0600CC08 RID: 52232 RVA: 0x00BE2F74 File Offset: 0x00BE1174
		public bool CnvPerSecureIgnoreRxClearPacketData_A19310_Visible
		{
			get
			{
				short num = (short)545652737;
				if (num != 0)
				{
				}
				num = (short)530693547;
				short num2 = num;
				num = (short)1921695147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1302134784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1004732416;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.Visible;
			}
			set
			{
				short num = (short)912523265;
				if (num != 0)
				{
				}
				num = (short)1441601269;
				short num2 = num;
				num = (short)248583925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277558784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1059651584;
				if (num != 0)
				{
				}
				this.cnvPerSecureIgnoreRxClearPacketData_A19310.Visible = value;
			}
		}

		// Token: 0x17006688 RID: 26248
		// (get) Token: 0x0600CC09 RID: 52233 RVA: 0x00BE3028 File Offset: 0x00BE1228
		// (set) Token: 0x0600CC0A RID: 52234 RVA: 0x00BE30DC File Offset: 0x00BE12DC
		public bool CnvPerSecureIgnoreRxClearPacketData_A19310_Editable
		{
			get
			{
				short num = (short)1120653823;
				short num2 = num;
				num = (short)2049823231;
				switch (num2 == num)
				{
				}
				num = (short)543162368;
				short num3 = num;
				num = (short)325124097;
				if (num != 0)
				{
				}
				num = (short)573046784;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.Editable;
			}
			set
			{
				short num = (short)1691055095;
				short num2 = num;
				num = (short)1695904759;
				switch (num2 == num)
				{
				}
				num = (short)856948736;
				short num3 = num;
				num = (short)478085121;
				if (num != 0)
				{
				}
				num = (short)313458688;
				if (num != 0)
				{
				}
				this.cnvPerSecureIgnoreRxClearPacketData_A19310.Editable = value;
			}
		}

		// Token: 0x17006689 RID: 26249
		// (get) Token: 0x0600CC0B RID: 52235 RVA: 0x00BE3190 File Offset: 0x00BE1390
		internal string CnvPerSecureIgnoreRxClearPacketData_A19310_UILabel
		{
			get
			{
				short num = (short)1092094018;
				short num2 = num;
				num = (short)1634535490;
				switch (num2 == num)
				{
				}
				num = (short)1260650496;
				short num3 = num;
				num = (short)475725824;
				if (num != 0)
				{
				}
				num = (short)281477121;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.UIName;
			}
		}

		// Token: 0x1700668A RID: 26250
		// (get) Token: 0x0600CC0C RID: 52236 RVA: 0x00BE3244 File Offset: 0x00BE1444
		// (set) Token: 0x0600CC0D RID: 52237 RVA: 0x00BE32F8 File Offset: 0x00BE14F8
		internal bool CnvPerSecureIgnoreRxClearPacketData_A19310_HiddenStatic
		{
			get
			{
				short num = (short)1218463430;
				short num2 = num;
				num = (short)2068596422;
				switch (num2 == num)
				{
				}
				num = (short)873070592;
				short num3 = num;
				num = (short)1464598529;
				if (num != 0)
				{
				}
				num = (short)1155727360;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.HiddenStatic;
			}
			set
			{
				short num = (short)864430920;
				short num2 = num;
				num = (short)559622984;
				switch (num2 == num)
				{
				}
				num = (short)685506560;
				short num3 = num;
				num = (short)989593601;
				if (num != 0)
				{
				}
				num = (short)253886464;
				if (num != 0)
				{
				}
				this.cnvPerSecureIgnoreRxClearPacketData_A19310.HiddenStatic = value;
			}
		}

		// Token: 0x1700668B RID: 26251
		// (get) Token: 0x0600CC0E RID: 52238 RVA: 0x00BE33B0 File Offset: 0x00BE15B0
		// (set) Token: 0x0600CC0F RID: 52239 RVA: 0x00BE3464 File Offset: 0x00BE1664
		internal bool CnvPerSecureIgnoreRxClearPacketData_A19310_HiddenDynamic
		{
			get
			{
				short num = (short)1170965840;
				short num2 = num;
				num = (short)207717712;
				switch (num2 == num)
				{
				}
				num = (short)387121152;
				short num3 = num;
				num = (short)1971716096;
				if (num != 0)
				{
				}
				num = (short)1023016961;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310.HiddenDynamic;
			}
			set
			{
				short num = (short)371897392;
				short num2 = num;
				num = (short)2023339056;
				switch (num2 == num)
				{
				}
				num = (short)896270336;
				short num3 = num;
				num = (short)1472528384;
				if (num != 0)
				{
				}
				num = (short)335085569;
				if (num != 0)
				{
				}
				this.cnvPerSecureIgnoreRxClearPacketData_A19310.HiddenDynamic = value;
			}
		}

		// Token: 0x1700668C RID: 26252
		// (get) Token: 0x0600CC10 RID: 52240 RVA: 0x00BE3518 File Offset: 0x00BE1718
		public bool CnvPerSecureIgnoreRxClearPacketData_A19310_HasDiffs
		{
			get
			{
				short num = (short)707649737;
				short num2 = num;
				num = (short)426827977;
				switch (num2 == num)
				{
				}
				num = (short)1981612032;
				short num3 = num;
				num = (short)1322975233;
				if (num != 0)
				{
				}
				num = (short)1905917952;
				if (num != 0)
				{
				}
				return this.cnvPerSecureIgnoreRxClearPacketData_A19310._HasDiffs;
			}
		}

		// Token: 0x1700668D RID: 26253
		// (get) Token: 0x0600CC11 RID: 52241 RVA: 0x00BE35CC File Offset: 0x00BE17CC
		// (set) Token: 0x0600CC12 RID: 52242 RVA: 0x00BE3680 File Offset: 0x00BE1880
		public int CnvPerSecureSecureClearStrapping1_A9090Value
		{
			get
			{
				short num = (short)14479738;
				short num2 = num;
				num = (short)295956858;
				switch (num2 == num)
				{
				}
				num = (short)335806464;
				short num3 = num;
				num = (short)1720582145;
				if (num != 0)
				{
				}
				num = (short)2097545216;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.Value;
			}
			set
			{
				short num = (short)446758287;
				short num2 = num;
				num = (short)1705835919;
				switch (num2 == num)
				{
				}
				num = (short)586416128;
				short num3 = num;
				num = (short)191889409;
				if (num != 0)
				{
				}
				num = (short)1189806080;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping1_A9090.Value = value;
			}
		}

		// Token: 0x1700668E RID: 26254
		// (get) Token: 0x0600CC13 RID: 52243 RVA: 0x00BE3738 File Offset: 0x00BE1938
		// (set) Token: 0x0600CC14 RID: 52244 RVA: 0x00BE37EC File Offset: 0x00BE19EC
		public string CnvPerSecureSecureClearStrapping1_A9090_UIValue
		{
			get
			{
				short num = (short)1755888409;
				short num2 = num;
				num = (short)103136025;
				switch (num2 == num)
				{
				}
				num = (short)1372061696;
				short num3 = num;
				num = (short)1082720257;
				if (num != 0)
				{
				}
				num = (short)243138560;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.UIValue;
			}
			set
			{
				short num = (short)1425860693;
				short num2 = num;
				num = (short)592504917;
				switch (num2 == num)
				{
				}
				num = (short)1069219840;
				short num3 = num;
				num = (short)149749760;
				if (num != 0)
				{
				}
				num = (short)129892353;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping1_A9090.UIValue = value;
			}
		}

		// Token: 0x1700668F RID: 26255
		// (get) Token: 0x0600CC15 RID: 52245 RVA: 0x00BE38A0 File Offset: 0x00BE1AA0
		public global::AcpBusinessLayer.AcpListField CnvPerSecureSecureClearStrapping1_A9090
		{
			get
			{
				short num = (short)1874979086;
				short num2 = num;
				num = (short)724822286;
				switch (num2 == num)
				{
				}
				num = (short)1492320256;
				short num3 = num;
				num = (short)334364673;
				if (num != 0)
				{
				}
				num = (short)1279459328;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090;
			}
		}

		// Token: 0x17006690 RID: 26256
		// (get) Token: 0x0600CC16 RID: 52246 RVA: 0x00BE3950 File Offset: 0x00BE1B50
		// (set) Token: 0x0600CC17 RID: 52247 RVA: 0x00BE3A04 File Offset: 0x00BE1C04
		public bool CnvPerSecureSecureClearStrapping1_A9090_Applicable
		{
			get
			{
				short num = (short)1763216814;
				short num2 = num;
				num = (short)387026350;
				switch (num2 == num)
				{
				}
				num = (short)1832976384;
				short num3 = num;
				num = (short)1976893441;
				if (num != 0)
				{
				}
				num = (short)862584832;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.Applicable;
			}
			set
			{
				short num = (short)949682177;
				if (num != 0)
				{
				}
				num = (short)1814357753;
				short num2 = num;
				num = (short)585950969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2089943040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900478464;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping1_A9090.Applicable = value;
			}
		}

		// Token: 0x17006691 RID: 26257
		// (get) Token: 0x0600CC18 RID: 52248 RVA: 0x00BE3ABC File Offset: 0x00BE1CBC
		// (set) Token: 0x0600CC19 RID: 52249 RVA: 0x00BE3B70 File Offset: 0x00BE1D70
		public bool CnvPerSecureSecureClearStrapping1_A9090_Valid
		{
			get
			{
				short num = (short)766586666;
				short num2 = num;
				num = (short)61288234;
				switch (num2 == num)
				{
				}
				num = (short)1400242176;
				short num3 = num;
				num = (short)1347682305;
				if (num != 0)
				{
				}
				num = (short)664862720;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.Valid;
			}
			set
			{
				short num = (short)1207801148;
				short num2 = num;
				num = (short)260085052;
				switch (num2 == num)
				{
				}
				num = (short)584974336;
				short num3 = num;
				num = (short)926875649;
				if (num != 0)
				{
				}
				num = (short)738918400;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping1_A9090.Valid = value;
			}
		}

		// Token: 0x17006692 RID: 26258
		// (get) Token: 0x0600CC1A RID: 52250 RVA: 0x00BE3C24 File Offset: 0x00BE1E24
		// (set) Token: 0x0600CC1B RID: 52251 RVA: 0x00BE3CDC File Offset: 0x00BE1EDC
		public bool CnvPerSecureSecureClearStrapping1_A9090_Visible
		{
			get
			{
				short num = (short)112215683;
				short num2 = num;
				num = (short)460146307;
				switch (num2 == num)
				{
				}
				num = (short)432930816;
				short num3 = num;
				num = (short)1138032640;
				if (num != 0)
				{
				}
				num = (short)1979318273;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.Visible;
			}
			set
			{
				short num = (short)934686556;
				short num2 = num;
				num = (short)832581468;
				switch (num2 == num)
				{
				}
				num = (short)2023096320;
				short num3 = num;
				num = (short)1431633921;
				if (num != 0)
				{
				}
				num = (short)358088704;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping1_A9090.Visible = value;
			}
		}

		// Token: 0x17006693 RID: 26259
		// (get) Token: 0x0600CC1C RID: 52252 RVA: 0x00BE3D94 File Offset: 0x00BE1F94
		// (set) Token: 0x0600CC1D RID: 52253 RVA: 0x00BE3E4C File Offset: 0x00BE204C
		public bool CnvPerSecureSecureClearStrapping1_A9090_Editable
		{
			get
			{
				short num = (short)728048572;
				short num2 = num;
				num = (short)798303164;
				switch (num2 == num)
				{
				}
				num = (short)1851785216;
				short num3 = num;
				num = (short)153747456;
				if (num != 0)
				{
				}
				num = (short)928120833;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.Editable;
			}
			set
			{
				short num = (short)396004970;
				short num2 = num;
				num = (short)125537898;
				switch (num2 == num)
				{
				}
				num = (short)1440350208;
				short num3 = num;
				num = (short)231145473;
				if (num != 0)
				{
				}
				num = (short)1754726400;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping1_A9090.Editable = value;
			}
		}

		// Token: 0x17006694 RID: 26260
		// (get) Token: 0x0600CC1E RID: 52254 RVA: 0x00BE3F00 File Offset: 0x00BE2100
		internal string CnvPerSecureSecureClearStrapping1_A9090_UILabel
		{
			get
			{
				short num = (short)2075050942;
				short num2 = num;
				num = (short)1566229438;
				switch (num2 == num)
				{
				}
				num = (short)1124728832;
				short num3 = num;
				num = (short)117309441;
				if (num != 0)
				{
				}
				num = (short)1908277248;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.UIName;
			}
		}

		// Token: 0x17006695 RID: 26261
		// (get) Token: 0x0600CC1F RID: 52255 RVA: 0x00BE3FB8 File Offset: 0x00BE21B8
		// (set) Token: 0x0600CC20 RID: 52256 RVA: 0x00BE406C File Offset: 0x00BE226C
		internal bool CnvPerSecureSecureClearStrapping1_A9090_HiddenStatic
		{
			get
			{
				short num = (short)1101221038;
				short num2 = num;
				num = (short)2076003502;
				switch (num2 == num)
				{
				}
				num = (short)1581645824;
				short num3 = num;
				num = (short)339935233;
				if (num != 0)
				{
				}
				num = (short)833290240;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.HiddenStatic;
			}
			set
			{
				short num = (short)1994577798;
				short num2 = num;
				num = (short)1643435910;
				switch (num2 == num)
				{
				}
				num = (short)1050869760;
				short num3 = num;
				num = (short)1463287809;
				if (num != 0)
				{
				}
				num = (short)1613758464;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping1_A9090.HiddenStatic = value;
			}
		}

		// Token: 0x17006696 RID: 26262
		// (get) Token: 0x0600CC21 RID: 52257 RVA: 0x00BE4120 File Offset: 0x00BE2320
		// (set) Token: 0x0600CC22 RID: 52258 RVA: 0x00BE41D8 File Offset: 0x00BE23D8
		internal bool CnvPerSecureSecureClearStrapping1_A9090_HiddenDynamic
		{
			get
			{
				short num = (short)683427755;
				short num2 = num;
				num = (short)781338539;
				switch (num2 == num)
				{
				}
				num = (short)1165754368;
				short num3 = num;
				num = (short)1808793601;
				if (num != 0)
				{
				}
				num = (short)1202520064;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090.HiddenDynamic;
			}
			set
			{
				short num = (short)246543705;
				short num2 = num;
				num = (short)1531245913;
				switch (num2 == num)
				{
				}
				num = (short)224919552;
				short num3 = num;
				num = (short)114294784;
				if (num != 0)
				{
				}
				num = (short)1988689921;
				if (num != 0)
				{
				}
				this.cnvPerSecureSecureClearStrapping1_A9090.HiddenDynamic = value;
			}
		}

		// Token: 0x17006697 RID: 26263
		// (get) Token: 0x0600CC23 RID: 52259 RVA: 0x00BE428C File Offset: 0x00BE248C
		public bool CnvPerSecureSecureClearStrapping1_A9090_HasDiffs
		{
			get
			{
				short num = (short)1284937323;
				short num2 = num;
				num = (short)698259051;
				switch (num2 == num)
				{
				}
				num = (short)1322450944;
				short num3 = num;
				num = (short)1445789696;
				if (num != 0)
				{
				}
				num = (short)367329281;
				if (num != 0)
				{
				}
				return this.cnvPerSecureSecureClearStrapping1_A9090._HasDiffs;
			}
		}

		// Token: 0x17006698 RID: 26264
		// (get) Token: 0x0600CC24 RID: 52260 RVA: 0x00BE4340 File Offset: 0x00BE2540
		// (set) Token: 0x0600CC25 RID: 52261 RVA: 0x00BE43F4 File Offset: 0x00BE25F4
		public bool CnvPerSecureASTROOTAR_A7493Value
		{
			get
			{
				short num = (short)998440278;
				short num2 = num;
				num = (short)1779957078;
				switch (num2 == num)
				{
				}
				num = (short)1356595200;
				short num3 = num;
				num = (short)526581761;
				if (num != 0)
				{
				}
				num = (short)1057882112;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.Value;
			}
			set
			{
				short num = (short)823763333;
				short num2 = num;
				num = (short)85827973;
				switch (num2 == num)
				{
				}
				num = (short)355205120;
				short num3 = num;
				num = (short)1233387520;
				if (num != 0)
				{
				}
				num = (short)915931137;
				if (num != 0)
				{
				}
				this.cnvPerSecureASTROOTAR_A7493.Value = value;
			}
		}

		// Token: 0x17006699 RID: 26265
		// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x00BE44AC File Offset: 0x00BE26AC
		public global::AcpBusinessLayer.AcpField<bool> CnvPerSecureASTROOTAR_A7493
		{
			get
			{
				short num = (short)1933815928;
				short num2 = num;
				num = (short)1681436792;
				switch (num2 == num)
				{
				}
				num = (short)1063649280;
				short num3 = num;
				num = (short)2122711040;
				if (num != 0)
				{
				}
				num = (short)1677131777;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493;
			}
		}

		// Token: 0x1700669A RID: 26266
		// (get) Token: 0x0600CC27 RID: 52263 RVA: 0x00BE455C File Offset: 0x00BE275C
		// (set) Token: 0x0600CC28 RID: 52264 RVA: 0x00BE4614 File Offset: 0x00BE2814
		public bool CnvPerSecureASTROOTAR_A7493_UIValue
		{
			get
			{
				short num = (short)1611887715;
				short num2 = num;
				num = (short)1517057123;
				switch (num2 == num)
				{
				}
				num = (short)1726808064;
				short num3 = num;
				num = (short)1381695488;
				if (num != 0)
				{
				}
				num = (short)1589510145;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.Value;
			}
			set
			{
				short num = (short)690494720;
				short num2 = num;
				num = (short)533929216;
				switch (num2 == num)
				{
				}
				num = (short)2062548992;
				short num3 = num;
				num = (short)1445462017;
				if (num != 0)
				{
				}
				num = (short)1160445952;
				if (num != 0)
				{
				}
				this.cnvPerSecureASTROOTAR_A7493.Value = value;
			}
		}

		// Token: 0x1700669B RID: 26267
		// (get) Token: 0x0600CC29 RID: 52265 RVA: 0x00BE46CC File Offset: 0x00BE28CC
		// (set) Token: 0x0600CC2A RID: 52266 RVA: 0x00BE4780 File Offset: 0x00BE2980
		public bool CnvPerSecureASTROOTAR_A7493_Applicable
		{
			get
			{
				short num = (short)1931538315;
				short num2 = num;
				num = (short)1115484043;
				switch (num2 == num)
				{
				}
				num = (short)1180565504;
				short num3 = num;
				num = (short)584450048;
				if (num != 0)
				{
				}
				num = (short)1661992961;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.Applicable;
			}
			set
			{
				short num = (short)2030451319;
				short num2 = num;
				num = (short)769669751;
				switch (num2 == num)
				{
				}
				num = (short)1967259648;
				short num3 = num;
				num = (short)459079681;
				if (num != 0)
				{
				}
				num = (short)2035482624;
				if (num != 0)
				{
				}
				this.cnvPerSecureASTROOTAR_A7493.Applicable = value;
			}
		}

		// Token: 0x1700669C RID: 26268
		// (get) Token: 0x0600CC2B RID: 52267 RVA: 0x00BE4834 File Offset: 0x00BE2A34
		// (set) Token: 0x0600CC2C RID: 52268 RVA: 0x00BE48E8 File Offset: 0x00BE2AE8
		public bool CnvPerSecureASTROOTAR_A7493_Valid
		{
			get
			{
				short num = (short)1780458908;
				short num2 = num;
				num = (short)1747035548;
				switch (num2 == num)
				{
				}
				num = (short)1370685440;
				short num3 = num;
				num = (short)1454374913;
				if (num != 0)
				{
				}
				num = (short)384106496;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.Valid;
			}
			set
			{
				short num = (short)796186451;
				short num2 = num;
				num = (short)1221187411;
				switch (num2 == num)
				{
				}
				num = (short)1420165120;
				short num3 = num;
				num = (short)540737537;
				if (num != 0)
				{
				}
				num = (short)1672216576;
				if (num != 0)
				{
				}
				this.cnvPerSecureASTROOTAR_A7493.Valid = value;
			}
		}

		// Token: 0x1700669D RID: 26269
		// (get) Token: 0x0600CC2D RID: 52269 RVA: 0x00BE49A0 File Offset: 0x00BE2BA0
		// (set) Token: 0x0600CC2E RID: 52270 RVA: 0x00BE4A58 File Offset: 0x00BE2C58
		public bool CnvPerSecureASTROOTAR_A7493_Visible
		{
			get
			{
				short num = (short)607262235;
				short num2 = num;
				num = (short)1259214363;
				switch (num2 == num)
				{
				}
				num = (short)1919025152;
				short num3 = num;
				num = (short)370606081;
				if (num != 0)
				{
				}
				num = (short)1269039104;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.Visible;
			}
			set
			{
				short num = (short)1431556566;
				short num2 = num;
				num = (short)293130710;
				switch (num2 == num)
				{
				}
				num = (short)1857028096;
				short num3 = num;
				num = (short)2044067841;
				if (num != 0)
				{
				}
				num = (short)441974784;
				if (num != 0)
				{
				}
				this.cnvPerSecureASTROOTAR_A7493.Visible = value;
			}
		}

		// Token: 0x1700669E RID: 26270
		// (get) Token: 0x0600CC2F RID: 52271 RVA: 0x00BE4B10 File Offset: 0x00BE2D10
		// (set) Token: 0x0600CC30 RID: 52272 RVA: 0x00BE4BC4 File Offset: 0x00BE2DC4
		public bool CnvPerSecureASTROOTAR_A7493_Editable
		{
			get
			{
				short num = (short)167135931;
				short num2 = num;
				num = (short)348474043;
				switch (num2 == num)
				{
				}
				num = (short)344195072;
				short num3 = num;
				num = (short)1760362497;
				if (num != 0)
				{
				}
				num = (short)892010496;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.Editable;
			}
			set
			{
				short num = (short)1015200454;
				short num2 = num;
				num = (short)806730438;
				switch (num2 == num)
				{
				}
				num = (short)850526208;
				short num3 = num;
				num = (short)1135869952;
				if (num != 0)
				{
				}
				num = (short)2081882113;
				if (num != 0)
				{
				}
				this.cnvPerSecureASTROOTAR_A7493.Editable = value;
			}
		}

		// Token: 0x1700669F RID: 26271
		// (get) Token: 0x0600CC31 RID: 52273 RVA: 0x00BE4C78 File Offset: 0x00BE2E78
		internal string CnvPerSecureASTROOTAR_A7493_UILabel
		{
			get
			{
				short num = (short)151498553;
				short num2 = num;
				num = (short)209563449;
				switch (num2 == num)
				{
				}
				num = (short)1727594496;
				short num3 = num;
				num = (short)1484390401;
				if (num != 0)
				{
				}
				num = (short)2097872896;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.UIName;
			}
		}

		// Token: 0x170066A0 RID: 26272
		// (get) Token: 0x0600CC32 RID: 52274 RVA: 0x00BE4D30 File Offset: 0x00BE2F30
		// (set) Token: 0x0600CC33 RID: 52275 RVA: 0x00BE4DE0 File Offset: 0x00BE2FE0
		internal bool CnvPerSecureASTROOTAR_A7493_HiddenStatic
		{
			get
			{
				short num = (short)724639465;
				short num2 = num;
				num = (short)1146101481;
				switch (num2 == num)
				{
				}
				num = (short)944504832;
				short num3 = num;
				num = (short)1255211009;
				if (num != 0)
				{
				}
				num = (short)34799616;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.HiddenStatic;
			}
			set
			{
				short num = (short)1296629761;
				if (num != 0)
				{
				}
				num = (short)2024987905;
				short num2 = num;
				num = (short)1704451329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075773440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2086076416;
				if (num != 0)
				{
				}
				this.cnvPerSecureASTROOTAR_A7493.HiddenStatic = value;
			}
		}

		// Token: 0x170066A1 RID: 26273
		// (get) Token: 0x0600CC34 RID: 52276 RVA: 0x00BE4E98 File Offset: 0x00BE3098
		// (set) Token: 0x0600CC35 RID: 52277 RVA: 0x00BE4F4C File Offset: 0x00BE314C
		internal bool CnvPerSecureASTROOTAR_A7493_HiddenDynamic
		{
			get
			{
				short num = (short)117670698;
				short num2 = num;
				num = (short)1664058154;
				switch (num2 == num)
				{
				}
				num = (short)1873149953;
				if (num != 0)
				{
				}
				num = (short)779747328;
				short num3 = num;
				num = (short)841809920;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493.HiddenDynamic;
			}
			set
			{
				short num = (short)428164218;
				short num2 = num;
				num = (short)1123370106;
				switch (num2 == num)
				{
				}
				num = (short)1245315072;
				if (num != 0)
				{
				}
				num = (short)1780350976;
				short num3 = num;
				num = (short)1505165313;
				if (num != 0)
				{
				}
				this.cnvPerSecureASTROOTAR_A7493.HiddenDynamic = value;
			}
		}

		// Token: 0x170066A2 RID: 26274
		// (get) Token: 0x0600CC36 RID: 52278 RVA: 0x00BE5004 File Offset: 0x00BE3204
		public bool CnvPerSecureASTROOTAR_A7493_HasDiffs
		{
			get
			{
				short num = (short)345562964;
				short num2 = num;
				num = (short)1522589524;
				switch (num2 == num)
				{
				}
				num = (short)2114519041;
				if (num != 0)
				{
				}
				num = (short)83689472;
				short num3 = num;
				num = (short)1872756736;
				if (num != 0)
				{
				}
				return this.cnvPerSecureASTROOTAR_A7493._HasDiffs;
			}
		}

		// Token: 0x170066A3 RID: 26275
		// (get) Token: 0x0600CC37 RID: 52279 RVA: 0x00BE50B8 File Offset: 0x00BE32B8
		// (set) Token: 0x0600CC38 RID: 52280 RVA: 0x00BE516C File Offset: 0x00BE336C
		public bool CnvPerIgnoreRxClearVoice_A41617Value
		{
			get
			{
				short num = (short)1993068267;
				short num2 = num;
				num = (short)586272491;
				switch (num2 == num)
				{
				}
				num = (short)266993665;
				if (num != 0)
				{
				}
				num = (short)488112128;
				short num3 = num;
				num = (short)1774977024;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.Value;
			}
			set
			{
				short num = (short)182607902;
				short num2 = num;
				num = (short)652566558;
				switch (num2 == num)
				{
				}
				num = (short)1080492033;
				if (num != 0)
				{
				}
				num = (short)988151808;
				short num3 = num;
				num = (short)1822883840;
				if (num != 0)
				{
				}
				this.cnvPerIgnoreRxClearVoice_A41617.Value = value;
			}
		}

		// Token: 0x170066A4 RID: 26276
		// (get) Token: 0x0600CC39 RID: 52281 RVA: 0x00BE5224 File Offset: 0x00BE3424
		public global::AcpBusinessLayer.AcpField<bool> CnvPerIgnoreRxClearVoice_A41617
		{
			get
			{
				short num = (short)542901548;
				short num2 = num;
				num = (short)1340146988;
				switch (num2 == num)
				{
				}
				num = (short)178388993;
				if (num != 0)
				{
				}
				num = (short)2017394688;
				short num3 = num;
				num = (short)1711734784;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617;
			}
		}

		// Token: 0x170066A5 RID: 26277
		// (get) Token: 0x0600CC3A RID: 52282 RVA: 0x00BE52D4 File Offset: 0x00BE34D4
		// (set) Token: 0x0600CC3B RID: 52283 RVA: 0x00BE5388 File Offset: 0x00BE3588
		public bool CnvPerIgnoreRxClearVoice_A41617_UIValue
		{
			get
			{
				short num = (short)1997131936;
				short num2 = num;
				num = (short)1888538784;
				switch (num2 == num)
				{
				}
				num = (short)527630336;
				if (num != 0)
				{
				}
				num = (short)1614086144;
				short num3 = num;
				num = (short)1147011073;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.Value;
			}
			set
			{
				short num = (short)866058241;
				if (num != 0)
				{
				}
				num = (short)1071201477;
				short num2 = num;
				num = (short)1951415493;
				switch (num2 == num)
				{
				}
				num = (short)1666121728;
				short num3 = num;
				num = (short)1510146048;
				if (num != 0)
				{
				}
				this.cnvPerIgnoreRxClearVoice_A41617.Value = value;
			}
		}

		// Token: 0x170066A6 RID: 26278
		// (get) Token: 0x0600CC3C RID: 52284 RVA: 0x00BE543C File Offset: 0x00BE363C
		// (set) Token: 0x0600CC3D RID: 52285 RVA: 0x00BE54F0 File Offset: 0x00BE36F0
		public bool CnvPerIgnoreRxClearVoice_A41617_Applicable
		{
			get
			{
				short num = (short)2059473560;
				short num2 = num;
				num = (short)2085360280;
				switch (num2 == num)
				{
				}
				num = (short)1148452864;
				if (num != 0)
				{
				}
				num = (short)1505558528;
				short num3 = num;
				num = (short)271974401;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.Applicable;
			}
			set
			{
				short num = (short)1614361031;
				short num2 = num;
				num = (short)2057449927;
				switch (num2 == num)
				{
				}
				num = (short)1864171521;
				if (num != 0)
				{
				}
				num = (short)1736048640;
				short num3 = num;
				num = (short)1042612224;
				if (num != 0)
				{
				}
				this.cnvPerIgnoreRxClearVoice_A41617.Applicable = value;
			}
		}

		// Token: 0x170066A7 RID: 26279
		// (get) Token: 0x0600CC3E RID: 52286 RVA: 0x00BE55A8 File Offset: 0x00BE37A8
		// (set) Token: 0x0600CC3F RID: 52287 RVA: 0x00BE565C File Offset: 0x00BE385C
		public bool CnvPerIgnoreRxClearVoice_A41617_Valid
		{
			get
			{
				short num = (short)787847663;
				short num2 = num;
				num = (short)944740847;
				switch (num2 == num)
				{
				}
				num = (short)1911226369;
				if (num != 0)
				{
				}
				num = (short)32047104;
				short num3 = num;
				num = (short)2055143424;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.Valid;
			}
			set
			{
				short num = (short)303925387;
				short num2 = num;
				num = (short)1346865291;
				switch (num2 == num)
				{
				}
				num = (short)1019150336;
				if (num != 0)
				{
				}
				num = (short)403570688;
				short num3 = num;
				num = (short)1043070977;
				if (num != 0)
				{
				}
				this.cnvPerIgnoreRxClearVoice_A41617.Valid = value;
			}
		}

		// Token: 0x170066A8 RID: 26280
		// (get) Token: 0x0600CC40 RID: 52288 RVA: 0x00BE5710 File Offset: 0x00BE3910
		// (set) Token: 0x0600CC41 RID: 52289 RVA: 0x00BE57C8 File Offset: 0x00BE39C8
		public bool CnvPerIgnoreRxClearVoice_A41617_Visible
		{
			get
			{
				short num = (short)135794240;
				short num2 = num;
				num = (short)1673203264;
				switch (num2 == num)
				{
				}
				num = (short)1556152321;
				if (num != 0)
				{
				}
				num = (short)690028544;
				short num3 = num;
				num = (short)175767552;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.Visible;
			}
			set
			{
				short num = (short)1952589641;
				short num2 = num;
				num = (short)670181193;
				switch (num2 == num)
				{
				}
				num = (short)423952385;
				if (num != 0)
				{
				}
				num = (short)1324089344;
				short num3 = num;
				num = (short)218759168;
				if (num != 0)
				{
				}
				this.cnvPerIgnoreRxClearVoice_A41617.Visible = value;
			}
		}

		// Token: 0x170066A9 RID: 26281
		// (get) Token: 0x0600CC42 RID: 52290 RVA: 0x00BE5880 File Offset: 0x00BE3A80
		// (set) Token: 0x0600CC43 RID: 52291 RVA: 0x00BE5938 File Offset: 0x00BE3B38
		public bool CnvPerIgnoreRxClearVoice_A41617_Editable
		{
			get
			{
				short num = (short)750989500;
				short num2 = num;
				num = (short)1888104636;
				switch (num2 == num)
				{
				}
				num = (short)1219624961;
				if (num != 0)
				{
				}
				num = (short)694550528;
				short num3 = num;
				num = (short)449708032;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.Editable;
			}
			set
			{
				short num = (short)1872166913;
				if (num != 0)
				{
				}
				num = (short)1815019290;
				short num2 = num;
				num = (short)2114191130;
				switch (num2 == num)
				{
				}
				num = (short)945815552;
				short num3 = num;
				num = (short)850526208;
				if (num != 0)
				{
				}
				this.cnvPerIgnoreRxClearVoice_A41617.Editable = value;
			}
		}

		// Token: 0x170066AA RID: 26282
		// (get) Token: 0x0600CC44 RID: 52292 RVA: 0x00BE59EC File Offset: 0x00BE3BEC
		internal string CnvPerIgnoreRxClearVoice_A41617_UILabel
		{
			get
			{
				short num = (short)282211822;
				short num2 = num;
				num = (short)1815950830;
				switch (num2 == num)
				{
				}
				num = (short)2013331457;
				if (num != 0)
				{
				}
				num = (short)1228603392;
				short num3 = num;
				num = (short)784072704;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.UIName;
			}
		}

		// Token: 0x170066AB RID: 26283
		// (get) Token: 0x0600CC45 RID: 52293 RVA: 0x00BE5AA0 File Offset: 0x00BE3CA0
		// (set) Token: 0x0600CC46 RID: 52294 RVA: 0x00BE5B58 File Offset: 0x00BE3D58
		internal bool CnvPerIgnoreRxClearVoice_A41617_HiddenStatic
		{
			get
			{
				short num = (short)1153691365;
				short num2 = num;
				num = (short)1429597925;
				switch (num2 == num)
				{
				}
				num = (short)1446379520;
				if (num != 0)
				{
				}
				num = (short)1695023104;
				short num3 = num;
				num = (short)848560129;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.HiddenStatic;
			}
			set
			{
				short num = (short)989574873;
				short num2 = num;
				num = (short)1520088793;
				switch (num2 == num)
				{
				}
				num = (short)239665153;
				if (num != 0)
				{
				}
				num = (short)2069430272;
				short num3 = num;
				num = (short)698286080;
				if (num != 0)
				{
				}
				this.cnvPerIgnoreRxClearVoice_A41617.HiddenStatic = value;
			}
		}

		// Token: 0x170066AC RID: 26284
		// (get) Token: 0x0600CC47 RID: 52295 RVA: 0x00BE5C10 File Offset: 0x00BE3E10
		// (set) Token: 0x0600CC48 RID: 52296 RVA: 0x00BE5CC4 File Offset: 0x00BE3EC4
		internal bool CnvPerIgnoreRxClearVoice_A41617_HiddenDynamic
		{
			get
			{
				short num = (short)1187462980;
				short num2 = num;
				num = (short)1715945284;
				switch (num2 == num)
				{
				}
				num = (short)1170538496;
				if (num != 0)
				{
				}
				num = (short)2100559872;
				short num3 = num;
				num = (short)640286721;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617.HiddenDynamic;
			}
			set
			{
				short num = (short)1212236033;
				short num2 = num;
				num = (short)907362561;
				switch (num2 == num)
				{
				}
				num = (short)715522049;
				if (num != 0)
				{
				}
				num = (short)45547520;
				short num3 = num;
				num = (short)1059520512;
				if (num != 0)
				{
				}
				this.cnvPerIgnoreRxClearVoice_A41617.HiddenDynamic = value;
			}
		}

		// Token: 0x170066AD RID: 26285
		// (get) Token: 0x0600CC49 RID: 52297 RVA: 0x00BE5D7C File Offset: 0x00BE3F7C
		public bool CnvPerIgnoreRxClearVoice_A41617_HasDiffs
		{
			get
			{
				short num = (short)90147115;
				short num2 = num;
				num = (short)169380139;
				switch (num2 == num)
				{
				}
				num = (short)1727922176;
				if (num != 0)
				{
				}
				num = (short)1166671872;
				short num3 = num;
				num = (short)930676737;
				if (num != 0)
				{
				}
				return this.cnvPerIgnoreRxClearVoice_A41617._HasDiffs;
			}
		}

		// Token: 0x170066AE RID: 26286
		// (get) Token: 0x0600CC4A RID: 52298 RVA: 0x00BE5E30 File Offset: 0x00BE4030
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1406639640;
				short num2 = num;
				num = (short)793812504;
				switch (num2 == num)
				{
				}
				num = (short)2057306113;
				if (num != 0)
				{
				}
				num = (short)1751384064;
				short num3 = num;
				num = (short)1001259008;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x170066AF RID: 26287
		// (get) Token: 0x0600CC4B RID: 52299 RVA: 0x00BE5EF0 File Offset: 0x00BE40F0
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile RefsecureKMFProfile
		{
			get
			{
				short num = (short)412940490;
				short num2 = num;
				num = (short)1754069194;
				switch (num2 == num)
				{
				}
				num = (short)2085224448;
				if (num != 0)
				{
				}
				num = (short)1523318784;
				short num3 = num;
				num = (short)909836289;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2055)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			}
		}

		// Token: 0x170066B0 RID: 26288
		// (get) Token: 0x0600CC4C RID: 52300 RVA: 0x00BE5FB0 File Offset: 0x00BE41B0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)657829526;
				short num2 = num;
				num = (short)1700245142;
				switch (num2 == num)
				{
				}
				num = (short)859766785;
				if (num != 0)
				{
				}
				num = (short)1982398464;
				short num3 = num;
				num = (short)1137442816;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170066B1 RID: 26289
		// (get) Token: 0x0600CC4D RID: 52301 RVA: 0x00BE6070 File Offset: 0x00BE4270
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)551282705;
				short num2 = num;
				num = (short)1523378193;
				switch (num2 == num)
				{
				}
				num = (short)872546305;
				if (num != 0)
				{
				}
				num = (short)188350464;
				short num3 = num;
				num = (short)6160384;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x170066B2 RID: 26290
		// (get) Token: 0x0600CC4E RID: 52302 RVA: 0x00BE6130 File Offset: 0x00BE4330
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide RefDataWide
		{
			get
			{
				short num = (short)1264586661;
				short num2 = num;
				num = (short)375459749;
				switch (num2 == num)
				{
				}
				num = (short)1085407233;
				if (num != 0)
				{
				}
				num = (short)711327744;
				short num3 = num;
				num = (short)1677787136;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			}
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x00BE61F0 File Offset: 0x00BE43F0
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
					num2 = (short)677910798;
					short num3 = num2;
					num2 = (short)1310333198;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_134;
					default:
						num2 = (short)1892941825;
						if (num2 != 0)
						{
						}
						num2 = (short)1016332288;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1268645889;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					goto IL_134;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)395837444;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)642711552;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_134:
				num2 = (short)1155858432;
				short num4 = num2;
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1519779842;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1181679619;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040064DC RID: 25820
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSecureDESXLTxDefault_A7831;

		// Token: 0x040064DD RID: 25821
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerSecureEchoMuteTimems_A7919;

		// Token: 0x040064DE RID: 25822
		private global::AcpBusinessLayer.AcpListField cnvPerSecureKeyID_A8361;

		// Token: 0x040064DF RID: 25823
		private global::AcpBusinessLayer.AcpRecRefField cnvPerSecureKeySelection1_A8368;

		// Token: 0x040064E0 RID: 25824
		private global::AcpBusinessLayer.AcpRecRefField cnvPerSecureKeySelection2_A8369;

		// Token: 0x040064E1 RID: 25825
		private global::AcpBusinessLayer.AcpListField cnvPerSecureKeyStrapping_A8370;

		// Token: 0x040064E2 RID: 25826
		private global::AcpBusinessLayer.AcpRecRefField cnvPerSecureKMFProfileIndex_A8381;

		// Token: 0x040064E3 RID: 25827
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSecureBroadbandASTROOTAR;

		// Token: 0x040064E4 RID: 25828
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSecureOTARTx_A8675;

		// Token: 0x040064E5 RID: 25829
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSecureProperCodeDetect_A8762;

		// Token: 0x040064E6 RID: 25830
		private global::AcpBusinessLayer.AcpListField cnvPerSecureScanHoldoffStrapping_A9050;

		// Token: 0x040064E7 RID: 25831
		private global::AcpBusinessLayer.AcpListField cnvPerSecureScanSelect_A9056;

		// Token: 0x040064E8 RID: 25832
		private global::AcpBusinessLayer.AcpListField cnvPerSecureSecureVoiceSignalType_A9086;

		// Token: 0x040064E9 RID: 25833
		private global::AcpBusinessLayer.AcpListField cnvPerSecureSecureClearStrapping2_A9091;

		// Token: 0x040064EA RID: 25834
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerSecureXLDelayFollowingKeyID_A9680;

		// Token: 0x040064EB RID: 25835
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSecureXLTransmit_A9683;

		// Token: 0x040064EC RID: 25836
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSecureIgnoreRxClearPacketData_A19310;

		// Token: 0x040064ED RID: 25837
		private global::AcpBusinessLayer.AcpListField cnvPerSecureSecureClearStrapping1_A9090;

		// Token: 0x040064EE RID: 25838
		private global::AcpBusinessLayer.AcpField<bool> cnvPerSecureASTROOTAR_A7493;

		// Token: 0x040064EF RID: 25839
		private global::AcpBusinessLayer.AcpField<bool> cnvPerIgnoreRxClearVoice_A41617;
	}
}
