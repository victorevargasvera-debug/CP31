using System;
using System.Collections;

namespace Infragistics.Collections
{
	// Token: 0x0200005D RID: 93
	public class MultiSourceEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x060003AD RID: 941 RVA: 0x00010220 File Offset: 0x0000E420
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0001029C File Offset: 0x0000E49C
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

		// Token: 0x060003AF RID: 943 RVA: 0x000102DC File Offset: 0x0000E4DC
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

		// Token: 0x060003B0 RID: 944 RVA: 0x0001035C File Offset: 0x0000E55C
		public void Reset()
		{
			this._currentEnumeratorIndex = -1;
			this._currentItem = global::Infragistics.Collections.MultiSourceEnumerator.UnsetObjectMarker;
			for (int i = 0; i < this._sourceEnumerators.Length; i++)
			{
				this._sourceEnumerators[i].Reset();
			}
		}

		// Token: 0x04000142 RID: 322
		private global::System.Collections.IEnumerator[] _sourceEnumerators;

		// Token: 0x04000143 RID: 323
		private int _currentEnumeratorIndex;

		// Token: 0x04000144 RID: 324
		private object _currentItem;

		// Token: 0x04000145 RID: 325
		private static object UnsetObjectMarker = new object();
	}
}
