using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003EC RID: 1004
	internal sealed class SoftCastOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002F26 RID: 12070 RVA: 0x000947F9 File Offset: 0x000929F9
		internal SoftCastOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast, type)
		{
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00094804 File Offset: 0x00092A04
		private SoftCastOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast)
		{
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x0009480E File Offset: 0x00092A0E
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00094811 File Offset: 0x00092A11
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x0009481B File Offset: 0x00092A1B
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FE4 RID: 4068
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp();
	}
}
