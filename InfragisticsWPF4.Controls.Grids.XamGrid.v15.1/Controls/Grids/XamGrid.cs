using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Grids.Primitives;
using Infragistics.Controls.Menus;
using Infragistics.Themes;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000295 RID: 661
	[global::Infragistics.Windows.Licensing.UltraLicense("XamGrid")]
	[global::System.Windows.TemplatePart(Name = "VerticalScrollBar", Type = typeof(global::System.Windows.Controls.Primitives.ScrollBar))]
	[global::System.Windows.TemplatePart(Name = "RowsPanel", Type = typeof(global::Infragistics.Controls.Grids.Primitives.RowsPanel))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.StyleTypedProperty(Property = "HeaderStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.HeaderCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "FooterStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.FooterCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "ChildBandHeaderStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.ChildBandCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "FixedRowSeparatorStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator))]
	[global::System.ComponentModel.ComplexBindingProperties("ItemsSource")]
	[global::System.Windows.TemplatePart(Name = "HorizontalScrollBar", Type = typeof(global::System.Windows.Controls.Primitives.ScrollBar))]
	[global::System.Windows.TemplatePart(Name = "DefaultDeferredScrollingTemplate", Type = typeof(global::System.Windows.DataTemplate))]
	[global::System.Windows.StyleTypedProperty(Property = "CellStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.CellControl))]
	public class XamGrid : global::System.Windows.Controls.Control, global::Infragistics.IProvideScrollInfo, global::System.IDisposable, global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.IProvidePropertyPersistenceSettings, global::Infragistics.Controls.ISupportScrollHelper, global::Infragistics.ICommandTarget
	{
		// Token: 0x06001628 RID: 5672 RVA: 0x000544D0 File Offset: 0x000526D0
		static XamGrid()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)));
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Grids.XamGrid));
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00054C0C File Offset: 0x00052E0C
		public XamGrid()
		{
			this._rowsManager = this.CreateRootRowsManager();
			base.AddHandler(global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.XamGrid_KeyDown), true);
			base.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.XamGrid_MouseLeftButtonDown), true);
			base.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.XamGrid_MouseLeftButtonUp), true);
			this._editCellValues = new global::System.Collections.Generic.Dictionary<string, object>();
			this._originalCellValues = new global::System.Collections.Generic.Dictionary<string, object>();
			base.Loaded += this.XamGrid_Loaded;
			base.Unloaded += this.XamGrid_Unloaded;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Grids.XamGrid), this);
			this.RegisterRenderAdorners(this.RenderAdorners);
			base.UseLayoutRounding = true;
			this._cachedIsAlternateRowsEnabled = (bool)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.IsAlternateRowsEnabledProperty);
			this._cachedColumnWidth = (global::Infragistics.Controls.Grids.ColumnWidth)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.ColumnWidthProperty);
			this._cachedRowHeight = (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.RowHeightProperty);
			this._cachedMinimumRowHeight = (double)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.MinimumRowHeightProperty);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Controls.Grids.XamGrid), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Controls.Grids.XamGrid.OnRequestBringIntoView));
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00054D4C File Offset: 0x00052F4C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._panel != null)
			{
				this._panel.ResetRows();
				this._panel.Children.Clear();
				this._panel.Grid = null;
				foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner in this._adorners)
				{
					xamGridRenderAdorner.UnregisterRowsPanel();
				}
			}
			this._panel = (base.GetTemplateChild("RowsPanel") as global::Infragistics.Controls.Grids.Primitives.RowsPanel);
			if (this._panel != null)
			{
				this._panel.Grid = this;
				this._rowsManager.Grid = this;
				this._rowsManager.InvalidateTopAndBottomRows();
				this._dropIndicatorPanel = new global::System.Windows.Controls.Canvas();
				global::System.Windows.Controls.Panel.SetZIndex(this._dropIndicatorPanel, 500);
				this._panel.Children.Add(this._dropIndicatorPanel);
				this._dropAreaIndicatorLeft = new global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator();
				this._dropIndicatorPanel.Children.Add(this._dropAreaIndicatorLeft);
				this._dropAreaIndicatorRight = new global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator();
				this._dropIndicatorPanel.Children.Add(this._dropAreaIndicatorRight);
				this._panel.CustomFilterDialogControl = new global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl();
				this._panel.CompoundFilterDialogControl = new global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl();
				foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner2 in this._adorners)
				{
					xamGridRenderAdorner2.RegisterRowsPanel(this._panel);
				}
				this._scrollHelper = new global::Infragistics.Controls.TouchScrollHelper(this._panel, this);
				this._scrollHelper.IsEnabled = this.IsTouchSupportEnabled;
				this._panel.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, this.IsTouchSupportEnabled);
			}
			if (this._verticalScrollbar != null)
			{
				this._verticalScrollbar.Scroll -= this.VerticalScrollbar_Scroll;
			}
			this._verticalScrollbar = (base.GetTemplateChild("VerticalScrollBar") as global::System.Windows.Controls.Primitives.ScrollBar);
			if (this._verticalScrollbar != null)
			{
				this._verticalScrollbar.Scroll += this.VerticalScrollbar_Scroll;
				this._verticalScrollbar.Orientation = global::System.Windows.Controls.Orientation.Vertical;
			}
			if (this._horizontalScrollbar != null)
			{
				this._horizontalScrollbar.Scroll -= this.HorizontalScrollbar_Scroll;
			}
			this._horizontalScrollbar = (base.GetTemplateChild("HorizontalScrollBar") as global::System.Windows.Controls.Primitives.ScrollBar);
			if (this._horizontalScrollbar != null)
			{
				this._horizontalScrollbar.Orientation = global::System.Windows.Controls.Orientation.Horizontal;
				this._horizontalScrollbar.Scroll += this.HorizontalScrollbar_Scroll;
			}
			this._rootElement = (base.GetTemplateChild("Root") as global::System.Windows.FrameworkElement);
			if (this._rootElement != null)
			{
				this._defaultDeferredScrollingTemplate = (this._rootElement.Resources["DefaultDeferredScrollingTemplate"] as global::System.Windows.DataTemplate);
				this._defaultGroupByDeferredScrollingTemplate = (this._rootElement.Resources["DefaultGroupByDeferredScrollingTemplate"] as global::System.Windows.DataTemplate);
			}
			this.LoadFilterIconFromControlTemplate("EqualsOperand", global::Infragistics.ComparisonOperator.Equals);
			this.LoadFilterIconFromControlTemplate("NotEqualsOperand", global::Infragistics.ComparisonOperator.NotEquals);
			this.LoadFilterIconFromControlTemplate("StartsWithOperand", global::Infragistics.ComparisonOperator.StartsWith);
			this.LoadFilterIconFromControlTemplate("EndsWithOperand", global::Infragistics.ComparisonOperator.EndsWith);
			this.LoadFilterIconFromControlTemplate("DoesNotStartWithOperand", global::Infragistics.ComparisonOperator.DoesNotStartWith);
			this.LoadFilterIconFromControlTemplate("DoesNotEndWithOperand", global::Infragistics.ComparisonOperator.DoesNotEndWith);
			this.LoadFilterIconFromControlTemplate("ContainsOperand", global::Infragistics.ComparisonOperator.Contains);
			this.LoadFilterIconFromControlTemplate("DoesNotContainOperand", global::Infragistics.ComparisonOperator.DoesNotContain);
			this.LoadFilterIconFromControlTemplate("GreaterThanOperand", global::Infragistics.ComparisonOperator.GreaterThan);
			this.LoadFilterIconFromControlTemplate("GreaterThanOrEqualOperand", global::Infragistics.ComparisonOperator.GreaterThanOrEqual);
			this.LoadFilterIconFromControlTemplate("LessThanOperand", global::Infragistics.ComparisonOperator.LessThan);
			this.LoadFilterIconFromControlTemplate("LessThanOrEqualOperand", global::Infragistics.ComparisonOperator.LessThanOrEqual);
			this.LoadFilterIconFromControlTemplate("TodayOperand", global::Infragistics.ComparisonOperator.DateTimeToday);
			this.LoadFilterIconFromControlTemplate("YesterdayOperand", global::Infragistics.ComparisonOperator.DateTimeYesterday);
			this.LoadFilterIconFromControlTemplate("TomorrowOperand", global::Infragistics.ComparisonOperator.DateTimeTomorrow);
			this.LoadFilterIconFromControlTemplate("YearToDateOperand", global::Infragistics.ComparisonOperator.DateTimeYearToDate);
			this.LoadFilterIconFromControlTemplate("NextMonthOperand", global::Infragistics.ComparisonOperator.DateTimeNextMonth);
			this.LoadFilterIconFromControlTemplate("ThisMonthOperand", global::Infragistics.ComparisonOperator.DateTimeThisMonth);
			this.LoadFilterIconFromControlTemplate("LastMonthOperand", global::Infragistics.ComparisonOperator.DateTimeLastMonth);
			this.LoadFilterIconFromControlTemplate("NextWeekOperand", global::Infragistics.ComparisonOperator.DateTimeNextWeek);
			this.LoadFilterIconFromControlTemplate("ThisWeekOperand", global::Infragistics.ComparisonOperator.DateTimeThisWeek);
			this.LoadFilterIconFromControlTemplate("LastWeekOperand", global::Infragistics.ComparisonOperator.DateTimeLastWeek);
			this.LoadFilterIconFromControlTemplate("NextQuarterOperand", global::Infragistics.ComparisonOperator.DateTimeNextQuarter);
			this.LoadFilterIconFromControlTemplate("ThisQuarterOperand", global::Infragistics.ComparisonOperator.DateTimeThisQuarter);
			this.LoadFilterIconFromControlTemplate("LastQuarterOperand", global::Infragistics.ComparisonOperator.DateTimeLastQuarter);
			this.LoadFilterIconFromControlTemplate("NextYearOperand", global::Infragistics.ComparisonOperator.DateTimeNextYear);
			this.LoadFilterIconFromControlTemplate("ThisYearOperand", global::Infragistics.ComparisonOperator.DateTimeThisYear);
			this.LoadFilterIconFromControlTemplate("LastYearOperand", global::Infragistics.ComparisonOperator.DateTimeLastYear);
			this.LoadFilterIconFromControlTemplate("DateAfterOperand", global::Infragistics.ComparisonOperator.DateTimeAfter);
			this.LoadFilterIconFromControlTemplate("DateBeforeOperand", global::Infragistics.ComparisonOperator.DateTimeBefore);
			this.LoadFilterIconFromControlTemplate("Quarter1Operand", global::Infragistics.ComparisonOperator.DateTimeQuarter1);
			this.LoadFilterIconFromControlTemplate("Quarter2Operand", global::Infragistics.ComparisonOperator.DateTimeQuarter2);
			this.LoadFilterIconFromControlTemplate("Quarter3Operand", global::Infragistics.ComparisonOperator.DateTimeQuarter3);
			this.LoadFilterIconFromControlTemplate("Quarter4Operand", global::Infragistics.ComparisonOperator.DateTimeQuarter4);
			this.LoadFilterIconFromControlTemplate("JanuaryOperand", global::Infragistics.ComparisonOperator.DateTimeJanuary);
			this.LoadFilterIconFromControlTemplate("FebruaryOperand", global::Infragistics.ComparisonOperator.DateTimeFebruary);
			this.LoadFilterIconFromControlTemplate("MarchOperand", global::Infragistics.ComparisonOperator.DateTimeMarch);
			this.LoadFilterIconFromControlTemplate("AprilOperand", global::Infragistics.ComparisonOperator.DateTimeApril);
			this.LoadFilterIconFromControlTemplate("MayOperand", global::Infragistics.ComparisonOperator.DateTimeMay);
			this.LoadFilterIconFromControlTemplate("JuneOperand", global::Infragistics.ComparisonOperator.DateTimeJune);
			this.LoadFilterIconFromControlTemplate("JulyOperand", global::Infragistics.ComparisonOperator.DateTimeJuly);
			this.LoadFilterIconFromControlTemplate("AugustOperand", global::Infragistics.ComparisonOperator.DateTimeAugust);
			this.LoadFilterIconFromControlTemplate("SeptemberOperand", global::Infragistics.ComparisonOperator.DateTimeSeptember);
			this.LoadFilterIconFromControlTemplate("OctoberOperand", global::Infragistics.ComparisonOperator.DateTimeOctober);
			this.LoadFilterIconFromControlTemplate("NovemberOperand", global::Infragistics.ComparisonOperator.DateTimeNovember);
			this.LoadFilterIconFromControlTemplate("DecemberOperand", global::Infragistics.ComparisonOperator.DateTimeDecember);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000552A0 File Offset: 0x000534A0
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamGridAutomationPeer(this);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000552A8 File Offset: 0x000534A8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.UIElement uielement = (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this) > 0) ? (global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0) as global::System.Windows.UIElement) : null;
			if (uielement != null)
			{
				uielement.Measure(availableSize);
				return uielement.DesiredSize;
			}
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000552E6 File Offset: 0x000534E6
		protected override void OnInitialized(global::System.EventArgs e)
		{
			if (!this._isLoaded)
			{
				this.LoadData();
			}
			base.OnInitialized(e);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000552FD File Offset: 0x000534FD
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseEnterImpl(e);
			base.OnMouseEnter(e);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0005530D File Offset: 0x0005350D
		private void OnMouseEnterImpl(global::System.Windows.Input.MouseEventArgs e)
		{
			this._mouseIsOver = true;
			if (this._selectRowsCellsTimer != null)
			{
				this._selectRowsCellsTimer.Stop();
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00055329 File Offset: 0x00053529
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseLeaveImpl(e);
			base.OnMouseLeave(e);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x0005533C File Offset: 0x0005353C
		private void OnMouseLeaveImpl(global::System.Windows.Input.MouseEventArgs e)
		{
			this._mouseIsOver = false;
			if (this._mouseOverCell != null)
			{
				this._mouseOverCell.Row.IsMouseOverInternal = false;
				if (this._mouseOverCell.Row.Control != null)
				{
					this._mouseOverCell.Row.Control.InternalCellMouseLeave(this._mouseOverCell, null);
				}
				this._mouseOverCell = null;
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x000553A0 File Offset: 0x000535A0
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnGotFocus(e);
			if (this.CurrentEditCell == null && this.ActiveCell == null)
			{
				if (this.Rows.Count > 0 && this.Rows[0].Cells.Count > 0)
				{
					bool setFocus = true;
					global::System.Windows.Controls.Control control = e.OriginalSource as global::System.Windows.Controls.Control;
					if (control != null)
					{
						setFocus = false;
					}
					global::Infragistics.Controls.Grids.Row row = this.Rows[0];
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.CellBase> enumerator = row.Cells.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Infragistics.Controls.Grids.CellBase cellBase = enumerator.Current;
							if (cellBase.Column.Visibility == global::System.Windows.Visibility.Visible)
							{
								this.SetActiveCell(cellBase, global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Code, true, setFocus, false);
								break;
							}
						}
						return;
					}
				}
				if (!this.SetFocusToSpecialRow(this.RowsManager.RegisteredTopRows, e.OriginalSource as global::System.Windows.Controls.Control))
				{
					this.SetFocusToSpecialRow(this.RowsManager.RegisteredBottomRows, e.OriginalSource as global::System.Windows.Controls.Control);
					return;
				}
			}
			else if (this.CurrentEditCell != null && this.CurrentEditCell.Control != null)
			{
				global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
				if (dependencyObject != null && !global::Infragistics.Controls.PresentationUtilities.IsAncestorOf(this.CurrentEditCell.Control, dependencyObject))
				{
					this.ScrollCellIntoView(this.CurrentEditCell);
					if (this.CurrentEditCell.Control.ContentProvider != null)
					{
						this.CurrentEditCell.Control.ContentProvider.FocusEditor();
					}
				}
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x0005551C File Offset: 0x0005371C
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.OnMouseMoveImpl(e);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x0005552C File Offset: 0x0005372C
		private void OnMouseMoveImpl(global::System.Windows.Input.MouseEventArgs e)
		{
			if (!this._mouseIsOver && this._dragSelectType != global::Infragistics.Controls.Grids.DragSelectType.None)
			{
				this._mousePosition = e.GetPosition(this);
			}
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellFromSource = this.GetCellFromSource(e.OriginalSource as global::System.Windows.DependencyObject);
			if (base.IsMouseCaptured)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(e.GetPosition(this), this);
				foreach (global::System.Windows.UIElement uielement in elementsFromPoint)
				{
					if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						cellFromSource = this.GetCellFromSource(uielement);
						if (cellFromSource != null && !(cellFromSource is global::Infragistics.Controls.Grids.Primitives.GroupCellControl))
						{
							break;
						}
					}
				}
				if (global::System.Windows.Media.VisualTreeHelper.HitTest(this, e.GetPosition(this)) == null)
				{
					this._mouseIsOver = false;
					if (this._dragSelectType != global::Infragistics.Controls.Grids.DragSelectType.None && (this.SelectionSettings.CellSelection == global::Infragistics.Controls.Grids.SelectionType.Multiple || this.SelectionSettings.RowSelection == global::Infragistics.Controls.Grids.SelectionType.Multiple))
					{
						if (this._selectRowsCellsTimer == null)
						{
							this._selectRowsCellsTimer = new global::System.Windows.Threading.DispatcherTimer();
							this._selectRowsCellsTimer.Tick += this.SelectRowsCellsTimer_Tick;
							this._selectRowsCellsTimer.Interval = global::System.TimeSpan.FromMilliseconds(0.0);
						}
						this._selectRowsCellsTimer.Start();
					}
				}
				else
				{
					this._mouseIsOver = true;
					if (this._selectRowsCellsTimer != null)
					{
						this._selectRowsCellsTimer.Stop();
					}
				}
			}
			if (cellFromSource != null)
			{
				if (cellFromSource.Cell != this._mouseOverCell)
				{
					bool flag = false;
					if (this._mouseOverCell != null)
					{
						if (this._mouseOverCell.Row.MergeData != null && this._mouseOverCell.Row.IsMouseOverInternal)
						{
							flag = true;
						}
						this._mouseOverCell.Row.IsMouseOverInternal = false;
						if (this._mouseOverCell.Row.Control != null)
						{
							this._mouseOverCell.Row.Control.InternalCellMouseLeave(this._mouseOverCell, cellFromSource.Cell);
						}
					}
					if (cellFromSource.Cell != null)
					{
						this._mouseOverCell = cellFromSource.Cell;
						if (this._mouseOverCell.Row.MergeData != null && !this._mouseOverCell.Row.IsMouseOverInternal)
						{
							flag = true;
						}
						this._mouseOverCell.Row.IsMouseOverInternal = true;
						if (this._mouseOverCell.Row.Control != null)
						{
							this._mouseOverCell.Row.Control.InternalCellMouseEnter(this._mouseOverCell);
						}
					}
					if (flag && this.RowHover == global::Infragistics.Controls.Grids.RowHoverType.Row)
					{
						this.InvalidateScrollPanel(false);
					}
				}
				if (this._dragSelectType != global::Infragistics.Controls.Grids.DragSelectType.None && cellFromSource.Cell != null && (this.SelectionSettings.CellSelection == global::Infragistics.Controls.Grids.SelectionType.Multiple || this.SelectionSettings.RowSelection == global::Infragistics.Controls.Grids.SelectionType.Multiple))
				{
					cellFromSource.Cell.OnCellDragging(this._dragSelectType);
				}
				if (cellFromSource.Cell != null)
				{
					cellFromSource.Cell.OnCellMouseMove(e);
					return;
				}
			}
			else if (this._mouseOverCell != null)
			{
				this._mouseOverCell.Row.IsMouseOverInternal = false;
				if (this._mouseOverCell.Row.Control != null)
				{
					this._mouseOverCell.Row.Control.InternalCellMouseLeave(this._mouseOverCell, null);
				}
				if (this._mouseOverCell.Row.MergeData != null)
				{
					this.InvalidateScrollPanel(false);
				}
				this._mouseOverCell = null;
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00055854 File Offset: 0x00053A54
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			this.OnMouseWheelImpl(e);
			base.OnMouseWheel(e);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00055864 File Offset: 0x00053A64
		private void OnMouseWheelImpl(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			if (this._mouseIsOver)
			{
				bool flag = false;
				int delta = e.Delta;
				int num = (delta < 0) ? 1 : -1;
				if (this._verticalScrollbar != null && this._verticalScrollbar.Visibility == global::System.Windows.Visibility.Visible)
				{
					double value = this._verticalScrollbar.Value;
					this._verticalScrollbar.Value += this._verticalScrollbar.SmallChange * (double)num;
					if (!global::Infragistics.CoreUtilities.AreClose(value, this._verticalScrollbar.Value))
					{
						flag = true;
					}
				}
				else if (this._horizontalScrollbar != null && this._horizontalScrollbar.Visibility == global::System.Windows.Visibility.Visible)
				{
					double value2 = this._horizontalScrollbar.Value;
					this._horizontalScrollbar.Value += this._horizontalScrollbar.SmallChange * (double)num;
					if (!global::Infragistics.CoreUtilities.AreClose(value2, this._horizontalScrollbar.Value))
					{
						flag = true;
					}
				}
				if (flag)
				{
					this.InvalidateScrollPanel(false);
					e.Handled = true;
				}
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0005594F File Offset: 0x00053B4F
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this.EndSelectionDrag(true);
			base.OnLostMouseCapture(e);
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x0005595F File Offset: 0x00053B5F
		public global::Infragistics.Controls.Grids.ColumnBaseCollection Columns
		{
			get
			{
				return this._rowsManager.ColumnLayout.Columns;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x00055971 File Offset: 0x00053B71
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.RowCollection Rows
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowCollection)this._rowsManager.Rows.ActualCollection;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00055988 File Offset: 0x00053B88
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x00055995 File Offset: 0x00053B95
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return this._rowsManager.ItemsSource;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.ItemsSourceProperty, value);
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x000559A4 File Offset: 0x00053BA4
		private static void ItemsSourceChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			if (xamGrid.IsLoaded)
			{
				if (xamGrid.Panel != null)
				{
					if ((xamGrid.CurrentEditCell != null || xamGrid.CurrentEditRow != null) && !xamGrid.ExitEditMode(true))
					{
						return;
					}
					xamGrid.Panel.ResetRows(true);
				}
				xamGrid.ApplyItemSource((global::System.Collections.IEnumerable)e.NewValue);
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00055A00 File Offset: 0x00053C00
		public global::Infragistics.Controls.Grids.ColumnLayoutCollection ColumnLayouts
		{
			get
			{
				if (this._columnLayouts == null)
				{
					this._columnLayouts = new global::Infragistics.Controls.Grids.ColumnLayoutCollection(this);
					this._columnLayouts.CollectionChanged += this.ColumnLayouts_CollectionChanged;
				}
				return this._columnLayouts;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00055A33 File Offset: 0x00053C33
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x00055A45 File Offset: 0x00053C45
		public int MaxDepth
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.MaxDepthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.MaxDepthProperty, value);
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00055A58 File Offset: 0x00053C58
		private static void MaxDepthChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x00055A5A File Offset: 0x00053C5A
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x00055A6C File Offset: 0x00053C6C
		public global::System.Windows.Visibility HeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderVisibilityProperty, value);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00055A80 File Offset: 0x00053C80
		private static void HeaderVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("HeaderVisibility");
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00055A9F File Offset: 0x00053C9F
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x00055AB1 File Offset: 0x00053CB1
		public global::System.Windows.Visibility FooterVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.FooterVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.FooterVisibilityProperty, value);
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00055AC4 File Offset: 0x00053CC4
		private static void FooterVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("FooterVisibility");
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x00055AE3 File Offset: 0x00053CE3
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x00055AF5 File Offset: 0x00053CF5
		public bool AutoGenerateColumns
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.AutoGenerateColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.AutoGenerateColumnsProperty, value);
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00055B08 File Offset: 0x00053D08
		private static void AutoGenerateColumnsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("AutoGenerateColumns");
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00055B27 File Offset: 0x00053D27
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00055B39 File Offset: 0x00053D39
		public double Indentation
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.IndentationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.IndentationProperty, value);
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00055B4C File Offset: 0x00053D4C
		private static void IndentationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("Indentation");
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x00055B6B File Offset: 0x00053D6B
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x00055B7D File Offset: 0x00053D7D
		public global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility ColumnLayoutHeaderVisibility
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.ColumnLayoutHeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.ColumnLayoutHeaderVisibilityProperty, value);
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00055B90 File Offset: 0x00053D90
		private static void ColumnLayoutHeaderVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("ColumnLayoutHeaderVisibility");
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00055BAF File Offset: 0x00053DAF
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00055BB7 File Offset: 0x00053DB7
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool IsAlternateRowsEnabled
		{
			get
			{
				return this._cachedIsAlternateRowsEnabled;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.IsAlternateRowsEnabledProperty, value);
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00055BCC File Offset: 0x00053DCC
		private static void IsAlternateRowsEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid._cachedIsAlternateRowsEnabled = (bool)e.NewValue;
			xamGrid.OnPropertyChanged("IsAlternateRowsEnabled");
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x00055BFD File Offset: 0x00053DFD
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x00055C0F File Offset: 0x00053E0F
		public global::System.Windows.Style CellStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.CellStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.CellStyleProperty, value);
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00055C20 File Offset: 0x00053E20
		private static void CellStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			global::System.Windows.Controls.ControlTemplate controlTemplateForConditionalFormatting;
			xamGrid.StrippedCellStyleForConditionalFormatting = global::Infragistics.Controls.Grids.XamGrid.CloneStyleWithoutControlTemplate(e.NewValue as global::System.Windows.Style, out controlTemplateForConditionalFormatting);
			xamGrid.ControlTemplateForConditionalFormatting = controlTemplateForConditionalFormatting;
			xamGrid.ResetPanelRows();
			xamGrid.OnPropertyChanged("CellStyle");
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x00055C65 File Offset: 0x00053E65
		// (set) Token: 0x06001657 RID: 5719 RVA: 0x00055C77 File Offset: 0x00053E77
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderStyleProperty, value);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00055C88 File Offset: 0x00053E88
		private static void HeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.ResetPanelRows();
			xamGrid.OnPropertyChanged("HeaderStyle");
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00055CAD File Offset: 0x00053EAD
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x00055CBF File Offset: 0x00053EBF
		public global::System.Windows.Style FooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.FooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.FooterStyleProperty, value);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00055CD0 File Offset: 0x00053ED0
		private static void FooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.ResetPanelRows();
			xamGrid.OnPropertyChanged("FooterStyle");
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x00055CF5 File Offset: 0x00053EF5
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x00055D07 File Offset: 0x00053F07
		public global::System.Windows.Style FixedRowSeparatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.FixedRowSeparatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.FixedRowSeparatorStyleProperty, value);
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00055D18 File Offset: 0x00053F18
		private static void FixedRowSeparatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("FixedRowSeparatorStyle");
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00055D37 File Offset: 0x00053F37
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00055D49 File Offset: 0x00053F49
		public global::System.Windows.Style ChildBandHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.ChildBandHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.ChildBandHeaderStyleProperty, value);
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00055D58 File Offset: 0x00053F58
		private static void ChildBandHeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.ResetPanelRows();
			xamGrid.OnPropertyChanged("ChildBandHeaderStyle");
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x00055D7D File Offset: 0x00053F7D
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x00055D8F File Offset: 0x00053F8F
		public global::System.Windows.DataTemplate ColumnsHeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00055DA0 File Offset: 0x00053FA0
		private static void ColumnsHeaderTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("ColumnsHeaderTemplate");
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00055DBF File Offset: 0x00053FBF
		// (set) Token: 0x06001666 RID: 5734 RVA: 0x00055DD1 File Offset: 0x00053FD1
		public global::System.Windows.DataTemplate ColumnsFooterTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.ColumnsFooterTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.ColumnsFooterTemplateProperty, value);
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00055DE0 File Offset: 0x00053FE0
		private static void ColumnsFooterTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("ColumnsFooterTemplate");
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x00055DFF File Offset: 0x00053FFF
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x00055E26 File Offset: 0x00054026
		public global::Infragistics.Controls.Grids.RowSelectorSettings RowSelectorSettings
		{
			get
			{
				if (this._rowSelectorSettings == null)
				{
					this._rowSelectorSettings = new global::Infragistics.Controls.Grids.RowSelectorSettings();
				}
				this._rowSelectorSettings.Grid = this;
				return this._rowSelectorSettings;
			}
			set
			{
				if (value != this._rowSelectorSettings)
				{
					this._rowSelectorSettings = value;
					this.OnPropertyChanged("RowSelectorSettings");
				}
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00055E43 File Offset: 0x00054043
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00055E6A File Offset: 0x0005406A
		public global::Infragistics.Controls.Grids.ExpansionIndicatorSettings ExpansionIndicatorSettings
		{
			get
			{
				if (this._expansionIndicators == null)
				{
					this._expansionIndicators = new global::Infragistics.Controls.Grids.ExpansionIndicatorSettings();
				}
				this._expansionIndicators.Grid = this;
				return this._expansionIndicators;
			}
			set
			{
				if (value != this._expansionIndicators)
				{
					this._expansionIndicators = value;
					this.OnPropertyChanged("ExpansionIndicatorSettings");
				}
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00055E87 File Offset: 0x00054087
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00055EAE File Offset: 0x000540AE
		public global::Infragistics.Controls.Grids.AddNewRowSettings AddNewRowSettings
		{
			get
			{
				if (this._addNewRowSettings == null)
				{
					this._addNewRowSettings = new global::Infragistics.Controls.Grids.AddNewRowSettings();
				}
				this._addNewRowSettings.Grid = this;
				return this._addNewRowSettings;
			}
			set
			{
				if (value != this._addNewRowSettings)
				{
					this._addNewRowSettings = value;
					this.OnPropertyChanged("AddNewRowSettings");
				}
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00055ECB File Offset: 0x000540CB
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x00055EF2 File Offset: 0x000540F2
		public global::Infragistics.Controls.Grids.SummaryRowSettings SummaryRowSettings
		{
			get
			{
				if (this._summaryRowSettings == null)
				{
					this._summaryRowSettings = new global::Infragistics.Controls.Grids.SummaryRowSettings();
				}
				this._summaryRowSettings.Grid = this;
				return this._summaryRowSettings;
			}
			set
			{
				if (value != this._summaryRowSettings)
				{
					this._summaryRowSettings = value;
					this.OnPropertyChanged("SummaryRowSettings");
				}
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00055F0F File Offset: 0x0005410F
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x00055F36 File Offset: 0x00054136
		public global::Infragistics.Controls.Grids.FilteringSettings FilteringSettings
		{
			get
			{
				if (this._filteringSettings == null)
				{
					this._filteringSettings = new global::Infragistics.Controls.Grids.FilteringSettings();
				}
				this._filteringSettings.Grid = this;
				return this._filteringSettings;
			}
			set
			{
				if (this._filteringSettings != value)
				{
					this._filteringSettings = value;
					this.OnPropertyChanged("FilteringSettings");
				}
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00055F53 File Offset: 0x00054153
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x00055F7A File Offset: 0x0005417A
		public global::Infragistics.Controls.Grids.ColumnMovingSettings ColumnMovingSettings
		{
			get
			{
				if (this._columnMovingSettings == null)
				{
					this._columnMovingSettings = new global::Infragistics.Controls.Grids.ColumnMovingSettings();
				}
				this._columnMovingSettings.Grid = this;
				return this._columnMovingSettings;
			}
			set
			{
				if (value != this._columnMovingSettings)
				{
					this._columnMovingSettings = value;
					this.OnPropertyChanged("ColumnMovingSettings");
				}
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00055F97 File Offset: 0x00054197
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x00055FBE File Offset: 0x000541BE
		public global::Infragistics.Controls.Grids.EditingSettings EditingSettings
		{
			get
			{
				if (this._editingSettings == null)
				{
					this._editingSettings = new global::Infragistics.Controls.Grids.EditingSettings();
				}
				this._editingSettings.Grid = this;
				return this._editingSettings;
			}
			set
			{
				if (value != this._editingSettings)
				{
					this._editingSettings = value;
					this.OnPropertyChanged("EditingSettings");
				}
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x00055FDB File Offset: 0x000541DB
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x00056002 File Offset: 0x00054202
		public global::Infragistics.Controls.Grids.FixedColumnSettings FixedColumnSettings
		{
			get
			{
				if (this._fixedColumnSettings == null)
				{
					this._fixedColumnSettings = new global::Infragistics.Controls.Grids.FixedColumnSettings();
				}
				this._fixedColumnSettings.Grid = this;
				return this._fixedColumnSettings;
			}
			set
			{
				if (value != this._fixedColumnSettings)
				{
					this._fixedColumnSettings = value;
					this.OnPropertyChanged("FixedColumnSettings");
				}
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x0005601F File Offset: 0x0005421F
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x00056046 File Offset: 0x00054246
		public global::Infragistics.Controls.Grids.SortingSettings SortingSettings
		{
			get
			{
				if (this._sortingSettings == null)
				{
					this._sortingSettings = new global::Infragistics.Controls.Grids.SortingSettings();
				}
				this._sortingSettings.Grid = this;
				return this._sortingSettings;
			}
			set
			{
				if (this._sortingSettings != value)
				{
					this._sortingSettings = value;
					this.OnPropertyChanged("SortingSettings");
				}
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00056063 File Offset: 0x00054263
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x0005608C File Offset: 0x0005428C
		public global::Infragistics.Controls.Grids.GroupBySettings GroupBySettings
		{
			get
			{
				if (this._groupBySettings == null)
				{
					this._groupBySettings = new global::Infragistics.Controls.Grids.GroupBySettings();
				}
				this._groupBySettings.Grid = this;
				return this._groupBySettings;
			}
			set
			{
				if (this._groupBySettings != value)
				{
					this._groupBySettings = value;
					this.OnPropertyChanged("GroupBySettings");
					if (this._groupBySettings != null)
					{
						this._groupBySettings.Grid = this;
						this.OnPropertyChanged("GroupByInvalidated");
						this.OnPropertyChanged("AllowGroupByArea");
					}
				}
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000560DE File Offset: 0x000542DE
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x00056105 File Offset: 0x00054305
		public global::Infragistics.Controls.Grids.PagerSettings PagerSettings
		{
			get
			{
				if (this._pagerSettings == null)
				{
					this._pagerSettings = new global::Infragistics.Controls.Grids.PagerSettings();
				}
				this._pagerSettings.Grid = this;
				return this._pagerSettings;
			}
			set
			{
				if (this._pagerSettings != value)
				{
					this._pagerSettings = value;
					this.OnPropertyChanged("PagingSettings");
				}
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00056122 File Offset: 0x00054322
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x0005612A File Offset: 0x0005432A
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.CellBase ActiveCell
		{
			get
			{
				return this._activeCell;
			}
			set
			{
				this.SetActiveCell(value, global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Code);
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x00056135 File Offset: 0x00054335
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x00056147 File Offset: 0x00054347
		public global::Infragistics.Controls.Grids.KeyboardNavigation KeyboardNavigation
		{
			get
			{
				return (global::Infragistics.Controls.Grids.KeyboardNavigation)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.KeyboardNavigationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.KeyboardNavigationProperty, value);
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x0005615A File Offset: 0x0005435A
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x00056181 File Offset: 0x00054381
		public global::Infragistics.Controls.Grids.SelectionSettings SelectionSettings
		{
			get
			{
				if (this._selectionSettings == null)
				{
					this._selectionSettings = new global::Infragistics.Controls.Grids.SelectionSettings();
				}
				this._selectionSettings.Grid = this;
				return this._selectionSettings;
			}
			set
			{
				if (value != this._selectionSettings)
				{
					this._selectionSettings = value;
					this.OnPropertyChanged("SelectionSettings");
				}
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x0005619E File Offset: 0x0005439E
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x000561C5 File Offset: 0x000543C5
		public global::Infragistics.Controls.Grids.DeferredScrollingSettings DeferredScrollingSettings
		{
			get
			{
				if (this._deferredScrollingSettings == null)
				{
					this._deferredScrollingSettings = new global::Infragistics.Controls.Grids.DeferredScrollingSettings();
				}
				this._deferredScrollingSettings.Grid = this;
				return this._deferredScrollingSettings;
			}
			set
			{
				if (value != this._deferredScrollingSettings)
				{
					this._deferredScrollingSettings = value;
					this.OnPropertyChanged("DeferredScrollingSettings");
				}
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x000561E4 File Offset: 0x000543E4
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.ColumnTypeMappingsCollection ColumnTypeMappings
		{
			get
			{
				if (this._columnTypeMappings == null)
				{
					this._columnTypeMappings = new global::Infragistics.Controls.Grids.ColumnTypeMappingsCollection();
					this._columnTypeMappings.Add(new global::Infragistics.Controls.Grids.ColumnTypeMapping
					{
						DataType = typeof(bool),
						ColumnType = typeof(global::Infragistics.Controls.Grids.CheckBoxColumn)
					});
					this._columnTypeMappings.Add(new global::Infragistics.Controls.Grids.ColumnTypeMapping
					{
						DataType = typeof(bool?),
						ColumnType = typeof(global::Infragistics.Controls.Grids.CheckBoxColumn)
					});
					this._columnTypeMappings.Add(new global::Infragistics.Controls.Grids.ColumnTypeMapping
					{
						DataType = typeof(global::System.Uri),
						ColumnType = typeof(global::Infragistics.Controls.Grids.HyperlinkColumn)
					});
					this._columnTypeMappings.Add(new global::Infragistics.Controls.Grids.ColumnTypeMapping
					{
						DataType = typeof(global::System.Collections.IEnumerable),
						ColumnType = typeof(global::Infragistics.Controls.Grids.ColumnLayout)
					});
					this._columnTypeMappings.Add(new global::Infragistics.Controls.Grids.ColumnTypeMapping
					{
						DataType = typeof(global::System.DateTime),
						ColumnType = typeof(global::Infragistics.Controls.Grids.DateColumn)
					});
					this._columnTypeMappings.Add(new global::Infragistics.Controls.Grids.ColumnTypeMapping
					{
						DataType = typeof(global::System.DateTime?),
						ColumnType = typeof(global::Infragistics.Controls.Grids.DateColumn)
					});
					this._columnTypeMappings.Add(new global::Infragistics.Controls.Grids.ColumnTypeMapping
					{
						DataType = typeof(global::System.Windows.Media.Imaging.BitmapImage),
						ColumnType = typeof(global::Infragistics.Controls.Grids.ImageColumn)
					});
				}
				return this._columnTypeMappings;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x00056377 File Offset: 0x00054577
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x0005639E File Offset: 0x0005459E
		public global::Infragistics.Controls.Grids.ColumnResizingSettings ColumnResizingSettings
		{
			get
			{
				if (this._columnResizingSettings == null)
				{
					this._columnResizingSettings = new global::Infragistics.Controls.Grids.ColumnResizingSettings();
				}
				this._columnResizingSettings.Grid = this;
				return this._columnResizingSettings;
			}
			set
			{
				if (value != this._columnResizingSettings)
				{
					this._columnResizingSettings = value;
					this.OnPropertyChanged("ColumnResizingSettings");
				}
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x000563BB File Offset: 0x000545BB
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x000563C3 File Offset: 0x000545C3
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight RowHeight
		{
			get
			{
				return this._cachedRowHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.RowHeightProperty, value);
			}
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000563D8 File Offset: 0x000545D8
		private static void RowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid._cachedRowHeight = (global::Infragistics.Controls.Grids.RowHeight)e.NewValue;
			xamGrid.OnPropertyChanged("RowHeight");
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x00056409 File Offset: 0x00054609
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x00056411 File Offset: 0x00054611
		public double MinimumRowHeight
		{
			get
			{
				return this._cachedMinimumRowHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.MinimumRowHeightProperty, value);
			}
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00056424 File Offset: 0x00054624
		private static void MinimumRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid._cachedMinimumRowHeight = (double)e.NewValue;
			xamGrid.OnPropertyChanged("MinimumRowHeight");
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00056455 File Offset: 0x00054655
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00056467 File Offset: 0x00054667
		public global::Infragistics.Controls.Grids.DeleteKeyAction DeleteKeyAction
		{
			get
			{
				return (global::Infragistics.Controls.Grids.DeleteKeyAction)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.DeleteKeyActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.DeleteKeyActionProperty, value);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x0005647A File Offset: 0x0005467A
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x0005648C File Offset: 0x0005468C
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight HeaderRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderRowHeightProperty, value);
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x000564A0 File Offset: 0x000546A0
		private static void HeaderRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("HeaderRowHeight");
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x000564BF File Offset: 0x000546BF
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x000564D1 File Offset: 0x000546D1
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight FooterRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.FooterRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.FooterRowHeightProperty, value);
			}
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000564E4 File Offset: 0x000546E4
		private static void FooterRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("FooterRowHeight");
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00056503 File Offset: 0x00054703
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x00056515 File Offset: 0x00054715
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight ChildBandHeaderHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.ChildBandHeaderHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.ChildBandHeaderHeightProperty, value);
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00056528 File Offset: 0x00054728
		private static void ChildBandHeaderHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("ChildBandHeaderHeight");
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00056547 File Offset: 0x00054747
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x0005654F File Offset: 0x0005474F
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.ColumnWidthTypeConverter))]
		public global::Infragistics.Controls.Grids.ColumnWidth ColumnWidth
		{
			get
			{
				return this._cachedColumnWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.ColumnWidthProperty, value);
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00056564 File Offset: 0x00054764
		private static void ColumnWidthChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid._cachedColumnWidth = (global::Infragistics.Controls.Grids.ColumnWidth)e.NewValue;
			xamGrid.OnPropertyChanged("ColumnWidth");
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00056595 File Offset: 0x00054795
		// (set) Token: 0x0600169E RID: 5790 RVA: 0x000565A7 File Offset: 0x000547A7
		public global::Infragistics.Controls.Grids.RowHoverType RowHover
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHoverType)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.RowHoverProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.RowHoverProperty, value);
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000565BA File Offset: 0x000547BA
		private static void RowHoverChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x000565BC File Offset: 0x000547BC
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x000565E3 File Offset: 0x000547E3
		public global::Infragistics.Controls.Grids.FillerColumnSettings FillerColumnSettings
		{
			get
			{
				if (this._fillerColumnSettings == null)
				{
					this._fillerColumnSettings = new global::Infragistics.Controls.Grids.FillerColumnSettings();
				}
				this._fillerColumnSettings.Grid = this;
				return this._fillerColumnSettings;
			}
			set
			{
				if (value != this._fillerColumnSettings)
				{
					this._fillerColumnSettings = value;
					this.OnPropertyChanged("FillerColumnSettings");
				}
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x00056600 File Offset: 0x00054800
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x00056612 File Offset: 0x00054812
		public global::System.Windows.HorizontalAlignment HeaderTextHorizontalAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderTextHorizontalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderTextHorizontalAlignmentProperty, value);
			}
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00056628 File Offset: 0x00054828
		private static void HeaderTextHorizontalAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("HeaderTextHorizontalAlignment");
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00056647 File Offset: 0x00054847
		// (set) Token: 0x060016A6 RID: 5798 RVA: 0x00056659 File Offset: 0x00054859
		public global::System.Windows.VerticalAlignment HeaderTextVerticalAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderTextVerticalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.HeaderTextVerticalAlignmentProperty, value);
			}
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0005666C File Offset: 0x0005486C
		private static void HeaderTextVerticalAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("HeaderTextVerticalAlignment");
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x0005668B File Offset: 0x0005488B
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x000566CC File Offset: 0x000548CC
		public global::Infragistics.Controls.Grids.ConditionalFormattingSettings ConditionalFormattingSettings
		{
			get
			{
				if (this._conditionalFormattingSettings == null)
				{
					this._conditionalFormattingSettings = new global::Infragistics.Controls.Grids.ConditionalFormattingSettings();
					this._conditionalFormattingSettings.PropertyChanged += this.ConditionalFormattingSettings_PropertyChanged;
				}
				this._conditionalFormattingSettings.Grid = this;
				return this._conditionalFormattingSettings;
			}
			set
			{
				if (value != this._conditionalFormattingSettings)
				{
					if (this._conditionalFormattingSettings != null)
					{
						this._conditionalFormattingSettings.PropertyChanged -= this.ConditionalFormattingSettings_PropertyChanged;
					}
					this._conditionalFormattingSettings = value;
					if (this._conditionalFormattingSettings != null)
					{
						this._conditionalFormattingSettings.PropertyChanged += this.ConditionalFormattingSettings_PropertyChanged;
					}
					this.OnPropertyChanged("ConditionalFormattingSettings");
				}
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x00056734 File Offset: 0x00054934
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x0005678A File Offset: 0x0005498A
		public global::Infragistics.Controls.Grids.ColumnChooserSettings ColumnChooserSettings
		{
			get
			{
				if (this._columnChooserSettings == null)
				{
					this._columnChooserSettings = new global::Infragistics.Controls.Grids.ColumnChooserSettings();
				}
				if (this._columnChooserSettings.Grid != this)
				{
					this._columnChooserSettings.Grid = this;
					global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this.ColumnChooserDialog, this._columnChooserSettings.Style);
				}
				return this._columnChooserSettings;
			}
			set
			{
				if (value != this._columnChooserSettings)
				{
					this._columnChooserSettings = value;
					if (this._columnChooserSettings != null)
					{
						global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this.ColumnChooserDialog, this._columnChooserSettings.Style);
					}
					this.OnPropertyChanged("ColumnChooserSettings");
				}
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x000567C5 File Offset: 0x000549C5
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x000567EC File Offset: 0x000549EC
		public global::Infragistics.Controls.Grids.ClipboardSettings ClipboardSettings
		{
			get
			{
				if (this._clipBoardSettings == null)
				{
					this._clipBoardSettings = new global::Infragistics.Controls.Grids.ClipboardSettings();
				}
				this._clipBoardSettings.Grid = this;
				return this._clipBoardSettings;
			}
			set
			{
				if (value != this._clipBoardSettings)
				{
					this._clipBoardSettings = value;
					this.OnPropertyChanged("ClipboardSettings");
				}
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00056809 File Offset: 0x00054A09
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00056816 File Offset: 0x00054A16
		public object ActiveItem
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.XamGrid.ActiveItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.ActiveItemProperty, value);
			}
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00056824 File Offset: 0x00054A24
		private static void ActiveItemChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)obj;
			xamGrid.OnPropertyChanged("ActiveItem");
			xamGrid.RowsManager.UpdateCurrentItem(e.NewValue);
			if (!xamGrid._ignoreActiveItemChanging)
			{
				object data = e.NewValue;
				global::Infragistics.Controls.Grids.Row row = null;
				if (xamGrid.GroupBySettings.GroupByColumns[xamGrid.RowsManager.ColumnLayout].Count > 0)
				{
					if (xamGrid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
					{
						data = new global::Infragistics.MergedRowInfo
						{
							Data = data
						};
					}
					else
					{
						row = xamGrid.WalkDownGroupByRowsForDataItem(xamGrid.Rows, data);
					}
				}
				if (row == null)
				{
					global::Infragistics.DataManagerBase dataManager = xamGrid.RowsManager.DataManager;
					if (dataManager != null)
					{
						int num = dataManager.ResolveIndexForRecord(data);
						if (num > -1)
						{
							row = xamGrid.Rows[num];
						}
						else
						{
							xamGrid._ignoreActiveItemChanging = true;
							if (xamGrid.ActiveCell != null && e.NewValue != null)
							{
								xamGrid.ActiveItem = xamGrid.ActiveCell.Row.Data;
							}
							else
							{
								xamGrid.ActiveItem = null;
								xamGrid.ActiveCell = null;
							}
							xamGrid._ignoreActiveItemChanging = false;
						}
					}
				}
				if (row != null && (xamGrid.ActiveCell == null || xamGrid.ActiveCell.Row != row))
				{
					global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = row.Columns.AllVisibleChildColumns;
					if (allVisibleChildColumns.Count > 0)
					{
						global::Infragistics.Controls.Grids.CellBase cellBase = row.Cells[allVisibleChildColumns[0]];
						cellBase.IsActive = true;
						if (xamGrid.ActiveCell != cellBase)
						{
							xamGrid._ignoreActiveItemChanging = true;
							xamGrid.ActiveItem = e.OldValue;
							xamGrid._ignoreActiveItemChanging = false;
						}
					}
				}
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x000569A4 File Offset: 0x00054BA4
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x000569AC File Offset: 0x00054BAC
		public global::Infragistics.DataManagerProvider DataManagerProvider
		{
			get
			{
				return this._dataManagerProvider;
			}
			set
			{
				if (this._dataManagerProvider != value && (this.ItemsSource == null || !this.IsLoaded))
				{
					this._dataManagerProvider = value;
				}
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000569D0 File Offset: 0x00054BD0
		private static void OnIsTouchSupportEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)d;
			if (xamGrid._scrollHelper != null)
			{
				xamGrid._scrollHelper.IsEnabled = (bool)e.NewValue;
			}
			if (xamGrid._panel != null)
			{
				xamGrid._panel.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, global::Infragistics.KnownBoxes.FromValue((bool)e.NewValue));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00056A2C File Offset: 0x00054C2C
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x00056A3E File Offset: 0x00054C3E
		public bool IsTouchSupportEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.IsTouchSupportEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.IsTouchSupportEnabledProperty, value);
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00056A54 File Offset: 0x00054C54
		private static void OnCellControlGenerationModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = (global::Infragistics.Controls.Grids.XamGrid)d;
			xamGrid.IsCellControlGenerationModeJustChanged = true;
			xamGrid._cachedCellControlGenerationMode = (global::Infragistics.Controls.Grids.CellControlGenerationMode)e.NewValue;
			if (xamGrid.Panel != null)
			{
				xamGrid.Panel.ResetRows(true);
			}
			xamGrid.IsCellControlGenerationModeJustChanged = false;
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x00056A9C File Offset: 0x00054C9C
		internal global::Infragistics.Controls.Grids.CellControlGenerationMode CellControlGenerationModeInternal
		{
			get
			{
				return this._cachedCellControlGenerationMode;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00056AA4 File Offset: 0x00054CA4
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00056AAC File Offset: 0x00054CAC
		internal bool IsCellControlGenerationModeJustChanged { get; set; }

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00056AB5 File Offset: 0x00054CB5
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x00056AC7 File Offset: 0x00054CC7
		public global::Infragistics.Controls.Grids.CellControlGenerationMode CellControlGenerationMode
		{
			get
			{
				return (global::Infragistics.Controls.Grids.CellControlGenerationMode)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.CellControlGenerationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGrid.CellControlGenerationModeProperty, value);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00056ADA File Offset: 0x00054CDA
		protected virtual global::System.Windows.Controls.Primitives.ScrollBar VerticalScrollBar
		{
			get
			{
				return this._verticalScrollbar;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00056AE2 File Offset: 0x00054CE2
		protected virtual global::System.Windows.Controls.Primitives.ScrollBar HorizontalScrollBar
		{
			get
			{
				return this._horizontalScrollbar;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x00056AEA File Offset: 0x00054CEA
		protected internal global::Infragistics.Controls.Grids.XamGridRowsManager RowsManager
		{
			get
			{
				return this._rowsManager;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00056AF2 File Offset: 0x00054CF2
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x00056AFA File Offset: 0x00054CFA
		protected internal global::Infragistics.Controls.Grids.Cell CurrentEditCell { get; set; }

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00056B03 File Offset: 0x00054D03
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x00056B0B File Offset: 0x00054D0B
		protected internal global::Infragistics.Controls.Grids.Row CurrentEditRow { get; set; }

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00056B14 File Offset: 0x00054D14
		protected internal global::Infragistics.Controls.Grids.Primitives.RowsPanel Panel
		{
			get
			{
				return this._panel;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x00056B1C File Offset: 0x00054D1C
		protected internal global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator DropAreaIndicatorLeft
		{
			get
			{
				return this._dropAreaIndicatorLeft;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00056B24 File Offset: 0x00054D24
		protected internal global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator DropAreaIndicatorRight
		{
			get
			{
				return this._dropAreaIndicatorRight;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00056B2C File Offset: 0x00054D2C
		protected internal global::Infragistics.Controls.Grids.CellBase MouseOverCell
		{
			get
			{
				return this._mouseOverCell;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00056B34 File Offset: 0x00054D34
		protected global::System.Windows.Controls.Primitives.Popup DeferredScrollingPopup
		{
			get
			{
				return this._deferredPopup;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00056B3C File Offset: 0x00054D3C
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00056B44 File Offset: 0x00054D44
		protected internal bool IsColumnResizing
		{
			get
			{
				return this._isColumnResizing;
			}
			set
			{
				this._isColumnResizing = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00056B4D File Offset: 0x00054D4D
		protected internal global::System.Collections.Generic.Dictionary<global::Infragistics.ComparisonOperator, global::System.Windows.DataTemplate> FilterIcons
		{
			get
			{
				if (this._filterIcons == null)
				{
					this._filterIcons = new global::System.Collections.Generic.Dictionary<global::Infragistics.ComparisonOperator, global::System.Windows.DataTemplate>();
				}
				return this._filterIcons;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x00056B68 File Offset: 0x00054D68
		// (set) Token: 0x060016CC RID: 5836 RVA: 0x00056B70 File Offset: 0x00054D70
		protected internal bool SuspendConditionalFormatUpdates
		{
			get
			{
				return this._suspendConditionalFormatUpdates;
			}
			set
			{
				if (this._suspendConditionalFormatUpdates != value)
				{
					this._suspendConditionalFormatUpdates = value;
					if (!value && this.NeedConditionalFormatUpdate)
					{
						this.InvalidateData();
						this.ResetPanelRows(true);
					}
					this.NeedConditionalFormatUpdate = false;
				}
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00056BA1 File Offset: 0x00054DA1
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x00056BA9 File Offset: 0x00054DA9
		protected internal bool NeedConditionalFormatUpdate { get; set; }

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00056BB2 File Offset: 0x00054DB2
		protected internal global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog ColumnChooserDialog
		{
			get
			{
				if (this._columnChooserDialog == null)
				{
					this._columnChooserDialog = new global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog();
				}
				return this._columnChooserDialog;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x00056BCD File Offset: 0x00054DCD
		protected internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner> RenderAdorners
		{
			get
			{
				if (this._adorners == null)
				{
					this._adorners = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner>();
				}
				return this._adorners;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00056BE8 File Offset: 0x00054DE8
		internal global::Infragistics.Controls.Grids.Primitives.InternalRowsCollection InternalRows
		{
			get
			{
				if (this._internalRows == null)
				{
					this._internalRows = new global::Infragistics.Controls.Grids.Primitives.InternalRowsCollection
					{
						RootRowsManager = this._rowsManager
					};
				}
				return this._internalRows;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00056C1C File Offset: 0x00054E1C
		internal global::System.Collections.Generic.Dictionary<string, object> EditCellValues
		{
			get
			{
				return this._editCellValues;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00056C24 File Offset: 0x00054E24
		internal global::System.Collections.Generic.Dictionary<string, object> OriginalCellValues
		{
			get
			{
				return this._originalCellValues;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x00056C2C File Offset: 0x00054E2C
		internal global::System.Windows.Controls.Canvas DropAreaIndicatorPanel
		{
			get
			{
				return this._dropIndicatorPanel;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00056C34 File Offset: 0x00054E34
		internal bool IsDeferredScrollingCurrently
		{
			get
			{
				return this._deferredPopup != null && this._deferredPopup.IsOpen;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00056C4B File Offset: 0x00054E4B
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00056C53 File Offset: 0x00054E53
		internal new bool IsLoaded
		{
			get
			{
				return this._isLoaded;
			}
			set
			{
				this._isLoaded = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x00056C5C File Offset: 0x00054E5C
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x00056C64 File Offset: 0x00054E64
		internal global::System.Windows.Style StrippedCellStyleForConditionalFormatting { get; set; }

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00056C6D File Offset: 0x00054E6D
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x00056C75 File Offset: 0x00054E75
		internal bool IgnoreActiveItemChanging
		{
			get
			{
				return this._ignoreActiveItemChanging;
			}
			set
			{
				this._ignoreActiveItemChanging = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x00056C7E File Offset: 0x00054E7E
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x00056C86 File Offset: 0x00054E86
		internal bool LoadDataFromPersistence { get; set; }

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00056C8F File Offset: 0x00054E8F
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00056C97 File Offset: 0x00054E97
		internal global::System.Windows.Controls.ControlTemplate ControlTemplateForConditionalFormatting { get; set; }

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00056CA0 File Offset: 0x00054EA0
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Cell> CellsThatCancelledEditMode
		{
			get
			{
				if (this._cellsThatCancelledEditMode == null)
				{
					this._cellsThatCancelledEditMode = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Cell>();
				}
				return this._cellsThatCancelledEditMode;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00056CBB File Offset: 0x00054EBB
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x00056CC3 File Offset: 0x00054EC3
		internal bool GridIsGoingToBeDestroyed { get; set; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00056CCC File Offset: 0x00054ECC
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00056CD4 File Offset: 0x00054ED4
		internal global::System.Windows.Input.Key LastKeyDown { get; set; }

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x00056CDD File Offset: 0x00054EDD
		internal global::Infragistics.Controls.Grids.CellBase MouseOverCellInternal
		{
			get
			{
				return this._mouseOverCell;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00056CE5 File Offset: 0x00054EE5
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x00056CED File Offset: 0x00054EED
		internal bool IsTouch { get; set; }

		// Token: 0x060016E8 RID: 5864 RVA: 0x00056CF8 File Offset: 0x00054EF8
		internal void ResetAdorners()
		{
			foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner in this.RenderAdorners)
			{
				xamGridRenderAdorner.Reset();
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00056D4C File Offset: 0x00054F4C
		protected internal void InvalidateScrollPanel(bool reset)
		{
			this.InvalidateScrollPanel(reset, false, false);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00056D57 File Offset: 0x00054F57
		protected internal void InvalidateScrollPanel(bool reset, bool resetVisibleRows)
		{
			this.InvalidateScrollPanel(reset, false, resetVisibleRows);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00056D62 File Offset: 0x00054F62
		protected internal void InvalidateScrollPanel(bool reset, bool resetScrollPosition, bool resetVisibleRows)
		{
			this.InvalidateScrollPanel(reset, resetScrollPosition, resetVisibleRows, null, true);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00056D70 File Offset: 0x00054F70
		internal void InvalidateScrollPanel(bool reset, bool resetScrollPosition, bool resetVisibleRows, global::Infragistics.Controls.Grids.EmptyDelegate callback, bool invalidateHorizontalMaxOnReset = true)
		{
			if (this._panel != null && this._isLoaded)
			{
				if (callback != null)
				{
					this._panel.InvalidateMeasureInternal(callback);
				}
				else
				{
					this._panel.InvalidateMeasureInternal();
				}
				if (reset)
				{
					this._panel.ResetCachedScrollInfo(resetVisibleRows, invalidateHorizontalMaxOnReset);
				}
				if (resetScrollPosition)
				{
					if (this._horizontalScrollbar != null)
					{
						this._horizontalScrollbar.Value = 0.0;
					}
					if (this._verticalScrollbar != null)
					{
						this._verticalScrollbar.Value = 0.0;
					}
				}
			}
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00056DF7 File Offset: 0x00054FF7
		protected internal void ResetPanelRows()
		{
			this.ResetPanelRows(false);
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00056E00 File Offset: 0x00055000
		protected internal void ResetPanelRows(bool releaseCellsPanels)
		{
			if (this.Panel != null)
			{
				this.Panel.ResetRows(releaseCellsPanels);
			}
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00056E18 File Offset: 0x00055018
		protected internal virtual bool SelectRow(global::Infragistics.Controls.Grids.Row row, global::Infragistics.Controls.Grids.InvokeAction action)
		{
			bool result = false;
			if (row != null)
			{
				global::Infragistics.Controls.Grids.SelectionType selectionType = this.SelectionSettings.RowSelection;
				global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRowsCollection = new global::Infragistics.Controls.Grids.SelectedRowsCollection();
				selectedRowsCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedRows);
				global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
				bool flag = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift;
				bool flag2 = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
				bool flag3 = action == global::Infragistics.Controls.Grids.InvokeAction.Keyboard && this.LastKeyDown == global::System.Windows.Input.Key.Tab;
				flag = ((flag && !flag3) || action == global::Infragistics.Controls.Grids.XamGrid.GetMovedAction());
				if (!flag2 && !flag)
				{
					this.SelectionSettings.SelectedCells.Clear();
					this.SelectionSettings.SelectedColumns.Clear();
				}
				if (!row.AllowSelection && (flag || flag2))
				{
					return false;
				}
				if (selectionType == global::Infragistics.Controls.Grids.SelectionType.None && action == global::Infragistics.Controls.Grids.InvokeAction.Code)
				{
					selectionType = global::Infragistics.Controls.Grids.SelectionType.Single;
				}
				if (selectionType != global::Infragistics.Controls.Grids.SelectionType.None)
				{
					global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRows = this.SelectionSettings.SelectedRows;
					if (selectionType == global::Infragistics.Controls.Grids.SelectionType.Single)
					{
						selectedRows.InternalResetItemsSilently();
						if (row.AllowSelection)
						{
							selectedRows.SelectItem(row, false);
						}
					}
					else if (flag)
					{
						if (selectedRows.Count > 0)
						{
							global::Infragistics.Controls.Grids.Row row2 = selectedRows.PivotItem;
							if (row2 == null)
							{
								row2 = selectedRows[selectedRows.Count - 1];
							}
							int num = this.InternalRows.IndexOf(row2);
							int num2 = this.InternalRows.IndexOf(row);
							if (selectedRows.PivotItem != null)
							{
								selectedRows.UnselectShiftSelectedItems();
							}
							if (num < num2)
							{
								for (int i = num; i <= num2; i++)
								{
									global::Infragistics.Controls.Grids.Row row3 = this.InternalRows[i] as global::Infragistics.Controls.Grids.Row;
									if (row3 != null && row3.AllowSelection)
									{
										selectedRows.SelectItem(row3, true);
									}
								}
							}
							else
							{
								for (int j = num; j >= num2; j--)
								{
									global::Infragistics.Controls.Grids.Row row4 = this.InternalRows[j] as global::Infragistics.Controls.Grids.Row;
									if (row4 != null && row4.AllowSelection)
									{
										selectedRows.SelectItem(row4, true);
									}
								}
							}
						}
						else if (row.AllowSelection)
						{
							selectedRows.SelectItem(row, true);
						}
					}
					else if (flag2)
					{
						if (action == global::Infragistics.Controls.Grids.InvokeAction.Click)
						{
							if (selectedRows.Contains(row))
							{
								int index = selectedRows.IndexOf(row);
								selectedRows.InternalRemoveItemSilently(index);
								result = true;
							}
							else if (row.AllowSelection)
							{
								selectedRows.SelectItem(row, false);
							}
						}
					}
					else
					{
						selectedRows.InternalResetItemsSilently();
						if (row.AllowSelection)
						{
							selectedRows.SelectItem(row, false);
						}
					}
					this.OnSelectedRowsCollectionChanged(selectedRowsCollection, this.SelectionSettings.SelectedRows);
					this.InvalidateScrollPanel(false);
				}
			}
			return result;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0005706F File Offset: 0x0005526F
		protected internal virtual void UnselectRow(global::Infragistics.Controls.Grids.Row row)
		{
			if (this.SelectionSettings.SelectedRows.Contains(row))
			{
				this.SelectionSettings.SelectedRows.Remove(row);
			}
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00057098 File Offset: 0x00055298
		protected internal virtual bool SelectCell(global::Infragistics.Controls.Grids.Cell cell, global::Infragistics.Controls.Grids.InvokeAction action)
		{
			if (cell == null || cell.Column is global::Infragistics.Controls.Grids.Primitives.FillerColumn || cell is global::Infragistics.Controls.Grids.Primitives.GroupByCell || this.IsColumnResizing)
			{
				return false;
			}
			bool result = false;
			global::Infragistics.Controls.Grids.SelectionType selectionType = this.SelectionSettings.CellSelection;
			global::Infragistics.Controls.Grids.SelectedCellsCollection selectedCellsCollection = new global::Infragistics.Controls.Grids.SelectedCellsCollection();
			selectedCellsCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedCells);
			if (action != global::Infragistics.Controls.Grids.InvokeAction.Code && cell.Row.AllowSelection && this.SelectionSettings.CellClickAction == global::Infragistics.Controls.Grids.CellSelectionAction.SelectRow)
			{
				result = this.SelectRow(cell.Row as global::Infragistics.Controls.Grids.Row, action);
			}
			global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
			bool flag = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift;
			bool flag2 = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
			bool flag3 = action == global::Infragistics.Controls.Grids.InvokeAction.Keyboard && this.LastKeyDown == global::System.Windows.Input.Key.Tab;
			flag = ((flag && !flag3) || action == global::Infragistics.Controls.Grids.XamGrid.GetMovedAction());
			if (!cell.Row.AllowSelection && selectionType == global::Infragistics.Controls.Grids.SelectionType.Multiple && (flag || flag2))
			{
				return false;
			}
			if (action != global::Infragistics.Controls.Grids.InvokeAction.Code && this.SelectionSettings.CellClickAction == global::Infragistics.Controls.Grids.CellSelectionAction.SelectRow)
			{
				return result;
			}
			if (!flag2 && !flag)
			{
				this.SelectionSettings.SelectedRows.Clear();
				this.SelectionSettings.SelectedColumns.Clear();
			}
			if (selectionType == global::Infragistics.Controls.Grids.SelectionType.None && action == global::Infragistics.Controls.Grids.InvokeAction.Code)
			{
				selectionType = global::Infragistics.Controls.Grids.SelectionType.Single;
			}
			if (selectionType != global::Infragistics.Controls.Grids.SelectionType.None)
			{
				global::Infragistics.Controls.Grids.SelectedCellsCollection selectedCells = this.SelectionSettings.SelectedCells;
				if (selectionType == global::Infragistics.Controls.Grids.SelectionType.Single)
				{
					selectedCells.InternalResetItemsSilently();
					if (cell.Row.AllowSelection)
					{
						selectedCells.SelectItem(cell, false);
					}
				}
				else if (flag && selectionType == global::Infragistics.Controls.Grids.SelectionType.Multiple)
				{
					if (selectedCells.Count > 0)
					{
						global::Infragistics.Controls.Grids.Cell cell2 = selectedCells.PivotItem;
						if (cell2 == null)
						{
							cell2 = selectedCells[selectedCells.Count - 1];
						}
						global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = cell2.Row.VisibleCells;
						int num = visibleCells.IndexOf(cell2);
						int num2 = this.InternalRows.IndexOf(cell2.Row);
						int num3 = this.InternalRows.IndexOf(cell.Row);
						if (selectedCells.PivotItem != null)
						{
							selectedCells.UnselectShiftSelectedItems();
						}
						if (num != -1)
						{
							if (num2 <= num3)
							{
								int num4 = num;
								visibleCells = cell.Row.VisibleCells;
								int num5 = visibleCells.IndexOf(cell);
								for (int i = num2; i <= num3; i++)
								{
									global::Infragistics.Controls.Grids.Row row = this.InternalRows[i] as global::Infragistics.Controls.Grids.Row;
									if (row != null)
									{
										visibleCells = row.VisibleCells;
										int num6 = visibleCells.Count - 1;
										int num7 = (num4 > num6) ? num6 : num4;
										int num8 = (num5 > num6) ? num6 : num5;
										if (num4 < num5)
										{
											for (int j = num7; j <= num8; j++)
											{
												global::Infragistics.Controls.Grids.Cell cell3 = visibleCells[j] as global::Infragistics.Controls.Grids.Cell;
												if (cell3 != null && cell3.Row.AllowSelection)
												{
													selectedCells.SelectItem(cell3, true);
												}
											}
										}
										else
										{
											for (int k = num7; k >= num8; k--)
											{
												global::Infragistics.Controls.Grids.Cell cell4 = visibleCells[k] as global::Infragistics.Controls.Grids.Cell;
												if (cell4 != null && cell4.Row.AllowSelection)
												{
													selectedCells.SelectItem(cell4, true);
												}
											}
										}
									}
								}
							}
							else
							{
								int num9 = num;
								visibleCells = cell.Row.VisibleCells;
								int num10 = visibleCells.IndexOf(cell);
								for (int l = num2; l >= num3; l--)
								{
									global::Infragistics.Controls.Grids.Row row2 = this.InternalRows[l] as global::Infragistics.Controls.Grids.Row;
									if (row2 != null)
									{
										visibleCells = row2.VisibleCells;
										int num11 = visibleCells.Count - 1;
										int num12 = (num9 > num11) ? num11 : num9;
										int num13 = (num10 > num11) ? num11 : num10;
										if (num9 < num10)
										{
											for (int m = num12; m <= num13; m++)
											{
												global::Infragistics.Controls.Grids.Cell cell5 = visibleCells[m] as global::Infragistics.Controls.Grids.Cell;
												if (cell5 != null && cell5.Row.AllowSelection)
												{
													selectedCells.SelectItem(cell5, true);
												}
											}
										}
										else
										{
											for (int n = num12; n >= num13; n--)
											{
												global::Infragistics.Controls.Grids.Cell cell6 = visibleCells[n] as global::Infragistics.Controls.Grids.Cell;
												if (cell6 != null && cell6.Row.AllowSelection)
												{
													selectedCells.SelectItem(cell6, true);
												}
											}
										}
									}
								}
							}
						}
						else if (cell.Row.AllowSelection)
						{
							selectedCells.SelectItem(cell, true);
						}
					}
					else if (cell.Row.AllowSelection)
					{
						selectedCells.SelectItem(cell, true);
					}
				}
				else if (flag2)
				{
					if (action == global::Infragistics.Controls.Grids.InvokeAction.Click)
					{
						if (selectedCells.Contains(cell))
						{
							int index = selectedCells.IndexOf(cell);
							selectedCells.InternalRemoveItemSilently(index);
							result = true;
						}
						else if (cell.Row.AllowSelection)
						{
							selectedCells.SelectItem(cell, false);
						}
					}
				}
				else
				{
					selectedCells.InternalResetItemsSilently();
					if (cell.Row.AllowSelection)
					{
						selectedCells.SelectItem(cell, false);
					}
				}
				this.OnSelectedCellsCollectionChanged(selectedCellsCollection, this.SelectionSettings.SelectedCells);
				this.InvalidateScrollPanel(false);
			}
			return result;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00057549 File Offset: 0x00055749
		internal static global::Infragistics.Controls.Grids.InvokeAction GetMovedAction()
		{
			return global::Infragistics.Controls.Grids.InvokeAction.MouseMove;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0005754C File Offset: 0x0005574C
		protected internal virtual void UnselectCell(global::Infragistics.Controls.Grids.Cell cell)
		{
			if (this.SelectionSettings.SelectedCells.Contains(cell))
			{
				this.SelectionSettings.SelectedCells.Remove(cell);
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00057573 File Offset: 0x00055773
		protected internal virtual void SetActiveCell(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.CellAlignment alignment, global::Infragistics.Controls.Grids.InvokeAction action)
		{
			this.SetActiveCell(cell, alignment, action, true, true);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00057580 File Offset: 0x00055780
		protected internal virtual void SetActiveCell(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.CellAlignment alignment, global::Infragistics.Controls.Grids.InvokeAction action, bool allowSelection)
		{
			this.SetActiveCell(cell, alignment, action, allowSelection, true);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0005758E File Offset: 0x0005578E
		protected internal virtual void SetActiveCell(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.CellAlignment alignment, global::Infragistics.Controls.Grids.InvokeAction action, bool allowSelection, bool scrollIntoView)
		{
			this.SetActiveCell(cell, alignment, action, allowSelection, true, true);
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x000575A0 File Offset: 0x000557A0
		protected internal virtual void SetActiveCell(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.CellAlignment alignment, global::Infragistics.Controls.Grids.InvokeAction action, bool allowSelection, bool setFocus, bool scrollIntoView)
		{
			if (cell != null)
			{
				if (cell.Column.Visibility == global::System.Windows.Visibility.Collapsed || cell.Row.ColumnLayout.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					throw new global::Infragistics.Controls.Grids.InvalidActiveCellException();
				}
			}
			else if (this.ActiveCell == null)
			{
				return;
			}
			if (cell != null && !cell.SupportsActivation)
			{
				return;
			}
			if (cell != null && this.ActiveCell == cell)
			{
				bool flag = false;
				if (cell.Control != null)
				{
					global::System.Windows.DependencyObject dependencyObject = global::Infragistics.PlatformProxy.GetFocusedElement(cell.Control) as global::System.Windows.DependencyObject;
					if (dependencyObject != null)
					{
						while (!flag && dependencyObject != null)
						{
							if (dependencyObject == cell.Control)
							{
								flag = true;
							}
							else
							{
								dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject);
							}
						}
					}
					if (!flag)
					{
						global::System.Windows.Controls.Control control = cell.Control.Content as global::System.Windows.Controls.Control;
						if (control != null && control.IsHitTestVisible)
						{
							flag = (control.Focus() || control.IsKeyboardFocusWithin);
						}
					}
					if (!flag)
					{
						cell.Control.Focus();
					}
				}
				return;
			}
			if (this.CurrentEditRow != null)
			{
				if (cell != null && cell.Row != this.CurrentEditRow && !this.ExitEditModeInternal(false))
				{
					this.ScrollCellIntoView(this.CurrentEditCell);
					return;
				}
			}
			else if (this.CurrentEditCell != null)
			{
				global::Infragistics.Controls.Grids.Cell currentEditCell = this.CurrentEditCell;
				if (!this.ExitEditModeInternal(false))
				{
					this.ScrollCellIntoView(currentEditCell);
					return;
				}
				if (currentEditCell.Row is global::Infragistics.Controls.Grids.Primitives.FilterRow && cell != null && !(cell.Row is global::Infragistics.Controls.Grids.Primitives.FilterRow) && currentEditCell.Row.Manager is global::Infragistics.Controls.Grids.RowsManager)
				{
					global::Infragistics.DataManagerBase dataManager = ((global::Infragistics.Controls.Grids.RowsManager)currentEditCell.Row.Manager).DataManager;
					if (dataManager != null)
					{
						global::System.Collections.IList list = dataManager.FilterItems(new global::System.Collections.Generic.List<object>
						{
							cell.Row.Data
						});
						if (list.Count == 0)
						{
							return;
						}
					}
				}
			}
			global::Infragistics.Controls.Grids.Cell cell2 = cell as global::Infragistics.Controls.Grids.Cell;
			if (cell2 == null && !(cell is global::Infragistics.Controls.Grids.Primitives.ChildBandCell))
			{
				cell = null;
			}
			global::Infragistics.Controls.Grids.ActiveCellChangingEventArgs activeCellChangingEventArgs = new global::Infragistics.Controls.Grids.ActiveCellChangingEventArgs
			{
				NewActiveCell = cell,
				PreviousActiveCell = this.ActiveCell
			};
			this.OnActiveCellChanging(activeCellChangingEventArgs);
			if (!activeCellChangingEventArgs.Cancel)
			{
				global::Infragistics.Controls.Grids.CellBase activeCell = this._activeCell;
				this._activeCell = cell;
				if (activeCell != null)
				{
					global::Infragistics.Controls.Grids.RowBase rowBase = null;
					if (cell != null)
					{
						rowBase = cell.Row;
					}
					activeCell.EnsureCurrentState();
					if (activeCell.Row != rowBase && activeCell.Row.ColumnLayout != null)
					{
						activeCell.Row.IsActive = false;
						global::Infragistics.Controls.Grids.CellBase cellBase = activeCell.Row.Cells[activeCell.Row.Columns.RowSelectorColumn];
						if (cellBase != null)
						{
							cellBase.EnsureCurrentState();
						}
					}
				}
				if (cell != null)
				{
					if (activeCell == null || activeCell.Row != cell.Row)
					{
						cell.Row.IsActive = true;
						global::Infragistics.Controls.Grids.CellBase cellBase2 = cell.Row.Cells[cell.Row.Columns.RowSelectorColumn];
						if (cellBase2 != null)
						{
							cellBase2.EnsureCurrentState();
						}
					}
					cell.EnsureCurrentState();
					if (setFocus && cell.Control != null)
					{
						bool flag2 = false;
						global::System.Windows.DependencyObject dependencyObject2 = global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.DependencyObject;
						if (dependencyObject2 != null)
						{
							while (!flag2 && dependencyObject2 != null)
							{
								if (dependencyObject2 == cell.Control)
								{
									flag2 = true;
								}
								else
								{
									dependencyObject2 = global::Infragistics.PlatformProxy.GetParent(dependencyObject2);
								}
							}
						}
						if (!flag2)
						{
							global::System.Windows.Controls.Control control2 = cell.Control.Content as global::System.Windows.Controls.Control;
							if (control2 != null && control2.IsHitTestVisible)
							{
								flag2 = (control2.Focus() || control2.IsKeyboardFocusWithin);
							}
						}
						if (!flag2)
						{
							cell.Control.Focus();
						}
					}
					if (scrollIntoView)
					{
						this.ScrollCellIntoView(cell, alignment, null);
					}
				}
				this.OnActiveCellChanged();
				if (cell != null)
				{
					global::Infragistics.Controls.Grids.EditingSettingsBaseOverride editingSettingsBaseOverride;
					if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow)
					{
						editingSettingsBaseOverride = cell.Row.ColumnLayout.AddNewRowSettings;
					}
					else if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
					{
						editingSettingsBaseOverride = cell.Row.ColumnLayout.FilteringSettings;
					}
					else
					{
						editingSettingsBaseOverride = cell.Row.ColumnLayout.EditingSettings;
					}
					global::Infragistics.Controls.Grids.CustomDisplayEditableColumn customDisplayEditableColumn = cell.Column as global::Infragistics.Controls.Grids.CustomDisplayEditableColumn;
					if (this.CurrentEditRow != null)
					{
						if (cell.Row == this.CurrentEditRow)
						{
							this.ExitCellFromEditModeInternalRow(false);
							if (cell2.IsEditable && this._originalCellValues.ContainsKey(cell2.Column.Key))
							{
								this.CurrentEditCell = cell2;
							}
						}
					}
					else if (editingSettingsBaseOverride.IsOnCellActiveEditingEnabledResolved && (customDisplayEditableColumn == null || customDisplayEditableColumn.EditorDisplayBehavior != global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always))
					{
						if (cell.Row.AllowEditing == global::Infragistics.Controls.Grids.EditingType.Cell)
						{
							this.EnterEditMode(cell);
						}
						else if (cell.Row.AllowEditing == global::Infragistics.Controls.Grids.EditingType.Row)
						{
							this.EnterEditMode((global::Infragistics.Controls.Grids.Row)cell.Row, cell);
						}
					}
					global::Infragistics.Controls.Grids.RowBase row = cell.Row;
					this._ignoreActiveItemChanging = true;
					if (row.Manager == this.RowsManager || row.Manager.ParentRow is global::Infragistics.Controls.Grids.Primitives.GroupByRow)
					{
						this.ActiveItem = row.Data;
					}
					else
					{
						this.ActiveItem = null;
					}
					this._ignoreActiveItemChanging = false;
				}
				else
				{
					this._ignoreActiveItemChanging = true;
					this.ActiveItem = null;
					this._ignoreActiveItemChanging = false;
				}
			}
			if (action != global::Infragistics.Controls.Grids.InvokeAction.Code && allowSelection)
			{
				this.SelectCell(cell2, action);
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00057A90 File Offset: 0x00055C90
		protected internal virtual bool SelectColumn(global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.InvokeAction action)
		{
			bool result = false;
			if (column != null && !(column is global::Infragistics.Controls.Grids.Primitives.FillerColumn) && column.SupportsActivationAndSelection)
			{
				global::Infragistics.Controls.Grids.SelectionType selectionType = this.SelectionSettings.ColumnSelection;
				global::Infragistics.Controls.Grids.SelectedColumnsCollection selectedColumnsCollection = new global::Infragistics.Controls.Grids.SelectedColumnsCollection();
				selectedColumnsCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedColumns);
				global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
				bool flag = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift;
				bool flag2 = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
				flag = (flag || action == global::Infragistics.Controls.Grids.XamGrid.GetMovedAction());
				if (!flag2 && !flag)
				{
					this.SelectionSettings.SelectedCells.Clear();
					this.SelectionSettings.SelectedRows.Clear();
				}
				if (selectionType == global::Infragistics.Controls.Grids.SelectionType.None && action == global::Infragistics.Controls.Grids.InvokeAction.Code)
				{
					selectionType = global::Infragistics.Controls.Grids.SelectionType.Single;
				}
				if (selectionType != global::Infragistics.Controls.Grids.SelectionType.None)
				{
					global::Infragistics.Controls.Grids.SelectedColumnsCollection selectedColumns = this.SelectionSettings.SelectedColumns;
					if (selectionType == global::Infragistics.Controls.Grids.SelectionType.Single)
					{
						selectedColumns.InternalResetItemsSilently();
						selectedColumns.SelectItem(column, false);
					}
					else if (flag)
					{
						if (selectedColumns.Count > 0)
						{
							global::Infragistics.Controls.Grids.Column column2 = selectedColumns.PivotItem;
							if (column2 == null)
							{
								column2 = selectedColumns[selectedColumns.Count - 1];
							}
							if (column2.ColumnLayout == column.ColumnLayout)
							{
								global::Infragistics.Controls.Grids.ColumnBaseCollection columns = column2.ColumnLayout.Columns;
								global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
								global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsLeft = columns.FixedColumnsLeft;
								foreach (global::Infragistics.Controls.Grids.Column column3 in fixedColumnsLeft)
								{
									if (column3.Visibility == global::System.Windows.Visibility.Visible)
									{
										if (column3.SupportsActivationAndSelection)
										{
											list.Add(column3);
										}
										global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns = column3.AllColumns;
										if (allColumns.Count > 0)
										{
											foreach (global::Infragistics.Controls.Grids.Column column4 in allColumns)
											{
												if (column4.SupportsActivationAndSelection && column4.Visibility == global::System.Windows.Visibility.Visible)
												{
													list.Add(column4);
												}
											}
										}
									}
								}
								foreach (global::Infragistics.Controls.Grids.Column column5 in columns.VisibleColumns)
								{
									if (column5 != this.Columns.FillerColumn)
									{
										if (column5.SupportsActivationAndSelection)
										{
											list.Add(column5);
										}
										global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns2 = column5.AllColumns;
										if (allColumns2.Count > 0)
										{
											foreach (global::Infragistics.Controls.Grids.Column column6 in allColumns2)
											{
												if (column6.SupportsActivationAndSelection && column6.Visibility == global::System.Windows.Visibility.Visible)
												{
													list.Add(column6);
												}
											}
										}
									}
								}
								global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsRight = columns.FixedColumnsRight;
								for (int i = fixedColumnsRight.Count - 1; i >= 0; i--)
								{
									global::Infragistics.Controls.Grids.Column column7 = fixedColumnsRight[i];
									if (column7.Visibility == global::System.Windows.Visibility.Visible)
									{
										if (column7.SupportsActivationAndSelection)
										{
											list.Add(column7);
										}
										global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns3 = column7.AllColumns;
										if (allColumns3.Count > 0)
										{
											foreach (global::Infragistics.Controls.Grids.Column column8 in allColumns3)
											{
												if (column8.SupportsActivationAndSelection && column8.Visibility == global::System.Windows.Visibility.Visible)
												{
													list.Add(column8);
												}
											}
										}
									}
								}
								int num = list.IndexOf(column2);
								if (num != -1)
								{
									int num2 = list.IndexOf(column);
									if (selectedColumns.PivotItem != null)
									{
										selectedColumns.UnselectShiftSelectedItems();
									}
									if (num < num2)
									{
										for (int j = num; j <= num2; j++)
										{
											global::Infragistics.Controls.Grids.Column column9 = list[j];
											if (column9 != null)
											{
												selectedColumns.SelectItem(column9, true);
											}
										}
									}
									else
									{
										for (int k = num; k >= num2; k--)
										{
											global::Infragistics.Controls.Grids.Column column10 = list[k];
											if (column10 != null)
											{
												selectedColumns.SelectItem(column10, true);
											}
										}
									}
								}
								else
								{
									selectedColumns.SelectItem(column, true);
								}
							}
							else
							{
								selectedColumns.InternalResetItemsSilently();
								selectedColumns.SelectItem(column, false);
							}
						}
						else
						{
							selectedColumns.SelectItem(column, true);
						}
					}
					else if (flag2)
					{
						if (action == global::Infragistics.Controls.Grids.InvokeAction.Click)
						{
							if (selectedColumns.Contains(column))
							{
								int index = selectedColumns.IndexOf(column);
								selectedColumns.InternalRemoveItemSilently(index);
								result = true;
							}
							else
							{
								selectedColumns.SelectItem(column, false);
							}
						}
					}
					else
					{
						selectedColumns.InternalResetItemsSilently();
						selectedColumns.SelectItem(column, false);
					}
					this.OnSelectedColumnsCollectionChanged(selectedColumnsCollection, this.SelectionSettings.SelectedColumns);
					this.InvalidateScrollPanel(false);
				}
			}
			return result;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00057F14 File Offset: 0x00056114
		protected internal virtual void UnselectColumn(global::Infragistics.Controls.Grids.Column column)
		{
			if (this.SelectionSettings.SelectedColumns.Contains(column))
			{
				this.SelectionSettings.SelectedColumns.Remove(column);
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00057F3C File Offset: 0x0005613C
		protected virtual bool EnterEditModeInternal(global::Infragistics.Controls.Grids.Row row, global::Infragistics.Controls.Grids.Cell cell)
		{
			if (row == null)
			{
				if (cell != null && cell.IsEditable && !cell.IsEditing)
				{
					row = (cell.Row as global::Infragistics.Controls.Grids.Row);
					if (row != null && row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
					{
						global::Infragistics.Controls.Grids.RowsManager rowsManager = row.Manager as global::Infragistics.Controls.Grids.RowsManager;
						if (rowsManager != null && !rowsManager.DataManager.SupportsEditing)
						{
							return false;
						}
					}
					if (this.ExitEditModeInternal(false) && !this.OnCellEnteringEditMode(cell))
					{
						bool flag = false;
						if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
						{
							global::Infragistics.Controls.Grids.RowsManager rowsManager2 = cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
							if (rowsManager2 != null)
							{
								flag = rowsManager2.DataManager.EditItem(cell.Row.Data);
							}
						}
						if (!flag)
						{
							global::System.ComponentModel.IEditableObject editableObject = cell.Row.Data as global::System.ComponentModel.IEditableObject;
							if (editableObject != null)
							{
								editableObject.BeginEdit();
							}
						}
						this.ActiveCell = cell;
						this.EditCellValues.Clear();
						this._originalCellValues.Clear();
						if (cell.Control != null && !cell.Control.IsEnabled)
						{
							return false;
						}
						object value = cell.Value;
						this.EditCellValues.Add(cell.Column.Key, value);
						this._originalCellValues.Add(cell.Column.Key, value);
						if (cell.Row.Control == null && this.Panel != null)
						{
							this.Panel.RenderRow(cell.Row);
						}
						if (cell.Row.Control == null)
						{
							return false;
						}
						if (cell.Control == null)
						{
							cell.Row.Control.RenderCell(cell);
						}
						cell.EnterEditMode(true);
						this.OnCellEnteredEditMode(cell, cell.Control.Content as global::System.Windows.FrameworkElement);
						base.Dispatcher.BeginInvoke(new global::System.Action(this.AttachCellMouseDownToRootVis), new object[0]);
						this.InvalidateScrollPanel(false);
						this.SuspendConditionalFormatUpdates = true;
						return true;
					}
				}
			}
			else
			{
				if (row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
				{
					global::Infragistics.Controls.Grids.RowsManager rowsManager3 = row.Manager as global::Infragistics.Controls.Grids.RowsManager;
					if (rowsManager3 != null && !rowsManager3.DataManager.SupportsEditing)
					{
						return false;
					}
				}
				if (this.CurrentEditRow == row)
				{
					if (cell != null && cell.IsEditable && this.CurrentEditCell != cell)
					{
						this.CurrentEditCell = cell;
					}
					return true;
				}
				if (cell != null && !cell.IsEditable)
				{
					return false;
				}
				if (cell == null && row.Cells.Count > 0)
				{
					foreach (global::Infragistics.Controls.Grids.CellBase cellBase in row.VisibleCells)
					{
						if (cellBase.Column.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							global::Infragistics.Controls.Grids.Cell cell2 = cellBase as global::Infragistics.Controls.Grids.Cell;
							if (cell2 != null && cell2.IsEditable)
							{
								cell = cell2;
								break;
							}
						}
					}
				}
				if (cell != null && this.ExitEditModeInternal(false) && !this.OnRowEnteringEditMode(row))
				{
					bool flag2 = false;
					if (row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
					{
						global::Infragistics.Controls.Grids.RowsManager rowsManager4 = row.Manager as global::Infragistics.Controls.Grids.RowsManager;
						if (rowsManager4 != null)
						{
							flag2 = rowsManager4.DataManager.EditItem(row.Data);
						}
					}
					if (!flag2)
					{
						global::System.ComponentModel.IEditableObject editableObject2 = row.Data as global::System.ComponentModel.IEditableObject;
						if (editableObject2 != null)
						{
							editableObject2.BeginEdit();
						}
					}
					this.EditCellValues.Clear();
					this._originalCellValues.Clear();
					this.ScrollCellIntoView(cell);
					this.CellsThatCancelledEditMode.Clear();
					foreach (global::Infragistics.Controls.Grids.CellBase cellBase2 in row.VisibleCells)
					{
						if (cellBase2.Column.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							global::Infragistics.Controls.Grids.Cell cell3 = cellBase2 as global::Infragistics.Controls.Grids.Cell;
							if (cell3 != null && cell3 != cell && !this.EnterCellToEditModeInternalRow(cell3, false) && cell3.IsEditable)
							{
								this.CellsThatCancelledEditMode.Add(cell3);
							}
						}
					}
					this.EnterCellToEditModeInternalRow(cell, true);
					if (this.EditCellValues.Count == 0)
					{
						return false;
					}
					this.CurrentEditRow = row;
					base.Dispatcher.BeginInvoke(new global::System.Action(this.AttachRowMouseDownToRootVis), new object[0]);
					this.OnRowEnteredEditMode(row);
					this.InvalidateScrollPanel(false);
					this.SuspendConditionalFormatUpdates = true;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00058354 File Offset: 0x00056554
		protected internal bool EnterCellToEditModeInternalRow(global::Infragistics.Controls.Grids.Cell cell, bool currentEditCell)
		{
			if (!cell.IsEditable || this.OnCellEnteringEditMode(cell))
			{
				return false;
			}
			if (cell.Row.Control == null)
			{
				cell.Row.ColumnLayout.Grid.Panel.RenderRow(cell.Row);
			}
			cell.Row.Control.RenderCell(cell);
			if (!cell.Control.IsEnabled)
			{
				return false;
			}
			object value = cell.Value;
			this._originalCellValues.Add(cell.Column.Key, value);
			this.EditCellValues.Add(cell.Column.Key, value);
			cell.EnterEditMode(currentEditCell);
			this.OnCellEnteredEditMode(cell, cell.Control.Content as global::System.Windows.FrameworkElement);
			return true;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0005841B File Offset: 0x0005661B
		protected internal bool ExitCellFromEditModeInternalRow(bool cancel)
		{
			return this.ExitCellFromEditModeInternalRow(cancel, global::Infragistics.Controls.Grids.ExitEditModeBehavior.Default);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00058428 File Offset: 0x00056628
		internal bool ExitCellFromEditModeInternalRow(bool cancel, global::Infragistics.Controls.Grids.ExitEditModeBehavior exitEditModeBehavior)
		{
			if (this.CurrentEditRow != null)
			{
				if (this.CurrentEditCell == null)
				{
					return true;
				}
				global::Infragistics.Controls.Grids.Cell currentEditCell = this.CurrentEditCell;
				global::System.Windows.FrameworkElement editor = currentEditCell.Control.Content as global::System.Windows.FrameworkElement;
				this.EditCellValues[currentEditCell.Column.Key] = currentEditCell.Control.ContentProvider.ResolveValueFromEditor(currentEditCell);
				object newValue = this.EditCellValues[currentEditCell.Column.Key];
				global::Infragistics.Controls.Grids.ExitEditingCellEventArgs exitEditingCellEventArgs = new global::Infragistics.Controls.Grids.ExitEditingCellEventArgs
				{
					Cell = this.CurrentEditCell,
					NewValue = newValue,
					EditingCanceled = cancel,
					Editor = editor
				};
				if (exitEditModeBehavior != global::Infragistics.Controls.Grids.ExitEditModeBehavior.Forceful)
				{
					this.OnCellExitingEditMode(exitEditingCellEventArgs);
				}
				if (!exitEditingCellEventArgs.Cancel)
				{
					if (cancel)
					{
						if (this._originalCellValues.ContainsKey(currentEditCell.Column.Key) && !currentEditCell.ResetDataValue(this._originalCellValues[currentEditCell.Column.Key], exitEditModeBehavior == global::Infragistics.Controls.Grids.ExitEditModeBehavior.Default))
						{
							this.CurrentEditCell = currentEditCell;
							return false;
						}
					}
					else if (!((global::Infragistics.Controls.Grids.CellControl)currentEditCell.Control).EvaluateEditingBindings())
					{
						return false;
					}
					this.EditCellValues[currentEditCell.Column.Key] = exitEditingCellEventArgs.NewValue;
					this.CurrentEditCell = null;
					this.OnExitedEditMode(currentEditCell);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0005856C File Offset: 0x0005676C
		protected internal bool ExitEditModeInternal(bool cancel)
		{
			return this.ExitEditModeInternal(cancel, global::Infragistics.Controls.Grids.ExitEditModeBehavior.Default);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00058578 File Offset: 0x00056778
		internal bool ExitEditModeInternal(bool cancel, global::Infragistics.Controls.Grids.ExitEditModeBehavior exitEditModeBehavior)
		{
			global::Infragistics.Controls.Grids.Row currentEditRow = this.CurrentEditRow;
			if (currentEditRow != null)
			{
				bool flag = false;
				if (this.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells && currentEditRow.RowType == global::Infragistics.Controls.Grids.RowType.DataRow && this.GroupBySettings.GroupByColumns[currentEditRow.ColumnLayout].Count > 0)
				{
					flag = true;
				}
				global::Infragistics.Controls.Grids.Cell currentEditCell = this.CurrentEditCell;
				if (this.ExitCellFromEditModeInternalRow(cancel, exitEditModeBehavior))
				{
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>(this.EditCellValues);
					foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in dictionary)
					{
						global::Infragistics.Controls.Grids.Column column = currentEditRow.Columns.AllColumns[keyValuePair.Key] as global::Infragistics.Controls.Grids.Column;
						if (column != null)
						{
							global::Infragistics.Controls.Grids.Cell cell = currentEditRow.Cells[column] as global::Infragistics.Controls.Grids.Cell;
							if (cell != null && cell != currentEditCell && cell.Control.ContentProvider.CanResolveValueFromEditor)
							{
								this.EditCellValues[cell.Column.Key] = cell.Control.ContentProvider.ResolveValueFromEditor(cell);
							}
						}
					}
					if (exitEditModeBehavior == global::Infragistics.Controls.Grids.ExitEditModeBehavior.Forceful || !this.OnRowExitingEditMode(currentEditRow, this._originalCellValues, this.EditCellValues, cancel))
					{
						global::Infragistics.Controls.Grids.Row row = currentEditRow;
						foreach (global::Infragistics.Controls.Grids.CellBase cellBase in row.VisibleCells)
						{
							if (cellBase.Column.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								global::Infragistics.Controls.Grids.Cell cell2 = cellBase as global::Infragistics.Controls.Grids.Cell;
								if (cell2 != null && cell2.IsEditable && cell2.Control != null && cell2 != currentEditCell)
								{
									if (cancel)
									{
										if (this._originalCellValues.ContainsKey(cell2.Column.Key) && !cell2.ResetDataValue(this._originalCellValues[cell2.Column.Key], exitEditModeBehavior == global::Infragistics.Controls.Grids.ExitEditModeBehavior.Default))
										{
											this.CurrentEditCell = cell2;
											return false;
										}
									}
									else if (!((global::Infragistics.Controls.Grids.CellControl)cell2.Control).EvaluateEditingBindings())
									{
										this.CurrentEditCell = cell2;
										return false;
									}
								}
							}
						}
						if (cancel)
						{
							this.NeedConditionalFormatUpdate = false;
						}
						this.CurrentEditRow = null;
						this.CurrentEditCell = null;
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> allColumns = row.ColumnLayout.Columns.AllColumns;
						foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in allColumns)
						{
							global::Infragistics.Controls.Grids.Column column2 = columnBase as global::Infragistics.Controls.Grids.Column;
							if (column2 != null)
							{
								global::Infragistics.Controls.Grids.Cell cell3 = row.Cells[column2] as global::Infragistics.Controls.Grids.Cell;
								if (cell3 != null && cell3.IsEditable && this._originalCellValues.ContainsKey(cell3.Column.Key))
								{
									object newValue;
									if (cancel)
									{
										newValue = this._originalCellValues[cell3.Column.Key];
									}
									else
									{
										object obj = this._originalCellValues[cell3.Column.Key];
										object obj2 = cell3.ResolveValueFromCell();
										if (obj != obj2 && cell3.Control.ContentProvider.CanResolveValueFromEditor)
										{
											newValue = obj2;
										}
										else
										{
											newValue = this.EditCellValues[cell3.Column.Key];
										}
									}
									cell3.ExitEditMode(newValue, cancel, false);
								}
							}
						}
						this.DetachRowMouseDownToRootVis();
						if (row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow && !cancel && ((global::Infragistics.Controls.Grids.Primitives.AddNewRow)row).IsRowDirty)
						{
							global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)row.Manager;
							rowsManager.AddItem(rowsManager.CreateItem(row.Data));
							rowsManager.ResetAddNewRows(true);
						}
						if (row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
						{
							bool flag2 = false;
							global::Infragistics.Controls.Grids.RowsManager rowsManager2 = row.Manager as global::Infragistics.Controls.Grids.RowsManager;
							if (rowsManager2 != null)
							{
								if (cancel)
								{
									flag2 = rowsManager2.DataManager.CancelEdit();
								}
								else
								{
									flag2 = rowsManager2.DataManager.CommitEdit();
								}
							}
							if (!flag2)
							{
								global::System.ComponentModel.IEditableObject editableObject = row.Data as global::System.ComponentModel.IEditableObject;
								if (editableObject != null)
								{
									if (cancel)
									{
										editableObject.CancelEdit();
									}
									else
									{
										editableObject.EndEdit();
									}
								}
							}
						}
						this.OnRowExitedEditMode(row);
						this.EditCellValues.Clear();
						this._originalCellValues.Clear();
						this.SuspendConditionalFormatUpdates = false;
						if (flag)
						{
							this.InvalidateData();
						}
						return true;
					}
					this.CurrentEditCell = currentEditCell;
					this.NeedConditionalFormatUpdate = false;
				}
				return false;
			}
			if (this.CurrentEditCell != null && this.CurrentEditCell.Control != null)
			{
				bool flag3 = false;
				if (this.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells && this.CurrentEditCell.Row != null && this.CurrentEditCell.Row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow && this.CurrentEditCell.Column.IsGroupBy)
				{
					flag3 = true;
				}
				global::Infragistics.Controls.Grids.Cell currentEditCell2 = this.CurrentEditCell;
				global::System.Windows.FrameworkElement editor = currentEditCell2.Control.Content as global::System.Windows.FrameworkElement;
				this.EditCellValues[currentEditCell2.Column.Key] = currentEditCell2.Control.ContentProvider.ResolveValueFromEditor(currentEditCell2);
				object obj3 = this.EditCellValues[currentEditCell2.Column.Key];
				if (cancel)
				{
					if (this._originalCellValues.ContainsKey(currentEditCell2.Column.Key) && !currentEditCell2.ResetDataValue(this._originalCellValues[currentEditCell2.Column.Key], exitEditModeBehavior == global::Infragistics.Controls.Grids.ExitEditModeBehavior.Default))
					{
						this.CurrentEditCell = currentEditCell2;
						return false;
					}
					obj3 = this._originalCellValues[currentEditCell2.Column.Key];
					this.NeedConditionalFormatUpdate = false;
				}
				object obj4 = obj3;
				if (!currentEditCell2.Control.ContentProvider.CanResolveValueFromEditor)
				{
					obj4 = null;
				}
				global::Infragistics.Controls.Grids.ExitEditingCellEventArgs exitEditingCellEventArgs = new global::Infragistics.Controls.Grids.ExitEditingCellEventArgs
				{
					Cell = this.CurrentEditCell,
					NewValue = obj4,
					EditingCanceled = cancel,
					Editor = editor
				};
				if (exitEditModeBehavior != global::Infragistics.Controls.Grids.ExitEditModeBehavior.Forceful)
				{
					this.OnCellExitingEditMode(exitEditingCellEventArgs);
				}
				obj4 = exitEditingCellEventArgs.NewValue;
				if (!currentEditCell2.Control.ContentProvider.CanResolveValueFromEditor && obj4 == null)
				{
					obj4 = obj3;
				}
				if (exitEditingCellEventArgs.Cancel)
				{
					this.NeedConditionalFormatUpdate = false;
					global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						frameworkElement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_CellEditing_MouseLeftButtonDown));
						frameworkElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_CellEditing_MouseLeftButtonDown), true);
					}
					this.ScrollCellIntoView(this.CurrentEditCell);
					return false;
				}
				this.CurrentEditCell = null;
				if (!currentEditCell2.ExitEditMode(obj4, cancel, !exitEditingCellEventArgs.PreventEvaluateBindings))
				{
					global::System.Windows.FrameworkElement frameworkElement2 = global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement;
					if (frameworkElement2 != null)
					{
						frameworkElement2.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_CellEditing_MouseLeftButtonDown));
						frameworkElement2.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_CellEditing_MouseLeftButtonDown), true);
					}
					this.CurrentEditCell = currentEditCell2;
					this.ScrollCellIntoView(this.CurrentEditCell);
					return false;
				}
				bool flag4 = false;
				if (currentEditCell2.Row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
				{
					global::Infragistics.Controls.Grids.RowsManager rowsManager3 = currentEditCell2.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
					if (rowsManager3 != null)
					{
						if (cancel)
						{
							flag4 = rowsManager3.DataManager.CancelEdit();
						}
						else
						{
							flag4 = rowsManager3.DataManager.CommitEdit();
						}
					}
				}
				if (!flag4)
				{
					global::System.ComponentModel.IEditableObject editableObject2 = currentEditCell2.Row.Data as global::System.ComponentModel.IEditableObject;
					if (editableObject2 != null)
					{
						if (cancel)
						{
							editableObject2.CancelEdit();
						}
						else if (editableObject2 is global::System.Data.DataRowView)
						{
							(editableObject2 as global::System.Data.DataRowView).Row.EndEdit();
						}
						else
						{
							editableObject2.EndEdit();
						}
					}
				}
				this.OnExitedEditMode(currentEditCell2);
				this.DetachCellMouseDownToRootVis();
				if (currentEditCell2.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow && cancel)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterRow filterRow = (global::Infragistics.Controls.Grids.Primitives.FilterRow)currentEditCell2.Row;
					global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = (global::Infragistics.Controls.Grids.Primitives.FilterRowCell)currentEditCell2;
					if (filterRowCell.FilteringOperandResolved.RequiresFilteringInput)
					{
						if (filterRowCell.FilterCellValueResolved == null)
						{
							filterRow.RemoveFilters(filterRowCell);
						}
						else if (filterRowCell.FilterCellValueResolved is string && string.IsNullOrEmpty((string)filterRowCell.FilterCellValueResolved))
						{
							filterRow.RemoveFilters(filterRowCell);
						}
						else
						{
							filterRow.BuildFilters(filterRowCell, filterRowCell.FilterCellValueResolved, false);
						}
					}
				}
				if (flag3)
				{
					this.InvalidateData();
				}
			}
			this.InvalidateScrollPanel(false);
			this.SuspendConditionalFormatUpdates = false;
			return true;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00058DC0 File Offset: 0x00056FC0
		protected internal bool IsDependancyObjectInsideGrid(global::System.Windows.DependencyObject control)
		{
			for (global::System.Windows.DependencyObject dependencyObject = control; dependencyObject != null; dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject))
			{
				if (dependencyObject == this)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00058DE2 File Offset: 0x00056FE2
		protected virtual void RegisterRenderAdorners(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner> adorners)
		{
			adorners.Add(new global::Infragistics.Controls.Grids.Primitives.MergedCellsRenderAdorner(this));
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00058DF0 File Offset: 0x00056FF0
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.XamGridCommandBase;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00058DFB File Offset: 0x00056FFB
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			if (source is global::Infragistics.Controls.Grids.XamGridCommandSource)
			{
				return this;
			}
			return null;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00058E08 File Offset: 0x00057008
		public void ScrollCellIntoView(global::Infragistics.Controls.Grids.CellBase cell)
		{
			this.ScrollCellIntoView(cell, global::Infragistics.Controls.Grids.CellAlignment.NotSet, null);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00058E13 File Offset: 0x00057013
		private void ScrollCellIntoView(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.CellAlignment alignment, global::Infragistics.Controls.Grids.EmptyDelegate callback)
		{
			if (this.Panel != null && cell != null)
			{
				this.Panel.ScrollCellIntoView(cell, alignment, callback);
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00058E2E File Offset: 0x0005702E
		public virtual bool EnterEditMode()
		{
			return this.EnterEditMode(this.ActiveCell);
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00058E3C File Offset: 0x0005703C
		public virtual bool EnterEditMode(global::Infragistics.Controls.Grids.CellBase cell)
		{
			if (this._currentlyEnteringEditMode)
			{
				return true;
			}
			this._currentlyEnteringEditMode = true;
			bool result = this.EnterEditModeInternal(null, cell as global::Infragistics.Controls.Grids.Cell);
			this._currentlyEnteringEditMode = false;
			return result;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00058E70 File Offset: 0x00057070
		public virtual bool EnterEditMode(global::Infragistics.Controls.Grids.Row row)
		{
			return this.EnterEditModeInternal(row, null);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00058E7A File Offset: 0x0005707A
		public virtual bool EnterEditMode(global::Infragistics.Controls.Grids.Row row, global::Infragistics.Controls.Grids.CellBase cell)
		{
			return row.VisibleCells.Contains(cell) && this.EnterEditModeInternal(row, cell as global::Infragistics.Controls.Grids.Cell);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00058E99 File Offset: 0x00057099
		public virtual bool ExitEditMode(bool cancel)
		{
			return this.ExitEditModeInternal(cancel);
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00058EA2 File Offset: 0x000570A2
		public void InvalidateData()
		{
			this.RowsManager.ColumnLayout.InvalidateData();
			this.ResetPanelRows();
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00058EBA File Offset: 0x000570BA
		public void ShowColumnChooser()
		{
			this.ShowColumnChooser(this.RowsManager.ColumnLayout);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00058ECD File Offset: 0x000570CD
		public void ShowColumnChooser(global::System.Windows.Point initialLocation)
		{
			this.ShowColumnChooser(this.RowsManager.ColumnLayout, initialLocation);
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00058EE1 File Offset: 0x000570E1
		public void ShowColumnChooser(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			this.ShowColumnChooserInternal(layout, this.ColumnChooserSettings.InitialLocation);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00058EF5 File Offset: 0x000570F5
		public void ShowColumnChooser(global::Infragistics.Controls.Grids.ColumnLayout layout, global::System.Windows.Point initialLocation)
		{
			this.ShowColumnChooserInternal(layout, new global::System.Windows.Point?(initialLocation));
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00058F04 File Offset: 0x00057104
		public void ShowColumnChooser(global::Infragistics.Controls.Grids.Column column)
		{
			this.ShowColumnChooserInternal(column, this.ColumnChooserSettings.InitialLocation);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00058F18 File Offset: 0x00057118
		public void ShowColumnChooser(global::Infragistics.Controls.Grids.Column column, global::System.Windows.Point initialLocation)
		{
			this.ShowColumnChooserInternal(column, new global::System.Windows.Point?(initialLocation));
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00058F28 File Offset: 0x00057128
		private void ShowColumnChooserInternal(global::Infragistics.Controls.Grids.ColumnBase col, global::System.Windows.Point? initialLocation)
		{
			if (col != null && this._isLoaded)
			{
				if (this.Panel != null && !this.Panel.Children.Contains(this.ColumnChooserDialog))
				{
					this.Panel.Children.Add(this.ColumnChooserDialog);
					this.ColumnChooserDialog.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				}
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = col as global::Infragistics.Controls.Grids.ColumnLayout;
				if (columnLayout != null)
				{
					this.ColumnChooserDialog.ColumnLayout = columnLayout;
					this.ColumnChooserDialog.Column = null;
				}
				else
				{
					global::Infragistics.Controls.Grids.Column column = col as global::Infragistics.Controls.Grids.Column;
					if (column == null || column.ResolveChildColumns() == null)
					{
						return;
					}
					this.ColumnChooserDialog.ColumnLayout = column.ColumnLayout;
					this.ColumnChooserDialog.Column = column;
				}
				this.ColumnChooserDialog.InitialLocation = initialLocation;
				this.ColumnChooserDialog.IsOpen = false;
				this.ColumnChooserDialog.IsOpen = true;
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0005901C File Offset: 0x0005721C
		public void HideColumnChooser()
		{
			if (this._panel != null)
			{
				this.Panel.Children.Remove(this.ColumnChooserDialog);
			}
			this.ColumnChooserDialog.IsOpen = false;
			this.ColumnChooserDialog.ColumnLayout = null;
			this.ColumnChooserDialog.Column = null;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0005906C File Offset: 0x0005726C
		private void PageUpCallback()
		{
			int indexOfFirst = this.InternalRows.IndexOf(this.Panel.VisibleRows[0]);
			int indexOfLast = this.InternalRows.IndexOf(this.Panel.VisibleRows[this.Panel.VisibleRows.Count - 1]);
			this.PageUpActivateCellInRowRange(indexOfFirst, indexOfLast);
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000590D0 File Offset: 0x000572D0
		private bool PageUpActivateCellInRowRange(int indexOfFirst, int indexOfLast)
		{
			global::Infragistics.Controls.Grids.Row row = null;
			bool flag = false;
			bool flag2 = false;
			int num = indexOfFirst;
			global::Infragistics.Controls.Grids.CellBase activeCell = this.ActiveCell;
			global::Infragistics.Controls.Grids.RowBase rowBase = null;
			if (activeCell != null)
			{
				rowBase = activeCell.Row;
			}
			while (row == null && num <= indexOfLast)
			{
				global::Infragistics.Controls.Grids.Row row2 = this.InternalRows[num] as global::Infragistics.Controls.Grids.Row;
				if (activeCell != null)
				{
					if (row2 != null && rowBase != null && row2.ColumnLayout != null && row2.ColumnLayout == rowBase.ColumnLayout && row2.RowType == rowBase.RowType)
					{
						row = row2;
						flag = true;
						break;
					}
				}
				else
				{
					row = row2;
				}
				num++;
			}
			if (rowBase != null)
			{
				global::Infragistics.Controls.Grids.RowBase rowBase2 = this.InternalRows[indexOfFirst];
				if (rowBase2 != null && rowBase.ColumnLayout == rowBase2.ColumnLayout)
				{
					flag2 = true;
				}
			}
			if (row != null)
			{
				global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = row.VisibleCells;
				if (flag)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase = row.Cells[activeCell.Column];
					if (cellBase != activeCell)
					{
						this.SetActiveCell(cellBase, flag2 ? global::Infragistics.Controls.Grids.CellAlignment.Top : global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Keyboard);
						return true;
					}
				}
				else if (visibleCells.Count > 0)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase = visibleCells[0];
					if (cellBase != activeCell)
					{
						this.SetActiveCell(cellBase, global::Infragistics.Controls.Grids.CellAlignment.Top, global::Infragistics.Controls.Grids.InvokeAction.Keyboard);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000591E8 File Offset: 0x000573E8
		private void PageDownCallback()
		{
			int indexOfLast = this.InternalRows.IndexOf(this.Panel.VisibleRows[this.Panel.VisibleRows.Count - 1]);
			int indexOfFirst = this.InternalRows.IndexOf(this.Panel.VisibleRows[0]);
			this.PageDownActivateCellInRowRange(indexOfFirst, indexOfLast);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0005924C File Offset: 0x0005744C
		private bool PageDownActivateCellInRowRange(int indexOfFirst, int indexOfLast)
		{
			global::Infragistics.Controls.Grids.Row row = null;
			bool flag = false;
			bool flag2 = false;
			int num = indexOfLast;
			global::Infragistics.Controls.Grids.CellBase activeCell = this.ActiveCell;
			global::Infragistics.Controls.Grids.RowBase rowBase = null;
			if (activeCell != null)
			{
				rowBase = activeCell.Row;
			}
			while (row == null && num >= indexOfFirst)
			{
				global::Infragistics.Controls.Grids.Row row2 = this.InternalRows[num] as global::Infragistics.Controls.Grids.Row;
				if (activeCell != null)
				{
					if (row2 != null && rowBase != null && row2.ColumnLayout != null && row2.ColumnLayout == rowBase.ColumnLayout && row2.RowType == rowBase.RowType)
					{
						row = row2;
						flag = true;
						break;
					}
				}
				else
				{
					row = row2;
				}
				num--;
			}
			if (rowBase != null)
			{
				global::Infragistics.Controls.Grids.RowBase rowBase2 = this.InternalRows[indexOfLast];
				if (rowBase2 != null && rowBase.ColumnLayout == rowBase2.ColumnLayout)
				{
					flag2 = true;
				}
			}
			if (row != null)
			{
				global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = row.VisibleCells;
				if (flag)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase = row.Cells[activeCell.Column];
					if (cellBase != activeCell)
					{
						this.SetActiveCell(cellBase, flag2 ? global::Infragistics.Controls.Grids.CellAlignment.Bottom : global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Keyboard);
						return true;
					}
				}
				else if (visibleCells.Count > 0)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase = visibleCells[0];
					if (cellBase != activeCell)
					{
						this.SetActiveCell(visibleCells[0], global::Infragistics.Controls.Grids.CellAlignment.Bottom, global::Infragistics.Controls.Grids.InvokeAction.Keyboard);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00059368 File Offset: 0x00057568
		internal global::Infragistics.Controls.Grids.Primitives.CellControlBase GetCellFromSource(global::System.Windows.DependencyObject obj)
		{
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = obj as global::Infragistics.Controls.Grids.Primitives.CellControlBase;
			while (obj != null && cellControlBase == null)
			{
				obj = global::Infragistics.PlatformProxy.GetParent(obj);
				cellControlBase = (obj as global::Infragistics.Controls.Grids.Primitives.CellControlBase);
				if (cellControlBase != null && cellControlBase.Cell != null && cellControlBase.Cell.Row.ColumnLayout != null && cellControlBase.Cell.Row.ColumnLayout.Grid == this)
				{
					break;
				}
				cellControlBase = null;
			}
			return cellControlBase;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x000593CC File Offset: 0x000575CC
		private void ApplyItemSource(global::System.Collections.IEnumerable itemSource)
		{
			if (this._rowsManager.ItemsSource != itemSource)
			{
				if (this.Panel != null)
				{
					this.Panel.ResetRowsInternal(false);
				}
				this._rowsManager.ItemsSource = itemSource;
				if (itemSource == null)
				{
					this._doubleClickCell = null;
					global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.ColumnLayout> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.ColumnLayout>();
					foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in this.ColumnLayouts)
					{
						if (columnLayout.IsAutoGenerated && !columnLayout.IsDefinedGloballyResolved && columnLayout != this._rowsManager.ColumnLayout)
						{
							list.Add(columnLayout);
						}
					}
					foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 in this.ColumnLayouts)
					{
						foreach (global::Infragistics.Controls.Grids.ColumnLayout item in list)
						{
							if (columnLayout2.Columns.Contains(item))
							{
								columnLayout2.Columns.Remove(item);
							}
						}
					}
					foreach (global::Infragistics.Controls.Grids.ColumnLayout item2 in list)
					{
						this.ColumnLayouts.Remove(item2);
					}
				}
				if (this.HorizontalScrollBar != null)
				{
					this.HorizontalScrollBar.Value = 0.0;
					this.HorizontalScrollBar.Visibility = global::System.Windows.Visibility.Collapsed;
				}
				if (this.VerticalScrollBar != null)
				{
					this.VerticalScrollBar.Value = 0.0;
					this.VerticalScrollBar.Visibility = global::System.Windows.Visibility.Collapsed;
				}
				global::System.ComponentModel.ICollectionView collectionView = itemSource as global::System.ComponentModel.ICollectionView;
				if (collectionView != null)
				{
					this.ActiveItem = collectionView.CurrentItem;
				}
			}
			this.InvalidateScrollPanel(true);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000595C4 File Offset: 0x000577C4
		private void OnLoadedColumnsCatchUp(global::Infragistics.Controls.Grids.ColumnLayout rootLayout, global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> columns)
		{
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in columns)
			{
				global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
				if (column != null)
				{
					column.FilterColumnSettings.OnLoadedCatchUp();
					column.SummaryColumnSettings.OnLoadedCatchUp();
				}
				else
				{
					global::Infragistics.Controls.Grids.ColumnLayout columnLayout = columnBase as global::Infragistics.Controls.Grids.ColumnLayout;
					if (columnLayout != null && rootLayout != columnLayout)
					{
						columnLayout.Grid = this;
						this.OnLoadedColumnsCatchUp(columnLayout, columnLayout.Columns.AllColumns);
					}
				}
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00059650 File Offset: 0x00057850
		private void EndSelectionDrag(bool resetMouseDownCell)
		{
			global::Infragistics.Controls.Grids.CellBase mouseDownCell = this._mouseDownCell;
			this._dragSelectType = global::Infragistics.Controls.Grids.DragSelectType.None;
			base.ReleaseMouseCapture();
			if (this._selectRowsCellsTimer != null)
			{
				this._selectRowsCellsTimer.Stop();
			}
			if (resetMouseDownCell)
			{
				this._mouseDownCell = null;
				return;
			}
			this._mouseDownCell = mouseDownCell;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00059698 File Offset: 0x00057898
		private void LoadFilterIconFromControlTemplate(string key, global::Infragistics.ComparisonOperator comOperator)
		{
			if (this._rootElement != null)
			{
				global::System.Windows.DataTemplate dataTemplate = this._rootElement.Resources[key] as global::System.Windows.DataTemplate;
				if (dataTemplate != null)
				{
					if (!this.FilterIcons.ContainsKey(comOperator))
					{
						this.FilterIcons.Add(comOperator, dataTemplate);
						return;
					}
					if (!dataTemplate.Equals(this.FilterIcons[comOperator]))
					{
						this.FilterIcons[comOperator] = dataTemplate;
					}
				}
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00059704 File Offset: 0x00057904
		public virtual void CopyToClipboard()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase>();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.ColumnLayout, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.ColumnLayout, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>>();
			bool flag = true;
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>();
			global::Infragistics.Controls.Grids.GridClipboardCopyType gridClipboardCopyType = this.ClipboardSettings.CopyType;
			if (gridClipboardCopyType == global::Infragistics.Controls.Grids.GridClipboardCopyType.Default)
			{
				if (this.SelectionSettings.CellClickAction == global::Infragistics.Controls.Grids.CellSelectionAction.SelectCell)
				{
					gridClipboardCopyType = global::Infragistics.Controls.Grids.GridClipboardCopyType.SelectedCells;
				}
				else
				{
					gridClipboardCopyType = global::Infragistics.Controls.Grids.GridClipboardCopyType.SelectedRows;
				}
			}
			int num = 0;
			if (gridClipboardCopyType == global::Infragistics.Controls.Grids.GridClipboardCopyType.SelectedCells)
			{
				flag = false;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.RowBase, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Cell>> dictionary2 = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.RowBase, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Cell>>();
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.Cell> enumerator = this.SelectionSettings.SelectedCells.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Infragistics.Controls.Grids.Cell cell = enumerator.Current;
						if (!(cell.GetType() == typeof(global::Infragistics.Controls.Grids.Primitives.GroupByCell)))
						{
							global::Infragistics.Controls.Grids.RowBase row = cell.Row;
							int num2 = this.InternalRows.IndexOf(row);
							if (num2 != -1)
							{
								global::Infragistics.Controls.Grids.Column column = cell.Column;
								global::Infragistics.Controls.Grids.ColumnLayout columnLayout = row.ColumnLayout;
								global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Cell> list3;
								if (dictionary2.ContainsKey(row))
								{
									list3 = dictionary2[row];
								}
								else
								{
									list3 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Cell>();
									dictionary2.Add(row, list3);
								}
								list3.Add(cell);
								if (!list.Contains(row))
								{
									row.CachedClipboardIndex = num2;
									list.Add(row);
									num = global::System.Math.Min(num, row.Manager.Level);
								}
								global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list4;
								if (dictionary.ContainsKey(columnLayout))
								{
									list4 = dictionary[columnLayout];
								}
								else
								{
									list4 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
									dictionary.Add(columnLayout, list4);
								}
								if (!list4.Contains(column))
								{
									column.CachedClipboardIndex = row.VisibleCells.IndexOf(cell);
									list4.Add(column);
								}
							}
						}
					}
					goto IL_29C;
				}
			}
			foreach (global::Infragistics.Controls.Grids.Row row2 in this.SelectionSettings.SelectedRows)
			{
				if (!(row2.GetType() == typeof(global::Infragistics.Controls.Grids.Primitives.GroupByRow)))
				{
					int num3 = this.InternalRows.IndexOf(row2);
					if (num3 != -1)
					{
						row2.CachedClipboardIndex = num3;
						list.Add(row2);
						num = global::System.Math.Min(num, row2.Manager.Level);
						global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 = row2.ColumnLayout;
						if (!dictionary.ContainsKey(columnLayout2))
						{
							global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list5 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
							global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = row2.VisibleCells;
							for (int i = 0; i < visibleCells.Count; i++)
							{
								global::Infragistics.Controls.Grids.Column column2 = visibleCells[i].Column;
								if (column2.Visibility == global::System.Windows.Visibility.Visible && !(column2 is global::Infragistics.Controls.Grids.GroupColumn))
								{
									column2.CachedClipboardIndex = i;
									list5.Add(column2);
								}
							}
							dictionary.Add(columnLayout2, list5);
						}
					}
				}
			}
			IL_29C:
			global::Infragistics.Controls.Grids.Primitives.ClipboardSortColumnComparer comparer = new global::Infragistics.Controls.Grids.Primitives.ClipboardSortColumnComparer();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Grids.ColumnLayout, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>> keyValuePair in dictionary)
			{
				if (gridClipboardCopyType == global::Infragistics.Controls.Grids.GridClipboardCopyType.SelectedCells)
				{
					keyValuePair.Value.Sort(comparer);
				}
			}
			list.Sort(new global::Infragistics.Controls.Grids.Primitives.ClipboardSortRowComparer());
			string value = (global::System.Environment.OSVersion.Platform == global::System.PlatformID.MacOSX) ? "\r" : "\r\n";
			global::Infragistics.Controls.Grids.GridClipboardCopyOptions copyOptions = this.ClipboardSettings.CopyOptions;
			int num4 = int.MinValue;
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase in list)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list6 = dictionary[rowBase.ColumnLayout];
				int num5 = rowBase.Manager.Level - num;
				if (copyOptions == global::Infragistics.Controls.Grids.GridClipboardCopyOptions.IncludeHeaders && num4 != num5)
				{
					stringBuilder.Append('\t', num5);
					for (int j = 0; j < list6.Count; j++)
					{
						global::Infragistics.Controls.Grids.Column column3 = list6[j];
						if (!(column3 is global::Infragistics.Controls.Grids.ColumnLayoutTemplateColumn))
						{
							if (!string.IsNullOrEmpty(column3.HeaderText))
							{
								string headerText = column3.HeaderText;
								if (!this.OnClipboardCopyingItem(((global::Infragistics.Controls.Grids.RowsManager)rowBase.Manager).HeaderRow.Cells[column3], ref headerText))
								{
									stringBuilder.Append(headerText);
									list2.Add(((global::Infragistics.Controls.Grids.RowsManager)rowBase.Manager).HeaderRow.Cells[column3]);
								}
							}
							else
							{
								string key = column3.Key;
								if (!this.OnClipboardCopyingItem(((global::Infragistics.Controls.Grids.RowsManager)rowBase.Manager).HeaderRow.Cells[column3], ref key))
								{
									stringBuilder.Append(key);
									list2.Add(((global::Infragistics.Controls.Grids.RowsManager)rowBase.Manager).HeaderRow.Cells[column3]);
								}
							}
							if (j != list6.Count - 1)
							{
								stringBuilder.Append('\t');
							}
						}
					}
					stringBuilder.Append(value);
					num4 = num5;
				}
				stringBuilder.Append('\t', num5);
				for (int k = 0; k < list6.Count; k++)
				{
					global::Infragistics.Controls.Grids.Column column4 = list6[k];
					global::Infragistics.Controls.Grids.CellBase cellBase = rowBase.Cells[column4];
					if (!(cellBase is global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateCell))
					{
						if (flag || cellBase.IsSelected)
						{
							string value2 = null;
							object value3 = cellBase.Value;
							if (value3 != null)
							{
								string formatStringResolved = column4.FormatStringResolved;
								string s;
								if (formatStringResolved != null)
								{
									s = string.Format(formatStringResolved, value3);
								}
								else
								{
									s = value3.ToString();
								}
								value2 = this.EscapeSpecialSymbols(s);
							}
							if (!this.OnClipboardCopyingItem(cellBase, ref value2))
							{
								stringBuilder.Append(value2);
								list2.Add(cellBase);
							}
						}
						if (k != list6.Count - 1)
						{
							stringBuilder.Append('\t');
						}
					}
				}
				stringBuilder.Append(value);
			}
			if (global::System.Environment.OSVersion.Platform == global::System.PlatformID.MacOSX)
			{
				stringBuilder.Replace("\r\n", "\r");
				if (stringBuilder[stringBuilder.Length - 1] == '\r')
				{
					stringBuilder.Length--;
				}
			}
			string text = stringBuilder.ToString();
			if (this.OnClipboardCopying(new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.CellBase>(list2), ref text))
			{
				return;
			}
			if (!string.IsNullOrEmpty(text))
			{
				try
				{
					global::System.Windows.Clipboard.SetDataObject(text);
				}
				catch (global::System.Security.SecurityException)
				{
				}
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00059D78 File Offset: 0x00057F78
		public virtual void PasteFromClipboard()
		{
			string text = string.Empty;
			global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>();
			try
			{
				text = global::System.Windows.Clipboard.GetText();
			}
			catch (global::System.Security.SecurityException)
			{
			}
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			char[] array = text.ToCharArray();
			int num = array.Length;
			int i = 0;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			while (i < num)
			{
				global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
				while (i < num)
				{
					bool flag = array[i] == '"';
					int num2 = flag ? (++i) : i;
					bool flag2 = flag;
					bool flag3 = false;
					bool flag4 = false;
					bool flag5 = false;
					while (i < num)
					{
						char c = array[i];
						if (flag3)
						{
							flag3 = false;
							num2 = i;
						}
						else if (flag && flag2 && c == '"' && i + 1 < num && array[i + 1] == '"')
						{
							stringBuilder.Append(array, num2, i - num2);
							flag3 = true;
						}
						else if (flag && flag2 && c == '"')
						{
							stringBuilder.Append(array, num2, i - num2);
							flag2 = false;
							num2 = i + 1;
						}
						else
						{
							if (!flag2 && c == '\t')
							{
								stringBuilder.Append(array, num2, i - num2);
								i++;
								flag4 = true;
								break;
							}
							if (!flag2 && (c == '\r' || c == '\n'))
							{
								stringBuilder.Append(array, num2, i - num2);
								if (i < num)
								{
									char c2 = array[i];
									if (c2 == '\r')
									{
										i++;
										if (i < num && array[i] == '\n')
										{
											i++;
										}
									}
									else if (c2 == '\n')
									{
										i++;
									}
								}
								flag5 = true;
								flag4 = true;
								break;
							}
						}
						i++;
					}
					if (!flag4)
					{
						stringBuilder.Append(array, num2, i - num2);
					}
					string item;
					if (!flag)
					{
						item = stringBuilder.ToString().Trim();
					}
					else
					{
						item = stringBuilder.ToString();
					}
					list2.Add(item);
					if (flag5)
					{
						break;
					}
					stringBuilder.Clear();
				}
				list.Add(list2);
				stringBuilder.Clear();
			}
			this.OnClipboardPasting(list, text);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00059F84 File Offset: 0x00058184
		private string EscapeSpecialSymbols(string s)
		{
			if (s.IndexOf('"') != -1)
			{
				s = s.Replace("\"", "\"\"");
				s = '"' + s + '"';
			}
			else if (s.IndexOfAny(global::Infragistics.Controls.Grids.XamGrid.ClipboardCopyEscapeChars) != -1)
			{
				s = '"' + s + '"';
			}
			else if (!string.IsNullOrEmpty(s) && (s[0].Equals(' ') || s[s.Length - 1].Equals(' ')))
			{
				s = '"' + s + '"';
			}
			return s;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0005A038 File Offset: 0x00058238
		private bool SetFocusToSpecialRow(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> rows, global::System.Windows.Controls.Control focusedControl)
		{
			bool flag = false;
			if (rows.Count > 0)
			{
				foreach (global::Infragistics.Controls.Grids.RowBase rowBase in rows)
				{
					if ((rowBase.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow || rowBase.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow) && rowBase.Cells.Count > 0)
					{
						bool setFocus = true;
						if (focusedControl != null)
						{
							setFocus = false;
						}
						foreach (global::Infragistics.Controls.Grids.CellBase cellBase in rowBase.Cells)
						{
							if (cellBase.Column.Visibility == global::System.Windows.Visibility.Visible)
							{
								this.SetActiveCell(cellBase, global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Code, true, setFocus, false);
								flag = true;
								break;
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
			}
			return flag;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0005A11C File Offset: 0x0005831C
		private global::Infragistics.Controls.Grids.Row WalkDownGroupByRowsForDataItem(global::Infragistics.Controls.Grids.RowCollection rows, object data)
		{
			global::Infragistics.Controls.Grids.Row row = null;
			if (rows.Count > 0 && rows[0] is global::Infragistics.Controls.Grids.Primitives.GroupByRow)
			{
				foreach (global::Infragistics.Controls.Grids.Row row2 in rows)
				{
					global::Infragistics.Controls.Grids.Primitives.GroupByRow groupByRow = (global::Infragistics.Controls.Grids.Primitives.GroupByRow)row2;
					global::Infragistics.Controls.Grids.RowsManager rowsManager = groupByRow.ChildRowsManager as global::Infragistics.Controls.Grids.RowsManager;
					if (rowsManager != null)
					{
						if (rowsManager.GroupedColumn == null)
						{
							int num = rowsManager.DataManager.ResolveIndexForRecord(data);
							if (num != -1)
							{
								row = (rowsManager.Rows[num] as global::Infragistics.Controls.Grids.Row);
							}
						}
						else
						{
							row = this.WalkDownGroupByRowsForDataItem(groupByRow.Rows, data);
						}
					}
					if (row != null)
					{
						break;
					}
				}
			}
			return row;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0005A1D4 File Offset: 0x000583D4
		private void AttachCellMouseDownToRootVis()
		{
			if (this.CurrentEditCell != null || this.CurrentEditRow != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					this._rootVis = new global::System.WeakReference(frameworkElement);
					frameworkElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_CellEditing_MouseLeftButtonDown), true);
				}
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0005A224 File Offset: 0x00058424
		private void AttachRowMouseDownToRootVis()
		{
			if (this.CurrentEditCell != null || this.CurrentEditRow != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					this._rootVis = new global::System.WeakReference(frameworkElement);
					frameworkElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_RowEditing_MouseLeftButtonDown), true);
				}
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0005A274 File Offset: 0x00058474
		private void DetachCellMouseDownToRootVis()
		{
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._rootVis) as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				frameworkElement = (global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement);
			}
			if (frameworkElement != null)
			{
				frameworkElement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_CellEditing_MouseLeftButtonDown));
			}
			this._rootVis = null;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0005A2C4 File Offset: 0x000584C4
		private void DetachRowMouseDownToRootVis()
		{
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._rootVis) as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				frameworkElement = (global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement);
			}
			if (frameworkElement != null)
			{
				frameworkElement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_RowEditing_MouseLeftButtonDown));
			}
			this._rootVis = null;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0005A314 File Offset: 0x00058514
		private global::Infragistics.Controls.Grids.Primitives.CellControlBase GetCellControlFromElement(global::System.Windows.UIElement elementDirectlyOver)
		{
			global::System.Windows.DependencyObject dependencyObject = elementDirectlyOver;
			while (dependencyObject != null && dependencyObject != this)
			{
				if (dependencyObject is global::Infragistics.Controls.Grids.Primitives.CellControlBase)
				{
					return dependencyObject as global::Infragistics.Controls.Grids.Primitives.CellControlBase;
				}
				dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject);
			}
			return null;
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0005A344 File Offset: 0x00058544
		private bool InUtilityControl(global::System.Windows.UIElement elementDirectlyOver)
		{
			global::System.Windows.DependencyObject dependencyObject = elementDirectlyOver;
			while (dependencyObject != null && dependencyObject != this)
			{
				if (dependencyObject is global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)
				{
					return true;
				}
				if (dependencyObject is global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)
				{
					return true;
				}
				if (dependencyObject is global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog)
				{
					return true;
				}
				dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject);
			}
			return false;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0005A384 File Offset: 0x00058584
		internal void Unload()
		{
			this._isLoaded = false;
			this.ExitEditModeInternal(true, global::Infragistics.Controls.Grids.ExitEditModeBehavior.Forceful);
			if (this.CurrentEditRow != null)
			{
				this.DetachRowMouseDownToRootVis();
			}
			else if (this.CurrentEditCell != null)
			{
				this.DetachCellMouseDownToRootVis();
			}
			if (this._panel != null && this._panel.CustomFilterDialogControl != null)
			{
				this._panel.CustomFilterDialogControl.Hide();
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Active", false);
			if (this.ColumnChooserDialog != null && this.ColumnChooserDialog.IsOpen)
			{
				this.HideColumnChooser();
			}
			this._doubleClickCell = null;
			this._rowsManager.Grid = null;
			this._cellsThatCancelledEditMode = null;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0005A426 File Offset: 0x00058626
		internal void RegisterOpenHeaderDropDownControl(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl hddc)
		{
			if (this._openDropDownControl != null && this._openDropDownControl != hddc)
			{
				this._openDropDownControl.IsOpen = false;
			}
			this._openDropDownControl = hddc;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0005A44C File Offset: 0x0005864C
		internal void CloseOpenHeaderDropDownControl()
		{
			if (this._openDropDownControl != null)
			{
				this._openDropDownControl.IsOpen = false;
				this._openDropDownControl = null;
			}
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0005A46C File Offset: 0x0005866C
		internal static global::System.Windows.Style CloneStyleWithoutControlTemplate(global::System.Windows.Style sourceStyle, out global::System.Windows.Controls.ControlTemplate controlTemplate)
		{
			controlTemplate = null;
			global::System.Windows.Style style = null;
			if (sourceStyle != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.SetterBase> list = new global::System.Collections.Generic.List<global::System.Windows.SetterBase>();
				list.AddRange(sourceStyle.Setters);
				if (list.Count > 0)
				{
					style = new global::System.Windows.Style(sourceStyle.TargetType);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						global::System.Windows.Setter setter = new global::System.Windows.Setter();
						global::System.Windows.Setter setter2 = (global::System.Windows.Setter)list[i];
						setter.Property = setter2.Property;
						object obj = setter2.Value;
						if (obj is uint)
						{
							obj = obj.ToString();
						}
						global::System.Windows.Controls.ControlTemplate controlTemplate2 = obj as global::System.Windows.Controls.ControlTemplate;
						if (controlTemplate2 != null)
						{
							controlTemplate = controlTemplate2;
						}
						else
						{
							setter.Value = obj;
							style.Setters.Add(setter);
						}
					}
				}
			}
			return style;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0005A525 File Offset: 0x00058725
		internal virtual global::Infragistics.Controls.Grids.XamGridRowsManager CreateRootRowsManager()
		{
			return new global::Infragistics.Controls.Grids.XamGridRowsManager(this);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0005A530 File Offset: 0x00058730
		internal void LoadData()
		{
			this.IsLoaded = true;
			this._rowsManager.Grid = this;
			foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in this.ColumnLayouts)
			{
				columnLayout.Grid = this;
			}
			global::System.Collections.IEnumerable enumerable = (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Controls.Grids.XamGrid.ItemsSourceProperty);
			if (enumerable != null)
			{
				this.ApplyItemSource(enumerable);
			}
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.Columns.AllColumns)
			{
				global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
				if (column != null)
				{
					if (column.IsGroupBy)
					{
						global::Infragistics.Controls.Grids.GroupByColumnsCollection groupByColumns = this.GroupBySettings.GroupByColumns;
						if (!groupByColumns.Contains(column))
						{
							groupByColumns.Add(column);
						}
					}
					if (column.IsSelected)
					{
						global::Infragistics.Controls.Grids.SelectedColumnsCollection selectedColumns = this.SelectionSettings.SelectedColumns;
						if (!selectedColumns.Contains(column))
						{
							selectedColumns.InternalAddItemSilently(selectedColumns.Count, column);
						}
					}
				}
			}
			this.OnLoadedColumnsCatchUp(this.Columns.ColumnLayout, this.Columns.AllColumns);
			if (this.CurrentEditRow != null)
			{
				this.AttachRowMouseDownToRootVis();
				this.ScrollCellIntoView(this.CurrentEditCell);
				return;
			}
			if (this.CurrentEditCell != null)
			{
				this.AttachCellMouseDownToRootVis();
				this.ScrollCellIntoView(this.CurrentEditCell);
			}
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0005A6B8 File Offset: 0x000588B8
		internal void ThrowInvalidColumnKeyException(string columnKey)
		{
			base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				throw new global::Infragistics.Controls.Grids.InvalidColumnKeyException(columnKey);
			}), new object[0]);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x0005A6F0 File Offset: 0x000588F0
		internal virtual bool ShouldAddColumnLayouts(global::Infragistics.Controls.Grids.ColumnLayout columnLayout)
		{
			return true;
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0005A6F3 File Offset: 0x000588F3
		internal virtual global::System.Windows.Style GetToolTipStyle(global::Infragistics.Controls.Grids.Column column)
		{
			return column.ToolTipStyle;
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0005A7A4 File Offset: 0x000589A4
		internal void DeleteKey()
		{
			if (this.CurrentEditCell == null && this.CurrentEditRow == null)
			{
				global::Infragistics.Controls.Grids.Cell prevActiveCell = this.ActiveCell as global::Infragistics.Controls.Grids.Cell;
				int newActiveCellRowIndex = 0;
				int newActiveCellIndex = 0;
				bool flag = false;
				bool flag2 = false;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.RowsManager, global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row>> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.RowsManager, global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row>>();
				global::Infragistics.Controls.Grids.SelectedCellsCollection selectedCells = this.SelectionSettings.SelectedCells;
				global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRows = this.SelectionSettings.SelectedRows;
				if (selectedCells.Count > 0)
				{
					foreach (global::Infragistics.Controls.Grids.Cell cell in selectedCells)
					{
						global::Infragistics.Controls.Grids.Row row = cell.Row as global::Infragistics.Controls.Grids.Row;
						if (row != null)
						{
							global::Infragistics.Controls.Grids.RowsManager key = (global::Infragistics.Controls.Grids.RowsManager)row.Manager;
							if (!dictionary.ContainsKey(key))
							{
								dictionary.Add(key, new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Row>());
							}
							global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row> list = dictionary[key];
							if ((row.ColumnLayout.DeleteKeyActionResolved == global::Infragistics.Controls.Grids.DeleteKeyAction.DeleteRowsOfSelectedCells || row.ColumnLayout.DeleteKeyActionResolved == global::Infragistics.Controls.Grids.DeleteKeyAction.DeleteRowsOfSelectedCellsAndRows) && !list.Contains(row) && row.CanBeDeleted)
							{
								list.Add(row);
								flag = true;
							}
						}
					}
				}
				if (selectedRows.Count > 0)
				{
					foreach (global::Infragistics.Controls.Grids.Row row2 in selectedRows)
					{
						global::Infragistics.Controls.Grids.RowsManager key2 = (global::Infragistics.Controls.Grids.RowsManager)row2.Manager;
						if (!dictionary.ContainsKey(key2))
						{
							dictionary.Add(key2, new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Row>());
						}
						global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row> list2 = dictionary[key2];
						if ((row2.ColumnLayout.DeleteKeyActionResolved == global::Infragistics.Controls.Grids.DeleteKeyAction.DeleteSelectedRows || row2.ColumnLayout.DeleteKeyActionResolved == global::Infragistics.Controls.Grids.DeleteKeyAction.DeleteRowsOfSelectedCellsAndRows) && !list2.Contains(row2) && row2.CanBeDeleted)
						{
							list2.Add(row2);
							flag2 = true;
						}
					}
				}
				if (prevActiveCell != null)
				{
					newActiveCellRowIndex = global::Infragistics.Controls.Grids.Cell.ResolveRowIndex(this.ActiveCell.Row, false);
					newActiveCellIndex = this.ActiveCell.Row.VisibleCells.IndexOf(this.ActiveCell);
					if (this.ActiveCell.Row.ColumnLayout.DeleteKeyActionResolved == global::Infragistics.Controls.Grids.DeleteKeyAction.DeleteRowOfActiveCell)
					{
						global::Infragistics.Controls.Grids.Row row3 = this.ActiveCell.Row as global::Infragistics.Controls.Grids.Row;
						if (row3 != null)
						{
							global::Infragistics.Controls.Grids.RowsManager key3 = (global::Infragistics.Controls.Grids.RowsManager)row3.Manager;
							if (!dictionary.ContainsKey(key3))
							{
								dictionary.Add(key3, new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Row>());
							}
							global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row> list3 = dictionary[key3];
							if (!list3.Contains(row3) && row3.CanBeDeleted)
							{
								list3.Add(row3);
								this.ActiveCell = null;
							}
						}
					}
				}
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Grids.RowsManager, global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row>> keyValuePair in dictionary)
				{
					((global::Infragistics.Controls.Grids.RowCollection)keyValuePair.Key.Rows.ActualCollection).RemoveRange(keyValuePair.Value);
				}
				if (flag)
				{
					selectedCells.Clear();
				}
				if (flag2)
				{
					selectedRows.Clear();
				}
				if (this.ActiveCell == null && prevActiveCell != null)
				{
					base.UpdateLayout();
					base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						global::Infragistics.Controls.Grids.RowBase rowBase = global::Infragistics.Controls.Grids.Cell.ResolveRow(prevActiveCell.Row, newActiveCellRowIndex, true, global::Infragistics.Controls.Grids.KeyboardNavigation.AllLayouts);
						if (rowBase != null)
						{
							global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = rowBase.VisibleCells;
							if (newActiveCellIndex < visibleCells.Count)
							{
								this.ActiveCell = visibleCells[newActiveCellIndex];
								return;
							}
							foreach (global::Infragistics.Controls.Grids.CellBase cellBase in visibleCells)
							{
								if (cellBase is global::Infragistics.Controls.Grids.Cell)
								{
									this.ActiveCell = cellBase;
									break;
								}
							}
						}
					}), new object[0]);
				}
			}
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0005AB0C File Offset: 0x00058D0C
		public static void RegisterResources(string name, global::System.Reflection.Assembly assembly)
		{
			global::SR.AddResource(name, assembly);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0005AB15 File Offset: 0x00058D15
		public static void UnregisterResources(string name)
		{
			global::SR.RemoveResource(name);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0005AB20 File Offset: 0x00058D20
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			if (e.OriginalSource == sender && e.TargetRect.IsEmpty)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0005AB4D File Offset: 0x00058D4D
		private void HorizontalScrollbar_Scroll(object sender, global::System.Windows.Controls.Primitives.ScrollEventArgs e)
		{
			this.InvalidateScrollPanel(true, false, false, null, false);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0005AB5C File Offset: 0x00058D5C
		private void VerticalScrollbar_Scroll(object sender, global::System.Windows.Controls.Primitives.ScrollEventArgs e)
		{
			if (e.ScrollEventType != global::System.Windows.Controls.Primitives.ScrollEventType.ThumbTrack || this.DeferredScrollingSettings.AllowDeferredScrolling == global::Infragistics.Controls.Grids.DeferredScrollingType.None)
			{
				if (this._deferredPopup != null && this._deferredPopup.IsOpen)
				{
					if (!global::Infragistics.CoreUtilities.AreClose(this._verticalScrollbar.Value, this._verticalScrollbar.Maximum))
					{
						this._verticalScrollbar.Value = (double)((int)this._verticalScrollbar.Value);
					}
					this._deferredPopup.IsOpen = false;
				}
				this.InvalidateScrollPanel(false);
				return;
			}
			if (this._deferredPopup == null)
			{
				this._deferredPopup = new global::System.Windows.Controls.Primitives.Popup();
				this._deferredContentControl = new global::System.Windows.Controls.ContentControl();
				this._deferredPopup.Child = this._deferredContentControl;
				this._deferredContentControl.HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Center;
				this._deferredContentControl.VerticalContentAlignment = global::System.Windows.VerticalAlignment.Center;
				this._deferredPopup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
				this._deferredPopup.PlacementTarget = this.Panel;
				this._deferredPopup.AllowsTransparency = true;
			}
			global::Infragistics.Controls.Grids.RowBase rowBase = this.InternalRows[(int)this.VerticalScrollBar.Value];
			if (rowBase != null)
			{
				global::System.Windows.DataTemplate dataTemplate = null;
				if (rowBase.RowType == global::Infragistics.Controls.Grids.RowType.GroupByRow)
				{
					dataTemplate = rowBase.ColumnLayout.DeferredScrollingSettings.GroupByDeferredScrollTemplateResolved;
					if (dataTemplate == null)
					{
						dataTemplate = this._defaultGroupByDeferredScrollingTemplate;
					}
				}
				else if (rowBase.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
				{
					dataTemplate = rowBase.ColumnLayout.DeferredScrollingSettings.DeferredScrollTemplateResolved;
					if (dataTemplate == null)
					{
						dataTemplate = this._defaultDeferredScrollingTemplate;
					}
				}
				if (dataTemplate != null)
				{
					global::System.Windows.FrameworkElement frameworkElement = dataTemplate.LoadContent() as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						global::Infragistics.ScrollTipInfo scrollTipInfo = new global::Infragistics.ScrollTipInfo
						{
							Row = rowBase
						};
						string text = rowBase.ColumnLayout.DeferredScrollingSettings.DefaultColumnKeyResolved;
						if (text == null && rowBase.Columns.VisibleColumns.Count > 0)
						{
							global::Infragistics.Controls.Grids.Column column = rowBase.Columns.VisibleColumns[0];
							global::Infragistics.ICollectionBase collectionBase = column.ResolveChildColumns();
							while (collectionBase != null && collectionBase.Count > 0)
							{
								foreach (object obj in collectionBase)
								{
									global::Infragistics.Controls.Grids.Column column2 = (global::Infragistics.Controls.Grids.Column)obj;
									if (column2.Visibility == global::System.Windows.Visibility.Visible)
									{
										column = column2;
										break;
									}
								}
								collectionBase = column.ResolveChildColumns();
							}
							text = column.Key;
						}
						if (rowBase.RowType == global::Infragistics.Controls.Grids.RowType.GroupByRow)
						{
							global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
							binding.Source = rowBase.Data;
							scrollTipInfo.SetBinding(global::Infragistics.ScrollTipInfo.FirstColumnValueProperty, binding);
							scrollTipInfo.Column = ((global::Infragistics.Controls.Grids.RowsManager)rowBase.Manager).GroupedColumn;
						}
						else if (text != null)
						{
							global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding(text);
							binding2.Source = rowBase.Data;
							scrollTipInfo.SetBinding(global::Infragistics.ScrollTipInfo.FirstColumnValueProperty, binding2);
							scrollTipInfo.Column = (rowBase.ColumnLayout.Columns[text] as global::Infragistics.Controls.Grids.Column);
						}
						frameworkElement.DataContext = scrollTipInfo;
						this._deferredContentControl.Content = frameworkElement;
						global::System.Windows.Point point = this.Panel.TransformToVisual(this).Transform(new global::System.Windows.Point(0.0, 0.0));
						double num = 0.0;
						foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in this.Panel.FixedRowsTop)
						{
							num += rowBase2.ActualHeight;
						}
						frameworkElement.Height = this.Panel.ActualHeight - num;
						frameworkElement.Width = this.Panel.ActualWidth;
						this._deferredPopup.VerticalOffset = point.Y + num;
						this._deferredPopup.HorizontalOffset = point.X;
						this._deferredPopup.FlowDirection = base.FlowDirection;
						this._deferredPopup.IsOpen = true;
					}
				}
			}
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0005AF2C File Offset: 0x0005912C
		private void SelectRowsCellsTimer_Tick(object sender, global::System.EventArgs e)
		{
			if (!this.OnOutsideDrag(this._dragSelectType, this._mousePosition))
			{
				this._selectRowsCellsTimer.Stop();
			}
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0005AF50 File Offset: 0x00059150
		internal bool OnOutsideDrag(global::Infragistics.Controls.Grids.DragSelectType dragSelect, global::System.Windows.Point mousePosition)
		{
			global::System.Windows.Rect rect = global::System.Windows.Rect.Empty;
			try
			{
				global::System.Windows.Media.GeneralTransform generalTransform = this._panel.TransformToVisual(this);
				global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this._panel);
				rect = generalTransform.TransformBounds(layoutSlot);
			}
			catch (global::System.ArgumentException)
			{
			}
			if (rect.IsEmpty)
			{
				return false;
			}
			double y = rect.Y;
			double num = y + this._panel.ActualHeight;
			double num2 = rect.X;
			double num3 = num2 + this._panel.ActualWidth;
			double num4 = mousePosition.Y;
			if (num4 < y)
			{
				num4 = y;
				using (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase>.Enumerator enumerator = this._panel.FixedRowsTop.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Infragistics.Controls.Grids.RowBase rowBase = enumerator.Current;
						if (rowBase.Control != null)
						{
							num4 += rowBase.Control.ActualHeight + 2.0;
						}
					}
					goto IL_136;
				}
			}
			if (num4 > num)
			{
				num4 = num - 1.0;
				foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in this._panel.FixedRowsBottom)
				{
					if (rowBase2.Control != null)
					{
						num4 -= rowBase2.Control.ActualHeight;
					}
				}
			}
			IL_136:
			global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(new global::System.Windows.Point(num2, num4), this._panel);
			global::Infragistics.Controls.Grids.Primitives.CellsPanel cellsPanel = null;
			foreach (global::System.Windows.UIElement uielement in elementsFromPoint)
			{
				cellsPanel = (uielement as global::Infragistics.Controls.Grids.Primitives.CellsPanel);
				if (cellsPanel != null)
				{
					break;
				}
			}
			if (cellsPanel != null)
			{
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase in cellsPanel.VisibleFixedLeftCells)
				{
					if (cellBase.Control != null)
					{
						global::Infragistics.Controls.Grids.Column column = cellBase.Column;
						if (column == null || (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.NotFixed && !column.IsGroupBy))
						{
							num2 += cellBase.Control.ActualWidth + 2.0;
						}
					}
				}
				global::Infragistics.Controls.Grids.RowBase row = cellsPanel.Row;
				global::Infragistics.Controls.Grids.CellBase cellBase2 = row.Cells[row.ColumnLayout.Columns.FillerColumn];
				if (cellsPanel.VisibleCells.Contains(cellBase2))
				{
					num3 -= cellBase2.Column.ActualWidth;
				}
			}
			double num5 = mousePosition.X;
			if (num5 < num2)
			{
				num5 = num2;
			}
			else if (num5 > num3)
			{
				num5 = num3 - 1.0;
			}
			if ((dragSelect == global::Infragistics.Controls.Grids.DragSelectType.Cell || dragSelect == global::Infragistics.Controls.Grids.DragSelectType.Column) && this._horizontalScrollbar != null && this._horizontalScrollbar.Visibility == global::System.Windows.Visibility.Visible)
			{
				if (mousePosition.X < num2)
				{
					this._horizontalScrollbar.Value -= 1.0;
				}
				else if (mousePosition.X > num3)
				{
					this._horizontalScrollbar.Value += 1.0;
				}
			}
			if (this._verticalScrollbar != null && dragSelect != global::Infragistics.Controls.Grids.DragSelectType.Column)
			{
				if (mousePosition.Y < y)
				{
					this._verticalScrollbar.Value -= 1.0;
				}
				else if (mousePosition.Y > num)
				{
					this._verticalScrollbar.Value += 1.0;
				}
			}
			elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(new global::System.Windows.Point(num5, num4), this._panel);
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = null;
			foreach (global::System.Windows.UIElement uielement2 in elementsFromPoint)
			{
				cellControlBase = (uielement2 as global::Infragistics.Controls.Grids.CellControl);
				if (cellControlBase != null && cellControlBase.Cell != null && !(cellControlBase.Cell.Column is global::Infragistics.Controls.Grids.Primitives.FillerColumn))
				{
					break;
				}
			}
			if (cellControlBase != null && cellControlBase.Cell != null)
			{
				if (dragSelect == global::Infragistics.Controls.Grids.DragSelectType.Cell)
				{
					this.SelectCell(cellControlBase.Cell as global::Infragistics.Controls.Grids.Cell, global::Infragistics.Controls.Grids.XamGrid.GetMovedAction());
				}
				else if (dragSelect == global::Infragistics.Controls.Grids.DragSelectType.Row)
				{
					this.SelectRow(cellControlBase.Cell.Row as global::Infragistics.Controls.Grids.Row, global::Infragistics.Controls.Grids.XamGrid.GetMovedAction());
				}
				else
				{
					this.SelectColumn(cellControlBase.Cell.Column, global::Infragistics.Controls.Grids.XamGrid.GetMovedAction());
				}
			}
			this.InvalidateScrollPanel(false);
			return true;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0005B3BC File Offset: 0x000595BC
		private void XamGrid_KeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (this._tabMode != null)
			{
				global::Infragistics.PlatformProxy.SetTabNavigation(this, this._tabMode.Value);
			}
			if (e.Handled)
			{
				return;
			}
			if (e.Key == global::System.Windows.Input.Key.Tab || e.Key == global::System.Windows.Input.Key.Down || e.Key == global::System.Windows.Input.Key.Up || e.Key == global::System.Windows.Input.Key.Left || e.Key == global::System.Windows.Input.Key.Right || e.Key == global::System.Windows.Input.Key.Next || e.Key == global::System.Windows.Input.Key.Prior)
			{
				if (this._lastKeyboardObject != null && e.OriginalSource == this._lastKeyboardObject.Target)
				{
					return;
				}
				for (global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject; dependencyObject != null; dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject))
				{
					if (dependencyObject is global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl)
					{
						this._lastKeyboardObject = new global::System.WeakReference(dependencyObject);
						return;
					}
					if (dependencyObject is global::Infragistics.Controls.Menus.XamMenuItem)
					{
						this._lastKeyboardObject = new global::System.WeakReference(dependencyObject);
						return;
					}
					if (dependencyObject is global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl)
					{
						this._lastKeyboardObject = new global::System.WeakReference(dependencyObject);
						return;
					}
				}
			}
			this._lastKeyboardObject = null;
			if (this.CurrentEditCell != null)
			{
				e.Handled = this.CurrentEditCell.HandleKeyDown(e.Key, 0);
			}
			else if (this.ActiveCell != null)
			{
				e.Handled = this.ActiveCell.HandleKeyDown(e.Key, 0);
			}
			if (e.Key == global::System.Windows.Input.Key.Tab && !e.Handled)
			{
				this._tabMode = new global::System.Windows.Input.KeyboardNavigationMode?(global::Infragistics.PlatformProxy.GetTabNavigation(this));
				global::Infragistics.PlatformProxy.SetTabNavigation(this, global::System.Windows.Input.KeyboardNavigationMode.Once);
			}
			if (!e.Handled)
			{
				global::System.Windows.Input.Key key = e.Key;
				if (key <= global::System.Windows.Input.Key.Delete)
				{
					switch (key)
					{
					case global::System.Windows.Input.Key.Prior:
						if (this.Panel != null && this.Panel.VisibleRows.Count > 0)
						{
							int num = this.InternalRows.IndexOf(this.Panel.VisibleRows[0]);
							global::Infragistics.Controls.Grids.RowBase rowBase = this.InternalRows[num];
							double num2 = this.VerticalScrollBar.LargeChange;
							bool flag = false;
							if (rowBase != null && rowBase.Control != null)
							{
								global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(rowBase.Control);
								double num3 = 0.0;
								foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in this.Panel.FixedRowsTop)
								{
									if (rowBase2.Control != null)
									{
										num3 += global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(rowBase2.Control).Height;
									}
								}
								if (layoutSlot.Top - num3 < 0.0)
								{
									num2 -= 1.0;
									flag = true;
								}
							}
							if (this.ActiveCell != null)
							{
								global::Infragistics.Controls.Grids.RowBase rowBase3 = rowBase;
								if (flag && num + 1 <= this.InternalRows.Count - 1)
								{
									rowBase3 = this.InternalRows[num + 1];
								}
								global::Infragistics.Controls.Grids.RowBase row = this.ActiveCell.Row;
								if (rowBase3 != null && row != rowBase3 && row.RowType == rowBase3.RowType)
								{
									int indexOfFirst = this.InternalRows.IndexOf(rowBase3);
									int indexOfLast = this.InternalRows.IndexOf(this.Panel.VisibleRows[this.Panel.VisibleRows.Count - 1]);
									if (this.PageUpActivateCellInRowRange(indexOfFirst, indexOfLast))
									{
										return;
									}
								}
							}
							double num4 = this.VerticalScrollBar.Value - num2;
							num4 = global::System.Math.Max(num4, this.VerticalScrollBar.Minimum);
							this.VerticalScrollBar.Value = num4;
							this.InvalidateScrollPanel(false, false, false, new global::Infragistics.Controls.Grids.EmptyDelegate(this.PageUpCallback), true);
							return;
						}
						break;
					case global::System.Windows.Input.Key.Next:
						if (this.Panel != null && this.Panel.VisibleRows.Count > 0)
						{
							int num5 = this.InternalRows.IndexOf(this.Panel.VisibleRows[this.Panel.VisibleRows.Count - 1]);
							global::Infragistics.Controls.Grids.RowBase rowBase4 = this.InternalRows[num5];
							double num6 = this.VerticalScrollBar.LargeChange;
							bool flag2 = false;
							if (rowBase4 != null && rowBase4.Control != null)
							{
								global::System.Windows.Rect layoutSlot2 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this.Panel);
								global::System.Windows.Rect layoutSlot3 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(rowBase4.Control);
								double num7 = 0.0;
								foreach (global::Infragistics.Controls.Grids.RowBase rowBase5 in this.Panel.FixedRowsBottom)
								{
									if (rowBase5.Control != null)
									{
										num7 += global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(rowBase5.Control).Height;
									}
								}
								if (layoutSlot3.Height + layoutSlot3.Top + num7 > layoutSlot2.Height)
								{
									num6 -= 1.0;
									flag2 = true;
								}
							}
							if (this.ActiveCell != null)
							{
								global::Infragistics.Controls.Grids.RowBase rowBase6 = rowBase4;
								if (flag2 && num5 - 1 >= 0)
								{
									rowBase6 = this.InternalRows[num5 - 1];
								}
								global::Infragistics.Controls.Grids.RowBase row2 = this.ActiveCell.Row;
								if (rowBase6 != null && row2 != rowBase6 && row2.RowType == rowBase6.RowType)
								{
									int indexOfFirst2 = this.InternalRows.IndexOf(this.Panel.VisibleRows[0]);
									int indexOfLast2 = this.InternalRows.IndexOf(rowBase6);
									if (this.PageDownActivateCellInRowRange(indexOfFirst2, indexOfLast2))
									{
										return;
									}
								}
							}
							double num8 = this.VerticalScrollBar.Value + num6;
							num8 = global::System.Math.Min(num8, this.VerticalScrollBar.Maximum);
							this.VerticalScrollBar.Value = num8;
							this.InvalidateScrollPanel(false, false, false, new global::Infragistics.Controls.Grids.EmptyDelegate(this.PageDownCallback), true);
							return;
						}
						break;
					default:
						if (key != global::System.Windows.Input.Key.Delete)
						{
							return;
						}
						this.DeleteKey();
						return;
					}
				}
				else if (key != global::System.Windows.Input.Key.C)
				{
					if (key != global::System.Windows.Input.Key.V)
					{
						return;
					}
					global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
					bool flag3 = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
					if (flag3 && this.ClipboardSettings.AllowPaste)
					{
						this.PasteFromClipboard();
					}
				}
				else
				{
					global::System.Windows.Input.ModifierKeys currentModifierKeys2 = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
					bool flag4 = (currentModifierKeys2 & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
					if (flag4 && this.ClipboardSettings.AllowCopy)
					{
						this.CopyToClipboard();
						return;
					}
				}
			}
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0005B9C4 File Offset: 0x00059BC4
		private void XamGrid_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._mouseCaptured != null)
			{
				this._mouseCaptured.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.XamGrid_MouseLeftButtonUp));
				this._mouseCaptured = null;
			}
			this.OnGridMouseLeftButtonUp(e);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0005B9F8 File Offset: 0x00059BF8
		internal virtual void OnGridMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.EndSelectionDrag(false);
			if (this._mouseDownCell != null)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = null;
				global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(e.GetPosition(this), this);
				foreach (global::System.Windows.UIElement uielement in elementsFromPoint)
				{
					global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase2 = uielement as global::Infragistics.Controls.Grids.Primitives.CellControlBase;
					if (cellControlBase2 != null && !(cellControlBase2 is global::Infragistics.Controls.Grids.Primitives.GroupCellControl))
					{
						cellControlBase = cellControlBase2;
						break;
					}
				}
				if (cellControlBase != null && cellControlBase.Cell == this._mouseDownCell)
				{
					this._mouseDownCell.OnCellClick(e);
				}
				this._mouseDownCell = null;
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0005BA98 File Offset: 0x00059C98
		private void XamGrid_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.OnGridMouseLeftButtonDown(e);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0005BB04 File Offset: 0x00059D04
		internal virtual void OnGridMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellFromSource = this.GetCellFromSource(e.OriginalSource as global::System.Windows.DependencyObject);
			if (!e.Handled)
			{
				base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					if (this.CurrentEditCell == null || !global::Infragistics.Controls.PresentationUtilities.HasFocus(this.CurrentEditCell.Control))
					{
						base.Focus();
					}
				}), new object[0]);
			}
			bool flag = false;
			long ticks = global::System.DateTime.Now.Ticks;
			if (cellFromSource != null && cellFromSource.Cell != null)
			{
				if (ticks - this._doubleClickTimeStamp <= 4000000L && cellFromSource.Cell == this._doubleClickCell)
				{
					flag = true;
				}
				this._doubleClickTimeStamp = global::System.DateTime.Now.Ticks;
				global::Infragistics.Controls.Grids.Cell cell = cellFromSource.Cell as global::Infragistics.Controls.Grids.Cell;
				if (flag)
				{
					if (cell == null || !cell.IsEditing)
					{
						cellFromSource.Cell.OnCellDoubleClick();
					}
					e.Handled = true;
					this._doubleClickCell = (this._mouseDownCell = null);
					return;
				}
				if (cell == null || !cell.IsEditing)
				{
					if (cell is global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateCell)
					{
						if (!cell.IsSelected)
						{
							cellFromSource.Cell.OnCellMouseDown(e);
						}
						this._dragSelectType = global::Infragistics.Controls.Grids.DragSelectType.None;
					}
					else
					{
						global::Infragistics.Controls.Grids.CustomDisplayEditableColumn customDisplayEditableColumn = cellFromSource.Cell.Column as global::Infragistics.Controls.Grids.CustomDisplayEditableColumn;
						if (customDisplayEditableColumn == null || (cell != null && !cell.EnableCustomEditorBehaviors) || customDisplayEditableColumn.EditorDisplayBehavior != global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always)
						{
							bool handled = e.Handled;
							this._dragSelectType = global::Infragistics.Controls.Grids.DragSelectType.None;
							this._doubleClickCell = (this._mouseDownCell = cellFromSource.Cell);
							global::Infragistics.Controls.Grids.DragSelectType dragSelectType = cellFromSource.Cell.OnCellMouseDown(e);
							if (dragSelectType != global::Infragistics.Controls.Grids.DragSelectType.None && !cellFromSource.IsResizing && !handled)
							{
								base.LostMouseCapture += delegate(object sender, global::System.Windows.Input.MouseEventArgs args)
								{
									this._mouseCaptured = (global::System.Windows.Input.Mouse.Captured as global::System.Windows.UIElement);
									if (this._mouseCaptured != null && this._mouseCaptured != this)
									{
										this._mouseCaptured.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.XamGrid_MouseLeftButtonUp), true);
									}
								};
								base.CaptureMouse();
							}
							this._dragSelectType = dragSelectType;
						}
					}
				}
				if (this.EditingSettings.AllowEditing == global::Infragistics.Controls.Grids.EditingType.Hover && cell != null && cell.IsEditing && !cell.IsActive)
				{
					this.SetActiveCell(cell, global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Click, false);
					return;
				}
				if (cell != null && cell.SupportsActivation && !cell.IsActive && cell.EnableCustomEditorBehaviors)
				{
					global::Infragistics.Controls.Grids.CustomDisplayEditableColumn customDisplayEditableColumn2 = cell.Column as global::Infragistics.Controls.Grids.CustomDisplayEditableColumn;
					if (customDisplayEditableColumn2 != null && customDisplayEditableColumn2.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always)
					{
						this.SetActiveCell(cell, global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Click, true);
						return;
					}
				}
			}
			else
			{
				this._doubleClickCell = (this._mouseDownCell = null);
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0005BD3C File Offset: 0x00059F3C
		private void RootVis_CellEditing_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellFromSource = this.GetCellFromSource(e.OriginalSource as global::System.Windows.DependencyObject);
			if (cellFromSource == null || cellFromSource.Cell == null || this.CurrentEditCell != cellFromSource.Cell)
			{
				this.ExitEditMode(false);
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0005BD7C File Offset: 0x00059F7C
		private void RootVis_RowEditing_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellFromSource = this.GetCellFromSource(e.OriginalSource as global::System.Windows.DependencyObject);
			if (cellFromSource == null)
			{
				global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
				while (dependencyObject != null && dependencyObject != this.HorizontalScrollBar)
				{
					dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject);
				}
				if (dependencyObject == this.HorizontalScrollBar)
				{
					return;
				}
			}
			if (cellFromSource == null || cellFromSource.Cell == null || this.CurrentEditRow != cellFromSource.Cell.Row)
			{
				this.ExitEditMode(false);
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0005BDEF File Offset: 0x00059FEF
		private void XamGrid_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (!this._isLoaded)
			{
				this.LoadData();
			}
			if (this._panel != null && this._panel.VisibleRows.Count == 0)
			{
				this.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0005BE20 File Offset: 0x0005A020
		private void XamGrid_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Unload();
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0005BE28 File Offset: 0x0005A028
		private void ColumnLayouts_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
						columnLayout.Grid = this;
					}
					return;
				}
			}
			if (e.OldItems != null)
			{
				foreach (object obj2 in e.OldItems)
				{
					global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 = (global::Infragistics.Controls.Grids.ColumnLayout)obj2;
					columnLayout2.OnColumnLayoutDisposing();
					columnLayout2.Grid = null;
				}
			}
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0005BEE8 File Offset: 0x0005A0E8
		private void ConditionalFormattingSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.RowsManager.ColumnLayout.ClearCachedRows();
			this.ResetPanelRows(true);
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x0005BF01 File Offset: 0x0005A101
		global::System.Windows.Controls.Primitives.ScrollBar global::Infragistics.IProvideScrollInfo.VerticalScrollBar
		{
			get
			{
				return this.VerticalScrollBar;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x0005BF09 File Offset: 0x0005A109
		global::System.Windows.Controls.Primitives.ScrollBar global::Infragistics.IProvideScrollInfo.HorizontalScrollBar
		{
			get
			{
				return this.HorizontalScrollBar;
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0005BF14 File Offset: 0x0005A114
		protected virtual void Dispose(bool disposing)
		{
			if (this._internalRows != null)
			{
				this._internalRows.Dispose();
			}
			if (this._rowsManager != null)
			{
				this._rowsManager.Dispose();
			}
			if (this._selectionSettings != null)
			{
				this._selectionSettings.Dispose();
			}
			if (this._columnTypeMappings != null)
			{
				this._columnTypeMappings.Dispose();
			}
			if (this._columnLayouts != null)
			{
				this._columnLayouts.Dispose();
			}
			if (this._groupBySettings != null)
			{
				this._groupBySettings.Dispose();
			}
			if (this._columnLayouts != null)
			{
				this._columnLayouts.CollectionChanged -= this.ColumnLayouts_CollectionChanged;
			}
			if (this._summaryRowSettings != null)
			{
				this._summaryRowSettings.Dispose();
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0005BFC5 File Offset: 0x0005A1C5
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06001748 RID: 5960 RVA: 0x0005BFD4 File Offset: 0x0005A1D4
		// (remove) Token: 0x06001749 RID: 5961 RVA: 0x0005C00C File Offset: 0x0005A20C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600174A RID: 5962 RVA: 0x0005C041 File Offset: 0x0005A241
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600174B RID: 5963 RVA: 0x0005C060 File Offset: 0x0005A260
		// (remove) Token: 0x0600174C RID: 5964 RVA: 0x0005C098 File Offset: 0x0005A298
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CancellablePageChangingEventArgs> PageIndexChanging;

		// Token: 0x0600174D RID: 5965 RVA: 0x0005C0D0 File Offset: 0x0005A2D0
		protected internal virtual bool OnPageIndexChanging(int newPageIndex, int level, global::Infragistics.Controls.Grids.RowCollection rows, global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			if (this.PageIndexChanging != null)
			{
				global::Infragistics.Controls.Grids.CancellablePageChangingEventArgs cancellablePageChangingEventArgs = new global::Infragistics.Controls.Grids.CancellablePageChangingEventArgs
				{
					NextPageIndex = newPageIndex,
					ColumnLayout = layout,
					Rows = rows,
					Level = level
				};
				this.PageIndexChanging(this, cancellablePageChangingEventArgs);
				return cancellablePageChangingEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600174E RID: 5966 RVA: 0x0005C120 File Offset: 0x0005A320
		// (remove) Token: 0x0600174F RID: 5967 RVA: 0x0005C158 File Offset: 0x0005A358
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.PageChangedEventArgs> PageIndexChanged;

		// Token: 0x06001750 RID: 5968 RVA: 0x0005C190 File Offset: 0x0005A390
		protected internal virtual void OnPageIndexChanged(int oldPageIndex)
		{
			if (this.PageIndexChanged != null)
			{
				global::Infragistics.Controls.Grids.PageChangedEventArgs e = new global::Infragistics.Controls.Grids.PageChangedEventArgs
				{
					OldPageIndex = oldPageIndex
				};
				this.PageIndexChanged(this, e);
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06001751 RID: 5969 RVA: 0x0005C1C4 File Offset: 0x0005A3C4
		// (remove) Token: 0x06001752 RID: 5970 RVA: 0x0005C1FC File Offset: 0x0005A3FC
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.SortingCancellableEventArgs> ColumnSorting;

		// Token: 0x06001753 RID: 5971 RVA: 0x0005C234 File Offset: 0x0005A434
		protected internal virtual bool OnColumnSorting(global::Infragistics.Controls.Grids.Column sortedColumn, global::Infragistics.Controls.Grids.SortDirection sortDirection)
		{
			if (this.ColumnSorting != null)
			{
				global::Infragistics.Controls.Grids.SortingCancellableEventArgs sortingCancellableEventArgs = new global::Infragistics.Controls.Grids.SortingCancellableEventArgs
				{
					Column = sortedColumn,
					NewSortDirection = sortDirection,
					PreviousSortDirection = sortedColumn.IsSorted
				};
				this.ColumnSorting(this, sortingCancellableEventArgs);
				return sortingCancellableEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06001754 RID: 5972 RVA: 0x0005C280 File Offset: 0x0005A480
		// (remove) Token: 0x06001755 RID: 5973 RVA: 0x0005C2B8 File Offset: 0x0005A4B8
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.SortedColumnEventArgs> ColumnSorted;

		// Token: 0x06001756 RID: 5974 RVA: 0x0005C2F0 File Offset: 0x0005A4F0
		protected internal virtual void OnColumnSorted(global::Infragistics.Controls.Grids.Column sortedColumn, global::Infragistics.Controls.Grids.SortDirection sortDirection)
		{
			if (this.ColumnSorted != null)
			{
				this.ColumnSorted(this, new global::Infragistics.Controls.Grids.SortedColumnEventArgs
				{
					Column = sortedColumn,
					PreviousSortDirection = sortDirection
				});
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06001757 RID: 5975 RVA: 0x0005C328 File Offset: 0x0005A528
		// (remove) Token: 0x06001758 RID: 5976 RVA: 0x0005C360 File Offset: 0x0005A560
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ActiveCellChangingEventArgs> ActiveCellChanging;

		// Token: 0x06001759 RID: 5977 RVA: 0x0005C395 File Offset: 0x0005A595
		protected internal virtual void OnActiveCellChanging(global::Infragistics.Controls.Grids.ActiveCellChangingEventArgs e)
		{
			if (this.ActiveCellChanging != null)
			{
				this.ActiveCellChanging(this, e);
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600175A RID: 5978 RVA: 0x0005C3AC File Offset: 0x0005A5AC
		// (remove) Token: 0x0600175B RID: 5979 RVA: 0x0005C3E4 File Offset: 0x0005A5E4
		public event global::System.EventHandler<global::System.EventArgs> ActiveCellChanged;

		// Token: 0x0600175C RID: 5980 RVA: 0x0005C419 File Offset: 0x0005A619
		protected internal virtual void OnActiveCellChanged()
		{
			if (this.ActiveCellChanged != null)
			{
				this.ActiveCellChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600175D RID: 5981 RVA: 0x0005C434 File Offset: 0x0005A634
		// (remove) Token: 0x0600175E RID: 5982 RVA: 0x0005C46C File Offset: 0x0005A66C
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.SelectionCollectionChangedEventArgs<global::Infragistics.Controls.Grids.SelectedCellsCollection>> SelectedCellsCollectionChanged;

		// Token: 0x0600175F RID: 5983 RVA: 0x0005C4A4 File Offset: 0x0005A6A4
		protected internal virtual void OnSelectedCellsCollectionChanged(global::Infragistics.Controls.Grids.SelectedCellsCollection previouslySelectedCells, global::Infragistics.Controls.Grids.SelectedCellsCollection newSelectedCells)
		{
			if (this.SelectedCellsCollectionChanged != null)
			{
				bool flag = false;
				if (previouslySelectedCells.Count != newSelectedCells.Count)
				{
					flag = true;
				}
				else
				{
					foreach (global::Infragistics.Controls.Grids.Cell item in previouslySelectedCells)
					{
						if (!newSelectedCells.Contains(item))
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					this.SelectedCellsCollectionChanged(this, new global::Infragistics.Controls.Grids.SelectionCollectionChangedEventArgs<global::Infragistics.Controls.Grids.SelectedCellsCollection>
					{
						NewSelectedItems = newSelectedCells,
						PreviouslySelectedItems = previouslySelectedCells
					});
				}
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06001760 RID: 5984 RVA: 0x0005C534 File Offset: 0x0005A734
		// (remove) Token: 0x06001761 RID: 5985 RVA: 0x0005C56C File Offset: 0x0005A76C
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.SelectionCollectionChangedEventArgs<global::Infragistics.Controls.Grids.SelectedRowsCollection>> SelectedRowsCollectionChanged;

		// Token: 0x06001762 RID: 5986 RVA: 0x0005C5A4 File Offset: 0x0005A7A4
		protected internal virtual void OnSelectedRowsCollectionChanged(global::Infragistics.Controls.Grids.SelectedRowsCollection previouslySelectedRows, global::Infragistics.Controls.Grids.SelectedRowsCollection newSelectedRows)
		{
			if (this.SelectedRowsCollectionChanged != null)
			{
				bool flag = false;
				if (previouslySelectedRows.Count != newSelectedRows.Count)
				{
					flag = true;
				}
				else
				{
					foreach (global::Infragistics.Controls.Grids.Row item in previouslySelectedRows)
					{
						if (!newSelectedRows.Contains(item))
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					this.SelectedRowsCollectionChanged(this, new global::Infragistics.Controls.Grids.SelectionCollectionChangedEventArgs<global::Infragistics.Controls.Grids.SelectedRowsCollection>
					{
						NewSelectedItems = newSelectedRows,
						PreviouslySelectedItems = previouslySelectedRows
					});
				}
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06001763 RID: 5987 RVA: 0x0005C634 File Offset: 0x0005A834
		// (remove) Token: 0x06001764 RID: 5988 RVA: 0x0005C66C File Offset: 0x0005A86C
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.SelectionCollectionChangedEventArgs<global::Infragistics.Controls.Grids.SelectedColumnsCollection>> SelectedColumnsCollectionChanged;

		// Token: 0x06001765 RID: 5989 RVA: 0x0005C6A4 File Offset: 0x0005A8A4
		protected internal virtual void OnSelectedColumnsCollectionChanged(global::Infragistics.Controls.Grids.SelectedColumnsCollection previouslySelectedColumns, global::Infragistics.Controls.Grids.SelectedColumnsCollection newSelectedColumns)
		{
			if (this.SelectedColumnsCollectionChanged != null)
			{
				bool flag = false;
				if (previouslySelectedColumns.Count != newSelectedColumns.Count)
				{
					flag = true;
				}
				else
				{
					foreach (global::Infragistics.Controls.Grids.Column item in previouslySelectedColumns)
					{
						if (!newSelectedColumns.Contains(item))
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					this.SelectedColumnsCollectionChanged(this, new global::Infragistics.Controls.Grids.SelectionCollectionChangedEventArgs<global::Infragistics.Controls.Grids.SelectedColumnsCollection>
					{
						NewSelectedItems = newSelectedColumns,
						PreviouslySelectedItems = previouslySelectedColumns
					});
				}
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06001766 RID: 5990 RVA: 0x0005C734 File Offset: 0x0005A934
		// (remove) Token: 0x06001767 RID: 5991 RVA: 0x0005C76C File Offset: 0x0005A96C
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CellControlAttachedEventArgs> CellControlAttached;

		// Token: 0x06001768 RID: 5992 RVA: 0x0005C7A4 File Offset: 0x0005A9A4
		protected internal virtual bool OnCellControlAttached(global::Infragistics.Controls.Grids.Cell cell)
		{
			if (this.CellControlAttached != null && cell != null && !cell.SuppressCellControlAttached)
			{
				global::Infragistics.Controls.Grids.CellControlAttachedEventArgs cellControlAttachedEventArgs = new global::Infragistics.Controls.Grids.CellControlAttachedEventArgs
				{
					Cell = cell
				};
				this.CellControlAttached(this, cellControlAttachedEventArgs);
				return cellControlAttachedEventArgs.IsDirty;
			}
			return false;
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06001769 RID: 5993 RVA: 0x0005C7E8 File Offset: 0x0005A9E8
		// (remove) Token: 0x0600176A RID: 5994 RVA: 0x0005C820 File Offset: 0x0005AA20
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.InitializeRowEventArgs> InitializeRow;

		// Token: 0x0600176B RID: 5995 RVA: 0x0005C858 File Offset: 0x0005AA58
		protected internal virtual void OnInitializeRow(global::Infragistics.Controls.Grids.Row row)
		{
			if (this.InitializeRow != null)
			{
				this.InitializeRow(this, new global::Infragistics.Controls.Grids.InitializeRowEventArgs
				{
					Row = row
				});
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x0600176C RID: 5996 RVA: 0x0005C888 File Offset: 0x0005AA88
		// (remove) Token: 0x0600176D RID: 5997 RVA: 0x0005C8C0 File Offset: 0x0005AAC0
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.RowSelectorClickedEventArgs> RowSelectorClicked;

		// Token: 0x0600176E RID: 5998 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
		protected internal virtual void OnRowSelectorClicked(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (this.RowSelectorClicked != null)
			{
				this.RowSelectorClicked(this, new global::Infragistics.Controls.Grids.RowSelectorClickedEventArgs
				{
					Row = row
				});
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x0600176F RID: 5999 RVA: 0x0005C928 File Offset: 0x0005AB28
		// (remove) Token: 0x06001770 RID: 6000 RVA: 0x0005C960 File Offset: 0x0005AB60
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CellClickedEventArgs> CellClicked;

		// Token: 0x06001771 RID: 6001 RVA: 0x0005C998 File Offset: 0x0005AB98
		protected internal virtual void OnCellClicked(global::Infragistics.Controls.Grids.Cell cell)
		{
			if (this.CellClicked != null)
			{
				this.CellClicked(this, new global::Infragistics.Controls.Grids.CellClickedEventArgs
				{
					Cell = cell
				});
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06001772 RID: 6002 RVA: 0x0005C9C8 File Offset: 0x0005ABC8
		// (remove) Token: 0x06001773 RID: 6003 RVA: 0x0005CA00 File Offset: 0x0005AC00
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CellClickedEventArgs> CellDoubleClicked;

		// Token: 0x06001774 RID: 6004 RVA: 0x0005CA38 File Offset: 0x0005AC38
		protected internal virtual void OnCellDoubleClicked(global::Infragistics.Controls.Grids.Cell cell)
		{
			if (this.CellDoubleClicked != null)
			{
				this.CellDoubleClicked(this, new global::Infragistics.Controls.Grids.CellClickedEventArgs
				{
					Cell = cell
				});
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06001775 RID: 6005 RVA: 0x0005CA68 File Offset: 0x0005AC68
		// (remove) Token: 0x06001776 RID: 6006 RVA: 0x0005CAA0 File Offset: 0x0005ACA0
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CancellableColumnResizingEventArgs> ColumnResizing;

		// Token: 0x06001777 RID: 6007 RVA: 0x0005CAD8 File Offset: 0x0005ACD8
		protected internal virtual bool OnColumnResizing(global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column> columns, double newWidth)
		{
			if (this.ColumnResizing != null)
			{
				global::Infragistics.Controls.Grids.CancellableColumnResizingEventArgs cancellableColumnResizingEventArgs = new global::Infragistics.Controls.Grids.CancellableColumnResizingEventArgs
				{
					Columns = columns,
					Width = newWidth
				};
				this.ColumnResizing(this, cancellableColumnResizingEventArgs);
				return cancellableColumnResizingEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06001778 RID: 6008 RVA: 0x0005CB18 File Offset: 0x0005AD18
		// (remove) Token: 0x06001779 RID: 6009 RVA: 0x0005CB50 File Offset: 0x0005AD50
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnResizedEventArgs> ColumnResized;

		// Token: 0x0600177A RID: 6010 RVA: 0x0005CB88 File Offset: 0x0005AD88
		protected internal virtual void OnColumnResized(global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column> columns)
		{
			if (this.ColumnResized != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(columns);
				this.ColumnResized(this, new global::Infragistics.Controls.Grids.ColumnResizedEventArgs
				{
					Columns = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column>(list)
				});
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x0600177B RID: 6011 RVA: 0x0005CBC4 File Offset: 0x0005ADC4
		// (remove) Token: 0x0600177C RID: 6012 RVA: 0x0005CBFC File Offset: 0x0005ADFC
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CancellableColumnFixedStateEventArgs> ColumnFixedStateChanging;

		// Token: 0x0600177D RID: 6013 RVA: 0x0005CC34 File Offset: 0x0005AE34
		protected internal virtual bool OnColumnFixedStateChanging(global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.FixedState newState)
		{
			if (this.ColumnFixedStateChanging != null)
			{
				global::Infragistics.Controls.Grids.CancellableColumnFixedStateEventArgs cancellableColumnFixedStateEventArgs = new global::Infragistics.Controls.Grids.CancellableColumnFixedStateEventArgs
				{
					Column = column,
					FixedState = newState
				};
				this.ColumnFixedStateChanging(this, cancellableColumnFixedStateEventArgs);
				return cancellableColumnFixedStateEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x0600177E RID: 6014 RVA: 0x0005CC74 File Offset: 0x0005AE74
		// (remove) Token: 0x0600177F RID: 6015 RVA: 0x0005CCAC File Offset: 0x0005AEAC
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnFixedStateEventArgs> ColumnFixedStateChanged;

		// Token: 0x06001780 RID: 6016 RVA: 0x0005CCE4 File Offset: 0x0005AEE4
		protected internal virtual void OnColumnFixedStateChanged(global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.FixedState previous)
		{
			if (this.ColumnFixedStateChanged != null)
			{
				this.ColumnFixedStateChanged(this, new global::Infragistics.Controls.Grids.ColumnFixedStateEventArgs
				{
					Column = column,
					PreviousFixedState = previous
				});
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06001781 RID: 6017 RVA: 0x0005CD1C File Offset: 0x0005AF1C
		// (remove) Token: 0x06001782 RID: 6018 RVA: 0x0005CD54 File Offset: 0x0005AF54
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnLayoutAssignedEventArgs> ColumnLayoutAssigned;

		// Token: 0x06001783 RID: 6019 RVA: 0x0005CD89 File Offset: 0x0005AF89
		protected internal virtual void OnColumnLayoutAssigned(global::Infragistics.Controls.Grids.ColumnLayoutAssignedEventArgs e)
		{
			if (this.ColumnLayoutAssigned != null)
			{
				this.ColumnLayoutAssigned(this, e);
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06001784 RID: 6020 RVA: 0x0005CDA0 File Offset: 0x0005AFA0
		// (remove) Token: 0x06001785 RID: 6021 RVA: 0x0005CDD8 File Offset: 0x0005AFD8
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CancellableRowExpansionChangedEventArgs> RowExpansionChanging;

		// Token: 0x06001786 RID: 6022 RVA: 0x0005CE10 File Offset: 0x0005B010
		protected internal virtual bool OnRowExpansionChanging(global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase row)
		{
			if (this.RowExpansionChanging != null)
			{
				global::Infragistics.Controls.Grids.CancellableRowExpansionChangedEventArgs cancellableRowExpansionChangedEventArgs = new global::Infragistics.Controls.Grids.CancellableRowExpansionChangedEventArgs
				{
					Row = row
				};
				this.RowExpansionChanging(this, cancellableRowExpansionChangedEventArgs);
				return cancellableRowExpansionChangedEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06001787 RID: 6023 RVA: 0x0005CE4C File Offset: 0x0005B04C
		// (remove) Token: 0x06001788 RID: 6024 RVA: 0x0005CE84 File Offset: 0x0005B084
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.RowExpansionChangedEventArgs> RowExpansionChanged;

		// Token: 0x06001789 RID: 6025 RVA: 0x0005CEBC File Offset: 0x0005B0BC
		protected internal virtual void OnRowExpansionChanged(global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase row)
		{
			if (this.RowExpansionChanged != null)
			{
				this.RowExpansionChanged(this, new global::Infragistics.Controls.Grids.RowExpansionChangedEventArgs
				{
					Row = row
				});
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x0600178A RID: 6026 RVA: 0x0005CEEC File Offset: 0x0005B0EC
		// (remove) Token: 0x0600178B RID: 6027 RVA: 0x0005CF24 File Offset: 0x0005B124
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnDragStartEventArgs> ColumnDragStart;

		// Token: 0x0600178C RID: 6028 RVA: 0x0005CF5C File Offset: 0x0005B15C
		protected internal virtual bool OnColumnDragStart(global::Infragistics.Controls.Grids.Column column)
		{
			if (this.ColumnDragStart != null)
			{
				global::Infragistics.Controls.Grids.ColumnDragStartEventArgs columnDragStartEventArgs = new global::Infragistics.Controls.Grids.ColumnDragStartEventArgs
				{
					Column = column
				};
				this.ColumnDragStart(this, columnDragStartEventArgs);
				return columnDragStartEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x0600178D RID: 6029 RVA: 0x0005CF98 File Offset: 0x0005B198
		// (remove) Token: 0x0600178E RID: 6030 RVA: 0x0005CFD0 File Offset: 0x0005B1D0
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnMovingEventArgs> ColumnMoving;

		// Token: 0x0600178F RID: 6031 RVA: 0x0005D008 File Offset: 0x0005B208
		protected internal virtual void OnColumnMoving(global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.Primitives.HeaderCellControl header, global::System.Windows.Input.MouseEventArgs args)
		{
			if (this.ColumnMoving != null)
			{
				this.ColumnMoving(this, new global::Infragistics.Controls.Grids.ColumnMovingEventArgs
				{
					Column = column,
					DraggingHeader = header,
					MouseArgs = args
				});
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06001790 RID: 6032 RVA: 0x0005D048 File Offset: 0x0005B248
		// (remove) Token: 0x06001791 RID: 6033 RVA: 0x0005D080 File Offset: 0x0005B280
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnDroppedEventArgs> ColumnDropped;

		// Token: 0x06001792 RID: 6034 RVA: 0x0005D0B8 File Offset: 0x0005B2B8
		protected internal virtual void OnColumnDropped(global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.DropOperationType type, int newIndex, int previousIndex)
		{
			if (this.ColumnDropped != null)
			{
				this.ColumnDropped(this, new global::Infragistics.Controls.Grids.ColumnDroppedEventArgs
				{
					Column = column,
					DropType = type,
					NewIndex = newIndex,
					PreviousIndex = previousIndex
				});
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06001793 RID: 6035 RVA: 0x0005D100 File Offset: 0x0005B300
		// (remove) Token: 0x06001794 RID: 6036 RVA: 0x0005D138 File Offset: 0x0005B338
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnDragCanceledEventArgs> ColumnDragCanceled;

		// Token: 0x06001795 RID: 6037 RVA: 0x0005D170 File Offset: 0x0005B370
		protected internal virtual void OnColumnDragCanceled(global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.DragCancelType type)
		{
			if (this.ColumnDragCanceled != null)
			{
				this.ColumnDragCanceled(this, new global::Infragistics.Controls.Grids.ColumnDragCanceledEventArgs
				{
					Column = column,
					CancelType = type
				});
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06001796 RID: 6038 RVA: 0x0005D1A8 File Offset: 0x0005B3A8
		// (remove) Token: 0x06001797 RID: 6039 RVA: 0x0005D1E0 File Offset: 0x0005B3E0
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnDragEndedEventArgs> ColumnDragEnded;

		// Token: 0x06001798 RID: 6040 RVA: 0x0005D218 File Offset: 0x0005B418
		protected internal virtual void OnColumnDragEnded(global::Infragistics.Controls.Grids.Column column)
		{
			if (this.ColumnDragEnded != null)
			{
				this.ColumnDragEnded(this, new global::Infragistics.Controls.Grids.ColumnDragEndedEventArgs
				{
					Column = column
				});
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06001799 RID: 6041 RVA: 0x0005D248 File Offset: 0x0005B448
		// (remove) Token: 0x0600179A RID: 6042 RVA: 0x0005D280 File Offset: 0x0005B480
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.BeginEditingCellEventArgs> CellEnteringEditMode;

		// Token: 0x0600179B RID: 6043 RVA: 0x0005D2B8 File Offset: 0x0005B4B8
		protected internal virtual bool OnCellEnteringEditMode(global::Infragistics.Controls.Grids.Cell cell)
		{
			if (this.CellEnteringEditMode != null)
			{
				global::Infragistics.Controls.Grids.BeginEditingCellEventArgs beginEditingCellEventArgs = new global::Infragistics.Controls.Grids.BeginEditingCellEventArgs
				{
					Cell = cell
				};
				this.CellEnteringEditMode(this, beginEditingCellEventArgs);
				return beginEditingCellEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600179C RID: 6044 RVA: 0x0005D2F4 File Offset: 0x0005B4F4
		// (remove) Token: 0x0600179D RID: 6045 RVA: 0x0005D32C File Offset: 0x0005B52C
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.EditingCellEventArgs> CellEnteredEditMode;

		// Token: 0x0600179E RID: 6046 RVA: 0x0005D364 File Offset: 0x0005B564
		protected internal virtual void OnCellEnteredEditMode(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.FrameworkElement editor)
		{
			if (this.CellEnteredEditMode != null)
			{
				this.CellEnteredEditMode(this, new global::Infragistics.Controls.Grids.EditingCellEventArgs
				{
					Cell = cell,
					Editor = editor
				});
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600179F RID: 6047 RVA: 0x0005D39C File Offset: 0x0005B59C
		// (remove) Token: 0x060017A0 RID: 6048 RVA: 0x0005D3D4 File Offset: 0x0005B5D4
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ExitEditingCellEventArgs> CellExitingEditMode;

		// Token: 0x060017A1 RID: 6049 RVA: 0x0005D409 File Offset: 0x0005B609
		protected internal virtual void OnCellExitingEditMode(global::Infragistics.Controls.Grids.ExitEditingCellEventArgs e)
		{
			if (this.CellExitingEditMode != null)
			{
				this.CellExitingEditMode(this, e);
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060017A2 RID: 6050 RVA: 0x0005D420 File Offset: 0x0005B620
		// (remove) Token: 0x060017A3 RID: 6051 RVA: 0x0005D458 File Offset: 0x0005B658
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.PopulatingFiltersEventArgs> PopulatingColumnFilters;

		// Token: 0x060017A4 RID: 6052 RVA: 0x0005D48D File Offset: 0x0005B68D
		protected internal virtual void OnShowAvailableColumnFilterOperands(global::Infragistics.Controls.Grids.PopulatingFiltersEventArgs args)
		{
			if (this.PopulatingColumnFilters != null)
			{
				this.PopulatingColumnFilters(this, args);
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060017A5 RID: 6053 RVA: 0x0005D4A4 File Offset: 0x0005B6A4
		// (remove) Token: 0x060017A6 RID: 6054 RVA: 0x0005D4DC File Offset: 0x0005B6DC
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CellExitedEditingEventArgs> CellExitedEditMode;

		// Token: 0x060017A7 RID: 6055 RVA: 0x0005D514 File Offset: 0x0005B714
		protected internal virtual void OnExitedEditMode(global::Infragistics.Controls.Grids.Cell cell)
		{
			if (this.CellExitedEditMode != null)
			{
				this.CellExitedEditMode(this, new global::Infragistics.Controls.Grids.CellExitedEditingEventArgs
				{
					Cell = cell
				});
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060017A8 RID: 6056 RVA: 0x0005D544 File Offset: 0x0005B744
		// (remove) Token: 0x060017A9 RID: 6057 RVA: 0x0005D57C File Offset: 0x0005B77C
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.BeginEditingRowEventArgs> RowEnteringEditMode;

		// Token: 0x060017AA RID: 6058 RVA: 0x0005D5B4 File Offset: 0x0005B7B4
		protected internal virtual bool OnRowEnteringEditMode(global::Infragistics.Controls.Grids.Row row)
		{
			if (this.RowEnteringEditMode != null)
			{
				global::Infragistics.Controls.Grids.BeginEditingRowEventArgs beginEditingRowEventArgs = new global::Infragistics.Controls.Grids.BeginEditingRowEventArgs
				{
					Row = row
				};
				this.RowEnteringEditMode(this, beginEditingRowEventArgs);
				return beginEditingRowEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x060017AB RID: 6059 RVA: 0x0005D5F0 File Offset: 0x0005B7F0
		// (remove) Token: 0x060017AC RID: 6060 RVA: 0x0005D628 File Offset: 0x0005B828
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.EditingRowEventArgs> RowEnteredEditMode;

		// Token: 0x060017AD RID: 6061 RVA: 0x0005D660 File Offset: 0x0005B860
		protected internal virtual void OnRowEnteredEditMode(global::Infragistics.Controls.Grids.Row row)
		{
			if (this.RowEnteredEditMode != null)
			{
				this.RowEnteredEditMode(this, new global::Infragistics.Controls.Grids.EditingRowEventArgs
				{
					Row = row
				});
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x060017AE RID: 6062 RVA: 0x0005D690 File Offset: 0x0005B890
		// (remove) Token: 0x060017AF RID: 6063 RVA: 0x0005D6C8 File Offset: 0x0005B8C8
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ExitEditingRowEventArgs> RowExitingEditMode;

		// Token: 0x060017B0 RID: 6064 RVA: 0x0005D700 File Offset: 0x0005B900
		protected internal virtual bool OnRowExitingEditMode(global::Infragistics.Controls.Grids.Row row, global::System.Collections.Generic.Dictionary<string, object> originalCellValues, global::System.Collections.Generic.Dictionary<string, object> newCellValues, bool cancel)
		{
			if (this.RowExitingEditMode != null)
			{
				global::Infragistics.Controls.Grids.ExitEditingRowEventArgs exitEditingRowEventArgs = new global::Infragistics.Controls.Grids.ExitEditingRowEventArgs
				{
					Row = row,
					EditingCanceled = cancel,
					NewCellValues = newCellValues,
					OriginalCellValues = originalCellValues
				};
				this.RowExitingEditMode(this, exitEditingRowEventArgs);
				return exitEditingRowEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x060017B1 RID: 6065 RVA: 0x0005D750 File Offset: 0x0005B950
		// (remove) Token: 0x060017B2 RID: 6066 RVA: 0x0005D788 File Offset: 0x0005B988
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.EditingRowEventArgs> RowExitedEditMode;

		// Token: 0x060017B3 RID: 6067 RVA: 0x0005D7C0 File Offset: 0x0005B9C0
		protected internal virtual void OnRowExitedEditMode(global::Infragistics.Controls.Grids.Row row)
		{
			if (this.RowExitedEditMode != null)
			{
				this.RowExitedEditMode(this, new global::Infragistics.Controls.Grids.EditingRowEventArgs
				{
					Row = row
				});
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x060017B4 RID: 6068 RVA: 0x0005D7F0 File Offset: 0x0005B9F0
		// (remove) Token: 0x060017B5 RID: 6069 RVA: 0x0005D828 File Offset: 0x0005BA28
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CancellableRowAddingEventArgs> RowAdding;

		// Token: 0x060017B6 RID: 6070 RVA: 0x0005D860 File Offset: 0x0005BA60
		protected internal virtual bool OnRowAdding(global::Infragistics.Controls.Grids.Row row, int index)
		{
			if (this.RowAdding != null)
			{
				global::Infragistics.Controls.Grids.CancellableRowAddingEventArgs cancellableRowAddingEventArgs = new global::Infragistics.Controls.Grids.CancellableRowAddingEventArgs
				{
					Row = row,
					InsertionIndex = index
				};
				this.RowAdding(this, cancellableRowAddingEventArgs);
				return cancellableRowAddingEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060017B7 RID: 6071 RVA: 0x0005D8A0 File Offset: 0x0005BAA0
		// (remove) Token: 0x060017B8 RID: 6072 RVA: 0x0005D8D8 File Offset: 0x0005BAD8
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.RowEventArgs> RowAdded;

		// Token: 0x060017B9 RID: 6073 RVA: 0x0005D910 File Offset: 0x0005BB10
		protected internal virtual void OnRowAdded(global::Infragistics.Controls.Grids.Row row)
		{
			if (this.RowAdded != null)
			{
				global::Infragistics.Controls.Grids.RowEventArgs e = new global::Infragistics.Controls.Grids.RowEventArgs
				{
					Row = row
				};
				this.RowAdded(this, e);
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060017BA RID: 6074 RVA: 0x0005D944 File Offset: 0x0005BB44
		// (remove) Token: 0x060017BB RID: 6075 RVA: 0x0005D97C File Offset: 0x0005BB7C
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CancellableRowEventArgs> RowDeleting;

		// Token: 0x060017BC RID: 6076 RVA: 0x0005D9B4 File Offset: 0x0005BBB4
		protected internal virtual bool OnRowDeleting(global::Infragistics.Controls.Grids.Row row)
		{
			if (this.RowDeleting != null)
			{
				global::Infragistics.Controls.Grids.CancellableRowEventArgs cancellableRowEventArgs = new global::Infragistics.Controls.Grids.CancellableRowEventArgs
				{
					Row = row
				};
				this.RowDeleting(this, cancellableRowEventArgs);
				return cancellableRowEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060017BD RID: 6077 RVA: 0x0005D9F0 File Offset: 0x0005BBF0
		// (remove) Token: 0x060017BE RID: 6078 RVA: 0x0005DA28 File Offset: 0x0005BC28
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.RowEventArgs> RowDeleted;

		// Token: 0x060017BF RID: 6079 RVA: 0x0005DA60 File Offset: 0x0005BC60
		protected internal virtual void OnRowDeleted(global::Infragistics.Controls.Grids.Row row)
		{
			if (this.RowDeleted != null)
			{
				global::Infragistics.Controls.Grids.RowEventArgs e = new global::Infragistics.Controls.Grids.RowEventArgs
				{
					Row = row
				};
				this.RowDeleted(this, e);
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060017C0 RID: 6080 RVA: 0x0005DA94 File Offset: 0x0005BC94
		// (remove) Token: 0x060017C1 RID: 6081 RVA: 0x0005DACC File Offset: 0x0005BCCC
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.GroupByCollectionChangedEventArgs> GroupByCollectionChanged;

		// Token: 0x060017C2 RID: 6082 RVA: 0x0005DB04 File Offset: 0x0005BD04
		protected internal virtual void OnGroupByCollectionChanged(global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Column> previousGroupedColumns, global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Column> newGroupedColumns)
		{
			if (this.GroupByCollectionChanged != null)
			{
				bool flag = false;
				if (previousGroupedColumns.Count != newGroupedColumns.Count)
				{
					flag = true;
				}
				else
				{
					foreach (global::Infragistics.Controls.Grids.Column item in previousGroupedColumns)
					{
						if (!newGroupedColumns.Contains(item))
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					this.GroupByCollectionChanged(this, new global::Infragistics.Controls.Grids.GroupByCollectionChangedEventArgs
					{
						NewGroupedColumns = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column>(newGroupedColumns),
						PreviousGroupedColumns = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column>(previousGroupedColumns)
					});
				}
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060017C3 RID: 6083 RVA: 0x0005DB9C File Offset: 0x0005BD9C
		// (remove) Token: 0x060017C4 RID: 6084 RVA: 0x0005DBD4 File Offset: 0x0005BDD4
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CellValidationErrorEventArgs> CellEditingValidationFailed;

		// Token: 0x060017C5 RID: 6085 RVA: 0x0005DC0C File Offset: 0x0005BE0C
		protected internal virtual bool OnCellEditingValidationFailed(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Controls.ValidationErrorEventArgs args)
		{
			if (this.CellEditingValidationFailed != null)
			{
				global::Infragistics.Controls.Grids.CellValidationErrorEventArgs cellValidationErrorEventArgs = new global::Infragistics.Controls.Grids.CellValidationErrorEventArgs
				{
					ValidationErrorEventArgs = args,
					Cell = cell
				};
				this.CellEditingValidationFailed(this, cellValidationErrorEventArgs);
				return cellValidationErrorEventArgs.Handled;
			}
			return false;
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060017C6 RID: 6086 RVA: 0x0005DC4C File Offset: 0x0005BE4C
		// (remove) Token: 0x060017C7 RID: 6087 RVA: 0x0005DC84 File Offset: 0x0005BE84
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.DataObjectCreationEventArgs> DataObjectRequested;

		// Token: 0x060017C8 RID: 6088 RVA: 0x0005DCBC File Offset: 0x0005BEBC
		protected internal virtual void OnDataObjectRequested(global::Infragistics.HandleableObjectGenerationEventArgs args, global::Infragistics.Controls.Grids.ColumnLayout columnLayout, global::Infragistics.Controls.Grids.Row parentRow, global::Infragistics.Controls.Grids.RowType? typeOfRowPopulated)
		{
			global::Infragistics.Controls.Grids.DataObjectCreationEventArgs dataObjectCreationEventArgs = new global::Infragistics.Controls.Grids.DataObjectCreationEventArgs();
			dataObjectCreationEventArgs.ObjectType = args.ObjectType;
			dataObjectCreationEventArgs.ColumnLayout = columnLayout;
			dataObjectCreationEventArgs.ParentRow = parentRow;
			dataObjectCreationEventArgs.CollectionType = args.CollectionType;
			dataObjectCreationEventArgs.RowTypeCreated = typeOfRowPopulated;
			if (this.DataObjectRequested != null)
			{
				this.DataObjectRequested(this, dataObjectCreationEventArgs);
			}
			args.NewObject = dataObjectCreationEventArgs.NewObject;
			if (args.NewObject != null)
			{
				args.Handled = true;
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060017C9 RID: 6089 RVA: 0x0005DD30 File Offset: 0x0005BF30
		// (remove) Token: 0x060017CA RID: 6090 RVA: 0x0005DD68 File Offset: 0x0005BF68
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.CancellableFilteringEventArgs> Filtering;

		// Token: 0x060017CB RID: 6091 RVA: 0x0005DDA0 File Offset: 0x0005BFA0
		protected internal virtual bool OnFiltering(global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.FilterOperand operand, global::Infragistics.Controls.Grids.RowFiltersCollection filters, object newValue)
		{
			if (this.Filtering != null)
			{
				global::Infragistics.Controls.Grids.CancellableFilteringEventArgs cancellableFilteringEventArgs = new global::Infragistics.Controls.Grids.CancellableFilteringEventArgs();
				cancellableFilteringEventArgs.Column = column;
				cancellableFilteringEventArgs.FilteringOperand = operand;
				cancellableFilteringEventArgs.RowFiltersCollection = filters;
				cancellableFilteringEventArgs.FilterValue = newValue;
				this.Filtering(this, cancellableFilteringEventArgs);
				return cancellableFilteringEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x060017CC RID: 6092 RVA: 0x0005DDF0 File Offset: 0x0005BFF0
		// (remove) Token: 0x060017CD RID: 6093 RVA: 0x0005DE28 File Offset: 0x0005C028
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.FilteredEventArgs> Filtered;

		// Token: 0x060017CE RID: 6094 RVA: 0x0005DE60 File Offset: 0x0005C060
		protected internal virtual void OnFiltered(global::Infragistics.Controls.Grids.RowFiltersCollection filters)
		{
			if (this.Filtered != null)
			{
				this.Filtered(this, new global::Infragistics.Controls.Grids.FilteredEventArgs
				{
					RowFiltersCollection = filters
				});
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0005DE8F File Offset: 0x0005C08F
		protected internal virtual void OnDataResolution(global::Infragistics.Controls.Grids.DataLimitingEventArgs e)
		{
			if (this.DataResolution != null)
			{
				this.DataResolution(this, e);
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060017D0 RID: 6096 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
		// (remove) Token: 0x060017D1 RID: 6097 RVA: 0x0005DEE0 File Offset: 0x0005C0E0
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.DataLimitingEventArgs> DataResolution;

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060017D2 RID: 6098 RVA: 0x0005DF18 File Offset: 0x0005C118
		// (remove) Token: 0x060017D3 RID: 6099 RVA: 0x0005DF50 File Offset: 0x0005C150
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ClipboardCopyingEventArgs> ClipboardCopying;

		// Token: 0x060017D4 RID: 6100 RVA: 0x0005DF88 File Offset: 0x0005C188
		protected internal virtual bool OnClipboardCopying(global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.CellBase> selectedItems, ref string clipboardValue)
		{
			if (this.ClipboardCopying != null)
			{
				global::Infragistics.Controls.Grids.ClipboardCopyingEventArgs clipboardCopyingEventArgs = new global::Infragistics.Controls.Grids.ClipboardCopyingEventArgs(this)
				{
					SelectedItems = selectedItems,
					ClipboardValue = clipboardValue
				};
				this.ClipboardCopying(this, clipboardCopyingEventArgs);
				clipboardValue = clipboardCopyingEventArgs.ClipboardValue;
				return clipboardCopyingEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060017D5 RID: 6101 RVA: 0x0005DFD4 File Offset: 0x0005C1D4
		// (remove) Token: 0x060017D6 RID: 6102 RVA: 0x0005E00C File Offset: 0x0005C20C
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ClipboardCopyingItemEventArgs> ClipboardCopyingItem;

		// Token: 0x060017D7 RID: 6103 RVA: 0x0005E044 File Offset: 0x0005C244
		protected internal virtual bool OnClipboardCopyingItem(global::Infragistics.Controls.Grids.CellBase cell, ref string clipboardValue)
		{
			if (this.ClipboardCopyingItem != null)
			{
				global::Infragistics.Controls.Grids.ClipboardCopyingItemEventArgs clipboardCopyingItemEventArgs = new global::Infragistics.Controls.Grids.ClipboardCopyingItemEventArgs
				{
					Cell = cell,
					ClipboardValue = clipboardValue
				};
				this.ClipboardCopyingItem(this, clipboardCopyingItemEventArgs);
				clipboardValue = clipboardCopyingItemEventArgs.ClipboardValue;
				return clipboardCopyingItemEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060017D8 RID: 6104 RVA: 0x0005E090 File Offset: 0x0005C290
		// (remove) Token: 0x060017D9 RID: 6105 RVA: 0x0005E0C8 File Offset: 0x0005C2C8
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ClipboardPastingEventArgs> ClipboardPasting;

		// Token: 0x060017DA RID: 6106 RVA: 0x0005E100 File Offset: 0x0005C300
		protected internal virtual void OnClipboardPasting(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> parsedValues, string clipboardValue)
		{
			if (this.ClipboardPasting != null)
			{
				global::Infragistics.Controls.Grids.ClipboardPastingEventArgs e = new global::Infragistics.Controls.Grids.ClipboardPastingEventArgs(this)
				{
					Values = parsedValues,
					ClipboardValue = clipboardValue
				};
				this.ClipboardPasting(this, e);
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060017DB RID: 6107 RVA: 0x0005E13C File Offset: 0x0005C33C
		// (remove) Token: 0x060017DC RID: 6108 RVA: 0x0005E174 File Offset: 0x0005C374
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ClipboardPasteErrorEventArgs> ClipboardPasteError;

		// Token: 0x060017DD RID: 6109 RVA: 0x0005E1AC File Offset: 0x0005C3AC
		protected internal virtual bool OnClipboardPasteError(global::Infragistics.Controls.Grids.ClipboardPasteErrorType errorType, bool isRecoverable)
		{
			if (this.ClipboardPasteError != null)
			{
				global::Infragistics.Controls.Grids.ClipboardPasteErrorEventArgs clipboardPasteErrorEventArgs = new global::Infragistics.Controls.Grids.ClipboardPasteErrorEventArgs
				{
					ErrorType = errorType,
					IsRecoverable = isRecoverable
				};
				this.ClipboardPasteError(this, clipboardPasteErrorEventArgs);
				return clipboardPasteErrorEventArgs.AttemptRecover;
			}
			return true;
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060017DE RID: 6110 RVA: 0x0005E1EC File Offset: 0x0005C3EC
		// (remove) Token: 0x060017DF RID: 6111 RVA: 0x0005E224 File Offset: 0x0005C424
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnAutoGeneratedEventArgs> ColumnAutoGenerated;

		// Token: 0x060017E0 RID: 6112 RVA: 0x0005E259 File Offset: 0x0005C459
		protected internal virtual void OnColumnAutoGenerated(global::Infragistics.Controls.Grids.ColumnAutoGeneratedEventArgs e)
		{
			if (this.ColumnAutoGenerated != null)
			{
				this.ColumnAutoGenerated(this, e);
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x060017E1 RID: 6113 RVA: 0x0005E270 File Offset: 0x0005C470
		// (remove) Token: 0x060017E2 RID: 6114 RVA: 0x0005E2A8 File Offset: 0x0005C4A8
		public event global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnVisibilityChangedEventArgs> ColumnVisibilityChanged;

		// Token: 0x060017E3 RID: 6115 RVA: 0x0005E2E0 File Offset: 0x0005C4E0
		protected internal virtual void OnColumnVisibilityChanged(global::Infragistics.Controls.Grids.ColumnVisibilityChangedEventArgs e)
		{
			global::System.EventHandler<global::Infragistics.Controls.Grids.ColumnVisibilityChangedEventArgs> columnVisibilityChanged = this.ColumnVisibilityChanged;
			if (columnVisibilityChanged != null)
			{
				columnVisibilityChanged(this, e);
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0005E300 File Offset: 0x0005C500
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"ItemsSource",
						"Rows",
						"Columns",
						"ColumnLayouts",
						"ActiveCell",
						"ActiveItem"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x0005E36A File Offset: 0x0005C56A
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0005E374 File Offset: 0x0005C574
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				if (this._prioirtyProperties == null)
				{
					this._prioirtyProperties = new global::System.Collections.Generic.List<string>
					{
						"ColumnLayouts"
					};
				}
				return this._prioirtyProperties;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0005E3A7 File Offset: 0x0005C5A7
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0005E3B0 File Offset: 0x0005C5B0
		protected virtual void FinishedLoadingPersistence()
		{
			if (this.VerticalScrollBar != null)
			{
				this.VerticalScrollBar.Value = 0.0;
			}
			if (this.HorizontalScrollBar != null)
			{
				this.HorizontalScrollBar.Value = 0.0;
			}
			if (this.RowsManager.ColumnLayout.DataFields == null)
			{
				this.RowsManager.InitData();
			}
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0005E412 File Offset: 0x0005C612
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0005E41A File Offset: 0x0005C61A
		global::Infragistics.Controls.ScrollType global::Infragistics.Controls.ISupportScrollHelper.VerticalScrollType
		{
			get
			{
				return global::Infragistics.Controls.ScrollType.Item;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x0005E41D File Offset: 0x0005C61D
		global::Infragistics.Controls.ScrollType global::Infragistics.Controls.ISupportScrollHelper.HorizontalScrollType
		{
			get
			{
				return global::Infragistics.Controls.ScrollType.Item;
			}
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0005E420 File Offset: 0x0005C620
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemHeight()
		{
			if (this._panel != null && this._panel.VisibleRows.Count > 0)
			{
				return this._panel.VisibleRows[0].Control.DesiredSize.Height;
			}
			return 0.0;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0005E475 File Offset: 0x0005C675
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemWidth()
		{
			return 100.0;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0005E480 File Offset: 0x0005C680
		void global::Infragistics.Controls.ISupportScrollHelper.InvalidateScrollLayout()
		{
			this.InvalidateScrollPanel(false);
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0005E489 File Offset: 0x0005C689
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x0005E4A8 File Offset: 0x0005C6A8
		double global::Infragistics.Controls.ISupportScrollHelper.VerticalValue
		{
			get
			{
				if (this.VerticalScrollBar != null)
				{
					return this.VerticalScrollBar.Value;
				}
				return 0.0;
			}
			set
			{
				if (this.VerticalScrollBar != null)
				{
					this.VerticalScrollBar.Value = value;
				}
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0005E4BE File Offset: 0x0005C6BE
		double global::Infragistics.Controls.ISupportScrollHelper.VerticalMax
		{
			get
			{
				if (this.VerticalScrollBar != null)
				{
					return this.VerticalScrollBar.Maximum;
				}
				return 0.0;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0005E4DD File Offset: 0x0005C6DD
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0005E4FC File Offset: 0x0005C6FC
		double global::Infragistics.Controls.ISupportScrollHelper.HorizontalValue
		{
			get
			{
				if (this.HorizontalScrollBar != null)
				{
					return this.HorizontalScrollBar.Value;
				}
				return 0.0;
			}
			set
			{
				if (this.HorizontalScrollBar != null)
				{
					this.HorizontalScrollBar.Value = value;
				}
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0005E512 File Offset: 0x0005C712
		double global::Infragistics.Controls.ISupportScrollHelper.HorizontalMax
		{
			get
			{
				if (this.HorizontalScrollBar != null)
				{
					return this.HorizontalScrollBar.Maximum;
				}
				return 0.0;
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0005E534 File Offset: 0x0005C734
		global::Infragistics.Controls.TouchScrollMode global::Infragistics.Controls.ISupportScrollHelper.GetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver)
		{
			if (this.IsColumnResizing)
			{
				return global::Infragistics.Controls.TouchScrollMode.None;
			}
			if (this.ColumnChooserDialog.IsOpen)
			{
				return global::Infragistics.Controls.TouchScrollMode.None;
			}
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlFromElement = this.GetCellControlFromElement(elementDirectlyOver);
			if (cellControlFromElement != null)
			{
				global::System.Type type = cellControlFromElement.GetType();
				if (type == typeof(global::Infragistics.Controls.Grids.CellControl))
				{
					global::Infragistics.Controls.Grids.Column column = cellControlFromElement.Column;
					if (column != null)
					{
						if (column.IsMoving)
						{
							return global::Infragistics.Controls.TouchScrollMode.None;
						}
						if (column.IsFixed != global::Infragistics.Controls.Grids.FixedState.NotFixed)
						{
							return global::Infragistics.Controls.TouchScrollMode.Vertical;
						}
					}
				}
				if (type == typeof(global::Infragistics.Controls.Grids.Primitives.PagerCellControl))
				{
					return global::Infragistics.Controls.TouchScrollMode.None;
				}
				if (type == typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl))
				{
					return global::Infragistics.Controls.TouchScrollMode.None;
				}
			}
			if (this.InUtilityControl(elementDirectlyOver))
			{
				return global::Infragistics.Controls.TouchScrollMode.None;
			}
			return global::Infragistics.Controls.TouchScrollMode.Both;
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0005E5D0 File Offset: 0x0005C7D0
		void global::Infragistics.Controls.ISupportScrollHelper.OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0005E5D2 File Offset: 0x0005C7D2
		void global::Infragistics.Controls.ISupportScrollHelper.OnPanComplete()
		{
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x0005E5D4 File Offset: 0x0005C7D4
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0005E5DD File Offset: 0x0005C7DD
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x040006A6 RID: 1702
		private const double DefaultIndentation = 30.0;

		// Token: 0x040006A7 RID: 1703
		private static readonly char[] ClipboardCopyEscapeChars = new char[]
		{
			'\r',
			'\n',
			'\t'
		};

		// Token: 0x040006A8 RID: 1704
		private bool _ignoreActiveItemChanging;

		// Token: 0x040006A9 RID: 1705
		private bool _mouseIsOver;

		// Token: 0x040006AA RID: 1706
		private bool _isColumnResizing;

		// Token: 0x040006AB RID: 1707
		private bool _isLoaded;

		// Token: 0x040006AC RID: 1708
		private bool _suspendConditionalFormatUpdates;

		// Token: 0x040006AD RID: 1709
		private bool _currentlyEnteringEditMode;

		// Token: 0x040006AE RID: 1710
		private bool _cachedIsAlternateRowsEnabled;

		// Token: 0x040006AF RID: 1711
		private long _doubleClickTimeStamp;

		// Token: 0x040006B0 RID: 1712
		private double _cachedMinimumRowHeight;

		// Token: 0x040006B1 RID: 1713
		private global::Infragistics.Controls.Grids.ColumnWidth _cachedColumnWidth;

		// Token: 0x040006B2 RID: 1714
		private global::Infragistics.Controls.Grids.RowHeight _cachedRowHeight;

		// Token: 0x040006B3 RID: 1715
		private global::System.Windows.Point _mousePosition;

		// Token: 0x040006B4 RID: 1716
		private global::Infragistics.Controls.Grids.DragSelectType _dragSelectType;

		// Token: 0x040006B5 RID: 1717
		private global::System.Windows.Input.KeyboardNavigationMode? _tabMode;

		// Token: 0x040006B6 RID: 1718
		private readonly global::Infragistics.Controls.Grids.XamGridRowsManager _rowsManager;

		// Token: 0x040006B7 RID: 1719
		private readonly global::System.Collections.Generic.Dictionary<string, object> _editCellValues;

		// Token: 0x040006B8 RID: 1720
		private readonly global::System.Collections.Generic.Dictionary<string, object> _originalCellValues;

		// Token: 0x040006B9 RID: 1721
		private global::System.Windows.Controls.Primitives.ScrollBar _verticalScrollbar;

		// Token: 0x040006BA RID: 1722
		private global::System.Windows.Controls.Primitives.ScrollBar _horizontalScrollbar;

		// Token: 0x040006BB RID: 1723
		private global::Infragistics.Controls.Grids.Primitives.RowsPanel _panel;

		// Token: 0x040006BC RID: 1724
		private global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator _dropAreaIndicatorLeft;

		// Token: 0x040006BD RID: 1725
		private global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator _dropAreaIndicatorRight;

		// Token: 0x040006BE RID: 1726
		private global::System.Windows.Controls.Canvas _dropIndicatorPanel;

		// Token: 0x040006BF RID: 1727
		private global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog _columnChooserDialog;

		// Token: 0x040006C0 RID: 1728
		private global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl _openDropDownControl;

		// Token: 0x040006C1 RID: 1729
		private global::System.Windows.Controls.Primitives.Popup _deferredPopup;

		// Token: 0x040006C2 RID: 1730
		private global::System.Windows.Controls.ContentControl _deferredContentControl;

		// Token: 0x040006C3 RID: 1731
		private global::System.Windows.FrameworkElement _rootElement;

		// Token: 0x040006C4 RID: 1732
		private global::System.Windows.DataTemplate _defaultDeferredScrollingTemplate;

		// Token: 0x040006C5 RID: 1733
		private global::System.Windows.DataTemplate _defaultGroupByDeferredScrollingTemplate;

		// Token: 0x040006C6 RID: 1734
		private global::Infragistics.Controls.Grids.Primitives.InternalRowsCollection _internalRows;

		// Token: 0x040006C7 RID: 1735
		private global::Infragistics.Controls.Grids.ColumnLayoutCollection _columnLayouts;

		// Token: 0x040006C8 RID: 1736
		private global::Infragistics.Controls.Grids.ColumnTypeMappingsCollection _columnTypeMappings;

		// Token: 0x040006C9 RID: 1737
		private global::System.Collections.Generic.Dictionary<global::Infragistics.ComparisonOperator, global::System.Windows.DataTemplate> _filterIcons;

		// Token: 0x040006CA RID: 1738
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner> _adorners;

		// Token: 0x040006CB RID: 1739
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Cell> _cellsThatCancelledEditMode;

		// Token: 0x040006CC RID: 1740
		private global::Infragistics.Controls.Grids.RowSelectorSettings _rowSelectorSettings;

		// Token: 0x040006CD RID: 1741
		private global::Infragistics.Controls.Grids.ExpansionIndicatorSettings _expansionIndicators;

		// Token: 0x040006CE RID: 1742
		private global::Infragistics.Controls.Grids.ColumnMovingSettings _columnMovingSettings;

		// Token: 0x040006CF RID: 1743
		private global::Infragistics.Controls.Grids.SelectionSettings _selectionSettings;

		// Token: 0x040006D0 RID: 1744
		private global::Infragistics.Controls.Grids.FixedColumnSettings _fixedColumnSettings;

		// Token: 0x040006D1 RID: 1745
		private global::Infragistics.Controls.Grids.EditingSettings _editingSettings;

		// Token: 0x040006D2 RID: 1746
		private global::Infragistics.Controls.Grids.ColumnResizingSettings _columnResizingSettings;

		// Token: 0x040006D3 RID: 1747
		private global::Infragistics.Controls.Grids.GroupBySettings _groupBySettings;

		// Token: 0x040006D4 RID: 1748
		private global::Infragistics.Controls.Grids.DeferredScrollingSettings _deferredScrollingSettings;

		// Token: 0x040006D5 RID: 1749
		private global::Infragistics.Controls.Grids.AddNewRowSettings _addNewRowSettings;

		// Token: 0x040006D6 RID: 1750
		private global::Infragistics.Controls.Grids.FilteringSettings _filteringSettings;

		// Token: 0x040006D7 RID: 1751
		private global::Infragistics.Controls.Grids.SummaryRowSettings _summaryRowSettings;

		// Token: 0x040006D8 RID: 1752
		private global::Infragistics.Controls.Grids.FillerColumnSettings _fillerColumnSettings;

		// Token: 0x040006D9 RID: 1753
		private global::Infragistics.Controls.Grids.ConditionalFormattingSettings _conditionalFormattingSettings;

		// Token: 0x040006DA RID: 1754
		private global::Infragistics.Controls.Grids.ColumnChooserSettings _columnChooserSettings;

		// Token: 0x040006DB RID: 1755
		private global::Infragistics.Controls.Grids.ClipboardSettings _clipBoardSettings;

		// Token: 0x040006DC RID: 1756
		private global::Infragistics.Controls.Grids.SortingSettings _sortingSettings;

		// Token: 0x040006DD RID: 1757
		private global::Infragistics.Controls.Grids.PagerSettings _pagerSettings;

		// Token: 0x040006DE RID: 1758
		private global::Infragistics.Controls.Grids.CellBase _activeCell;

		// Token: 0x040006DF RID: 1759
		private global::Infragistics.Controls.Grids.CellBase _doubleClickCell;

		// Token: 0x040006E0 RID: 1760
		private global::Infragistics.Controls.Grids.CellBase _mouseDownCell;

		// Token: 0x040006E1 RID: 1761
		private global::Infragistics.Controls.Grids.CellBase _mouseOverCell;

		// Token: 0x040006E2 RID: 1762
		private global::System.Windows.Threading.DispatcherTimer _selectRowsCellsTimer;

		// Token: 0x040006E3 RID: 1763
		private global::Infragistics.DataManagerProvider _dataManagerProvider;

		// Token: 0x040006E4 RID: 1764
		private global::Infragistics.Controls.TouchScrollHelper _scrollHelper;

		// Token: 0x040006E5 RID: 1765
		private global::System.WeakReference _rootVis;

		// Token: 0x040006E6 RID: 1766
		private global::System.Windows.UIElement _mouseCaptured;

		// Token: 0x040006E7 RID: 1767
		private global::System.WeakReference _lastKeyboardObject;

		// Token: 0x040006E8 RID: 1768
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::System.Windows.DependencyProperty.Register("ItemsSource", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.ItemsSourceChanged)));

		// Token: 0x040006E9 RID: 1769
		public static readonly global::System.Windows.DependencyProperty MaxDepthProperty = global::System.Windows.DependencyProperty.Register("MaxDepth", typeof(int), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(int.MaxValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.MaxDepthChanged)));

		// Token: 0x040006EA RID: 1770
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.HeaderVisibilityChanged)));

		// Token: 0x040006EB RID: 1771
		public static readonly global::System.Windows.DependencyProperty FooterVisibilityProperty = global::System.Windows.DependencyProperty.Register("FooterVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.FooterVisibilityChanged)));

		// Token: 0x040006EC RID: 1772
		public static readonly global::System.Windows.DependencyProperty AutoGenerateColumnsProperty = global::System.Windows.DependencyProperty.Register("AutoGenerateColumns", typeof(bool), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.AutoGenerateColumnsChanged)));

		// Token: 0x040006ED RID: 1773
		public static readonly global::System.Windows.DependencyProperty IndentationProperty = global::System.Windows.DependencyProperty.Register("Indentation", typeof(double), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(30.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.IndentationChanged)));

		// Token: 0x040006EE RID: 1774
		public static readonly global::System.Windows.DependencyProperty ColumnLayoutHeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("ColumnLayoutHeaderVisibility", typeof(global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility.SiblingsExist, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.ColumnLayoutHeaderVisibilityChanged)));

		// Token: 0x040006EF RID: 1775
		public static readonly global::System.Windows.DependencyProperty IsAlternateRowsEnabledProperty = global::System.Windows.DependencyProperty.Register("IsAlternateRowsEnabled", typeof(bool), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.IsAlternateRowsEnabledChanged)));

		// Token: 0x040006F0 RID: 1776
		public static readonly global::System.Windows.DependencyProperty CellStyleProperty = global::System.Windows.DependencyProperty.Register("CellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.CellStyleChanged)));

		// Token: 0x040006F1 RID: 1777
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.HeaderStyleChanged)));

		// Token: 0x040006F2 RID: 1778
		public static readonly global::System.Windows.DependencyProperty FooterStyleProperty = global::System.Windows.DependencyProperty.Register("FooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.FooterStyleChanged)));

		// Token: 0x040006F3 RID: 1779
		public static readonly global::System.Windows.DependencyProperty FixedRowSeparatorStyleProperty = global::System.Windows.DependencyProperty.Register("FixedRowSeparatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.FixedRowSeparatorStyleChanged)));

		// Token: 0x040006F4 RID: 1780
		public static readonly global::System.Windows.DependencyProperty ChildBandHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("ChildBandHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.ChildBandHeaderStyleChanged)));

		// Token: 0x040006F5 RID: 1781
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("ColumnsHeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.ColumnsHeaderTemplateChanged)));

		// Token: 0x040006F6 RID: 1782
		public static readonly global::System.Windows.DependencyProperty ColumnsFooterTemplateProperty = global::System.Windows.DependencyProperty.Register("ColumnsFooterTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.ColumnsFooterTemplateChanged)));

		// Token: 0x040006F7 RID: 1783
		public static readonly global::System.Windows.DependencyProperty KeyboardNavigationProperty = global::System.Windows.DependencyProperty.Register("KeyboardNavigation", typeof(global::Infragistics.Controls.Grids.KeyboardNavigation), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.KeyboardNavigation.CurrentLayout));

		// Token: 0x040006F8 RID: 1784
		public static readonly global::System.Windows.DependencyProperty RowHeightProperty = global::System.Windows.DependencyProperty.Register("RowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.RowHeightChanged))));

		// Token: 0x040006F9 RID: 1785
		public static readonly global::System.Windows.DependencyProperty MinimumRowHeightProperty = global::System.Windows.DependencyProperty.Register("MinimumRowHeight", typeof(double), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(26.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.MinimumRowHeightChanged)));

		// Token: 0x040006FA RID: 1786
		public static readonly global::System.Windows.DependencyProperty DeleteKeyActionProperty = global::System.Windows.DependencyProperty.Register("DeleteKeyAction", typeof(global::Infragistics.Controls.Grids.DeleteKeyAction), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.DeleteKeyAction.None));

		// Token: 0x040006FB RID: 1787
		public static readonly global::System.Windows.DependencyProperty HeaderRowHeightProperty = global::System.Windows.DependencyProperty.Register("HeaderRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.HeaderRowHeightChanged))));

		// Token: 0x040006FC RID: 1788
		public static readonly global::System.Windows.DependencyProperty FooterRowHeightProperty = global::System.Windows.DependencyProperty.Register("FooterRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.FooterRowHeightChanged))));

		// Token: 0x040006FD RID: 1789
		public static readonly global::System.Windows.DependencyProperty ChildBandHeaderHeightProperty = global::System.Windows.DependencyProperty.Register("ChildBandHeaderHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.ChildBandHeaderHeightChanged))));

		// Token: 0x040006FE RID: 1790
		public static readonly global::System.Windows.DependencyProperty ColumnWidthProperty = global::System.Windows.DependencyProperty.Register("ColumnWidth", typeof(global::Infragistics.Controls.Grids.ColumnWidth), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.ColumnWidth.InitialAuto, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.ColumnWidth>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.ColumnWidthChanged))));

		// Token: 0x040006FF RID: 1791
		public static readonly global::System.Windows.DependencyProperty RowHoverProperty = global::System.Windows.DependencyProperty.Register("RowHover", typeof(global::Infragistics.Controls.Grids.RowHoverType), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHoverType.Cell, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.RowHoverChanged)));

		// Token: 0x04000700 RID: 1792
		public static readonly global::System.Windows.DependencyProperty HeaderTextHorizontalAlignmentProperty = global::System.Windows.DependencyProperty.Register("HeaderTextHorizontalAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::System.Windows.HorizontalAlignment.Left, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.HeaderTextHorizontalAlignmentChanged)));

		// Token: 0x04000701 RID: 1793
		public static readonly global::System.Windows.DependencyProperty HeaderTextVerticalAlignmentProperty = global::System.Windows.DependencyProperty.Register("HeaderTextVerticalAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Controls.Grids.XamGrid), new global::System.Windows.PropertyMetadata(global::System.Windows.VerticalAlignment.Center, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.HeaderTextVerticalAlignmentChanged)));

		// Token: 0x04000702 RID: 1794
		public static readonly global::System.Windows.DependencyProperty ActiveItemProperty = global::Infragistics.DependencyPropertyUtilities.Register("ActiveItem", typeof(object), typeof(global::Infragistics.Controls.Grids.XamGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.ActiveItemChanged), global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.BindsTwoWayByDefault));

		// Token: 0x04000703 RID: 1795
		public static readonly global::System.Windows.DependencyProperty IsTouchSupportEnabledProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsTouchSupportEnabled", typeof(bool), typeof(global::Infragistics.Controls.Grids.XamGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.OnIsTouchSupportEnabledChanged)));

		// Token: 0x04000704 RID: 1796
		private global::Infragistics.Controls.Grids.CellControlGenerationMode _cachedCellControlGenerationMode;

		// Token: 0x04000705 RID: 1797
		public static readonly global::System.Windows.DependencyProperty CellControlGenerationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("CellControlGenerationMode", typeof(global::Infragistics.Controls.Grids.CellControlGenerationMode), typeof(global::Infragistics.Controls.Grids.XamGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Grids.CellControlGenerationMode.Virtualize, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGrid.OnCellControlGenerationModeChanged)));

		// Token: 0x0400073A RID: 1850
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;

		// Token: 0x0400073B RID: 1851
		private global::System.Collections.Generic.List<string> _prioirtyProperties;
	}
}
