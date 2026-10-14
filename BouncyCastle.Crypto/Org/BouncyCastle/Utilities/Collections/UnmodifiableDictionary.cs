using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000073 RID: 115
	public abstract class UnmodifiableDictionary : global::System.Collections.IDictionary, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x0001627E File Offset: 0x0001447E
		public virtual void Add(object k, object v)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00016285 File Offset: 0x00014485
		public virtual void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600048A RID: 1162
		public abstract bool Contains(object k);

		// Token: 0x0600048B RID: 1163
		public abstract void CopyTo(global::System.Array array, int index);

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600048C RID: 1164
		public abstract int Count { get; }

		// Token: 0x0600048D RID: 1165 RVA: 0x0001628C File Offset: 0x0001448C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600048E RID: 1166
		public abstract global::System.Collections.IDictionaryEnumerator GetEnumerator();

		// Token: 0x0600048F RID: 1167 RVA: 0x00016294 File Offset: 0x00014494
		public virtual void Remove(object k)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000490 RID: 1168
		public abstract bool IsFixedSize { get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0001629B File Offset: 0x0001449B
		public virtual bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000492 RID: 1170
		public abstract bool IsSynchronized { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000493 RID: 1171
		public abstract object SyncRoot { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000494 RID: 1172
		public abstract global::System.Collections.ICollection Keys { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000495 RID: 1173
		public abstract global::System.Collections.ICollection Values { get; }

		// Token: 0x170000B5 RID: 181
		public virtual object this[object k]
		{
			get
			{
				return this.GetValue(k);
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06000498 RID: 1176
		protected abstract object GetValue(object k);
	}
}
