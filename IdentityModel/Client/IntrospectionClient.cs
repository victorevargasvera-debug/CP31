using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
	// Token: 0x02000045 RID: 69
	public class IntrospectionClient
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00004850 File Offset: 0x00002A50
		public IntrospectionClient(string endpoint, string clientId = "", string clientSecret = "", global::System.Net.Http.HttpMessageHandler innerHttpMessageHandler = null)
		{
			if (string.IsNullOrWhiteSpace(endpoint))
			{
				throw new global::System.ArgumentNullException("endpoint");
			}
			if (innerHttpMessageHandler == null)
			{
				innerHttpMessageHandler = new global::System.Net.Http.HttpClientHandler();
			}
			this._client = new global::System.Net.Http.HttpClient(innerHttpMessageHandler)
			{
				BaseAddress = new global::System.Uri(endpoint)
			};
			this._client.DefaultRequestHeaders.Accept.Clear();
			this._client.DefaultRequestHeaders.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			if (!string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(clientSecret))
			{
				this._client.SetBasicAuthentication(clientId, clientSecret);
				return;
			}
			if (!string.IsNullOrWhiteSpace(clientId))
			{
				this._clientId = clientId;
			}
		}

		// Token: 0x1700005D RID: 93
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000048FC File Offset: 0x00002AFC
		public global::System.TimeSpan Timeout
		{
			set
			{
				this._client.Timeout = value;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000490C File Offset: 0x00002B0C
		public async global::System.Threading.Tasks.Task<global::IdentityModel.Client.IntrospectionResponse> SendAsync(global::IdentityModel.Client.IntrospectionRequest request)
		{
			if (request == null)
			{
				throw new global::System.ArgumentNullException("request");
			}
			if (string.IsNullOrWhiteSpace(request.Token))
			{
				throw new global::System.ArgumentNullException("Token");
			}
			global::System.Collections.Generic.IDictionary<string, string> dictionary;
			if (request.Parameters == null)
			{
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
			}
			else
			{
				dictionary = request.Parameters;
			}
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
			global::System.Net.Http.HttpResponseMessage response;
			try
			{
				global::System.Net.Http.HttpResponseMessage httpResponseMessage = await this._client.PostAsync("", new global::System.Net.Http.FormUrlEncodedContent(dictionary)).ConfigureAwait(false);
				response = httpResponseMessage;
			}
			catch (global::System.Exception exception)
			{
				return new global::IdentityModel.Client.IntrospectionResponse(exception);
			}
			global::IdentityModel.Client.IntrospectionResponse result;
			if (response.IsSuccessStatusCode)
			{
				result = new global::IdentityModel.Client.IntrospectionResponse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
			}
			else
			{
				result = new global::IdentityModel.Client.IntrospectionResponse(response.StatusCode, response.ReasonPhrase);
			}
			return result;
		}

		// Token: 0x04000195 RID: 405
		private readonly global::System.Net.Http.HttpClient _client;

		// Token: 0x04000196 RID: 406
		private readonly string _clientId;
	}
}
