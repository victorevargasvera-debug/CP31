using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Validation;
using System.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000229 RID: 553
	public abstract class DbMemberEntry
	{
		// Token: 0x06001D17 RID: 7447 RVA: 0x00052129 File Offset: 0x00050329
		internal static global::System.Data.Entity.Infrastructure.DbMemberEntry Create(global::System.Data.Entity.Internal.InternalMemberEntry internalMemberEntry)
		{
			return internalMemberEntry.CreateDbMemberEntry();
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001D18 RID: 7448
		public abstract string Name { get; }

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001D19 RID: 7449
		// (set) Token: 0x06001D1A RID: 7450
		public abstract object CurrentValue { get; set; }

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001D1B RID: 7451
		public abstract global::System.Data.Entity.Infrastructure.DbEntityEntry EntityEntry { get; }

		// Token: 0x06001D1C RID: 7452 RVA: 0x00052131 File Offset: 0x00050331
		public global::System.Collections.Generic.ICollection<global::System.Data.Entity.Validation.DbValidationError> GetValidationErrors()
		{
			return this.InternalMemberEntry.GetValidationErrors().ToList<global::System.Data.Entity.Validation.DbValidationError>();
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00052143 File Offset: 0x00050343
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0005214B File Offset: 0x0005034B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00052154 File Offset: 0x00050354
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x0005215C File Offset: 0x0005035C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001D21 RID: 7457
		internal abstract global::System.Data.Entity.Internal.InternalMemberEntry InternalMemberEntry { get; }

		// Token: 0x06001D22 RID: 7458 RVA: 0x00052164 File Offset: 0x00050364
		public global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> Cast<TEntity, TProperty>() where TEntity : class
		{
			global::System.Data.Entity.Internal.MemberEntryMetadata entryMetadata = this.InternalMemberEntry.EntryMetadata;
			if (!typeof(TEntity).IsAssignableFrom(entryMetadata.DeclaringType) || !typeof(TProperty).IsAssignableFrom(entryMetadata.MemberType))
			{
				throw global::System.Data.Entity.Resources.Error.DbMember_BadTypeForCast(typeof(global::System.Data.Entity.Infrastructure.DbMemberEntry).Name, typeof(TEntity).Name, typeof(TProperty).Name, entryMetadata.DeclaringType.Name, entryMetadata.MemberType.Name);
			}
			return global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty>.Create(this.InternalMemberEntry);
		}
	}
}
