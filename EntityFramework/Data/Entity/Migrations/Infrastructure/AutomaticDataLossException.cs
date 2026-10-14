using System;
using System.Data.Entity.Utilities;
using System.Runtime.Serialization;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000CC RID: 204
	[global::System.Serializable]
	public sealed class AutomaticDataLossException : global::System.Data.Entity.Migrations.Infrastructure.MigrationsException
	{
		// Token: 0x06000FE6 RID: 4070 RVA: 0x000203BA File Offset: 0x0001E5BA
		public AutomaticDataLossException()
		{
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000203C2 File Offset: 0x0001E5C2
		public AutomaticDataLossException(string message) : base(message)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(message, "message");
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x000203D7 File Offset: 0x0001E5D7
		public AutomaticDataLossException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000203E1 File Offset: 0x0001E5E1
		private AutomaticDataLossException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
