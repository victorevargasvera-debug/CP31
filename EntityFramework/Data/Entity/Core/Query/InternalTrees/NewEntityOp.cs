using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003BC RID: 956
	internal sealed class NewEntityOp : global::System.Data.Entity.Core.Query.InternalTrees.NewEntityBaseOp
	{
		// Token: 0x06002DD3 RID: 11731 RVA: 0x00091570 File Offset: 0x0008F770
		private NewEntityOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewEntity)
		{
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x0009157A File Offset: 0x0008F77A
		internal NewEntityOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> relProperties, bool scoped, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewEntity, type, scoped, entitySet, relProperties)
		{
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00091589 File Offset: 0x0008F789
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00091593 File Offset: 0x0008F793
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F55 RID: 3925
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp();
	}
}
