using System;
using System.Net;

namespace IdentityModel.Client
{
	// Token: 0x02000057 RID: 87
	public class TokenResponse : global::IdentityModel.Client.Response
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00006614 File Offset: 0x00004814
		public TokenResponse(string raw) : base(raw)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006620 File Offset: 0x00004820
		public TokenResponse(global::System.Exception exception) : base(exception)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000662C File Offset: 0x0000482C
		public TokenResponse(global::System.Net.HttpStatusCode statusCode, string reason) : base(statusCode, reason)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00006638 File Offset: 0x00004838
		public string AccessToken
		{
			get
			{
				return base.TryGet("access_token");
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00006648 File Offset: 0x00004848
		public string IdentityToken
		{
			get
			{
				return base.TryGet("id_token");
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00006658 File Offset: 0x00004858
		public string TokenType
		{
			get
			{
				return base.TryGet("token_type");
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00006668 File Offset: 0x00004868
		public string RefreshToken
		{
			get
			{
				return base.TryGet("refresh_token");
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00006678 File Offset: 0x00004878
		public string ErrorDescription
		{
			get
			{
				return base.TryGet("error_description");
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00006688 File Offset: 0x00004888
		public long ExpiresIn
		{
			get
			{
				string text = base.TryGet("expires_in");
				long result;
				if (text != null && long.TryParse(text, out result))
				{
					return result;
				}
				return 0L;
			}
		}
	}
}
