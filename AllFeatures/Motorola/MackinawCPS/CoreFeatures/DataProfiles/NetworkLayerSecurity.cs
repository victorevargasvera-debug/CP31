using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000512 RID: 1298
	[global::System.Serializable]
	public class NetworkLayerSecurity : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AFC0 RID: 44992 RVA: 0x00A328F0 File Offset: 0x00A30AF0
		public NetworkLayerSecurity(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600AFC1 RID: 44993 RVA: 0x00A3290C File Offset: 0x00A30B0C
		protected NetworkLayerSecurity(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AFC2 RID: 44994 RVA: 0x00A32924 File Offset: 0x00A30B24
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1778692626;
			short num2 = num;
			num = (short)1103278610;
			switch (num2 == num)
			{
			}
			num = (short)597360640;
			if (num != 0)
			{
			}
			num = (short)405143553;
			if (num != 0)
			{
			}
			num = (short)54919168;
			short num3 = num;
			this.dataProfNLSKeySele_A36410 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖韘韚軜铞蓠髢뛤苦藨軪달껮싰엲쇴웶째", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25KEYSELECTION, null, null, true, false);
			this.dataProfNLSKeySele_A36410.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfNLSKeySele_A36410.DataTransferOrder = 49;
			this.dataProfNLSEncGatewayAddr_A36412 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖韘韚軜髞迠胢ꋤ蛦鷨軪髬軮裰닲釴鏶诸ꓺ볼쳾㜀㜂㐄㔆", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25ENCRYPTEDGATEWAYADDRESS);
			this.dataProfNLSEncGatewayAddr_A36412.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfNLSEncGatewayAddr_A36412.DataTransferOrder = 43;
			this.dataProfNLSAllowRxClrPackData_A36414 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖韘韚軜點跠迢諤郦믨鏪껬菮菰ꏲ铴银鋸뿺鳼课怀専䐄㐆㼈㼊㰌㬎", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25ALLOWRXCLEARPACKETDATA);
			this.dataProfNLSAllowRxClrPackData_A36414.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfNLSAllowRxClrPackData_A36414.DataTransferOrder = 44;
			this.dataProfNLSSecClrStrp_A36415 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖韘韚軜賞蓠胢ꛤ详鯨룪駬鷮臰곲듴쓶쿸쿺쳼쫾", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25SECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfNLSSecClrStrp_A36415LovStrs);
			this.dataProfNLSSecClrStrp_A36415.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfNLSSecClrStrp_A36415.DataTransferOrder = 41;
			this.dataProfNLSSecClrStrp_A36415.EvaluateRecRefs = true;
			this.dataProfNLSKMFProfSele_A36419 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖韘韚軜铞고ꗢ뗤闦蛨跪뻬諮鷰雲ꫴ뛶쫸췺짼컾㠀", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25ASTROOTARPROFILEINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false, new string[]
			{
				global::CommonResources.AcgResources.ID_PACKETDATAAPCO25KMFPROFILESELECTION
			});
			this.dataProfNLSKMFProfSele_A36419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfNLSKMFProfSele_A36419.DataTransferOrder = 42;
			this.dataProfNLSKMFProfSele_A36419.EvaluateRecRefs = true;
			this.dataProfVPNGatewayIPAddress_A42079 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖还诚鏜飞胠韢胤郦裨鋪ꓬ뿮냰韲釴藶鳸裺軼ꃾ䀀㜂㜄㜆㸈㈊", a_), global::CommonResources.AcgResources.ID_VPNVPNGATEWAYIPADDRESS);
			this.dataProfVPNGatewayIPAddress_A42079.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfVPNGatewayIPAddress_A42079.DataTransferOrder = 57;
			this.dataProfVPNSecClrStrp_A42120 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖还诚鏜賞蓠胢ꛤ详鯨룪駬鷮臰곲듴쏶쯸쫺쿼쿾", a_), global::CommonResources.AcgResources.ID_VPNVPNSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfVPNSecClrStrp_A42120LovStrs);
			this.dataProfVPNSecClrStrp_A42120.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfVPNSecClrStrp_A42120.DataTransferOrder = 58;
			this.dataProfVPNMessageRetransmissionTime_A42209 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖还诚鏜鋞蓠郢雤蛦軨軪뿬諮藰臲铴駶諸雺铼賾爀樂樄椆崈戊怌樎丐划℔┖⬘⬚␜", a_), global::CommonResources.AcgResources.ID_VPNVPNMESSAGERETRANSMISSIONTIMESEC, 10, 60, null, null, 0, 1);
			this.dataProfVPNMessageRetransmissionTime_A42209.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataProfVPNMessageRetransmissionTime_A42209.DataTransferOrder = 60;
			this.dataProfVPNMessageRetransmissionTime_A42209.ShowHexValue = false;
			this.dataProfVPNMessageRetransmissionAttempts_A42210 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖还诚鏜鋞蓠郢雤蛦軨軪뿬諮藰臲铴駶諸雺铼賾爀樂樄椆䠈缊礌樎簐挒愔搖䘘娚⤜ⴞጠሢᔤ", a_), global::CommonResources.AcgResources.ID_VPNVPNMESSAGERETRANSMISSIONATTEMPTS, 2, 10, null, null, 0, 1);
			this.dataProfVPNMessageRetransmissionAttempts_A42210.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataProfVPNMessageRetransmissionAttempts_A42210.DataTransferOrder = 61;
			this.dataProfVPNMessageRetransmissionAttempts_A42210.ShowHexValue = false;
			this.dataProfVPNDeadPeerDetectionInterval_A42211 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖还诚鏜鯞蓠苢臤럦賨軪鿬꯮铰蟲郴银跸鋺鋼釾䠀洂焄戆笈紊氌挎丐划℔┖⬘⨚Ⱌ", a_), global::CommonResources.AcgResources.ID_VPNVPNDEADPEERDETECTIONINTERVALMIN, 5, 60, null, null, 0, 1);
			this.dataProfVPNDeadPeerDetectionInterval_A42211.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataProfVPNDeadPeerDetectionInterval_A42211.DataTransferOrder = 63;
			this.dataProfVPNDeadPeerDetectionInterval_A42211.ShowHexValue = false;
			this.dataProfVPNRekeyMargin_A42212 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖还诚鏜跞蓠裢胤黦ꓨ諪鿬裮飰鷲ꫴ뛶췸짺쿼컾㌀", a_), global::CommonResources.AcgResources.ID_VPNVPNREKEYMARGINMIN, 1, 9, null, null, 0, 1);
			this.dataProfVPNRekeyMargin_A42212.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataProfVPNRekeyMargin_A42212.DataTransferOrder = 64;
			this.dataProfVPNRekeyMargin_A42212.ShowHexValue = false;
			this.dataProfVPNRekeyAttempts_A42213 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖还诚鏜跞蓠裢胤黦꣨鿪駬諮鳰菲致蓶꛸뫺짼췾㌀㈂㘄", a_), global::CommonResources.AcgResources.ID_VPNVPNREKEYATTEMPTS, 1, 10, null, null, 0, 1);
			this.dataProfVPNRekeyAttempts_A42213.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataProfVPNRekeyAttempts_A42213.DataTransferOrder = 65;
			this.dataProfVPNRekeyAttempts_A42213.ShowHexValue = false;
			this.dataProfVPNKeySelection_42280 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎臐ꇒ뫔뇖还诚鏜铞蓠髢뛤苦藨軪軬鯮飰鳲鯴ꣶ췸짺쿼쟾㄀", a_), global::CommonResources.AcgResources.ID_VPNVPNKEYSELECTION, null, null, true, false);
			this.dataProfVPNKeySelection_42280.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfVPNKeySelection_42280.DataTransferOrder = 66;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟈껊만룎뻐ꇒ뻔闘뫚ꓜ뫞鏠쏢뛤苦諨黪鿬蛮藰諲", a_);
			base.Id = 10600;
			base.UIName = global::CommonResources.AcgResources.ID_NETWORKLAYERSECURITY;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x00A32D98 File Offset: 0x00A30F98
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1004077070;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距돟蟡蟣ꗥ蓧飩뿫髭苯英꯳럵쯷쳹죻쿽㗿", a_)))
					{
						num = (short)1206910983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92D;
				case 1:
					goto IL_20B;
				case 2:
					if (producerFields != null)
					{
						num = (short)111411218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AAC;
				case 3:
					this.dataProfNLSKMFProfSele_A36419 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距ꯟ꿡ꋣ뛥髧藩諫뷭闯黱釳꧵맷짹쫻쫽ㇿ㬁", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25ASTROOTARPROFILEINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false, new string[]
					{
						global::CommonResources.AcgResources.ID_PACKETDATAAPCO25KMFPROFILESELECTION
					});
					this.dataProfNLSKMFProfSele_A36419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfNLSKMFProfSele_A36419.DataTransferOrder = 42;
					this.dataProfNLSKMFProfSele_A36419.EvaluateRecRefs = true;
					num = (short)1481703456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.dataProfVPNSecClrStrp_A42120 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝돟蟡蟣ꗥ蓧飩뿫髭苯英꯳럵쳷죹췻쳽ヿ", a_), global::CommonResources.AcgResources.ID_VPNVPNSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfVPNSecClrStrp_A42120LovStrs);
					this.dataProfVPNSecClrStrp_A42120.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfVPNSecClrStrp_A42120.DataTransferOrder = 58;
					num = (short)829095942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_3BD;
				case 6:
					goto IL_A14;
				case 7:
					this.dataProfNLSSecClrStrp_A36415 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距돟蟡蟣ꗥ蓧飩뿫髭苯英꯳럵쯷쳹죻쿽㗿", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25SECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfNLSSecClrStrp_A36415LovStrs);
					this.dataProfNLSSecClrStrp_A36415.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfNLSSecClrStrp_A36415.DataTransferOrder = 41;
					this.dataProfNLSSecClrStrp_A36415.EvaluateRecRefs = true;
					num = (short)1122172962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距ꯟ蟡鷣뗥跧蛩觫뇭뇯쇱싳싵짷쫹", a_)))
					{
						num = (short)1738276891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BD;
				case 9:
					goto IL_97A;
				case 10:
					this.dataProfVPNRekeyAttempts_A42213 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝닟蟡迣菥釧ꯩ飫髭闯鿱蓳苵请ꗹ뷻쫽㋿、㔃㔅", a_), global::CommonResources.AcgResources.ID_VPNVPNREKEYATTEMPTS, null, null, 0, 1);
					this.dataProfVPNRekeyAttempts_A42213.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dataProfVPNRekeyAttempts_A42213.DataTransferOrder = 65;
					this.dataProfVPNRekeyAttempts_A42213.ShowHexValue = false;
					num = (short)141099017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝닟蟡迣菥釧꟩跫鳭韯鯱髳꧵맷컹컻쳽ㇿ、", a_)))
					{
						num = (short)1376190500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_461;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距ꗟ賡蟣ꇥ觧黩觫駭釯诱뗳鋵鳷裹ꏻ뿽㏿㐁〃㜅㨇", a_)))
					{
						num = (short)197263385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20B;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝닟蟡迣菥釧ꯩ飫髭闯鿱蓳苵请ꗹ뷻쫽㋿、㔃㔅", a_)))
					{
						num = (short)956563466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97A;
				case 14:
					switch (0)
					{
					case 0:
						goto IL_D9;
					}
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝꟟菡郣菥鿧诩闫꟭ꃯ돱郳鋵諷鿹迻跽忿䌁〃㐅㠇㴉㔋", a_)))
					{
						num = (short)1170538518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3BD;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝귟蟡韣闥觧跩觫볭闯蛱蛳韵雷觹釻韽珿焁洃椅昇䬉砋稍甏缑搓戕欗䔙崛⨝ሟအᔣᘥ", a_)))
					{
						num = (short)1968439334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30B;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝ꯟ蟡鷣뗥跧蛩觫跭蓯鯱鯳飵ꟷ컹컻쳽㣿㈁", a_)))
					{
						num = (short)57081884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AAC;
				case 18:
					num = (short)1875509256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.dataProfVPNDeadPeerDetectionInterval_A42211 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝ꓟ蟡藣若룧迩觫鳭듯韱胳鏵鯷軹闻釽滿䬁樃爅洇砉程漍簏䴑唓∕⨗⠙ⴛ⼝", a_), global::CommonResources.AcgResources.ID_VPNVPNDEADPEERDETECTIONINTERVALMIN, null, null, 0, 1);
					this.dataProfVPNDeadPeerDetectionInterval_A42211.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dataProfVPNDeadPeerDetectionInterval_A42211.DataTransferOrder = 63;
					this.dataProfVPNDeadPeerDetectionInterval_A42211.ShowHexValue = false;
					num = (short)505544734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_A5E;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝돟蟡蟣ꗥ蓧飩뿫髭苯英꯳럵쳷죹췻쳽ヿ", a_)))
					{
						num = (short)2019885060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A14;
				case 22:
					num = (short)389611521;
					if (num != 0)
					{
					}
					this.dataProfVPNGatewayIPAddress_A42079 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝꟟菡郣菥鿧诩闫꟭ꃯ돱郳鋵諷鿹迻跽忿䌁〃㐅㠇㴉㔋", a_), global::CommonResources.AcgResources.ID_VPNVPNGATEWAYIPADDRESS);
					this.dataProfVPNGatewayIPAddress_A42079.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfVPNGatewayIPAddress_A42079.DataTransferOrder = 57;
					num = (short)709296133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_45C;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝ꓟ蟡藣若룧迩觫鳭듯韱胳鏵鯷軹闻釽滿䬁樃爅洇砉程漍簏䴑唓∕⨗⠙ⴛ⼝", a_)))
					{
						num = (short)1066336275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F7;
				case 25:
					this.dataProfNLSEncGatewayAddr_A36412 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距ꗟ賡蟣ꇥ觧黩觫駭釯诱뗳鋵鳷裹ꏻ뿽㏿㐁〃㜅㨇", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25ENCRYPTEDGATEWAYADDRESS);
					this.dataProfNLSEncGatewayAddr_A36412.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfNLSEncGatewayAddr_A36412.DataTransferOrder = 43;
					num = (short)1769078785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_503;
				case 27:
					this.dataProfNLSKeySele_A36410 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距ꯟ蟡鷣뗥跧蛩觫뇭뇯쇱싳싵짷쫹", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25KEYSELECTION, null, null, true, false);
					this.dataProfNLSKeySele_A36410.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfNLSKeySele_A36410.DataTransferOrder = 49;
					num = (short)675872801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					this.dataProfVPNKeySelection_42280 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝ꯟ蟡鷣뗥跧蛩觫跭蓯鯱鯳飵ꟷ컹컻쳽㣿㈁", a_), global::CommonResources.AcgResources.ID_VPNVPNKEYSELECTION, null, null, true, false);
					this.dataProfVPNKeySelection_42280.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfVPNKeySelection_42280.DataTransferOrder = 66;
					num = (short)834600986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					this.dataProfVPNMessageRetransmissionTime_A42209 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝귟蟡韣闥觧跩觫볭闯蛱蛳韵雷觹釻韽珿焁洃椅昇帉攋挍甏䴑唓∕⨗⠙Ⱋ✝", a_), global::CommonResources.AcgResources.ID_VPNVPNMESSAGERETRANSMISSIONTIMESEC, null, null, 0, 1);
					this.dataProfVPNMessageRetransmissionTime_A42209.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dataProfVPNMessageRetransmissionTime_A42209.DataTransferOrder = 60;
					this.dataProfVPNMessageRetransmissionTime_A42209.ShowHexValue = false;
					num = (short)1448345620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					goto IL_6F7;
				case 31:
					num = (short)127401986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_7A8;
				case 33:
					goto IL_2BD;
				case 34:
					goto IL_92D;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝귟蟡韣闥觧跩觫볭闯蛱蛳韵雷觹釻韽珿焁洃椅昇帉攋挍甏䴑唓∕⨗⠙Ⱋ✝", a_)))
					{
						num = (short)1676148765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A5E;
				case 36:
					this.dataProfVPNRekeyMargin_A42212 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝닟蟡迣菥釧꟩跫鳭韯鯱髳꧵맷컹컻쳽ㇿ、", a_), global::CommonResources.AcgResources.ID_VPNVPNREKEYMARGINMIN, null, null, 0, 1);
					this.dataProfVPNRekeyMargin_A42212.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dataProfVPNRekeyMargin_A42212.DataTransferOrder = 64;
					this.dataProfVPNRekeyMargin_A42212.ShowHexValue = false;
					num = (short)1387986983;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					this.dataProfNLSAllowRxClrPackData_A36414 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距ꇟ軡裣觥鿧룩铫귭鳯胱ꓳ韵鯷釹룻鿽瓿持嬃䜅㬇㰉㠋㼍␏", a_), global::CommonResources.AcgResources.ID_PACKETDATAAPCO25ALLOWRXCLEARPACKETDATA);
					this.dataProfNLSAllowRxClrPackData_A36414.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfNLSAllowRxClrPackData_A36414.DataTransferOrder = 44;
					num = (short)1817313303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
				{
					num = (short)1828604927;
					short num3 = num;
					num = (short)587484159;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45C;
					default:
						num = (short)1912799232;
						if (num != 0)
						{
						}
						this.dataProfVPNMessageRetransmissionAttempts_A42210 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗賙賛郝귟蟡韣闥觧跩觫볭闯蛱蛳韵雷觹釻韽珿焁洃椅昇䬉砋稍甏缑搓戕欗䔙崛⨝ሟအᔣᘥ", a_), global::CommonResources.AcgResources.ID_VPNVPNMESSAGERETRANSMISSIONATTEMPTS, null, null, 0, 1);
						this.dataProfVPNMessageRetransmissionAttempts_A42210.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						this.dataProfVPNMessageRetransmissionAttempts_A42210.DataTransferOrder = 61;
						this.dataProfVPNMessageRetransmissionAttempts_A42210.ShowHexValue = false;
						num = (short)1303445544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 39:
					goto IL_461;
				case 40:
					goto IL_30B;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距ꇟ軡裣觥鿧룩铫귭鳯胱ꓳ韵鯷釹룻鿽瓿持嬃䜅㬇㰉㠋㼍␏", a_)))
					{
						num = (short)1600913445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_647;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏苑ꛓ맕뻗铙郛距ꯟ꿡ꋣ뛥髧藩諫뷭闯黱釳꧵맷짹쫻쫽ㇿ㬁", a_)))
					{
						num = (short)1779171331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A8;
				}
				IL_D9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)208797727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_AAC;
				IL_20B:
				num = (short)1736245289;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BD:
				num = (short)56164364;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30B:
				num = (short)1017315352;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BD:
				num = (short)1699676181;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_461:
				num = (short)1700134925;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_647:
				num = (short)111280128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45C:
				goto IL_647;
				IL_6F7:
				num = (short)1487601675;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7A8:
				num = (short)1259012111;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_92D:
				num = (short)2095710250;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_97A:
				num = (short)1022820369;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A14:
				num = (short)1316159523;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A5E:
				num = (short)241238032;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_503:
			num = (short)301793280;
			short num4 = num;
			IL_AAC:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓉꧋뫍꟏뷑ꛓ뷕雙뷛꟝藟郡쓣뗥跧觩駫鳭駯蛱跳", a_);
			base.Id = 10600;
			base.UIName = global::CommonResources.AcgResources.ID_NETWORKLAYERSECURITY;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x00A33884 File Offset: 0x00A31A84
		public override void PopulateReferences()
		{
			short num = (short)1624047616;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				for (;;)
				{
					IL_28:
					num = (short)273285121;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
					bool? flag2;
					bool? flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
						num = (short)1348730882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.dataProfNLSKMFProfSele_A36419.ReferencedNode != null)
						{
							num = (short)1609957386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DB;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = secureKMFProfile.General;
						if (general == null)
						{
							bool? flag = null;
							num = (short)1004732419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = new bool?(general.SecKmfProfGenIndependentKeyList_43597.Value);
						goto IL_28E;
					}
					case 3:
					{
						bool? flag;
						flag2 = flag;
						goto IL_28E;
					}
					case 4:
						if (secureKMFProfile != null)
						{
							num = (short)1986330624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DB;
					case 5:
						goto IL_2D6;
					case 6:
						goto IL_1BF;
					case 7:
					{
						num = (short)1636934317;
						short num3 = num;
						num = (short)467575469;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D6;
						default:
							num = (short)1060569088;
							if (num != 0)
							{
							}
							num = (short)885325825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
						{
							num = (short)230424581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DB;
					case 9:
						if (this.dataProfNLSKMFProfSele_A36419.Value > 0)
						{
							num = (short)560398343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DB;
					case 10:
						secureKMFProfile = (this.dataProfNLSKMFProfSele_A36419.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
						num = (short)1362755588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_82;
					IL_28E:
					flag3 = flag2;
					flag4 = true;
					num = (short)1699479560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D6:
					embeddedRecset = secureKMFProfile.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
					num = (short)1875705862;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BF:
				IL_2DB:
				num = (short)716570624;
				short num4 = num;
				this.dataProfNLSKeySele_A36410.SetRecset(embeddedRecset);
				return;
				IL_82:
				this.dataProfVPNKeySelection_42280.SetRecset(this.a(2021)[0][10040].EmbeddedRecset);
				this.dataProfNLSKMFProfSele_A36419.SetRecset(this.a(2055));
				embeddedRecset = this.a(2021)[0][10040].EmbeddedRecset;
				num = (short)892207113;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600AFC5 RID: 44997 RVA: 0x00A33BA4 File Offset: 0x00A31DA4
		public override void DropReferences()
		{
			short num = (short)1829327011;
			short num2 = num;
			num = (short)1698517155;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1853816832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)452722689;
			if (num != 0)
			{
			}
			num = (short)395837440;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x00A33C4C File Offset: 0x00A31E4C
		public override void SetConstraints()
		{
			short num = (short)1506082817;
			if (num != 0)
			{
			}
			num = (short)1906180096;
			short num2 = num;
			num = (short)469310585;
			short num3 = num;
			num = (short)2059148409;
			switch (num3 == num)
			{
			}
			num = (short)389808128;
			if (num != 0)
			{
			}
			this.dataProfNLSKeySele_A36410.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSecureClearStrappingSecure);
			this.dataProfNLSKeySele_A36410.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conKeySelValid);
			this.dataProfNLSEncGatewayAddr_A36412.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSecureClearStrappingSecure);
			this.dataProfNLSEncGatewayAddr_A36412.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conIPAddrNonZeroValid);
			this.dataProfNLSAllowRxClrPackData_A36414.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSecureClearStrappingSecure);
			this.dataProfNLSSecClrStrp_A36415.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSecureClearStrappingApplicable);
			this.dataProfNLSSecClrStrp_A36415.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSecureClearStrappingValid);
			this.dataProfNLSKMFProfSele_A36419.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSecureClearStrappingSecure);
			this.dataProfNLSKMFProfSele_A36419.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.condataProfNLSKMFProfSeleValid);
			this.dataProfVPNGatewayIPAddress_A42079.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfVPNGatewayIPApp);
			this.dataProfVPNGatewayIPAddress_A42079.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConVPNGatewayIPAddrValid);
			this.dataProfVPNSecClrStrp_A42120.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfVPNSecureClearStrappingApp);
			this.dataProfVPNMessageRetransmissionTime_A42209.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfVPNGatewayIPApp);
			this.dataProfVPNMessageRetransmissionAttempts_A42210.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfVPNGatewayIPApp);
			this.dataProfVPNDeadPeerDetectionInterval_A42211.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfVPNGatewayIPApp);
			this.dataProfVPNRekeyMargin_A42212.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfVPNGatewayIPApp);
			this.dataProfVPNRekeyAttempts_A42213.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfVPNGatewayIPApp);
			this.dataProfVPNKeySelection_42280.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfVPNGatewayIPApp);
		}

		// Token: 0x0600AFC7 RID: 44999 RVA: 0x00A33E94 File Offset: 0x00A32094
		public override void SetupDependencies()
		{
			short num = (short)65265016;
			short num2 = num;
			num = (short)854318456;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2072838144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1993408512;
			if (num != 0)
			{
			}
			num = (short)1015414785;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfNLSEncGatewayAddr_A36412);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfNLSSecClrStrp_A36415);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfNLSSecClrStrp_A36415);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.dataProfNLSSecClrStrp_A36415);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.dataProfNLSSecClrStrp_A36415);
			dataProfiles.General.DataConfigDataProfIPHeaderCompressionEnable_A36190.AddDependentObject(this.dataProfNLSSecClrStrp_A36415);
			this.dataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfVPNGatewayIPAddress_A42079);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfVPNGatewayIPAddress_A42079);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfVPNGatewayIPAddress_A42079);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfVPNGatewayIPAddress_A42079);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfVPNSecClrStrp_A42120);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfVPNSecClrStrp_A42120);
			this.dataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfVPNMessageRetransmissionTime_A42209);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfVPNMessageRetransmissionTime_A42209);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfVPNMessageRetransmissionTime_A42209);
			this.dataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfVPNMessageRetransmissionAttempts_A42210);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfVPNMessageRetransmissionAttempts_A42210);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfVPNMessageRetransmissionAttempts_A42210);
			this.dataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfVPNDeadPeerDetectionInterval_A42211);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfVPNDeadPeerDetectionInterval_A42211);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfVPNDeadPeerDetectionInterval_A42211);
			this.dataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfVPNRekeyMargin_A42212);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfVPNRekeyMargin_A42212);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfVPNRekeyMargin_A42212);
			this.dataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfVPNRekeyAttempts_A42213);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfVPNRekeyAttempts_A42213);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfVPNRekeyAttempts_A42213);
			this.dataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfVPNKeySelection_42280);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfVPNKeySelection_42280);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfVPNKeySelection_42280);
		}

		// Token: 0x17005838 RID: 22584
		// (get) Token: 0x0600AFC8 RID: 45000 RVA: 0x00A34218 File Offset: 0x00A32418
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForDataProfNLSKeySele_A36410
		{
			get
			{
				short num = (short)1163583356;
				short num2 = num;
				num = (short)945282940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)966328320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)400949248;
				if (num != 0)
				{
				}
				num = (short)1920663553;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17005839 RID: 22585
		// (get) Token: 0x0600AFC9 RID: 45001 RVA: 0x00A342D0 File Offset: 0x00A324D0
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile SecureKMFProfileForDataProfNLSKMFProfSele_A36419
		{
			get
			{
				short num = (short)507145711;
				short num2 = num;
				num = (short)354905583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835663360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1361051649;
				if (num != 0)
				{
				}
				num = (short)108658688;
				if (num != 0)
				{
				}
				return this.dataProfNLSKMFProfSele_A36419.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			}
		}

		// Token: 0x1700583A RID: 22586
		// (get) Token: 0x0600AFCA RID: 45002 RVA: 0x00A34388 File Offset: 0x00A32588
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForDataProfVPNKeySelection_42280
		{
			get
			{
				short num = (short)697196564;
				short num2 = num;
				num = (short)871784468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499594752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1726676993;
				if (num != 0)
				{
				}
				num = (short)2078998528;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x1700583B RID: 22587
		// (get) Token: 0x0600AFCB RID: 45003 RVA: 0x00A34444 File Offset: 0x00A32644
		public bool HasDiffs
		{
			get
			{
				short num = (short)1629625699;
				short num2 = num;
				num = (short)663297379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)613744640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1954152449;
				if (num != 0)
				{
				}
				num = (short)331677696;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700583C RID: 22588
		// (get) Token: 0x0600AFCC RID: 45004 RVA: 0x00A344F0 File Offset: 0x00A326F0
		// (set) Token: 0x0600AFCD RID: 45005 RVA: 0x00A345A4 File Offset: 0x00A327A4
		public int DataProfNLSKeySele_A36410Value
		{
			get
			{
				short num = (short)1847879131;
				short num2 = num;
				num = (short)1121609179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1658978304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264962049;
				if (num != 0)
				{
				}
				num = (short)1659371520;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.Value;
			}
			set
			{
				short num = (short)628097025;
				if (num != 0)
				{
				}
				num = (short)1277689856;
				short num2 = num;
				num = (short)21352557;
				short num3 = num;
				num = (short)1623904365;
				switch (num3 == num)
				{
				}
				num = (short)2044854272;
				if (num != 0)
				{
				}
				this.dataProfNLSKeySele_A36410.Value = value;
			}
		}

		// Token: 0x1700583D RID: 22589
		// (get) Token: 0x0600AFCE RID: 45006 RVA: 0x00A34658 File Offset: 0x00A32858
		// (set) Token: 0x0600AFCF RID: 45007 RVA: 0x00A34710 File Offset: 0x00A32910
		public string DataProfNLSKeySele_A36410_UIValue
		{
			get
			{
				short num = (short)1473884324;
				short num2 = num;
				num = (short)243052708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1708785664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1019084801;
				if (num != 0)
				{
				}
				num = (short)2100232192;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.UIValue;
			}
			set
			{
				short num = (short)1472123316;
				short num2 = num;
				num = (short)67228084;
				switch (num2 == num)
				{
				}
				num = (short)1107427328;
				short num3 = num;
				num = (short)1266810880;
				if (num != 0)
				{
				}
				num = (short)1163919361;
				if (num != 0)
				{
				}
				this.dataProfNLSKeySele_A36410.UIValue = value;
			}
		}

		// Token: 0x1700583E RID: 22590
		// (get) Token: 0x0600AFD0 RID: 45008 RVA: 0x00A347C8 File Offset: 0x00A329C8
		public global::AcpBusinessLayer.AcpRecRefField DataProfNLSKeySele_A36410
		{
			get
			{
				short num = (short)1196490753;
				if (num != 0)
				{
				}
				num = (short)1726665233;
				short num2 = num;
				num = (short)539415057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1011286016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2016215040;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410;
			}
		}

		// Token: 0x1700583F RID: 22591
		// (get) Token: 0x0600AFD1 RID: 45009 RVA: 0x00A34878 File Offset: 0x00A32A78
		// (set) Token: 0x0600AFD2 RID: 45010 RVA: 0x00A3492C File Offset: 0x00A32B2C
		public bool DataProfNLSKeySele_A36410_Applicable
		{
			get
			{
				short num = (short)41353217;
				if (num != 0)
				{
				}
				num = (short)637088207;
				short num2 = num;
				num = (short)1346974159;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414922240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)27262976;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.Applicable;
			}
			set
			{
				short num = (short)700579841;
				if (num != 0)
				{
				}
				num = (short)640722836;
				short num2 = num;
				num = (short)509519764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1455751168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1112539136;
				if (num != 0)
				{
				}
				this.dataProfNLSKeySele_A36410.Applicable = value;
			}
		}

		// Token: 0x17005840 RID: 22592
		// (get) Token: 0x0600AFD3 RID: 45011 RVA: 0x00A349E4 File Offset: 0x00A32BE4
		// (set) Token: 0x0600AFD4 RID: 45012 RVA: 0x00A34A9C File Offset: 0x00A32C9C
		public bool DataProfNLSKeySele_A36410_Valid
		{
			get
			{
				short num = (short)354770587;
				short num2 = num;
				num = (short)1933467291;
				switch (num2 == num)
				{
				}
				num = (short)1354104832;
				short num3 = num;
				num = (short)277086209;
				if (num != 0)
				{
				}
				num = (short)1985150976;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.Valid;
			}
			set
			{
				short num = (short)331630144;
				short num2 = num;
				num = (short)1100695104;
				switch (num2 == num)
				{
				}
				num = (short)721092608;
				short num3 = num;
				num = (short)1661861888;
				if (num != 0)
				{
				}
				num = (short)910622721;
				if (num != 0)
				{
				}
				this.dataProfNLSKeySele_A36410.Valid = value;
			}
		}

		// Token: 0x17005841 RID: 22593
		// (get) Token: 0x0600AFD5 RID: 45013 RVA: 0x00A34B54 File Offset: 0x00A32D54
		// (set) Token: 0x0600AFD6 RID: 45014 RVA: 0x00A34C08 File Offset: 0x00A32E08
		public bool DataProfNLSKeySele_A36410_Visible
		{
			get
			{
				short num = (short)1672123515;
				short num2 = num;
				num = (short)1921422459;
				switch (num2 == num)
				{
				}
				num = (short)1522204672;
				short num3 = num;
				num = (short)1359413249;
				if (num != 0)
				{
				}
				num = (short)185466880;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.Visible;
			}
			set
			{
				short num = (short)966519308;
				short num2 = num;
				num = (short)1334241804;
				switch (num2 == num)
				{
				}
				num = (short)196083712;
				short num3 = num;
				num = (short)445382656;
				if (num != 0)
				{
				}
				num = (short)501088257;
				if (num != 0)
				{
				}
				this.dataProfNLSKeySele_A36410.Visible = value;
			}
		}

		// Token: 0x17005842 RID: 22594
		// (get) Token: 0x0600AFD7 RID: 45015 RVA: 0x00A34CC0 File Offset: 0x00A32EC0
		// (set) Token: 0x0600AFD8 RID: 45016 RVA: 0x00A34D74 File Offset: 0x00A32F74
		public bool DataProfNLSKeySele_A36410_Editable
		{
			get
			{
				short num = (short)1889482918;
				short num2 = num;
				num = (short)1092761766;
				switch (num2 == num)
				{
				}
				num = (short)1523646464;
				short num3 = num;
				num = (short)2014642176;
				if (num != 0)
				{
				}
				num = (short)399966209;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.Editable;
			}
			set
			{
				short num = (short)1219956565;
				short num2 = num;
				num = (short)1934692181;
				switch (num2 == num)
				{
				}
				num = (short)1982988288;
				short num3 = num;
				num = (short)973275137;
				if (num != 0)
				{
				}
				num = (short)524746752;
				if (num != 0)
				{
				}
				this.dataProfNLSKeySele_A36410.Editable = value;
			}
		}

		// Token: 0x17005843 RID: 22595
		// (get) Token: 0x0600AFD9 RID: 45017 RVA: 0x00A34E28 File Offset: 0x00A33028
		internal string DataProfNLSKeySele_A36410_UILabel
		{
			get
			{
				short num = (short)446054859;
				short num2 = num;
				num = (short)1297826251;
				switch (num2 == num)
				{
				}
				num = (short)1355218944;
				short num3 = num;
				num = (short)486735873;
				if (num != 0)
				{
				}
				num = (short)1562443776;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.UIName;
			}
		}

		// Token: 0x17005844 RID: 22596
		// (get) Token: 0x0600AFDA RID: 45018 RVA: 0x00A34EDC File Offset: 0x00A330DC
		// (set) Token: 0x0600AFDB RID: 45019 RVA: 0x00A34F90 File Offset: 0x00A33190
		internal bool DataProfNLSKeySele_A36410_HiddenStatic
		{
			get
			{
				short num = (short)283404547;
				short num2 = num;
				num = (short)2130077955;
				switch (num2 == num)
				{
				}
				num = (short)1131347968;
				short num3 = num;
				num = (short)1144913920;
				if (num != 0)
				{
				}
				num = (short)1061879809;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.HiddenStatic;
			}
			set
			{
				short num = (short)1123652451;
				short num2 = num;
				num = (short)75600739;
				switch (num2 == num)
				{
				}
				num = (short)1634729984;
				short num3 = num;
				num = (short)433913857;
				if (num != 0)
				{
				}
				num = (short)552140800;
				if (num != 0)
				{
				}
				this.dataProfNLSKeySele_A36410.HiddenStatic = value;
			}
		}

		// Token: 0x17005845 RID: 22597
		// (get) Token: 0x0600AFDC RID: 45020 RVA: 0x00A35044 File Offset: 0x00A33244
		// (set) Token: 0x0600AFDD RID: 45021 RVA: 0x00A350FC File Offset: 0x00A332FC
		internal bool DataProfNLSKeySele_A36410_HiddenDynamic
		{
			get
			{
				short num = (short)1730150401;
				if (num != 0)
				{
				}
				num = (short)1551875287;
				short num2 = num;
				num = (short)1779547351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1824194560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)997326848;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410.HiddenDynamic;
			}
			set
			{
				short num = (short)526575241;
				short num2 = num;
				num = (short)1651238537;
				switch (num2 == num)
				{
				}
				num = (short)879230976;
				short num3 = num;
				num = (short)1060044801;
				if (num != 0)
				{
				}
				num = (short)1352400896;
				if (num != 0)
				{
				}
				this.dataProfNLSKeySele_A36410.HiddenDynamic = value;
			}
		}

		// Token: 0x17005846 RID: 22598
		// (get) Token: 0x0600AFDE RID: 45022 RVA: 0x00A351B8 File Offset: 0x00A333B8
		public bool DataProfNLSKeySele_A36410_HasDiffs
		{
			get
			{
				short num = (short)1574554539;
				short num2 = num;
				num = (short)378457003;
				switch (num2 == num)
				{
				}
				num = (short)717488128;
				short num3 = num;
				num = (short)239927296;
				if (num != 0)
				{
				}
				num = (short)645201921;
				if (num != 0)
				{
				}
				return this.dataProfNLSKeySele_A36410._HasDiffs;
			}
		}

		// Token: 0x17005847 RID: 22599
		// (get) Token: 0x0600AFDF RID: 45023 RVA: 0x00A35270 File Offset: 0x00A33470
		// (set) Token: 0x0600AFE0 RID: 45024 RVA: 0x00A35328 File Offset: 0x00A33528
		public long DataProfNLSEncGatewayAddr_A36412Value
		{
			get
			{
				short num = (short)914167569;
				short num2 = num;
				num = (short)1571034897;
				switch (num2 == num)
				{
				}
				num = (short)1359544320;
				short num3 = num;
				num = (short)908328960;
				if (num != 0)
				{
				}
				num = (short)1888288769;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.Value;
			}
			set
			{
				short num = (short)1507644436;
				short num2 = num;
				num = (short)374461460;
				switch (num2 == num)
				{
				}
				num = (short)67108864;
				short num3 = num;
				num = (short)1659502593;
				if (num != 0)
				{
				}
				num = (short)1995177984;
				if (num != 0)
				{
				}
				this.dataProfNLSEncGatewayAddr_A36412.Value = value;
			}
		}

		// Token: 0x17005848 RID: 22600
		// (get) Token: 0x0600AFE1 RID: 45025 RVA: 0x00A353DC File Offset: 0x00A335DC
		// (set) Token: 0x0600AFE2 RID: 45026 RVA: 0x00A35490 File Offset: 0x00A33690
		public string DataProfNLSEncGatewayAddr_A36412_UIValue
		{
			get
			{
				short num = (short)1508986892;
				short num2 = num;
				num = (short)1746423820;
				switch (num2 == num)
				{
				}
				num = (short)2010841088;
				short num3 = num;
				num = (short)1759182849;
				if (num != 0)
				{
				}
				num = (short)1662976000;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.UIValue;
			}
			set
			{
				short num = (short)902770800;
				short num2 = num;
				num = (short)963391600;
				switch (num2 == num)
				{
				}
				num = (short)1664155648;
				short num3 = num;
				num = (short)410648576;
				if (num != 0)
				{
				}
				num = (short)2057043969;
				if (num != 0)
				{
				}
				this.dataProfNLSEncGatewayAddr_A36412.UIValue = value;
			}
		}

		// Token: 0x17005849 RID: 22601
		// (get) Token: 0x0600AFE3 RID: 45027 RVA: 0x00A35544 File Offset: 0x00A33744
		public global::AcpBusinessLayer.AcpIPAddressField DataProfNLSEncGatewayAddr_A36412
		{
			get
			{
				short num = (short)1934298405;
				short num2 = num;
				num = (short)738200869;
				switch (num2 == num)
				{
				}
				num = (short)115081216;
				short num3 = num;
				num = (short)556269568;
				if (num != 0)
				{
				}
				num = (short)380764161;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412;
			}
		}

		// Token: 0x1700584A RID: 22602
		// (get) Token: 0x0600AFE4 RID: 45028 RVA: 0x00A355F4 File Offset: 0x00A337F4
		// (set) Token: 0x0600AFE5 RID: 45029 RVA: 0x00A356A8 File Offset: 0x00A338A8
		public bool DataProfNLSEncGatewayAddr_A36412_Applicable
		{
			get
			{
				short num = (short)1218969601;
				if (num != 0)
				{
				}
				num = (short)1931388687;
				short num2 = num;
				num = (short)1849206543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)872939520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1874198528;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.Applicable;
			}
			set
			{
				short num = (short)1566686905;
				short num2 = num;
				num = (short)146521785;
				switch (num2 == num)
				{
				}
				num = (short)263061504;
				short num3 = num;
				num = (short)1230897152;
				if (num != 0)
				{
				}
				num = (short)1539899393;
				if (num != 0)
				{
				}
				this.dataProfNLSEncGatewayAddr_A36412.Applicable = value;
			}
		}

		// Token: 0x1700584B RID: 22603
		// (get) Token: 0x0600AFE6 RID: 45030 RVA: 0x00A3575C File Offset: 0x00A3395C
		// (set) Token: 0x0600AFE7 RID: 45031 RVA: 0x00A35810 File Offset: 0x00A33A10
		public bool DataProfNLSEncGatewayAddr_A36412_Valid
		{
			get
			{
				short num = (short)372809889;
				short num2 = num;
				num = (short)1267245217;
				switch (num2 == num)
				{
				}
				num = (short)204865536;
				short num3 = num;
				num = (short)720240640;
				if (num != 0)
				{
				}
				num = (short)252968961;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.Valid;
			}
			set
			{
				short num = (short)339607553;
				if (num != 0)
				{
				}
				num = (short)1342863947;
				short num2 = num;
				num = (short)786070091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1897398272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2018312192;
				if (num != 0)
				{
				}
				this.dataProfNLSEncGatewayAddr_A36412.Valid = value;
			}
		}

		// Token: 0x1700584C RID: 22604
		// (get) Token: 0x0600AFE8 RID: 45032 RVA: 0x00A358C4 File Offset: 0x00A33AC4
		// (set) Token: 0x0600AFE9 RID: 45033 RVA: 0x00A35978 File Offset: 0x00A33B78
		public bool DataProfNLSEncGatewayAddr_A36412_Visible
		{
			get
			{
				short num = (short)155501500;
				short num2 = num;
				num = (short)303023036;
				switch (num2 == num)
				{
				}
				num = (short)1957756928;
				short num3 = num;
				num = (short)1466761217;
				if (num != 0)
				{
				}
				num = (short)999489536;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.Visible;
			}
			set
			{
				short num = (short)1174203521;
				short num2 = num;
				num = (short)75295873;
				switch (num2 == num)
				{
				}
				num = (short)805896192;
				short num3 = num;
				num = (short)1685716993;
				if (num != 0)
				{
				}
				num = (short)2142437376;
				if (num != 0)
				{
				}
				this.dataProfNLSEncGatewayAddr_A36412.Visible = value;
			}
		}

		// Token: 0x1700584D RID: 22605
		// (get) Token: 0x0600AFEA RID: 45034 RVA: 0x00A35A2C File Offset: 0x00A33C2C
		// (set) Token: 0x0600AFEB RID: 45035 RVA: 0x00A35AE0 File Offset: 0x00A33CE0
		public bool DataProfNLSEncGatewayAddr_A36412_Editable
		{
			get
			{
				short num = (short)1533581402;
				short num2 = num;
				num = (short)82876506;
				switch (num2 == num)
				{
				}
				num = (short)2029387776;
				short num3 = num;
				num = (short)1105854465;
				if (num != 0)
				{
				}
				num = (short)1578303488;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.Editable;
			}
			set
			{
				short num = (short)1750728705;
				if (num != 0)
				{
				}
				num = (short)586948493;
				short num2 = num;
				num = (short)1681923981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)819855360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1121517568;
				if (num != 0)
				{
				}
				this.dataProfNLSEncGatewayAddr_A36412.Editable = value;
			}
		}

		// Token: 0x1700584E RID: 22606
		// (get) Token: 0x0600AFEC RID: 45036 RVA: 0x00A35B94 File Offset: 0x00A33D94
		internal string DataProfNLSEncGatewayAddr_A36412_UILabel
		{
			get
			{
				short num = (short)1595597147;
				short num2 = num;
				num = (short)1929371995;
				switch (num2 == num)
				{
				}
				num = (short)19988480;
				short num3 = num;
				num = (short)1494417408;
				if (num != 0)
				{
				}
				num = (short)1573781505;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.UIName;
			}
		}

		// Token: 0x1700584F RID: 22607
		// (get) Token: 0x0600AFED RID: 45037 RVA: 0x00A35C48 File Offset: 0x00A33E48
		// (set) Token: 0x0600AFEE RID: 45038 RVA: 0x00A35CFC File Offset: 0x00A33EFC
		internal bool DataProfNLSEncGatewayAddr_A36412_HiddenStatic
		{
			get
			{
				short num = (short)692392634;
				short num2 = num;
				num = (short)1326715578;
				switch (num2 == num)
				{
				}
				num = (short)320143360;
				short num3 = num;
				num = (short)1827078145;
				if (num != 0)
				{
				}
				num = (short)772145152;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.HiddenStatic;
			}
			set
			{
				short num = (short)941876282;
				short num2 = num;
				num = (short)1762714682;
				switch (num2 == num)
				{
				}
				num = (short)951123968;
				short num3 = num;
				num = (short)1256390657;
				if (num != 0)
				{
				}
				num = (short)2053046272;
				if (num != 0)
				{
				}
				this.dataProfNLSEncGatewayAddr_A36412.HiddenStatic = value;
			}
		}

		// Token: 0x17005850 RID: 22608
		// (get) Token: 0x0600AFEF RID: 45039 RVA: 0x00A35DB0 File Offset: 0x00A33FB0
		// (set) Token: 0x0600AFF0 RID: 45040 RVA: 0x00A35E64 File Offset: 0x00A34064
		internal bool DataProfNLSEncGatewayAddr_A36412_HiddenDynamic
		{
			get
			{
				short num = (short)413008468;
				short num2 = num;
				num = (short)1062208084;
				switch (num2 == num)
				{
				}
				num = (short)1934950400;
				short num3 = num;
				num = (short)1089536000;
				if (num != 0)
				{
				}
				num = (short)472449025;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412.HiddenDynamic;
			}
			set
			{
				short num = (short)1645278874;
				short num2 = num;
				num = (short)689763994;
				switch (num2 == num)
				{
				}
				num = (short)1359413248;
				short num3 = num;
				num = (short)70778880;
				if (num != 0)
				{
				}
				num = (short)59899905;
				if (num != 0)
				{
				}
				this.dataProfNLSEncGatewayAddr_A36412.HiddenDynamic = value;
			}
		}

		// Token: 0x17005851 RID: 22609
		// (get) Token: 0x0600AFF1 RID: 45041 RVA: 0x00A35F1C File Offset: 0x00A3411C
		public bool DataProfNLSEncGatewayAddr_A36412_HasDiffs
		{
			get
			{
				short num = (short)402452366;
				short num2 = num;
				num = (short)75689870;
				switch (num2 == num)
				{
				}
				num = (short)1157365760;
				short num3 = num;
				num = (short)499712001;
				if (num != 0)
				{
				}
				num = (short)738721792;
				if (num != 0)
				{
				}
				return this.dataProfNLSEncGatewayAddr_A36412._HasDiffs;
			}
		}

		// Token: 0x17005852 RID: 22610
		// (get) Token: 0x0600AFF2 RID: 45042 RVA: 0x00A35FD0 File Offset: 0x00A341D0
		// (set) Token: 0x0600AFF3 RID: 45043 RVA: 0x00A36084 File Offset: 0x00A34284
		public bool DataProfNLSAllowRxClrPackData_A36414Value
		{
			get
			{
				short num = (short)588225551;
				short num2 = num;
				num = (short)1465490447;
				switch (num2 == num)
				{
				}
				num = (short)2035154944;
				short num3 = num;
				num = (short)2136539136;
				if (num != 0)
				{
				}
				num = (short)997785601;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.Value;
			}
			set
			{
				short num = (short)23265138;
				short num2 = num;
				num = (short)1232994162;
				switch (num2 == num)
				{
				}
				num = (short)1298857984;
				short num3 = num;
				num = (short)57344001;
				if (num != 0)
				{
				}
				num = (short)456916992;
				if (num != 0)
				{
				}
				this.dataProfNLSAllowRxClrPackData_A36414.Value = value;
			}
		}

		// Token: 0x17005853 RID: 22611
		// (get) Token: 0x0600AFF4 RID: 45044 RVA: 0x00A3613C File Offset: 0x00A3433C
		public global::AcpBusinessLayer.AcpField<bool> DataProfNLSAllowRxClrPackData_A36414
		{
			get
			{
				short num = (short)1623785473;
				if (num != 0)
				{
				}
				num = (short)146408107;
				short num2 = num;
				num = (short)1537933995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)626982912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1314586624;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414;
			}
		}

		// Token: 0x17005854 RID: 22612
		// (get) Token: 0x0600AFF5 RID: 45045 RVA: 0x00A361E8 File Offset: 0x00A343E8
		// (set) Token: 0x0600AFF6 RID: 45046 RVA: 0x00A3629C File Offset: 0x00A3449C
		public bool DataProfNLSAllowRxClrPackData_A36414_UIValue
		{
			get
			{
				short num = (short)1071298017;
				short num2 = num;
				num = (short)497530337;
				switch (num2 == num)
				{
				}
				num = (short)1674051584;
				short num3 = num;
				num = (short)1420558337;
				if (num != 0)
				{
				}
				num = (short)931069952;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.Value;
			}
			set
			{
				short num = (short)1456939242;
				short num2 = num;
				num = (short)1726554346;
				switch (num2 == num)
				{
				}
				num = (short)1796669440;
				short num3 = num;
				num = (short)1785069569;
				if (num != 0)
				{
				}
				num = (short)904003584;
				if (num != 0)
				{
				}
				this.dataProfNLSAllowRxClrPackData_A36414.Value = value;
			}
		}

		// Token: 0x17005855 RID: 22613
		// (get) Token: 0x0600AFF7 RID: 45047 RVA: 0x00A36354 File Offset: 0x00A34554
		// (set) Token: 0x0600AFF8 RID: 45048 RVA: 0x00A36408 File Offset: 0x00A34608
		public bool DataProfNLSAllowRxClrPackData_A36414_Applicable
		{
			get
			{
				short num = (short)377014844;
				short num2 = num;
				num = (short)109759036;
				switch (num2 == num)
				{
				}
				num = (short)297664512;
				short num3 = num;
				num = (short)1308753920;
				if (num != 0)
				{
				}
				num = (short)128647169;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.Applicable;
			}
			set
			{
				short num = (short)1585407350;
				short num2 = num;
				num = (short)173106550;
				switch (num2 == num)
				{
				}
				num = (short)1929379840;
				short num3 = num;
				num = (short)566165504;
				if (num != 0)
				{
				}
				num = (short)248250369;
				if (num != 0)
				{
				}
				this.dataProfNLSAllowRxClrPackData_A36414.Applicable = value;
			}
		}

		// Token: 0x17005856 RID: 22614
		// (get) Token: 0x0600AFF9 RID: 45049 RVA: 0x00A364BC File Offset: 0x00A346BC
		// (set) Token: 0x0600AFFA RID: 45050 RVA: 0x00A36570 File Offset: 0x00A34770
		public bool DataProfNLSAllowRxClrPackData_A36414_Valid
		{
			get
			{
				short num = (short)668236139;
				short num2 = num;
				num = (short)2086041963;
				switch (num2 == num)
				{
				}
				num = (short)1344208896;
				short num3 = num;
				num = (short)612433920;
				if (num != 0)
				{
				}
				num = (short)774832129;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.Valid;
			}
			set
			{
				short num = (short)256195754;
				short num2 = num;
				num = (short)2105162922;
				switch (num2 == num)
				{
				}
				num = (short)2052915200;
				short num3 = num;
				num = (short)1619984385;
				if (num != 0)
				{
				}
				num = (short)329646080;
				if (num != 0)
				{
				}
				this.dataProfNLSAllowRxClrPackData_A36414.Valid = value;
			}
		}

		// Token: 0x17005857 RID: 22615
		// (get) Token: 0x0600AFFB RID: 45051 RVA: 0x00A36624 File Offset: 0x00A34824
		// (set) Token: 0x0600AFFC RID: 45052 RVA: 0x00A366D8 File Offset: 0x00A348D8
		public bool DataProfNLSAllowRxClrPackData_A36414_Visible
		{
			get
			{
				short num = (short)1020223713;
				short num2 = num;
				num = (short)253190369;
				switch (num2 == num)
				{
				}
				num = (short)1266089984;
				short num3 = num;
				num = (short)955908097;
				if (num != 0)
				{
				}
				num = (short)1667104768;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.Visible;
			}
			set
			{
				short num = (short)292087712;
				short num2 = num;
				num = (short)333375392;
				switch (num2 == num)
				{
				}
				num = (short)945160192;
				short num3 = num;
				num = (short)1378877441;
				if (num != 0)
				{
				}
				num = (short)1596981248;
				if (num != 0)
				{
				}
				this.dataProfNLSAllowRxClrPackData_A36414.Visible = value;
			}
		}

		// Token: 0x17005858 RID: 22616
		// (get) Token: 0x0600AFFD RID: 45053 RVA: 0x00A36790 File Offset: 0x00A34990
		// (set) Token: 0x0600AFFE RID: 45054 RVA: 0x00A36844 File Offset: 0x00A34A44
		public bool DataProfNLSAllowRxClrPackData_A36414_Editable
		{
			get
			{
				short num = (short)629180694;
				short num2 = num;
				num = (short)1027967254;
				switch (num2 == num)
				{
				}
				num = (short)381353984;
				short num3 = num;
				num = (short)805371905;
				if (num != 0)
				{
				}
				num = (short)290783232;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.Editable;
			}
			set
			{
				short num = (short)1940005024;
				short num2 = num;
				num = (short)1979850912;
				switch (num2 == num)
				{
				}
				num = (short)1354694656;
				short num3 = num;
				num = (short)919404545;
				if (num != 0)
				{
				}
				num = (short)1640562688;
				if (num != 0)
				{
				}
				this.dataProfNLSAllowRxClrPackData_A36414.Editable = value;
			}
		}

		// Token: 0x17005859 RID: 22617
		// (get) Token: 0x0600AFFF RID: 45055 RVA: 0x00A368F8 File Offset: 0x00A34AF8
		internal string DataProfNLSAllowRxClrPackData_A36414_UILabel
		{
			get
			{
				short num = (short)491059442;
				short num2 = num;
				num = (short)1188755698;
				switch (num2 == num)
				{
				}
				num = (short)1051131904;
				short num3 = num;
				num = (short)1163919361;
				if (num != 0)
				{
				}
				num = (short)568000512;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.UIName;
			}
		}

		// Token: 0x1700585A RID: 22618
		// (get) Token: 0x0600B000 RID: 45056 RVA: 0x00A369AC File Offset: 0x00A34BAC
		// (set) Token: 0x0600B001 RID: 45057 RVA: 0x00A36A60 File Offset: 0x00A34C60
		internal bool DataProfNLSAllowRxClrPackData_A36414_HiddenStatic
		{
			get
			{
				short num = (short)2038407747;
				short num2 = num;
				num = (short)346661443;
				switch (num2 == num)
				{
				}
				num = (short)2082078720;
				short num3 = num;
				num = (short)602669057;
				if (num != 0)
				{
				}
				num = (short)1189609472;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.HiddenStatic;
			}
			set
			{
				short num = (short)1824475394;
				short num2 = num;
				num = (short)263276802;
				switch (num2 == num)
				{
				}
				num = (short)1633288192;
				short num3 = num;
				num = (short)130023425;
				if (num != 0)
				{
				}
				num = (short)771620864;
				if (num != 0)
				{
				}
				this.dataProfNLSAllowRxClrPackData_A36414.HiddenStatic = value;
			}
		}

		// Token: 0x1700585B RID: 22619
		// (get) Token: 0x0600B002 RID: 45058 RVA: 0x00A36B14 File Offset: 0x00A34D14
		// (set) Token: 0x0600B003 RID: 45059 RVA: 0x00A36BC8 File Offset: 0x00A34DC8
		internal bool DataProfNLSAllowRxClrPackData_A36414_HiddenDynamic
		{
			get
			{
				short num = (short)643629057;
				if (num != 0)
				{
				}
				num = (short)1660832079;
				short num2 = num;
				num = (short)2076920143;
				switch (num2 == num)
				{
				}
				num = (short)2112880640;
				short num3 = num;
				num = (short)952238080;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414.HiddenDynamic;
			}
			set
			{
				short num = (short)1334318543;
				short num2 = num;
				num = (short)887166415;
				switch (num2 == num)
				{
				}
				num = (short)1674510337;
				if (num != 0)
				{
				}
				num = (short)1670512640;
				short num3 = num;
				num = (short)575864832;
				if (num != 0)
				{
				}
				this.dataProfNLSAllowRxClrPackData_A36414.HiddenDynamic = value;
			}
		}

		// Token: 0x1700585C RID: 22620
		// (get) Token: 0x0600B004 RID: 45060 RVA: 0x00A36C7C File Offset: 0x00A34E7C
		public bool DataProfNLSAllowRxClrPackData_A36414_HasDiffs
		{
			get
			{
				short num = (short)935108604;
				short num2 = num;
				num = (short)744923132;
				switch (num2 == num)
				{
				}
				num = (short)651493377;
				if (num != 0)
				{
				}
				num = (short)1504968704;
				short num3 = num;
				num = (short)873922560;
				if (num != 0)
				{
				}
				return this.dataProfNLSAllowRxClrPackData_A36414._HasDiffs;
			}
		}

		// Token: 0x1700585D RID: 22621
		// (get) Token: 0x0600B005 RID: 45061 RVA: 0x00A36D30 File Offset: 0x00A34F30
		// (set) Token: 0x0600B006 RID: 45062 RVA: 0x00A36DE4 File Offset: 0x00A34FE4
		public int DataProfNLSSecClrStrp_A36415Value
		{
			get
			{
				short num = (short)1485808511;
				short num2 = num;
				num = (short)676045695;
				switch (num2 == num)
				{
				}
				num = (short)1855651841;
				if (num != 0)
				{
				}
				num = (short)1254948864;
				short num3 = num;
				num = (short)894304256;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.Value;
			}
			set
			{
				short num = (short)1915234981;
				short num2 = num;
				num = (short)1704077989;
				switch (num2 == num)
				{
				}
				num = (short)929759232;
				if (num != 0)
				{
				}
				num = (short)1067384832;
				short num3 = num;
				num = (short)2041970689;
				if (num != 0)
				{
				}
				this.dataProfNLSSecClrStrp_A36415.Value = value;
			}
		}

		// Token: 0x1700585E RID: 22622
		// (get) Token: 0x0600B007 RID: 45063 RVA: 0x00A36E9C File Offset: 0x00A3509C
		// (set) Token: 0x0600B008 RID: 45064 RVA: 0x00A36F50 File Offset: 0x00A35150
		public string DataProfNLSSecClrStrp_A36415_UIValue
		{
			get
			{
				short num = (short)987693057;
				if (num != 0)
				{
				}
				num = (short)1138561879;
				short num2 = num;
				num = (short)585700183;
				switch (num2 == num)
				{
				}
				num = (short)2137128960;
				short num3 = num;
				num = (short)1664811008;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.UIValue;
			}
			set
			{
				short num = (short)1674678573;
				short num2 = num;
				num = (short)1601605933;
				switch (num2 == num)
				{
				}
				num = (short)630259713;
				if (num != 0)
				{
				}
				num = (short)1591607296;
				short num3 = num;
				num = (short)36831232;
				if (num != 0)
				{
				}
				this.dataProfNLSSecClrStrp_A36415.UIValue = value;
			}
		}

		// Token: 0x1700585F RID: 22623
		// (get) Token: 0x0600B009 RID: 45065 RVA: 0x00A37004 File Offset: 0x00A35204
		public global::AcpBusinessLayer.AcpListField DataProfNLSSecClrStrp_A36415
		{
			get
			{
				short num = (short)1953967432;
				short num2 = num;
				num = (short)322383176;
				switch (num2 == num)
				{
				}
				num = (short)780730368;
				if (num != 0)
				{
				}
				num = (short)1955659776;
				short num3 = num;
				num = (short)253231105;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415;
			}
		}

		// Token: 0x17005860 RID: 22624
		// (get) Token: 0x0600B00A RID: 45066 RVA: 0x00A370B8 File Offset: 0x00A352B8
		// (set) Token: 0x0600B00B RID: 45067 RVA: 0x00A3716C File Offset: 0x00A3536C
		public bool DataProfNLSSecClrStrp_A36415_Applicable
		{
			get
			{
				short num = (short)646552286;
				short num2 = num;
				num = (short)1300404958;
				switch (num2 == num)
				{
				}
				num = (short)164560897;
				if (num != 0)
				{
				}
				num = (short)913637376;
				short num3 = num;
				num = (short)358088704;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.Applicable;
			}
			set
			{
				short num = (short)2040659969;
				if (num != 0)
				{
				}
				num = (short)955603391;
				short num2 = num;
				num = (short)1072847295;
				switch (num2 == num)
				{
				}
				num = (short)562102272;
				short num3 = num;
				num = (short)294125568;
				if (num != 0)
				{
				}
				this.dataProfNLSSecClrStrp_A36415.Applicable = value;
			}
		}

		// Token: 0x17005861 RID: 22625
		// (get) Token: 0x0600B00C RID: 45068 RVA: 0x00A37220 File Offset: 0x00A35420
		// (set) Token: 0x0600B00D RID: 45069 RVA: 0x00A372D4 File Offset: 0x00A354D4
		public bool DataProfNLSSecClrStrp_A36415_Valid
		{
			get
			{
				short num = (short)2119105569;
				short num2 = num;
				num = (short)1689648161;
				switch (num2 == num)
				{
				}
				num = (short)1649606657;
				if (num != 0)
				{
				}
				num = (short)800194560;
				short num3 = num;
				num = (short)1232207872;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.Valid;
			}
			set
			{
				short num = (short)522439295;
				short num2 = num;
				num = (short)597543551;
				switch (num2 == num)
				{
				}
				num = (short)1553399809;
				if (num != 0)
				{
				}
				num = (short)899088384;
				short num3 = num;
				num = (short)940965888;
				if (num != 0)
				{
				}
				this.dataProfNLSSecClrStrp_A36415.Valid = value;
			}
		}

		// Token: 0x17005862 RID: 22626
		// (get) Token: 0x0600B00E RID: 45070 RVA: 0x00A3738C File Offset: 0x00A3558C
		// (set) Token: 0x0600B00F RID: 45071 RVA: 0x00A37444 File Offset: 0x00A35644
		public bool DataProfNLSSecClrStrp_A36415_Visible
		{
			get
			{
				short num = (short)1485701121;
				if (num != 0)
				{
				}
				num = (short)1115576139;
				short num2 = num;
				num = (short)991909707;
				switch (num2 == num)
				{
				}
				num = (short)458752000;
				short num3 = num;
				num = (short)1623392256;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.Visible;
			}
			set
			{
				short num = (short)2074279066;
				short num2 = num;
				num = (short)1447034010;
				switch (num2 == num)
				{
				}
				num = (short)1516699648;
				if (num != 0)
				{
				}
				num = (short)1684668416;
				short num3 = num;
				num = (short)468123649;
				if (num != 0)
				{
				}
				this.dataProfNLSSecClrStrp_A36415.Visible = value;
			}
		}

		// Token: 0x17005863 RID: 22627
		// (get) Token: 0x0600B010 RID: 45072 RVA: 0x00A374F8 File Offset: 0x00A356F8
		// (set) Token: 0x0600B011 RID: 45073 RVA: 0x00A375AC File Offset: 0x00A357AC
		public bool DataProfNLSSecClrStrp_A36415_Editable
		{
			get
			{
				short num = (short)1950375312;
				short num2 = num;
				num = (short)1465015696;
				switch (num2 == num)
				{
				}
				num = (short)391184384;
				if (num != 0)
				{
				}
				num = (short)520552448;
				short num3 = num;
				num = (short)326696961;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.Editable;
			}
			set
			{
				short num = (short)249757697;
				if (num != 0)
				{
				}
				num = (short)394684078;
				short num2 = num;
				num = (short)1517119150;
				switch (num2 == num)
				{
				}
				num = (short)2049048576;
				short num3 = num;
				num = (short)1352269824;
				if (num != 0)
				{
				}
				this.dataProfNLSSecClrStrp_A36415.Editable = value;
			}
		}

		// Token: 0x17005864 RID: 22628
		// (get) Token: 0x0600B012 RID: 45074 RVA: 0x00A37664 File Offset: 0x00A35864
		internal string DataProfNLSSecClrStrp_A36415_UILabel
		{
			get
			{
				short num = (short)1469816008;
				short num2 = num;
				num = (short)56990920;
				switch (num2 == num)
				{
				}
				num = (short)1737490432;
				if (num != 0)
				{
				}
				num = (short)141295616;
				short num3 = num;
				num = (short)1523122177;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.UIName;
			}
		}

		// Token: 0x17005865 RID: 22629
		// (get) Token: 0x0600B013 RID: 45075 RVA: 0x00A37718 File Offset: 0x00A35918
		// (set) Token: 0x0600B014 RID: 45076 RVA: 0x00A377CC File Offset: 0x00A359CC
		internal bool DataProfNLSSecClrStrp_A36415_HiddenStatic
		{
			get
			{
				short num = (short)1734462792;
				short num2 = num;
				num = (short)1980878152;
				switch (num2 == num)
				{
				}
				num = (short)709165057;
				if (num != 0)
				{
				}
				num = (short)1128136704;
				short num3 = num;
				num = (short)1923481600;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.HiddenStatic;
			}
			set
			{
				short num = (short)1748912761;
				short num2 = num;
				num = (short)297486969;
				switch (num2 == num)
				{
				}
				num = (short)1268449281;
				if (num != 0)
				{
				}
				num = (short)453443584;
				short num3 = num;
				num = (short)1638596608;
				if (num != 0)
				{
				}
				this.dataProfNLSSecClrStrp_A36415.HiddenStatic = value;
			}
		}

		// Token: 0x17005866 RID: 22630
		// (get) Token: 0x0600B015 RID: 45077 RVA: 0x00A3787C File Offset: 0x00A35A7C
		// (set) Token: 0x0600B016 RID: 45078 RVA: 0x00A37934 File Offset: 0x00A35B34
		internal bool DataProfNLSSecClrStrp_A36415_HiddenDynamic
		{
			get
			{
				short num = (short)1753140280;
				short num2 = num;
				num = (short)1953221688;
				switch (num2 == num)
				{
				}
				num = (short)743440385;
				if (num != 0)
				{
				}
				num = (short)1626144768;
				short num3 = num;
				num = (short)2091319296;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415.HiddenDynamic;
			}
			set
			{
				short num = (short)525866085;
				short num2 = num;
				num = (short)1150882917;
				switch (num2 == num)
				{
				}
				num = (short)1718484992;
				if (num != 0)
				{
				}
				num = (short)414973952;
				short num3 = num;
				num = (short)1644101633;
				if (num != 0)
				{
				}
				this.dataProfNLSSecClrStrp_A36415.HiddenDynamic = value;
			}
		}

		// Token: 0x17005867 RID: 22631
		// (get) Token: 0x0600B017 RID: 45079 RVA: 0x00A379EC File Offset: 0x00A35BEC
		public bool DataProfNLSSecClrStrp_A36415_HasDiffs
		{
			get
			{
				short num = (short)410787378;
				short num2 = num;
				num = (short)388308530;
				switch (num2 == num)
				{
				}
				num = (short)1376583681;
				if (num != 0)
				{
				}
				num = (short)472055808;
				short num3 = num;
				num = (short)1771110400;
				if (num != 0)
				{
				}
				return this.dataProfNLSSecClrStrp_A36415._HasDiffs;
			}
		}

		// Token: 0x17005868 RID: 22632
		// (get) Token: 0x0600B018 RID: 45080 RVA: 0x00A37AA4 File Offset: 0x00A35CA4
		// (set) Token: 0x0600B019 RID: 45081 RVA: 0x00A37B5C File Offset: 0x00A35D5C
		public int DataProfNLSKMFProfSele_A36419Value
		{
			get
			{
				short num = (short)2000695073;
				short num2 = num;
				num = (short)454242081;
				switch (num2 == num)
				{
				}
				num = (short)1388445696;
				if (num != 0)
				{
				}
				num = (short)1311768576;
				short num3 = num;
				num = (short)858324993;
				if (num != 0)
				{
				}
				return this.dataProfNLSKMFProfSele_A36419.Value;
			}
			set
			{
				short num = (short)1992818689;
				if (num != 0)
				{
				}
				num = (short)1759602228;
				short num2 = num;
				num = (short)2052286004;
				switch (num2 == num)
				{
				}
				num = (short)229769216;
				short num3 = num;
				num = (short)768868352;
				if (num != 0)
				{
				}
				this.dataProfNLSKMFProfSele_A36419.Value = value;
			}
		}

		// Token: 0x17005869 RID: 22633
		// (get) Token: 0x0600B01A RID: 45082 RVA: 0x00A37C10 File Offset: 0x00A35E10
		// (set) Token: 0x0600B01B RID: 45083 RVA: 0x00A37CC4 File Offset: 0x00A35EC4
		public string DataProfNLSKMFProfSele_A36419_UIValue
		{
			get
			{
				short num = (short)474261422;
				short num2 = num;
				num = (short)1006806958;
				switch (num2 == num)
				{
				}
				num = (short)353173504;
				if (num != 0)
				{
				}
				num = (short)108134400;
				short num3 = num;
				num = (short)922157057;
				if (num != 0)
				{
				}
				return this.dataProfNLSKMFProfSele_A36419.UIValue;
			}
			set
			{
				short num = (short)716844451;
				short num2 = num;
				num = (short)1963273635;
				switch (num2 == num)
				{
				}
				num = (short)2127822849;
				if (num != 0)
				{
				}
				num = (short)1686962176;
				short num3 = num;
				num = (short)1379926016;
				if (num != 0)
				{
				}
				this.dataProfNLSKMFProfSele_A36419.UIValue = value;
			}
		}

		// Token: 0x1700586A RID: 22634
		// (get) Token: 0x0600B01C RID: 45084 RVA: 0x00A37D78 File Offset: 0x00A35F78
		public global::AcpBusinessLayer.AcpRecRefField DataProfNLSKMFProfSele_A36419
		{
			get
			{
				short num = (short)635011599;
				short num2 = num;
				num = (short)1106084367;
				switch (num2 == num)
				{
				}
				num = (short)945487872;
				if (num != 0)
				{
				}
				num = (short)2029191168;
				short num3 = num;
				num = (short)1822425089;
				if (num != 0)
				{
				}
				return this.dataProfNLSKMFProfSele_A36419;
			}
		}

		// Token: 0x1700586B RID: 22635
		// (get) Token: 0x0600B01D RID: 45085 RVA: 0x00A37E28 File Offset: 0x00A36028
		// (set) Token: 0x0600B01E RID: 45086 RVA: 0x00A37EDC File Offset: 0x00A360DC
		public bool DataProfNLSKMFProfSele_A36419_Applicable
		{
			get
			{
				short num = (short)55132096;
				short num2 = num;
				num = (short)136003520;
				switch (num2 == num)
				{
				}
				num = (short)667156481;
				if (num != 0)
				{
				}
				num = (short)1740701696;
				short num3 = num;
				num = (short)431816704;
				if (num != 0)
				{
				}
				return this.dataProfNLSKMFProfSele_A36419.Applicable;
			}
			set
			{
				short num = (short)1357943467;
				short num2 = num;
				num = (short)1824297643;
				switch (num2 == num)
				{
				}
				num = (short)601423873;
				if (num != 0)
				{
				}
				num = (short)2112290816;
				short num3 = num;
				num = (short)1258553344;
				if (num != 0)
				{
				}
				this.dataProfNLSKMFProfSele_A36419.Applicable = value;
			}
		}

		// Token: 0x1700586C RID: 22636
		// (get) Token: 0x0600B01F RID: 45087 RVA: 0x00A37F90 File Offset: 0x00A36190
		// (set) Token: 0x0600B020 RID: 45088 RVA: 0x00A38044 File Offset: 0x00A36244
		public bool DataProfNLSKMFProfSele_A36419_Valid
		{
			get
			{
				short num = (short)329005734;
				short num2 = num;
				num = (short)1337932454;
				switch (num2 == num)
				{
				}
				num = (short)485359616;
				if (num != 0)
				{
				}
				num = (short)567279617;
				if (num != 0)
				{
				}
				num = (short)630652928;
				short num3 = num;
				return this.dataProfNLSKMFProfSele_A36419.Valid;
			}
			set
			{
				short num = (short)933494785;
				if (num != 0)
				{
				}
				num = (short)1959971808;
				short num2 = num;
				num = (short)1345047520;
				switch (num2 == num)
				{
				}
				num = (short)801112064;
				if (num != 0)
				{
				}
				num = (short)1533083648;
				short num3 = num;
				this.dataProfNLSKMFProfSele_A36419.Valid = value;
			}
		}

		// Token: 0x1700586D RID: 22637
		// (get) Token: 0x0600B021 RID: 45089 RVA: 0x00A380FC File Offset: 0x00A362FC
		// (set) Token: 0x0600B022 RID: 45090 RVA: 0x00A381B0 File Offset: 0x00A363B0
		public bool DataProfNLSKMFProfSele_A36419_Visible
		{
			get
			{
				short num = (short)2016780135;
				short num2 = num;
				num = (short)481206119;
				switch (num2 == num)
				{
				}
				num = (short)356581377;
				if (num != 0)
				{
				}
				num = (short)2117795840;
				if (num != 0)
				{
				}
				num = (short)66715648;
				short num3 = num;
				return this.dataProfNLSKMFProfSele_A36419.Visible;
			}
			set
			{
				short num = (short)1889828169;
				short num2 = num;
				num = (short)377716041;
				switch (num2 == num)
				{
				}
				num = (short)1537802241;
				if (num != 0)
				{
				}
				num = (short)972161024;
				if (num != 0)
				{
				}
				num = (short)1407713280;
				short num3 = num;
				this.dataProfNLSKMFProfSele_A36419.Visible = value;
			}
		}

		// Token: 0x1700586E RID: 22638
		// (get) Token: 0x0600B023 RID: 45091 RVA: 0x00A38264 File Offset: 0x00A36464
		// (set) Token: 0x0600B024 RID: 45092 RVA: 0x00A3831C File Offset: 0x00A3651C
		public bool DataProfNLSKMFProfSele_A36419_Editable
		{
			get
			{
				short num = (short)872978520;
				short num2 = num;
				num = (short)1157601368;
				switch (num2 == num)
				{
				}
				num = (short)2064515073;
				if (num != 0)
				{
				}
				num = (short)1590099968;
				if (num != 0)
				{
				}
				num = (short)1065418752;
				short num3 = num;
				return this.dataProfNLSKMFProfSele_A36419.Editable;
			}
			set
			{
				short num = (short)335006059;
				short num2 = num;
				num = (short)756599147;
				switch (num2 == num)
				{
				}
				num = (short)350814209;
				if (num != 0)
				{
				}
				num = (short)331612160;
				if (num != 0)
				{
				}
				num = (short)1964244992;
				short num3 = num;
				this.dataProfNLSKMFProfSele_A36419.Editable = value;
			}
		}

		// Token: 0x1700586F RID: 22639
		// (get) Token: 0x0600B025 RID: 45093 RVA: 0x00A383D4 File Offset: 0x00A365D4
		internal string DataProfNLSKMFProfSele_A36419_UILabel
		{
			get
			{
				short num = (short)1690357355;
				short num2 = num;
				num = (short)1892142699;
				switch (num2 == num)
				{
				}
				num = (short)938541057;
				if (num != 0)
				{
				}
				num = (short)1463615488;
				if (num != 0)
				{
				}
				num = (short)1270611968;
				short num3 = num;
				return this.dataProfNLSKMFProfSele_A36419.UIName;
			}
		}

		// Token: 0x17005870 RID: 22640
		// (get) Token: 0x0600B026 RID: 45094 RVA: 0x00A3848C File Offset: 0x00A3668C
		// (set) Token: 0x0600B027 RID: 45095 RVA: 0x00A38544 File Offset: 0x00A36744
		internal bool DataProfNLSKMFProfSele_A36419_HiddenStatic
		{
			get
			{
				short num = (short)1333879383;
				short num2 = num;
				num = (short)1777558103;
				switch (num2 == num)
				{
				}
				num = (short)450691072;
				if (num != 0)
				{
				}
				num = (short)1263665153;
				if (num != 0)
				{
				}
				num = (short)210567168;
				short num3 = num;
				return this.dataProfNLSKMFProfSele_A36419.HiddenStatic;
			}
			set
			{
				short num = (short)953439003;
				short num2 = num;
				num = (short)749490971;
				switch (num2 == num)
				{
				}
				num = (short)275054593;
				if (num != 0)
				{
				}
				num = (short)1446969344;
				if (num != 0)
				{
				}
				num = (short)2087583744;
				short num3 = num;
				this.dataProfNLSKMFProfSele_A36419.HiddenStatic = value;
			}
		}

		// Token: 0x17005871 RID: 22641
		// (get) Token: 0x0600B028 RID: 45096 RVA: 0x00A385FC File Offset: 0x00A367FC
		// (set) Token: 0x0600B029 RID: 45097 RVA: 0x00A386B4 File Offset: 0x00A368B4
		internal bool DataProfNLSKMFProfSele_A36419_HiddenDynamic
		{
			get
			{
				short num = (short)191546601;
				short num2 = num;
				num = (short)1770046697;
				switch (num2 == num)
				{
				}
				num = (short)1074331648;
				if (num != 0)
				{
				}
				num = (short)315162625;
				if (num != 0)
				{
				}
				num = (short)2127429632;
				short num3 = num;
				return this.dataProfNLSKMFProfSele_A36419.HiddenDynamic;
			}
			set
			{
				short num = (short)1516472503;
				short num2 = num;
				num = (short)2010286263;
				switch (num2 == num)
				{
				}
				num = (short)1695350784;
				if (num != 0)
				{
				}
				num = (short)1737162753;
				if (num != 0)
				{
				}
				num = (short)337707008;
				short num3 = num;
				this.dataProfNLSKMFProfSele_A36419.HiddenDynamic = value;
			}
		}

		// Token: 0x17005872 RID: 22642
		// (get) Token: 0x0600B02A RID: 45098 RVA: 0x00A38768 File Offset: 0x00A36968
		public bool DataProfNLSKMFProfSele_A36419_HasDiffs
		{
			get
			{
				short num = (short)91713093;
				short num2 = num;
				num = (short)1127640645;
				switch (num2 == num)
				{
				}
				num = (short)1938096129;
				if (num != 0)
				{
				}
				num = (short)1500315648;
				if (num != 0)
				{
				}
				num = (short)951451648;
				short num3 = num;
				return this.dataProfNLSKMFProfSele_A36419._HasDiffs;
			}
		}

		// Token: 0x17005873 RID: 22643
		// (get) Token: 0x0600B02B RID: 45099 RVA: 0x00A3881C File Offset: 0x00A36A1C
		// (set) Token: 0x0600B02C RID: 45100 RVA: 0x00A388CC File Offset: 0x00A36ACC
		public long DataProfVPNGatewayIPAddress_A42079Value
		{
			get
			{
				short num = (short)2129253731;
				short num2 = num;
				num = (short)1965348195;
				switch (num2 == num)
				{
				}
				num = (short)1264910337;
				if (num != 0)
				{
				}
				num = (short)92995584;
				if (num != 0)
				{
				}
				num = (short)1874460672;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.Value;
			}
			set
			{
				short num = (short)762387203;
				short num2 = num;
				num = (short)318118659;
				switch (num2 == num)
				{
				}
				num = (short)530841601;
				if (num != 0)
				{
				}
				num = (short)2048131072;
				if (num != 0)
				{
				}
				num = (short)1498284032;
				short num3 = num;
				this.dataProfVPNGatewayIPAddress_A42079.Value = value;
			}
		}

		// Token: 0x17005874 RID: 22644
		// (get) Token: 0x0600B02D RID: 45101 RVA: 0x00A38984 File Offset: 0x00A36B84
		// (set) Token: 0x0600B02E RID: 45102 RVA: 0x00A38A3C File Offset: 0x00A36C3C
		public string DataProfVPNGatewayIPAddress_A42079_UIValue
		{
			get
			{
				short num = (short)1010171905;
				if (num != 0)
				{
				}
				num = (short)1836042026;
				short num2 = num;
				num = (short)980666154;
				switch (num2 == num)
				{
				}
				num = (short)1888092160;
				if (num != 0)
				{
				}
				num = (short)761200640;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.UIValue;
			}
			set
			{
				short num = (short)476433947;
				short num2 = num;
				num = (short)587124251;
				switch (num2 == num)
				{
				}
				num = (short)1266155521;
				if (num != 0)
				{
				}
				num = (short)1676214272;
				if (num != 0)
				{
				}
				num = (short)18546688;
				short num3 = num;
				this.dataProfVPNGatewayIPAddress_A42079.UIValue = value;
			}
		}

		// Token: 0x17005875 RID: 22645
		// (get) Token: 0x0600B02F RID: 45103 RVA: 0x00A38AF4 File Offset: 0x00A36CF4
		public global::AcpBusinessLayer.AcpIPAddressField DataProfVPNGatewayIPAddress_A42079
		{
			get
			{
				short num = (short)995334903;
				short num2 = num;
				num = (short)1840356087;
				switch (num2 == num)
				{
				}
				num = (short)1664942081;
				if (num != 0)
				{
				}
				num = (short)1117913088;
				if (num != 0)
				{
				}
				num = (short)1661665280;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079;
			}
		}

		// Token: 0x17005876 RID: 22646
		// (get) Token: 0x0600B030 RID: 45104 RVA: 0x00A38BA4 File Offset: 0x00A36DA4
		// (set) Token: 0x0600B031 RID: 45105 RVA: 0x00A38C58 File Offset: 0x00A36E58
		public bool DataProfVPNGatewayIPAddress_A42079_Applicable
		{
			get
			{
				short num = (short)1228481056;
				short num2 = num;
				num = (short)596189728;
				switch (num2 == num)
				{
				}
				num = (short)1300692992;
				if (num != 0)
				{
				}
				num = (short)960757761;
				if (num != 0)
				{
				}
				num = (short)375259136;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.Applicable;
			}
			set
			{
				short num = (short)1507934223;
				short num2 = num;
				num = (short)292503567;
				switch (num2 == num)
				{
				}
				num = (short)750583809;
				if (num != 0)
				{
				}
				num = (short)2118189056;
				if (num != 0)
				{
				}
				num = (short)1359085568;
				short num3 = num;
				this.dataProfVPNGatewayIPAddress_A42079.Applicable = value;
			}
		}

		// Token: 0x17005877 RID: 22647
		// (get) Token: 0x0600B032 RID: 45106 RVA: 0x00A38D10 File Offset: 0x00A36F10
		// (set) Token: 0x0600B033 RID: 45107 RVA: 0x00A38DC4 File Offset: 0x00A36FC4
		public bool DataProfVPNGatewayIPAddress_A42079_Valid
		{
			get
			{
				short num = (short)331088721;
				short num2 = num;
				num = (short)488702801;
				switch (num2 == num)
				{
				}
				num = (short)1616576513;
				if (num != 0)
				{
				}
				num = (short)328466432;
				if (num != 0)
				{
				}
				num = (short)194510848;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.Valid;
			}
			set
			{
				short num = (short)1710653681;
				short num2 = num;
				num = (short)1204257009;
				switch (num2 == num)
				{
				}
				num = (short)1558446081;
				if (num != 0)
				{
				}
				num = (short)548012032;
				if (num != 0)
				{
				}
				num = (short)320536576;
				short num3 = num;
				this.dataProfVPNGatewayIPAddress_A42079.Valid = value;
			}
		}

		// Token: 0x17005878 RID: 22648
		// (get) Token: 0x0600B034 RID: 45108 RVA: 0x00A38E78 File Offset: 0x00A37078
		// (set) Token: 0x0600B035 RID: 45109 RVA: 0x00A38F2C File Offset: 0x00A3712C
		public bool DataProfVPNGatewayIPAddress_A42079_Visible
		{
			get
			{
				short num = (short)209972301;
				short num2 = num;
				num = (short)1085271117;
				switch (num2 == num)
				{
				}
				num = (short)664600576;
				if (num != 0)
				{
				}
				num = (short)906231809;
				if (num != 0)
				{
				}
				num = (short)283574272;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.Visible;
			}
			set
			{
				short num = (short)593580887;
				short num2 = num;
				num = (short)1812026199;
				switch (num2 == num)
				{
				}
				num = (short)218365953;
				if (num != 0)
				{
				}
				num = (short)200867840;
				if (num != 0)
				{
				}
				num = (short)1288503296;
				short num3 = num;
				this.dataProfVPNGatewayIPAddress_A42079.Visible = value;
			}
		}

		// Token: 0x17005879 RID: 22649
		// (get) Token: 0x0600B036 RID: 45110 RVA: 0x00A38FDC File Offset: 0x00A371DC
		// (set) Token: 0x0600B037 RID: 45111 RVA: 0x00A39090 File Offset: 0x00A37290
		public bool DataProfVPNGatewayIPAddress_A42079_Editable
		{
			get
			{
				short num = (short)478850681;
				short num2 = num;
				num = (short)78032505;
				switch (num2 == num)
				{
				}
				num = (short)1142947841;
				if (num != 0)
				{
				}
				num = (short)2134048768;
				if (num != 0)
				{
				}
				num = (short)645529600;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.Editable;
			}
			set
			{
				short num = (short)607518721;
				if (num != 0)
				{
				}
				num = (short)64607755;
				short num2 = num;
				num = (short)1511511563;
				switch (num2 == num)
				{
				}
				num = (short)807993344;
				if (num != 0)
				{
				}
				num = (short)561774592;
				short num3 = num;
				this.dataProfVPNGatewayIPAddress_A42079.Editable = value;
			}
		}

		// Token: 0x1700587A RID: 22650
		// (get) Token: 0x0600B038 RID: 45112 RVA: 0x00A39144 File Offset: 0x00A37344
		internal string DataProfVPNGatewayIPAddress_A42079_UILabel
		{
			get
			{
				short num = (short)1331049628;
				short num2 = num;
				num = (short)543831196;
				switch (num2 == num)
				{
				}
				num = (short)1456930816;
				if (num != 0)
				{
				}
				num = (short)685178881;
				if (num != 0)
				{
				}
				num = (short)1217331200;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.UIName;
			}
		}

		// Token: 0x1700587B RID: 22651
		// (get) Token: 0x0600B039 RID: 45113 RVA: 0x00A391F8 File Offset: 0x00A373F8
		// (set) Token: 0x0600B03A RID: 45114 RVA: 0x00A392AC File Offset: 0x00A374AC
		internal bool DataProfVPNGatewayIPAddress_A42079_HiddenStatic
		{
			get
			{
				short num = (short)114305820;
				short num2 = num;
				num = (short)1954687772;
				switch (num2 == num)
				{
				}
				num = (short)1089077248;
				if (num != 0)
				{
				}
				num = (short)594214913;
				if (num != 0)
				{
				}
				num = (short)1154285568;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.HiddenStatic;
			}
			set
			{
				short num = (short)381740717;
				short num2 = num;
				num = (short)1983899309;
				switch (num2 == num)
				{
				}
				num = (short)706805761;
				if (num != 0)
				{
				}
				num = (short)1716060160;
				if (num != 0)
				{
				}
				num = (short)71172096;
				short num3 = num;
				this.dataProfVPNGatewayIPAddress_A42079.HiddenStatic = value;
			}
		}

		// Token: 0x1700587C RID: 22652
		// (get) Token: 0x0600B03B RID: 45115 RVA: 0x00A39364 File Offset: 0x00A37564
		// (set) Token: 0x0600B03C RID: 45116 RVA: 0x00A39418 File Offset: 0x00A37618
		internal bool DataProfVPNGatewayIPAddress_A42079_HiddenDynamic
		{
			get
			{
				short num = (short)30081025;
				if (num != 0)
				{
				}
				num = (short)1284913608;
				short num2 = num;
				num = (short)549927368;
				switch (num2 == num)
				{
				}
				num = (short)390332416;
				if (num != 0)
				{
				}
				num = (short)798883840;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079.HiddenDynamic;
			}
			set
			{
				short num = (short)24968144;
				short num2 = num;
				num = (short)1267858384;
				switch (num2 == num)
				{
				}
				num = (short)1407451137;
				if (num != 0)
				{
				}
				num = (short)856031232;
				if (num != 0)
				{
				}
				num = (short)804585472;
				short num3 = num;
				this.dataProfVPNGatewayIPAddress_A42079.HiddenDynamic = value;
			}
		}

		// Token: 0x1700587D RID: 22653
		// (get) Token: 0x0600B03D RID: 45117 RVA: 0x00A394D0 File Offset: 0x00A376D0
		public bool DataProfVPNGatewayIPAddress_A42079_HasDiffs
		{
			get
			{
				short num = (short)1101266177;
				short num2 = num;
				num = (short)1222573313;
				switch (num2 == num)
				{
				}
				num = (short)1886322689;
				if (num != 0)
				{
				}
				num = (short)1794834432;
				if (num != 0)
				{
				}
				num = (short)911212544;
				short num3 = num;
				return this.dataProfVPNGatewayIPAddress_A42079._HasDiffs;
			}
		}

		// Token: 0x1700587E RID: 22654
		// (get) Token: 0x0600B03E RID: 45118 RVA: 0x00A39584 File Offset: 0x00A37784
		// (set) Token: 0x0600B03F RID: 45119 RVA: 0x00A3963C File Offset: 0x00A3783C
		public int DataProfVPNSecClrStrp_A42120Value
		{
			get
			{
				short num = (short)1434292552;
				short num2 = num;
				num = (short)1978831176;
				switch (num2 == num)
				{
				}
				num = (short)1713700865;
				if (num != 0)
				{
				}
				num = (short)769982464;
				if (num != 0)
				{
				}
				num = (short)1305280512;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.Value;
			}
			set
			{
				short num = (short)96620909;
				short num2 = num;
				num = (short)1104040301;
				switch (num2 == num)
				{
				}
				num = (short)16515072;
				if (num != 0)
				{
				}
				num = (short)12648449;
				if (num != 0)
				{
				}
				num = (short)1097465856;
				short num3 = num;
				this.dataProfVPNSecClrStrp_A42120.Value = value;
			}
		}

		// Token: 0x1700587F RID: 22655
		// (get) Token: 0x0600B040 RID: 45120 RVA: 0x00A396F0 File Offset: 0x00A378F0
		// (set) Token: 0x0600B041 RID: 45121 RVA: 0x00A397A8 File Offset: 0x00A379A8
		public string DataProfVPNSecClrStrp_A42120_UIValue
		{
			get
			{
				short num = (short)1156881053;
				short num2 = num;
				num = (short)957085;
				switch (num2 == num)
				{
				}
				num = (short)947060737;
				if (num != 0)
				{
				}
				num = (short)277807104;
				if (num != 0)
				{
				}
				num = (short)734330880;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.UIValue;
			}
			set
			{
				short num = (short)1774936120;
				short num2 = num;
				num = (short)1142906936;
				switch (num2 == num)
				{
				}
				num = (short)2134900737;
				if (num != 0)
				{
				}
				num = (short)1020657664;
				if (num != 0)
				{
				}
				num = (short)816971776;
				short num3 = num;
				this.dataProfVPNSecClrStrp_A42120.UIValue = value;
			}
		}

		// Token: 0x17005880 RID: 22656
		// (get) Token: 0x0600B042 RID: 45122 RVA: 0x00A39860 File Offset: 0x00A37A60
		public global::AcpBusinessLayer.AcpListField DataProfVPNSecClrStrp_A42120
		{
			get
			{
				short num = (short)819134465;
				if (num != 0)
				{
				}
				num = (short)1795984863;
				short num2 = num;
				num = (short)1797426655;
				switch (num2 == num)
				{
				}
				num = (short)419889152;
				if (num != 0)
				{
				}
				num = (short)38797312;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120;
			}
		}

		// Token: 0x17005881 RID: 22657
		// (get) Token: 0x0600B043 RID: 45123 RVA: 0x00A3990C File Offset: 0x00A37B0C
		// (set) Token: 0x0600B044 RID: 45124 RVA: 0x00A399C4 File Offset: 0x00A37BC4
		public bool DataProfVPNSecClrStrp_A42120_Applicable
		{
			get
			{
				short num = (short)966352057;
				short num2 = num;
				num = (short)1584553145;
				switch (num2 == num)
				{
				}
				num = (short)1344405505;
				if (num != 0)
				{
				}
				num = (short)459210752;
				if (num != 0)
				{
				}
				num = (short)31195136;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.Applicable;
			}
			set
			{
				short num = (short)771162113;
				if (num != 0)
				{
				}
				num = (short)1261456693;
				short num2 = num;
				num = (short)1947946293;
				switch (num2 == num)
				{
				}
				num = (short)760020992;
				if (num != 0)
				{
				}
				num = (short)1904214016;
				short num3 = num;
				this.dataProfVPNSecClrStrp_A42120.Applicable = value;
			}
		}

		// Token: 0x17005882 RID: 22658
		// (get) Token: 0x0600B045 RID: 45125 RVA: 0x00A39A78 File Offset: 0x00A37C78
		// (set) Token: 0x0600B046 RID: 45126 RVA: 0x00A39B28 File Offset: 0x00A37D28
		public bool DataProfVPNSecClrStrp_A42120_Valid
		{
			get
			{
				short num = (short)505528050;
				short num2 = num;
				num = (short)1265942258;
				switch (num2 == num)
				{
				}
				num = (short)672661505;
				if (num != 0)
				{
				}
				num = (short)1012793344;
				if (num != 0)
				{
				}
				num = (short)1976958976;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.Valid;
			}
			set
			{
				short num = (short)2026189615;
				short num2 = num;
				num = (short)58602287;
				switch (num2 == num)
				{
				}
				num = (short)643760129;
				if (num != 0)
				{
				}
				num = (short)1511981056;
				if (num != 0)
				{
				}
				num = (short)1147928576;
				short num3 = num;
				this.dataProfVPNSecClrStrp_A42120.Valid = value;
			}
		}

		// Token: 0x17005883 RID: 22659
		// (get) Token: 0x0600B047 RID: 45127 RVA: 0x00A39BDC File Offset: 0x00A37DDC
		// (set) Token: 0x0600B048 RID: 45128 RVA: 0x00A39C90 File Offset: 0x00A37E90
		public bool DataProfVPNSecClrStrp_A42120_Visible
		{
			get
			{
				short num = (short)384732965;
				short num2 = num;
				num = (short)114855717;
				switch (num2 == num)
				{
				}
				num = (short)694681601;
				if (num != 0)
				{
				}
				num = (short)106758144;
				if (num != 0)
				{
				}
				num = (short)1372127232;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.Visible;
			}
			set
			{
				short num = (short)1984758871;
				short num2 = num;
				num = (short)1899365463;
				switch (num2 == num)
				{
				}
				num = (short)1024262145;
				if (num != 0)
				{
				}
				num = (short)1513291776;
				if (num != 0)
				{
				}
				num = (short)2014707712;
				short num3 = num;
				this.dataProfVPNSecClrStrp_A42120.Visible = value;
			}
		}

		// Token: 0x17005884 RID: 22660
		// (get) Token: 0x0600B049 RID: 45129 RVA: 0x00A39D48 File Offset: 0x00A37F48
		// (set) Token: 0x0600B04A RID: 45130 RVA: 0x00A39DFC File Offset: 0x00A37FFC
		public bool DataProfVPNSecClrStrp_A42120_Editable
		{
			get
			{
				short num = (short)34359725;
				short num2 = num;
				num = (short)1872316845;
				switch (num2 == num)
				{
				}
				num = (short)863043585;
				if (num != 0)
				{
				}
				num = (short)162725888;
				if (num != 0)
				{
				}
				num = (short)159252480;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.Editable;
			}
			set
			{
				short num = (short)1919223903;
				short num2 = num;
				num = (short)1741621343;
				switch (num2 == num)
				{
				}
				num = (short)967311361;
				if (num != 0)
				{
				}
				num = (short)2121793536;
				if (num != 0)
				{
				}
				num = (short)1980628992;
				short num3 = num;
				this.dataProfVPNSecClrStrp_A42120.Editable = value;
			}
		}

		// Token: 0x17005885 RID: 22661
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x00A39EB4 File Offset: 0x00A380B4
		internal string DataProfVPNSecClrStrp_A42120_UILabel
		{
			get
			{
				short num = (short)568443330;
				short num2 = num;
				num = (short)1112654274;
				switch (num2 == num)
				{
				}
				num = (short)2044657665;
				if (num != 0)
				{
				}
				num = (short)200802304;
				if (num != 0)
				{
				}
				num = (short)24772608;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.UIName;
			}
		}

		// Token: 0x17005886 RID: 22662
		// (get) Token: 0x0600B04C RID: 45132 RVA: 0x00A39F6C File Offset: 0x00A3816C
		// (set) Token: 0x0600B04D RID: 45133 RVA: 0x00A3A024 File Offset: 0x00A38224
		internal bool DataProfVPNSecClrStrp_A42120_HiddenStatic
		{
			get
			{
				short num = (short)8257537;
				if (num != 0)
				{
				}
				num = (short)355425779;
				short num2 = num;
				num = (short)1455513075;
				switch (num2 == num)
				{
				}
				num = (short)2082734080;
				if (num != 0)
				{
				}
				num = (short)331546624;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.HiddenStatic;
			}
			set
			{
				short num = (short)966672130;
				short num2 = num;
				num = (short)316882690;
				switch (num2 == num)
				{
				}
				num = (short)986185729;
				if (num != 0)
				{
				}
				num = (short)306905088;
				if (num != 0)
				{
				}
				num = (short)572522496;
				short num3 = num;
				this.dataProfVPNSecClrStrp_A42120.HiddenStatic = value;
			}
		}

		// Token: 0x17005887 RID: 22663
		// (get) Token: 0x0600B04E RID: 45134 RVA: 0x00A3A0D8 File Offset: 0x00A382D8
		// (set) Token: 0x0600B04F RID: 45135 RVA: 0x00A3A190 File Offset: 0x00A38390
		internal bool DataProfVPNSecClrStrp_A42120_HiddenDynamic
		{
			get
			{
				short num = (short)1807614767;
				short num2 = num;
				num = (short)66847535;
				switch (num2 == num)
				{
				}
				num = (short)1132331009;
				if (num != 0)
				{
				}
				num = (short)930611200;
				if (num != 0)
				{
				}
				num = (short)241500160;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120.HiddenDynamic;
			}
			set
			{
				short num = (short)343238646;
				short num2 = num;
				num = (short)346580982;
				switch (num2 == num)
				{
				}
				num = (short)2013528064;
				if (num != 0)
				{
				}
				num = (short)1920073729;
				if (num != 0)
				{
				}
				num = (short)907280384;
				short num3 = num;
				this.dataProfVPNSecClrStrp_A42120.HiddenDynamic = value;
			}
		}

		// Token: 0x17005888 RID: 22664
		// (get) Token: 0x0600B050 RID: 45136 RVA: 0x00A3A244 File Offset: 0x00A38444
		public bool DataProfVPNSecClrStrp_A42120_HasDiffs
		{
			get
			{
				short num = (short)1975883801;
				short num2 = num;
				num = (short)2027722777;
				switch (num2 == num)
				{
				}
				num = (short)447152129;
				if (num != 0)
				{
				}
				num = (short)2116222976;
				if (num != 0)
				{
				}
				num = (short)2086207488;
				short num3 = num;
				return this.dataProfVPNSecClrStrp_A42120._HasDiffs;
			}
		}

		// Token: 0x17005889 RID: 22665
		// (get) Token: 0x0600B051 RID: 45137 RVA: 0x00A3A2FC File Offset: 0x00A384FC
		// (set) Token: 0x0600B052 RID: 45138 RVA: 0x00A3A3B0 File Offset: 0x00A385B0
		public int DataProfVPNMessageRetransmissionTime_A42209Value
		{
			get
			{
				short num = (short)1403325623;
				short num2 = num;
				num = (short)951651511;
				switch (num2 == num)
				{
				}
				num = (short)1958150144;
				if (num != 0)
				{
				}
				num = (short)1198653441;
				if (num != 0)
				{
				}
				num = (short)1895170048;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.Value;
			}
			set
			{
				short num = (short)2111769475;
				short num2 = num;
				num = (short)1815022467;
				switch (num2 == num)
				{
				}
				num = (short)638910465;
				if (num != 0)
				{
				}
				num = (short)528285696;
				if (num != 0)
				{
				}
				num = (short)118947840;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.Value = value;
			}
		}

		// Token: 0x1700588A RID: 22666
		// (get) Token: 0x0600B053 RID: 45139 RVA: 0x00A3A46C File Offset: 0x00A3866C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfVPNMessageRetransmissionTime_A42209
		{
			get
			{
				short num = (short)523256320;
				short num2 = num;
				num = (short)263733760;
				switch (num2 == num)
				{
				}
				num = (short)1160249345;
				if (num != 0)
				{
				}
				num = (short)522387456;
				if (num != 0)
				{
				}
				num = (short)264896512;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209;
			}
		}

		// Token: 0x1700588B RID: 22667
		// (get) Token: 0x0600B054 RID: 45140 RVA: 0x00A3A51C File Offset: 0x00A3871C
		// (set) Token: 0x0600B055 RID: 45141 RVA: 0x00A3A5D4 File Offset: 0x00A387D4
		public string DataProfVPNMessageRetransmissionTime_A42209_UIValue
		{
			get
			{
				short num = (short)207830127;
				short num2 = num;
				num = (short)272055407;
				switch (num2 == num)
				{
				}
				num = (short)492306432;
				if (num != 0)
				{
				}
				num = (short)761004033;
				if (num != 0)
				{
				}
				num = (short)1124597760;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.UIValue;
			}
			set
			{
				short num = (short)548339713;
				if (num != 0)
				{
				}
				num = (short)648745401;
				short num2 = num;
				num = (short)1627001273;
				switch (num2 == num)
				{
				}
				num = (short)1255538688;
				if (num != 0)
				{
				}
				num = (short)1308295168;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.UIValue = value;
			}
		}

		// Token: 0x1700588C RID: 22668
		// (get) Token: 0x0600B056 RID: 45142 RVA: 0x00A3A68C File Offset: 0x00A3888C
		// (set) Token: 0x0600B057 RID: 45143 RVA: 0x00A3A740 File Offset: 0x00A38940
		internal int DataProfVPNMessageRetransmissionTime_A42209Min
		{
			get
			{
				short num = (short)1553813080;
				short num2 = num;
				num = (short)709709400;
				switch (num2 == num)
				{
				}
				num = (short)1682833409;
				if (num != 0)
				{
				}
				num = (short)951582720;
				if (num != 0)
				{
				}
				num = (short)896270336;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.Min;
			}
			set
			{
				short num = (short)1906145416;
				short num2 = num;
				num = (short)978876552;
				switch (num2 == num)
				{
				}
				num = (short)564985856;
				if (num != 0)
				{
				}
				num = (short)1491140609;
				if (num != 0)
				{
				}
				num = (short)1343356928;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.Min = value;
			}
		}

		// Token: 0x1700588D RID: 22669
		// (get) Token: 0x0600B058 RID: 45144 RVA: 0x00A3A7F4 File Offset: 0x00A389F4
		// (set) Token: 0x0600B059 RID: 45145 RVA: 0x00A3A8A8 File Offset: 0x00A38AA8
		internal int DataProfVPNMessageRetransmissionTime_A42209Max
		{
			get
			{
				short num = (short)2120085742;
				short num2 = num;
				num = (short)81981678;
				switch (num2 == num)
				{
				}
				num = (short)1878458369;
				if (num != 0)
				{
				}
				num = (short)848494592;
				if (num != 0)
				{
				}
				num = (short)596770816;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.Max;
			}
			set
			{
				short num = (short)278374206;
				short num2 = num;
				num = (short)1183426366;
				switch (num2 == num)
				{
				}
				num = (short)692584449;
				if (num != 0)
				{
				}
				num = (short)1141964800;
				if (num != 0)
				{
				}
				num = (short)1448411136;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.Max = value;
			}
		}

		// Token: 0x1700588E RID: 22670
		// (get) Token: 0x0600B05A RID: 45146 RVA: 0x00A3A95C File Offset: 0x00A38B5C
		// (set) Token: 0x0600B05B RID: 45147 RVA: 0x00A3AA10 File Offset: 0x00A38C10
		internal int DataProfVPNMessageRetransmissionTime_A42209Step
		{
			get
			{
				short num = (short)349594556;
				short num2 = num;
				num = (short)795108284;
				switch (num2 == num)
				{
				}
				num = (short)1796407297;
				if (num != 0)
				{
				}
				num = (short)564133888;
				if (num != 0)
				{
				}
				num = (short)1563754496;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.StepSize;
			}
			set
			{
				short num = (short)1634967118;
				short num2 = num;
				num = (short)618962510;
				switch (num2 == num)
				{
				}
				num = (short)2127036416;
				if (num != 0)
				{
				}
				num = (short)739246081;
				if (num != 0)
				{
				}
				num = (short)736493568;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.StepSize = value;
			}
		}

		// Token: 0x1700588F RID: 22671
		// (get) Token: 0x0600B05C RID: 45148 RVA: 0x00A3AAC4 File Offset: 0x00A38CC4
		// (set) Token: 0x0600B05D RID: 45149 RVA: 0x00A3AB78 File Offset: 0x00A38D78
		public bool DataProfVPNMessageRetransmissionTime_A42209_Applicable
		{
			get
			{
				short num = (short)55044029;
				short num2 = num;
				num = (short)1672341437;
				switch (num2 == num)
				{
				}
				num = (short)398655488;
				if (num != 0)
				{
				}
				num = (short)513146881;
				if (num != 0)
				{
				}
				num = (short)328925184;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.Applicable;
			}
			set
			{
				short num = (short)723658895;
				short num2 = num;
				num = (short)350824591;
				switch (num2 == num)
				{
				}
				num = (short)929628161;
				if (num != 0)
				{
				}
				num = (short)1469251584;
				if (num != 0)
				{
				}
				num = (short)1111687168;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.Applicable = value;
			}
		}

		// Token: 0x17005890 RID: 22672
		// (get) Token: 0x0600B05E RID: 45150 RVA: 0x00A3AC2C File Offset: 0x00A38E2C
		// (set) Token: 0x0600B05F RID: 45151 RVA: 0x00A3ACE4 File Offset: 0x00A38EE4
		public bool DataProfVPNMessageRetransmissionTime_A42209_Valid
		{
			get
			{
				short num = (short)1654085450;
				short num2 = num;
				num = (short)1514690378;
				switch (num2 == num)
				{
				}
				num = (short)1213857793;
				if (num != 0)
				{
				}
				num = (short)2024210432;
				if (num != 0)
				{
				}
				num = (short)1022754816;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.Valid;
			}
			set
			{
				short num = (short)201377767;
				short num2 = num;
				num = (short)1107609575;
				switch (num2 == num)
				{
				}
				num = (short)318308353;
				if (num != 0)
				{
				}
				num = (short)1466957824;
				if (num != 0)
				{
				}
				num = (short)527826944;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.Valid = value;
			}
		}

		// Token: 0x17005891 RID: 22673
		// (get) Token: 0x0600B060 RID: 45152 RVA: 0x00A3AD98 File Offset: 0x00A38F98
		// (set) Token: 0x0600B061 RID: 45153 RVA: 0x00A3AE4C File Offset: 0x00A3904C
		public bool DataProfVPNMessageRetransmissionTime_A42209_Visible
		{
			get
			{
				short num = (short)1890514799;
				short num2 = num;
				num = (short)771815279;
				switch (num2 == num)
				{
				}
				num = (short)494338049;
				if (num != 0)
				{
				}
				num = (short)886505472;
				if (num != 0)
				{
				}
				num = (short)1308491776;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.Visible;
			}
			set
			{
				short num = (short)1777409239;
				short num2 = num;
				num = (short)804330711;
				switch (num2 == num)
				{
				}
				num = (short)1297088513;
				if (num != 0)
				{
				}
				num = (short)1977745408;
				if (num != 0)
				{
				}
				num = (short)1694236672;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.Visible = value;
			}
		}

		// Token: 0x17005892 RID: 22674
		// (get) Token: 0x0600B062 RID: 45154 RVA: 0x00A3AF04 File Offset: 0x00A39104
		// (set) Token: 0x0600B063 RID: 45155 RVA: 0x00A3AFBC File Offset: 0x00A391BC
		public bool DataProfVPNMessageRetransmissionTime_A42209_Editable
		{
			get
			{
				short num = (short)1180318406;
				short num2 = num;
				num = (short)606550726;
				switch (num2 == num)
				{
				}
				num = (short)519110656;
				if (num != 0)
				{
				}
				num = (short)1207369729;
				if (num != 0)
				{
				}
				num = (short)967901184;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.Editable;
			}
			set
			{
				short num = (short)1394064074;
				short num2 = num;
				num = (short)423082698;
				switch (num2 == num)
				{
				}
				num = (short)378470400;
				if (num != 0)
				{
				}
				num = (short)1551433729;
				if (num != 0)
				{
				}
				num = (short)1885077504;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.Editable = value;
			}
		}

		// Token: 0x17005893 RID: 22675
		// (get) Token: 0x0600B064 RID: 45156 RVA: 0x00A3B070 File Offset: 0x00A39270
		internal string DataProfVPNMessageRetransmissionTime_A42209_UILabel
		{
			get
			{
				short num = (short)520028161;
				if (num != 0)
				{
				}
				num = (short)1515534667;
				short num2 = num;
				num = (short)166541643;
				switch (num2 == num)
				{
				}
				num = (short)1300234240;
				if (num != 0)
				{
				}
				num = (short)1024720896;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.UIName;
			}
		}

		// Token: 0x17005894 RID: 22676
		// (get) Token: 0x0600B065 RID: 45157 RVA: 0x00A3B124 File Offset: 0x00A39324
		// (set) Token: 0x0600B066 RID: 45158 RVA: 0x00A3B1D8 File Offset: 0x00A393D8
		internal bool DataProfVPNMessageRetransmissionTime_A42209_HiddenStatic
		{
			get
			{
				short num = (short)1540976993;
				short num2 = num;
				num = (short)1393717601;
				switch (num2 == num)
				{
				}
				num = (short)1431240704;
				if (num != 0)
				{
				}
				num = (short)1288830977;
				if (num != 0)
				{
				}
				num = (short)1990918144;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.HiddenStatic;
			}
			set
			{
				short num = (short)573702145;
				if (num != 0)
				{
				}
				num = (short)109727170;
				short num2 = num;
				num = (short)899894722;
				switch (num2 == num)
				{
				}
				num = (short)469434368;
				if (num != 0)
				{
				}
				num = (short)274923520;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.HiddenStatic = value;
			}
		}

		// Token: 0x17005895 RID: 22677
		// (get) Token: 0x0600B067 RID: 45159 RVA: 0x00A3B28C File Offset: 0x00A3948C
		// (set) Token: 0x0600B068 RID: 45160 RVA: 0x00A3B340 File Offset: 0x00A39540
		internal bool DataProfVPNMessageRetransmissionTime_A42209_HiddenDynamic
		{
			get
			{
				short num = (short)2141978625;
				if (num != 0)
				{
				}
				num = (short)292119341;
				short num2 = num;
				num = (short)435053357;
				switch (num2 == num)
				{
				}
				num = (short)881459200;
				if (num != 0)
				{
				}
				num = (short)1359740928;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209.HiddenDynamic;
			}
			set
			{
				short num = (short)163319007;
				short num2 = num;
				num = (short)1316490463;
				switch (num2 == num)
				{
				}
				num = (short)1232273408;
				if (num != 0)
				{
				}
				num = (short)830799873;
				if (num != 0)
				{
				}
				num = (short)514916352;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionTime_A42209.HiddenDynamic = value;
			}
		}

		// Token: 0x17005896 RID: 22678
		// (get) Token: 0x0600B069 RID: 45161 RVA: 0x00A3B3F8 File Offset: 0x00A395F8
		public bool DataProfVPNMessageRetransmissionTime_A42209_HasDiffs
		{
			get
			{
				short num = (short)954233899;
				short num2 = num;
				num = (short)1926591531;
				switch (num2 == num)
				{
				}
				num = (short)660668416;
				if (num != 0)
				{
				}
				num = (short)1062469633;
				if (num != 0)
				{
				}
				num = (short)1948254208;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionTime_A42209._HasDiffs;
			}
		}

		// Token: 0x17005897 RID: 22679
		// (get) Token: 0x0600B06A RID: 45162 RVA: 0x00A3B4AC File Offset: 0x00A396AC
		// (set) Token: 0x0600B06B RID: 45163 RVA: 0x00A3B560 File Offset: 0x00A39760
		public int DataProfVPNMessageRetransmissionAttempts_A42210Value
		{
			get
			{
				short num = (short)2094496922;
				short num2 = num;
				num = (short)802258074;
				switch (num2 == num)
				{
				}
				num = (short)163446785;
				if (num != 0)
				{
				}
				num = (short)1358168064;
				if (num != 0)
				{
				}
				num = (short)913244160;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.Value;
			}
			set
			{
				short num = (short)1047372447;
				short num2 = num;
				num = (short)987275935;
				switch (num2 == num)
				{
				}
				num = (short)566362113;
				if (num != 0)
				{
				}
				num = (short)555352064;
				if (num != 0)
				{
				}
				num = (short)1610285056;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.Value = value;
			}
		}

		// Token: 0x17005898 RID: 22680
		// (get) Token: 0x0600B06C RID: 45164 RVA: 0x00A3B618 File Offset: 0x00A39818
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfVPNMessageRetransmissionAttempts_A42210
		{
			get
			{
				short num = (short)485378808;
				short num2 = num;
				num = (short)1464158968;
				switch (num2 == num)
				{
				}
				num = (short)456720385;
				if (num != 0)
				{
				}
				num = (short)534315008;
				if (num != 0)
				{
				}
				num = (short)979894272;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210;
			}
		}

		// Token: 0x17005899 RID: 22681
		// (get) Token: 0x0600B06D RID: 45165 RVA: 0x00A3B6C8 File Offset: 0x00A398C8
		// (set) Token: 0x0600B06E RID: 45166 RVA: 0x00A3B77C File Offset: 0x00A3997C
		public string DataProfVPNMessageRetransmissionAttempts_A42210_UIValue
		{
			get
			{
				short num = (short)170912951;
				short num2 = num;
				num = (short)567798967;
				switch (num2 == num)
				{
				}
				num = (short)707133441;
				if (num != 0)
				{
				}
				num = (short)1313341440;
				if (num != 0)
				{
				}
				num = (short)1548615680;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.UIValue;
			}
			set
			{
				short num = (short)255721473;
				if (num != 0)
				{
				}
				num = (short)681605143;
				short num2 = num;
				num = (short)491550743;
				switch (num2 == num)
				{
				}
				num = (short)1467744256;
				if (num != 0)
				{
				}
				num = (short)1125318656;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.UIValue = value;
			}
		}

		// Token: 0x1700589A RID: 22682
		// (get) Token: 0x0600B06F RID: 45167 RVA: 0x00A3B830 File Offset: 0x00A39A30
		// (set) Token: 0x0600B070 RID: 45168 RVA: 0x00A3B8E4 File Offset: 0x00A39AE4
		internal int DataProfVPNMessageRetransmissionAttempts_A42210Min
		{
			get
			{
				short num = (short)11990425;
				short num2 = num;
				num = (short)196670873;
				switch (num2 == num)
				{
				}
				num = (short)2075262977;
				if (num != 0)
				{
				}
				num = (short)729350144;
				if (num != 0)
				{
				}
				num = (short)633405440;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.Min;
			}
			set
			{
				short num = (short)993798125;
				short num2 = num;
				num = (short)214706157;
				switch (num2 == num)
				{
				}
				num = (short)2001534977;
				if (num != 0)
				{
				}
				num = (short)1559822336;
				if (num != 0)
				{
				}
				num = (short)570687488;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.Min = value;
			}
		}

		// Token: 0x1700589B RID: 22683
		// (get) Token: 0x0600B071 RID: 45169 RVA: 0x00A3B99C File Offset: 0x00A39B9C
		// (set) Token: 0x0600B072 RID: 45170 RVA: 0x00A3BA50 File Offset: 0x00A39C50
		internal int DataProfVPNMessageRetransmissionAttempts_A42210Max
		{
			get
			{
				short num = (short)769818294;
				short num2 = num;
				num = (short)297828022;
				switch (num2 == num)
				{
				}
				num = (short)1169686529;
				if (num != 0)
				{
				}
				num = (short)1294729216;
				if (num != 0)
				{
				}
				num = (short)855834624;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.Max;
			}
			set
			{
				short num = (short)1987027375;
				short num2 = num;
				num = (short)555393455;
				switch (num2 == num)
				{
				}
				num = (short)1636564993;
				if (num != 0)
				{
				}
				num = (short)599195648;
				if (num != 0)
				{
				}
				num = (short)1208483840;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.Max = value;
			}
		}

		// Token: 0x1700589C RID: 22684
		// (get) Token: 0x0600B073 RID: 45171 RVA: 0x00A3BB08 File Offset: 0x00A39D08
		// (set) Token: 0x0600B074 RID: 45172 RVA: 0x00A3BBBC File Offset: 0x00A39DBC
		internal int DataProfVPNMessageRetransmissionAttempts_A42210Step
		{
			get
			{
				short num = (short)1638461209;
				short num2 = num;
				num = (short)716569;
				switch (num2 == num)
				{
				}
				num = (short)1633288192;
				if (num != 0)
				{
				}
				num = (short)1694367745;
				if (num != 0)
				{
				}
				num = (short)734330880;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.StepSize;
			}
			set
			{
				short num = (short)2093347198;
				short num2 = num;
				num = (short)1985540478;
				switch (num2 == num)
				{
				}
				num = (short)1453719552;
				if (num != 0)
				{
				}
				num = (short)159055873;
				if (num != 0)
				{
				}
				num = (short)61472768;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.StepSize = value;
			}
		}

		// Token: 0x1700589D RID: 22685
		// (get) Token: 0x0600B075 RID: 45173 RVA: 0x00A3BC74 File Offset: 0x00A39E74
		// (set) Token: 0x0600B076 RID: 45174 RVA: 0x00A3BD28 File Offset: 0x00A39F28
		public bool DataProfVPNMessageRetransmissionAttempts_A42210_Applicable
		{
			get
			{
				short num = (short)1052331847;
				short num2 = num;
				num = (short)655642439;
				switch (num2 == num)
				{
				}
				num = (short)263651328;
				if (num != 0)
				{
				}
				num = (short)1970012161;
				if (num != 0)
				{
				}
				num = (short)316276736;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.Applicable;
			}
			set
			{
				short num = (short)792002561;
				if (num != 0)
				{
				}
				num = (short)1590301950;
				short num2 = num;
				num = (short)2017006846;
				switch (num2 == num)
				{
				}
				num = (short)1510670336;
				if (num != 0)
				{
				}
				num = (short)327614464;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.Applicable = value;
			}
		}

		// Token: 0x1700589E RID: 22686
		// (get) Token: 0x0600B077 RID: 45175 RVA: 0x00A3BDDC File Offset: 0x00A39FDC
		// (set) Token: 0x0600B078 RID: 45176 RVA: 0x00A3BE90 File Offset: 0x00A3A090
		public bool DataProfVPNMessageRetransmissionAttempts_A42210_Valid
		{
			get
			{
				short num = (short)431327459;
				short num2 = num;
				num = (short)498436323;
				switch (num2 == num)
				{
				}
				num = (short)927531009;
				if (num != 0)
				{
				}
				num = (short)487260160;
				if (num != 0)
				{
				}
				num = (short)2130247680;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.Valid;
			}
			set
			{
				short num = (short)1697316865;
				if (num != 0)
				{
				}
				num = (short)932516319;
				short num2 = num;
				num = (short)429003231;
				switch (num2 == num)
				{
				}
				num = (short)936902656;
				if (num != 0)
				{
				}
				num = (short)1150943232;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.Valid = value;
			}
		}

		// Token: 0x1700589F RID: 22687
		// (get) Token: 0x0600B079 RID: 45177 RVA: 0x00A3BF48 File Offset: 0x00A3A148
		// (set) Token: 0x0600B07A RID: 45178 RVA: 0x00A3BFFC File Offset: 0x00A3A1FC
		public bool DataProfVPNMessageRetransmissionAttempts_A42210_Visible
		{
			get
			{
				short num = (short)285676886;
				short num2 = num;
				num = (short)133240150;
				switch (num2 == num)
				{
				}
				num = (short)973275137;
				if (num != 0)
				{
				}
				num = (short)165806080;
				if (num != 0)
				{
				}
				num = (short)1188560896;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.Visible;
			}
			set
			{
				short num = (short)532638666;
				short num2 = num;
				num = (short)278096842;
				switch (num2 == num)
				{
				}
				num = (short)1797914625;
				if (num != 0)
				{
				}
				num = (short)1304559616;
				if (num != 0)
				{
				}
				num = (short)67043328;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.Visible = value;
			}
		}

		// Token: 0x170058A0 RID: 22688
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x00A3C0B0 File Offset: 0x00A3A2B0
		// (set) Token: 0x0600B07C RID: 45180 RVA: 0x00A3C164 File Offset: 0x00A3A364
		public bool DataProfVPNMessageRetransmissionAttempts_A42210_Editable
		{
			get
			{
				short num = (short)684369398;
				short num2 = num;
				num = (short)1938204150;
				switch (num2 == num)
				{
				}
				num = (short)355205121;
				if (num != 0)
				{
				}
				num = (short)1578500096;
				if (num != 0)
				{
				}
				num = (short)1308950528;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.Editable;
			}
			set
			{
				short num = (short)1857093633;
				if (num != 0)
				{
				}
				num = (short)1252481846;
				short num2 = num;
				num = (short)956062518;
				switch (num2 == num)
				{
				}
				num = (short)1762197504;
				if (num != 0)
				{
				}
				num = (short)1854210048;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.Editable = value;
			}
		}

		// Token: 0x170058A1 RID: 22689
		// (get) Token: 0x0600B07D RID: 45181 RVA: 0x00A3C21C File Offset: 0x00A3A41C
		internal string DataProfVPNMessageRetransmissionAttempts_A42210_UILabel
		{
			get
			{
				short num = (short)1251316960;
				short num2 = num;
				num = (short)392271072;
				switch (num2 == num)
				{
				}
				num = (short)561840129;
				if (num != 0)
				{
				}
				num = (short)838008832;
				if (num != 0)
				{
				}
				num = (short)693174272;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.UIName;
			}
		}

		// Token: 0x170058A2 RID: 22690
		// (get) Token: 0x0600B07E RID: 45182 RVA: 0x00A3C2D0 File Offset: 0x00A3A4D0
		// (set) Token: 0x0600B07F RID: 45183 RVA: 0x00A3C388 File Offset: 0x00A3A588
		internal bool DataProfVPNMessageRetransmissionAttempts_A42210_HiddenStatic
		{
			get
			{
				short num = (short)618833767;
				short num2 = num;
				num = (short)1362732903;
				switch (num2 == num)
				{
				}
				num = (short)1611530241;
				if (num != 0)
				{
				}
				num = (short)1903493120;
				if (num != 0)
				{
				}
				num = (short)182452224;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.HiddenStatic;
			}
			set
			{
				short num = (short)1912265671;
				short num2 = num;
				num = (short)1059904455;
				switch (num2 == num)
				{
				}
				num = (short)1540423681;
				if (num != 0)
				{
				}
				num = (short)1725693952;
				if (num != 0)
				{
				}
				num = (short)370016256;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.HiddenStatic = value;
			}
		}

		// Token: 0x170058A3 RID: 22691
		// (get) Token: 0x0600B080 RID: 45184 RVA: 0x00A3C43C File Offset: 0x00A3A63C
		// (set) Token: 0x0600B081 RID: 45185 RVA: 0x00A3C4F0 File Offset: 0x00A3A6F0
		internal bool DataProfVPNMessageRetransmissionAttempts_A42210_HiddenDynamic
		{
			get
			{
				short num = (short)2013393506;
				short num2 = num;
				num = (short)433582690;
				switch (num2 == num)
				{
				}
				num = (short)1417740288;
				if (num != 0)
				{
				}
				num = (short)605683713;
				if (num != 0)
				{
				}
				num = (short)2082340864;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210.HiddenDynamic;
			}
			set
			{
				short num = (short)1224360055;
				short num2 = num;
				num = (short)859127927;
				switch (num2 == num)
				{
				}
				num = (short)1606418433;
				if (num != 0)
				{
				}
				num = (short)2099249152;
				if (num != 0)
				{
				}
				num = (short)788987904;
				short num3 = num;
				this.dataProfVPNMessageRetransmissionAttempts_A42210.HiddenDynamic = value;
			}
		}

		// Token: 0x170058A4 RID: 22692
		// (get) Token: 0x0600B082 RID: 45186 RVA: 0x00A3C5A4 File Offset: 0x00A3A7A4
		public bool DataProfVPNMessageRetransmissionAttempts_A42210_HasDiffs
		{
			get
			{
				short num = (short)331218945;
				if (num != 0)
				{
				}
				num = (short)484624978;
				short num2 = num;
				num = (short)1262013010;
				switch (num2 == num)
				{
				}
				num = (short)406781952;
				if (num != 0)
				{
				}
				num = (short)93519872;
				short num3 = num;
				return this.dataProfVPNMessageRetransmissionAttempts_A42210._HasDiffs;
			}
		}

		// Token: 0x170058A5 RID: 22693
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x00A3C658 File Offset: 0x00A3A858
		// (set) Token: 0x0600B084 RID: 45188 RVA: 0x00A3C70C File Offset: 0x00A3A90C
		public int DataProfVPNDeadPeerDetectionInterval_A42211Value
		{
			get
			{
				short num = (short)986071323;
				short num2 = num;
				num = (short)1878737179;
				switch (num2 == num)
				{
				}
				num = (short)378667009;
				if (num != 0)
				{
				}
				num = (short)1752039424;
				if (num != 0)
				{
				}
				num = (short)506527744;
				short num3 = num;
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.Value;
			}
			set
			{
				short num = (short)1288569916;
				short num2 = num;
				num = (short)90047548;
				switch (num2 == num)
				{
				}
				num = (short)1949564928;
				if (num != 0)
				{
				}
				num = (short)797573121;
				if (num != 0)
				{
				}
				num = (short)1183055872;
				short num3 = num;
				this.dataProfVPNDeadPeerDetectionInterval_A42211.Value = value;
			}
		}

		// Token: 0x170058A6 RID: 22694
		// (get) Token: 0x0600B085 RID: 45189 RVA: 0x00A3C7C4 File Offset: 0x00A3A9C4
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfVPNDeadPeerDetectionInterval_A42211
		{
			get
			{
				short num = (short)995641444;
				short num2 = num;
				num = (short)2095794276;
				switch (num2 == num)
				{
				}
				num = (short)899547137;
				if (num != 0)
				{
				}
				num = (short)556269568;
				if (num != 0)
				{
				}
				num = (short)1530593280;
				short num3 = num;
				return this.dataProfVPNDeadPeerDetectionInterval_A42211;
			}
		}

		// Token: 0x170058A7 RID: 22695
		// (get) Token: 0x0600B086 RID: 45190 RVA: 0x00A3C878 File Offset: 0x00A3AA78
		// (set) Token: 0x0600B087 RID: 45191 RVA: 0x00A3C92C File Offset: 0x00A3AB2C
		public string DataProfVPNDeadPeerDetectionInterval_A42211_UIValue
		{
			get
			{
				short num = (short)35204779;
				short num2 = num;
				num = (short)46149291;
				switch (num2 == num)
				{
				}
				num = (short)1876361216;
				if (num != 0)
				{
				}
				num = (short)2128871425;
				if (num != 0)
				{
				}
				num = (short)501612544;
				short num3 = num;
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.UIValue;
			}
			set
			{
				short num = (short)457778871;
				short num2 = num;
				num = (short)1976182455;
				switch (num2 == num)
				{
				}
				num = (short)674496512;
				if (num != 0)
				{
				}
				num = (short)2039480321;
				if (num != 0)
				{
				}
				num = (short)694550528;
				short num3 = num;
				this.dataProfVPNDeadPeerDetectionInterval_A42211.UIValue = value;
			}
		}

		// Token: 0x170058A8 RID: 22696
		// (get) Token: 0x0600B088 RID: 45192 RVA: 0x00A3C9E0 File Offset: 0x00A3ABE0
		// (set) Token: 0x0600B089 RID: 45193 RVA: 0x00A3CA98 File Offset: 0x00A3AC98
		internal int DataProfVPNDeadPeerDetectionInterval_A42211Min
		{
			get
			{
				short num = (short)2130951925;
				short num2 = num;
				num = (short)102153973;
				switch (num2 == num)
				{
				}
				num = (short)386596865;
				if (num != 0)
				{
				}
				num = (short)68091904;
				if (num != 0)
				{
				}
				num = (short)356777984;
				short num3 = num;
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.Min;
			}
			set
			{
				short num = (short)1046521941;
				short num2 = num;
				num = (short)1680189525;
				switch (num2 == num)
				{
				}
				num = (short)1933901825;
				if (num != 0)
				{
				}
				num = (short)1451753472;
				if (num != 0)
				{
				}
				num = (short)523567104;
				short num3 = num;
				this.dataProfVPNDeadPeerDetectionInterval_A42211.Min = value;
			}
		}

		// Token: 0x170058A9 RID: 22697
		// (get) Token: 0x0600B08A RID: 45194 RVA: 0x00A3CB4C File Offset: 0x00A3AD4C
		// (set) Token: 0x0600B08B RID: 45195 RVA: 0x00A3CC00 File Offset: 0x00A3AE00
		internal int DataProfVPNDeadPeerDetectionInterval_A42211Max
		{
			get
			{
				short num = (short)1552154624;
				short num2 = num;
				num = (short)1680684320;
				short num3 = num;
				num = (short)1461990688;
				switch (num3 == num)
				{
				}
				num = (short)1027342336;
				if (num != 0)
				{
				}
				num = (short)1320091649;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.Max;
			}
			set
			{
				short num = (short)2065760256;
				short num2 = num;
				num = (short)994363459;
				short num3 = num;
				num = (short)421775427;
				switch (num3 == num)
				{
				}
				num = (short)926220288;
				if (num != 0)
				{
				}
				num = (short)1661075457;
				if (num != 0)
				{
				}
				this.dataProfVPNDeadPeerDetectionInterval_A42211.Max = value;
			}
		}

		// Token: 0x170058AA RID: 22698
		// (get) Token: 0x0600B08C RID: 45196 RVA: 0x00A3CCB4 File Offset: 0x00A3AEB4
		// (set) Token: 0x0600B08D RID: 45197 RVA: 0x00A3CD68 File Offset: 0x00A3AF68
		internal int DataProfVPNDeadPeerDetectionInterval_A42211Step
		{
			get
			{
				short num = (short)1053818880;
				short num2 = num;
				num = (short)590714143;
				short num3 = num;
				num = (short)1122014495;
				switch (num3 == num)
				{
				}
				num = (short)490143744;
				if (num != 0)
				{
				}
				num = (short)1095172097;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.StepSize;
			}
			set
			{
				short num = (short)936640512;
				short num2 = num;
				num = (short)923249593;
				short num3 = num;
				num = (short)1477290937;
				switch (num3 == num)
				{
				}
				num = (short)1060962304;
				if (num != 0)
				{
				}
				num = (short)2123038721;
				if (num != 0)
				{
				}
				this.dataProfVPNDeadPeerDetectionInterval_A42211.StepSize = value;
			}
		}

		// Token: 0x170058AB RID: 22699
		// (get) Token: 0x0600B08E RID: 45198 RVA: 0x00A3CE1C File Offset: 0x00A3B01C
		// (set) Token: 0x0600B08F RID: 45199 RVA: 0x00A3CED8 File Offset: 0x00A3B0D8
		public bool DataProfVPNDeadPeerDetectionInterval_A42211_Applicable
		{
			get
			{
				short num = (short)1905721344;
				short num2 = num;
				num = (short)115092880;
				short num3 = num;
				num = (short)1430203792;
				switch (num3 == num)
				{
				}
				num = (short)1800470529;
				if (num != 0)
				{
				}
				num = (short)1900412928;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.Applicable;
			}
			set
			{
				short num = (short)1388249088;
				short num2 = num;
				num = (short)2132739127;
				short num3 = num;
				num = (short)1235158071;
				switch (num3 == num)
				{
				}
				num = (short)1580007425;
				if (num != 0)
				{
				}
				num = (short)1273823232;
				if (num != 0)
				{
				}
				this.dataProfVPNDeadPeerDetectionInterval_A42211.Applicable = value;
			}
		}

		// Token: 0x170058AC RID: 22700
		// (get) Token: 0x0600B090 RID: 45200 RVA: 0x00A3CF90 File Offset: 0x00A3B190
		// (set) Token: 0x0600B091 RID: 45201 RVA: 0x00A3D044 File Offset: 0x00A3B244
		public bool DataProfVPNDeadPeerDetectionInterval_A42211_Valid
		{
			get
			{
				short num = (short)115277824;
				short num2 = num;
				num = (short)54210342;
				short num3 = num;
				num = (short)1553674022;
				switch (num3 == num)
				{
				}
				num = (short)1873870849;
				if (num != 0)
				{
				}
				num = (short)1058930688;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.Valid;
			}
			set
			{
				short num = (short)180486144;
				short num2 = num;
				num = (short)1350397474;
				short num3 = num;
				num = (short)1907715618;
				switch (num3 == num)
				{
				}
				num = (short)542703617;
				if (num != 0)
				{
				}
				num = (short)161808384;
				if (num != 0)
				{
				}
				this.dataProfVPNDeadPeerDetectionInterval_A42211.Valid = value;
			}
		}

		// Token: 0x170058AD RID: 22701
		// (get) Token: 0x0600B092 RID: 45202 RVA: 0x00A3D0FC File Offset: 0x00A3B2FC
		// (set) Token: 0x0600B093 RID: 45203 RVA: 0x00A3D1B8 File Offset: 0x00A3B3B8
		public bool DataProfVPNDeadPeerDetectionInterval_A42211_Visible
		{
			get
			{
				short num = (short)437583872;
				short num2 = num;
				num = (short)943325185;
				if (num != 0)
				{
				}
				num = (short)83195489;
				short num3 = num;
				num = (short)559314529;
				switch (num3 == num)
				{
				}
				num = (short)359137280;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.Visible;
			}
			set
			{
				short num = (short)1514668032;
				short num2 = num;
				num = (short)351561991;
				short num3 = num;
				num = (short)780888327;
				switch (num3 == num)
				{
				}
				num = (short)749207553;
				if (num != 0)
				{
				}
				num = (short)812580864;
				if (num != 0)
				{
				}
				this.dataProfVPNDeadPeerDetectionInterval_A42211.Visible = value;
			}
		}

		// Token: 0x170058AE RID: 22702
		// (get) Token: 0x0600B094 RID: 45204 RVA: 0x00A3D26C File Offset: 0x00A3B46C
		// (set) Token: 0x0600B095 RID: 45205 RVA: 0x00A3D320 File Offset: 0x00A3B520
		public bool DataProfVPNDeadPeerDetectionInterval_A42211_Editable
		{
			get
			{
				short num = (short)625868800;
				short num2 = num;
				num = (short)1137149664;
				short num3 = num;
				num = (short)1342342880;
				switch (num3 == num)
				{
				}
				num = (short)139001857;
				if (num != 0)
				{
				}
				num = (short)1377501184;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.Editable;
			}
			set
			{
				short num = (short)127205376;
				short num2 = num;
				num = (short)1756129329;
				short num3 = num;
				num = (short)395798577;
				switch (num3 == num)
				{
				}
				num = (short)1351811072;
				if (num != 0)
				{
				}
				num = (short)1500250113;
				if (num != 0)
				{
				}
				this.dataProfVPNDeadPeerDetectionInterval_A42211.Editable = value;
			}
		}

		// Token: 0x170058AF RID: 22703
		// (get) Token: 0x0600B096 RID: 45206 RVA: 0x00A3D3D8 File Offset: 0x00A3B5D8
		internal string DataProfVPNDeadPeerDetectionInterval_A42211_UILabel
		{
			get
			{
				short num = (short)340131840;
				short num2 = num;
				num = (short)613078633;
				short num3 = num;
				num = (short)1883559529;
				switch (num3 == num)
				{
				}
				num = (short)644218881;
				if (num != 0)
				{
				}
				num = (short)951123968;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.UIName;
			}
		}

		// Token: 0x170058B0 RID: 22704
		// (get) Token: 0x0600B097 RID: 45207 RVA: 0x00A3D48C File Offset: 0x00A3B68C
		// (set) Token: 0x0600B098 RID: 45208 RVA: 0x00A3D544 File Offset: 0x00A3B744
		internal bool DataProfVPNDeadPeerDetectionInterval_A42211_HiddenStatic
		{
			get
			{
				short num = (short)1481637888;
				short num2 = num;
				num = (short)17737768;
				short num3 = num;
				num = (short)1273538600;
				switch (num3 == num)
				{
				}
				num = (short)1613430785;
				if (num != 0)
				{
				}
				num = (short)1798504448;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.HiddenStatic;
			}
			set
			{
				short num = (short)1145503744;
				short num2 = num;
				num = (short)2066286553;
				short num3 = num;
				num = (short)486410201;
				switch (num3 == num)
				{
				}
				num = (short)1900478465;
				if (num != 0)
				{
				}
				num = (short)402915328;
				if (num != 0)
				{
				}
				this.dataProfVPNDeadPeerDetectionInterval_A42211.HiddenStatic = value;
			}
		}

		// Token: 0x170058B1 RID: 22705
		// (get) Token: 0x0600B099 RID: 45209 RVA: 0x00A3D5F8 File Offset: 0x00A3B7F8
		// (set) Token: 0x0600B09A RID: 45210 RVA: 0x00A3D6AC File Offset: 0x00A3B8AC
		internal bool DataProfVPNDeadPeerDetectionInterval_A42211_HiddenDynamic
		{
			get
			{
				short num = (short)170655744;
				short num2 = num;
				num = (short)1070772707;
				short num3 = num;
				num = (short)2061414883;
				switch (num3 == num)
				{
				}
				num = (short)3735553;
				if (num != 0)
				{
				}
				num = (short)9240576;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211.HiddenDynamic;
			}
			set
			{
				short num = (short)246480896;
				short num2 = num;
				num = (short)1813883115;
				short num3 = num;
				num = (short)1959962859;
				switch (num3 == num)
				{
				}
				num = (short)823328768;
				if (num != 0)
				{
				}
				num = (short)896270337;
				if (num != 0)
				{
				}
				this.dataProfVPNDeadPeerDetectionInterval_A42211.HiddenDynamic = value;
			}
		}

		// Token: 0x170058B2 RID: 22706
		// (get) Token: 0x0600B09B RID: 45211 RVA: 0x00A3D764 File Offset: 0x00A3B964
		public bool DataProfVPNDeadPeerDetectionInterval_A42211_HasDiffs
		{
			get
			{
				short num = (short)507052032;
				short num2 = num;
				num = (short)892478453;
				short num3 = num;
				num = (short)797320181;
				switch (num3 == num)
				{
				}
				num = (short)1303904256;
				if (num != 0)
				{
				}
				num = (short)1199308801;
				if (num != 0)
				{
				}
				return this.dataProfVPNDeadPeerDetectionInterval_A42211._HasDiffs;
			}
		}

		// Token: 0x170058B3 RID: 22707
		// (get) Token: 0x0600B09C RID: 45212 RVA: 0x00A3D818 File Offset: 0x00A3BA18
		// (set) Token: 0x0600B09D RID: 45213 RVA: 0x00A3D8D0 File Offset: 0x00A3BAD0
		public int DataProfVPNRekeyMargin_A42212Value
		{
			get
			{
				short num = (short)854786048;
				short num2 = num;
				num = (short)1918502295;
				short num3 = num;
				num = (short)1260979607;
				switch (num3 == num)
				{
				}
				num = (short)1904607233;
				if (num != 0)
				{
				}
				num = (short)214892544;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.Value;
			}
			set
			{
				short num = (short)1606615040;
				short num2 = num;
				num = (short)69707723;
				short num3 = num;
				num = (short)2067441611;
				switch (num3 == num)
				{
				}
				num = (short)442957825;
				if (num != 0)
				{
				}
				num = (short)294322176;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.Value = value;
			}
		}

		// Token: 0x170058B4 RID: 22708
		// (get) Token: 0x0600B09E RID: 45214 RVA: 0x00A3D98C File Offset: 0x00A3BB8C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfVPNRekeyMargin_A42212
		{
			get
			{
				short num = (short)654442496;
				short num2 = num;
				num = (short)347342839;
				short num3 = num;
				num = (short)703989751;
				switch (num3 == num)
				{
				}
				num = (short)1998520320;
				if (num != 0)
				{
				}
				num = (short)1182007297;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212;
			}
		}

		// Token: 0x170058B5 RID: 22709
		// (get) Token: 0x0600B09F RID: 45215 RVA: 0x00A3DA38 File Offset: 0x00A3BC38
		// (set) Token: 0x0600B0A0 RID: 45216 RVA: 0x00A3DAEC File Offset: 0x00A3BCEC
		public string DataProfVPNRekeyMargin_A42212_UIValue
		{
			get
			{
				short num = (short)471203840;
				short num2 = num;
				num = (short)1247936513;
				if (num != 0)
				{
				}
				num = (short)1457158142;
				short num3 = num;
				num = (short)159807486;
				switch (num3 == num)
				{
				}
				num = (short)1028915200;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.UIValue;
			}
			set
			{
				short num = (short)2015035392;
				short num2 = num;
				num = (short)2125843652;
				short num3 = num;
				num = (short)1576324292;
				switch (num3 == num)
				{
				}
				num = (short)1693384705;
				if (num != 0)
				{
				}
				num = (short)725155840;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.UIValue = value;
			}
		}

		// Token: 0x170058B6 RID: 22710
		// (get) Token: 0x0600B0A1 RID: 45217 RVA: 0x00A3DBA0 File Offset: 0x00A3BDA0
		// (set) Token: 0x0600B0A2 RID: 45218 RVA: 0x00A3DC50 File Offset: 0x00A3BE50
		internal int DataProfVPNRekeyMargin_A42212Min
		{
			get
			{
				short num = (short)2096562176;
				short num2 = num;
				num = (short)1269080274;
				short num3 = num;
				num = (short)1951047890;
				switch (num3 == num)
				{
				}
				num = (short)99352577;
				if (num != 0)
				{
				}
				num = (short)806354944;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.Min;
			}
			set
			{
				short num = (short)427032576;
				short num2 = num;
				num = (short)313372732;
				short num3 = num;
				num = (short)1022799932;
				switch (num3 == num)
				{
				}
				num = (short)111804417;
				if (num != 0)
				{
				}
				num = (short)1715404800;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.Min = value;
			}
		}

		// Token: 0x170058B7 RID: 22711
		// (get) Token: 0x0600B0A3 RID: 45219 RVA: 0x00A3DD04 File Offset: 0x00A3BF04
		// (set) Token: 0x0600B0A4 RID: 45220 RVA: 0x00A3DDB8 File Offset: 0x00A3BFB8
		internal int DataProfVPNRekeyMargin_A42212Max
		{
			get
			{
				short num = (short)324993024;
				short num2 = num;
				num = (short)1262619264;
				short num3 = num;
				num = (short)1789332096;
				switch (num3 == num)
				{
				}
				num = (short)1217724417;
				if (num != 0)
				{
				}
				num = (short)1231486976;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.Max;
			}
			set
			{
				short num = (short)916520960;
				short num2 = num;
				num = (short)672604772;
				short num3 = num;
				num = (short)1978802788;
				switch (num3 == num)
				{
				}
				num = (short)298844161;
				if (num != 0)
				{
				}
				num = (short)2063073280;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.Max = value;
			}
		}

		// Token: 0x170058B8 RID: 22712
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x00A3DE70 File Offset: 0x00A3C070
		// (set) Token: 0x0600B0A6 RID: 45222 RVA: 0x00A3DF28 File Offset: 0x00A3C128
		internal int DataProfVPNRekeyMargin_A42212Step
		{
			get
			{
				short num = (short)208666624;
				short num2 = num;
				num = (short)409614076;
				short num3 = num;
				num = (short)1176844028;
				switch (num3 == num)
				{
				}
				num = (short)1832845313;
				if (num != 0)
				{
				}
				num = (short)1887830016;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.StepSize;
			}
			set
			{
				short num = (short)1677721600;
				short num2 = num;
				num = (short)434499933;
				short num3 = num;
				num = (short)1942745437;
				switch (num3 == num)
				{
				}
				num = (short)421003265;
				if (num != 0)
				{
				}
				num = (short)370671616;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.StepSize = value;
			}
		}

		// Token: 0x170058B9 RID: 22713
		// (get) Token: 0x0600B0A7 RID: 45223 RVA: 0x00A3DFDC File Offset: 0x00A3C1DC
		// (set) Token: 0x0600B0A8 RID: 45224 RVA: 0x00A3E090 File Offset: 0x00A3C290
		public bool DataProfVPNRekeyMargin_A42212_Applicable
		{
			get
			{
				short num = (short)1485897728;
				short num2 = num;
				num = (short)1262804873;
				short num3 = num;
				num = (short)1064689545;
				switch (num3 == num)
				{
				}
				num = (short)1418133505;
				if (num != 0)
				{
				}
				num = (short)1025048576;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.Applicable;
			}
			set
			{
				short num = (short)521404416;
				short num2 = num;
				num = (short)304828427;
				short num3 = num;
				num = (short)379867147;
				switch (num3 == num)
				{
				}
				num = (short)238485505;
				if (num != 0)
				{
				}
				num = (short)177930240;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.Applicable = value;
			}
		}

		// Token: 0x170058BA RID: 22714
		// (get) Token: 0x0600B0A9 RID: 45225 RVA: 0x00A3E148 File Offset: 0x00A3C348
		// (set) Token: 0x0600B0AA RID: 45226 RVA: 0x00A3E1FC File Offset: 0x00A3C3FC
		public bool DataProfVPNRekeyMargin_A42212_Valid
		{
			get
			{
				short num = (short)1024983040;
				short num2 = num;
				num = (short)559708919;
				short num3 = num;
				num = (short)1253800695;
				switch (num3 == num)
				{
				}
				num = (short)1922564097;
				if (num != 0)
				{
				}
				num = (short)1682898944;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.Valid;
			}
			set
			{
				short num = (short)168427520;
				short num2 = num;
				num = (short)362807297;
				if (num != 0)
				{
				}
				num = (short)1391603748;
				short num3 = num;
				num = (short)762327076;
				switch (num3 == num)
				{
				}
				num = (short)838008832;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.Valid = value;
			}
		}

		// Token: 0x170058BB RID: 22715
		// (get) Token: 0x0600B0AB RID: 45227 RVA: 0x00A3E2B0 File Offset: 0x00A3C4B0
		// (set) Token: 0x0600B0AC RID: 45228 RVA: 0x00A3E368 File Offset: 0x00A3C568
		public bool DataProfVPNRekeyMargin_A42212_Visible
		{
			get
			{
				short num = (short)1442512896;
				short num2 = num;
				num = (short)1529628968;
				short num3 = num;
				num = (short)1523468584;
				switch (num3 == num)
				{
				}
				num = (short)1416364033;
				if (num != 0)
				{
				}
				num = (short)510656512;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.Visible;
			}
			set
			{
				short num = (short)2126118912;
				short num2 = num;
				num = (short)1687493158;
				short num3 = num;
				num = (short)1198987814;
				switch (num3 == num)
				{
				}
				num = (short)259457025;
				if (num != 0)
				{
				}
				num = (short)966656000;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.Visible = value;
			}
		}

		// Token: 0x170058BC RID: 22716
		// (get) Token: 0x0600B0AD RID: 45229 RVA: 0x00A3E41C File Offset: 0x00A3C61C
		// (set) Token: 0x0600B0AE RID: 45230 RVA: 0x00A3E4CC File Offset: 0x00A3C6CC
		public bool DataProfVPNRekeyMargin_A42212_Editable
		{
			get
			{
				short num = (short)53346304;
				short num2 = num;
				num = (short)916147386;
				short num3 = num;
				num = (short)1324436666;
				switch (num3 == num)
				{
				}
				num = (short)54132737;
				if (num != 0)
				{
				}
				num = (short)411566080;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.Editable;
			}
			set
			{
				short num = (short)702283776;
				short num2 = num;
				num = (short)876016580;
				short num3 = num;
				num = (short)1514206148;
				switch (num3 == num)
				{
				}
				num = (short)287244289;
				if (num != 0)
				{
				}
				num = (short)663027712;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.Editable = value;
			}
		}

		// Token: 0x170058BD RID: 22717
		// (get) Token: 0x0600B0AF RID: 45231 RVA: 0x00A3E584 File Offset: 0x00A3C784
		internal string DataProfVPNRekeyMargin_A42212_UILabel
		{
			get
			{
				short num = (short)1510539264;
				short num2 = num;
				num = (short)1222796838;
				short num3 = num;
				num = (short)1756063270;
				switch (num3 == num)
				{
				}
				num = (short)1275723777;
				if (num != 0)
				{
				}
				num = (short)110559232;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.UIName;
			}
		}

		// Token: 0x170058BE RID: 22718
		// (get) Token: 0x0600B0B0 RID: 45232 RVA: 0x00A3E638 File Offset: 0x00A3C838
		// (set) Token: 0x0600B0B1 RID: 45233 RVA: 0x00A3E6EC File Offset: 0x00A3C8EC
		internal bool DataProfVPNRekeyMargin_A42212_HiddenStatic
		{
			get
			{
				short num = (short)53280768;
				short num2 = num;
				num = (short)1979121665;
				if (num != 0)
				{
				}
				num = (short)1609689030;
				short num3 = num;
				num = (short)2073356230;
				switch (num3 == num)
				{
				}
				num = (short)1424424960;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.HiddenStatic;
			}
			set
			{
				short num = (short)1640300544;
				short num2 = num;
				num = (short)868116371;
				short num3 = num;
				num = (short)1411803027;
				switch (num3 == num)
				{
				}
				num = (short)884604929;
				if (num != 0)
				{
				}
				num = (short)418971648;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.HiddenStatic = value;
			}
		}

		// Token: 0x170058BF RID: 22719
		// (get) Token: 0x0600B0B2 RID: 45234 RVA: 0x00A3E7A0 File Offset: 0x00A3C9A0
		// (set) Token: 0x0600B0B3 RID: 45235 RVA: 0x00A3E858 File Offset: 0x00A3CA58
		internal bool DataProfVPNRekeyMargin_A42212_HiddenDynamic
		{
			get
			{
				short num = (short)446824448;
				short num2 = num;
				num = (short)1509979856;
				short num3 = num;
				num = (short)413300432;
				switch (num3 == num)
				{
				}
				num = (short)1817116673;
				if (num != 0)
				{
				}
				num = (short)179372032;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212.HiddenDynamic;
			}
			set
			{
				short num = (short)227213312;
				short num2 = num;
				num = (short)446688531;
				short num3 = num;
				num = (short)946466067;
				switch (num3 == num)
				{
				}
				num = (short)1621098496;
				if (num != 0)
				{
				}
				num = (short)149946369;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyMargin_A42212.HiddenDynamic = value;
			}
		}

		// Token: 0x170058C0 RID: 22720
		// (get) Token: 0x0600B0B4 RID: 45236 RVA: 0x00A3E910 File Offset: 0x00A3CB10
		public bool DataProfVPNRekeyMargin_A42212_HasDiffs
		{
			get
			{
				short num = (short)2079653888;
				short num2 = num;
				num = (short)1806376575;
				short num3 = num;
				num = (short)2039291519;
				switch (num3 == num)
				{
				}
				num = (short)1946943489;
				if (num != 0)
				{
				}
				num = (short)1682440192;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyMargin_A42212._HasDiffs;
			}
		}

		// Token: 0x170058C1 RID: 22721
		// (get) Token: 0x0600B0B5 RID: 45237 RVA: 0x00A3E9CC File Offset: 0x00A3CBCC
		// (set) Token: 0x0600B0B6 RID: 45238 RVA: 0x00A3EA84 File Offset: 0x00A3CC84
		public int DataProfVPNRekeyAttempts_A42213Value
		{
			get
			{
				short num = (short)1839071232;
				short num2 = num;
				num = (short)1967865440;
				short num3 = num;
				num = (short)1947090528;
				switch (num3 == num)
				{
				}
				num = (short)1952251905;
				if (num != 0)
				{
				}
				num = (short)1412235264;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.Value;
			}
			set
			{
				short num = (short)47382528;
				short num2 = num;
				num = (short)857691367;
				short num3 = num;
				num = (short)1510560999;
				switch (num3 == num)
				{
				}
				num = (short)1568342017;
				if (num != 0)
				{
				}
				num = (short)652279808;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.Value = value;
			}
		}

		// Token: 0x170058C2 RID: 22722
		// (get) Token: 0x0600B0B7 RID: 45239 RVA: 0x00A3EB3C File Offset: 0x00A3CD3C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfVPNRekeyAttempts_A42213
		{
			get
			{
				short num = (short)1301610496;
				short num2 = num;
				num = (short)449743409;
				short num3 = num;
				num = (short)776571441;
				switch (num3 == num)
				{
				}
				num = (short)1964703744;
				if (num != 0)
				{
				}
				num = (short)1979580417;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213;
			}
		}

		// Token: 0x170058C3 RID: 22723
		// (get) Token: 0x0600B0B8 RID: 45240 RVA: 0x00A3EBEC File Offset: 0x00A3CDEC
		// (set) Token: 0x0600B0B9 RID: 45241 RVA: 0x00A3ECA4 File Offset: 0x00A3CEA4
		public string DataProfVPNRekeyAttempts_A42213_UIValue
		{
			get
			{
				short num = (short)1309868032;
				short num2 = num;
				num = (short)1951033870;
				short num3 = num;
				num = (short)1897359886;
				switch (num3 == num)
				{
				}
				num = (short)1514340353;
				if (num != 0)
				{
				}
				num = (short)1721434112;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.UIValue;
			}
			set
			{
				short num = (short)467599360;
				short num2 = num;
				num = (short)914367018;
				short num3 = num;
				num = (short)1443242538;
				switch (num3 == num)
				{
				}
				num = (short)363921409;
				if (num != 0)
				{
				}
				num = (short)1612382208;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.UIValue = value;
			}
		}

		// Token: 0x170058C4 RID: 22724
		// (get) Token: 0x0600B0BA RID: 45242 RVA: 0x00A3ED58 File Offset: 0x00A3CF58
		// (set) Token: 0x0600B0BB RID: 45243 RVA: 0x00A3EE0C File Offset: 0x00A3D00C
		internal int DataProfVPNRekeyAttempts_A42213Min
		{
			get
			{
				short num = (short)1298202624;
				short num2 = num;
				num = (short)1273182529;
				short num3 = num;
				num = (short)142096705;
				switch (num3 == num)
				{
				}
				num = (short)252903425;
				if (num != 0)
				{
				}
				num = (short)1121910784;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.Min;
			}
			set
			{
				short num = (short)1546715136;
				short num2 = num;
				num = (short)1080316505;
				short num3 = num;
				num = (short)219959897;
				switch (num3 == num)
				{
				}
				num = (short)1699545089;
				if (num != 0)
				{
				}
				num = (short)1601306624;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.Min = value;
			}
		}

		// Token: 0x170058C5 RID: 22725
		// (get) Token: 0x0600B0BC RID: 45244 RVA: 0x00A3EEC4 File Offset: 0x00A3D0C4
		// (set) Token: 0x0600B0BD RID: 45245 RVA: 0x00A3EF78 File Offset: 0x00A3D178
		internal int DataProfVPNRekeyAttempts_A42213Max
		{
			get
			{
				short num = (short)677093240;
				short num2 = num;
				num = (short)1552064376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1356398592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)548405249;
				if (num != 0)
				{
				}
				num = (short)2091122688;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.Max;
			}
			set
			{
				short num = (short)669908993;
				if (num != 0)
				{
				}
				num = (short)125960192;
				short num2 = num;
				num = (short)922094262;
				short num3 = num;
				num = (short)573311670;
				switch (num3 == num)
				{
				}
				num = (short)1887240192;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.Max = value;
			}
		}

		// Token: 0x170058C6 RID: 22726
		// (get) Token: 0x0600B0BE RID: 45246 RVA: 0x00A3F02C File Offset: 0x00A3D22C
		// (set) Token: 0x0600B0BF RID: 45247 RVA: 0x00A3F0E0 File Offset: 0x00A3D2E0
		internal int DataProfVPNRekeyAttempts_A42213Step
		{
			get
			{
				short num = (short)39723296;
				short num2 = num;
				num = (short)977215776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1596194816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1696464897;
				if (num != 0)
				{
				}
				num = (short)672268288;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.StepSize;
			}
			set
			{
				short num = (short)461248297;
				short num2 = num;
				num = (short)239015721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016542720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027290625;
				if (num != 0)
				{
				}
				num = (short)1723465728;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.StepSize = value;
			}
		}

		// Token: 0x170058C7 RID: 22727
		// (get) Token: 0x0600B0C0 RID: 45248 RVA: 0x00A3F198 File Offset: 0x00A3D398
		// (set) Token: 0x0600B0C1 RID: 45249 RVA: 0x00A3F24C File Offset: 0x00A3D44C
		public bool DataProfVPNRekeyAttempts_A42213_Applicable
		{
			get
			{
				short num = (short)1480368221;
				short num2 = num;
				num = (short)1617403997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029767168;
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
				num = (short)1334247424;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.Applicable;
			}
			set
			{
				short num = (short)1152171297;
				short num2 = num;
				num = (short)1625406753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1869807616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174732801;
				if (num != 0)
				{
				}
				num = (short)1094320128;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.Applicable = value;
			}
		}

		// Token: 0x170058C8 RID: 22728
		// (get) Token: 0x0600B0C2 RID: 45250 RVA: 0x00A3F300 File Offset: 0x00A3D500
		// (set) Token: 0x0600B0C3 RID: 45251 RVA: 0x00A3F3B4 File Offset: 0x00A3D5B4
		public bool DataProfVPNRekeyAttempts_A42213_Valid
		{
			get
			{
				short num = (short)1415248766;
				short num2 = num;
				num = (short)260307838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2014576640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1321992193;
				if (num != 0)
				{
				}
				num = (short)1322713088;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.Valid;
			}
			set
			{
				short num = (short)1170142284;
				short num2 = num;
				num = (short)1463678028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1529675776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1718288385;
				if (num != 0)
				{
				}
				num = (short)301072384;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.Valid = value;
			}
		}

		// Token: 0x170058C9 RID: 22729
		// (get) Token: 0x0600B0C4 RID: 45252 RVA: 0x00A3F46C File Offset: 0x00A3D66C
		// (set) Token: 0x0600B0C5 RID: 45253 RVA: 0x00A3F520 File Offset: 0x00A3D720
		public bool DataProfVPNRekeyAttempts_A42213_Visible
		{
			get
			{
				short num = (short)1378417532;
				short num2 = num;
				num = (short)1144060796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246887936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)665124865;
				if (num != 0)
				{
				}
				num = (short)1304428544;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.Visible;
			}
			set
			{
				short num = (short)1310270223;
				short num2 = num;
				num = (short)1655776015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)936509440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)513146880;
				if (num != 0)
				{
				}
				num = (short)432799745;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.Visible = value;
			}
		}

		// Token: 0x170058CA RID: 22730
		// (get) Token: 0x0600B0C6 RID: 45254 RVA: 0x00A3F5D8 File Offset: 0x00A3D7D8
		// (set) Token: 0x0600B0C7 RID: 45255 RVA: 0x00A3F68C File Offset: 0x00A3D88C
		public bool DataProfVPNRekeyAttempts_A42213_Editable
		{
			get
			{
				short num = (short)1025966081;
				if (num != 0)
				{
				}
				num = (short)1575419904;
				short num2 = num;
				num = (short)1829429714;
				short num3 = num;
				num = (short)1666179538;
				switch (num3 == num)
				{
				}
				num = (short)1373962240;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.Editable;
			}
			set
			{
				short num = (short)718469162;
				short num2 = num;
				num = (short)1833039914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)11010048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)10485760;
				if (num != 0)
				{
				}
				num = (short)1123745793;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.Editable = value;
			}
		}

		// Token: 0x170058CB RID: 22731
		// (get) Token: 0x0600B0C8 RID: 45256 RVA: 0x00A3F740 File Offset: 0x00A3D940
		internal string DataProfVPNRekeyAttempts_A42213_UILabel
		{
			get
			{
				short num = (short)2019654852;
				short num2 = num;
				num = (short)1055554756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1315831808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)605618176;
				if (num != 0)
				{
				}
				num = (short)1445396481;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.UIName;
			}
		}

		// Token: 0x170058CC RID: 22732
		// (get) Token: 0x0600B0C9 RID: 45257 RVA: 0x00A3F7F8 File Offset: 0x00A3D9F8
		// (set) Token: 0x0600B0CA RID: 45258 RVA: 0x00A3F8AC File Offset: 0x00A3DAAC
		internal bool DataProfVPNRekeyAttempts_A42213_HiddenStatic
		{
			get
			{
				short num = (short)321689304;
				short num2 = num;
				num = (short)1062115032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1050083328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1231355904;
				if (num != 0)
				{
				}
				num = (short)703201281;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.HiddenStatic;
			}
			set
			{
				short num = (short)238098683;
				short num2 = num;
				num = (short)1037900027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1415053312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)730333184;
				if (num != 0)
				{
				}
				num = (short)87293953;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.HiddenStatic = value;
			}
		}

		// Token: 0x170058CD RID: 22733
		// (get) Token: 0x0600B0CB RID: 45259 RVA: 0x00A3F960 File Offset: 0x00A3DB60
		// (set) Token: 0x0600B0CC RID: 45260 RVA: 0x00A3FA10 File Offset: 0x00A3DC10
		internal bool DataProfVPNRekeyAttempts_A42213_HiddenDynamic
		{
			get
			{
				short num = (short)145755112;
				short num2 = num;
				num = (short)1928858600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1378484224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)953876480;
				if (num != 0)
				{
				}
				num = (short)1908473857;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213.HiddenDynamic;
			}
			set
			{
				short num = (short)1285437453;
				short num2 = num;
				num = (short)1190344717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1410924544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751501312;
				if (num != 0)
				{
				}
				num = (short)1233059841;
				if (num != 0)
				{
				}
				this.dataProfVPNRekeyAttempts_A42213.HiddenDynamic = value;
			}
		}

		// Token: 0x170058CE RID: 22734
		// (get) Token: 0x0600B0CD RID: 45261 RVA: 0x00A3FAC4 File Offset: 0x00A3DCC4
		public bool DataProfVPNRekeyAttempts_A42213_HasDiffs
		{
			get
			{
				short num = (short)1489931584;
				short num2 = num;
				num = (short)1805749568;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1864761344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784007169;
				if (num != 0)
				{
				}
				num = (short)1890123776;
				if (num != 0)
				{
				}
				return this.dataProfVPNRekeyAttempts_A42213._HasDiffs;
			}
		}

		// Token: 0x170058CF RID: 22735
		// (get) Token: 0x0600B0CE RID: 45262 RVA: 0x00A3FB7C File Offset: 0x00A3DD7C
		// (set) Token: 0x0600B0CF RID: 45263 RVA: 0x00A3FC30 File Offset: 0x00A3DE30
		public int DataProfVPNKeySelection_42280Value
		{
			get
			{
				short num = (short)2029358593;
				short num2 = num;
				num = (short)1327074817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1700790272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)781647873;
				if (num != 0)
				{
				}
				num = (short)978518016;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.Value;
			}
			set
			{
				short num = (short)1970191134;
				short num2 = num;
				num = (short)857193246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667615232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1853882368;
				if (num != 0)
				{
				}
				num = (short)754843649;
				if (num != 0)
				{
				}
				this.dataProfVPNKeySelection_42280.Value = value;
			}
		}

		// Token: 0x170058D0 RID: 22736
		// (get) Token: 0x0600B0D0 RID: 45264 RVA: 0x00A3FCE4 File Offset: 0x00A3DEE4
		// (set) Token: 0x0600B0D1 RID: 45265 RVA: 0x00A3FD9C File Offset: 0x00A3DF9C
		public string DataProfVPNKeySelection_42280_UIValue
		{
			get
			{
				short num = (short)1181072926;
				short num2 = num;
				num = (short)779795998;
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
				num = (short)1993146368;
				if (num != 0)
				{
				}
				num = (short)19595265;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.UIValue;
			}
			set
			{
				short num = (short)1804026565;
				short num2 = num;
				num = (short)648692421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1641021440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)237305857;
				if (num != 0)
				{
				}
				num = (short)257753088;
				if (num != 0)
				{
				}
				this.dataProfVPNKeySelection_42280.UIValue = value;
			}
		}

		// Token: 0x170058D1 RID: 22737
		// (get) Token: 0x0600B0D2 RID: 45266 RVA: 0x00A3FE50 File Offset: 0x00A3E050
		public global::AcpBusinessLayer.AcpRecRefField DataProfVPNKeySelection_42280
		{
			get
			{
				short num = (short)2047687726;
				short num2 = num;
				num = (short)338836526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1175322624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074593793;
				if (num != 0)
				{
				}
				num = (short)2005073920;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280;
			}
		}

		// Token: 0x170058D2 RID: 22738
		// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x00A3FF00 File Offset: 0x00A3E100
		// (set) Token: 0x0600B0D4 RID: 45268 RVA: 0x00A3FFB4 File Offset: 0x00A3E1B4
		public bool DataProfVPNKeySelection_42280_Applicable
		{
			get
			{
				short num = (short)1768463875;
				short num2 = num;
				num = (short)1102552579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2053177344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16187392;
				if (num != 0)
				{
				}
				num = (short)1462435841;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.Applicable;
			}
			set
			{
				short num = (short)219361531;
				short num2 = num;
				num = (short)1977430267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)425328640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506462209;
				if (num != 0)
				{
				}
				num = (short)331218944;
				if (num != 0)
				{
				}
				this.dataProfVPNKeySelection_42280.Applicable = value;
			}
		}

		// Token: 0x170058D3 RID: 22739
		// (get) Token: 0x0600B0D5 RID: 45269 RVA: 0x00A4006C File Offset: 0x00A3E26C
		// (set) Token: 0x0600B0D6 RID: 45270 RVA: 0x00A40124 File Offset: 0x00A3E324
		public bool DataProfVPNKeySelection_42280_Valid
		{
			get
			{
				short num = (short)1550974977;
				if (num != 0)
				{
				}
				num = (short)1839792128;
				short num2 = num;
				num = (short)1320819427;
				short num3 = num;
				num = (short)1450449635;
				switch (num3 == num)
				{
				}
				num = (short)2142961664;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.Valid;
			}
			set
			{
				short num = (short)816339327;
				short num2 = num;
				num = (short)612129151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)488112128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1933508609;
				if (num != 0)
				{
				}
				num = (short)2055995392;
				if (num != 0)
				{
				}
				this.dataProfVPNKeySelection_42280.Valid = value;
			}
		}

		// Token: 0x170058D4 RID: 22740
		// (get) Token: 0x0600B0D7 RID: 45271 RVA: 0x00A401D8 File Offset: 0x00A3E3D8
		// (set) Token: 0x0600B0D8 RID: 45272 RVA: 0x00A4028C File Offset: 0x00A3E48C
		public bool DataProfVPNKeySelection_42280_Visible
		{
			get
			{
				short num = (short)1663172609;
				if (num != 0)
				{
				}
				num = (short)695795712;
				short num2 = num;
				num = (short)1520864868;
				short num3 = num;
				num = (short)1686408804;
				switch (num3 == num)
				{
				}
				num = (short)1322844160;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.Visible;
			}
			set
			{
				short num = (short)285297643;
				short num2 = num;
				num = (short)796740587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1973878784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)540213249;
				if (num != 0)
				{
				}
				num = (short)2121138176;
				if (num != 0)
				{
				}
				this.dataProfVPNKeySelection_42280.Visible = value;
			}
		}

		// Token: 0x170058D5 RID: 22741
		// (get) Token: 0x0600B0D9 RID: 45273 RVA: 0x00A40344 File Offset: 0x00A3E544
		// (set) Token: 0x0600B0DA RID: 45274 RVA: 0x00A403F8 File Offset: 0x00A3E5F8
		public bool DataProfVPNKeySelection_42280_Editable
		{
			get
			{
				short num = (short)1556293131;
				short num2 = num;
				num = (short)1651779083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1175584768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)204603393;
				if (num != 0)
				{
				}
				num = (short)1387069440;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.Editable;
			}
			set
			{
				short num = (short)2014945393;
				short num2 = num;
				num = (short)1010409585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)982122496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1555496960;
				if (num != 0)
				{
				}
				num = (short)489947137;
				if (num != 0)
				{
				}
				this.dataProfVPNKeySelection_42280.Editable = value;
			}
		}

		// Token: 0x170058D6 RID: 22742
		// (get) Token: 0x0600B0DB RID: 45275 RVA: 0x00A404B0 File Offset: 0x00A3E6B0
		internal string DataProfVPNKeySelection_42280_UILabel
		{
			get
			{
				short num = (short)48889857;
				if (num != 0)
				{
				}
				num = (short)344260608;
				short num2 = num;
				num = (short)1048969274;
				short num3 = num;
				num = (short)1085997114;
				switch (num3 == num)
				{
				}
				num = (short)1028390912;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.UIName;
			}
		}

		// Token: 0x170058D7 RID: 22743
		// (get) Token: 0x0600B0DC RID: 45276 RVA: 0x00A40564 File Offset: 0x00A3E764
		// (set) Token: 0x0600B0DD RID: 45277 RVA: 0x00A40618 File Offset: 0x00A3E818
		internal bool DataProfVPNKeySelection_42280_HiddenStatic
		{
			get
			{
				short num = (short)1964768698;
				short num2 = num;
				num = (short)444726714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036269056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)107741185;
				if (num != 0)
				{
				}
				num = (short)890830848;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.HiddenStatic;
			}
			set
			{
				short num = (short)1918213892;
				short num2 = num;
				num = (short)1977720580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1607270400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1935343616;
				if (num != 0)
				{
				}
				num = (short)1972436993;
				if (num != 0)
				{
				}
				this.dataProfVPNKeySelection_42280.HiddenStatic = value;
			}
		}

		// Token: 0x170058D8 RID: 22744
		// (get) Token: 0x0600B0DE RID: 45278 RVA: 0x00A406CC File Offset: 0x00A3E8CC
		// (set) Token: 0x0600B0DF RID: 45279 RVA: 0x00A40780 File Offset: 0x00A3E980
		internal bool DataProfVPNKeySelection_42280_HiddenDynamic
		{
			get
			{
				short num = (short)1740062736;
				short num2 = num;
				num = (short)1679573008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1860567040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)105119744;
				if (num != 0)
				{
				}
				num = (short)1043005441;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280.HiddenDynamic;
			}
			set
			{
				short num = (short)1043481941;
				short num2 = num;
				num = (short)1698055509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1281622016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1225654273;
				if (num != 0)
				{
				}
				num = (short)1203896320;
				if (num != 0)
				{
				}
				this.dataProfVPNKeySelection_42280.HiddenDynamic = value;
			}
		}

		// Token: 0x170058D9 RID: 22745
		// (get) Token: 0x0600B0E0 RID: 45280 RVA: 0x00A40834 File Offset: 0x00A3EA34
		public bool DataProfVPNKeySelection_42280_HasDiffs
		{
			get
			{
				short num = (short)1749375446;
				short num2 = num;
				num = (short)1282038230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)90308608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)135069697;
				if (num != 0)
				{
				}
				num = (short)1509228544;
				if (num != 0)
				{
				}
				return this.dataProfVPNKeySelection_42280._HasDiffs;
			}
		}

		// Token: 0x170058DA RID: 22746
		// (get) Token: 0x0600B0E1 RID: 45281 RVA: 0x00A408E8 File Offset: 0x00A3EAE8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1496783098;
				short num2 = num;
				num = (short)1793857786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1893335040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2039152640;
				if (num != 0)
				{
				}
				num = (short)2096693249;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170058DB RID: 22747
		// (get) Token: 0x0600B0E2 RID: 45282 RVA: 0x00A409A8 File Offset: 0x00A3EBA8
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)360491210;
				short num2 = num;
				num = (short)103721162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1545666560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1239941121;
				if (num != 0)
				{
				}
				num = (short)1759248384;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600B0E3 RID: 45283 RVA: 0x00A40A68 File Offset: 0x00A3EC68
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1375427844;
			short num2 = num;
			num = (short)1833131268;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CE:
				num = (short)1948647425;
				if (num != 0)
				{
				}
				num = (short)1057816578;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1590427648;
				short num4 = num;
				num = (short)1205796864;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				break;
			}
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_7E:
				switch (num3)
				{
				case 0:
					goto IL_CE;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)607125504;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)602537988;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1708720131;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_98;
			}
			return result;
			IL_98:
			result = null;
			num = (short)36503553;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x040053E4 RID: 21476
		private global::AcpBusinessLayer.AcpRecRefField dataProfNLSKeySele_A36410;

		// Token: 0x040053E5 RID: 21477
		private global::AcpBusinessLayer.AcpIPAddressField dataProfNLSEncGatewayAddr_A36412;

		// Token: 0x040053E6 RID: 21478
		private global::AcpBusinessLayer.AcpField<bool> dataProfNLSAllowRxClrPackData_A36414;

		// Token: 0x040053E7 RID: 21479
		private global::AcpBusinessLayer.AcpListField dataProfNLSSecClrStrp_A36415;

		// Token: 0x040053E8 RID: 21480
		private global::AcpBusinessLayer.AcpRecRefField dataProfNLSKMFProfSele_A36419;

		// Token: 0x040053E9 RID: 21481
		private global::AcpBusinessLayer.AcpIPAddressField dataProfVPNGatewayIPAddress_A42079;

		// Token: 0x040053EA RID: 21482
		private global::AcpBusinessLayer.AcpListField dataProfVPNSecClrStrp_A42120;

		// Token: 0x040053EB RID: 21483
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfVPNMessageRetransmissionTime_A42209;

		// Token: 0x040053EC RID: 21484
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfVPNMessageRetransmissionAttempts_A42210;

		// Token: 0x040053ED RID: 21485
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfVPNDeadPeerDetectionInterval_A42211;

		// Token: 0x040053EE RID: 21486
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfVPNRekeyMargin_A42212;

		// Token: 0x040053EF RID: 21487
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfVPNRekeyAttempts_A42213;

		// Token: 0x040053F0 RID: 21488
		private global::AcpBusinessLayer.AcpRecRefField dataProfVPNKeySelection_42280;
	}
}
