using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000200 RID: 512
	[global::System.Windows.TemplateVisualState(GroupName = "HeaderFilterStates", Name = "NoIcon")]
	[global::System.Windows.TemplateVisualState(GroupName = "HeaderFilterStates", Name = "FilterIcon")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Moving")]
	[global::System.Windows.TemplateVisualState(GroupName = "FixedStates", Name = "Unfixed")]
	[global::System.Windows.TemplateVisualState(GroupName = "FixedStates", Name = "Fixed")]
	[global::System.Windows.TemplateVisualState(GroupName = "FixedIndicatorStates", Name = "NotFixable")]
	[global::System.Windows.TemplateVisualState(GroupName = "FixedIndicatorStates", Name = "Pinned")]
	[global::System.Windows.TemplateVisualState(GroupName = "FixedIndicatorStates", Name = "Unpinned")]
	[global::System.Windows.TemplateVisualState(GroupName = "SortedStates", Name = "NotSorted")]
	[global::System.Windows.TemplateVisualState(GroupName = "SortedStates", Name = "Ascending")]
	[global::System.Windows.TemplateVisualState(GroupName = "SortedStates", Name = "Descending")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "Active")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "InActive")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectedStates", Name = "NotSelected")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectedStates", Name = "Selected")]
	[global::System.Windows.TemplateVisualState(GroupName = "FilteredStates", Name = "NoFiltering")]
	[global::System.Windows.TemplateVisualState(GroupName = "FilteredStates", Name = "NotFiltered")]
	[global::System.Windows.TemplateVisualState(GroupName = "FilteredStates", Name = "Filtered")]
	[global::System.Windows.TemplateVisualState(GroupName = "SummableStates", Name = "Summable")]
	[global::System.Windows.TemplateVisualState(GroupName = "SummableStates", Name = "NotSummable")]
	[global::System.Windows.TemplateVisualState(GroupName = "HeaderFilterAppliedStates", Name = "Summable")]
	[global::System.Windows.TemplateVisualState(GroupName = "HeaderFilterAppliedStates", Name = "NotSummable")]
	public class HeaderCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase, global::Infragistics.ICommandTarget
	{
		// Token: 0x06000E76 RID: 3702 RVA: 0x00035EA4 File Offset: 0x000340A4
		static HeaderCellControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.HeaderCellControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.HeaderCellControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.HeaderCellControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00035EF4 File Offset: 0x000340F4
		public HeaderCellControl()
		{
			this._scrollTimer = new global::System.Windows.Threading.DispatcherTimer();
			this._scrollTimer.Tick += this.ScrollTimer_Tick;
			this._scrollTimer.Interval = global::System.TimeSpan.FromMilliseconds(0.0);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00035F49 File Offset: 0x00034149
		protected override void AttachContent()
		{
			this.EnsureContent();
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00035F54 File Offset: 0x00034154
		protected internal override void EnsureContent()
		{
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			if (column != null)
			{
				bool flag = true;
				string text = null;
				if (column.Key != null)
				{
					string[] array = column.Key.Split(new char[]
					{
						'.'
					});
					text = array[array.Length - 1];
					if (string.IsNullOrEmpty(column.HeaderText))
					{
						column.HeaderText = text;
					}
				}
				if (column.HeaderTemplate != null)
				{
					if (this._currentTemplate != column.HeaderTemplate)
					{
						this._currentTemplate = column.HeaderTemplate;
						this._contentElement = (column.HeaderTemplate.LoadContent() as global::System.Windows.FrameworkElement);
					}
					base.Content = this._contentElement;
					base.DataContext = text;
					flag = false;
				}
				else if (column.SupportsHeaderFooterContent)
				{
					global::System.Windows.DataTemplate columnsHeaderTemplateResolved = base.Cell.Row.ColumnLayout.ColumnsHeaderTemplateResolved;
					if (columnsHeaderTemplateResolved != null)
					{
						if (this._currentTemplate != columnsHeaderTemplateResolved)
						{
							this._contentElement = (columnsHeaderTemplateResolved.LoadContent() as global::System.Windows.FrameworkElement);
						}
						base.Content = this._contentElement;
						base.DataContext = text;
						flag = false;
					}
					this._currentTemplate = columnsHeaderTemplateResolved;
				}
				if (flag || base.Content == null)
				{
					if (string.IsNullOrEmpty(column.HeaderText) && column.DataField.DisplayName == null)
					{
						base.Content = text;
					}
					else
					{
						base.Content = column.HeaderText;
					}
				}
				base.HorizontalContentAlignment = column.HeaderTextHorizontalAlignmentResolved;
				base.VerticalContentAlignment = column.HeaderTextVerticalAlignmentResolved;
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x000360AF File Offset: 0x000342AF
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			if (!this._isDragging)
			{
				base.OnReleased(cell);
				base.DataContext = null;
				return;
			}
			this.DelayRecycling = true;
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000360CF File Offset: 0x000342CF
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._mouseDown && !this._isDragging)
			{
				this._mouseDown = false;
			}
			base.OnMouseEnter(e);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x000360F0 File Offset: 0x000342F0
		protected override bool OnMouseLeftButtonDownColumnMoving(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (base.Cell != null)
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Cell.Row.ColumnLayout;
				this._columnMovingSettings = columnLayout.ColumnMovingSettings;
				this._fixedColumnSettings = columnLayout.FixedColumnSettings;
				this._groupBySettings = columnLayout.GroupBySettings;
				global::Infragistics.Controls.Grids.FixedColumnType allowFixedColumnsResolved = this._fixedColumnSettings.AllowFixedColumnsResolved;
				this._dragFixable = ((allowFixedColumnsResolved == global::Infragistics.Controls.Grids.FixedColumnType.Both || allowFixedColumnsResolved == global::Infragistics.Controls.Grids.FixedColumnType.DropArea) && base.Cell.Column.IsFixable);
				this._dragGroupBy = (columnLayout.Grid.GroupBySettings.AllowGroupByArea != global::Infragistics.Controls.Grids.GroupByAreaLocation.Hidden && (columnLayout.Grid.GroupBySettings.ExpansionIndicatorVisibility == global::System.Windows.Visibility.Collapsed || columnLayout.Grid.GroupBySettings.IsGroupByAreaExpanded) && columnLayout.GroupBySettings.IsGroupableResolved && this.ResolveColumn().IsGroupable);
				this._columnMovingEnabled = (this._columnMovingSettings.AllowColumnMovingResolved != global::Infragistics.Controls.Grids.ColumnMovingType.Disabled && base.Cell.Column.IsMovable);
				if (this._dragGroupBy && base.Cell.Column.IsGroupBy && columnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
				{
					return false;
				}
				if (!this._isDragObject && (this._columnMovingEnabled || this._dragFixable || this._dragGroupBy))
				{
					this._mouseDown = true;
					e.Handled = true;
				}
				if (this._mouseDown)
				{
					columnLayout.Grid.SuspendConditionalFormatUpdates = true;
				}
			}
			return this._mouseDown;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00036260 File Offset: 0x00034460
		protected override void OnMouseMoveColumnMoving(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._mouseDown)
			{
				if (base.Cell == null)
				{
					this.EndDrag();
					return;
				}
				global::Infragistics.Controls.Grids.XamGrid grid = base.Cell.Row.ColumnLayout.Grid;
				global::System.Windows.Controls.Panel panel = grid.Panel;
				bool dragGroupBy = this._dragGroupBy;
				if (!this._isDragging && !this.InitializeDrag(e))
				{
					return;
				}
				base.Focus();
				global::System.Windows.Point position = e.GetPosition(panel);
				global::System.Windows.Point position2 = e.GetPosition(grid.DropAreaIndicatorLeft);
				this.EnsureIndicatorState(grid.DropAreaIndicatorLeft, position2, true);
				global::System.Windows.Point position3 = e.GetPosition(grid.DropAreaIndicatorRight);
				this.EnsureIndicatorState(grid.DropAreaIndicatorRight, position3, false);
				global::System.Windows.Controls.Primitives.Popup contentContainer = this._columnMovingSettings.ContentContainer;
				global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
				grid.OnColumnMoving(column, contentContainer.Child as global::Infragistics.Controls.Grids.Primitives.HeaderCellControl, e);
				this._groupBySettings.IndicatorContainer.IsOpen = false;
				if (this._dragGroupBy)
				{
					global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl groupByAreaCellControl = null;
					if (grid != null)
					{
						groupByAreaCellControl = (this.GetCellControlFromPoint(e.GetPosition(grid), typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl), false) as global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl);
					}
					global::Infragistics.Controls.Grids.Primitives.CellControlBase control = grid.RowsManager.GroupByAreaRow.Cells[0].Control;
					if (control != null)
					{
						if (groupByAreaCellControl != null)
						{
							control.GoToState("DraggingOver", false);
						}
						else
						{
							control.GoToState("Dragging", false);
						}
					}
				}
				global::System.Windows.Rect boundsForPopup = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsForPopup(contentContainer, grid);
				this._dropHeader = this.ResolveDropHeader(position, boundsForPopup);
				if (!this._isMerged || this is global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl)
				{
					if (this._dropHeader != null && this._dropHeader.Cell != null && this._dropHeader.Cell.Row != null && this._dropHeader.Cell.Row.ColumnLayout == base.Cell.Row.ColumnLayout)
					{
						this.ReactToMouseOverDroppableCellControl(e);
					}
					else
					{
						this._columnMovingSettings.IndicatorContainer.IsOpen = false;
						this._dropHeader = null;
					}
				}
				if (global::System.Windows.SystemParameters.IsMenuDropRightAligned)
				{
					contentContainer.HorizontalOffset = position.X - this._offsetPoint.X + boundsForPopup.Width;
				}
				else
				{
					contentContainer.HorizontalOffset = position.X - this._offsetPoint.X;
				}
				if (dragGroupBy)
				{
					contentContainer.VerticalOffset = position.Y - this._offsetPoint.Y;
				}
				if ((!this._isMerged || this is global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl) && this._columnMovingSettings.AllowColumnMovingResolved != global::Infragistics.Controls.Grids.ColumnMovingType.Disabled)
				{
					if (position.X < 0.0)
					{
						this._scrollDirectionLeft = true;
						this._scrollTimer.Start();
					}
					else if (position.X > grid.ActualWidth)
					{
						this._scrollDirectionLeft = false;
						this._scrollTimer.Start();
					}
					else
					{
						this._scrollTimer.Stop();
					}
				}
			}
			base.OnMouseMoveColumnMoving(e);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00036524 File Offset: 0x00034724
		protected override void OnMouseLeftButtonUpColumnMoving(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUpColumnMoving(e);
			this._mouseDown = false;
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			if (column == null)
			{
				return;
			}
			if (column.ColumnLayout != null)
			{
				column.ColumnLayout.Grid.SuspendConditionalFormatUpdates = false;
			}
			if (this._isDragging)
			{
				bool flag = false;
				global::Infragistics.Controls.Grids.FixedState fixedState = column.IsFixed;
				global::Infragistics.Controls.Grids.XamGrid grid = base.Cell.Row.ColumnLayout.Grid;
				global::Infragistics.Controls.Grids.DropOperationType dropOperationType = global::Infragistics.Controls.Grids.DropOperationType.ColumnMoved;
				global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl groupByAreaCellControl = null;
				if (grid != null)
				{
					groupByAreaCellControl = (this.GetCellControlFromPoint(e.GetPosition(grid), typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl), false) as global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl);
				}
				if (groupByAreaCellControl != null && (grid.GroupBySettings.ExpansionIndicatorVisibility == global::System.Windows.Visibility.Collapsed || grid.GroupBySettings.IsGroupByAreaExpanded) && column.IsGroupable)
				{
					global::Infragistics.Controls.Grids.GroupByColumnsCollection groupByColumns = grid.GroupBySettings.GroupByColumns;
					global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl groupByHeaderCellControl = this._dropHeader as global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl;
					if (groupByHeaderCellControl != null)
					{
						global::Infragistics.Controls.Grids.Column item = groupByHeaderCellControl.ResolveColumn();
						int num = groupByColumns.IndexOf(item);
						int num2 = groupByColumns.IndexOf(column);
						if (!this._dropBefore)
						{
							num++;
						}
						if (num2 < num && num2 != -1)
						{
							num--;
						}
						global::Infragistics.ICollectionBase collectionBase = groupByColumns;
						if (num != collectionBase.IndexOf(column))
						{
							if (column.IsGroupBy)
							{
								dropOperationType = global::Infragistics.Controls.Grids.DropOperationType.GroupedColumnIndexChanged;
							}
							else
							{
								dropOperationType = global::Infragistics.Controls.Grids.DropOperationType.ColumnGrouped;
							}
							if (collectionBase.Contains(column))
							{
								collectionBase.RemoveItemSilently(collectionBase.IndexOf(column));
							}
							collectionBase.Insert(num, column);
						}
					}
					else if (!column.IsGroupBy)
					{
						column.IsGroupBy = true;
						dropOperationType = global::Infragistics.Controls.Grids.DropOperationType.ColumnGrouped;
					}
					flag = true;
				}
				else if (global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.IsElementAtPoint(e.GetPosition(base.Cell.Row.ColumnLayout.Grid.DropAreaIndicatorLeft), base.Cell.Row.ColumnLayout.Grid.DropAreaIndicatorLeft))
				{
					dropOperationType = global::Infragistics.Controls.Grids.DropOperationType.ColumnFixed;
					fixedState = global::Infragistics.Controls.Grids.FixedState.Left;
					flag = true;
				}
				else if (global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.IsElementAtPoint(e.GetPosition(base.Cell.Row.ColumnLayout.Grid.DropAreaIndicatorRight), base.Cell.Row.ColumnLayout.Grid.DropAreaIndicatorRight))
				{
					dropOperationType = global::Infragistics.Controls.Grids.DropOperationType.ColumnFixed;
					fixedState = global::Infragistics.Controls.Grids.FixedState.Right;
					flag = true;
				}
				else if (this._dropHeader != null)
				{
					if (this._columnMovingSettings.AllowColumnMovingResolved == global::Infragistics.Controls.Grids.ColumnMovingType.Indicator && !this.MoveColumn())
					{
						this.CancelDrag(false, true);
						return;
					}
				}
				else
				{
					global::System.Windows.Point position = e.GetPosition(grid);
					if (position.X < 0.0 || position.X > grid.ActualWidth)
					{
						flag = true;
						fixedState = global::Infragistics.Controls.Grids.FixedState.NotFixed;
					}
					else if (base.Cell.Row.Control == null)
					{
						flag = true;
					}
					else
					{
						global::System.Windows.Rect boundsForPopup = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsForPopup(this._columnMovingSettings.ContentContainer, grid);
						position = e.GetPosition(grid);
						position = new global::System.Windows.Point(position.X, boundsForPopup.Y);
						double zoomFactor = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetZoomFactor();
						position.Y /= zoomFactor;
						if (this.GetCellControlFromPoint(position, null, true) == null)
						{
							global::System.Collections.Generic.List<global::System.Windows.UIElement> elementsAtPoint = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetElementsAtPoint(position, base.Cell.Row.Control);
							if (elementsAtPoint.Count > 0)
							{
								bool flag2 = true;
								bool flag3 = false;
								foreach (global::System.Windows.UIElement uielement in elementsAtPoint)
								{
									global::Infragistics.Controls.Grids.Primitives.HeaderCellControl headerCellControl = uielement as global::Infragistics.Controls.Grids.Primitives.HeaderCellControl;
									if (headerCellControl != null && (headerCellControl.Cell.Column is global::Infragistics.Controls.Grids.Primitives.FillerColumn || headerCellControl.Cell.Column is global::Infragistics.Controls.Grids.Primitives.RowSelectorColumn || headerCellControl.Cell.Column is global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorColumn))
									{
										flag3 = true;
										break;
									}
								}
								if (!flag3)
								{
									if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Right)
									{
										global::Infragistics.Controls.Grids.CellBase cellBase = base.Cell.Row.Cells[base.Cell.Row.Columns.FixedBorderColumnRight];
										if (cellBase != null && cellBase.Control != null && global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(cellBase.Control, null).X < position.X)
										{
											flag2 = false;
										}
									}
									else if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Left)
									{
										global::Infragistics.Controls.Grids.CellBase cellBase2 = base.Cell.Row.Cells[base.Cell.Row.Columns.FixedBorderColumnLeft];
										if (cellBase2 != null && cellBase2.Control != null && global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(cellBase2.Control, null).X > position.X)
										{
											flag2 = false;
										}
									}
								}
								if (flag2)
								{
									flag = true;
									fixedState = global::Infragistics.Controls.Grids.FixedState.NotFixed;
								}
							}
						}
					}
				}
				if (dropOperationType == global::Infragistics.Controls.Grids.DropOperationType.ColumnMoved && column.IsFixed != global::Infragistics.Controls.Grids.FixedState.NotFixed)
				{
					dropOperationType = global::Infragistics.Controls.Grids.DropOperationType.FixColumnMoved;
				}
				if (flag)
				{
					bool fireEvent = true;
					if (dropOperationType == global::Infragistics.Controls.Grids.DropOperationType.ColumnFixed || dropOperationType == global::Infragistics.Controls.Grids.DropOperationType.ColumnGrouped || dropOperationType == global::Infragistics.Controls.Grids.DropOperationType.GroupedColumnIndexChanged)
					{
						grid.OnColumnDropped(column, dropOperationType, this.ResolveCollection().IndexOf(column), this._originalIndex);
						fireEvent = false;
					}
					this.CancelDrag(column.IsFixed != fixedState, fireEvent);
				}
				else
				{
					int num3 = this.ResolveCollection().IndexOf(column);
					if (num3 != this._originalIndex)
					{
						grid.OnColumnDropped(column, dropOperationType, num3, this._originalIndex);
						this.EndDrag();
					}
					else
					{
						this.CancelDrag(false, true);
					}
				}
				if (column.IsFixed != fixedState)
				{
					column.IsFixed = fixedState;
				}
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00036A40 File Offset: 0x00034C40
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (this._isDragging)
			{
				if (e.Key == global::System.Windows.Input.Key.Escape)
				{
					this.CancelDrag(false, true);
				}
				e.Handled = true;
			}
			base.OnKeyDown(e);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00036A6A File Offset: 0x00034C6A
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._isDragging)
			{
				this.EndDrag();
			}
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00036A81 File Offset: 0x00034C81
		protected override bool DetermineCursorHelper(global::Infragistics.Controls.Grids.Column column, global::System.Windows.Rect bounds, double xPosition)
		{
			return base.DetermineCursorHelper(column, bounds, xPosition) && !this.IsDragging;
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00036A99 File Offset: 0x00034C99
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool IsDragging
		{
			get
			{
				return this._isDragging;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00036AA1 File Offset: 0x00034CA1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Grids.Primitives.HeaderCellControl MovingHeader
		{
			get
			{
				return this._movingHeader;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00036AA9 File Offset: 0x00034CA9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public virtual global::System.Windows.Controls.Primitives.Popup Indicator
		{
			get
			{
				if (this._columnMovingSettings != null)
				{
					return this._columnMovingSettings.IndicatorContainer;
				}
				return null;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x00036AC0 File Offset: 0x00034CC0
		public global::Infragistics.SummaryOperandCollection AvailableSummariesOperands
		{
			get
			{
				global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
				global::Infragistics.SummaryOperandCollection result = null;
				if (cell != null && cell.Column != null)
				{
					result = base.Cell.Column.SummaryColumnSettings.SummaryOperands;
				}
				return result;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00036AF8 File Offset: 0x00034CF8
		protected global::Infragistics.Controls.Grids.Primitives.CellControlBase DropHeader
		{
			get
			{
				return this._dropHeader;
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00036B00 File Offset: 0x00034D00
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.ColumnChooserCommandBase || command is global::Infragistics.Controls.Grids.ShowColumnCommand || command is global::Infragistics.Controls.Grids.Primitives.FilterMenuCommands || (command is global::Infragistics.Controls.Grids.ColumnCommandBase && !base.AllowUserResizing);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00036B30 File Offset: 0x00034D30
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			global::Infragistics.Controls.Grids.Column result = null;
			if (source.Command is global::Infragistics.Controls.Grids.ColumnCommandBase)
			{
				result = this.ResolveColumn();
			}
			else
			{
				if (source.Command is global::Infragistics.Controls.Grids.ColumnChooserCommandBase)
				{
					return base.Cell.Column;
				}
				if (source.Command is global::Infragistics.Controls.Grids.Primitives.FilterMenuCommands)
				{
					return base.Cell;
				}
			}
			return result;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00036B84 File Offset: 0x00034D84
		protected virtual bool InitializeDrag(global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid grid = base.Cell.Row.ColumnLayout.Grid;
			global::Infragistics.Controls.Grids.Primitives.RowsPanel panel = grid.Panel;
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			this._cachedGrid = grid;
			this._cachedCollection = this.ResolveCollection();
			if (grid.OnColumnDragStart(column))
			{
				return false;
			}
			this._isMerged = (column.IsGroupBy && grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells);
			this._originalIndex = this.ResolveCollection().IndexOf(column);
			this._originalColumn = column;
			this.MarkColumnAsMoving();
			if (this._dragGroupBy)
			{
				panel.Children.Add(this._groupBySettings.IndicatorContainer);
				global::Infragistics.Controls.Grids.Primitives.CellControlBase control = grid.RowsManager.GroupByAreaRow.Cells[0].Control;
				if (control != null)
				{
					control.GoToState("Dragging", false);
				}
			}
			this._originalColumn.IsDragging = true;
			this._isDragging = true;
			this._offsetPoint = e.GetPosition(this);
			this._movingHeader = this.GenerateDragHeader();
			this._movingHeader._isDragObject = true;
			this._movingHeader.Width = base.ActualWidth;
			this._movingHeader.Height = base.ActualHeight;
			this._movingHeader.LayoutUpdated += this.MovingHeader_LayoutUpdated;
			global::System.Windows.Controls.Primitives.Popup contentContainer = this._columnMovingSettings.ContentContainer;
			contentContainer.Child = this._movingHeader;
			this._movingHeader.IsHitTestVisible = false;
			panel.Children.Add(contentContainer);
			contentContainer.IsOpen = true;
			contentContainer.VerticalOffset = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(this, panel).Y;
			if (this._dragFixable)
			{
				global::Infragistics.Controls.Grids.FixedDropAreaLocation fixedDropAreaLocationResolved = this._fixedColumnSettings.FixedDropAreaLocationResolved;
				double num = 0.0;
				foreach (global::Infragistics.Controls.Grids.RowBase rowBase in grid.Panel.FixedRowsTop)
				{
					if (rowBase == base.Cell.Row)
					{
						break;
					}
					num += rowBase.ActualHeight;
				}
				double num2 = 0.0;
				foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in grid.Panel.FixedRowsBottom)
				{
					num2 += rowBase2.ActualHeight;
				}
				if (fixedDropAreaLocationResolved == global::Infragistics.Controls.Grids.FixedDropAreaLocation.Left || fixedDropAreaLocationResolved == global::Infragistics.Controls.Grids.FixedDropAreaLocation.Both)
				{
					bool flag = column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Left;
					if (grid.DropAreaIndicatorLeft != null && !flag)
					{
						this.ApplyIndicatorStyle(grid.DropAreaIndicatorLeft, base.Cell.Row.ColumnLayout.FixedColumnSettings.FixedDropAreaLeftStyleResolved);
						grid.DropAreaIndicatorLeft.Height = grid.Panel.ActualHeight - num - num2;
						global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleFixedLeftCells = base.Cell.Row.Control.VisibleFixedLeftCells;
						double length;
						if (visibleFixedLeftCells.Count > 0)
						{
							global::Infragistics.Controls.Grids.CellBase cellBase = visibleFixedLeftCells[visibleFixedLeftCells.Count - 1];
							global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(cellBase.Control);
							length = layoutSlot.X + layoutSlot.Width;
						}
						else
						{
							double num3 = base.Cell.Row.Manager.ResolveIndentation(base.Cell.Row);
							length = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(base.Cell.Row.Control).X + num3;
						}
						global::System.Windows.Controls.Canvas.SetLeft(grid.DropAreaIndicatorLeft, length);
						global::System.Windows.Controls.Canvas.SetTop(grid.DropAreaIndicatorLeft, num);
						grid.DropAreaIndicatorLeft.DisplayFromLeft();
					}
				}
				if (fixedDropAreaLocationResolved == global::Infragistics.Controls.Grids.FixedDropAreaLocation.Right || fixedDropAreaLocationResolved == global::Infragistics.Controls.Grids.FixedDropAreaLocation.Both)
				{
					bool flag2 = column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Right;
					if (grid.DropAreaIndicatorRight != null && !flag2)
					{
						this.ApplyIndicatorStyle(grid.DropAreaIndicatorRight, base.Cell.Row.ColumnLayout.FixedColumnSettings.FixedDropAreaRightStyleResolved);
						grid.DropAreaIndicatorRight.Height = grid.Panel.ActualHeight - num - num2;
						global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleFixedRightCells = base.Cell.Row.Control.VisibleFixedRightCells;
						double num4 = panel.ActualWidth - grid.DropAreaIndicatorRight.ActualWidth;
						num4 -= column.ColumnLayout.Columns.FillerColumn.ActualWidth;
						if (visibleFixedRightCells.Count > 0)
						{
							global::Infragistics.Controls.Grids.CellBase cellBase2 = visibleFixedRightCells[visibleFixedRightCells.Count - 1];
							num4 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(cellBase2.Control).X - grid.DropAreaIndicatorRight.ActualWidth;
						}
						global::System.Windows.Controls.Canvas.SetLeft(grid.DropAreaIndicatorRight, num4);
						global::System.Windows.Controls.Canvas.SetTop(grid.DropAreaIndicatorRight, num);
						grid.DropAreaIndicatorRight.DisplayFromRight();
					}
				}
			}
			grid.InvalidateScrollPanel(false);
			this.EnsureFocusable();
			base.CaptureMouse();
			return true;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00037060 File Offset: 0x00035260
		protected virtual void CancelDrag(bool columnUnfixed, bool fireEvent)
		{
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			if (column.CachedParentColumn == null || column.ParentColumn == column.CachedParentColumn)
			{
				this.MoveColumn(this._originalIndex);
			}
			if (fireEvent)
			{
				global::Infragistics.Controls.Grids.DragCancelType type = columnUnfixed ? global::Infragistics.Controls.Grids.DragCancelType.ColumnUnfixed : global::Infragistics.Controls.Grids.DragCancelType.MoveCanceled;
				column.ColumnLayout.Grid.OnColumnDragCanceled(column, type);
			}
			this.EndDrag();
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000370BC File Offset: 0x000352BC
		protected virtual void EndDrag()
		{
			this._scrollTimer.Stop();
			this.RestoreFocusable();
			global::Infragistics.Controls.Grids.XamGrid cachedGrid = this._cachedGrid;
			if (cachedGrid == null)
			{
				return;
			}
			this._dropHeader = null;
			cachedGrid.InvalidateScrollPanel(false);
			this._columnMovingSettings.ContentContainer.IsOpen = false;
			if (this._movingHeader != null)
			{
				global::System.Windows.Controls.Panel panel = cachedGrid.Panel;
				if (panel != null)
				{
					panel.Children.Remove(this._columnMovingSettings.ContentContainer);
					panel.Children.Remove(this._columnMovingSettings.IndicatorContainer);
					panel.Children.Remove(this._groupBySettings.IndicatorContainer);
				}
				this._originalColumn.IsMoving = false;
				this._movingHeader.LayoutUpdated -= this.MovingHeader_LayoutUpdated;
				this._movingHeader = null;
			}
			if (this._dragGroupBy)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase control = cachedGrid.RowsManager.GroupByAreaRow.Cells[0].Control;
				if (control != null)
				{
					control.GoToState("NotDragging", false);
				}
			}
			this._columnMovingSettings.IndicatorContainer.IsOpen = false;
			this._groupBySettings.IndicatorContainer.IsOpen = false;
			this._originalColumn.IsDragging = false;
			this._isDragging = false;
			this._mouseDown = false;
			base.ReleaseMouseCapture();
			if (cachedGrid.DropAreaIndicatorLeft != null)
			{
				cachedGrid.DropAreaIndicatorLeft.Hide();
			}
			if (cachedGrid.DropAreaIndicatorRight != null)
			{
				cachedGrid.DropAreaIndicatorRight.Hide();
			}
			cachedGrid.OnColumnDragEnded(this.ResolveColumn());
			this._originalColumn = null;
			this._cachedCollection = null;
			this._cachedGrid = null;
			if (this._columnMovingAnimation != null && this._columnMovingAnimation.IsPlaying && this._columnMovingAnimation.Time == 0)
			{
				this._columnMovingAnimation.Stop();
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00037270 File Offset: 0x00035470
		protected virtual bool MoveColumn()
		{
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			global::Infragistics.Controls.Grids.Column column2 = this._dropHeader.Cell.Column;
			global::System.Collections.IList list = this.ResolveReadOnlyCollection();
			int num = list.IndexOf(column2);
			int num2 = this._dropBefore ? (num - 1) : (num + 1);
			int num3 = list.IndexOf(column);
			if (num2 == num3)
			{
				return false;
			}
			global::Infragistics.Controls.Grids.Column columnBeingSwitched = this._columnBeingSwitched;
			this._columnBeingSwitched = this._dropHeader.Cell.Column;
			this._columnBeingSwitched.MovingColumnsWidth = column.ActualWidth;
			if (this._columnBeingSwitched != columnBeingSwitched || this._columnMovingSettings.AllowColumnMovingResolved == global::Infragistics.Controls.Grids.ColumnMovingType.Indicator)
			{
				list = this.ResolveCollection();
				num = list.IndexOf(column2);
				num3 = list.IndexOf(column);
				if (!this._dropBefore)
				{
					num++;
				}
				if (num3 < num)
				{
					num--;
				}
				this._columnMovingNewIndex = num;
				this._columnBeingSwitched.ReverseMove = !this._dropBefore;
				if (this._columnMovingSettings.AllowColumnMovingResolved == global::Infragistics.Controls.Grids.ColumnMovingType.Indicator)
				{
					this.MoveColumn(this._columnMovingNewIndex);
					base.Cell.Row.ColumnLayout.Grid.InvalidateScrollPanel(false);
				}
				else
				{
					if (this._columnMovingAnimation == null)
					{
						this._columnMovingAnimation = new global::Infragistics.Animation();
						this._columnMovingAnimation.Complete += this.ColumnMovingAnimation_Complete;
						this._columnMovingAnimation.Tick += this.ColumnMovingAnimation_Tick;
					}
					this._columnMovingAnimation.Duration = this._columnMovingSettings.AnimationDurationResolved;
					this._columnMovingAnimation.EasingFunction = this._columnMovingSettings.EasingFunctionResolved;
					if (this._columnMovingAnimation.IsPlaying && columnBeingSwitched != this._columnBeingSwitched)
					{
						this._columnMovingAnimation.Stop();
						columnBeingSwitched.PercentMoved = 0.0;
					}
					this._columnMovingAnimation.Play();
				}
			}
			return true;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0003743E File Offset: 0x0003563E
		protected virtual global::Infragistics.Controls.Grids.Column ResolveColumn()
		{
			return base.Column;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00037448 File Offset: 0x00035648
		protected virtual global::Infragistics.Controls.Grids.Primitives.HeaderCellControl GenerateDragHeader()
		{
			global::Infragistics.Controls.Grids.Primitives.HeaderCellControl headerCellControl = new global::Infragistics.Controls.Grids.Primitives.HeaderCellControl();
			headerCellControl.OnAttached(base.Cell);
			return headerCellControl;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00037468 File Offset: 0x00035668
		protected virtual global::Infragistics.Controls.Grids.Primitives.CellControlBase ResolveDropHeader(global::System.Windows.Point rootPoint, global::System.Windows.Rect draggingElementBounds)
		{
			if (this._dragGroupBy)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlFromPoint = this.GetCellControlFromPoint(rootPoint, null, false);
				if (cellControlFromPoint == null)
				{
					cellControlFromPoint = this.GetCellControlFromPoint(rootPoint, typeof(global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl), false);
				}
				return cellControlFromPoint;
			}
			return this.GetCellControlFromPoint(new global::System.Windows.Point(rootPoint.X, draggingElementBounds.Y), null, true);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000374BC File Offset: 0x000356BC
		protected virtual void ReactToMouseOverDroppableCellControl(global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid grid = base.Cell.Row.ColumnLayout.Grid;
			global::System.Windows.Controls.Panel panel = grid.Panel;
			global::System.Windows.Point position = e.GetPosition(panel);
			global::System.Windows.Rect boundsOfElement = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(this._dropHeader, panel);
			global::System.Windows.Rect boundsOfElement2 = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(this, panel);
			this._dropBefore = (position.X <= this._dropHeader.ActualWidth / 2.0 + boundsOfElement.X);
			if (this._dropHeader is global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl)
			{
				this.ReactToMouseOverDroppableGroupByHeader(e, boundsOfElement, boundsOfElement2);
				return;
			}
			if (this._columnMovingEnabled)
			{
				this.ReactToMouseOverDroppableHeader(e, boundsOfElement, boundsOfElement2);
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00037560 File Offset: 0x00035760
		protected virtual void ReactToMouseOverDroppableGroupByHeader(global::System.Windows.Input.MouseEventArgs e, global::System.Windows.Rect dropHeaderBounds, global::System.Windows.Rect currentHeaderBounds)
		{
			global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl element = (global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl)this._dropHeader;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Cell.Row.ColumnLayout;
			int level = global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GetLevel(element);
			string levelKey = global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GetLevelKey(element);
			if (columnLayout.Level == level && columnLayout.Key == levelKey)
			{
				double num = this._dropBefore ? dropHeaderBounds.X : (dropHeaderBounds.X + this._dropHeader.ActualWidth);
				global::System.Windows.Controls.Primitives.Popup indicatorContainer = columnLayout.GroupBySettings.IndicatorContainer;
				indicatorContainer.IsOpen = true;
				columnLayout.GroupBySettings.Indicator.Height = this._dropHeader.ActualHeight;
				indicatorContainer.VerticalOffset = dropHeaderBounds.Y;
				if (global::System.Windows.SystemParameters.IsMenuDropRightAligned)
				{
					num += global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsForPopup(indicatorContainer, this).Width;
				}
				indicatorContainer.HorizontalOffset = num + columnLayout.GroupBySettings.Indicator.HorizontalOffset;
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00037650 File Offset: 0x00035850
		protected virtual void ReactToMouseOverDroppableHeader(global::System.Windows.Input.MouseEventArgs e, global::System.Windows.Rect dropHeaderBounds, global::System.Windows.Rect currentHeaderBounds)
		{
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Right)
			{
				this._dropBefore = !this._dropBefore;
			}
			if (this._columnMovingSettings.AllowColumnMovingResolved == global::Infragistics.Controls.Grids.ColumnMovingType.Immediate)
			{
				this.MoveColumn();
				return;
			}
			if (this._columnMovingSettings.AllowColumnMovingResolved == global::Infragistics.Controls.Grids.ColumnMovingType.Indicator)
			{
				double num = this._dropBefore ? dropHeaderBounds.X : (dropHeaderBounds.X + this._dropHeader.ActualWidth);
				this._columnMovingSettings.Indicator.FillIndicatorHeight = base.ActualHeight;
				global::System.Windows.Controls.Primitives.Popup indicatorContainer = this._columnMovingSettings.IndicatorContainer;
				indicatorContainer.IsOpen = true;
				if (this.DelayRecycling)
				{
					indicatorContainer.VerticalOffset = dropHeaderBounds.Y;
				}
				else
				{
					indicatorContainer.VerticalOffset = currentHeaderBounds.Y;
				}
				indicatorContainer.VerticalOffset -= this._columnMovingSettings.Indicator.TopIndicatorDesiredHeight;
				num -= this._columnMovingSettings.Indicator.DesiredSize.Width / 2.0;
				if (global::System.Windows.SystemParameters.IsMenuDropRightAligned)
				{
					num += global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsForPopup(indicatorContainer, this).Width;
				}
				indicatorContainer.HorizontalOffset = num + this._columnMovingSettings.Indicator.HorizontalOffset;
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0003778C File Offset: 0x0003598C
		protected internal static global::System.Windows.Rect GetBoundsOfElement(global::System.Windows.FrameworkElement element, global::System.Windows.UIElement relativeElement)
		{
			if (element == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			if (relativeElement == null)
			{
				relativeElement = global::Infragistics.PlatformProxy.GetRootVisual(element);
			}
			global::System.Windows.Media.GeneralTransform generalTransform = element.TransformToVisual(relativeElement);
			global::System.Windows.Media.MatrixTransform matrixTransform = generalTransform as global::System.Windows.Media.MatrixTransform;
			if (matrixTransform != null)
			{
				global::System.Windows.Media.Matrix matrix = matrixTransform.Matrix;
				return new global::System.Windows.Rect(matrix.OffsetX, matrix.OffsetY, element.ActualWidth * global::System.Math.Abs(matrix.M11), element.ActualHeight * global::System.Math.Abs(matrix.M22));
			}
			return generalTransform.TransformBounds(global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(element));
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0003780C File Offset: 0x00035A0C
		protected global::Infragistics.Controls.Grids.Primitives.CellControlBase GetCellControlFromPoint(global::System.Windows.Point point, global::System.Type type, bool applyZoom)
		{
			global::System.Windows.UIElement grid = base.Cell.Row.ColumnLayout.Grid;
			if (applyZoom)
			{
				double zoomFactor = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetZoomFactor();
				point.Y = global::System.Math.Ceiling(point.Y / zoomFactor);
			}
			global::System.Collections.Generic.List<global::System.Windows.UIElement> elementsAtPoint = global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetElementsAtPoint(point, grid);
			if (elementsAtPoint.Count > 0)
			{
				foreach (global::System.Windows.UIElement uielement in elementsAtPoint)
				{
					global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = uielement as global::Infragistics.Controls.Grids.Primitives.CellControlBase;
					if (cellControlBase != null && cellControlBase != this)
					{
						global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
						global::Infragistics.Controls.Grids.Column column2 = cellControlBase.Column;
						if (column2.ColumnLayout != null && base.Cell.Row != null && base.Cell.Row.ColumnLayout != null && column2.ColumnLayout.Grid == base.Cell.Row.ColumnLayout.Grid)
						{
							if (type == null)
							{
								if (column2.IsMovable)
								{
									if (column.IsFixed != global::Infragistics.Controls.Grids.FixedState.NotFixed)
									{
										if (column2.IsFixed == column.IsFixed)
										{
											return cellControlBase;
										}
									}
									else if (this.ResolveReadOnlyCollection().IndexOf(column2) > -1)
									{
										return cellControlBase;
									}
								}
							}
							else if (cellControlBase.GetType() == type)
							{
								return cellControlBase;
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0003797C File Offset: 0x00035B7C
		protected virtual void MarkColumnAsMoving()
		{
			global::Infragistics.Controls.Grids.Column column = this.ResolveColumn();
			if (this._columnMovingEnabled)
			{
				if (this._columnMovingSettings.AllowColumnMovingResolved == global::Infragistics.Controls.Grids.ColumnMovingType.Immediate)
				{
					column.IsMoving = true;
					return;
				}
				base.Cell.Row.ColumnLayout.Grid.Panel.Children.Add(this._columnMovingSettings.IndicatorContainer);
				this._columnMovingSettings.IndicatorContainer.IsOpen = true;
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000379F0 File Offset: 0x00035BF0
		private static global::System.Windows.Rect GetBoundsForPopup(global::System.Windows.Controls.Primitives.Popup popup, global::System.Windows.UIElement relative)
		{
			global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)popup.Child;
			global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(relative);
			global::System.Windows.Point point = popup.TranslatePoint(new global::System.Windows.Point(popup.HorizontalOffset, popup.VerticalOffset), rootVisual);
			return new global::System.Windows.Rect(point.X, point.Y, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00037A60 File Offset: 0x00035C60
		private static global::System.Collections.Generic.List<global::System.Windows.UIElement> GetElementsAtPoint(global::System.Windows.Point p, global::System.Windows.UIElement realtiveElement)
		{
			return (from i in global::Infragistics.PlatformProxy.GetElementsFromPoint(p, realtiveElement)
			where i != realtiveElement
			select i).ToList<global::System.Windows.UIElement>();
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00037A9C File Offset: 0x00035C9C
		private static bool IsElementAtPoint(global::System.Windows.Point p, global::System.Windows.FrameworkElement element)
		{
			return global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetElementsAtPoint(p, element).Any<global::System.Windows.UIElement>();
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00037AAA File Offset: 0x00035CAA
		private void ApplyIndicatorStyle(global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator dropAreaIndicator, global::System.Windows.Style s)
		{
			if (dropAreaIndicator != null && dropAreaIndicator.Style != s)
			{
				if (s != null)
				{
					dropAreaIndicator.Style = s;
					return;
				}
				dropAreaIndicator.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00037AD0 File Offset: 0x00035CD0
		private void EnsureIndicatorState(global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator indicator, global::System.Windows.Point p, bool left)
		{
			global::Infragistics.Controls.Grids.Column column = base.Cell.Column;
			if (this._dragFixable && indicator != null)
			{
				global::Infragistics.Controls.Grids.FixedState fixedState = left ? global::Infragistics.Controls.Grids.FixedState.Left : global::Infragistics.Controls.Grids.FixedState.Right;
				global::Infragistics.Controls.Grids.FixedDropAreaLocation fixedDropAreaLocation = left ? global::Infragistics.Controls.Grids.FixedDropAreaLocation.Left : global::Infragistics.Controls.Grids.FixedDropAreaLocation.Right;
				bool flag = column.IsFixed == fixedState;
				global::Infragistics.Controls.Grids.FixedDropAreaLocation fixedDropAreaLocationResolved = this._fixedColumnSettings.FixedDropAreaLocationResolved;
				if (fixedDropAreaLocationResolved != fixedDropAreaLocation && fixedDropAreaLocationResolved != global::Infragistics.Controls.Grids.FixedDropAreaLocation.Both)
				{
					flag = true;
				}
				if (flag)
				{
					indicator.Hide();
					return;
				}
				if (global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.IsElementAtPoint(p, indicator))
				{
					indicator.DisplayMouseOver();
					return;
				}
				if (left)
				{
					indicator.DisplayFromLeft();
					return;
				}
				indicator.DisplayFromRight();
			}
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00037B58 File Offset: 0x00035D58
		private global::Infragistics.ICollectionBase ResolveCollection()
		{
			global::Infragistics.Controls.Grids.Column column = base.Cell.Column;
			global::Infragistics.ICollectionBase result = null;
			if (base.Cell.Row.ColumnLayout != null)
			{
				if (column.ParentColumn != null)
				{
					result = column.ParentColumn.ResolveChildColumns();
				}
				else if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.NotFixed)
				{
					result = base.Cell.Row.Columns;
				}
				else if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Left)
				{
					result = base.Cell.Row.Columns.FixedColumnsLeft;
				}
				else if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Right)
				{
					result = base.Cell.Row.Columns.FixedColumnsRight;
				}
			}
			else
			{
				result = this._cachedCollection;
			}
			return result;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00037C00 File Offset: 0x00035E00
		private global::System.Collections.IList ResolveReadOnlyCollection()
		{
			global::Infragistics.Controls.Grids.Column column = base.Cell.Column;
			global::System.Collections.IList result = null;
			if (column.ParentColumn != null)
			{
				result = column.ParentColumn.ResolveChildColumns();
			}
			else if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.NotFixed)
			{
				result = base.Cell.Row.Columns.VisibleColumns;
			}
			else if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Left)
			{
				result = base.Cell.Row.Columns.FixedColumnsLeft;
			}
			else if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Right)
			{
				result = base.Cell.Row.Columns.FixedColumnsRight;
			}
			return result;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00037C94 File Offset: 0x00035E94
		private void MoveColumn(int index)
		{
			global::Infragistics.Controls.Grids.Column originalColumn = this._originalColumn;
			global::Infragistics.ICollectionBase collectionBase = this.ResolveCollection();
			int num = collectionBase.IndexOf(originalColumn);
			if (index != num)
			{
				originalColumn.IsMoving = true;
				if (collectionBase is global::Infragistics.Controls.Grids.FixedColumnsCollection)
				{
					collectionBase.RemoveItemSilently(num);
					collectionBase.AddItemSilently(index, originalColumn);
					return;
				}
				collectionBase.RemoveAt(num);
				collectionBase.Insert(index, originalColumn);
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00037CEC File Offset: 0x00035EEC
		private static double GetZoomFactor()
		{
			double result = 1.0;
			try
			{
				result = global::Infragistics.PlatformProxy.GetZoomFactor();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00037D20 File Offset: 0x00035F20
		private void EnsureFocusable()
		{
			this._wasFocusable = ((base.ReadLocalValue(global::System.Windows.UIElement.FocusableProperty) == global::System.Windows.DependencyProperty.UnsetValue) ? null : new bool?(base.Focusable));
			base.Focusable = true;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00037D62 File Offset: 0x00035F62
		private void RestoreFocusable()
		{
			if (this._wasFocusable != null)
			{
				base.Focusable = this._wasFocusable.GetValueOrDefault();
				return;
			}
			base.ClearValue(global::System.Windows.UIElement.FocusableProperty);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00037D90 File Offset: 0x00035F90
		private void ColumnMovingAnimation_Tick(object sender, global::Infragistics.AnimationEventArgs e)
		{
			if (this._columnBeingSwitched != null && base.Cell != null)
			{
				this._columnBeingSwitched.PercentMoved = e.Value;
				if (this._columnMovingNewIndex != -1)
				{
					this.MoveColumn(this._columnMovingNewIndex);
					this._columnMovingNewIndex = -1;
					return;
				}
				base.Cell.Row.ColumnLayout.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00037DF6 File Offset: 0x00035FF6
		private void ColumnMovingAnimation_Complete(object sender, global::System.EventArgs e)
		{
			if (this._columnBeingSwitched != null)
			{
				this._columnBeingSwitched.PercentMoved = 0.0;
				this._columnBeingSwitched = null;
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00037E1B File Offset: 0x0003601B
		private void MovingHeader_LayoutUpdated(object sender, global::System.EventArgs e)
		{
			if (this._movingHeader != null)
			{
				this._movingHeader.GoToState("Moving", true);
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00037E38 File Offset: 0x00036038
		private void ScrollTimer_Tick(object sender, global::System.EventArgs e)
		{
			if (this._cachedGrid != null)
			{
				global::System.Windows.Controls.Primitives.ScrollBar horizontalScrollBar = ((global::Infragistics.IProvideScrollInfo)this._cachedGrid).HorizontalScrollBar;
				if (horizontalScrollBar.Visibility == global::System.Windows.Visibility.Visible && horizontalScrollBar.Maximum > 0.0)
				{
					if (this._scrollDirectionLeft)
					{
						horizontalScrollBar.Value -= 0.1;
					}
					else
					{
						horizontalScrollBar.Value += 0.1;
					}
					this._cachedGrid.InvalidateScrollPanel(false);
				}
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00037EB4 File Offset: 0x000360B4
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00037EBD File Offset: 0x000360BD
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x040004AA RID: 1194
		private global::System.Windows.DataTemplate _currentTemplate;

		// Token: 0x040004AB RID: 1195
		private global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride _columnMovingSettings;

		// Token: 0x040004AC RID: 1196
		private global::Infragistics.Controls.Grids.FixedColumnSettingsOverride _fixedColumnSettings;

		// Token: 0x040004AD RID: 1197
		private global::Infragistics.Controls.Grids.GroupBySettingsOverride _groupBySettings;

		// Token: 0x040004AE RID: 1198
		private bool _mouseDown;

		// Token: 0x040004AF RID: 1199
		private bool _dragFixable;

		// Token: 0x040004B0 RID: 1200
		private bool _columnMovingEnabled;

		// Token: 0x040004B1 RID: 1201
		private int _originalIndex;

		// Token: 0x040004B2 RID: 1202
		private bool _isDragging;

		// Token: 0x040004B3 RID: 1203
		private bool _isDragObject;

		// Token: 0x040004B4 RID: 1204
		private global::Infragistics.Controls.Grids.Primitives.CellControlBase _dropHeader;

		// Token: 0x040004B5 RID: 1205
		private global::Infragistics.Controls.Grids.Primitives.HeaderCellControl _movingHeader;

		// Token: 0x040004B6 RID: 1206
		private bool _dropBefore;

		// Token: 0x040004B7 RID: 1207
		private global::System.Windows.Point _offsetPoint;

		// Token: 0x040004B8 RID: 1208
		private global::Infragistics.Controls.Grids.Column _columnBeingSwitched;

		// Token: 0x040004B9 RID: 1209
		private global::Infragistics.Animation _columnMovingAnimation;

		// Token: 0x040004BA RID: 1210
		private int _columnMovingNewIndex = -1;

		// Token: 0x040004BB RID: 1211
		private bool _dragGroupBy;

		// Token: 0x040004BC RID: 1212
		private global::Infragistics.Controls.Grids.Column _originalColumn;

		// Token: 0x040004BD RID: 1213
		private global::System.Windows.FrameworkElement _contentElement;

		// Token: 0x040004BE RID: 1214
		private global::Infragistics.ICollectionBase _cachedCollection;

		// Token: 0x040004BF RID: 1215
		private global::System.Windows.Threading.DispatcherTimer _scrollTimer;

		// Token: 0x040004C0 RID: 1216
		private bool _scrollDirectionLeft;

		// Token: 0x040004C1 RID: 1217
		private global::Infragistics.Controls.Grids.XamGrid _cachedGrid;

		// Token: 0x040004C2 RID: 1218
		private bool _isMerged;

		// Token: 0x040004C3 RID: 1219
		private bool? _wasFocusable;
	}
}
