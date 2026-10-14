using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200026A RID: 618
	public abstract class RowBase : global::Infragistics.RecyclingContainer<global::Infragistics.Controls.Grids.Primitives.CellsPanel>, global::System.IDisposable
	{
		// Token: 0x060013ED RID: 5101 RVA: 0x0004B074 File Offset: 0x00049274
		protected RowBase(global::Infragistics.Controls.Grids.RowsManagerBase manager)
		{
			this.Manager = manager;
			this.Index = -1;
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0004B08A File Offset: 0x0004928A
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0004B092 File Offset: 0x00049292
		public object Data { get; protected internal set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0004B09B File Offset: 0x0004929B
		public virtual global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout
		{
			get
			{
				return this.Manager.ColumnLayout;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0004B0A8 File Offset: 0x000492A8
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x0004B0B0 File Offset: 0x000492B0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Grids.RowsManagerBase Manager { get; protected internal set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0004B0B9 File Offset: 0x000492B9
		public virtual global::Infragistics.Controls.Grids.Primitives.CellBaseCollection Cells
		{
			get
			{
				if (this._cells == null)
				{
					this._cells = new global::Infragistics.Controls.Grids.Primitives.CellBaseCollection(this.Columns, this);
				}
				return this._cells;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0004B0DB File Offset: 0x000492DB
		public global::Infragistics.Controls.Grids.Primitives.CellsPanel Control
		{
			get
			{
				return this._control;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0004B0E3 File Offset: 0x000492E3
		public global::Infragistics.Controls.Grids.ColumnBaseCollection Columns
		{
			get
			{
				return this.ColumnLayout.Columns;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0004B0F0 File Offset: 0x000492F0
		public virtual bool IsAlternateRow
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0004B0F3 File Offset: 0x000492F3
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0004B0FB File Offset: 0x000492FB
		public double ActualHeight { get; internal set; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0004B104 File Offset: 0x00049304
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x0004B10C File Offset: 0x0004930C
		public bool IsMouseOver
		{
			get
			{
				return this._isMouseOver;
			}
			protected internal set
			{
				this._isMouseOver = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0004B115 File Offset: 0x00049315
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x0004B11D File Offset: 0x0004931D
		public bool IsActive { get; protected internal set; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0004B126 File Offset: 0x00049326
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x0004B12E File Offset: 0x0004932E
		public object Tag { get; set; }

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0004B137 File Offset: 0x00049337
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x0004B13F File Offset: 0x0004933F
		public int Index { get; protected internal set; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0004B148 File Offset: 0x00049348
		public int Level
		{
			get
			{
				return this.Manager.Level;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001402 RID: 5122
		public abstract global::Infragistics.Controls.Grids.RowType RowType { get; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0004B155 File Offset: 0x00049355
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0004B15D File Offset: 0x0004935D
		public global::Infragistics.Controls.Grids.RowHeight? Height
		{
			get
			{
				return this._height;
			}
			set
			{
				this._height = value;
				this.OnPropertyChanged("Height");
				if (this.ColumnLayout != null && this.ColumnLayout.Grid != null)
				{
					this.ColumnLayout.Grid.InvalidateScrollPanel(false);
				}
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0004B198 File Offset: 0x00049398
		public virtual global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (this.Height == null)
				{
					return this.ColumnLayout.RowHeightResolved;
				}
				return this.Height.Value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0004B1CF File Offset: 0x000493CF
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x0004B1D7 File Offset: 0x000493D7
		public double? MinimumRowHeight
		{
			get
			{
				return this._minRowHeight;
			}
			set
			{
				this._minRowHeight = value;
				this.OnPropertyChanged("MinimumRowHeight");
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0004B1EC File Offset: 0x000493EC
		public double MinimumRowHeightResolved
		{
			get
			{
				if (this.MinimumRowHeight == null)
				{
					return this.ColumnLayout.MinimumRowHeightResolved;
				}
				return this.MinimumRowHeight.Value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0004B224 File Offset: 0x00049424
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0004B22C File Offset: 0x0004942C
		public global::Infragistics.MergedRowInfo MergeData { get; protected internal set; }

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0004B235 File Offset: 0x00049435
		protected internal virtual global::Infragistics.Controls.Grids.RowHoverType ResolveRowHover
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHoverType.None;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0004B238 File Offset: 0x00049438
		protected internal virtual global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> VisibleCells
		{
			get
			{
				global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
				if (this.ColumnLayout != null && this.ColumnLayout.Grid != null && this.ColumnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
				{
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = this.ColumnLayout.Grid.GroupBySettings.GroupByColumns[this.ColumnLayout];
					foreach (global::Infragistics.Controls.Grids.Column column in readOnlyCollection)
					{
						if (column.Visibility == global::System.Windows.Visibility.Visible && column.SupportsActivationAndSelection)
						{
							collection.Add(this.Cells[column]);
						}
					}
				}
				foreach (global::Infragistics.Controls.Grids.Column column2 in this.Columns.FixedColumnsLeft)
				{
					if (column2.Visibility == global::System.Windows.Visibility.Visible)
					{
						if (column2.SupportsActivationAndSelection)
						{
							collection.Add(this.Cells[column2]);
						}
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns = column2.AllColumns;
						if (allColumns.Count > 0)
						{
							foreach (global::Infragistics.Controls.Grids.Column column3 in allColumns)
							{
								if (column3.SupportsActivationAndSelection && column3.Visibility == global::System.Windows.Visibility.Visible)
								{
									collection.Add(this.Cells[column3]);
								}
							}
						}
					}
				}
				foreach (global::Infragistics.Controls.Grids.Column column4 in this.Columns.VisibleColumns)
				{
					if (column4 != this.Columns.FillerColumn && column4.Visibility == global::System.Windows.Visibility.Visible)
					{
						if (column4.SupportsActivationAndSelection)
						{
							collection.Add(this.Cells[column4]);
						}
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns2 = column4.AllColumns;
						if (allColumns2.Count > 0)
						{
							foreach (global::Infragistics.Controls.Grids.Column column5 in allColumns2)
							{
								if (column5.SupportsActivationAndSelection && column5.Visibility == global::System.Windows.Visibility.Visible)
								{
									global::Infragistics.Controls.Grids.GroupColumn groupColumn = column5.ParentColumn as global::Infragistics.Controls.Grids.GroupColumn;
									if (groupColumn != null)
									{
										bool flag = this.AreParentsVisible(column5);
										if (flag)
										{
											collection.Add(this.Cells[column5]);
										}
									}
									else
									{
										collection.Add(this.Cells[column5]);
									}
								}
							}
						}
					}
				}
				global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsRight = this.Columns.FixedColumnsRight;
				int count = fixedColumnsRight.Count;
				for (int i = count - 1; i >= 0; i--)
				{
					global::Infragistics.Controls.Grids.Column column6 = fixedColumnsRight[i];
					if (column6.Visibility == global::System.Windows.Visibility.Visible && column6 != this.Columns.FillerColumn)
					{
						if (column6.SupportsActivationAndSelection)
						{
							collection.Add(this.Cells[column6]);
						}
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns3 = column6.AllColumns;
						if (allColumns3.Count > 0)
						{
							foreach (global::Infragistics.Controls.Grids.Column column7 in allColumns3)
							{
								if (column7.SupportsActivationAndSelection && column7.Visibility == global::System.Windows.Visibility.Visible)
								{
									collection.Add(this.Cells[column7]);
								}
							}
						}
					}
				}
				return collection;
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0004B5D8 File Offset: 0x000497D8
		private bool AreParentsVisible(global::Infragistics.Controls.Grids.Column column)
		{
			return column == null || column.ParentColumn == null || (column.ParentColumn.Visibility == global::System.Windows.Visibility.Visible && this.AreParentsVisible(column.ParentColumn));
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0004B604 File Offset: 0x00049804
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x0004B60C File Offset: 0x0004980C
		protected internal int FixedPositionSortOrder { get; set; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0004B615 File Offset: 0x00049815
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0004B61D File Offset: 0x0004981D
		protected internal global::System.Collections.IEnumerable ItemSource
		{
			get
			{
				return this._itemSource;
			}
			set
			{
				if (value != this._itemSource)
				{
					this._itemSource = value;
					this.OnItemSourceChanged();
				}
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0004B635 File Offset: 0x00049835
		protected internal virtual bool CanScrollHorizontally
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0004B638 File Offset: 0x00049838
		protected internal virtual global::Infragistics.Controls.Grids.EditingType AllowEditing
		{
			get
			{
				return global::Infragistics.Controls.Grids.EditingType.None;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0004B63B File Offset: 0x0004983B
		protected internal virtual bool AllowKeyboardNavigation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0004B63E File Offset: 0x0004983E
		protected internal virtual bool AllowSelection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0004B641 File Offset: 0x00049841
		protected internal virtual bool IsStandAloneRow
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0004B644 File Offset: 0x00049844
		protected internal virtual bool IsStandAloneRowResolved
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0004B647 File Offset: 0x00049847
		protected internal virtual bool RequiresFixedRowSeparator
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0004B64A File Offset: 0x0004984A
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x0004B652 File Offset: 0x00049852
		internal bool IsHorizontallyAlignedBy { get; set; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0004B65B File Offset: 0x0004985B
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0004B663 File Offset: 0x00049863
		internal bool ShouldInvalidateHorizontalScroll { get; set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0004B66C File Offset: 0x0004986C
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0004B674 File Offset: 0x00049874
		internal int CachedClipboardIndex { get; set; }

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0004B67D File Offset: 0x0004987D
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x0004B685 File Offset: 0x00049885
		internal bool InCellConverter { get; set; }

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0004B68E File Offset: 0x0004988E
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x0004B696 File Offset: 0x00049896
		internal bool IgnoreCellControlAttached { get; set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0004B69F File Offset: 0x0004989F
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x0004B6A7 File Offset: 0x000498A7
		internal bool SkipApplyStyle { get; set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0004B6B0 File Offset: 0x000498B0
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x0004B6B8 File Offset: 0x000498B8
		internal bool IsMouseOverInternal
		{
			get
			{
				return this._isMouseOver;
			}
			set
			{
				this._isMouseOver = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0004B6C1 File Offset: 0x000498C1
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0004B6C9 File Offset: 0x000498C9
		internal bool IsReleasingCells { get; set; }

		// Token: 0x06001429 RID: 5161 RVA: 0x0004B6D2 File Offset: 0x000498D2
		protected internal virtual global::Infragistics.Controls.Grids.CellBase ResolveCell(global::Infragistics.Controls.Grids.Column column)
		{
			return this.Cells[column];
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0004B6E0 File Offset: 0x000498E0
		protected internal virtual void CellEditorValueChanged(global::Infragistics.Controls.Grids.CellBase cellBase, object newValue)
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0004B6E2 File Offset: 0x000498E2
		protected virtual void OnItemSourceChanged()
		{
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0004B6E4 File Offset: 0x000498E4
		protected internal virtual object GetCellValue(global::Infragistics.Controls.Grids.Column column)
		{
			return null;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0004B6E7 File Offset: 0x000498E7
		internal global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator ResolveSeparator()
		{
			if (this._fixedSeparator == null)
			{
				this._fixedSeparator = new global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator();
			}
			return this._fixedSeparator;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0004B702 File Offset: 0x00049902
		protected override void OnElementAttached(global::Infragistics.Controls.Grids.Primitives.CellsPanel element)
		{
			this._control = element;
			this._control.OnAttached(this);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0004B717 File Offset: 0x00049917
		protected override void OnElementReleased(global::Infragistics.Controls.Grids.Primitives.CellsPanel element)
		{
			this._control = null;
			element.OnReleased();
			this._isMouseOver = false;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0004B72D File Offset: 0x0004992D
		protected override global::Infragistics.Controls.Grids.Primitives.CellsPanel CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.CellsPanel();
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0004B734 File Offset: 0x00049934
		protected virtual void Dispose(bool disposing)
		{
			if (this._cells != null)
			{
				this._cells.Dispose();
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0004B749 File Offset: 0x00049949
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400061B RID: 1563
		private global::Infragistics.Controls.Grids.Primitives.CellsPanel _control;

		// Token: 0x0400061C RID: 1564
		private global::Infragistics.Controls.Grids.Primitives.CellBaseCollection _cells;

		// Token: 0x0400061D RID: 1565
		private global::Infragistics.Controls.Grids.RowHeight? _height;

		// Token: 0x0400061E RID: 1566
		private double? _minRowHeight;

		// Token: 0x0400061F RID: 1567
		private global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator _fixedSeparator;

		// Token: 0x04000620 RID: 1568
		private global::System.Collections.IEnumerable _itemSource;

		// Token: 0x04000621 RID: 1569
		private bool _isMouseOver;
	}
}
