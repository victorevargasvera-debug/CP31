using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
	// Token: 0x02000052 RID: 82
	public class TokenClient : global::System.IDisposable
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00005D50 File Offset: 0x00003F50
		public TokenClient(string address) : this(address, new global::System.Net.Http.HttpClientHandler())
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005D60 File Offset: 0x00003F60
		public TokenClient(string address, global::System.Net.Http.HttpMessageHandler innerHttpMessageHandler)
		{
			if (innerHttpMessageHandler == null)
			{
				throw new global::System.ArgumentNullException("innerHttpMessageHandler");
			}
			this.Client = new global::System.Net.Http.HttpClient(innerHttpMessageHandler);
			this.Client.DefaultRequestHeaders.Accept.Clear();
			this.Client.DefaultRequestHeaders.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			this.AuthenticationStyle = global::IdentityModel.Client.AuthenticationStyle.Custom;
			if (address == null)
			{
				throw new global::System.ArgumentNullException("address");
			}
			this.Address = address;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00005DE0 File Offset: 0x00003FE0
		public TokenClient(string address, string clientId, global::IdentityModel.Client.AuthenticationStyle style = global::IdentityModel.Client.AuthenticationStyle.PostValues) : this(address, clientId, string.Empty, new global::System.Net.Http.HttpClientHandler(), style)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public TokenClient(string address, string clientId, string clientSecret, global::IdentityModel.Client.AuthenticationStyle style = global::IdentityModel.Client.AuthenticationStyle.BasicAuthentication) : this(address, clientId, clientSecret, new global::System.Net.Http.HttpClientHandler(), style)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00005E0C File Offset: 0x0000400C
		public TokenClient(string address, string clientId, global::System.Net.Http.HttpMessageHandler innerHttpMessageHandler) : this(address, clientId, string.Empty, innerHttpMessageHandler, global::IdentityModel.Client.AuthenticationStyle.PostValues)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005E20 File Offset: 0x00004020
		public TokenClient(string address, string clientId, string clientSecret, global::System.Net.Http.HttpMessageHandler innerHttpMessageHandler, global::IdentityModel.Client.AuthenticationStyle style = global::IdentityModel.Client.AuthenticationStyle.BasicAuthentication) : this(address, innerHttpMessageHandler)
		{
			if (string.IsNullOrEmpty(clientId))
			{
				throw new global::System.ArgumentNullException("clientId");
			}
			this.AuthenticationStyle = style;
			this.ClientId = clientId;
			this.ClientSecret = clientSecret;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00005E54 File Offset: 0x00004054
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00005E5C File Offset: 0x0000405C
		public string ClientId { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00005E68 File Offset: 0x00004068
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00005E70 File Offset: 0x00004070
		public string ClientSecret { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00005E7C File Offset: 0x0000407C
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00005E84 File Offset: 0x00004084
		public string Address { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00005E90 File Offset: 0x00004090
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00005E98 File Offset: 0x00004098
		public global::IdentityModel.Client.AuthenticationStyle AuthenticationStyle { get; set; }

		// Token: 0x17000098 RID: 152
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00005EA4 File Offset: 0x000040A4
		public global::System.TimeSpan Timeout
		{
			set
			{
				this.Client.Timeout = value;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005EB4 File Offset: 0x000040B4
		public virtual async global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestAsync(global::System.Collections.Generic.IDictionary<string, string> form, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Net.Http.HttpRequestMessage httpRequestMessage = new global::System.Net.Http.HttpRequestMessage(global::System.Net.Http.HttpMethod.Post, this.Address);
			httpRequestMessage.Content = new global::System.Net.Http.FormUrlEncodedContent(form);
			if (this.AuthenticationStyle == global::IdentityModel.Client.AuthenticationStyle.BasicAuthentication)
			{
				httpRequestMessage.Headers.Authorization = new global::System.Net.Http.BasicAuthenticationHeaderValue(this.ClientId, this.ClientSecret);
			}
			global::System.Net.Http.HttpResponseMessage response;
			try
			{
				global::System.Net.Http.HttpResponseMessage httpResponseMessage = await this.Client.SendAsync(httpRequestMessage, cancellationToken).ConfigureAwait(false);
				response = httpResponseMessage;
			}
			catch (global::System.Exception exception)
			{
				return new global::IdentityModel.Client.TokenResponse(exception);
			}
			global::IdentityModel.Client.TokenResponse result;
			if (response.StatusCode == global::System.Net.HttpStatusCode.OK || response.StatusCode == global::System.Net.HttpStatusCode.BadRequest)
			{
				result = new global::IdentityModel.Client.TokenResponse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
			}
			else
			{
				result = new global::IdentityModel.Client.TokenResponse(response.StatusCode, response.ReasonPhrase);
			}
			return result;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00005F0C File Offset: 0x0000410C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00005F1C File Offset: 0x0000411C
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this._disposed)
			{
				this._disposed = true;
				this.Client.Dispose();
			}
		}

		// Token: 0x040001E9 RID: 489
		protected global::System.Net.Http.HttpClient Client;

		// Token: 0x040001EA RID: 490
		private bool _disposed;
	}
}
