using System;
using System.Collections;

namespace Infragistics.Collections
{
	// Token: 0x0200007F RID: 127
	public class SingleItemEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x00013948 File Offset: 0x00011B48
		public SingleItemEnumerator(object item)
		{
			this._item = item;
			this._currentItem = global::Infragistics.Collections.SingleItemEnumerator.UnsetObjectMarker;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00013962 File Offset: 0x00011B62
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

		// Token: 0x0600051D RID: 1309 RVA: 0x000139A0 File Offset: 0x00011BA0
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

		// Token: 0x0600051E RID: 1310 RVA: 0x000139F1 File Offset: 0x00011BF1
		public void Reset()
		{
			this._currentItem = global::Infragistics.Collections.SingleItemEnumerator.UnsetObjectMarker;
			this._endReached = false;
		}

		// Token: 0x040001AF RID: 431
		private object _currentItem;

		// Token: 0x040001B0 RID: 432
		private object _item;

		// Token: 0x040001B1 RID: 433
		private bool _endReached;

		// Token: 0x040001B2 RID: 434
		private static object UnsetObjectMarker = new object();
	}
}
