using System;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200023E RID: 574
	public abstract class ResourceSetLocator
	{
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060017B0 RID: 6064
		public abstract string Theme { get; }

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060017B1 RID: 6065
		public abstract string Grouping { get; }

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060017B2 RID: 6066
		public abstract global::System.Reflection.Assembly Assembly { get; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060017B3 RID: 6067
		public abstract string ResourcePath { get; }
	}
}
