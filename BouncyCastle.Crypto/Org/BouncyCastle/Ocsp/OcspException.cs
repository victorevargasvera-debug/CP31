using System;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001DE RID: 478
	[global::System.Serializable]
	public class OcspException : global::System.Exception
	{
		// Token: 0x060011B5 RID: 4533 RVA: 0x0004E2B4 File Offset: 0x0004C4B4
		public OcspException()
		{
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0004E2BC File Offset: 0x0004C4BC
		public OcspException(string message) : base(message)
		{
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0004E2C5 File Offset: 0x0004C4C5
		public OcspException(string message, global::System.Exception e) : base(message, e)
		{
		}
	}
}
