using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000211 RID: 529
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TabItemPanel : global::System.Windows.Controls.Panel, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x060013E6 RID: 5094 RVA: 0x0004620C File Offset: 0x0004440C
		static TabItemPanel()
		{
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Once));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00046491 File Offset: 0x00044691
		public TabItemPanel()
		{
			this._maximumTabRows = (int)global::Infragistics.Windows.Controls.TabItemPanel.MaximumTabRowsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000464C0 File Offset: 0x000446C0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			bool isVertical = this.IsVertical;
			double num = 0.0;
			double interTabSpacing = this.InterTabSpacing;
			double interRowSpacing = this.InterRowSpacing;
			global::System.Windows.Controls.Dock tabStripPlacement = this.TabStripPlacement;
			int num2 = 0;
			double num3 = isVertical ? finalSize.Height : finalSize.Width;
			double num4 = num3;
			double? lastExtent = this._lastExtent;
			if (num4 != lastExtent.GetValueOrDefault() || lastExtent == null)
			{
				this.UpdateExtents(num3);
			}
			global::Infragistics.Windows.Controls.TabLayoutStyle tabLayoutStyle = this.TabLayoutStyle;
			double tabRowHeight = this._tabRowHeight;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo> rows = this._rows;
			int num5 = this.FirstTabItemRowIndex;
			int num6 = num5;
			global::System.Windows.Rect rect = default(global::System.Windows.Rect);
			switch (tabStripPlacement)
			{
			case global::System.Windows.Controls.Dock.Left:
				rect.X = finalSize.Width;
				break;
			case global::System.Windows.Controls.Dock.Top:
				rect.Y = finalSize.Height;
				break;
			}
			if (rows.Count > this.MaximumTabRows)
			{
				switch (tabStripPlacement)
				{
				case global::System.Windows.Controls.Dock.Left:
					rect.X += tabRowHeight * (double)num5;
					break;
				case global::System.Windows.Controls.Dock.Top:
					rect.Y += tabRowHeight * (double)num5;
					break;
				case global::System.Windows.Controls.Dock.Right:
					rect.X -= tabRowHeight * (double)num5;
					break;
				case global::System.Windows.Controls.Dock.Bottom:
					rect.Y -= tabRowHeight * (double)num5;
					break;
				}
				num5 = 0;
			}
			global::System.Windows.Point point = default(global::System.Windows.Point);
			if (!this.IsMultiRow && this.IsScrollClient)
			{
				switch (tabStripPlacement)
				{
				case global::System.Windows.Controls.Dock.Left:
				case global::System.Windows.Controls.Dock.Right:
					point.Y = rect.Y - this._scrollDataInfo._offset.Y;
					break;
				case global::System.Windows.Controls.Dock.Top:
				case global::System.Windows.Controls.Dock.Bottom:
					point.X = rect.X - this._scrollDataInfo._offset.X;
					break;
				}
			}
			int num7 = num6 + (this.MaximumTabRows - 1);
			int count = rows.Count;
			int i = num5;
			int num8 = num5 + count;
			while (i < num8)
			{
				global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo tabRowInfo = rows[i % count];
				global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> tabs = tabRowInfo.Tabs;
				double num9 = num;
				num = tabRowHeight;
				num2++;
				switch (tabStripPlacement)
				{
				case global::System.Windows.Controls.Dock.Left:
					rect.X -= num;
					if (num2 > 1)
					{
						rect.X -= interRowSpacing;
					}
					break;
				case global::System.Windows.Controls.Dock.Top:
					rect.Y -= num;
					if (num2 > 1)
					{
						rect.Y -= interRowSpacing;
					}
					break;
				case global::System.Windows.Controls.Dock.Right:
					rect.X += num9;
					if (num2 > 1)
					{
						rect.X += interRowSpacing;
					}
					break;
				case global::System.Windows.Controls.Dock.Bottom:
					rect.Y += num9;
					if (num2 > 1)
					{
						rect.Y += interRowSpacing;
					}
					break;
				}
				if (isVertical)
				{
					rect.Y = point.Y;
					rect.Width = num;
				}
				else
				{
					rect.Height = num;
					rect.X = point.X;
				}
				int j = 0;
				int count2 = tabs.Count;
				while (j < count2)
				{
					global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = tabs[j];
					global::System.Windows.UIElement element = tabItemInfo.Element;
					global::System.Windows.Size desiredSize = element.DesiredSize;
					double extent = tabItemInfo.Extent;
					if (isVertical)
					{
						rect.Height = extent;
					}
					else
					{
						rect.Width = extent;
					}
					if (rect.Width < element.DesiredSize.Width || rect.Height < element.DesiredSize.Height)
					{
						this._isMeasuringInArrange = true;
						element.Measure(rect.Size);
						this._isMeasuringInArrange = false;
					}
					if (i < num6 || i > num7)
					{
						global::System.Windows.Vector offsetVector = default(global::System.Windows.Vector);
						if (isVertical)
						{
							if (rect.X < 0.0)
							{
								offsetVector.X = -10000.0;
							}
							else
							{
								offsetVector.X = 10000.0;
							}
						}
						else if (rect.Y < 0.0)
						{
							offsetVector.Y = -10000.0;
						}
						else
						{
							offsetVector.Y = 10000.0;
						}
						element.Arrange(global::System.Windows.Rect.Offset(rect, offsetVector));
					}
					else
					{
						element.Arrange(rect);
					}
					if (!isVertical)
					{
						rect.X += extent + interTabSpacing;
					}
					else
					{
						rect.Y += extent + interTabSpacing;
					}
					j++;
				}
				i++;
			}
			if (this._alignTabRowToSelectedTab || this._lastNumberOfRowsArranged != count)
			{
				this._alignTabRowToSelectedTab = false;
				this._lastNumberOfRowsArranged = count;
				global::System.EventHandler value = new global::System.EventHandler(this.OnLayoutUpdated);
				base.LayoutUpdated -= value;
				base.LayoutUpdated += value;
			}
			return finalSize;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00046988 File Offset: 0x00044B88
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this._rows.Clear();
			this._lastExtent = null;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			int num5 = 0;
			int num6 = 0;
			double interTabSpacing = this.InterTabSpacing;
			double interRowSpacing = this.InterRowSpacing;
			bool isVertical = this.IsVertical;
			bool isMultiRow = this.IsMultiRow;
			double num7 = isVertical ? availableSize.Height : availableSize.Width;
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo tabRowInfo = null;
			bool flag = !isMultiRow && this.TabLayoutStyle != global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize;
			if (flag && double.IsPositiveInfinity(num7) && this.IsScrollClient)
			{
				flag = false;
			}
			this._lastPreferredExtent = 0.0;
			global::System.Windows.Size availableSize2 = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
			int i = 0;
			int count = children.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = children[i];
				if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					if (num5 == 0)
					{
						uielement.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.IsFirstTabInRowPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else
					{
						uielement.ClearValue(global::Infragistics.Windows.Controls.TabItemPanel.IsFirstTabInRowPropertyKey);
					}
					uielement.Measure(availableSize2);
					global::System.Windows.Size desiredSize = uielement.DesiredSize;
					double minExtent = this.GetMinExtent(uielement, isVertical);
					double num8 = global::System.Math.Max(minExtent, isVertical ? desiredSize.Height : desiredSize.Width);
					double num9 = flag ? minExtent : num8;
					double num10 = isVertical ? desiredSize.Width : desiredSize.Height;
					if (isMultiRow && num5 > 0 && num9 + num2 > num7 - interTabSpacing)
					{
						uielement.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.IsFirstTabInRowPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						if (!uielement.IsMeasureValid)
						{
							uielement.Measure(availableSize2);
							desiredSize = uielement.DesiredSize;
							minExtent = this.GetMinExtent(uielement, isVertical);
							num8 = global::System.Math.Max(minExtent, isVertical ? desiredSize.Height : desiredSize.Width);
							num9 = (flag ? minExtent : num8);
							num10 = (isVertical ? desiredSize.Width : desiredSize.Height);
						}
						if (num > num4)
						{
							num4 = num;
						}
						if (tabRowInfo.PreferredExtent > this._lastPreferredExtent)
						{
							this._lastPreferredExtent = tabRowInfo.PreferredExtent;
						}
						if (num2 > num3)
						{
							num3 = num2;
						}
						num5 = 0;
					}
					if (num5 == 0)
					{
						tabRowInfo = new global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo();
						this._rows.Add(tabRowInfo);
						num6++;
						num = num10;
						num2 = num9;
					}
					else
					{
						num2 += num9 + interTabSpacing;
						if (num10 > num)
						{
							num = num10;
						}
						tabRowInfo.PreferredExtent += interTabSpacing;
					}
					num5++;
					tabRowInfo.PreferredExtent += num8;
					global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = new global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo(uielement, i, tabRowInfo);
					tabRowInfo.Tabs.Add(tabItemInfo);
					uielement.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabInfoProperty, tabItemInfo);
				}
				i++;
			}
			if (num6 > 0)
			{
				if (num > num4)
				{
					num4 = num;
				}
				if (tabRowInfo.PreferredExtent > this._lastPreferredExtent)
				{
					this._lastPreferredExtent = tabRowInfo.PreferredExtent;
				}
				if (num2 > num3)
				{
					num3 = num2;
				}
			}
			if (this._lastPreferredExtent > num3 && num3 < num7)
			{
				num3 = global::System.Math.Min(this._lastPreferredExtent, num7);
			}
			this._tabRowHeight = num4;
			global::System.Windows.Size viewPort;
			global::System.Windows.Size extent;
			if (isMultiRow)
			{
				int num11 = global::System.Math.Max(0, this._rows.Count - 1);
				if (isVertical)
				{
					viewPort = new global::System.Windows.Size((double)global::System.Math.Min(num11, this.MaximumTabRows - 1), availableSize.Height);
					extent = new global::System.Windows.Size((double)num11, num3);
				}
				else
				{
					viewPort = new global::System.Windows.Size(availableSize.Width, (double)global::System.Math.Min(num11, this.MaximumTabRows - 1));
					extent = new global::System.Windows.Size(num3, (double)num11);
				}
			}
			else
			{
				viewPort = new global::System.Windows.Size(availableSize.Width, availableSize.Height);
				if (isVertical)
				{
					extent = new global::System.Windows.Size(num4, num3);
				}
				else
				{
					extent = new global::System.Windows.Size(num3, num4);
				}
			}
			global::System.Windows.Vector offset = this.ScrollDataInfo._offset;
			this.ScrollDataInfo.VerifyScrollData(viewPort, extent);
			if (isMultiRow && base.IsInitialized && (!global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this.ScrollDataInfo._offset.X, offset.X) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this.ScrollDataInfo._offset.Y, offset.Y)))
			{
				this._alignTabRowToSelectedTab = true;
			}
			double num12 = (num4 + interRowSpacing) * (double)global::System.Math.Min(this._rows.Count, this.MaximumTabRows);
			if (num12 > 0.0)
			{
				num12 -= interRowSpacing;
			}
			global::System.Windows.Size result = isVertical ? new global::System.Windows.Size(num12, num3) : new global::System.Windows.Size(num3, num12);
			if (this.IsScrollClient)
			{
				if (this.ScrollDataInfo._canHorizontallyScroll && availableSize.Width < result.Width)
				{
					result.Width = availableSize.Width;
				}
				if (this.ScrollDataInfo._canVerticallyScroll && availableSize.Height < result.Height)
				{
					result.Height = availableSize.Height;
				}
			}
			return result;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00046E71 File Offset: 0x00045071
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._isMeasuringInArrange)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00046E84 File Offset: 0x00045084
		protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost)
		{
			global::System.Windows.Controls.ItemsControl itemsOwner = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this);
			this.HookSelector(itemsOwner as global::System.Windows.Controls.Primitives.Selector);
			base.OnIsItemsHostChanged(oldIsItemsHost, newIsItemsHost);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00046EAC File Offset: 0x000450AC
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.FrameworkElement.ActualWidthProperty)
			{
				if (e.OldValue is double && (double)e.OldValue < this._lastPreferredExtent && !this.IsVertical && !this.IsMultiRow && this.TabLayoutStyle != global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize)
				{
					base.InvalidateMeasure();
					return;
				}
			}
			else if (e.Property == global::System.Windows.FrameworkElement.ActualHeightProperty && e.OldValue is double && (double)e.OldValue < this._lastPreferredExtent && this.IsVertical && !this.IsMultiRow && this.TabLayoutStyle != global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize)
			{
				base.InvalidateMeasure();
			}
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00046F60 File Offset: 0x00045160
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			if (visualRemoved != null)
			{
				global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = (global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo)visualRemoved.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabInfoProperty);
				if (tabItemInfo != null)
				{
					tabItemInfo.Group = null;
					tabItemInfo.Row.Tabs.Remove(tabItemInfo);
				}
				visualRemoved.ClearValue(global::Infragistics.Windows.Controls.TabItemPanel.TabInfoProperty);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00046FB0 File Offset: 0x000451B0
		private int FirstTabItemRowIndex
		{
			get
			{
				if (this._rows != null && this._rows.Count <= this.MaximumTabRows)
				{
					return this.SelectedTabRowIndex;
				}
				return (int)global::System.Math.Round(this.IsVertical ? ((global::System.Windows.Controls.Primitives.IScrollInfo)this).HorizontalOffset : ((global::System.Windows.Controls.Primitives.IScrollInfo)this).VerticalOffset, global::System.MidpointRounding.ToEven);
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00046FFC File Offset: 0x000451FC
		private static void OnGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::Infragistics.Windows.Utilities.IsUIElementOrUIElement3D(d))
			{
				global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(d) as global::Infragistics.Windows.Controls.TabItemPanel;
				if (tabItemPanel != null)
				{
					tabItemPanel.InvalidateArrange();
				}
				global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = d.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabInfoProperty) as global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo;
				if (tabItemInfo != null)
				{
					tabItemInfo.Group = (e.NewValue as global::Infragistics.Windows.Controls.ITabItemGroup);
				}
			}
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0004704C File Offset: 0x0004524C
		internal static global::Infragistics.Windows.Controls.ITabItemGroup GetGroup(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Controls.ITabItemGroup)d.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.GroupProperty);
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0004705E File Offset: 0x0004525E
		internal static void SetGroup(global::System.Windows.DependencyObject d, global::Infragistics.Windows.Controls.ITabItemGroup value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.GroupProperty, value);
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0004706C File Offset: 0x0004526C
		internal double HorizontalOffsetInternal
		{
			get
			{
				return this.ScrollDataInfo._offset.X;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0004707E File Offset: 0x0004527E
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x00047090 File Offset: 0x00045290
		[global::System.ComponentModel.Bindable(true)]
		public double InterRowSpacing
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.InterRowSpacingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.InterRowSpacingProperty, value);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x000470A3 File Offset: 0x000452A3
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x000470B5 File Offset: 0x000452B5
		[global::System.ComponentModel.Bindable(true)]
		public double InterTabSpacing
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.InterTabSpacingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.InterTabSpacingProperty, value);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x000470C8 File Offset: 0x000452C8
		private bool InvertsHorizontalOffset
		{
			get
			{
				return this.IsMultiRow && this.TabStripPlacement == global::System.Windows.Controls.Dock.Left;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000470DD File Offset: 0x000452DD
		private bool InvertsVerticalOffset
		{
			get
			{
				return this.IsMultiRow && this.TabStripPlacement == global::System.Windows.Controls.Dock.Top;
			}
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x000470F2 File Offset: 0x000452F2
		public static bool GetIsFirstTabInRow(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.IsFirstTabInRowProperty);
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00047104 File Offset: 0x00045304
		private bool IsMultiRow
		{
			get
			{
				return global::Infragistics.Windows.Controls.TabItemPanel.IsMultiRowStyle(this.TabLayoutStyle);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00047111 File Offset: 0x00045311
		private bool IsScrollClient
		{
			get
			{
				return this._scrollDataInfo != null && this._scrollDataInfo._scrollOwner != null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x00047130 File Offset: 0x00045330
		private bool IsVertical
		{
			get
			{
				global::System.Windows.Controls.Dock tabStripPlacement = this.TabStripPlacement;
				return tabStripPlacement == global::System.Windows.Controls.Dock.Left || tabStripPlacement == global::System.Windows.Controls.Dock.Right;
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00047150 File Offset: 0x00045350
		private static void OnMaximumSizeToFitAdjustment(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = d as global::Infragistics.Windows.Controls.TabItemPanel;
			if (tabItemPanel != null && tabItemPanel.TabLayoutStyle == global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowSizeToFit)
			{
				tabItemPanel._lastExtent = null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0004717C File Offset: 0x0004537C
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x0004718E File Offset: 0x0004538E
		[global::System.ComponentModel.Bindable(true)]
		public double MaximumSizeToFitAdjustment
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.MaximumSizeToFitAdjustmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.MaximumSizeToFitAdjustmentProperty, value);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x000471A4 File Offset: 0x000453A4
		internal double MaxHorizontalOffset
		{
			get
			{
				if (this.IsMultiRow && this.IsVertical)
				{
					return global::System.Math.Max(this.ScrollDataInfo._extent.Width, 0.0);
				}
				return global::System.Math.Max(this.ScrollDataInfo._extent.Width - this.ScrollDataInfo._viewport.Width, 0.0);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00047210 File Offset: 0x00045410
		internal double MaxVerticalOffset
		{
			get
			{
				if (this.IsMultiRow && !this.IsVertical)
				{
					return global::System.Math.Max(this.ScrollDataInfo._extent.Height, 0.0);
				}
				return global::System.Math.Max(this.ScrollDataInfo._extent.Height - this.ScrollDataInfo._viewport.Height, 0.0);
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0004727B File Offset: 0x0004547B
		public static double GetTabSeparatorOpacity(global::System.Windows.DependencyObject d)
		{
			return (double)d.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabSeparatorOpacityProperty);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0004728D File Offset: 0x0004548D
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0004729F File Offset: 0x0004549F
		[global::System.ComponentModel.Bindable(true)]
		public double MinimumTabExtent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.MinimumTabExtentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.MinimumTabExtentProperty, value);
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x000472B4 File Offset: 0x000454B4
		private static void OnMaximumTabRowsChanged(object target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = target as global::Infragistics.Windows.Controls.TabItemPanel;
			if (tabItemPanel != null)
			{
				tabItemPanel._maximumTabRows = (int)e.NewValue;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x000472DD File Offset: 0x000454DD
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x000472E5 File Offset: 0x000454E5
		[global::System.ComponentModel.Bindable(true)]
		public int MaximumTabRows
		{
			get
			{
				return this._maximumTabRows;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.MaximumTabRowsProperty, value);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x000472F8 File Offset: 0x000454F8
		private int SelectedTabRowIndex
		{
			get
			{
				int result = 0;
				global::System.Windows.Controls.Primitives.Selector selector = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this) as global::System.Windows.Controls.Primitives.Selector;
				if (selector != null && this._rows.Count > 1)
				{
					object selectedItem = selector.SelectedItem;
					result = this.GetTabItemRowNumber(selectedItem);
				}
				return result;
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00047334 File Offset: 0x00045534
		private static void OnTabLayoutStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = target as global::Infragistics.Windows.Controls.TabItemPanel;
			if (tabItemPanel != null && tabItemPanel.IsInitialized)
			{
				tabItemPanel._alignTabRowToSelectedTab = true;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0004735A File Offset: 0x0004555A
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0004736C File Offset: 0x0004556C
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.TabLayoutStyle TabLayoutStyle
		{
			get
			{
				return (global::Infragistics.Windows.Controls.TabLayoutStyle)base.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabLayoutStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabLayoutStyleProperty, value);
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00047380 File Offset: 0x00045580
		private static void OnTabStripPlacementChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = target as global::Infragistics.Windows.Controls.TabItemPanel;
			if (tabItemPanel != null && tabItemPanel.IsInitialized)
			{
				tabItemPanel._alignTabRowToSelectedTab = true;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x000473A6 File Offset: 0x000455A6
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x000473B8 File Offset: 0x000455B8
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Dock TabStripPlacement
		{
			get
			{
				return (global::System.Windows.Controls.Dock)base.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabStripPlacementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabStripPlacementProperty, value);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x000473CB File Offset: 0x000455CB
		internal double VerticalOffsetInternal
		{
			get
			{
				return this.ScrollDataInfo._offset.Y;
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x000473DD File Offset: 0x000455DD
		private void AdjustHorizontalOffset(double adjustment, bool adjustForOrientation)
		{
			this.SetHorizontalOffset(((global::System.Windows.Controls.Primitives.IScrollInfo)this).HorizontalOffset + adjustment, true);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x000473F0 File Offset: 0x000455F0
		private double AdjustTabsProportionally(global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> tabs, bool hasMultiplePriorities, bool isVertical, double adjustment, double maxPerTabAdjustment, bool skipUngroupedTabs)
		{
			bool flag = adjustment > 0.0;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo>();
			foreach (global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo in tabs)
			{
				if (!skipUngroupedTabs || tabItemInfo.Group != null)
				{
					list.Add(tabItemInfo);
				}
			}
			list.Sort(global::Infragistics.Windows.Controls.TabItemPanel.TabPriorityComparer.Instance);
			if (flag)
			{
				list.Reverse();
			}
			double result = this.AdjustTabsProportionallyImpl(list, hasMultiplePriorities, isVertical, adjustment, maxPerTabAdjustment);
			if (maxPerTabAdjustment > 0.0)
			{
				int i = 0;
				int count = tabs.Count;
				while (i < count)
				{
					global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo2 = tabs[i];
					if (tabItemInfo2.AdjustmentMade > 0.0)
					{
						double num = tabItemInfo2.AdjustmentMade / maxPerTabAdjustment;
						object value = (num > 0.3) ? global::Infragistics.KnownBoxes.DoubleZeroBox : (1.0 - num / 0.3);
						tabItemInfo2.Element.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabSeparatorOpacityPropertyKey, value);
					}
					i++;
				}
			}
			return result;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00047518 File Offset: 0x00045718
		private double AdjustTabsProportionallyImpl(global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> sortedTabs, bool hasMultiplePriorities, bool isVertical, double adjustment, double maxPerTabAdjustment)
		{
			bool flag = adjustment > 0.0;
			int count = sortedTabs.Count;
			double num = 0.0;
			int num2 = 0;
			int num3 = -1;
			int num4 = 0;
			while (!global::Infragistics.CoreUtilities.AreClose(adjustment, 0.0) && num2 < count)
			{
				int? num5 = null;
				int num6 = 0;
				int i = num2;
				double num7 = 0.0;
				double? num8 = null;
				while (i < count)
				{
					global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = sortedTabs[i];
					if (!double.IsNaN(tabItemInfo.Extent))
					{
						if (num5 == null)
						{
							num5 = new int?(tabItemInfo.Priority);
							num6++;
							num7 = tabItemInfo.Extent;
						}
						else
						{
							if (num5 != tabItemInfo.Priority)
							{
								break;
							}
							if (!flag && !global::Infragistics.CoreUtilities.AreClose(tabItemInfo.Extent, num7))
							{
								if (num3 == num2 && num4 >= num6)
								{
									num7 = tabItemInfo.Extent;
									num6++;
									break;
								}
								num8 = new double?(tabItemInfo.Extent);
								break;
							}
							else
							{
								num6++;
							}
						}
					}
					i++;
				}
				num3 = num2;
				num4 = num6;
				if (num6 > 0)
				{
					double num9 = (adjustment < 0.0) ? -1.0 : 1.0;
					double adjustment2 = (!flag && num8 != null) ? (num9 * global::System.Math.Min(global::System.Math.Abs(adjustment), global::System.Math.Abs(num7 - num8.Value) * (double)num6)) : adjustment;
					double num10 = this.AdjustTabsProportionallyImpl(sortedTabs, isVertical, num2, num6, adjustment2, flag, maxPerTabAdjustment);
					adjustment -= num10;
					num += num10;
					if (!flag && num8 != null && !global::Infragistics.CoreUtilities.AreClose(num10, 0.0))
					{
						continue;
					}
				}
				num2 = i;
			}
			return num;
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000476F4 File Offset: 0x000458F4
		private double AdjustTabsProportionallyImpl(global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> tabs, bool isVertical, int startIndex, int tabsToAdjust, double adjustment, bool expanding, double maxPerTabAdjustment)
		{
			int num = 0;
			int count = tabs.Count;
			double num2 = 0.0;
			int count2 = tabs.Count;
			for (int i = startIndex; i < count; i++)
			{
				global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = tabs[i];
				if (!double.IsNaN(tabItemInfo.Extent))
				{
					double num3 = tabItemInfo.Extent;
					double minExtent = tabItemInfo.MinExtent;
					double num4 = adjustment / (double)(tabsToAdjust - num);
					if (expanding && maxPerTabAdjustment > 0.0 && num4 + tabItemInfo.AdjustmentMade > maxPerTabAdjustment)
					{
						num4 = global::System.Math.Max(maxPerTabAdjustment - tabItemInfo.AdjustmentMade, 0.0);
					}
					else if (!expanding && maxPerTabAdjustment < 0.0 && num4 < maxPerTabAdjustment)
					{
						num4 = maxPerTabAdjustment;
					}
					num3 += num4;
					if (num3 < minExtent)
					{
						num4 += minExtent - num3;
						num3 += minExtent - num3;
					}
					tabItemInfo.Extent = num3;
					tabItemInfo.AdjustmentMade += num4;
					num2 += num4;
					adjustment -= num4;
					num++;
					if (num == tabsToAdjust || adjustment == 0.0)
					{
						return num2;
					}
					if (expanding)
					{
						if (adjustment < 0.0)
						{
							return num2;
						}
					}
					else if (adjustment > 0.0)
					{
						return num2;
					}
				}
			}
			return num2;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0004783A File Offset: 0x00045A3A
		private void AdjustVerticalOffset(double adjustment, bool adjustForOrientation)
		{
			this.SetVerticalOffset(((global::System.Windows.Controls.Primitives.IScrollInfo)this).VerticalOffset + adjustment, true);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0004784C File Offset: 0x00045A4C
		private void BringSelectedTabIntoView()
		{
			global::System.Windows.Controls.Primitives.Selector selector = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this) as global::System.Windows.Controls.Primitives.Selector;
			if (selector != null && selector.Items.Count > 0)
			{
				int num = selector.SelectedIndex;
				if (num < 0)
				{
					num = 0;
				}
				global::System.Windows.Media.Visual visual = selector.ItemContainerGenerator.ContainerFromIndex(num) as global::System.Windows.Media.Visual;
				if (visual != null)
				{
					((global::System.Windows.Controls.Primitives.IScrollInfo)this).MakeVisible(visual, new global::System.Windows.Rect(default(global::System.Windows.Point), new global::System.Windows.Size(base.ActualWidth, base.ActualHeight)));
				}
			}
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000478BF File Offset: 0x00045ABF
		private double GetScrollAdjustment(double adjustment)
		{
			if (!this.IsMultiRow)
			{
				adjustment *= 16.0;
			}
			if (this.InvertsHorizontalOffset || this.InvertsVerticalOffset)
			{
				return -adjustment;
			}
			return adjustment;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x000478EC File Offset: 0x00045AEC
		private double GetMinExtent(global::System.Windows.UIElement tabElement, bool isVertical)
		{
			global::System.Windows.FrameworkElement frameworkElement = tabElement as global::System.Windows.FrameworkElement;
			double num;
			if (frameworkElement != null)
			{
				num = (isVertical ? frameworkElement.MinHeight : frameworkElement.MinWidth);
			}
			else
			{
				num = double.NaN;
			}
			double minimumTabExtent = this.MinimumTabExtent;
			if (double.IsNaN(num))
			{
				num = minimumTabExtent;
			}
			else if (num < minimumTabExtent)
			{
				num = minimumTabExtent;
			}
			return num;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0004793C File Offset: 0x00045B3C
		private int GetTabItemRowNumber(object item)
		{
			int result = 0;
			global::System.Windows.Controls.Primitives.Selector selector = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this) as global::System.Windows.Controls.Primitives.Selector;
			if (selector != null && this._rows.Count > 1)
			{
				global::System.Windows.UIElement uielement = selector.ItemContainerGenerator.ContainerFromItem(item) as global::System.Windows.UIElement;
				if (uielement != null)
				{
					global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = (global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo)uielement.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabInfoProperty);
					if (tabItemInfo != null)
					{
						return this._rows.IndexOf(tabItemInfo.Row);
					}
				}
			}
			return result;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000479A4 File Offset: 0x00045BA4
		private void HookSelector(global::System.Windows.Controls.Primitives.Selector selector)
		{
			this.UnhookSelector();
			this._hookedSelector = selector;
			if (selector != null)
			{
				selector.SelectionChanged += this.OnSelectorSelectionChanged;
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x000479C8 File Offset: 0x00045BC8
		internal static bool IsMultiRowStyle(global::Infragistics.Windows.Controls.TabLayoutStyle style)
		{
			switch (style)
			{
			case global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize:
			case global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowJustified:
			case global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowSizeToFit:
				return false;
			case global::Infragistics.Windows.Controls.TabLayoutStyle.MultiRowAutoSize:
			case global::Infragistics.Windows.Controls.TabLayoutStyle.MultiRowSizeToFit:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x000479F8 File Offset: 0x00045BF8
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.OnLayoutUpdated;
			this.BringSelectedTabIntoView();
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00047A12 File Offset: 0x00045C12
		private void OnSelectorSelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00047A14 File Offset: 0x00045C14
		private void ProcessGroupExtents(global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo> rows, double extent)
		{
			double interTabSpacing = this.InterTabSpacing;
			global::Infragistics.Windows.Controls.TabLayoutStyle tabLayoutStyle = this.TabLayoutStyle;
			int i = 0;
			int count = rows.Count;
			while (i < count)
			{
				global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo tabRowInfo = rows[i];
				double num = extent - tabRowInfo.CurrentExtent;
				if (!global::Infragistics.CoreUtilities.LessThanOrClose(num, 0.0))
				{
					global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.Controls.ITabItemGroup, global::Infragistics.Windows.Controls.TabItemPanel.TabGroupInfo> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.Controls.ITabItemGroup, global::Infragistics.Windows.Controls.TabItemPanel.TabGroupInfo>();
					int j = 0;
					int count2 = tabRowInfo.Tabs.Count;
					while (j < count2)
					{
						global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = tabRowInfo.Tabs[j];
						global::Infragistics.Windows.Controls.ITabItemGroup group = tabItemInfo.Group;
						if (group != null)
						{
							global::Infragistics.Windows.Controls.TabItemPanel.TabGroupInfo tabGroupInfo;
							if (!dictionary.TryGetValue(group, out tabGroupInfo))
							{
								double preferredExtent = group.PreferredExtent;
								if (double.IsNaN(preferredExtent) || global::Infragistics.CoreUtilities.LessThanOrClose(preferredExtent, 0.0))
								{
									goto IL_D3;
								}
								tabGroupInfo = (dictionary[group] = new global::Infragistics.Windows.Controls.TabItemPanel.TabGroupInfo(group));
								tabGroupInfo.PreferredExtent = preferredExtent;
							}
							tabGroupInfo.Tabs.Add(tabItemInfo);
						}
						IL_D3:
						j++;
					}
					if (dictionary.Count != 0)
					{
						foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.Controls.ITabItemGroup, global::Infragistics.Windows.Controls.TabItemPanel.TabGroupInfo> keyValuePair in dictionary)
						{
							double num2 = 0.0;
							global::Infragistics.Windows.Controls.TabItemPanel.TabGroupInfo value = keyValuePair.Value;
							foreach (global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo2 in value.Tabs)
							{
								num2 += tabItemInfo2.Extent;
							}
							double num3 = num2 + (double)(value.Tabs.Count - 1) * interTabSpacing;
							value.SpaceNeeded = global::System.Math.Max(value.PreferredExtent - num3, 0.0);
							num -= value.SpaceNeeded;
						}
						if (global::Infragistics.CoreUtilities.LessThan(num, 0.0))
						{
							tabRowInfo.SkipExpandUngrouped = true;
							return;
						}
						foreach (global::Infragistics.Windows.Controls.TabItemPanel.TabGroupInfo tabGroupInfo2 in dictionary.Values)
						{
							this.AdjustTabsProportionally(tabGroupInfo2.Tabs, false, this.IsVertical, tabGroupInfo2.SpaceNeeded, 0.0, false);
							tabRowInfo.CurrentExtent += tabGroupInfo2.SpaceNeeded;
						}
					}
				}
				i++;
			}
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00047C90 File Offset: 0x00045E90
		private void SetHorizontalOffset(double offset, bool adjustForOrientation)
		{
			if (this.IsScrollClient)
			{
				double num;
				if (this.ScrollDataInfo._viewport.Width >= this.ScrollDataInfo._extent.Width)
				{
					num = 0.0;
				}
				else
				{
					double maxHorizontalOffset = this.MaxHorizontalOffset;
					if (this.IsMultiRow && this.IsVertical)
					{
						offset = global::System.Math.Round(offset, 0);
					}
					if (adjustForOrientation && this.InvertsHorizontalOffset)
					{
						offset = maxHorizontalOffset - offset;
					}
					num = global::System.Math.Max(global::System.Math.Min(offset, maxHorizontalOffset), 0.0);
				}
				if (num != this.ScrollDataInfo._offset.X)
				{
					this.ScrollDataInfo._offset.X = num;
					base.InvalidateArrange();
				}
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00047D48 File Offset: 0x00045F48
		private void SetVerticalOffset(double offset, bool adjustForOrientation)
		{
			if (this.IsScrollClient)
			{
				double num;
				if (this.ScrollDataInfo._viewport.Height >= this.ScrollDataInfo._extent.Height)
				{
					num = 0.0;
				}
				else
				{
					double maxVerticalOffset = this.MaxVerticalOffset;
					if (this.IsMultiRow && !this.IsVertical)
					{
						offset = global::System.Math.Round(offset, 0);
					}
					if (adjustForOrientation && this.InvertsVerticalOffset)
					{
						offset = maxVerticalOffset - offset;
					}
					num = global::System.Math.Max(global::System.Math.Min(offset, maxVerticalOffset), 0.0);
				}
				if (num != this.ScrollDataInfo._offset.Y)
				{
					this.ScrollDataInfo._offset.Y = num;
					base.InvalidateArrange();
				}
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00047DFE File Offset: 0x00045FFE
		private void UnhookSelector()
		{
			if (this._hookedSelector != null)
			{
				this._hookedSelector.SelectionChanged -= this.OnSelectorSelectionChanged;
				this._hookedSelector = null;
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00047E28 File Offset: 0x00046028
		private void UpdateExtents(double extent)
		{
			this._lastExtent = new double?(extent);
			bool isVertical = this.IsVertical;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo> rows = this._rows;
			global::Infragistics.Windows.Controls.TabLayoutStyle tabLayoutStyle = this.TabLayoutStyle;
			double interTabSpacing = this.InterTabSpacing;
			bool flag = false;
			int i = 0;
			int count = rows.Count;
			while (i < count)
			{
				global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo tabRowInfo = rows[i];
				global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> tabs = tabRowInfo.Tabs;
				double num = 0.0;
				int num2 = (tabs.Count > 0) ? global::Infragistics.Windows.Controls.XamTabControl.GetTabPriority(tabs[0].Element) : 0;
				bool flag2 = true;
				int j = 0;
				int count2 = tabs.Count;
				while (j < count2)
				{
					global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = tabs[j];
					tabItemInfo.AdjustmentMade = 0.0;
					tabItemInfo.Element.ClearValue(global::Infragistics.Windows.Controls.TabItemPanel.TabSeparatorOpacityPropertyKey);
					if (tabItemInfo.Element.Visibility == global::System.Windows.Visibility.Collapsed)
					{
						tabItemInfo.Extent = double.NaN;
					}
					else
					{
						double val = isVertical ? tabItemInfo.Element.DesiredSize.Height : tabItemInfo.Element.DesiredSize.Width;
						tabItemInfo.Extent = global::System.Math.Max(val, this.GetMinExtent(tabItemInfo.Element, isVertical));
					}
					tabItemInfo.Priority = global::Infragistics.Windows.Controls.XamTabControl.GetTabPriority(tabItemInfo.Element);
					tabItemInfo.MinExtent = this.GetMinExtent(tabItemInfo.Element, isVertical);
					tabItemInfo.Group = global::Infragistics.Windows.Controls.TabItemPanel.GetGroup(tabItemInfo.Element);
					num += tabItemInfo.Extent + interTabSpacing;
					if (tabItemInfo.Group != null)
					{
						flag = true;
					}
					if (flag2 && num2 != tabItemInfo.Priority)
					{
						flag2 = false;
					}
					j++;
				}
				tabRowInfo.CurrentExtent = num - interTabSpacing;
				tabRowInfo.HasMultiplePriorities = !flag2;
				tabRowInfo.SkipExpandUngrouped = false;
				i++;
			}
			if (flag)
			{
				this.ProcessGroupExtents(rows, extent);
			}
			if (tabLayoutStyle == global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize)
			{
				return;
			}
			if (tabLayoutStyle == global::Infragistics.Windows.Controls.TabLayoutStyle.MultiRowAutoSize)
			{
				return;
			}
			int k = 0;
			int count3 = rows.Count;
			while (k < count3)
			{
				global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo tabRowInfo = rows[k];
				global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> tabs = tabRowInfo.Tabs;
				switch (tabLayoutStyle)
				{
				case global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowJustified:
					if (tabRowInfo.CurrentExtent > extent)
					{
						this.AdjustTabsProportionally(tabs, tabRowInfo.HasMultiplePriorities, isVertical, extent - tabRowInfo.CurrentExtent, 0.0, tabRowInfo.SkipExpandUngrouped);
					}
					break;
				case global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowSizeToFit:
				case global::Infragistics.Windows.Controls.TabLayoutStyle.MultiRowSizeToFit:
					if (tabRowInfo.CurrentExtent < extent)
					{
						this.AdjustTabsProportionally(tabs, tabRowInfo.HasMultiplePriorities, isVertical, extent - tabRowInfo.CurrentExtent, this.MaximumSizeToFitAdjustment, tabRowInfo.SkipExpandUngrouped);
					}
					else if (tabRowInfo.CurrentExtent > extent)
					{
						this.AdjustTabsProportionally(tabs, tabRowInfo.HasMultiplePriorities, isVertical, extent - tabRowInfo.CurrentExtent, 0.0, tabRowInfo.SkipExpandUngrouped);
					}
					break;
				}
				k++;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x000480FB File Offset: 0x000462FB
		private global::Infragistics.Windows.Controls.TabItemPanel.ScrollData ScrollDataInfo
		{
			get
			{
				if (this._scrollDataInfo == null)
				{
					this._scrollDataInfo = new global::Infragistics.Windows.Controls.TabItemPanel.ScrollData(this);
				}
				return this._scrollDataInfo;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x00048117 File Offset: 0x00046317
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x0004812E File Offset: 0x0004632E
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanHorizontallyScroll
		{
			get
			{
				return this.IsScrollClient && this.ScrollDataInfo._canHorizontallyScroll;
			}
			set
			{
				if (this.IsScrollClient)
				{
					this.ScrollDataInfo._canHorizontallyScroll = value;
				}
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x00048144 File Offset: 0x00046344
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x0004815B File Offset: 0x0004635B
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanVerticallyScroll
		{
			get
			{
				return this.IsScrollClient && this.ScrollDataInfo._canVerticallyScroll;
			}
			set
			{
				if (this.IsScrollClient)
				{
					this.ScrollDataInfo._canVerticallyScroll = value;
				}
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x00048171 File Offset: 0x00046371
		double global::System.Windows.Controls.Primitives.IScrollInfo.ExtentHeight
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._extent.Height;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00048195 File Offset: 0x00046395
		double global::System.Windows.Controls.Primitives.IScrollInfo.ExtentWidth
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._extent.Width;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x000481BC File Offset: 0x000463BC
		double global::System.Windows.Controls.Primitives.IScrollInfo.HorizontalOffset
		{
			get
			{
				double num = 0.0;
				if (this.IsScrollClient)
				{
					num = this.ScrollDataInfo._offset.X;
					if (this.InvertsHorizontalOffset)
					{
						num = this.ScrollDataInfo._extent.Width - num;
					}
				}
				return num;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00048208 File Offset: 0x00046408
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineDown()
		{
			this.AdjustVerticalOffset(this.GetScrollAdjustment(1.0), true);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00048220 File Offset: 0x00046420
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineLeft()
		{
			this.AdjustHorizontalOffset(this.GetScrollAdjustment(-1.0), true);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00048238 File Offset: 0x00046438
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineRight()
		{
			this.AdjustHorizontalOffset(this.GetScrollAdjustment(1.0), true);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00048250 File Offset: 0x00046450
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineUp()
		{
			this.AdjustVerticalOffset(this.GetScrollAdjustment(-1.0), true);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00048268 File Offset: 0x00046468
		global::System.Windows.Rect global::System.Windows.Controls.Primitives.IScrollInfo.MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			if (this.IsScrollClient)
			{
				if (this.IsMultiRow)
				{
					global::System.Windows.Controls.TabItem tabItem = visual as global::System.Windows.Controls.TabItem;
					if (tabItem == null)
					{
						tabItem = (global::System.Windows.Controls.TabItem)global::Infragistics.Windows.Utilities.GetAncestorFromType(visual, typeof(global::System.Windows.Controls.TabItem), true, this);
					}
					if (tabItem != null)
					{
						global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = (global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo)tabItem.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabInfoProperty);
						if (tabItemInfo != null)
						{
							int num = this._rows.IndexOf(tabItemInfo.Row);
							if (num >= 0)
							{
								if (this.IsVertical)
								{
									((global::System.Windows.Controls.Primitives.IScrollInfo)this).SetHorizontalOffset((double)num);
								}
								else
								{
									((global::System.Windows.Controls.Primitives.IScrollInfo)this).SetVerticalOffset((double)num);
								}
							}
						}
					}
				}
				else
				{
					if (rectangle.IsEmpty || visual == null || !base.IsAncestorOf(visual))
					{
						return global::System.Windows.Rect.Empty;
					}
					global::System.Windows.Media.GeneralTransform generalTransform = visual.TransformToAncestor(this);
					if (generalTransform == null)
					{
						return global::System.Windows.Rect.Empty;
					}
					global::System.Windows.Rect rect = generalTransform.TransformBounds(rectangle);
					global::System.Windows.Rect rect2 = new global::System.Windows.Rect(base.RenderSize);
					global::System.Windows.Rect rect3 = global::System.Windows.Rect.Intersect(rect, rect2);
					if (rect3.Width != rect.Width)
					{
						double num2 = 0.0;
						if (rect.Right > rect2.Right)
						{
							num2 = rect.Right - rect2.Right;
						}
						if (rect.Left - num2 - rect2.Left < 0.0)
						{
							num2 += rect.Left - num2 - rect2.Left;
						}
						rect.X -= num2;
						num2 += ((global::System.Windows.Controls.Primitives.IScrollInfo)this).HorizontalOffset;
						((global::System.Windows.Controls.Primitives.IScrollInfo)this).SetHorizontalOffset(num2);
					}
					if (rect3.Height != rect.Height)
					{
						double num3 = 0.0;
						if (rect.Bottom > rect2.Bottom)
						{
							num3 = rect.Bottom - rect2.Bottom;
						}
						if (rect.Top - num3 - rect2.Top < 0.0)
						{
							num3 += rect.Top - num3 - rect2.Top;
						}
						rect.Y -= num3;
						num3 += ((global::System.Windows.Controls.Primitives.IScrollInfo)this).VerticalOffset;
						((global::System.Windows.Controls.Primitives.IScrollInfo)this).SetVerticalOffset(num3);
					}
					return rect;
				}
			}
			return rectangle;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0004847F File Offset: 0x0004667F
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelDown()
		{
			this.AdjustVerticalOffset(this.GetScrollAdjustment((double)(-(double)global::System.Windows.SystemParameters.WheelScrollLines)), true);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00048495 File Offset: 0x00046695
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelLeft()
		{
			this.AdjustHorizontalOffset(this.GetScrollAdjustment((double)(-(double)global::System.Windows.SystemParameters.WheelScrollLines)), true);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000484AB File Offset: 0x000466AB
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelRight()
		{
			this.AdjustHorizontalOffset(this.GetScrollAdjustment((double)global::System.Windows.SystemParameters.WheelScrollLines), true);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x000484C0 File Offset: 0x000466C0
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelUp()
		{
			this.AdjustVerticalOffset(this.GetScrollAdjustment((double)global::System.Windows.SystemParameters.WheelScrollLines), true);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x000484D5 File Offset: 0x000466D5
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageDown()
		{
			this.AdjustVerticalOffset(this.ScrollDataInfo._viewport.Height, true);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000484EE File Offset: 0x000466EE
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageLeft()
		{
			this.AdjustHorizontalOffset(-this.ScrollDataInfo._viewport.Width, true);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00048508 File Offset: 0x00046708
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageRight()
		{
			this.AdjustHorizontalOffset(this.ScrollDataInfo._viewport.Width, true);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00048521 File Offset: 0x00046721
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageUp()
		{
			this.AdjustVerticalOffset(-this.ScrollDataInfo._viewport.Height, true);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0004853B File Offset: 0x0004673B
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x00048552 File Offset: 0x00046752
		global::System.Windows.Controls.ScrollViewer global::System.Windows.Controls.Primitives.IScrollInfo.ScrollOwner
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return null;
				}
				return this.ScrollDataInfo._scrollOwner;
			}
			set
			{
				if (value != this.ScrollDataInfo._scrollOwner)
				{
					this.ScrollDataInfo._scrollOwner = value;
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00048574 File Offset: 0x00046774
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetHorizontalOffset(double offset)
		{
			this.SetHorizontalOffset(offset, true);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0004857E File Offset: 0x0004677E
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetVerticalOffset(double offset)
		{
			this.SetVerticalOffset(offset, true);
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00048588 File Offset: 0x00046788
		double global::System.Windows.Controls.Primitives.IScrollInfo.VerticalOffset
		{
			get
			{
				double num = 0.0;
				if (this.IsScrollClient)
				{
					num = this.ScrollDataInfo._offset.Y;
					if (this.InvertsVerticalOffset)
					{
						num = this.ScrollDataInfo._extent.Height - num;
					}
				}
				return num;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x000485D4 File Offset: 0x000467D4
		double global::System.Windows.Controls.Primitives.IScrollInfo.ViewportHeight
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._viewport.Height;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x000485F8 File Offset: 0x000467F8
		double global::System.Windows.Controls.Primitives.IScrollInfo.ViewportWidth
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._viewport.Width;
			}
		}

		// Token: 0x04000A89 RID: 2697
		private const double LineOffset = 16.0;

		// Token: 0x04000A8A RID: 2698
		private const double ElementOffset = 10000.0;

		// Token: 0x04000A8B RID: 2699
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo> _rows = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo>();

		// Token: 0x04000A8C RID: 2700
		private double? _lastExtent;

		// Token: 0x04000A8D RID: 2701
		private double _lastPreferredExtent;

		// Token: 0x04000A8E RID: 2702
		private bool _isMeasuringInArrange;

		// Token: 0x04000A8F RID: 2703
		private double _tabRowHeight;

		// Token: 0x04000A90 RID: 2704
		private global::System.Windows.Controls.Primitives.Selector _hookedSelector;

		// Token: 0x04000A91 RID: 2705
		private int _maximumTabRows;

		// Token: 0x04000A92 RID: 2706
		private bool _alignTabRowToSelectedTab;

		// Token: 0x04000A93 RID: 2707
		private int _lastNumberOfRowsArranged;

		// Token: 0x04000A94 RID: 2708
		internal static readonly global::System.Windows.DependencyProperty GroupProperty = global::System.Windows.DependencyProperty.RegisterAttached("Group", typeof(global::Infragistics.Windows.Controls.ITabItemGroup), typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnGroupChanged)));

		// Token: 0x04000A95 RID: 2709
		public static readonly global::System.Windows.DependencyProperty InterRowSpacingProperty = global::Infragistics.Windows.Controls.XamTabControl.InterRowSpacingProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000A96 RID: 2710
		public static readonly global::System.Windows.DependencyProperty InterTabSpacingProperty = global::Infragistics.Windows.Controls.XamTabControl.InterTabSpacingProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000A97 RID: 2711
		private static readonly global::System.Windows.DependencyPropertyKey IsFirstTabInRowPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsFirstTabInRow", typeof(bool), typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000A98 RID: 2712
		public static readonly global::System.Windows.DependencyProperty IsFirstTabInRowProperty = global::Infragistics.Windows.Controls.TabItemPanel.IsFirstTabInRowPropertyKey.DependencyProperty;

		// Token: 0x04000A99 RID: 2713
		public static readonly global::System.Windows.DependencyProperty MaximumSizeToFitAdjustmentProperty = global::Infragistics.Windows.Controls.XamTabControl.MaximumSizeToFitAdjustmentProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnMaximumSizeToFitAdjustment)));

		// Token: 0x04000A9A RID: 2714
		private static readonly global::System.Windows.DependencyPropertyKey TabSeparatorOpacityPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("TabSeparatorOpacity", typeof(double), typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(1.0));

		// Token: 0x04000A9B RID: 2715
		public static readonly global::System.Windows.DependencyProperty TabSeparatorOpacityProperty = global::Infragistics.Windows.Controls.TabItemPanel.TabSeparatorOpacityPropertyKey.DependencyProperty;

		// Token: 0x04000A9C RID: 2716
		public static readonly global::System.Windows.DependencyProperty MinimumTabExtentProperty = global::Infragistics.Windows.Controls.XamTabControl.MinimumTabExtentProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(18.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000A9D RID: 2717
		public static readonly global::System.Windows.DependencyProperty MaximumTabRowsProperty = global::Infragistics.Windows.Controls.XamTabControl.MaximumTabRowsProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.XamTabControl.MaximumTabRowsProperty.DefaultMetadata.DefaultValue, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnMaximumTabRowsChanged)));

		// Token: 0x04000A9E RID: 2718
		private static readonly global::System.Windows.DependencyProperty TabInfoProperty = global::System.Windows.DependencyProperty.RegisterAttached("TabInfo", typeof(global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo), typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A9F RID: 2719
		public static readonly global::System.Windows.DependencyProperty TabLayoutStyleProperty = global::Infragistics.Windows.Controls.XamTabControl.TabLayoutStyleProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnTabLayoutStyleChanged)));

		// Token: 0x04000AA0 RID: 2720
		public static readonly global::System.Windows.DependencyProperty TabStripPlacementProperty = global::System.Windows.Controls.TabControl.TabStripPlacementProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.DockTopBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnTabStripPlacementChanged)));

		// Token: 0x04000AA1 RID: 2721
		private global::Infragistics.Windows.Controls.TabItemPanel.ScrollData _scrollDataInfo;

		// Token: 0x02000212 RID: 530
		// (Invoke) Token: 0x0600143F RID: 5183
		private delegate void MethodInvoker();

		// Token: 0x02000213 RID: 531
		private class TabItemInfo
		{
			// Token: 0x06001442 RID: 5186 RVA: 0x0004861C File Offset: 0x0004681C
			internal TabItemInfo(global::System.Windows.UIElement element, int childIndex, global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo row)
			{
				this.ChildIndex = childIndex;
				this.Element = element;
				this.Row = row;
			}

			// Token: 0x170004A4 RID: 1188
			// (get) Token: 0x06001443 RID: 5187 RVA: 0x00048639 File Offset: 0x00046839
			// (set) Token: 0x06001444 RID: 5188 RVA: 0x0004864C File Offset: 0x0004684C
			internal global::Infragistics.Windows.Controls.ITabItemGroup Group
			{
				get
				{
					return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._group) as global::Infragistics.Windows.Controls.ITabItemGroup;
				}
				set
				{
					global::Infragistics.Windows.Controls.ITabItemGroup group = this.Group;
					if (value != group)
					{
						if (group != null)
						{
							group.PropertyChanged -= this.OnGroupPropertyChanged;
						}
						this._group = ((value != null) ? new global::System.WeakReference(value) : null);
						if (value != null)
						{
							value.PropertyChanged += this.OnGroupPropertyChanged;
						}
					}
				}
			}

			// Token: 0x06001445 RID: 5189 RVA: 0x000486A0 File Offset: 0x000468A0
			private void OnGroupPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
			{
				if (string.IsNullOrEmpty(e.PropertyName) || e.PropertyName == "PreferredExtent")
				{
					global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(this.Element) as global::Infragistics.Windows.Controls.TabItemPanel;
					if (tabItemPanel != null)
					{
						tabItemPanel.InvalidateArrange();
						tabItemPanel._lastExtent = null;
					}
				}
			}

			// Token: 0x04000AA2 RID: 2722
			internal int ChildIndex;

			// Token: 0x04000AA3 RID: 2723
			internal double Extent;

			// Token: 0x04000AA4 RID: 2724
			internal double AdjustmentMade;

			// Token: 0x04000AA5 RID: 2725
			internal double MinExtent;

			// Token: 0x04000AA6 RID: 2726
			internal readonly global::System.Windows.UIElement Element;

			// Token: 0x04000AA7 RID: 2727
			internal int Priority;

			// Token: 0x04000AA8 RID: 2728
			internal global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo Row;

			// Token: 0x04000AA9 RID: 2729
			private global::System.WeakReference _group;
		}

		// Token: 0x02000214 RID: 532
		private class TabRowInfo
		{
			// Token: 0x04000AAA RID: 2730
			internal double CurrentExtent;

			// Token: 0x04000AAB RID: 2731
			internal double PreferredExtent;

			// Token: 0x04000AAC RID: 2732
			internal bool HasMultiplePriorities;

			// Token: 0x04000AAD RID: 2733
			internal bool SkipExpandUngrouped;

			// Token: 0x04000AAE RID: 2734
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> Tabs = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo>();
		}

		// Token: 0x02000215 RID: 533
		private class TabGroupInfo
		{
			// Token: 0x06001447 RID: 5191 RVA: 0x00048705 File Offset: 0x00046905
			internal TabGroupInfo(global::Infragistics.Windows.Controls.ITabItemGroup group)
			{
				this.Group = group;
			}

			// Token: 0x04000AAF RID: 2735
			internal readonly global::Infragistics.Windows.Controls.ITabItemGroup Group;

			// Token: 0x04000AB0 RID: 2736
			internal double PreferredExtent;

			// Token: 0x04000AB1 RID: 2737
			internal double SpaceNeeded;

			// Token: 0x04000AB2 RID: 2738
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> Tabs = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo>();
		}

		// Token: 0x02000216 RID: 534
		private class TabPriorityComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo>
		{
			// Token: 0x06001449 RID: 5193 RVA: 0x0004872B File Offset: 0x0004692B
			private TabPriorityComparer()
			{
			}

			// Token: 0x170004A5 RID: 1189
			// (get) Token: 0x0600144A RID: 5194 RVA: 0x00048733 File Offset: 0x00046933
			public static global::System.Collections.Generic.IComparer<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> Instance
			{
				get
				{
					return global::Infragistics.Windows.Controls.TabItemPanel.TabPriorityComparer.instance;
				}
			}

			// Token: 0x0600144B RID: 5195 RVA: 0x0004873C File Offset: 0x0004693C
			public int Compare(global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo x, global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo y)
			{
				int num = x.Priority.CompareTo(y.Priority);
				if (num != 0)
				{
					return num;
				}
				if (x.Extent != y.Extent)
				{
					return y.Extent.CompareTo(x.Extent);
				}
				return y.ChildIndex.CompareTo(x.ChildIndex);
			}

			// Token: 0x04000AB3 RID: 2739
			private static global::Infragistics.Windows.Controls.TabItemPanel.TabPriorityComparer instance = new global::Infragistics.Windows.Controls.TabItemPanel.TabPriorityComparer();
		}

		// Token: 0x02000217 RID: 535
		internal class ScrollData
		{
			// Token: 0x0600144C RID: 5196 RVA: 0x00048791 File Offset: 0x00046991
			internal ScrollData(global::Infragistics.Windows.Controls.TabItemPanel panel)
			{
				this._panel = panel;
			}

			// Token: 0x0600144D RID: 5197 RVA: 0x000487C4 File Offset: 0x000469C4
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
			}

			// Token: 0x0600144E RID: 5198 RVA: 0x000487EC File Offset: 0x000469EC
			internal void VerifyScrollData(global::System.Windows.Size viewPort, global::System.Windows.Size extent)
			{
				if (double.IsInfinity(viewPort.Width))
				{
					viewPort.Width = extent.Width;
				}
				if (double.IsInfinity(viewPort.Height))
				{
					viewPort.Height = extent.Height;
				}
				bool flag = !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._viewport.Width, viewPort.Width) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._viewport.Height, viewPort.Height) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._extent.Width, extent.Width) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._extent.Height, extent.Height);
				this._viewport = viewPort;
				this._extent = extent;
				flag |= this.VerifyOffset();
				if (this._scrollOwner != null && flag)
				{
					this._scrollOwner.InvalidateScrollInfo();
				}
			}

			// Token: 0x0600144F RID: 5199 RVA: 0x000488C8 File Offset: 0x00046AC8
			private bool VerifyOffset()
			{
				double x = global::System.Math.Max(global::System.Math.Min(this._offset.X, this._panel.MaxHorizontalOffset), 0.0);
				double y = global::System.Math.Max(global::System.Math.Min(this._offset.Y, this._panel.MaxVerticalOffset), 0.0);
				global::System.Windows.Vector offset = this._offset;
				this._offset = new global::System.Windows.Vector(x, y);
				return !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._offset.X, offset.X) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._offset.Y, offset.Y);
			}

			// Token: 0x04000AB4 RID: 2740
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x04000AB5 RID: 2741
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x04000AB6 RID: 2742
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x04000AB7 RID: 2743
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x04000AB8 RID: 2744
			internal bool _canHorizontallyScroll;

			// Token: 0x04000AB9 RID: 2745
			internal bool _canVerticallyScroll;

			// Token: 0x04000ABA RID: 2746
			private global::Infragistics.Windows.Controls.TabItemPanel _panel;
		}
	}
}
