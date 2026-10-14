using System;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
	// Token: 0x0200005A RID: 90
	public static class TokenRevocationClientExtensions
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x00006AEC File Offset: 0x00004CEC
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenRevocationResponse> RevokeAccessTokenAsync(this global::IdentityModel.Client.TokenRevocationClient client, string token, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return client.RevokeAsync(new global::IdentityModel.Client.TokenRevocationRequest
			{
				Token = token,
				TokenTypeHint = "access_token"
			}, cancellationToken);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006B0C File Offset: 0x00004D0C
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenRevocationResponse> RevokeRefreshTokenAsync(this global::IdentityModel.Client.TokenRevocationClient client, string token, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return client.RevokeAsync(new global::IdentityModel.Client.TokenRevocationRequest
			{
				Token = token,
				TokenTypeHint = "refresh_token"
			}, cancellationToken);
		}
	}
}
