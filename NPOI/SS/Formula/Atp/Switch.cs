using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000236 RID: 566
	public class Switch : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DCC RID: 3532 RVA: 0x0000253E File Offset: 0x0000073E
		private Switch()
		{
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0002699C File Offset: 0x00024B9C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length < 3)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
			}
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], ec.RowIndex, ec.ColumnIndex);
			}
			catch (global::System.Exception)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
			}
			for (int i = 1; i < args.Length; i += 2)
			{
				try
				{
					global::NPOI.SS.Formula.Eval.ValueEval singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[i], ec.RowIndex, ec.ColumnIndex);
					global::NPOI.SS.Formula.Eval.ValueEval result = args[i + 1];
					global::NPOI.SS.Formula.Eval.ValueEval valueEval = new global::NPOI.SS.Formula.Eval.EqualEval().Evaluate(new global::NPOI.SS.Formula.Eval.ValueEval[]
					{
						singleValue,
						singleValue2
					}, ec.RowIndex, ec.ColumnIndex);
					if (valueEval is global::NPOI.SS.Formula.Eval.BoolEval && ((global::NPOI.SS.Formula.Eval.BoolEval)valueEval).BooleanValue)
					{
						return result;
					}
				}
				catch (global::NPOI.SS.Formula.Eval.EvaluationException)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
				}
				if (i + 2 == args.Length - 1)
				{
					return args[args.Length - 1];
				}
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
		}

		// Token: 0x04000626 RID: 1574
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Atp.Switch();
	}
}
