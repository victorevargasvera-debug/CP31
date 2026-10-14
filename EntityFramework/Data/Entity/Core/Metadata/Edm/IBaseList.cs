using System;
using System.Collections;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C5 RID: 1221
	internal interface IBaseList<T> : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x17000BE6 RID: 3046
		T this[string identity]
		{
			get;
		}

		// Token: 0x17000BE7 RID: 3047
		T this[int index]
		{
			get;
		}

		// Token: 0x06003C76 RID: 15478
		int IndexOf(T item);
	}
}
