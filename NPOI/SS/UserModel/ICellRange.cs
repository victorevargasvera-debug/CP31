using System;
using System.Collections;
using System.Collections.Generic;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200004D RID: 77
	public interface ICellRange<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable where T : global::NPOI.SS.UserModel.ICell
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002C8 RID: 712
		int Width { get; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C9 RID: 713
		int Height { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002CA RID: 714
		int Size { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002CB RID: 715
		string ReferenceText { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002CC RID: 716
		T TopLeftCell { get; }

		// Token: 0x060002CD RID: 717
		T GetCell(int relativeRowIndex, int relativeColumnIndex);

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002CE RID: 718
		T[] FlattenedCells { get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002CF RID: 719
		T[][] Cells { get; }
	}
}
