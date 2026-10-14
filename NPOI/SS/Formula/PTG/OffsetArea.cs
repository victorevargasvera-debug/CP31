using System;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F9 RID: 249
	public class OffsetArea : global::NPOI.SS.Formula.PTG.AreaI
	{
		// Token: 0x06000855 RID: 2133 RVA: 0x00016DA8 File Offset: 0x00014FA8
		public OffsetArea(int baseRow, int baseColumn, int relFirstRowIx, int relLastRowIx, int relFirstColIx, int relLastColIx)
		{
			this._firstRow = baseRow + global::System.Math.Min(relFirstRowIx, relLastRowIx);
			this._lastRow = baseRow + global::System.Math.Max(relFirstRowIx, relLastRowIx);
			this._firstColumn = baseColumn + global::System.Math.Min(relFirstColIx, relLastColIx);
			this._lastColumn = baseColumn + global::System.Math.Max(relFirstColIx, relLastColIx);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00016DFD File Offset: 0x00014FFD
		public int FirstColumn
		{
			get
			{
				return this._firstColumn;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00016E05 File Offset: 0x00015005
		public int FirstRow
		{
			get
			{
				return this._firstRow;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00016E0D File Offset: 0x0001500D
		public int LastColumn
		{
			get
			{
				return this._lastColumn;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00016E15 File Offset: 0x00015015
		public int LastRow
		{
			get
			{
				return this._lastRow;
			}
		}

		// Token: 0x04000452 RID: 1106
		private int _firstColumn;

		// Token: 0x04000453 RID: 1107
		private int _firstRow;

		// Token: 0x04000454 RID: 1108
		private int _lastColumn;

		// Token: 0x04000455 RID: 1109
		private int _lastRow;
	}
}
