using System;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000C7 RID: 199
	public class SXSSFEvaluationCell : global::NPOI.SS.Formula.IEvaluationCell
	{
		// Token: 0x06000C86 RID: 3206 RVA: 0x0002DE58 File Offset: 0x0002C058
		public SXSSFEvaluationCell(global::NPOI.XSSF.Streaming.SXSSFCell cell, global::NPOI.XSSF.Streaming.SXSSFEvaluationSheet evaluationSheet)
		{
			this._cell = cell;
			this._evalSheet = evaluationSheet;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0002DE6E File Offset: 0x0002C06E
		public SXSSFEvaluationCell(global::NPOI.XSSF.Streaming.SXSSFCell cell) : this(cell, new global::NPOI.XSSF.Streaming.SXSSFEvaluationSheet(cell.Sheet as global::NPOI.XSSF.Streaming.SXSSFSheet))
		{
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0002DE87 File Offset: 0x0002C087
		public object IdentityKey
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0002DE87 File Offset: 0x0002C087
		public global::NPOI.XSSF.Streaming.SXSSFCell GetSXSSFCell()
		{
			return this._cell;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0002DE8F File Offset: 0x0002C08F
		public bool BooleanCellValue
		{
			get
			{
				return this._cell.BooleanCellValue;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0002DE9C File Offset: 0x0002C09C
		public global::NPOI.SS.UserModel.CellType CellType
		{
			get
			{
				return this._cell.CellType;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x0002DE9C File Offset: 0x0002C09C
		public global::NPOI.SS.UserModel.CellType CellTypeEnum
		{
			get
			{
				return this._cell.CellType;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0002DEA9 File Offset: 0x0002C0A9
		public int ColumnIndex
		{
			get
			{
				return this._cell.ColumnIndex;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0002DEB6 File Offset: 0x0002C0B6
		public int ErrorCellValue
		{
			get
			{
				return (int)this._cell.ErrorCellValue;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0002DEC3 File Offset: 0x0002C0C3
		public double NumericCellValue
		{
			get
			{
				return this._cell.NumericCellValue;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		public int RowIndex
		{
			get
			{
				return this._cell.RowIndex;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0002DEDD File Offset: 0x0002C0DD
		public global::NPOI.SS.Formula.IEvaluationSheet Sheet
		{
			get
			{
				return this._evalSheet;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0002DEE5 File Offset: 0x0002C0E5
		public string StringCellValue
		{
			get
			{
				return this._cell.RichStringCellValue.String;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0002DEF7 File Offset: 0x0002C0F7
		public global::NPOI.SS.UserModel.CellType CachedFormulaResultType
		{
			get
			{
				return this._cell.CachedFormulaResultType;
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0002DF04 File Offset: 0x0002C104
		public global::NPOI.SS.UserModel.CellType GetCachedFormulaResultTypeEnum()
		{
			return this._cell.GetCachedFormulaResultTypeEnum();
		}

		// Token: 0x040003E5 RID: 997
		private global::NPOI.XSSF.Streaming.SXSSFEvaluationSheet _evalSheet;

		// Token: 0x040003E6 RID: 998
		private global::NPOI.XSSF.Streaming.SXSSFCell _cell;
	}
}
