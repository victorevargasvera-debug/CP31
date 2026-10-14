using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C0 RID: 960
	internal class Node
	{
		// Token: 0x06002DEA RID: 11754 RVA: 0x000916B3 File Offset: 0x0008F8B3
		internal Node(int nodeId, global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> children)
		{
			this.m_id = nodeId;
			this.Op = op;
			this.m_children = children;
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000916D0 File Offset: 0x0008F8D0
		internal Node(global::System.Data.Entity.Core.Query.InternalTrees.Op op, params global::System.Data.Entity.Core.Query.InternalTrees.Node[] children) : this(-1, op, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(children))
		{
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x000916E0 File Offset: 0x0008F8E0
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> Children
		{
			get
			{
				return this.m_children;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000916E8 File Offset: 0x0008F8E8
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x000916F0 File Offset: 0x0008F8F0
		internal global::System.Data.Entity.Core.Query.InternalTrees.Op Op { get; set; }

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x000916F9 File Offset: 0x0008F8F9
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x00091707 File Offset: 0x0008F907
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node Child0
		{
			get
			{
				return this.m_children[0];
			}
			set
			{
				this.m_children[0] = value;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00091716 File Offset: 0x0008F916
		internal bool HasChild0
		{
			get
			{
				return this.m_children.Count > 0;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x00091726 File Offset: 0x0008F926
		// (set) Token: 0x06002DF3 RID: 11763 RVA: 0x00091734 File Offset: 0x0008F934
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node Child1
		{
			get
			{
				return this.m_children[1];
			}
			set
			{
				this.m_children[1] = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x00091743 File Offset: 0x0008F943
		internal bool HasChild1
		{
			get
			{
				return this.m_children.Count > 1;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x00091753 File Offset: 0x0008F953
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x00091761 File Offset: 0x0008F961
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node Child2
		{
			get
			{
				return this.m_children[2];
			}
			set
			{
				this.m_children[2] = value;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x00091770 File Offset: 0x0008F970
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node Child3
		{
			get
			{
				return this.m_children[3];
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x0009177E File Offset: 0x0008F97E
		internal bool HasChild2
		{
			get
			{
				return this.m_children.Count > 2;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x0009178E File Offset: 0x0008F98E
		internal bool HasChild3
		{
			get
			{
				return this.m_children.Count > 3;
			}
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x000917A0 File Offset: 0x0008F9A0
		internal bool IsEquivalent(global::System.Data.Entity.Core.Query.InternalTrees.Node other)
		{
			if (this.Children.Count != other.Children.Count)
			{
				return false;
			}
			bool? flag = new bool?(this.Op.IsEquivalent(other.Op));
			bool flag2 = true;
			if (!(flag.GetValueOrDefault() == flag2 & flag != null))
			{
				return false;
			}
			for (int i = 0; i < this.Children.Count; i++)
			{
				if (!this.Children[i].IsEquivalent(other.Children[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x0009182E File Offset: 0x0008FA2E
		internal bool IsNodeInfoInitialized
		{
			get
			{
				return this.m_nodeInfo != null;
			}
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00091839 File Offset: 0x0008FA39
		internal global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo GetNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			if (this.m_nodeInfo == null)
			{
				this.InitializeNodeInfo(command);
			}
			return this.m_nodeInfo;
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00091850 File Offset: 0x0008FA50
		internal global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo GetExtendedNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			if (this.m_nodeInfo == null)
			{
				this.InitializeNodeInfo(command);
			}
			return this.m_nodeInfo as global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo;
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x0009186C File Offset: 0x0008FA6C
		private void InitializeNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			if (this.Op.IsRelOp || this.Op.IsPhysicalOp)
			{
				this.m_nodeInfo = new global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo(command);
			}
			else
			{
				this.m_nodeInfo = new global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo(command);
			}
			command.RecomputeNodeInfo(this);
		}

		// Token: 0x04000F5A RID: 3930
		private readonly int m_id;

		// Token: 0x04000F5B RID: 3931
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> m_children;

		// Token: 0x04000F5C RID: 3932
		private global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo m_nodeInfo;
	}
}
