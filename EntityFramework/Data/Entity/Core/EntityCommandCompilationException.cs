using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002CD RID: 717
	[global::System.Serializable]
	public sealed class EntityCommandCompilationException : global::System.Data.Entity.Core.EntityException
	{
		// Token: 0x060022AE RID: 8878 RVA: 0x00061052 File Offset: 0x0005F252
		public EntityCommandCompilationException()
		{
			base.HResult = -2146232005;
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00061065 File Offset: 0x0005F265
		public EntityCommandCompilationException(string message) : base(message)
		{
			base.HResult = -2146232005;
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00061079 File Offset: 0x0005F279
		public EntityCommandCompilationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232005;
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0006108E File Offset: 0x0005F28E
		private EntityCommandCompilationException(global::System.Runtime.Serialization.SerializationInfo serializationInfo, global::System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
			base.HResult = -2146232005;
		}

		// Token: 0x04000BF5 RID: 3061
		private const int HResultCommandCompilation = -2146232005;
	}
}
