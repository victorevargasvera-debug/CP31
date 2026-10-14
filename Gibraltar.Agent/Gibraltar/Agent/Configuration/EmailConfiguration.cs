using System;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000041 RID: 65
	public sealed class EmailConfiguration
	{
		// Token: 0x0600039A RID: 922 RVA: 0x0000B31C File Offset: 0x0000951C
		internal EmailConfiguration(global::Gibraltar.Monitor.EmailConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000B32C File Offset: 0x0000952C
		// (set) Token: 0x0600039C RID: 924 RVA: 0x0000B33C File Offset: 0x0000953C
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

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000B34C File Offset: 0x0000954C
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000B35C File Offset: 0x0000955C
		public string User
		{
			get
			{
				return this.m_WrappedConfiguration.User;
			}
			set
			{
				this.m_WrappedConfiguration.User = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000B36C File Offset: 0x0000956C
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x0000B37C File Offset: 0x0000957C
		public string Password
		{
			get
			{
				return this.m_WrappedConfiguration.Password;
			}
			set
			{
				this.m_WrappedConfiguration.Password = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000B38C File Offset: 0x0000958C
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x0000B39C File Offset: 0x0000959C
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000B3AC File Offset: 0x000095AC
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x0000B3BC File Offset: 0x000095BC
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000B3CC File Offset: 0x000095CC
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x0000B3DC File Offset: 0x000095DC
		public int MaxMessageSize
		{
			get
			{
				return this.m_WrappedConfiguration.MaxMessageSize;
			}
			set
			{
				this.m_WrappedConfiguration.MaxMessageSize = value;
			}
		}

		// Token: 0x040000CC RID: 204
		private readonly global::Gibraltar.Monitor.EmailConfiguration m_WrappedConfiguration;
	}
}
