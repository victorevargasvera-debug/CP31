using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x02000269 RID: 617
	internal class AutoSendConsentElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x00072E64 File Offset: 0x00071064
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x00072E78 File Offset: 0x00071078
		[global::System.Configuration.ConfigurationProperty("enabled", DefaultValue = false, IsRequired = false)]
		public bool Enabled
		{
			get
			{
				return (bool)base["enabled"];
			}
			set
			{
				base["enabled"] = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00072E8C File Offset: 0x0007108C
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00072EA0 File Offset: 0x000710A0
		[global::System.Configuration.ConfigurationProperty("consentDefault", DefaultValue = false, IsRequired = false)]
		public bool ConsentDefault
		{
			get
			{
				return (bool)base["consentDefault"];
			}
			set
			{
				base["consentDefault"] = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x00072EB4 File Offset: 0x000710B4
		// (set) Token: 0x06001F8B RID: 8075 RVA: 0x00072EC8 File Offset: 0x000710C8
		[global::System.Configuration.ConfigurationProperty("promptUserOnStartupLimit", DefaultValue = 0, IsRequired = false)]
		public int PromptUserOnStartupLimit
		{
			get
			{
				return (int)base["promptUserOnStartupLimit"];
			}
			set
			{
				base["promptUserOnStartupLimit"] = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00072EDC File Offset: 0x000710DC
		// (set) Token: 0x06001F8D RID: 8077 RVA: 0x00072EF0 File Offset: 0x000710F0
		[global::System.Configuration.ConfigurationProperty("companyName", DefaultValue = "", IsRequired = true)]
		public string CompanyName
		{
			get
			{
				return (string)base["companyName"];
			}
			set
			{
				base["companyName"] = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x00072F00 File Offset: 0x00071100
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x00072F14 File Offset: 0x00071114
		[global::System.Configuration.ConfigurationProperty("serviceName", DefaultValue = "", IsRequired = true)]
		public string ServiceName
		{
			get
			{
				return (string)base["serviceName"];
			}
			set
			{
				base["serviceName"] = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00072F24 File Offset: 0x00071124
		// (set) Token: 0x06001F91 RID: 8081 RVA: 0x00072F38 File Offset: 0x00071138
		[global::System.Configuration.ConfigurationProperty("privacyPolicyUrl", DefaultValue = "", IsRequired = true)]
		public string PrivacyPolicyUrl
		{
			get
			{
				return (string)base["privacyPolicyUrl"];
			}
			set
			{
				base["privacyPolicyUrl"] = value;
			}
		}
	}
}
