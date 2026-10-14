using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000315 RID: 789
	internal sealed class SchemaElementLookUpTableEnumerator<T, S> : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator where T : S where S : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x060025AE RID: 9646 RVA: 0x0006A8D7 File Offset: 0x00068AD7
		public SchemaElementLookUpTableEnumerator(global::System.Collections.Generic.Dictionary<string, S> data, global::System.Collections.Generic.List<string> keysInOrder)
		{
			this._data = data;
			this._enumerator = keysInOrder.GetEnumerator();
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x0006A8F2 File Offset: 0x00068AF2
		public void Reset()
		{
			((global::System.Collections.IEnumerator)this._enumerator).Reset();
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x0006A904 File Offset: 0x00068B04
		public T Current
		{
			get
			{
				string key = this._enumerator.Current;
				return this._data[key] as T;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x0006A938 File Offset: 0x00068B38
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				string key = this._enumerator.Current;
				return this._data[key] as T;
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0006A971 File Offset: 0x00068B71
		public bool MoveNext()
		{
			while (this._enumerator.MoveNext())
			{
				if (this.Current != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x0006A992 File Offset: 0x00068B92
		public void Dispose()
		{
		}

		// Token: 0x04000D3F RID: 3391
		private readonly global::System.Collections.Generic.Dictionary<string, S> _data;

		// Token: 0x04000D40 RID: 3392
		private global::System.Collections.Generic.List<string>.Enumerator _enumerator;
	}
}
