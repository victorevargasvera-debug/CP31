using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000076 RID: 118
	public class UnmodifiableListProxy : global::Org.BouncyCastle.Utilities.Collections.UnmodifiableList
	{
		// Token: 0x060004B6 RID: 1206 RVA: 0x00016381 File Offset: 0x00014581
		public UnmodifiableListProxy(global::System.Collections.IList l)
		{
			this.l = l;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00016390 File Offset: 0x00014590
		public override bool Contains(object o)
		{
			return this.l.Contains(o);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001639E File Offset: 0x0001459E
		public override void CopyTo(global::System.Array array, int index)
		{
			this.l.CopyTo(array, index);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x000163AD File Offset: 0x000145AD
		public override int Count
		{
			get
			{
				return this.l.Count;
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000163BA File Offset: 0x000145BA
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.l.GetEnumerator();
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000163C7 File Offset: 0x000145C7
		public override int IndexOf(object o)
		{
			return this.l.IndexOf(o);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x000163D5 File Offset: 0x000145D5
		public override bool IsFixedSize
		{
			get
			{
				return this.l.IsFixedSize;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x000163E2 File Offset: 0x000145E2
		public override bool IsSynchronized
		{
			get
			{
				return this.l.IsSynchronized;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x000163EF File Offset: 0x000145EF
		public override object SyncRoot
		{
			get
			{
				return this.l.SyncRoot;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000163FC File Offset: 0x000145FC
		protected override object GetValue(int i)
		{
			return this.l[i];
		}

		// Token: 0x040002A6 RID: 678
		private readonly global::System.Collections.IList l;
	}
}
