using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000132 RID: 306
	public class Bin2Dec : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A05 RID: 2565 RVA: 0x00019DF4 File Offset: 0x00017FF4
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval numberVE)
		{
			string text;
			if (numberVE is global::NPOI.SS.Formula.Eval.RefEval)
			{
				global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)numberVE;
				text = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(refEval.GetInnerValueEval(refEval.FirstSheetIndex));
			}
			else
			{
				text = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(numberVE);
			}
			if (text.Length > 10)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			string text2;
			bool flag;
			if (text.Length < 10)
			{
				text2 = text;
				flag = true;
			}
			else
			{
				text2 = text.Substring(1);
				flag = text.StartsWith("0");
			}
			string s;
			try
			{
				if (flag)
				{
					s = this.getDecimalValue(text2).ToString();
				}
				else
				{
					string unsigned = global::NPOI.SS.Formula.Functions.Bin2Dec.toggleBits(text2);
					int decimalValue = this.getDecimalValue(unsigned);
					s = "-" + (decimalValue + 1).ToString();
				}
			}
			catch (global::System.FormatException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)long.Parse(s));
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00019ECC File Offset: 0x000180CC
		private int getDecimalValue(string unsigned)
		{
			int num = 0;
			int length = unsigned.Length;
			int num2 = length - 1;
			for (int i = 0; i < length; i++)
			{
				int num3 = (int)((double)int.Parse(unsigned.Substring(i, 1)) * global::System.Math.Pow(2.0, (double)num2));
				num += num3;
				num2--;
			}
			return num;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00019F20 File Offset: 0x00018120
		private static string toggleBits(string s)
		{
			string text = global::System.Convert.ToString(global::System.Convert.ToInt64(s, 2) ^ (1L << s.Length) - 1L, 2);
			while (text.Length < s.Length)
			{
				text = "0" + text;
			}
			return text;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00019F68 File Offset: 0x00018168
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0]);
		}

		// Token: 0x04000503 RID: 1283
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Bin2Dec();
	}
}
