using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E4 RID: 996
	internal class SimpleCollectionColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap
	{
		// Token: 0x06002F06 RID: 12038 RVA: 0x00094534 File Offset: 0x00092734
		internal SimpleCollectionColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap elementMap, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keys, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] foreignKeys) : base(type, name, elementMap, keys, foreignKeys)
		{
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00094543 File Offset: 0x00092743
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x0009454D File Offset: 0x0009274D
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}
	}
}
