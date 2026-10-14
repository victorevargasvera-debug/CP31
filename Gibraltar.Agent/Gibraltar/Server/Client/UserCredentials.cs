using System;
using System.Collections.Specialized;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200012D RID: 301
	internal sealed class UserCredentials : global::Gibraltar.Server.Client.IWebAuthenticationProvider
	{
		// Token: 0x06000C3C RID: 3132 RVA: 0x0001F9FC File Offset: 0x0001DBFC
		public UserCredentials(global::System.Guid repositoryId, string userName, string password)
		{
			if (string.IsNullOrEmpty(userName))
			{
				throw new global::System.ArgumentNullException(userName);
			}
			if (string.IsNullOrEmpty(password))
			{
				throw new global::System.ArgumentNullException(password);
			}
			if (repositoryId == global::System.Guid.Empty)
			{
				throw new global::System.ArgumentOutOfRangeException("repositoryId", "The supplied repository Id is an empty Guid, which can't be right.");
			}
			this.RepositoryId = repositoryId;
			this.UserName = userName.Trim();
			this.Password = password.Trim();
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0001FA84 File Offset: 0x0001DC84
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x0001FA8C File Offset: 0x0001DC8C
		public string UserName { get; set; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0001FA98 File Offset: 0x0001DC98
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		public string Password { get; set; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x0001FAB4 File Offset: 0x0001DCB4
		public global::System.Guid RepositoryId { get; private set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0001FAC0 File Offset: 0x0001DCC0
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0001FB14 File Offset: 0x0001DD14
		bool global::Gibraltar.Server.Client.IWebAuthenticationProvider.LogoutIsSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0001FB18 File Offset: 0x0001DD18
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.Login(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				try
				{
					this.m_AccessToken = null;
					bool flag = false;
					do
					{
						global::System.Collections.Specialized.NameValueCollection nameValueCollection = new global::System.Collections.Specialized.NameValueCollection();
						nameValueCollection.Add("userName", this.UserName);
						nameValueCollection.Add("password", this.Password);
						flag = false;
						try
						{
							byte[] bytes = client.UploadValues("Login", nameValueCollection);
							this.m_AccessToken = global::System.Text.Encoding.UTF8.GetString(bytes);
						}
						catch (global::System.Net.WebException ex)
						{
							if (ex.Status == global::System.Net.WebExceptionStatus.ProtocolError && ((global::System.Net.HttpWebResponse)ex.Response).StatusCode == global::System.Net.HttpStatusCode.Unauthorized && global::Gibraltar.Server.Client.CachedCredentialsManager.UpdateCredentials(channel, this.RepositoryId, true))
							{
								flag = true;
							}
							if (!flag)
							{
								throw;
							}
						}
					}
					while (flag);
				}
				finally
				{
					global::System.Threading.Monitor.PulseAll(this.m_Lock);
				}
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0001FC1C File Offset: 0x0001DE1C
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.Logout(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_AccessToken = null;
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0001FC64 File Offset: 0x0001DE64
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.PreProcessRequest(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client, string resourceUrl, bool requestSupportsAuthentication)
		{
			if (!string.IsNullOrEmpty(client.BaseAddress))
			{
				client.BaseAddress + resourceUrl;
			}
			if (requestSupportsAuthentication)
			{
				client.Headers["Authorization"] = "Gibraltar-User-Credentials: " + this.m_AccessToken;
				client.Headers["X-Gibraltar-Repository"] = this.RepositoryId.ToString();
				return;
			}
			client.Headers.Remove("X-Gibraltar-Repository");
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
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

		// Token: 0x0400038F RID: 911
		public const string AuthorizationPrefix = "Gibraltar-User-Credentials";

		// Token: 0x04000390 RID: 912
		public const string UserNameParameter = "userName";

		// Token: 0x04000391 RID: 913
		public const string PasswordParameter = "password";

		// Token: 0x04000392 RID: 914
		private readonly object m_Lock = new object();

		// Token: 0x04000393 RID: 915
		private string m_AccessToken;
	}
}
