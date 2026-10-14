using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200012C RID: 300
	internal sealed class RepositoryCredentials : global::Gibraltar.Server.Client.IWebAuthenticationProvider
	{
		// Token: 0x06000C2F RID: 3119 RVA: 0x0001F734 File Offset: 0x0001D934
		public RepositoryCredentials(global::System.Guid repositoryId, string keyContainerName, bool useMachineStore)
		{
			if (repositoryId == global::System.Guid.Empty)
			{
				throw new global::System.ArgumentOutOfRangeException("repositoryId", "The supplied repository Id is an empty guid, which can't be right.");
			}
			this.RepositoryId = repositoryId;
			this.KeyContainerName = keyContainerName;
			this.UseMachineStore = useMachineStore;
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0001F78C File Offset: 0x0001D98C
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x0001F794 File Offset: 0x0001D994
		public bool UseMachineStore { get; private set; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
		public string KeyContainerName { get; private set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0001F7B4 File Offset: 0x0001D9B4
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x0001F7BC File Offset: 0x0001D9BC
		public global::System.Guid RepositoryId { get; private set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0001F7C8 File Offset: 0x0001D9C8
		public bool IsAuthenticated
		{
			get
			{
				bool result = false;
				object @lock = this.m_Lock;
				lock (@lock)
				{
					result = !string.IsNullOrEmpty(this.m_AccessToken);
					global::System.Threading.Monitor.PulseAll(this.m_Lock);
				}
				return result;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0001F81C File Offset: 0x0001DA1C
		bool global::Gibraltar.Server.Client.IWebAuthenticationProvider.LogoutIsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0001F820 File Offset: 0x0001DA20
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.Login(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				string address = string.Format("Repositories/{0}/AccessToken.bin", this.RepositoryId);
				string accessToken = client.DownloadString(address);
				this.m_AccessToken = accessToken;
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0001F888 File Offset: 0x0001DA88
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.Logout(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_AccessToken = null;
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.PreProcessRequest(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client, string resourceUrl, bool requestSupportsAuthentication)
		{
			string uriString = resourceUrl;
			if (!string.IsNullOrEmpty(client.BaseAddress))
			{
				uriString = client.BaseAddress + resourceUrl;
			}
			global::System.Uri uri = new global::System.Uri(uriString);
			if (requestSupportsAuthentication)
			{
				client.Headers["Authorization"] = "Gibraltar-Repository: " + this.CalculateHash(uri.PathAndQuery);
				client.Headers["X-Gibraltar-Repository"] = this.RepositoryId.ToString();
				return;
			}
			client.Headers.Remove("X-Gibraltar-Repository");
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0001F96C File Offset: 0x0001DB6C
		private string CalculateHash(string saltText)
		{
			global::System.Text.UTF8Encoding utf8Encoding = new global::System.Text.UTF8Encoding();
			object @lock = this.m_Lock;
			byte[] bytes;
			lock (@lock)
			{
				bytes = utf8Encoding.GetBytes(this.m_AccessToken + saltText);
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
			string result;
			using (global::System.Security.Cryptography.SHA1CryptoServiceProvider sha1CryptoServiceProvider = new global::System.Security.Cryptography.SHA1CryptoServiceProvider())
			{
				result = global::System.Convert.ToBase64String(sha1CryptoServiceProvider.ComputeHash(bytes));
			}
			return result;
		}

		// Token: 0x04000387 RID: 903
		public const string AuthorizationPrefix = "Gibraltar-Repository";

		// Token: 0x04000388 RID: 904
		public const string ClientRepositoryHeader = "X-Gibraltar-Repository";

		// Token: 0x04000389 RID: 905
		internal const string AuthorizationHeader = "Authorization";

		// Token: 0x0400038A RID: 906
		private readonly object m_Lock = new object();

		// Token: 0x0400038B RID: 907
		private string m_AccessToken;
	}
}
