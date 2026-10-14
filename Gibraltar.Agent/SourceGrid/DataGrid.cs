using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevAge.ComponentModel;
using SourceGrid.Cells;
using SourceGrid.Cells.DataGrid;
using SourceGrid.Selection;

namespace SourceGrid
{
	// Token: 0x02000400 RID: 1024
	[global::System.ComponentModel.ToolboxItem(true)]
	internal class DataGrid : global::SourceGrid.GridVirtual
	{
		// Token: 0x06002D2E RID: 11566 RVA: 0x000980BC File Offset: 0x000962BC
		public DataGrid()
		{
			base.FixedRows = 1;
			base.FixedColumns = 0;
			base.Controller.AddController(new global::SourceGrid.DataGridCellController());
			base.SelectionMode = global::SourceGrid.GridSelectionMode.Row;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00098118 File Offset: 0x00096318
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00098124 File Offset: 0x00096324
		protected override global::SourceGrid.RowsBase CreateRowsObject()
		{
			return new global::SourceGrid.DataGridRows(this);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x0009812C File Offset: 0x0009632C
		protected override global::SourceGrid.ColumnsBase CreateColumnsObject()
		{
			return new global::SourceGrid.DataGridColumns(this);
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00098134 File Offset: 0x00096334
		protected override global::SourceGrid.Selection.SelectionBase CreateSelectionObject()
		{
			global::SourceGrid.Selection.SelectionBase selectionBase = base.CreateSelectionObject();
			selectionBase.EnableMultiSelection = false;
			selectionBase.FocusStyle = global::SourceGrid.FocusStyle.RemoveFocusCellOnLeave;
			selectionBase.FocusRowLeaving += this.Selection_FocusRowLeaving;
			return selectionBase;
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x00098170 File Offset: 0x00096370
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x00098178 File Offset: 0x00096378
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::DevAge.ComponentModel.IBoundList DataSource
		{
			get
			{
				return this.mBoundList;
			}
			set
			{
				this.Unbind();
				this.mBoundList = value;
				if (this.mBoundList != null)
				{
					this.Bind();
				}
			}
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00098198 File Offset: 0x00096398
		protected virtual void Unbind()
		{
			if (this.mBoundList != null)
			{
				this.mBoundList.ListChanged -= this.mBoundList_ListChanged;
			}
			this.Rows.RowsChanged();
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x000981C8 File Offset: 0x000963C8
		protected virtual void Bind()
		{
			if (this.Columns.Count == 0)
			{
				this.CreateColumns();
			}
			this.mBoundList.ListChanged += this.mBoundList_ListChanged;
			this.Rows.RowsChanged();
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x00098214 File Offset: 0x00096414
		public new global::SourceGrid.DataGridRows Rows
		{
			get
			{
				return (global::SourceGrid.DataGridRows)base.Rows;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x00098224 File Offset: 0x00096424
		public new global::SourceGrid.DataGridColumns Columns
		{
			get
			{
				return (global::SourceGrid.DataGridColumns)base.Columns;
			}
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00098234 File Offset: 0x00096434
		protected virtual void mBoundList_ListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			this.Rows.RowsChanged();
			base.Invalidate(true);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00098248 File Offset: 0x00096448
		public override global::SourceGrid.Cells.ICellVirtual GetCell(int row, int column)
		{
			global::SourceGrid.Cells.ICellVirtual result;
			try
			{
				if (this.mBoundList != null)
				{
					if (row < base.FixedRows)
					{
						result = this.Columns[column].HeaderCell;
					}
					else
					{
						result = this.Columns[column].GetDataCell(row);
					}
				}
				else
				{
					result = null;
				}
			}
			catch (global::System.Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x000982BC File Offset: 0x000964BC
		protected override void OnSortingRangeRows(global::SourceGrid.SortRangeRowsEventArgs e)
		{
			base.OnSortingRangeRows(e);
			if (this.DataSource == null || !this.DataSource.AllowSort)
			{
				return;
			}
			global::System.ComponentModel.PropertyDescriptor propertyColumn = this.Columns[e.KeyColumn].PropertyColumn;
			if (propertyColumn != null)
			{
				global::System.ComponentModel.ListSortDirection direction;
				if (e.Ascending)
				{
					direction = global::System.ComponentModel.ListSortDirection.Ascending;
				}
				else
				{
					direction = global::System.ComponentModel.ListSortDirection.Descending;
				}
				global::System.ComponentModel.ListSortDescription[] sorts = new global::System.ComponentModel.ListSortDescription[]
				{
					new global::System.ComponentModel.ListSortDescription(propertyColumn, direction)
				};
				this.DataSource.ApplySort(new global::System.ComponentModel.ListSortDescriptionCollection(sorts));
				return;
			}
			this.DataSource.ApplySort(null);
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00098354 File Offset: 0x00096554
		public void CreateColumns()
		{
			this.Columns.Clear();
			if (this.DataSource != null)
			{
				int num = 0;
				if (base.FixedColumns > 0)
				{
					this.Columns.Insert(num, global::SourceGrid.DataGridColumn.CreateRowHeader(this));
					num++;
				}
				foreach (object obj in this.DataSource.GetItemProperties())
				{
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
					this.Columns.Add(propertyDescriptor.Name, propertyDescriptor.DisplayName, global::SourceGrid.Cells.DataGrid.Cell.Create(propertyDescriptor.PropertyType, !propertyDescriptor.IsReadOnly));
				}
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x0009841C File Offset: 0x0009661C
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x000984C4 File Offset: 0x000966C4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public object[] SelectedDataRows
		{
			get
			{
				if (this.mBoundList == null)
				{
					return new global::System.Data.DataRowView[0];
				}
				int[] rowsIndex = base.Selection.GetSelectionRegion().GetRowsIndex();
				int num = 0;
				for (int i = 0; i < rowsIndex.Length; i++)
				{
					object obj = this.Rows.IndexToDataSourceRow(rowsIndex[i]);
					if (obj != null)
					{
						num++;
					}
				}
				object[] array = new object[num];
				int num2 = 0;
				for (int j = 0; j < rowsIndex.Length; j++)
				{
					object obj2 = this.Rows.IndexToDataSourceRow(rowsIndex[j]);
					if (obj2 != null)
					{
						array[num2] = obj2;
						num2++;
					}
				}
				return array;
			}
			set
			{
				base.Selection.ResetSelection(false);
				if (this.mBoundList != null && value != null)
				{
					for (int i = 0; i < value.Length; i++)
					{
						for (int j = base.FixedRows; j < this.Rows.Count; j++)
						{
							object objA = this.Rows.IndexToDataSourceRow(j);
							if (object.ReferenceEquals(objA, value[i]))
							{
								base.Selection.SelectRow(j, true);
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00098550 File Offset: 0x00096750
		protected override void OnKeyDown(global::System.Windows.Forms.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyCode == global::System.Windows.Forms.Keys.Delete && this.mBoundList != null && this.mBoundList.AllowDelete && !e.Handled && this.mDeleteRowsWithDeleteKey)
			{
				object[] selectedDataRows = this.SelectedDataRows;
				if (selectedDataRows != null && selectedDataRows.Length > 0)
				{
					this.DeleteSelectedRows();
				}
				e.Handled = true;
				return;
			}
			if (e.KeyCode == global::System.Windows.Forms.Keys.Escape && !e.Handled && this.mCancelEditingWithEscapeKey)
			{
				this.EndEditingRow(true);
				e.Handled = true;
			}
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x000985FC File Offset: 0x000967FC
		protected override void OnValidating(global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnValidating(e);
			try
			{
				if (this.EndEditingRowOnValidate)
				{
					this.EndEditingRow(false);
				}
			}
			catch (global::System.Exception p_Exception)
			{
				this.OnUserException(new global::SourceGrid.ExceptionEventArgs(p_Exception));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x0009864C File Offset: 0x0009684C
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00098654 File Offset: 0x00096854
		[global::System.ComponentModel.DefaultValue(true)]
		public bool EndEditingRowOnValidate
		{
			get
			{
				return this.mEndEditingRowOnValidate;
			}
			set
			{
				this.mEndEditingRowOnValidate = value;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x00098660 File Offset: 0x00096860
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x00098668 File Offset: 0x00096868
		[global::System.ComponentModel.DefaultValue(true)]
		public bool DeleteRowsWithDeleteKey
		{
			get
			{
				return this.mDeleteRowsWithDeleteKey;
			}
			set
			{
				this.mDeleteRowsWithDeleteKey = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x00098674 File Offset: 0x00096874
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x0009867C File Offset: 0x0009687C
		[global::System.ComponentModel.DefaultValue(true)]
		public bool CancelEditingWithEscapeKey
		{
			get
			{
				return this.mCancelEditingWithEscapeKey;
			}
			set
			{
				this.mCancelEditingWithEscapeKey = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x00098688 File Offset: 0x00096888
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x00098690 File Offset: 0x00096890
		public string DeleteQuestionMessage
		{
			get
			{
				return this.mDeleteQuestionMessage;
			}
			set
			{
				this.mDeleteQuestionMessage = value;
			}
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x0009869C File Offset: 0x0009689C
		public virtual bool DeleteSelectedRows()
		{
			if (string.IsNullOrEmpty(this.mDeleteQuestionMessage) || global::System.Windows.Forms.MessageBox.Show(this, this.mDeleteQuestionMessage, global::System.Windows.Forms.Application.ProductName, global::System.Windows.Forms.MessageBoxButtons.YesNo, global::System.Windows.Forms.MessageBoxIcon.Question) == global::System.Windows.Forms.DialogResult.Yes)
			{
				foreach (int gridRowIndex in base.Selection.GetSelectionRegion().GetRowsIndex())
				{
					int num = this.Rows.IndexToDataSourceIndex(gridRowIndex);
					if (num < this.DataSource.Count)
					{
						this.DataSource.RemoveAt(num);
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x0009872C File Offset: 0x0009692C
		public override void AutoSizeCells()
		{
			this.Columns.AutoSizeView();
			if (this.Rows.Count > 1)
			{
				this.Rows.AutoSizeRow(1);
				return;
			}
			if (this.Rows.Count > 0)
			{
				this.Rows.AutoSizeRow(0);
			}
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00098784 File Offset: 0x00096984
		private void Selection_FocusRowLeaving(object sender, global::SourceGrid.RowCancelEventArgs e)
		{
			try
			{
				this.EndEditingRow(false);
			}
			catch (global::System.Exception innerException)
			{
				this.OnUserException(new global::SourceGrid.ExceptionEventArgs(new global::SourceGrid.EndEditingException(innerException)));
				e.Cancel = true;
			}
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000987CC File Offset: 0x000969CC
		public bool BeginEditRow(int gridRow)
		{
			if (this.mEditingRow != null && this.mEditingRow.Value == gridRow)
			{
				return true;
			}
			this.EndEditingRow(false);
			if (this.DataSource != null)
			{
				int num = this.Rows.IndexToDataSourceIndex(gridRow);
				if (!this.DataSource.AllowEdit)
				{
					return false;
				}
				if (num == this.DataSource.Count && this.DataSource.AllowNew)
				{
					this.DataSource.BeginAddNew();
				}
				else if (num < this.DataSource.Count)
				{
					this.DataSource.BeginEdit(num);
				}
			}
			this.mEditingRow = new int?(gridRow);
			return true;
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x00098890 File Offset: 0x00096A90
		public void EndEditingRow(bool cancel)
		{
			if (this.mBoundList != null)
			{
				this.mBoundList.EndEdit(cancel);
			}
			this.mEditingRow = null;
		}

		// Token: 0x04000F57 RID: 3927
		private global::DevAge.ComponentModel.IBoundList mBoundList;

		// Token: 0x04000F58 RID: 3928
		private bool mEndEditingRowOnValidate = true;

		// Token: 0x04000F59 RID: 3929
		private bool mDeleteRowsWithDeleteKey = true;

		// Token: 0x04000F5A RID: 3930
		private bool mCancelEditingWithEscapeKey = true;

		// Token: 0x04000F5B RID: 3931
		private string mDeleteQuestionMessage = "Are you sure to delete all the selected rows?";

		// Token: 0x04000F5C RID: 3932
		private int? mEditingRow;
	}
}
