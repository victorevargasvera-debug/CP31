using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003BD RID: 957
	internal sealed class NewInstanceOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002DD8 RID: 11736 RVA: 0x000915A9 File Offset: 0x0008F7A9
		internal NewInstanceOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewInstance, type)
		{
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x000915B4 File Offset: 0x0008F7B4
		private NewInstanceOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewInstance)
		{
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000915BE File Offset: 0x0008F7BE
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x000915C8 File Offset: 0x0008F7C8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F56 RID: 3926
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp();
	}
}
