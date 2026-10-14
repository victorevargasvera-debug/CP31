using System;
using System.Collections;

namespace Infragistics.Collections
{
	// Token: 0x02000096 RID: 150
	public class SingleItemEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x000163A7 File Offset: 0x000145A7
		public SingleItemEnumerator(object item)
		{
			this._item = item;
			this._currentItem = global::Infragistics.Collections.SingleItemEnumerator.UnsetObjectMarker;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x000163C1 File Offset: 0x000145C1
		public object Current
		{
			get
			{
				if (this._currentItem != global::Infragistics.Collections.SingleItemEnumerator.UnsetObjectMarker)
				{
					return this._currentItem;
				}
				if (this._endReached)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_4"));
				}
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_3"));
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00016400 File Offset: 0x00014600
		public bool MoveNext()
		{
			if (this._endReached)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_4"));
			}
			if (this._item == null || this._currentItem == this._item)
			{
				this._endReached = true;
				return false;
			}
			this._currentItem = this._item;
			return true;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00016451 File Offset: 0x00014651
		public void Reset()
		{
			this._currentItem = global::Infragistics.Collections.SingleItemEnumerator.UnsetObjectMarker;
			this._endReached = false;
		}

		// Token: 0x04000225 RID: 549
		private object _currentItem;

		// Token: 0x04000226 RID: 550
		private object _item;

		// Token: 0x04000227 RID: 551
		private bool _endReached;

		// Token: 0x04000228 RID: 552
		private static object UnsetObjectMarker = new object();
	}
}
