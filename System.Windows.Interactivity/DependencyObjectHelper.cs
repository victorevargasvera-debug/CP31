using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace System.Windows.Interactivity
{
	// Token: 0x0200000A RID: 10
	public static class DependencyObjectHelper
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002944 File Offset: 0x00000B44
		public static global::System.Collections.Generic.IEnumerable<global::System.Windows.DependencyObject> GetSelfAndAncestors(this global::System.Windows.DependencyObject dependencyObject)
		{
			while (dependencyObject != null)
			{
				yield return dependencyObject;
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
			}
			yield break;
		}
	}
}
