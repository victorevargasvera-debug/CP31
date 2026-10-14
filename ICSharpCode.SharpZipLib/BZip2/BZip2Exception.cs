using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000077 RID: 119
	[global::System.Serializable]
	public class BZip2Exception : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x00014930 File Offset: 0x00012B30
		public BZip2Exception()
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00014938 File Offset: 0x00012B38
		public BZip2Exception(string message) : base(message)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00014941 File Offset: 0x00012B41
		public BZip2Exception(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001494B File Offset: 0x00012B4B
		protected BZip2Exception(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
