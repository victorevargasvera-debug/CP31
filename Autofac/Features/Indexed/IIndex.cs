using System;

namespace Autofac.Features.Indexed
{
	// Token: 0x02000049 RID: 73
	public interface IIndex<in TKey, TValue>
	{
		// Token: 0x17000078 RID: 120
		TValue this[TKey key]
		{
			get;
		}

		// Token: 0x060001EA RID: 490
		bool TryGetValue(TKey key, out TValue value);
	}
}
