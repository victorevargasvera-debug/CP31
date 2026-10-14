using System;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Filters
{
	// Token: 0x02000150 RID: 336
	public abstract class LayoutBasedFilter : global::NLog.Filters.Filter
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00026136 File Offset: 0x00024336
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x0002613E File Offset: 0x0002433E
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Layout { get; set; }
	}
}
