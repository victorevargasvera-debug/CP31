using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula
{
	// Token: 0x020000DF RID: 223
	public class UserDefinedFunction : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x0000253E File Offset: 0x0000073E
		private UserDefinedFunction()
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00014364 File Offset: 0x00012564
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			int num = args.Length;
			if (num < 1)
			{
				throw new global::System.Exception("function name argument missing");
			}
			global::NPOI.SS.Formula.Eval.ValueEval valueEval = args[0];
			string functionName = string.Empty;
			if (!(valueEval is global::NPOI.SS.Formula.Eval.FunctionNameEval))
			{
				throw new global::System.Exception("First argument should be a NameEval, but got (" + valueEval.GetType().Name + ")");
			}
			functionName = ((global::NPOI.SS.Formula.Eval.FunctionNameEval)valueEval).FunctionName;
			global::NPOI.SS.Formula.Functions.FreeRefFunction freeRefFunction = ec.FindUserDefinedFunction(functionName);
			if (freeRefFunction == null)
			{
				throw new global::NPOI.SS.Formula.Eval.NotImplementedFunctionException(functionName);
			}
			int num2 = num - 1;
			global::NPOI.SS.Formula.Eval.ValueEval[] array = new global::NPOI.SS.Formula.Eval.ValueEval[num2];
			global::System.Array.Copy(args, 1, array, 0, num2);
			return freeRefFunction.Evaluate(array, ec);
		}

		// Token: 0x040003F7 RID: 1015
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.UserDefinedFunction();
	}
}
