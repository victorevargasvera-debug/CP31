using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004CC RID: 1228
	internal interface INamedDataModelItem
	{
		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06003CEF RID: 15599
		string Name { get; }

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06003CF0 RID: 15600
		string Identity { get; }
	}
}
