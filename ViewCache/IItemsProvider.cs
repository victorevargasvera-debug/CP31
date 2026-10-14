using System;
using System.Collections.Generic;

namespace Motorola.CommonCPS.RadioManagement.ViewCache
{
	// Token: 0x02000004 RID: 4
	public interface IItemsProvider<T>
	{
		// Token: 0x06000006 RID: 6
		global::System.Collections.Generic.IList<T> FetchRange(int startIndex, int length, out int milliseconds);

		// Token: 0x06000007 RID: 7
		int GetTotalCount();

		// Token: 0x06000008 RID: 8
		void SetValidator(T item);
	}
}
