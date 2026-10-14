using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002CE RID: 718
	[global::System.Serializable]
	public sealed class EntityCommandExecutionException : global::System.Data.Entity.Core.EntityException
	{
		// Token: 0x060022B2 RID: 8882 RVA: 0x000610A3 File Offset: 0x0005F2A3
		public EntityCommandExecutionException()
		{
			base.HResult = -2146232004;
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x000610B6 File Offset: 0x0005F2B6
		public EntityCommandExecutionException(string message) : base(message)
		{
			base.HResult = -2146232004;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x000610CA File Offset: 0x0005F2CA
		public EntityCommandExecutionException(string message, global::System.Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232004;
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x000610DF File Offset: 0x0005F2DF
		private EntityCommandExecutionException(global::System.Runtime.Serialization.SerializationInfo serializationInfo, global::System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
			base.HResult = -2146232004;
		}

		// Token: 0x04000BF6 RID: 3062
		private const int HResultCommandExecution = -2146232004;
	}
}
