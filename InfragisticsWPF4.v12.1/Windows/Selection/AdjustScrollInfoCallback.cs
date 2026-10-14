using System;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x02000278 RID: 632
	// (Invoke) Token: 0x06001900 RID: 6400
	public delegate void AdjustScrollInfoCallback(bool isHorizontal, global::System.Windows.Input.MouseEventArgs mouseArgs, global::Infragistics.Windows.Selection.ISelectableItem item, ref global::Infragistics.Windows.Selection.ScrollDirection? scrollDirection, ref double timerInterval);
}
