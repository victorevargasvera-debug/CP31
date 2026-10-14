using System;
using System.Globalization;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200016D RID: 365
	public abstract class BooleanFunction : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000AD2 RID: 2770
		protected abstract bool InitialResultValue { get; }

		// Token: 0x06000AD3 RID: 2771
		protected abstract bool PartialEvaluate(bool cumulativeResult, bool currentValue);

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0001D2DC File Offset: 0x0001B4DC
		private bool Calculate(global::NPOI.SS.Formula.Eval.ValueEval[] args)
		{
			bool flag = this.InitialResultValue;
			bool flag2 = false;
			foreach (global::NPOI.SS.Formula.Eval.ValueEval valueEval in args)
			{
				if (valueEval is global::NPOI.SS.Formula.TwoDEval)
				{
					global::NPOI.SS.Formula.TwoDEval twoDEval = (global::NPOI.SS.Formula.TwoDEval)valueEval;
					int height = twoDEval.Height;
					int width = twoDEval.Width;
					for (int j = 0; j < height; j++)
					{
						for (int k = 0; k < width; k++)
						{
							bool? flag3 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(twoDEval.GetValue(j, k), true);
							if (flag3 != null)
							{
								flag = this.PartialEvaluate(flag, global::System.Convert.ToBoolean(flag3, global::System.Globalization.CultureInfo.InvariantCulture));
								flag2 = true;
							}
						}
					}
				}
				else if (valueEval is global::NPOI.SS.Formula.Eval.RefEval)
				{
					global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)valueEval;
					int firstSheetIndex = refEval.FirstSheetIndex;
					int lastSheetIndex = refEval.LastSheetIndex;
					for (int l = firstSheetIndex; l <= lastSheetIndex; l++)
					{
						bool? flag3 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(refEval.GetInnerValueEval(l), true);
						if (flag3 != null)
						{
							flag = this.PartialEvaluate(flag, flag3.Value);
							flag2 = true;
						}
					}
				}
				else
				{
					bool? flag3;
					if (valueEval == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
					{
						flag3 = null;
					}
					else
					{
						flag3 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(valueEval, false);
					}
					if (flag3 != null)
					{
						flag = this.PartialEvaluate(flag, global::System.Convert.ToBoolean(flag3, global::System.Globalization.CultureInfo.InvariantCulture));
						flag2 = true;
					}
				}
			}
			if (!flag2)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			return flag;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0001D444 File Offset: 0x0001B644
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRow, int srcCol)
		{
			if (args.Length < 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			bool b;
			try
			{
				b = this.Calculate(args);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(b);
		}
	}
}
