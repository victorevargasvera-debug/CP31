using System;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000045 RID: 69
	internal class SelectionStrategyExtendedAutoDrag : global::Infragistics.Controls.Primitives.SelectionStrategyExtended
	{
		// Token: 0x060002FC RID: 764 RVA: 0x0000EB27 File Offset: 0x0000CD27
		public SelectionStrategyExtendedAutoDrag(global::Infragistics.Controls.Primitives.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000EB30 File Offset: 0x0000CD30
		public override bool OnMouseLeftButtonDown(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, true);
		}
	}
}
