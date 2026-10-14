using System;

namespace SourceGrid.Exporter
{
	// Token: 0x02000391 RID: 913
	[global::System.Flags]
	internal enum ExportHTMLMode
	{
		// Token: 0x04000E74 RID: 3700
		None = 0,
		// Token: 0x04000E75 RID: 3701
		HTMLAndBody = 1,
		// Token: 0x04000E76 RID: 3702
		GridBackColor = 2,
		// Token: 0x04000E77 RID: 3703
		CellBackColor = 4,
		// Token: 0x04000E78 RID: 3704
		RectangleBorder = 8,
		// Token: 0x04000E79 RID: 3705
		CellForeColor = 16,
		// Token: 0x04000E7A RID: 3706
		CellImages = 32,
		// Token: 0x04000E7B RID: 3707
		Default = 63
	}
}
