using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000CD RID: 205
	[global::System.Serializable]
	public sealed class AutomaticMigrationsDisabledException : global::System.Data.Entity.Migrations.Infrastructure.MigrationsException
	{
		// Token: 0x06000FEA RID: 4074 RVA: 0x000203EB File Offset: 0x0001E5EB
		public AutomaticMigrationsDisabledException()
		{
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000203F3 File Offset: 0x0001E5F3
		public AutomaticMigrationsDisabledException(string message) : base(message)
		{
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x000203FC File Offset: 0x0001E5FC
		public AutomaticMigrationsDisabledException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00020406 File Offset: 0x0001E606
		private AutomaticMigrationsDisabledException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
