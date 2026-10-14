using System;
using System.ComponentModel;
using System.Data;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001F2 RID: 498
	public class DataColumnPropertyDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x0600129A RID: 4762 RVA: 0x000421DC File Offset: 0x000403DC
		public DataColumnPropertyDescriptor(global::System.Data.DataColumn column) : base(column.ColumnName, null)
		{
			if (column == null)
			{
				throw new global::System.ArgumentNullException("column");
			}
			this._column = column;
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00042200 File Offset: 0x00040400
		public global::System.Data.DataColumn Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00042208 File Offset: 0x00040408
		public override global::System.Type ComponentType
		{
			get
			{
				return typeof(global::System.Data.DataRow);
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00042214 File Offset: 0x00040414
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x00042218 File Offset: 0x00040418
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

		// Token: 0x0600129F RID: 4767 RVA: 0x0004224C File Offset: 0x0004044C
		public override object GetValue(object component)
		{
			global::System.Data.DataRow row = global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor.GetRow(component);
			return row[this._column];
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0004226C File Offset: 0x0004046C
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x000422A8 File Offset: 0x000404A8
		public override global::System.Type PropertyType
		{
			get
			{
				return this._column.DataType;
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000422B5 File Offset: 0x000404B5
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000422B7 File Offset: 0x000404B7
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000422BA File Offset: 0x000404BA
		public override bool IsBrowsable
		{
			get
			{
				return this._column.ColumnMapping != global::System.Data.MappingType.Hidden && base.IsBrowsable;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x000422D2 File Offset: 0x000404D2
		public override bool IsReadOnly
		{
			get
			{
				return this._column.ReadOnly;
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000422E0 File Offset: 0x000404E0
		public override void SetValue(object component, object value)
		{
			global::System.Data.DataRow row = global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor.GetRow(component);
			row[this._column] = value;
		}

		// Token: 0x040009AB RID: 2475
		private global::System.Data.DataColumn _column;
	}
}
