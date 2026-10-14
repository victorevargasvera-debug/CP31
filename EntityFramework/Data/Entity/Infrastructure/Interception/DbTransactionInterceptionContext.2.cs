using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000289 RID: 649
	public class DbTransactionInterceptionContext<TResult> : global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext<TResult>
	{
		// Token: 0x060020AC RID: 8364 RVA: 0x0005B948 File Offset: 0x00059B48
		public DbTransactionInterceptionContext()
		{
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0005B950 File Offset: 0x00059B50
		public DbTransactionInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0005B965 File Offset: 0x00059B65
		public new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<TResult> AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<TResult>)base.AsAsync();
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0005B972 File Offset: 0x00059B72
		public new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<TResult> WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<TResult>)base.WithDbContext(context);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0005B98C File Offset: 0x00059B8C
		public new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<TResult> WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<TResult>)base.WithObjectContext(context);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0005B9A6 File Offset: 0x00059BA6
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<TResult>(this);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0005B9AE File Offset: 0x00059BAE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0005B9B6 File Offset: 0x00059BB6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0005B9BF File Offset: 0x00059BBF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x0005B9C7 File Offset: 0x00059BC7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
