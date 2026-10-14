using System;
using System.Data.Entity.Core;
using System.Data.Entity.Internal;
using System.Runtime.Serialization;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000239 RID: 569
	[global::System.Serializable]
	public class DbUpdateConcurrencyException : global::System.Data.Entity.Infrastructure.DbUpdateException
	{
		// Token: 0x06001E1A RID: 7706 RVA: 0x000532C7 File Offset: 0x000514C7
		internal DbUpdateConcurrencyException(global::System.Data.Entity.Internal.InternalContext context, global::System.Data.Entity.Core.OptimisticConcurrencyException innerException) : base(context, innerException, false)
		{
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x000532D2 File Offset: 0x000514D2
		public DbUpdateConcurrencyException()
		{
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000532DA File Offset: 0x000514DA
		public DbUpdateConcurrencyException(string message) : base(message)
		{
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000532E3 File Offset: 0x000514E3
		public DbUpdateConcurrencyException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000532ED File Offset: 0x000514ED
		protected DbUpdateConcurrencyException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
