using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib
{
	// Token: 0x02000005 RID: 5
	[global::System.Serializable]
	public class UnexpectedEndOfStreamException : global::ICSharpCode.SharpZipLib.StreamDecodingException
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000020C9 File Offset: 0x000002C9
		public UnexpectedEndOfStreamException() : base("Input stream ended unexpectedly")
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020D6 File Offset: 0x000002D6
		public UnexpectedEndOfStreamException(string message) : base(message)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020DF File Offset: 0x000002DF
		public UnexpectedEndOfStreamException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020E9 File Offset: 0x000002E9
		protected UnexpectedEndOfStreamException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000003 RID: 3
		private const string GenericMessage = "Input stream ended unexpectedly";
	}
}
