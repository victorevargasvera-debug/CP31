using System;
using System.ComponentModel;
using System.Data;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001C4 RID: 452
	public class DataColumnPropertyDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x060010C9 RID: 4297 RVA: 0x0003CA9C File Offset: 0x0003AC9C
		public DataColumnPropertyDescriptor(global::System.Data.DataColumn column) : base(column.ColumnName, null)
		{
			if (column == null)
			{
				throw new global::System.ArgumentNullException("column");
			}
			this._column = column;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x0003CAC0 File Offset: 0x0003ACC0
		public global::System.Data.DataColumn Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0003CAC8 File Offset: 0x0003ACC8
		public override global::System.Type ComponentType
		{
			get
			{
				return typeof(global::System.Data.DataRow);
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0003CAD4 File Offset: 0x0003ACD4
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0003CAD8 File Offset: 0x0003ACD8
		public override string DisplayName
		{
			get
			{
				string caption = this._column.Caption;
				if (caption != null && caption.Length > 0)
				{
					return caption;
				}
				return this._column.ColumnName;
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0003CB0C File Offset: 0x0003AD0C
		public override object GetValue(object component)
		{
			global::System.Data.DataRow row = global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor.GetRow(component);
			return row[this._column];
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0003CB2C File Offset: 0x0003AD2C
		private static global::System.Data.DataRow GetRow(object component)
		{
			global::System.Data.DataRow dataRow = component as global::System.Data.DataRow;
			if (dataRow == null)
			{
				global::System.Data.DataRowView dataRowView = component as global::System.Data.DataRowView;
				if (dataRowView != null)
				{
					dataRow = dataRowView.Row;
				}
			}
			if (dataRow == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_1"));
			}
			return dataRow;
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0003CB68 File Offset: 0x0003AD68
		public override global::System.Type PropertyType
		{
			get
			{
				return this._column.DataType;
			}
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0003CB75 File Offset: 0x0003AD75
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0003CB77 File Offset: 0x0003AD77
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0003CB7A File Offset: 0x0003AD7A
		public override bool IsBrowsable
		{
			get
			{
				return this._column.ColumnMapping != global::System.Data.MappingType.Hidden && base.IsBrowsable;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0003CB92 File Offset: 0x0003AD92
		public override bool IsReadOnly
		{
			get
			{
				return this._column.ReadOnly;
			}
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0003CBA0 File Offset: 0x0003ADA0
		public override void SetValue(object component, object value)
		{
			global::System.Data.DataRow row = global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor.GetRow(component);
			row[this._column] = value;
		}

		// Token: 0x0400086A RID: 2154
		private global::System.Data.DataColumn _column;
	}
}
