using System;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200004C RID: 76
	public interface ICell
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002A2 RID: 674
		int ColumnIndex { get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002A3 RID: 675
		int RowIndex { get; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002A4 RID: 676
		global::NPOI.SS.UserModel.ISheet Sheet { get; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002A5 RID: 677
		global::NPOI.SS.UserModel.IRow Row { get; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002A6 RID: 678
		global::NPOI.SS.UserModel.CellType CellType { get; }

		// Token: 0x060002A7 RID: 679
		void SetCellType(global::NPOI.SS.UserModel.CellType cellType);

		// Token: 0x060002A8 RID: 680
		void SetBlank();

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002A9 RID: 681
		global::NPOI.SS.UserModel.CellType CachedFormulaResultType { get; }

		// Token: 0x060002AA RID: 682
		void SetCellValue(double value);

		// Token: 0x060002AB RID: 683
		void SetCellErrorValue(byte value);

		// Token: 0x060002AC RID: 684
		void SetCellValue(global::System.DateTime value);

		// Token: 0x060002AD RID: 685
		void SetCellValue(global::NPOI.SS.UserModel.IRichTextString value);

		// Token: 0x060002AE RID: 686
		void SetCellValue(string value);

		// Token: 0x060002AF RID: 687
		global::NPOI.SS.UserModel.ICell CopyCellTo(int targetIndex);

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002B0 RID: 688
		// (set) Token: 0x060002B1 RID: 689
		string CellFormula { get; set; }

		// Token: 0x060002B2 RID: 690
		void SetCellFormula(string formula);

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002B3 RID: 691
		double NumericCellValue { get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002B4 RID: 692
		global::System.DateTime DateCellValue { get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002B5 RID: 693
		global::NPOI.SS.UserModel.IRichTextString RichStringCellValue { get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002B6 RID: 694
		byte ErrorCellValue { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002B7 RID: 695
		string StringCellValue { get; }

		// Token: 0x060002B8 RID: 696
		void SetCellValue(bool value);

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002B9 RID: 697
		bool BooleanCellValue { get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002BA RID: 698
		// (set) Token: 0x060002BB RID: 699
		global::NPOI.SS.UserModel.ICellStyle CellStyle { get; set; }

		// Token: 0x060002BC RID: 700
		void SetAsActiveCell();

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002BD RID: 701
		global::NPOI.SS.Util.CellAddress Address { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002BE RID: 702
		// (set) Token: 0x060002BF RID: 703
		global::NPOI.SS.UserModel.IComment CellComment { get; set; }

		// Token: 0x060002C0 RID: 704
		void RemoveCellComment();

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002C1 RID: 705
		// (set) Token: 0x060002C2 RID: 706
		global::NPOI.SS.UserModel.IHyperlink Hyperlink { get; set; }

		// Token: 0x060002C3 RID: 707
		void RemoveHyperlink();

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002C4 RID: 708
		global::NPOI.SS.Util.CellRangeAddress ArrayFormulaRange { get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002C5 RID: 709
		bool IsPartOfArrayFormulaGroup { get; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002C6 RID: 710
		bool IsMergedCell { get; }

		// Token: 0x060002C7 RID: 711
		global::NPOI.SS.UserModel.CellType GetCachedFormulaResultTypeEnum();
	}
}
