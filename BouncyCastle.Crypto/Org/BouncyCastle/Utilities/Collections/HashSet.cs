using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x0200006F RID: 111
	public class HashSet : global::Org.BouncyCastle.Utilities.Collections.ISet, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x00015DE0 File Offset: 0x00013FE0
		public HashSet()
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00015DF4 File Offset: 0x00013FF4
		public HashSet(global::System.Collections.IEnumerable s)
		{
			foreach (object o in s)
			{
				this.Add(o);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00015E54 File Offset: 0x00014054
		public virtual void Add(object o)
		{
			this.impl[o] = null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00015E64 File Offset: 0x00014064
		public virtual void AddAll(global::System.Collections.IEnumerable e)
		{
			foreach (object o in e)
			{
				this.Add(o);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00015EB4 File Offset: 0x000140B4
		public virtual void Clear()
		{
			this.impl.Clear();
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00015EC1 File Offset: 0x000140C1
		public virtual bool Contains(object o)
		{
			return this.impl.Contains(o);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00015ECF File Offset: 0x000140CF
		public virtual void CopyTo(global::System.Array array, int index)
		{
			this.impl.Keys.CopyTo(array, index);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00015EE3 File Offset: 0x000140E3
		public virtual int Count
		{
			get
			{
				return this.impl.Count;
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00015EF0 File Offset: 0x000140F0
		public virtual global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.impl.Keys.GetEnumerator();
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00015F02 File Offset: 0x00014102
		public virtual bool IsEmpty
		{
			get
			{
				return this.impl.Count == 0;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00015F12 File Offset: 0x00014112
		public virtual bool IsFixedSize
		{
			get
			{
				return this.impl.IsFixedSize;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00015F1F File Offset: 0x0001411F
		public virtual bool IsReadOnly
		{
			get
			{
				return this.impl.IsReadOnly;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00015F2C File Offset: 0x0001412C
		public virtual bool IsSynchronized
		{
			get
			{
				return this.impl.IsSynchronized;
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00015F39 File Offset: 0x00014139
		public virtual void Remove(object o)
		{
			this.impl.Remove(o);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00015F48 File Offset: 0x00014148
		public virtual void RemoveAll(global::System.Collections.IEnumerable e)
		{
			foreach (object o in e)
			{
				this.Remove(o);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00015F98 File Offset: 0x00014198
		public virtual object SyncRoot
		{
			get
			{
				return this.impl.SyncRoot;
			}
		}

		// Token: 0x040002A0 RID: 672
		private readonly global::System.Collections.IDictionary impl = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
