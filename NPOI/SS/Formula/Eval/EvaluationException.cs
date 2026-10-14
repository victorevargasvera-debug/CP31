using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200020A RID: 522
	[global::System.Serializable]
	public class EvaluationException : global::System.Exception
	{
		// Token: 0x06000D10 RID: 3344 RVA: 0x00023846 File Offset: 0x00021A46
		public EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval errorEval)
		{
			this._errorEval = errorEval;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00023855 File Offset: 0x00021A55
		public static global::NPOI.SS.Formula.Eval.EvaluationException InvalidValue()
		{
			return new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00023861 File Offset: 0x00021A61
		public static global::NPOI.SS.Formula.Eval.EvaluationException InvalidRef()
		{
			return new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0002386D File Offset: 0x00021A6D
		public static global::NPOI.SS.Formula.Eval.EvaluationException NumberError()
		{
			return new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00023879 File Offset: 0x00021A79
		public global::NPOI.SS.Formula.Eval.ErrorEval GetErrorEval()
		{
			return this._errorEval;
		}

		// Token: 0x040005EF RID: 1519
		private global::NPOI.SS.Formula.Eval.ErrorEval _errorEval;
	}
}
