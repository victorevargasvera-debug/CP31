using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000044 RID: 68
	public class XamDataTreeNodesManager : global::Infragistics.Controls.Menus.NodesManager
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x00012DDC File Offset: 0x00010FDC
		public XamDataTreeNodesManager(global::Infragistics.Controls.Menus.XamDataTree tree) : base(0, new global::Infragistics.Controls.Menus.NodeLayout(tree)
		{
			Key = "XamDataTree_Root_XamDataTree"
		}, null)
		{
			this._tree = tree;
		}

		// Token: 0x04000154 RID: 340
		private global::Infragistics.Controls.Menus.XamDataTree _tree;
	}
}
