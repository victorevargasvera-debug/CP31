using System;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001CA RID: 458
	[global::System.Obsolete("Never thrown")]
	[global::System.Serializable]
	public class NoSuchAlgorithmException : global::Org.BouncyCastle.Security.GeneralSecurityException
	{
		// Token: 0x0600110C RID: 4364 RVA: 0x000484D6 File Offset: 0x000466D6
		public NoSuchAlgorithmException()
		{
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x000484DE File Offset: 0x000466DE
		public NoSuchAlgorithmException(string message) : base(message)
		{
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x000484E7 File Offset: 0x000466E7
		public NoSuchAlgorithmException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
