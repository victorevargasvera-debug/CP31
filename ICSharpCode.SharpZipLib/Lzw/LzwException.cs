using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Lzw
{
	// Token: 0x0200004D RID: 77
	[global::System.Serializable]
	public class LzwException : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x060003CC RID: 972 RVA: 0x000119A2 File Offset: 0x0000FBA2
		public LzwException()
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000119AA File Offset: 0x0000FBAA
		public LzwException(string message) : base(message)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000119B3 File Offset: 0x0000FBB3
		public LzwException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000119BD File Offset: 0x0000FBBD
		protected LzwException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
