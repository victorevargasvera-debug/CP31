using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000B4 RID: 180
	public abstract class CellCacheEntry : global::NPOI.SS.Formula.ICacheEntry
	{
		// Token: 0x06000621 RID: 1569 RVA: 0x0000E2AF File Offset: 0x0000C4AF
		protected CellCacheEntry()
		{
			this._consumingCells = new global::NPOI.SS.Formula.FormulaCellCacheEntrySet();
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000E2C2 File Offset: 0x0000C4C2
		protected void ClearValue()
		{
			this._value = null;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000E2CB File Offset: 0x0000C4CB
		public bool UpdateValue(global::NPOI.SS.Formula.Eval.ValueEval value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentException("Did not expect To Update To null");
			}
			bool result = !global::NPOI.SS.Formula.CellCacheEntry.AreValuesEqual(this._value, value);
			this._value = value;
			return result;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000E2F1 File Offset: 0x0000C4F1
		public global::NPOI.SS.Formula.Eval.ValueEval GetValue()
		{
			return this._value;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		private static bool AreValuesEqual(global::NPOI.SS.Formula.Eval.ValueEval a, global::NPOI.SS.Formula.Eval.ValueEval b)
		{
			if (a == null)
			{
				return false;
			}
			global::System.Type type = a.GetType();
			if (type != b.GetType())
			{
				return false;
			}
			if (a == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return b == a;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.NumberEval))
			{
				return ((global::NPOI.SS.Formula.Eval.NumberEval)a).NumberValue == ((global::NPOI.SS.Formula.Eval.NumberEval)b).NumberValue;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.StringEval))
			{
				return ((global::NPOI.SS.Formula.Eval.StringEval)a).StringValue.Equals(((global::NPOI.SS.Formula.Eval.StringEval)b).StringValue);
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.BoolEval))
			{
				return ((global::NPOI.SS.Formula.Eval.BoolEval)a).BooleanValue == ((global::NPOI.SS.Formula.Eval.BoolEval)b).BooleanValue;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.ErrorEval))
			{
				return ((global::NPOI.SS.Formula.Eval.ErrorEval)a).ErrorCode == ((global::NPOI.SS.Formula.Eval.ErrorEval)b).ErrorCode;
			}
			throw new global::System.InvalidOperationException("Unexpected value class (" + type.Name + ")");
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000E3FB File Offset: 0x0000C5FB
		public void AddConsumingCell(global::NPOI.SS.Formula.FormulaCellCacheEntry cellLoc)
		{
			this._consumingCells.Add(cellLoc);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000E409 File Offset: 0x0000C609
		public global::NPOI.SS.Formula.FormulaCellCacheEntry[] GetConsumingCells()
		{
			return this._consumingCells.ToArray();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000E416 File Offset: 0x0000C616
		public void ClearConsumingCell(global::NPOI.SS.Formula.FormulaCellCacheEntry cce)
		{
			if (!this._consumingCells.Remove(cce))
			{
				throw new global::System.InvalidOperationException("Specified formula cell is not consumed by this cell");
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000E431 File Offset: 0x0000C631
		public void RecurseClearCachedFormulaResults(global::NPOI.SS.Formula.IEvaluationListener listener)
		{
			if (listener == null)
			{
				this.RecurseClearCachedFormulaResults();
				return;
			}
			listener.OnClearCachedValue(this);
			this.RecurseClearCachedFormulaResults(listener, 1);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000E44C File Offset: 0x0000C64C
		protected void RecurseClearCachedFormulaResults()
		{
			foreach (global::NPOI.SS.Formula.FormulaCellCacheEntry formulaCellCacheEntry in this.GetConsumingCells())
			{
				formulaCellCacheEntry.ClearFormulaEntry();
				formulaCellCacheEntry.RecurseClearCachedFormulaResults();
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000E47C File Offset: 0x0000C67C
		protected void RecurseClearCachedFormulaResults(global::NPOI.SS.Formula.IEvaluationListener listener, int depth)
		{
			global::NPOI.SS.Formula.FormulaCellCacheEntry[] consumingCells = this.GetConsumingCells();
			global::NPOI.SS.Formula.ICacheEntry[] formulaCells = consumingCells;
			listener.SortDependentCachedValues(formulaCells);
			foreach (global::NPOI.SS.Formula.FormulaCellCacheEntry formulaCellCacheEntry in consumingCells)
			{
				listener.OnClearDependentCachedValue(formulaCellCacheEntry, depth);
				formulaCellCacheEntry.ClearFormulaEntry();
				formulaCellCacheEntry.RecurseClearCachedFormulaResults(listener, depth + 1);
			}
		}

		// Token: 0x04000393 RID: 915
		public static global::NPOI.SS.Formula.CellCacheEntry[] EMPTY_ARRAY = new global::NPOI.SS.Formula.CellCacheEntry[0];

		// Token: 0x04000394 RID: 916
		private global::NPOI.SS.Formula.FormulaCellCacheEntrySet _consumingCells;

		// Token: 0x04000395 RID: 917
		private global::NPOI.SS.Formula.Eval.ValueEval _value;
	}
}
