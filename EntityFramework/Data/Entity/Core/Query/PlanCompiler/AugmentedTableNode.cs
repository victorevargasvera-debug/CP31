using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000332 RID: 818
	internal sealed class AugmentedTableNode : global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode
	{
		// Token: 0x06002701 RID: 9985 RVA: 0x000702E4 File Offset: 0x0006E4E4
		internal AugmentedTableNode(int id, global::System.Data.Entity.Core.Query.InternalTrees.Node node) : base(id, node)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = (global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp)node.Op;
			this.m_table = scanTableOp.Table;
			this.LastVisibleId = id;
			this.m_replacementTable = this;
			this.m_newLocationId = id;
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x00070326 File Offset: 0x0006E526
		internal global::System.Data.Entity.Core.Query.InternalTrees.Table Table
		{
			get
			{
				return this.m_table;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x0007032E File Offset: 0x0006E52E
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x00070336 File Offset: 0x0006E536
		internal int LastVisibleId { get; set; }

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x0007033F File Offset: 0x0006E53F
		internal bool IsEliminated
		{
			get
			{
				return this.m_replacementTable != this;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x0007034D File Offset: 0x0006E54D
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x00070355 File Offset: 0x0006E555
		internal global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode ReplacementTable
		{
			get
			{
				return this.m_replacementTable;
			}
			set
			{
				this.m_replacementTable = value;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x0007035E File Offset: 0x0006E55E
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x00070366 File Offset: 0x0006E566
		internal int NewLocationId
		{
			get
			{
				return this.m_newLocationId;
			}
			set
			{
				this.m_newLocationId = value;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x0007036F File Offset: 0x0006E56F
		internal bool IsMoved
		{
			get
			{
				return this.m_newLocationId != base.Id;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00070382 File Offset: 0x0006E582
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x0007038A File Offset: 0x0006E58A
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec NullableColumns { get; set; }

		// Token: 0x04000D9C RID: 3484
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Table m_table;

		// Token: 0x04000D9D RID: 3485
		private global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode m_replacementTable;

		// Token: 0x04000D9E RID: 3486
		private int m_newLocationId;
	}
}
