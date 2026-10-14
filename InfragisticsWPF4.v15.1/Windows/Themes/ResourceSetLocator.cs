using System;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000273 RID: 627
	public abstract class ResourceSetLocator
	{
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060019B2 RID: 6578
		public abstract string Theme { get; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060019B3 RID: 6579
		public abstract string Grouping { get; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060019B4 RID: 6580
		public abstract global::System.Reflection.Assembly Assembly { get; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060019B5 RID: 6581
		public abstract string ResourcePath { get; }
	}
}
