using System;
using System.ComponentModel;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000240 RID: 576
	public class ColumnTypeMapping
	{
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x00043B08 File Offset: 0x00041D08
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x00043B10 File Offset: 0x00041D10
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.TypeTypeConverter))]
		public global::System.Type ColumnType { get; set; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00043B19 File Offset: 0x00041D19
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x00043B21 File Offset: 0x00041D21
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.TypeTypeConverter))]
		public global::System.Type DataType { get; set; }
	}
}
