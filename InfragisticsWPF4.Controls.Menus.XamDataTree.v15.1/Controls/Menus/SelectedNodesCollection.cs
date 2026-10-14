using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000036 RID: 54
	public class SelectedNodesCollection : global::Infragistics.Controls.Menus.SelectedCollectionBase<global::Infragistics.Controls.Menus.XamDataTreeNode>
	{
		// Token: 0x06000230 RID: 560 RVA: 0x0000A073 File Offset: 0x00008273
		protected override global::Infragistics.Controls.Menus.SelectedCollectionBase<global::Infragistics.Controls.Menus.XamDataTreeNode> CreateNewInstance()
		{
			return new global::Infragistics.Controls.Menus.SelectedNodesCollection();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000A07A File Offset: 0x0000827A
		protected override void OnSelectionChanged(global::Infragistics.Controls.Menus.SelectedCollectionBase<global::Infragistics.Controls.Menus.XamDataTreeNode> oldCollection, global::Infragistics.Controls.Menus.SelectedCollectionBase<global::Infragistics.Controls.Menus.XamDataTreeNode> newCollection)
		{
			if (base.Tree != null)
			{
				base.Tree.OnSelectedNodesCollectionChanged((global::Infragistics.Controls.Menus.SelectedNodesCollection)oldCollection, (global::Infragistics.Controls.Menus.SelectedNodesCollection)newCollection);
			}
		}
	}
}
