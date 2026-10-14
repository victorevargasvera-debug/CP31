using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000104 RID: 260
	internal class InternalCollectionEntry : global::System.Data.Entity.Internal.InternalNavigationEntry
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x0002FADD File Offset: 0x0002DCDD
		public InternalCollectionEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.NavigationEntryMetadata navigationMetadata) : base(internalEntityEntry, navigationMetadata)
		{
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0002FAE7 File Offset: 0x0002DCE7
		protected override object GetNavigationPropertyFromRelatedEnd(object entity)
		{
			return base.RelatedEnd;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x0002FAEF File Offset: 0x0002DCEF
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x0002FAF8 File Offset: 0x0002DCF8
		public override object CurrentValue
		{
			get
			{
				return base.CurrentValue;
			}
			set
			{
				if (base.Setter != null)
				{
					base.Setter(this.InternalEntityEntry.Entity, value);
					return;
				}
				if (this.InternalEntityEntry.IsDetached || base.RelatedEnd != value)
				{
					throw global::System.Data.Entity.Resources.Error.DbCollectionEntry_CannotSetCollectionProp(this.Name, this.InternalEntityEntry.Entity.GetType().ToString());
				}
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0002FB5C File Offset: 0x0002DD5C
		public override global::System.Data.Entity.Infrastructure.DbMemberEntry CreateDbMemberEntry()
		{
			return new global::System.Data.Entity.Infrastructure.DbCollectionEntry(this);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0002FB64 File Offset: 0x0002DD64
		public override global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> CreateDbMemberEntry<TEntity, TProperty>()
		{
			return this.CreateDbCollectionEntry<TEntity, TProperty>(this.EntryMetadata.ElementType);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0002FB77 File Offset: 0x0002DD77
		public virtual global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement> CreateDbCollectionEntry<TEntity, TElement>() where TEntity : class
		{
			return new global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement>(this);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0002FB80 File Offset: 0x0002DD80
		private global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> CreateDbCollectionEntry<TEntity, TProperty>(global::System.Type elementType) where TEntity : class
		{
			global::System.Type typeFromHandle = typeof(global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty>);
			global::System.Func<global::System.Data.Entity.Internal.InternalCollectionEntry, object> func;
			if (!global::System.Data.Entity.Internal.InternalCollectionEntry._entryFactories.TryGetValue(typeFromHandle, out func))
			{
				global::System.Type type = typeof(global::System.Data.Entity.Infrastructure.DbCollectionEntry<, >).MakeGenericType(new global::System.Type[]
				{
					typeof(TEntity),
					elementType
				});
				if (!typeFromHandle.IsAssignableFrom(type))
				{
					throw global::System.Data.Entity.Resources.Error.DbEntityEntry_WrongGenericForCollectionNavProp(typeof(TProperty), this.Name, this.EntryMetadata.DeclaringType, typeof(global::System.Collections.Generic.ICollection<>).MakeGenericType(new global::System.Type[]
					{
						elementType
					}));
				}
				global::System.Reflection.MethodInfo declaredMethod = type.GetDeclaredMethod("Create", new global::System.Type[]
				{
					typeof(global::System.Data.Entity.Internal.InternalCollectionEntry)
				});
				func = (global::System.Func<global::System.Data.Entity.Internal.InternalCollectionEntry, object>)global::System.Delegate.CreateDelegate(typeof(global::System.Func<global::System.Data.Entity.Internal.InternalCollectionEntry, object>), declaredMethod);
				global::System.Data.Entity.Internal.InternalCollectionEntry._entryFactories.TryAdd(typeFromHandle, func);
			}
			return (global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty>)func(this);
		}

		// Token: 0x0400092B RID: 2347
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalCollectionEntry, object>> _entryFactories = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalCollectionEntry, object>>();
	}
}
