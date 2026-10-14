using System;
using System.Text;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000199 RID: 409
	public class Indirect : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000B5E RID: 2910 RVA: 0x0000253E File Offset: 0x0000073E
		private Indirect()
		{
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001EC20 File Offset: 0x0001CE20
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length < 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string text;
			bool isA1style;
			try
			{
				text = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], ec.RowIndex, ec.ColumnIndex));
				int num = args.Length;
				if (num != 1)
				{
					if (num != 2)
					{
						return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
					}
					isA1style = global::NPOI.SS.Formula.Functions.Indirect.EvaluateBooleanArg(args[1], ec);
				}
				else
				{
					isA1style = true;
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Functions.Indirect.EvaluateIndirect(ec, text, isA1style);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
		private static bool EvaluateBooleanArg(global::NPOI.SS.Formula.Eval.ValueEval arg, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, ec.RowIndex, ec.ColumnIndex);
			return singleValue != global::NPOI.SS.Formula.Eval.BlankEval.instance && singleValue != global::NPOI.SS.Formula.Eval.MissingArgEval.instance && global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(singleValue, false).Value;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
		private static global::NPOI.SS.Formula.Eval.ValueEval EvaluateIndirect(global::NPOI.SS.Formula.OperationEvaluationContext ec, string text, bool isA1style)
		{
			int rowIndex = ec.RowIndex;
			int columnIndex = ec.ColumnIndex;
			int num = text.LastIndexOf('!');
			string workbookName;
			string sheetName;
			string text2;
			if (num < 0)
			{
				workbookName = null;
				sheetName = null;
				text2 = text;
			}
			else
			{
				string[] array = global::NPOI.SS.Formula.Functions.Indirect.ParseWorkbookAndSheetName(text.Substring(0, num));
				if (array == null)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
				}
				workbookName = array[0];
				sheetName = array[1];
				text2 = text.Substring(num + 1);
			}
			if (global::NPOI.SS.UserModel.Table.IsStructuredReference.Match(text2).Success)
			{
				global::NPOI.SS.Formula.PTG.Area3DPxg aptg = null;
				try
				{
					aptg = global::NPOI.SS.Formula.FormulaParser.ParseStructuredReference(text2, (global::NPOI.SS.Formula.IFormulaParsingWorkbook)ec.GetWorkbook(), ec.RowIndex);
				}
				catch (global::NPOI.SS.Formula.FormulaParseException)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
				}
				return ec.GetArea3DEval(aptg);
			}
			int num2 = text2.IndexOf(':');
			string refStrPart;
			string refStrPart2;
			if (num2 < 0)
			{
				refStrPart = text2.Trim();
				refStrPart2 = null;
			}
			else
			{
				refStrPart = text2.Substring(0, num2).Trim();
				refStrPart2 = text2.Substring(num2 + 1).Trim();
			}
			return ec.GetDynamicReference(workbookName, sheetName, refStrPart, refStrPart2, isA1style);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		private static string[] ParseWorkbookAndSheetName(string text)
		{
			int num = text.Length - 1;
			if (num < 0)
			{
				return null;
			}
			if (global::NPOI.SS.Formula.Functions.Indirect.CanTrim(text))
			{
				return null;
			}
			char c = text[0];
			if (char.IsWhiteSpace(c))
			{
				return null;
			}
			if (c == '\'')
			{
				if (text[num] != '\'')
				{
					return null;
				}
				c = text[1];
				if (char.IsWhiteSpace(c))
				{
					return null;
				}
				string text2;
				int num3;
				if (c == '[')
				{
					int num2 = text.ToString().LastIndexOf(']');
					if (num2 < 0)
					{
						return null;
					}
					text2 = global::NPOI.SS.Formula.Functions.Indirect.UnescapeString(text.Substring(2, num2 - 2));
					if (text2 == null || global::NPOI.SS.Formula.Functions.Indirect.CanTrim(text2))
					{
						return null;
					}
					num3 = num2 + 1;
				}
				else
				{
					text2 = null;
					num3 = 1;
				}
				string text3 = global::NPOI.SS.Formula.Functions.Indirect.UnescapeString(text.Substring(num3, num - num3));
				if (text3 == null)
				{
					return null;
				}
				return new string[]
				{
					text2,
					text3
				};
			}
			else
			{
				if (c != '[')
				{
					return new string[]
					{
						null,
						text.ToString()
					};
				}
				int num4 = text.ToString().LastIndexOf(']');
				if (num4 < 0)
				{
					return null;
				}
				string text4 = text.Substring(1, num4 - 1);
				if (global::NPOI.SS.Formula.Functions.Indirect.CanTrim(text4))
				{
					return null;
				}
				string text5 = text.Substring(num4 + 1);
				if (global::NPOI.SS.Formula.Functions.Indirect.CanTrim(text5))
				{
					return null;
				}
				return new string[]
				{
					text4.ToString(),
					text5.ToString()
				};
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001EF24 File Offset: 0x0001D124
		private static string UnescapeString(string text)
		{
			int length = text.Length;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length);
			for (int i = 0; i < length; i++)
			{
				char c = text[i];
				if (c == '\'')
				{
					i++;
					if (i >= length)
					{
						return null;
					}
					c = text[i];
					if (c != '\'')
					{
						return null;
					}
				}
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001EF80 File Offset: 0x0001D180
		private static bool CanTrim(string text)
		{
			int num = text.Length - 1;
			return num >= 0 && (char.IsWhiteSpace(text[0]) || char.IsWhiteSpace(text[num]));
		}

		// Token: 0x04000568 RID: 1384
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Indirect();
	}
}
