using System;
using System.Data.Entity.Internal;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000236 RID: 566
	public class DbReferenceEntry<TEntity, TProperty> : global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> where TEntity : class
	{
		// Token: 0x06001DFC RID: 7676 RVA: 0x00053127 File Offset: 0x00051327
		internal static global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty> Create(global::System.Data.Entity.Internal.InternalReferenceEntry internalReferenceEntry)
		{
			return (global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty>)internalReferenceEntry.CreateDbMemberEntry<TEntity, TProperty>();
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00053134 File Offset: 0x00051334
		internal DbReferenceEntry(global::System.Data.Entity.Internal.InternalReferenceEntry internalReferenceEntry)
		{
			this._internalReferenceEntry = internalReferenceEntry;
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00053143 File Offset: 0x00051343
		public override string Name
		{
			get
			{
				return this._internalReferenceEntry.Name;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00053150 File Offset: 0x00051350
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x00053162 File Offset: 0x00051362
		public override TProperty CurrentValue
		{
			get
			{
				return (TProperty)((object)this._internalReferenceEntry.CurrentValue);
			}
			set
			{
				this._internalReferenceEntry.CurrentValue = value;
			}
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00053175 File Offset: 0x00051375
		public void Load()
		{
			this._internalReferenceEntry.Load();
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00053182 File Offset: 0x00051382
		public global::System.Threading.Tasks.Task LoadAsync()
		{
			return this.LoadAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0005318F File Offset: 0x0005138F
		public global::System.Threading.Tasks.Task LoadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this._internalReferenceEntry.LoadAsync(cancellationToken);
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x0005319D File Offset: 0x0005139D
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x000531AA File Offset: 0x000513AA
		public bool IsLoaded
		{
			get
			{
				return this._internalReferenceEntry.IsLoaded;
			}
			set
			{
				this._internalReferenceEntry.IsLoaded = value;
			}
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x000531B8 File Offset: 0x000513B8
		public global::System.Linq.IQueryable<TProperty> Query()
		{
			return (global::System.Linq.IQueryable<TProperty>)this._internalReferenceEntry.Query();
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x000531CA File Offset: 0x000513CA
		public static implicit operator global::System.Data.Entity.Infrastructure.DbReferenceEntry(global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty> entry)
		{
			return global::System.Data.Entity.Infrastructure.DbReferenceEntry.Create(entry._internalReferenceEntry);
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000531D7 File Offset: 0x000513D7
		internal override global::System.Data.Entity.Internal.InternalMemberEntry InternalMemberEntry
		{
			get
			{
				return this._internalReferenceEntry;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x000531DF File Offset: 0x000513DF
		public override global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> EntityEntry
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>(this._internalReferenceEntry.InternalEntityEntry);
			}
		}

		// Token: 0x04000B29 RID: 2857
		private readonly global::System.Data.Entity.Internal.InternalReferenceEntry _internalReferenceEntry;
	}
}
