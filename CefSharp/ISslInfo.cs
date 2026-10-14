using System;
using System.Security.Cryptography.X509Certificates;

namespace CefSharp
{
	// Token: 0x02000081 RID: 129
	public interface ISslInfo
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600033F RID: 831
		global::CefSharp.CertStatus CertStatus { get; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000340 RID: 832
		global::System.Security.Cryptography.X509Certificates.X509Certificate2 X509Certificate { get; }
	}
}
