using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A5 RID: 933
	internal class ExtendedNodeInfo : global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo
	{
		// Token: 0x06002D49 RID: 11593 RVA: 0x00090CD8 File Offset: 0x0008EED8
		internal ExtendedNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd) : base(cmd)
		{
			this.m_localDefinitions = cmd.CreateVarVec();
			this.m_definitions = cmd.CreateVarVec();
			this.m_nonNullableDefinitions = cmd.CreateVarVec();
			this.m_nonNullableVisibleDefinitions = cmd.CreateVarVec();
			this.m_keys = new global::System.Data.Entity.Core.Query.InternalTrees.KeyVec(cmd);
			this.m_minRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
			this.m_maxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Unbounded;
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00090D38 File Offset: 0x0008EF38
		internal override void Clear()
		{
			base.Clear();
			this.m_definitions.Clear();
			this.m_localDefinitions.Clear();
			this.m_nonNullableDefinitions.Clear();
			this.m_nonNullableVisibleDefinitions.Clear();
			this.m_keys.Clear();
			this.m_minRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
			this.m_maxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Unbounded;
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00090D90 File Offset: 0x0008EF90
		internal override void ComputeHashValue(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			base.ComputeHashValue(cmd, n);
			this.m_hashValue = (this.m_hashValue << 4 ^ global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo.GetHashValue(this.Definitions));
			this.m_hashValue = (this.m_hashValue << 4 ^ global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo.GetHashValue(this.Keys.KeyVars));
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x00090DDE File Offset: 0x0008EFDE
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec LocalDefinitions
		{
			get
			{
				return this.m_localDefinitions;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x00090DE6 File Offset: 0x0008EFE6
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Definitions
		{
			get
			{
				return this.m_definitions;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x00090DEE File Offset: 0x0008EFEE
		internal global::System.Data.Entity.Core.Query.InternalTrees.KeyVec Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x00090DF6 File Offset: 0x0008EFF6
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec NonNullableDefinitions
		{
			get
			{
				return this.m_nonNullableDefinitions;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x00090DFE File Offset: 0x0008EFFE
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec NonNullableVisibleDefinitions
		{
			get
			{
				return this.m_nonNullableVisibleDefinitions;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x00090E06 File Offset: 0x0008F006
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x00090E0E File Offset: 0x0008F00E
		internal global::System.Data.Entity.Core.Query.InternalTrees.RowCount MinRows
		{
			get
			{
				return this.m_minRows;
			}
			set
			{
				this.m_minRows = value;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x00090E17 File Offset: 0x0008F017
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x00090E1F File Offset: 0x0008F01F
		internal global::System.Data.Entity.Core.Query.InternalTrees.RowCount MaxRows
		{
			get
			{
				return this.m_maxRows;
			}
			set
			{
				this.m_maxRows = value;
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00090E28 File Offset: 0x0008F028
		internal void SetRowCount(global::System.Data.Entity.Core.Query.InternalTrees.RowCount minRows, global::System.Data.Entity.Core.Query.InternalTrees.RowCount maxRows)
		{
			this.m_minRows = minRows;
			this.m_maxRows = maxRows;
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00090E38 File Offset: 0x0008F038
		internal void InitRowCountFrom(global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo source)
		{
			this.m_minRows = source.m_minRows;
			this.m_maxRows = source.m_maxRows;
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00090E52 File Offset: 0x0008F052
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void ValidateRowCount()
		{
		}

		// Token: 0x04000F28 RID: 3880
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_localDefinitions;

		// Token: 0x04000F29 RID: 3881
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_definitions;

		// Token: 0x04000F2A RID: 3882
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.KeyVec m_keys;

		// Token: 0x04000F2B RID: 3883
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_nonNullableDefinitions;

		// Token: 0x04000F2C RID: 3884
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_nonNullableVisibleDefinitions;

		// Token: 0x04000F2D RID: 3885
		private global::System.Data.Entity.Core.Query.InternalTrees.RowCount m_minRows;

		// Token: 0x04000F2E RID: 3886
		private global::System.Data.Entity.Core.Query.InternalTrees.RowCount m_maxRows;
	}
}
