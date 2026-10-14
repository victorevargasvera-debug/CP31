using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Motorola.Common.Cryptography.Providers
{
	// Token: 0x0200000B RID: 11
	public interface ICertificateStore
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31
		global::System.Collections.Generic.IEnumerable<global::System.Security.Cryptography.X509Certificates.X509Certificate2> AvailableCertificates { get; }
	}
}
