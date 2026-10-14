using System;
using System.Text;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Util;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000159 RID: 345
	public class Address : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x0001CD70 File Offset: 0x0001AF70
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length < 2 || args.Length > 5)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				int num = (int)global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(args[0], srcRowIndex, srcColumnIndex);
				int num2 = (int)global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(args[1], srcRowIndex, srcColumnIndex);
				int num3;
				if (args.Length > 2 && args[2] != global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
				{
					num3 = (int)global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(args[2], srcRowIndex, srcColumnIndex);
				}
				else
				{
					num3 = 1;
				}
				bool pAbsRow;
				bool pAbsCol;
				switch (num3)
				{
				case 1:
					pAbsRow = true;
					pAbsCol = true;
					break;
				case 2:
					pAbsRow = true;
					pAbsCol = false;
					break;
				case 3:
					pAbsRow = false;
					pAbsCol = true;
					break;
				case 4:
					pAbsRow = false;
					pAbsCol = false;
					break;
				default:
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				if (args.Length > 3)
				{
					global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[3], srcRowIndex, srcColumnIndex);
					if (singleValue != global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
					{
						bool value = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(singleValue, false).Value;
					}
				}
				string text;
				if (args.Length == 5)
				{
					global::NPOI.SS.Formula.Eval.ValueEval singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[4], srcRowIndex, srcColumnIndex);
					text = ((singleValue2 == global::NPOI.SS.Formula.Eval.MissingArgEval.instance) ? null : global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue2));
				}
				else
				{
					text = null;
				}
				global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(num - 1, num2 - 1, pAbsRow, pAbsCol);
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(32);
				if (text != null)
				{
					global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, text);
					stringBuilder.Append('!');
				}
				stringBuilder.Append(cellReference.FormatAsString());
				result = new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x04000536 RID: 1334
		public const int REF_ABSOLUTE = 1;

		// Token: 0x04000537 RID: 1335
		public const int REF_ROW_ABSOLUTE_COLUMN_RELATIVE = 2;

		// Token: 0x04000538 RID: 1336
		public const int REF_ROW_RELATIVE_RELATIVE_ABSOLUTE = 3;

		// Token: 0x04000539 RID: 1337
		public const int REF_RELATIVE = 4;
	}
}
