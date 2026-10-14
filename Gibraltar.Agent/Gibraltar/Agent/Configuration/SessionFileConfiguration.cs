using System;
using Gibraltar.Messaging;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000044 RID: 68
	public sealed class SessionFileConfiguration
	{
		// Token: 0x060003CA RID: 970 RVA: 0x0000B61C File Offset: 0x0000981C
		internal SessionFileConfiguration(global::Gibraltar.Messaging.FileMessengerConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000B62C File Offset: 0x0000982C
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0000B63C File Offset: 0x0000983C
		public int AutoFlushInterval
		{
			get
			{
				return this.m_WrappedConfiguration.AutoFlushInterval;
			}
			set
			{
				this.m_WrappedConfiguration.AutoFlushInterval = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000B64C File Offset: 0x0000984C
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000B65C File Offset: 0x0000985C
		public string Folder
		{
			get
			{
				return this.m_WrappedConfiguration.Folder;
			}
			set
			{
				this.m_WrappedConfiguration.Folder = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000B66C File Offset: 0x0000986C
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0000B67C File Offset: 0x0000987C
		public int IndexUpdateInterval
		{
			get
			{
				return this.m_WrappedConfiguration.IndexUpdateInterval;
			}
			set
			{
				this.m_WrappedConfiguration.IndexUpdateInterval = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0000B68C File Offset: 0x0000988C
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0000B69C File Offset: 0x0000989C
		public int MaxFileSize
		{
			get
			{
				return this.m_WrappedConfiguration.MaxFileSize;
			}
			set
			{
				this.m_WrappedConfiguration.MaxFileSize = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0000B6AC File Offset: 0x000098AC
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x0000B6BC File Offset: 0x000098BC
		public int MaxFileDuration
		{
			get
			{
				return this.m_WrappedConfiguration.MaxFileDuration;
			}
			set
			{
				this.m_WrappedConfiguration.MaxFileDuration = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0000B6CC File Offset: 0x000098CC
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0000B6DC File Offset: 0x000098DC
		public bool EnableFilePruning
		{
			get
			{
				return this.m_WrappedConfiguration.EnableFilePruning;
			}
			set
			{
				this.m_WrappedConfiguration.EnableFilePruning = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000B6EC File Offset: 0x000098EC
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0000B6FC File Offset: 0x000098FC
		public int MaxLocalDiskUsage
		{
			get
			{
				return this.m_WrappedConfiguration.MaxLocalDiskUsage;
			}
			set
			{
				this.m_WrappedConfiguration.MaxLocalDiskUsage = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000B70C File Offset: 0x0000990C
		// (set) Token: 0x060003DA RID: 986 RVA: 0x0000B71C File Offset: 0x0000991C
		public int MaxLocalFileAge
		{
			get
			{
				return this.m_WrappedConfiguration.MaxLocalFileAge;
			}
			set
			{
				this.m_WrappedConfiguration.MaxLocalFileAge = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0000B72C File Offset: 0x0000992C
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0000B73C File Offset: 0x0000993C
		public int MinimumFreeDisk
		{
			get
			{
				return this.m_WrappedConfiguration.MinimumFreeDisk;
			}
			set
			{
				this.m_WrappedConfiguration.MinimumFreeDisk = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000B74C File Offset: 0x0000994C
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000B75C File Offset: 0x0000995C
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000B76C File Offset: 0x0000996C
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0000B77C File Offset: 0x0000997C
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0000B78C File Offset: 0x0000998C
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0000B79C File Offset: 0x0000999C
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

		// Token: 0x040000CF RID: 207
		private readonly global::Gibraltar.Messaging.FileMessengerConfiguration m_WrappedConfiguration;
	}
}
