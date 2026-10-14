using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x02000267 RID: 615
	internal class LiveStreamElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x00072CF0 File Offset: 0x00070EF0
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x00072D04 File Offset: 0x00070F04
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

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00072D18 File Offset: 0x00070F18
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x00072D2C File Offset: 0x00070F2C
		[global::System.Configuration.ConfigurationProperty("agentPort", DefaultValue = 29971, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 1, MaxValue = 65535)]
		public int AgentPort
		{
			get
			{
				return (int)base["agentPort"];
			}
			set
			{
				base["agentPort"] = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x00072D40 File Offset: 0x00070F40
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x00072D54 File Offset: 0x00070F54
		[global::System.Configuration.ConfigurationProperty("clientPort", DefaultValue = 29970, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 1, MaxValue = 65535)]
		public int ClientPort
		{
			get
			{
				return (int)base["clientPort"];
			}
			set
			{
				base["clientPort"] = value;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00072D68 File Offset: 0x00070F68
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x00072D7C File Offset: 0x00070F7C
		[global::System.Configuration.ConfigurationProperty("useSsl", DefaultValue = false, IsRequired = false)]
		public bool UseSsl
		{
			get
			{
				return (bool)base["useSsl"];
			}
			set
			{
				base["useSsl"] = value;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x00072D90 File Offset: 0x00070F90
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x00072DA4 File Offset: 0x00070FA4
		[global::System.Configuration.ConfigurationProperty("certificateName", DefaultValue = "", IsRequired = false)]
		public string CertificateName
		{
			get
			{
				return (string)base["certificateName"];
			}
			set
			{
				base["certificateName"] = value;
			}
		}

		// Token: 0x04000BF6 RID: 3062
		public const int DefaultAgentPort = 29971;

		// Token: 0x04000BF7 RID: 3063
		public const int DefaultClientPort = 29970;
	}
}
