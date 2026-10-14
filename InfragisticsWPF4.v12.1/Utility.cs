using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000C2 RID: 194
	internal static class Utility
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x00019774 File Offset: 0x00017974
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
