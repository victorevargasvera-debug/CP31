using System;

namespace Loupe.Extensibility.Client
{
	// Token: 0x02000095 RID: 149
	internal interface IGlobalContext
	{
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600069F RID: 1695
		global::Loupe.Extensibility.LoupeEnvironment Environment { get; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060006A0 RID: 1696
		bool IsUserInterfaceSupported { get; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060006A1 RID: 1697
		global::Loupe.Extensibility.ILog Log { get; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060006A2 RID: 1698
		global::Loupe.Extensibility.Client.IGlobalController GlobalController { get; }
	}
}
