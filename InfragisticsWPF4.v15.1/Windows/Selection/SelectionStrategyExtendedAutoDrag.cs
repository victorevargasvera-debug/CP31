using System;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002BD RID: 701
	public class SelectionStrategyExtendedAutoDrag : global::Infragistics.Windows.Selection.SelectionStrategyExtended
	{
		// Token: 0x06001B92 RID: 7058 RVA: 0x000685B1 File Offset: 0x000667B1
		public SelectionStrategyExtendedAutoDrag(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000685BA File Offset: 0x000667BA
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, true);
		}
	}
}
