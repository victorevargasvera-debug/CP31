using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F3 RID: 499
	public class Substitute : global::NPOI.SS.Formula.Functions.TextFunction
	{
		// Token: 0x06000C9A RID: 3226 RVA: 0x000227E0 File Offset: 0x000209E0
		public override global::NPOI.SS.Formula.Eval.ValueEval EvaluateFunc(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			if (args.Length < 3 || args.Length > 4)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string oldStr = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[0], srcCellRow, srcCellCol);
			string searchStr = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[1], srcCellRow, srcCellCol);
			string newStr = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[2], srcCellRow, srcCellCol);
			int num = args.Length;
			string value;
			if (num != 3)
			{
				if (num != 4)
				{
					throw new global::System.InvalidOperationException("Cannot happen");
				}
				int num2 = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateIntArg(args[3], srcCellRow, srcCellCol);
				if (num2 < 1)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				value = global::NPOI.SS.Formula.Functions.Substitute.ReplaceOneOccurrence(oldStr, searchStr, newStr, num2);
			}
			else
			{
				value = global::NPOI.SS.Formula.Functions.Substitute.ReplaceAllOccurrences(oldStr, searchStr, newStr);
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(value);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00022870 File Offset: 0x00020A70
		private static string ReplaceAllOccurrences(string oldStr, string searchStr, string newStr)
		{
			if (searchStr.Length < 1)
			{
				return oldStr;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = 0;
			for (;;)
			{
				int num2 = oldStr.IndexOf(searchStr, num, global::System.StringComparison.CurrentCulture);
				if (num2 < 0)
				{
					break;
				}
				stringBuilder.Append(oldStr.Substring(num, num2 - num));
				stringBuilder.Append(newStr);
				num = num2 + searchStr.Length;
			}
			stringBuilder.Append(oldStr.Substring(num));
			return stringBuilder.ToString();
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000228D8 File Offset: 0x00020AD8
		private static string ReplaceOneOccurrence(string oldStr, string searchStr, string newStr, int instanceNumber)
		{
			if (searchStr.Length < 1)
			{
				return oldStr;
			}
			int startIndex = 0;
			int num = 0;
			int num2;
			for (;;)
			{
				num2 = oldStr.IndexOf(searchStr, startIndex, global::System.StringComparison.CurrentCulture);
				if (num2 < 0)
				{
					break;
				}
				num++;
				if (num == instanceNumber)
				{
					goto Block_3;
				}
				startIndex = num2 + searchStr.Length;
			}
			return oldStr;
			Block_3:
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(oldStr.Length + newStr.Length);
			stringBuilder.Append(oldStr.Substring(0, num2));
			stringBuilder.Append(newStr);
			stringBuilder.Append(oldStr.Substring(num2 + searchStr.Length));
			return stringBuilder.ToString();
		}
	}
}
