using System;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x02000561 RID: 1377
	public class CmpException : global::System.Exception
	{
		// Token: 0x060034AC RID: 13484 RVA: 0x000FB9D6 File Offset: 0x000F9BD6
		public CmpException()
		{
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x000FB9DE File Offset: 0x000F9BDE
		public CmpException(string message) : base(message)
		{
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000FB9E7 File Offset: 0x000F9BE7
		public CmpException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
