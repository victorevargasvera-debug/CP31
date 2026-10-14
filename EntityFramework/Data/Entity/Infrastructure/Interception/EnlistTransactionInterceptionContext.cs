using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;
using System.Transactions;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200028A RID: 650
	public class EnlistTransactionInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext
	{
		// Token: 0x060020B6 RID: 8374 RVA: 0x0005B9CF File Offset: 0x00059BCF
		public EnlistTransactionInterceptionContext()
		{
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x0005B9D8 File Offset: 0x00059BD8
		public EnlistTransactionInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
			global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext enlistTransactionInterceptionContext = copyFrom as global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext;
			if (enlistTransactionInterceptionContext != null)
			{
				this._transaction = enlistTransactionInterceptionContext._transaction;
			}
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0005BA0E File Offset: 0x00059C0E
		public new global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext)base.AsAsync();
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0005BA1B File Offset: 0x00059C1B
		public global::System.Transactions.Transaction Transaction
		{
			get
			{
				return this._transaction;
			}
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x0005BA23 File Offset: 0x00059C23
		public global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext WithTransaction(global::System.Transactions.Transaction transaction)
		{
			global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext enlistTransactionInterceptionContext = this.TypedClone();
			enlistTransactionInterceptionContext._transaction = transaction;
			return enlistTransactionInterceptionContext;
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x0005BA32 File Offset: 0x00059C32
		private global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext TypedClone()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext)this.Clone();
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x0005BA3F File Offset: 0x00059C3F
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext(this);
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0005BA47 File Offset: 0x00059C47
		public new global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext)base.WithDbContext(context);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0005BA61 File Offset: 0x00059C61
		public new global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext)base.WithObjectContext(context);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0005BA7B File Offset: 0x00059C7B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0005BA83 File Offset: 0x00059C83
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0005BA8C File Offset: 0x00059C8C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0005BA94 File Offset: 0x00059C94
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B89 RID: 2953
		private global::System.Transactions.Transaction _transaction;
	}
}
