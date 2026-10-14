using System;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000047 RID: 71
	public sealed class PublisherConfiguration
	{
		// Token: 0x06000419 RID: 1049 RVA: 0x0000BB0C File Offset: 0x00009D0C
		internal PublisherConfiguration(global::Gibraltar.Monitor.PublisherConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000BB1C File Offset: 0x00009D1C
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0000BB2C File Offset: 0x00009D2C
		public string ProductName
		{
			get
			{
				return this.m_WrappedConfiguration.ProductName;
			}
			set
			{
				this.m_WrappedConfiguration.ProductName = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0000BB3C File Offset: 0x00009D3C
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public string ApplicationDescription
		{
			get
			{
				return this.m_WrappedConfiguration.ApplicationDescription;
			}
			set
			{
				this.m_WrappedConfiguration.ApplicationDescription = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0000BB5C File Offset: 0x00009D5C
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x0000BB6C File Offset: 0x00009D6C
		public string ApplicationName
		{
			get
			{
				return this.m_WrappedConfiguration.ApplicationName;
			}
			set
			{
				this.m_WrappedConfiguration.ApplicationName = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000BB7C File Offset: 0x00009D7C
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x0000BB8C File Offset: 0x00009D8C
		public global::Gibraltar.Agent.ApplicationType ApplicationType
		{
			get
			{
				return (global::Gibraltar.Agent.ApplicationType)this.m_WrappedConfiguration.ApplicationType;
			}
			set
			{
				this.m_WrappedConfiguration.ApplicationType = (global::Loupe.Extensibility.Data.ApplicationType)value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000BB9C File Offset: 0x00009D9C
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x0000BBAC File Offset: 0x00009DAC
		public global::System.Version ApplicationVersion
		{
			get
			{
				return this.m_WrappedConfiguration.ApplicationVersion;
			}
			set
			{
				this.m_WrappedConfiguration.ApplicationVersion = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0000BBBC File Offset: 0x00009DBC
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public string EnvironmentName
		{
			get
			{
				return this.m_WrappedConfiguration.EnvironmentName;
			}
			set
			{
				this.m_WrappedConfiguration.EnvironmentName = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0000BBDC File Offset: 0x00009DDC
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x0000BBEC File Offset: 0x00009DEC
		public string PromotionLevelName
		{
			get
			{
				return this.m_WrappedConfiguration.PromotionLevelName;
			}
			set
			{
				this.m_WrappedConfiguration.PromotionLevelName = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000BBFC File Offset: 0x00009DFC
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000BC0C File Offset: 0x00009E0C
		public bool ForceSynchronous
		{
			get
			{
				return this.m_WrappedConfiguration.ForceSynchronous;
			}
			set
			{
				this.m_WrappedConfiguration.ForceSynchronous = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0000BC1C File Offset: 0x00009E1C
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x0000BC2C File Offset: 0x00009E2C
		public int MaxQueueLength
		{
			get
			{
				return this.m_WrappedConfiguration.MaxQueueLength;
			}
			set
			{
				this.m_WrappedConfiguration.MaxQueueLength = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0000BC3C File Offset: 0x00009E3C
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0000BC4C File Offset: 0x00009E4C
		public bool EnableAnonymousMode
		{
			get
			{
				return this.m_WrappedConfiguration.EnableAnonymousMode;
			}
			set
			{
				this.m_WrappedConfiguration.EnableAnonymousMode = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000BC5C File Offset: 0x00009E5C
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000BC6C File Offset: 0x00009E6C
		public bool EnableDebugMode
		{
			get
			{
				return this.m_WrappedConfiguration.EnableDebugMode;
			}
			set
			{
				this.m_WrappedConfiguration.EnableDebugMode = value;
			}
		}

		// Token: 0x040000D3 RID: 211
		private readonly global::Gibraltar.Monitor.PublisherConfiguration m_WrappedConfiguration;
	}
}
