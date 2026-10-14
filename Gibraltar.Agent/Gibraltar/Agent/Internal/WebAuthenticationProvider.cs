using System;
using System.Net;
using Gibraltar.Agent.Net;
using Gibraltar.Server.Client;

namespace Gibraltar.Agent.Internal
{
	// Token: 0x0200003A RID: 58
	internal class WebAuthenticationProvider : global::Gibraltar.Server.Client.IWebAuthenticationProvider
	{
		// Token: 0x06000348 RID: 840 RVA: 0x0000AF14 File Offset: 0x00009114
		public WebAuthenticationProvider(global::Gibraltar.Agent.Net.IServerAuthenticationProvider wrappedProvider)
		{
			this.m_WrappedProvider = wrappedProvider;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0000AF24 File Offset: 0x00009124
		public bool IsAuthenticated
		{
			get
			{
				return this.m_WrappedProvider.IsAuthenticated;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000AF34 File Offset: 0x00009134
		public bool LogoutIsSupported
		{
			get
			{
				return this.m_WrappedProvider.LogoutIsSupported;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000AF44 File Offset: 0x00009144
		public void Login(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client)
		{
			this.m_WrappedProvider.Login(channel.EntryUri, client);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000AF58 File Offset: 0x00009158
		public void Logout(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client)
		{
			if (this.m_WrappedProvider.LogoutIsSupported)
			{
				this.m_WrappedProvider.Logout(channel.EntryUri, client);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000AF7C File Offset: 0x0000917C
		public void PreProcessRequest(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client, string resourceUrl, bool requestSupportsAuthentication)
		{
			this.m_WrappedProvider.PreProcessRequest(channel.EntryUri, client, resourceUrl, requestSupportsAuthentication);
		}

		// Token: 0x040000BE RID: 190
		private readonly global::Gibraltar.Agent.Net.IServerAuthenticationProvider m_WrappedProvider;
	}
}
