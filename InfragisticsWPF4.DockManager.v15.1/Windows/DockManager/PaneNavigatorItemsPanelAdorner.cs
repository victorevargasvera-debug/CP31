using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000083 RID: 131
	internal class PaneNavigatorItemsPanelAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x060004B7 RID: 1207 RVA: 0x0001A0B0 File Offset: 0x000182B0
		internal PaneNavigatorItemsPanelAdorner(global::System.Windows.UIElement adornedElement) : base(adornedElement)
		{
			this._paneNavigatorItemsPanel = (adornedElement as global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001A10A File Offset: 0x0001830A
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			return finalSize;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001A10D File Offset: 0x0001830D
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index < 0 || index >= this.Children.Count)
			{
				return null;
			}
			return this.Children[index];
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0001A12F File Offset: 0x0001832F
		protected override int VisualChildrenCount
		{
			get
			{
				return this.Children.Count;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0001A13C File Offset: 0x0001833C
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> Children
		{
			get
			{
				if (this._children == null)
				{
					this._children = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(2);
				}
				return this._children;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0001A158 File Offset: 0x00018358
		internal global::System.Windows.Controls.Button ScrollDownButton
		{
			get
			{
				if (this._scrollDownButton == null)
				{
					this._scrollDownButton = new global::System.Windows.Controls.Button();
					base.AddVisualChild(this._scrollDownButton);
					this.Children.Add(this._scrollDownButton);
					if (this._paneNavigatorItemsPanel != null && global::System.Windows.LogicalTreeHelper.GetParent(this._scrollDownButton) == null)
					{
						this._paneNavigatorItemsPanel.AddLogicalChildInternal(this._scrollDownButton);
					}
					this._scrollDownButton.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ScrollDownButtonStyleKey);
					this._scrollDownButton.InvalidateMeasure();
					this._scrollDownButton.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					if (this._scrollDownButton.DesiredSize.Width == 0.0 || this._scrollDownButton.DesiredSize.Height == 0.0)
					{
						this._scrollDownButton.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					}
					this._scrollDownButton.Focusable = false;
					this._scrollDownButton.IsHitTestVisible = true;
					this._scrollDownButton.Click += this.OnScrollDownButtonClick;
				}
				return this._scrollDownButton;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0001A298 File Offset: 0x00018498
		internal global::System.Windows.Controls.Button ScrollUpButton
		{
			get
			{
				if (this._scrollUpButton == null)
				{
					this._scrollUpButton = new global::System.Windows.Controls.Button();
					base.AddVisualChild(this._scrollUpButton);
					this.Children.Add(this._scrollUpButton);
					if (this._paneNavigatorItemsPanel != null && global::System.Windows.LogicalTreeHelper.GetParent(this._scrollUpButton) == null)
					{
						this._paneNavigatorItemsPanel.AddLogicalChildInternal(this._scrollUpButton);
					}
					this._scrollUpButton.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ScrollUpButtonStyleKey);
					this._scrollUpButton.InvalidateMeasure();
					this._scrollUpButton.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					if (this._scrollUpButton.DesiredSize.Width == 0.0 || this._scrollUpButton.DesiredSize.Height == 0.0)
					{
						this._scrollUpButton.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					}
					this._scrollUpButton.Focusable = false;
					this._scrollUpButton.IsHitTestVisible = true;
					this._scrollUpButton.Click += this.OnScrollUpButtonClick;
				}
				return this._scrollUpButton;
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0001A3D8 File Offset: 0x000185D8
		private void OnScrollDownButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.IScrollInfo paneNavigatorItemsPanel = this._paneNavigatorItemsPanel;
			paneNavigatorItemsPanel.SetVerticalOffset(paneNavigatorItemsPanel.VerticalOffset + 1.0);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001A404 File Offset: 0x00018604
		private void OnScrollUpButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.IScrollInfo paneNavigatorItemsPanel = this._paneNavigatorItemsPanel;
			paneNavigatorItemsPanel.SetVerticalOffset(paneNavigatorItemsPanel.VerticalOffset - 1.0);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001A42E File Offset: 0x0001862E
		internal void PositionScrollDownButton(global::System.Windows.Point location, double width)
		{
			this._scrollDownButtonLocation = location;
			this._scrollDownButtonWidth = width;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001A43E File Offset: 0x0001863E
		internal void PositionScrollUpButton(global::System.Windows.Point location, double width)
		{
			this._scrollUpButtonLocation = location;
			this._scrollUpButtonWidth = width;
		}

		// Token: 0x04000310 RID: 784
		private global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel _paneNavigatorItemsPanel;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Controls.Button _scrollUpButton;

		// Token: 0x04000312 RID: 786
		private global::System.Windows.Controls.Button _scrollDownButton;

		// Token: 0x04000313 RID: 787
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> _children;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Point _scrollDownButtonLocation = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x04000315 RID: 789
		private double _scrollDownButtonWidth;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Point _scrollUpButtonLocation = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x04000317 RID: 791
		private double _scrollUpButtonWidth;
	}
}
