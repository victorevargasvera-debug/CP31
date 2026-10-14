using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x0200002A RID: 42
	internal class X509CollectionStore : global::Org.BouncyCastle.X509.Store.IX509Store
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0000AB57 File Offset: 0x00008D57
		internal X509CollectionStore(global::System.Collections.ICollection collection)
		{
			this._local = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(collection);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000AB6C File Offset: 0x00008D6C
		public global::System.Collections.ICollection GetMatches(global::Org.BouncyCastle.X509.Store.IX509Selector selector)
		{
			if (selector == null)
			{
				return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this._local);
			}
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in this._local)
			{
				if (selector.Match(obj))
				{
					result.Add(obj);
				}
			}
			return result;
		}

		// Token: 0x040000DE RID: 222
		private global::System.Collections.ICollection _local;
	}
}
