using System;
using System.ComponentModel;
using System.Data;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001CA RID: 458
	public class DataTablePropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
	{
		// Token: 0x06001106 RID: 4358 RVA: 0x0003DD6E File Offset: 0x0003BF6E
		public DataTablePropertyDescriptorProvider(global::System.Data.DataTable table) : base(table)
		{
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0003DD77 File Offset: 0x0003BF77
		public global::System.Data.DataTable Table
		{
			get
			{
				return base.Source as global::System.Data.DataTable;
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0003DD84 File Offset: 0x0003BF84
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
		{
			if (this._properties == null)
			{
				global::System.Data.DataTable table = this.Table;
				global::System.ComponentModel.PropertyDescriptor[] array = new global::System.ComponentModel.PropertyDescriptor[table.Columns.Count];
				for (int i = 0; i < table.Columns.Count; i++)
				{
					array[i] = new global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor(table.Columns[i]);
				}
				this._properties = new global::System.ComponentModel.PropertyDescriptorCollection(array, true);
			}
			return this._properties;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0003DDEE File Offset: 0x0003BFEE
		public override string Name
		{
			get
			{
				return this.Table.TableName;
			}
		}

		// Token: 0x04000879 RID: 2169
		private global::System.ComponentModel.PropertyDescriptorCollection _properties;
	}
}
