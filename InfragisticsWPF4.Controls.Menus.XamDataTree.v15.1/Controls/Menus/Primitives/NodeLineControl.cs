using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Controls.Menus.Primitives
{
	// Token: 0x02000027 RID: 39
	public class NodeLineControl : global::System.Windows.Controls.Control, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00007072 File Offset: 0x00005272
		public NodeLineControl()
		{
			base.SnapsToDevicePixels = true;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007088 File Offset: 0x00005288
		static NodeLineControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineControl)));
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00007154 File Offset: 0x00005354
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00007166 File Offset: 0x00005366
		public global::Infragistics.Controls.Menus.XamDataTreeNode Node
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamDataTreeNode)base.GetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.NodeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.NodeProperty, value);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007174 File Offset: 0x00005374
		private static void NodeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.Primitives.NodeLineControl nodeLineControl = (global::Infragistics.Controls.Menus.Primitives.NodeLineControl)obj;
			nodeLineControl.OnPropertyChanged("Node");
			nodeLineControl.BuildNodeIndicators();
			if (nodeLineControl.Node == null)
			{
				nodeLineControl._originalLevel = -1;
				return;
			}
			nodeLineControl._originalLevel = nodeLineControl.Node.Manager.Level;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000071BF File Offset: 0x000053BF
		// (set) Token: 0x06000185 RID: 389 RVA: 0x000071D1 File Offset: 0x000053D1
		public global::System.Windows.DataTemplate VerticalLine
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.VerticalLineProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.VerticalLineProperty, value);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000071E0 File Offset: 0x000053E0
		private static void VerticalLineChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.Primitives.NodeLineControl nodeLineControl = (global::Infragistics.Controls.Menus.Primitives.NodeLineControl)obj;
			nodeLineControl.OnPropertyChanged("VerticalLine");
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000071FF File Offset: 0x000053FF
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00007211 File Offset: 0x00005411
		public global::System.Windows.DataTemplate HorizontalLine
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.HorizontalLineProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.HorizontalLineProperty, value);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007220 File Offset: 0x00005420
		private static void HorizontalLineChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.Primitives.NodeLineControl nodeLineControl = (global::Infragistics.Controls.Menus.Primitives.NodeLineControl)obj;
			nodeLineControl.OnPropertyChanged("HorizontalLine");
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000723F File Offset: 0x0000543F
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._sp = (base.GetTemplateChild("StackPanel") as global::Infragistics.Controls.Menus.Primitives.NodeLinePanel);
			this.BuildNodeIndicators();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007263 File Offset: 0x00005463
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this.Node != null && this.Node.JustMoved)
			{
				this.BuildNodeIndicators();
			}
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007288 File Offset: 0x00005488
		protected virtual void BuildNodeIndicators()
		{
			if (this._sp != null && this.Node != null && this.Node.NodeLayout != null)
			{
				base.Width = (double)this.Node.Manager.Level * this.Node.NodeLayout.IndentationResolved;
				this._sp.Children.Clear();
				if (this.Node.Manager.ParentNode != null)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = this.Node;
					if (this.Node.NodeLayout.Tree.NodeLineVisibility == global::System.Windows.Visibility.Visible)
					{
						while (xamDataTreeNode.Manager.ParentNode != null)
						{
							xamDataTreeNode = xamDataTreeNode.Manager.ParentNode;
							if (xamDataTreeNode.Manager.Nodes.Count >= 1)
							{
								if (xamDataTreeNode.Manager.Nodes.IndexOf(xamDataTreeNode) != xamDataTreeNode.Manager.Nodes.Count - 1)
								{
									global::System.Windows.FrameworkElement frameworkElement = this.VerticalLine.LoadContent() as global::System.Windows.FrameworkElement;
									frameworkElement.Width = xamDataTreeNode.NodeLayout.IndentationResolved;
									this._sp.Children.Insert(0, frameworkElement);
								}
								else
								{
									global::System.Windows.Shapes.Rectangle element = new global::System.Windows.Shapes.Rectangle
									{
										Width = xamDataTreeNode.NodeLayout.IndentationResolved,
										Fill = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent)
									};
									this._sp.Children.Insert(0, element);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600018D RID: 397 RVA: 0x000073F8 File Offset: 0x000055F8
		// (remove) Token: 0x0600018E RID: 398 RVA: 0x00007430 File Offset: 0x00005630
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600018F RID: 399 RVA: 0x00007465 File Offset: 0x00005665
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Controls.Panel _sp;

		// Token: 0x0400006F RID: 111
		public static readonly global::System.Windows.DependencyProperty NodeProperty = global::System.Windows.DependencyProperty.Register("Node", typeof(global::Infragistics.Controls.Menus.XamDataTreeNode), typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.NodeChanged)));

		// Token: 0x04000070 RID: 112
		public static readonly global::System.Windows.DependencyProperty VerticalLineProperty = global::System.Windows.DependencyProperty.Register("VerticalLine", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.VerticalLineChanged)));

		// Token: 0x04000071 RID: 113
		public static readonly global::System.Windows.DependencyProperty HorizontalLineProperty = global::System.Windows.DependencyProperty.Register("HorizontalLine", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.Primitives.NodeLineControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.NodeLineControl.HorizontalLineChanged)));

		// Token: 0x04000072 RID: 114
		private int _originalLevel = -1;
	}
}
