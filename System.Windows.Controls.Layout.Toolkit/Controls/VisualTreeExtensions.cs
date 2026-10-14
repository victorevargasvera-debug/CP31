using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x02000005 RID: 5
	internal static class VisualTreeExtensions
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002834 File Offset: 0x00000A34
		internal static global::System.Collections.Generic.IEnumerable<global::System.Windows.DependencyObject> GetVisualChildren(this global::System.Windows.DependencyObject parent)
		{
			int childCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent);
			for (int counter = 0; counter < childCount; counter++)
			{
				yield return global::System.Windows.Media.VisualTreeHelper.GetChild(parent, counter);
			}
			yield break;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000029C0 File Offset: 0x00000BC0
		internal static global::System.Collections.Generic.IEnumerable<global::System.Windows.FrameworkElement> GetLogicalChildrenBreadthFirst(this global::System.Windows.FrameworkElement parent)
		{
			global::System.Collections.Generic.Queue<global::System.Windows.FrameworkElement> queue = new global::System.Collections.Generic.Queue<global::System.Windows.FrameworkElement>(parent.GetVisualChildren().OfType<global::System.Windows.FrameworkElement>());
			while (queue.Count > 0)
			{
				global::System.Windows.FrameworkElement element = queue.Dequeue();
				yield return element;
				foreach (global::System.Windows.FrameworkElement item in element.GetVisualChildren().OfType<global::System.Windows.FrameworkElement>())
				{
					queue.Enqueue(item);
				}
			}
			yield break;
		}
	}
}
