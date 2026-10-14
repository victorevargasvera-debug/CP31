using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000080 RID: 128
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PaneNavigatorItemsPanel : global::System.Windows.Controls.Panel, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x0001935C File Offset: 0x0001755C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this._inArrange = true;
			int num = 0;
			int num2 = (int)this.VerticalOffset;
			int i = 0;
			double num3 = 0.0;
			double num4 = 0.0;
			bool flag = false;
			global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
			int count = base.Children.Count;
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			for (int j = 0; j < count; j++)
			{
				children[j].SetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.IsFirstVisibleItemPropertyKey, false);
				children[j].SetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.IsLastVisibleItemPropertyKey, false);
			}
			for (int k = 0; k < count; k++)
			{
				global::System.Windows.UIElement uielement = children[k];
				if (k == 0)
				{
					if (k != num2)
					{
						this._paneNavigatorItemsPanelAdorner.ScrollUpButton.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(0.0, 0.0), new global::System.Windows.Size(this.ColumnWidth, this._paneNavigatorItemsPanelAdorner.ScrollUpButton.DesiredSize.Height)));
						this._scrollUpButtonIsVisible = true;
						num4 += this._paneNavigatorItemsPanelAdorner.ScrollUpButton.DesiredSize.Height;
					}
					else
					{
						this._paneNavigatorItemsPanelAdorner.ScrollUpButton.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(-5000.0, -5000.0), new global::System.Windows.Size(1.0, 1.0)));
						this._scrollUpButtonIsVisible = false;
					}
				}
				if (k < num2 || flag)
				{
					if (!global::Infragistics.KnownBoxes.VisibilityCollapsedBox.Equals(uielement.Visibility))
					{
						uielement.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
					}
				}
				else
				{
					if (k == num2)
					{
						uielement.SetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.IsFirstVisibleItemPropertyKey, true);
					}
					if (!global::Infragistics.KnownBoxes.VisibilityVisibleBox.Equals(uielement.Visibility))
					{
						uielement.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityVisibleBox);
					}
					bool flag2 = false;
					while (i < this.MaxColumns)
					{
						if (num4 + uielement.DesiredSize.Height < finalSize.Height)
						{
							empty = new global::System.Windows.Rect(num3, num4, this.ColumnWidth, uielement.DesiredSize.Height);
							uielement.Arrange(empty);
							this._lastArrangedChild = uielement;
							this._lastArrangedChildIndex = k;
							num++;
							num4 += uielement.DesiredSize.Height;
							flag2 = true;
							break;
						}
						i++;
						num4 = 0.0;
						num3 += this.ColumnWidth;
					}
					if (!flag2)
					{
						if (!flag)
						{
							flag = true;
							this._paneNavigatorItemsPanelAdorner.ScrollDownButton.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(empty.Left, empty.Top), new global::System.Windows.Size(this.ColumnWidth, this._paneNavigatorItemsPanelAdorner.ScrollDownButton.DesiredSize.Height)));
							this._scrollDownButtonIsVisible = true;
							if (this._lastArrangedChild != null)
							{
								this._lastArrangedChild.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
								this._lastArrangedChildIndex--;
								this._lastArrangedChild = base.Children[this._lastArrangedChildIndex];
								num--;
							}
						}
						if (!global::Infragistics.KnownBoxes.VisibilityCollapsedBox.Equals(uielement.Visibility))
						{
							uielement.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
						}
					}
				}
			}
			if (count > 0 && this._lastArrangedChildIndex == count - 1)
			{
				this._paneNavigatorItemsPanelAdorner.ScrollDownButton.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(-5000.0, -5000.0), new global::System.Windows.Size(1.0, 1.0)));
				this._scrollDownButtonIsVisible = false;
			}
			if (count > 0)
			{
				this._lastArrangedChild.SetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.IsLastVisibleItemPropertyKey, true);
				this.UpdateScrollData(new global::System.Windows.Size((double)this.TotalItemCount, (double)this.TotalItemCount), new global::System.Windows.Size((double)num, (double)num), this.ScrollingData._offset);
			}
			this._inArrange = false;
			return finalSize;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001977C File Offset: 0x0001797C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			int num = (int)this.VerticalOffset;
			int i = 0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double height = availableSize.Height;
			bool flag = false;
			int count = base.Children.Count;
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			if (this._paneNavigatorItemsPanelAdorner == null)
			{
				this.InitializeAdorner();
			}
			for (int j = 0; j < count; j++)
			{
				global::System.Windows.UIElement uielement = children[j];
				if (j < num || flag)
				{
					uielement.Measure(new global::System.Windows.Size(this.ColumnWidth, double.PositiveInfinity));
				}
				else
				{
					bool flag2 = false;
					uielement.Measure(new global::System.Windows.Size(this.ColumnWidth, double.PositiveInfinity));
					while (i < this.MaxColumns)
					{
						if (num3 + uielement.DesiredSize.Height < availableSize.Height)
						{
							num3 += uielement.DesiredSize.Height;
							num4 = global::System.Math.Max(num4, num3);
							flag2 = true;
							break;
						}
						if (i + 1 >= this.MaxColumns)
						{
							break;
						}
						i++;
						num3 = 0.0;
						num2 += this.ColumnWidth;
					}
					if (!flag2)
					{
						flag = true;
					}
				}
			}
			double height2 = availableSize.Height;
			if (i == 0 && flag)
			{
				height2 = num4;
			}
			else if (double.IsPositiveInfinity(availableSize.Height))
			{
				height2 = num4;
			}
			return new global::System.Windows.Size((double)(i + 1) * this.ColumnWidth, height2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000198F4 File Offset: 0x00017AF4
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._inArrange)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00019908 File Offset: 0x00017B08
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			switch (e.Key)
			{
			case global::System.Windows.Input.Key.Up:
			case global::System.Windows.Input.Key.Down:
			{
				bool flag = (e.Key == global::System.Windows.Input.Key.Down) ? this._scrollDownButtonIsVisible : this._scrollUpButtonIsVisible;
				global::System.Windows.UIElement uielement = (e.Key == global::System.Windows.Input.Key.Down) ? this._lastArrangedChild : base.Children[(int)this.VerticalOffset];
				global::System.Windows.UIElement uielement2 = e.OriginalSource as global::System.Windows.UIElement;
				int num = base.Children.IndexOf(uielement2);
				if (flag)
				{
					if (uielement2 == uielement)
					{
						global::System.Windows.UIElement uielement3;
						if (e.Key == global::System.Windows.Input.Key.Down)
						{
							uielement3 = base.Children[global::System.Math.Min(base.Children.Count - 1, num + 1)];
						}
						else
						{
							uielement3 = base.Children[global::System.Math.Max(0, num - 1)];
						}
						this.EnsureItemIsInView(uielement3);
						uielement3.Focus();
						this.SelectorControl.SelectedItem = ((global::System.Windows.Controls.ListBoxItem)uielement3).Content;
						e.Handled = true;
						return;
					}
				}
				else if (uielement2 == uielement)
				{
					if (e.Key == global::System.Windows.Input.Key.Down)
					{
						uielement.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Next));
					}
					else
					{
						uielement.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Previous));
					}
					e.Handled = true;
					return;
				}
				break;
			}
			}
			base.OnPreviewKeyDown(e);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00019A45 File Offset: 0x00017C45
		private static bool OnValidateColumnWidth(object value)
		{
			return (double)value > 0.0;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00019A58 File Offset: 0x00017C58
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00019A6A File Offset: 0x00017C6A
		public double ColumnWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ColumnWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ColumnWidthProperty, value);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00019A7D File Offset: 0x00017C7D
		private static bool OnValidateMaxColumns(object value)
		{
			return (int)value > 0;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00019A88 File Offset: 0x00017C88
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00019A9A File Offset: 0x00017C9A
		public int MaxColumns
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.MaxColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.MaxColumnsProperty, value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00019AAD File Offset: 0x00017CAD
		internal global::System.Windows.Controls.Primitives.Selector SelectorControl
		{
			get
			{
				if (this._selectorControl == null)
				{
					this._selectorControl = (global::System.Windows.Controls.ItemsControl.GetItemsOwner(this) as global::System.Windows.Controls.Primitives.Selector);
				}
				return this._selectorControl;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00019ACE File Offset: 0x00017CCE
		internal global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ScrollData ScrollingData
		{
			get
			{
				if (this._scrollingData == null)
				{
					this._scrollingData = new global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ScrollData();
				}
				return this._scrollingData;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00019AE9 File Offset: 0x00017CE9
		internal double ScrollLargeChange
		{
			get
			{
				return this.ScrollingData._viewport.Height;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00019AFB File Offset: 0x00017CFB
		private int TotalItemCount
		{
			get
			{
				return base.Children.Count;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00019B08 File Offset: 0x00017D08
		internal static bool GetIsFirstVisibleItem(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.IsFirstVisibleItemProperty);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00019B1A File Offset: 0x00017D1A
		internal static bool GetIsLastVisibleItem(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.IsLastVisibleItemProperty);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00019B2C File Offset: 0x00017D2C
		private void InitializeAdorner()
		{
			if (this._paneNavigatorItemsPanelAdorner != null)
			{
				return;
			}
			this._paneNavigatorItemsPanelAdorner = new global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanelAdorner(this);
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
			if (adornerLayer != null)
			{
				adornerLayer.Add(this._paneNavigatorItemsPanelAdorner);
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00019B64 File Offset: 0x00017D64
		private void OnScrollInfoChange()
		{
			if (this.ScrollingData._scrollOwner != null)
			{
				this.ScrollingData._scrollOwner.InvalidateScrollInfo();
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00019B84 File Offset: 0x00017D84
		private void UpdateScrollData(global::System.Windows.Size newExtent, global::System.Windows.Size newViewport, global::System.Windows.Vector newOffset)
		{
			if (this.ScrollingData._extent != newExtent || this.ScrollingData._viewport != newViewport || this.ScrollingData._offset != newOffset)
			{
				this.ScrollingData._extent = newExtent;
				this.ScrollingData._viewport = newViewport;
				this.ScrollingData._offset = newOffset;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00019BEE File Offset: 0x00017DEE
		internal void AddLogicalChildInternal(global::System.Windows.DependencyObject child)
		{
			base.AddLogicalChild(child);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00019BF8 File Offset: 0x00017DF8
		internal void EnsureItemIsInView(global::System.Windows.UIElement elementToMakeVisible)
		{
			int i = base.Children.IndexOf(elementToMakeVisible);
			if (i != -1)
			{
				int selectedIndex = this.SelectorControl.SelectedIndex;
				if (selectedIndex != -1)
				{
					if (selectedIndex < i)
					{
						while (i > this._lastArrangedChildIndex)
						{
							this.SetVerticalOffset(global::System.Math.Min((double)(base.Children.Count - 1), this.VerticalOffset + (double)(i - this._lastArrangedChildIndex)));
							base.UpdateLayout();
						}
						return;
					}
					int num = (int)this.VerticalOffset;
					if (num > i)
					{
						this.SetVerticalOffset(global::System.Math.Max(this.VerticalOffset - (double)(num - i), 0.0));
						base.UpdateLayout();
					}
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00019C99 File Offset: 0x00017E99
		public double ExtentHeight
		{
			get
			{
				return this.ScrollingData._extent.Height;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00019CAB File Offset: 0x00017EAB
		public double ExtentWidth
		{
			get
			{
				return this.ScrollingData._extent.Width;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00019CBD File Offset: 0x00017EBD
		public double HorizontalOffset
		{
			get
			{
				return this.ScrollingData._offset.Y;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00019CCF File Offset: 0x00017ECF
		public double VerticalOffset
		{
			get
			{
				return this.ScrollingData._offset.Y;
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00019CE1 File Offset: 0x00017EE1
		public void SetHorizontalOffset(double offset)
		{
			this.SetVerticalOffset(offset);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00019CEC File Offset: 0x00017EEC
		public void SetVerticalOffset(double offset)
		{
			global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ScrollData scrollingData = this.ScrollingData;
			global::System.Math.Min(global::System.Math.Max(offset, 0.0), scrollingData._viewport.Height - 1.0);
			scrollingData._offset.Y = offset;
			base.InvalidateMeasure();
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00019D3C File Offset: 0x00017F3C
		public void LineDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00019D54 File Offset: 0x00017F54
		public void LineLeft()
		{
			this.SetHorizontalOffset(this.HorizontalOffset - 1.0);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00019D6C File Offset: 0x00017F6C
		public void LineRight()
		{
			this.SetHorizontalOffset(this.HorizontalOffset + 1.0);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00019D84 File Offset: 0x00017F84
		public void LineUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00019D9C File Offset: 0x00017F9C
		public void MouseWheelDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00019DB4 File Offset: 0x00017FB4
		public void MouseWheelLeft()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00019DCC File Offset: 0x00017FCC
		public void MouseWheelRight()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00019DE4 File Offset: 0x00017FE4
		public void MouseWheelUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00019DFC File Offset: 0x00017FFC
		public void PageDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + this.ScrollLargeChange);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00019E11 File Offset: 0x00018011
		public void PageLeft()
		{
			this.SetHorizontalOffset(this.HorizontalOffset - this.ScrollLargeChange);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00019E26 File Offset: 0x00018026
		public void PageRight()
		{
			this.SetHorizontalOffset(this.HorizontalOffset + this.ScrollLargeChange);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00019E3B File Offset: 0x0001803B
		public void PageUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - this.ScrollLargeChange);
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00019E50 File Offset: 0x00018050
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00019E5D File Offset: 0x0001805D
		public global::System.Windows.Controls.ScrollViewer ScrollOwner
		{
			get
			{
				return this.ScrollingData._scrollOwner;
			}
			set
			{
				if (value != this.ScrollingData._scrollOwner)
				{
					this.ScrollingData.Reset();
					this.ScrollingData._scrollOwner = value;
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00019E84 File Offset: 0x00018084
		public double ViewportHeight
		{
			get
			{
				return this.ScrollingData._viewport.Height;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00019E96 File Offset: 0x00018096
		public double ViewportWidth
		{
			get
			{
				return this.ScrollingData._viewport.Width;
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00019EA8 File Offset: 0x000180A8
		public global::System.Windows.Rect MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			return default(global::System.Windows.Rect);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00019EBE File Offset: 0x000180BE
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00019ECB File Offset: 0x000180CB
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanVerticallyScroll
		{
			get
			{
				return this.ScrollingData._canVerticallyScroll;
			}
			set
			{
				if (this.ScrollingData._canVerticallyScroll != value)
				{
					this.ScrollingData._canVerticallyScroll = value;
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00019EED File Offset: 0x000180ED
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00019EFA File Offset: 0x000180FA
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanHorizontallyScroll
		{
			get
			{
				return this.ScrollingData._canHorizontallyScroll;
			}
			set
			{
				if (this.ScrollingData._canHorizontallyScroll != value)
				{
					this.ScrollingData._canHorizontallyScroll = value;
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x040002F7 RID: 759
		private const int MAXCOLUMNS_DEFAULT = 1;

		// Token: 0x040002F8 RID: 760
		private const double COLUMNWIDTH_DEFAULT = 180.0;

		// Token: 0x040002F9 RID: 761
		private const int SCROLL_SMALL_CHANGE = 1;

		// Token: 0x040002FA RID: 762
		private global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ScrollData _scrollingData;

		// Token: 0x040002FB RID: 763
		private global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanelAdorner _paneNavigatorItemsPanelAdorner;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Controls.Primitives.Selector _selectorControl;

		// Token: 0x040002FD RID: 765
		private bool _scrollUpButtonIsVisible;

		// Token: 0x040002FE RID: 766
		private bool _scrollDownButtonIsVisible;

		// Token: 0x040002FF RID: 767
		private int _lastArrangedChildIndex = -1;

		// Token: 0x04000300 RID: 768
		private global::System.Windows.UIElement _lastArrangedChild;

		// Token: 0x04000301 RID: 769
		private bool _inArrange;

		// Token: 0x04000302 RID: 770
		public static readonly global::System.Windows.ResourceKey ScrollUpButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel), "ScrollUpButtonStyleKey");

		// Token: 0x04000303 RID: 771
		public static readonly global::System.Windows.ResourceKey ScrollDownButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel), "ScrollDownButtonStyleKey");

		// Token: 0x04000304 RID: 772
		public static readonly global::System.Windows.DependencyProperty ColumnWidthProperty = global::System.Windows.DependencyProperty.Register("ColumnWidth", typeof(double), typeof(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel), new global::System.Windows.FrameworkPropertyMetadata(180.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.OnValidateColumnWidth));

		// Token: 0x04000305 RID: 773
		public static readonly global::System.Windows.DependencyProperty MaxColumnsProperty = global::System.Windows.DependencyProperty.Register("MaxColumns", typeof(int), typeof(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel), new global::System.Windows.FrameworkPropertyMetadata(1), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.OnValidateMaxColumns));

		// Token: 0x04000306 RID: 774
		private static readonly global::System.Windows.DependencyPropertyKey IsFirstVisibleItemPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsFirstVisibleItem", typeof(bool), typeof(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000307 RID: 775
		internal static readonly global::System.Windows.DependencyProperty IsFirstVisibleItemProperty = global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.IsFirstVisibleItemPropertyKey.DependencyProperty;

		// Token: 0x04000308 RID: 776
		private static readonly global::System.Windows.DependencyPropertyKey IsLastVisibleItemPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsLastVisibleItem", typeof(bool), typeof(global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000309 RID: 777
		internal static readonly global::System.Windows.DependencyProperty IsLastVisibleItemProperty = global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.IsLastVisibleItemPropertyKey.DependencyProperty;

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060004B2 RID: 1202
		private delegate void DeferredFocusDelegate(global::System.Windows.UIElement element);

		// Token: 0x02000082 RID: 130
		internal class ScrollData
		{
			// Token: 0x060004B5 RID: 1205 RVA: 0x0001A05E File Offset: 0x0001825E
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
			}

			// Token: 0x0400030A RID: 778
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x0400030B RID: 779
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x0400030C RID: 780
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x0400030D RID: 781
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x0400030E RID: 782
			internal bool _canHorizontallyScroll;

			// Token: 0x0400030F RID: 783
			internal bool _canVerticallyScroll;
		}
	}
}
