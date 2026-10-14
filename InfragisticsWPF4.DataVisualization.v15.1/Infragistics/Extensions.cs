using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000097 RID: 151
	public static class Extensions
	{
		// Token: 0x060006A9 RID: 1705 RVA: 0x0001C855 File Offset: 0x0001AA55
		public static void Reset(this global::System.Windows.Media.PathGeometry geom)
		{
			geom.Figures.Clear();
			geom.Figures.Add(new global::System.Windows.Media.PathFigure());
			geom.Figures.RemoveAt(0);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001C87E File Offset: 0x0001AA7E
		public static void Reset(this global::System.Windows.Media.GeometryGroup geom)
		{
			geom.Children.Clear();
			geom.Children.Add(new global::System.Windows.Media.PathGeometry());
			geom.Children.RemoveAt(0);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		public static void Detach(this global::System.Windows.FrameworkElement child)
		{
			if (child == null)
			{
				return;
			}
			global::System.Windows.Controls.Panel panel = child.Parent as global::System.Windows.Controls.Panel;
			if (panel != null)
			{
				panel.Children.Remove(child);
				return;
			}
			global::System.Windows.Controls.ContentControl contentControl = child.Parent as global::System.Windows.Controls.ContentControl;
			if (contentControl != null)
			{
				contentControl.Content = null;
				return;
			}
			global::System.Windows.Controls.ContentPresenter contentPresenter = child.Parent as global::System.Windows.Controls.ContentPresenter;
			if (contentPresenter != null)
			{
				contentPresenter.Content = null;
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001C904 File Offset: 0x0001AB04
		public static void TransferChildrenTo(this global::System.Windows.Controls.Panel from, global::System.Windows.Controls.Panel to)
		{
			global::System.Collections.Generic.List<global::System.Windows.UIElement> list = new global::System.Collections.Generic.List<global::System.Windows.UIElement>();
			foreach (global::System.Windows.UIElement item in from.Children.OfType<global::System.Windows.UIElement>())
			{
				list.Add(item);
			}
			foreach (global::System.Windows.UIElement element in list)
			{
				from.Children.Remove(element);
				to.Children.Add(element);
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001C9AC File Offset: 0x0001ABAC
		public static bool IsPlottable(this double num)
		{
			return !double.IsNaN(num) && !double.IsInfinity(num);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001C9C1 File Offset: 0x0001ABC1
		public static bool IsPlottable(this global::System.Windows.Point point)
		{
			return point.X.IsPlottable() && point.Y.IsPlottable();
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		public static bool IsPlottable(this global::System.Windows.Rect rect)
		{
			return !double.IsNaN(rect.Left) && !double.IsNaN(rect.Right) && !double.IsNaN(rect.Top) && !double.IsNaN(rect.Bottom) && !double.IsInfinity(rect.Left) && !double.IsInfinity(rect.Right) && !double.IsInfinity(rect.Top) && !double.IsInfinity(rect.Bottom);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001CCDC File Offset: 0x0001AEDC
		public static global::System.Collections.Generic.IEnumerable<T> LogicalDescendantsOfType<T>(this global::System.Windows.FrameworkElement ele) where T : global::System.Windows.FrameworkElement
		{
			foreach (global::System.Windows.FrameworkElement child in global::System.Windows.LogicalTreeHelper.GetChildren(ele).OfType<global::System.Windows.FrameworkElement>())
			{
				if (child is T)
				{
					yield return (T)((object)child);
				}
				foreach (T subChild in child.LogicalDescendantsOfType<T>())
				{
					yield return subChild;
				}
			}
			yield break;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001CF30 File Offset: 0x0001B130
		public static global::System.Collections.Generic.IEnumerable<T> VisualDescendantsOfType<T>(this global::System.Windows.FrameworkElement ele) where T : global::System.Windows.FrameworkElement
		{
			for (int i = 0; i < global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(ele); i++)
			{
				global::System.Windows.FrameworkElement child = global::System.Windows.Media.VisualTreeHelper.GetChild(ele, i) as global::System.Windows.FrameworkElement;
				if (child != null)
				{
					if (child is T)
					{
						yield return (T)((object)child);
					}
					foreach (T subChild in child.VisualDescendantsOfType<T>())
					{
						yield return subChild;
					}
				}
			}
			yield break;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001CF4D File Offset: 0x0001B14D
		public static bool IsInVisualTree(this global::System.Windows.DependencyObject element)
		{
			return element.IsInVisualTree(global::Infragistics.PlatformProxy.GetRootVisual(element));
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0001CF5C File Offset: 0x0001B15C
		public static bool IsInVisualTree(this global::System.Windows.DependencyObject element, global::System.Windows.DependencyObject ancestor)
		{
			for (global::System.Windows.DependencyObject dependencyObject = element; dependencyObject != null; dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject))
			{
				if (dependencyObject == ancestor)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001CF7E File Offset: 0x0001B17E
		public static bool IsVisibleInVisualTree(this global::System.Windows.FrameworkElement ele, global::System.Windows.FrameworkElement topParent = null)
		{
			if (!ele.IsInVisualTree())
			{
				return false;
			}
			while (ele != topParent && ele != null)
			{
				if (ele.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					return false;
				}
				ele = (global::System.Windows.Media.VisualTreeHelper.GetParent(ele) as global::System.Windows.FrameworkElement);
			}
			return true;
		}
	}
}
