using System;

namespace Infragistics.Windows.Selection
{
	// Token: 0x0200027F RID: 639
	public class SelectionStrategyContiguous : global::Infragistics.Windows.Selection.SelectionStrategyExtended
	{
		// Token: 0x06001963 RID: 6499 RVA: 0x000613F5 File Offset: 0x0005F5F5
		public SelectionStrategyContiguous(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x000613FE File Offset: 0x0005F5FE
		public override bool IsDiscontiguousAllowed
		{
			get
			{
				return false;
			}
		}
	}
}
