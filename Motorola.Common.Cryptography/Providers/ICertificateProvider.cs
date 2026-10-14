using System;
using System.Security.Cryptography.X509Certificates;

namespace Motorola.Common.Cryptography.Providers
{
	// Token: 0x0200000C RID: 12
	public interface ICertificateProvider
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32
		global::System.Security.Cryptography.X509Certificates.X509Certificate2 SelectedCertificate { get; }
	}
}
