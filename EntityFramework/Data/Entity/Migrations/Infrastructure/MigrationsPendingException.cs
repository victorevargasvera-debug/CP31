using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000D5 RID: 213
	[global::System.Serializable]
	public sealed class MigrationsPendingException : global::System.Data.Entity.Migrations.Infrastructure.MigrationsException
	{
		// Token: 0x06001076 RID: 4214 RVA: 0x00024712 File Offset: 0x00022912
		public MigrationsPendingException()
		{
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0002471A File Offset: 0x0002291A
		public MigrationsPendingException(string message) : base(message)
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00024723 File Offset: 0x00022923
		public MigrationsPendingException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0002472D File Offset: 0x0002292D
		private MigrationsPendingException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
