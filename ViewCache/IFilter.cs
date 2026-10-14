using System;

namespace Motorola.CommonCPS.RadioManagement.ViewCache
{
	// Token: 0x02000003 RID: 3
	public interface IFilter<T>
	{
		// Token: 0x06000005 RID: 5
		bool IsFilterOut(T item);
	}
}
