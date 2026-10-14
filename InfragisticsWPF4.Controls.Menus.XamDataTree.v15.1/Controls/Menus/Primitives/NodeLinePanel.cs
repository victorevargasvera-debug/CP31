using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Menus.Primitives
{
	// Token: 0x02000028 RID: 40
	public class NodeLinePanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00007481 File Offset: 0x00005681
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00007493 File Offset: 0x00005693
		public global::Infragistics.Controls.Menus.XamDataTreeNode Node
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamDataTreeNode)base.GetValue(global::Infragistics.Controls.Menus.Primitives.NodeLinePanel.NodeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.NodeLinePanel.NodeProperty, value);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000074A1 File Offset: 0x000056A1
		private static void NodeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000074A4 File Offset: 0x000056A4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Size result = new global::System.Windows.Size(0.0, finalSize.Height);
			if (this.Node != null && this.Node.NodeLayout != null && base.Children.Count > 0)
			{
				double indentationResolved = this.Node.NodeLayout.IndentationResolved;
				foreach (object obj in base.Children)
				{
					global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
					uielement.Arrange(new global::System.Windows.Rect(result.Width, 0.0, indentationResolved, finalSize.Height));
					result.Width += uielement.DesiredSize.Width;
				}
			}
			return result;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007590 File Offset: 0x00005790
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			double num = 0.0;
			double num2 = 0.0;
			foreach (object obj in base.Children)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				uielement.Measure(availableSize);
				num += uielement.DesiredSize.Width;
				num2 = global::System.Math.Max(num2, uielement.DesiredSize.Height);
			}
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x04000074 RID: 116
		public static readonly global::System.Windows.DependencyProperty NodeProperty = global::System.Windows.DependencyProperty.Register("Node", typeof(global::Infragistics.Controls.Menus.XamDataTreeNode), typeof(global::Infragistics.Controls.Menus.Primitives.NodeLinePanel), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.NodeLinePanel.NodeChanged)));
	}
}
