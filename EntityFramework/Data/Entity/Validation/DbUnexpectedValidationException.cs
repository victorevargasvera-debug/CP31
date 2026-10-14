using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace System.Data.Entity.Validation
{
	// Token: 0x02000070 RID: 112
	[global::System.Serializable]
	public class DbUnexpectedValidationException : global::System.Data.DataException
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x0000E809 File Offset: 0x0000CA09
		public DbUnexpectedValidationException()
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000E811 File Offset: 0x0000CA11
		public DbUnexpectedValidationException(string message) : base(message)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000E81A File Offset: 0x0000CA1A
		public DbUnexpectedValidationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000E824 File Offset: 0x0000CA24
		[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
		protected DbUnexpectedValidationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
