using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Microsoft.Windows.Controls.Primitives
{
	// Token: 0x0200005A RID: 90
	public class SelectiveScrollingGrid : global::System.Windows.Controls.Grid
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x0001DE85 File Offset: 0x0001C085
		public static global::Microsoft.Windows.Controls.SelectiveScrollingOrientation GetSelectiveScrollingOrientation(global::System.Windows.DependencyObject obj)
		{
			return (global::Microsoft.Windows.Controls.SelectiveScrollingOrientation)obj.GetValue(global::Microsoft.Windows.Controls.Primitives.SelectiveScrollingGrid.SelectiveScrollingOrientationProperty);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001DE97 File Offset: 0x0001C097
		public static void SetSelectiveScrollingOrientation(global::System.Windows.DependencyObject obj, global::Microsoft.Windows.Controls.SelectiveScrollingOrientation value)
		{
			obj.SetValue(global::Microsoft.Windows.Controls.Primitives.SelectiveScrollingGrid.SelectiveScrollingOrientationProperty, value);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0001DEAC File Offset: 0x0001C0AC
		private static void OnSelectiveScrollingOrientationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.UIElement uielement = d as global::System.Windows.UIElement;
			global::Microsoft.Windows.Controls.SelectiveScrollingOrientation selectiveScrollingOrientation = (global::Microsoft.Windows.Controls.SelectiveScrollingOrientation)e.NewValue;
			global::System.Windows.Controls.ScrollViewer scrollViewer = global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::System.Windows.Controls.ScrollViewer>(uielement);
			if (scrollViewer != null && uielement != null)
			{
				global::System.Windows.Media.Transform renderTransform = uielement.RenderTransform;
				if (renderTransform != null)
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(renderTransform, global::System.Windows.Media.TranslateTransform.XProperty);
					global::System.Windows.Data.BindingOperations.ClearBinding(renderTransform, global::System.Windows.Media.TranslateTransform.YProperty);
				}
				if (selectiveScrollingOrientation == global::Microsoft.Windows.Controls.SelectiveScrollingOrientation.Both)
				{
					uielement.RenderTransform = null;
					return;
				}
				global::System.Windows.Media.TranslateTransform translateTransform = new global::System.Windows.Media.TranslateTransform();
				if (selectiveScrollingOrientation != global::Microsoft.Windows.Controls.SelectiveScrollingOrientation.Horizontal)
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding("ContentHorizontalOffset");
					binding.Source = scrollViewer;
					global::System.Windows.Data.BindingOperations.SetBinding(translateTransform, global::System.Windows.Media.TranslateTransform.XProperty, binding);
				}
				if (selectiveScrollingOrientation != global::Microsoft.Windows.Controls.SelectiveScrollingOrientation.Vertical)
				{
					global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding("ContentVerticalOffset");
					binding2.Source = scrollViewer;
					global::System.Windows.Data.BindingOperations.SetBinding(translateTransform, global::System.Windows.Media.TranslateTransform.YProperty, binding2);
				}
				uielement.RenderTransform = translateTransform;
			}
		}

		// Token: 0x0400020E RID: 526
		public static readonly global::System.Windows.DependencyProperty SelectiveScrollingOrientationProperty = global::System.Windows.DependencyProperty.RegisterAttached("SelectiveScrollingOrientation", typeof(global::Microsoft.Windows.Controls.SelectiveScrollingOrientation), typeof(global::Microsoft.Windows.Controls.Primitives.SelectiveScrollingGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.SelectiveScrollingOrientation.Both, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.SelectiveScrollingGrid.OnSelectiveScrollingOrientationChanged)));
	}
}
