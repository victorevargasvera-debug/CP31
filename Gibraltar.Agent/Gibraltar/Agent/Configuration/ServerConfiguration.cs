using System;
using Gibraltar.Messaging;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000043 RID: 67
	public class ServerConfiguration
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x0000B47C File Offset: 0x0000967C
		internal ServerConfiguration(global::Gibraltar.Messaging.ServerConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000B48C File Offset: 0x0000968C
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x0000B49C File Offset: 0x0000969C
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000B4AC File Offset: 0x000096AC
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0000B4BC File Offset: 0x000096BC
		public bool AutoSendSessions
		{
			get
			{
				return this.m_WrappedConfiguration.AutoSendSessions;
			}
			set
			{
				this.m_WrappedConfiguration.AutoSendSessions = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000B4CC File Offset: 0x000096CC
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x0000B4DC File Offset: 0x000096DC
		public bool AutoSendOnError
		{
			get
			{
				return this.m_WrappedConfiguration.AutoSendOnError;
			}
			set
			{
				this.m_WrappedConfiguration.AutoSendOnError = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000B4EC File Offset: 0x000096EC
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x0000B4FC File Offset: 0x000096FC
		public bool SendAllApplications
		{
			get
			{
				return this.m_WrappedConfiguration.SendAllApplications;
			}
			set
			{
				this.m_WrappedConfiguration.SendAllApplications = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000B50C File Offset: 0x0000970C
		// (set) Token: 0x060003BA RID: 954 RVA: 0x0000B51C File Offset: 0x0000971C
		public bool PurgeSentSessions
		{
			get
			{
				return this.m_WrappedConfiguration.PurgeSentSessions;
			}
			set
			{
				this.m_WrappedConfiguration.PurgeSentSessions = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0000B52C File Offset: 0x0000972C
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0000B53C File Offset: 0x0000973C
		public string CustomerName
		{
			get
			{
				return this.m_WrappedConfiguration.CustomerName;
			}
			set
			{
				this.m_WrappedConfiguration.CustomerName = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000B54C File Offset: 0x0000974C
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000B55C File Offset: 0x0000975C
		public bool UseGibraltarService
		{
			get
			{
				return this.m_WrappedConfiguration.UseGibraltarService;
			}
			set
			{
				this.m_WrappedConfiguration.UseGibraltarService = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000B56C File Offset: 0x0000976C
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0000B57C File Offset: 0x0000977C
		public bool UseSsl
		{
			get
			{
				return this.m_WrappedConfiguration.UseSsl;
			}
			set
			{
				this.m_WrappedConfiguration.UseSsl = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000B58C File Offset: 0x0000978C
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x0000B59C File Offset: 0x0000979C
		public string Server
		{
			get
			{
				return this.m_WrappedConfiguration.Server;
			}
			set
			{
				this.m_WrappedConfiguration.Server = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000B5AC File Offset: 0x000097AC
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0000B5BC File Offset: 0x000097BC
		public int Port
		{
			get
			{
				return this.m_WrappedConfiguration.Port;
			}
			set
			{
				this.m_WrappedConfiguration.Port = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000B5CC File Offset: 0x000097CC
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0000B5DC File Offset: 0x000097DC
		public string ApplicationBaseDirectory
		{
			get
			{
				return this.m_WrappedConfiguration.ApplicationBaseDirectory;
			}
			set
			{
				this.m_WrappedConfiguration.ApplicationBaseDirectory = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000B5EC File Offset: 0x000097EC
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0000B5FC File Offset: 0x000097FC
		public string Repository
		{
			get
			{
				return this.m_WrappedConfiguration.Repository;
			}
			set
			{
				this.m_WrappedConfiguration.Repository = value;
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000B60C File Offset: 0x0000980C
		public void Validate()
		{
			this.m_WrappedConfiguration.Validate();
		}

		// Token: 0x040000CE RID: 206
		private readonly global::Gibraltar.Messaging.ServerConfiguration m_WrappedConfiguration;
	}
}
