using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F7 RID: 1015
	internal sealed class UnnestOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002F5F RID: 12127 RVA: 0x00094D5C File Offset: 0x00092F5C
		internal UnnestOp(global::System.Data.Entity.Core.Query.InternalTrees.Var v, global::System.Data.Entity.Core.Query.InternalTrees.Table t) : this()
		{
			this.m_var = v;
			this.m_table = t;
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00094D72 File Offset: 0x00092F72
		private UnnestOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Unnest)
		{
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x00094D7C File Offset: 0x00092F7C
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var Var
		{
			get
			{
				return this.m_var;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x00094D84 File Offset: 0x00092F84
		internal global::System.Data.Entity.Core.Query.InternalTrees.Table Table
		{
			get
			{
				return this.m_table;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x00094D8C File Offset: 0x00092F8C
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x00094D8F File Offset: 0x00092F8F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00094D99 File Offset: 0x00092F99
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FFD RID: 4093
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Table m_table;

		// Token: 0x04000FFE RID: 4094
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var m_var;

		// Token: 0x04000FFF RID: 4095
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp();
	}
}
