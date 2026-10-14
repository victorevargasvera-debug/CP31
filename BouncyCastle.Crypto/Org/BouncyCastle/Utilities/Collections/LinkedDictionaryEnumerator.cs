using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000072 RID: 114
	internal class LinkedDictionaryEnumerator : global::System.Collections.IDictionaryEnumerator, global::System.Collections.IEnumerator
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x00016174 File Offset: 0x00014374
		internal LinkedDictionaryEnumerator(global::Org.BouncyCastle.Utilities.Collections.LinkedDictionary parent)
		{
			this.parent = parent;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0001618A File Offset: 0x0001438A
		public virtual object Current
		{
			get
			{
				return this.Entry;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00016198 File Offset: 0x00014398
		public virtual global::System.Collections.DictionaryEntry Entry
		{
			get
			{
				object i = this.CurrentKey;
				return new global::System.Collections.DictionaryEntry(i, this.parent.hash[i]);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000161C3 File Offset: 0x000143C3
		public virtual object Key
		{
			get
			{
				return this.CurrentKey;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000161CC File Offset: 0x000143CC
		public virtual bool MoveNext()
		{
			if (this.pos >= this.parent.keys.Count)
			{
				return false;
			}
			int num = this.pos + 1;
			this.pos = num;
			return num < this.parent.keys.Count;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00016216 File Offset: 0x00014416
		public virtual void Reset()
		{
			this.pos = -1;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0001621F File Offset: 0x0001441F
		public virtual object Value
		{
			get
			{
				return this.parent.hash[this.CurrentKey];
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00016237 File Offset: 0x00014437
		private object CurrentKey
		{
			get
			{
				if (this.pos < 0 || this.pos >= this.parent.keys.Count)
				{
					throw new global::System.InvalidOperationException();
				}
				return this.parent.keys[this.pos];
			}
		}

		// Token: 0x040002A3 RID: 675
		private readonly global::Org.BouncyCastle.Utilities.Collections.LinkedDictionary parent;

		// Token: 0x040002A4 RID: 676
		private int pos = -1;
	}
}
