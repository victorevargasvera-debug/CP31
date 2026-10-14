using System;
using System.Data.Entity.Internal;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200022E RID: 558
	public class DbPropertyEntry<TEntity, TProperty> : global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> where TEntity : class
	{
		// Token: 0x06001D4E RID: 7502 RVA: 0x00052497 File Offset: 0x00050697
		internal static global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty> Create(global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry)
		{
			return (global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty>)internalPropertyEntry.CreateDbMemberEntry<TEntity, TProperty>();
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000524A4 File Offset: 0x000506A4
		internal DbPropertyEntry(global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry)
		{
			this._internalPropertyEntry = internalPropertyEntry;
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x000524B3 File Offset: 0x000506B3
		public override string Name
		{
			get
			{
				return this._internalPropertyEntry.Name;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x000524C0 File Offset: 0x000506C0
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x000524D2 File Offset: 0x000506D2
		public TProperty OriginalValue
		{
			get
			{
				return (TProperty)((object)this._internalPropertyEntry.OriginalValue);
			}
			set
			{
				this._internalPropertyEntry.OriginalValue = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x000524E5 File Offset: 0x000506E5
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x000524F7 File Offset: 0x000506F7
		public override TProperty CurrentValue
		{
			get
			{
				return (TProperty)((object)this._internalPropertyEntry.CurrentValue);
			}
			set
			{
				this._internalPropertyEntry.CurrentValue = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0005250A File Offset: 0x0005070A
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x00052517 File Offset: 0x00050717
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

		// Token: 0x06001D57 RID: 7511 RVA: 0x00052525 File Offset: 0x00050725
		public static implicit operator global::System.Data.Entity.Infrastructure.DbPropertyEntry(global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty> entry)
		{
			return global::System.Data.Entity.Infrastructure.DbPropertyEntry.Create(entry._internalPropertyEntry);
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00052532 File Offset: 0x00050732
		public override global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> EntityEntry
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>(this._internalPropertyEntry.InternalEntityEntry);
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x00052544 File Offset: 0x00050744
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00052568 File Offset: 0x00050768
		internal global::System.Data.Entity.Internal.InternalPropertyEntry InternalPropertyEntry
		{
			get
			{
				return this._internalPropertyEntry;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00052570 File Offset: 0x00050770
		internal override global::System.Data.Entity.Internal.InternalMemberEntry InternalMemberEntry
		{
			get
			{
				return this.InternalPropertyEntry;
			}
		}

		// Token: 0x04000B1F RID: 2847
		private readonly global::System.Data.Entity.Internal.InternalPropertyEntry _internalPropertyEntry;
	}
}
