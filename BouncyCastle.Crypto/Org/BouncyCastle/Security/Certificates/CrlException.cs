using System;

namespace Org.BouncyCastle.Security.Certificates
{
	// Token: 0x020001D9 RID: 473
	[global::System.Serializable]
	public class CrlException : global::Org.BouncyCastle.Security.GeneralSecurityException
	{
		// Token: 0x06001186 RID: 4486 RVA: 0x0004DA9A File Offset: 0x0004BC9A
		public CrlException()
		{
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0004DAA2 File Offset: 0x0004BCA2
		public CrlException(string msg) : base(msg)
		{
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0004DAAB File Offset: 0x0004BCAB
		public CrlException(string msg, global::System.Exception e) : base(msg, e)
		{
		}
	}
}
