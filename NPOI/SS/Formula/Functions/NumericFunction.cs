using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001CB RID: 459
	public abstract class NumericFunction : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000C1A RID: 3098 RVA: 0x00021030 File Offset: 0x0001F230
		public static double SingleOperandEvaluate(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			double result = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol));
			global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(result);
			return result;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0001C2D9 File Offset: 0x0001A4D9
		public static void CheckValue(double result)
		{
			if (double.IsNaN(result) || double.IsInfinity(result))
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00021048 File Offset: 0x0001F248
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			double num;
			try
			{
				num = this.Eval(args, srcCellRow, srcCellCol);
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x06000C1D RID: 3101
		protected abstract double Eval(global::NPOI.SS.Formula.Eval.ValueEval[] evals, int srcCellRow, int srcCellCol);

		// Token: 0x04000587 RID: 1415
		public const double TEN = 10.0;

		// Token: 0x04000588 RID: 1416
		public static readonly double LOG_10_TO_BASE_e = global::System.Math.Log(10.0);

		// Token: 0x04000589 RID: 1417
		public const double E = 2.718281828459045;

		// Token: 0x0400058A RID: 1418
		public const double PI = 3.141592653589793;

		// Token: 0x0400058B RID: 1419
		public const double ZERO = 0.0;

		// Token: 0x0400058C RID: 1420
		public static readonly global::NPOI.SS.Formula.Functions.Function ABS = new global::NPOI.SS.Formula.Functions.Abs();

		// Token: 0x0400058D RID: 1421
		public static readonly global::NPOI.SS.Formula.Functions.Function COS = new global::NPOI.SS.Formula.Functions.Cos();

		// Token: 0x0400058E RID: 1422
		public static readonly global::NPOI.SS.Formula.Functions.Function COSH = new global::NPOI.SS.Formula.Functions.Cosh();

		// Token: 0x0400058F RID: 1423
		public static readonly global::NPOI.SS.Formula.Functions.Function ACOS = new global::NPOI.SS.Formula.Functions.Acos();

		// Token: 0x04000590 RID: 1424
		public static readonly global::NPOI.SS.Formula.Functions.Function ACOSH = new global::NPOI.SS.Formula.Functions.Acosh();

		// Token: 0x04000591 RID: 1425
		public static readonly global::NPOI.SS.Formula.Functions.Function ASIN = new global::NPOI.SS.Formula.Functions.Asin();

		// Token: 0x04000592 RID: 1426
		public static readonly global::NPOI.SS.Formula.Functions.Function ASINH = new global::NPOI.SS.Formula.Functions.Asinh();

		// Token: 0x04000593 RID: 1427
		public static readonly global::NPOI.SS.Formula.Functions.Function SIN = new global::NPOI.SS.Formula.Functions.Sin();

		// Token: 0x04000594 RID: 1428
		public static readonly global::NPOI.SS.Formula.Functions.Function SINH = new global::NPOI.SS.Formula.Functions.Sinh();

		// Token: 0x04000595 RID: 1429
		public static readonly global::NPOI.SS.Formula.Functions.Function TAN = new global::NPOI.SS.Formula.Functions.Tan();

		// Token: 0x04000596 RID: 1430
		public static readonly global::NPOI.SS.Formula.Functions.Function TANH = new global::NPOI.SS.Formula.Functions.Tanh();

		// Token: 0x04000597 RID: 1431
		public static readonly global::NPOI.SS.Formula.Functions.Function ATAN = new global::NPOI.SS.Formula.Functions.Atan();

		// Token: 0x04000598 RID: 1432
		public static readonly global::NPOI.SS.Formula.Functions.Function ATANH = new global::NPOI.SS.Formula.Functions.Atanh();

		// Token: 0x04000599 RID: 1433
		public static readonly global::NPOI.SS.Formula.Functions.Function ATAN2 = new global::NPOI.SS.Formula.Functions.Atan2();

		// Token: 0x0400059A RID: 1434
		public static readonly global::NPOI.SS.Formula.Functions.Function DEGREES = new global::NPOI.SS.Formula.Functions.Degrees();

		// Token: 0x0400059B RID: 1435
		public static readonly global::NPOI.SS.Formula.Functions.Function DOLLAR = new global::NPOI.SS.Formula.Functions.Dollar();

		// Token: 0x0400059C RID: 1436
		public static readonly global::NPOI.SS.Formula.Functions.Function EXP = new global::NPOI.SS.Formula.Functions.Exp();

		// Token: 0x0400059D RID: 1437
		public static readonly global::NPOI.SS.Formula.Functions.Function FACT = new global::NPOI.SS.Formula.Functions.Fact();

		// Token: 0x0400059E RID: 1438
		public static readonly global::NPOI.SS.Formula.Functions.Function INT = new global::NPOI.SS.Formula.Functions.Int();

		// Token: 0x0400059F RID: 1439
		public static readonly global::NPOI.SS.Formula.Functions.Function LN = new global::NPOI.SS.Formula.Functions.Ln();

		// Token: 0x040005A0 RID: 1440
		public static readonly global::NPOI.SS.Formula.Functions.Function LOG10 = new global::NPOI.SS.Formula.Functions.Log10();

		// Token: 0x040005A1 RID: 1441
		public static readonly global::NPOI.SS.Formula.Functions.Function RADIANS = new global::NPOI.SS.Formula.Functions.Radians();

		// Token: 0x040005A2 RID: 1442
		public static readonly global::NPOI.SS.Formula.Functions.Function SIGN = new global::NPOI.SS.Formula.Functions.Sign();

		// Token: 0x040005A3 RID: 1443
		public static readonly global::NPOI.SS.Formula.Functions.Function SQRT = new global::NPOI.SS.Formula.Functions.Sqrt();

		// Token: 0x040005A4 RID: 1444
		public static readonly global::NPOI.SS.Formula.Functions.Function CEILING = new global::NPOI.SS.Formula.Functions.Ceiling();

		// Token: 0x040005A5 RID: 1445
		public static readonly global::NPOI.SS.Formula.Functions.Function COMBIN = new global::NPOI.SS.Formula.Functions.Combin();

		// Token: 0x040005A6 RID: 1446
		public static readonly global::NPOI.SS.Formula.Functions.Function FLOOR = new global::NPOI.SS.Formula.Functions.Floor();

		// Token: 0x040005A7 RID: 1447
		public static readonly global::NPOI.SS.Formula.Functions.Function MOD = new global::NPOI.SS.Formula.Functions.Mod();

		// Token: 0x040005A8 RID: 1448
		public static readonly global::NPOI.SS.Formula.Functions.Function POWER = new global::NPOI.SS.Formula.Functions.Power();

		// Token: 0x040005A9 RID: 1449
		public static readonly global::NPOI.SS.Formula.Functions.Function ROUND = new global::NPOI.SS.Formula.Functions.Round();

		// Token: 0x040005AA RID: 1450
		public static readonly global::NPOI.SS.Formula.Functions.Function ROUNDDOWN = new global::NPOI.SS.Formula.Functions.Rounddown();

		// Token: 0x040005AB RID: 1451
		public static readonly global::NPOI.SS.Formula.Functions.Function ROUNDUP = new global::NPOI.SS.Formula.Functions.Roundup();

		// Token: 0x040005AC RID: 1452
		public static readonly global::NPOI.SS.Formula.Functions.Function LOG = new global::NPOI.SS.Formula.Functions.Log();

		// Token: 0x040005AD RID: 1453
		public static readonly global::NPOI.SS.Formula.Functions.Function TRUNC = new global::NPOI.SS.Formula.Functions.Trunc();

		// Token: 0x040005AE RID: 1454
		public static readonly global::NPOI.SS.Formula.Functions.Function POISSON = new global::NPOI.SS.Formula.Functions.Poisson();
	}
}
