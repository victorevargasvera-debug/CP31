using System;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.Internal;

namespace IdentityModel.Client
{
	// Token: 0x0200003B RID: 59
	public class DiscoveryCache
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000034B8 File Offset: 0x000016B8
		public DiscoveryCache(string authority)
		{
			this._client = new global::IdentityModel.Client.DiscoveryClient(authority, null);
			this._client.Policy.RequireHttps = authority.StartsWith("https://");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003514 File Offset: 0x00001714
		public DiscoveryCache(global::IdentityModel.Client.DiscoveryClient client)
		{
			this._client = client;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003544 File Offset: 0x00001744
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000354C File Offset: 0x0000174C
		public global::System.TimeSpan CacheDuration { get; set; } = global::System.TimeSpan.FromHours(24.0);

		// Token: 0x06000091 RID: 145 RVA: 0x00003558 File Offset: 0x00001758
		public global::System.Threading.Tasks.Task<global::IdentityModel.Client.DiscoveryResponse> GetAsync()
		{
			if (this._nextReload <= global::System.DateTime.UtcNow)
			{
				this.Refresh();
			}
			return this._lazyResponse.Value;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003580 File Offset: 0x00001780
		public void Refresh()
		{
			this._lazyResponse = new global::IdentityModel.Internal.AsyncLazy<global::IdentityModel.Client.DiscoveryResponse>(new global::System.Func<global::System.Threading.Tasks.Task<global::IdentityModel.Client.DiscoveryResponse>>(this.GetResponseAsync));
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000359C File Offset: 0x0000179C
		private async global::System.Threading.Tasks.Task<global::IdentityModel.Client.DiscoveryResponse> GetResponseAsync()
		{
			global::IdentityModel.Client.DiscoveryResponse result = await this._client.GetAsync(default(global::System.Threading.CancellationToken));
			this._nextReload = global::System.DateTime.UtcNow.Add(this.CacheDuration);
			return result;
		}

		// Token: 0x0400015C RID: 348
		private readonly global::IdentityModel.Client.DiscoveryClient _client;

		// Token: 0x0400015D RID: 349
		private global::System.DateTime _nextReload = global::System.DateTime.MinValue;

		// Token: 0x0400015E RID: 350
		private global::IdentityModel.Internal.AsyncLazy<global::IdentityModel.Client.DiscoveryResponse> _lazyResponse;
	}
}
