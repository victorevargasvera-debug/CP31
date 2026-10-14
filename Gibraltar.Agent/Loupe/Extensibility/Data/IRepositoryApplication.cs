using System;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000073 RID: 115
	internal interface IRepositoryApplication
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000582 RID: 1410
		string Name { get; }

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000583 RID: 1411
		string Caption { get; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000584 RID: 1412
		string Description { get; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000585 RID: 1413
		global::Loupe.Extensibility.Data.ApplicationType Type { get; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000586 RID: 1414
		global::Loupe.Extensibility.Data.IRepositoryProduct Product { get; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000587 RID: 1415
		global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IRepositoryApplicationVersion> Versions { get; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000588 RID: 1416
		global::Loupe.Extensibility.Data.ApplicationUserMode UserMode { get; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000589 RID: 1417
		string ProductApplicationCaption { get; }
	}
}
