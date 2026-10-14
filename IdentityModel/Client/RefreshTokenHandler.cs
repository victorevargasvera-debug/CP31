using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
	// Token: 0x0200004A RID: 74
	public class RefreshTokenHandler : global::System.Net.Http.DelegatingHandler
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00004FC8 File Offset: 0x000031C8
		public string AccessToken
		{
			get
			{
				if (this._lock.Wait(global::IdentityModel.Client.RefreshTokenHandler.LockTimeout))
				{
					try
					{
						return this._accessToken;
					}
					finally
					{
						this._lock.Release();
					}
				}
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00005010 File Offset: 0x00003210
		public string RefreshToken
		{
			get
			{
				if (this._lock.Wait(global::IdentityModel.Client.RefreshTokenHandler.LockTimeout))
				{
					try
					{
						return this._refreshToken;
					}
					finally
					{
						this._lock.Release();
					}
				}
				return null;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005058 File Offset: 0x00003258
		public RefreshTokenHandler(string tokenEndpoint, string clientId, string clientSecret, string refreshToken, string accessToken = null, global::System.Net.Http.HttpMessageHandler innerHandler = null) : this(new global::IdentityModel.Client.TokenClient(tokenEndpoint, clientId, clientSecret, global::IdentityModel.Client.AuthenticationStyle.BasicAuthentication), refreshToken, accessToken, innerHandler)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005070 File Offset: 0x00003270
		public RefreshTokenHandler(global::IdentityModel.Client.TokenClient client, string refreshToken, string accessToken = null, global::System.Net.Http.HttpMessageHandler innerHandler = null)
		{
			this._tokenClient = client;
			this._refreshToken = refreshToken;
			this._accessToken = accessToken;
			base.InnerHandler = (innerHandler ?? new global::System.Net.Http.HttpClientHandler());
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000050AC File Offset: 0x000032AC
		protected override async global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage> SendAsync(global::System.Net.Http.HttpRequestMessage request, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Net.Http.HttpResponseMessage result;
			if (string.IsNullOrEmpty(await this.GetAccessTokenAsync(cancellationToken)) && !(await this.RefreshTokensAsync(cancellationToken)))
			{
				result = new global::System.Net.Http.HttpResponseMessage(global::System.Net.HttpStatusCode.Unauthorized);
			}
			else
			{
				request.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.AccessToken);
				global::System.Net.Http.HttpResponseMessage response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
				if (response.StatusCode != global::System.Net.HttpStatusCode.Unauthorized)
				{
					result = response;
				}
				else if (!(await this.RefreshTokensAsync(cancellationToken)))
				{
					result = response;
				}
				else
				{
					request.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.AccessToken);
					result = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
				}
			}
			return result;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005104 File Offset: 0x00003304
		protected override void Dispose(bool disposing)
		{
			if (disposing && !this._disposed)
			{
				this._disposed = true;
				this._lock.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000512C File Offset: 0x0000332C
		private async global::System.Threading.Tasks.Task<bool> RefreshTokensAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			string refreshToken = this.RefreshToken;
			bool result;
			if (string.IsNullOrEmpty(refreshToken))
			{
				result = false;
			}
			else
			{
				if (await this._lock.WaitAsync(global::IdentityModel.Client.RefreshTokenHandler.LockTimeout, cancellationToken).ConfigureAwait(false))
				{
					try
					{
						global::IdentityModel.Client.TokenResponse tokenResponse = await this._tokenClient.RequestRefreshTokenAsync(refreshToken, null, cancellationToken).ConfigureAwait(false);
						if (!tokenResponse.IsError)
						{
							this._accessToken = tokenResponse.AccessToken;
							this._refreshToken = tokenResponse.RefreshToken;
							return true;
						}
					}
					finally
					{
						this._lock.Release();
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000517C File Offset: 0x0000337C
		private async global::System.Threading.Tasks.Task<string> GetAccessTokenAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			if (await this._lock.WaitAsync(global::IdentityModel.Client.RefreshTokenHandler.LockTimeout, cancellationToken).ConfigureAwait(false))
			{
				try
				{
					return this._accessToken;
				}
				finally
				{
					this._lock.Release();
				}
			}
			return null;
		}

		// Token: 0x040001A4 RID: 420
		private static readonly global::System.TimeSpan LockTimeout = global::System.TimeSpan.FromSeconds(2.0);

		// Token: 0x040001A5 RID: 421
		private readonly global::System.Threading.SemaphoreSlim _lock = new global::System.Threading.SemaphoreSlim(1, 1);

		// Token: 0x040001A6 RID: 422
		private readonly global::IdentityModel.Client.TokenClient _tokenClient;

		// Token: 0x040001A7 RID: 423
		private string _accessToken;

		// Token: 0x040001A8 RID: 424
		private string _refreshToken;

		// Token: 0x040001A9 RID: 425
		private bool _disposed;
	}
}
