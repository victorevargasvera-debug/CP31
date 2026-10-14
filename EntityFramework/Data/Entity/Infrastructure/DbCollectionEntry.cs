using System;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200021D RID: 541
	public class DbCollectionEntry : global::System.Data.Entity.Infrastructure.DbMemberEntry
	{
		// Token: 0x06001C67 RID: 7271 RVA: 0x00050803 File Offset: 0x0004EA03
		internal static global::System.Data.Entity.Infrastructure.DbCollectionEntry Create(global::System.Data.Entity.Internal.InternalCollectionEntry internalCollectionEntry)
		{
			return (global::System.Data.Entity.Infrastructure.DbCollectionEntry)internalCollectionEntry.CreateDbMemberEntry();
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00050810 File Offset: 0x0004EA10
		internal DbCollectionEntry(global::System.Data.Entity.Internal.InternalCollectionEntry internalCollectionEntry)
		{
			this._internalCollectionEntry = internalCollectionEntry;
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x0005081F File Offset: 0x0004EA1F
		public override string Name
		{
			get
			{
				return this._internalCollectionEntry.Name;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x0005082C File Offset: 0x0004EA2C
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x00050839 File Offset: 0x0004EA39
		public override object CurrentValue
		{
			get
			{
				return this._internalCollectionEntry.CurrentValue;
			}
			set
			{
				this._internalCollectionEntry.CurrentValue = value;
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00050847 File Offset: 0x0004EA47
		public void Load()
		{
			this._internalCollectionEntry.Load();
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00050854 File Offset: 0x0004EA54
		public global::System.Threading.Tasks.Task LoadAsync()
		{
			return this.LoadAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x00050861 File Offset: 0x0004EA61
		public global::System.Threading.Tasks.Task LoadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this._internalCollectionEntry.LoadAsync(cancellationToken);
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x0005086F File Offset: 0x0004EA6F
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0005087C File Offset: 0x0004EA7C
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

		// Token: 0x06001C71 RID: 7281 RVA: 0x0005088A File Offset: 0x0004EA8A
		public global::System.Linq.IQueryable Query()
		{
			return this._internalCollectionEntry.Query();
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00050897 File Offset: 0x0004EA97
		public override global::System.Data.Entity.Infrastructure.DbEntityEntry EntityEntry
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbEntityEntry(this._internalCollectionEntry.InternalEntityEntry);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x000508A9 File Offset: 0x0004EAA9
		internal override global::System.Data.Entity.Internal.InternalMemberEntry InternalMemberEntry
		{
			get
			{
				return this._internalCollectionEntry;
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x000508B4 File Offset: 0x0004EAB4
		public new global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement> Cast<TEntity, TElement>() where TEntity : class
		{
			global::System.Data.Entity.Internal.MemberEntryMetadata entryMetadata = this._internalCollectionEntry.EntryMetadata;
			if (!typeof(TEntity).IsAssignableFrom(entryMetadata.DeclaringType) || !typeof(TElement).IsAssignableFrom(entryMetadata.ElementType))
			{
				throw global::System.Data.Entity.Resources.Error.DbMember_BadTypeForCast(typeof(global::System.Data.Entity.Infrastructure.DbCollectionEntry).Name, typeof(TEntity).Name, typeof(TElement).Name, entryMetadata.DeclaringType.Name, entryMetadata.ElementType.Name);
			}
			return global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement>.Create(this._internalCollectionEntry);
		}

		// Token: 0x04000AF3 RID: 2803
		private readonly global::System.Data.Entity.Internal.InternalCollectionEntry _internalCollectionEntry;
	}
}
