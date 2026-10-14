using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000074 RID: 116
	internal interface IRepositoryApplicationVersion
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600058A RID: 1418
		global::System.Version Version { get; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600058B RID: 1419
		global::System.Version DisplayVersion { get; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600058C RID: 1420
		string Caption { get; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600058D RID: 1421
		string Description { get; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600058E RID: 1422
		global::System.DateTime? ReleaseDate { get; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600058F RID: 1423
		string ReleaseNotesUrl { get; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000590 RID: 1424
		global::Loupe.Extensibility.Data.IRepositoryApplication Application { get; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000591 RID: 1425
		global::Loupe.Extensibility.Data.IPromotionLevel PromotionLevel { get; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000592 RID: 1426
		global::Loupe.Extensibility.Data.IReleaseType ReleaseType { get; }
	}
}
