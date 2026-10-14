using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B8 RID: 952
	internal class MultiStreamNestOp : global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp
	{
		// Token: 0x06002DBD RID: 11709 RVA: 0x00091468 File Offset: 0x0008F668
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00091472 File Offset: 0x0008F672
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x0009147C File Offset: 0x0008F67C
		internal MultiStreamNestOp(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> prefixSortKeys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> collectionInfoList) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.MultiStreamNest, prefixSortKeys, outputVars, collectionInfoList)
		{
		}
	}
}
