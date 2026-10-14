using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000075 RID: 117
	public abstract class UnmodifiableList : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x0001634B File Offset: 0x0001454B
		public virtual int Add(object o)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00016352 File Offset: 0x00014552
		public virtual void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060004A7 RID: 1191
		public abstract bool Contains(object o);

		// Token: 0x060004A8 RID: 1192
		public abstract void CopyTo(global::System.Array array, int index);

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004A9 RID: 1193
		public abstract int Count { get; }

		// Token: 0x060004AA RID: 1194
		public abstract global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x060004AB RID: 1195
		public abstract int IndexOf(object o);

		// Token: 0x060004AC RID: 1196 RVA: 0x00016359 File Offset: 0x00014559
		public virtual void Insert(int i, object o)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004AD RID: 1197
		public abstract bool IsFixedSize { get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00016360 File Offset: 0x00014560
		public virtual bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004AF RID: 1199
		public abstract bool IsSynchronized { get; }

		// Token: 0x060004B0 RID: 1200 RVA: 0x00016363 File Offset: 0x00014563
		public virtual void Remove(object o)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0001636A File Offset: 0x0001456A
		public virtual void RemoveAt(int i)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004B2 RID: 1202
		public abstract object SyncRoot { get; }

		// Token: 0x170000C1 RID: 193
		public virtual object this[int i]
		{
			get
			{
				return this.GetValue(i);
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060004B5 RID: 1205
		protected abstract object GetValue(int i);
	}
}
