using System;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x02000281 RID: 641
	public class SelectionStrategySingleAutoDrag : global::Infragistics.Windows.Selection.SelectionStrategySingle
	{
		// Token: 0x06001967 RID: 6503 RVA: 0x00061415 File Offset: 0x0005F615
		public SelectionStrategySingleAutoDrag(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0006141E File Offset: 0x0005F61E
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return base.ProcessMouseLeftButtonDown(item, e, true);
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00061429 File Offset: 0x0005F629
		protected override bool ShouldSelectOnDrag
		{
			get
			{
				return false;
			}
		}
	}
}
