using System;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x02000094 RID: 148
	public interface ICollectionFind<T>
	{
		// Token: 0x060005AC RID: 1452
		T Find(global::System.Predicate<T> match);

		// Token: 0x060005AD RID: 1453
		global::System.Collections.Generic.ICollection<T> FindAll(global::System.Predicate<T> match);
	}
}
