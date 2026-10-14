using System;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200025E RID: 606
	public class ProxyColumn : global::Infragistics.Controls.Grids.TextColumn
	{
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x000494D7 File Offset: 0x000476D7
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x000494DF File Offset: 0x000476DF
		internal global::Infragistics.Controls.Grids.CellBase ProxiedSource { get; set; }

		// Token: 0x06001377 RID: 4983 RVA: 0x000494E8 File Offset: 0x000476E8
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.ProxyColumnContentProvider();
		}
	}
}
