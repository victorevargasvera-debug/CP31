using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A3 RID: 931
	internal sealed class ExistsOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002D3E RID: 11582 RVA: 0x00090BB5 File Offset: 0x0008EDB5
		internal ExistsOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Exists, type)
		{
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00090BC0 File Offset: 0x0008EDC0
		private ExistsOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Exists)
		{
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x00090BCA File Offset: 0x0008EDCA
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00090BCD File Offset: 0x0008EDCD
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00090BD7 File Offset: 0x0008EDD7
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F24 RID: 3876
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp();
	}
}
