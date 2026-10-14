using System;
using System.Collections.Generic;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x0200022E RID: 558
	internal class ArgumentsEvaluator
	{
		// Token: 0x06000DB1 RID: 3505 RVA: 0x0000253E File Offset: 0x0000073E
		private ArgumentsEvaluator()
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000262F8 File Offset: 0x000244F8
		public double EvaluateDateArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, (int)((short)srcCellCol));
			if (!(singleValue is global::NPOI.SS.Formula.Eval.StringEval))
			{
				return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue);
			}
			string stringValue = ((global::NPOI.SS.Formula.Eval.StringEval)singleValue).StringValue;
			double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(stringValue);
			if (!double.IsNaN(num))
			{
				return num;
			}
			return global::NPOI.SS.UserModel.DateUtil.GetExcelDate(global::NPOI.SS.Formula.Atp.DateParser.ParseDate(stringValue), false);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00026348 File Offset: 0x00024548
		public double[] EvaluateDatesArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			if (arg == null)
			{
				return new double[0];
			}
			if (arg is global::NPOI.SS.Formula.Eval.StringEval)
			{
				return new double[]
				{
					this.EvaluateDateArg(arg, srcCellRow, srcCellCol)
				};
			}
			if (arg is global::NPOI.SS.Formula.Eval.AreaEvalBase)
			{
				global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
				global::NPOI.SS.Formula.Eval.AreaEvalBase areaEvalBase = (global::NPOI.SS.Formula.Eval.AreaEvalBase)arg;
				for (int i = areaEvalBase.FirstRow; i <= areaEvalBase.LastRow; i++)
				{
					for (int j = areaEvalBase.FirstColumn; j <= areaEvalBase.LastColumn; j++)
					{
						list.Add(this.EvaluateDateArg(areaEvalBase.GetAbsoluteValue(i, j), i, j));
					}
				}
				double[] array = new double[list.Count];
				for (int k = 0; k < list.Count; k++)
				{
					array[k] = list[k];
				}
				return array;
			}
			return new double[]
			{
				global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(arg)
			};
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00026418 File Offset: 0x00024618
		public double EvaluateNumberArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			if (arg == null)
			{
				return 0.0;
			}
			return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(arg);
		}

		// Token: 0x0400061E RID: 1566
		public static global::NPOI.SS.Formula.Atp.ArgumentsEvaluator instance = new global::NPOI.SS.Formula.Atp.ArgumentsEvaluator();
	}
}
