using System;
using System.ComponentModel;
using Infragistics.Controls.Grids;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics
{
	// Token: 0x02000082 RID: 130
	public class FilteringDataContext : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000480 RID: 1152 RVA: 0x000151B5 File Offset: 0x000133B5
		public FilteringDataContext(global::Infragistics.Controls.Grids.Primitives.FilterRowCell frc)
		{
			this.Cell = frc;
			this.RowData = frc.Row.Data;
			this._filterCellValue = frc.FilterCellValueResolved;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x000151E1 File Offset: 0x000133E1
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x000151EC File Offset: 0x000133EC
		internal global::Infragistics.Controls.Grids.Primitives.FilterRowCell Cell
		{
			get
			{
				return this._cell;
			}
			set
			{
				if (this._cell != value)
				{
					if (this._cell != null)
					{
						this._cell.PropertyChanged -= this.Cell_PropertyChanged;
					}
					this._cell = value;
					if (this._cell != null)
					{
						this._cell.PropertyChanged += this.Cell_PropertyChanged;
					}
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00015247 File Offset: 0x00013447
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x0001524F File Offset: 0x0001344F
		public object Value
		{
			get
			{
				return this._filterCellValue;
			}
			set
			{
				if (this._filterCellValue != value)
				{
					this._filterCellValue = value;
					this.OnValueChanged();
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00015267 File Offset: 0x00013467
		public string ColumnKey
		{
			get
			{
				return this._cell.Column.Key;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00015279 File Offset: 0x00013479
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00015281 File Offset: 0x00013481
		public object RowData { get; protected set; }

		// Token: 0x06000488 RID: 1160 RVA: 0x0001528A File Offset: 0x0001348A
		private void Cell_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "FilterCellValueResolved")
			{
				this._filterCellValue = this.Cell.FilterCellValueResolved;
				this.OnPropertyChanged("Value");
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000489 RID: 1161 RVA: 0x000152BC File Offset: 0x000134BC
		// (remove) Token: 0x0600048A RID: 1162 RVA: 0x000152F4 File Offset: 0x000134F4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600048B RID: 1163 RVA: 0x00015329 File Offset: 0x00013529
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00015348 File Offset: 0x00013548
		protected virtual void OnValueChanged()
		{
			if (this.Cell.Row.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ChildBand)
			{
				this.Cell.FilterCellValue = this._filterCellValue;
				return;
			}
			this.Cell.Column.FilterColumnSettings.FilterCellValue = this._filterCellValue;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001539E File Offset: 0x0001359E
		protected void SetValueSilent(object value)
		{
			this._filterCellValue = value;
		}

		// Token: 0x04000133 RID: 307
		private global::Infragistics.Controls.Grids.Primitives.FilterRowCell _cell;

		// Token: 0x04000134 RID: 308
		private object _filterCellValue;
	}
}
