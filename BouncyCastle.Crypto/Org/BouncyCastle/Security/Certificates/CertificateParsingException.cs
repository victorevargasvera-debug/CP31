using System;

namespace Org.BouncyCastle.Security.Certificates
{
	// Token: 0x020001D8 RID: 472
	[global::System.Serializable]
	public class CertificateParsingException : global::Org.BouncyCastle.Security.Certificates.CertificateException
	{
		// Token: 0x06001183 RID: 4483 RVA: 0x0004DA7F File Offset: 0x0004BC7F
		public CertificateParsingException()
		{
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0004DA87 File Offset: 0x0004BC87
		public CertificateParsingException(string message) : base(message)
		{
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0004DA90 File Offset: 0x0004BC90
		public CertificateParsingException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
