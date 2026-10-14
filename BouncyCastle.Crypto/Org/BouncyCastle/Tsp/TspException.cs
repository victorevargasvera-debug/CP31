using System;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x02000083 RID: 131
	[global::System.Serializable]
	public class TspException : global::System.Exception
	{
		// Token: 0x0600053C RID: 1340 RVA: 0x00017D00 File Offset: 0x00015F00
		public TspException()
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00017D08 File Offset: 0x00015F08
		public TspException(string message) : base(message)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00017D11 File Offset: 0x00015F11
		public TspException(string message, global::System.Exception e) : base(message, e)
		{
		}
	}
}
