using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Infragistics
{
	// Token: 0x020000E8 RID: 232
	internal static class PlatformProxy
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x0001D3AC File Offset: 0x0001B5AC
		internal static object GetFocusedElement(global::System.Windows.DependencyObject scopedElement)
		{
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(scopedElement);
			if (focusScope != null)
			{
				return global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope);
			}
			return null;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		internal static global::System.Windows.UIElement GetRootVisual(global::System.Windows.DependencyObject scopedElement)
		{
			if (scopedElement == null)
			{
				return global::System.Windows.Application.Current.MainWindow;
			}
			global::System.Windows.UIElement result = scopedElement as global::System.Windows.UIElement;
			global::System.Windows.DependencyObject dependencyObject = scopedElement;
			while (dependencyObject is global::System.Windows.ContentElement)
			{
				dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
			}
			while (dependencyObject != null)
			{
				if (dependencyObject is global::System.Windows.Media.Visual || dependencyObject is global::System.Windows.Media.Media3D.Visual3D)
				{
					dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
				}
				if (dependencyObject is global::System.Windows.UIElement)
				{
					result = (global::System.Windows.UIElement)dependencyObject;
				}
			}
			return result;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0001D430 File Offset: 0x0001B630
		private static global::System.Windows.DependencyObject GetVisualParent(global::System.Windows.DependencyObject child)
		{
			global::System.Windows.Media.Visual visual = child as global::System.Windows.Media.Visual;
			if (visual != null)
			{
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(visual);
				if (parent != null)
				{
					return parent;
				}
				global::System.Windows.FrameworkElement frameworkElement = child as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					return frameworkElement.Parent;
				}
				return null;
			}
			else
			{
				global::System.Windows.FrameworkContentElement frameworkContentElement = child as global::System.Windows.FrameworkContentElement;
				if (frameworkContentElement != null)
				{
					return frameworkContentElement.Parent;
				}
				global::System.Windows.Media.Media3D.Visual3D visual3D = child as global::System.Windows.Media.Media3D.Visual3D;
				if (visual3D != null)
				{
					return global::System.Windows.Media.VisualTreeHelper.GetParent(visual3D);
				}
				return null;
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0001D48C File Offset: 0x0001B68C
		internal static double GetZoomFactor()
		{
			return 1.0;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0001D498 File Offset: 0x0001B698
		internal static global::System.Windows.Size ResolveContainerSize()
		{
			return default(global::System.Windows.Size);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
		internal static global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> GetElementsFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement subtree)
		{
			global::Infragistics.PlatformProxy.HitTestHelper hitTestHelper = new global::Infragistics.PlatformProxy.HitTestHelper();
			global::System.Windows.Media.VisualTreeHelper.HitTest(subtree, new global::System.Windows.Media.HitTestFilterCallback(hitTestHelper.FilterCallback), new global::System.Windows.Media.HitTestResultCallback(hitTestHelper.ResultCallback), new global::System.Windows.Media.PointHitTestParameters(point));
			return hitTestHelper.HitResults;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0001D4ED File Offset: 0x0001B6ED
		internal static bool IsVersionSupported(string version)
		{
			return true;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		internal static global::System.Windows.DependencyObject GetRootParent(global::System.Windows.DependencyObject element)
		{
			global::System.Windows.DependencyObject result = null;
			for (global::System.Windows.DependencyObject visualParent = global::Infragistics.PlatformProxy.GetVisualParent(element); visualParent != null; visualParent = global::Infragistics.PlatformProxy.GetVisualParent(visualParent))
			{
				result = visualParent;
			}
			return result;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0001D515 File Offset: 0x0001B715
		public static global::System.Windows.Input.KeyboardNavigationMode GetTabNavigation(global::System.Windows.Controls.Control element)
		{
			return global::System.Windows.Input.KeyboardNavigation.GetTabNavigation(element);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0001D51D File Offset: 0x0001B71D
		public static void SetTabNavigation(global::System.Windows.Controls.Control element, global::System.Windows.Input.KeyboardNavigationMode mode)
		{
			global::System.Windows.Input.KeyboardNavigation.SetTabNavigation(element, mode);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0001D526 File Offset: 0x0001B726
		public static global::System.Windows.DependencyObject GetParent(global::System.Windows.DependencyObject child)
		{
			return global::Infragistics.PlatformProxy.GetParent(child, true);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0001D530 File Offset: 0x0001B730
		public static global::System.Windows.DependencyObject GetParent(global::System.Windows.DependencyObject child, bool walkDirectParents)
		{
			if (!(child is global::System.Windows.Media.Visual))
			{
				return global::System.Windows.LogicalTreeHelper.GetParent(child);
			}
			global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(child);
			if (parent != null)
			{
				return parent;
			}
			if (walkDirectParents)
			{
				global::System.Windows.FrameworkElement frameworkElement = child as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && frameworkElement.Parent != null)
				{
					return frameworkElement.Parent;
				}
			}
			return null;
		}

		// Token: 0x020000E9 RID: 233
		internal class HitTestHelper
		{
			// Token: 0x06000853 RID: 2131 RVA: 0x0001D578 File Offset: 0x0001B778
			public global::System.Windows.Media.HitTestFilterBehavior FilterCallback(global::System.Windows.DependencyObject target)
			{
				global::System.Windows.UIElement uielement = target as global::System.Windows.UIElement;
				if (uielement != null)
				{
					this._hitElements.Add(uielement);
				}
				return global::System.Windows.Media.HitTestFilterBehavior.Continue;
			}

			// Token: 0x06000854 RID: 2132 RVA: 0x0001D59C File Offset: 0x0001B79C
			public global::System.Windows.Media.HitTestResultBehavior ResultCallback(global::System.Windows.Media.HitTestResult result)
			{
				return global::System.Windows.Media.HitTestResultBehavior.Continue;
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000855 RID: 2133 RVA: 0x0001D59F File Offset: 0x0001B79F
			public global::System.Collections.Generic.List<global::System.Windows.UIElement> HitResults
			{
				get
				{
					return this._hitElements;
				}
			}

			// Token: 0x040003FC RID: 1020
			private global::System.Collections.Generic.List<global::System.Windows.UIElement> _hitElements = new global::System.Collections.Generic.List<global::System.Windows.UIElement>();
		}
	}
}
