using System;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace IdentityModel
{
	// Token: 0x02000026 RID: 38
	public static class Principal
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002718 File Offset: 0x00000918
		public static global::System.Security.Claims.ClaimsPrincipal Anonymous
		{
			get
			{
				return new global::System.Security.Claims.ClaimsPrincipal(global::IdentityModel.Identity.Anonymous);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002724 File Offset: 0x00000924
		public static global::System.Security.Claims.ClaimsPrincipal Create(string authenticationType, params global::System.Security.Claims.Claim[] claims)
		{
			return new global::System.Security.Claims.ClaimsPrincipal(global::IdentityModel.Identity.Create(authenticationType, claims));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002734 File Offset: 0x00000934
		public static global::System.Security.Claims.ClaimsPrincipal CreateFromCertificate(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string authenticationType = "X.509", bool includeAllClaims = false)
		{
			return new global::System.Security.Claims.ClaimsPrincipal(global::IdentityModel.Identity.CreateFromCertificate(certificate, authenticationType, includeAllClaims));
		}
	}
}
