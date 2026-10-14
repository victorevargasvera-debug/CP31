using System;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200022D RID: 557
	public class DbPropertyEntry : global::System.Data.Entity.Infrastructure.DbMemberEntry
	{
		// Token: 0x06001D41 RID: 7489 RVA: 0x00052341 File Offset: 0x00050541
		internal static global::System.Data.Entity.Infrastructure.DbPropertyEntry Create(global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry)
		{
			return (global::System.Data.Entity.Infrastructure.DbPropertyEntry)internalPropertyEntry.CreateDbMemberEntry();
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0005234E File Offset: 0x0005054E
		internal DbPropertyEntry(global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry)
		{
			this._internalPropertyEntry = internalPropertyEntry;
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0005235D File Offset: 0x0005055D
		public override string Name
		{
			get
			{
				return this._internalPropertyEntry.Name;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0005236A File Offset: 0x0005056A
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00052377 File Offset: 0x00050577
		public object OriginalValue
		{
			get
			{
				return this._internalPropertyEntry.OriginalValue;
			}
			set
			{
				this._internalPropertyEntry.OriginalValue = value;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00052385 File Offset: 0x00050585
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x00052392 File Offset: 0x00050592
		public override object CurrentValue
		{
			get
			{
				return this._internalPropertyEntry.CurrentValue;
			}
			set
			{
				this._internalPropertyEntry.CurrentValue = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x000523A0 File Offset: 0x000505A0
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x000523AD File Offset: 0x000505AD
		public bool IsModified
		{
			get
			{
				return this._internalPropertyEntry.IsModified;
			}
			set
			{
				this._internalPropertyEntry.IsModified = value;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x000523BB File Offset: 0x000505BB
		public override global::System.Data.Entity.Infrastructure.DbEntityEntry EntityEntry
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbEntityEntry(this._internalPropertyEntry.InternalEntityEntry);
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x000523D0 File Offset: 0x000505D0
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry ParentProperty
		{
			get
			{
				global::System.Data.Entity.Internal.InternalPropertyEntry parentPropertyEntry = this._internalPropertyEntry.ParentPropertyEntry;
				if (parentPropertyEntry == null)
				{
					return null;
				}
				return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry.Create(parentPropertyEntry);
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x000523F4 File Offset: 0x000505F4
		internal override global::System.Data.Entity.Internal.InternalMemberEntry InternalMemberEntry
		{
			get
			{
				return this._internalPropertyEntry;
			}
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x000523FC File Offset: 0x000505FC
		public new global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty> Cast<TEntity, TProperty>() where TEntity : class
		{
			global::System.Data.Entity.Internal.PropertyEntryMetadata entryMetadata = this._internalPropertyEntry.EntryMetadata;
			if (!typeof(TEntity).IsAssignableFrom(entryMetadata.DeclaringType) || !typeof(TProperty).IsAssignableFrom(entryMetadata.ElementType))
			{
				throw global::System.Data.Entity.Resources.Error.DbMember_BadTypeForCast(typeof(global::System.Data.Entity.Infrastructure.DbPropertyEntry).Name, typeof(TEntity).Name, typeof(TProperty).Name, entryMetadata.DeclaringType.Name, entryMetadata.MemberType.Name);
			}
			return global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty>.Create(this._internalPropertyEntry);
		}

		// Token: 0x04000B1E RID: 2846
		private readonly global::System.Data.Entity.Internal.InternalPropertyEntry _internalPropertyEntry;
	}
}
