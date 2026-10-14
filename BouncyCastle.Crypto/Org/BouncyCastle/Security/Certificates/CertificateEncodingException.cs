using System;

namespace Org.BouncyCastle.Security.Certificates
{
	// Token: 0x020001D4 RID: 468
	[global::System.Serializable]
	public class CertificateEncodingException : global::Org.BouncyCastle.Security.Certificates.CertificateException
	{
		// Token: 0x06001177 RID: 4471 RVA: 0x0004DA13 File Offset: 0x0004BC13
		public CertificateEncodingException()
		{
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0004DA1B File Offset: 0x0004BC1B
		public CertificateEncodingException(string msg) : base(msg)
		{
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0004DA24 File Offset: 0x0004BC24
		public CertificateEncodingException(string msg, global::System.Exception e) : base(msg, e)
		{
		}
	}
}
