using System;
using System.Collections;

namespace NPOI.SS.Formula
{
	// Token: 0x020000C4 RID: 196
	public class FormulaCellCache
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0000F277 File Offset: 0x0000D477
		public FormulaCellCache()
		{
			this._formulaEntriesByCell = new global::System.Collections.Hashtable();
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000F28C File Offset: 0x0000D48C
		public global::NPOI.SS.Formula.CellCacheEntry[] GetCacheEntries()
		{
			global::NPOI.SS.Formula.FormulaCellCacheEntry[] array = new global::NPOI.SS.Formula.FormulaCellCacheEntry[this._formulaEntriesByCell.Count];
			this._formulaEntriesByCell.Values.CopyTo(array, 0);
			return array;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000F2BF File Offset: 0x0000D4BF
		public void Clear()
		{
			this._formulaEntriesByCell.Clear();
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		public global::NPOI.SS.Formula.FormulaCellCacheEntry Get(global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			if (this._formulaEntriesByCell.ContainsKey(cell.IdentityKey))
			{
				return (global::NPOI.SS.Formula.FormulaCellCacheEntry)this._formulaEntriesByCell[cell.IdentityKey];
			}
			return null;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000F2F9 File Offset: 0x0000D4F9
		public void Put(global::NPOI.SS.Formula.IEvaluationCell cell, global::NPOI.SS.Formula.FormulaCellCacheEntry entry)
		{
			this._formulaEntriesByCell[cell.IdentityKey] = entry;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000F30D File Offset: 0x0000D50D
		public global::NPOI.SS.Formula.FormulaCellCacheEntry Remove(global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			global::NPOI.SS.Formula.FormulaCellCacheEntry result = (global::NPOI.SS.Formula.FormulaCellCacheEntry)this._formulaEntriesByCell[cell.IdentityKey];
			this._formulaEntriesByCell.Remove(cell);
			return result;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000F334 File Offset: 0x0000D534
		public void ApplyOperation(global::NPOI.SS.Formula.IEntryOperation operation)
		{
			foreach (object obj in this._formulaEntriesByCell.Values)
			{
				operation.ProcessEntry((global::NPOI.SS.Formula.FormulaCellCacheEntry)obj);
			}
		}

		// Token: 0x040003AC RID: 940
		private global::System.Collections.Hashtable _formulaEntriesByCell;
	}
}
