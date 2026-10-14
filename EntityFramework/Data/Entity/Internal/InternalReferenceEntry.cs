using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200010C RID: 268
	internal class InternalReferenceEntry : global::System.Data.Entity.Internal.InternalNavigationEntry
	{
		// Token: 0x0600131B RID: 4891 RVA: 0x00031470 File Offset: 0x0002F670
		public InternalReferenceEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.NavigationEntryMetadata navigationMetadata) : base(internalEntityEntry, navigationMetadata)
		{
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0003147C File Offset: 0x0002F67C
		protected override object GetNavigationPropertyFromRelatedEnd(object entity)
		{
			global::System.Collections.IEnumerator enumerator = base.RelatedEnd.GetEnumerator();
			if (!enumerator.MoveNext())
			{
				return null;
			}
			return enumerator.Current;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000314A8 File Offset: 0x0002F6A8
		protected virtual void SetNavigationPropertyOnRelatedEnd(object value)
		{
			global::System.Type type = base.RelatedEnd.GetType();
			global::System.Action<global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd, object> action;
			if (!global::System.Data.Entity.Internal.InternalReferenceEntry._entityReferenceValueSetters.TryGetValue(type, out action))
			{
				global::System.Reflection.MethodInfo method = global::System.Data.Entity.Internal.InternalReferenceEntry.SetValueOnEntityReferenceMethod.MakeGenericMethod(new global::System.Type[]
				{
					type.GetGenericArguments().Single<global::System.Type>()
				});
				action = (global::System.Action<global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd, object>)global::System.Delegate.CreateDelegate(typeof(global::System.Action<global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd, object>), method);
				global::System.Data.Entity.Internal.InternalReferenceEntry._entityReferenceValueSetters.TryAdd(type, action);
			}
			action(base.RelatedEnd, value);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0003151F File Offset: 0x0002F71F
		private static void SetValueOnEntityReference<TRelatedEntity>(global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd entityReference, object value) where TRelatedEntity : class
		{
			((global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TRelatedEntity>)entityReference).Value = (TRelatedEntity)((object)value);
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x00031532 File Offset: 0x0002F732
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x0003153C File Offset: 0x0002F73C
		public override object CurrentValue
		{
			get
			{
				return base.CurrentValue;
			}
			set
			{
				if (base.RelatedEnd != null && this.InternalEntityEntry.State != global::System.Data.Entity.EntityState.Deleted)
				{
					this.SetNavigationPropertyOnRelatedEnd(value);
					return;
				}
				if (base.Setter != null)
				{
					base.Setter(this.InternalEntityEntry.Entity, value);
					return;
				}
				throw global::System.Data.Entity.Resources.Error.DbPropertyEntry_SettingEntityRefNotSupported(this.Name, this.InternalEntityEntry.EntityType.Name, this.InternalEntityEntry.State);
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000315B2 File Offset: 0x0002F7B2
		public override global::System.Data.Entity.Infrastructure.DbMemberEntry CreateDbMemberEntry()
		{
			return new global::System.Data.Entity.Infrastructure.DbReferenceEntry(this);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000315BA File Offset: 0x0002F7BA
		public override global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> CreateDbMemberEntry<TEntity, TProperty>()
		{
			return new global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty>(this);
		}

		// Token: 0x04000941 RID: 2369
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Action<global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd, object>> _entityReferenceValueSetters = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Action<global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd, object>>();

		// Token: 0x04000942 RID: 2370
		public static readonly global::System.Reflection.MethodInfo SetValueOnEntityReferenceMethod = typeof(global::System.Data.Entity.Internal.InternalReferenceEntry).GetOnlyDeclaredMethod("SetValueOnEntityReference");
	}
}
