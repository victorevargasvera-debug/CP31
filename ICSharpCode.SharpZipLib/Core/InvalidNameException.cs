using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000068 RID: 104
	[global::System.Serializable]
	public class InvalidNameException : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x00013858 File Offset: 0x00011A58
		public InvalidNameException() : base("An invalid name was specified")
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00013865 File Offset: 0x00011A65
		public InvalidNameException(string message) : base(message)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001386E File Offset: 0x00011A6E
		public InvalidNameException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00013878 File Offset: 0x00011A78
		protected InvalidNameException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
