using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000D3 RID: 211
	[global::System.Serializable]
	public class MigrationsException : global::System.Exception
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x000246E5 File Offset: 0x000228E5
		public MigrationsException()
		{
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000246ED File Offset: 0x000228ED
		public MigrationsException(string message) : base(message)
		{
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x000246F6 File Offset: 0x000228F6
		public MigrationsException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00024700 File Offset: 0x00022900
		protected MigrationsException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
