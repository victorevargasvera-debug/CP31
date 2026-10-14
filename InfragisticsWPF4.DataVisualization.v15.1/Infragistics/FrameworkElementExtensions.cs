using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics
{
	// Token: 0x02000098 RID: 152
	internal static class FrameworkElementExtensions
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x0001CFAA File Offset: 0x0001B1AA
		public static bool HasParent(this global::System.Windows.FrameworkElement frameworkElement, global::System.Windows.Controls.Panel collection)
		{
			return frameworkElement.Parent != null;
		}
	}
}
