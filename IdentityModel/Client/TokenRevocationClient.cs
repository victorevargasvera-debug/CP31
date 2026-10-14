using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
	// Token: 0x02000058 RID: 88
	public class TokenRevocationClient
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000066B4 File Offset: 0x000048B4
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000066BC File Offset: 0x000048BC
		public global::IdentityModel.Client.AuthenticationStyle AuthenticationStyle { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000066C8 File Offset: 0x000048C8
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000066D0 File Offset: 0x000048D0
		public string ClientId { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000066DC File Offset: 0x000048DC
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000066E4 File Offset: 0x000048E4
		public string ClientSecret { get; set; }

		// Token: 0x060001A1 RID: 417 RVA: 0x000066F0 File Offset: 0x000048F0
		public TokenRevocationClient(string endpoint, string clientId = "", string clientSecret = "", global::System.Net.Http.HttpMessageHandler innerHttpMessageHandler = null)
		{
			if (endpoint == null)
			{
				throw new global::System.ArgumentNullException("endpoint");
			}
			if (innerHttpMessageHandler == null)
			{
				innerHttpMessageHandler = new global::System.Net.Http.HttpClientHandler();
			}
			this.Client = new global::System.Net.Http.HttpClient(innerHttpMessageHandler)
			{
				BaseAddress = new global::System.Uri(endpoint)
			};
			this.Client.DefaultRequestHeaders.Accept.Clear();
			this.Client.DefaultRequestHeaders.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			if (!string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(clientSecret))
			{
				this.Client.SetBasicAuthentication(clientId, clientSecret);
				return;
			}
			if (!string.IsNullOrWhiteSpace(clientId))
			{
				this._clientId = clientId;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00006798 File Offset: 0x00004998
		public global::System.TimeSpan Timeout
		{
			set
			{
				this.Client.Timeout = value;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000067A8 File Offset: 0x000049A8
		public virtual async global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenRevocationResponse> RevokeAsync(global::IdentityModel.Client.TokenRevocationRequest request, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (request == null)
			{
				throw new global::System.ArgumentNullException("request");
			}
			if (string.IsNullOrWhiteSpace(request.Token))
			{
				throw new global::System.ArgumentNullException("Token");
			}
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
			dictionary.Add("token", request.Token);
			if (!string.IsNullOrWhiteSpace(request.TokenTypeHint))
			{
				dictionary.Add("token_type_hint", request.TokenTypeHint);
			}
			if (!string.IsNullOrWhiteSpace(request.ClientId))
			{
				dictionary.Add("client_id", request.ClientId);
			}
			else if (!string.IsNullOrWhiteSpace(this._clientId))
			{
				dictionary.Add("client_id", this._clientId);
			}
			if (!string.IsNullOrWhiteSpace(request.ClientSecret))
			{
				dictionary.Add("client_secret", request.ClientSecret);
			}
			global::IdentityModel.Client.TokenRevocationResponse result;
			try
			{
				global::System.Net.Http.HttpResponseMessage httpResponseMessage = await this.Client.PostAsync("", new global::System.Net.Http.FormUrlEncodedContent(dictionary), cancellationToken).ConfigureAwait(false);
				global::System.Net.Http.HttpResponseMessage response = httpResponseMessage;
				if (response.StatusCode == global::System.Net.HttpStatusCode.OK)
				{
					result = new global::IdentityModel.Client.TokenRevocationResponse();
				}
				else if (response.StatusCode == global::System.Net.HttpStatusCode.BadRequest)
				{
					result = new global::IdentityModel.Client.TokenRevocationResponse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
				}
				else
				{
					result = new global::IdentityModel.Client.TokenRevocationResponse(response.StatusCode, response.ReasonPhrase);
				}
			}
			catch (global::System.Exception exception)
			{
				result = new global::IdentityModel.Client.TokenRevocationResponse(exception);
			}
			return result;
		}

		// Token: 0x040001FB RID: 507
		protected global::System.Net.Http.HttpClient Client;

		// Token: 0x040001FC RID: 508
		private readonly string _clientId;
	}
}
