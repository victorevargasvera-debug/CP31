using System;
using Gibraltar.Messaging;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000042 RID: 66
	public class NetworkViewerConfiguration
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x0000B3EC File Offset: 0x000095EC
		internal NetworkViewerConfiguration(global::Gibraltar.Messaging.NetworkMessengerConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000B3FC File Offset: 0x000095FC
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0000B40C File Offset: 0x0000960C
		public bool AllowLocalClients
		{
			get
			{
				return this.m_WrappedConfiguration.AllowLocalClients;
			}
			set
			{
				this.m_WrappedConfiguration.AllowLocalClients = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000B41C File Offset: 0x0000961C
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0000B42C File Offset: 0x0000962C
		public bool AllowRemoteClients
		{
			get
			{
				return this.m_WrappedConfiguration.AllowRemoteClients;
			}
			set
			{
				this.m_WrappedConfiguration.AllowRemoteClients = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000B43C File Offset: 0x0000963C
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0000B44C File Offset: 0x0000964C
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000B45C File Offset: 0x0000965C
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0000B46C File Offset: 0x0000966C
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

		// Token: 0x040000CD RID: 205
		private readonly global::Gibraltar.Messaging.NetworkMessengerConfiguration m_WrappedConfiguration;
	}
}
