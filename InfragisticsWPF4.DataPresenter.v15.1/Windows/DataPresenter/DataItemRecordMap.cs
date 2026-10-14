using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DE RID: 478
	internal class DataItemRecordMap
	{
		// Token: 0x06001C82 RID: 7298 RVA: 0x00081DFC File Offset: 0x0007FFFC
		internal DataItemRecordMap(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, object[] dataItems)
		{
			this._comparer = dp.DataItemEqualityComparerResolved;
			this._itemsRemainingToBeMapped = ((dataItems != null) ? dataItems.Length : 0);
			this._map = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord>(this._comparer);
			if (this._itemsRemainingToBeMapped > 0)
			{
				this._dataItemsForComparison = new object[this._itemsRemainingToBeMapped];
				for (int i = 0; i < this._itemsRemainingToBeMapped; i++)
				{
					this._dataItemsForComparison[i] = global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(dataItems[i]);
					this._map[this._dataItemsForComparison[i]] = null;
				}
				this._itemsRemainingToBeMapped = this._map.Count;
			}
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00081E9C File Offset: 0x0008009C
		internal void CheckMap(object item, global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecord> getRecord)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
			if (this._map.TryGetValue(item, out dataRecord) && dataRecord == null)
			{
				dataRecord = getRecord();
				this._map[item] = dataRecord;
				this._itemsRemainingToBeMapped--;
			}
		}

		// Token: 0x04000BFB RID: 3067
		internal int _itemsRemainingToBeMapped;

		// Token: 0x04000BFC RID: 3068
		internal global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> _map;

		// Token: 0x04000BFD RID: 3069
		internal global::System.Collections.Generic.IEqualityComparer<object> _comparer;

		// Token: 0x04000BFE RID: 3070
		internal object[] _dataItemsForComparison;
	}
}
