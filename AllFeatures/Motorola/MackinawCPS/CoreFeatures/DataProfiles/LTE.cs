using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DataWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000511 RID: 1297
	[global::System.Serializable]
	public class LTE : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AF63 RID: 44899 RVA: 0x00A2E1A4 File Offset: 0x00A2C3A4
		public LTE(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x00A2E1C0 File Offset: 0x00A2C3C0
		protected LTE(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AF65 RID: 44901 RVA: 0x00A2E1D8 File Offset: 0x00A2C3D8
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1590540368;
			short num2 = num;
			num = (short)273266768;
			switch (num2 == num)
			{
			}
			num = (short)804782081;
			if (num != 0)
			{
			}
			num = (short)27000832;
			if (num != 0)
			{
			}
			num = (short)145227776;
			short num3 = num;
			this.dataProfLTEEnabled_A42075 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢꃤ触裨觪臬諮闰곲듴쏶쯸쯺쫼쫾", a_), global::CommonResources.AcgResources.ID_LTEENABLE);
			this.dataProfLTEEnabled_A42075.IgnoreOnCompare = true;
			this.dataProfLTEEnabled_A42075.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataProfLTEEnabled_A42075.DataTransferOrder = 54;
			this.dataProfBroadbandSource_A42858 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鷞鏠賢蓤菦诨諪菬诮ꋰ鳲胴藶髸黺ꋼ뻾㔀㄂㴄㈆ㄈ", a_), global::CommonResources.AcgResources.ID_BROADBANDSOURCE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfBroadbandSource_A42858LovStrs);
			this.dataProfBroadbandSource_A42858.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfBroadbandSource_A42858.DataTransferOrder = 75;
			this.dataProfBroadbandSource_A42858.EvaluateRecRefs = true;
			this.dataProfLTEBackupPTTGatewayPort_A43618 = new global::AcpBusinessLayer.AcpSimpleRangeField(49665, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢ꟤蛦諨胪飬鿮ꇰꟲꇴ냶飸迺飼裾怀稂唄栆笈缊刌与┐‒⌔☖℘", a_), global::CommonResources.AcgResources.ID_BACKUPPTTGATEWAYTLSPORTNUMBER, 1, 65535, null, null, 0, 1);
			this.dataProfLTEBackupPTTGatewayPort_A43618.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataProfLTEBackupPTTGatewayPort_A43618.DataTransferOrder = 79;
			this.dataProfLTEBackupPTTGatewayPort_A43618.ShowHexValue = false;
			this.dataProfLTEBackupPTTGatewayHostname_A43621 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢ꟤蛦諨胪飬鿮ꇰꟲꇴ냶飸迺飼裾怀稂䴄栆稈缊挌渎簐瘒䨔嘖ⴘ⠚⬜ⴞဠ", a_), global::CommonResources.AcgResources.ID_BACKUPPTTGATEWAYHOSTNAME, 63);
			this.dataProfLTEBackupPTTGatewayHostname_A43621.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataProfLTEBackupPTTGatewayHostname_A43621.DataTransferOrder = 78;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跎ꏐ볒듔돖믘뫚돜믞", a_);
			base.Id = 10773;
			base.UIName = global::CommonResources.AcgResources.ID_BROADBAND;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600AF66 RID: 44902 RVA: 0x00A2E3DC File Offset: 0x00A2C5DC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1452015619;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鷞鏠賢蓤菦诨諪菬诮ꋰ鳲胴藶髸黺ꋼ뻾㔀㄂㴄㈆ㄈ", a_)))
					{
						num = (short)1885995020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25E;
				case 1:
					goto IL_32C;
				case 2:
					num = (short)1248460801;
					if (num != 0)
					{
					}
					if (producerFields != null)
					{
						num = (short)1841233935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42B;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 4:
					goto IL_25E;
				case 5:
					this.dataProfLTEBackupPTTGatewayPort_A43618 = new global::AcpBusinessLayer.AcpSimpleRangeField(443, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢ꟤蛦諨胪飬鿮ꇰꟲꇴ냶飸迺飼裾怀稂唄栆笈缊刌与┐‒⌔☖℘", a_), global::CommonResources.AcgResources.ID_BACKUPPTTGATEWAYTLSPORTNUMBER, null, null, 0, 1);
					this.dataProfLTEBackupPTTGatewayPort_A43618.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dataProfLTEBackupPTTGatewayPort_A43618.DataTransferOrder = 79;
					this.dataProfLTEBackupPTTGatewayPort_A43618.ShowHexValue = false;
					num = (short)5505034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢꃤ触裨觪臬諮闰곲듴쏶쯸쯺쫼쫾", a_)))
					{
						num = (short)986644494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_331;
				case 7:
					goto IL_331;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢ꟤蛦諨胪飬鿮ꇰꟲꇴ냶飸迺飼裾怀稂唄栆笈缊刌与┐‒⌔☖℘", a_)))
					{
						num = (short)1034944517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B0;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢ꟤蛦諨胪飬鿮ꇰꟲꇴ냶飸迺飼裾怀稂䴄栆稈缊挌渎簐瘒䨔嘖ⴘ⠚⬜ⴞဠ", a_)))
					{
						num = (short)650510349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42B;
				case 10:
					goto IL_1B0;
				case 11:
					num = (short)1329725442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.dataProfBroadbandSource_A42858 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鷞鏠賢蓤菦诨諪菬诮ꋰ鳲胴藶髸黺ꋼ뻾㔀㄂㴄㈆ㄈ", a_), global::CommonResources.AcgResources.ID_BROADBANDSOURCE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfBroadbandSource_A42858LovStrs);
					this.dataProfBroadbandSource_A42858.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfBroadbandSource_A42858.DataTransferOrder = 75;
					this.dataProfBroadbandSource_A42858.EvaluateRecRefs = true;
					num = (short)1153826820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					this.dataProfLTEBackupPTTGatewayHostname_A43621 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢ꟤蛦諨胪飬鿮ꇰꟲꇴ냶飸迺飼裾怀稂䴄栆稈缊挌渎簐瘒䨔嘖ⴘ⠚⬜ⴞဠ", a_), global::CommonResources.AcgResources.ID_BACKUPPTTGATEWAYHOSTNAME, 63);
					this.dataProfLTEBackupPTTGatewayHostname_A43621.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataProfLTEBackupPTTGatewayHostname_A43621.DataTransferOrder = 78;
					num = (short)1717239808;
					short num3 = num;
					num = (short)1203044353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
				{
					this.dataProfLTEEnabled_A42075 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜鏞뗠ꛢꃤ触裨觪臬諮闰곲듴쏶쯸쯺쫼쫾", a_), global::CommonResources.AcgResources.ID_LTEENABLE);
					this.dataProfLTEEnabled_A42075.IgnoreOnCompare = true;
					this.dataProfLTEEnabled_A42075.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataProfLTEEnabled_A42075.DataTransferOrder = 54;
					num = (short)863006690;
					short num4 = num;
					num = (short)1954050018;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_163;
					default:
						num = (short)304349184;
						if (num != 0)
						{
						}
						num = (short)1604714503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					goto IL_163;
				}
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1355284491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_163:
				num = (short)1771896838;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B0:
				num = (short)1947402249;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25E:
				num = (short)637861896;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_331:
				num = (short)1194000384;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_32C:
			IL_42B:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跎ꏐ볒듔돖믘뫚돜믞", a_);
			base.Id = 10773;
			base.UIName = global::CommonResources.AcgResources.ID_BROADBAND;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600AF67 RID: 44903 RVA: 0x00A2E848 File Offset: 0x00A2CA48
		public override void PopulateReferences()
		{
			short num = (short)1982586091;
			short num2 = num;
			num = (short)744021227;
			switch (num2 == num)
			{
			}
			num = (short)594673665;
			if (num != 0)
			{
			}
			num = (short)714276864;
			if (num != 0)
			{
			}
			num = (short)1649737728;
			short num3 = num;
		}

		// Token: 0x0600AF68 RID: 44904 RVA: 0x00A2E8F4 File Offset: 0x00A2CAF4
		public override void DropReferences()
		{
			short num = (short)308740097;
			if (num != 0)
			{
			}
			num = (short)938636678;
			short num2 = num;
			num = (short)417494406;
			switch (num2 == num)
			{
			}
			num = (short)34865152;
			if (num != 0)
			{
			}
			num = (short)1281753088;
			short num3 = num;
		}

		// Token: 0x0600AF69 RID: 44905 RVA: 0x00A2E9A0 File Offset: 0x00A2CBA0
		public override void SetConstraints()
		{
			short num = (short)1131868937;
			short num2 = num;
			num = (short)347271945;
			switch (num2 == num)
			{
			}
			num = (short)1154023425;
			if (num != 0)
			{
			}
			num = (short)390070272;
			if (num != 0)
			{
			}
			num = (short)1623392256;
			short num3 = num;
			this.dataProfLTEEnabled_A42075.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfLTEApp);
			this.dataProfLTEEnabled_A42075.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conReturnFalse);
			this.dataProfLTEEnabled_A42075.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileLTEValueSetter);
			this.dataProfBroadbandSource_A42858.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfDataTypeValid);
			this.dataProfBroadbandSource_A42858.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSynLTEEnable);
			this.dataProfLTEBackupPTTGatewayPort_A43618.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conBackUpPTTTLSPortUnique);
			this.DataProfLTEBackupPTTGatewayHostname_A43621.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conBackupPTTHostnameValidity);
		}

		// Token: 0x0600AF6A RID: 44906 RVA: 0x00A2EAEC File Offset: 0x00A2CCEC
		public override void SetupDependencies()
		{
			short num = (short)1270836766;
			short num2 = num;
			num = (short)1672441374;
			switch (num2 == num)
			{
			}
			num = (short)1642201088;
			if (num != 0)
			{
			}
			num = (short)1945108481;
			if (num != 0)
			{
			}
			num = (short)129630208;
			short num3 = num;
			(base.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfLTEEnabled_A42075);
			this.RefDataWide.ExternalDataModem.DataWideExternalDataModemType_42843.AddDependentObject(this.dataProfBroadbandSource_A42858);
			this.RefDataWide.ExternalDataModem.ModemConnectionType_43350.AddDependentObject(this.dataProfBroadbandSource_A42858);
			this.RefDataWide.WIFI.DataWideWIFIEnable_42506.AddDependentObject(this.dataProfBroadbandSource_A42858);
		}

		// Token: 0x17005807 RID: 22535
		// (get) Token: 0x0600AF6B RID: 44907 RVA: 0x00A2EC08 File Offset: 0x00A2CE08
		public bool HasDiffs
		{
			get
			{
				short num = (short)629669889;
				if (num != 0)
				{
				}
				num = (short)723578670;
				short num2 = num;
				num = (short)1600122670;
				switch (num2 == num)
				{
				}
				num = (short)2097872896;
				if (num != 0)
				{
				}
				num = (short)32112640;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17005808 RID: 22536
		// (get) Token: 0x0600AF6C RID: 44908 RVA: 0x00A2ECB8 File Offset: 0x00A2CEB8
		// (set) Token: 0x0600AF6D RID: 44909 RVA: 0x00A2ED6C File Offset: 0x00A2CF6C
		public bool DataProfLTEEnabled_A42075Value
		{
			get
			{
				short num = (short)1177381428;
				short num2 = num;
				num = (short)1708812852;
				switch (num2 == num)
				{
				}
				num = (short)710868992;
				if (num != 0)
				{
				}
				num = (short)1123483649;
				if (num != 0)
				{
				}
				num = (short)1060241408;
				short num3 = num;
				return this.dataProfLTEEnabled_A42075.Value;
			}
			set
			{
				short num = (short)105095063;
				short num2 = num;
				num = (short)102473623;
				switch (num2 == num)
				{
				}
				num = (short)166592512;
				if (num != 0)
				{
				}
				num = (short)1634074625;
				if (num != 0)
				{
				}
				num = (short)1564999680;
				short num3 = num;
				this.dataProfLTEEnabled_A42075.Value = value;
			}
		}

		// Token: 0x17005809 RID: 22537
		// (get) Token: 0x0600AF6E RID: 44910 RVA: 0x00A2EE20 File Offset: 0x00A2D020
		public global::AcpBusinessLayer.AcpField<bool> DataProfLTEEnabled_A42075
		{
			get
			{
				short num = (short)1268097869;
				short num2 = num;
				num = (short)12886861;
				switch (num2 == num)
				{
				}
				num = (short)908328961;
				if (num != 0)
				{
				}
				num = (short)916914176;
				if (num != 0)
				{
				}
				num = (short)1738670080;
				short num3 = num;
				return this.dataProfLTEEnabled_A42075;
			}
		}

		// Token: 0x1700580A RID: 22538
		// (get) Token: 0x0600AF6F RID: 44911 RVA: 0x00A2EED0 File Offset: 0x00A2D0D0
		// (set) Token: 0x0600AF70 RID: 44912 RVA: 0x00A2EF84 File Offset: 0x00A2D184
		public bool DataProfLTEEnabled_A42075_UIValue
		{
			get
			{
				short num = (short)1168563734;
				short num2 = num;
				num = (short)166452758;
				switch (num2 == num)
				{
				}
				num = (short)79364097;
				if (num != 0)
				{
				}
				num = (short)522518528;
				if (num != 0)
				{
				}
				num = (short)557318144;
				short num3 = num;
				return this.dataProfLTEEnabled_A42075.Value;
			}
			set
			{
				short num = (short)664010753;
				if (num != 0)
				{
				}
				num = (short)194657248;
				short num2 = num;
				num = (short)1960590304;
				switch (num2 == num)
				{
				}
				num = (short)703332352;
				if (num != 0)
				{
				}
				num = (short)1108410368;
				short num3 = num;
				this.dataProfLTEEnabled_A42075.Value = value;
			}
		}

		// Token: 0x1700580B RID: 22539
		// (get) Token: 0x0600AF71 RID: 44913 RVA: 0x00A2F038 File Offset: 0x00A2D238
		// (set) Token: 0x0600AF72 RID: 44914 RVA: 0x00A2F0EC File Offset: 0x00A2D2EC
		public bool DataProfLTEEnabled_A42075_Applicable
		{
			get
			{
				short num = (short)1682779805;
				short num2 = num;
				num = (short)858599069;
				switch (num2 == num)
				{
				}
				num = (short)2088501249;
				if (num != 0)
				{
				}
				num = (short)967442432;
				if (num != 0)
				{
				}
				num = (short)1853489152;
				short num3 = num;
				return this.dataProfLTEEnabled_A42075.Applicable;
			}
			set
			{
				short num = (short)1960770099;
				short num2 = num;
				num = (short)2065496627;
				switch (num2 == num)
				{
				}
				num = (short)1015611392;
				if (num != 0)
				{
				}
				num = (short)1979187200;
				short num3 = num;
				num = (short)185532417;
				if (num != 0)
				{
				}
				this.dataProfLTEEnabled_A42075.Applicable = value;
			}
		}

		// Token: 0x1700580C RID: 22540
		// (get) Token: 0x0600AF73 RID: 44915 RVA: 0x00A2F1A0 File Offset: 0x00A2D3A0
		// (set) Token: 0x0600AF74 RID: 44916 RVA: 0x00A2F258 File Offset: 0x00A2D458
		public bool DataProfLTEEnabled_A42075_Valid
		{
			get
			{
				short num = (short)505675777;
				if (num != 0)
				{
				}
				num = (short)459547573;
				short num2 = num;
				num = (short)300884917;
				switch (num2 == num)
				{
				}
				num = (short)997457920;
				short num3 = num;
				num = (short)1886388224;
				if (num != 0)
				{
				}
				return this.dataProfLTEEnabled_A42075.Valid;
			}
			set
			{
				short num = (short)24675658;
				short num2 = num;
				num = (short)873694538;
				switch (num2 == num)
				{
				}
				num = (short)1937637376;
				if (num != 0)
				{
				}
				num = (short)407699456;
				short num3 = num;
				num = (short)589627393;
				if (num != 0)
				{
				}
				this.dataProfLTEEnabled_A42075.Valid = value;
			}
		}

		// Token: 0x1700580D RID: 22541
		// (get) Token: 0x0600AF75 RID: 44917 RVA: 0x00A2F30C File Offset: 0x00A2D50C
		// (set) Token: 0x0600AF76 RID: 44918 RVA: 0x00A2F3C0 File Offset: 0x00A2D5C0
		public bool DataProfLTEEnabled_A42075_Visible
		{
			get
			{
				short num = (short)1855782913;
				if (num != 0)
				{
				}
				num = (short)1332778541;
				short num2 = num;
				num = (short)1780192813;
				switch (num2 == num)
				{
				}
				num = (short)801636352;
				short num3 = num;
				num = (short)1380777984;
				if (num != 0)
				{
				}
				return this.dataProfLTEEnabled_A42075.Visible;
			}
			set
			{
				short num = (short)362574302;
				short num2 = num;
				num = (short)310014430;
				switch (num2 == num)
				{
				}
				num = (short)1675165696;
				if (num != 0)
				{
				}
				num = (short)404291584;
				short num3 = num;
				num = (short)415956993;
				if (num != 0)
				{
				}
				this.dataProfLTEEnabled_A42075.Visible = value;
			}
		}

		// Token: 0x1700580E RID: 22542
		// (get) Token: 0x0600AF77 RID: 44919 RVA: 0x00A2F47C File Offset: 0x00A2D67C
		// (set) Token: 0x0600AF78 RID: 44920 RVA: 0x00A2F530 File Offset: 0x00A2D730
		public bool DataProfLTEEnabled_A42075_Editable
		{
			get
			{
				short num = (short)1333548889;
				short num2 = num;
				num = (short)1825396569;
				switch (num2 == num)
				{
				}
				num = (short)1430126593;
				if (num != 0)
				{
				}
				num = (short)1549991936;
				short num3 = num;
				num = (short)1036779520;
				if (num != 0)
				{
				}
				return this.dataProfLTEEnabled_A42075.Editable;
			}
			set
			{
				short num = (short)949434194;
				short num2 = num;
				num = (short)2087270226;
				switch (num2 == num)
				{
				}
				num = (short)1514340353;
				if (num != 0)
				{
				}
				num = (short)1190854656;
				short num3 = num;
				num = (short)558039040;
				if (num != 0)
				{
				}
				this.dataProfLTEEnabled_A42075.Editable = value;
			}
		}

		// Token: 0x1700580F RID: 22543
		// (get) Token: 0x0600AF79 RID: 44921 RVA: 0x00A2F5E4 File Offset: 0x00A2D7E4
		internal string DataProfLTEEnabled_A42075_UILabel
		{
			get
			{
				short num = (short)490087820;
				short num2 = num;
				num = (short)1882269068;
				switch (num2 == num)
				{
				}
				num = (short)959840256;
				if (num != 0)
				{
				}
				num = (short)343932928;
				short num3 = num;
				num = (short)901316609;
				if (num != 0)
				{
				}
				return this.dataProfLTEEnabled_A42075.UIName;
			}
		}

		// Token: 0x17005810 RID: 22544
		// (get) Token: 0x0600AF7A RID: 44922 RVA: 0x00A2F698 File Offset: 0x00A2D898
		// (set) Token: 0x0600AF7B RID: 44923 RVA: 0x00A2F74C File Offset: 0x00A2D94C
		internal bool DataProfLTEEnabled_A42075_HiddenStatic
		{
			get
			{
				short num = (short)58502141;
				short num2 = num;
				num = (short)1070705661;
				switch (num2 == num)
				{
				}
				num = (short)1924661249;
				if (num != 0)
				{
				}
				num = (short)1498349568;
				short num3 = num;
				num = (short)750911488;
				if (num != 0)
				{
				}
				return this.dataProfLTEEnabled_A42075.HiddenStatic;
			}
			set
			{
				short num = (short)1816131672;
				short num2 = num;
				num = (short)295237720;
				switch (num2 == num)
				{
				}
				num = (short)1294991361;
				if (num != 0)
				{
				}
				num = (short)1033306112;
				short num3 = num;
				num = (short)1231290368;
				if (num != 0)
				{
				}
				this.dataProfLTEEnabled_A42075.HiddenStatic = value;
			}
		}

		// Token: 0x17005811 RID: 22545
		// (get) Token: 0x0600AF7C RID: 44924 RVA: 0x00A2F804 File Offset: 0x00A2DA04
		// (set) Token: 0x0600AF7D RID: 44925 RVA: 0x00A2F8B8 File Offset: 0x00A2DAB8
		internal bool DataProfLTEEnabled_A42075_HiddenDynamic
		{
			get
			{
				short num = (short)1655988949;
				short num2 = num;
				num = (short)819552981;
				switch (num2 == num)
				{
				}
				num = (short)1135345664;
				if (num != 0)
				{
				}
				num = (short)1435107328;
				short num3 = num;
				num = (short)1665007617;
				if (num != 0)
				{
				}
				return this.dataProfLTEEnabled_A42075.HiddenDynamic;
			}
			set
			{
				short num = (short)14366226;
				short num2 = num;
				num = (short)702494226;
				switch (num2 == num)
				{
				}
				num = (short)339804161;
				if (num != 0)
				{
				}
				num = (short)1541341184;
				short num3 = num;
				num = (short)1431371776;
				if (num != 0)
				{
				}
				this.dataProfLTEEnabled_A42075.HiddenDynamic = value;
			}
		}

		// Token: 0x17005812 RID: 22546
		// (get) Token: 0x0600AF7E RID: 44926 RVA: 0x00A2F970 File Offset: 0x00A2DB70
		public bool DataProfLTEEnabled_A42075_HasDiffs
		{
			get
			{
				short num = (short)2005821224;
				short num2 = num;
				num = (short)831940392;
				switch (num2 == num)
				{
				}
				num = (short)494469120;
				if (num != 0)
				{
				}
				num = (short)541523968;
				short num3 = num;
				num = (short)681246721;
				if (num != 0)
				{
				}
				return this.dataProfLTEEnabled_A42075._HasDiffs;
			}
		}

		// Token: 0x17005813 RID: 22547
		// (get) Token: 0x0600AF7F RID: 44927 RVA: 0x00A2FA28 File Offset: 0x00A2DC28
		// (set) Token: 0x0600AF80 RID: 44928 RVA: 0x00A2FADC File Offset: 0x00A2DCDC
		public int DataProfBroadbandSource_A42858Value
		{
			get
			{
				short num = (short)908394497;
				if (num != 0)
				{
				}
				num = (short)2057450072;
				short num2 = num;
				num = (short)1596273240;
				switch (num2 == num)
				{
				}
				num = (short)1047658496;
				short num3 = num;
				num = (short)239992832;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.Value;
			}
			set
			{
				short num = (short)1323218059;
				short num2 = num;
				num = (short)1850258571;
				switch (num2 == num)
				{
				}
				num = (short)652607489;
				if (num != 0)
				{
				}
				num = (short)337575936;
				short num3 = num;
				num = (short)2121007104;
				if (num != 0)
				{
				}
				this.dataProfBroadbandSource_A42858.Value = value;
			}
		}

		// Token: 0x17005814 RID: 22548
		// (get) Token: 0x0600AF81 RID: 44929 RVA: 0x00A2FB94 File Offset: 0x00A2DD94
		// (set) Token: 0x0600AF82 RID: 44930 RVA: 0x00A2FC48 File Offset: 0x00A2DE48
		public string DataProfBroadbandSource_A42858_UIValue
		{
			get
			{
				short num = (short)1432284185;
				short num2 = num;
				num = (short)289860633;
				switch (num2 == num)
				{
				}
				num = (short)1420361729;
				if (num != 0)
				{
				}
				num = (short)918880256;
				short num3 = num;
				num = (short)1336082432;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.UIValue;
			}
			set
			{
				short num = (short)162155244;
				short num2 = num;
				num = (short)478825196;
				switch (num2 == num)
				{
				}
				num = (short)1714094081;
				if (num != 0)
				{
				}
				num = (short)866058240;
				short num3 = num;
				num = (short)870121472;
				if (num != 0)
				{
				}
				this.dataProfBroadbandSource_A42858.UIValue = value;
			}
		}

		// Token: 0x17005815 RID: 22549
		// (get) Token: 0x0600AF83 RID: 44931 RVA: 0x00A2FD00 File Offset: 0x00A2DF00
		public global::AcpBusinessLayer.AcpListField DataProfBroadbandSource_A42858
		{
			get
			{
				short num = (short)754558560;
				short num2 = num;
				num = (short)293643872;
				switch (num2 == num)
				{
				}
				num = (short)1732116481;
				if (num != 0)
				{
				}
				num = (short)1145241600;
				short num3 = num;
				num = (short)108593152;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858;
			}
		}

		// Token: 0x17005816 RID: 22550
		// (get) Token: 0x0600AF84 RID: 44932 RVA: 0x00A2FDB0 File Offset: 0x00A2DFB0
		// (set) Token: 0x0600AF85 RID: 44933 RVA: 0x00A2FE60 File Offset: 0x00A2E060
		public bool DataProfBroadbandSource_A42858_Applicable
		{
			get
			{
				short num = (short)272309444;
				short num2 = num;
				num = (short)55385284;
				switch (num2 == num)
				{
				}
				num = (short)83886081;
				if (num != 0)
				{
				}
				num = (short)1832910848;
				short num3 = num;
				num = (short)504168448;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.Applicable;
			}
			set
			{
				short num = (short)1823101774;
				short num2 = num;
				num = (short)1790399310;
				switch (num2 == num)
				{
				}
				num = (short)648937473;
				if (num != 0)
				{
				}
				num = (short)1761869824;
				short num3 = num;
				num = (short)460324864;
				if (num != 0)
				{
				}
				this.dataProfBroadbandSource_A42858.Applicable = value;
			}
		}

		// Token: 0x17005817 RID: 22551
		// (get) Token: 0x0600AF86 RID: 44934 RVA: 0x00A2FF18 File Offset: 0x00A2E118
		// (set) Token: 0x0600AF87 RID: 44935 RVA: 0x00A2FFCC File Offset: 0x00A2E1CC
		public bool DataProfBroadbandSource_A42858_Valid
		{
			get
			{
				short num = (short)625768293;
				short num2 = num;
				num = (short)1071609701;
				switch (num2 == num)
				{
				}
				num = (short)1212743681;
				if (num != 0)
				{
				}
				num = (short)167641088;
				short num3 = num;
				num = (short)391774208;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.Valid;
			}
			set
			{
				short num = (short)1006988042;
				short num2 = num;
				num = (short)165702410;
				switch (num2 == num)
				{
				}
				num = (short)944832512;
				if (num != 0)
				{
				}
				num = (short)1352138752;
				short num3 = num;
				num = (short)425721857;
				if (num != 0)
				{
				}
				this.dataProfBroadbandSource_A42858.Valid = value;
			}
		}

		// Token: 0x17005818 RID: 22552
		// (get) Token: 0x0600AF88 RID: 44936 RVA: 0x00A30084 File Offset: 0x00A2E284
		// (set) Token: 0x0600AF89 RID: 44937 RVA: 0x00A30138 File Offset: 0x00A2E338
		public bool DataProfBroadbandSource_A42858_Visible
		{
			get
			{
				short num = (short)548456204;
				short num2 = num;
				num = (short)2072823564;
				switch (num2 == num)
				{
				}
				num = (short)607125505;
				if (num != 0)
				{
				}
				num = (short)1184890880;
				short num3 = num;
				num = (short)1269432320;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.Visible;
			}
			set
			{
				short num = (short)1969618945;
				if (num != 0)
				{
				}
				num = (short)1390554152;
				short num2 = num;
				num = (short)1027877928;
				switch (num2 == num)
				{
				}
				num = (short)596246528;
				short num3 = num;
				num = (short)1450049536;
				if (num != 0)
				{
				}
				this.dataProfBroadbandSource_A42858.Visible = value;
			}
		}

		// Token: 0x17005819 RID: 22553
		// (get) Token: 0x0600AF8A RID: 44938 RVA: 0x00A301EC File Offset: 0x00A2E3EC
		// (set) Token: 0x0600AF8B RID: 44939 RVA: 0x00A302A0 File Offset: 0x00A2E4A0
		public bool DataProfBroadbandSource_A42858_Editable
		{
			get
			{
				short num = (short)1870564211;
				short num2 = num;
				num = (short)1034193779;
				switch (num2 == num)
				{
				}
				num = (short)534315009;
				if (num != 0)
				{
				}
				num = (short)1627258880;
				short num3 = num;
				num = (short)902823936;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.Editable;
			}
			set
			{
				short num = (short)1868246670;
				short num2 = num;
				num = (short)18886286;
				switch (num2 == num)
				{
				}
				num = (short)749993984;
				if (num != 0)
				{
				}
				num = (short)633798656;
				short num3 = num;
				num = (short)136052737;
				if (num != 0)
				{
				}
				this.dataProfBroadbandSource_A42858.Editable = value;
			}
		}

		// Token: 0x1700581A RID: 22554
		// (get) Token: 0x0600AF8C RID: 44940 RVA: 0x00A30354 File Offset: 0x00A2E554
		internal string DataProfBroadbandSource_A42858_UILabel
		{
			get
			{
				short num = (short)861113449;
				short num2 = num;
				num = (short)400657513;
				switch (num2 == num)
				{
				}
				num = (short)782303233;
				if (num != 0)
				{
				}
				num = (short)1541406720;
				short num3 = num;
				num = (short)187957248;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.UIName;
			}
		}

		// Token: 0x1700581B RID: 22555
		// (get) Token: 0x0600AF8D RID: 44941 RVA: 0x00A30408 File Offset: 0x00A2E608
		// (set) Token: 0x0600AF8E RID: 44942 RVA: 0x00A304BC File Offset: 0x00A2E6BC
		internal bool DataProfBroadbandSource_A42858_HiddenStatic
		{
			get
			{
				short num = (short)2102744859;
				short num2 = num;
				num = (short)1195136795;
				switch (num2 == num)
				{
				}
				num = (short)1447034880;
				if (num != 0)
				{
				}
				num = (short)339476480;
				short num3 = num;
				num = (short)1482293249;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.HiddenStatic;
			}
			set
			{
				short num = (short)365845394;
				short num2 = num;
				num = (short)1807834002;
				switch (num2 == num)
				{
				}
				num = (short)117047297;
				if (num != 0)
				{
				}
				num = (short)1699217408;
				short num3 = num;
				num = (short)693895168;
				if (num != 0)
				{
				}
				this.dataProfBroadbandSource_A42858.HiddenStatic = value;
			}
		}

		// Token: 0x1700581C RID: 22556
		// (get) Token: 0x0600AF8F RID: 44943 RVA: 0x00A30574 File Offset: 0x00A2E774
		// (set) Token: 0x0600AF90 RID: 44944 RVA: 0x00A30628 File Offset: 0x00A2E828
		internal bool DataProfBroadbandSource_A42858_HiddenDynamic
		{
			get
			{
				short num = (short)1741763622;
				short num2 = num;
				num = (short)172176422;
				switch (num2 == num)
				{
				}
				num = (short)880410625;
				if (num != 0)
				{
				}
				num = (short)1838284800;
				short num3 = num;
				num = (short)984612864;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858.HiddenDynamic;
			}
			set
			{
				short num = (short)1774545628;
				short num2 = num;
				num = (short)1373858524;
				switch (num2 == num)
				{
				}
				num = (short)1121189889;
				if (num != 0)
				{
				}
				num = (short)1086062592;
				short num3 = num;
				num = (short)1074397184;
				if (num != 0)
				{
				}
				this.dataProfBroadbandSource_A42858.HiddenDynamic = value;
			}
		}

		// Token: 0x1700581D RID: 22557
		// (get) Token: 0x0600AF91 RID: 44945 RVA: 0x00A306DC File Offset: 0x00A2E8DC
		public bool DataProfBroadbandSource_A42858_HasDiffs
		{
			get
			{
				short num = (short)1827676518;
				short num2 = num;
				num = (short)1881088358;
				switch (num2 == num)
				{
				}
				num = (short)1054670849;
				if (num != 0)
				{
				}
				num = (short)1335164928;
				short num3 = num;
				num = (short)835452928;
				if (num != 0)
				{
				}
				return this.dataProfBroadbandSource_A42858._HasDiffs;
			}
		}

		// Token: 0x1700581E RID: 22558
		// (get) Token: 0x0600AF92 RID: 44946 RVA: 0x00A3078C File Offset: 0x00A2E98C
		// (set) Token: 0x0600AF93 RID: 44947 RVA: 0x00A30840 File Offset: 0x00A2EA40
		public int DataProfLTEBackupPTTGatewayPort_A43618Value
		{
			get
			{
				short num = (short)1764163585;
				if (num != 0)
				{
				}
				num = (short)45286900;
				short num2 = num;
				num = (short)1612514804;
				switch (num2 == num)
				{
				}
				num = (short)2121531392;
				short num3 = num;
				num = (short)95420416;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.Value;
			}
			set
			{
				short num = (short)1666981138;
				short num2 = num;
				num = (short)1550458130;
				switch (num2 == num)
				{
				}
				num = (short)468844545;
				if (num != 0)
				{
				}
				num = (short)1690828800;
				short num3 = num;
				num = (short)1402142720;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.Value = value;
			}
		}

		// Token: 0x1700581F RID: 22559
		// (get) Token: 0x0600AF94 RID: 44948 RVA: 0x00A308F8 File Offset: 0x00A2EAF8
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfLTEBackupPTTGatewayPort_A43618
		{
			get
			{
				short num = (short)150298518;
				short num2 = num;
				num = (short)71196566;
				switch (num2 == num)
				{
				}
				num = (short)1906114561;
				if (num != 0)
				{
				}
				num = (short)2047541248;
				short num3 = num;
				num = (short)1883635712;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618;
			}
		}

		// Token: 0x17005820 RID: 22560
		// (get) Token: 0x0600AF95 RID: 44949 RVA: 0x00A309A8 File Offset: 0x00A2EBA8
		// (set) Token: 0x0600AF96 RID: 44950 RVA: 0x00A30A5C File Offset: 0x00A2EC5C
		public string DataProfLTEBackupPTTGatewayPort_A43618_UIValue
		{
			get
			{
				short num = (short)1302007117;
				short num2 = num;
				num = (short)998182221;
				switch (num2 == num)
				{
				}
				num = (short)1255997440;
				if (num != 0)
				{
				}
				num = (short)2686976;
				short num3 = num;
				num = (short)1891500033;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.UIValue;
			}
			set
			{
				short num = (short)92482262;
				short num2 = num;
				num = (short)289614550;
				switch (num2 == num)
				{
				}
				num = (short)1361772544;
				if (num != 0)
				{
				}
				num = (short)575930368;
				short num3 = num;
				num = (short)1909456897;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.UIValue = value;
			}
		}

		// Token: 0x17005821 RID: 22561
		// (get) Token: 0x0600AF97 RID: 44951 RVA: 0x00A30B18 File Offset: 0x00A2ED18
		// (set) Token: 0x0600AF98 RID: 44952 RVA: 0x00A30BCC File Offset: 0x00A2EDCC
		internal int DataProfLTEBackupPTTGatewayPort_A43618Min
		{
			get
			{
				short num = (short)407428299;
				short num2 = num;
				num = (short)777313483;
				switch (num2 == num)
				{
				}
				num = (short)991166465;
				if (num != 0)
				{
				}
				num = (short)1327562752;
				short num3 = num;
				num = (short)1056047104;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.Min;
			}
			set
			{
				short num = (short)381515038;
				short num2 = num;
				num = (short)1485337886;
				switch (num2 == num)
				{
				}
				num = (short)897974272;
				if (num != 0)
				{
				}
				num = (short)749469696;
				short num3 = num;
				num = (short)1170341889;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.Min = value;
			}
		}

		// Token: 0x17005822 RID: 22562
		// (get) Token: 0x0600AF99 RID: 44953 RVA: 0x00A30C84 File Offset: 0x00A2EE84
		// (set) Token: 0x0600AF9A RID: 44954 RVA: 0x00A30D38 File Offset: 0x00A2EF38
		internal int DataProfLTEBackupPTTGatewayPort_A43618Max
		{
			get
			{
				short num = (short)301691523;
				short num2 = num;
				num = (short)1212641923;
				switch (num2 == num)
				{
				}
				num = (short)561250305;
				if (num != 0)
				{
				}
				num = (short)586743808;
				short num3 = num;
				num = (short)15663104;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.Max;
			}
			set
			{
				short num = (short)179584721;
				short num2 = num;
				num = (short)1406287569;
				switch (num2 == num)
				{
				}
				num = (short)682229760;
				if (num != 0)
				{
				}
				num = (short)1984823296;
				short num3 = num;
				num = (short)2075983873;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.Max = value;
			}
		}

		// Token: 0x17005823 RID: 22563
		// (get) Token: 0x0600AF9B RID: 44955 RVA: 0x00A30DF0 File Offset: 0x00A2EFF0
		// (set) Token: 0x0600AF9C RID: 44956 RVA: 0x00A30EA4 File Offset: 0x00A2F0A4
		internal int DataProfLTEBackupPTTGatewayPort_A43618Step
		{
			get
			{
				short num = (short)315297850;
				short num2 = num;
				num = (short)898699322;
				switch (num2 == num)
				{
				}
				num = (short)1225785345;
				if (num != 0)
				{
				}
				num = (short)1583611904;
				short num3 = num;
				num = (short)1047396352;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.StepSize;
			}
			set
			{
				short num = (short)1205734482;
				short num2 = num;
				num = (short)1158810706;
				switch (num2 == num)
				{
				}
				num = (short)1219821569;
				if (num != 0)
				{
				}
				num = (short)259391488;
				short num3 = num;
				num = (short)1126301696;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.StepSize = value;
			}
		}

		// Token: 0x17005824 RID: 22564
		// (get) Token: 0x0600AF9D RID: 44957 RVA: 0x00A30F5C File Offset: 0x00A2F15C
		// (set) Token: 0x0600AF9E RID: 44958 RVA: 0x00A31010 File Offset: 0x00A2F210
		public bool DataProfLTEBackupPTTGatewayPort_A43618_Applicable
		{
			get
			{
				short num = (short)1433433993;
				short num2 = num;
				num = (short)548370313;
				switch (num2 == num)
				{
				}
				num = (short)896925696;
				if (num != 0)
				{
				}
				num = (short)1932984320;
				short num3 = num;
				num = (short)2028011521;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.Applicable;
			}
			set
			{
				short num = (short)1270905365;
				short num2 = num;
				num = (short)737638933;
				switch (num2 == num)
				{
				}
				num = (short)1794703361;
				if (num != 0)
				{
				}
				num = (short)892469248;
				short num3 = num;
				num = (short)1812201472;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.Applicable = value;
			}
		}

		// Token: 0x17005825 RID: 22565
		// (get) Token: 0x0600AF9F RID: 44959 RVA: 0x00A310CC File Offset: 0x00A2F2CC
		// (set) Token: 0x0600AFA0 RID: 44960 RVA: 0x00A31180 File Offset: 0x00A2F380
		public bool DataProfLTEBackupPTTGatewayPort_A43618_Valid
		{
			get
			{
				short num = (short)2046115699;
				short num2 = num;
				num = (short)718618483;
				switch (num2 == num)
				{
				}
				num = (short)251068416;
				if (num != 0)
				{
				}
				num = (short)689111040;
				short num3 = num;
				num = (short)1473773569;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.Valid;
			}
			set
			{
				short num = (short)573803489;
				short num2 = num;
				num = (short)729320417;
				switch (num2 == num)
				{
				}
				num = (short)215678976;
				if (num != 0)
				{
				}
				num = (short)1488781312;
				short num3 = num;
				num = (short)657457153;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.Valid = value;
			}
		}

		// Token: 0x17005826 RID: 22566
		// (get) Token: 0x0600AFA1 RID: 44961 RVA: 0x00A31238 File Offset: 0x00A2F438
		// (set) Token: 0x0600AFA2 RID: 44962 RVA: 0x00A312F0 File Offset: 0x00A2F4F0
		public bool DataProfLTEBackupPTTGatewayPort_A43618_Visible
		{
			get
			{
				short num = (short)1207188421;
				short num2 = num;
				num = (short)1014315973;
				switch (num2 == num)
				{
				}
				num = (short)785973248;
				if (num != 0)
				{
				}
				num = (short)1714814976;
				short num3 = num;
				num = (short)257294337;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.Visible;
			}
			set
			{
				short num = (short)53885602;
				short num2 = num;
				num = (short)1760180898;
				switch (num2 == num)
				{
				}
				num = (short)1380188160;
				if (num != 0)
				{
				}
				num = (short)373948416;
				short num3 = num;
				num = (short)1506738177;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.Visible = value;
			}
		}

		// Token: 0x17005827 RID: 22567
		// (get) Token: 0x0600AFA3 RID: 44963 RVA: 0x00A313AC File Offset: 0x00A2F5AC
		// (set) Token: 0x0600AFA4 RID: 44964 RVA: 0x00A31460 File Offset: 0x00A2F660
		public bool DataProfLTEBackupPTTGatewayPort_A43618_Editable
		{
			get
			{
				short num = (short)1234992666;
				short num2 = num;
				num = (short)438861338;
				switch (num2 == num)
				{
				}
				num = (short)1533345793;
				if (num != 0)
				{
				}
				num = (short)810287104;
				short num3 = num;
				num = (short)1605566464;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.Editable;
			}
			set
			{
				short num = (short)1621054634;
				short num2 = num;
				num = (short)30889130;
				switch (num2 == num)
				{
				}
				num = (short)423821313;
				if (num != 0)
				{
				}
				num = (short)1340276736;
				short num3 = num;
				num = (short)301268992;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.Editable = value;
			}
		}

		// Token: 0x17005828 RID: 22568
		// (get) Token: 0x0600AFA5 RID: 44965 RVA: 0x00A31514 File Offset: 0x00A2F714
		internal string DataProfLTEBackupPTTGatewayPort_A43618_UILabel
		{
			get
			{
				short num = (short)511442157;
				short num2 = num;
				num = (short)2004548845;
				switch (num2 == num)
				{
				}
				num = (short)1167458305;
				if (num != 0)
				{
				}
				num = (short)1292828672;
				short num3 = num;
				num = (short)1348337664;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.UIName;
			}
		}

		// Token: 0x17005829 RID: 22569
		// (get) Token: 0x0600AFA6 RID: 44966 RVA: 0x00A315C8 File Offset: 0x00A2F7C8
		// (set) Token: 0x0600AFA7 RID: 44967 RVA: 0x00A3167C File Offset: 0x00A2F87C
		internal bool DataProfLTEBackupPTTGatewayPort_A43618_HiddenStatic
		{
			get
			{
				short num = (short)393019393;
				if (num != 0)
				{
				}
				num = (short)739164498;
				short num2 = num;
				num = (short)836092242;
				switch (num2 == num)
				{
				}
				num = (short)1044119552;
				short num3 = num;
				num = (short)1248198656;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.HiddenStatic;
			}
			set
			{
				short num = (short)30730385;
				short num2 = num;
				num = (short)234678417;
				switch (num2 == num)
				{
				}
				num = (short)336396289;
				if (num != 0)
				{
				}
				num = (short)878379008;
				short num3 = num;
				num = (short)2049048576;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.HiddenStatic = value;
			}
		}

		// Token: 0x1700582A RID: 22570
		// (get) Token: 0x0600AFA8 RID: 44968 RVA: 0x00A31730 File Offset: 0x00A2F930
		// (set) Token: 0x0600AFA9 RID: 44969 RVA: 0x00A317E4 File Offset: 0x00A2F9E4
		internal bool DataProfLTEBackupPTTGatewayPort_A43618_HiddenDynamic
		{
			get
			{
				short num = (short)268238849;
				if (num != 0)
				{
				}
				num = (short)1880274743;
				short num2 = num;
				num = (short)116045623;
				switch (num2 == num)
				{
				}
				num = (short)1831993344;
				short num3 = num;
				num = (short)2101739520;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618.HiddenDynamic;
			}
			set
			{
				short num = (short)1857261352;
				short num2 = num;
				num = (short)326274856;
				switch (num2 == num)
				{
				}
				num = (short)486998017;
				if (num != 0)
				{
				}
				num = (short)1351090176;
				short num3 = num;
				num = (short)1798242304;
				if (num != 0)
				{
				}
				this.dataProfLTEBackupPTTGatewayPort_A43618.HiddenDynamic = value;
			}
		}

		// Token: 0x1700582B RID: 22571
		// (get) Token: 0x0600AFAA RID: 44970 RVA: 0x00A3189C File Offset: 0x00A2FA9C
		public bool DataProfLTEBackupPTTGatewayPort_A43618_HasDiffs
		{
			get
			{
				short num = (short)890330280;
				short num2 = num;
				num = (short)950099112;
				switch (num2 == num)
				{
				}
				num = (short)1770061825;
				if (num != 0)
				{
				}
				num = (short)1025048576;
				short num3 = num;
				num = (short)519962624;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayPort_A43618._HasDiffs;
			}
		}

		// Token: 0x1700582C RID: 22572
		// (get) Token: 0x0600AFAB RID: 44971 RVA: 0x00A31950 File Offset: 0x00A2FB50
		// (set) Token: 0x0600AFAC RID: 44972 RVA: 0x00A31A08 File Offset: 0x00A2FC08
		public string DataProfLTEBackupPTTGatewayHostname_A43621Value
		{
			get
			{
				short num = (short)41900321;
				short num2 = num;
				num = (short)1634752801;
				switch (num2 == num)
				{
				}
				num = (short)1459617792;
				if (num != 0)
				{
				}
				num = (short)649396224;
				short num3 = num;
				num = (short)1223491585;
				if (num != 0)
				{
				}
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.Value;
			}
			set
			{
				short num = (short)1075710649;
				short num2 = num;
				num = (short)1116474041;
				switch (num2 == num)
				{
				}
				num = (short)1818034177;
				if (num != 0)
				{
				}
				num = (short)1850671104;
				if (num != 0)
				{
				}
				num = (short)537985024;
				short num3 = num;
				this.dataProfLTEBackupPTTGatewayHostname_A43621.Value = value;
			}
		}

		// Token: 0x1700582D RID: 22573
		// (get) Token: 0x0600AFAD RID: 44973 RVA: 0x00A31ABC File Offset: 0x00A2FCBC
		public global::AcpBusinessLayer.AcpField<string> DataProfLTEBackupPTTGatewayHostname_A43621
		{
			get
			{
				short num = (short)1704477519;
				short num2 = num;
				num = (short)983712591;
				switch (num2 == num)
				{
				}
				num = (short)337575936;
				if (num != 0)
				{
				}
				num = (short)77725697;
				if (num != 0)
				{
				}
				num = (short)1450115072;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621;
			}
		}

		// Token: 0x1700582E RID: 22574
		// (get) Token: 0x0600AFAE RID: 44974 RVA: 0x00A31B6C File Offset: 0x00A2FD6C
		// (set) Token: 0x0600AFAF RID: 44975 RVA: 0x00A31C20 File Offset: 0x00A2FE20
		public string DataProfLTEBackupPTTGatewayHostname_A43621_UIValue
		{
			get
			{
				short num = (short)392415983;
				short num2 = num;
				num = (short)1612368623;
				switch (num2 == num)
				{
				}
				num = (short)730005505;
				if (num != 0)
				{
				}
				num = (short)2046951424;
				if (num != 0)
				{
				}
				num = (short)1096679424;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.Value;
			}
			set
			{
				short num = (short)46522422;
				short num2 = num;
				num = (short)756604982;
				switch (num2 == num)
				{
				}
				num = (short)764805121;
				if (num != 0)
				{
				}
				num = (short)136708096;
				if (num != 0)
				{
				}
				num = (short)656474112;
				short num3 = num;
				this.dataProfLTEBackupPTTGatewayHostname_A43621.Value = value;
			}
		}

		// Token: 0x1700582F RID: 22575
		// (get) Token: 0x0600AFB0 RID: 44976 RVA: 0x00A31CD4 File Offset: 0x00A2FED4
		// (set) Token: 0x0600AFB1 RID: 44977 RVA: 0x00A31D90 File Offset: 0x00A2FF90
		public bool DataProfLTEBackupPTTGatewayHostname_A43621_Applicable
		{
			get
			{
				short num = (short)985123321;
				short num2 = num;
				num = (short)2118371833;
				switch (num2 == num)
				{
				}
				num = (short)1662255105;
				if (num != 0)
				{
				}
				num = (short)1848246272;
				if (num != 0)
				{
				}
				num = (short)237436928;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.Applicable;
			}
			set
			{
				short num = (short)1998454785;
				if (num != 0)
				{
				}
				num = (short)520583126;
				short num2 = num;
				num = (short)2082568150;
				switch (num2 == num)
				{
				}
				num = (short)691011584;
				if (num != 0)
				{
				}
				num = (short)1580007424;
				short num3 = num;
				this.dataProfLTEBackupPTTGatewayHostname_A43621.Applicable = value;
			}
		}

		// Token: 0x17005830 RID: 22576
		// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x00A31E44 File Offset: 0x00A30044
		// (set) Token: 0x0600AFB3 RID: 44979 RVA: 0x00A31EF8 File Offset: 0x00A300F8
		public bool DataProfLTEBackupPTTGatewayHostname_A43621_Valid
		{
			get
			{
				short num = (short)620989820;
				short num2 = num;
				num = (short)429886844;
				switch (num2 == num)
				{
				}
				num = (short)56164353;
				if (num != 0)
				{
				}
				num = (short)1217789952;
				if (num != 0)
				{
				}
				num = (short)1833304064;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.Valid;
			}
			set
			{
				short num = (short)557597039;
				short num2 = num;
				num = (short)1027621231;
				switch (num2 == num)
				{
				}
				num = (short)2020212737;
				if (num != 0)
				{
				}
				num = (short)961150976;
				if (num != 0)
				{
				}
				num = (short)739901440;
				short num3 = num;
				this.dataProfLTEBackupPTTGatewayHostname_A43621.Valid = value;
			}
		}

		// Token: 0x17005831 RID: 22577
		// (get) Token: 0x0600AFB4 RID: 44980 RVA: 0x00A31FB0 File Offset: 0x00A301B0
		// (set) Token: 0x0600AFB5 RID: 44981 RVA: 0x00A32064 File Offset: 0x00A30264
		public bool DataProfLTEBackupPTTGatewayHostname_A43621_Visible
		{
			get
			{
				short num = (short)1832661022;
				short num2 = num;
				num = (short)508768286;
				switch (num2 == num)
				{
				}
				num = (short)227540993;
				if (num != 0)
				{
				}
				num = (short)1186922496;
				if (num != 0)
				{
				}
				num = (short)1732378624;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.Visible;
			}
			set
			{
				short num = (short)968116757;
				short num2 = num;
				num = (short)443697685;
				switch (num2 == num)
				{
				}
				num = (short)298778625;
				if (num != 0)
				{
				}
				num = (short)50528256;
				if (num != 0)
				{
				}
				num = (short)1837629440;
				short num3 = num;
				this.dataProfLTEBackupPTTGatewayHostname_A43621.Visible = value;
			}
		}

		// Token: 0x17005832 RID: 22578
		// (get) Token: 0x0600AFB6 RID: 44982 RVA: 0x00A32118 File Offset: 0x00A30318
		// (set) Token: 0x0600AFB7 RID: 44983 RVA: 0x00A321CC File Offset: 0x00A303CC
		public bool DataProfLTEBackupPTTGatewayHostname_A43621_Editable
		{
			get
			{
				short num = (short)2076299970;
				short num2 = num;
				num = (short)540988098;
				switch (num2 == num)
				{
				}
				num = (short)470810624;
				if (num != 0)
				{
				}
				num = (short)2073100289;
				if (num != 0)
				{
				}
				num = (short)1918369792;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.Editable;
			}
			set
			{
				short num = (short)362719038;
				short num2 = num;
				num = (short)578987838;
				switch (num2 == num)
				{
				}
				num = (short)398721025;
				if (num != 0)
				{
				}
				num = (short)306184192;
				if (num != 0)
				{
				}
				num = (short)2119565312;
				short num3 = num;
				this.dataProfLTEBackupPTTGatewayHostname_A43621.Editable = value;
			}
		}

		// Token: 0x17005833 RID: 22579
		// (get) Token: 0x0600AFB8 RID: 44984 RVA: 0x00A32280 File Offset: 0x00A30480
		internal string DataProfLTEBackupPTTGatewayHostname_A43621_UILabel
		{
			get
			{
				short num = (short)208257347;
				short num2 = num;
				num = (short)1057603907;
				switch (num2 == num)
				{
				}
				num = (short)1727463425;
				if (num != 0)
				{
				}
				num = (short)1354170368;
				if (num != 0)
				{
				}
				num = (short)299171840;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.UIName;
			}
		}

		// Token: 0x17005834 RID: 22580
		// (get) Token: 0x0600AFB9 RID: 44985 RVA: 0x00A32334 File Offset: 0x00A30534
		// (set) Token: 0x0600AFBA RID: 44986 RVA: 0x00A323E8 File Offset: 0x00A305E8
		internal bool DataProfLTEBackupPTTGatewayHostname_A43621_HiddenStatic
		{
			get
			{
				short num = (short)707358241;
				short num2 = num;
				num = (short)432434721;
				switch (num2 == num)
				{
				}
				num = (short)1425145856;
				if (num != 0)
				{
				}
				num = (short)24182785;
				if (num != 0)
				{
				}
				num = (short)751501312;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.HiddenStatic;
			}
			set
			{
				short num = (short)1994862913;
				short num2 = num;
				num = (short)1996960065;
				switch (num2 == num)
				{
				}
				num = (short)1500774401;
				if (num != 0)
				{
				}
				num = (short)74252288;
				if (num != 0)
				{
				}
				num = (short)1428684800;
				short num3 = num;
				this.dataProfLTEBackupPTTGatewayHostname_A43621.HiddenStatic = value;
			}
		}

		// Token: 0x17005835 RID: 22581
		// (get) Token: 0x0600AFBB RID: 44987 RVA: 0x00A324A0 File Offset: 0x00A306A0
		// (set) Token: 0x0600AFBC RID: 44988 RVA: 0x00A32554 File Offset: 0x00A30754
		internal bool DataProfLTEBackupPTTGatewayHostname_A43621_HiddenDynamic
		{
			get
			{
				short num = (short)381921856;
				short num2 = num;
				num = (short)551463488;
				switch (num2 == num)
				{
				}
				num = (short)232914945;
				if (num != 0)
				{
				}
				num = (short)528809984;
				if (num != 0)
				{
				}
				num = (short)31981568;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621.HiddenDynamic;
			}
			set
			{
				short num = (short)473044093;
				short num2 = num;
				num = (short)693703805;
				switch (num2 == num)
				{
				}
				num = (short)1163132928;
				if (num != 0)
				{
				}
				num = (short)1473839105;
				if (num != 0)
				{
				}
				num = (short)799408128;
				short num3 = num;
				this.dataProfLTEBackupPTTGatewayHostname_A43621.HiddenDynamic = value;
			}
		}

		// Token: 0x17005836 RID: 22582
		// (get) Token: 0x0600AFBD RID: 44989 RVA: 0x00A32608 File Offset: 0x00A30808
		public bool DataProfLTEBackupPTTGatewayHostname_A43621_HasDiffs
		{
			get
			{
				short num = (short)536504107;
				short num2 = num;
				num = (short)1089890091;
				switch (num2 == num)
				{
				}
				num = (short)1492975616;
				if (num != 0)
				{
				}
				num = (short)317849601;
				if (num != 0)
				{
				}
				num = (short)133627904;
				short num3 = num;
				return this.dataProfLTEBackupPTTGatewayHostname_A43621._HasDiffs;
			}
		}

		// Token: 0x17005837 RID: 22583
		// (get) Token: 0x0600AFBE RID: 44990 RVA: 0x00A326BC File Offset: 0x00A308BC
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide RefDataWide
		{
			get
			{
				short num = (short)686644919;
				short num2 = num;
				num = (short)1923636919;
				switch (num2 == num)
				{
				}
				num = (short)1847066625;
				if (num != 0)
				{
				}
				num = (short)383123456;
				if (num != 0)
				{
				}
				num = (short)934936576;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			}
		}

		// Token: 0x0600AFBF RID: 44991 RVA: 0x00A3277C File Offset: 0x00A3097C
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
					goto IL_161;
				case 1:
				{
					num2 = (short)1598312323;
					short num3 = num2;
					num2 = (short)450842499;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_161;
					default:
						goto IL_E8;
					}
					break;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1023934464;
						short num4 = num2;
						num2 = (short)430768131;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)135266308;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1963458560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_161:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1117454337;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E8:
			num2 = (short)1274740737;
			if (num2 != 0)
			{
			}
			num2 = (short)833355776;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1098514434;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040053E0 RID: 21472
		private global::AcpBusinessLayer.AcpField<bool> dataProfLTEEnabled_A42075;

		// Token: 0x040053E1 RID: 21473
		private global::AcpBusinessLayer.AcpListField dataProfBroadbandSource_A42858;

		// Token: 0x040053E2 RID: 21474
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfLTEBackupPTTGatewayPort_A43618;

		// Token: 0x040053E3 RID: 21475
		private global::AcpBusinessLayer.AcpField<string> dataProfLTEBackupPTTGatewayHostname_A43621;
	}
}
