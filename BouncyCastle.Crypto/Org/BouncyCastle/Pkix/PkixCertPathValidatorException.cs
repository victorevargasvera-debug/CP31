using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x0200019D RID: 413
	[global::System.Serializable]
	public class PkixCertPathValidatorException : global::Org.BouncyCastle.Security.GeneralSecurityException
	{
		// Token: 0x06000F23 RID: 3875 RVA: 0x000386B4 File Offset: 0x000368B4
		public PkixCertPathValidatorException()
		{
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x000386C3 File Offset: 0x000368C3
		public PkixCertPathValidatorException(string message) : base(message)
		{
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000386D3 File Offset: 0x000368D3
		public PkixCertPathValidatorException(string message, global::System.Exception cause) : base(message)
		{
			this.cause = cause;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000386EC File Offset: 0x000368EC
		public PkixCertPathValidatorException(string message, global::System.Exception cause, global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index) : base(message)
		{
			if (certPath == null && index != -1)
			{
				throw new global::System.ArgumentNullException("certPath = null and index != -1");
			}
			if (index < -1 || (certPath != null && index >= certPath.Certificates.Count))
			{
				throw new global::System.IndexOutOfRangeException(" index < -1 or out of bound of certPath.getCertificates()");
			}
			this.cause = cause;
			this.certPath = certPath;
			this.index = index;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00038754 File Offset: 0x00036954
		public override string Message
		{
			get
			{
				string message = base.Message;
				if (message != null)
				{
					return message;
				}
				if (this.cause != null)
				{
					return this.cause.Message;
				}
				return null;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00038782 File Offset: 0x00036982
		public global::Org.BouncyCastle.Pkix.PkixCertPath CertPath
		{
			get
			{
				return this.certPath;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x0003878A File Offset: 0x0003698A
		public int Index
		{
			get
			{
				return this.index;
			}
		}

		// Token: 0x04000857 RID: 2135
		private global::System.Exception cause;

		// Token: 0x04000858 RID: 2136
		private global::Org.BouncyCastle.Pkix.PkixCertPath certPath;

		// Token: 0x04000859 RID: 2137
		private int index = -1;
	}
}
