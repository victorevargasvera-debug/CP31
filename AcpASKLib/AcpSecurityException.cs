using System;
using AcpCommonResources;

namespace AcpASKLib
{
	// Token: 0x02000017 RID: 23
	[global::System.Serializable]
	public class AcpSecurityException : global::System.Exception
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00010FFC File Offset: 0x0000F1FC
		public AcpSecurityException() : base(global::AcpCommonResources.AcpResources.Key_Not_Found)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00011014 File Offset: 0x0000F214
		public AcpSecurityException(string message) : base(message)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00011028 File Offset: 0x0000F228
		public AcpSecurityException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
