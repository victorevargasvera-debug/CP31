using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B8 RID: 440
	public class NotImplementedFunction : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000BEA RID: 3050 RVA: 0x00020BDB File Offset: 0x0001EDDB
		internal NotImplementedFunction()
		{
			this._functionName = base.GetType().Name;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		public NotImplementedFunction(string name)
		{
			this._functionName = name;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00020C03 File Offset: 0x0001EE03
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] operands, int srcRow, int srcCol)
		{
			throw new global::NPOI.SS.Formula.Eval.NotImplementedFunctionException(this._functionName);
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00020C10 File Offset: 0x0001EE10
		public string FunctionName
		{
			get
			{
				return this._functionName;
			}
		}

		// Token: 0x04000586 RID: 1414
		private string _functionName;
	}
}
