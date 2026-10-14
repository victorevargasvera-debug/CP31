using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000074 RID: 116
	public class UnmodifiableDictionaryProxy : global::Org.BouncyCastle.Utilities.Collections.UnmodifiableDictionary
	{
		// Token: 0x06000499 RID: 1177 RVA: 0x000162AE File Offset: 0x000144AE
		public UnmodifiableDictionaryProxy(global::System.Collections.IDictionary d)
		{
			this.d = d;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000162BD File Offset: 0x000144BD
		public override bool Contains(object k)
		{
			return this.d.Contains(k);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000162CB File Offset: 0x000144CB
		public override void CopyTo(global::System.Array array, int index)
		{
			this.d.CopyTo(array, index);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000162DA File Offset: 0x000144DA
		public override int Count
		{
			get
			{
				return this.d.Count;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000162E7 File Offset: 0x000144E7
		public override global::System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			return this.d.GetEnumerator();
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000162F4 File Offset: 0x000144F4
		public override bool IsFixedSize
		{
			get
			{
				return this.d.IsFixedSize;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00016301 File Offset: 0x00014501
		public override bool IsSynchronized
		{
			get
			{
				return this.d.IsSynchronized;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0001630E File Offset: 0x0001450E
		public override object SyncRoot
		{
			get
			{
				return this.d.SyncRoot;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0001631B File Offset: 0x0001451B
		public override global::System.Collections.ICollection Keys
		{
			get
			{
				return this.d.Keys;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00016328 File Offset: 0x00014528
		public override global::System.Collections.ICollection Values
		{
			get
			{
				return this.d.Values;
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00016335 File Offset: 0x00014535
		protected override object GetValue(object k)
		{
			return this.d[k];
		}

		// Token: 0x040002A5 RID: 677
		private readonly global::System.Collections.IDictionary d;
	}
}
