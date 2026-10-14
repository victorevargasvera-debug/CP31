using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000052 RID: 82
	[global::System.Serializable]
	public class GZipException : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x000122D8 File Offset: 0x000104D8
		public GZipException()
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000122E0 File Offset: 0x000104E0
		public GZipException(string message) : base(message)
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000122E9 File Offset: 0x000104E9
		public GZipException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000122F3 File Offset: 0x000104F3
		protected GZipException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
