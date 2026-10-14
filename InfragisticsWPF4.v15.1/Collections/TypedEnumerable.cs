using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x0200009B RID: 155
	public class TypedEnumerable<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x00016B2C File Offset: 0x00014D2C
		public TypedEnumerable(global::System.Collections.IEnumerable e)
		{
			this._e = (e ?? new T[0]);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00016B45 File Offset: 0x00014D45
		internal void ResetSourceEnumerable(global::System.Collections.IEnumerable e)
		{
			this._e = (e ?? new T[0]);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00016B58 File Offset: 0x00014D58
		private global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::Infragistics.Collections.TypedEnumerable<T>.Enumerator(this._e.GetEnumerator());
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00016B6A File Offset: 0x00014D6A
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00016B72 File Offset: 0x00014D72
		global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400025F RID: 607
		private global::System.Collections.IEnumerable _e;

		// Token: 0x0200009C RID: 156
		internal class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060005F7 RID: 1527 RVA: 0x00016B7A File Offset: 0x00014D7A
			public Enumerator(global::System.Collections.IEnumerator e)
			{
				this._e = e;
			}

			// Token: 0x060005F8 RID: 1528 RVA: 0x00016B89 File Offset: 0x00014D89
			public void Reset()
			{
				this._e.Reset();
			}

			// Token: 0x060005F9 RID: 1529 RVA: 0x00016B96 File Offset: 0x00014D96
			public bool MoveNext()
			{
				return this._e.MoveNext();
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060005FA RID: 1530 RVA: 0x00016BA3 File Offset: 0x00014DA3
			public T Current
			{
				get
				{
					return (T)((object)this._e.Current);
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060005FB RID: 1531 RVA: 0x00016BB5 File Offset: 0x00014DB5
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x00016BC2 File Offset: 0x00014DC2
			public void Dispose()
			{
			}

			// Token: 0x04000260 RID: 608
			private global::System.Collections.IEnumerator _e;
		}
	}
}
