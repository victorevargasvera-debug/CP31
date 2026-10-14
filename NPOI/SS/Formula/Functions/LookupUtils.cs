using System;
using System.Globalization;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A7 RID: 423
	internal class LookupUtils
	{
		// Token: 0x06000B86 RID: 2950 RVA: 0x0001F33B File Offset: 0x0001D53B
		public static global::NPOI.SS.Formula.Functions.ValueVector CreateRowVector(global::NPOI.SS.Formula.TwoDEval tableArray, int relativeRowIndex)
		{
			return new global::NPOI.SS.Formula.Functions.LookupUtils.RowVector((global::NPOI.SS.Formula.Eval.AreaEval)tableArray, relativeRowIndex);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0001F349 File Offset: 0x0001D549
		public static global::NPOI.SS.Formula.Functions.ValueVector CreateColumnVector(global::NPOI.SS.Formula.TwoDEval tableArray, int relativeColumnIndex)
		{
			return new global::NPOI.SS.Formula.Functions.LookupUtils.ColumnVector((global::NPOI.SS.Formula.Eval.AreaEval)tableArray, relativeColumnIndex);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0001F357 File Offset: 0x0001D557
		public static global::NPOI.SS.Formula.Functions.ValueVector CreateVector(global::NPOI.SS.Formula.TwoDEval ae)
		{
			if (ae.IsColumn)
			{
				return global::NPOI.SS.Formula.Functions.LookupUtils.CreateColumnVector(ae, 0);
			}
			if (ae.IsRow)
			{
				return global::NPOI.SS.Formula.Functions.LookupUtils.CreateRowVector(ae, 0);
			}
			return null;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0001F37A File Offset: 0x0001D57A
		public static global::NPOI.SS.Formula.Functions.ValueVector CreateVector(global::NPOI.SS.Formula.Eval.RefEval re)
		{
			return new global::NPOI.SS.Formula.Functions.LookupUtils.SheetVector(re);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0001F384 File Offset: 0x0001D584
		public static int ResolveRowOrColIndexArg(global::NPOI.SS.Formula.Eval.ValueEval rowColIndexArg, int srcCellRow, int srcCellCol)
		{
			if (rowColIndexArg == null)
			{
				throw new global::System.ArgumentException("argument must not be null");
			}
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(rowColIndexArg, srcCellRow, (int)((short)srcCellCol));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidRef();
			}
			if (singleValue is global::NPOI.SS.Formula.Eval.StringEval && double.IsNaN(global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(((global::NPOI.SS.Formula.Eval.StringEval)singleValue).StringValue)))
			{
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidRef();
			}
			int num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(singleValue);
			if (num < 1)
			{
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
			}
			return num - 1;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0001F3FC File Offset: 0x0001D5FC
		public static global::NPOI.SS.Formula.Eval.AreaEval ResolveTableArrayArg(global::NPOI.SS.Formula.Eval.ValueEval eval)
		{
			if (eval is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				return (global::NPOI.SS.Formula.Eval.AreaEval)eval;
			}
			if (eval is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return ((global::NPOI.SS.Formula.Eval.RefEval)eval).Offset(0, 0, 0, 0);
			}
			throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0001F42C File Offset: 0x0001D62C
		public static bool ResolveRangeLookupArg(global::NPOI.SS.Formula.Eval.ValueEval rangeLookupArg, int srcCellRow, int srcCellCol)
		{
			if (rangeLookupArg == null)
			{
				return true;
			}
			global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(rangeLookupArg, srcCellRow, srcCellCol);
			if (singleValue is global::NPOI.SS.Formula.Eval.BlankEval)
			{
				return false;
			}
			if (singleValue is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				return ((global::NPOI.SS.Formula.Eval.BoolEval)singleValue).BooleanValue;
			}
			if (singleValue is global::NPOI.SS.Formula.Eval.StringEval)
			{
				string stringValue = ((global::NPOI.SS.Formula.Eval.StringEval)singleValue).StringValue;
				if (stringValue.Length < 1)
				{
					throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
				}
				bool? flag = global::NPOI.SS.Formula.Functions.Countif.ParseBoolean(stringValue);
				if (flag != null)
				{
					bool? flag2 = flag;
					bool flag3 = true;
					return flag2.GetValueOrDefault() == flag3 & flag2 != null;
				}
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
			}
			else
			{
				if (singleValue is global::NPOI.SS.Formula.Eval.NumericValueEval)
				{
					global::NPOI.SS.Formula.Eval.NumericValueEval numericValueEval = (global::NPOI.SS.Formula.Eval.NumericValueEval)singleValue;
					return 0.0 != numericValueEval.NumberValue;
				}
				throw new global::System.Exception("Unexpected eval type (" + singleValue.GetType().Name + ")");
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0001F500 File Offset: 0x0001D700
		public static int LookupIndexOfValue(global::NPOI.SS.Formula.Eval.ValueEval lookupValue, global::NPOI.SS.Formula.Functions.ValueVector vector, bool isRangeLookup)
		{
			global::NPOI.SS.Formula.Functions.LookupValueComparer lookupComparer = global::NPOI.SS.Formula.Functions.LookupUtils.CreateLookupComparer(lookupValue, isRangeLookup, false);
			int num;
			if (isRangeLookup)
			{
				num = global::NPOI.SS.Formula.Functions.LookupUtils.PerformBinarySearch(vector, lookupComparer);
			}
			else
			{
				num = global::NPOI.SS.Formula.Functions.LookupUtils.LookupIndexOfExactValue(lookupComparer, vector);
			}
			if (num < 0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
			}
			return num;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0001F53C File Offset: 0x0001D73C
		private static int LookupIndexOfExactValue(global::NPOI.SS.Formula.Functions.LookupValueComparer lookupComparer, global::NPOI.SS.Formula.Functions.ValueVector vector)
		{
			int size = vector.Size;
			for (int i = 0; i < size; i++)
			{
				if (lookupComparer.CompareTo(vector.GetItem(i)).IsEqual)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0001F574 File Offset: 0x0001D774
		private static int PerformBinarySearch(global::NPOI.SS.Formula.Functions.ValueVector vector, global::NPOI.SS.Formula.Functions.LookupValueComparer lookupComparer)
		{
			global::NPOI.SS.Formula.Functions.BinarySearchIndexes binarySearchIndexes = new global::NPOI.SS.Formula.Functions.BinarySearchIndexes(vector.Size);
			int num;
			for (;;)
			{
				num = binarySearchIndexes.GetMidIx();
				if (num < 0)
				{
					break;
				}
				global::NPOI.SS.Formula.Functions.CompareResult compareResult = lookupComparer.CompareTo(vector.GetItem(num));
				if (compareResult.IsTypeMismatch)
				{
					int num2 = global::NPOI.SS.Formula.Functions.LookupUtils.HandleMidValueTypeMismatch(lookupComparer, vector, binarySearchIndexes, num);
					if (num2 < 0)
					{
						continue;
					}
					num = num2;
					compareResult = lookupComparer.CompareTo(vector.GetItem(num));
				}
				if (compareResult.IsEqual)
				{
					goto Block_4;
				}
				binarySearchIndexes.NarrowSearch(num, compareResult.IsLessThan);
			}
			return binarySearchIndexes.GetLowIx();
			Block_4:
			return global::NPOI.SS.Formula.Functions.LookupUtils.FindLastIndexInRunOfEqualValues(lookupComparer, vector, num, binarySearchIndexes.GetHighIx());
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0001F5F8 File Offset: 0x0001D7F8
		private static int HandleMidValueTypeMismatch(global::NPOI.SS.Formula.Functions.LookupValueComparer lookupComparer, global::NPOI.SS.Formula.Functions.ValueVector vector, global::NPOI.SS.Formula.Functions.BinarySearchIndexes bsi, int midIx)
		{
			int num = midIx;
			int highIx = bsi.GetHighIx();
			global::NPOI.SS.Formula.Functions.CompareResult compareResult;
			for (;;)
			{
				num++;
				if (num == highIx)
				{
					break;
				}
				compareResult = lookupComparer.CompareTo(vector.GetItem(num));
				if (compareResult.IsLessThan && num == highIx - 1)
				{
					goto Block_3;
				}
				if (!compareResult.IsTypeMismatch)
				{
					goto Block_4;
				}
			}
			bsi.NarrowSearch(midIx, true);
			return -1;
			Block_3:
			bsi.NarrowSearch(midIx, true);
			return -1;
			Block_4:
			if (compareResult.IsEqual)
			{
				return num;
			}
			bsi.NarrowSearch(num, compareResult.IsLessThan);
			return -1;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0001F668 File Offset: 0x0001D868
		private static int FindLastIndexInRunOfEqualValues(global::NPOI.SS.Formula.Functions.LookupValueComparer lookupComparer, global::NPOI.SS.Formula.Functions.ValueVector vector, int firstFoundIndex, int maxIx)
		{
			for (int i = firstFoundIndex + 1; i < maxIx; i++)
			{
				if (!lookupComparer.CompareTo(vector.GetItem(i)).IsEqual)
				{
					return i - 1;
				}
			}
			return maxIx - 1;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0001F6A0 File Offset: 0x0001D8A0
		public static global::NPOI.SS.Formula.Functions.LookupValueComparer CreateLookupComparer(global::NPOI.SS.Formula.Eval.ValueEval lookupValue, bool matchExact, bool isMatchFunction)
		{
			if (lookupValue == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return new global::NPOI.SS.Formula.Functions.LookupUtils.NumberLookupComparer(global::NPOI.SS.Formula.Eval.NumberEval.ZERO);
			}
			if (lookupValue is global::NPOI.SS.Formula.Eval.StringEval)
			{
				return new global::NPOI.SS.Formula.Functions.LookupUtils.StringLookupComparer((global::NPOI.SS.Formula.Eval.StringEval)lookupValue, matchExact, isMatchFunction);
			}
			if (lookupValue is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return new global::NPOI.SS.Formula.Functions.LookupUtils.NumberLookupComparer((global::NPOI.SS.Formula.Eval.NumberEval)lookupValue);
			}
			if (lookupValue is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				return new global::NPOI.SS.Formula.Functions.BooleanLookupComparer((global::NPOI.SS.Formula.Eval.BoolEval)lookupValue);
			}
			throw new global::System.ArgumentException("Bad lookup value type (" + lookupValue.GetType().Name + ")");
		}

		// Token: 0x0200057D RID: 1405
		internal class RowVector : global::NPOI.SS.Formula.Functions.ValueVector
		{
			// Token: 0x0600340B RID: 13323 RVA: 0x000A2394 File Offset: 0x000A0594
			public RowVector(global::NPOI.SS.Formula.Eval.AreaEval tableArray, int rowIndex)
			{
				this._rowIndex = rowIndex;
				int row = tableArray.FirstRow + rowIndex;
				if (!tableArray.ContainsRow(row))
				{
					int num = tableArray.LastRow - tableArray.FirstRow;
					throw new global::System.ArgumentException(string.Concat(new string[]
					{
						"Specified row index (",
						rowIndex.ToString(),
						") is outside the allowed range (0..",
						num.ToString(),
						")"
					}));
				}
				this._tableArray = tableArray;
				this._size = tableArray.Width;
			}

			// Token: 0x0600340C RID: 13324 RVA: 0x000A2420 File Offset: 0x000A0620
			public global::NPOI.SS.Formula.Eval.ValueEval GetItem(int index)
			{
				if (index > this._size)
				{
					throw new global::System.IndexOutOfRangeException(string.Concat(new string[]
					{
						"Specified index (",
						index.ToString(),
						") is outside the allowed range (0..",
						(this._size - 1).ToString(),
						")"
					}));
				}
				return this._tableArray.GetRelativeValue(this._rowIndex, index);
			}

			// Token: 0x17000DA9 RID: 3497
			// (get) Token: 0x0600340D RID: 13325 RVA: 0x000A248E File Offset: 0x000A068E
			public int Size
			{
				get
				{
					return this._size;
				}
			}

			// Token: 0x040018D2 RID: 6354
			private global::NPOI.SS.Formula.Eval.AreaEval _tableArray;

			// Token: 0x040018D3 RID: 6355
			private int _size;

			// Token: 0x040018D4 RID: 6356
			private int _rowIndex;
		}

		// Token: 0x0200057E RID: 1406
		internal class ColumnVector : global::NPOI.SS.Formula.Functions.ValueVector
		{
			// Token: 0x0600340E RID: 13326 RVA: 0x000A2498 File Offset: 0x000A0698
			public ColumnVector(global::NPOI.SS.Formula.Eval.AreaEval tableArray, int columnIndex)
			{
				this._columnIndex = columnIndex;
				int num = tableArray.FirstColumn + columnIndex;
				if (!tableArray.ContainsColumn((int)((short)num)))
				{
					int num2 = tableArray.LastColumn - tableArray.FirstColumn;
					throw new global::System.ArgumentException(string.Concat(new string[]
					{
						"Specified column index (",
						columnIndex.ToString(),
						") is outside the allowed range (0..",
						num2.ToString(),
						")"
					}));
				}
				this._tableArray = tableArray;
				this._size = this._tableArray.Height;
			}

			// Token: 0x0600340F RID: 13327 RVA: 0x000A2528 File Offset: 0x000A0728
			public global::NPOI.SS.Formula.Eval.ValueEval GetItem(int index)
			{
				if (index > this._size)
				{
					throw new global::System.IndexOutOfRangeException(string.Concat(new string[]
					{
						"Specified index (",
						index.ToString(),
						") is outside the allowed range (0..",
						(this._size - 1).ToString(),
						")"
					}));
				}
				return this._tableArray.GetRelativeValue(index, this._columnIndex);
			}

			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x06003410 RID: 13328 RVA: 0x000A2596 File Offset: 0x000A0796
			public int Size
			{
				get
				{
					return this._size;
				}
			}

			// Token: 0x040018D5 RID: 6357
			private global::NPOI.SS.Formula.Eval.AreaEval _tableArray;

			// Token: 0x040018D6 RID: 6358
			private int _size;

			// Token: 0x040018D7 RID: 6359
			private int _columnIndex;
		}

		// Token: 0x0200057F RID: 1407
		private class SheetVector : global::NPOI.SS.Formula.Functions.ValueVector
		{
			// Token: 0x06003411 RID: 13329 RVA: 0x000A259E File Offset: 0x000A079E
			public SheetVector(global::NPOI.SS.Formula.Eval.RefEval re)
			{
				this._size = re.NumberOfSheets;
				this._re = re;
			}

			// Token: 0x06003412 RID: 13330 RVA: 0x000A25BC File Offset: 0x000A07BC
			public global::NPOI.SS.Formula.Eval.ValueEval GetItem(int index)
			{
				if (index >= this._size)
				{
					throw new global::System.IndexOutOfRangeException(string.Concat(new string[]
					{
						"Specified index (",
						index.ToString(),
						") is outside the allowed range (0..",
						(this._size - 1).ToString(),
						")"
					}));
				}
				int sheetIndex = this._re.FirstSheetIndex + index;
				return this._re.GetInnerValueEval(sheetIndex);
			}

			// Token: 0x17000DAB RID: 3499
			// (get) Token: 0x06003413 RID: 13331 RVA: 0x000A2632 File Offset: 0x000A0832
			public int Size
			{
				get
				{
					return this._size;
				}
			}

			// Token: 0x040018D8 RID: 6360
			private global::NPOI.SS.Formula.Eval.RefEval _re;

			// Token: 0x040018D9 RID: 6361
			private int _size;
		}

		// Token: 0x02000580 RID: 1408
		private class StringLookupComparer : global::NPOI.SS.Formula.Functions.LookupValueComparerBase
		{
			// Token: 0x06003414 RID: 13332 RVA: 0x000A263A File Offset: 0x000A083A
			public StringLookupComparer(global::NPOI.SS.Formula.Eval.StringEval se, bool matchExact, bool isMatchFunction) : base(se)
			{
				this._value = se.StringValue;
				this._wildCardPattern = global::NPOI.SS.Formula.Functions.Countif.StringMatcher.GetWildCardPattern(this._value);
				this._matchExact = matchExact;
				this._isMatchFunction = isMatchFunction;
			}

			// Token: 0x06003415 RID: 13333 RVA: 0x000A2670 File Offset: 0x000A0870
			protected override global::NPOI.SS.Formula.Functions.CompareResult CompareSameType(global::NPOI.SS.Formula.Eval.ValueEval other)
			{
				string stringValue = ((global::NPOI.SS.Formula.Eval.StringEval)other).StringValue;
				if (this._wildCardPattern != null)
				{
					bool matches = this._wildCardPattern.Matches(stringValue).Count > 0;
					if (this._isMatchFunction || !this._matchExact)
					{
						return global::NPOI.SS.Formula.Functions.CompareResult.ValueOf(matches);
					}
				}
				return global::NPOI.SS.Formula.Functions.CompareResult.ValueOf(string.Compare(this._value, stringValue, true));
			}

			// Token: 0x06003416 RID: 13334 RVA: 0x000A26CF File Offset: 0x000A08CF
			protected override string GetValueAsString()
			{
				return this._value;
			}

			// Token: 0x040018DA RID: 6362
			private string _value;

			// Token: 0x040018DB RID: 6363
			private global::System.Text.RegularExpressions.Regex _wildCardPattern;

			// Token: 0x040018DC RID: 6364
			private bool _matchExact;

			// Token: 0x040018DD RID: 6365
			private bool _isMatchFunction;
		}

		// Token: 0x02000581 RID: 1409
		private class NumberLookupComparer : global::NPOI.SS.Formula.Functions.LookupValueComparerBase
		{
			// Token: 0x06003417 RID: 13335 RVA: 0x000A26D7 File Offset: 0x000A08D7
			public NumberLookupComparer(global::NPOI.SS.Formula.Eval.NumberEval ne) : base(ne)
			{
				this._value = ne.NumberValue;
			}

			// Token: 0x06003418 RID: 13336 RVA: 0x000A26EC File Offset: 0x000A08EC
			protected override global::NPOI.SS.Formula.Functions.CompareResult CompareSameType(global::NPOI.SS.Formula.Eval.ValueEval other)
			{
				global::NPOI.SS.Formula.Eval.NumberEval numberEval = (global::NPOI.SS.Formula.Eval.NumberEval)other;
				return global::NPOI.SS.Formula.Functions.CompareResult.ValueOf(this._value.CompareTo(numberEval.NumberValue));
			}

			// Token: 0x06003419 RID: 13337 RVA: 0x000A2716 File Offset: 0x000A0916
			protected override string GetValueAsString()
			{
				return this._value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			}

			// Token: 0x040018DE RID: 6366
			private double _value;
		}
	}
}
