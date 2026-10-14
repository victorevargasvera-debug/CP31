using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000288 RID: 648
	public class DbTransactionInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext
	{
		// Token: 0x0600209F RID: 8351 RVA: 0x0005B870 File Offset: 0x00059A70
		public DbTransactionInterceptionContext()
		{
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0005B878 File Offset: 0x00059A78
		public DbTransactionInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext dbTransactionInterceptionContext = copyFrom as global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext;
			if (dbTransactionInterceptionContext != null)
			{
				this._connection = dbTransactionInterceptionContext.Connection;
			}
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0005B8AE File Offset: 0x00059AAE
		public global::System.Data.Common.DbConnection Connection
		{
			get
			{
				return this._connection;
			}
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0005B8B6 File Offset: 0x00059AB6
		public global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext WithConnection(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext dbTransactionInterceptionContext = this.TypedClone();
			dbTransactionInterceptionContext._connection = connection;
			return dbTransactionInterceptionContext;
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0005B8D1 File Offset: 0x00059AD1
		public new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext)base.AsAsync();
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0005B8DE File Offset: 0x00059ADE
		public new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext)base.WithDbContext(context);
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0005B8F8 File Offset: 0x00059AF8
		public new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext)base.WithObjectContext(context);
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0005B912 File Offset: 0x00059B12
		private global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext TypedClone()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext)this.Clone();
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0005B91F File Offset: 0x00059B1F
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext(this);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0005B927 File Offset: 0x00059B27
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0005B92F File Offset: 0x00059B2F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0005B938 File Offset: 0x00059B38
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0005B940 File Offset: 0x00059B40
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B88 RID: 2952
		private global::System.Data.Common.DbConnection _connection;
	}
}
