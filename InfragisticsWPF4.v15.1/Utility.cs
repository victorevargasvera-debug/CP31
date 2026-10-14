using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000DF RID: 223
	internal static class Utility
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x0001D374 File Offset: 0x0001B574
		internal static global::System.Windows.Controls.Panel ResolveRootPanel()
		{
			global::System.Windows.UIElement uielement = global::System.Windows.Application.Current.MainWindow;
			while (uielement != null && !(uielement is global::System.Windows.Controls.Panel))
			{
				uielement = (global::System.Windows.Media.VisualTreeHelper.GetChild(uielement, 0) as global::System.Windows.UIElement);
			}
			return uielement as global::System.Windows.Controls.Panel;
		}
	}
}
