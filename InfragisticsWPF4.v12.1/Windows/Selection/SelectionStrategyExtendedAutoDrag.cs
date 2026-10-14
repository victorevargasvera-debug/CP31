using System;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x02000280 RID: 640
	public class SelectionStrategyExtendedAutoDrag : global::Infragistics.Windows.Selection.SelectionStrategyExtended
	{
		// Token: 0x06001965 RID: 6501 RVA: 0x00061401 File Offset: 0x0005F601
		public SelectionStrategyExtendedAutoDrag(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0006140A File Offset: 0x0005F60A
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, true);
		}
	}
}
