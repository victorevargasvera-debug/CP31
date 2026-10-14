using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x02000199 RID: 409
	[global::System.Serializable]
	public class PkixCertPathBuilderException : global::Org.BouncyCastle.Security.GeneralSecurityException
	{
		// Token: 0x06000F14 RID: 3860 RVA: 0x00037F78 File Offset: 0x00036178
		public PkixCertPathBuilderException()
		{
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00037F80 File Offset: 0x00036180
		public PkixCertPathBuilderException(string message) : base(message)
		{
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00037F89 File Offset: 0x00036189
		public PkixCertPathBuilderException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
