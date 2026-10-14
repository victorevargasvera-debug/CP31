using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000B3 RID: 179
	public class SafeSetterCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.SafeSetter>
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x00024E5C File Offset: 0x0002305C
		public void Apply(global::System.Windows.DependencyObject target)
		{
			if (target == null)
			{
				return;
			}
			foreach (global::Infragistics.SafeSetter safeSetter in this)
			{
				safeSetter.Apply(target);
			}
		}
	}
}
