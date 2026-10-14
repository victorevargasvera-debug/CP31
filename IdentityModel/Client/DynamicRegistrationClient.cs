using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdentityModel.Client
{
	// Token: 0x02000043 RID: 67
	public class DynamicRegistrationClient : global::System.IDisposable
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000044CC File Offset: 0x000026CC
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000044D4 File Offset: 0x000026D4
		public string Address { get; set; }

		// Token: 0x060000E1 RID: 225 RVA: 0x000044E0 File Offset: 0x000026E0
		public DynamicRegistrationClient(string address) : this(address, new global::System.Net.Http.HttpClientHandler())
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000044F0 File Offset: 0x000026F0
		public DynamicRegistrationClient(string address, global::System.Net.Http.HttpMessageHandler innerHttpMessageHandler)
		{
			if (innerHttpMessageHandler == null)
			{
				throw new global::System.ArgumentNullException("innerHttpMessageHandler");
			}
			this.Client = new global::System.Net.Http.HttpClient(innerHttpMessageHandler);
			this.Client.DefaultRequestHeaders.Accept.Clear();
			this.Client.DefaultRequestHeaders.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			if (address == null)
			{
				throw new global::System.ArgumentNullException("address");
			}
			this.Address = address;
		}

		// Token: 0x1700005C RID: 92
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00004568 File Offset: 0x00002768
		public global::System.TimeSpan Timeout
		{
			set
			{
				this.Client.Timeout = value;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004578 File Offset: 0x00002778
		public virtual async global::System.Threading.Tasks.Task<global::IdentityModel.Client.RegistrationResponse> RegisterAsync(global::IdentityModel.Client.RegistrationRequest request, string token = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Net.Http.HttpRequestMessage httpRequestMessage = new global::System.Net.Http.HttpRequestMessage(global::System.Net.Http.HttpMethod.Post, this.Address)
			{
				Content = new global::System.Net.Http.StringContent(global::Newtonsoft.Json.JsonConvert.SerializeObject(request), global::System.Text.Encoding.UTF8, "application/json")
			};
			if (!string.IsNullOrEmpty(token))
			{
				httpRequestMessage.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
			}
			global::System.Net.Http.HttpResponseMessage response;
			try
			{
				global::System.Net.Http.HttpResponseMessage httpResponseMessage = await this.Client.SendAsync(httpRequestMessage, cancellationToken).ConfigureAwait(false);
				response = httpResponseMessage;
			}
			catch (global::System.Exception exception)
			{
				return new global::IdentityModel.Client.RegistrationResponse(exception);
			}
			global::IdentityModel.Client.RegistrationResponse result;
			if (response.StatusCode == global::System.Net.HttpStatusCode.Created || response.StatusCode == global::System.Net.HttpStatusCode.BadRequest)
			{
				result = new global::IdentityModel.Client.RegistrationResponse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
			}
			else
			{
				result = new global::IdentityModel.Client.RegistrationResponse(response.StatusCode, response.ReasonPhrase);
			}
			return result;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000045D8 File Offset: 0x000027D8
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000045E8 File Offset: 0x000027E8
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this._disposed)
			{
				this._disposed = true;
				this.Client.Dispose();
			}
		}

		// Token: 0x04000189 RID: 393
		protected global::System.Net.Http.HttpClient Client;

		// Token: 0x0400018A RID: 394
		private bool _disposed;
	}
}
