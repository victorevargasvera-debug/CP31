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
	// Token: 0x020001E3 RID: 483
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TabItemPanel : global::System.Windows.Controls.Panel, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x00040964 File Offset: 0x0003EB64
		static TabItemPanel()
		{
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Once));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00040BB4 File Offset: 0x0003EDB4
		public TabItemPanel()
		{
			this._maximumTabRows = (int)global::Infragistics.Windows.Controls.TabItemPanel.MaximumTabRowsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00040BE4 File Offset: 0x0003EDE4
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

		// Token: 0x06001215 RID: 4629 RVA: 0x000410AC File Offset: 0x0003F2AC
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

		// Token: 0x06001216 RID: 4630 RVA: 0x00041595 File Offset: 0x0003F795
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._isMeasuringInArrange)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x000415A8 File Offset: 0x0003F7A8
		protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost)
		{
			global::System.Windows.Controls.ItemsControl itemsOwner = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this);
			this.HookSelector(itemsOwner as global::System.Windows.Controls.Primitives.Selector);
			base.OnIsItemsHostChanged(oldIsItemsHost, newIsItemsHost);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000415D0 File Offset: 0x0003F7D0
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

		// Token: 0x06001219 RID: 4633 RVA: 0x00041684 File Offset: 0x0003F884
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			if (visualRemoved != null)
			{
				global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = (global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo)visualRemoved.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabInfoProperty);
				if (tabItemInfo != null)
				{
					tabItemInfo.Row.Tabs.Remove(tabItemInfo);
				}
				visualRemoved.ClearValue(global::Infragistics.Windows.Controls.TabItemPanel.TabInfoProperty);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000416D0 File Offset: 0x0003F8D0
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

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0004171C File Offset: 0x0003F91C
		internal double HorizontalOffsetInternal
		{
			get
			{
				return this.ScrollDataInfo._offset.X;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x0004172E File Offset: 0x0003F92E
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x00041740 File Offset: 0x0003F940
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

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00041753 File Offset: 0x0003F953
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x00041765 File Offset: 0x0003F965
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

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00041778 File Offset: 0x0003F978
		private bool InvertsHorizontalOffset
		{
			get
			{
				return this.IsMultiRow && this.TabStripPlacement == global::System.Windows.Controls.Dock.Left;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x0004178D File Offset: 0x0003F98D
		private bool InvertsVerticalOffset
		{
			get
			{
				return this.IsMultiRow && this.TabStripPlacement == global::System.Windows.Controls.Dock.Top;
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000417A2 File Offset: 0x0003F9A2
		public static bool GetIsFirstTabInRow(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.IsFirstTabInRowProperty);
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x000417B4 File Offset: 0x0003F9B4
		private bool IsMultiRow
		{
			get
			{
				return global::Infragistics.Windows.Controls.TabItemPanel.IsMultiRowStyle(this.TabLayoutStyle);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x000417C1 File Offset: 0x0003F9C1
		private bool IsScrollClient
		{
			get
			{
				return this._scrollDataInfo != null && this._scrollDataInfo._scrollOwner != null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x000417E0 File Offset: 0x0003F9E0
		private bool IsVertical
		{
			get
			{
				global::System.Windows.Controls.Dock tabStripPlacement = this.TabStripPlacement;
				return tabStripPlacement == global::System.Windows.Controls.Dock.Left || tabStripPlacement == global::System.Windows.Controls.Dock.Right;
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00041800 File Offset: 0x0003FA00
		private static void OnMaximumSizeToFitAdjustment(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = d as global::Infragistics.Windows.Controls.TabItemPanel;
			if (tabItemPanel != null && tabItemPanel.TabLayoutStyle == global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowSizeToFit)
			{
				tabItemPanel._lastExtent = null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x0004182C File Offset: 0x0003FA2C
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x0004183E File Offset: 0x0003FA3E
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

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x00041854 File Offset: 0x0003FA54
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

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000418C0 File Offset: 0x0003FAC0
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

		// Token: 0x0600122B RID: 4651 RVA: 0x0004192B File Offset: 0x0003FB2B
		public static double GetTabSeparatorOpacity(global::System.Windows.DependencyObject d)
		{
			return (double)d.GetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabSeparatorOpacityProperty);
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0004193D File Offset: 0x0003FB3D
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x0004194F File Offset: 0x0003FB4F
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

		// Token: 0x0600122E RID: 4654 RVA: 0x00041964 File Offset: 0x0003FB64
		private static void OnMaximumTabRowsChanged(object target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = target as global::Infragistics.Windows.Controls.TabItemPanel;
			if (tabItemPanel != null)
			{
				tabItemPanel._maximumTabRows = (int)e.NewValue;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0004198D File Offset: 0x0003FB8D
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x00041995 File Offset: 0x0003FB95
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x000419A8 File Offset: 0x0003FBA8
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

		// Token: 0x06001232 RID: 4658 RVA: 0x000419E4 File Offset: 0x0003FBE4
		private static void OnTabLayoutStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = target as global::Infragistics.Windows.Controls.TabItemPanel;
			if (tabItemPanel != null && tabItemPanel.IsInitialized)
			{
				tabItemPanel._alignTabRowToSelectedTab = true;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00041A0A File Offset: 0x0003FC0A
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x00041A1C File Offset: 0x0003FC1C
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

		// Token: 0x06001235 RID: 4661 RVA: 0x00041A30 File Offset: 0x0003FC30
		private static void OnTabStripPlacementChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.TabItemPanel tabItemPanel = target as global::Infragistics.Windows.Controls.TabItemPanel;
			if (tabItemPanel != null && tabItemPanel.IsInitialized)
			{
				tabItemPanel._alignTabRowToSelectedTab = true;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00041A56 File Offset: 0x0003FC56
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x00041A68 File Offset: 0x0003FC68
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

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00041A7B File Offset: 0x0003FC7B
		internal double VerticalOffsetInternal
		{
			get
			{
				return this.ScrollDataInfo._offset.Y;
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00041A8D File Offset: 0x0003FC8D
		private void AdjustHorizontalOffset(double adjustment, bool adjustForOrientation)
		{
			this.SetHorizontalOffset(((global::System.Windows.Controls.Primitives.IScrollInfo)this).HorizontalOffset + adjustment, true);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00041AA0 File Offset: 0x0003FCA0
		private double AdjustTabsProportionally(global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> tabs, bool hasMultiplePriorities, bool isVertical, double adjustment, double maxPerTabAdjustment)
		{
			bool flag = adjustment > 0.0;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo>(tabs);
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
					global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo tabItemInfo = list[i];
					if (tabItemInfo.AdjustmentMade > 0.0)
					{
						double num = tabItemInfo.AdjustmentMade / maxPerTabAdjustment;
						object value = (num > 0.3) ? global::Infragistics.KnownBoxes.DoubleZeroBox : (1.0 - num / 0.3);
						tabItemInfo.Element.SetValue(global::Infragistics.Windows.Controls.TabItemPanel.TabSeparatorOpacityPropertyKey, value);
					}
					i++;
				}
			}
			return result;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00041B78 File Offset: 0x0003FD78
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

		// Token: 0x0600123C RID: 4668 RVA: 0x00041D54 File Offset: 0x0003FF54
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
					if (expanding && maxPerTabAdjustment > 0.0 && num4 > maxPerTabAdjustment)
					{
						num4 = maxPerTabAdjustment;
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

		// Token: 0x0600123D RID: 4669 RVA: 0x00041E7C File Offset: 0x0004007C
		private void AdjustVerticalOffset(double adjustment, bool adjustForOrientation)
		{
			this.SetVerticalOffset(((global::System.Windows.Controls.Primitives.IScrollInfo)this).VerticalOffset + adjustment, true);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00041E90 File Offset: 0x00040090
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

		// Token: 0x0600123F RID: 4671 RVA: 0x00041F03 File Offset: 0x00040103
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

		// Token: 0x06001240 RID: 4672 RVA: 0x00041F30 File Offset: 0x00040130
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

		// Token: 0x06001241 RID: 4673 RVA: 0x00041F80 File Offset: 0x00040180
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

		// Token: 0x06001242 RID: 4674 RVA: 0x00041FE8 File Offset: 0x000401E8
		private void HookSelector(global::System.Windows.Controls.Primitives.Selector selector)
		{
			this.UnhookSelector();
			this._hookedSelector = selector;
			if (selector != null)
			{
				selector.SelectionChanged += this.OnSelectorSelectionChanged;
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0004200C File Offset: 0x0004020C
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

		// Token: 0x06001244 RID: 4676 RVA: 0x0004203C File Offset: 0x0004023C
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.OnLayoutUpdated;
			this.BringSelectedTabIntoView();
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00042056 File Offset: 0x00040256
		private void OnSelectorSelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00042058 File Offset: 0x00040258
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

		// Token: 0x06001247 RID: 4679 RVA: 0x00042110 File Offset: 0x00040310
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

		// Token: 0x06001248 RID: 4680 RVA: 0x000421C6 File Offset: 0x000403C6
		private void UnhookSelector()
		{
			if (this._hookedSelector != null)
			{
				this._hookedSelector.SelectionChanged += this.OnSelectorSelectionChanged;
				this._hookedSelector = null;
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000421F0 File Offset: 0x000403F0
		private void UpdateExtents(double extent)
		{
			this._lastExtent = new double?(extent);
			bool isVertical = this.IsVertical;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo> rows = this._rows;
			global::Infragistics.Windows.Controls.TabLayoutStyle tabLayoutStyle = this.TabLayoutStyle;
			double interTabSpacing = this.InterTabSpacing;
			int i = 0;
			int count = rows.Count;
			while (i < count)
			{
				global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo tabRowInfo = rows[i];
				global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> tabs = tabRowInfo.Tabs;
				double num = 0.0;
				int num2 = (tabs.Count > 0) ? global::Infragistics.Windows.Controls.XamTabControl.GetTabPriority(tabs[0].Element) : 0;
				bool flag = true;
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
					num += tabItemInfo.Extent + interTabSpacing;
					if (flag && num2 != tabItemInfo.Priority)
					{
						flag = false;
					}
					j++;
				}
				tabRowInfo.CurrentExtent = num - interTabSpacing;
				tabRowInfo.HasMultiplePriorities = !flag;
				i++;
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
						this.AdjustTabsProportionally(tabs, tabRowInfo.HasMultiplePriorities, isVertical, extent - tabRowInfo.CurrentExtent, 0.0);
					}
					break;
				case global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowSizeToFit:
				case global::Infragistics.Windows.Controls.TabLayoutStyle.MultiRowSizeToFit:
					if (tabRowInfo.CurrentExtent < extent)
					{
						this.AdjustTabsProportionally(tabs, tabRowInfo.HasMultiplePriorities, isVertical, extent - tabRowInfo.CurrentExtent, this.MaximumSizeToFitAdjustment);
					}
					else if (tabRowInfo.CurrentExtent > extent)
					{
						this.AdjustTabsProportionally(tabs, tabRowInfo.HasMultiplePriorities, isVertical, extent - tabRowInfo.CurrentExtent, 0.0);
					}
					break;
				}
				k++;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00042476 File Offset: 0x00040676
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00042492 File Offset: 0x00040692
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x000424A9 File Offset: 0x000406A9
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

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x000424BF File Offset: 0x000406BF
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x000424D6 File Offset: 0x000406D6
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x000424EC File Offset: 0x000406EC
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00042510 File Offset: 0x00040710
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00042534 File Offset: 0x00040734
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

		// Token: 0x06001252 RID: 4690 RVA: 0x00042580 File Offset: 0x00040780
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineDown()
		{
			this.AdjustVerticalOffset(this.GetScrollAdjustment(1.0), true);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00042598 File Offset: 0x00040798
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineLeft()
		{
			this.AdjustHorizontalOffset(this.GetScrollAdjustment(-1.0), true);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000425B0 File Offset: 0x000407B0
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineRight()
		{
			this.AdjustHorizontalOffset(this.GetScrollAdjustment(1.0), true);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000425C8 File Offset: 0x000407C8
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineUp()
		{
			this.AdjustVerticalOffset(this.GetScrollAdjustment(-1.0), true);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000425E0 File Offset: 0x000407E0
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

		// Token: 0x06001257 RID: 4695 RVA: 0x000427F7 File Offset: 0x000409F7
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelDown()
		{
			this.AdjustVerticalOffset(this.GetScrollAdjustment((double)(-(double)global::System.Windows.SystemParameters.WheelScrollLines)), true);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0004280D File Offset: 0x00040A0D
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelLeft()
		{
			this.AdjustHorizontalOffset(this.GetScrollAdjustment((double)(-(double)global::System.Windows.SystemParameters.WheelScrollLines)), true);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00042823 File Offset: 0x00040A23
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelRight()
		{
			this.AdjustHorizontalOffset(this.GetScrollAdjustment((double)global::System.Windows.SystemParameters.WheelScrollLines), true);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00042838 File Offset: 0x00040A38
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelUp()
		{
			this.AdjustVerticalOffset(this.GetScrollAdjustment((double)global::System.Windows.SystemParameters.WheelScrollLines), true);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0004284D File Offset: 0x00040A4D
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageDown()
		{
			this.AdjustVerticalOffset(this.ScrollDataInfo._viewport.Height, true);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00042866 File Offset: 0x00040A66
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageLeft()
		{
			this.AdjustHorizontalOffset(-this.ScrollDataInfo._viewport.Width, true);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00042880 File Offset: 0x00040A80
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageRight()
		{
			this.AdjustHorizontalOffset(this.ScrollDataInfo._viewport.Width, true);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00042899 File Offset: 0x00040A99
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageUp()
		{
			this.AdjustVerticalOffset(-this.ScrollDataInfo._viewport.Height, true);
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x000428B3 File Offset: 0x00040AB3
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x000428CA File Offset: 0x00040ACA
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

		// Token: 0x06001261 RID: 4705 RVA: 0x000428EC File Offset: 0x00040AEC
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetHorizontalOffset(double offset)
		{
			this.SetHorizontalOffset(offset, true);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000428F6 File Offset: 0x00040AF6
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetVerticalOffset(double offset)
		{
			this.SetVerticalOffset(offset, true);
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00042900 File Offset: 0x00040B00
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

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0004294C File Offset: 0x00040B4C
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00042970 File Offset: 0x00040B70
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

		// Token: 0x04000945 RID: 2373
		private const double LineOffset = 16.0;

		// Token: 0x04000946 RID: 2374
		private const double ElementOffset = 10000.0;

		// Token: 0x04000947 RID: 2375
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo> _rows = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo>();

		// Token: 0x04000948 RID: 2376
		private double? _lastExtent;

		// Token: 0x04000949 RID: 2377
		private double _lastPreferredExtent;

		// Token: 0x0400094A RID: 2378
		private bool _isMeasuringInArrange;

		// Token: 0x0400094B RID: 2379
		private double _tabRowHeight;

		// Token: 0x0400094C RID: 2380
		private global::System.Windows.Controls.Primitives.Selector _hookedSelector;

		// Token: 0x0400094D RID: 2381
		private int _maximumTabRows;

		// Token: 0x0400094E RID: 2382
		private bool _alignTabRowToSelectedTab;

		// Token: 0x0400094F RID: 2383
		private int _lastNumberOfRowsArranged;

		// Token: 0x04000950 RID: 2384
		public static readonly global::System.Windows.DependencyProperty InterRowSpacingProperty = global::Infragistics.Windows.Controls.XamTabControl.InterRowSpacingProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000951 RID: 2385
		public static readonly global::System.Windows.DependencyProperty InterTabSpacingProperty = global::Infragistics.Windows.Controls.XamTabControl.InterTabSpacingProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000952 RID: 2386
		private static readonly global::System.Windows.DependencyPropertyKey IsFirstTabInRowPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsFirstTabInRow", typeof(bool), typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000953 RID: 2387
		public static readonly global::System.Windows.DependencyProperty IsFirstTabInRowProperty = global::Infragistics.Windows.Controls.TabItemPanel.IsFirstTabInRowPropertyKey.DependencyProperty;

		// Token: 0x04000954 RID: 2388
		public static readonly global::System.Windows.DependencyProperty MaximumSizeToFitAdjustmentProperty = global::Infragistics.Windows.Controls.XamTabControl.MaximumSizeToFitAdjustmentProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnMaximumSizeToFitAdjustment)));

		// Token: 0x04000955 RID: 2389
		private static readonly global::System.Windows.DependencyPropertyKey TabSeparatorOpacityPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("TabSeparatorOpacity", typeof(double), typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(1.0));

		// Token: 0x04000956 RID: 2390
		public static readonly global::System.Windows.DependencyProperty TabSeparatorOpacityProperty = global::Infragistics.Windows.Controls.TabItemPanel.TabSeparatorOpacityPropertyKey.DependencyProperty;

		// Token: 0x04000957 RID: 2391
		public static readonly global::System.Windows.DependencyProperty MinimumTabExtentProperty = global::Infragistics.Windows.Controls.XamTabControl.MinimumTabExtentProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(18.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000958 RID: 2392
		public static readonly global::System.Windows.DependencyProperty MaximumTabRowsProperty = global::Infragistics.Windows.Controls.XamTabControl.MaximumTabRowsProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.XamTabControl.MaximumTabRowsProperty.DefaultMetadata.DefaultValue, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnMaximumTabRowsChanged)));

		// Token: 0x04000959 RID: 2393
		private static readonly global::System.Windows.DependencyProperty TabInfoProperty = global::System.Windows.DependencyProperty.RegisterAttached("TabInfo", typeof(global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo), typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400095A RID: 2394
		public static readonly global::System.Windows.DependencyProperty TabLayoutStyleProperty = global::Infragistics.Windows.Controls.XamTabControl.TabLayoutStyleProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.TabLayoutStyle.SingleRowAutoSize, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnTabLayoutStyleChanged)));

		// Token: 0x0400095B RID: 2395
		public static readonly global::System.Windows.DependencyProperty TabStripPlacementProperty = global::System.Windows.Controls.TabControl.TabStripPlacementProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.TabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.DockTopBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.TabItemPanel.OnTabStripPlacementChanged)));

		// Token: 0x0400095C RID: 2396
		private global::Infragistics.Windows.Controls.TabItemPanel.ScrollData _scrollDataInfo;

		// Token: 0x020001E4 RID: 484
		// (Invoke) Token: 0x06001267 RID: 4711
		private delegate void MethodInvoker();

		// Token: 0x020001E5 RID: 485
		private class TabItemInfo
		{
			// Token: 0x0600126A RID: 4714 RVA: 0x00042994 File Offset: 0x00040B94
			internal TabItemInfo(global::System.Windows.UIElement element, int childIndex, global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo row)
			{
				this.ChildIndex = childIndex;
				this.Element = element;
				this.Row = row;
			}

			// Token: 0x0400095D RID: 2397
			internal int ChildIndex;

			// Token: 0x0400095E RID: 2398
			internal double Extent;

			// Token: 0x0400095F RID: 2399
			internal double AdjustmentMade;

			// Token: 0x04000960 RID: 2400
			internal double MinExtent;

			// Token: 0x04000961 RID: 2401
			internal global::System.Windows.UIElement Element;

			// Token: 0x04000962 RID: 2402
			internal int Priority;

			// Token: 0x04000963 RID: 2403
			internal global::Infragistics.Windows.Controls.TabItemPanel.TabRowInfo Row;
		}

		// Token: 0x020001E6 RID: 486
		private class TabRowInfo
		{
			// Token: 0x04000964 RID: 2404
			internal double CurrentExtent;

			// Token: 0x04000965 RID: 2405
			internal double PreferredExtent;

			// Token: 0x04000966 RID: 2406
			internal bool HasMultiplePriorities;

			// Token: 0x04000967 RID: 2407
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> Tabs = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo>();
		}

		// Token: 0x020001E7 RID: 487
		private class TabPriorityComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo>
		{
			// Token: 0x0600126D RID: 4717 RVA: 0x000429D0 File Offset: 0x00040BD0
			private TabPriorityComparer()
			{
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x0600126E RID: 4718 RVA: 0x000429D8 File Offset: 0x00040BD8
			public static global::System.Collections.Generic.IComparer<global::Infragistics.Windows.Controls.TabItemPanel.TabItemInfo> Instance
			{
				get
				{
					return global::Infragistics.Windows.Controls.TabItemPanel.TabPriorityComparer.instance;
				}
			}

			// Token: 0x0600126F RID: 4719 RVA: 0x000429E0 File Offset: 0x00040BE0
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

			// Token: 0x04000968 RID: 2408
			private static global::Infragistics.Windows.Controls.TabItemPanel.TabPriorityComparer instance = new global::Infragistics.Windows.Controls.TabItemPanel.TabPriorityComparer();
		}

		// Token: 0x020001E8 RID: 488
		internal class ScrollData
		{
			// Token: 0x06001270 RID: 4720 RVA: 0x00042A35 File Offset: 0x00040C35
			internal ScrollData(global::Infragistics.Windows.Controls.TabItemPanel panel)
			{
				this._panel = panel;
			}

			// Token: 0x06001271 RID: 4721 RVA: 0x00042A68 File Offset: 0x00040C68
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
			}

			// Token: 0x06001272 RID: 4722 RVA: 0x00042A90 File Offset: 0x00040C90
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

			// Token: 0x06001273 RID: 4723 RVA: 0x00042B6C File Offset: 0x00040D6C
			private bool VerifyOffset()
			{
				double x = global::System.Math.Max(global::System.Math.Min(this._offset.X, this._panel.MaxHorizontalOffset), 0.0);
				double y = global::System.Math.Max(global::System.Math.Min(this._offset.Y, this._panel.MaxVerticalOffset), 0.0);
				global::System.Windows.Vector offset = this._offset;
				this._offset = new global::System.Windows.Vector(x, y);
				return !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._offset.X, offset.X) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._offset.Y, offset.Y);
			}

			// Token: 0x04000969 RID: 2409
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x0400096A RID: 2410
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x0400096B RID: 2411
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x0400096C RID: 2412
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x0400096D RID: 2413
			internal bool _canHorizontallyScroll;

			// Token: 0x0400096E RID: 2414
			internal bool _canVerticallyScroll;

			// Token: 0x0400096F RID: 2415
			private global::Infragistics.Windows.Controls.TabItemPanel _panel;
		}
	}
}
