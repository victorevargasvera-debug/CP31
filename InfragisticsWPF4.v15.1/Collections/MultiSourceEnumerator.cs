using System;
using System.Collections;

namespace Infragistics.Collections
{
	// Token: 0x02000074 RID: 116
	public class MultiSourceEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x00012858 File Offset: 0x00010A58
		public MultiSourceEnumerator(params global::System.Collections.IEnumerator[] sourceEnumerators)
		{
			if (sourceEnumerators == null)
			{
				throw new global::System.ArgumentNullException("sourceEnumerators");
			}
			if (sourceEnumerators.Length == 0)
			{
				throw new global::System.ArgumentException("sourceEnumerators", global::SR.GetString("LE_ArgumentException_20"));
			}
			for (int i = 0; i < sourceEnumerators.Length; i++)
			{
				if (sourceEnumerators[i] == null)
				{
					throw new global::System.ArgumentException("sourceEnumerators", global::SR.GetString("LE_ArgumentException_20"));
				}
			}
			this._sourceEnumerators = sourceEnumerators;
			this._currentEnumeratorIndex = -1;
			this._currentItem = global::Infragistics.Collections.MultiSourceEnumerator.UnsetObjectMarker;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x000128D4 File Offset: 0x00010AD4
		public object Current
		{
			get
			{
				if (this._currentItem != global::Infragistics.Collections.MultiSourceEnumerator.UnsetObjectMarker)
				{
					return this._currentItem;
				}
				if (this._currentEnumeratorIndex == -1)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_3"));
				}
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_4"));
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00012914 File Offset: 0x00010B14
		public bool MoveNext()
		{
			if (this._currentEnumeratorIndex < 0)
			{
				this._currentEnumeratorIndex = 0;
			}
			if (this._sourceEnumerators[this._currentEnumeratorIndex].MoveNext())
			{
				this._currentItem = this._sourceEnumerators[this._currentEnumeratorIndex].Current;
				return true;
			}
			if (this._currentEnumeratorIndex < this._sourceEnumerators.Length - 1)
			{
				this._currentEnumeratorIndex++;
				return ((global::System.Collections.IEnumerator)this).MoveNext();
			}
			this._currentItem = global::Infragistics.Collections.MultiSourceEnumerator.UnsetObjectMarker;
			return false;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00012994 File Offset: 0x00010B94
		public void Reset()
		{
			this._currentEnumeratorIndex = -1;
			this._currentItem = global::Infragistics.Collections.MultiSourceEnumerator.UnsetObjectMarker;
			for (int i = 0; i < this._sourceEnumerators.Length; i++)
			{
				this._sourceEnumerators[i].Reset();
			}
		}

		// Token: 0x040001B0 RID: 432
		private global::System.Collections.IEnumerator[] _sourceEnumerators;

		// Token: 0x040001B1 RID: 433
		private int _currentEnumeratorIndex;

		// Token: 0x040001B2 RID: 434
		private object _currentItem;

		// Token: 0x040001B3 RID: 435
		private static object UnsetObjectMarker = new object();
	}
}
