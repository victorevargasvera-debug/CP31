using System;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util.CellWalk
{
	// Token: 0x02000030 RID: 48
	public interface ICellHandler
	{
		// Token: 0x060001E3 RID: 483
		void OnCell(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.Util.CellWalk.ICellWalkContext ctx);
	}
}
