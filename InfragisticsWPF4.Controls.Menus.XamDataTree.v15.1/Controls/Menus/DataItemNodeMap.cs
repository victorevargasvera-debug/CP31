using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200003A RID: 58
	internal class DataItemNodeMap
	{
		// Token: 0x06000345 RID: 837 RVA: 0x0000EC38 File Offset: 0x0000CE38
		internal DataItemNodeMap(object[] dataItems)
		{
			this._comparer = global::Infragistics.Controls.Menus.ReferenceEqualityComparer.Instance;
			this._itemsRemainingToBeMapped = ((dataItems != null) ? dataItems.Length : 0);
			this._map = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Menus.XamDataTreeNode>(this._comparer);
			if (this._itemsRemainingToBeMapped > 0)
			{
				this._dataItemsForComparison = new object[this._itemsRemainingToBeMapped];
				for (int i = 0; i < this._itemsRemainingToBeMapped; i++)
				{
					this._dataItemsForComparison[i] = dataItems[i];
					this._map[this._dataItemsForComparison[i]] = null;
				}
				this._itemsRemainingToBeMapped = this._map.Count;
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000ECD4 File Offset: 0x0000CED4
		internal void CheckMap(object item, global::System.Func<global::Infragistics.Controls.Menus.XamDataTreeNode> getNode)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
			if (this._map.TryGetValue(item, out xamDataTreeNode) && xamDataTreeNode == null)
			{
				xamDataTreeNode = getNode();
				this._map[item] = xamDataTreeNode;
				this._itemsRemainingToBeMapped--;
			}
		}

		// Token: 0x04000110 RID: 272
		internal int _itemsRemainingToBeMapped;

		// Token: 0x04000111 RID: 273
		internal global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Menus.XamDataTreeNode> _map;

		// Token: 0x04000112 RID: 274
		internal global::System.Collections.Generic.IEqualityComparer<object> _comparer;

		// Token: 0x04000113 RID: 275
		internal object[] _dataItemsForComparison;
	}
}
