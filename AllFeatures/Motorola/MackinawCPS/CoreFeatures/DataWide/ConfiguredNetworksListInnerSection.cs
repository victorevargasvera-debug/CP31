using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004C5 RID: 1221
	[global::System.Serializable]
	public class ConfiguredNetworksListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A034 RID: 41012 RVA: 0x009569D4 File Offset: 0x00954BD4
		public ConfiguredNetworksListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x009569F0 File Offset: 0x00954BF0
		protected ConfiguredNetworksListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x00956A08 File Offset: 0x00954C08
		public override void Init()
		{
			int a_ = 17;
			short num = (short)714480854;
			short num2 = num;
			num = (short)1068571862;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1824587776;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)296222720;
			if (num != 0)
			{
			}
			num = (short)799145985;
			if (num != 0)
			{
			}
			this.dataWideWiFiNetworkPriority_42512 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟뗡跣ꃥ臧ꓩ觫髭蟯鷱蛳鷵ꣷ裹闻釽狿欁瀃缅圇㸉㸋㬍ℏ‑", a_), global::CommonResources.AcgResources.ID_NETWORKPRIORITY, 1, 255, null, null, 0, 1);
			this.dataWideWiFiNetworkPriority_42512.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideWiFiNetworkPriority_42512.DataTransferOrder = 31;
			this.dataWideWiFiNetworkPriority_42512.ShowHexValue = false;
			this.dataWideWiFiNetworkSecurityType_42516 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟뗡跣ꃥ臧ꓩ觫髭蟯鷱蛳鷵꯷鿹鿻诽狿欁瀃缅將猉簋欍伏☑☓⌕⤗Ⱉ", a_), global::CommonResources.AcgResources.ID_SECURITYTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideWiFiNetworkSecurityType_42516LovStrs);
			this.dataWideWiFiNetworkSecurityType_42516.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideWiFiNetworkSecurityType_42516.DataTransferOrder = 33;
			this.dataWideWiFiNetworkEncryptedNetworkPassword_42517 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("雓鯙퇟헡ꗣ\udee5\udce7\udce9\ud9eb\udeed쟯뛱췳쿵쯷쯹쳻쿽䓿㜁㜃㈅㴇䤉䤋䬍⌏匑嘓唕帗弙⤛⠝ᐟᨡ昣朥ᄧᰩᤫ栭࠯猱Գ5礷ह礻砽̿Ł癃E็祉籋絍ᙏၑ浓ፕᵗᥙ楛汝剟啡⁣幥⹧幩啫坭䝯㍱ㅳ㍵䡷䥹㵻䩽땿놁놃뚅뺇쾉쪋춍ꖏ꒑ꞓ햕\udc97ꦙꢛꞝ閟鲣鎥骧芯肱辵趷覹ﶻ躽膿蟅難﷉ﻋﻍ鏏", a_), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.WiFiPasswordEncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟뗡跣ꃥ臧ꓩ觫髭蟯鷱蛳鷵뷷铹鿻賽秿爁瀃挅氇䐉椋稍朏紑易紕䠗笙漛洝土䴡嘣䈥眧ḩḫᬭįԱ", a_), global::CommonResources.AcgResources.ID_ENCRYPTEDNETWORKPASSWORD);
			this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.IgnoreOnCompare = true;
			this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.IsMasked = true;
			this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.DataTransferOrder = -1;
			this.dataWideWiFiNetworkSSID_42519 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟뗡跣ꃥ臧ꓩ觫髭蟯鷱蛳鷵꯷꧹뗻뫽忿㘁㘃㌅㤇㌉", a_), global::CommonResources.AcgResources.ID_NETWORKSSID, 32);
			this.dataWideWiFiNetworkSSID_42519.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideWiFiNetworkSSID_42519.DataTransferOrder = 32;
			this.dataWideWiFiNetworkSSID_42519.ValidateAcrossRecset = true;
			this.dataWideWIFINetworkHidden = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟뗡귣ꃥꇧꓩ觫髭蟯鷱蛳鷵냷鏹飻髽旿氁", a_), global::CommonResources.AcgResources.ID_HIDDENNETWORK);
			this.dataWideWIFINetworkHidden.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideWIFINetworkHidden.DataTransferOrder = 34;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("金믓룕뻗동믛ꯝ鋟蟡胣웥ꛧ迩飫駭鿯胱鿳藵\ud8f7뛹闻跽瓿", a_);
			base.Id = 10794;
			base.UIName = global::CommonResources.AcgResources.ID_CONFIGUREDNETWORKSLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x00956C5C File Offset: 0x00954E5C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1063452688;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1365180431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.dataWideWiFiNetworkSecurityType_42516 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘닚鯜뛞꿠蛢釤郦蛨駪蛬볮铰郲胴藶郸迺蓼꯾砀猂怄堆㴈㤊㠌㸎✐", a_), global::CommonResources.AcgResources.ID_SECURITYTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideWiFiNetworkSecurityType_42516LovStrs);
					this.dataWideWiFiNetworkSecurityType_42516.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideWiFiNetworkSecurityType_42516.DataTransferOrder = 33;
					num = (short)1905983494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.dataWideWiFiNetworkPriority_42512 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘닚鯜뛞꿠蛢釤郦蛨駪蛬뿮菰髲髴藶郸迺蓼ꃾ㔀㄂〄㘆㬈", a_), global::CommonResources.AcgResources.ID_NETWORKPRIORITY, null, null, 0, 1);
					this.dataWideWiFiNetworkPriority_42512.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideWiFiNetworkPriority_42512.DataTransferOrder = 31;
					this.dataWideWiFiNetworkPriority_42512.ShowHexValue = false;
					num = (short)2001666052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1AD;
				case 4:
					goto IL_47E;
				case 5:
					this.dataWideWIFINetworkHidden = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘鋚鯜雞꿠蛢釤郦蛨駪蛬꟮飰韲釴鋶韸", a_), global::CommonResources.AcgResources.ID_HIDDENNETWORK);
					this.dataWideWIFINetworkHidden.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideWIFINetworkHidden.DataTransferOrder = 34;
					num = (short)740884497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_113;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘닚鯜뛞꿠蛢釤郦蛨駪蛬ꫮ鿰郲蟴軶觸迺飼鯾伀昂焄瀆昈礊昌弎瀐怒昔怖瘘椚礜䀞ᔠᄢဤᘦḨ", a_)))
					{
						num = (short)1155727369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
				case 8:
					if (producerFields != null)
					{
						num = (short)2055274496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4F5;
				case 9:
					this.dataWideWiFiNetworkEncryptedNetworkPassword_42517 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("﯈觊ﻌ龜郐髚ퟠ훢헤탦귨틪퓬\udcee샰쏲쓴돶쳸죺짼쫾䈀䘂䀄㐆䠈䤊丌䤎吐☒⌔⌖℘多尜☞ᜠᘢ挤ἦ栨ᨪᬬ渮Ȱ瘲猴琶稸ऺ笼社牀獂癄ņୈ牊ࡌ੎ቐ晒杔敖湘὚敜ᥞ啠婢層偦⡨⹪⡬彮䉰㉲䅴䉶䩸乺䵼䥾쒀얂욄늆뾈뢊캌쮎ꊐꞒ겔ꊖ\uda98ꎚꢜ궞閦鮨钬骮芰薴躸覺ﲼ趾蓆", a_), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.WiFiPasswordEncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘닚鯜뛞꿠蛢釤郦蛨駪蛬ꫮ鿰郲蟴軶觸迺飼鯾伀昂焄瀆昈礊昌弎瀐怒昔怖瘘椚礜䀞ᔠᄢဤᘦḨ", a_), global::CommonResources.AcgResources.ID_ENCRYPTEDNETWORKPASSWORD);
					this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.IgnoreOnCompare = true;
					this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.IsMasked = true;
					this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.DataTransferOrder = -1;
					num = (short)568655890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)77377454;
					short num3 = num;
					num = (short)696889262;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_246;
					default:
						num = (short)1437925376;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘鋚鯜雞꿠蛢釤郦蛨駪蛬꟮飰韲釴鋶韸", a_)))
						{
							num = (short)1561395205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F5;
					}
					break;
				}
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘닚鯜뛞꿠蛢釤郦蛨駪蛬볮ꋰ뫲뇴ꣶ췸짺주컾㠀", a_)))
					{
						num = (short)877854733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AD;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘닚鯜뛞꿠蛢釤郦蛨駪蛬볮铰郲胴藶郸迺蓼꯾砀猂怄堆㴈㤊㠌㸎✐", a_)))
					{
						num = (short)644415489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_113;
				case 13:
					this.dataWideWiFiNetworkSSID_42519 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘닚鯜뛞꿠蛢釤郦蛨駪蛬볮ꋰ뫲뇴ꣶ췸짺주컾㠀", a_), global::CommonResources.AcgResources.ID_NETWORKSSID, 32);
					this.dataWideWiFiNetworkSSID_42519.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideWiFiNetworkSSID_42519.DataTransferOrder = 32;
					this.dataWideWiFiNetworkSSID_42519.ValidateAcrossRecset = true;
					num = (short)598540291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_246;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖軘닚鯜뛞꿠蛢釤郦蛨駪蛬뿮菰髲髴藶郸迺蓼ꃾ㔀㄂〄㘆㬈", a_)))
					{
						num = (short)1123090434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_47E;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 17:
					goto IL_33C;
				case 18:
					goto IL_9E;
				}
				IL_7A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)242941966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9E:
				num = (short)803078145;
				if (num != 0)
				{
				}
				num = (short)1919221771;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_113:
				num = (short)1260060679;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AD:
				num = (short)51707914;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_246:
				num = (short)159383560;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_47E:
				num = (short)478674944;
				short num4 = num;
				num = (short)1054539788;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_33C:
			IL_4F5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諈꓊ꏌ꧎룐듒ꃔꗖ볘뿚﷜釞蓠韢鋤裦鯨胪黬쿮뷰髲蛴菶", a_);
			base.Id = 10794;
			base.UIName = global::CommonResources.AcgResources.ID_CONFIGUREDNETWORKSLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x00957190 File Offset: 0x00955390
		public override void PopulateReferences()
		{
			short num = (short)1696824609;
			short num2 = num;
			num = (short)1122139425;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1237909504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1798176769;
			if (num != 0)
			{
			}
			num = (short)1911291904;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x0095723C File Offset: 0x0095543C
		public override void DropReferences()
		{
			short num = (short)313535385;
			short num2 = num;
			num = (short)1232087961;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1093795840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1331757057;
			if (num != 0)
			{
			}
			num = (short)1579417600;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x009572E4 File Offset: 0x009554E4
		public override void SetConstraints()
		{
			short num = (short)1072037889;
			if (num != 0)
			{
			}
			num = (short)1045364736;
			short num2 = num;
			num = (short)864163527;
			short num3 = num;
			num = (short)1048516295;
			switch (num3 == num)
			{
			}
			num = (short)1151926272;
			if (num != 0)
			{
			}
			this.dataWideWiFiNetworkPriority_42512.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiFiIsApp);
			this.dataWideWiFiNetworkSecurityType_42516.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiFiIsApp);
			this.dataWideWiFiNetworkSecurityType_42516.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConClearWiFiPWD);
			this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiFiPasswordIsApp);
			this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiFiPasswordIsValid);
			this.dataWideWiFiNetworkSSID_42519.ValidateAcrossRecset = true;
			this.dataWideWiFiNetworkSSID_42519.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiFiIsApp);
			this.dataWideWiFiNetworkSSID_42519.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiFiSSIDIsValid);
			this.dataWideWiFiNetworkSSID_42519.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConClearWiFiPWDWhenSSIDChange);
			this.dataWideWIFINetworkHidden.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiFiIsApp);
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x00957468 File Offset: 0x00955668
		public override void SetupDependencies()
		{
			short num = (short)538687992;
			short num2 = num;
			num = (short)605403640;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1761411072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)815202304;
			if (num != 0)
			{
			}
			num = (short)1035337729;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			dataWide.WIFI.DataWideWIFIEnable_42506.AddDependentObject(this.dataWideWiFiNetworkPriority_42512);
			dataWide.WIFI.DataWideWIFIEnable_42506.AddDependentObject(this.dataWideWiFiNetworkSecurityType_42516);
			dataWide.WIFI.DataWideWIFIEnable_42506.AddDependentObject(this.dataWideWiFiNetworkSSID_42519);
			dataWide.WIFI.DataWideWIFIEnable_42506.AddDependentObject(this.dataWideWIFINetworkHidden);
		}

		// Token: 0x1700505B RID: 20571
		// (get) Token: 0x0600A03C RID: 41020 RVA: 0x00957584 File Offset: 0x00955784
		public bool HasDiffs
		{
			get
			{
				short num = (short)2028302;
				short num2 = num;
				num = (short)812315406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1330315264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)653131777;
				if (num != 0)
				{
				}
				num = (short)1388511232;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700505C RID: 20572
		// (get) Token: 0x0600A03D RID: 41021 RVA: 0x00957634 File Offset: 0x00955834
		// (set) Token: 0x0600A03E RID: 41022 RVA: 0x009576E8 File Offset: 0x009558E8
		public int DataWideWiFiNetworkPriority_42512Value
		{
			get
			{
				short num = (short)1147813395;
				short num2 = num;
				num = (short)2055355923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)549322752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2123235329;
				if (num != 0)
				{
				}
				num = (short)258277376;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.Value;
			}
			set
			{
				short num = (short)1701707646;
				short num2 = num;
				num = (short)671940478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1657470976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)617611265;
				if (num != 0)
				{
				}
				num = (short)775225344;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.Value = value;
			}
		}

		// Token: 0x1700505D RID: 20573
		// (get) Token: 0x0600A03F RID: 41023 RVA: 0x009577A0 File Offset: 0x009559A0
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideWiFiNetworkPriority_42512
		{
			get
			{
				short num = (short)1416245501;
				short num2 = num;
				num = (short)700788989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448542208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344850432;
				if (num != 0)
				{
				}
				num = (short)510722049;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512;
			}
		}

		// Token: 0x1700505E RID: 20574
		// (get) Token: 0x0600A040 RID: 41024 RVA: 0x00957854 File Offset: 0x00955A54
		// (set) Token: 0x0600A041 RID: 41025 RVA: 0x00957908 File Offset: 0x00955B08
		public string DataWideWiFiNetworkPriority_42512_UIValue
		{
			get
			{
				short num = (short)1596414569;
				short num2 = num;
				num = (short)1572887145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1463549952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1587019776;
				if (num != 0)
				{
				}
				num = (short)1987837953;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.UIValue;
			}
			set
			{
				short num = (short)1978083484;
				short num2 = num;
				num = (short)90319004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584398336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1223491585;
				if (num != 0)
				{
				}
				num = (short)744226816;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.UIValue = value;
			}
		}

		// Token: 0x1700505F RID: 20575
		// (get) Token: 0x0600A042 RID: 41026 RVA: 0x009579C0 File Offset: 0x00955BC0
		// (set) Token: 0x0600A043 RID: 41027 RVA: 0x00957A74 File Offset: 0x00955C74
		internal int DataWideWiFiNetworkPriority_42512Min
		{
			get
			{
				short num = (short)267470199;
				short num2 = num;
				num = (short)2119124343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1844051968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)668139521;
				if (num != 0)
				{
				}
				num = (short)66650112;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.Min;
			}
			set
			{
				short num = (short)1820222513;
				short num2 = num;
				num = (short)1615029297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217331200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)657063936;
				if (num != 0)
				{
				}
				num = (short)1130627073;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.Min = value;
			}
		}

		// Token: 0x17005060 RID: 20576
		// (get) Token: 0x0600A044 RID: 41028 RVA: 0x00957B2C File Offset: 0x00955D2C
		// (set) Token: 0x0600A045 RID: 41029 RVA: 0x00957BE4 File Offset: 0x00955DE4
		internal int DataWideWiFiNetworkPriority_42512Max
		{
			get
			{
				short num = (short)576877838;
				short num2 = num;
				num = (short)1776448782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2138570752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2883585;
				if (num != 0)
				{
				}
				num = (short)508100608;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.Max;
			}
			set
			{
				short num = (short)1592762216;
				short num2 = num;
				num = (short)54501224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)252772352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28442625;
				if (num != 0)
				{
				}
				num = (short)1826881536;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.Max = value;
			}
		}

		// Token: 0x17005061 RID: 20577
		// (get) Token: 0x0600A046 RID: 41030 RVA: 0x00957C98 File Offset: 0x00955E98
		// (set) Token: 0x0600A047 RID: 41031 RVA: 0x00957D4C File Offset: 0x00955F4C
		internal int DataWideWiFiNetworkPriority_42512Step
		{
			get
			{
				short num = (short)2092521259;
				short num2 = num;
				num = (short)1688229675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1243480064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1078329345;
				if (num != 0)
				{
				}
				num = (short)1467351040;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.StepSize;
			}
			set
			{
				short num = (short)1131605566;
				short num2 = num;
				num = (short)772402750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1474560000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690828801;
				if (num != 0)
				{
				}
				num = (short)2085355520;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.StepSize = value;
			}
		}

		// Token: 0x17005062 RID: 20578
		// (get) Token: 0x0600A048 RID: 41032 RVA: 0x00957E00 File Offset: 0x00956000
		// (set) Token: 0x0600A049 RID: 41033 RVA: 0x00957EB0 File Offset: 0x009560B0
		public bool DataWideWiFiNetworkPriority_42512_Applicable
		{
			get
			{
				short num = (short)1010086094;
				short num2 = num;
				num = (short)1734193358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597964288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989855745;
				if (num != 0)
				{
				}
				num = (short)1344929792;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.Applicable;
			}
			set
			{
				short num = (short)1451420595;
				short num2 = num;
				num = (short)1789782963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075445760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1482096641;
				if (num != 0)
				{
				}
				num = (short)896729088;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.Applicable = value;
			}
		}

		// Token: 0x17005063 RID: 20579
		// (get) Token: 0x0600A04A RID: 41034 RVA: 0x00957F68 File Offset: 0x00956168
		// (set) Token: 0x0600A04B RID: 41035 RVA: 0x00958020 File Offset: 0x00956220
		public bool DataWideWiFiNetworkPriority_42512_Valid
		{
			get
			{
				short num = (short)1462545086;
				short num2 = num;
				num = (short)830515902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)568721408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)392888321;
				if (num != 0)
				{
				}
				num = (short)1223294976;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.Valid;
			}
			set
			{
				short num = (short)1878120129;
				short num2 = num;
				num = (short)2079315649;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1129447424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007288321;
				if (num != 0)
				{
				}
				num = (short)790036480;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.Valid = value;
			}
		}

		// Token: 0x17005064 RID: 20580
		// (get) Token: 0x0600A04C RID: 41036 RVA: 0x009580D8 File Offset: 0x009562D8
		// (set) Token: 0x0600A04D RID: 41037 RVA: 0x0095818C File Offset: 0x0095638C
		public bool DataWideWiFiNetworkPriority_42512_Visible
		{
			get
			{
				short num = (short)1782777604;
				short num2 = num;
				num = (short)2084701956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)623509504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)419758081;
				if (num != 0)
				{
				}
				num = (short)1667956736;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.Visible;
			}
			set
			{
				short num = (short)962429497;
				short num2 = num;
				num = (short)1353286201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610285056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1109524481;
				if (num != 0)
				{
				}
				num = (short)1828716544;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.Visible = value;
			}
		}

		// Token: 0x17005065 RID: 20581
		// (get) Token: 0x0600A04E RID: 41038 RVA: 0x00958240 File Offset: 0x00956440
		// (set) Token: 0x0600A04F RID: 41039 RVA: 0x009582F8 File Offset: 0x009564F8
		public bool DataWideWiFiNetworkPriority_42512_Editable
		{
			get
			{
				short num = (short)2042230820;
				short num2 = num;
				num = (short)630257700;
				switch (num2 == num)
				{
				}
				num = (short)1310588928;
				short num3 = num;
				num = (short)1105592321;
				if (num != 0)
				{
				}
				num = (short)1138163712;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.Editable;
			}
			set
			{
				short num = (short)1032323073;
				if (num != 0)
				{
				}
				num = (short)1658764364;
				short num2 = num;
				num = (short)1634647116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)116719616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1370095616;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.Editable = value;
			}
		}

		// Token: 0x17005066 RID: 20582
		// (get) Token: 0x0600A050 RID: 41040 RVA: 0x009583AC File Offset: 0x009565AC
		internal string DataWideWiFiNetworkPriority_42512_UILabel
		{
			get
			{
				short num = (short)1046049956;
				short num2 = num;
				num = (short)988771492;
				switch (num2 == num)
				{
				}
				num = (short)886177792;
				short num3 = num;
				num = (short)1358626817;
				if (num != 0)
				{
				}
				num = (short)1328087040;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.UIName;
			}
		}

		// Token: 0x17005067 RID: 20583
		// (get) Token: 0x0600A051 RID: 41041 RVA: 0x00958460 File Offset: 0x00956660
		// (set) Token: 0x0600A052 RID: 41042 RVA: 0x00958514 File Offset: 0x00956714
		internal bool DataWideWiFiNetworkPriority_42512_HiddenStatic
		{
			get
			{
				short num = (short)226250498;
				short num2 = num;
				num = (short)1862618882;
				switch (num2 == num)
				{
				}
				num = (short)55640064;
				short num3 = num;
				num = (short)807665665;
				if (num != 0)
				{
				}
				num = (short)1786707968;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.HiddenStatic;
			}
			set
			{
				short num = (short)1155946727;
				short num2 = num;
				num = (short)573069543;
				switch (num2 == num)
				{
				}
				num = (short)1691811840;
				short num3 = num;
				num = (short)545652736;
				if (num != 0)
				{
				}
				num = (short)1508966401;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.HiddenStatic = value;
			}
		}

		// Token: 0x17005068 RID: 20584
		// (get) Token: 0x0600A053 RID: 41043 RVA: 0x009585C8 File Offset: 0x009567C8
		// (set) Token: 0x0600A054 RID: 41044 RVA: 0x0095867C File Offset: 0x0095687C
		internal bool DataWideWiFiNetworkPriority_42512_HiddenDynamic
		{
			get
			{
				short num = (short)1306993146;
				short num2 = num;
				num = (short)1483219450;
				switch (num2 == num)
				{
				}
				num = (short)1535836160;
				short num3 = num;
				num = (short)1942880257;
				if (num != 0)
				{
				}
				num = (short)1300365312;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512.HiddenDynamic;
			}
			set
			{
				short num = (short)975437825;
				if (num != 0)
				{
				}
				num = (short)2100824091;
				short num2 = num;
				num = (short)1740441627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1467154432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1549729792;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkPriority_42512.HiddenDynamic = value;
			}
		}

		// Token: 0x17005069 RID: 20585
		// (get) Token: 0x0600A055 RID: 41045 RVA: 0x00958730 File Offset: 0x00956930
		public bool DataWideWiFiNetworkPriority_42512_HasDiffs
		{
			get
			{
				short num = (short)531121099;
				short num2 = num;
				num = (short)2060272587;
				switch (num2 == num)
				{
				}
				num = (short)732889088;
				short num3 = num;
				num = (short)1353383937;
				if (num != 0)
				{
				}
				num = (short)1326907392;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkPriority_42512._HasDiffs;
			}
		}

		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x0600A056 RID: 41046 RVA: 0x009587E4 File Offset: 0x009569E4
		// (set) Token: 0x0600A057 RID: 41047 RVA: 0x0095889C File Offset: 0x00956A9C
		public int DataWideWiFiNetworkSecurityType_42516Value
		{
			get
			{
				short num = (short)665524713;
				short num2 = num;
				num = (short)106699241;
				switch (num2 == num)
				{
				}
				num = (short)1329659904;
				short num3 = num;
				num = (short)422379521;
				if (num != 0)
				{
				}
				num = (short)213975040;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.Value;
			}
			set
			{
				short num = (short)762154723;
				short num2 = num;
				num = (short)2032504547;
				switch (num2 == num)
				{
				}
				num = (short)1695285248;
				short num3 = num;
				num = (short)649003009;
				if (num != 0)
				{
				}
				num = (short)165281792;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSecurityType_42516.Value = value;
			}
		}

		// Token: 0x1700506B RID: 20587
		// (get) Token: 0x0600A058 RID: 41048 RVA: 0x00958954 File Offset: 0x00956B54
		// (set) Token: 0x0600A059 RID: 41049 RVA: 0x00958A08 File Offset: 0x00956C08
		public string DataWideWiFiNetworkSecurityType_42516_UIValue
		{
			get
			{
				short num = (short)779985412;
				short num2 = num;
				num = (short)2021302788;
				switch (num2 == num)
				{
				}
				num = (short)2091778048;
				short num3 = num;
				num = (short)852426753;
				if (num != 0)
				{
				}
				num = (short)1390739456;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.UIValue;
			}
			set
			{
				short num = (short)460787133;
				short num2 = num;
				num = (short)886050237;
				switch (num2 == num)
				{
				}
				num = (short)996147200;
				short num3 = num;
				num = (short)957808641;
				if (num != 0)
				{
				}
				num = (short)1972043776;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSecurityType_42516.UIValue = value;
			}
		}

		// Token: 0x1700506C RID: 20588
		// (get) Token: 0x0600A05A RID: 41050 RVA: 0x00958ABC File Offset: 0x00956CBC
		public global::AcpBusinessLayer.AcpListField DataWideWiFiNetworkSecurityType_42516
		{
			get
			{
				short num = (short)982477397;
				short num2 = num;
				num = (short)1012296277;
				switch (num2 == num)
				{
				}
				num = (short)787546112;
				short num3 = num;
				num = (short)63963137;
				if (num != 0)
				{
				}
				num = (short)1747255296;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516;
			}
		}

		// Token: 0x1700506D RID: 20589
		// (get) Token: 0x0600A05B RID: 41051 RVA: 0x00958B70 File Offset: 0x00956D70
		// (set) Token: 0x0600A05C RID: 41052 RVA: 0x00958C28 File Offset: 0x00956E28
		public bool DataWideWiFiNetworkSecurityType_42516_Applicable
		{
			get
			{
				short num = (short)258393340;
				short num2 = num;
				num = (short)1978844412;
				switch (num2 == num)
				{
				}
				num = (short)181403648;
				short num3 = num;
				num = (short)619511809;
				if (num != 0)
				{
				}
				num = (short)982384640;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.Applicable;
			}
			set
			{
				short num = (short)317325313;
				if (num != 0)
				{
				}
				num = (short)1256669538;
				short num2 = num;
				num = (short)775700834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)632291328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)630718464;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSecurityType_42516.Applicable = value;
			}
		}

		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x0600A05D RID: 41053 RVA: 0x00958CDC File Offset: 0x00956EDC
		// (set) Token: 0x0600A05E RID: 41054 RVA: 0x00958D94 File Offset: 0x00956F94
		public bool DataWideWiFiNetworkSecurityType_42516_Valid
		{
			get
			{
				short num = (short)1922328580;
				short num2 = num;
				num = (short)45836292;
				switch (num2 == num)
				{
				}
				num = (short)776798208;
				short num3 = num;
				num = (short)1288962049;
				if (num != 0)
				{
				}
				num = (short)432865280;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.Valid;
			}
			set
			{
				short num = (short)805945432;
				short num2 = num;
				num = (short)244564056;
				switch (num2 == num)
				{
				}
				num = (short)1976565760;
				short num3 = num;
				num = (short)1948254209;
				if (num != 0)
				{
				}
				num = (short)577896448;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSecurityType_42516.Valid = value;
			}
		}

		// Token: 0x1700506F RID: 20591
		// (get) Token: 0x0600A05F RID: 41055 RVA: 0x00958E48 File Offset: 0x00957048
		// (set) Token: 0x0600A060 RID: 41056 RVA: 0x00958F00 File Offset: 0x00957100
		public bool DataWideWiFiNetworkSecurityType_42516_Visible
		{
			get
			{
				short num = (short)2100700982;
				short num2 = num;
				num = (short)2026186550;
				switch (num2 == num)
				{
				}
				num = (short)934871040;
				short num3 = num;
				num = (short)987168769;
				if (num != 0)
				{
				}
				num = (short)2095382528;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.Visible;
			}
			set
			{
				short num = (short)1654827557;
				short num2 = num;
				num = (short)1922345509;
				switch (num2 == num)
				{
				}
				num = (short)1850998784;
				short num3 = num;
				num = (short)313196544;
				if (num != 0)
				{
				}
				num = (short)1128857601;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSecurityType_42516.Visible = value;
			}
		}

		// Token: 0x17005070 RID: 20592
		// (get) Token: 0x0600A061 RID: 41057 RVA: 0x00958FB8 File Offset: 0x009571B8
		// (set) Token: 0x0600A062 RID: 41058 RVA: 0x0095906C File Offset: 0x0095726C
		public bool DataWideWiFiNetworkSecurityType_42516_Editable
		{
			get
			{
				short num = (short)1436891077;
				short num2 = num;
				num = (short)2098214853;
				switch (num2 == num)
				{
				}
				num = (short)990183424;
				short num3 = num;
				num = (short)432078849;
				if (num != 0)
				{
				}
				num = (short)1490812928;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.Editable;
			}
			set
			{
				short num = (short)944566777;
				short num2 = num;
				num = (short)1166995961;
				switch (num2 == num)
				{
				}
				num = (short)909574144;
				short num3 = num;
				num = (short)1381629953;
				if (num != 0)
				{
				}
				num = (short)461307904;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSecurityType_42516.Editable = value;
			}
		}

		// Token: 0x17005071 RID: 20593
		// (get) Token: 0x0600A063 RID: 41059 RVA: 0x00959120 File Offset: 0x00957320
		internal string DataWideWiFiNetworkSecurityType_42516_UILabel
		{
			get
			{
				short num = (short)799785027;
				short num2 = num;
				num = (short)8634435;
				switch (num2 == num)
				{
				}
				num = (short)1337524224;
				short num3 = num;
				num = (short)1394933760;
				if (num != 0)
				{
				}
				num = (short)1291059201;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.UIName;
			}
		}

		// Token: 0x17005072 RID: 20594
		// (get) Token: 0x0600A064 RID: 41060 RVA: 0x009591D4 File Offset: 0x009573D4
		// (set) Token: 0x0600A065 RID: 41061 RVA: 0x0095928C File Offset: 0x0095748C
		internal bool DataWideWiFiNetworkSecurityType_42516_HiddenStatic
		{
			get
			{
				short num = (short)154927105;
				if (num != 0)
				{
				}
				num = (short)2048264755;
				short num2 = num;
				num = (short)455150131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)831389696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1795227648;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.HiddenStatic;
			}
			set
			{
				short num = (short)1033170174;
				short num2 = num;
				num = (short)1492839678;
				switch (num2 == num)
				{
				}
				num = (short)589496320;
				short num3 = num;
				num = (short)567934977;
				if (num != 0)
				{
				}
				num = (short)731840512;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSecurityType_42516.HiddenStatic = value;
			}
		}

		// Token: 0x17005073 RID: 20595
		// (get) Token: 0x0600A066 RID: 41062 RVA: 0x00959340 File Offset: 0x00957540
		// (set) Token: 0x0600A067 RID: 41063 RVA: 0x009593F4 File Offset: 0x009575F4
		internal bool DataWideWiFiNetworkSecurityType_42516_HiddenDynamic
		{
			get
			{
				short num = (short)2146435073;
				if (num != 0)
				{
				}
				num = (short)938052016;
				short num2 = num;
				num = (short)387221936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)147456000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)93192192;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516.HiddenDynamic;
			}
			set
			{
				short num = (short)107554626;
				short num2 = num;
				num = (short)1950361410;
				switch (num2 == num)
				{
				}
				num = (short)1037697024;
				short num3 = num;
				num = (short)1371209729;
				if (num != 0)
				{
				}
				num = (short)895090688;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSecurityType_42516.HiddenDynamic = value;
			}
		}

		// Token: 0x17005074 RID: 20596
		// (get) Token: 0x0600A068 RID: 41064 RVA: 0x009594A8 File Offset: 0x009576A8
		public bool DataWideWiFiNetworkSecurityType_42516_HasDiffs
		{
			get
			{
				short num = (short)1882984205;
				short num2 = num;
				num = (short)1196494605;
				switch (num2 == num)
				{
				}
				num = (short)322633728;
				short num3 = num;
				num = (short)874381313;
				if (num != 0)
				{
				}
				num = (short)982188032;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSecurityType_42516._HasDiffs;
			}
		}

		// Token: 0x17005075 RID: 20597
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x00959560 File Offset: 0x00957760
		// (set) Token: 0x0600A06A RID: 41066 RVA: 0x00959618 File Offset: 0x00957818
		public string DataWideWiFiNetworkEncryptedNetworkPassword_42517Value
		{
			get
			{
				short num = (short)855002833;
				short num2 = num;
				num = (short)930959057;
				switch (num2 == num)
				{
				}
				num = (short)906756096;
				short num3 = num;
				num = (short)1326972929;
				if (num != 0)
				{
				}
				num = (short)898629632;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Value;
			}
			set
			{
				short num = (short)212074497;
				if (num != 0)
				{
				}
				num = (short)1553227515;
				short num2 = num;
				num = (short)2041143035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1392443392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1212350464;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Value = value;
			}
		}

		// Token: 0x17005076 RID: 20598
		// (get) Token: 0x0600A06B RID: 41067 RVA: 0x009596D0 File Offset: 0x009578D0
		public global::AcpBusinessLayer.AcpFieldX<string, string> DataWideWiFiNetworkEncryptedNetworkPassword_42517
		{
			get
			{
				short num = (short)1443254574;
				short num2 = num;
				num = (short)1113739566;
				switch (num2 == num)
				{
				}
				num = (short)769327104;
				short num3 = num;
				num = (short)388104192;
				if (num != 0)
				{
				}
				num = (short)2006712321;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517;
			}
		}

		// Token: 0x17005077 RID: 20599
		// (get) Token: 0x0600A06C RID: 41068 RVA: 0x00959784 File Offset: 0x00957984
		// (set) Token: 0x0600A06D RID: 41069 RVA: 0x00959838 File Offset: 0x00957A38
		public string DataWideWiFiNetworkEncryptedNetworkPassword_42517_UIValue
		{
			get
			{
				short num = (short)2115229714;
				short num2 = num;
				num = (short)121493522;
				switch (num2 == num)
				{
				}
				num = (short)1717305344;
				short num3 = num;
				num = (short)675414017;
				if (num != 0)
				{
				}
				num = (short)1385431040;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.UIValue;
			}
			set
			{
				short num = (short)1050035732;
				short num2 = num;
				num = (short)1682916884;
				switch (num2 == num)
				{
				}
				num = (short)1262419968;
				short num3 = num;
				num = (short)818741249;
				if (num != 0)
				{
				}
				num = (short)1987313664;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.UIValue = value;
			}
		}

		// Token: 0x17005078 RID: 20600
		// (get) Token: 0x0600A06E RID: 41070 RVA: 0x009598F0 File Offset: 0x00957AF0
		// (set) Token: 0x0600A06F RID: 41071 RVA: 0x009599A4 File Offset: 0x00957BA4
		public bool DataWideWiFiNetworkEncryptedNetworkPassword_42517_Applicable
		{
			get
			{
				short num = (short)1663609001;
				short num2 = num;
				num = (short)679651497;
				switch (num2 == num)
				{
				}
				num = (short)601948160;
				short num3 = num;
				num = (short)1890582529;
				if (num != 0)
				{
				}
				num = (short)781844480;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Applicable;
			}
			set
			{
				short num = (short)621674497;
				if (num != 0)
				{
				}
				num = (short)1863842535;
				short num2 = num;
				num = (short)709360359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325648384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)724041728;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Applicable = value;
			}
		}

		// Token: 0x17005079 RID: 20601
		// (get) Token: 0x0600A070 RID: 41072 RVA: 0x00959A58 File Offset: 0x00957C58
		// (set) Token: 0x0600A071 RID: 41073 RVA: 0x00959B10 File Offset: 0x00957D10
		public bool DataWideWiFiNetworkEncryptedNetworkPassword_42517_Valid
		{
			get
			{
				short num = (short)327758709;
				short num2 = num;
				num = (short)1660957557;
				switch (num2 == num)
				{
				}
				num = (short)1300037632;
				short num3 = num;
				num = (short)1042087937;
				if (num != 0)
				{
				}
				num = (short)1232470016;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Valid;
			}
			set
			{
				short num = (short)716046337;
				if (num != 0)
				{
				}
				num = (short)1673878138;
				short num2 = num;
				num = (short)1895979642;
				switch (num2 == num)
				{
				default:
				{
					num = (short)151912448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1369440256;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Valid = value;
			}
		}

		// Token: 0x1700507A RID: 20602
		// (get) Token: 0x0600A072 RID: 41074 RVA: 0x00959BC4 File Offset: 0x00957DC4
		// (set) Token: 0x0600A073 RID: 41075 RVA: 0x00959C74 File Offset: 0x00957E74
		public bool DataWideWiFiNetworkEncryptedNetworkPassword_42517_Visible
		{
			get
			{
				short num = (short)1945060692;
				short num2 = num;
				num = (short)1973241172;
				switch (num2 == num)
				{
				}
				num = (short)1068367872;
				short num3 = num;
				num = (short)840761345;
				if (num != 0)
				{
				}
				num = (short)1902641152;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Visible;
			}
			set
			{
				short num = (short)34776075;
				short num2 = num;
				num = (short)520201227;
				switch (num2 == num)
				{
				}
				num = (short)1469972480;
				short num3 = num;
				num = (short)1071972353;
				if (num != 0)
				{
				}
				num = (short)2144927744;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Visible = value;
			}
		}

		// Token: 0x1700507B RID: 20603
		// (get) Token: 0x0600A074 RID: 41076 RVA: 0x00959D30 File Offset: 0x00957F30
		// (set) Token: 0x0600A075 RID: 41077 RVA: 0x00959DE4 File Offset: 0x00957FE4
		public bool DataWideWiFiNetworkEncryptedNetworkPassword_42517_Editable
		{
			get
			{
				short num = (short)1882121516;
				short num2 = num;
				num = (short)69788972;
				switch (num2 == num)
				{
				}
				num = (short)1391525888;
				short num3 = num;
				num = (short)630456321;
				if (num != 0)
				{
				}
				num = (short)1814822912;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Editable;
			}
			set
			{
				short num = (short)1438440836;
				short num2 = num;
				num = (short)700833156;
				switch (num2 == num)
				{
				}
				num = (short)2028404736;
				short num3 = num;
				num = (short)1090191361;
				if (num != 0)
				{
				}
				num = (short)1711800320;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.Editable = value;
			}
		}

		// Token: 0x1700507C RID: 20604
		// (get) Token: 0x0600A076 RID: 41078 RVA: 0x00959E9C File Offset: 0x0095809C
		internal string DataWideWiFiNetworkEncryptedNetworkPassword_42517_UILabel
		{
			get
			{
				short num = (short)1577855201;
				short num2 = num;
				num = (short)2088380641;
				switch (num2 == num)
				{
				}
				num = (short)336330752;
				short num3 = num;
				num = (short)825229312;
				if (num != 0)
				{
				}
				num = (short)1039466497;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.UIName;
			}
		}

		// Token: 0x1700507D RID: 20605
		// (get) Token: 0x0600A077 RID: 41079 RVA: 0x00959F50 File Offset: 0x00958150
		// (set) Token: 0x0600A078 RID: 41080 RVA: 0x0095A004 File Offset: 0x00958204
		internal bool DataWideWiFiNetworkEncryptedNetworkPassword_42517_HiddenStatic
		{
			get
			{
				short num = (short)1339102877;
				short num2 = num;
				num = (short)1968641693;
				switch (num2 == num)
				{
				}
				num = (short)2106392576;
				short num3 = num;
				num = (short)1356005377;
				if (num != 0)
				{
				}
				num = (short)1113128960;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.HiddenStatic;
			}
			set
			{
				short num = (short)619318963;
				short num2 = num;
				num = (short)1734807219;
				switch (num2 == num)
				{
				}
				num = (short)306905088;
				short num3 = num;
				num = (short)1493630977;
				if (num != 0)
				{
				}
				num = (short)1946025984;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.HiddenStatic = value;
			}
		}

		// Token: 0x1700507E RID: 20606
		// (get) Token: 0x0600A079 RID: 41081 RVA: 0x0095A0B8 File Offset: 0x009582B8
		// (set) Token: 0x0600A07A RID: 41082 RVA: 0x0095A170 File Offset: 0x00958370
		internal bool DataWideWiFiNetworkEncryptedNetworkPassword_42517_HiddenDynamic
		{
			get
			{
				short num = (short)547225601;
				if (num != 0)
				{
				}
				num = (short)918861459;
				short num2 = num;
				num = (short)439955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)690159616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)479002624;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.HiddenDynamic;
			}
			set
			{
				short num = (short)1769456172;
				short num2 = num;
				num = (short)1805894188;
				switch (num2 == num)
				{
				}
				num = (short)166068224;
				short num3 = num;
				num = (short)1390739457;
				if (num != 0)
				{
				}
				num = (short)1159856128;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkEncryptedNetworkPassword_42517.HiddenDynamic = value;
			}
		}

		// Token: 0x1700507F RID: 20607
		// (get) Token: 0x0600A07B RID: 41083 RVA: 0x0095A228 File Offset: 0x00958428
		public bool DataWideWiFiNetworkEncryptedNetworkPassword_42517_HasDiffs
		{
			get
			{
				short num = (short)1177249616;
				short num2 = num;
				num = (short)349595472;
				switch (num2 == num)
				{
				}
				num = (short)720633856;
				short num3 = num;
				num = (short)47644673;
				if (num != 0)
				{
				}
				num = (short)882376704;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkEncryptedNetworkPassword_42517._HasDiffs;
			}
		}

		// Token: 0x17005080 RID: 20608
		// (get) Token: 0x0600A07C RID: 41084 RVA: 0x0095A2DC File Offset: 0x009584DC
		// (set) Token: 0x0600A07D RID: 41085 RVA: 0x0095A390 File Offset: 0x00958590
		public string DataWideWiFiNetworkSSID_42519Value
		{
			get
			{
				short num = (short)1965110546;
				short num2 = num;
				num = (short)1655256338;
				switch (num2 == num)
				{
				}
				num = (short)1746862080;
				short num3 = num;
				num = (short)1955004417;
				if (num != 0)
				{
				}
				num = (short)1369833472;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSSID_42519.Value;
			}
			set
			{
				short num = (short)112824879;
				short num2 = num;
				num = (short)1027969583;
				switch (num2 == num)
				{
				}
				num = (short)808321024;
				short num3 = num;
				num = (short)1753939969;
				if (num != 0)
				{
				}
				num = (short)1579155456;
				if (num != 0)
				{
				}
				this.dataWideWiFiNetworkSSID_42519.Value = value;
			}
		}

		// Token: 0x17005081 RID: 20609
		// (get) Token: 0x0600A07E RID: 41086 RVA: 0x0095A444 File Offset: 0x00958644
		public global::AcpBusinessLayer.AcpField<string> DataWideWiFiNetworkSSID_42519
		{
			get
			{
				short num = (short)385395932;
				short num2 = num;
				num = (short)289647836;
				switch (num2 == num)
				{
				}
				num = (short)1596784640;
				short num3 = num;
				num = (short)822083585;
				if (num != 0)
				{
				}
				num = (short)1931673600;
				if (num != 0)
				{
				}
				return this.dataWideWiFiNetworkSSID_42519;
			}
		}

		// Token: 0x17005082 RID: 20610
		// (get) Token: 0x0600A07F RID: 41087 RVA: 0x0095A4F8 File Offset: 0x009586F8
		// (set) Token: 0x0600A080 RID: 41088 RVA: 0x0095A5B0 File Offset: 0x009587B0
		public string DataWideWiFiNetworkSSID_42519_UIValue
		{
			get
			{
				short num = (short)1630750922;
				short num2 = num;
				num = (short)1895909578;
				switch (num2 == num)
				{
				}
				num = (short)1347420161;
				if (num != 0)
				{
				}
				num = (short)530055168;
				if (num != 0)
				{
				}
				num = (short)1912930304;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519.Value;
			}
			set
			{
				short num = (short)499460955;
				short num2 = num;
				num = (short)691743579;
				switch (num2 == num)
				{
				}
				num = (short)1664155648;
				if (num != 0)
				{
				}
				num = (short)1834483713;
				if (num != 0)
				{
				}
				num = (short)1949433856;
				short num3 = num;
				this.dataWideWiFiNetworkSSID_42519.Value = value;
			}
		}

		// Token: 0x17005083 RID: 20611
		// (get) Token: 0x0600A081 RID: 41089 RVA: 0x0095A664 File Offset: 0x00958864
		// (set) Token: 0x0600A082 RID: 41090 RVA: 0x0095A71C File Offset: 0x0095891C
		public bool DataWideWiFiNetworkSSID_42519_Applicable
		{
			get
			{
				short num = (short)1517257608;
				short num2 = num;
				num = (short)951288712;
				switch (num2 == num)
				{
				}
				num = (short)419758081;
				if (num != 0)
				{
				}
				num = (short)1606877184;
				if (num != 0)
				{
				}
				num = (short)1342046208;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519.Applicable;
			}
			set
			{
				short num = (short)1142762652;
				short num2 = num;
				num = (short)1100295324;
				switch (num2 == num)
				{
				}
				num = (short)652869633;
				if (num != 0)
				{
				}
				num = (short)1498021888;
				if (num != 0)
				{
				}
				num = (short)81592320;
				short num3 = num;
				this.dataWideWiFiNetworkSSID_42519.Applicable = value;
			}
		}

		// Token: 0x17005084 RID: 20612
		// (get) Token: 0x0600A083 RID: 41091 RVA: 0x0095A7D0 File Offset: 0x009589D0
		// (set) Token: 0x0600A084 RID: 41092 RVA: 0x0095A880 File Offset: 0x00958A80
		public bool DataWideWiFiNetworkSSID_42519_Valid
		{
			get
			{
				short num = (short)1706426369;
				if (num != 0)
				{
				}
				num = (short)1473761087;
				short num2 = num;
				num = (short)1912590143;
				switch (num2 == num)
				{
				}
				num = (short)1965686784;
				if (num != 0)
				{
				}
				num = (short)1095237632;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519.Valid;
			}
			set
			{
				short num = (short)1931644991;
				short num2 = num;
				num = (short)1030000703;
				switch (num2 == num)
				{
				}
				num = (short)1824391169;
				if (num != 0)
				{
				}
				num = (short)3014656;
				if (num != 0)
				{
				}
				num = (short)1271857152;
				short num3 = num;
				this.dataWideWiFiNetworkSSID_42519.Valid = value;
			}
		}

		// Token: 0x17005085 RID: 20613
		// (get) Token: 0x0600A085 RID: 41093 RVA: 0x0095A938 File Offset: 0x00958B38
		// (set) Token: 0x0600A086 RID: 41094 RVA: 0x0095A9EC File Offset: 0x00958BEC
		public bool DataWideWiFiNetworkSSID_42519_Visible
		{
			get
			{
				short num = (short)149239777;
				short num2 = num;
				num = (short)2027042785;
				switch (num2 == num)
				{
				}
				num = (short)1610350592;
				if (num != 0)
				{
				}
				num = (short)298844161;
				if (num != 0)
				{
				}
				num = (short)1863450624;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519.Visible;
			}
			set
			{
				short num = (short)2012131865;
				short num2 = num;
				num = (short)480686617;
				switch (num2 == num)
				{
				}
				num = (short)934871040;
				if (num != 0)
				{
				}
				num = (short)1551826945;
				if (num != 0)
				{
				}
				num = (short)1447297024;
				short num3 = num;
				this.dataWideWiFiNetworkSSID_42519.Visible = value;
			}
		}

		// Token: 0x17005086 RID: 20614
		// (get) Token: 0x0600A087 RID: 41095 RVA: 0x0095AAA4 File Offset: 0x00958CA4
		// (set) Token: 0x0600A088 RID: 41096 RVA: 0x0095AB5C File Offset: 0x00958D5C
		public bool DataWideWiFiNetworkSSID_42519_Editable
		{
			get
			{
				short num = (short)393381798;
				short num2 = num;
				num = (short)774866854;
				switch (num2 == num)
				{
				}
				num = (short)1766064129;
				if (num != 0)
				{
				}
				num = (short)984285184;
				if (num != 0)
				{
				}
				num = (short)2140405760;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519.Editable;
			}
			set
			{
				short num = (short)1997194577;
				short num2 = num;
				num = (short)121619793;
				switch (num2 == num)
				{
				}
				num = (short)1838940161;
				if (num != 0)
				{
				}
				num = (short)499318784;
				if (num != 0)
				{
				}
				num = (short)975765504;
				short num3 = num;
				this.dataWideWiFiNetworkSSID_42519.Editable = value;
			}
		}

		// Token: 0x17005087 RID: 20615
		// (get) Token: 0x0600A089 RID: 41097 RVA: 0x0095AC14 File Offset: 0x00958E14
		internal string DataWideWiFiNetworkSSID_42519_UILabel
		{
			get
			{
				short num = (short)1438724516;
				short num2 = num;
				num = (short)961753508;
				switch (num2 == num)
				{
				}
				num = (short)1497563137;
				if (num != 0)
				{
				}
				num = (short)1664548864;
				if (num != 0)
				{
				}
				num = (short)487391232;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519.UIName;
			}
		}

		// Token: 0x17005088 RID: 20616
		// (get) Token: 0x0600A08A RID: 41098 RVA: 0x0095ACCC File Offset: 0x00958ECC
		// (set) Token: 0x0600A08B RID: 41099 RVA: 0x0095AD80 File Offset: 0x00958F80
		internal bool DataWideWiFiNetworkSSID_42519_HiddenStatic
		{
			get
			{
				short num = (short)1173754604;
				short num2 = num;
				num = (short)1009128172;
				switch (num2 == num)
				{
				}
				num = (short)1660616705;
				if (num != 0)
				{
				}
				num = (short)821493760;
				if (num != 0)
				{
				}
				num = (short)1239678976;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519.HiddenStatic;
			}
			set
			{
				short num = (short)2001516874;
				short num2 = num;
				num = (short)1639692618;
				switch (num2 == num)
				{
				}
				num = (short)183238656;
				if (num != 0)
				{
				}
				num = (short)1424293889;
				if (num != 0)
				{
				}
				num = (short)1101266944;
				short num3 = num;
				this.dataWideWiFiNetworkSSID_42519.HiddenStatic = value;
			}
		}

		// Token: 0x17005089 RID: 20617
		// (get) Token: 0x0600A08C RID: 41100 RVA: 0x0095AE34 File Offset: 0x00959034
		// (set) Token: 0x0600A08D RID: 41101 RVA: 0x0095AEE8 File Offset: 0x009590E8
		internal bool DataWideWiFiNetworkSSID_42519_HiddenDynamic
		{
			get
			{
				short num = (short)548529360;
				short num2 = num;
				num = (short)984409296;
				switch (num2 == num)
				{
				}
				num = (short)1594163201;
				if (num != 0)
				{
				}
				num = (short)80871424;
				if (num != 0)
				{
				}
				num = (short)183631872;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519.HiddenDynamic;
			}
			set
			{
				short num = (short)2115422395;
				short num2 = num;
				num = (short)999147707;
				switch (num2 == num)
				{
				}
				num = (short)1913651201;
				if (num != 0)
				{
				}
				num = (short)452526080;
				if (num != 0)
				{
				}
				num = (short)1138753536;
				short num3 = num;
				this.dataWideWiFiNetworkSSID_42519.HiddenDynamic = value;
			}
		}

		// Token: 0x1700508A RID: 20618
		// (get) Token: 0x0600A08E RID: 41102 RVA: 0x0095AF9C File Offset: 0x0095919C
		public bool DataWideWiFiNetworkSSID_42519_HasDiffs
		{
			get
			{
				short num = (short)1220851409;
				short num2 = num;
				num = (short)1644279505;
				switch (num2 == num)
				{
				}
				num = (short)557121536;
				if (num != 0)
				{
				}
				num = (short)1862664193;
				if (num != 0)
				{
				}
				num = (short)1771175936;
				short num3 = num;
				return this.dataWideWiFiNetworkSSID_42519._HasDiffs;
			}
		}

		// Token: 0x1700508B RID: 20619
		// (get) Token: 0x0600A08F RID: 41103 RVA: 0x0095B050 File Offset: 0x00959250
		// (set) Token: 0x0600A090 RID: 41104 RVA: 0x0095B108 File Offset: 0x00959308
		public bool DataWideWIFINetworkHiddenValue
		{
			get
			{
				short num = (short)908942320;
				short num2 = num;
				num = (short)476077040;
				switch (num2 == num)
				{
				}
				num = (short)730988544;
				if (num != 0)
				{
				}
				num = (short)152895489;
				if (num != 0)
				{
				}
				num = (short)953352192;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.Value;
			}
			set
			{
				short num = (short)210330900;
				short num2 = num;
				num = (short)1377854740;
				switch (num2 == num)
				{
				}
				num = (short)770441217;
				if (num != 0)
				{
				}
				num = (short)428015616;
				if (num != 0)
				{
				}
				num = (short)1241972736;
				short num3 = num;
				this.dataWideWIFINetworkHidden.Value = value;
			}
		}

		// Token: 0x1700508C RID: 20620
		// (get) Token: 0x0600A091 RID: 41105 RVA: 0x0095B1C0 File Offset: 0x009593C0
		public global::AcpBusinessLayer.AcpField<bool> DataWideWIFINetworkHidden
		{
			get
			{
				short num = (short)1915420673;
				if (num != 0)
				{
				}
				num = (short)1811115885;
				short num2 = num;
				num = (short)923299693;
				switch (num2 == num)
				{
				}
				num = (short)1655373824;
				if (num != 0)
				{
				}
				num = (short)84541440;
				short num3 = num;
				return this.dataWideWIFINetworkHidden;
			}
		}

		// Token: 0x1700508D RID: 20621
		// (get) Token: 0x0600A092 RID: 41106 RVA: 0x0095B270 File Offset: 0x00959470
		// (set) Token: 0x0600A093 RID: 41107 RVA: 0x0095B324 File Offset: 0x00959524
		public bool DataWideWIFINetworkHidden_UIValue
		{
			get
			{
				short num = (short)1007980934;
				short num2 = num;
				num = (short)1232572806;
				switch (num2 == num)
				{
				}
				num = (short)1951662080;
				if (num != 0)
				{
				}
				num = (short)1799946241;
				if (num != 0)
				{
				}
				num = (short)1364721664;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.Value;
			}
			set
			{
				short num = (short)2818049;
				if (num != 0)
				{
				}
				num = (short)1888675560;
				short num2 = num;
				num = (short)68806376;
				switch (num2 == num)
				{
				}
				num = (short)1910571008;
				if (num != 0)
				{
				}
				num = (short)402456576;
				short num3 = num;
				this.dataWideWIFINetworkHidden.Value = value;
			}
		}

		// Token: 0x1700508E RID: 20622
		// (get) Token: 0x0600A094 RID: 41108 RVA: 0x0095B3D8 File Offset: 0x009595D8
		// (set) Token: 0x0600A095 RID: 41109 RVA: 0x0095B48C File Offset: 0x0095968C
		public bool DataWideWIFINetworkHidden_Applicable
		{
			get
			{
				short num = (short)432153263;
				short num2 = num;
				num = (short)1906188975;
				switch (num2 == num)
				{
				}
				num = (short)1853554688;
				if (num != 0)
				{
				}
				num = (short)845676545;
				if (num != 0)
				{
				}
				num = (short)1885863936;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.Applicable;
			}
			set
			{
				short num = (short)37289985;
				if (num != 0)
				{
				}
				num = (short)1997741133;
				short num2 = num;
				num = (short)116595789;
				switch (num2 == num)
				{
				}
				num = (short)508690432;
				if (num != 0)
				{
				}
				num = (short)1647116288;
				short num3 = num;
				this.dataWideWIFINetworkHidden.Applicable = value;
			}
		}

		// Token: 0x1700508F RID: 20623
		// (get) Token: 0x0600A096 RID: 41110 RVA: 0x0095B544 File Offset: 0x00959744
		// (set) Token: 0x0600A097 RID: 41111 RVA: 0x0095B5F8 File Offset: 0x009597F8
		public bool DataWideWIFINetworkHidden_Valid
		{
			get
			{
				short num = (short)1877033482;
				short num2 = num;
				num = (short)2046247434;
				switch (num2 == num)
				{
				}
				num = (short)1353711616;
				if (num != 0)
				{
				}
				num = (short)300220417;
				if (num != 0)
				{
				}
				num = (short)2092367872;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.Valid;
			}
			set
			{
				short num = (short)442354849;
				short num2 = num;
				num = (short)525913249;
				switch (num2 == num)
				{
				}
				num = (short)402259969;
				if (num != 0)
				{
				}
				num = (short)1488846848;
				if (num != 0)
				{
				}
				num = (short)824115200;
				short num3 = num;
				this.dataWideWIFINetworkHidden.Valid = value;
			}
		}

		// Token: 0x17005090 RID: 20624
		// (get) Token: 0x0600A098 RID: 41112 RVA: 0x0095B6AC File Offset: 0x009598AC
		// (set) Token: 0x0600A099 RID: 41113 RVA: 0x0095B764 File Offset: 0x00959964
		public bool DataWideWIFINetworkHidden_Visible
		{
			get
			{
				short num = (short)145624803;
				short num2 = num;
				num = (short)521670371;
				switch (num2 == num)
				{
				}
				num = (short)568524801;
				if (num != 0)
				{
				}
				num = (short)1638989824;
				if (num != 0)
				{
				}
				num = (short)527958016;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.Visible;
			}
			set
			{
				short num = (short)82107228;
				short num2 = num;
				num = (short)152427356;
				switch (num2 == num)
				{
				}
				num = (short)1924530176;
				if (num != 0)
				{
				}
				num = (short)500957185;
				if (num != 0)
				{
				}
				num = (short)1141637120;
				short num3 = num;
				this.dataWideWIFINetworkHidden.Visible = value;
			}
		}

		// Token: 0x17005091 RID: 20625
		// (get) Token: 0x0600A09A RID: 41114 RVA: 0x0095B818 File Offset: 0x00959A18
		// (set) Token: 0x0600A09B RID: 41115 RVA: 0x0095B8D0 File Offset: 0x00959AD0
		public bool DataWideWIFINetworkHidden_Editable
		{
			get
			{
				short num = (short)915583375;
				short num2 = num;
				num = (short)2114826639;
				switch (num2 == num)
				{
				}
				num = (short)796983296;
				if (num != 0)
				{
				}
				num = (short)1351090177;
				if (num != 0)
				{
				}
				num = (short)1357316096;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.Editable;
			}
			set
			{
				short num = (short)975590304;
				short num2 = num;
				num = (short)1415926688;
				switch (num2 == num)
				{
				}
				num = (short)1163067392;
				if (num != 0)
				{
				}
				num = (short)1842348033;
				if (num != 0)
				{
				}
				num = (short)1127677952;
				short num3 = num;
				this.dataWideWIFINetworkHidden.Editable = value;
			}
		}

		// Token: 0x17005092 RID: 20626
		// (get) Token: 0x0600A09C RID: 41116 RVA: 0x0095B984 File Offset: 0x00959B84
		internal string DataWideWIFINetworkHidden_UILabel
		{
			get
			{
				short num = (short)1646799569;
				short num2 = num;
				num = (short)1241197265;
				switch (num2 == num)
				{
				}
				num = (short)622919680;
				if (num != 0)
				{
				}
				num = (short)1562509313;
				if (num != 0)
				{
				}
				num = (short)112656384;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.UIName;
			}
		}

		// Token: 0x17005093 RID: 20627
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x0095BA3C File Offset: 0x00959C3C
		// (set) Token: 0x0600A09E RID: 41118 RVA: 0x0095BAF0 File Offset: 0x00959CF0
		internal bool DataWideWIFINetworkHidden_HiddenStatic
		{
			get
			{
				short num = (short)197993056;
				short num2 = num;
				num = (short)2127503968;
				switch (num2 == num)
				{
				}
				num = (short)1361772545;
				if (num != 0)
				{
				}
				num = (short)96665600;
				if (num != 0)
				{
				}
				num = (short)1629945856;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.HiddenStatic;
			}
			set
			{
				short num = (short)2004546095;
				short num2 = num;
				num = (short)1308750383;
				switch (num2 == num)
				{
				}
				num = (short)130809857;
				if (num != 0)
				{
				}
				num = (short)1444872192;
				if (num != 0)
				{
				}
				num = (short)1654390784;
				short num3 = num;
				this.dataWideWIFINetworkHidden.HiddenStatic = value;
			}
		}

		// Token: 0x17005094 RID: 20628
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x0095BBA4 File Offset: 0x00959DA4
		// (set) Token: 0x0600A0A0 RID: 41120 RVA: 0x0095BC58 File Offset: 0x00959E58
		internal bool DataWideWIFINetworkHidden_HiddenDynamic
		{
			get
			{
				short num = (short)496270558;
				short num2 = num;
				num = (short)884899038;
				switch (num2 == num)
				{
				}
				num = (short)3342337;
				if (num != 0)
				{
				}
				num = (short)1553989632;
				if (num != 0)
				{
				}
				num = (short)654835712;
				short num3 = num;
				return this.dataWideWIFINetworkHidden.HiddenDynamic;
			}
			set
			{
				short num = (short)278438389;
				short num2 = num;
				num = (short)1803461109;
				switch (num2 == num)
				{
				}
				num = (short)617349120;
				if (num != 0)
				{
				}
				num = (short)868876289;
				if (num != 0)
				{
				}
				num = (short)722927616;
				short num3 = num;
				this.dataWideWIFINetworkHidden.HiddenDynamic = value;
			}
		}

		// Token: 0x17005095 RID: 20629
		// (get) Token: 0x0600A0A1 RID: 41121 RVA: 0x0095BD10 File Offset: 0x00959F10
		public bool DataWideWIFINetworkHidden_HasDiffs
		{
			get
			{
				short num = (short)1232934448;
				short num2 = num;
				num = (short)1068504624;
				switch (num2 == num)
				{
				}
				num = (short)1577254912;
				if (num != 0)
				{
				}
				num = (short)1640235009;
				if (num != 0)
				{
				}
				num = (short)1602748416;
				short num3 = num;
				return this.dataWideWIFINetworkHidden._HasDiffs;
			}
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x0095BDC8 File Offset: 0x00959FC8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)273678337;
			if (num != 0)
			{
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1759903748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)614268928;
							short num3 = num;
							num = (short)2060320768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)809304065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)642262483;
						short num4 = num;
						num = (short)985736659;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4E;
						default:
							num = (short)979173376;
							if (num != 0)
							{
							}
							if (base.ParentRecset != null)
							{
								num = (short)1378615298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						break;
					}
					case 4:
						return result;
					}
					goto IL_4C;
				}
				return result;
			}
			IL_4C:
			result = null;
			IL_4E:
			num = (short)2040070147;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x04004DFC RID: 19964
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideWiFiNetworkPriority_42512;

		// Token: 0x04004DFD RID: 19965
		private global::AcpBusinessLayer.AcpListField dataWideWiFiNetworkSecurityType_42516;

		// Token: 0x04004DFE RID: 19966
		private global::AcpBusinessLayer.AcpFieldX<string, string> dataWideWiFiNetworkEncryptedNetworkPassword_42517;

		// Token: 0x04004DFF RID: 19967
		private global::AcpBusinessLayer.AcpField<string> dataWideWiFiNetworkSSID_42519;

		// Token: 0x04004E00 RID: 19968
		private global::AcpBusinessLayer.AcpField<bool> dataWideWIFINetworkHidden;
	}
}
