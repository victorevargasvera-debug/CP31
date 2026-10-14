using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000062 RID: 98
	public interface IDrawing
	{
		// Token: 0x060003B8 RID: 952
		global::NPOI.SS.UserModel.IPicture CreatePicture(global::NPOI.SS.UserModel.IClientAnchor anchor, int pictureIndex);

		// Token: 0x060003B9 RID: 953
		global::NPOI.SS.UserModel.IComment CreateCellComment(global::NPOI.SS.UserModel.IClientAnchor anchor);

		// Token: 0x060003BA RID: 954
		global::NPOI.SS.UserModel.IChart CreateChart(global::NPOI.SS.UserModel.IClientAnchor anchor);

		// Token: 0x060003BB RID: 955
		global::NPOI.SS.UserModel.IClientAnchor CreateAnchor(int dx1, int dy1, int dx2, int dy2, int col1, int row1, int col2, int row2);
	}
}
