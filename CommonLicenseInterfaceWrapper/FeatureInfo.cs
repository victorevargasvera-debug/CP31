using System;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x0200000F RID: 15
	public class FeatureInfo
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00006FA4 File Offset: 0x000051A4
		public static implicit operator global::MSI.FeatureInfo(global::CommonLicenseInterfaceWrapper.FeatureInfo parameter)
		{
			short num = (short)791175655;
			short num2 = num;
			num = (short)24928743;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2031157248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2004353024;
			if (num != 0)
			{
			}
			num = (short)1047003137;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007054 File Offset: 0x00005254
		public static implicit operator global::CommonLicenseInterfaceWrapper.FeatureInfo(global::MSI.FeatureInfo parameter)
		{
			short num = (short)2026100706;
			short num2 = num;
			num = (short)1000265698;
			switch (num2 == num)
			{
			default:
			{
				num = (short)602341376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1255342081;
			if (num != 0)
			{
			}
			num = (short)192020480;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.FeatureInfo
			{
				a = parameter
			};
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007108 File Offset: 0x00005308
		static FeatureInfo()
		{
			short num = (short)1581000088;
			short num2 = num;
			num = (short)2099520920;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1831862272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)236388352;
			if (num != 0)
			{
			}
			num = (short)2136276993;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000071B8 File Offset: 0x000053B8
		public FeatureInfo(string featureName, string featureVersion)
		{
			this.a = new global::MSI.FeatureInfo(featureName, featureVersion);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000071E4 File Offset: 0x000053E4
		public FeatureInfo()
		{
			this.a = new global::MSI.FeatureInfo();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00007210 File Offset: 0x00005410
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000072C4 File Offset: 0x000054C4
		public string featureName
		{
			get
			{
				short num = (short)1005125633;
				if (num != 0)
				{
				}
				num = (short)1339817984;
				short num2 = num;
				num = (short)1552306169;
				short num3 = num;
				num = (short)1901481977;
				switch (num3 == num)
				{
				}
				num = (short)925630464;
				if (num != 0)
				{
				}
				return this.a.featureName;
			}
			set
			{
				short num = (short)584601204;
				short num2 = num;
				num = (short)1432899188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448528384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1049952257;
				if (num != 0)
				{
				}
				num = (short)1163198464;
				if (num != 0)
				{
				}
				this.a.featureName = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00007378 File Offset: 0x00005578
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000742C File Offset: 0x0000562C
		public string featureVersion
		{
			get
			{
				short num = (short)1793279150;
				short num2 = num;
				num = (short)1500791982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113391104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)121831425;
				if (num != 0)
				{
				}
				num = (short)2039545856;
				if (num != 0)
				{
				}
				return this.a.featureVersion;
			}
			set
			{
				short num = (short)208897298;
				short num2 = num;
				num = (short)1952941330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1247674368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)574095361;
				if (num != 0)
				{
				}
				num = (short)1008730112;
				if (num != 0)
				{
				}
				this.a.featureVersion = value;
			}
		}

		// Token: 0x0400001E RID: 30
		private global::MSI.FeatureInfo a = new global::MSI.FeatureInfo();
	}
}
