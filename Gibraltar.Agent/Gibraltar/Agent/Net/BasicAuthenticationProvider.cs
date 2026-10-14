using System;
using System.Net;

namespace Gibraltar.Agent.Net
{
	// Token: 0x02000018 RID: 24
	public sealed class BasicAuthenticationProvider : global::Gibraltar.Agent.Net.IServerAuthenticationProvider
	{
		// Token: 0x06000179 RID: 377 RVA: 0x000057F4 File Offset: 0x000039F4
		public BasicAuthenticationProvider(string userName, string password)
		{
			this.UserName = userName;
			this.Password = password;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000580C File Offset: 0x00003A0C
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00005814 File Offset: 0x00003A14
		public string UserName { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00005820 File Offset: 0x00003A20
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00005828 File Offset: 0x00003A28
		public string Password { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00005834 File Offset: 0x00003A34
		public bool IsAuthenticated
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00005838 File Offset: 0x00003A38
		public bool LogoutIsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000583C File Offset: 0x00003A3C
		public void Login(global::System.Uri entryUri, global::System.Net.WebClient client)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005840 File Offset: 0x00003A40
		public void Logout(global::System.Uri entryUri, global::System.Net.WebClient client)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005844 File Offset: 0x00003A44
		public void PreProcessRequest(global::System.Uri entryUri, global::System.Net.WebClient client, string resourceUrl, bool requestSupportsAuthentication)
		{
			client.Credentials = new global::System.Net.NetworkCredential(this.UserName, this.Password);
		}
	}
}
