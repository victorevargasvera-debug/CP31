using System;
using System.Data.Entity.Core;
using System.Runtime.Serialization;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200025C RID: 604
	[global::System.Serializable]
	public sealed class RetryLimitExceededException : global::System.Data.Entity.Core.EntityException
	{
		// Token: 0x06001EDC RID: 7900 RVA: 0x00054C34 File Offset: 0x00052E34
		public RetryLimitExceededException()
		{
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00054C3C File Offset: 0x00052E3C
		public RetryLimitExceededException(string message) : base(message)
		{
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00054C45 File Offset: 0x00052E45
		public RetryLimitExceededException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00054C4F File Offset: 0x00052E4F
		private RetryLimitExceededException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
