using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000097 RID: 151
	public sealed class CertificateEntry
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x0001A2E9 File Offset: 0x000184E9
		public CertificateEntry(global::Org.BouncyCastle.Tls.Crypto.TlsCertificate certificate, global::System.Collections.IDictionary extensions)
		{
			if (certificate == null)
			{
				throw new global::System.ArgumentNullException("certificate");
			}
			this.m_certificate = certificate;
			this.m_extensions = extensions;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x0001A30D File Offset: 0x0001850D
		public global::Org.BouncyCastle.Tls.Crypto.TlsCertificate Certificate
		{
			get
			{
				return this.m_certificate;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001A315 File Offset: 0x00018515
		public global::System.Collections.IDictionary Extensions
		{
			get
			{
				return this.m_extensions;
			}
		}

		// Token: 0x04000341 RID: 833
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsCertificate m_certificate;

		// Token: 0x04000342 RID: 834
		private readonly global::System.Collections.IDictionary m_extensions;
	}
}
