using System;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Server
{
	// Token: 0x02000050 RID: 80
	internal class ApplicationEventEventArgs
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		public ApplicationEventEventArgs(global::Loupe.Extensibility.Data.IApplicationEvent applicationEvent)
		{
			this.ApplicationEvent = applicationEvent;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		public global::Loupe.Extensibility.Data.IApplicationEvent ApplicationEvent { get; private set; }
	}
}
