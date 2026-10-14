using System;
using System.Collections.Generic;
using System.Linq;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001AF RID: 431
	public class Match : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000BB1 RID: 2993 RVA: 0x0001FA20 File Offset: 0x0001DC20
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			double num = 1.0;
			int num2 = args.Length;
			if (num2 != 2)
			{
				if (num2 == 3)
				{
					try
					{
						num = global::NPOI.SS.Formula.Functions.Match.EvaluateMatchTypeArg(args[2], srcCellRow, srcCellCol);
						goto IL_34;
					}
					catch (global::NPOI.SS.Formula.Eval.EvaluationException)
					{
						return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
					}
				}
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			IL_34:
			bool matchExact = num == 0.0;
			bool findLargestLessThanOrEqual = num > 0.0;
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], srcCellRow, srcCellCol);
				global::NPOI.SS.Formula.Functions.ValueVector lookupRange = global::NPOI.SS.Formula.Functions.Match.EvaluateLookupRange(args[1]);
				result = new global::NPOI.SS.Formula.Eval.NumberEval((double)(global::NPOI.SS.Formula.Functions.Match.FindIndexOfValue(singleValue, lookupRange, matchExact, findLargestLessThanOrEqual) + 1));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0001FACC File Offset: 0x0001DCCC
		private static global::NPOI.SS.Formula.Functions.ValueVector EvaluateLookupRange(global::NPOI.SS.Formula.Eval.ValueEval eval)
		{
			if (eval is global::NPOI.SS.Formula.Eval.RefEval)
			{
				global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)eval;
				if (refEval.NumberOfSheets == 1)
				{
					return new global::NPOI.SS.Formula.Functions.SingleValueVector(refEval.GetInnerValueEval(refEval.FirstSheetIndex));
				}
				return global::NPOI.SS.Formula.Functions.LookupUtils.CreateVector(refEval);
			}
			else if (eval is global::NPOI.SS.Formula.TwoDEval)
			{
				global::NPOI.SS.Formula.Functions.ValueVector valueVector = global::NPOI.SS.Formula.Functions.LookupUtils.CreateVector((global::NPOI.SS.Formula.TwoDEval)eval);
				if (valueVector == null)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
				}
				return valueVector;
			}
			else
			{
				if (eval is global::NPOI.SS.Formula.Eval.NumericValueEval)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
				}
				if (!(eval is global::NPOI.SS.Formula.Eval.StringEval))
				{
					throw new global::System.Exception("Unexpected eval type (" + eval.GetType().Name + ")");
				}
				if (double.IsNaN(global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(((global::NPOI.SS.Formula.Eval.StringEval)eval).StringValue)))
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0001FB94 File Offset: 0x0001DD94
		private static double EvaluateMatchTypeArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol);
			if (singleValue is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)singleValue);
			}
			if (singleValue is global::NPOI.SS.Formula.Eval.NumericValueEval)
			{
				return ((global::NPOI.SS.Formula.Eval.NumericValueEval)singleValue).NumberValue;
			}
			if (singleValue is global::NPOI.SS.Formula.Eval.StringEval)
			{
				double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(((global::NPOI.SS.Formula.Eval.StringEval)singleValue).StringValue);
				if (double.IsNaN(num))
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				return num;
			}
			else
			{
				if (singleValue is global::NPOI.SS.Formula.Eval.MissingArgEval)
				{
					return 1.0;
				}
				throw new global::System.Exception("Unexpected match_type type (" + singleValue.GetType().Name + ")");
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0001FC30 File Offset: 0x0001DE30
		private static int FindIndexOfValue(global::NPOI.SS.Formula.Eval.ValueEval lookupValue, global::NPOI.SS.Formula.Functions.ValueVector lookupRange, bool matchExact, bool FindLargestLessThanOrEqual)
		{
			global::NPOI.SS.Formula.Functions.LookupValueComparer lookupValueComparer = global::NPOI.SS.Formula.Functions.Match.CreateLookupComparer(lookupValue, matchExact);
			int size = lookupRange.Size;
			if (matchExact)
			{
				for (int i = 0; i < size; i++)
				{
					if (lookupValueComparer.CompareTo(lookupRange.GetItem(i)).IsEqual)
					{
						return i;
					}
				}
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
			}
			if (!FindLargestLessThanOrEqual)
			{
				int j = 0;
				while (j < size)
				{
					global::NPOI.SS.Formula.Functions.CompareResult compareResult = lookupValueComparer.CompareTo(lookupRange.GetItem(j));
					if (compareResult.IsEqual)
					{
						return j;
					}
					if (compareResult.IsGreaterThan)
					{
						if (j < 1)
						{
							throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
						}
						return j - 1;
					}
					else
					{
						j++;
					}
				}
				return size - 1;
			}
			global::NPOI.SS.Formula.Eval.NumericValueEval numericValueEval = lookupValue as global::NPOI.SS.Formula.Eval.NumericValueEval;
			if (numericValueEval != null)
			{
				global::System.Collections.Generic.Dictionary<int, double> dictionary = new global::System.Collections.Generic.Dictionary<int, double>();
				for (int k = 0; k < size; k++)
				{
					global::NPOI.SS.Formula.Eval.NumericValueEval numericValueEval2 = lookupRange.GetItem(k) as global::NPOI.SS.Formula.Eval.NumericValueEval;
					if (lookupValueComparer.CompareTo(numericValueEval2).IsEqual)
					{
						return k;
					}
					dictionary.Add(k, numericValueEval2.NumberValue - numericValueEval.NumberValue);
				}
				return (from kv in dictionary
				where kv.Value < 0.0
				orderby kv.Value descending
				select kv).First<global::System.Collections.Generic.KeyValuePair<int, double>>().Key;
			}
			for (int l = size - 1; l >= 0; l--)
			{
				global::NPOI.SS.Formula.Functions.CompareResult compareResult2 = lookupValueComparer.CompareTo(lookupRange.GetItem(l));
				if (!compareResult2.IsTypeMismatch && !compareResult2.IsLessThan)
				{
					return l;
				}
			}
			throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0001FDC6 File Offset: 0x0001DFC6
		private static global::NPOI.SS.Formula.Functions.LookupValueComparer CreateLookupComparer(global::NPOI.SS.Formula.Eval.ValueEval lookupValue, bool matchExact)
		{
			return global::NPOI.SS.Formula.Functions.LookupUtils.CreateLookupComparer(lookupValue, matchExact, true);
		}
	}
}
