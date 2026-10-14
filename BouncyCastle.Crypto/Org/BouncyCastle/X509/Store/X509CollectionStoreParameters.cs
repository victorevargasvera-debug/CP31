using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x0200002B RID: 43
	public class X509CollectionStoreParameters : global::Org.BouncyCastle.X509.Store.IX509StoreParameters
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x0000ABE0 File Offset: 0x00008DE0
		public X509CollectionStoreParameters(global::System.Collections.ICollection collection)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			this.collection = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(collection);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000AC02 File Offset: 0x00008E02
		public global::System.Collections.ICollection GetCollection()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.collection);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000AC10 File Offset: 0x00008E10
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("X509CollectionStoreParameters: [\n");
			string str = "  collection: ";
			global::System.Collections.IList list = this.collection;
			stringBuilder.Append(str + ((list != null) ? list.ToString() : null) + "\n");
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040000DF RID: 223
		private readonly global::System.Collections.IList collection;
	}
}
