using System;
using System.Globalization;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000212 RID: 530
	public class OperandResolver
	{
		// Token: 0x06000D32 RID: 3378 RVA: 0x0000253E File Offset: 0x0000073E
		private OperandResolver()
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00025084 File Offset: 0x00023284
		public static global::NPOI.SS.Formula.Eval.ValueEval GetSingleValue(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval valueEval;
			if (arg is global::NPOI.SS.Formula.Eval.RefEval)
			{
				valueEval = global::NPOI.SS.Formula.Eval.OperandResolver.ChooseSingleElementFromRef((global::NPOI.SS.Formula.Eval.RefEval)arg);
			}
			else if (arg is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				valueEval = global::NPOI.SS.Formula.Eval.OperandResolver.ChooseSingleElementFromArea((global::NPOI.SS.Formula.Eval.AreaEval)arg, srcCellRow, srcCellCol);
			}
			else
			{
				valueEval = arg;
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)valueEval);
			}
			return valueEval;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000250D8 File Offset: 0x000232D8
		public static global::NPOI.SS.Formula.Eval.ValueEval ChooseSingleElementFromArea(global::NPOI.SS.Formula.Eval.AreaEval ae, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval valueEval = global::NPOI.SS.Formula.Eval.OperandResolver.ChooseSingleElementFromAreaInternal(ae, srcCellRow, srcCellCol);
			if (valueEval is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)valueEval);
			}
			return valueEval;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00025104 File Offset: 0x00023304
		private static global::NPOI.SS.Formula.Eval.ValueEval ChooseSingleElementFromAreaInternal(global::NPOI.SS.Formula.Eval.AreaEval ae, int srcCellRow, int srcCellCol)
		{
			if (ae.IsColumn)
			{
				if (ae.IsRow)
				{
					return ae.GetRelativeValue(0, 0);
				}
				if (!ae.ContainsRow(srcCellRow))
				{
					throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
				}
				return ae.GetAbsoluteValue(srcCellRow, ae.FirstColumn);
			}
			else if (!ae.IsRow)
			{
				if (ae.ContainsRow(srcCellRow) && ae.ContainsColumn(srcCellCol))
				{
					return ae.GetAbsoluteValue(ae.FirstRow, ae.FirstColumn);
				}
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
			}
			else
			{
				if (!ae.ContainsColumn(srcCellCol))
				{
					throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
				}
				return ae.GetAbsoluteValue(ae.FirstRow, srcCellCol);
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00025196 File Offset: 0x00023396
		private static global::NPOI.SS.Formula.Eval.ValueEval ChooseSingleElementFromRef(global::NPOI.SS.Formula.Eval.RefEval ref1)
		{
			return ref1.GetInnerValueEval(ref1.FirstSheetIndex);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000251A4 File Offset: 0x000233A4
		public static int CoerceValueToInt(global::NPOI.SS.Formula.Eval.ValueEval ev)
		{
			if (ev == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return 0;
			}
			return (int)global::System.Math.Floor(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(ev));
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000251BC File Offset: 0x000233BC
		public static double CoerceValueToDouble(global::NPOI.SS.Formula.Eval.ValueEval ev)
		{
			if (ev == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return 0.0;
			}
			if (ev is global::NPOI.SS.Formula.Eval.NumericValueEval)
			{
				return ((global::NPOI.SS.Formula.Eval.NumericValueEval)ev).NumberValue;
			}
			if (!(ev is global::NPOI.SS.Formula.Eval.StringEval))
			{
				throw new global::System.Exception("Unexpected arg eval type (" + ev.GetType().Name + ")");
			}
			double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(((global::NPOI.SS.Formula.Eval.StringEval)ev).StringValue);
			if (double.IsNaN(num))
			{
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
			}
			return num;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00025238 File Offset: 0x00023438
		public static double ParseDouble(string pText)
		{
			double result;
			try
			{
				double num = double.Parse(pText, global::System.Globalization.CultureInfo.CurrentCulture);
				if (double.IsInfinity(num))
				{
					result = double.NaN;
				}
				else
				{
					result = num;
				}
			}
			catch (global::System.Exception)
			{
				result = double.NaN;
			}
			return result;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00025288 File Offset: 0x00023488
		public static string CoerceValueToString(global::NPOI.SS.Formula.Eval.ValueEval ve)
		{
			if (ve is global::NPOI.SS.Formula.Eval.StringValueEval)
			{
				return ((global::NPOI.SS.Formula.Eval.StringValueEval)ve).StringValue;
			}
			if (ve is global::NPOI.SS.Formula.Eval.BlankEval)
			{
				return "";
			}
			throw new global::System.ArgumentException("Unexpected eval class (" + ve.GetType().Name + ")");
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000252D8 File Offset: 0x000234D8
		public static bool? CoerceValueToBoolean(global::NPOI.SS.Formula.Eval.ValueEval ve, bool stringsAreBlanks)
		{
			if (ve == null || ve == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return null;
			}
			if (ve is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				return new bool?(((global::NPOI.SS.Formula.Eval.BoolEval)ve).BooleanValue);
			}
			if (ve is global::NPOI.SS.Formula.Eval.StringEval)
			{
				if (stringsAreBlanks)
				{
					return null;
				}
				string stringValue = ((global::NPOI.SS.Formula.Eval.StringEval)ve).StringValue;
				if (stringValue.Equals("true", global::System.StringComparison.OrdinalIgnoreCase))
				{
					return new bool?(true);
				}
				if (stringValue.Equals("false", global::System.StringComparison.OrdinalIgnoreCase))
				{
					return new bool?(false);
				}
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			else if (ve is global::NPOI.SS.Formula.Eval.NumericValueEval)
			{
				double numberValue = ((global::NPOI.SS.Formula.Eval.NumericValueEval)ve).NumberValue;
				if (double.IsNaN(numberValue))
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				return new bool?(numberValue != 0.0);
			}
			else
			{
				if (ve is global::NPOI.SS.Formula.Eval.ErrorEval)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)ve);
				}
				throw new global::System.InvalidOperationException("Unexpected eval (" + ve.GetType().Name + ")");
			}
		}

		// Token: 0x040005F9 RID: 1529
		private const string Digits = "\\d+";

		// Token: 0x040005FA RID: 1530
		private const string Exp = "[eE][+-]?\\d+";

		// Token: 0x040005FB RID: 1531
		private const string fpRegex = "[\\x00-\\x20]*[+-]?((((\\d+(\\.)?(\\d+?)([eE][+-]?\\d+)?)|(\\.(\\d+)([eE][+-]?\\d+)?))))[\\x00-\\x20]*";
	}
}
