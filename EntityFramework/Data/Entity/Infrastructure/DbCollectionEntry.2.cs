using System;
using System.Collections.Generic;
using System.Data.Entity.Internal;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200021E RID: 542
	public class DbCollectionEntry<TEntity, TElement> : global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, global::System.Collections.Generic.ICollection<TElement>> where TEntity : class
	{
		// Token: 0x06001C75 RID: 7285 RVA: 0x0005094F File Offset: 0x0004EB4F
		internal static global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement> Create(global::System.Data.Entity.Internal.InternalCollectionEntry internalCollectionEntry)
		{
			return internalCollectionEntry.CreateDbCollectionEntry<TEntity, TElement>();
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00050957 File Offset: 0x0004EB57
		internal DbCollectionEntry(global::System.Data.Entity.Internal.InternalCollectionEntry internalCollectionEntry)
		{
			this._internalCollectionEntry = internalCollectionEntry;
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00050966 File Offset: 0x0004EB66
		public override string Name
		{
			get
			{
				return this._internalCollectionEntry.Name;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00050973 File Offset: 0x0004EB73
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x00050985 File Offset: 0x0004EB85
		public override global::System.Collections.Generic.ICollection<TElement> CurrentValue
		{
			get
			{
				return (global::System.Collections.Generic.ICollection<TElement>)this._internalCollectionEntry.CurrentValue;
			}
			set
			{
				this._internalCollectionEntry.CurrentValue = value;
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00050993 File Offset: 0x0004EB93
		public void Load()
		{
			this._internalCollectionEntry.Load();
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x000509A0 File Offset: 0x0004EBA0
		public global::System.Threading.Tasks.Task LoadAsync()
		{
			return this.LoadAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000509AD File Offset: 0x0004EBAD
		public global::System.Threading.Tasks.Task LoadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this._internalCollectionEntry.LoadAsync(cancellationToken);
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x000509BB File Offset: 0x0004EBBB
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x000509C8 File Offset: 0x0004EBC8
		public bool IsLoaded
		{
			get
			{
				return this._internalCollectionEntry.IsLoaded;
			}
			set
			{
				this._internalCollectionEntry.IsLoaded = value;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000509D6 File Offset: 0x0004EBD6
		public global::System.Linq.IQueryable<TElement> Query()
		{
			return (global::System.Linq.IQueryable<TElement>)this._internalCollectionEntry.Query();
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000509E8 File Offset: 0x0004EBE8
		public static implicit operator global::System.Data.Entity.Infrastructure.DbCollectionEntry(global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement> entry)
		{
			return global::System.Data.Entity.Infrastructure.DbCollectionEntry.Create(entry._internalCollectionEntry);
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x000509F5 File Offset: 0x0004EBF5
		internal override global::System.Data.Entity.Internal.InternalMemberEntry InternalMemberEntry
		{
			get
			{
				return this._internalCollectionEntry;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x000509FD File Offset: 0x0004EBFD
		public override global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> EntityEntry
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>(this._internalCollectionEntry.InternalEntityEntry);
			}
		}

		// Token: 0x04000AF4 RID: 2804
		private readonly global::System.Data.Entity.Internal.InternalCollectionEntry _internalCollectionEntry;
	}
}
