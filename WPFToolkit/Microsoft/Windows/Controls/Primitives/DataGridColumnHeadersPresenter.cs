using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Windows.Automation.Peers;
using MS.Internal;

namespace Microsoft.Windows.Controls.Primitives
{
	// Token: 0x02000063 RID: 99
	[global::System.Windows.TemplatePart(Name = "PART_FillerColumnHeader", Type = typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader))]
	public class DataGridColumnHeadersPresenter : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x000212B0 File Offset: 0x0001F4B0
		static DataGridColumnHeadersPresenter()
		{
			global::System.Type typeFromHandle = typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter);
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(typeFromHandle));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.FrameworkElementFactory root = new global::System.Windows.FrameworkElementFactory(typeof(global::Microsoft.Windows.Controls.DataGridCellsPanel));
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Controls.ItemsPanelTemplate(root)));
			global::System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter.OnIsVirtualizingPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter.OnCoerceIsVirtualizingProperty)));
			global::System.Windows.Controls.VirtualizingStackPanel.VirtualizationModeProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.VirtualizationMode.Recycling));
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0002135C File Offset: 0x0001F55C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			if (parentDataGrid != null)
			{
				base.ItemsSource = new global::Microsoft.Windows.Controls.ColumnHeaderCollection(parentDataGrid.Columns);
				parentDataGrid.ColumnHeadersPresenter = this;
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty);
				global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = base.GetTemplateChild("PART_FillerColumnHeader") as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
				if (dataGridColumnHeader != null)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(dataGridColumnHeader, global::System.Windows.FrameworkElement.StyleProperty);
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(dataGridColumnHeader, global::System.Windows.FrameworkElement.HeightProperty);
					return;
				}
			}
			else
			{
				base.ItemsSource = null;
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000213CE File Offset: 0x0001F5CE
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.DataGridColumnHeadersPresenterAutomationPeer(this);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000213D8 File Offset: 0x0001F5D8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size size = availableSize;
			size.Width = double.PositiveInfinity;
			global::System.Windows.Size result = base.MeasureOverride(size);
			if (this._columnHeaderDragIndicator != null && this._isColumnHeaderDragging)
			{
				this._columnHeaderDragIndicator.Measure(size);
				global::System.Windows.Size desiredSize = this._columnHeaderDragIndicator.DesiredSize;
				result.Width = global::System.Math.Max(result.Width, desiredSize.Width);
				result.Height = global::System.Math.Max(result.Height, desiredSize.Height);
			}
			if (this._columnHeaderDropLocationIndicator != null && this._isColumnHeaderDragging)
			{
				this._columnHeaderDropLocationIndicator.Measure(availableSize);
				global::System.Windows.Size desiredSize = this._columnHeaderDropLocationIndicator.DesiredSize;
				result.Width = global::System.Math.Max(result.Width, desiredSize.Width);
				result.Height = global::System.Math.Max(result.Height, desiredSize.Height);
			}
			result.Width = global::System.Math.Min(availableSize.Width, result.Width);
			return result;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000214D4 File Offset: 0x0001F6D4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.UIElement uielement = (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this) > 0) ? (global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0) as global::System.Windows.UIElement) : null;
			if (uielement != null)
			{
				global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid != null)
				{
					finalRect.X = -parentDataGrid.HorizontalScrollOffset;
					finalRect.Width = global::System.Math.Max(finalSize.Width, parentDataGrid.CellsPanelActualWidth);
				}
				uielement.Arrange(finalRect);
			}
			if (this._columnHeaderDragIndicator != null && this._isColumnHeaderDragging)
			{
				this._columnHeaderDragIndicator.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(this._columnHeaderDragCurrentPosition.X - this._columnHeaderDragStartRelativePosition.X, 0.0), new global::System.Windows.Size(this._columnHeaderDragIndicator.Width, this._columnHeaderDragIndicator.Height)));
			}
			if (this._columnHeaderDropLocationIndicator != null && this._isColumnHeaderDragging)
			{
				global::System.Windows.Point location = this.FindColumnHeaderPositionByCurrentPosition(this._columnHeaderDragCurrentPosition, true);
				double width = this._columnHeaderDropLocationIndicator.Width;
				location.X -= width * 0.5;
				this._columnHeaderDropLocationIndicator.Arrange(new global::System.Windows.Rect(location, new global::System.Windows.Size(width, this._columnHeaderDropLocationIndicator.Height)));
			}
			return finalSize;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00021608 File Offset: 0x0001F808
		protected override global::System.Windows.Media.Geometry GetLayoutClip(global::System.Windows.Size layoutSlotSize)
		{
			global::System.Windows.Media.RectangleGeometry rectangleGeometry = new global::System.Windows.Media.RectangleGeometry(new global::System.Windows.Rect(base.RenderSize));
			rectangleGeometry.Freeze();
			return rectangleGeometry;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0002162D File Offset: 0x0001F82D
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader();
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00021634 File Offset: 0x0001F834
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0002163F File Offset: 0x0001F83F
		internal bool IsItemItsOwnContainerInternal(object item)
		{
			return this.IsItemItsOwnContainerOverride(item);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00021648 File Offset: 0x0001F848
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = element as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
			if (dataGridColumnHeader != null)
			{
				global::Microsoft.Windows.Controls.DataGridColumn column = this.ColumnFromContainer(dataGridColumnHeader);
				if (dataGridColumnHeader.Column == null)
				{
					dataGridColumnHeader.Tracker.StartTracking(ref this._headerTrackingRoot);
				}
				dataGridColumnHeader.PrepareColumnHeader(item, column);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00021688 File Offset: 0x0001F888
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = element as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
			base.ClearContainerForItemOverride(element, item);
			if (dataGridColumnHeader != null)
			{
				dataGridColumnHeader.Tracker.StopTracking(ref this._headerTrackingRoot);
				dataGridColumnHeader.ClearHeader();
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000216C0 File Offset: 0x0001F8C0
		private global::Microsoft.Windows.Controls.DataGridColumn ColumnFromContainer(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader container)
		{
			int index = base.ItemContainerGenerator.IndexFromContainer(container);
			return this.HeaderCollection.ColumnFromIndex(index);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000216E6 File Offset: 0x0001F8E6
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			this.NotifyPropertyChanged(d, string.Empty, e, target);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000216F8 File Offset: 0x0001F8F8
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, string propertyName, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumnHeadersPresenter(target))
			{
				if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty)
				{
					if (dataGridColumn.IsVisible)
					{
						this.InvalidateDataGridCellsPanelMeasureAndArrange();
					}
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.FrozenColumnCountProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.VisibilityProperty || e.Property == global::Microsoft.Windows.Controls.DataGrid.CellsPanelHorizontalOffsetProperty || string.Compare(propertyName, "ViewportWidth", global::System.StringComparison.Ordinal) == 0 || string.Compare(propertyName, "DelayedColumnWidthComputation", global::System.StringComparison.Ordinal) == 0)
				{
					this.InvalidateDataGridCellsPanelMeasureAndArrange();
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.HorizontalScrollOffsetProperty)
				{
					base.InvalidateArrange();
					this.InvalidateDataGridCellsPanelMeasureAndArrange();
				}
				else if (string.Compare(propertyName, "RealizedColumnsBlockListForNonVirtualizedRows", global::System.StringComparison.Ordinal) == 0)
				{
					this.InvalidateDataGridCellsPanelMeasureAndArrange(false);
				}
				else if (string.Compare(propertyName, "RealizedColumnsBlockListForVirtualizedRows", global::System.StringComparison.Ordinal) == 0)
				{
					this.InvalidateDataGridCellsPanelMeasureAndArrange(true);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CellsPanelActualWidthProperty)
				{
					base.InvalidateArrange();
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty);
				}
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumnHeaders(target))
			{
				if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.HeaderProperty)
				{
					if (this.HeaderCollection != null)
					{
						this.HeaderCollection.NotifyHeaderPropertyChanged(dataGridColumn, e);
						return;
					}
				}
				else
				{
					for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader> containerTracking = this._headerTrackingRoot; containerTracking != null; containerTracking = containerTracking.Next)
					{
						containerTracking.Container.NotifyPropertyChanged(d, e);
					}
					if (d is global::Microsoft.Windows.Controls.DataGrid && (e.Property == global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderStyleProperty || e.Property == global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderHeightProperty))
					{
						global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = base.GetTemplateChild("PART_FillerColumnHeader") as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
						if (dataGridColumnHeader != null)
						{
							dataGridColumnHeader.NotifyPropertyChanged(d, e);
						}
					}
				}
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000218A4 File Offset: 0x0001FAA4
		private static void OnIsVirtualizingPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter)d;
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(dataGridColumnHeadersPresenter, global::System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty);
			if (e.OldValue != dataGridColumnHeadersPresenter.GetValue(global::System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty))
			{
				dataGridColumnHeadersPresenter.InvalidateDataGridCellsPanelMeasureAndArrange();
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000218E0 File Offset: 0x0001FAE0
		private static object OnCoerceIsVirtualizingProperty(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter = d as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumnHeadersPresenter, baseValue, global::System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty, dataGridColumnHeadersPresenter.ParentDataGrid, global::Microsoft.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0002190B File Offset: 0x0001FB0B
		private void InvalidateDataGridCellsPanelMeasureAndArrange()
		{
			if (this._internalItemsHost != null)
			{
				this._internalItemsHost.InvalidateMeasure();
				this._internalItemsHost.InvalidateArrange();
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0002192B File Offset: 0x0001FB2B
		private void InvalidateDataGridCellsPanelMeasureAndArrange(bool withColumnVirtualization)
		{
			if (withColumnVirtualization == global::System.Windows.Controls.VirtualizingStackPanel.GetIsVirtualizing(this))
			{
				this.InvalidateDataGridCellsPanelMeasureAndArrange();
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0002193C File Offset: 0x0001FB3C
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00021944 File Offset: 0x0001FB44
		internal global::System.Windows.Controls.Panel InternalItemsHost
		{
			get
			{
				return this._internalItemsHost;
			}
			set
			{
				this._internalItemsHost = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00021950 File Offset: 0x0001FB50
		protected override int VisualChildrenCount
		{
			get
			{
				int num = base.VisualChildrenCount;
				if (this._columnHeaderDragIndicator != null)
				{
					num++;
				}
				if (this._columnHeaderDropLocationIndicator != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00021980 File Offset: 0x0001FB80
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			int visualChildrenCount = base.VisualChildrenCount;
			if (index == visualChildrenCount)
			{
				if (this._columnHeaderDragIndicator != null)
				{
					return this._columnHeaderDragIndicator;
				}
				if (this._columnHeaderDropLocationIndicator != null)
				{
					return this._columnHeaderDropLocationIndicator;
				}
			}
			if (index == visualChildrenCount + 1 && this._columnHeaderDragIndicator != null && this._columnHeaderDropLocationIndicator != null)
			{
				return this._columnHeaderDropLocationIndicator;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000219DC File Offset: 0x0001FBDC
		internal void OnHeaderMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.ParentDataGrid == null)
			{
				return;
			}
			if (this._columnHeaderDragIndicator != null)
			{
				base.RemoveVisualChild(this._columnHeaderDragIndicator);
				this._columnHeaderDragIndicator = null;
			}
			if (this._columnHeaderDropLocationIndicator != null)
			{
				base.RemoveVisualChild(this._columnHeaderDropLocationIndicator);
				this._columnHeaderDropLocationIndicator = null;
			}
			global::System.Windows.Point position = e.GetPosition(this);
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = this.FindColumnHeaderByPosition(position);
			if (dataGridColumnHeader != null)
			{
				global::Microsoft.Windows.Controls.DataGridColumn column = dataGridColumnHeader.Column;
				if (this.ParentDataGrid.CanUserReorderColumns && column.CanUserReorder)
				{
					this.PrepareColumnHeaderDrag(dataGridColumnHeader, e.GetPosition(this), e.GetPosition(dataGridColumnHeader));
					return;
				}
			}
			else
			{
				this._isColumnHeaderDragging = false;
				this._prepareColumnHeaderDragging = false;
				this._draggingSrcColumnHeader = null;
				base.InvalidateArrange();
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00021A88 File Offset: 0x0001FC88
		internal void OnHeaderMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed && this._prepareColumnHeaderDragging)
			{
				this._columnHeaderDragCurrentPosition = e.GetPosition(this);
				if (!this._isColumnHeaderDragging)
				{
					if (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter.CheckStartColumnHeaderDrag(this._columnHeaderDragCurrentPosition, this._columnHeaderDragStartPosition))
					{
						this.StartColumnHeaderDrag();
						return;
					}
				}
				else
				{
					global::System.Windows.Visibility visibility = this.IsMousePositionValidForColumnDrag(2.0) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed;
					if (this._columnHeaderDragIndicator != null)
					{
						this._columnHeaderDragIndicator.Visibility = visibility;
					}
					if (this._columnHeaderDropLocationIndicator != null)
					{
						this._columnHeaderDropLocationIndicator.Visibility = visibility;
					}
					base.InvalidateArrange();
					global::System.Windows.Controls.Primitives.DragDeltaEventArgs e2 = new global::System.Windows.Controls.Primitives.DragDeltaEventArgs(this._columnHeaderDragCurrentPosition.X - this._columnHeaderDragStartPosition.X, this._columnHeaderDragCurrentPosition.Y - this._columnHeaderDragStartPosition.Y);
					this._columnHeaderDragStartPosition = this._columnHeaderDragCurrentPosition;
					this.ParentDataGrid.OnColumnHeaderDragDelta(e2);
				}
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00021B70 File Offset: 0x0001FD70
		internal void OnHeaderMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._isColumnHeaderDragging)
			{
				this._columnHeaderDragCurrentPosition = e.GetPosition(this);
				this.FinishColumnHeaderDrag(false);
				return;
			}
			this.ClearColumnHeaderDragInfo();
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00021B95 File Offset: 0x0001FD95
		internal void OnHeaderLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._isColumnHeaderDragging && global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
			{
				this.FinishColumnHeaderDrag(true);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		private void ClearColumnHeaderDragInfo()
		{
			this._isColumnHeaderDragging = false;
			this._prepareColumnHeaderDragging = false;
			this._draggingSrcColumnHeader = null;
			if (this._columnHeaderDragIndicator != null)
			{
				base.RemoveVisualChild(this._columnHeaderDragIndicator);
				this._columnHeaderDragIndicator = null;
			}
			if (this._columnHeaderDropLocationIndicator != null)
			{
				base.RemoveVisualChild(this._columnHeaderDropLocationIndicator);
				this._columnHeaderDropLocationIndicator = null;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00021C08 File Offset: 0x0001FE08
		private void PrepareColumnHeaderDrag(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader header, global::System.Windows.Point pos, global::System.Windows.Point relativePos)
		{
			this._prepareColumnHeaderDragging = true;
			this._isColumnHeaderDragging = false;
			this._draggingSrcColumnHeader = header;
			this._columnHeaderDragStartPosition = pos;
			this._columnHeaderDragStartRelativePosition = relativePos;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00021C2D File Offset: 0x0001FE2D
		private static bool CheckStartColumnHeaderDrag(global::System.Windows.Point currentPos, global::System.Windows.Point originalPos)
		{
			return global::MS.Internal.DoubleUtil.GreaterThan(global::System.Math.Abs(currentPos.X - originalPos.X), global::System.Windows.SystemParameters.MinimumHorizontalDragDistance);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00021C50 File Offset: 0x0001FE50
		private bool IsMousePositionValidForColumnDrag(double dragFactor)
		{
			int num = -1;
			return this.IsMousePositionValidForColumnDrag(dragFactor, out num);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00021C68 File Offset: 0x0001FE68
		private bool IsMousePositionValidForColumnDrag(double dragFactor, out int nearestDisplayIndex)
		{
			nearestDisplayIndex = -1;
			bool flag = false;
			if (this._draggingSrcColumnHeader.Column != null)
			{
				flag = this._draggingSrcColumnHeader.Column.IsFrozen;
			}
			int num = 0;
			if (this.ParentDataGrid != null)
			{
				num = this.ParentDataGrid.FrozenColumnCount;
			}
			nearestDisplayIndex = this.FindDisplayIndexByPosition(this._columnHeaderDragCurrentPosition, true);
			if (flag && nearestDisplayIndex >= num)
			{
				return false;
			}
			if (!flag && nearestDisplayIndex < num)
			{
				return false;
			}
			double num2;
			if (this._columnHeaderDragIndicator == null)
			{
				num2 = this._draggingSrcColumnHeader.RenderSize.Height;
			}
			else
			{
				num2 = global::System.Math.Max(this._draggingSrcColumnHeader.RenderSize.Height, this._columnHeaderDragIndicator.Height);
			}
			return global::MS.Internal.DoubleUtil.LessThanOrClose(-num2 * dragFactor, this._columnHeaderDragCurrentPosition.Y) && global::MS.Internal.DoubleUtil.LessThanOrClose(this._columnHeaderDragCurrentPosition.Y, num2 * (dragFactor + 1.0));
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00021D54 File Offset: 0x0001FF54
		private void StartColumnHeaderDrag()
		{
			this._columnHeaderDragStartPosition = this._columnHeaderDragCurrentPosition;
			global::System.Windows.Controls.Primitives.DragStartedEventArgs e = new global::System.Windows.Controls.Primitives.DragStartedEventArgs(this._columnHeaderDragStartPosition.X, this._columnHeaderDragStartPosition.Y);
			this.ParentDataGrid.OnColumnHeaderDragStarted(e);
			global::Microsoft.Windows.Controls.DataGridColumnReorderingEventArgs dataGridColumnReorderingEventArgs = new global::Microsoft.Windows.Controls.DataGridColumnReorderingEventArgs(this._draggingSrcColumnHeader.Column);
			this._columnHeaderDragIndicator = this.CreateColumnHeaderDragIndicator();
			this._columnHeaderDropLocationIndicator = this.CreateColumnHeaderDropIndicator();
			dataGridColumnReorderingEventArgs.DragIndicator = this._columnHeaderDragIndicator;
			dataGridColumnReorderingEventArgs.DropLocationIndicator = this._columnHeaderDropLocationIndicator;
			this.ParentDataGrid.OnColumnReordering(dataGridColumnReorderingEventArgs);
			if (!dataGridColumnReorderingEventArgs.Cancel)
			{
				this._isColumnHeaderDragging = true;
				this._columnHeaderDragIndicator = dataGridColumnReorderingEventArgs.DragIndicator;
				this._columnHeaderDropLocationIndicator = dataGridColumnReorderingEventArgs.DropLocationIndicator;
				if (this._columnHeaderDragIndicator != null)
				{
					this.SetDefaultsOnDragIndicator();
					base.AddVisualChild(this._columnHeaderDragIndicator);
				}
				if (this._columnHeaderDropLocationIndicator != null)
				{
					this.SetDefaultsOnDropIndicator();
					base.AddVisualChild(this._columnHeaderDropLocationIndicator);
				}
				this._draggingSrcColumnHeader.SuppressClickEvent = true;
				base.InvalidateMeasure();
				return;
			}
			this.FinishColumnHeaderDrag(true);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00021E58 File Offset: 0x00020058
		private global::System.Windows.Controls.Control CreateColumnHeaderDragIndicator()
		{
			return new global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader
			{
				ReferenceHeader = this._draggingSrcColumnHeader
			};
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00021E78 File Offset: 0x00020078
		private void SetDefaultsOnDragIndicator()
		{
			global::Microsoft.Windows.Controls.DataGridColumn column = this._draggingSrcColumnHeader.Column;
			global::System.Windows.Style style = null;
			if (column != null)
			{
				style = column.DragIndicatorStyle;
			}
			this._columnHeaderDragIndicator.Style = style;
			this._columnHeaderDragIndicator.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
			this._columnHeaderDragIndicator.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00021ECC File Offset: 0x000200CC
		private global::System.Windows.Controls.Control CreateColumnHeaderDropIndicator()
		{
			return new global::Microsoft.Windows.Controls.DataGridColumnDropSeparator
			{
				ReferenceHeader = this._draggingSrcColumnHeader
			};
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00021EEC File Offset: 0x000200EC
		private void SetDefaultsOnDropIndicator()
		{
			global::System.Windows.Style style = null;
			if (this.ParentDataGrid != null)
			{
				style = this.ParentDataGrid.DropLocationIndicatorStyle;
			}
			this._columnHeaderDropLocationIndicator.Style = style;
			this._columnHeaderDropLocationIndicator.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
			this._columnHeaderDropLocationIndicator.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00021F3C File Offset: 0x0002013C
		private void FinishColumnHeaderDrag(bool isCancel)
		{
			this._prepareColumnHeaderDragging = false;
			this._isColumnHeaderDragging = false;
			this._draggingSrcColumnHeader.SuppressClickEvent = false;
			if (this._columnHeaderDragIndicator != null)
			{
				this._columnHeaderDragIndicator.Visibility = global::System.Windows.Visibility.Collapsed;
				global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader dataGridColumnFloatingHeader = this._columnHeaderDragIndicator as global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader;
				if (dataGridColumnFloatingHeader != null)
				{
					dataGridColumnFloatingHeader.ClearHeader();
				}
				base.RemoveVisualChild(this._columnHeaderDragIndicator);
			}
			if (this._columnHeaderDropLocationIndicator != null)
			{
				this._columnHeaderDropLocationIndicator.Visibility = global::System.Windows.Visibility.Collapsed;
				global::Microsoft.Windows.Controls.DataGridColumnDropSeparator dataGridColumnDropSeparator = this._columnHeaderDropLocationIndicator as global::Microsoft.Windows.Controls.DataGridColumnDropSeparator;
				if (dataGridColumnDropSeparator != null)
				{
					dataGridColumnDropSeparator.ReferenceHeader = null;
				}
				base.RemoveVisualChild(this._columnHeaderDropLocationIndicator);
			}
			global::System.Windows.Controls.Primitives.DragCompletedEventArgs e = new global::System.Windows.Controls.Primitives.DragCompletedEventArgs(this._columnHeaderDragCurrentPosition.X - this._columnHeaderDragStartPosition.X, this._columnHeaderDragCurrentPosition.Y - this._columnHeaderDragStartPosition.Y, isCancel);
			this.ParentDataGrid.OnColumnHeaderDragCompleted(e);
			this._draggingSrcColumnHeader.InvalidateArrange();
			if (!isCancel)
			{
				int num = -1;
				bool flag = this.IsMousePositionValidForColumnDrag(2.0, out num);
				global::Microsoft.Windows.Controls.DataGridColumn column = this._draggingSrcColumnHeader.Column;
				if (column != null && flag && num != column.DisplayIndex)
				{
					column.DisplayIndex = num;
					global::Microsoft.Windows.Controls.DataGridColumnEventArgs e2 = new global::Microsoft.Windows.Controls.DataGridColumnEventArgs(this._draggingSrcColumnHeader.Column);
					this.ParentDataGrid.OnColumnReordered(e2);
				}
			}
			this._draggingSrcColumnHeader = null;
			this._columnHeaderDragIndicator = null;
			this._columnHeaderDropLocationIndicator = null;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00022090 File Offset: 0x00020290
		private int FindDisplayIndexByPosition(global::System.Windows.Point startPos, bool findNearestColumn)
		{
			int result;
			global::System.Windows.Point point;
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader;
			this.FindDisplayIndexAndHeaderPosition(startPos, findNearestColumn, out result, out point, out dataGridColumnHeader);
			return result;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000220AC File Offset: 0x000202AC
		private global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader FindColumnHeaderByPosition(global::System.Windows.Point startPos)
		{
			int num;
			global::System.Windows.Point point;
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader result;
			this.FindDisplayIndexAndHeaderPosition(startPos, false, out num, out point, out result);
			return result;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000220C8 File Offset: 0x000202C8
		private global::System.Windows.Point FindColumnHeaderPositionByCurrentPosition(global::System.Windows.Point startPos, bool findNearestColumn)
		{
			int num;
			global::System.Windows.Point result;
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader;
			this.FindDisplayIndexAndHeaderPosition(startPos, findNearestColumn, out num, out result, out dataGridColumnHeader);
			return result;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000220E4 File Offset: 0x000202E4
		private static double GetColumnEstimatedWidth(global::Microsoft.Windows.Controls.DataGridColumn column, double averageColumnWidth)
		{
			double num = column.Width.DisplayValue;
			if (global::MS.Internal.DoubleUtil.IsNaN(num))
			{
				num = global::System.Math.Max(averageColumnWidth, column.MinWidth);
				num = global::System.Math.Min(num, column.MaxWidth);
			}
			return num;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00022124 File Offset: 0x00020324
		private void FindDisplayIndexAndHeaderPosition(global::System.Windows.Point startPos, bool findNearestColumn, out int displayIndex, out global::System.Windows.Point headerPos, out global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader header)
		{
			global::System.Windows.Point point = new global::System.Windows.Point(0.0, 0.0);
			headerPos = point;
			displayIndex = -1;
			header = null;
			if (startPos.X < 0.0)
			{
				if (findNearestColumn)
				{
					displayIndex = 0;
				}
				return;
			}
			double num = 0.0;
			double num2 = 0.0;
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			double averageColumnWidth = parentDataGrid.InternalColumns.AverageColumnWidth;
			bool flag = false;
			int i = 0;
			while (i < parentDataGrid.Columns.Count)
			{
				displayIndex++;
				global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = parentDataGrid.ColumnHeaderFromDisplayIndex(i);
				if (dataGridColumnHeader != null)
				{
					global::System.Windows.Media.GeneralTransform generalTransform = dataGridColumnHeader.TransformToAncestor(this);
					num = generalTransform.Transform(point).X;
					num2 = num + dataGridColumnHeader.RenderSize.Width;
					goto IL_FB;
				}
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = parentDataGrid.ColumnFromDisplayIndex(i);
				if (dataGridColumn.IsVisible)
				{
					num = num2;
					if (i >= parentDataGrid.FrozenColumnCount && !flag)
					{
						num -= parentDataGrid.HorizontalScrollOffset;
						flag = true;
					}
					num2 = num + global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter.GetColumnEstimatedWidth(dataGridColumn, averageColumnWidth);
					goto IL_FB;
				}
				IL_18D:
				i++;
				continue;
				IL_FB:
				if (global::MS.Internal.DoubleUtil.LessThanOrClose(startPos.X, num))
				{
					break;
				}
				if (!global::MS.Internal.DoubleUtil.GreaterThanOrClose(startPos.X, num) || !global::MS.Internal.DoubleUtil.LessThanOrClose(startPos.X, num2))
				{
					goto IL_18D;
				}
				if (!findNearestColumn)
				{
					header = dataGridColumnHeader;
					break;
				}
				double value = (num + num2) * 0.5;
				if (global::MS.Internal.DoubleUtil.GreaterThanOrClose(startPos.X, value))
				{
					num = num2;
					displayIndex++;
				}
				if (this._draggingSrcColumnHeader != null && this._draggingSrcColumnHeader.Column != null && this._draggingSrcColumnHeader.Column.DisplayIndex < displayIndex)
				{
					displayIndex--;
					break;
				}
				break;
			}
			if (i == parentDataGrid.Columns.Count)
			{
				displayIndex = parentDataGrid.Columns.Count - 1;
				num = num2;
			}
			headerPos.X = num;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000222FD File Offset: 0x000204FD
		private global::Microsoft.Windows.Controls.ColumnHeaderCollection HeaderCollection
		{
			get
			{
				return base.ItemsSource as global::Microsoft.Windows.Controls.ColumnHeaderCollection;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0002230A File Offset: 0x0002050A
		internal global::Microsoft.Windows.Controls.DataGrid ParentDataGrid
		{
			get
			{
				if (this._parentDataGrid == null)
				{
					this._parentDataGrid = global::Microsoft.Windows.Controls.DataGridHelper.FindParent<global::Microsoft.Windows.Controls.DataGrid>(this);
				}
				return this._parentDataGrid;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00022326 File Offset: 0x00020526
		internal global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader> HeaderTrackingRoot
		{
			get
			{
				return this._headerTrackingRoot;
			}
		}

		// Token: 0x04000259 RID: 601
		private const string ElementFillerColumnHeader = "PART_FillerColumnHeader";

		// Token: 0x0400025A RID: 602
		private global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader> _headerTrackingRoot;

		// Token: 0x0400025B RID: 603
		private global::Microsoft.Windows.Controls.DataGrid _parentDataGrid;

		// Token: 0x0400025C RID: 604
		private bool _prepareColumnHeaderDragging;

		// Token: 0x0400025D RID: 605
		private bool _isColumnHeaderDragging;

		// Token: 0x0400025E RID: 606
		private global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader _draggingSrcColumnHeader;

		// Token: 0x0400025F RID: 607
		private global::System.Windows.Point _columnHeaderDragStartPosition;

		// Token: 0x04000260 RID: 608
		private global::System.Windows.Point _columnHeaderDragStartRelativePosition;

		// Token: 0x04000261 RID: 609
		private global::System.Windows.Point _columnHeaderDragCurrentPosition;

		// Token: 0x04000262 RID: 610
		private global::System.Windows.Controls.Control _columnHeaderDropLocationIndicator;

		// Token: 0x04000263 RID: 611
		private global::System.Windows.Controls.Control _columnHeaderDragIndicator;

		// Token: 0x04000264 RID: 612
		private global::System.Windows.Controls.Panel _internalItemsHost;
	}
}
