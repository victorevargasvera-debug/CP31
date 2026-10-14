using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A8 RID: 936
	internal sealed class FunctionOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002D61 RID: 11617 RVA: 0x00090EBF File Offset: 0x0008F0BF
		internal FunctionOp(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function, function.ReturnParameter.TypeUsage)
		{
			this.m_function = function;
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00090EDB File Offset: 0x0008F0DB
		private FunctionOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function)
		{
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00090EE5 File Offset: 0x0008F0E5
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmFunction Function
		{
			get
			{
				return this.m_function;
			}
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00090EF0 File Offset: 0x0008F0F0
		internal override bool IsEquivalent(global::System.Data.Entity.Core.Query.InternalTrees.Op other)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp functionOp = other as global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp;
			return functionOp != null && functionOp.Function.EdmEquals(this.Function);
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00090F1A File Offset: 0x0008F11A
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00090F24 File Offset: 0x0008F124
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F33 RID: 3891
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction m_function;

		// Token: 0x04000F34 RID: 3892
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp();
	}
}
