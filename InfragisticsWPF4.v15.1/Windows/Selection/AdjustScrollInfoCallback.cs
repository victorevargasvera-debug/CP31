using System;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002B5 RID: 693
	// (Invoke) Token: 0x06001B2B RID: 6955
	public delegate void AdjustScrollInfoCallback(bool isHorizontal, global::System.Windows.Input.MouseEventArgs mouseArgs, global::Infragistics.Windows.Selection.ISelectableItem item, ref global::Infragistics.Windows.Selection.ScrollDirection? scrollDirection, ref double timerInterval);
}
