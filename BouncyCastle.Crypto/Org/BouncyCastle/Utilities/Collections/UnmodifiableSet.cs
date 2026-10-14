using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000077 RID: 119
	public abstract class UnmodifiableSet : global::Org.BouncyCastle.Utilities.Collections.ISet, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x00016412 File Offset: 0x00014612
		public virtual void Add(object o)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00016419 File Offset: 0x00014619
		public virtual void AddAll(global::System.Collections.IEnumerable e)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00016420 File Offset: 0x00014620
		public virtual void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060004C4 RID: 1220
		public abstract bool Contains(object o);

		// Token: 0x060004C5 RID: 1221
		public abstract void CopyTo(global::System.Array array, int index);

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004C6 RID: 1222
		public abstract int Count { get; }

		// Token: 0x060004C7 RID: 1223
		public abstract global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004C8 RID: 1224
		public abstract bool IsEmpty { get; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004C9 RID: 1225
		public abstract bool IsFixedSize { get; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00016427 File Offset: 0x00014627
		public virtual bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004CB RID: 1227
		public abstract bool IsSynchronized { get; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004CC RID: 1228
		public abstract object SyncRoot { get; }

		// Token: 0x060004CD RID: 1229 RVA: 0x0001642A File Offset: 0x0001462A
		public virtual void Remove(object o)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00016431 File Offset: 0x00014631
		public virtual void RemoveAll(global::System.Collections.IEnumerable e)
		{
			throw new global::System.NotSupportedException();
		}
	}
}
