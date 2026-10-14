using System;
using System.Net.Http;
using IdentityModel.Client;

namespace IdentityModel.OidcClient.Infrastructure
{
	// Token: 0x0200002A RID: 42
	internal class TokenClientFactory
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00005A70 File Offset: 0x00003C70
		public static global::IdentityModel.Client.TokenClient Create(global::IdentityModel.OidcClient.OidcClientOptions options)
		{
			global::IdentityModel.OidcClient.ProviderInformation providerInformation = options.ProviderInformation;
			global::System.Net.Http.HttpMessageHandler innerHttpMessageHandler = options.BackchannelHandler ?? new global::System.Net.Http.HttpClientHandler();
			global::IdentityModel.Client.TokenClient tokenClient;
			if (options.ClientSecret.IsMissing())
			{
				tokenClient = new global::IdentityModel.Client.TokenClient(providerInformation.TokenEndpoint, options.ClientId, innerHttpMessageHandler);
			}
			else
			{
				tokenClient = new global::IdentityModel.Client.TokenClient(providerInformation.TokenEndpoint, options.ClientId, options.ClientSecret, innerHttpMessageHandler, options.TokenClientAuthenticationStyle);
			}
			tokenClient.Timeout = options.BackchannelTimeout;
			tokenClient.AuthenticationStyle = options.TokenClientAuthenticationStyle;
			return tokenClient;
		}
	}
}
