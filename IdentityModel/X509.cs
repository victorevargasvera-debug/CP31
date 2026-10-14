using System;
using System.Security.Cryptography.X509Certificates;

namespace IdentityModel
{
	// Token: 0x02000028 RID: 40
	public static class X509
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000027B8 File Offset: 0x000009B8
		public static global::IdentityModel.X509CertificatesLocation CurrentUser
		{
			get
			{
				return new global::IdentityModel.X509CertificatesLocation(global::System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000027C0 File Offset: 0x000009C0
		public static global::IdentityModel.X509CertificatesLocation LocalMachine
		{
			get
			{
				return new global::IdentityModel.X509CertificatesLocation(global::System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
			}
		}
	}
}
