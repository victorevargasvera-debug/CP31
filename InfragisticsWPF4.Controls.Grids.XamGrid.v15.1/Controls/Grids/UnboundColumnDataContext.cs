using System;
using System.ComponentModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000268 RID: 616
	public class UnboundColumnDataContext : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0004AA40 File Offset: 0x00048C40
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x0004AA48 File Offset: 0x00048C48
		public object RowData
		{
			get
			{
				return this._rowData;
			}
			protected internal set
			{
				if (this._rowData != value)
				{
					this._rowData = value;
					this.OnPropertyChanged("RowData");
				}
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0004AA65 File Offset: 0x00048C65
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x0004AA6D File Offset: 0x00048C6D
		public object Value
		{
			get
			{
				return this._value;
			}
			protected internal set
			{
				if (this._value != value)
				{
					this._value = value;
					this.OnPropertyChanged("Value");
				}
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0004AA8A File Offset: 0x00048C8A
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x0004AA92 File Offset: 0x00048C92
		public string ColumnKey
		{
			get
			{
				return this._columnKey;
			}
			protected internal set
			{
				if (this._columnKey != value)
				{
					this._columnKey = value;
					this.OnPropertyChanged("ColumnKey");
				}
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060013DE RID: 5086 RVA: 0x0004AAB4 File Offset: 0x00048CB4
		// (remove) Token: 0x060013DF RID: 5087 RVA: 0x0004AAEC File Offset: 0x00048CEC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060013E0 RID: 5088 RVA: 0x0004AB24 File Offset: 0x00048D24
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000610 RID: 1552
		private object _rowData;

		// Token: 0x04000611 RID: 1553
		private object _value;

		// Token: 0x04000612 RID: 1554
		private string _columnKey;
	}
}
