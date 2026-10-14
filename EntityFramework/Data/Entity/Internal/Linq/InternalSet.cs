using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Internal.Linq
{
	// Token: 0x02000147 RID: 327
	internal class InternalSet<TEntity> : global::System.Data.Entity.Internal.Linq.InternalQuery<TEntity>, global::System.Data.Entity.Internal.Linq.IInternalSet<TEntity>, global::System.Data.Entity.Internal.Linq.IInternalSet, global::System.Data.Entity.Internal.Linq.IInternalQuery, global::System.Data.Entity.Internal.Linq.IInternalQuery<TEntity> where TEntity : class
	{
		// Token: 0x0600154B RID: 5451 RVA: 0x00036771 File Offset: 0x00034971
		public InternalSet(global::System.Data.Entity.Internal.InternalContext internalContext) : base(internalContext)
		{
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0003677A File Offset: 0x0003497A
		public override void ResetQuery()
		{
			this._entitySet = null;
			this._localView = null;
			base.ResetQuery();
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00036790 File Offset: 0x00034990
		public TEntity Find(params object[] keyValues)
		{
			this.InternalContext.ObjectContext.AsyncMonitor.EnsureNotEntered();
			this.InternalContext.DetectChanges(false);
			global::System.Data.Entity.Internal.WrappedEntityKey key = new global::System.Data.Entity.Internal.WrappedEntityKey(this.EntitySet, this.EntitySetName, keyValues, "keyValues");
			object obj = this.FindInStateManager(key) ?? this.FindInStore(key, "keyValues");
			if (obj != null && !(obj is TEntity))
			{
				throw global::System.Data.Entity.Resources.Error.DbSet_WrongEntityTypeFound(obj.GetType().Name, typeof(TEntity).Name);
			}
			return (TEntity)((object)obj);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0003681F File Offset: 0x00034A1F
		public global::System.Threading.Tasks.Task<TEntity> FindAsync(global::System.Threading.CancellationToken cancellationToken, params object[] keyValues)
		{
			cancellationToken.ThrowIfCancellationRequested();
			this.InternalContext.ObjectContext.AsyncMonitor.EnsureNotEntered();
			return this.FindInternalAsync(cancellationToken, keyValues);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00036848 File Offset: 0x00034A48
		private async global::System.Threading.Tasks.Task<TEntity> FindInternalAsync(global::System.Threading.CancellationToken cancellationToken, params object[] keyValues)
		{
			this.InternalContext.DetectChanges(false);
			global::System.Data.Entity.Internal.WrappedEntityKey key = new global::System.Data.Entity.Internal.WrappedEntityKey(this.EntitySet, this.EntitySetName, keyValues, "keyValues");
			object obj = this.FindInStateManager(key);
			if (obj == null)
			{
				obj = await this.FindInStoreAsync(key, "keyValues", cancellationToken).WithCurrentCulture<object>();
			}
			object obj2 = obj;
			if (obj2 != null && !(obj2 is TEntity))
			{
				throw global::System.Data.Entity.Resources.Error.DbSet_WrongEntityTypeFound(obj2.GetType().Name, typeof(TEntity).Name);
			}
			return (TEntity)((object)obj2);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000368A0 File Offset: 0x00034AA0
		private object FindInStateManager(global::System.Data.Entity.Internal.WrappedEntityKey key)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry;
			if (!key.HasNullValues && this.InternalContext.ObjectContext.ObjectStateManager.TryGetObjectStateEntry(key.EntityKey, out objectStateEntry))
			{
				return objectStateEntry.Entity;
			}
			object obj = null;
			foreach (global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry2 in from e in this.InternalContext.ObjectContext.ObjectStateManager.GetObjectStateEntries(global::System.Data.Entity.EntityState.Added)
			where !e.IsRelationship && e.Entity != null && this.EntitySetBaseType.IsAssignableFrom(e.Entity.GetType())
			select e)
			{
				bool flag = true;
				foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in key.KeyValuePairs)
				{
					int ordinal = objectStateEntry2.CurrentValues.GetOrdinal(keyValuePair.Key);
					if (!global::System.Data.Entity.Internal.DbHelpers.KeyValuesEqual(keyValuePair.Value, objectStateEntry2.CurrentValues.GetValue(ordinal)))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					if (obj != null)
					{
						throw global::System.Data.Entity.Resources.Error.DbSet_MultipleAddedEntitiesFound();
					}
					obj = objectStateEntry2.Entity;
				}
			}
			return obj;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000369C4 File Offset: 0x00034BC4
		private object FindInStore(global::System.Data.Entity.Internal.WrappedEntityKey key, string keyValuesParamName)
		{
			if (key.HasNullValues)
			{
				return null;
			}
			object result;
			try
			{
				result = this.BuildFindQuery(key).SingleOrDefault<TEntity>();
			}
			catch (global::System.Data.Entity.Core.EntitySqlException innerException)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbSet_WrongKeyValueType, keyValuesParamName, innerException);
			}
			return result;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00036A10 File Offset: 0x00034C10
		private async global::System.Threading.Tasks.Task<object> FindInStoreAsync(global::System.Data.Entity.Internal.WrappedEntityKey key, string keyValuesParamName, global::System.Threading.CancellationToken cancellationToken)
		{
			object result;
			if (key.HasNullValues)
			{
				result = null;
			}
			else
			{
				try
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<TEntity> cultureAwaiter = this.BuildFindQuery(key).SingleOrDefaultAsync(cancellationToken).WithCurrentCulture<TEntity>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<TEntity> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<TEntity>);
					}
					result = cultureAwaiter.GetResult();
				}
				catch (global::System.Data.Entity.Core.EntitySqlException innerException)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbSet_WrongKeyValueType, keyValuesParamName, innerException);
				}
			}
			return result;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00036A70 File Offset: 0x00034C70
		private global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> BuildFindQuery(global::System.Data.Entity.Internal.WrappedEntityKey key)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendFormat("SELECT VALUE X FROM {0} AS X WHERE ", this.QuotedEntitySetName);
			global::System.Data.Entity.Core.EntityKeyMember[] entityKeyValues = key.EntityKey.EntityKeyValues;
			global::System.Data.Entity.Core.Objects.ObjectParameter[] array = new global::System.Data.Entity.Core.Objects.ObjectParameter[entityKeyValues.Length];
			for (int i = 0; i < entityKeyValues.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(" AND ");
				}
				string text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "p{0}", new object[]
				{
					i.ToString(global::System.Globalization.CultureInfo.InvariantCulture)
				});
				stringBuilder.AppendFormat("X.{0} = @{1}", global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(entityKeyValues[i].Key), text);
				array[i] = new global::System.Data.Entity.Core.Objects.ObjectParameter(text, entityKeyValues[i].Value);
			}
			return this.InternalContext.ObjectContext.CreateQuery<TEntity>(stringBuilder.ToString(), array);
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00036B34 File Offset: 0x00034D34
		public global::System.Collections.ObjectModel.ObservableCollection<TEntity> Local
		{
			get
			{
				this.InternalContext.DetectChanges(false);
				global::System.Data.Entity.Internal.DbLocalView<TEntity> result;
				if ((result = this._localView) == null)
				{
					result = (this._localView = new global::System.Data.Entity.Internal.DbLocalView<TEntity>(this.InternalContext));
				}
				return result;
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00036B6C File Offset: 0x00034D6C
		public virtual void Attach(object entity)
		{
			this.ActOnSet(delegate()
			{
				this.InternalContext.ObjectContext.AttachTo(this.EntitySetName, entity);
			}, global::System.Data.Entity.EntityState.Unchanged, entity, "Attach");
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00036BAC File Offset: 0x00034DAC
		public virtual void Add(object entity)
		{
			this.ActOnSet(delegate()
			{
				this.InternalContext.ObjectContext.AddObject(this.EntitySetName, entity);
			}, global::System.Data.Entity.EntityState.Added, entity, "Add");
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00036BEB File Offset: 0x00034DEB
		public virtual void AddRange(global::System.Collections.IEnumerable entities)
		{
			this.InternalContext.DetectChanges(false);
			this.ActOnSet(delegate(object entity)
			{
				this.InternalContext.ObjectContext.AddObject(this.EntitySetName, entity);
			}, global::System.Data.Entity.EntityState.Added, entities, "AddRange");
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00036C14 File Offset: 0x00034E14
		public virtual void Remove(object entity)
		{
			if (!(entity is TEntity))
			{
				throw global::System.Data.Entity.Resources.Error.DbSet_BadTypeForAddAttachRemove("Remove", entity.GetType().Name, typeof(TEntity).Name);
			}
			this.InternalContext.DetectChanges(false);
			this.InternalContext.ObjectContext.DeleteObject(entity);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00036C6C File Offset: 0x00034E6C
		public virtual void RemoveRange(global::System.Collections.IEnumerable entities)
		{
			global::System.Collections.Generic.List<object> list = entities.Cast<object>().ToList<object>();
			this.InternalContext.DetectChanges(false);
			foreach (object obj in list)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<object>(obj, "entity");
				if (!(obj is TEntity))
				{
					throw global::System.Data.Entity.Resources.Error.DbSet_BadTypeForAddAttachRemove("RemoveRange", obj.GetType().Name, typeof(TEntity).Name);
				}
				this.InternalContext.ObjectContext.DeleteObject(obj);
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00036D14 File Offset: 0x00034F14
		private void ActOnSet(global::System.Action action, global::System.Data.Entity.EntityState newState, object entity, string methodName)
		{
			if (!(entity is TEntity))
			{
				throw global::System.Data.Entity.Resources.Error.DbSet_BadTypeForAddAttachRemove(methodName, entity.GetType().Name, typeof(TEntity).Name);
			}
			this.InternalContext.DetectChanges(false);
			global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry;
			if (this.InternalContext.ObjectContext.ObjectStateManager.TryGetObjectStateEntry(entity, out objectStateEntry))
			{
				objectStateEntry.ChangeState(newState);
				return;
			}
			action();
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00036D80 File Offset: 0x00034F80
		private void ActOnSet(global::System.Action<object> action, global::System.Data.Entity.EntityState newState, global::System.Collections.IEnumerable entities, string methodName)
		{
			foreach (object obj in entities)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<object>(obj, "entity");
				if (!(obj is TEntity))
				{
					throw global::System.Data.Entity.Resources.Error.DbSet_BadTypeForAddAttachRemove(methodName, obj.GetType().Name, typeof(TEntity).Name);
				}
				global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry;
				if (this.InternalContext.ObjectContext.ObjectStateManager.TryGetObjectStateEntry(obj, out objectStateEntry))
				{
					objectStateEntry.ChangeState(newState);
				}
				else
				{
					action(obj);
				}
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00036E28 File Offset: 0x00035028
		public TEntity Create()
		{
			return this.InternalContext.CreateObject<TEntity>();
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00036E38 File Offset: 0x00035038
		public TEntity Create(global::System.Type derivedEntityType)
		{
			if (!typeof(TEntity).IsAssignableFrom(derivedEntityType))
			{
				throw global::System.Data.Entity.Resources.Error.DbSet_BadTypeForCreate(derivedEntityType.Name, typeof(TEntity).Name);
			}
			return (TEntity)((object)this.InternalContext.CreateObject(global::System.Data.Entity.Internal.ObjectContextTypeCache.GetObjectType(derivedEntityType)));
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00036E88 File Offset: 0x00035088
		public override global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> ObjectQuery
		{
			get
			{
				this.Initialize();
				return base.ObjectQuery;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x00036E96 File Offset: 0x00035096
		public string EntitySetName
		{
			get
			{
				this.Initialize();
				return this._entitySetName;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00036EA4 File Offset: 0x000350A4
		public string QuotedEntitySetName
		{
			get
			{
				this.Initialize();
				return this._quotedEntitySetName;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00036EB2 File Offset: 0x000350B2
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				this.Initialize();
				return this._entitySet;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00036EC0 File Offset: 0x000350C0
		public global::System.Type EntitySetBaseType
		{
			get
			{
				this.Initialize();
				return this._baseType;
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00036ED0 File Offset: 0x000350D0
		public virtual void Initialize()
		{
			if (this._entitySet == null)
			{
				global::System.Data.Entity.Internal.EntitySetTypePair entitySetAndBaseTypeForType = base.InternalContext.GetEntitySetAndBaseTypeForType(typeof(TEntity));
				if (this._entitySet == null)
				{
					this.InitializeUnderlyingTypes(entitySetAndBaseTypeForType);
				}
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00036F0C File Offset: 0x0003510C
		public virtual void TryInitialize()
		{
			if (this._entitySet == null)
			{
				global::System.Data.Entity.Internal.EntitySetTypePair entitySetTypePair = base.InternalContext.TryGetEntitySetAndBaseTypeForType(typeof(TEntity));
				if (entitySetTypePair != null)
				{
					this.InitializeUnderlyingTypes(entitySetTypePair);
				}
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00036F44 File Offset: 0x00035144
		private void InitializeUnderlyingTypes(global::System.Data.Entity.Internal.EntitySetTypePair pair)
		{
			this._entitySet = pair.EntitySet;
			this._baseType = pair.BaseType;
			this._entitySetName = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				this._entitySet.EntityContainer.Name,
				this._entitySet.Name
			});
			this._quotedEntitySetName = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(this._entitySet.EntityContainer.Name),
				global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(this._entitySet.Name)
			});
			base.InitializeQuery(this.CreateObjectQuery(false, null, null));
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00037004 File Offset: 0x00035204
		private global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> CreateObjectQuery(bool asNoTracking, bool? streaming = null, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = null)
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> objectQuery = this.InternalContext.ObjectContext.CreateQuery<TEntity>(this._quotedEntitySetName, new global::System.Data.Entity.Core.Objects.ObjectParameter[0]);
			if (this._baseType != typeof(TEntity))
			{
				objectQuery = objectQuery.OfType<TEntity>();
			}
			if (asNoTracking)
			{
				objectQuery.MergeOption = global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
			}
			if (streaming != null)
			{
				objectQuery.Streaming = streaming.Value;
			}
			objectQuery.ExecutionStrategy = executionStrategy;
			return objectQuery;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00037074 File Offset: 0x00035274
		public override string ToString()
		{
			this.Initialize();
			return base.ToString();
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00037082 File Offset: 0x00035282
		public override string ToTraceString()
		{
			this.Initialize();
			return base.ToTraceString();
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00037090 File Offset: 0x00035290
		public override global::System.Data.Entity.Internal.InternalContext InternalContext
		{
			get
			{
				this.Initialize();
				return base.InternalContext;
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0003709E File Offset: 0x0003529E
		public override global::System.Data.Entity.Internal.Linq.IInternalQuery<TEntity> Include(string path)
		{
			this.Initialize();
			return base.Include(path);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x000370B0 File Offset: 0x000352B0
		public override global::System.Data.Entity.Internal.Linq.IInternalQuery<TEntity> AsNoTracking()
		{
			this.Initialize();
			return new global::System.Data.Entity.Internal.Linq.InternalQuery<TEntity>(this.InternalContext, this.CreateObjectQuery(true, null, null));
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000370DF File Offset: 0x000352DF
		public override global::System.Data.Entity.Internal.Linq.IInternalQuery<TEntity> AsStreaming()
		{
			this.Initialize();
			return new global::System.Data.Entity.Internal.Linq.InternalQuery<TEntity>(this.InternalContext, this.CreateObjectQuery(false, new bool?(true), null));
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00037100 File Offset: 0x00035300
		public override global::System.Data.Entity.Internal.Linq.IInternalQuery<TEntity> WithExecutionStrategy(global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			this.Initialize();
			return new global::System.Data.Entity.Internal.Linq.InternalQuery<TEntity>(this.InternalContext, this.CreateObjectQuery(false, new bool?(false), executionStrategy));
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00037124 File Offset: 0x00035324
		public global::System.Collections.IEnumerator ExecuteSqlQuery(string sql, bool asNoTracking, bool? streaming, object[] parameters)
		{
			this.InternalContext.ObjectContext.AsyncMonitor.EnsureNotEntered();
			this.Initialize();
			global::System.Data.Entity.Core.Objects.MergeOption mergeOption = asNoTracking ? global::System.Data.Entity.Core.Objects.MergeOption.NoTracking : global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly;
			return new global::System.Data.Entity.Internal.LazyEnumerator<TEntity>(() => this.InternalContext.ObjectContext.ExecuteStoreQuery<TEntity>(sql, this.EntitySetName, new global::System.Data.Entity.Core.Objects.ExecutionOptions(mergeOption, streaming), parameters));
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0003718C File Offset: 0x0003538C
		public global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator ExecuteSqlQueryAsync(string sql, bool asNoTracking, bool? streaming, object[] parameters)
		{
			this.InternalContext.ObjectContext.AsyncMonitor.EnsureNotEntered();
			this.Initialize();
			global::System.Data.Entity.Core.Objects.MergeOption mergeOption = asNoTracking ? global::System.Data.Entity.Core.Objects.MergeOption.NoTracking : global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly;
			return new global::System.Data.Entity.Internal.LazyAsyncEnumerator<TEntity>((global::System.Threading.CancellationToken cancellationToken) => this.InternalContext.ObjectContext.ExecuteStoreQueryAsync<TEntity>(sql, this.EntitySetName, new global::System.Data.Entity.Core.Objects.ExecutionOptions(mergeOption, streaming), cancellationToken, parameters));
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000371F3 File Offset: 0x000353F3
		public override global::System.Linq.Expressions.Expression Expression
		{
			get
			{
				this.Initialize();
				return base.Expression;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00037201 File Offset: 0x00035401
		public override global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider ObjectQueryProvider
		{
			get
			{
				this.Initialize();
				return base.ObjectQueryProvider;
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0003720F File Offset: 0x0003540F
		public override global::System.Collections.Generic.IEnumerator<TEntity> GetEnumerator()
		{
			this.Initialize();
			return base.GetEnumerator();
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0003721D File Offset: 0x0003541D
		public override global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> GetAsyncEnumerator()
		{
			this.Initialize();
			return base.GetAsyncEnumerator();
		}

		// Token: 0x040009D0 RID: 2512
		private global::System.Data.Entity.Internal.DbLocalView<TEntity> _localView;

		// Token: 0x040009D1 RID: 2513
		private global::System.Data.Entity.Core.Metadata.Edm.EntitySet _entitySet;

		// Token: 0x040009D2 RID: 2514
		private string _entitySetName;

		// Token: 0x040009D3 RID: 2515
		private string _quotedEntitySetName;

		// Token: 0x040009D4 RID: 2516
		private global::System.Type _baseType;
	}
}
