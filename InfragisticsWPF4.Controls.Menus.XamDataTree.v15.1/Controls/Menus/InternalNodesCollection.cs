using System;
using Infragistics.Collections;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000023 RID: 35
	internal class InternalNodesCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Menus.XamDataTreeNode>
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000056EC File Offset: 0x000038EC
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000056F4 File Offset: 0x000038F4
		public global::Infragistics.Controls.Menus.NodesManager RootNodesManager { get; set; }

		// Token: 0x06000101 RID: 257 RVA: 0x00005700 File Offset: 0x00003900
		private int RecursiveGetCount(global::Infragistics.Controls.Menus.NodesManager manager)
		{
			int num = manager.FullNodeCount;
			foreach (global::Infragistics.Controls.Menus.NodesManager manager2 in manager.VisibleChildManagers)
			{
				num += this.RecursiveGetCount(manager2);
			}
			return num;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00005758 File Offset: 0x00003958
		private static int GetOffsetIndex(global::Infragistics.Controls.Menus.NodesManager manager)
		{
			int num = 0;
			while (manager.ParentNode != null)
			{
				num += manager.ParentNode.Manager.ResolveIndexForNode(manager.ParentNode) + 1;
				manager = manager.ParentNode.Manager;
			}
			return num;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000579C File Offset: 0x0000399C
		private global::Infragistics.Controls.Menus.XamDataTreeNode GetNodeForIndex(int index, global::Infragistics.Controls.Menus.NodesManager currentManager, int currentOffset, int additionalOffset)
		{
			int num = 0;
			foreach (global::Infragistics.Controls.Menus.NodesManager nodesManager in currentManager.VisibleChildManagers)
			{
				int num2 = global::Infragistics.Controls.Menus.InternalNodesCollection.GetOffsetIndex(nodesManager) + num + additionalOffset;
				if (index < num2)
				{
					return currentManager.ResolveNodeForIndex(index - currentOffset - num);
				}
				int num3 = this.RecursiveGetCount(nodesManager);
				if (index >= num2 && index < num2 + num3)
				{
					return this.GetNodeForIndex(index, nodesManager, num2, num + additionalOffset);
				}
				num += num3;
			}
			return currentManager.ResolveNodeForIndex(index - currentOffset - num);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005840 File Offset: 0x00003A40
		private bool GetIndexOfNode(global::Infragistics.Controls.Menus.NodesManager currentManager, global::Infragistics.Controls.Menus.XamDataTreeNode node, ref int index)
		{
			if (currentManager != node.Manager)
			{
				foreach (global::Infragistics.Controls.Menus.NodesManager nodesManager in currentManager.VisibleChildManagers)
				{
					if (this.GetIndexOfNode(nodesManager, node, ref index))
					{
						return true;
					}
					index += nodesManager.FullNodeCount;
				}
				return false;
			}
			global::Infragistics.Controls.Menus.NodesManager manager = node.Manager;
			if (manager != null)
			{
				int num = manager.ResolveIndexForNode(node);
				int num2 = num;
				foreach (global::Infragistics.Controls.Menus.NodesManager nodesManager2 in currentManager.VisibleChildManagers)
				{
					int num3 = manager.ResolveIndexForNode(nodesManager2.ParentNode);
					if (num > num3)
					{
						num2 += this.RecursiveGetCount(nodesManager2);
					}
				}
				index += num2 + global::Infragistics.Controls.Menus.InternalNodesCollection.GetOffsetIndex(currentManager);
				return true;
			}
			return false;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005934 File Offset: 0x00003B34
		protected override int GetCount()
		{
			return this.RecursiveGetCount(this.RootNodesManager);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005942 File Offset: 0x00003B42
		protected override global::Infragistics.Controls.Menus.XamDataTreeNode GetItem(int index)
		{
			if (this.RootNodesManager.VisibleChildManagers.Count == 0)
			{
				return this.RootNodesManager.Nodes[index];
			}
			return this.GetNodeForIndex(index, this.RootNodesManager, 0, 0);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005978 File Offset: 0x00003B78
		public override int IndexOf(global::Infragistics.Controls.Menus.XamDataTreeNode item)
		{
			int result = 0;
			this.GetIndexOfNode(this.RootNodesManager, item, ref result);
			return result;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005998 File Offset: 0x00003B98
		public new bool Contains(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			int num = 0;
			return this.GetIndexOfNode(this.RootNodesManager, node, ref num);
		}
	}
}
