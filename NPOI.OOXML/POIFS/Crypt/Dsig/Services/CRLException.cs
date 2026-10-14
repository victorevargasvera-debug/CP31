using System;
using System.Runtime.Serialization;

namespace NPOI.POIFS.Crypt.Dsig.Services
{
	// Token: 0x02000106 RID: 262
	[global::System.Serializable]
	internal class CRLException : global::System.Exception
	{
		// Token: 0x06000F6E RID: 3950 RVA: 0x00002DE6 File Offset: 0x00000FE6
		public CRLException()
		{
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00002DEE File Offset: 0x00000FEE
		public CRLException(string message) : base(message)
		{
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00002DF7 File Offset: 0x00000FF7
		public CRLException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00036440 File Offset: 0x00034640
		protected CRLException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
