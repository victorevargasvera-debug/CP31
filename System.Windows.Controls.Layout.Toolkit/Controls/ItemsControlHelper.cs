using System;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x02000006 RID: 6
	internal sealed class ItemsControlHelper
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000029DD File Offset: 0x00000BDD
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000029E5 File Offset: 0x00000BE5
		private global::System.Windows.Controls.ItemsControl ItemsControl { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000029F0 File Offset: 0x00000BF0
		internal global::System.Windows.Controls.Panel ItemsHost
		{
			get
			{
				if (this._itemsHost == null && this.ItemsControl != null && this.ItemsControl.ItemContainerGenerator != null)
				{
					global::System.Windows.DependencyObject dependencyObject = this.ItemsControl.ItemContainerGenerator.ContainerFromIndex(0);
					if (dependencyObject != null)
					{
						this._itemsHost = (global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject) as global::System.Windows.Controls.Panel);
					}
				}
				return this._itemsHost;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002A48 File Offset: 0x00000C48
		internal global::System.Windows.Controls.ScrollViewer ScrollHost
		{
			get
			{
				if (this._scrollHost == null)
				{
					global::System.Windows.Controls.Panel itemsHost = this.ItemsHost;
					if (itemsHost != null)
					{
						global::System.Windows.DependencyObject dependencyObject = itemsHost;
						while (dependencyObject != this.ItemsControl && dependencyObject != null)
						{
							global::System.Windows.Controls.ScrollViewer scrollViewer = dependencyObject as global::System.Windows.Controls.ScrollViewer;
							if (scrollViewer != null)
							{
								this._scrollHost = scrollViewer;
								break;
							}
							dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
						}
					}
				}
				return this._scrollHost;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A97 File Offset: 0x00000C97
		internal ItemsControlHelper(global::System.Windows.Controls.ItemsControl control)
		{
			this.ItemsControl = control;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002AA6 File Offset: 0x00000CA6
		internal void OnApplyTemplate()
		{
			this._itemsHost = null;
			this._scrollHost = null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002AB8 File Offset: 0x00000CB8
		internal static void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, global::System.Windows.Style parentItemContainerStyle)
		{
			global::System.Windows.Controls.Control control = element as global::System.Windows.Controls.Control;
			if (parentItemContainerStyle != null && control != null && control.Style == null)
			{
				control.SetValue(global::System.Windows.FrameworkElement.StyleProperty, parentItemContainerStyle);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002AE8 File Offset: 0x00000CE8
		internal void UpdateItemContainerStyle(global::System.Windows.Style itemContainerStyle)
		{
			if (itemContainerStyle == null)
			{
				return;
			}
			global::System.Windows.Controls.Panel itemsHost = this.ItemsHost;
			if (itemsHost == null || itemsHost.Children == null)
			{
				return;
			}
			foreach (object obj in itemsHost.Children)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				global::System.Windows.FrameworkElement frameworkElement = uielement as global::System.Windows.FrameworkElement;
				if (frameworkElement.Style == null)
				{
					frameworkElement.Style = itemContainerStyle;
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002B6C File Offset: 0x00000D6C
		internal void ScrollIntoView(global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.Controls.ScrollViewer scrollHost = this.ScrollHost;
			if (scrollHost == null)
			{
				return;
			}
			global::System.Windows.Media.GeneralTransform generalTransform = null;
			try
			{
				generalTransform = element.TransformToVisual(scrollHost);
			}
			catch (global::System.ArgumentException)
			{
				return;
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(generalTransform.Transform(default(global::System.Windows.Point)), generalTransform.Transform(new global::System.Windows.Point(element.ActualWidth, element.ActualHeight)));
			double num = scrollHost.VerticalOffset;
			double num2 = 0.0;
			double viewportHeight = scrollHost.ViewportHeight;
			double bottom = rect.Bottom;
			if (viewportHeight < bottom)
			{
				num2 = bottom - viewportHeight;
				num += num2;
			}
			double top = rect.Top;
			if (top - num2 < 0.0)
			{
				num -= num2 - top;
			}
			scrollHost.ScrollToVerticalOffset(num);
			double num3 = scrollHost.HorizontalOffset;
			double num4 = 0.0;
			double viewportWidth = scrollHost.ViewportWidth;
			double right = rect.Right;
			if (viewportWidth < right)
			{
				num4 = right - viewportWidth;
				num3 += num4;
			}
			double left = rect.Left;
			if (left - num4 < 0.0)
			{
				num3 -= num4 - left;
			}
			scrollHost.ScrollToHorizontalOffset(num3);
		}

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Controls.Panel _itemsHost;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Controls.ScrollViewer _scrollHost;
	}
}
