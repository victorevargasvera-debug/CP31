using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Practices.Prism
{
	// Token: 0x02000090 RID: 144
	public static class CollectionExtensions
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x0000AB14 File Offset: 0x00008D14
		public static global::System.Collections.ObjectModel.Collection<T> AddRange<T>(this global::System.Collections.ObjectModel.Collection<T> collection, global::System.Collections.Generic.IEnumerable<T> items)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (items == null)
			{
				throw new global::System.ArgumentNullException("items");
			}
			foreach (T item in items)
			{
				collection.Add(item);
			}
			return collection;
		}
	}
}
