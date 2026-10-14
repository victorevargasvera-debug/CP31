using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E0 RID: 992
	internal sealed class ScanTableOp : global::System.Data.Entity.Core.Query.InternalTrees.ScanTableBaseOp
	{
		// Token: 0x06002EF4 RID: 12020 RVA: 0x0009446E File Offset: 0x0009266E
		internal ScanTableOp(global::System.Data.Entity.Core.Query.InternalTrees.Table table) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable, table)
		{
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00094479 File Offset: 0x00092679
		private ScanTableOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable)
		{
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x00094483 File Offset: 0x00092683
		internal override int Arity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00094486 File Offset: 0x00092686
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00094490 File Offset: 0x00092690
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FD6 RID: 4054
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp();
	}
}
