using System;
using System.Collections.Generic;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000241 RID: 577
	public class ColumnTypeMappingsCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.ColumnTypeMapping>
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x00043B32 File Offset: 0x00041D32
		public ColumnTypeMappingsCollection()
		{
			this._usedDataTypes = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Controls.Grids.ColumnTypeMapping>();
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00043B48 File Offset: 0x00041D48
		protected override void OnItemAdded(int index, global::Infragistics.Controls.Grids.ColumnTypeMapping item)
		{
			if (item == null || item.ColumnType == null || item.DataType == null)
			{
				throw new global::Infragistics.Controls.Grids.InvalidColumnTypeMappingException();
			}
			if (this._usedDataTypes.ContainsKey(item.DataType))
			{
				global::Infragistics.Controls.Grids.ColumnTypeMapping item2 = this._usedDataTypes[item.DataType];
				this.Items.Remove(item2);
				this._usedDataTypes[item.DataType] = item;
				index = this.IndexOf(item);
			}
			else
			{
				this._usedDataTypes.Add(item.DataType, item);
			}
			base.OnItemAdded(index, item);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00043BE4 File Offset: 0x00041DE4
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.Controls.Grids.ColumnTypeMapping columnTypeMapping = this.Items[index];
			this._usedDataTypes.Remove(columnTypeMapping.DataType);
			return base.RemoveItem(index);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00043C17 File Offset: 0x00041E17
		protected override void ResetItems()
		{
			this._usedDataTypes.Clear();
			base.ResetItems();
		}

		// Token: 0x040005B3 RID: 1459
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Controls.Grids.ColumnTypeMapping> _usedDataTypes;
	}
}
