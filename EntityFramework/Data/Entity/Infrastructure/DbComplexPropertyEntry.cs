using System;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000220 RID: 544
	public class DbComplexPropertyEntry : global::System.Data.Entity.Infrastructure.DbPropertyEntry
	{
		// Token: 0x06001C8C RID: 7308 RVA: 0x00050CDE File Offset: 0x0004EEDE
		internal new static global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry Create(global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry)
		{
			return (global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry)internalPropertyEntry.CreateDbMemberEntry();
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00050CEB File Offset: 0x0004EEEB
		internal DbComplexPropertyEntry(global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry) : base(internalPropertyEntry)
		{
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		public global::System.Data.Entity.Infrastructure.DbPropertyEntry Property(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbPropertyEntry.Create(((global::System.Data.Entity.Internal.InternalPropertyEntry)this.InternalMemberEntry).Property(propertyName, null, false));
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00050D1A File Offset: 0x0004EF1A
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry ComplexProperty(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry.Create(((global::System.Data.Entity.Internal.InternalPropertyEntry)this.InternalMemberEntry).Property(propertyName, null, true));
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00050D40 File Offset: 0x0004EF40
		public new global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TComplexProperty> Cast<TEntity, TComplexProperty>() where TEntity : class
		{
			global::System.Data.Entity.Internal.MemberEntryMetadata entryMetadata = this.InternalMemberEntry.EntryMetadata;
			if (!typeof(TEntity).IsAssignableFrom(entryMetadata.DeclaringType) || !typeof(TComplexProperty).IsAssignableFrom(entryMetadata.ElementType))
			{
				throw global::System.Data.Entity.Resources.Error.DbMember_BadTypeForCast(typeof(global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry).Name, typeof(TEntity).Name, typeof(TComplexProperty).Name, entryMetadata.DeclaringType.Name, entryMetadata.MemberType.Name);
			}
			return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TComplexProperty>.Create((global::System.Data.Entity.Internal.InternalPropertyEntry)this.InternalMemberEntry);
		}
	}
}
