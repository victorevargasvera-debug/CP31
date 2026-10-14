using System;
using System.Drawing;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003A6 RID: 934
	internal interface IImage : global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B5A RID: 11098
		global::System.Drawing.Image GetImage(global::SourceGrid.CellContext cellContext);
	}
}
