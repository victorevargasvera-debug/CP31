using System;
using System.Security.Cryptography.X509Certificates;

namespace CefSharp
{
	// Token: 0x02000097 RID: 151
	public sealed class SslStatus
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00006A8C File Offset: 0x00004C8C
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00006A94 File Offset: 0x00004C94
		public bool IsSecureConnection { get; private set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00006A9D File Offset: 0x00004C9D
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00006AA5 File Offset: 0x00004CA5
		public global::CefSharp.CertStatus CertStatus { get; private set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00006AAE File Offset: 0x00004CAE
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00006AB6 File Offset: 0x00004CB6
		public global::CefSharp.SslVersion SslVersion { get; private set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00006ABF File Offset: 0x00004CBF
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00006AC7 File Offset: 0x00004CC7
		public global::CefSharp.SslContentStatus ContentStatus { get; private set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00006AD0 File Offset: 0x00004CD0
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00006AD8 File Offset: 0x00004CD8
		public global::System.Security.Cryptography.X509Certificates.X509Certificate2 X509Certificate { get; private set; }

		// Token: 0x06000451 RID: 1105 RVA: 0x00006AE1 File Offset: 0x00004CE1
		public SslStatus(bool isSecureConnection, global::CefSharp.CertStatus certStatus, global::CefSharp.SslVersion sslVersion, global::CefSharp.SslContentStatus contentStatus, global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
		{
			this.IsSecureConnection = isSecureConnection;
			this.CertStatus = certStatus;
			this.SslVersion = sslVersion;
			this.ContentStatus = contentStatus;
			this.X509Certificate = certificate;
		}
	}
}
