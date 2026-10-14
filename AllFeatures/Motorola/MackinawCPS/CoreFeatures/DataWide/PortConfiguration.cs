using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004EA RID: 1258
	[global::System.Serializable]
	public class PortConfiguration : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A8E1 RID: 43233 RVA: 0x009CD548 File Offset: 0x009CB748
		public PortConfiguration(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x009CD564 File Offset: 0x009CB764
		protected PortConfiguration(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x009CD57C File Offset: 0x009CB77C
		public override void Init()
		{
			int a_ = 3;
			short num = (short)845263951;
			short num2 = num;
			num = (short)1197323343;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1461649408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1265500161;
			if (num != 0)
			{
			}
			num = (short)413270016;
			if (num != 0)
			{
			}
			this.dataConfDataWidePortConAuthenticationUDPPort_A37608 = new global::AcpBusinessLayer.AcpSimpleRangeField(49165, this, global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ迋ꇍ뻏듑郓럕곗믙诛럝蓟蟡듣觥髧黩꿫臭黯돱至苵郷鿹鋻諽槿愁攃爅愇攉戋嬍吏䈑䐓礕樗渙䌛弝ጟᔡሣᘥဧ", a_), global::CommonResources.AcgResources.ID_AUTHENTICATIONUDPPORT, 49152, 65535, null, null, 0, 1);
			this.dataConfDataWidePortConAuthenticationUDPPort_A37608.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataConfDataWidePortConAuthenticationUDPPort_A37608.DataTransferOrder = 24;
			this.dataConfDataWidePortConAuthenticationUDPPort_A37608.ShowHexValue = false;
			this.dataWideP25LocationReportingUDPPort_42413 = new global::AcpBusinessLayer.AcpSimpleRangeField(49198, this, global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑蓓雙돛뷝臟雡跣觥蛧룩觫黭鿯胱胳鿵雷鷹ꧻ뫽僿刁欃琅簇唉㠋㰍␏⌑✓", a_), global::CommonResources.AcgResources.ID_P25LOCATIONREPORTINGUDPPORT, 1, 65535, null, null, 0, 1);
			this.dataWideP25LocationReportingUDPPort_42413.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWideP25LocationReportingUDPPort_42413.DataTransferOrder = 70;
			this.dataWideP25LocationReportingUDPPort_42413.ShowHexValue = false;
			this.dataWideWIFIOTAPTCPPort_42627 = new global::AcpBusinessLayer.AcpSimpleRangeField(52010, this, global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑菓鿕黗鏙鏛諝ꇟ닡냣ꗥ룧뫩菫鳭蓯귱샳쓵컷죹쯻", a_), global::CommonResources.AcgResources.ID_WIRELESSPROGRAMMINGTCPPORT, 49152, 52151, null, null, 0, 1);
			this.dataWideWIFIOTAPTCPPort_42627.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideWIFIOTAPTCPPort_42627.DataTransferOrder = 36;
			this.dataWideWIFIOTAPTCPPort_42627.ShowHexValue = false;
			this.sensorMeasurementReportingUDPPort_A43022 = new global::AcpBusinessLayer.AcpSimpleRangeField(49625, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꛇ막ꏋ볍鷏럑뗓ꗕ귗꣙맛돝藟賡郣듥跧髩菫鳭蓯鯱髳釵귷뻹곻껽濿瀁瀃夅䤇㸉㼋㸍∏‑", a_), global::CommonResources.AcgResources.ID_SENSORMEASUREMENTREPORTINGUDPPORT, 49625, 65535, null, null, 0, 1);
			this.sensorMeasurementReportingUDPPort_A43022.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.sensorMeasurementReportingUDPPort_A43022.DataTransferOrder = 79;
			this.sensorMeasurementReportingUDPPort_A43022.ShowHexValue = false;
			this.dataWideKVLKeyloadingUDPPort_43205 = new global::AcpBusinessLayer.AcpSimpleRangeField(49644, this, global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑鿓胕铗釙맛꟝賟跡藣若臧蓩诫믭듯ꋱꓳ駵諷軹ꏻ쫽㏿、㐃㌅", a_), global::CommonResources.AcgResources.ID_KVLKEYLOADINGUDPPORT, 49152, 65535, null, null, 0, 1);
			this.dataWideKVLKeyloadingUDPPort_43205.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWideKVLKeyloadingUDPPort_43205.DataTransferOrder = 80;
			this.dataWideKVLKeyloadingUDPPort_43205.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铃꧅뫇뻉跍뿏병닓뿕뿗꿙껛뿝铟诡诣裥", a_);
			base.Id = 10632;
			base.UIName = global::CommonResources.AcgResources.ID_PORTCONFIGURATION;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x009CD810 File Offset: 0x009CBA10
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)702873603;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)385724741;
					short num3 = num;
					num = (short)1716826437;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)370016256;
						if (num != 0)
						{
						}
						this.dataWideP25LocationReportingUDPPort_42413 = new global::AcpBusinessLayer.AcpSimpleRangeField(49198, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓蛕郛뇝菟菡郣迥蟧蓩뻫语胯鷱蛳苵釷铹鯻꯽䓿刁吃椅稇縉匋㨍∏☑┓┕", a_), global::CommonResources.AcgResources.ID_P25LOCATIONREPORTINGUDPPORT, null, null, 0, 1);
						this.dataWideP25LocationReportingUDPPort_42413.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.dataWideP25LocationReportingUDPPort_42413.DataTransferOrder = 70;
						this.dataWideP25LocationReportingUDPPort_42413.ShowHexValue = false;
						num = (short)597491724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闅귇꓉뿋ꇍꋏ鿑뇓럕ꯗ꿙껛믝跟蟡諣鋥뫧迩鳫臭苯蛱鷳飵鿷꿹룻껽僿洁瘃爅圇䬉㠋㴍‏‑☓", a_)))
					{
						num = (short)562561039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A8;
				case 2:
					if (producerFields != null)
					{
						num = (short)1249902600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FF;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓鷕軗雙韛믝駟軡诣蟥賧菩苫觭ꗯ뛱ꓳ꛵韷裹裻ꇽ㓿㄁㘃㘅㴇", a_)))
					{
						num = (short)1678770193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FF;
				case 5:
					goto IL_1A8;
				case 6:
					this.dataConfDataWidePortConAuthenticationUDPPort_A37608 = new global::AcpBusinessLayer.AcpSimpleRangeField(49165, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓鋕맗껙뷛觝觟蛡臣뛥蟧飩飫귭鿯鳱뗳菵賷鋹駻都瓿欁會朅簇按挋怍䔏嘑䐓䘕眗栙栛䄝感ᄡጣဥᠧሩ", a_), global::CommonResources.AcgResources.ID_AUTHENTICATIONUDPPORT, null, null, 0, 1);
					this.dataConfDataWidePortConAuthenticationUDPPort_A37608.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataConfDataWidePortConAuthenticationUDPPort_A37608.DataTransferOrder = 24;
					this.dataConfDataWidePortConAuthenticationUDPPort_A37608.ShowHexValue = false;
					num = (short)663879687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_466;
				case 8:
					num = (short)706347021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_2FE;
				case 10:
				{
					this.dataWideWIFIOTAPTCPPort_42627 = new global::AcpBusinessLayer.AcpSimpleRangeField(52010, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓臕釗鳙闛針듟ꏡ듣닥ꯧ뫩볫臭苯蛱꯳싵쫷쳹컻짽", a_), global::CommonResources.AcgResources.ID_WIRELESSPROGRAMMINGTCPPORT, null, null, 0, 1);
					this.dataWideWIFIOTAPTCPPort_42627.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideWIFIOTAPTCPPort_42627.DataTransferOrder = 36;
					this.dataWideWIFIOTAPTCPPort_42627.ShowHexValue = false;
					num = (short)1658978304;
					short num4 = num;
					num = (short)232521746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					num = (short)291110914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_EA;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓鋕맗껙뷛觝觟蛡臣뛥蟧飩飫귭鿯鳱뗳菵賷鋹駻都瓿欁會朅簇按挋怍䔏嘑䐓䘕眗栙栛䄝感ᄡጣဥᠧሩ", a_)))
					{
						num = (short)401801222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_466;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓蛕郛뇝菟菡郣迥蟧蓩뻫语胯鷱蛳苵釷铹鯻꯽䓿刁吃椅稇縉匋㨍∏☑┓┕", a_)))
					{
						num = (short)52756480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				case 15:
					this.sensorMeasurementReportingUDPPort_A43022 = new global::AcpBusinessLayer.AcpSimpleRangeField(49625, this, global::AllFeatures.CodeplugGuid.b("闅귇꓉뿋ꇍꋏ鿑뇓럕ꯗ꿙껛믝跟蟡諣鋥뫧迩鳫臭苯蛱鷳飵鿷꿹룻껽僿洁瘃爅圇䬉㠋㴍‏‑☓", a_), global::CommonResources.AcgResources.ID_SENSORMEASUREMENTREPORTINGUDPPORT, null, null, 0, 1);
					this.sensorMeasurementReportingUDPPort_A43022.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.sensorMeasurementReportingUDPPort_A43022.DataTransferOrder = 79;
					this.sensorMeasurementReportingUDPPort_A43022.ShowHexValue = false;
					num = (short)1057357829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓臕釗鳙闛針듟ꏡ듣닥ꯧ뫩볫臭苯蛱꯳싵쫷쳹컻짽", a_)))
					{
						num = (short)1190789121;
						if (num != 0)
						{
						}
						num = (short)1148518410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
				case 17:
					this.dataWideKVLKeyloadingUDPPort_43205 = new global::AcpBusinessLayer.AcpSimpleRangeField(49644, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓鷕軗雙韛믝駟軡诣蟥賧菩苫觭ꗯ뛱ꓳ꛵韷裹裻ꇽ㓿㄁㘃㘅㴇", a_), global::CommonResources.AcgResources.ID_KVLKEYLOADINGUDPPORT, null, null, 0, 1);
					this.dataWideKVLKeyloadingUDPPort_43205.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataWideKVLKeyloadingUDPPort_43205.DataTransferOrder = 80;
					this.dataWideKVLKeyloadingUDPPort_43205.ShowHexValue = false;
					num = (short)212860937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_9E;
				}
				IL_7B:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1924530187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9E:
				num = (short)1120010241;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EA:
				num = (short)532938768;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A8:
				num = (short)1724907524;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_466:
				num = (short)744226830;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2FE:
			IL_4FF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雅Ꟈ룉룋鏏뷑뫓냕뇗뷙꧛곝臟雡跣觥蛧", a_);
			base.Id = 10632;
			base.UIName = global::CommonResources.AcgResources.ID_PORTCONFIGURATION;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600A8E5 RID: 43237 RVA: 0x009CDD50 File Offset: 0x009CBF50
		public override void PopulateReferences()
		{
			short num = (short)1011550113;
			short num2 = num;
			num = (short)1547569057;
			switch (num2 == num)
			{
			default:
			{
				num = (short)558235648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1021313024;
			if (num != 0)
			{
			}
			num = (short)74645505;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x009CDDFC File Offset: 0x009CBFFC
		public override void DropReferences()
		{
			short num = (short)1244422288;
			short num2 = num;
			num = (short)2110414992;
			switch (num2 == num)
			{
			default:
			{
				num = (short)398393344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)753598465;
			if (num != 0)
			{
			}
			num = (short)1206583296;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x009CDEA4 File Offset: 0x009CC0A4
		public override void SetConstraints()
		{
			short num = (short)41033443;
			short num2 = num;
			num = (short)693640931;
			switch (num2 == num)
			{
			default:
			{
				num = (short)375848960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1493630977;
			if (num != 0)
			{
			}
			num = (short)190251008;
			if (num != 0)
			{
			}
			this.dataWideP25LocationReportingUDPPort_42413.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConP25LocReportAppAndEn);
			this.dataWideP25LocationReportingUDPPort_42413.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConP25LocReportValueUnique);
			this.dataWideWIFIOTAPTCPPort_42627.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWifiPortValueUnique);
			this.sensorMeasurementReportingUDPPort_A43022.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConSensorMeasurementRepApp);
			this.sensorMeasurementReportingUDPPort_A43022.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConSensorPortValueUnique);
			this.dataWideKVLKeyloadingUDPPort_43205.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConKVLKeyloadingSourceIsKVL);
			this.dataWideKVLKeyloadingUDPPort_43205.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConKVLKeyloadingUDPPortValueUnique);
		}

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x009CDFF0 File Offset: 0x009CC1F0
		public override void SetupDependencies()
		{
			short num = (short)299913056;
			short num2 = num;
			num = (short)56512352;
			switch (num2 == num)
			{
			default:
			{
				num = (short)529137664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1539506177;
			if (num != 0)
			{
			}
			num = (short)1073217536;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.dataWideP25LocationReportingUDPPort_42413);
			this.RefRadioWide.Location.RadWideLocP25LocationReporting_42412.AddDependentObject(this.dataWideP25LocationReportingUDPPort_42413);
			this.dataConfDataWidePortConAuthenticationUDPPort_A37608.AddDependentObject(this.dataWideP25LocationReportingUDPPort_42413);
			this.dataConfDataWidePortConAuthenticationUDPPort_A37608.AddDependentObject(this.dataWideWIFIOTAPTCPPort_42627);
			dataWide.General.SensorMeasurementReporting_A43021.AddDependentObject(this.sensorMeasurementReportingUDPPort_A43022);
			this.dataConfDataWidePortConAuthenticationUDPPort_A37608.AddDependentObject(this.sensorMeasurementReportingUDPPort_A43022);
			this.dataWideWIFIOTAPTCPPort_42627.AddDependentObject(this.sensorMeasurementReportingUDPPort_A43022);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataWideKVLKeyloadingUDPPort_43205);
			this.RefSecureWide.General.SecureWideKeyloadingSource_43204.AddDependentObject(this.dataWideKVLKeyloadingUDPPort_43205);
			this.dataConfDataWidePortConAuthenticationUDPPort_A37608.AddDependentObject(this.dataWideKVLKeyloadingUDPPort_43205);
			this.dataWideWIFIOTAPTCPPort_42627.AddDependentObject(this.dataWideKVLKeyloadingUDPPort_43205);
		}

		// Token: 0x170054CF RID: 21711
		// (get) Token: 0x0600A8E9 RID: 43241 RVA: 0x009CE198 File Offset: 0x009CC398
		public bool HasDiffs
		{
			get
			{
				short num = (short)614741010;
				short num2 = num;
				num = (short)1316697106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1894776832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756430337;
				if (num != 0)
				{
				}
				num = (short)300875776;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170054D0 RID: 21712
		// (get) Token: 0x0600A8EA RID: 43242 RVA: 0x009CE24C File Offset: 0x009CC44C
		// (set) Token: 0x0600A8EB RID: 43243 RVA: 0x009CE300 File Offset: 0x009CC500
		public int DataConfDataWidePortConAuthenticationUDPPort_A37608Value
		{
			get
			{
				short num = (short)1262450786;
				short num2 = num;
				num = (short)786528354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2035941376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)31522816;
				if (num != 0)
				{
				}
				num = (short)1632698369;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Value;
			}
			set
			{
				short num = (short)1624645489;
				short num2 = num;
				num = (short)1076240241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1798438912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1015152640;
				if (num != 0)
				{
				}
				num = (short)1404502017;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Value = value;
			}
		}

		// Token: 0x170054D1 RID: 21713
		// (get) Token: 0x0600A8EC RID: 43244 RVA: 0x009CE3B4 File Offset: 0x009CC5B4
		public global::AcpBusinessLayer.AcpSimpleRangeField DataConfDataWidePortConAuthenticationUDPPort_A37608
		{
			get
			{
				short num = (short)2104037246;
				short num2 = num;
				num = (short)193597310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38600704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)711983104;
				if (num != 0)
				{
				}
				num = (short)1894187009;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608;
			}
		}

		// Token: 0x170054D2 RID: 21714
		// (get) Token: 0x0600A8ED RID: 43245 RVA: 0x009CE464 File Offset: 0x009CC664
		// (set) Token: 0x0600A8EE RID: 43246 RVA: 0x009CE518 File Offset: 0x009CC718
		public string DataConfDataWidePortConAuthenticationUDPPort_A37608_UIValue
		{
			get
			{
				short num = (short)1715059065;
				short num2 = num;
				num = (short)2069019001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1143275520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)233635840;
				if (num != 0)
				{
				}
				num = (short)1083244545;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.UIValue;
			}
			set
			{
				short num = (short)242822375;
				short num2 = num;
				num = (short)707341543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)63373312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493696513;
				if (num != 0)
				{
				}
				num = (short)1622016000;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.UIValue = value;
			}
		}

		// Token: 0x170054D3 RID: 21715
		// (get) Token: 0x0600A8EF RID: 43247 RVA: 0x009CE5CC File Offset: 0x009CC7CC
		// (set) Token: 0x0600A8F0 RID: 43248 RVA: 0x009CE680 File Offset: 0x009CC880
		internal int DataConfDataWidePortConAuthenticationUDPPort_A37608Min
		{
			get
			{
				short num = (short)377588896;
				short num2 = num;
				num = (short)277908640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)642580480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1593704449;
				if (num != 0)
				{
				}
				num = (short)1086980096;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Min;
			}
			set
			{
				short num = (short)128493906;
				short num2 = num;
				num = (short)252946770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1271398400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1494089729;
				if (num != 0)
				{
				}
				num = (short)263913472;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Min = value;
			}
		}

		// Token: 0x170054D4 RID: 21716
		// (get) Token: 0x0600A8F1 RID: 43249 RVA: 0x009CE734 File Offset: 0x009CC934
		// (set) Token: 0x0600A8F2 RID: 43250 RVA: 0x009CE7E8 File Offset: 0x009CC9E8
		internal int DataConfDataWidePortConAuthenticationUDPPort_A37608Max
		{
			get
			{
				short num = (short)830255317;
				short num2 = num;
				num = (short)1803727061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)986513408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1661992961;
				if (num != 0)
				{
				}
				num = (short)1361772544;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Max;
			}
			set
			{
				short num = (short)2089226981;
				short num2 = num;
				num = (short)820515557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1720057856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1982332929;
				if (num != 0)
				{
				}
				num = (short)655360;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Max = value;
			}
		}

		// Token: 0x170054D5 RID: 21717
		// (get) Token: 0x0600A8F3 RID: 43251 RVA: 0x009CE8A0 File Offset: 0x009CCAA0
		// (set) Token: 0x0600A8F4 RID: 43252 RVA: 0x009CE958 File Offset: 0x009CCB58
		internal int DataConfDataWidePortConAuthenticationUDPPort_A37608Step
		{
			get
			{
				short num = (short)233945365;
				short num2 = num;
				num = (short)403355925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)967376896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1094320129;
				if (num != 0)
				{
				}
				num = (short)1771700224;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.StepSize;
			}
			set
			{
				short num = (short)1018363905;
				if (num != 0)
				{
				}
				num = (short)521994240;
				short num2 = num;
				num = (short)2103578486;
				short num3 = num;
				num = (short)1892618102;
				switch (num3 == num)
				{
				}
				num = (short)1161691136;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.StepSize = value;
			}
		}

		// Token: 0x170054D6 RID: 21718
		// (get) Token: 0x0600A8F5 RID: 43253 RVA: 0x009CEA0C File Offset: 0x009CCC0C
		// (set) Token: 0x0600A8F6 RID: 43254 RVA: 0x009CEAC0 File Offset: 0x009CCCC0
		public bool DataConfDataWidePortConAuthenticationUDPPort_A37608_Applicable
		{
			get
			{
				short num = (short)765329409;
				if (num != 0)
				{
				}
				num = (short)1932853248;
				short num2 = num;
				num = (short)1103041897;
				short num3 = num;
				num = (short)1633752425;
				switch (num3 == num)
				{
				}
				num = (short)2017394688;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Applicable;
			}
			set
			{
				short num = (short)39418748;
				short num2 = num;
				num = (short)1873312636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1358430208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063400961;
				if (num != 0)
				{
				}
				num = (short)993722368;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Applicable = value;
			}
		}

		// Token: 0x170054D7 RID: 21719
		// (get) Token: 0x0600A8F7 RID: 43255 RVA: 0x009CEB78 File Offset: 0x009CCD78
		// (set) Token: 0x0600A8F8 RID: 43256 RVA: 0x009CEC30 File Offset: 0x009CCE30
		public bool DataConfDataWidePortConAuthenticationUDPPort_A37608_Valid
		{
			get
			{
				short num = (short)508406851;
				short num2 = num;
				num = (short)1040624707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1363410944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1668087808;
				if (num != 0)
				{
				}
				num = (short)890241025;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Valid;
			}
			set
			{
				short num = (short)689831937;
				if (num != 0)
				{
				}
				num = (short)1574371328;
				short num2 = num;
				num = (short)226569923;
				short num3 = num;
				num = (short)1666002627;
				switch (num3 == num)
				{
				}
				num = (short)504299520;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Valid = value;
			}
		}

		// Token: 0x170054D8 RID: 21720
		// (get) Token: 0x0600A8F9 RID: 43257 RVA: 0x009CECE4 File Offset: 0x009CCEE4
		// (set) Token: 0x0600A8FA RID: 43258 RVA: 0x009CED98 File Offset: 0x009CCF98
		public bool DataConfDataWidePortConAuthenticationUDPPort_A37608_Visible
		{
			get
			{
				short num = (short)1463591799;
				short num2 = num;
				num = (short)1999807351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1175912448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)460718081;
				if (num != 0)
				{
				}
				num = (short)84606976;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Visible;
			}
			set
			{
				short num = (short)2069228380;
				short num2 = num;
				num = (short)645458780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1944584192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1703608320;
				if (num != 0)
				{
				}
				num = (short)420610049;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Visible = value;
			}
		}

		// Token: 0x170054D9 RID: 21721
		// (get) Token: 0x0600A8FB RID: 43259 RVA: 0x009CEE4C File Offset: 0x009CD04C
		// (set) Token: 0x0600A8FC RID: 43260 RVA: 0x009CEF00 File Offset: 0x009CD100
		public bool DataConfDataWidePortConAuthenticationUDPPort_A37608_Editable
		{
			get
			{
				short num = (short)1615863534;
				short num2 = num;
				num = (short)1790844654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1415118848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1499463681;
				if (num != 0)
				{
				}
				num = (short)1128595456;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Editable;
			}
			set
			{
				short num = (short)1932296601;
				short num2 = num;
				num = (short)104563097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)453312512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)464715776;
				if (num != 0)
				{
				}
				num = (short)700579841;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.Editable = value;
			}
		}

		// Token: 0x170054DA RID: 21722
		// (get) Token: 0x0600A8FD RID: 43261 RVA: 0x009CEFB4 File Offset: 0x009CD1B4
		internal string DataConfDataWidePortConAuthenticationUDPPort_A37608_UILabel
		{
			get
			{
				short num = (short)508100609;
				if (num != 0)
				{
				}
				num = (short)1381105664;
				short num2 = num;
				num = (short)1713351005;
				short num3 = num;
				num = (short)1085450589;
				switch (num3 == num)
				{
				}
				num = (short)1595539456;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.UIName;
			}
		}

		// Token: 0x170054DB RID: 21723
		// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x009CF068 File Offset: 0x009CD268
		// (set) Token: 0x0600A8FF RID: 43263 RVA: 0x009CF11C File Offset: 0x009CD31C
		internal bool DataConfDataWidePortConAuthenticationUDPPort_A37608_HiddenStatic
		{
			get
			{
				short num = (short)1262196916;
				short num2 = num;
				num = (short)838244532;
				switch (num2 == num)
				{
				default:
				{
					num = (short)993067008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)832897025;
				if (num != 0)
				{
				}
				num = (short)728170496;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.HiddenStatic;
			}
			set
			{
				short num = (short)977986330;
				short num2 = num;
				num = (short)558555930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)816644096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941621248;
				if (num != 0)
				{
				}
				num = (short)866385921;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.HiddenStatic = value;
			}
		}

		// Token: 0x170054DC RID: 21724
		// (get) Token: 0x0600A900 RID: 43264 RVA: 0x009CF1D4 File Offset: 0x009CD3D4
		// (set) Token: 0x0600A901 RID: 43265 RVA: 0x009CF288 File Offset: 0x009CD488
		internal bool DataConfDataWidePortConAuthenticationUDPPort_A37608_HiddenDynamic
		{
			get
			{
				short num = (short)975474110;
				short num2 = num;
				num = (short)2117307838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366673920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1231290368;
				if (num != 0)
				{
				}
				num = (short)649134081;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608.HiddenDynamic;
			}
			set
			{
				short num = (short)710672385;
				if (num != 0)
				{
				}
				num = (short)1525678080;
				short num2 = num;
				num = (short)536455543;
				short num3 = num;
				num = (short)269134199;
				switch (num3 == num)
				{
				}
				num = (short)1327824896;
				if (num != 0)
				{
				}
				this.dataConfDataWidePortConAuthenticationUDPPort_A37608.HiddenDynamic = value;
			}
		}

		// Token: 0x170054DD RID: 21725
		// (get) Token: 0x0600A902 RID: 43266 RVA: 0x009CF340 File Offset: 0x009CD540
		public bool DataConfDataWidePortConAuthenticationUDPPort_A37608_HasDiffs
		{
			get
			{
				short num = (short)97714177;
				if (num != 0)
				{
				}
				num = (short)420741120;
				short num2 = num;
				num = (short)1024054933;
				short num3 = num;
				num = (short)1887884949;
				switch (num3 == num)
				{
				}
				num = (short)1498677248;
				if (num != 0)
				{
				}
				return this.dataConfDataWidePortConAuthenticationUDPPort_A37608._HasDiffs;
			}
		}

		// Token: 0x170054DE RID: 21726
		// (get) Token: 0x0600A903 RID: 43267 RVA: 0x009CF3F8 File Offset: 0x009CD5F8
		// (set) Token: 0x0600A904 RID: 43268 RVA: 0x009CF4B0 File Offset: 0x009CD6B0
		public int DataWideP25LocationReportingUDPPort_42413Value
		{
			get
			{
				short num = (short)1999831041;
				if (num != 0)
				{
				}
				num = (short)650051584;
				short num2 = num;
				num = (short)1498620978;
				short num3 = num;
				num = (short)48505906;
				switch (num3 == num)
				{
				}
				num = (short)194183168;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.Value;
			}
			set
			{
				short num = (short)1008723607;
				short num2 = num;
				num = (short)1150543511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)845611008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)651100160;
				if (num != 0)
				{
				}
				num = (short)1433534465;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.Value = value;
			}
		}

		// Token: 0x170054DF RID: 21727
		// (get) Token: 0x0600A905 RID: 43269 RVA: 0x009CF564 File Offset: 0x009CD764
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideP25LocationReportingUDPPort_42413
		{
			get
			{
				short num = (short)549650433;
				if (num != 0)
				{
				}
				num = (short)1773469696;
				short num2 = num;
				num = (short)2116441359;
				short num3 = num;
				num = (short)1358058767;
				switch (num3 == num)
				{
				}
				num = (short)820707328;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413;
			}
		}

		// Token: 0x170054E0 RID: 21728
		// (get) Token: 0x0600A906 RID: 43270 RVA: 0x009CF610 File Offset: 0x009CD810
		// (set) Token: 0x0600A907 RID: 43271 RVA: 0x009CF6C4 File Offset: 0x009CD8C4
		public string DataWideP25LocationReportingUDPPort_42413_UIValue
		{
			get
			{
				short num = (short)1657433516;
				short num2 = num;
				num = (short)1234791852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)331612160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)345702400;
				if (num != 0)
				{
				}
				num = (short)434307073;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.UIValue;
			}
			set
			{
				short num = (short)2015372348;
				short num2 = num;
				num = (short)388834364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521418240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2037776385;
				if (num != 0)
				{
				}
				num = (short)1350565888;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.UIValue = value;
			}
		}

		// Token: 0x170054E1 RID: 21729
		// (get) Token: 0x0600A908 RID: 43272 RVA: 0x009CF778 File Offset: 0x009CD978
		// (set) Token: 0x0600A909 RID: 43273 RVA: 0x009CF82C File Offset: 0x009CDA2C
		internal int DataWideP25LocationReportingUDPPort_42413Min
		{
			get
			{
				short num = (short)2042340031;
				short num2 = num;
				num = (short)1482334911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1025376256;
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
				num = (short)2002124800;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.Min;
			}
			set
			{
				short num = (short)421461570;
				short num2 = num;
				num = (short)62193218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1487994880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1780285440;
				if (num != 0)
				{
				}
				num = (short)493551617;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.Min = value;
			}
		}

		// Token: 0x170054E2 RID: 21730
		// (get) Token: 0x0600A90A RID: 43274 RVA: 0x009CF8E0 File Offset: 0x009CDAE0
		// (set) Token: 0x0600A90B RID: 43275 RVA: 0x009CF994 File Offset: 0x009CDB94
		internal int DataWideP25LocationReportingUDPPort_42413Max
		{
			get
			{
				short num = (short)1240112675;
				short num2 = num;
				num = (short)690200099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1995374592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033568257;
				if (num != 0)
				{
				}
				num = (short)1453522944;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.Max;
			}
			set
			{
				short num = (short)703496289;
				short num2 = num;
				num = (short)993558625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1728970752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2007105537;
				if (num != 0)
				{
				}
				num = (short)824442880;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.Max = value;
			}
		}

		// Token: 0x170054E3 RID: 21731
		// (get) Token: 0x0600A90C RID: 43276 RVA: 0x009CFA48 File Offset: 0x009CDC48
		// (set) Token: 0x0600A90D RID: 43277 RVA: 0x009CFAFC File Offset: 0x009CDCFC
		internal int DataWideP25LocationReportingUDPPort_42413Step
		{
			get
			{
				short num = (short)756383193;
				short num2 = num;
				num = (short)1012301273;
				switch (num2 == num)
				{
				default:
				{
					num = (short)216858624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816316416;
				if (num != 0)
				{
				}
				num = (short)829095937;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.StepSize;
			}
			set
			{
				short num = (short)220236945;
				short num2 = num;
				num = (short)62557329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)437321728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545732097;
				if (num != 0)
				{
				}
				num = (short)1831206912;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.StepSize = value;
			}
		}

		// Token: 0x170054E4 RID: 21732
		// (get) Token: 0x0600A90E RID: 43278 RVA: 0x009CFBB4 File Offset: 0x009CDDB4
		// (set) Token: 0x0600A90F RID: 43279 RVA: 0x009CFC68 File Offset: 0x009CDE68
		public bool DataWideP25LocationReportingUDPPort_42413_Applicable
		{
			get
			{
				short num = (short)846891750;
				short num2 = num;
				num = (short)1908509414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)66387968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051066369;
				if (num != 0)
				{
				}
				num = (short)1002373120;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.Applicable;
			}
			set
			{
				short num = (short)390998344;
				short num2 = num;
				num = (short)206317896;
				switch (num2 == num)
				{
				default:
				{
					num = (short)635109376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)973668353;
				if (num != 0)
				{
				}
				num = (short)824311808;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.Applicable = value;
			}
		}

		// Token: 0x170054E5 RID: 21733
		// (get) Token: 0x0600A910 RID: 43280 RVA: 0x009CFD20 File Offset: 0x009CDF20
		// (set) Token: 0x0600A911 RID: 43281 RVA: 0x009CFDD8 File Offset: 0x009CDFD8
		public bool DataWideP25LocationReportingUDPPort_42413_Valid
		{
			get
			{
				short num = (short)1581352299;
				short num2 = num;
				num = (short)1580565867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)298582016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)999751681;
				if (num != 0)
				{
				}
				num = (short)262537216;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.Valid;
			}
			set
			{
				short num = (short)913929642;
				short num2 = num;
				num = (short)48330154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1016791040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)42991616;
				if (num != 0)
				{
				}
				num = (short)1297285121;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.Valid = value;
			}
		}

		// Token: 0x170054E6 RID: 21734
		// (get) Token: 0x0600A912 RID: 43282 RVA: 0x009CFE8C File Offset: 0x009CE08C
		// (set) Token: 0x0600A913 RID: 43283 RVA: 0x009CFF40 File Offset: 0x009CE140
		public bool DataWideP25LocationReportingUDPPort_42413_Visible
		{
			get
			{
				short num = (short)1543559538;
				short num2 = num;
				num = (short)871029106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1863974912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)507576320;
				if (num != 0)
				{
				}
				num = (short)958267393;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.Visible;
			}
			set
			{
				short num = (short)248265931;
				short num2 = num;
				num = (short)1112095947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)887816192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758593025;
				if (num != 0)
				{
				}
				num = (short)361234432;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.Visible = value;
			}
		}

		// Token: 0x170054E7 RID: 21735
		// (get) Token: 0x0600A914 RID: 43284 RVA: 0x009CFFF8 File Offset: 0x009CE1F8
		// (set) Token: 0x0600A915 RID: 43285 RVA: 0x009D00AC File Offset: 0x009CE2AC
		public bool DataWideP25LocationReportingUDPPort_42413_Editable
		{
			get
			{
				short num = (short)1383240662;
				short num2 = num;
				num = (short)1310954454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)590413824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1063649280;
				if (num != 0)
				{
				}
				num = (short)1146683393;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.Editable;
			}
			set
			{
				short num = (short)388687431;
				short num2 = num;
				num = (short)1765860935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)537067520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379715585;
				if (num != 0)
				{
				}
				num = (short)98893824;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.Editable = value;
			}
		}

		// Token: 0x170054E8 RID: 21736
		// (get) Token: 0x0600A916 RID: 43286 RVA: 0x009D0160 File Offset: 0x009CE360
		internal string DataWideP25LocationReportingUDPPort_42413_UILabel
		{
			get
			{
				short num = (short)1811663998;
				short num2 = num;
				num = (short)40029310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816854528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1336147968;
				if (num != 0)
				{
				}
				num = (short)1194393601;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.UIName;
			}
		}

		// Token: 0x170054E9 RID: 21737
		// (get) Token: 0x0600A917 RID: 43287 RVA: 0x009D0214 File Offset: 0x009CE414
		// (set) Token: 0x0600A918 RID: 43288 RVA: 0x009D02C8 File Offset: 0x009CE4C8
		internal bool DataWideP25LocationReportingUDPPort_42413_HiddenStatic
		{
			get
			{
				short num = (short)545317164;
				short num2 = num;
				num = (short)1086972204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1931280384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)636157953;
				if (num != 0)
				{
				}
				num = (short)2006712320;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.HiddenStatic;
			}
			set
			{
				short num = (short)886459084;
				short num2 = num;
				num = (short)1864256204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)741539840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)161873920;
				if (num != 0)
				{
				}
				num = (short)914292737;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.HiddenStatic = value;
			}
		}

		// Token: 0x170054EA RID: 21738
		// (get) Token: 0x0600A919 RID: 43289 RVA: 0x009D0380 File Offset: 0x009CE580
		// (set) Token: 0x0600A91A RID: 43290 RVA: 0x009D0434 File Offset: 0x009CE634
		internal bool DataWideP25LocationReportingUDPPort_42413_HiddenDynamic
		{
			get
			{
				short num = (short)14983333;
				short num2 = num;
				num = (short)1017684133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1422589952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687603712;
				if (num != 0)
				{
				}
				num = (short)2134835201;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413.HiddenDynamic;
			}
			set
			{
				short num = (short)337347979;
				short num2 = num;
				num = (short)476349835;
				switch (num2 == num)
				{
				default:
				{
					num = (short)795082752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)737542145;
				if (num != 0)
				{
				}
				num = (short)1672347648;
				if (num != 0)
				{
				}
				this.dataWideP25LocationReportingUDPPort_42413.HiddenDynamic = value;
			}
		}

		// Token: 0x170054EB RID: 21739
		// (get) Token: 0x0600A91B RID: 43291 RVA: 0x009D04EC File Offset: 0x009CE6EC
		public bool DataWideP25LocationReportingUDPPort_42413_HasDiffs
		{
			get
			{
				short num = (short)1988365773;
				short num2 = num;
				num = (short)2097352141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)701497344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1886912512;
				if (num != 0)
				{
				}
				num = (short)359661569;
				if (num != 0)
				{
				}
				return this.dataWideP25LocationReportingUDPPort_42413._HasDiffs;
			}
		}

		// Token: 0x170054EC RID: 21740
		// (get) Token: 0x0600A91C RID: 43292 RVA: 0x009D059C File Offset: 0x009CE79C
		// (set) Token: 0x0600A91D RID: 43293 RVA: 0x009D0650 File Offset: 0x009CE850
		public int DataWideWIFIOTAPTCPPort_42627Value
		{
			get
			{
				short num = (short)1248795717;
				short num2 = num;
				num = (short)1825381445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2026766336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1155203072;
				if (num != 0)
				{
				}
				num = (short)1005256705;
				if (num != 0)
				{
				}
				return this.dataWideWIFIOTAPTCPPort_42627.Value;
			}
			set
			{
				short num = (short)162087330;
				short num2 = num;
				num = (short)407912866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1204289536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40894464;
				if (num != 0)
				{
				}
				num = (short)365166593;
				if (num != 0)
				{
				}
				this.dataWideWIFIOTAPTCPPort_42627.Value = value;
			}
		}

		// Token: 0x170054ED RID: 21741
		// (get) Token: 0x0600A91E RID: 43294 RVA: 0x009D0704 File Offset: 0x009CE904
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideWIFIOTAPTCPPort_42627
		{
			get
			{
				short num = (short)768253257;
				short num2 = num;
				num = (short)1490591049;
				switch (num2 == num)
				{
				}
				num = (short)162988033;
				if (num != 0)
				{
				}
				num = (short)686489600;
				if (num != 0)
				{
				}
				num = (short)908328960;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627;
			}
		}

		// Token: 0x170054EE RID: 21742
		// (get) Token: 0x0600A91F RID: 43295 RVA: 0x009D07B0 File Offset: 0x009CE9B0
		// (set) Token: 0x0600A920 RID: 43296 RVA: 0x009D0864 File Offset: 0x009CEA64
		public string DataWideWIFIOTAPTCPPort_42627_UIValue
		{
			get
			{
				short num = (short)1352640003;
				short num2 = num;
				num = (short)1500751363;
				switch (num2 == num)
				{
				}
				num = (short)28508161;
				if (num != 0)
				{
				}
				num = (short)2046558208;
				if (num != 0)
				{
				}
				num = (short)184483840;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.UIValue;
			}
			set
			{
				short num = (short)1035508573;
				short num2 = num;
				num = (short)232954717;
				switch (num2 == num)
				{
				}
				num = (short)1754726401;
				if (num != 0)
				{
				}
				num = (short)1015939072;
				if (num != 0)
				{
				}
				num = (short)1582497792;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.UIValue = value;
			}
		}

		// Token: 0x170054EF RID: 21743
		// (get) Token: 0x0600A921 RID: 43297 RVA: 0x009D091C File Offset: 0x009CEB1C
		// (set) Token: 0x0600A922 RID: 43298 RVA: 0x009D09D0 File Offset: 0x009CEBD0
		internal int DataWideWIFIOTAPTCPPort_42627Min
		{
			get
			{
				short num = (short)87818241;
				if (num != 0)
				{
				}
				num = (short)2115212615;
				short num2 = num;
				num = (short)1136170311;
				switch (num2 == num)
				{
				}
				num = (short)2086862848;
				if (num != 0)
				{
				}
				num = (short)1642528768;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.Min;
			}
			set
			{
				short num = (short)1528365057;
				if (num != 0)
				{
				}
				num = (short)330011058;
				short num2 = num;
				num = (short)1540067762;
				switch (num2 == num)
				{
				}
				num = (short)1257177088;
				if (num != 0)
				{
				}
				num = (short)2085617664;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.Min = value;
			}
		}

		// Token: 0x170054F0 RID: 21744
		// (get) Token: 0x0600A923 RID: 43299 RVA: 0x009D0A84 File Offset: 0x009CEC84
		// (set) Token: 0x0600A924 RID: 43300 RVA: 0x009D0B3C File Offset: 0x009CED3C
		internal int DataWideWIFIOTAPTCPPort_42627Max
		{
			get
			{
				short num = (short)1848927750;
				short num2 = num;
				num = (short)1431004678;
				switch (num2 == num)
				{
				}
				num = (short)1694040064;
				if (num != 0)
				{
				}
				num = (short)2049703937;
				if (num != 0)
				{
				}
				num = (short)1905590272;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.Max;
			}
			set
			{
				short num = (short)1380508388;
				short num2 = num;
				num = (short)714072804;
				switch (num2 == num)
				{
				}
				num = (short)406192128;
				if (num != 0)
				{
				}
				num = (short)95420417;
				if (num != 0)
				{
				}
				num = (short)1069219840;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.Max = value;
			}
		}

		// Token: 0x170054F1 RID: 21745
		// (get) Token: 0x0600A925 RID: 43301 RVA: 0x009D0BF0 File Offset: 0x009CEDF0
		// (set) Token: 0x0600A926 RID: 43302 RVA: 0x009D0CA0 File Offset: 0x009CEEA0
		internal int DataWideWIFIOTAPTCPPort_42627Step
		{
			get
			{
				short num = (short)142411956;
				short num2 = num;
				num = (short)1806043316;
				switch (num2 == num)
				{
				}
				num = (short)2049966081;
				if (num != 0)
				{
				}
				num = (short)1849556992;
				if (num != 0)
				{
				}
				num = (short)439418880;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.StepSize;
			}
			set
			{
				short num = (short)157722120;
				short num2 = num;
				num = (short)925345288;
				switch (num2 == num)
				{
				}
				num = (short)1375469569;
				if (num != 0)
				{
				}
				num = (short)1488846848;
				if (num != 0)
				{
				}
				num = (short)65667072;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.StepSize = value;
			}
		}

		// Token: 0x170054F2 RID: 21746
		// (get) Token: 0x0600A927 RID: 43303 RVA: 0x009D0D58 File Offset: 0x009CEF58
		// (set) Token: 0x0600A928 RID: 43304 RVA: 0x009D0E10 File Offset: 0x009CF010
		public bool DataWideWIFIOTAPTCPPort_42627_Applicable
		{
			get
			{
				short num = (short)1281643586;
				short num2 = num;
				num = (short)476271682;
				switch (num2 == num)
				{
				}
				num = (short)1235025921;
				if (num != 0)
				{
				}
				num = (short)920322048;
				if (num != 0)
				{
				}
				num = (short)177143808;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.Applicable;
			}
			set
			{
				short num = (short)1637434153;
				short num2 = num;
				num = (short)1624654633;
				switch (num2 == num)
				{
				}
				num = (short)2091909121;
				if (num != 0)
				{
				}
				num = (short)1302134784;
				if (num != 0)
				{
				}
				num = (short)1238892544;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.Applicable = value;
			}
		}

		// Token: 0x170054F3 RID: 21747
		// (get) Token: 0x0600A929 RID: 43305 RVA: 0x009D0EC8 File Offset: 0x009CF0C8
		// (set) Token: 0x0600A92A RID: 43306 RVA: 0x009D0F80 File Offset: 0x009CF180
		public bool DataWideWIFIOTAPTCPPort_42627_Valid
		{
			get
			{
				short num = (short)978382504;
				short num2 = num;
				num = (short)1178660520;
				switch (num2 == num)
				{
				}
				num = (short)1484849153;
				if (num != 0)
				{
				}
				num = (short)1562116096;
				if (num != 0)
				{
				}
				num = (short)643366912;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.Valid;
			}
			set
			{
				short num = (short)1267406421;
				short num2 = num;
				num = (short)1758991957;
				switch (num2 == num)
				{
				}
				num = (short)1377370113;
				if (num != 0)
				{
				}
				num = (short)1197998080;
				if (num != 0)
				{
				}
				num = (short)1509883904;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.Valid = value;
			}
		}

		// Token: 0x170054F4 RID: 21748
		// (get) Token: 0x0600A92B RID: 43307 RVA: 0x009D1034 File Offset: 0x009CF234
		// (set) Token: 0x0600A92C RID: 43308 RVA: 0x009D10E8 File Offset: 0x009CF2E8
		public bool DataWideWIFIOTAPTCPPort_42627_Visible
		{
			get
			{
				short num = (short)42930484;
				short num2 = num;
				num = (short)1823740212;
				switch (num2 == num)
				{
				}
				num = (short)1420886017;
				if (num != 0)
				{
				}
				num = (short)1597898752;
				if (num != 0)
				{
				}
				num = (short)1617887232;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.Visible;
			}
			set
			{
				short num = (short)683308869;
				short num2 = num;
				num = (short)1980200773;
				switch (num2 == num)
				{
				}
				num = (short)389545984;
				if (num != 0)
				{
				}
				num = (short)2041511937;
				if (num != 0)
				{
				}
				num = (short)1859780608;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.Visible = value;
			}
		}

		// Token: 0x170054F5 RID: 21749
		// (get) Token: 0x0600A92D RID: 43309 RVA: 0x009D11A4 File Offset: 0x009CF3A4
		// (set) Token: 0x0600A92E RID: 43310 RVA: 0x009D1258 File Offset: 0x009CF458
		public bool DataWideWIFIOTAPTCPPort_42627_Editable
		{
			get
			{
				short num = (short)892403713;
				if (num != 0)
				{
				}
				num = (short)1827863322;
				short num2 = num;
				num = (short)734853914;
				switch (num2 == num)
				{
				}
				num = (short)774111232;
				if (num != 0)
				{
				}
				num = (short)1816657920;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.Editable;
			}
			set
			{
				short num = (short)1000603649;
				if (num != 0)
				{
				}
				num = (short)710880874;
				short num2 = num;
				num = (short)1142763114;
				switch (num2 == num)
				{
				}
				num = (short)559022080;
				if (num != 0)
				{
				}
				num = (short)1739653120;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.Editable = value;
			}
		}

		// Token: 0x170054F6 RID: 21750
		// (get) Token: 0x0600A92F RID: 43311 RVA: 0x009D1310 File Offset: 0x009CF510
		internal string DataWideWIFIOTAPTCPPort_42627_UILabel
		{
			get
			{
				short num = (short)2122228273;
				short num2 = num;
				num = (short)1608753713;
				switch (num2 == num)
				{
				}
				num = (short)591200257;
				if (num != 0)
				{
				}
				num = (short)836108288;
				if (num != 0)
				{
				}
				num = (short)642121728;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.UIName;
			}
		}

		// Token: 0x170054F7 RID: 21751
		// (get) Token: 0x0600A930 RID: 43312 RVA: 0x009D13C4 File Offset: 0x009CF5C4
		// (set) Token: 0x0600A931 RID: 43313 RVA: 0x009D147C File Offset: 0x009CF67C
		internal bool DataWideWIFIOTAPTCPPort_42627_HiddenStatic
		{
			get
			{
				short num = (short)359143568;
				short num2 = num;
				num = (short)1291786384;
				switch (num2 == num)
				{
				}
				num = (short)1304166400;
				if (num != 0)
				{
				}
				num = (short)233832449;
				if (num != 0)
				{
				}
				num = (short)626327552;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.HiddenStatic;
			}
			set
			{
				short num = (short)1199358483;
				short num2 = num;
				num = (short)303743507;
				switch (num2 == num)
				{
				}
				num = (short)1124859905;
				if (num != 0)
				{
				}
				num = (short)1444020224;
				if (num != 0)
				{
				}
				num = (short)1741225984;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.HiddenStatic = value;
			}
		}

		// Token: 0x170054F8 RID: 21752
		// (get) Token: 0x0600A932 RID: 43314 RVA: 0x009D1530 File Offset: 0x009CF730
		// (set) Token: 0x0600A933 RID: 43315 RVA: 0x009D15E4 File Offset: 0x009CF7E4
		internal bool DataWideWIFIOTAPTCPPort_42627_HiddenDynamic
		{
			get
			{
				short num = (short)868745217;
				if (num != 0)
				{
				}
				num = (short)1016043906;
				short num2 = num;
				num = (short)1301780866;
				switch (num2 == num)
				{
				}
				num = (short)977076224;
				if (num != 0)
				{
				}
				num = (short)575864832;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627.HiddenDynamic;
			}
			set
			{
				short num = (short)917048302;
				short num2 = num;
				num = (short)1762986990;
				switch (num2 == num)
				{
				}
				num = (short)1396572160;
				if (num != 0)
				{
				}
				num = (short)1033502721;
				if (num != 0)
				{
				}
				num = (short)1376780288;
				short num3 = num;
				this.dataWideWIFIOTAPTCPPort_42627.HiddenDynamic = value;
			}
		}

		// Token: 0x170054F9 RID: 21753
		// (get) Token: 0x0600A934 RID: 43316 RVA: 0x009D1698 File Offset: 0x009CF898
		public bool DataWideWIFIOTAPTCPPort_42627_HasDiffs
		{
			get
			{
				short num = (short)1359859690;
				short num2 = num;
				num = (short)272486378;
				switch (num2 == num)
				{
				}
				num = (short)108789761;
				if (num != 0)
				{
				}
				num = (short)645005312;
				if (num != 0)
				{
				}
				num = (short)1859059712;
				short num3 = num;
				return this.dataWideWIFIOTAPTCPPort_42627._HasDiffs;
			}
		}

		// Token: 0x170054FA RID: 21754
		// (get) Token: 0x0600A935 RID: 43317 RVA: 0x009D1750 File Offset: 0x009CF950
		// (set) Token: 0x0600A936 RID: 43318 RVA: 0x009D1804 File Offset: 0x009CFA04
		public int SensorMeasurementReportingUDPPort_A43022Value
		{
			get
			{
				short num = (short)2027248616;
				short num2 = num;
				num = (short)2013289448;
				switch (num2 == num)
				{
				}
				num = (short)937951232;
				if (num != 0)
				{
				}
				num = (short)459800577;
				if (num != 0)
				{
				}
				num = (short)884932608;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.Value;
			}
			set
			{
				short num = (short)1251168068;
				short num2 = num;
				num = (short)317869892;
				switch (num2 == num)
				{
				}
				num = (short)1414266880;
				if (num != 0)
				{
				}
				num = (short)427491329;
				if (num != 0)
				{
				}
				num = (short)86638592;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.Value = value;
			}
		}

		// Token: 0x170054FB RID: 21755
		// (get) Token: 0x0600A937 RID: 43319 RVA: 0x009D18BC File Offset: 0x009CFABC
		public global::AcpBusinessLayer.AcpSimpleRangeField SensorMeasurementReportingUDPPort_A43022
		{
			get
			{
				short num = (short)1175824247;
				short num2 = num;
				num = (short)329885559;
				switch (num2 == num)
				{
				}
				num = (short)1285160961;
				if (num != 0)
				{
				}
				num = (short)380698624;
				if (num != 0)
				{
				}
				num = (short)991363072;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022;
			}
		}

		// Token: 0x170054FC RID: 21756
		// (get) Token: 0x0600A938 RID: 43320 RVA: 0x009D196C File Offset: 0x009CFB6C
		// (set) Token: 0x0600A939 RID: 43321 RVA: 0x009D1A24 File Offset: 0x009CFC24
		public string SensorMeasurementReportingUDPPort_A43022_UIValue
		{
			get
			{
				short num = (short)597613817;
				short num2 = num;
				num = (short)2111298809;
				switch (num2 == num)
				{
				}
				num = (short)282066945;
				if (num != 0)
				{
				}
				num = (short)360382464;
				if (num != 0)
				{
				}
				num = (short)1577975808;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.UIValue;
			}
			set
			{
				short num = (short)745272680;
				short num2 = num;
				num = (short)506262888;
				switch (num2 == num)
				{
				}
				num = (short)99418112;
				if (num != 0)
				{
				}
				num = (short)1975713793;
				if (num != 0)
				{
				}
				num = (short)1078198272;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.UIValue = value;
			}
		}

		// Token: 0x170054FD RID: 21757
		// (get) Token: 0x0600A93A RID: 43322 RVA: 0x009D1AD8 File Offset: 0x009CFCD8
		// (set) Token: 0x0600A93B RID: 43323 RVA: 0x009D1B8C File Offset: 0x009CFD8C
		internal int SensorMeasurementReportingUDPPort_A43022Min
		{
			get
			{
				short num = (short)1459345766;
				short num2 = num;
				num = (short)972347750;
				switch (num2 == num)
				{
				}
				num = (short)1554710529;
				if (num != 0)
				{
				}
				num = (short)780730368;
				if (num != 0)
				{
				}
				num = (short)1370554368;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.Min;
			}
			set
			{
				short num = (short)1360545266;
				short num2 = num;
				num = (short)347948530;
				switch (num2 == num)
				{
				}
				num = (short)1697513473;
				if (num != 0)
				{
				}
				num = (short)343015424;
				if (num != 0)
				{
				}
				num = (short)284033024;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.Min = value;
			}
		}

		// Token: 0x170054FE RID: 21758
		// (get) Token: 0x0600A93C RID: 43324 RVA: 0x009D1C44 File Offset: 0x009CFE44
		// (set) Token: 0x0600A93D RID: 43325 RVA: 0x009D1CF8 File Offset: 0x009CFEF8
		internal int SensorMeasurementReportingUDPPort_A43022Max
		{
			get
			{
				short num = (short)423219075;
				short num2 = num;
				num = (short)2018430851;
				switch (num2 == num)
				{
				}
				num = (short)1807679488;
				if (num != 0)
				{
				}
				num = (short)1582694401;
				if (num != 0)
				{
				}
				num = (short)1486422016;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.Max;
			}
			set
			{
				short num = (short)958750686;
				short num2 = num;
				num = (short)552230878;
				switch (num2 == num)
				{
				}
				num = (short)915668992;
				if (num != 0)
				{
				}
				num = (short)164364289;
				if (num != 0)
				{
				}
				num = (short)1749876736;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.Max = value;
			}
		}

		// Token: 0x170054FF RID: 21759
		// (get) Token: 0x0600A93E RID: 43326 RVA: 0x009D1DB0 File Offset: 0x009CFFB0
		// (set) Token: 0x0600A93F RID: 43327 RVA: 0x009D1E64 File Offset: 0x009D0064
		internal int SensorMeasurementReportingUDPPort_A43022Step
		{
			get
			{
				short num = (short)1548093431;
				short num2 = num;
				num = (short)47974391;
				switch (num2 == num)
				{
				}
				num = (short)2072051713;
				if (num != 0)
				{
				}
				num = (short)1289486336;
				if (num != 0)
				{
				}
				num = (short)703463424;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.StepSize;
			}
			set
			{
				short num = (short)1325162780;
				short num2 = num;
				num = (short)992895260;
				switch (num2 == num)
				{
				}
				num = (short)1086717953;
				if (num != 0)
				{
				}
				num = (short)961216512;
				if (num != 0)
				{
				}
				num = (short)1277296640;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.StepSize = value;
			}
		}

		// Token: 0x17005500 RID: 21760
		// (get) Token: 0x0600A940 RID: 43328 RVA: 0x009D1F18 File Offset: 0x009D0118
		// (set) Token: 0x0600A941 RID: 43329 RVA: 0x009D1FCC File Offset: 0x009D01CC
		public bool SensorMeasurementReportingUDPPort_A43022_Applicable
		{
			get
			{
				short num = (short)212361465;
				short num2 = num;
				num = (short)66937081;
				switch (num2 == num)
				{
				}
				num = (short)1574830081;
				if (num != 0)
				{
				}
				num = (short)692584448;
				if (num != 0)
				{
				}
				num = (short)1037434880;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.Applicable;
			}
			set
			{
				short num = (short)1193015327;
				short num2 = num;
				num = (short)684390431;
				switch (num2 == num)
				{
				}
				num = (short)168361984;
				if (num != 0)
				{
				}
				num = (short)208797697;
				if (num != 0)
				{
				}
				num = (short)1097859072;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.Applicable = value;
			}
		}

		// Token: 0x17005501 RID: 21761
		// (get) Token: 0x0600A942 RID: 43330 RVA: 0x009D2084 File Offset: 0x009D0284
		// (set) Token: 0x0600A943 RID: 43331 RVA: 0x009D2138 File Offset: 0x009D0338
		public bool SensorMeasurementReportingUDPPort_A43022_Valid
		{
			get
			{
				short num = (short)1659168003;
				short num2 = num;
				num = (short)318760195;
				switch (num2 == num)
				{
				}
				num = (short)1736114176;
				if (num != 0)
				{
				}
				num = (short)528613377;
				if (num != 0)
				{
				}
				num = (short)568131584;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.Valid;
			}
			set
			{
				short num = (short)747301009;
				short num2 = num;
				num = (short)624093329;
				switch (num2 == num)
				{
				}
				num = (short)1508245504;
				if (num != 0)
				{
				}
				num = (short)405340161;
				if (num != 0)
				{
				}
				num = (short)2081357824;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.Valid = value;
			}
		}

		// Token: 0x17005502 RID: 21762
		// (get) Token: 0x0600A944 RID: 43332 RVA: 0x009D21F0 File Offset: 0x009D03F0
		// (set) Token: 0x0600A945 RID: 43333 RVA: 0x009D22A4 File Offset: 0x009D04A4
		public bool SensorMeasurementReportingUDPPort_A43022_Visible
		{
			get
			{
				short num = (short)1633221343;
				short num2 = num;
				num = (short)1368521439;
				switch (num2 == num)
				{
				}
				num = (short)94765057;
				if (num != 0)
				{
				}
				num = (short)867631104;
				if (num != 0)
				{
				}
				num = (short)1815871488;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.Visible;
			}
			set
			{
				short num = (short)1939350751;
				short num2 = num;
				num = (short)691610847;
				switch (num2 == num)
				{
				}
				num = (short)1261305857;
				if (num != 0)
				{
				}
				num = (short)1605369856;
				if (num != 0)
				{
				}
				num = (short)671481856;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.Visible = value;
			}
		}

		// Token: 0x17005503 RID: 21763
		// (get) Token: 0x0600A946 RID: 43334 RVA: 0x009D2358 File Offset: 0x009D0558
		// (set) Token: 0x0600A947 RID: 43335 RVA: 0x009D240C File Offset: 0x009D060C
		public bool SensorMeasurementReportingUDPPort_A43022_Editable
		{
			get
			{
				short num = (short)477775460;
				short num2 = num;
				num = (short)144393828;
				switch (num2 == num)
				{
				}
				num = (short)1729101825;
				if (num != 0)
				{
				}
				num = (short)1140916224;
				if (num != 0)
				{
				}
				num = (short)1094254592;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.Editable;
			}
			set
			{
				short num = (short)466092033;
				if (num != 0)
				{
				}
				num = (short)394951862;
				short num2 = num;
				num = (short)1275362486;
				switch (num2 == num)
				{
				}
				num = (short)767229952;
				if (num != 0)
				{
				}
				num = (short)1499070464;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.Editable = value;
			}
		}

		// Token: 0x17005504 RID: 21764
		// (get) Token: 0x0600A948 RID: 43336 RVA: 0x009D24C0 File Offset: 0x009D06C0
		internal string SensorMeasurementReportingUDPPort_A43022_UILabel
		{
			get
			{
				short num = (short)1975963554;
				short num2 = num;
				num = (short)1780797346;
				switch (num2 == num)
				{
				}
				num = (short)1382612993;
				if (num != 0)
				{
				}
				num = (short)15859712;
				if (num != 0)
				{
				}
				num = (short)1869152256;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.UIName;
			}
		}

		// Token: 0x17005505 RID: 21765
		// (get) Token: 0x0600A949 RID: 43337 RVA: 0x009D2578 File Offset: 0x009D0778
		// (set) Token: 0x0600A94A RID: 43338 RVA: 0x009D2630 File Offset: 0x009D0830
		internal bool SensorMeasurementReportingUDPPort_A43022_HiddenStatic
		{
			get
			{
				short num = (short)1646298415;
				short num2 = num;
				num = (short)1089242415;
				switch (num2 == num)
				{
				}
				num = (short)194904065;
				if (num != 0)
				{
				}
				num = (short)1123221504;
				if (num != 0)
				{
				}
				num = (short)457375744;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.HiddenStatic;
			}
			set
			{
				short num = (short)313719202;
				short num2 = num;
				num = (short)1875638690;
				switch (num2 == num)
				{
				}
				num = (short)1630535681;
				if (num != 0)
				{
				}
				num = (short)1646395392;
				if (num != 0)
				{
				}
				num = (short)452526080;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.HiddenStatic = value;
			}
		}

		// Token: 0x17005506 RID: 21766
		// (get) Token: 0x0600A94B RID: 43339 RVA: 0x009D26E8 File Offset: 0x009D08E8
		// (set) Token: 0x0600A94C RID: 43340 RVA: 0x009D279C File Offset: 0x009D099C
		internal bool SensorMeasurementReportingUDPPort_A43022_HiddenDynamic
		{
			get
			{
				short num = (short)1243194669;
				short num2 = num;
				num = (short)1350280493;
				switch (num2 == num)
				{
				}
				num = (short)327745537;
				if (num != 0)
				{
				}
				num = (short)1836974080;
				if (num != 0)
				{
				}
				num = (short)16777216;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022.HiddenDynamic;
			}
			set
			{
				short num = (short)1489686513;
				short num2 = num;
				num = (short)882823153;
				switch (num2 == num)
				{
				}
				num = (short)1008205825;
				if (num != 0)
				{
				}
				num = (short)1884356608;
				if (num != 0)
				{
				}
				num = (short)1398800384;
				short num3 = num;
				this.sensorMeasurementReportingUDPPort_A43022.HiddenDynamic = value;
			}
		}

		// Token: 0x17005507 RID: 21767
		// (get) Token: 0x0600A94D RID: 43341 RVA: 0x009D2850 File Offset: 0x009D0A50
		public bool SensorMeasurementReportingUDPPort_A43022_HasDiffs
		{
			get
			{
				short num = (short)710916938;
				short num2 = num;
				num = (short)88193866;
				switch (num2 == num)
				{
				}
				num = (short)2027225089;
				if (num != 0)
				{
				}
				num = (short)102629376;
				if (num != 0)
				{
				}
				num = (short)140640256;
				short num3 = num;
				return this.sensorMeasurementReportingUDPPort_A43022._HasDiffs;
			}
		}

		// Token: 0x17005508 RID: 21768
		// (get) Token: 0x0600A94E RID: 43342 RVA: 0x009D2904 File Offset: 0x009D0B04
		// (set) Token: 0x0600A94F RID: 43343 RVA: 0x009D29B8 File Offset: 0x009D0BB8
		public int DataWideKVLKeyloadingUDPPort_43205Value
		{
			get
			{
				short num = (short)1198156262;
				short num2 = num;
				num = (short)223570406;
				switch (num2 == num)
				{
				}
				num = (short)2001338369;
				if (num != 0)
				{
				}
				num = (short)1505492992;
				if (num != 0)
				{
				}
				num = (short)1668284416;
				short num3 = num;
				return this.dataWideKVLKeyloadingUDPPort_43205.Value;
			}
			set
			{
				short num = (short)528568241;
				short num2 = num;
				num = (short)1200443313;
				switch (num2 == num)
				{
				}
				num = (short)572588032;
				if (num != 0)
				{
				}
				num = (short)281608193;
				if (num != 0)
				{
				}
				num = (short)571015168;
				short num3 = num;
				this.dataWideKVLKeyloadingUDPPort_43205.Value = value;
			}
		}

		// Token: 0x17005509 RID: 21769
		// (get) Token: 0x0600A950 RID: 43344 RVA: 0x009D2A6C File Offset: 0x009D0C6C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideKVLKeyloadingUDPPort_43205
		{
			get
			{
				short num = (short)2094559802;
				short num2 = num;
				num = (short)1539600954;
				switch (num2 == num)
				{
				}
				num = (short)552796161;
				if (num != 0)
				{
				}
				num = (short)229638144;
				if (num != 0)
				{
				}
				num = (short)1313603584;
				short num3 = num;
				return this.dataWideKVLKeyloadingUDPPort_43205;
			}
		}

		// Token: 0x1700550A RID: 21770
		// (get) Token: 0x0600A951 RID: 43345 RVA: 0x009D2B20 File Offset: 0x009D0D20
		// (set) Token: 0x0600A952 RID: 43346 RVA: 0x009D2BD8 File Offset: 0x009D0DD8
		public string DataWideKVLKeyloadingUDPPort_43205_UIValue
		{
			get
			{
				short num = (short)1628562265;
				short num2 = num;
				num = (short)470213465;
				switch (num2 == num)
				{
				}
				num = (short)1139146752;
				if (num != 0)
				{
				}
				num = (short)1369505793;
				if (num != 0)
				{
				}
				num = (short)2086338560;
				short num3 = num;
				return this.dataWideKVLKeyloadingUDPPort_43205.UIValue;
			}
			set
			{
				short num = (short)1632302397;
				short num2 = num;
				num = (short)80737597;
				switch (num2 == num)
				{
				}
				num = (short)571277313;
				if (num != 0)
				{
				}
				num = (short)392364032;
				if (num != 0)
				{
				}
				num = (short)1662582784;
				short num3 = num;
				this.dataWideKVLKeyloadingUDPPort_43205.UIValue = value;
			}
		}

		// Token: 0x1700550B RID: 21771
		// (get) Token: 0x0600A953 RID: 43347 RVA: 0x009D2C90 File Offset: 0x009D0E90
		// (set) Token: 0x0600A954 RID: 43348 RVA: 0x009D2D44 File Offset: 0x009D0F44
		internal int DataWideKVLKeyloadingUDPPort_43205Min
		{
			get
			{
				short num = (short)1381653041;
				short num2 = num;
				num = (short)1145199153;
				switch (num2 == num)
				{
				}
				num = (short)226557953;
				if (num != 0)
				{
				}
				num = (short)59244544;
				if (num != 0)
				{
				}
				num = (short)56557568;
				short num3 = num;
				return this.dataWideKVLKeyloadingUDPPort_43205.Min;
			}
			set
			{
				short num = (short)1656727584;
				short num2 = num;
				num = (short)655337504;
				switch (num2 == num)
				{
				}
				num = (short)97517568;
				if (num != 0)
				{
				}
				num = (short)1291911168;
				short num3 = num;
				num = (short)806944769;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.Min = value;
			}
		}

		// Token: 0x1700550C RID: 21772
		// (get) Token: 0x0600A955 RID: 43349 RVA: 0x009D2DF8 File Offset: 0x009D0FF8
		// (set) Token: 0x0600A956 RID: 43350 RVA: 0x009D2EAC File Offset: 0x009D10AC
		internal int DataWideKVLKeyloadingUDPPort_43205Max
		{
			get
			{
				short num = (short)1453494618;
				short num2 = num;
				num = (short)614306138;
				switch (num2 == num)
				{
				}
				num = (short)2099249153;
				if (num != 0)
				{
				}
				num = (short)1694367744;
				short num3 = num;
				num = (short)788529152;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.Max;
			}
			set
			{
				short num = (short)1444140568;
				short num2 = num;
				num = (short)2032326168;
				switch (num2 == num)
				{
				}
				num = (short)546308097;
				if (num != 0)
				{
				}
				num = (short)1889075200;
				short num3 = num;
				num = (short)1011417088;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.Max = value;
			}
		}

		// Token: 0x1700550D RID: 21773
		// (get) Token: 0x0600A957 RID: 43351 RVA: 0x009D2F60 File Offset: 0x009D1160
		// (set) Token: 0x0600A958 RID: 43352 RVA: 0x009D3018 File Offset: 0x009D1218
		internal int DataWideKVLKeyloadingUDPPort_43205Step
		{
			get
			{
				short num = (short)1387806580;
				short num2 = num;
				num = (short)884359028;
				switch (num2 == num)
				{
				}
				num = (short)1463091201;
				if (num != 0)
				{
				}
				num = (short)1703804928;
				short num3 = num;
				num = (short)1970995200;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.StepSize;
			}
			set
			{
				short num = (short)661061633;
				if (num != 0)
				{
				}
				num = (short)924141059;
				short num2 = num;
				num = (short)1787395;
				switch (num2 == num)
				{
				}
				num = (short)1883045888;
				short num3 = num;
				num = (short)1281556480;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.StepSize = value;
			}
		}

		// Token: 0x1700550E RID: 21774
		// (get) Token: 0x0600A959 RID: 43353 RVA: 0x009D30CC File Offset: 0x009D12CC
		// (set) Token: 0x0600A95A RID: 43354 RVA: 0x009D3180 File Offset: 0x009D1380
		public bool DataWideKVLKeyloadingUDPPort_43205_Applicable
		{
			get
			{
				short num = (short)1280830010;
				short num2 = num;
				num = (short)179169850;
				switch (num2 == num)
				{
				}
				num = (short)255066113;
				if (num != 0)
				{
				}
				num = (short)1522663424;
				short num3 = num;
				num = (short)1719140352;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.Applicable;
			}
			set
			{
				short num = (short)1626376461;
				short num2 = num;
				num = (short)1920764173;
				switch (num2 == num)
				{
				}
				num = (short)1993277441;
				if (num != 0)
				{
				}
				num = (short)1280638976;
				short num3 = num;
				num = (short)1569587200;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.Applicable = value;
			}
		}

		// Token: 0x1700550F RID: 21775
		// (get) Token: 0x0600A95B RID: 43355 RVA: 0x009D3238 File Offset: 0x009D1438
		// (set) Token: 0x0600A95C RID: 43356 RVA: 0x009D32E8 File Offset: 0x009D14E8
		public bool DataWideKVLKeyloadingUDPPort_43205_Valid
		{
			get
			{
				short num = (short)372895099;
				short num2 = num;
				num = (short)2113006971;
				switch (num2 == num)
				{
				}
				num = (short)1759182848;
				if (num != 0)
				{
				}
				num = (short)2134114304;
				short num3 = num;
				num = (short)1142554625;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.Valid;
			}
			set
			{
				short num = (short)700133198;
				short num2 = num;
				num = (short)1952722766;
				switch (num2 == num)
				{
				}
				num = (short)1380319233;
				if (num != 0)
				{
				}
				num = (short)1138229248;
				short num3 = num;
				num = (short)999096320;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.Valid = value;
			}
		}

		// Token: 0x17005510 RID: 21776
		// (get) Token: 0x0600A95D RID: 43357 RVA: 0x009D339C File Offset: 0x009D159C
		// (set) Token: 0x0600A95E RID: 43358 RVA: 0x009D3454 File Offset: 0x009D1654
		public bool DataWideKVLKeyloadingUDPPort_43205_Visible
		{
			get
			{
				short num = (short)98787349;
				short num2 = num;
				num = (short)68378645;
				switch (num2 == num)
				{
				}
				num = (short)1632960513;
				if (num != 0)
				{
				}
				num = (short)1943732224;
				short num3 = num;
				num = (short)1844772864;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.Visible;
			}
			set
			{
				short num = (short)1672053951;
				short num2 = num;
				num = (short)1347912895;
				switch (num2 == num)
				{
				}
				num = (short)1864040449;
				if (num != 0)
				{
				}
				num = (short)946339840;
				short num3 = num;
				num = (short)1695219712;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.Visible = value;
			}
		}

		// Token: 0x17005511 RID: 21777
		// (get) Token: 0x0600A95F RID: 43359 RVA: 0x009D350C File Offset: 0x009D170C
		// (set) Token: 0x0600A960 RID: 43360 RVA: 0x009D35C0 File Offset: 0x009D17C0
		public bool DataWideKVLKeyloadingUDPPort_43205_Editable
		{
			get
			{
				short num = (short)838001482;
				short num2 = num;
				num = (short)103277386;
				switch (num2 == num)
				{
				}
				num = (short)874184705;
				if (num != 0)
				{
				}
				num = (short)1743257600;
				short num3 = num;
				num = (short)505348096;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.Editable;
			}
			set
			{
				short num = (short)2019033089;
				if (num != 0)
				{
				}
				num = (short)1035069105;
				short num2 = num;
				num = (short)455730865;
				switch (num2 == num)
				{
				}
				num = (short)687276032;
				short num3 = num;
				num = (short)1396113408;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.Editable = value;
			}
		}

		// Token: 0x17005512 RID: 21778
		// (get) Token: 0x0600A961 RID: 43361 RVA: 0x009D3678 File Offset: 0x009D1878
		internal string DataWideKVLKeyloadingUDPPort_43205_UILabel
		{
			get
			{
				short num = (short)436909368;
				short num2 = num;
				num = (short)917484856;
				switch (num2 == num)
				{
				}
				num = (short)1546190848;
				if (num != 0)
				{
				}
				num = (short)1597636608;
				short num3 = num;
				num = (short)1160904705;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.UIName;
			}
		}

		// Token: 0x17005513 RID: 21779
		// (get) Token: 0x0600A962 RID: 43362 RVA: 0x009D372C File Offset: 0x009D192C
		// (set) Token: 0x0600A963 RID: 43363 RVA: 0x009D37E4 File Offset: 0x009D19E4
		internal bool DataWideKVLKeyloadingUDPPort_43205_HiddenStatic
		{
			get
			{
				short num = (short)531083323;
				short num2 = num;
				num = (short)1675276347;
				switch (num2 == num)
				{
				}
				num = (short)1425801216;
				if (num != 0)
				{
				}
				num = (short)36175872;
				short num3 = num;
				num = (short)1223163905;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.HiddenStatic;
			}
			set
			{
				short num = (short)984612865;
				if (num != 0)
				{
				}
				num = (short)1641185062;
				short num2 = num;
				num = (short)312966950;
				switch (num2 == num)
				{
				}
				num = (short)482541568;
				short num3 = num;
				num = (short)1703411712;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.HiddenStatic = value;
			}
		}

		// Token: 0x17005514 RID: 21780
		// (get) Token: 0x0600A964 RID: 43364 RVA: 0x009D3898 File Offset: 0x009D1A98
		// (set) Token: 0x0600A965 RID: 43365 RVA: 0x009D394C File Offset: 0x009D1B4C
		internal bool DataWideKVLKeyloadingUDPPort_43205_HiddenDynamic
		{
			get
			{
				short num = (short)1407582209;
				if (num != 0)
				{
				}
				num = (short)1341396503;
				short num2 = num;
				num = (short)282269207;
				switch (num2 == num)
				{
				}
				num = (short)1113456640;
				short num3 = num;
				num = (short)1140588544;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205.HiddenDynamic;
			}
			set
			{
				short num = (short)410797528;
				short num2 = num;
				num = (short)1849050584;
				switch (num2 == num)
				{
				}
				num = (short)727777281;
				if (num != 0)
				{
				}
				num = (short)66584576;
				short num3 = num;
				num = (short)10551296;
				if (num != 0)
				{
				}
				this.dataWideKVLKeyloadingUDPPort_43205.HiddenDynamic = value;
			}
		}

		// Token: 0x17005515 RID: 21781
		// (get) Token: 0x0600A966 RID: 43366 RVA: 0x009D3A04 File Offset: 0x009D1C04
		public bool DataWideKVLKeyloadingUDPPort_43205_HasDiffs
		{
			get
			{
				short num = (short)1357031250;
				short num2 = num;
				num = (short)478914386;
				switch (num2 == num)
				{
				}
				num = (short)145620992;
				if (num != 0)
				{
				}
				num = (short)1135607808;
				short num3 = num;
				num = (short)232652801;
				if (num != 0)
				{
				}
				return this.dataWideKVLKeyloadingUDPPort_43205._HasDiffs;
			}
		}

		// Token: 0x17005516 RID: 21782
		// (get) Token: 0x0600A967 RID: 43367 RVA: 0x009D3AB4 File Offset: 0x009D1CB4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)2048979889;
				short num2 = num;
				num = (short)1405350833;
				switch (num2 == num)
				{
				}
				num = (short)364314625;
				if (num != 0)
				{
				}
				num = (short)504954880;
				short num3 = num;
				num = (short)1618870272;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17005517 RID: 21783
		// (get) Token: 0x0600A968 RID: 43368 RVA: 0x009D3B74 File Offset: 0x009D1D74
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)2058976175;
				short num2 = num;
				num = (short)60717999;
				switch (num2 == num)
				{
				}
				num = (short)2063335424;
				if (num != 0)
				{
				}
				num = (short)1847394304;
				short num3 = num;
				num = (short)1609236481;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x009D3C34 File Offset: 0x009D1E34
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)59899905;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num = (short)877862091;
					short num3 = num;
					num = (short)537664715;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_162;
					default:
						num = (short)525205504;
						if (num != 0)
						{
						}
						num = (short)221184001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_162;
				case 2:
					if (base.ParentRecset != null)
					{
						num = (short)1536819203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					num = (short)1140981760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_AA;
				}
				goto IL_4C;
				IL_162:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num = (short)1893859332;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AA:
			num = (short)1882652672;
			short num4 = num;
			return result;
			IL_4C:
			result = null;
			num = (short)895418370;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0400513F RID: 20799
		private global::AcpBusinessLayer.AcpSimpleRangeField dataConfDataWidePortConAuthenticationUDPPort_A37608;

		// Token: 0x04005140 RID: 20800
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideP25LocationReportingUDPPort_42413;

		// Token: 0x04005141 RID: 20801
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideWIFIOTAPTCPPort_42627;

		// Token: 0x04005142 RID: 20802
		private global::AcpBusinessLayer.AcpSimpleRangeField sensorMeasurementReportingUDPPort_A43022;

		// Token: 0x04005143 RID: 20803
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideKVLKeyloadingUDPPort_43205;
	}
}
