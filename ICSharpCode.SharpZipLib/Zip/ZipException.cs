using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000015 RID: 21
	[global::System.Serializable]
	public class ZipException : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00004193 File Offset: 0x00002393
		public ZipException()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000419B File Offset: 0x0000239B
		public ZipException(string message) : base(message)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000041A4 File Offset: 0x000023A4
		public ZipException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000041AE File Offset: 0x000023AE
		protected ZipException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
