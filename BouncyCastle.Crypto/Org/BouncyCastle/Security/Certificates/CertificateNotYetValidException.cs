using System;

namespace Org.BouncyCastle.Security.Certificates
{
	// Token: 0x020001D7 RID: 471
	[global::System.Serializable]
	public class CertificateNotYetValidException : global::Org.BouncyCastle.Security.Certificates.CertificateException
	{
		// Token: 0x06001180 RID: 4480 RVA: 0x0004DA64 File Offset: 0x0004BC64
		public CertificateNotYetValidException()
		{
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0004DA6C File Offset: 0x0004BC6C
		public CertificateNotYetValidException(string message) : base(message)
		{
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0004DA75 File Offset: 0x0004BC75
		public CertificateNotYetValidException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
