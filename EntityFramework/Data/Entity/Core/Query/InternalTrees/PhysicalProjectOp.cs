using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003CE RID: 974
	internal class PhysicalProjectOp : global::System.Data.Entity.Core.Query.InternalTrees.PhysicalOp
	{
		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x00093D16 File Offset: 0x00091F16
		internal global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap ColumnMap
		{
			get
			{
				return this.m_columnMap;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x00093D1E File Offset: 0x00091F1E
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarList Outputs
		{
			get
			{
				return this.m_outputVars;
			}
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00093D26 File Offset: 0x00091F26
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00093D30 File Offset: 0x00091F30
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00093D3A File Offset: 0x00091F3A
		internal PhysicalProjectOp(global::System.Data.Entity.Core.Query.InternalTrees.VarList outputVars, global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap) : this()
		{
			this.m_outputVars = outputVars;
			this.m_columnMap = columnMap;
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00093D50 File Offset: 0x00091F50
		private PhysicalProjectOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject)
		{
		}

		// Token: 0x04000FB8 RID: 4024
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp();

		// Token: 0x04000FB9 RID: 4025
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap m_columnMap;

		// Token: 0x04000FBA RID: 4026
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarList m_outputVars;
	}
}
