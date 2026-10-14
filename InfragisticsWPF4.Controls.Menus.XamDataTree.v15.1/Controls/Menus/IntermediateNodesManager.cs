using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000022 RID: 34
	public class IntermediateNodesManager : global::Infragistics.Controls.Menus.NodesManager
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00005626 File Offset: 0x00003826
		public IntermediateNodesManager(int level, global::Infragistics.Controls.Menus.NodeLayout nodeLayout, global::Infragistics.Controls.Menus.XamDataTreeNode parentLayoutNode) : base(level, nodeLayout, parentLayoutNode)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005634 File Offset: 0x00003834
		protected override global::Infragistics.Controls.Menus.XamDataTreeNode GetDataItem(int index)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = base.NodeLayout.NodeLayouts[index];
			if (nodeLayout == null)
			{
				return null;
			}
			if (base.CachedNodes.ContainsKey(nodeLayout))
			{
				return base.CachedNodes[nodeLayout];
			}
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = new global::Infragistics.Controls.Menus.XamDataTreeNode(index, this, this.ParentNode.Data, true, nodeLayout);
			if (base.NodeLayout != null && base.NodeLayout.Tree != null)
			{
				base.NodeLayout.Tree.OnInitializeNode(xamDataTreeNode);
			}
			base.CachedNodes.Add(nodeLayout, xamDataTreeNode);
			return xamDataTreeNode;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000056BC File Offset: 0x000038BC
		protected override void EnsureDataManager()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000056C0 File Offset: 0x000038C0
		protected override int DataCount
		{
			get
			{
				int result = 0;
				if (base.NodeLayout != null)
				{
					result = base.NodeLayout.NodeLayouts.Count;
				}
				return result;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000056E9 File Offset: 0x000038E9
		protected internal override global::Infragistics.DataManagerBase DataManager
		{
			get
			{
				return null;
			}
		}
	}
}
