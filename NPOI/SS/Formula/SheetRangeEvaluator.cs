using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000AF RID: 175
	public class SheetRangeEvaluator : global::NPOI.SS.Formula.ISheetRange
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x0000E080 File Offset: 0x0000C280
		public SheetRangeEvaluator(int firstSheetIndex, int lastSheetIndex, global::NPOI.SS.Formula.SheetRefEvaluator[] sheetEvaluators)
		{
			if (firstSheetIndex < 0)
			{
				throw new global::System.ArgumentException("Invalid firstSheetIndex: " + firstSheetIndex.ToString() + ".");
			}
			if (lastSheetIndex < firstSheetIndex)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid lastSheetIndex: ",
					lastSheetIndex.ToString(),
					" for firstSheetIndex: ",
					firstSheetIndex.ToString(),
					"."
				}));
			}
			this._firstSheetIndex = firstSheetIndex;
			this._lastSheetIndex = lastSheetIndex;
			this._sheetEvaluators = (global::NPOI.SS.Formula.SheetRefEvaluator[])sheetEvaluators.Clone();
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000E113 File Offset: 0x0000C313
		public SheetRangeEvaluator(int onlySheetIndex, global::NPOI.SS.Formula.SheetRefEvaluator sheetEvaluator) : this(onlySheetIndex, onlySheetIndex, new global::NPOI.SS.Formula.SheetRefEvaluator[]
		{
			sheetEvaluator
		})
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000E128 File Offset: 0x0000C328
		public global::NPOI.SS.Formula.SheetRefEvaluator GetSheetEvaluator(int sheetIndex)
		{
			if (sheetIndex < this._firstSheetIndex || sheetIndex > this._lastSheetIndex)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid SheetIndex: ",
					sheetIndex.ToString(),
					" - Outside range ",
					this._firstSheetIndex.ToString(),
					" : ",
					this._lastSheetIndex.ToString()
				}));
			}
			return this._sheetEvaluators[sheetIndex - this._firstSheetIndex];
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0000E1A5 File Offset: 0x0000C3A5
		public int FirstSheetIndex
		{
			get
			{
				return this._firstSheetIndex;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0000E1AD File Offset: 0x0000C3AD
		public int LastSheetIndex
		{
			get
			{
				return this._lastSheetIndex;
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000E1B5 File Offset: 0x0000C3B5
		public string GetSheetName(int sheetIndex)
		{
			return this.GetSheetEvaluator(sheetIndex).SheetName;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		public string SheetNameRange
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(this.GetSheetName(this._firstSheetIndex));
				if (this._firstSheetIndex != this._lastSheetIndex)
				{
					stringBuilder.Append(':');
					stringBuilder.Append(this.GetSheetName(this._lastSheetIndex));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0000E21A File Offset: 0x0000C41A
		public global::NPOI.SS.Formula.Eval.ValueEval GetEvalForCell(int sheetIndex, int rowIndex, int columnIndex)
		{
			return this.GetSheetEvaluator(sheetIndex).GetEvalForCell(rowIndex, columnIndex);
		}

		// Token: 0x0400038F RID: 911
		private int _firstSheetIndex;

		// Token: 0x04000390 RID: 912
		private int _lastSheetIndex;

		// Token: 0x04000391 RID: 913
		private global::NPOI.SS.Formula.SheetRefEvaluator[] _sheetEvaluators;
	}
}
