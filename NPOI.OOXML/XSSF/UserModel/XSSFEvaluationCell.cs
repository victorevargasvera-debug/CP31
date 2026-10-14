using System;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200007E RID: 126
	public class XSSFEvaluationCell : global::NPOI.SS.Formula.IEvaluationCell
	{
		// Token: 0x060006A4 RID: 1700 RVA: 0x00017256 File Offset: 0x00015456
		public XSSFEvaluationCell(global::NPOI.SS.UserModel.ICell cell, global::NPOI.XSSF.UserModel.XSSFEvaluationSheet EvaluationSheet)
		{
			this._cell = (global::NPOI.XSSF.UserModel.XSSFCell)cell;
			this._evalSheet = EvaluationSheet;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00017271 File Offset: 0x00015471
		public XSSFEvaluationCell(global::NPOI.SS.UserModel.ICell cell) : this(cell, new global::NPOI.XSSF.UserModel.XSSFEvaluationSheet(cell.Sheet))
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002FA4 File Offset: 0x000011A4
		public XSSFEvaluationCell()
		{
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00017285 File Offset: 0x00015485
		public object IdentityKey
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00017285 File Offset: 0x00015485
		public global::NPOI.XSSF.UserModel.XSSFCell GetXSSFCell()
		{
			return this._cell;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001728D File Offset: 0x0001548D
		public virtual bool BooleanCellValue
		{
			get
			{
				return this._cell.BooleanCellValue;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0001729A File Offset: 0x0001549A
		public virtual global::NPOI.SS.UserModel.CellType CellType
		{
			get
			{
				return this._cell.CellType;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x000172A7 File Offset: 0x000154A7
		public virtual int ColumnIndex
		{
			get
			{
				return this._cell.ColumnIndex;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x000172B4 File Offset: 0x000154B4
		public virtual int ErrorCellValue
		{
			get
			{
				return (int)this._cell.ErrorCellValue;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x000172C1 File Offset: 0x000154C1
		public virtual double NumericCellValue
		{
			get
			{
				return this._cell.NumericCellValue;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x000172CE File Offset: 0x000154CE
		public virtual int RowIndex
		{
			get
			{
				return this._cell.RowIndex;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x000172DB File Offset: 0x000154DB
		public virtual global::NPOI.SS.Formula.IEvaluationSheet Sheet
		{
			get
			{
				return this._evalSheet;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x000172E3 File Offset: 0x000154E3
		public virtual string StringCellValue
		{
			get
			{
				return this._cell.RichStringCellValue.String;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x000172F5 File Offset: 0x000154F5
		public virtual global::NPOI.SS.UserModel.CellType CachedFormulaResultType
		{
			get
			{
				return this._cell.CachedFormulaResultType;
			}
		}

		// Token: 0x040002D4 RID: 724
		private global::NPOI.SS.Formula.IEvaluationSheet _evalSheet;

		// Token: 0x040002D5 RID: 725
		private global::NPOI.XSSF.UserModel.XSSFCell _cell;
	}
}
