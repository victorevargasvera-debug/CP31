using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x02000271 RID: 625
	internal class PublisherElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x000738A8 File Offset: 0x00071AA8
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x000738BC File Offset: 0x00071ABC
		[global::System.Configuration.ConfigurationProperty("productName", DefaultValue = "", IsRequired = false)]
		public string ProductName
		{
			get
			{
				return (string)base["productName"];
			}
			set
			{
				base["productName"] = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x000738CC File Offset: 0x00071ACC
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x000738E0 File Offset: 0x00071AE0
		[global::System.Configuration.ConfigurationProperty("applicationDescription", DefaultValue = "", IsRequired = false)]
		public string ApplicationDescription
		{
			get
			{
				return (string)base["applicationDescription"];
			}
			set
			{
				base["applicationDescription"] = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x000738F0 File Offset: 0x00071AF0
		// (set) Token: 0x06002018 RID: 8216 RVA: 0x00073904 File Offset: 0x00071B04
		[global::System.Configuration.ConfigurationProperty("applicationName", DefaultValue = "", IsRequired = false)]
		public string ApplicationName
		{
			get
			{
				return (string)base["applicationName"];
			}
			set
			{
				base["applicationName"] = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x00073914 File Offset: 0x00071B14
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x00073928 File Offset: 0x00071B28
		[global::System.Configuration.ConfigurationProperty("environmentName", DefaultValue = "", IsRequired = false)]
		public string EnvironmentName
		{
			get
			{
				return (string)base["environmentName"];
			}
			set
			{
				base["environmentName"] = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x00073938 File Offset: 0x00071B38
		// (set) Token: 0x0600201C RID: 8220 RVA: 0x0007394C File Offset: 0x00071B4C
		[global::System.Configuration.ConfigurationProperty("promotionLevelName", DefaultValue = "", IsRequired = false)]
		public string PromotionLevelName
		{
			get
			{
				return (string)base["promotionLevelName"];
			}
			set
			{
				base["promotionLevelName"] = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x0007395C File Offset: 0x00071B5C
		// (set) Token: 0x0600201E RID: 8222 RVA: 0x00073970 File Offset: 0x00071B70
		[global::System.Configuration.ConfigurationProperty("applicationType", DefaultValue = "Unknown", IsRequired = false)]
		public string ApplicationType
		{
			get
			{
				return (string)base["applicationType"];
			}
			set
			{
				base["applicationType"] = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x00073980 File Offset: 0x00071B80
		// (set) Token: 0x06002020 RID: 8224 RVA: 0x00073994 File Offset: 0x00071B94
		[global::System.Configuration.ConfigurationProperty("applicationVersion", DefaultValue = "", IsRequired = false)]
		public string ApplicationVersion
		{
			get
			{
				return (string)base["applicationVersion"];
			}
			set
			{
				base["applicationVersion"] = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x000739A4 File Offset: 0x00071BA4
		// (set) Token: 0x06002022 RID: 8226 RVA: 0x000739B8 File Offset: 0x00071BB8
		[global::System.Configuration.ConfigurationProperty("forceSynchronous", DefaultValue = false, IsRequired = false)]
		public bool ForceSynchronous
		{
			get
			{
				return (bool)base["forceSynchronous"];
			}
			set
			{
				base["forceSynchronous"] = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x000739CC File Offset: 0x00071BCC
		// (set) Token: 0x06002024 RID: 8228 RVA: 0x000739E0 File Offset: 0x00071BE0
		[global::System.Configuration.ConfigurationProperty("maxQueueLength", DefaultValue = 2000, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 1, MaxValue = 50000)]
		public int MaxQueueLength
		{
			get
			{
				return (int)base["maxQueueLength"];
			}
			set
			{
				base["maxQueueLength"] = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x000739F4 File Offset: 0x00071BF4
		// (set) Token: 0x06002026 RID: 8230 RVA: 0x00073A08 File Offset: 0x00071C08
		[global::System.Configuration.ConfigurationProperty("enableAnonymousMode", DefaultValue = false, IsRequired = false)]
		public bool EnableAnonymousMode
		{
			get
			{
				return (bool)base["enableAnonymousMode"];
			}
			set
			{
				base["enableAnonymousMode"] = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x00073A1C File Offset: 0x00071C1C
		// (set) Token: 0x06002028 RID: 8232 RVA: 0x00073A30 File Offset: 0x00071C30
		[global::System.Configuration.ConfigurationProperty("enableDebugMode", DefaultValue = false, IsRequired = false)]
		public bool EnableDebugMode
		{
			get
			{
				return (bool)base["enableDebugMode"];
			}
			set
			{
				base["enableDebugMode"] = value;
			}
		}
	}
}
