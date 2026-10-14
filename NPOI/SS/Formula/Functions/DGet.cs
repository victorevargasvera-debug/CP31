using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000139 RID: 313
	public class DGet : global::NPOI.SS.Formula.Functions.IDStarAlgorithm
	{
		// Token: 0x06000A24 RID: 2596 RVA: 0x0001A78C File Offset: 0x0001898C
		public bool ProcessMatch(global::NPOI.SS.Formula.Eval.ValueEval eval)
		{
			if (this.result == null)
			{
				this.result = eval;
				return true;
			}
			this.result = global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			return false;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0001A7B0 File Offset: 0x000189B0
		public global::NPOI.SS.Formula.Eval.ValueEval Result
		{
			get
			{
				if (this.result == null)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				if (this.result is global::NPOI.SS.Formula.Eval.BlankEval)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				global::NPOI.SS.Formula.Eval.ValueEval valueEval;
				try
				{
					if (global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(this.result, 0, 0)).Equals(""))
					{
						valueEval = global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
					}
					else
					{
						valueEval = this.result;
					}
				}
				catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
				{
					valueEval = ex.GetErrorEval();
				}
				return valueEval;
			}
		}

		// Token: 0x04000513 RID: 1299
		private global::NPOI.SS.Formula.Eval.ValueEval result;
	}
}
