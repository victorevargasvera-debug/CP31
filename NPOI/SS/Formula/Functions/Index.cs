using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000198 RID: 408
	public class Index : global::NPOI.SS.Formula.Functions.Function2Arg, global::NPOI.SS.Formula.Functions.Function, global::NPOI.SS.Formula.Functions.Function3Arg, global::NPOI.SS.Formula.Functions.Function4Arg
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x0001E8FC File Offset: 0x0001CAFC
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			global::NPOI.SS.Formula.TwoDEval twoDEval = global::NPOI.SS.Formula.Functions.Index.ConvertFirstArg(arg0);
			int pColumnIx = 0;
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				int num = global::NPOI.SS.Formula.Functions.Index.ResolveIndexArg(arg1, srcRowIndex, srcColumnIndex);
				if (!twoDEval.IsColumn)
				{
					if (!twoDEval.IsRow)
					{
						return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
					}
					pColumnIx = num;
					num = 0;
				}
				result = global::NPOI.SS.Formula.Functions.Index.GetValueFromArea(twoDEval, num, pColumnIx);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0001E95C File Offset: 0x0001CB5C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			global::NPOI.SS.Formula.TwoDEval ae = global::NPOI.SS.Formula.Functions.Index.ConvertFirstArg(arg0);
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				int pColumnIx = global::NPOI.SS.Formula.Functions.Index.ResolveIndexArg(arg2, srcRowIndex, srcColumnIndex);
				int pRowIx = global::NPOI.SS.Formula.Functions.Index.ResolveIndexArg(arg1, srcRowIndex, srcColumnIndex);
				result = global::NPOI.SS.Formula.Functions.Index.GetValueFromArea(ae, pRowIx, pColumnIx);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2, global::NPOI.SS.Formula.Eval.ValueEval arg3)
		{
			throw new global::System.Exception("Incomplete code - don't know how to support the 'area_num' parameter yet)");
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
		private static global::NPOI.SS.Formula.TwoDEval ConvertFirstArg(global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			if (arg0 is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return ((global::NPOI.SS.Formula.Eval.RefEval)arg0).Offset(0, 0, 0, 0);
			}
			if (arg0 is global::NPOI.SS.Formula.TwoDEval)
			{
				return (global::NPOI.SS.Formula.TwoDEval)arg0;
			}
			throw new global::System.Exception("Incomplete code - cannot handle first arg of type (" + arg0.GetType().Name + ")");
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0001EA0C File Offset: 0x0001CC0C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			switch (args.Length)
			{
			case 2:
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1]);
			case 3:
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2]);
			case 4:
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2], args[3]);
			default:
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0001EA70 File Offset: 0x0001CC70
		private static global::NPOI.SS.Formula.Eval.ValueEval GetValueFromArea(global::NPOI.SS.Formula.TwoDEval ae, int pRowIx, int pColumnIx)
		{
			global::NPOI.SS.Formula.TwoDEval twoDEval = ae;
			if (pRowIx != 0)
			{
				if (pRowIx > ae.Height)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID);
				}
				twoDEval = twoDEval.GetRow(pRowIx - 1);
			}
			if (pColumnIx != 0)
			{
				if (pColumnIx > ae.Width)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID);
				}
				twoDEval = twoDEval.GetColumn(pColumnIx - 1);
			}
			return twoDEval;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0001EAC4 File Offset: 0x0001CCC4
		[global::System.Obsolete]
		private static global::NPOI.SS.Formula.Eval.ValueEval GetValueFromArea(global::NPOI.SS.Formula.Eval.AreaEval ae, int pRowIx, int pColumnIx, bool colArgWasPassed, int srcRowIx, int srcColIx)
		{
			bool flag = pRowIx == 0;
			bool flag2 = pColumnIx == 0;
			int num;
			int num2;
			if (ae.IsRow)
			{
				if (ae.IsColumn)
				{
					num = (flag ? 0 : (pRowIx - 1));
					num2 = (flag2 ? 0 : (pColumnIx - 1));
				}
				else if (colArgWasPassed)
				{
					num = (flag ? 0 : (pRowIx - 1));
					num2 = pColumnIx - 1;
				}
				else
				{
					num = 0;
					num2 = pRowIx - 1;
					flag2 = flag;
				}
			}
			else if (ae.IsColumn)
			{
				if (flag)
				{
					num = srcRowIx - ae.FirstRow;
				}
				else
				{
					num = pRowIx - 1;
				}
				if (flag2)
				{
					num2 = 0;
				}
				else
				{
					num2 = (flag2 ? 0 : (pColumnIx - 1));
				}
			}
			else
			{
				if (!colArgWasPassed)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException((pRowIx < 0) ? global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID : global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID);
				}
				if (flag)
				{
					num = srcRowIx - ae.FirstRow;
				}
				else
				{
					num = pRowIx - 1;
				}
				if (flag2)
				{
					num2 = srcColIx - ae.FirstColumn;
				}
				else
				{
					num2 = pColumnIx - 1;
				}
			}
			int width = ae.Width;
			int height = ae.Height;
			if ((!flag && num >= height) || (!flag2 && num2 >= width))
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID);
			}
			if (num < 0 || num2 < 0 || num >= height || num2 >= width)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			return ae.GetRelativeValue(num, num2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0001EBE0 File Offset: 0x0001CDE0
		private static int ResolveIndexArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol);
			if (singleValue == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
			{
				return 0;
			}
			if (singleValue == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return 0;
			}
			int num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(singleValue);
			if (num < 0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			return num;
		}
	}
}
