using System;
using System.Collections.ObjectModel;

namespace Infragistics
{
	// Token: 0x020000E6 RID: 230
	public interface IProvidePersistenceLookupKeys
	{
		// Token: 0x06000843 RID: 2115
		global::System.Collections.ObjectModel.Collection<string> GetLookupKeys();

		// Token: 0x06000844 RID: 2116
		bool CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys);
	}
}
