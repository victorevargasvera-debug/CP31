using System;
using NPOI.SS.Formula.Functions;
using NPOI.SS.Util;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200021E RID: 542
	public abstract class RelationalOperationEval : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x00025634 File Offset: 0x00023834
		private static int DoCompare(global::NPOI.SS.Formula.Eval.ValueEval va, global::NPOI.SS.Formula.Eval.ValueEval vb)
		{
			if (va == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return global::NPOI.SS.Formula.Eval.RelationalOperationEval.CompareBlank(vb);
			}
			if (vb == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return -global::NPOI.SS.Formula.Eval.RelationalOperationEval.CompareBlank(va);
			}
			if (va is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				if (!(vb is global::NPOI.SS.Formula.Eval.BoolEval))
				{
					return 1;
				}
				global::NPOI.SS.Formula.Eval.BoolEval boolEval = (global::NPOI.SS.Formula.Eval.BoolEval)va;
				global::NPOI.SS.Formula.Eval.BoolEval boolEval2 = (global::NPOI.SS.Formula.Eval.BoolEval)vb;
				if (boolEval.BooleanValue == boolEval2.BooleanValue)
				{
					return 0;
				}
				if (!boolEval.BooleanValue)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (vb is global::NPOI.SS.Formula.Eval.BoolEval)
				{
					return -1;
				}
				if (va is global::NPOI.SS.Formula.Eval.StringEval)
				{
					if (vb is global::NPOI.SS.Formula.Eval.StringEval)
					{
						global::NPOI.SS.Formula.Eval.StringEval stringEval = (global::NPOI.SS.Formula.Eval.StringEval)va;
						global::NPOI.SS.Formula.Eval.StringEval stringEval2 = (global::NPOI.SS.Formula.Eval.StringEval)vb;
						return string.Compare(stringEval.StringValue, stringEval2.StringValue, global::System.StringComparison.OrdinalIgnoreCase);
					}
					return 1;
				}
				else
				{
					if (vb is global::NPOI.SS.Formula.Eval.StringEval)
					{
						return -1;
					}
					if (!(va is global::NPOI.SS.Formula.Eval.NumberEval) || !(vb is global::NPOI.SS.Formula.Eval.NumberEval))
					{
						throw new global::System.ArgumentException(string.Concat(new string[]
						{
							"Bad operand types (",
							va.GetType().Name,
							"), (",
							vb.GetType().Name,
							")"
						}));
					}
					global::NPOI.SS.Formula.Eval.NumberEval numberEval = (global::NPOI.SS.Formula.Eval.NumberEval)va;
					global::NPOI.SS.Formula.Eval.NumberEval numberEval2 = (global::NPOI.SS.Formula.Eval.NumberEval)vb;
					if (numberEval.NumberValue == numberEval2.NumberValue)
					{
						return 0;
					}
					return global::NPOI.SS.Util.NumberComparer.Compare(numberEval.NumberValue, numberEval2.NumberValue);
				}
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00025768 File Offset: 0x00023968
		private static int CompareBlank(global::NPOI.SS.Formula.Eval.ValueEval v)
		{
			if (v == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return 0;
			}
			if (v is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				if (!((global::NPOI.SS.Formula.Eval.BoolEval)v).BooleanValue)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (v is global::NPOI.SS.Formula.Eval.NumberEval)
				{
					global::NPOI.SS.Formula.Eval.NumberEval numberEval = (global::NPOI.SS.Formula.Eval.NumberEval)v;
					return global::NPOI.SS.Util.NumberComparer.Compare(0.0, numberEval.NumberValue);
				}
				if (!(v is global::NPOI.SS.Formula.Eval.StringEval))
				{
					throw new global::System.ArgumentException("bad value class (" + v.GetType().Name + ")");
				}
				if (((global::NPOI.SS.Formula.Eval.StringEval)v).StringValue.Length >= 1)
				{
					return -1;
				}
				return 0;
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000257FC File Offset: 0x000239FC
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			global::NPOI.SS.Formula.Eval.ValueEval singleValue2;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex);
				singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg1, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			int cmpResult = global::NPOI.SS.Formula.Eval.RelationalOperationEval.DoCompare(singleValue, singleValue2);
			return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(this.ConvertComparisonResult(cmpResult));
		}

		// Token: 0x06000D64 RID: 3428
		public abstract bool ConvertComparisonResult(int cmpResult);

		// Token: 0x04000602 RID: 1538
		public static global::NPOI.SS.Formula.Functions.Function EqualEval = new global::NPOI.SS.Formula.Eval.EqualEval();

		// Token: 0x04000603 RID: 1539
		public static global::NPOI.SS.Formula.Functions.Function NotEqualEval = new global::NPOI.SS.Formula.Eval.NotEqualEval();

		// Token: 0x04000604 RID: 1540
		public static global::NPOI.SS.Formula.Functions.Function LessEqualEval = new global::NPOI.SS.Formula.Eval.LessEqualEval();

		// Token: 0x04000605 RID: 1541
		public static global::NPOI.SS.Formula.Functions.Function LessThanEval = new global::NPOI.SS.Formula.Eval.LessThanEval();

		// Token: 0x04000606 RID: 1542
		public static global::NPOI.SS.Formula.Functions.Function GreaterEqualEval = new global::NPOI.SS.Formula.Eval.GreaterEqualEval();

		// Token: 0x04000607 RID: 1543
		public static global::NPOI.SS.Formula.Functions.Function GreaterThanEval = new global::NPOI.SS.Formula.Eval.GreaterThanEval();
	}
}
