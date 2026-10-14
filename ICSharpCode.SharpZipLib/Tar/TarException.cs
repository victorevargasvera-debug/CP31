using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000047 RID: 71
	[global::System.Serializable]
	public class TarException : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x06000349 RID: 841 RVA: 0x0000FEC1 File Offset: 0x0000E0C1
		public TarException()
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000FEC9 File Offset: 0x0000E0C9
		public TarException(string message) : base(message)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000FED2 File Offset: 0x0000E0D2
		public TarException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000FEDC File Offset: 0x0000E0DC
		protected TarException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
