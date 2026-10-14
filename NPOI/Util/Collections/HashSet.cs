using System;
using System.Collections;
using System.Collections.Generic;

namespace NPOI.Util.Collections
{
	// Token: 0x02000298 RID: 664
	public class HashSet<T> : global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
	{
		// Token: 0x06001230 RID: 4656 RVA: 0x0003666A File Offset: 0x0003486A
		public void Add(T o)
		{
			if (this.IsReadOnly)
			{
				throw new global::System.InvalidOperationException("this hashset is readonly");
			}
			this.impl[o] = null;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0003668C File Offset: 0x0003488C
		public bool Contains(T o)
		{
			return o != null && this.impl.ContainsKey(o);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000366A4 File Offset: 0x000348A4
		public void CopyTo(T[] array, int index)
		{
			this.impl.Keys.CopyTo(array, index);
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x000366B8 File Offset: 0x000348B8
		public int Count
		{
			get
			{
				return this.impl.Count;
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x000366C5 File Offset: 0x000348C5
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return this.impl.Keys.GetEnumerator();
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x000366DC File Offset: 0x000348DC
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x000366E4 File Offset: 0x000348E4
		public bool IsReadOnly { get; set; }

		// Token: 0x06001237 RID: 4663 RVA: 0x000366ED File Offset: 0x000348ED
		public bool Remove(T o)
		{
			if (this.IsReadOnly)
			{
				throw new global::System.InvalidOperationException("this hashset is readonly");
			}
			this.impl.Remove(o);
			return true;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00036710 File Offset: 0x00034910
		public void Clear()
		{
			this.impl.Clear();
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0003671D File Offset: 0x0003491D
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.impl.GetEnumerator();
		}

		// Token: 0x04000785 RID: 1925
		private readonly global::System.Collections.Generic.Dictionary<T, object> impl = new global::System.Collections.Generic.Dictionary<T, object>();
	}
}
