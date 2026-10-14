using System;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000046 RID: 70
	internal class SelectionStrategySingleAutoDrag : global::Infragistics.Controls.Primitives.SelectionStrategySingle
	{
		// Token: 0x060002FE RID: 766 RVA: 0x0000EB3B File Offset: 0x0000CD3B
		public SelectionStrategySingleAutoDrag(global::Infragistics.Controls.Primitives.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000EB44 File Offset: 0x0000CD44
		public override bool OnMouseLeftButtonDown(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return base.ProcessMouseLeftButtonDown(item, e, true);
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000EB4F File Offset: 0x0000CD4F
		protected override bool ShouldSelectOnDrag
		{
			get
			{
				return false;
			}
		}
	}
}
