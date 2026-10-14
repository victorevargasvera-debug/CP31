using System;
using System.Text;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Constant
{
	// Token: 0x020000E7 RID: 231
	public class ErrorConstant
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00015BEA File Offset: 0x00013DEA
		private ErrorConstant(int errorCode)
		{
			this._errorCode = errorCode;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00015BF9 File Offset: 0x00013DF9
		public int ErrorCode
		{
			get
			{
				return this._errorCode;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00015C01 File Offset: 0x00013E01
		public string Text
		{
			get
			{
				if (global::NPOI.SS.UserModel.FormulaError.IsValidCode(this._errorCode))
				{
					return global::NPOI.SS.UserModel.FormulaError.ForInt(this._errorCode).String;
				}
				return "unknown error code (" + this._errorCode.ToString() + ")";
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00015C3C File Offset: 0x00013E3C
		public static global::NPOI.SS.Formula.Constant.ErrorConstant ValueOf(int errorCode)
		{
			if (global::NPOI.SS.UserModel.FormulaError.IsValidCode(errorCode))
			{
				global::NPOI.SS.UserModel.FormulaErrorEnum formulaErrorEnum = (global::NPOI.SS.UserModel.FormulaErrorEnum)errorCode;
				if (formulaErrorEnum <= global::NPOI.SS.UserModel.FormulaErrorEnum.VALUE)
				{
					if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NULL)
					{
						return global::NPOI.SS.Formula.Constant.ErrorConstant.NULL;
					}
					if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.DIV_0)
					{
						return global::NPOI.SS.Formula.Constant.ErrorConstant.DIV_0;
					}
					if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.VALUE)
					{
						return global::NPOI.SS.Formula.Constant.ErrorConstant.VALUE;
					}
				}
				else if (formulaErrorEnum <= global::NPOI.SS.UserModel.FormulaErrorEnum.NAME)
				{
					if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.REF)
					{
						return global::NPOI.SS.Formula.Constant.ErrorConstant.REF;
					}
					if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NAME)
					{
						return global::NPOI.SS.Formula.Constant.ErrorConstant.NAME;
					}
				}
				else
				{
					if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NUM)
					{
						return global::NPOI.SS.Formula.Constant.ErrorConstant.NUM;
					}
					if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NA)
					{
						return global::NPOI.SS.Formula.Constant.ErrorConstant.NA;
					}
				}
			}
			global::System.Console.Error.WriteLine("Warning - Unexpected error code (" + errorCode.ToString() + ")");
			return new global::NPOI.SS.Formula.Constant.ErrorConstant(errorCode);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00015CDC File Offset: 0x00013EDC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.Text);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x04000428 RID: 1064
		private static readonly global::NPOI.SS.Formula.Constant.ErrorConstant NULL = new global::NPOI.SS.Formula.Constant.ErrorConstant((int)global::NPOI.SS.UserModel.FormulaError.NULL.Code);

		// Token: 0x04000429 RID: 1065
		private static readonly global::NPOI.SS.Formula.Constant.ErrorConstant DIV_0 = new global::NPOI.SS.Formula.Constant.ErrorConstant((int)global::NPOI.SS.UserModel.FormulaError.DIV0.Code);

		// Token: 0x0400042A RID: 1066
		private static readonly global::NPOI.SS.Formula.Constant.ErrorConstant VALUE = new global::NPOI.SS.Formula.Constant.ErrorConstant((int)global::NPOI.SS.UserModel.FormulaError.VALUE.Code);

		// Token: 0x0400042B RID: 1067
		private static readonly global::NPOI.SS.Formula.Constant.ErrorConstant REF = new global::NPOI.SS.Formula.Constant.ErrorConstant((int)global::NPOI.SS.UserModel.FormulaError.REF.Code);

		// Token: 0x0400042C RID: 1068
		private static readonly global::NPOI.SS.Formula.Constant.ErrorConstant NAME = new global::NPOI.SS.Formula.Constant.ErrorConstant((int)global::NPOI.SS.UserModel.FormulaError.NAME.Code);

		// Token: 0x0400042D RID: 1069
		private static readonly global::NPOI.SS.Formula.Constant.ErrorConstant NUM = new global::NPOI.SS.Formula.Constant.ErrorConstant((int)global::NPOI.SS.UserModel.FormulaError.NUM.Code);

		// Token: 0x0400042E RID: 1070
		private static readonly global::NPOI.SS.Formula.Constant.ErrorConstant NA = new global::NPOI.SS.Formula.Constant.ErrorConstant((int)global::NPOI.SS.UserModel.FormulaError.NA.Code);

		// Token: 0x0400042F RID: 1071
		private int _errorCode;
	}
}
