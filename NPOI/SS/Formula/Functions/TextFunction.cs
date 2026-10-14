using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F6 RID: 502
	public abstract class TextFunction : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x000229FB File Offset: 0x00020BFB
		public static string EvaluateStringArg(global::NPOI.SS.Formula.Eval.ValueEval eval, int srcRow, int srcCol)
		{
			return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(eval, srcRow, srcCol));
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
		public static int EvaluateIntArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol));
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00022A0A File Offset: 0x00020C0A
		public static double EvaluateDoubleArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol));
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00022A1C File Offset: 0x00020C1C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = this.EvaluateFunc(args, srcCellRow, srcCellCol);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00022A50 File Offset: 0x00020C50
		internal static bool IsPrintable(char c)
		{
			return c >= ' ';
		}

		// Token: 0x06000CA9 RID: 3241
		public abstract global::NPOI.SS.Formula.Eval.ValueEval EvaluateFunc(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol);

		// Token: 0x040005BD RID: 1469
		protected static string EMPTY_STRING = "";

		// Token: 0x040005BE RID: 1470
		public static readonly global::NPOI.SS.Formula.Functions.Function LEN = new global::NPOI.SS.Formula.Functions.Len();

		// Token: 0x040005BF RID: 1471
		public static readonly global::NPOI.SS.Formula.Functions.Function LOWER = new global::NPOI.SS.Formula.Functions.Lower();

		// Token: 0x040005C0 RID: 1472
		public static readonly global::NPOI.SS.Formula.Functions.Function UPPER = new global::NPOI.SS.Formula.Functions.Upper();

		// Token: 0x040005C1 RID: 1473
		public static readonly global::NPOI.SS.Formula.Functions.Function TRIM = new global::NPOI.SS.Formula.Functions.Trim();

		// Token: 0x040005C2 RID: 1474
		public static readonly global::NPOI.SS.Formula.Functions.Function MID = new global::NPOI.SS.Formula.Functions.Mid();

		// Token: 0x040005C3 RID: 1475
		public static readonly global::NPOI.SS.Formula.Functions.Function LEFT = new global::NPOI.SS.Formula.Functions.LeftRight(true);

		// Token: 0x040005C4 RID: 1476
		public static readonly global::NPOI.SS.Formula.Functions.Function RIGHT = new global::NPOI.SS.Formula.Functions.LeftRight(false);

		// Token: 0x040005C5 RID: 1477
		public static readonly global::NPOI.SS.Formula.Functions.Function CONCATENATE = new global::NPOI.SS.Formula.Functions.Concatenate();

		// Token: 0x040005C6 RID: 1478
		public static readonly global::NPOI.SS.Formula.Functions.Function EXACT = new global::NPOI.SS.Formula.Functions.Exact();

		// Token: 0x040005C7 RID: 1479
		public static readonly global::NPOI.SS.Formula.Functions.Function TEXT = new global::NPOI.SS.Formula.Functions.Text();

		// Token: 0x040005C8 RID: 1480
		public static readonly global::NPOI.SS.Formula.Functions.Function FIND = new global::NPOI.SS.Formula.Functions.SearchFind(true);

		// Token: 0x040005C9 RID: 1481
		public static readonly global::NPOI.SS.Formula.Functions.Function SEARCH = new global::NPOI.SS.Formula.Functions.SearchFind(false);

		// Token: 0x040005CA RID: 1482
		public static readonly global::NPOI.SS.Formula.Functions.Function CLEAN = new global::NPOI.SS.Formula.Functions.Clean();

		// Token: 0x040005CB RID: 1483
		public static readonly global::NPOI.SS.Formula.Functions.Function CHAR = new global::NPOI.SS.Formula.Functions.CHAR();

		// Token: 0x040005CC RID: 1484
		public static readonly global::NPOI.SS.Formula.Functions.Function PROPER = new global::NPOI.SS.Formula.Functions.Proper();
	}
}
