using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Infragistics
{
	// Token: 0x020000CA RID: 202
	internal static class PlatformProxy
	{
		// Token: 0x06000747 RID: 1863 RVA: 0x000197AC File Offset: 0x000179AC
		internal static object GetFocusedElement(global::System.Windows.DependencyObject scopedElement)
		{
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(scopedElement);
			if (focusScope != null)
			{
				return global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope);
			}
			return null;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000197CC File Offset: 0x000179CC
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

		// Token: 0x06000749 RID: 1865 RVA: 0x00019830 File Offset: 0x00017A30
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

		// Token: 0x0600074A RID: 1866 RVA: 0x0001988C File Offset: 0x00017A8C
		internal static double GetZoomFactor()
		{
			return 1.0;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00019898 File Offset: 0x00017A98
		internal static global::System.Windows.Size ResolveContainerSize()
		{
			return default(global::System.Windows.Size);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000198B0 File Offset: 0x00017AB0
		internal static global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> GetElementsFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement subtree)
		{
			global::Infragistics.PlatformProxy.HitTestHelper hitTestHelper = new global::Infragistics.PlatformProxy.HitTestHelper();
			global::System.Windows.Media.VisualTreeHelper.HitTest(subtree, new global::System.Windows.Media.HitTestFilterCallback(hitTestHelper.FilterCallback), new global::System.Windows.Media.HitTestResultCallback(hitTestHelper.ResultCallback), new global::System.Windows.Media.PointHitTestParameters(point));
			return hitTestHelper.HitResults;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000198ED File Offset: 0x00017AED
		internal static bool IsVersionSupported(string version)
		{
			return true;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000198F0 File Offset: 0x00017AF0
		internal static global::System.Windows.DependencyObject GetRootParent(global::System.Windows.DependencyObject element)
		{
			global::System.Windows.DependencyObject result = null;
			for (global::System.Windows.DependencyObject visualParent = global::Infragistics.PlatformProxy.GetVisualParent(element); visualParent != null; visualParent = global::Infragistics.PlatformProxy.GetVisualParent(visualParent))
			{
				result = visualParent;
			}
			return result;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00019915 File Offset: 0x00017B15
		public static global::System.Windows.Input.KeyboardNavigationMode GetTabNavigation(global::System.Windows.Controls.Control element)
		{
			return global::System.Windows.Input.KeyboardNavigation.GetTabNavigation(element);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0001991D File Offset: 0x00017B1D
		public static void SetTabNavigation(global::System.Windows.Controls.Control element, global::System.Windows.Input.KeyboardNavigationMode mode)
		{
			global::System.Windows.Input.KeyboardNavigation.SetTabNavigation(element, mode);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00019926 File Offset: 0x00017B26
		public static global::System.Windows.DependencyObject GetParent(global::System.Windows.DependencyObject child)
		{
			return global::Infragistics.PlatformProxy.GetParent(child, true);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00019930 File Offset: 0x00017B30
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

		// Token: 0x06000753 RID: 1875 RVA: 0x00019978 File Offset: 0x00017B78
		internal static global::System.Windows.Controls.Primitives.Popup GetPopupRootVisual(global::System.Windows.DependencyObject scopedElement)
		{
			global::System.Windows.DependencyObject child = scopedElement;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.Primitives.Popup);
			while (child != null)
			{
				global::System.Windows.DependencyObject visualParent = global::Infragistics.PlatformProxy.GetVisualParent(child);
				if (visualParent != null)
				{
					global::System.Type type = visualParent.GetType();
					if (type == typeFromHandle)
					{
						return visualParent as global::System.Windows.Controls.Primitives.Popup;
					}
					if (typeFromHandle.IsAssignableFrom(type))
					{
						return visualParent as global::System.Windows.Controls.Primitives.Popup;
					}
				}
				child = visualParent;
			}
			return null;
		}

		// Token: 0x020000CB RID: 203
		internal class HitTestHelper
		{
			// Token: 0x06000754 RID: 1876 RVA: 0x000199CC File Offset: 0x00017BCC
			public global::System.Windows.Media.HitTestFilterBehavior FilterCallback(global::System.Windows.DependencyObject target)
			{
				global::System.Windows.UIElement uielement = target as global::System.Windows.UIElement;
				if (uielement != null)
				{
					this._hitElements.Add(uielement);
				}
				return global::System.Windows.Media.HitTestFilterBehavior.Continue;
			}

			// Token: 0x06000755 RID: 1877 RVA: 0x000199F0 File Offset: 0x00017BF0
			public global::System.Windows.Media.HitTestResultBehavior ResultCallback(global::System.Windows.Media.HitTestResult result)
			{
				return global::System.Windows.Media.HitTestResultBehavior.Continue;
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000756 RID: 1878 RVA: 0x000199F3 File Offset: 0x00017BF3
			public global::System.Collections.Generic.List<global::System.Windows.UIElement> HitResults
			{
				get
				{
					return this._hitElements;
				}
			}

			// Token: 0x0400034A RID: 842
			private global::System.Collections.Generic.List<global::System.Windows.UIElement> _hitElements = new global::System.Collections.Generic.List<global::System.Windows.UIElement>();
		}
	}
}
