using System;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace NLog
{
	// Token: 0x0200001C RID: 28
	[global::System.Serializable]
	public class NLogRuntimeException : global::System.Exception
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x000088B8 File Offset: 0x00006AB8
		public NLogRuntimeException()
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000088C0 File Offset: 0x00006AC0
		public NLogRuntimeException(string message) : base(message)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000088C9 File Offset: 0x00006AC9
		[global::JetBrains.Annotations.StringFormatMethod("message")]
		public NLogRuntimeException(string message, params object[] messageParameters) : base(string.Format(message, messageParameters))
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000088D8 File Offset: 0x00006AD8
		public NLogRuntimeException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000088E2 File Offset: 0x00006AE2
		protected NLogRuntimeException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
