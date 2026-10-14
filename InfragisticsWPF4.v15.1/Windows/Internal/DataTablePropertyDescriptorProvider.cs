using System;
using System.ComponentModel;
using System.Data;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001F8 RID: 504
	public class DataTablePropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x000434AE File Offset: 0x000416AE
		public DataTablePropertyDescriptorProvider(global::System.Data.DataTable table) : base(table)
		{
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x000434B7 File Offset: 0x000416B7
		public global::System.Data.DataTable Table
		{
			get
			{
				return base.Source as global::System.Data.DataTable;
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000434C4 File Offset: 0x000416C4
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

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x0004352E File Offset: 0x0004172E
		public override string Name
		{
			get
			{
				return this.Table.TableName;
			}
		}

		// Token: 0x040009BA RID: 2490
		private global::System.ComponentModel.PropertyDescriptorCollection _properties;
	}
}
