using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003AF RID: 943
	internal sealed class InternalConstantOp : global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp
	{
		// Token: 0x06002D8B RID: 11659 RVA: 0x000910A3 File Offset: 0x0008F2A3
		internal InternalConstantOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, object value) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant, type, value)
		{
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x000910AE File Offset: 0x0008F2AE
		private InternalConstantOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant)
		{
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x000910B7 File Offset: 0x0008F2B7
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x000910C1 File Offset: 0x0008F2C1
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F3E RID: 3902
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp();
	}
}
