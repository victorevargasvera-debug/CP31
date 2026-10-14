using System;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000106 RID: 262
	public class ErrPtg : global::NPOI.SS.Formula.PTG.ScalarConstantPtg
	{
		// Token: 0x060008D2 RID: 2258 RVA: 0x00017FD4 File Offset: 0x000161D4
		public static global::NPOI.SS.Formula.PTG.ErrPtg ValueOf(int code)
		{
			global::NPOI.SS.UserModel.FormulaErrorEnum formulaErrorEnum = (global::NPOI.SS.UserModel.FormulaErrorEnum)code;
			if (formulaErrorEnum <= global::NPOI.SS.UserModel.FormulaErrorEnum.VALUE)
			{
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NULL)
				{
					return global::NPOI.SS.Formula.PTG.ErrPtg.NULL_INTERSECTION;
				}
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.DIV_0)
				{
					return global::NPOI.SS.Formula.PTG.ErrPtg.DIV_ZERO;
				}
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.VALUE)
				{
					return global::NPOI.SS.Formula.PTG.ErrPtg.VALUE_INVALID;
				}
			}
			else if (formulaErrorEnum <= global::NPOI.SS.UserModel.FormulaErrorEnum.NAME)
			{
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.REF)
				{
					return global::NPOI.SS.Formula.PTG.ErrPtg.REF_INVALID;
				}
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NAME)
				{
					return global::NPOI.SS.Formula.PTG.ErrPtg.NAME_INVALID;
				}
			}
			else
			{
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NUM)
				{
					return global::NPOI.SS.Formula.PTG.ErrPtg.NUM_ERROR;
				}
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NA)
				{
					return global::NPOI.SS.Formula.PTG.ErrPtg.N_A;
				}
			}
			throw new global::System.InvalidOperationException("Unexpected error code (" + code.ToString() + ")");
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00018061 File Offset: 0x00016261
		public ErrPtg(int errorCode)
		{
			if (!global::NPOI.SS.UserModel.FormulaError.IsValidCode(errorCode))
			{
				throw new global::System.ArgumentException("Invalid error code (" + errorCode.ToString() + ")");
			}
			this.field_1_error_code = errorCode;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00018094 File Offset: 0x00016294
		public ErrPtg(global::NPOI.Util.ILittleEndianInput in1) : this(in1.ReadByte())
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000180A2 File Offset: 0x000162A2
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(28 + base.PtgClass));
			out1.WriteByte((int)((byte)this.field_1_error_code));
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000180C0 File Offset: 0x000162C0
		public override string ToFormulaString()
		{
			return global::NPOI.SS.UserModel.FormulaError.ForInt(this.field_1_error_code).String;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int Size
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000180D2 File Offset: 0x000162D2
		public int ErrorCode
		{
			get
			{
				return this.field_1_error_code;
			}
		}

		// Token: 0x04000487 RID: 1159
		public static readonly global::NPOI.SS.Formula.PTG.ErrPtg NULL_INTERSECTION = new global::NPOI.SS.Formula.PTG.ErrPtg((int)global::NPOI.SS.UserModel.FormulaError.NULL.Code);

		// Token: 0x04000488 RID: 1160
		public static readonly global::NPOI.SS.Formula.PTG.ErrPtg DIV_ZERO = new global::NPOI.SS.Formula.PTG.ErrPtg((int)global::NPOI.SS.UserModel.FormulaError.DIV0.Code);

		// Token: 0x04000489 RID: 1161
		public static readonly global::NPOI.SS.Formula.PTG.ErrPtg VALUE_INVALID = new global::NPOI.SS.Formula.PTG.ErrPtg((int)global::NPOI.SS.UserModel.FormulaError.VALUE.Code);

		// Token: 0x0400048A RID: 1162
		public static readonly global::NPOI.SS.Formula.PTG.ErrPtg REF_INVALID = new global::NPOI.SS.Formula.PTG.ErrPtg((int)global::NPOI.SS.UserModel.FormulaError.REF.Code);

		// Token: 0x0400048B RID: 1163
		public static readonly global::NPOI.SS.Formula.PTG.ErrPtg NAME_INVALID = new global::NPOI.SS.Formula.PTG.ErrPtg((int)global::NPOI.SS.UserModel.FormulaError.NAME.Code);

		// Token: 0x0400048C RID: 1164
		public static readonly global::NPOI.SS.Formula.PTG.ErrPtg NUM_ERROR = new global::NPOI.SS.Formula.PTG.ErrPtg((int)global::NPOI.SS.UserModel.FormulaError.NUM.Code);

		// Token: 0x0400048D RID: 1165
		public static readonly global::NPOI.SS.Formula.PTG.ErrPtg N_A = new global::NPOI.SS.Formula.PTG.ErrPtg((int)global::NPOI.SS.UserModel.FormulaError.NA.Code);

		// Token: 0x0400048E RID: 1166
		public const byte sid = 28;

		// Token: 0x0400048F RID: 1167
		private const int SIZE = 2;

		// Token: 0x04000490 RID: 1168
		private int field_1_error_code;
	}
}
