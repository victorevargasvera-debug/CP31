using System;

namespace Org.BouncyCastle.Security.Certificates
{
	// Token: 0x020001D6 RID: 470
	[global::System.Serializable]
	public class CertificateExpiredException : global::Org.BouncyCastle.Security.Certificates.CertificateException
	{
		// Token: 0x0600117D RID: 4477 RVA: 0x0004DA49 File Offset: 0x0004BC49
		public CertificateExpiredException()
		{
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0004DA51 File Offset: 0x0004BC51
		public CertificateExpiredException(string message) : base(message)
		{
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0004DA5A File Offset: 0x0004BC5A
		public CertificateExpiredException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
