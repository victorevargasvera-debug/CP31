using System;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200012E RID: 302
	internal interface ICommandEx
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000B3B RID: 2875
		long MinimumStateDisallowed { get; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000B3C RID: 2876
		long MinimumStateRequired { get; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000B3D RID: 2877
		bool ForceHandled { get; }
	}
}
