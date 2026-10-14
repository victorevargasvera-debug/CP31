using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005AD RID: 1453
	[global::System.Serializable]
	public class PgpKeyValidationException : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException
	{
		// Token: 0x06003655 RID: 13909 RVA: 0x00101695 File Offset: 0x000FF895
		public PgpKeyValidationException()
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x0010169D File Offset: 0x000FF89D
		public PgpKeyValidationException(string message) : base(message)
		{
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x001016A6 File Offset: 0x000FF8A6
		public PgpKeyValidationException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
