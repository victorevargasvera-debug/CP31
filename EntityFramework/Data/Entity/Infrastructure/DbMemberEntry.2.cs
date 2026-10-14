using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Validation;
using System.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200022A RID: 554
	public abstract class DbMemberEntry<TEntity, TProperty> where TEntity : class
	{
		// Token: 0x06001D24 RID: 7460 RVA: 0x00052207 File Offset: 0x00050407
		internal static global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> Create(global::System.Data.Entity.Internal.InternalMemberEntry internalMemberEntry)
		{
			return internalMemberEntry.CreateDbMemberEntry<TEntity, TProperty>();
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001D25 RID: 7461
		public abstract string Name { get; }

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001D26 RID: 7462
		// (set) Token: 0x06001D27 RID: 7463
		public abstract TProperty CurrentValue { get; set; }

		// Token: 0x06001D28 RID: 7464 RVA: 0x0005220F File Offset: 0x0005040F
		public static implicit operator global::System.Data.Entity.Infrastructure.DbMemberEntry(global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> entry)
		{
			return global::System.Data.Entity.Infrastructure.DbMemberEntry.Create(entry.InternalMemberEntry);
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001D29 RID: 7465
		internal abstract global::System.Data.Entity.Internal.InternalMemberEntry InternalMemberEntry { get; }

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001D2A RID: 7466
		public abstract global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> EntityEntry { get; }

		// Token: 0x06001D2B RID: 7467 RVA: 0x0005221C File Offset: 0x0005041C
		public global::System.Collections.Generic.ICollection<global::System.Data.Entity.Validation.DbValidationError> GetValidationErrors()
		{
			return this.InternalMemberEntry.GetValidationErrors().ToList<global::System.Data.Entity.Validation.DbValidationError>();
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x0005222E File Offset: 0x0005042E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00052236 File Offset: 0x00050436
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x0005223F File Offset: 0x0005043F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00052247 File Offset: 0x00050447
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
