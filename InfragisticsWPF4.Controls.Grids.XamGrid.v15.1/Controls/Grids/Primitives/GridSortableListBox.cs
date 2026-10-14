using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001D5 RID: 469
	public class GridSortableListBox : global::System.Windows.Controls.ListBox, global::Infragistics.Controls.ISupportScrollHelper
	{
		// Token: 0x06000C56 RID: 3158 RVA: 0x0002B965 File Offset: 0x00029B65
		public GridSortableListBox()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.GridSortableListBox);
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0002B97D File Offset: 0x00029B7D
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x0002B98F File Offset: 0x00029B8F
		public bool IsSortable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.GridSortableListBox.IsSortableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.GridSortableListBox.IsSortableProperty, value);
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0002B9A4 File Offset: 0x00029BA4
		private static void IsSortableChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.GridSortableListBox gridSortableListBox = (global::Infragistics.Controls.Grids.Primitives.GridSortableListBox)obj;
			int count = gridSortableListBox.Items.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem gridSortableListBoxItem = gridSortableListBox.ItemContainerGenerator.ContainerFromIndex(i) as global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem;
				if (gridSortableListBoxItem != null)
				{
					gridSortableListBoxItem.IsMovable = gridSortableListBox.IsSortable;
				}
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0002B9F1 File Offset: 0x00029BF1
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0002B9F9 File Offset: 0x00029BF9
		internal global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem CurrentDragItem { get; set; }

		// Token: 0x06000C5C RID: 3164 RVA: 0x0002BA02 File Offset: 0x00029C02
		internal void IncreaseScrollPosition()
		{
			if (this._scrollViewer != null)
			{
				this._scrollViewer.ScrollToVerticalOffset(this._scrollViewer.VerticalOffset + 1.0);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0002BA2C File Offset: 0x00029C2C
		internal void DecreaseScrollPosition()
		{
			if (this._scrollViewer != null)
			{
				this._scrollViewer.ScrollToVerticalOffset(this._scrollViewer.VerticalOffset - 1.0);
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0002BA56 File Offset: 0x00029C56
		internal void SetItem(global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem item)
		{
			this._mouseDown = base.CaptureMouse();
			if (this._mouseDown)
			{
				this.CurrentDragItem = item;
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0002BA74 File Offset: 0x00029C74
		private void EndDrag()
		{
			if (this._mouseDown)
			{
				this._mouseDown = false;
				this._isDragging = false;
				this.CurrentDragItem.Opacity = 1.0;
				this.CurrentDragItem.PopupElement.IsOpen = false;
				base.ReleaseMouseCapture();
				this.CurrentDragItem = null;
				if (this._scrollListBoxTimer != null)
				{
					this._scrollListBoxTimer.Stop();
				}
				if (this._dragItem != null)
				{
					this._dragItem.KeyDown -= this.GridSortableListBoxItem_KeyDown;
				}
			}
			this._dragItem = null;
			base.ReleaseMouseCapture();
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0002BB08 File Offset: 0x00029D08
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._scrollViewer = (base.GetTemplateChild("ScrollViewer") as global::System.Windows.Controls.ScrollViewer);
			this._scrollHelper = new global::Infragistics.Controls.TouchScrollHelper(this, this);
			base.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, true);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0002BB44 File Offset: 0x00029D44
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			if (this.CurrentDragItem == null)
			{
				return new global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem
				{
					IsMovable = this.IsSortable
				};
			}
			return this.CurrentDragItem;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0002BB73 File Offset: 0x00029D73
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.EndDrag();
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0002BB84 File Offset: 0x00029D84
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._mouseDown)
			{
				this._mousePosition = e.GetPosition(null);
				if (!this._isDragging)
				{
					base.CaptureMouse();
					this._offsetPoint = e.GetPosition(this.CurrentDragItem);
					this._isDragging = true;
					this.CurrentDragItem.Opacity = 0.0;
					this._dragItem = new global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem();
					this._dragItem.Content = this.CurrentDragItem.Content;
					this._dragItem.ContentTemplate = this.CurrentDragItem.ContentTemplate;
					this.CurrentDragItem.PopupElement.Child = this._dragItem;
					this.CurrentDragItem.PopupElement.IsOpen = true;
					this._dragItem.Focus();
					this._dragItem.KeyDown += this.GridSortableListBoxItem_KeyDown;
					this._originalDragItemIndex = (base.ItemsSource as global::System.Collections.IList).IndexOf(this.CurrentDragItem.Content);
					this._dragItem.FlowDirection = this.CurrentDragItem.FlowDirection;
					this._lastPoint = e.GetPosition(this);
					double x = this._offsetPoint.X;
					if (global::System.Windows.SystemParameters.IsMenuDropRightAligned)
					{
						if (this._dragItem.ActualWidth != 0.0)
						{
							this._lastTrueItemWidth = this._dragItem.ActualWidth;
						}
						this._offsetPoint.X = this._offsetPoint.X - this._lastTrueItemWidth;
					}
					this.CurrentDragItem.PopupElement.HorizontalOffset = this._mousePosition.X - x;
				}
				else
				{
					bool flag = false;
					global::System.Windows.Point point = this._mousePosition;
					point = e.GetPosition(this);
					if (point == this._lastPoint)
					{
						return;
					}
					this._lastPoint = point;
					global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(point, this);
					foreach (global::System.Windows.UIElement uielement in elementsFromPoint)
					{
						global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem gridSortableListBoxItem = uielement as global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem;
						if (gridSortableListBoxItem != null && gridSortableListBoxItem != this.CurrentDragItem && gridSortableListBoxItem != this.CurrentDragItem.PopupElement.Child)
						{
							object content = this._dragItem.Content;
							int num = (base.ItemsSource as global::System.Collections.IList).IndexOf(content);
							int num2 = (base.ItemsSource as global::System.Collections.IList).IndexOf(gridSortableListBoxItem.Content);
							if (num != -1 && num2 != -1)
							{
								global::Infragistics.Controls.Grids.ColumnBase columnBase = content as global::Infragistics.Controls.Grids.ColumnBase;
								if (columnBase != null)
								{
									columnBase.IsMoving = true;
									columnBase.ColumnLayout.Grid.SuspendConditionalFormatUpdates = true;
								}
								(base.ItemsSource as global::System.Collections.IList).RemoveAt(num);
								(base.ItemsSource as global::System.Collections.IList).Insert(num2, content);
								if (columnBase != null)
								{
									columnBase.IsMoving = false;
									columnBase.ColumnLayout.Grid.SuspendConditionalFormatUpdates = false;
								}
								flag = true;
								break;
							}
						}
						if (uielement == this)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						if (this._scrollListBoxTimer == null)
						{
							this._scrollListBoxTimer = new global::System.Windows.Threading.DispatcherTimer();
							this._scrollListBoxTimer.Tick += this.ScrollListBoxTimer_Tick;
							this._scrollListBoxTimer.Interval = global::System.TimeSpan.FromMilliseconds(0.0);
						}
						this._scrollListBoxTimer.Start();
					}
					else if (this._scrollListBoxTimer != null)
					{
						this._scrollListBoxTimer.Stop();
					}
					this.CurrentDragItem.PopupElement.HorizontalOffset = this._mousePosition.X - this._offsetPoint.X;
				}
				this.CurrentDragItem.PopupElement.VerticalOffset = this._mousePosition.Y - this._offsetPoint.Y;
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0002BF48 File Offset: 0x0002A148
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this.EndDrag();
			base.OnLostMouseCapture(e);
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0002BF57 File Offset: 0x0002A157
		global::Infragistics.Controls.ScrollType global::Infragistics.Controls.ISupportScrollHelper.VerticalScrollType
		{
			get
			{
				return global::Infragistics.Controls.ScrollType.Pixel;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0002BF5A File Offset: 0x0002A15A
		global::Infragistics.Controls.ScrollType global::Infragistics.Controls.ISupportScrollHelper.HorizontalScrollType
		{
			get
			{
				return global::Infragistics.Controls.ScrollType.Pixel;
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0002BF60 File Offset: 0x0002A160
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemHeight()
		{
			if (this._scrollViewer != null && base.Items.Count > 0)
			{
				global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem gridSortableListBoxItem = base.ItemContainerGenerator.ContainerFromIndex(0) as global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem;
				if (gridSortableListBoxItem != null)
				{
					return gridSortableListBoxItem.DesiredSize.Height;
				}
			}
			return 0.0;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemWidth()
		{
			if (this._scrollViewer != null && base.Items.Count > 0)
			{
				global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem gridSortableListBoxItem = base.ItemContainerGenerator.ContainerFromIndex(0) as global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem;
				if (gridSortableListBoxItem != null)
				{
					return gridSortableListBoxItem.DesiredSize.Width;
				}
			}
			return 0.0;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0002C000 File Offset: 0x0002A200
		void global::Infragistics.Controls.ISupportScrollHelper.InvalidateScrollLayout()
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0002C002 File Offset: 0x0002A202
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x0002C021 File Offset: 0x0002A221
		double global::Infragistics.Controls.ISupportScrollHelper.VerticalValue
		{
			get
			{
				if (this._scrollViewer != null)
				{
					return this._scrollViewer.VerticalOffset;
				}
				return 0.0;
			}
			set
			{
				if (this._scrollViewer != null)
				{
					this._scrollViewer.ScrollToVerticalOffset(value);
				}
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0002C037 File Offset: 0x0002A237
		double global::Infragistics.Controls.ISupportScrollHelper.VerticalMax
		{
			get
			{
				if (this._scrollViewer != null)
				{
					return this._scrollViewer.ExtentHeight;
				}
				return 0.0;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0002C056 File Offset: 0x0002A256
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x0002C075 File Offset: 0x0002A275
		double global::Infragistics.Controls.ISupportScrollHelper.HorizontalValue
		{
			get
			{
				if (this._scrollViewer != null)
				{
					return this._scrollViewer.HorizontalOffset;
				}
				return 0.0;
			}
			set
			{
				if (this._scrollViewer != null)
				{
					this._scrollViewer.ScrollToHorizontalOffset(value);
				}
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0002C08B File Offset: 0x0002A28B
		double global::Infragistics.Controls.ISupportScrollHelper.HorizontalMax
		{
			get
			{
				if (this._scrollViewer != null)
				{
					return this._scrollViewer.ScrollableWidth;
				}
				return 0.0;
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0002C0AA File Offset: 0x0002A2AA
		global::Infragistics.Controls.TouchScrollMode global::Infragistics.Controls.ISupportScrollHelper.GetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver)
		{
			return global::Infragistics.Controls.TouchScrollMode.Both;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0002C0AD File Offset: 0x0002A2AD
		void global::Infragistics.Controls.ISupportScrollHelper.OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0002C0AF File Offset: 0x0002A2AF
		void global::Infragistics.Controls.ISupportScrollHelper.OnPanComplete()
		{
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0002C0B4 File Offset: 0x0002A2B4
		private void ScrollListBoxTimer_Tick(object sender, global::System.EventArgs e)
		{
			try
			{
				global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this);
				double zoomFactor = global::Infragistics.PlatformProxy.GetZoomFactor();
				double num = this._mousePosition.Y * zoomFactor;
				if (num < layoutSlot.Y)
				{
					this.DecreaseScrollPosition();
				}
				else if (num > layoutSlot.Y + layoutSlot.Height)
				{
					this.IncreaseScrollPosition();
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0002C11C File Offset: 0x0002A31C
		private void GridSortableListBoxItem_KeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (this._isDragging && e.Key == global::System.Windows.Input.Key.Escape)
			{
				object content = this.CurrentDragItem.Content;
				int num = (base.ItemsSource as global::System.Collections.IList).IndexOf(content);
				int originalDragItemIndex = this._originalDragItemIndex;
				if (num != -1 && originalDragItemIndex != -1 && num != originalDragItemIndex)
				{
					global::Infragistics.Controls.Grids.ColumnBase columnBase = content as global::Infragistics.Controls.Grids.ColumnBase;
					if (columnBase != null)
					{
						columnBase.IsMoving = true;
					}
					(base.ItemsSource as global::System.Collections.IList).RemoveAt(num);
					(base.ItemsSource as global::System.Collections.IList).Insert(originalDragItemIndex, content);
					if (columnBase != null)
					{
						columnBase.IsMoving = false;
					}
				}
				this.EndDrag();
			}
		}

		// Token: 0x04000400 RID: 1024
		private global::System.Windows.Controls.ScrollViewer _scrollViewer;

		// Token: 0x04000401 RID: 1025
		private global::Infragistics.Controls.TouchScrollHelper _scrollHelper;

		// Token: 0x04000402 RID: 1026
		private global::Infragistics.Controls.Grids.Primitives.GridSortableListBoxItem _dragItem;

		// Token: 0x04000403 RID: 1027
		private bool _mouseDown;

		// Token: 0x04000404 RID: 1028
		private bool _isDragging;

		// Token: 0x04000405 RID: 1029
		private global::System.Windows.Threading.DispatcherTimer _scrollListBoxTimer;

		// Token: 0x04000406 RID: 1030
		private global::System.Windows.Point _offsetPoint;

		// Token: 0x04000407 RID: 1031
		private global::System.Windows.Point _mousePosition;

		// Token: 0x04000408 RID: 1032
		private global::System.Windows.Point _lastPoint;

		// Token: 0x04000409 RID: 1033
		internal int _originalDragItemIndex;

		// Token: 0x0400040A RID: 1034
		private double _lastTrueItemWidth;

		// Token: 0x0400040B RID: 1035
		public static readonly global::System.Windows.DependencyProperty IsSortableProperty = global::System.Windows.DependencyProperty.Register("IsSortable", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.GridSortableListBox), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.GridSortableListBox.IsSortableChanged)));
	}
}
