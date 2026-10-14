using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs
{
	// Token: 0x020001EF RID: 495
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ConfigurationOriginalRadioInformation
	{
		// Token: 0x0600186B RID: 6251 RVA: 0x0010835C File Offset: 0x0010655C
		public ConfigurationOriginalRadioInformation(global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary configurationViewSummary)
		{
			this.OrginalCPVersion = configurationViewSummary.OrginalCPVersion;
			this.Original_RadioSN = configurationViewSummary.Original_RadioSN;
			this.Original_FirmwareVersion = configurationViewSummary.Original_FirmwareVersion;
			this.Original_OptionsWithPCI = configurationViewSummary.Original_OptionsWithPCI;
			if (configurationViewSummary is global::Motorola.CommonCPS.Server.EntityModel.APXConfigurationViewSummary)
			{
				global::Motorola.CommonCPS.Server.EntityModel.APXConfigurationViewSummary apxconfigurationViewSummary = configurationViewSummary as global::Motorola.CommonCPS.Server.EntityModel.APXConfigurationViewSummary;
				this.OriginalModelNumber = apxconfigurationViewSummary.OriginalModelNumber;
				this.OriginalFlashCode = apxconfigurationViewSummary.OriginalFlashCode;
				this.Original_CFS = apxconfigurationViewSummary.Original_CFS;
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x001083D8 File Offset: 0x001065D8
		public ConfigurationOriginalRadioInformation(global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration)
		{
			this.OrginalCPVersion = configuration.OrginalCPVersion;
			this.Original_RadioSN = configuration.Original_RadioSN;
			this.Original_FirmwareVersion = configuration.Original_FirmwareVersion;
			this.Original_OptionsWithPCI = configuration.Original_OptionsWithPCI;
			if (configuration is global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration)
			{
				global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration apxconfiguration = configuration as global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration;
				this.OriginalModelNumber = apxconfiguration.OriginalModelNumber;
				this.OriginalFlashCode = apxconfiguration.OriginalFlashCode;
				this.Original_CFS = apxconfiguration.Original_CFS;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x00108454 File Offset: 0x00106654
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x00108504 File Offset: 0x00106704
		[global::System.Runtime.Serialization.DataMember]
		public string OrginalCPVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)543358976;
				short num2 = num;
				num = (short)1261913352;
				short num3 = num;
				num = (short)363349256;
				switch (num3 == num)
				{
				}
				num = (short)1185087488;
				if (num != 0)
				{
				}
				num = (short)1737818113;
				if (num != 0)
				{
				}
				return this.<OrginalCPVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1480458240;
				short num2 = num;
				num = (short)62722851;
				short num3 = num;
				num = (short)601428771;
				switch (num3 == num)
				{
				}
				num = (short)2008547329;
				if (num != 0)
				{
				}
				num = (short)1398472704;
				if (num != 0)
				{
				}
				this.<OrginalCPVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x001085B8 File Offset: 0x001067B8
		// (set) Token: 0x06001870 RID: 6256 RVA: 0x00108668 File Offset: 0x00106868
		[global::System.Runtime.Serialization.DataMember]
		public string Original_RadioSN
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1442840576;
				short num2 = num;
				num = (short)1856356229;
				short num3 = num;
				num = (short)10141573;
				switch (num3 == num)
				{
				}
				num = (short)1089142785;
				if (num != 0)
				{
				}
				num = (short)295370752;
				if (num != 0)
				{
				}
				return this.<Original_RadioSN>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)272826368;
				short num2 = num;
				num = (short)2124900460;
				short num3 = num;
				num = (short)667379820;
				switch (num3 == num)
				{
				}
				num = (short)1806106624;
				if (num != 0)
				{
				}
				num = (short)1356857345;
				if (num != 0)
				{
				}
				this.<Original_RadioSN>k__BackingField = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x00108718 File Offset: 0x00106918
		// (set) Token: 0x06001872 RID: 6258 RVA: 0x001087C8 File Offset: 0x001069C8
		[global::System.Runtime.Serialization.DataMember]
		public string Original_FirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1052835840;
				short num2 = num;
				num = (short)813498369;
				if (num != 0)
				{
				}
				num = (short)1699485037;
				short num3 = num;
				num = (short)1284707693;
				switch (num3 == num)
				{
				}
				num = (short)875167744;
				if (num != 0)
				{
				}
				return this.<Original_FirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)844562432;
				short num2 = num;
				num = (short)105672087;
				short num3 = num;
				num = (short)2114350487;
				switch (num3 == num)
				{
				}
				num = (short)1353515009;
				if (num != 0)
				{
				}
				num = (short)1776353280;
				if (num != 0)
				{
				}
				this.<Original_FirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0010887C File Offset: 0x00106A7C
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0010892C File Offset: 0x00106B2C
		[global::System.Runtime.Serialization.DataMember]
		public string OriginalModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)307167232;
				short num2 = num;
				num = (short)216639692;
				short num3 = num;
				num = (short)395356364;
				switch (num3 == num)
				{
				}
				num = (short)321519617;
				if (num != 0)
				{
				}
				num = (short)1253572608;
				if (num != 0)
				{
				}
				return this.<OriginalModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)693174272;
				short num2 = num;
				num = (short)1135874210;
				short num3 = num;
				num = (short)1103958178;
				switch (num3 == num)
				{
				}
				num = (short)1791492097;
				if (num != 0)
				{
				}
				num = (short)92012544;
				if (num != 0)
				{
				}
				this.<OriginalModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x001089DC File Offset: 0x00106BDC
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x00108A8C File Offset: 0x00106C8C
		[global::System.Runtime.Serialization.DataMember]
		public byte[] OriginalFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)911015936;
				short num2 = num;
				num = (short)2023985676;
				short num3 = num;
				num = (short)1672647180;
				switch (num3 == num)
				{
				}
				num = (short)1547960320;
				if (num != 0)
				{
				}
				num = (short)1383530497;
				if (num != 0)
				{
				}
				return this.<OriginalFlashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1633943552;
				short num2 = num;
				num = (short)2002574723;
				short num3 = num;
				num = (short)1551752579;
				switch (num3 == num)
				{
				}
				num = (short)965345280;
				if (num != 0)
				{
				}
				num = (short)56360961;
				if (num != 0)
				{
				}
				this.<OriginalFlashCode>k__BackingField = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x00108B40 File Offset: 0x00106D40
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x00108BF0 File Offset: 0x00106DF0
		[global::System.Runtime.Serialization.DataMember]
		public string Original_CFS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)267780096;
				short num2 = num;
				num = (short)405753559;
				short num3 = num;
				num = (short)531844823;
				switch (num3 == num)
				{
				}
				num = (short)647561217;
				if (num != 0)
				{
				}
				num = (short)1254293504;
				if (num != 0)
				{
				}
				return this.<Original_CFS>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)55181312;
				short num2 = num;
				num = (short)1810727715;
				short num3 = num;
				num = (short)591168291;
				switch (num3 == num)
				{
				}
				num = (short)635961345;
				if (num != 0)
				{
				}
				num = (short)1275789312;
				if (num != 0)
				{
				}
				this.<Original_CFS>k__BackingField = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x00108CA0 File Offset: 0x00106EA0
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x00108D50 File Offset: 0x00106F50
		[global::System.Runtime.Serialization.DataMember]
		public string Original_OptionsWithPCI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)947650560;
				short num2 = num;
				num = (short)2069011598;
				short num3 = num;
				num = (short)1041865870;
				switch (num3 == num)
				{
				}
				num = (short)1735262209;
				if (num != 0)
				{
				}
				num = (short)21495808;
				if (num != 0)
				{
				}
				return this.<Original_OptionsWithPCI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1970012160;
				short num2 = num;
				num = (short)1566144000;
				short num3 = num;
				num = (short)1480685056;
				switch (num3 == num)
				{
				}
				num = (short)94699521;
				if (num != 0)
				{
				}
				num = (short)257097728;
				if (num != 0)
				{
				}
				this.<Original_OptionsWithPCI>k__BackingField = value;
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00108E00 File Offset: 0x00107000
		public void FillOriginalMVOInformationIntoConfig(global::Motorola.CommonCPS.Server.EntityModel.Configuration result_ConfigColumn)
		{
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						if (result_ConfigColumn is global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration)
						{
							num2 = (short)610729986;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					{
						num2 = (short)1038090241;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration apxconfiguration = result_ConfigColumn as global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration;
						apxconfiguration.OriginalModelNumber = this.OriginalModelNumber;
						apxconfiguration.OriginalFlashCode = this.OriginalFlashCode;
						apxconfiguration.Original_CFS = this.Original_CFS;
						num2 = (short)287834113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				IL_1C:
				result_ConfigColumn.OrginalCPVersion = this.OrginalCPVersion;
				result_ConfigColumn.Original_RadioSN = this.Original_RadioSN;
				result_ConfigColumn.Original_FirmwareVersion = this.Original_FirmwareVersion;
				result_ConfigColumn.Original_OptionsWithPCI = this.Original_OptionsWithPCI;
				num2 = (short)911933440;
				short num3 = num2;
				num2 = (short)606668774;
				short num4 = num2;
				num2 = (short)1222838246;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1071448064;
					if (num2 != 0)
					{
					}
					num2 = (short)1865809920;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}
	}
}
