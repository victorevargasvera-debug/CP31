using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A4 RID: 420
	public abstract class LogicalFunction : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000B7C RID: 2940 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			global::NPOI.SS.Formula.Eval.ValueEval arg;
			try
			{
				arg = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				arg = ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(this.Evaluate(arg));
		}

		// Token: 0x06000B7D RID: 2941
		protected abstract bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg);

		// Token: 0x04000569 RID: 1385
		public static readonly global::NPOI.SS.Formula.Functions.Function ISLOGICAL = new global::NPOI.SS.Formula.Functions.Islogical();

		// Token: 0x0400056A RID: 1386
		public static readonly global::NPOI.SS.Formula.Functions.Function ISNONTEXT = new global::NPOI.SS.Formula.Functions.Isnontext();

		// Token: 0x0400056B RID: 1387
		public static readonly global::NPOI.SS.Formula.Functions.Function ISNUMBER = new global::NPOI.SS.Formula.Functions.Isnumber();

		// Token: 0x0400056C RID: 1388
		public static readonly global::NPOI.SS.Formula.Functions.Function ISTEXT = new global::NPOI.SS.Formula.Functions.Istext();

		// Token: 0x0400056D RID: 1389
		public static readonly global::NPOI.SS.Formula.Functions.Function ISBLANK = new global::NPOI.SS.Formula.Functions.Isblank();

		// Token: 0x0400056E RID: 1390
		public static readonly global::NPOI.SS.Formula.Functions.Function ISERROR = new global::NPOI.SS.Formula.Functions.Iserror();

		// Token: 0x0400056F RID: 1391
		public static readonly global::NPOI.SS.Formula.Functions.Function ISNA = new global::NPOI.SS.Formula.Functions.Isna();

		// Token: 0x04000570 RID: 1392
		public static readonly global::NPOI.SS.Formula.Functions.Function ISREF = new global::NPOI.SS.Formula.Functions.Isref();

		// Token: 0x04000571 RID: 1393
		public static readonly global::NPOI.SS.Formula.Functions.Function ISERR = new global::NPOI.SS.Formula.Functions.Iserr();
	}
}
