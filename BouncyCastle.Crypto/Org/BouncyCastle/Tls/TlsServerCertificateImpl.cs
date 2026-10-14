using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000120 RID: 288
	internal sealed class TlsServerCertificateImpl : global::Org.BouncyCastle.Tls.TlsServerCertificate
	{
		// Token: 0x06000B30 RID: 2864 RVA: 0x00029B9E File Offset: 0x00027D9E
		internal TlsServerCertificateImpl(global::Org.BouncyCastle.Tls.Certificate certificate, global::Org.BouncyCastle.Tls.CertificateStatus certificateStatus)
		{
			this.m_certificate = certificate;
			this.m_certificateStatus = certificateStatus;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00029BB4 File Offset: 0x00027DB4
		public global::Org.BouncyCastle.Tls.Certificate Certificate
		{
			get
			{
				return this.m_certificate;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00029BBC File Offset: 0x00027DBC
		public global::Org.BouncyCastle.Tls.CertificateStatus CertificateStatus
		{
			get
			{
				return this.m_certificateStatus;
			}
		}

		// Token: 0x0400073C RID: 1852
		private readonly global::Org.BouncyCastle.Tls.Certificate m_certificate;

		// Token: 0x0400073D RID: 1853
		private readonly global::Org.BouncyCastle.Tls.CertificateStatus m_certificateStatus;
	}
}
