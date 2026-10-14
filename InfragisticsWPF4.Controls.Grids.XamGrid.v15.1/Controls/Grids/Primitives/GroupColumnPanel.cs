using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000251 RID: 593
	public class GroupColumnPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x0004617E File Offset: 0x0004437E
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x00046190 File Offset: 0x00044390
		public global::Infragistics.Controls.Grids.CellBase Cell
		{
			get
			{
				return (global::Infragistics.Controls.Grids.CellBase)base.GetValue(global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel.CellProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel.CellProperty, value);
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000461A0 File Offset: 0x000443A0
		private static void CellChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel groupColumnPanel = (global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel)obj;
			groupColumnPanel.ReleaseUsedCells();
			if (e.NewValue != null)
			{
				groupColumnPanel.InvalidateMeasure();
				global::Infragistics.Controls.Grids.CellBase cellBase = (global::Infragistics.Controls.Grids.CellBase)e.NewValue;
				groupColumnPanel._previousColumns = groupColumnPanel.Column.AllColumns;
				foreach (global::Infragistics.Controls.Grids.Column column in groupColumnPanel._previousColumns)
				{
					column.PropertyChanged += groupColumnPanel.Col_PropertyChanged;
				}
				groupColumnPanel.Column.Columns.CollectionChanged += groupColumnPanel.Columns_CollectionChanged;
			}
			if (e.OldValue != null)
			{
				global::Infragistics.Controls.Grids.CellBase cellBase2 = (global::Infragistics.Controls.Grids.CellBase)e.OldValue;
				foreach (global::Infragistics.Controls.Grids.Column column2 in groupColumnPanel._previousColumns)
				{
					column2.PropertyChanged -= groupColumnPanel.Col_PropertyChanged;
				}
				global::Infragistics.Controls.Grids.GroupColumn groupColumn = (global::Infragistics.Controls.Grids.GroupColumn)cellBase2.Column;
				groupColumn.Columns.CollectionChanged -= groupColumnPanel.Columns_CollectionChanged;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000462E0 File Offset: 0x000444E0
		public global::Infragistics.Controls.Grids.RowBase Row
		{
			get
			{
				if (this.Cell != null)
				{
					return this.Cell.Row;
				}
				return null;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000462F7 File Offset: 0x000444F7
		public global::Infragistics.Controls.Grids.GroupColumn Column
		{
			get
			{
				if (this.Cell != null)
				{
					return this.Cell.Column as global::Infragistics.Controls.Grids.GroupColumn;
				}
				return null;
			}
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00046314 File Offset: 0x00044514
		protected double SetupStarCells(double availableWidth, double currentWidth, ref double maxHeight, global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns)
		{
			double num = availableWidth - currentWidth;
			double num2 = num;
			double num3 = 0.0;
			if (num > 0.0)
			{
				if (starColumns.Count <= 0)
				{
					goto IL_719;
				}
				double num4 = 0.0;
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase in starColumns)
				{
					num4 += cellBase.Column.WidthResolved.Value;
				}
				if (num4 == 0.0)
				{
					goto IL_719;
				}
				double num5 = num / num4;
				bool flag = false;
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>(starColumns);
				do
				{
					flag = false;
					global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>();
					foreach (global::Infragistics.Controls.Grids.CellBase cellBase2 in list)
					{
						double num6 = (double)((int)num5) * cellBase2.Column.WidthResolved.Value;
						if (num6 < cellBase2.Column.MinimumWidth)
						{
							num -= cellBase2.Column.MinimumWidth;
							num4 -= cellBase2.Column.WidthResolved.Value;
							cellBase2.Column.ActualWidth = cellBase2.Column.MinimumWidth;
							if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase2.Column))
							{
								this.Row.Manager.StarColumnWidths.Add(cellBase2.Column, cellBase2.Column.MinimumWidth);
							}
							else
							{
								this.Row.Manager.StarColumnWidths[cellBase2.Column] = cellBase2.Column.MinimumWidth;
							}
							flag = true;
						}
						else
						{
							list2.Add(cellBase2);
						}
					}
					list = list2;
					num5 = num / num4;
				}
				while (flag);
				if (num > 0.0)
				{
					if (list.Count > 0)
					{
						foreach (global::Infragistics.Controls.Grids.CellBase cellBase3 in list)
						{
							cellBase3.Column.ActualWidth = (double)((int)num5) * cellBase3.Column.WidthResolved.Value;
							if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase3.Column))
							{
								this.Row.Manager.StarColumnWidths.Add(cellBase3.Column, cellBase3.Column.ActualWidth);
							}
							else
							{
								this.Row.Manager.StarColumnWidths[cellBase3.Column] = cellBase3.Column.ActualWidth;
							}
							num3 += num5 - (double)((int)num5);
						}
						int num7 = 0;
						while (num3 > 1.0)
						{
							global::Infragistics.Controls.Grids.CellBase cellBase4 = starColumns[num7];
							cellBase4.Column.ActualWidth += 1.0;
							if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase4.Column))
							{
								this.Row.Manager.StarColumnWidths.Add(cellBase4.Column, cellBase4.Column.ActualWidth);
							}
							else
							{
								this.Row.Manager.StarColumnWidths[cellBase4.Column] = cellBase4.Column.ActualWidth;
							}
							num7++;
							num3 -= 1.0;
						}
						list[list.Count - 1].Column.ActualWidth += num3;
					}
				}
				else
				{
					num2 = 0.0;
					foreach (global::Infragistics.Controls.Grids.CellBase cellBase5 in list)
					{
						cellBase5.Column.ActualWidth = cellBase5.Column.MinimumWidth;
						if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase5.Column))
						{
							this.Row.Manager.StarColumnWidths.Add(cellBase5.Column, cellBase5.Column.ActualWidth);
						}
						else
						{
							this.Row.Manager.StarColumnWidths[cellBase5.Column] = cellBase5.Column.ActualWidth;
						}
					}
				}
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.CellBase> enumerator5 = starColumns.GetEnumerator())
				{
					while (enumerator5.MoveNext())
					{
						global::Infragistics.Controls.Grids.CellBase cellBase6 = enumerator5.Current;
						double num8 = 0.0;
						if (this.Row.Manager.StarColumnWidths.ContainsKey(cellBase6.Column))
						{
							num8 = this.Row.Manager.StarColumnWidths[cellBase6.Column];
						}
						if (cellBase6.Column.AllowToolTips == global::Infragistics.Controls.Grids.AllowToolTips.Overflow)
						{
							global::Infragistics.Controls.Grids.CellControl cellControl = cellBase6.Control as global::Infragistics.Controls.Grids.CellControl;
							if (cellControl != null)
							{
								cellControl.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
								double width = cellControl.DesiredSize.Width;
								if (width > num8)
								{
									cellControl.ShowToolTip();
								}
								else
								{
									cellControl.HideToolTip();
								}
							}
						}
						cellBase6.Control.MeasureRaised = false;
						cellBase6.Control.Measure(new global::System.Windows.Size(num8, double.PositiveInfinity));
						if (!cellBase6.Control.MeasureRaised)
						{
							global::System.Windows.FrameworkElement frameworkElement = cellBase6.Control.Content as global::System.Windows.FrameworkElement;
							if (frameworkElement != null && (frameworkElement.DesiredSize.Width > cellBase6.Control.DesiredSize.Width || frameworkElement.DesiredSize.Width < 10.0))
							{
								cellBase6.Control.Measure(new global::System.Windows.Size(1.0, 1.0));
								cellBase6.Control.Measure(new global::System.Windows.Size(num8, double.PositiveInfinity));
							}
						}
						num2 -= num8;
						maxHeight = global::System.Math.Max(maxHeight, cellBase6.Control.DesiredSize.Height);
					}
					goto IL_719;
				}
			}
			num2 = 0.0;
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase7 in starColumns)
			{
				cellBase7.Column.ActualWidth = cellBase7.Column.MinimumWidth;
				if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase7.Column))
				{
					this.Row.Manager.StarColumnWidths.Add(cellBase7.Column, cellBase7.Column.ActualWidth);
				}
				else
				{
					this.Row.Manager.StarColumnWidths[cellBase7.Column] = cellBase7.Column.ActualWidth;
				}
				num2 -= cellBase7.Column.ActualWidth;
			}
			IL_719:
			if (double.IsInfinity(num2))
			{
				num2 = 0.0;
			}
			return currentWidth + global::System.Math.Abs(num2);
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00046AE8 File Offset: 0x00044CE8
		internal void ReleaseUsedCells()
		{
			if (this._usedCells.Count > 0)
			{
				foreach (global::Infragistics.Controls.Grids.CellBase obj in this._usedCells)
				{
					global::Infragistics.RecyclingManager.Manager.ReleaseElement(obj, this);
				}
				this._usedCells.Clear();
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00046B5C File Offset: 0x00044D5C
		internal static void InitializeColumnActualWidths(global::Infragistics.Controls.Grids.GroupColumnsCollection columns, global::Infragistics.Controls.Grids.RowBase row, double availableWidth = -1.0)
		{
			foreach (global::Infragistics.Controls.Grids.Column column in columns)
			{
				if (column.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase = row.ResolveCell(column);
					if (cellBase != null)
					{
						global::Infragistics.Controls.Grids.Primitives.CellControlBase control = cellBase.Control;
						if (control != null)
						{
							double width = control.DesiredSize.Width;
							global::Infragistics.Controls.Grids.ColumnWidthType columnWidthType = column.WidthResolved.WidthType;
							if (double.IsPositiveInfinity(availableWidth) && columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star)
							{
								columnWidthType = global::Infragistics.Controls.Grids.ColumnWidthType.Auto;
							}
							switch (columnWidthType)
							{
							case global::Infragistics.Controls.Grids.ColumnWidthType.Auto:
								if (column.ActualWidth < width)
								{
									column.ActualWidth = width;
								}
								break;
							case global::Infragistics.Controls.Grids.ColumnWidthType.InitialAuto:
								if (column.ActualWidth == 0.0)
								{
									column.IsInitialAutoSet = false;
								}
								if (!column.IsInitialAutoSet && column.ActualWidth < width)
								{
									column.ActualWidth = width;
								}
								break;
							case global::Infragistics.Controls.Grids.ColumnWidthType.SizeToHeader:
								if (row is global::Infragistics.Controls.Grids.Primitives.HeaderRow && column.ActualWidth < width)
								{
									column.ActualWidth = width;
								}
								break;
							case global::Infragistics.Controls.Grids.ColumnWidthType.SizeToCells:
								if (!(row is global::Infragistics.Controls.Grids.Primitives.HeaderRow) && !(row is global::Infragistics.Controls.Grids.Primitives.FooterRow) && column.ActualWidth < width)
								{
									column.ActualWidth = width;
								}
								break;
							case global::Infragistics.Controls.Grids.ColumnWidthType.Star:
								continue;
							case global::Infragistics.Controls.Grids.ColumnWidthType.Numeric:
								column.ActualWidth = column.WidthResolved.Value;
								break;
							}
							if (column.ActualWidth < column.MinimumWidth)
							{
								double height = (row.HeightResolved.HeightType == global::Infragistics.Controls.Grids.RowHeightType.Numeric) ? row.HeightResolved.Value : double.PositiveInfinity;
								column.ActualWidth = column.MinimumWidth;
								if (cellBase.Control != null)
								{
									cellBase.Control.Measure(new global::System.Windows.Size(column.ActualWidth, height));
								}
							}
							if (column.ActualWidth > column.MaximumWidth)
							{
								column.ActualWidth = column.MaximumWidth;
							}
						}
					}
				}
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00046D4C File Offset: 0x00044F4C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this._inMeasure = true;
			if (this.Row == null)
			{
				return base.MeasureOverride(availableSize);
			}
			double num = 0.0;
			double num2 = 0.0;
			if (this.Column != null && this.Cell.Control != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>(this._usedCells);
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase in list)
				{
					if (cellBase.Row != this.Row)
					{
						global::Infragistics.RecyclingManager.Manager.ReleaseElement(cellBase, this);
						this._usedCells.Remove(cellBase);
					}
				}
				global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
				foreach (global::Infragistics.Controls.Grids.Column column in this.Column.Columns)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase2 = this.Row.ResolveCell(column);
					if (column.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						if (cellBase2 != null)
						{
							global::Infragistics.Controls.Grids.ColumnWidth widthResolved = column.WidthResolved;
							global::Infragistics.Controls.Grids.ColumnWidthType columnWidthType = widthResolved.WidthType;
							double num3 = double.PositiveInfinity;
							if (columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Numeric)
							{
								num3 = widthResolved.Value;
							}
							else if (double.IsPositiveInfinity(availableSize.Width) && columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star)
							{
								columnWidthType = global::Infragistics.Controls.Grids.ColumnWidthType.Auto;
							}
							else if (columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.InitialAuto && column.IsInitialAutoSet)
							{
								num3 = column.ActualWidth;
							}
							double num4 = double.PositiveInfinity;
							global::Infragistics.Controls.Grids.RowHeight heightResolved = this.Row.HeightResolved;
							if (heightResolved.HeightType == global::Infragistics.Controls.Grids.RowHeightType.Numeric)
							{
								num4 = heightResolved.Value;
							}
							if (cellBase2.Control != null && cellBase2.Control.Parent != this)
							{
								global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel groupColumnPanel = cellBase2.Control.Parent as global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel;
								if (groupColumnPanel != null)
								{
									global::Infragistics.RecyclingManager.Manager.ReleaseElement(cellBase2, groupColumnPanel);
									groupColumnPanel._usedCells.Remove(cellBase2);
								}
								else
								{
									global::Infragistics.Controls.Grids.Primitives.CellsPanel cellsPanel = cellBase2.Control.Parent as global::Infragistics.Controls.Grids.Primitives.CellsPanel;
									if (cellsPanel != null)
									{
										cellsPanel.ReleaseCell(cellBase2);
									}
								}
							}
							global::System.Windows.Size size = global::System.Windows.Size.Empty;
							if (cellBase2.Control == null)
							{
								if (!this._usedCells.Contains(cellBase2))
								{
									this._usedCells.Add(cellBase2);
								}
								global::Infragistics.RecyclingManager.Manager.AttachElement(cellBase2, this);
								cellBase2.Control.EnsureContent();
								cellBase2.MeasuringSize = global::System.Windows.Size.Empty;
								cellBase2.EnsureCurrentState();
							}
							else
							{
								cellBase2.ApplyStyle();
								cellBase2.Control.EnsureContent();
								cellBase2.EnsureCurrentState();
							}
							if (columnWidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star)
							{
								if (cellBase2.MeasuringSize.IsEmpty)
								{
									size = new global::System.Windows.Size(num3, num4);
								}
								else
								{
									size = cellBase2.MeasuringSize;
								}
								cellBase2.Control.MeasureRaised = false;
								cellBase2.Control.Measure(size);
								if (!cellBase2.Control.MeasureRaised)
								{
									global::System.Windows.FrameworkElement frameworkElement = cellBase2.Control.Content as global::System.Windows.FrameworkElement;
									if (frameworkElement != null && (frameworkElement.DesiredSize.Width > cellBase2.Control.DesiredSize.Width || frameworkElement.DesiredSize.Width < 10.0))
									{
										cellBase2.Control.Measure(new global::System.Windows.Size(1.0, 1.0));
										cellBase2.Control.Measure(new global::System.Windows.Size(num3, num4));
									}
								}
								if (!cellBase2.Control.MeasureRaised)
								{
									cellBase2.Control.ManuallyInvokeMeasure(size);
								}
							}
							global::Infragistics.Controls.Grids.Primitives.CellControlBase control = cellBase2.Control;
							double width = control.DesiredSize.Width;
							if (column.AllowToolTips == global::Infragistics.Controls.Grids.AllowToolTips.Overflow)
							{
								global::Infragistics.Controls.Grids.CellControl cellControl = control as global::Infragistics.Controls.Grids.CellControl;
								if (cellControl != null && (num3 != double.PositiveInfinity || num4 != double.PositiveInfinity) && cellBase2.MeasuringSize.IsEmpty)
								{
									control.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
									double width2 = control.DesiredSize.Width;
									control.Measure(new global::System.Windows.Size(num3, num4));
									if (width2 > width)
									{
										cellControl.ShowToolTip();
									}
									else
									{
										cellControl.HideToolTip();
									}
								}
							}
						}
					}
					else
					{
						cellBase2.MeasuringSize = global::System.Windows.Size.Empty;
					}
				}
				global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel.InitializeColumnActualWidths(this.Column.Columns, this.Row, availableSize.Width);
				foreach (global::Infragistics.Controls.Grids.Column column2 in this.Column.Columns)
				{
					if (column2.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						global::Infragistics.Controls.Grids.CellBase cellBase3 = this.Row.ResolveCell(column2);
						if (column2.WidthResolved.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star && !double.IsPositiveInfinity(availableSize.Width))
						{
							collection.Add(cellBase3);
						}
						else
						{
							num2 = global::System.Math.Max(num2, cellBase3.Control.DesiredSize.Height);
							num += column2.ActualWidth;
						}
					}
				}
				if (collection.Count > 0)
				{
					this.SetupStarCells(availableSize.Width, num, ref num2, collection);
					num = global::System.Math.Max(num, availableSize.Width);
				}
				if (collection.Count <= 0 || this.Column.WidthResolved.WidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star)
				{
					this.Column.Width = new global::Infragistics.Controls.Grids.ColumnWidth?(new global::Infragistics.Controls.Grids.ColumnWidth(num, false));
				}
			}
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00047310 File Offset: 0x00045510
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this._inMeasure = false;
			global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> availableElements = global::Infragistics.RecyclingManager.Manager.GetAvailableElements(this);
			foreach (global::System.Windows.FrameworkElement frameworkElement in availableElements)
			{
				frameworkElement.Arrange(new global::System.Windows.Rect(-1000.0, -1000.0, 0.0, 0.0));
			}
			if (this.Column != null && this.Row != null && this.Cell.Control != null)
			{
				double num = 0.0;
				foreach (global::Infragistics.Controls.Grids.Column column in this.Column.Columns)
				{
					if (!column.IsInitialAutoSet)
					{
						bool flag = false;
						global::Infragistics.Controls.Grids.RowsManager rowsManager = this.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
						if (rowsManager != null)
						{
							flag = rowsManager.RegisteredTopRows.Contains(this.Row);
							if (!flag)
							{
								flag = rowsManager.RegisteredBottomRows.Contains(this.Row);
							}
						}
						if (!flag && this.Cell != null && this.Cell.Control.IsCellLoaded)
						{
							column.IsInitialAutoSet = true;
						}
					}
					global::Infragistics.Controls.Grids.CellBase cellBase = this.Row.ResolveCell(column);
					if (cellBase != null && cellBase.Control != null)
					{
						if (column.IsMoving)
						{
							cellBase.Control.Arrange(new global::System.Windows.Rect(num, 0.0, 0.0, 0.0));
							num += column.ActualWidth;
						}
						else
						{
							double x = num;
							if (column.PercentMoved > 0.0)
							{
								if (!column.ReverseMove)
								{
									x = num - column.MovingColumnsWidth + column.MovingColumnsWidth * column.PercentMoved;
								}
								else
								{
									x = num + column.MovingColumnsWidth - column.MovingColumnsWidth * column.PercentMoved;
								}
							}
							if (cellBase.Column.ActualWidth == 0.0 && cellBase.Column.Visibility == global::System.Windows.Visibility.Visible && cellBase.Column.WidthResolved.Value != 0.0)
							{
								base.InvalidateMeasure();
								break;
							}
							cellBase.Control.Arrange(new global::System.Windows.Rect(x, 0.0, column.ActualWidth, finalSize.Height));
							num += column.ActualWidth;
						}
					}
				}
			}
			return finalSize;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000475CC File Offset: 0x000457CC
		private void Columns_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._previousColumns != null)
			{
				foreach (global::Infragistics.Controls.Grids.Column column in this._previousColumns)
				{
					column.PropertyChanged -= this.Col_PropertyChanged;
				}
			}
			if (this.Column != null)
			{
				this._previousColumns = this.Column.AllColumns;
				foreach (global::Infragistics.Controls.Grids.Column column2 in this._previousColumns)
				{
					column2.PropertyChanged += this.Col_PropertyChanged;
				}
				if (!this._inMeasure)
				{
					base.InvalidateMeasure();
					return;
				}
			}
			else
			{
				this._previousColumns = null;
			}
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x000476A4 File Offset: 0x000458A4
		private void Col_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (!this._inMeasure && e.PropertyName != "IsSorted")
			{
				base.InvalidateMeasure();
			}
		}

		// Token: 0x040005D9 RID: 1497
		private bool _inMeasure;

		// Token: 0x040005DA RID: 1498
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> _usedCells = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>();

		// Token: 0x040005DB RID: 1499
		private global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> _previousColumns;

		// Token: 0x040005DC RID: 1500
		public static readonly global::System.Windows.DependencyProperty CellProperty = global::System.Windows.DependencyProperty.Register("Cell", typeof(global::Infragistics.Controls.Grids.CellBase), typeof(global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel.CellChanged)));
	}
}
