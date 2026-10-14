using System;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000235 RID: 565
	public class DbReferenceEntry : global::System.Data.Entity.Infrastructure.DbMemberEntry
	{
		// Token: 0x06001DEE RID: 7662 RVA: 0x00052FDE File Offset: 0x000511DE
		internal static global::System.Data.Entity.Infrastructure.DbReferenceEntry Create(global::System.Data.Entity.Internal.InternalReferenceEntry internalReferenceEntry)
		{
			return (global::System.Data.Entity.Infrastructure.DbReferenceEntry)internalReferenceEntry.CreateDbMemberEntry();
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00052FEB File Offset: 0x000511EB
		internal DbReferenceEntry(global::System.Data.Entity.Internal.InternalReferenceEntry internalReferenceEntry)
		{
			this._internalReferenceEntry = internalReferenceEntry;
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00052FFA File Offset: 0x000511FA
		public override string Name
		{
			get
			{
				return this._internalReferenceEntry.Name;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00053007 File Offset: 0x00051207
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x00053014 File Offset: 0x00051214
		public override object CurrentValue
		{
			get
			{
				return this._internalReferenceEntry.CurrentValue;
			}
			set
			{
				this._internalReferenceEntry.CurrentValue = value;
			}
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00053022 File Offset: 0x00051222
		public void Load()
		{
			this._internalReferenceEntry.Load();
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0005302F File Offset: 0x0005122F
		public global::System.Threading.Tasks.Task LoadAsync()
		{
			return this.LoadAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0005303C File Offset: 0x0005123C
		public global::System.Threading.Tasks.Task LoadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this._internalReferenceEntry.LoadAsync(cancellationToken);
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x0005304A File Offset: 0x0005124A
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x00053057 File Offset: 0x00051257
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

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00053065 File Offset: 0x00051265
		public global::System.Linq.IQueryable Query()
		{
			return this._internalReferenceEntry.Query();
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00053072 File Offset: 0x00051272
		public override global::System.Data.Entity.Infrastructure.DbEntityEntry EntityEntry
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbEntityEntry(this._internalReferenceEntry.InternalEntityEntry);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x00053084 File Offset: 0x00051284
		internal override global::System.Data.Entity.Internal.InternalMemberEntry InternalMemberEntry
		{
			get
			{
				return this._internalReferenceEntry;
			}
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0005308C File Offset: 0x0005128C
		public new global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty> Cast<TEntity, TProperty>() where TEntity : class
		{
			global::System.Data.Entity.Internal.MemberEntryMetadata entryMetadata = this._internalReferenceEntry.EntryMetadata;
			if (!typeof(TEntity).IsAssignableFrom(entryMetadata.DeclaringType) || !typeof(TProperty).IsAssignableFrom(entryMetadata.ElementType))
			{
				throw global::System.Data.Entity.Resources.Error.DbMember_BadTypeForCast(typeof(global::System.Data.Entity.Infrastructure.DbReferenceEntry).Name, typeof(TEntity).Name, typeof(TProperty).Name, entryMetadata.DeclaringType.Name, entryMetadata.MemberType.Name);
			}
			return global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty>.Create(this._internalReferenceEntry);
		}

		// Token: 0x04000B28 RID: 2856
		private readonly global::System.Data.Entity.Internal.InternalReferenceEntry _internalReferenceEntry;
	}
}
