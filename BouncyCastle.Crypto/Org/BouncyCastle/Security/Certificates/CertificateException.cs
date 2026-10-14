using System;

namespace Org.BouncyCastle.Security.Certificates
{
	// Token: 0x020001D5 RID: 469
	[global::System.Serializable]
	public class CertificateException : global::Org.BouncyCastle.Security.GeneralSecurityException
	{
		// Token: 0x0600117A RID: 4474 RVA: 0x0004DA2E File Offset: 0x0004BC2E
		public CertificateException()
		{
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0004DA36 File Offset: 0x0004BC36
		public CertificateException(string message) : base(message)
		{
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0004DA3F File Offset: 0x0004BC3F
		public CertificateException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
