using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C2 RID: 962
	internal class NodeInfo
	{
		// Token: 0x06002E02 RID: 11778 RVA: 0x0009191C File Offset: 0x0008FB1C
		internal NodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd)
		{
			this.m_externalReferences = cmd.CreateVarVec();
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x00091930 File Offset: 0x0008FB30
		internal virtual void Clear()
		{
			this.m_externalReferences.Clear();
			this.m_hashValue = 0;
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x00091944 File Offset: 0x0008FB44
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec ExternalReferences
		{
			get
			{
				return this.m_externalReferences;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x0009194C File Offset: 0x0008FB4C
		internal int HashValue
		{
			get
			{
				return this.m_hashValue;
			}
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00091954 File Offset: 0x0008FB54
		internal static int GetHashValue(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vec)
		{
			int num = 0;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in vec)
			{
				num ^= var.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000919A4 File Offset: 0x0008FBA4
		internal virtual void ComputeHashValue(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_hashValue = 0;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = cmd.GetNodeInfo(n2);
				this.m_hashValue ^= nodeInfo.HashValue;
			}
			this.m_hashValue = (this.m_hashValue << 4 ^ (int)n.Op.OpType);
			this.m_hashValue = (this.m_hashValue << 4 ^ global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo.GetHashValue(this.m_externalReferences));
		}

		// Token: 0x04000F5E RID: 3934
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_externalReferences;

		// Token: 0x04000F5F RID: 3935
		protected int m_hashValue;
	}
}
