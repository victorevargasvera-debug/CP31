using System;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000374 RID: 884
	public class HSSFEvaluationSheet : global::NPOI.SS.Formula.IEvaluationSheet
	{
		// Token: 0x06001BC7 RID: 7111 RVA: 0x00054E21 File Offset: 0x00053021
		public HSSFEvaluationSheet(global::NPOI.HSSF.UserModel.HSSFSheet hs)
		{
			this._hs = hs;
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00054E30 File Offset: 0x00053030
		public global::NPOI.HSSF.UserModel.HSSFSheet HSSFSheet
		{
			get
			{
				return this._hs;
			}
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00054E38 File Offset: 0x00053038
		public global::NPOI.SS.Formula.IEvaluationCell GetCell(int rowIndex, int columnIndex)
		{
			global::NPOI.HSSF.UserModel.HSSFRow hssfrow = (global::NPOI.HSSF.UserModel.HSSFRow)this._hs.GetRow(rowIndex);
			if (hssfrow == null)
			{
				return null;
			}
			global::NPOI.SS.UserModel.ICell cell = (global::NPOI.HSSF.UserModel.HSSFCell)hssfrow.GetCell(columnIndex);
			if (cell == null)
			{
				return null;
			}
			return new global::NPOI.HSSF.UserModel.HSSFEvaluationCell(cell, this);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00019A7F File Offset: 0x00017C7F
		public void ClearAllCachedResultValues()
		{
		}

		// Token: 0x04000B4C RID: 2892
		private global::NPOI.HSSF.UserModel.HSSFSheet _hs;
	}
}
