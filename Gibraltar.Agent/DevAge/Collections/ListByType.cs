using System;
using System.Collections.Generic;

namespace DevAge.Collections
{
	// Token: 0x020002A1 RID: 673
	internal abstract class ListByType<T> : global::System.Collections.Generic.List<T>
	{
		// Token: 0x060021B0 RID: 8624 RVA: 0x00077CD4 File Offset: 0x00075ED4
		public T GetByType(global::System.Type searchType)
		{
			for (int i = 0; i < base.Count; i++)
			{
				T t = base[i];
				if (searchType.IsAssignableFrom(t.GetType()))
				{
					return base[i];
				}
			}
			return default(T);
		}
	}
}
