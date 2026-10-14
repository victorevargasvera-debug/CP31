using System;
using System.Security.Cryptography.X509Certificates;

namespace CefSharp
{
	// Token: 0x02000014 RID: 20
	public interface ISelectClientCertificateCallback : global::System.IDisposable
	{
		// Token: 0x0600003A RID: 58
		void Select(global::System.Security.Cryptography.X509Certificates.X509Certificate2 selectedCert);

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003B RID: 59
		bool IsDisposed { get; }
	}
}
