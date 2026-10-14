using System;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000373 RID: 883
	public class HSSFEvaluationCell : global::NPOI.SS.Formula.IEvaluationCell
	{
		// Token: 0x06001BB8 RID: 7096 RVA: 0x00054CEE File Offset: 0x00052EEE
		public HSSFEvaluationCell(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.Formula.IEvaluationSheet evalSheet)
		{
			this._cell = cell;
			this._evalSheet = evalSheet;
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00054D04 File Offset: 0x00052F04
		public HSSFEvaluationCell(global::NPOI.SS.UserModel.ICell cell)
		{
			this._cell = cell;
			this._evalSheet = new global::NPOI.HSSF.UserModel.HSSFEvaluationSheet((global::NPOI.HSSF.UserModel.HSSFSheet)cell.Sheet);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00054D29 File Offset: 0x00052F29
		public override int GetHashCode()
		{
			return this._cell.GetHashCode();
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00054D38 File Offset: 0x00052F38
		public override bool Equals(object obj)
		{
			global::NPOI.SS.UserModel.ICell cell = ((global::NPOI.HSSF.UserModel.HSSFEvaluationCell)obj)._cell;
			return this._cell.RowIndex == cell.RowIndex && this._cell.ColumnIndex == cell.ColumnIndex && this._cell.CellFormula == cell.CellFormula && this._cell.Sheet == cell.Sheet;
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00054DA4 File Offset: 0x00052FA4
		public global::NPOI.SS.UserModel.ICell HSSFCell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00054DAC File Offset: 0x00052FAC
		public bool BooleanCellValue
		{
			get
			{
				return this._cell.BooleanCellValue;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00054DB9 File Offset: 0x00052FB9
		public global::NPOI.SS.UserModel.CellType CellType
		{
			get
			{
				return this._cell.CellType;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00054DC6 File Offset: 0x00052FC6
		public int ColumnIndex
		{
			get
			{
				return this._cell.ColumnIndex;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00054DD3 File Offset: 0x00052FD3
		public int ErrorCellValue
		{
			get
			{
				return (int)this._cell.ErrorCellValue;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00054DE0 File Offset: 0x00052FE0
		public double NumericCellValue
		{
			get
			{
				return this._cell.NumericCellValue;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00054DED File Offset: 0x00052FED
		public int RowIndex
		{
			get
			{
				return this._cell.RowIndex;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00054DFA File Offset: 0x00052FFA
		public global::NPOI.SS.Formula.IEvaluationSheet Sheet
		{
			get
			{
				return this._evalSheet;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00054E02 File Offset: 0x00053002
		public string StringCellValue
		{
			get
			{
				return this._cell.RichStringCellValue.String;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00054DA4 File Offset: 0x00052FA4
		public object IdentityKey
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00054E14 File Offset: 0x00053014
		public global::NPOI.SS.UserModel.CellType CachedFormulaResultType
		{
			get
			{
				return this._cell.CachedFormulaResultType;
			}
		}

		// Token: 0x04000B4A RID: 2890
		private global::NPOI.SS.Formula.IEvaluationSheet _evalSheet;

		// Token: 0x04000B4B RID: 2891
		private global::NPOI.SS.UserModel.ICell _cell;
	}
}
