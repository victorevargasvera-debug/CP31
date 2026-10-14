using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A3 RID: 1443
	[global::System.Serializable]
	public class PgpDataValidationException : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException
	{
		// Token: 0x06003615 RID: 13845 RVA: 0x0010078E File Offset: 0x000FE98E
		public PgpDataValidationException()
		{
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00100796 File Offset: 0x000FE996
		public PgpDataValidationException(string message) : base(message)
		{
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0010079F File Offset: 0x000FE99F
		public PgpDataValidationException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
