using System;

namespace Infragistics.Windows.Commands
{
	// Token: 0x02000110 RID: 272
	internal interface ICommandEx
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A3C RID: 2620
		long MinimumStateDisallowed { get; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A3D RID: 2621
		long MinimumStateRequired { get; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A3E RID: 2622
		bool ForceHandled { get; }
	}
}
