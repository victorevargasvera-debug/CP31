using System;
using System.Data.Common;
using System.Data.Entity.Core.Mapping.Update.Internal;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Resources;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.EntityClient.Internal
{
	// Token: 0x020005E5 RID: 1509
	internal class EntityAdapter : global::System.Data.Entity.Core.EntityClient.Internal.IEntityAdapter
	{
		// Token: 0x060049CD RID: 18893 RVA: 0x00104E32 File Offset: 0x00103032
		public EntityAdapter(global::System.Data.Entity.Core.Objects.ObjectContext context) : this(context, (global::System.Data.Entity.Core.EntityClient.Internal.EntityAdapter a) => new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator(a))
		{
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00104E5A File Offset: 0x0010305A
		protected EntityAdapter(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Func<global::System.Data.Entity.Core.EntityClient.Internal.EntityAdapter, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator> updateTranslatorFactory)
		{
			this._context = context;
			this._updateTranslatorFactory = updateTranslatorFactory;
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x00104E77 File Offset: 0x00103077
		public global::System.Data.Entity.Core.Objects.ObjectContext Context
		{
			get
			{
				return this._context;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x060049D0 RID: 18896 RVA: 0x00104E7F File Offset: 0x0010307F
		// (set) Token: 0x060049D1 RID: 18897 RVA: 0x00104E87 File Offset: 0x00103087
		global::System.Data.Common.DbConnection global::System.Data.Entity.Core.EntityClient.Internal.IEntityAdapter.Connection
		{
			get
			{
				return this.Connection;
			}
			set
			{
				this.Connection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x00104E95 File Offset: 0x00103095
		// (set) Token: 0x060049D3 RID: 18899 RVA: 0x00104E9D File Offset: 0x0010309D
		public global::System.Data.Entity.Core.EntityClient.EntityConnection Connection
		{
			get
			{
				return this._connection;
			}
			set
			{
				this._connection = value;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x00104EA6 File Offset: 0x001030A6
		// (set) Token: 0x060049D5 RID: 18901 RVA: 0x00104EAE File Offset: 0x001030AE
		public bool AcceptChangesDuringUpdate
		{
			get
			{
				return this._acceptChangesDuringUpdate;
			}
			set
			{
				this._acceptChangesDuringUpdate = value;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x060049D6 RID: 18902 RVA: 0x00104EB7 File Offset: 0x001030B7
		// (set) Token: 0x060049D7 RID: 18903 RVA: 0x00104EBF File Offset: 0x001030BF
		public int? CommandTimeout { get; set; }

		// Token: 0x060049D8 RID: 18904 RVA: 0x00104EC8 File Offset: 0x001030C8
		public int Update()
		{
			return this.Update<int>(0, (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator ut) => ut.Update());
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x00104EF0 File Offset: 0x001030F0
		public global::System.Threading.Tasks.Task<int> UpdateAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.Update<global::System.Threading.Tasks.Task<int>>(global::System.Threading.Tasks.Task.FromResult<int>(0), (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator ut) => ut.UpdateAsync(cancellationToken));
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00104F24 File Offset: 0x00103124
		private T Update<T>(T noChangesResult, global::System.Func<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator, T> updateFunction)
		{
			if (!global::System.Data.Entity.Core.EntityClient.Internal.EntityAdapter.IsStateManagerDirty(this._context.ObjectStateManager))
			{
				return noChangesResult;
			}
			if (this._connection == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_NoConnectionForAdapter();
			}
			if (this._connection.StoreProviderFactory == null || this._connection.StoreConnection == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_NoStoreConnectionForUpdate();
			}
			if (global::System.Data.ConnectionState.Open != this._connection.State)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ClosedConnectionForUpdate();
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator arg = this._updateTranslatorFactory(this);
			return updateFunction(arg);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x00104F9B File Offset: 0x0010319B
		private static bool IsStateManagerDirty(global::System.Data.Entity.Core.Objects.ObjectStateManager entityCache)
		{
			return entityCache.HasChanges();
		}

		// Token: 0x04001A0A RID: 6666
		private bool _acceptChangesDuringUpdate = true;

		// Token: 0x04001A0B RID: 6667
		private global::System.Data.Entity.Core.EntityClient.EntityConnection _connection;

		// Token: 0x04001A0C RID: 6668
		private readonly global::System.Data.Entity.Core.Objects.ObjectContext _context;

		// Token: 0x04001A0D RID: 6669
		private readonly global::System.Func<global::System.Data.Entity.Core.EntityClient.Internal.EntityAdapter, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator> _updateTranslatorFactory;
	}
}
