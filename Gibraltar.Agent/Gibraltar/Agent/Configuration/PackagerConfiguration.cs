using System;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000046 RID: 70
	public sealed class PackagerConfiguration
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x0000B9DC File Offset: 0x00009BDC
		internal PackagerConfiguration(global::Gibraltar.Monitor.PackagerConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000B9EC File Offset: 0x00009BEC
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000B9FC File Offset: 0x00009BFC
		public string HotKey
		{
			get
			{
				return this.m_WrappedConfiguration.HotKey;
			}
			set
			{
				this.m_WrappedConfiguration.HotKey = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000BA0C File Offset: 0x00009C0C
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000BA1C File Offset: 0x00009C1C
		public bool AllowFile
		{
			get
			{
				return this.m_WrappedConfiguration.AllowFile;
			}
			set
			{
				this.m_WrappedConfiguration.AllowFile = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000BA2C File Offset: 0x00009C2C
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0000BA3C File Offset: 0x00009C3C
		public bool AllowRemovableMedia
		{
			get
			{
				return this.m_WrappedConfiguration.AllowRemovableMedia;
			}
			set
			{
				this.m_WrappedConfiguration.AllowRemovableMedia = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000BA4C File Offset: 0x00009C4C
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000BA5C File Offset: 0x00009C5C
		public bool AllowEmail
		{
			get
			{
				return this.m_WrappedConfiguration.AllowEmail;
			}
			set
			{
				this.m_WrappedConfiguration.AllowEmail = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000BA6C File Offset: 0x00009C6C
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0000BA7C File Offset: 0x00009C7C
		public bool AllowServer
		{
			get
			{
				return this.m_WrappedConfiguration.AllowServer;
			}
			set
			{
				this.m_WrappedConfiguration.AllowServer = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000BA8C File Offset: 0x00009C8C
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0000BA9C File Offset: 0x00009C9C
		public string FromEmailAddress
		{
			get
			{
				return this.m_WrappedConfiguration.FromEmailAddress;
			}
			set
			{
				this.m_WrappedConfiguration.FromEmailAddress = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000BAAC File Offset: 0x00009CAC
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0000BABC File Offset: 0x00009CBC
		public string DestinationEmailAddress
		{
			get
			{
				return this.m_WrappedConfiguration.DestinationEmailAddress;
			}
			set
			{
				this.m_WrappedConfiguration.DestinationEmailAddress = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0000BACC File Offset: 0x00009CCC
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0000BADC File Offset: 0x00009CDC
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0000BAEC File Offset: 0x00009CEC
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0000BAFC File Offset: 0x00009CFC
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

		// Token: 0x040000D1 RID: 209
		private readonly global::Gibraltar.Monitor.PackagerConfiguration m_WrappedConfiguration;

		// Token: 0x040000D2 RID: 210
		public const string DefaultHotKey = "Ctrl-Alt-F4";
	}
}
