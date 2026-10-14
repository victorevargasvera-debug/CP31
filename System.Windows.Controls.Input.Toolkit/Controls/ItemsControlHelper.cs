using System;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x02000008 RID: 8
	internal sealed class ItemsControlHelper
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003155 File Offset: 0x00001355
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000315D File Offset: 0x0000135D
		private global::System.Windows.Controls.ItemsControl ItemsControl { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003168 File Offset: 0x00001368
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000031C0 File Offset: 0x000013C0
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

		// Token: 0x06000054 RID: 84 RVA: 0x0000320F File Offset: 0x0000140F
		internal ItemsControlHelper(global::System.Windows.Controls.ItemsControl control)
		{
			this.ItemsControl = control;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000321E File Offset: 0x0000141E
		internal void OnApplyTemplate()
		{
			this._itemsHost = null;
			this._scrollHost = null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003230 File Offset: 0x00001430
		internal static void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, global::System.Windows.Style parentItemContainerStyle)
		{
			global::System.Windows.Controls.Control control = element as global::System.Windows.Controls.Control;
			if (parentItemContainerStyle != null && control != null && control.Style == null)
			{
				control.SetValue(global::System.Windows.FrameworkElement.StyleProperty, parentItemContainerStyle);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003260 File Offset: 0x00001460
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

		// Token: 0x06000058 RID: 88 RVA: 0x000032E4 File Offset: 0x000014E4
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

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Controls.Panel _itemsHost;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Controls.ScrollViewer _scrollHost;
	}
}
