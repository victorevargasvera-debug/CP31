using System;
using NPOI.SS.Formula;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000C8 RID: 200
	public class SXSSFEvaluationSheet : global::NPOI.SS.Formula.IEvaluationSheet
	{
		// Token: 0x06000C95 RID: 3221 RVA: 0x0002DF11 File Offset: 0x0002C111
		public SXSSFEvaluationSheet(global::NPOI.XSSF.Streaming.SXSSFSheet sheet)
		{
			this._xs = sheet;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0002DF20 File Offset: 0x0002C120
		public global::NPOI.XSSF.Streaming.SXSSFSheet GetSXSSFSheet()
		{
			return this._xs;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0002DF28 File Offset: 0x0002C128
		public global::NPOI.SS.Formula.IEvaluationCell GetCell(int rowIndex, int columnIndex)
		{
			global::NPOI.XSSF.Streaming.SXSSFRow sxssfrow = (global::NPOI.XSSF.Streaming.SXSSFRow)this._xs.GetRow(rowIndex);
			if (sxssfrow == null)
			{
				if (rowIndex <= this._xs.LastFlushedRowNumber)
				{
					throw new global::NPOI.XSSF.Streaming.RowFlushedException(rowIndex);
				}
				return null;
			}
			else
			{
				global::NPOI.XSSF.Streaming.SXSSFCell sxssfcell = (global::NPOI.XSSF.Streaming.SXSSFCell)sxssfrow.GetCell(columnIndex);
				if (sxssfcell == null)
				{
					return null;
				}
				return new global::NPOI.XSSF.Streaming.SXSSFEvaluationCell(sxssfcell, this);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x000029BF File Offset: 0x00000BBF
		public void ClearAllCachedResultValues()
		{
		}

		// Token: 0x040003E7 RID: 999
		private global::NPOI.XSSF.Streaming.SXSSFSheet _xs;
	}
}
