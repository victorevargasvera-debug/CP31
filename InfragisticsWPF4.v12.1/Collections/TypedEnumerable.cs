using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x02000084 RID: 132
	public class TypedEnumerable<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x000140CC File Offset: 0x000122CC
		public TypedEnumerable(global::System.Collections.IEnumerable e)
		{
			this._e = (e ?? new T[0]);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000140E5 File Offset: 0x000122E5
		internal void ResetSourceEnumerable(global::System.Collections.IEnumerable e)
		{
			this._e = (e ?? new T[0]);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000140F8 File Offset: 0x000122F8
		private global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::Infragistics.Collections.TypedEnumerable<T>.Enumerator(this._e.GetEnumerator());
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0001410A File Offset: 0x0001230A
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00014112 File Offset: 0x00012312
		global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040001E9 RID: 489
		private global::System.Collections.IEnumerable _e;

		// Token: 0x02000085 RID: 133
		internal class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06000534 RID: 1332 RVA: 0x0001411A File Offset: 0x0001231A
			public Enumerator(global::System.Collections.IEnumerator e)
			{
				this._e = e;
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00014129 File Offset: 0x00012329
			public void Reset()
			{
				this._e.Reset();
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x00014136 File Offset: 0x00012336
			public bool MoveNext()
			{
				return this._e.MoveNext();
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x06000537 RID: 1335 RVA: 0x00014143 File Offset: 0x00012343
			public T Current
			{
				get
				{
					return (T)((object)this._e.Current);
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x06000538 RID: 1336 RVA: 0x00014155 File Offset: 0x00012355
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x00014162 File Offset: 0x00012362
			public void Dispose()
			{
			}

			// Token: 0x040001EA RID: 490
			private global::System.Collections.IEnumerator _e;
		}
	}
}
