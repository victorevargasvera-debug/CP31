using System;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002BC RID: 700
	public class SelectionStrategyContiguous : global::Infragistics.Windows.Selection.SelectionStrategyExtended
	{
		// Token: 0x06001B90 RID: 7056 RVA: 0x000685A5 File Offset: 0x000667A5
		public SelectionStrategyContiguous(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000685AE File Offset: 0x000667AE
		public override bool IsDiscontiguousAllowed
		{
			get
			{
				return false;
			}
		}
	}
}
