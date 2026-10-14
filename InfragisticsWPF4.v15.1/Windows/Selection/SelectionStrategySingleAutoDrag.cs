using System;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002BE RID: 702
	public class SelectionStrategySingleAutoDrag : global::Infragistics.Windows.Selection.SelectionStrategySingle
	{
		// Token: 0x06001B94 RID: 7060 RVA: 0x000685C5 File Offset: 0x000667C5
		public SelectionStrategySingleAutoDrag(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000685CE File Offset: 0x000667CE
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return base.ProcessMouseLeftButtonDown(item, e, true);
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x000685D9 File Offset: 0x000667D9
		protected override bool ShouldSelectOnDrag
		{
			get
			{
				return false;
			}
		}
	}
}
