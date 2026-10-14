using System;
using System.Collections;
using System.Collections.Generic;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000084 RID: 132
	public interface IRow : global::System.Collections.Generic.IEnumerable<global::NPOI.SS.UserModel.ICell>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000486 RID: 1158
		global::NPOI.SS.UserModel.ICell CreateCell(int column);

		// Token: 0x06000487 RID: 1159
		global::NPOI.SS.UserModel.ICell CreateCell(int column, global::NPOI.SS.UserModel.CellType type);

		// Token: 0x06000488 RID: 1160
		void RemoveCell(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000489 RID: 1161
		// (set) Token: 0x0600048A RID: 1162
		int RowNum { get; set; }

		// Token: 0x0600048B RID: 1163
		global::NPOI.SS.UserModel.ICell GetCell(int cellnum);

		// Token: 0x0600048C RID: 1164
		global::NPOI.SS.UserModel.ICell GetCell(int cellnum, global::NPOI.SS.UserModel.MissingCellPolicy policy);

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600048D RID: 1165
		short FirstCellNum { get; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600048E RID: 1166
		short LastCellNum { get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600048F RID: 1167
		int PhysicalNumberOfCells { get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000490 RID: 1168
		// (set) Token: 0x06000491 RID: 1169
		bool ZeroHeight { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000492 RID: 1170
		// (set) Token: 0x06000493 RID: 1171
		short Height { get; set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000494 RID: 1172
		// (set) Token: 0x06000495 RID: 1173
		float HeightInPoints { get; set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000496 RID: 1174
		bool IsFormatted { get; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000497 RID: 1175
		global::NPOI.SS.UserModel.ISheet Sheet { get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000498 RID: 1176
		// (set) Token: 0x06000499 RID: 1177
		global::NPOI.SS.UserModel.ICellStyle RowStyle { get; set; }

		// Token: 0x0600049A RID: 1178
		void MoveCell(global::NPOI.SS.UserModel.ICell cell, int newColumn);

		// Token: 0x0600049B RID: 1179
		global::NPOI.SS.UserModel.IRow CopyRowTo(int targetIndex);

		// Token: 0x0600049C RID: 1180
		global::NPOI.SS.UserModel.ICell CopyCell(int sourceIndex, int targetIndex);

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600049D RID: 1181
		global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell> Cells { get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600049E RID: 1182
		int OutlineLevel { get; }

		// Token: 0x0600049F RID: 1183
		bool HasCustomHeight();

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004A0 RID: 1184
		// (set) Token: 0x060004A1 RID: 1185
		bool? Hidden { get; set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004A2 RID: 1186
		// (set) Token: 0x060004A3 RID: 1187
		bool? Collapsed { get; set; }
	}
}
