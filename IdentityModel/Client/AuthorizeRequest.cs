using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace IdentityModel.Client
{
	// Token: 0x02000035 RID: 53
	public class AuthorizeRequest
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002F58 File Offset: 0x00001158
		public AuthorizeRequest(global::System.Uri authorizeEndpoint)
		{
			this._authorizeEndpoint = authorizeEndpoint;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002F68 File Offset: 0x00001168
		public AuthorizeRequest(string authorizeEndpoint)
		{
			this._authorizeEndpoint = new global::System.Uri(authorizeEndpoint);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002F7C File Offset: 0x0000117C
		public string Create(global::System.Collections.Generic.IDictionary<string, string> values)
		{
			string arg = string.Join("&", (from kvp in values
			select string.Format("{0}={1}", global::System.Net.WebUtility.UrlEncode(kvp.Key), global::System.Net.WebUtility.UrlEncode(kvp.Value))).ToArray<string>());
			if (this._authorizeEndpoint.IsAbsoluteUri)
			{
				return string.Format("{0}?{1}", this._authorizeEndpoint.AbsoluteUri, arg);
			}
			return string.Format("{0}?{1}", this._authorizeEndpoint.OriginalString, arg);
		}

		// Token: 0x04000153 RID: 339
		private readonly global::System.Uri _authorizeEndpoint;
	}
}
