using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000179 RID: 377
	public class Counta : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000AF6 RID: 2806 RVA: 0x0001D886 File Offset: 0x0001BA86
		public Counta()
		{
			this._predicate = global::NPOI.SS.Formula.Functions.Counta.defaultPredicate;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0001D899 File Offset: 0x0001BA99
		private Counta(global::NPOI.SS.Formula.Functions.IMatchPredicate criteriaPredicate)
		{
			this._predicate = criteriaPredicate;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
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

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
		public static global::NPOI.SS.Formula.Functions.Counta SubtotalInstance()
		{
			return new global::NPOI.SS.Formula.Functions.Counta(global::NPOI.SS.Formula.Functions.Counta.subtotalPredicate);
		}

		// Token: 0x0400055B RID: 1371
		private global::NPOI.SS.Formula.Functions.IMatchPredicate _predicate;

		// Token: 0x0400055C RID: 1372
		private static global::NPOI.SS.Formula.Functions.IMatchPredicate defaultPredicate = new global::NPOI.SS.Formula.Functions.Counta.DefaultPredicate();

		// Token: 0x0400055D RID: 1373
		private static global::NPOI.SS.Formula.Functions.IMatchPredicate subtotalPredicate = new global::NPOI.SS.Formula.Functions.Counta.SubtotalPredicate();

		// Token: 0x02000574 RID: 1396
		public class DefaultPredicate : global::NPOI.SS.Formula.Functions.IMatchPredicate
		{
			// Token: 0x060033E4 RID: 13284 RVA: 0x000A1C2D File Offset: 0x0009FE2D
			public bool Matches(global::NPOI.SS.Formula.Eval.ValueEval valueEval)
			{
				return valueEval != global::NPOI.SS.Formula.Eval.BlankEval.instance;
			}
		}

		// Token: 0x02000575 RID: 1397
		public class SubtotalPredicate : global::NPOI.SS.Formula.Functions.I_MatchAreaPredicate, global::NPOI.SS.Formula.Functions.IMatchPredicate
		{
			// Token: 0x060033E6 RID: 13286 RVA: 0x000A1C3A File Offset: 0x0009FE3A
			public bool Matches(global::NPOI.SS.Formula.Eval.ValueEval valueEval)
			{
				return global::NPOI.SS.Formula.Functions.Counta.defaultPredicate.Matches(valueEval);
			}

			// Token: 0x060033E7 RID: 13287 RVA: 0x000A1C20 File Offset: 0x0009FE20
			public bool Matches(global::NPOI.SS.Formula.TwoDEval areEval, int rowIndex, int columnIndex)
			{
				return !areEval.IsSubTotal(rowIndex, columnIndex);
			}
		}
	}
}
