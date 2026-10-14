using System;
using System.Collections.ObjectModel;

namespace Infragistics
{
	// Token: 0x020000C8 RID: 200
	public interface IProvidePersistenceLookupKeys
	{
		// Token: 0x06000743 RID: 1859
		global::System.Collections.ObjectModel.Collection<string> GetLookupKeys();

		// Token: 0x06000744 RID: 1860
		bool CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys);
	}
}
