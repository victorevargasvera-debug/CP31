using System;
using System.Collections.Generic;
using System.Text;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000237 RID: 567
	public class TextJoinFunction : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DCF RID: 3535 RVA: 0x00026A98 File Offset: 0x00024C98
		private TextJoinFunction(global::NPOI.SS.Formula.Atp.ArgumentsEvaluator anEvaluator)
		{
			this.evaluator = anEvaluator;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00026AA8 File Offset: 0x00024CA8
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length < 3 || args.Length > 254)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			int rowIndex = ec.RowIndex;
			int columnIndex = ec.ColumnIndex;
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::System.Collections.Generic.List<global::NPOI.SS.Formula.Eval.ValueEval> values = this.GetValues(args[0], rowIndex, columnIndex, true);
				bool value = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[1], rowIndex, columnIndex), false).Value;
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				for (int i = 2; i < args.Length; i++)
				{
					foreach (global::NPOI.SS.Formula.Eval.ValueEval ve in this.GetValues(args[i], rowIndex, columnIndex, false))
					{
						string text = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(ve);
						if (!value || (text != null && text.Length > 0))
						{
							list.Add(text);
						}
					}
				}
				if (values.Count == 0)
				{
					result = new global::NPOI.SS.Formula.Eval.StringEval(string.Join("", list));
				}
				else if (values.Count == 1)
				{
					result = new global::NPOI.SS.Formula.Eval.StringEval(string.Join(this.LaxValueToString(values[0]), list));
				}
				else
				{
					global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
					foreach (global::NPOI.SS.Formula.Eval.ValueEval eval in values)
					{
						list2.Add(this.LaxValueToString(eval));
					}
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					for (int j = 0; j < list.Count; j++)
					{
						if (j > 0)
						{
							int index = (j - 1) % list2.Count;
							stringBuilder.Append(list2[index]);
						}
						stringBuilder.Append(list[j]);
					}
					result = new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00026CB4 File Offset: 0x00024EB4
		private string LaxValueToString(global::NPOI.SS.Formula.Eval.ValueEval eval)
		{
			if (!(eval is global::NPOI.SS.Formula.Eval.MissingArgEval))
			{
				return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(eval);
			}
			return "";
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00026CCC File Offset: 0x00024ECC
		private global::System.Collections.Generic.List<global::NPOI.SS.Formula.Eval.ValueEval> GetValues(global::NPOI.SS.Formula.Eval.ValueEval eval, int srcRowIndex, int srcColumnIndex, bool lastRowOnly)
		{
			if (eval is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				global::NPOI.SS.Formula.Eval.AreaEval areaEval = (global::NPOI.SS.Formula.Eval.AreaEval)eval;
				global::System.Collections.Generic.List<global::NPOI.SS.Formula.Eval.ValueEval> list = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.Eval.ValueEval>();
				for (int i = lastRowOnly ? areaEval.LastRow : areaEval.FirstRow; i <= areaEval.LastRow; i++)
				{
					for (int j = areaEval.FirstColumn; j <= areaEval.LastColumn; j++)
					{
						list.Add(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(areaEval.GetAbsoluteValue(i, j), i, j));
					}
				}
				return list;
			}
			return new global::System.Collections.Generic.List<global::NPOI.SS.Formula.Eval.ValueEval>
			{
				global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(eval, srcRowIndex, srcColumnIndex)
			};
		}

		// Token: 0x04000627 RID: 1575
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Atp.TextJoinFunction(global::NPOI.SS.Formula.Atp.ArgumentsEvaluator.instance);

		// Token: 0x04000628 RID: 1576
		private global::NPOI.SS.Formula.Atp.ArgumentsEvaluator evaluator;
	}
}
