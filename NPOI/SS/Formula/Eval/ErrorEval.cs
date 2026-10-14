using System;
using System.Collections.Generic;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000208 RID: 520
	public class ErrorEval : global::NPOI.SS.Formula.Eval.ValueEval
	{
		// Token: 0x06000D09 RID: 3337 RVA: 0x000236A0 File Offset: 0x000218A0
		public static global::NPOI.SS.Formula.Eval.ErrorEval ValueOf(int errorCode)
		{
			global::NPOI.SS.UserModel.FormulaError key = global::NPOI.SS.UserModel.FormulaError.ForInt(errorCode);
			if (global::NPOI.SS.Formula.Eval.ErrorEval.evals.ContainsKey(key))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.evals[key];
			}
			throw new global::NPOI.Util.RuntimeException("Unhandled error type  for code " + errorCode.ToString());
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x000236E3 File Offset: 0x000218E3
		public static string GetText(int errorCode)
		{
			if (global::NPOI.SS.UserModel.FormulaError.IsValidCode(errorCode))
			{
				return global::NPOI.SS.UserModel.FormulaError.ForInt(errorCode).String;
			}
			return "~non~std~err(" + errorCode.ToString() + ")~";
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0002370F File Offset: 0x0002190F
		private ErrorEval(global::NPOI.SS.UserModel.FormulaError error)
		{
			this._error = error;
			if (!global::NPOI.SS.Formula.Eval.ErrorEval.evals.ContainsKey(error))
			{
				global::NPOI.SS.Formula.Eval.ErrorEval.evals.Add(error, this);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00023737 File Offset: 0x00021937
		public int ErrorCode
		{
			get
			{
				return this._error.LongCode;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00023744 File Offset: 0x00021944
		public string ErrorString
		{
			get
			{
				return this._error.String;
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00023754 File Offset: 0x00021954
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this._error.String);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040005E4 RID: 1508
		private static global::System.Collections.Generic.Dictionary<global::NPOI.SS.UserModel.FormulaError, global::NPOI.SS.Formula.Eval.ErrorEval> evals = new global::System.Collections.Generic.Dictionary<global::NPOI.SS.UserModel.FormulaError, global::NPOI.SS.Formula.Eval.ErrorEval>();

		// Token: 0x040005E5 RID: 1509
		public static readonly global::NPOI.SS.Formula.Eval.ErrorEval NULL_INTERSECTION = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.NULL);

		// Token: 0x040005E6 RID: 1510
		public static readonly global::NPOI.SS.Formula.Eval.ErrorEval DIV_ZERO = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.DIV0);

		// Token: 0x040005E7 RID: 1511
		public static readonly global::NPOI.SS.Formula.Eval.ErrorEval VALUE_INVALID = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.VALUE);

		// Token: 0x040005E8 RID: 1512
		public static readonly global::NPOI.SS.Formula.Eval.ErrorEval REF_INVALID = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.REF);

		// Token: 0x040005E9 RID: 1513
		public static readonly global::NPOI.SS.Formula.Eval.ErrorEval NAME_INVALID = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.NAME);

		// Token: 0x040005EA RID: 1514
		public static readonly global::NPOI.SS.Formula.Eval.ErrorEval NUM_ERROR = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.NUM);

		// Token: 0x040005EB RID: 1515
		public static readonly global::NPOI.SS.Formula.Eval.ErrorEval NA = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.NA);

		// Token: 0x040005EC RID: 1516
		public static global::NPOI.SS.Formula.Eval.ErrorEval FUNCTION_NOT_IMPLEMENTED = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.FUNCTION_NOT_IMPLEMENTED);

		// Token: 0x040005ED RID: 1517
		public static global::NPOI.SS.Formula.Eval.ErrorEval CIRCULAR_REF_ERROR = new global::NPOI.SS.Formula.Eval.ErrorEval(global::NPOI.SS.UserModel.FormulaError.CIRCULAR_REF);

		// Token: 0x040005EE RID: 1518
		private global::NPOI.SS.UserModel.FormulaError _error;
	}
}
