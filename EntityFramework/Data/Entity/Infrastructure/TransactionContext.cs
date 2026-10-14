using System;
using System.Data.Common;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000264 RID: 612
	public class TransactionContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x06001F14 RID: 7956 RVA: 0x000557F4 File Offset: 0x000539F4
		public TransactionContext(global::System.Data.Common.DbConnection existingConnection) : base(existingConnection, false)
		{
			base.Configuration.ValidateOnSaveEnabled = false;
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0005580A File Offset: 0x00053A0A
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x00055812 File Offset: 0x00053A12
		public virtual global::System.Data.Entity.IDbSet<global::System.Data.Entity.Infrastructure.TransactionRow> Transactions { get; set; }

		// Token: 0x06001F17 RID: 7959 RVA: 0x0005581B File Offset: 0x00053A1B
		protected override void OnModelCreating(global::System.Data.Entity.DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<global::System.Data.Entity.Infrastructure.TransactionRow>().ToTable("__TransactionHistory");
		}

		// Token: 0x04000B45 RID: 2885
		private const string _defaultTableName = "__TransactionHistory";
	}
}
