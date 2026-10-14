using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200011E RID: 286
	internal sealed class CustomerCredentials : global::Gibraltar.Server.Client.IWebAuthenticationProvider
	{
		// Token: 0x06000BBC RID: 3004 RVA: 0x0001DC50 File Offset: 0x0001BE50
		public CustomerCredentials(string sharedSecret)
		{
			if (string.IsNullOrEmpty(sharedSecret))
			{
				throw new global::System.ArgumentNullException(sharedSecret);
			}
			this.SharedSecret = sharedSecret.Trim();
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0001DC78 File Offset: 0x0001BE78
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0001DC80 File Offset: 0x0001BE80
		public string SharedSecret { get; private set; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0001DC8C File Offset: 0x0001BE8C
		public bool IsAuthenticated
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0001DC90 File Offset: 0x0001BE90
		bool global::Gibraltar.Server.Client.IWebAuthenticationProvider.LogoutIsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0001DC94 File Offset: 0x0001BE94
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.Login(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client)
		{
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0001DC98 File Offset: 0x0001BE98
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.Logout(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client)
		{
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		void global::Gibraltar.Server.Client.IWebAuthenticationProvider.PreProcessRequest(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client, string resourceUrl, bool requestSupportsAuthentication)
		{
			if (!requestSupportsAuthentication)
			{
				return;
			}
			string uriString = resourceUrl;
			if (!string.IsNullOrEmpty(client.BaseAddress))
			{
				uriString = client.BaseAddress + resourceUrl;
			}
			global::System.Uri uri = new global::System.Uri(uriString);
			client.Headers["Authorization"] = "Gibraltar-Shared: " + this.CalculateHash(uri.PathAndQuery);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0001DD04 File Offset: 0x0001BF04
		private string CalculateHash(string saltText)
		{
			byte[] bytes = new global::System.Text.UTF8Encoding().GetBytes(this.SharedSecret + saltText);
			string result;
			using (global::System.Security.Cryptography.SHA1CryptoServiceProvider sha1CryptoServiceProvider = new global::System.Security.Cryptography.SHA1CryptoServiceProvider())
			{
				result = global::System.Convert.ToBase64String(sha1CryptoServiceProvider.ComputeHash(bytes));
			}
			return result;
		}

		// Token: 0x04000353 RID: 851
		public const string AuthorizationPrefix = "Gibraltar-Shared";
	}
}
