using System;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000276 RID: 630
	public class FilterRow : global::Infragistics.Controls.Grids.Row
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x0004D090 File Offset: 0x0004B290
		protected internal static bool IsNullableValueType(global::System.Type dataType)
		{
			if (dataType != null)
			{
				bool isGenericType = dataType.IsGenericType;
				if (isGenericType && dataType.GetGenericTypeDefinition().Equals(typeof(global::System.Nullable<>)))
				{
					global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(dataType);
					return underlyingType.IsValueType;
				}
			}
			return false;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0004D0D8 File Offset: 0x0004B2D8
		private static bool IsNullableVersionOfType(global::System.Type sourceType, global::System.Type comparisonType)
		{
			if (sourceType != null && comparisonType != null)
			{
				bool isGenericType = sourceType.IsGenericType;
				if (isGenericType && sourceType.GetGenericTypeDefinition().Equals(typeof(global::System.Nullable<>)))
				{
					global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(sourceType);
					return underlyingType == comparisonType;
				}
			}
			return false;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0004D128 File Offset: 0x0004B328
		protected internal static object ChangeType(object value, global::System.Type dataType)
		{
			bool isGenericType = dataType.IsGenericType;
			if (isGenericType && dataType.GetGenericTypeDefinition().Equals(typeof(global::System.Nullable<>)))
			{
				if (value == null)
				{
					return null;
				}
				dataType = global::System.Nullable.GetUnderlyingType(dataType);
			}
			bool isEnum = dataType.IsEnum;
			if (isEnum && value != null)
			{
				return global::System.Enum.Parse(dataType, value.ToString(), true);
			}
			return global::System.Convert.ChangeType(value, dataType, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0004D18A File Offset: 0x0004B38A
		protected internal FilterRow(global::Infragistics.Controls.Grids.RowsManager manager) : base(-1, manager, null)
		{
			base.FixedPositionSortOrder = 3;
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0004D19C File Offset: 0x0004B39C
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.FilterRow;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0004D1A0 File Offset: 0x0004B3A0
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (base.Height != null)
				{
					return base.Height.Value;
				}
				return this.ColumnLayout.FilteringSettings.FilterRowHeightResolved;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0004D1DC File Offset: 0x0004B3DC
		public override bool HasChildren
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0004D1DF File Offset: 0x0004B3DF
		protected internal override global::Infragistics.Controls.Grids.EditingType AllowEditing
		{
			get
			{
				return global::Infragistics.Controls.Grids.EditingType.Cell;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0004D1E2 File Offset: 0x0004B3E2
		protected internal override bool AllowSelection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x0004D1E5 File Offset: 0x0004B3E5
		protected internal override bool AllowKeyboardNavigation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x0004D1E8 File Offset: 0x0004B3E8
		protected internal override bool IsStandAloneRow
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x0004D1EC File Offset: 0x0004B3EC
		protected internal override bool IsStandAloneRowResolved
		{
			get
			{
				global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)base.Manager;
				if (rowsManager.DataManager != null)
				{
					return rowsManager.DataManager.TotalRecordCount > 0;
				}
				return this.IsStandAloneRow;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0004D222 File Offset: 0x0004B422
		protected internal override bool RequiresFixedRowSeparator
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0004D225 File Offset: 0x0004B425
		protected internal void SetData(object data)
		{
			base.Data = data;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0004D230 File Offset: 0x0004B430
		protected internal override void CellEditorValueChanged(global::Infragistics.Controls.Grids.CellBase cellBase, object newValue)
		{
			global::Infragistics.Controls.Grids.Column column = cellBase.Column;
			if (column.AllowCellEditorValueChangedFiltering && this.ColumnLayout != null)
			{
				this.BuildFilters(cellBase, newValue, true);
				this.RaiseFilteredEvent();
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0004D264 File Offset: 0x0004B464
		protected internal bool BuildFilters(global::Infragistics.Controls.Grids.CellBase cellBase, object newValue, bool fireEvents)
		{
			global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)cellBase.Row.Manager;
			global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = (global::Infragistics.Controls.Grids.Primitives.FilterRowCell)cellBase;
			return this.ColumnLayout.BuildFilters(rowsManager.RowFiltersCollectionResolved, newValue, filterRowCell.Column, filterRowCell.FilteringOperandResolved, false, fireEvents);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0004D2AC File Offset: 0x0004B4AC
		protected internal void RemoveFilters(global::Infragistics.Controls.Grids.Primitives.FilterRowCell cellBase)
		{
			cellBase.Row.ColumnLayout.Grid.ExitEditMode(false);
			global::Infragistics.Controls.Grids.Column column = cellBase.Column;
			cellBase.SilentUpdate = true;
			cellBase.Column.FilterColumnSettings.SilentUpdate = true;
			object filterCellValue;
			if (column.DataType == null)
			{
				filterCellValue = null;
			}
			else if (typeof(bool) == column.DataType || global::Infragistics.Controls.Grids.Primitives.FilterRow.IsNullableVersionOfType(column.DataType, typeof(bool)))
			{
				filterCellValue = null;
			}
			else if (global::Infragistics.Controls.Grids.Primitives.FilterRow.IsNullableValueType(column.DataType))
			{
				filterCellValue = null;
			}
			else if (column.DataType.IsValueType)
			{
				filterCellValue = null;
			}
			else if (column.DataType == typeof(string))
			{
				filterCellValue = "";
			}
			else
			{
				filterCellValue = null;
			}
			cellBase.FilterCellValue = filterCellValue;
			cellBase.Column.FilterColumnSettings.FilterCellValue = filterCellValue;
			cellBase.SilentUpdate = false;
			cellBase.Column.FilterColumnSettings.SilentUpdate = false;
			global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)base.Manager;
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowsManager.RowFiltersCollectionResolved[cellBase.Column.Key];
			if (rowsFilter != null)
			{
				rowsFilter.Conditions.ClearSilently();
			}
			this.ColumnLayout.InvalidateFiltering();
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0004D3EC File Offset: 0x0004B5EC
		internal void RaiseFilteredEvent()
		{
			global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)base.Manager;
			this.ColumnLayout.Grid.OnFiltered(rowsManager.RowFiltersCollectionResolved);
		}
	}
}
