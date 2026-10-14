using System;
using System.Net.Http.Headers;
using System.Text;

namespace System.Net.Http
{
	// Token: 0x02000002 RID: 2
	public class BasicAuthenticationHeaderValue : global::System.Net.Http.Headers.AuthenticationHeaderValue
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public BasicAuthenticationHeaderValue(string userName, string password) : base("Basic", global::System.Net.Http.BasicAuthenticationHeaderValue.EncodeCredential(userName, password))
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		private static string EncodeCredential(string userName, string password)
		{
			if (string.IsNullOrWhiteSpace(userName))
			{
				throw new global::System.ArgumentNullException("userName");
			}
			if (password == null)
			{
				password = "";
			}
			global::System.Text.Encoding utf = global::System.Text.Encoding.UTF8;
			string s = string.Format("{0}:{1}", userName, password);
			return global::System.Convert.ToBase64String(utf.GetBytes(s));
		}
	}
}
