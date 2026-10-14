using System;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001D0 RID: 464
	[global::System.Serializable]
	public class SecurityUtilityException : global::System.Exception
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x0004B61E File Offset: 0x0004981E
		public SecurityUtilityException()
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0004B626 File Offset: 0x00049826
		public SecurityUtilityException(string message) : base(message)
		{
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0004B62F File Offset: 0x0004982F
		public SecurityUtilityException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
