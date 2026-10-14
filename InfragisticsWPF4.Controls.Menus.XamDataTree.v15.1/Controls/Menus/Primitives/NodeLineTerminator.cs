using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Menus.Primitives
{
	// Token: 0x02000029 RID: 41
	[global::System.Windows.TemplateVisualState(GroupName = "Lines", Name = "L")]
	[global::System.Windows.TemplateVisualState(GroupName = "Lines", Name = "T")]
	[global::System.Windows.TemplateVisualState(GroupName = "Lines", Name = "None")]
	public class NodeLineTerminator : global::System.Windows.Controls.Control
	{
		// Token: 0x06000197 RID: 407 RVA: 0x0000766E File Offset: 0x0000586E
		public NodeLineTerminator()
		{
			base.SnapsToDevicePixels = true;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007680 File Offset: 0x00005880
		static NodeLineTerminator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator)));
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000771E File Offset: 0x0000591E
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00007730 File Offset: 0x00005930
		public global::Infragistics.Controls.Menus.XamDataTreeNode Node
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamDataTreeNode)base.GetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator.NodeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator.NodeProperty, value);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007740 File Offset: 0x00005940
		private static void NodeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator nodeLineTerminator = (global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator)obj;
			nodeLineTerminator.EnsureState();
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000775A File Offset: 0x0000595A
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000776C File Offset: 0x0000596C
		public global::Infragistics.Controls.Menus.NodeLineTemination NodeLineEnd
		{
			get
			{
				return (global::Infragistics.Controls.Menus.NodeLineTemination)base.GetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator.NodeLineEndProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator.NodeLineEndProperty, value);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007780 File Offset: 0x00005980
		private static void NodeLineEndChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator nodeLineTerminator = (global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator)obj;
			nodeLineTerminator.EnsureState();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000779C File Offset: 0x0000599C
		protected internal virtual void EnsureState()
		{
			if (this.Node == null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "None", false);
				return;
			}
			switch (this.NodeLineEnd)
			{
			case global::Infragistics.Controls.Menus.NodeLineTemination.None:
				global::System.Windows.VisualStateManager.GoToState(this, "None", false);
				return;
			case global::Infragistics.Controls.Menus.NodeLineTemination.TShape:
				global::System.Windows.VisualStateManager.GoToState(this, "T", false);
				return;
			case global::Infragistics.Controls.Menus.NodeLineTemination.LShape:
				global::System.Windows.VisualStateManager.GoToState(this, "L", false);
				return;
			default:
				return;
			}
		}

		// Token: 0x04000075 RID: 117
		public static readonly global::System.Windows.DependencyProperty NodeProperty = global::System.Windows.DependencyProperty.Register("Node", typeof(global::Infragistics.Controls.Menus.XamDataTreeNode), typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator.NodeChanged)));

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty NodeLineEndProperty = global::System.Windows.DependencyProperty.Register("NodeLineEnd", typeof(global::Infragistics.Controls.Menus.NodeLineTemination), typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Menus.NodeLineTemination.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator.NodeLineEndChanged)));
	}
}
