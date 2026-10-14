using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000071 RID: 113
	public class LinkedDictionary : global::System.Collections.IDictionary, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x00015FC3 File Offset: 0x000141C3
		public virtual void Add(object k, object v)
		{
			this.hash.Add(k, v);
			this.keys.Add(k);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00015FDF File Offset: 0x000141DF
		public virtual void Clear()
		{
			this.hash.Clear();
			this.keys.Clear();
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00015FF7 File Offset: 0x000141F7
		public virtual bool Contains(object k)
		{
			return this.hash.Contains(k);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00016008 File Offset: 0x00014208
		public virtual void CopyTo(global::System.Array array, int index)
		{
			foreach (object i in this.keys)
			{
				array.SetValue(this.hash[i], index++);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00016070 File Offset: 0x00014270
		public virtual int Count
		{
			get
			{
				return this.hash.Count;
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001607D File Offset: 0x0001427D
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00016085 File Offset: 0x00014285
		public virtual global::System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.LinkedDictionaryEnumerator(this);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001608D File Offset: 0x0001428D
		public virtual void Remove(object k)
		{
			this.hash.Remove(k);
			this.keys.Remove(k);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000160A7 File Offset: 0x000142A7
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000160AA File Offset: 0x000142AA
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000160AD File Offset: 0x000142AD
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000160B0 File Offset: 0x000142B0
		public virtual object SyncRoot
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000160B8 File Offset: 0x000142B8
		public virtual global::System.Collections.ICollection Keys
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.keys);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000160C8 File Offset: 0x000142C8
		public virtual global::System.Collections.ICollection Values
		{
			get
			{
				global::System.Collections.IList values = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.keys.Count);
				foreach (object i in this.keys)
				{
					values.Add(this.hash[i]);
				}
				return values;
			}
		}

		// Token: 0x170000A8 RID: 168
		public virtual object this[object k]
		{
			get
			{
				return this.hash[k];
			}
			set
			{
				if (!this.hash.Contains(k))
				{
					this.keys.Add(k);
				}
				this.hash[k] = value;
			}
		}

		// Token: 0x040002A1 RID: 673
		internal readonly global::System.Collections.IDictionary hash = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040002A2 RID: 674
		internal readonly global::System.Collections.IList keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
	}
}
