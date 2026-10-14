using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x02000007 RID: 7
	internal static class VisualTreeExtensions
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002FAC File Offset: 0x000011AC
		internal static global::System.Collections.Generic.IEnumerable<global::System.Windows.DependencyObject> GetVisualChildren(this global::System.Windows.DependencyObject parent)
		{
			int childCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent);
			for (int counter = 0; counter < childCount; counter++)
			{
				yield return global::System.Windows.Media.VisualTreeHelper.GetChild(parent, counter);
			}
			yield break;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003138 File Offset: 0x00001338
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
