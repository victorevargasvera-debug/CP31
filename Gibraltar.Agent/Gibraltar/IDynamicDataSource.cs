using System;
using System.Collections.Generic;

namespace Gibraltar
{
	// Token: 0x02000163 RID: 355
	internal interface IDynamicDataSource<TList>
	{
		// Token: 0x06000ED2 RID: 3794
		void Synchronize(TList list, out global::System.Collections.Generic.IList<global::Gibraltar.IDynamicData> deferredUpdates);

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000ED3 RID: 3795
		string LogCategory { get; }
	}
}
