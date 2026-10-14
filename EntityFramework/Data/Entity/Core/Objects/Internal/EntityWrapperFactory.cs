using System;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000442 RID: 1090
	internal class EntityWrapperFactory
	{
		// Token: 0x06003547 RID: 13639 RVA: 0x000AA7B0 File Offset: 0x000A89B0
		internal static global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper CreateNewWrapper(object entity, global::System.Data.Entity.Core.EntityKey key)
		{
			if (entity == null)
			{
				return global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
			}
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory._delegateCache.Evaluate(entity.GetType())(entity);
			entityWrapper.RelationshipManager.SetWrappedOwner(entityWrapper, entity);
			if (key != null && entityWrapper.EntityKey == null)
			{
				entityWrapper.EntityKey = key;
			}
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo;
			if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetProxyType(entity.GetType(), out entityProxyTypeInfo))
			{
				entityProxyTypeInfo.SetEntityWrapper(entityWrapper);
			}
			return entityWrapper;
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x000AA814 File Offset: 0x000A8A14
		private static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> CreateWrapperDelegate(global::System.Type entityType)
		{
			bool flag = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships).IsAssignableFrom(entityType);
			bool flag2 = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker).IsAssignableFrom(entityType);
			bool flag3 = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey).IsAssignableFrom(entityType);
			bool flag4 = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.IsProxyType(entityType);
			global::System.Reflection.MethodInfo methodInfo;
			if (flag && flag2 && flag3 && !flag4)
			{
				methodInfo = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateWrapperDelegateTypedLightweightMethod;
			}
			else if (flag)
			{
				methodInfo = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateWrapperDelegateTypedWithRelationshipsMethod;
			}
			else
			{
				methodInfo = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateWrapperDelegateTypedWithoutRelationshipsMethod;
			}
			methodInfo = methodInfo.MakeGenericMethod(new global::System.Type[]
			{
				entityType
			});
			return (global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>)methodInfo.Invoke(null, new object[0]);
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x000AA8A7 File Offset: 0x000A8AA7
		private static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> CreateWrapperDelegateTypedLightweight<TEntity>() where TEntity : class, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker
		{
			bool overridesEquals = typeof(TEntity).OverridesEqualsOrGetHashCode();
			return (object entity) => new global::System.Data.Entity.Core.Objects.Internal.LightweightEntityWrapper<TEntity>((TEntity)((object)entity), overridesEquals);
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x000AA8D0 File Offset: 0x000A8AD0
		private static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> CreateWrapperDelegateTypedWithRelationships<TEntity>() where TEntity : class, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships
		{
			bool overridesEquals = typeof(TEntity).OverridesEqualsOrGetHashCode();
			global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> propertyAccessorStrategy;
			global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> changeTrackingStrategy;
			global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> keyStrategy;
			global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateStrategies<TEntity>(out propertyAccessorStrategy, out changeTrackingStrategy, out keyStrategy);
			return (object entity) => new global::System.Data.Entity.Core.Objects.Internal.EntityWrapperWithRelationships<TEntity>((TEntity)((object)entity), propertyAccessorStrategy, changeTrackingStrategy, keyStrategy, overridesEquals);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x000AA91C File Offset: 0x000A8B1C
		private static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> CreateWrapperDelegateTypedWithoutRelationships<TEntity>() where TEntity : class
		{
			bool overridesEquals = typeof(TEntity).OverridesEqualsOrGetHashCode();
			global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> propertyAccessorStrategy;
			global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> changeTrackingStrategy;
			global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> keyStrategy;
			global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateStrategies<TEntity>(out propertyAccessorStrategy, out changeTrackingStrategy, out keyStrategy);
			return (object entity) => new global::System.Data.Entity.Core.Objects.Internal.EntityWrapperWithoutRelationships<TEntity>((TEntity)((object)entity), propertyAccessorStrategy, changeTrackingStrategy, keyStrategy, overridesEquals);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x000AA968 File Offset: 0x000A8B68
		private static void CreateStrategies<TEntity>(out global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> createPropertyAccessorStrategy, out global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> createChangeTrackingStrategy, out global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> createKeyStrategy)
		{
			global::System.Type typeFromHandle = typeof(TEntity);
			int num = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships).IsAssignableFrom(typeFromHandle) ? 1 : 0;
			bool flag = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker).IsAssignableFrom(typeFromHandle);
			bool flag2 = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey).IsAssignableFrom(typeFromHandle);
			bool flag3 = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.IsProxyType(typeFromHandle);
			if (num == 0 || flag3)
			{
				createPropertyAccessorStrategy = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.GetPocoPropertyAccessorStrategyFunc();
			}
			else
			{
				createPropertyAccessorStrategy = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.GetNullPropertyAccessorStrategyFunc();
			}
			if (flag)
			{
				createChangeTrackingStrategy = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.GetEntityWithChangeTrackerStrategyFunc();
			}
			else
			{
				createChangeTrackingStrategy = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.GetSnapshotChangeTrackingStrategyFunc();
			}
			if (flag2)
			{
				createKeyStrategy = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.GetEntityWithKeyStrategyStrategyFunc();
				return;
			}
			createKeyStrategy = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.GetPocoEntityKeyStrategyFunc();
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x000AA9F8 File Offset: 0x000A8BF8
		internal global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper WrapEntityUsingContext(object entity, global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			return this.WrapEntityUsingStateManagerGettingEntry(entity, (context == null) ? null : context.ObjectStateManager, out entityEntry);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000AAA1A File Offset: 0x000A8C1A
		internal global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper WrapEntityUsingContextGettingEntry(object entity, global::System.Data.Entity.Core.Objects.ObjectContext context, out global::System.Data.Entity.Core.Objects.EntityEntry existingEntry)
		{
			return this.WrapEntityUsingStateManagerGettingEntry(entity, (context == null) ? null : context.ObjectStateManager, out existingEntry);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000AAA30 File Offset: 0x000A8C30
		internal global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper WrapEntityUsingStateManager(object entity, global::System.Data.Entity.Core.Objects.ObjectStateManager stateManager)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			return this.WrapEntityUsingStateManagerGettingEntry(entity, stateManager, out entityEntry);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x000AAA48 File Offset: 0x000A8C48
		internal virtual global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper WrapEntityUsingStateManagerGettingEntry(object entity, global::System.Data.Entity.Core.Objects.ObjectStateManager stateManager, out global::System.Data.Entity.Core.Objects.EntityEntry existingEntry)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = null;
			existingEntry = null;
			if (entity == null)
			{
				return global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
			}
			if (stateManager != null)
			{
				existingEntry = stateManager.FindEntityEntry(entity);
				if (existingEntry != null)
				{
					return existingEntry.WrappedEntity;
				}
				if (stateManager.TransactionManager.TrackProcessedEntities && stateManager.TransactionManager.WrappedEntities.TryGetValue(entity, out entityWrapper))
				{
					return entityWrapper;
				}
			}
			global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships entityWithRelationships = entity as global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships;
			if (entityWithRelationships == null)
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetProxyWrapper(entity, out entityWrapper);
				if (entityWrapper == null)
				{
					global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey entityWithKey = entity as global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey;
					entityWrapper = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateNewWrapper(entity, (entityWithKey == null) ? null : entityWithKey.EntityKey);
				}
				if (stateManager != null && stateManager.TransactionManager.TrackProcessedEntities)
				{
					stateManager.TransactionManager.WrappedEntities.Add(entity, entityWrapper);
				}
				return entityWrapper;
			}
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager = entityWithRelationships.RelationshipManager;
			if (relationshipManager == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnexpectedNull);
			}
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = relationshipManager.WrappedOwner;
			if (wrappedOwner.Entity != entity)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_InvalidRelationshipManagerOwner);
			}
			return wrappedOwner;
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x000AAB20 File Offset: 0x000A8D20
		internal virtual void UpdateNoTrackingWrapper(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			if (wrapper.EntityKey == null)
			{
				wrapper.EntityKey = context.ObjectStateManager.CreateEntityKey(entitySet, wrapper.Entity);
			}
			if (wrapper.Context == null)
			{
				wrapper.AttachContext(context, entitySet, global::System.Data.Entity.Core.Objects.MergeOption.NoTracking);
			}
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000AAB59 File Offset: 0x000A8D59
		internal static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> GetPocoPropertyAccessorStrategyFunc()
		{
			return (object entity) => new global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy(entity);
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x000AAB7A File Offset: 0x000A8D7A
		internal static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> GetNullPropertyAccessorStrategyFunc()
		{
			return (object entity) => null;
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x000AAB9B File Offset: 0x000A8D9B
		internal static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> GetEntityWithChangeTrackerStrategyFunc()
		{
			return (object entity) => new global::System.Data.Entity.Core.Objects.Internal.EntityWithChangeTrackerStrategy((global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker)entity);
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x000AABBC File Offset: 0x000A8DBC
		internal static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> GetSnapshotChangeTrackingStrategyFunc()
		{
			return (object entity) => global::System.Data.Entity.Core.Objects.Internal.SnapshotChangeTrackingStrategy.Instance;
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x000AABDD File Offset: 0x000A8DDD
		internal static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> GetEntityWithKeyStrategyStrategyFunc()
		{
			return (object entity) => new global::System.Data.Entity.Core.Objects.Internal.EntityWithKeyStrategy((global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey)entity);
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x000AABFE File Offset: 0x000A8DFE
		internal static global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> GetPocoEntityKeyStrategyFunc()
		{
			return (object entity) => new global::System.Data.Entity.Core.Objects.Internal.PocoEntityKeyStrategy();
		}

		// Token: 0x0400113F RID: 4415
		private static readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> _delegateCache = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>(new global::System.Func<global::System.Type, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateWrapperDelegate), null);

		// Token: 0x04001140 RID: 4416
		internal static readonly global::System.Reflection.MethodInfo CreateWrapperDelegateTypedLightweightMethod = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("CreateWrapperDelegateTypedLightweight");

		// Token: 0x04001141 RID: 4417
		internal static readonly global::System.Reflection.MethodInfo CreateWrapperDelegateTypedWithRelationshipsMethod = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("CreateWrapperDelegateTypedWithRelationships");

		// Token: 0x04001142 RID: 4418
		internal static readonly global::System.Reflection.MethodInfo CreateWrapperDelegateTypedWithoutRelationshipsMethod = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("CreateWrapperDelegateTypedWithoutRelationships");
	}
}
