using System;
using System.Net.Http.Headers;

namespace System.Net.Http
{
	// Token: 0x02000003 RID: 3
	public static class HttpClientExtensions
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020AC File Offset: 0x000002AC
		public static void SetBasicAuthentication(this global::System.Net.Http.HttpClient client, string userName, string password)
		{
			client.DefaultRequestHeaders.Authorization = new global::System.Net.Http.BasicAuthenticationHeaderValue(userName, password);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020C0 File Offset: 0x000002C0
		public static void SetToken(this global::System.Net.Http.HttpClient client, string scheme, string token)
		{
			client.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(scheme, token);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020D4 File Offset: 0x000002D4
		public static void SetBearerToken(this global::System.Net.Http.HttpClient client, string token)
		{
			client.SetToken("Bearer", token);
		}
	}
}
