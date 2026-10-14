using System;
using Motorola.CommonCPS.ResourceRepository;

namespace ASK.Core
{
	// Token: 0x02000014 RID: 20
	[global::System.Serializable]
	public class AcpSecurityException : global::System.Exception
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x000124A4 File Offset: 0x000106A4
		public AcpSecurityException() : base(global::Motorola.CommonCPS.ResourceRepository.Resources.Key_Not_Found)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000124BC File Offset: 0x000106BC
		public AcpSecurityException(string message) : base(message)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000124D0 File Offset: 0x000106D0
		public AcpSecurityException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
