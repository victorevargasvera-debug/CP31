using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000178 RID: 376
	public class Count : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000AF1 RID: 2801 RVA: 0x0001D7F6 File Offset: 0x0001B9F6
		public Count()
		{
			this._predicate = global::NPOI.SS.Formula.Functions.Count.defaultPredicate;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0001D809 File Offset: 0x0001BA09
		private Count(global::NPOI.SS.Formula.Functions.IMatchPredicate criteriaPredicate)
		{
			this._predicate = criteriaPredicate;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0001D818 File Offset: 0x0001BA18
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			int num = args.Length;
			if (num < 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num > 30)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				num2 += global::NPOI.SS.Formula.Functions.CountUtils.CountArg(args[i], this._predicate);
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)num2);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001D864 File Offset: 0x0001BA64
		public static global::NPOI.SS.Formula.Functions.Count SubtotalInstance()
		{
			return new global::NPOI.SS.Formula.Functions.Count(global::NPOI.SS.Formula.Functions.Count.subtotalPredicate);
		}

		// Token: 0x04000558 RID: 1368
		private global::NPOI.SS.Formula.Functions.IMatchPredicate _predicate;

		// Token: 0x04000559 RID: 1369
		private static global::NPOI.SS.Formula.Functions.IMatchPredicate defaultPredicate = new global::NPOI.SS.Formula.Functions.Count.DefaultPredicate();

		// Token: 0x0400055A RID: 1370
		private static global::NPOI.SS.Formula.Functions.IMatchPredicate subtotalPredicate = new global::NPOI.SS.Formula.Functions.Count.SubtotalPredicate();

		// Token: 0x02000572 RID: 1394
		private class DefaultPredicate : global::NPOI.SS.Formula.Functions.IMatchPredicate
		{
			// Token: 0x060033DF RID: 13279 RVA: 0x000A1BFC File Offset: 0x0009FDFC
			public bool Matches(global::NPOI.SS.Formula.Eval.ValueEval valueEval)
			{
				return valueEval is global::NPOI.SS.Formula.Eval.NumberEval || valueEval == global::NPOI.SS.Formula.Eval.MissingArgEval.instance;
			}
		}

		// Token: 0x02000573 RID: 1395
		private class SubtotalPredicate : global::NPOI.SS.Formula.Functions.I_MatchAreaPredicate, global::NPOI.SS.Formula.Functions.IMatchPredicate
		{
			// Token: 0x060033E1 RID: 13281 RVA: 0x000A1C13 File Offset: 0x0009FE13
			public bool Matches(global::NPOI.SS.Formula.Eval.ValueEval valueEval)
			{
				return global::NPOI.SS.Formula.Functions.Count.defaultPredicate.Matches(valueEval);
			}

			// Token: 0x060033E2 RID: 13282 RVA: 0x000A1C20 File Offset: 0x0009FE20
			public bool Matches(global::NPOI.SS.Formula.TwoDEval x, int rowIndex, int columnIndex)
			{
				return !x.IsSubTotal(rowIndex, columnIndex);
			}
		}
	}
}
