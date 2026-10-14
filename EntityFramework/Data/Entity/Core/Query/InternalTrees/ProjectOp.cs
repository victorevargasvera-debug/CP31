using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003CF RID: 975
	internal sealed class ProjectOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002E9F RID: 11935 RVA: 0x00093D66 File Offset: 0x00091F66
		private ProjectOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
		{
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00093D70 File Offset: 0x00091F70
		internal ProjectOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars) : this()
		{
			this.m_vars = vars;
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00093D7F File Offset: 0x00091F7F
		internal override int Arity
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x00093D82 File Offset: 0x00091F82
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Outputs
		{
			get
			{
				return this.m_vars;
			}
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00093D8A File Offset: 0x00091F8A
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00093D94 File Offset: 0x00091F94
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FBB RID: 4027
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_vars;

		// Token: 0x04000FBC RID: 4028
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp();
	}
}
