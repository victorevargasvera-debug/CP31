using System;
using System.Collections.Generic;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Eval.Forked
{
	// Token: 0x0200022C RID: 556
	internal class ForkedEvaluationWorkbook : global::NPOI.SS.Formula.IEvaluationWorkbook
	{
		// Token: 0x06000D96 RID: 3478 RVA: 0x00025EEF File Offset: 0x000240EF
		public ForkedEvaluationWorkbook(global::NPOI.SS.Formula.IEvaluationWorkbook master)
		{
			this._masterBook = master;
			this._sharedSheetsByName = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet>();
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00025F09 File Offset: 0x00024109
		public global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell GetOrCreateUpdatableCell(string sheetName, int rowIndex, int columnIndex)
		{
			return this.GetSharedSheet(sheetName).GetOrCreateUpdatableCell(rowIndex, columnIndex);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00025F19 File Offset: 0x00024119
		public global::NPOI.SS.Formula.IEvaluationCell GetEvaluationCell(string sheetName, int rowIndex, int columnIndex)
		{
			return this.GetSharedSheet(sheetName).GetCell(rowIndex, columnIndex);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00025F2C File Offset: 0x0002412C
		private global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet GetSharedSheet(string sheetName)
		{
			global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet forkedEvaluationSheet = null;
			if (this._sharedSheetsByName.ContainsKey(sheetName))
			{
				forkedEvaluationSheet = this._sharedSheetsByName[sheetName];
			}
			if (forkedEvaluationSheet == null)
			{
				forkedEvaluationSheet = new global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet(this._masterBook.GetSheet(this._masterBook.GetSheetIndex(sheetName)));
				if (this._sharedSheetsByName.ContainsKey(sheetName))
				{
					this._sharedSheetsByName[sheetName] = forkedEvaluationSheet;
				}
				else
				{
					this._sharedSheetsByName.Add(sheetName, forkedEvaluationSheet);
				}
			}
			return forkedEvaluationSheet;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00025FA4 File Offset: 0x000241A4
		public void CopyUpdatedCells(global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			string[] array = new string[this._sharedSheetsByName.Count];
			this._sharedSheetsByName.Keys.CopyTo(array, 0);
			foreach (string text in array)
			{
				this._sharedSheetsByName[text].CopyUpdatedCells(workbook.GetSheet(text));
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00026000 File Offset: 0x00024200
		public int ConvertFromExternSheetIndex(int externSheetIndex)
		{
			return this._masterBook.ConvertFromExternSheetIndex(externSheetIndex);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0002600E File Offset: 0x0002420E
		public global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(int externSheetIndex)
		{
			return this._masterBook.GetExternalSheet(externSheetIndex);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0002601C File Offset: 0x0002421C
		public global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(string firstSheetName, string lastSheetName, int externalWorkbookNumber)
		{
			return this._masterBook.GetExternalSheet(firstSheetName, lastSheetName, externalWorkbookNumber);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0002602C File Offset: 0x0002422C
		public global::NPOI.SS.Formula.PTG.Ptg[] GetFormulaTokens(global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			if (cell is global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell)
			{
				throw new global::System.Exception("Updated formulas not supported yet");
			}
			return this._masterBook.GetFormulaTokens(cell);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0002604D File Offset: 0x0002424D
		public global::NPOI.SS.Formula.IEvaluationName GetName(global::NPOI.SS.Formula.PTG.NamePtg namePtg)
		{
			return this._masterBook.GetName(namePtg);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0002605B File Offset: 0x0002425B
		public global::NPOI.SS.Formula.IEvaluationName GetName(string name, int sheetIndex)
		{
			return this._masterBook.GetName(name, sheetIndex);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0002606A File Offset: 0x0002426A
		public global::NPOI.SS.Formula.IEvaluationSheet GetSheet(int sheetIndex)
		{
			return this.GetSharedSheet(this.GetSheetName(sheetIndex));
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00026079 File Offset: 0x00024279
		public global::NPOI.SS.Formula.ExternalName GetExternalName(int externSheetIndex, int externNameIndex)
		{
			return this._masterBook.GetExternalName(externSheetIndex, externNameIndex);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00026088 File Offset: 0x00024288
		public global::NPOI.SS.Formula.ExternalName GetExternalName(string nameName, string sheetName, int externalWorkbookNumber)
		{
			return this._masterBook.GetExternalName(nameName, sheetName, externalWorkbookNumber);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00026098 File Offset: 0x00024298
		public int GetSheetIndex(global::NPOI.SS.Formula.IEvaluationSheet sheet)
		{
			if (sheet is global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet)
			{
				return ((global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet)sheet).GetSheetIndex(this._masterBook);
			}
			return this._masterBook.GetSheetIndex(sheet);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000260C0 File Offset: 0x000242C0
		public int GetSheetIndex(string sheetName)
		{
			return this._masterBook.GetSheetIndex(sheetName);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000260CE File Offset: 0x000242CE
		public string GetSheetName(int sheetIndex)
		{
			return this._masterBook.GetSheetName(sheetIndex);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x000260DC File Offset: 0x000242DC
		public string ResolveNameXText(global::NPOI.SS.Formula.PTG.NameXPtg ptg)
		{
			return this._masterBook.ResolveNameXText(ptg);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000260EA File Offset: 0x000242EA
		public global::NPOI.SS.Formula.UDF.UDFFinder GetUDFFinder()
		{
			return this._masterBook.GetUDFFinder();
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000260F7 File Offset: 0x000242F7
		public void ClearAllCachedResultValues()
		{
			this._masterBook.ClearAllCachedResultValues();
		}

		// Token: 0x0400061A RID: 1562
		private global::NPOI.SS.Formula.IEvaluationWorkbook _masterBook;

		// Token: 0x0400061B RID: 1563
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet> _sharedSheetsByName;
	}
}
