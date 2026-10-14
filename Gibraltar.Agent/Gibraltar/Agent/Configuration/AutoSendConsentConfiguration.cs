using System;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000040 RID: 64
	public sealed class AutoSendConsentConfiguration
	{
		// Token: 0x0600038D RID: 909 RVA: 0x0000B24C File Offset: 0x0000944C
		internal AutoSendConsentConfiguration(global::Gibraltar.Monitor.AutoSendConsentConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000B25C File Offset: 0x0000945C
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000B26C File Offset: 0x0000946C
		public bool Enabled
		{
			get
			{
				return this.m_WrappedConfiguration.Enabled;
			}
			set
			{
				this.m_WrappedConfiguration.Enabled = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000B27C File Offset: 0x0000947C
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0000B28C File Offset: 0x0000948C
		public bool ConsentDefault
		{
			get
			{
				return this.m_WrappedConfiguration.ConsentDefault;
			}
			set
			{
				this.m_WrappedConfiguration.ConsentDefault = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000B29C File Offset: 0x0000949C
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0000B2AC File Offset: 0x000094AC
		public int PromptUserOnStartupLimit
		{
			get
			{
				return this.m_WrappedConfiguration.PromptUserOnStartupLimit;
			}
			set
			{
				this.m_WrappedConfiguration.PromptUserOnStartupLimit = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0000B2BC File Offset: 0x000094BC
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0000B2CC File Offset: 0x000094CC
		public string CompanyName
		{
			get
			{
				return this.m_WrappedConfiguration.CompanyName;
			}
			set
			{
				this.m_WrappedConfiguration.CompanyName = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000B2DC File Offset: 0x000094DC
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0000B2EC File Offset: 0x000094EC
		public string PrivacyPolicyUrl
		{
			get
			{
				return this.m_WrappedConfiguration.PrivacyPolicyUrl;
			}
			set
			{
				this.m_WrappedConfiguration.PrivacyPolicyUrl = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000B2FC File Offset: 0x000094FC
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000B30C File Offset: 0x0000950C
		public string ServiceName
		{
			get
			{
				return this.m_WrappedConfiguration.ServiceName;
			}
			set
			{
				this.m_WrappedConfiguration.ServiceName = value;
			}
		}

		// Token: 0x040000CB RID: 203
		private readonly global::Gibraltar.Monitor.AutoSendConsentConfiguration m_WrappedConfiguration;
	}
}
