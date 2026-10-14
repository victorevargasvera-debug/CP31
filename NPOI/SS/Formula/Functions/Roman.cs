using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000150 RID: 336
	public class Roman : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval numberVE, global::NPOI.SS.Formula.Eval.ValueEval formVE)
		{
			int num = 0;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(numberVE, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num < 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num > 3999)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num == 0)
			{
				return new global::NPOI.SS.Formula.Eval.StringEval("");
			}
			int num2 = 0;
			try
			{
				num2 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(formVE, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			if (num2 > 4 || num2 < 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string text = this.integerToRoman(num);
			if (num2 == 0)
			{
				return new global::NPOI.SS.Formula.Eval.StringEval(text);
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(this.MakeConcise(text, num2));
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001C468 File Offset: 0x0001A668
		private string integerToRoman(int number)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < 13; i++)
			{
				while (number >= global::NPOI.SS.Formula.Functions.Roman.VALUES[i])
				{
					number -= global::NPOI.SS.Formula.Functions.Roman.VALUES[i];
					stringBuilder.Append(global::NPOI.SS.Formula.Functions.Roman.ROMAN[i]);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001C4B4 File Offset: 0x0001A6B4
		public string MakeConcise(string result, int form)
		{
			if (form > 0)
			{
				result = result.Replace("XLV", "VL");
				result = result.Replace("XCV", "VC");
				result = result.Replace("CDL", "LD");
				result = result.Replace("CML", "LM");
				result = result.Replace("CMVC", "LMVL");
			}
			if (form == 1)
			{
				result = result.Replace("CDXC", "LDXL");
				result = result.Replace("CDVC", "LDVL");
				result = result.Replace("CMXC", "LMXL");
				result = result.Replace("XCIX", "VCIV");
				result = result.Replace("XLIX", "VLIV");
			}
			if (form > 1)
			{
				result = result.Replace("XLIX", "IL");
				result = result.Replace("XCIX", "IC");
				result = result.Replace("CDXC", "XD");
				result = result.Replace("CDVC", "XDV");
				result = result.Replace("CDIC", "XDIX");
				result = result.Replace("LMVL", "XMV");
				result = result.Replace("CMIC", "XMIX");
				result = result.Replace("CMXC", "XM");
			}
			if (form > 2)
			{
				result = result.Replace("XDV", "VD");
				result = result.Replace("XDIX", "VDIV");
				result = result.Replace("XMV", "VM");
				result = result.Replace("XMIX", "VMIV");
			}
			if (form == 4)
			{
				result = result.Replace("VDIV", "ID");
				result = result.Replace("VMIV", "IM");
			}
			return result;
		}

		// Token: 0x0400052E RID: 1326
		public static int[] VALUES = new int[]
		{
			1000,
			900,
			500,
			400,
			100,
			90,
			50,
			40,
			10,
			9,
			5,
			4,
			1
		};

		// Token: 0x0400052F RID: 1327
		public static string[] ROMAN = new string[]
		{
			"M",
			"CM",
			"D",
			"CD",
			"C",
			"XC",
			"L",
			"XL",
			"X",
			"IX",
			"V",
			"IV",
			"I"
		};
	}
}
