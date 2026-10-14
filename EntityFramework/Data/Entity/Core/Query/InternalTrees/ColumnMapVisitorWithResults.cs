using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200038B RID: 907
	internal abstract class ColumnMapVisitorWithResults<TResultType, TArgType>
	{
		// Token: 0x06002C08 RID: 11272 RVA: 0x0008E09C File Offset: 0x0008C29C
		protected global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity, TArgType arg)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity discriminatedEntityIdentity = entityIdentity as global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity;
			if (discriminatedEntityIdentity != null)
			{
				return this.VisitEntityIdentity(discriminatedEntityIdentity, arg);
			}
			return this.VisitEntityIdentity((global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity)entityIdentity, arg);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0008E0C9 File Offset: 0x0008C2C9
		protected virtual global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity entityIdentity, TArgType arg)
		{
			return entityIdentity;
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x0008E0CC File Offset: 0x0008C2CC
		protected virtual global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity entityIdentity, TArgType arg)
		{
			return entityIdentity;
		}

		// Token: 0x06002C0B RID: 11275
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap columnMap, TArgType arg);

		// Token: 0x06002C0C RID: 11276
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap columnMap, TArgType arg);

		// Token: 0x06002C0D RID: 11277
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap columnMap, TArgType arg);

		// Token: 0x06002C0E RID: 11278
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap columnMap, TArgType arg);

		// Token: 0x06002C0F RID: 11279
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, TArgType arg);

		// Token: 0x06002C10 RID: 11280
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap columnMap, TArgType arg);

		// Token: 0x06002C11 RID: 11281
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap columnMap, TArgType arg);

		// Token: 0x06002C12 RID: 11282
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap, TArgType arg);

		// Token: 0x06002C13 RID: 11283
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, TArgType arg);

		// Token: 0x06002C14 RID: 11284
		internal abstract TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap columnMap, TArgType arg);
	}
}
