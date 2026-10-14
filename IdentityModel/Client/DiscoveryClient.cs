using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.Internal;
using IdentityModel.Jwk;

namespace IdentityModel.Client
{
	// Token: 0x0200003D RID: 61
	public class DiscoveryClient : global::System.IDisposable
	{
		// Token: 0x06000096 RID: 150 RVA: 0x000036DC File Offset: 0x000018DC
		public static async global::System.Threading.Tasks.Task<global::IdentityModel.Client.DiscoveryResponse> GetAsync(string authority)
		{
			global::IdentityModel.Client.DiscoveryResponse result;
			using (global::IdentityModel.Client.DiscoveryClient client = new global::IdentityModel.Client.DiscoveryClient(authority, null))
			{
				result = await client.GetAsync(default(global::System.Threading.CancellationToken)).ConfigureAwait(false);
			}
			return result;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003724 File Offset: 0x00001924
		[return: global::System.Runtime.CompilerServices.TupleElementNames(new string[]
		{
			"authority",
			"discoveryEndpoint"
		})]
		public static global::System.ValueTuple<string, string> ParseUrl(string input)
		{
			global::System.Uri url;
			if (!global::System.Uri.TryCreate(input, global::System.UriKind.Absolute, out url))
			{
				throw new global::System.InvalidOperationException("Malformed URL");
			}
			if (!global::IdentityModel.Internal.DiscoveryUrlHelper.IsValidScheme(url))
			{
				throw new global::System.InvalidOperationException("Malformed URL");
			}
			string text = input.RemoveTrailingSlash();
			string item;
			string item2;
			if (text.EndsWith(".well-known/openid-configuration", global::System.StringComparison.OrdinalIgnoreCase))
			{
				item = text;
				item2 = text.Substring(0, text.Length - ".well-known/openid-configuration".Length - 1);
			}
			else
			{
				item2 = text;
				item = text.EnsureTrailingSlash() + ".well-known/openid-configuration";
			}
			return new global::System.ValueTuple<string, string>(item2, item);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000037B4 File Offset: 0x000019B4
		public string Authority { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000037BC File Offset: 0x000019BC
		public string Url { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000037C4 File Offset: 0x000019C4
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000037CC File Offset: 0x000019CC
		public global::IdentityModel.Client.DiscoveryPolicy Policy { get; set; } = new global::IdentityModel.Client.DiscoveryPolicy();

		// Token: 0x17000037 RID: 55
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000037D8 File Offset: 0x000019D8
		public global::System.TimeSpan Timeout
		{
			set
			{
				this._client.Timeout = value;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000037E8 File Offset: 0x000019E8
		public DiscoveryClient(string authority, global::System.Net.Http.HttpMessageHandler innerHandler = null)
		{
			global::System.Net.Http.HttpMessageHandler handler = innerHandler ?? new global::System.Net.Http.HttpClientHandler();
			global::System.ValueTuple<string, string> valueTuple = global::IdentityModel.Client.DiscoveryClient.ParseUrl(authority);
			string item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			this.Authority = item;
			this.Url = item2;
			this._client = new global::System.Net.Http.HttpClient(handler);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003840 File Offset: 0x00001A40
		public async global::System.Threading.Tasks.Task<global::IdentityModel.Client.DiscoveryResponse> GetAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			this.Policy.Authority = this.Authority;
			string jwkUrl = "";
			global::IdentityModel.Client.DiscoveryResponse result;
			if (!global::IdentityModel.Internal.DiscoveryUrlHelper.IsSecureScheme(new global::System.Uri(this.Url), this.Policy))
			{
				result = new global::IdentityModel.Client.DiscoveryResponse(new global::System.InvalidOperationException("HTTPS required"), string.Format("Error connecting to {0}", this.Url));
			}
			else
			{
				try
				{
					global::System.Net.Http.HttpResponseMessage httpResponseMessage = await this._client.GetAsync(this.Url, cancellationToken).ConfigureAwait(false);
					if (!httpResponseMessage.IsSuccessStatusCode)
					{
						result = new global::IdentityModel.Client.DiscoveryResponse(httpResponseMessage.StatusCode, string.Format("Error connecting to {0}: {1}", this.Url, httpResponseMessage.ReasonPhrase));
					}
					else
					{
						global::IdentityModel.Client.DiscoveryResponse disco = new global::IdentityModel.Client.DiscoveryResponse(await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false), this.Policy);
						if (disco.IsError)
						{
							result = disco;
						}
						else
						{
							try
							{
								jwkUrl = disco.JwksUri;
								if (jwkUrl != null)
								{
									httpResponseMessage = await this._client.GetAsync(jwkUrl, cancellationToken).ConfigureAwait(false);
									if (!httpResponseMessage.IsSuccessStatusCode)
									{
										return new global::IdentityModel.Client.DiscoveryResponse(httpResponseMessage.StatusCode, string.Format("Error connecting to {0}: {1}", jwkUrl, httpResponseMessage.ReasonPhrase));
									}
									disco.KeySet = new global::IdentityModel.Jwk.JsonWebKeySet(await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));
								}
								result = disco;
							}
							catch (global::System.Exception exception)
							{
								result = new global::IdentityModel.Client.DiscoveryResponse(exception, string.Format("Error connecting to {0}", jwkUrl));
							}
						}
					}
				}
				catch (global::System.Exception exception2)
				{
					result = new global::IdentityModel.Client.DiscoveryResponse(exception2, string.Format("Error connecting to {0}", this.Url));
				}
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003890 File Offset: 0x00001A90
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000038A0 File Offset: 0x00001AA0
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this._disposed)
			{
				this._disposed = true;
				this._client.Dispose();
			}
		}

		// Token: 0x04000164 RID: 356
		private bool _disposed;

		// Token: 0x04000165 RID: 357
		private readonly global::System.Net.Http.HttpClient _client;
	}
}
