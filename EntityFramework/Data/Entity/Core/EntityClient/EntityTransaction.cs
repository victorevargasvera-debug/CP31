using System;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005E2 RID: 1506
	public class EntityTransaction : global::System.Data.Common.DbTransaction
	{
		// Token: 0x060049B5 RID: 18869 RVA: 0x001046F9 File Offset: 0x001028F9
		internal EntityTransaction()
		{
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x00104701 File Offset: 0x00102901
		internal EntityTransaction(global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.Common.DbTransaction storeTransaction)
		{
			this._connection = connection;
			this._storeTransaction = storeTransaction;
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x00104717 File Offset: 0x00102917
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityConnection Connection
		{
			get
			{
				return (global::System.Data.Entity.Core.EntityClient.EntityConnection)this.DbConnection;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x00104724 File Offset: 0x00102924
		protected override global::System.Data.Common.DbConnection DbConnection
		{
			get
			{
				if (((this._storeTransaction != null) ? global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.GetConnection(this._storeTransaction, this.InterceptionContext) : null) == null)
				{
					return null;
				}
				return this._connection;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x00104756 File Offset: 0x00102956
		public override global::System.Data.IsolationLevel IsolationLevel
		{
			get
			{
				if (this._storeTransaction == null)
				{
					return (global::System.Data.IsolationLevel)0;
				}
				return global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.GetIsolationLevel(this._storeTransaction, this.InterceptionContext);
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x060049BA RID: 18874 RVA: 0x0010477D File Offset: 0x0010297D
		public virtual global::System.Data.Common.DbTransaction StoreTransaction
		{
			get
			{
				return this._storeTransaction;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x060049BB RID: 18875 RVA: 0x00104785 File Offset: 0x00102985
		private global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext InterceptionContext
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext.Combine(from c in this._connection.AssociatedContexts
				select c.InterceptionContext);
			}
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x001047BC File Offset: 0x001029BC
		public override void Commit()
		{
			try
			{
				if (this._storeTransaction != null)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.Commit(this._storeTransaction, this.InterceptionContext);
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType() && !(ex is global::System.Data.Entity.Infrastructure.CommitFailedException))
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("Commit"), ex);
				}
				throw;
			}
			this.ClearCurrentTransaction();
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00104828 File Offset: 0x00102A28
		public override void Rollback()
		{
			try
			{
				if (this._storeTransaction != null)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.Rollback(this._storeTransaction, this.InterceptionContext);
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("Rollback"), ex);
				}
				throw;
			}
			this.ClearCurrentTransaction();
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x0010488C File Offset: 0x00102A8C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.ClearCurrentTransaction();
				if (this._storeTransaction != null)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.Dispose(this._storeTransaction, this.InterceptionContext);
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x001048C1 File Offset: 0x00102AC1
		private void ClearCurrentTransaction()
		{
			if (this._connection != null && this._connection.CurrentTransaction == this)
			{
				this._connection.ClearCurrentTransaction();
			}
		}

		// Token: 0x04001A03 RID: 6659
		private readonly global::System.Data.Entity.Core.EntityClient.EntityConnection _connection;

		// Token: 0x04001A04 RID: 6660
		private readonly global::System.Data.Common.DbTransaction _storeTransaction;
	}
}
