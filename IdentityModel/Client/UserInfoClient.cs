using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
	// Token: 0x0200005D RID: 93
	public class UserInfoClient
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00006BBC File Offset: 0x00004DBC
		public UserInfoClient(string endpoint) : this(endpoint, new global::System.Net.Http.HttpClientHandler())
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00006BCC File Offset: 0x00004DCC
		public UserInfoClient(string endpoint, global::System.Net.Http.HttpMessageHandler innerHttpMessageHandler)
		{
			if (endpoint == null)
			{
				throw new global::System.ArgumentNullException("endpoint");
			}
			if (innerHttpMessageHandler == null)
			{
				throw new global::System.ArgumentNullException("innerHttpMessageHandler");
			}
			this._client = new global::System.Net.Http.HttpClient(innerHttpMessageHandler)
			{
				BaseAddress = new global::System.Uri(endpoint)
			};
			this._client.DefaultRequestHeaders.Accept.Clear();
			this._client.DefaultRequestHeaders.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
		}

		// Token: 0x170000A7 RID: 167
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00006C48 File Offset: 0x00004E48
		public global::System.TimeSpan Timeout
		{
			set
			{
				this._client.Timeout = value;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00006C58 File Offset: 0x00004E58
		public async global::System.Threading.Tasks.Task<global::IdentityModel.Client.UserInfoResponse> GetAsync(string token, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (string.IsNullOrEmpty(token))
			{
				throw new global::System.ArgumentNullException("token");
			}
			global::System.Net.Http.HttpRequestMessage httpRequestMessage = new global::System.Net.Http.HttpRequestMessage(global::System.Net.Http.HttpMethod.Get, "");
			httpRequestMessage.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
			global::System.Net.Http.HttpResponseMessage response;
			try
			{
				global::System.Net.Http.HttpResponseMessage httpResponseMessage = await this._client.SendAsync(httpRequestMessage, cancellationToken).ConfigureAwait(false);
				response = httpResponseMessage;
			}
			catch (global::System.Exception exception)
			{
				return new global::IdentityModel.Client.UserInfoResponse(exception);
			}
			global::IdentityModel.Client.UserInfoResponse result;
			if (!response.IsSuccessStatusCode)
			{
				result = new global::IdentityModel.Client.UserInfoResponse(response.StatusCode, response.ReasonPhrase);
			}
			else
			{
				result = new global::IdentityModel.Client.UserInfoResponse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
			}
			return result;
		}

		// Token: 0x0400020C RID: 524
		private readonly global::System.Net.Http.HttpClient _client;
	}
}
