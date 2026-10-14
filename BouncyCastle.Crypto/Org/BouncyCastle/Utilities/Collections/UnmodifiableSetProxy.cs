using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000078 RID: 120
	public class UnmodifiableSetProxy : global::Org.BouncyCastle.Utilities.Collections.UnmodifiableSet
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x00016438 File Offset: 0x00014638
		public UnmodifiableSetProxy(global::Org.BouncyCastle.Utilities.Collections.ISet s)
		{
			this.s = s;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00016447 File Offset: 0x00014647
		public override bool Contains(object o)
		{
			return this.s.Contains(o);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00016455 File Offset: 0x00014655
		public override void CopyTo(global::System.Array array, int index)
		{
			this.s.CopyTo(array, index);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00016464 File Offset: 0x00014664
		public override int Count
		{
			get
			{
				return this.s.Count;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00016471 File Offset: 0x00014671
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.s.GetEnumerator();
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0001647E File Offset: 0x0001467E
		public override bool IsEmpty
		{
			get
			{
				return this.s.IsEmpty;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0001648B File Offset: 0x0001468B
		public override bool IsFixedSize
		{
			get
			{
				return this.s.IsFixedSize;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00016498 File Offset: 0x00014698
		public override bool IsSynchronized
		{
			get
			{
				return this.s.IsSynchronized;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000164A5 File Offset: 0x000146A5
		public override object SyncRoot
		{
			get
			{
				return this.s.SyncRoot;
			}
		}

		// Token: 0x040002A7 RID: 679
		private readonly global::Org.BouncyCastle.Utilities.Collections.ISet s;
	}
}
