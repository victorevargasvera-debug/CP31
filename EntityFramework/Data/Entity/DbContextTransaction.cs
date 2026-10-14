using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;

namespace System.Data.Entity
{
	// Token: 0x0200005C RID: 92
	public class DbContextTransaction : global::System.IDisposable
	{
		// Token: 0x0600029C RID: 668 RVA: 0x00009550 File Offset: 0x00007750
		internal DbContextTransaction(global::System.Data.Entity.Core.EntityClient.EntityConnection connection)
		{
			this._connection = connection;
			this.EnsureOpenConnection();
			this._entityTransaction = this._connection.BeginTransaction();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00009576 File Offset: 0x00007776
		internal DbContextTransaction(global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.IsolationLevel isolationLevel)
		{
			this._connection = connection;
			this.EnsureOpenConnection();
			this._entityTransaction = this._connection.BeginTransaction(isolationLevel);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000959D File Offset: 0x0000779D
		internal DbContextTransaction(global::System.Data.Entity.Core.EntityClient.EntityTransaction transaction)
		{
			this._connection = transaction.Connection;
			this.EnsureOpenConnection();
			this._entityTransaction = transaction;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000095BE File Offset: 0x000077BE
		private void EnsureOpenConnection()
		{
			if (global::System.Data.ConnectionState.Open != this._connection.State)
			{
				this._connection.Open();
				this._shouldCloseConnection = true;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x000095E0 File Offset: 0x000077E0
		public global::System.Data.Common.DbTransaction UnderlyingTransaction
		{
			get
			{
				return this._entityTransaction.StoreTransaction;
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000095ED File Offset: 0x000077ED
		public void Commit()
		{
			this._entityTransaction.Commit();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000095FA File Offset: 0x000077FA
		public void Rollback()
		{
			this._entityTransaction.Rollback();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00009607 File Offset: 0x00007807
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00009618 File Offset: 0x00007818
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this._isDisposed)
			{
				this._connection.ClearCurrentTransaction();
				this._entityTransaction.Dispose();
				if (this._shouldCloseConnection && this._connection.State != global::System.Data.ConnectionState.Closed)
				{
					this._connection.Close();
				}
				this._isDisposed = true;
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000966D File Offset: 0x0000786D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009675 File Offset: 0x00007875
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000967E File Offset: 0x0000787E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00009686 File Offset: 0x00007886
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x040000B2 RID: 178
		private readonly global::System.Data.Entity.Core.EntityClient.EntityConnection _connection;

		// Token: 0x040000B3 RID: 179
		private readonly global::System.Data.Entity.Core.EntityClient.EntityTransaction _entityTransaction;

		// Token: 0x040000B4 RID: 180
		private bool _shouldCloseConnection;

		// Token: 0x040000B5 RID: 181
		private bool _isDisposed;
	}
}
