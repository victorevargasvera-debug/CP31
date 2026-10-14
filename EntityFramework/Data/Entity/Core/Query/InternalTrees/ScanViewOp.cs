using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E1 RID: 993
	internal sealed class ScanViewOp : global::System.Data.Entity.Core.Query.InternalTrees.ScanTableBaseOp
	{
		// Token: 0x06002EFA RID: 12026 RVA: 0x000944A6 File Offset: 0x000926A6
		internal ScanViewOp(global::System.Data.Entity.Core.Query.InternalTrees.Table table) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanView, table)
		{
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000944B1 File Offset: 0x000926B1
		private ScanViewOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanView)
		{
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x000944BB File Offset: 0x000926BB
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x000944BE File Offset: 0x000926BE
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x000944C8 File Offset: 0x000926C8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FD7 RID: 4055
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp();
	}
}
