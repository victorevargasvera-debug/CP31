using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200013B RID: 315
	public class ComparisonCondition : global::Infragistics.Windows.Controls.ICondition, global::System.ICloneable
	{
		// Token: 0x06000A87 RID: 2695 RVA: 0x0002219B File Offset: 0x0002039B
		public ComparisonCondition()
		{
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000221A3 File Offset: 0x000203A3
		public ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value) : this(comparisonOperator, value, null)
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000221AE File Offset: 0x000203AE
		public ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, string displayText)
		{
			global::Infragistics.Windows.Controls.ComparisonCondition.ValidateValueHelper(comparisonOperator, value);
			this.Operator = comparisonOperator;
			this._value = value;
			this._displayText = displayText;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000221D4 File Offset: 0x000203D4
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = obj as global::Infragistics.Windows.Controls.ComparisonCondition;
			return comparisonCondition != null && comparisonCondition._comparisonOperator == this._comparisonOperator && object.Equals(comparisonCondition._value, this._value);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0002220C File Offset: 0x0002040C
		public override int GetHashCode()
		{
			int num = this._comparisonOperator.GetHashCode();
			if (this._value != null)
			{
				num |= this._value.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00022244 File Offset: 0x00020444
		public override string ToString()
		{
			if (!string.IsNullOrEmpty(this._displayText))
			{
				return this._displayText;
			}
			object value = this.Value;
			return global::SR.GetString("ComparisonCondition_" + this.Operator.ToString(), new object[]
			{
				value
			});
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00022297 File Offset: 0x00020497
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0002229F File Offset: 0x0002049F
		public string DisplayText
		{
			get
			{
				return this._displayText;
			}
			set
			{
				this._displayText = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x000222A8 File Offset: 0x000204A8
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x000222B0 File Offset: 0x000204B0
		public global::Infragistics.Windows.Controls.ComparisonOperator Operator
		{
			get
			{
				return this._comparisonOperator;
			}
			set
			{
				if (this._comparisonOperator != value)
				{
					global::Infragistics.Windows.Utilities.ThrowIfInvalidEnum(value, "Operator");
					this._comparisonOperator = value;
					this.ClearCache();
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x000222D8 File Offset: 0x000204D8
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x000222E0 File Offset: 0x000204E0
		public object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (this._value != value)
				{
					global::Infragistics.Windows.Controls.ComparisonCondition.ValidateValueHelper(this._comparisonOperator, value);
					this._value = value;
				}
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000222FE File Offset: 0x000204FE
		public static global::Infragistics.Windows.Controls.ComparisonCondition Create(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object operand, bool validateOperand, out global::System.Exception error)
		{
			return global::Infragistics.Windows.Controls.ComparisonCondition.Create(comparisonOperator, operand, null, validateOperand, out error);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0002230C File Offset: 0x0002050C
		public static global::Infragistics.Windows.Controls.ComparisonCondition Create(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object operand, string displayText, bool validateOperand, out global::System.Exception error)
		{
			error = null;
			if (validateOperand && !global::Infragistics.Windows.Controls.ComparisonCondition.ValidateValueHelper(comparisonOperator, operand, null, null, out error))
			{
				return null;
			}
			return new global::Infragistics.Windows.Controls.ComparisonCondition
			{
				_comparisonOperator = comparisonOperator,
				_value = operand,
				_displayText = displayText
			};
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0002234B File Offset: 0x0002054B
		object global::System.ICloneable.Clone()
		{
			return new global::Infragistics.Windows.Controls.ComparisonCondition(this._comparisonOperator, this._value, this._displayText);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00022364 File Offset: 0x00020564
		public static global::Infragistics.Windows.Controls.ComparisonOperatorFlags GetComparisonOperatorFlag(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
		{
			return (global::Infragistics.Windows.Controls.ComparisonOperatorFlags)(1 << (int)comparisonOperator);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0002236C File Offset: 0x0002056C
		public static global::Infragistics.Windows.Controls.ComparisonOperator[] GetComparisonOperators(global::Infragistics.Windows.Controls.ComparisonOperatorFlags flags)
		{
			if (global::Infragistics.Windows.Controls.ComparisonCondition._operatorTable == null)
			{
				global::Infragistics.Windows.Controls.ComparisonCondition._operatorTable = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.Controls.ComparisonOperatorFlags, global::Infragistics.Windows.Controls.ComparisonOperator[]>();
			}
			global::Infragistics.Windows.Controls.ComparisonOperator[] array;
			if (!global::Infragistics.Windows.Controls.ComparisonCondition._operatorTable.TryGetValue(flags, out array))
			{
				array = (global::Infragistics.Windows.Controls.ComparisonCondition._operatorTable[flags] = global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperatorsImpl(flags));
			}
			return (global::Infragistics.Windows.Controls.ComparisonOperator[])array.Clone();
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000223B8 File Offset: 0x000205B8
		private static global::Infragistics.Windows.Controls.ComparisonOperator[] GetComparisonOperatorsImpl(global::Infragistics.Windows.Controls.ComparisonOperatorFlags flags)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ComparisonOperator> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ComparisonOperator>();
			for (int i = 0; i < 32; i++)
			{
				int num = 1 << i;
				if ((num & (int)flags) != 0 && global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.ComparisonOperator), i))
				{
					list.Add((global::Infragistics.Windows.Controls.ComparisonOperator)i);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00022408 File Offset: 0x00020608
		public static global::Infragistics.Windows.Controls.ComparisonOperatorFlags GetCompatibleComparisonOperators(global::System.Type dataType, out global::Infragistics.Windows.Controls.ComparisonOperator defaultUIOperator)
		{
			global::Infragistics.Windows.Controls.ComparisonOperator[] array;
			return global::Infragistics.Windows.Controls.ComparisonCondition.GetCompatibleComparisonOperators(dataType, out defaultUIOperator, out array);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00022420 File Offset: 0x00020620
		private static global::Infragistics.Windows.Controls.ComparisonOperatorFlags GetCompatibleComparisonOperators(global::System.Type dataType, out global::Infragistics.Windows.Controls.ComparisonOperator defaultUIOperator, out global::Infragistics.Windows.Controls.ComparisonOperator[] prioritizedDefaultUIOperators)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			bool flag = global::Infragistics.Windows.Utilities.IsNumericType(underlyingType);
			global::Infragistics.Windows.Controls.ComparisonOperatorFlags comparisonOperatorFlags = global::Infragistics.Windows.Controls.ComparisonOperatorFlags.None;
			if (flag || typeof(global::System.DateTime) == underlyingType)
			{
				defaultUIOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
				comparisonOperatorFlags |= (global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Equals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotEquals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.LessThan | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.LessThanOrEqualsTo | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.GreaterThan | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.GreaterThanOrEqualsTo | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Top | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Bottom);
				if (flag)
				{
					comparisonOperatorFlags |= (global::Infragistics.Windows.Controls.ComparisonOperatorFlags.TopPercentile | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.BottomPercentile);
					prioritizedDefaultUIOperators = new global::Infragistics.Windows.Controls.ComparisonOperator[]
					{
						global::Infragistics.Windows.Controls.ComparisonOperator.Equals,
						global::Infragistics.Windows.Controls.ComparisonOperator.Top,
						global::Infragistics.Windows.Controls.ComparisonOperator.TopPercentile,
						global::Infragistics.Windows.Controls.ComparisonOperator.Bottom,
						global::Infragistics.Windows.Controls.ComparisonOperator.BottomPercentile,
						global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith,
						global::Infragistics.Windows.Controls.ComparisonOperator.Contains,
						global::Infragistics.Windows.Controls.ComparisonOperator.Like,
						global::Infragistics.Windows.Controls.ComparisonOperator.Match
					};
				}
				else
				{
					prioritizedDefaultUIOperators = new global::Infragistics.Windows.Controls.ComparisonOperator[]
					{
						global::Infragistics.Windows.Controls.ComparisonOperator.Equals,
						global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith,
						global::Infragistics.Windows.Controls.ComparisonOperator.EndsWith,
						global::Infragistics.Windows.Controls.ComparisonOperator.Contains,
						global::Infragistics.Windows.Controls.ComparisonOperator.Like,
						global::Infragistics.Windows.Controls.ComparisonOperator.Match,
						global::Infragistics.Windows.Controls.ComparisonOperator.Top,
						global::Infragistics.Windows.Controls.ComparisonOperator.TopPercentile,
						global::Infragistics.Windows.Controls.ComparisonOperator.Bottom,
						global::Infragistics.Windows.Controls.ComparisonOperator.BottomPercentile
					};
				}
			}
			else if (typeof(bool) == underlyingType)
			{
				defaultUIOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
				comparisonOperatorFlags = (global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Equals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotEquals);
				global::Infragistics.Windows.Controls.ComparisonOperator[] array = new global::Infragistics.Windows.Controls.ComparisonOperator[1];
				prioritizedDefaultUIOperators = array;
			}
			else
			{
				defaultUIOperator = global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith;
				comparisonOperatorFlags = (global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Equals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotEquals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.LessThan | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.LessThanOrEqualsTo | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.GreaterThan | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.GreaterThanOrEqualsTo | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Contains | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.DoesNotContain | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Like | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotLike | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Match | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.DoesNotMatch | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.StartsWith | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.DoesNotStartWith | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.EndsWith | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.DoesNotEndWith);
				global::Infragistics.Windows.Controls.ComparisonOperator[] array2 = new global::Infragistics.Windows.Controls.ComparisonOperator[5];
				array2[0] = global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith;
				array2[1] = global::Infragistics.Windows.Controls.ComparisonOperator.Contains;
				array2[2] = global::Infragistics.Windows.Controls.ComparisonOperator.Like;
				array2[3] = global::Infragistics.Windows.Controls.ComparisonOperator.Match;
				prioritizedDefaultUIOperators = array2;
			}
			return comparisonOperatorFlags;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00022538 File Offset: 0x00020738
		public static global::Infragistics.Windows.Controls.ComparisonOperator GetCompatibleComparisonOperator(global::System.Type dataType, global::Infragistics.Windows.Controls.ComparisonOperatorFlags availableOperators)
		{
			global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator;
			global::Infragistics.Windows.Controls.ComparisonOperator[] array;
			global::Infragistics.Windows.Controls.ComparisonCondition.GetCompatibleComparisonOperators(dataType, out comparisonOperator, out array);
			if ((global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperatorFlag(comparisonOperator) & availableOperators) != global::Infragistics.Windows.Controls.ComparisonOperatorFlags.None)
			{
				return comparisonOperator;
			}
			if (array != null)
			{
				foreach (global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator2 in array)
				{
					if ((global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperatorFlag(comparisonOperator2) & availableOperators) != global::Infragistics.Windows.Controls.ComparisonOperatorFlags.None)
					{
						return comparisonOperator2;
					}
				}
			}
			global::Infragistics.Windows.Controls.ComparisonOperator[] comparisonOperators = global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperators(availableOperators);
			if (comparisonOperators.Length <= 0)
			{
				return comparisonOperator;
			}
			return comparisonOperators[0];
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00022592 File Offset: 0x00020792
		public static bool IsCompareValueValid(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object compareValue, global::System.Globalization.CultureInfo convertCulture, string convertFormat, out global::System.Exception error)
		{
			return global::Infragistics.Windows.Controls.ComparisonCondition.ValidateValueHelper(comparisonOperator, compareValue, convertCulture, convertFormat, out error);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000225A0 File Offset: 0x000207A0
		public static bool IsCountingOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
		{
			switch (comparisonOperator)
			{
			case global::Infragistics.Windows.Controls.ComparisonOperator.Top:
			case global::Infragistics.Windows.Controls.ComparisonOperator.Bottom:
			case global::Infragistics.Windows.Controls.ComparisonOperator.TopPercentile:
			case global::Infragistics.Windows.Controls.ComparisonOperator.BottomPercentile:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000225D0 File Offset: 0x000207D0
		public bool IsMatch(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			object obj = value;
			object value2 = this._value;
			global::Infragistics.Windows.Controls.IFilterEvaluator filterEvaluator = (context != null) ? context.FilterEvaluator : null;
			if (filterEvaluator != null)
			{
				bool? flag = filterEvaluator.Evaluate(this._comparisonOperator, ref obj, ref value2, context);
				if (flag != null)
				{
					return flag.Value;
				}
			}
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = value2 as global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
			if (specialFilterOperandBase != null)
			{
				return specialFilterOperandBase.SupportsOperator(this._comparisonOperator) && specialFilterOperandBase.IsMatch(this._comparisonOperator, obj, context);
			}
			global::System.Type targetType = null;
			global::System.Type type = null;
			global::System.Type type2 = null;
			if (global::Infragistics.Windows.Controls.ComparisonCondition.IsStringComparison(this._comparisonOperator))
			{
				type = (targetType = typeof(string));
			}
			else if (global::Infragistics.Windows.Controls.ComparisonCondition.IsCountingOperator(this._comparisonOperator))
			{
				targetType = null;
				type = typeof(double);
			}
			else if (global::Infragistics.Windows.Controls.ComparisonCondition.IsQuantitativeComparison(this._comparisonOperator) && obj != null && global::System.DBNull.Value != obj && value2 != null && global::System.DBNull.Value != value2)
			{
				type = (targetType = this.GetPreferredComparisonTypeHelper(context, obj, value2));
				if (type != typeof(bool))
				{
					type2 = typeof(string);
				}
			}
			object lhs = obj;
			object rhs = value2;
			if (!this.ConvertHelper(ref lhs, targetType, context) || !this.ConvertHelper(ref rhs, type, context))
			{
				if (!(null != type2))
				{
					return false;
				}
				if (!this.ConvertHelper(ref lhs, type2, context) || !this.ConvertHelper(ref rhs, type2, context))
				{
					return false;
				}
			}
			return this.Evaluate(this._comparisonOperator, lhs, rhs, context);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00022734 File Offset: 0x00020934
		public static bool IsQuantitativeComparison(global::Infragistics.Windows.Controls.ComparisonOperator op)
		{
			switch (op)
			{
			case global::Infragistics.Windows.Controls.ComparisonOperator.Equals:
			case global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals:
			case global::Infragistics.Windows.Controls.ComparisonOperator.LessThan:
			case global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo:
			case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThan:
			case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00022768 File Offset: 0x00020968
		public static bool IsStringComparison(global::Infragistics.Windows.Controls.ComparisonOperator op)
		{
			switch (op)
			{
			case global::Infragistics.Windows.Controls.ComparisonOperator.Contains:
			case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotContain:
			case global::Infragistics.Windows.Controls.ComparisonOperator.Like:
			case global::Infragistics.Windows.Controls.ComparisonOperator.NotLike:
			case global::Infragistics.Windows.Controls.ComparisonOperator.Match:
			case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotMatch:
			case global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith:
			case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotStartWith:
			case global::Infragistics.Windows.Controls.ComparisonOperator.EndsWith:
			case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotEndWith:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000227AC File Offset: 0x000209AC
		private void ClearCache()
		{
			this._cachedRegex = null;
			this._cachedRegex_Pattern = null;
			this._topValuesOperand = null;
			this._topValuesOperand_Number = double.NaN;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000227D4 File Offset: 0x000209D4
		private static int CompareHelper(object x, object y, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			global::System.Collections.IComparer comparer = (context != null) ? context.Comparer : null;
			if (comparer != null)
			{
				return comparer.Compare(x, y);
			}
			if (x is string && y is string)
			{
				return string.Compare((string)x, (string)y, context.IgnoreCase, global::Infragistics.Windows.Controls.ComparisonCondition.GetCulture(context));
			}
			if (x == null || x is global::System.DBNull)
			{
				if (y == null || y is global::System.DBNull)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (y == null || y is global::System.DBNull)
				{
					return 1;
				}
				if (!(x is global::System.IComparable))
				{
					return -2;
				}
				int num = global::System.Collections.Comparer.Default.Compare(x, y);
				if (num < 0)
				{
					return -1;
				}
				if (num > 0)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00022874 File Offset: 0x00020A74
		private object ConvertDataType(object x, global::System.Type targetType, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			if (targetType == typeof(string))
			{
				if (this._lastConversionToStringSourceValue == x && x != null)
				{
					return this._lastConvertedToStringValue;
				}
			}
			else if (this._lastConversionSourceValue == x && this._lastConversionType == targetType && x != null)
			{
				return this._lastConvertedValue;
			}
			object obj = global::Infragistics.Windows.Controls.ComparisonCondition.ConvertDataTypeHelper(x, targetType, context);
			if (x == this._value)
			{
				if (targetType == typeof(string))
				{
					this._lastConversionToStringSourceValue = x;
					this._lastConvertedToStringValue = obj;
				}
				else
				{
					this._lastConversionSourceValue = x;
					this._lastConversionType = targetType;
					this._lastConvertedValue = obj;
				}
			}
			return obj;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00022914 File Offset: 0x00020B14
		internal static object ConvertDataTypeHelper(object x, global::System.Type targetType, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			if (x == null || global::System.DBNull.Value == x)
			{
				return x;
			}
			global::System.Type type = x.GetType();
			if (type == targetType)
			{
				return x;
			}
			if (global::Infragistics.Windows.Utilities.IsNumericType(targetType) && global::Infragistics.Windows.Utilities.IsNumericType(type))
			{
				try
				{
					return global::System.Convert.ChangeType(x, targetType);
				}
				catch
				{
				}
			}
			global::Infragistics.Windows.Controls.ValueEntry currentValue = context.CurrentValue;
			return global::Infragistics.CoreUtilities.ConvertDataValue(x, targetType, currentValue.Culture, currentValue.Format);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0002298C File Offset: 0x00020B8C
		private bool ConvertHelper(ref object val, global::System.Type targetType, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			if (null != targetType)
			{
				object obj = this.ConvertDataType(val, targetType, context);
				if (obj == null && val != null)
				{
					return false;
				}
				val = obj;
			}
			return true;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000229BC File Offset: 0x00020BBC
		private string ConvertToString(object x, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			string text = x as string;
			if (text == null)
			{
				text = (this.ConvertDataType(x, typeof(string), context) as string);
			}
			if (text == null)
			{
				return string.Empty;
			}
			return text;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000229F8 File Offset: 0x00020BF8
		private static global::Infragistics.Windows.Controls.SpecialFilterOperandBase CreateTopValuesOperandHelper(global::Infragistics.Windows.Controls.ComparisonOperator op, double topNValue, out global::System.Exception error)
		{
			switch (op)
			{
			case global::Infragistics.Windows.Controls.ComparisonOperator.Top:
				return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.CreateHelper("Top", topNValue, false, true, out error);
			case global::Infragistics.Windows.Controls.ComparisonOperator.Bottom:
				return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.CreateHelper("Bottom", topNValue, false, false, out error);
			case global::Infragistics.Windows.Controls.ComparisonOperator.TopPercentile:
				return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.CreateHelper("TopPercentile", topNValue, true, true, out error);
			case global::Infragistics.Windows.Controls.ComparisonOperator.BottomPercentile:
				return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.CreateHelper("BottomPercentile", topNValue, true, false, out error);
			default:
				error = new global::System.InvalidOperationException();
				return null;
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00022A68 File Offset: 0x00020C68
		private bool Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator op, object lhs, object rhs, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			switch (op)
			{
			case global::Infragistics.Windows.Controls.ComparisonOperator.Equals:
			{
				int num = global::Infragistics.Windows.Controls.ComparisonCondition.CompareHelper(lhs, rhs, context);
				return -2 != num && 0 == num;
			}
			case global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals:
				return !this.Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, lhs, rhs, context);
			case global::Infragistics.Windows.Controls.ComparisonOperator.LessThan:
			{
				int num = global::Infragistics.Windows.Controls.ComparisonCondition.CompareHelper(lhs, rhs, context);
				return -2 != num && num < 0;
			}
			case global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo:
			{
				int num = global::Infragistics.Windows.Controls.ComparisonCondition.CompareHelper(lhs, rhs, context);
				return -2 != num && num <= 0;
			}
			case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThan:
			{
				int num = global::Infragistics.Windows.Controls.ComparisonCondition.CompareHelper(lhs, rhs, context);
				return -2 != num && num > 0;
			}
			case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo:
			{
				int num = global::Infragistics.Windows.Controls.ComparisonCondition.CompareHelper(lhs, rhs, context);
				return -2 != num && num >= 0;
			}
			default:
				switch (op)
				{
				case global::Infragistics.Windows.Controls.ComparisonOperator.Top:
				case global::Infragistics.Windows.Controls.ComparisonOperator.Bottom:
				case global::Infragistics.Windows.Controls.ComparisonOperator.TopPercentile:
				case global::Infragistics.Windows.Controls.ComparisonOperator.BottomPercentile:
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = null;
					if (rhs is double)
					{
						double num2 = (double)rhs;
						if (op == this._topValuesOperand_Operator && num2 == this._topValuesOperand_Number)
						{
							specialFilterOperandBase = this._topValuesOperand;
						}
						else
						{
							global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.ClearUserCacheHelper(this._topValuesOperand, context);
							global::System.Exception ex;
							specialFilterOperandBase = global::Infragistics.Windows.Controls.ComparisonCondition.CreateTopValuesOperandHelper(op, num2, out ex);
							this._topValuesOperand = specialFilterOperandBase;
							this._topValuesOperand_Number = num2;
							this._topValuesOperand_Operator = op;
						}
					}
					return specialFilterOperandBase != null && specialFilterOperandBase.IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, lhs, context);
				}
				default:
				{
					string text = this.ConvertToString(lhs, context);
					string text2 = this.ConvertToString(rhs, context);
					bool ignoreCase = context.IgnoreCase;
					switch (op)
					{
					case global::Infragistics.Windows.Controls.ComparisonOperator.Contains:
						if (ignoreCase)
						{
							string text3 = this.ToLower(text, context);
							string value = this.ToLower(text2, context);
							return text3.Contains(value);
						}
						return text.Contains(text2);
					case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotContain:
						return !this.Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator.Contains, text, text2, context);
					case global::Infragistics.Windows.Controls.ComparisonOperator.Like:
					{
						string pattern = text2;
						global::System.Text.RegularExpressions.Regex cachedRegex = this.GetCachedRegex(pattern, true, ignoreCase);
						return cachedRegex != null && cachedRegex.IsMatch(text);
					}
					case global::Infragistics.Windows.Controls.ComparisonOperator.NotLike:
						return !this.Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator.Like, text, text2, context);
					case global::Infragistics.Windows.Controls.ComparisonOperator.Match:
					{
						global::System.Text.RegularExpressions.Regex regex = rhs as global::System.Text.RegularExpressions.Regex;
						if (regex == null)
						{
							string pattern2 = text2;
							regex = this.GetCachedRegex(pattern2, false, ignoreCase);
						}
						return regex != null && regex.IsMatch(text);
					}
					case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotMatch:
						return !this.Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator.Match, text, text2, context);
					case global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith:
						return text.StartsWith(text2, ignoreCase, global::Infragistics.Windows.Controls.ComparisonCondition.GetCulture(context));
					case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotStartWith:
						return !this.Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith, text, text2, context);
					case global::Infragistics.Windows.Controls.ComparisonOperator.EndsWith:
						return text.EndsWith(text2, ignoreCase, global::Infragistics.Windows.Controls.ComparisonCondition.GetCulture(context));
					case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotEndWith:
						return !this.Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator.EndsWith, text, text2, context);
					default:
						return false;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00022CF8 File Offset: 0x00020EF8
		private global::System.Text.RegularExpressions.Regex GetCachedRegex(string pattern, bool isPatternWildcard, bool ignoreCase)
		{
			global::System.Text.RegularExpressions.Regex regex = null;
			if (this._cachedRegex_Pattern == pattern && this._cachedRegex_IgnoreCase == ignoreCase)
			{
				regex = this._cachedRegex;
			}
			else
			{
				this._cachedRegex_Pattern = pattern;
				this._cachedRegex_IgnoreCase = ignoreCase;
				try
				{
					if (isPatternWildcard)
					{
						regex = global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.Convert(pattern, ignoreCase);
					}
					else
					{
						global::System.Text.RegularExpressions.RegexOptions regexOptions = global::System.Text.RegularExpressions.RegexOptions.ExplicitCapture;
						if (ignoreCase)
						{
							regexOptions |= global::System.Text.RegularExpressions.RegexOptions.IgnoreCase;
						}
						regex = new global::System.Text.RegularExpressions.Regex(pattern, regexOptions);
					}
				}
				catch
				{
				}
				this._cachedRegex = regex;
			}
			return regex;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00022D70 File Offset: 0x00020F70
		private static global::System.Globalization.CultureInfo GetCulture(global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			global::System.Globalization.CultureInfo cultureInfo = null;
			if (context != null)
			{
				global::Infragistics.Windows.Controls.ValueEntry currentValue = context.CurrentValue;
				if (currentValue != null)
				{
					cultureInfo = currentValue.Culture;
				}
			}
			if (cultureInfo == null)
			{
				cultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
			}
			return cultureInfo;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00022DA0 File Offset: 0x00020FA0
		private global::System.Type GetPreferredComparisonTypeHelper(global::Infragistics.Windows.Controls.ConditionEvaluationContext context, object lhs, object rhs)
		{
			global::System.Type type = context.PreferredComparisonDataType;
			if (null == type || typeof(object) == type)
			{
				global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(lhs.GetType());
				global::System.Type underlyingType2 = global::Infragistics.CoreUtilities.GetUnderlyingType(rhs.GetType());
				if (underlyingType == underlyingType2)
				{
					type = underlyingType;
				}
				else if (global::Infragistics.Windows.Utilities.IsNumericType(underlyingType) || global::Infragistics.Windows.Utilities.IsNumericType(underlyingType2))
				{
					type = typeof(decimal);
				}
				else
				{
					type = typeof(string);
				}
			}
			return type;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00022E20 File Offset: 0x00021020
		private static bool IsValidRegex(string regex, out global::System.Exception error)
		{
			global::System.Exception innerException = null;
			try
			{
				if (!string.IsNullOrEmpty(regex))
				{
					new global::System.Text.RegularExpressions.Regex(regex);
					error = null;
					return true;
				}
			}
			catch (global::System.Exception ex)
			{
				innerException = ex;
			}
			error = new global::System.ArgumentException("value", global::SR.GetString("Filter_Regex_InvalidPattern"), innerException);
			return false;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00022E78 File Offset: 0x00021078
		private static bool IsValidWildcard(string wildcard, out global::System.Exception error)
		{
			string text;
			global::System.Text.RegularExpressions.RegexOptions regexOptions;
			global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.Convert(wildcard, out text, out regexOptions, out error);
			return null == error;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00022E95 File Offset: 0x00021095
		private string ToLower(string str, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			return str.ToLower(global::Infragistics.Windows.Controls.ComparisonCondition.GetCulture(context));
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00022EA4 File Offset: 0x000210A4
		private static void ValidateValueHelper(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value)
		{
			global::System.Exception ex;
			if (!global::Infragistics.Windows.Controls.ComparisonCondition.ValidateValueHelper(comparisonOperator, value, null, null, out ex))
			{
				throw ex;
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00022EC0 File Offset: 0x000210C0
		private static bool ValidateValueHelper(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::System.Globalization.CultureInfo convertCulture, string convertFormat, out global::System.Exception error)
		{
			error = null;
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = value as global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
			if (specialFilterOperandBase == null)
			{
				if (convertCulture == null)
				{
					convertCulture = global::Infragistics.Windows.Controls.ComparisonCondition.GetCulture(null);
				}
				switch (comparisonOperator)
				{
				case global::Infragistics.Windows.Controls.ComparisonOperator.Like:
				case global::Infragistics.Windows.Controls.ComparisonOperator.NotLike:
				{
					string wildcard = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(string), convertCulture, convertFormat) as string;
					if (!global::Infragistics.Windows.Controls.ComparisonCondition.IsValidWildcard(wildcard, out error))
					{
						return false;
					}
					break;
				}
				case global::Infragistics.Windows.Controls.ComparisonOperator.Match:
				case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotMatch:
				{
					string regex = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(string), convertCulture, convertFormat) as string;
					if (!global::Infragistics.Windows.Controls.ComparisonCondition.IsValidRegex(regex, out error))
					{
						return false;
					}
					break;
				}
				}
				if (global::Infragistics.Windows.Controls.ComparisonCondition.IsCountingOperator(comparisonOperator))
				{
					object obj = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(double), convertCulture, convertFormat);
					if (!(obj is double) || null == global::Infragistics.Windows.Controls.ComparisonCondition.CreateTopValuesOperandHelper(comparisonOperator, (double)obj, out error))
					{
						if (error == null)
						{
							error = new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_26"));
						}
						return false;
					}
				}
				return true;
			}
			if (!specialFilterOperandBase.SupportsOperator(comparisonOperator))
			{
				error = new global::System.ArgumentException("value", global::SR.GetString("Filter_IncompatibleOperand"));
				return false;
			}
			return true;
		}

		// Token: 0x040004C4 RID: 1220
		private global::Infragistics.Windows.Controls.ComparisonOperator _comparisonOperator;

		// Token: 0x040004C5 RID: 1221
		private object _value;

		// Token: 0x040004C6 RID: 1222
		private string _displayText;

		// Token: 0x040004C7 RID: 1223
		private global::System.Text.RegularExpressions.Regex _cachedRegex;

		// Token: 0x040004C8 RID: 1224
		private string _cachedRegex_Pattern;

		// Token: 0x040004C9 RID: 1225
		private bool _cachedRegex_IgnoreCase;

		// Token: 0x040004CA RID: 1226
		private global::Infragistics.Windows.Controls.SpecialFilterOperandBase _topValuesOperand;

		// Token: 0x040004CB RID: 1227
		private global::Infragistics.Windows.Controls.ComparisonOperator _topValuesOperand_Operator;

		// Token: 0x040004CC RID: 1228
		private double _topValuesOperand_Number;

		// Token: 0x040004CD RID: 1229
		private global::System.Type _lastConversionType;

		// Token: 0x040004CE RID: 1230
		private object _lastConversionSourceValue;

		// Token: 0x040004CF RID: 1231
		private object _lastConvertedValue;

		// Token: 0x040004D0 RID: 1232
		private object _lastConversionToStringSourceValue;

		// Token: 0x040004D1 RID: 1233
		private object _lastConvertedToStringValue;

		// Token: 0x040004D2 RID: 1234
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.Controls.ComparisonOperatorFlags, global::Infragistics.Windows.Controls.ComparisonOperator[]> _operatorTable;

		// Token: 0x0200013D RID: 317
		internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
		{
			// Token: 0x170001DA RID: 474
			// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00022FD4 File Offset: 0x000211D4
			public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
			{
				get
				{
					if (this._props == null)
					{
						this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
						{
							new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(global::Infragistics.Windows.Controls.ComparisonOperator), "Operator"),
							new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(object), "Value")
						};
					}
					return this._props;
				}
			}

			// Token: 0x06000AB6 RID: 2742 RVA: 0x0002302C File Offset: 0x0002122C
			public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
			{
				global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = (global::Infragistics.Windows.Controls.ComparisonCondition)obj;
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				dictionary["Operator"] = comparisonCondition.Operator;
				object obj2 = comparisonCondition.Value;
				if (obj2 is global::Infragistics.Windows.Controls.SpecialFilterOperandBase)
				{
					obj2 = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetSerializationValue((global::Infragistics.Windows.Controls.SpecialFilterOperandBase)obj2);
				}
				dictionary["Value"] = obj2;
				if (!string.IsNullOrEmpty(comparisonCondition._displayText))
				{
					dictionary["DisplayText"] = comparisonCondition._displayText;
				}
				return dictionary;
			}

			// Token: 0x06000AB7 RID: 2743 RVA: 0x000230A4 File Offset: 0x000212A4
			public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
			{
				object obj;
				object value;
				if (values.TryGetValue("Operator", out obj) && values.TryGetValue("Value", out value))
				{
					object obj2;
					values.TryGetValue("DisplayText", out obj2);
					return new global::Infragistics.Windows.Controls.ComparisonCondition((global::Infragistics.Windows.Controls.ComparisonOperator)obj, value, obj2 as string);
				}
				return null;
			}

			// Token: 0x040004D4 RID: 1236
			private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
		}

		// Token: 0x0200013E RID: 318
		internal class WildcardToRegexConverter
		{
			// Token: 0x06000AB9 RID: 2745 RVA: 0x000230F9 File Offset: 0x000212F9
			private WildcardToRegexConverter(string wildcard)
			{
				this._wildcard = wildcard;
				this._regex = new global::System.Text.StringBuilder(wildcard.Length);
			}

			// Token: 0x06000ABA RID: 2746 RVA: 0x0002311C File Offset: 0x0002131C
			public static global::System.Text.RegularExpressions.Regex Convert(string wildcard, bool ignoreCase)
			{
				string pattern;
				global::System.Text.RegularExpressions.RegexOptions regexOptions;
				global::System.Exception ex;
				global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.Convert(wildcard, out pattern, out regexOptions, out ex);
				if (ex == null)
				{
					if (ignoreCase)
					{
						regexOptions |= global::System.Text.RegularExpressions.RegexOptions.IgnoreCase;
					}
					return new global::System.Text.RegularExpressions.Regex(pattern, regexOptions);
				}
				return null;
			}

			// Token: 0x06000ABB RID: 2747 RVA: 0x00023148 File Offset: 0x00021348
			public static void Convert(string wildcard, out string regex, out global::System.Text.RegularExpressions.RegexOptions options, out global::System.Exception error)
			{
				if (wildcard == null || wildcard.Length == 0)
				{
					options = global::System.Text.RegularExpressions.RegexOptions.None;
					regex = null;
					error = new global::System.Exception(global::SR.GetString("Filter_WildCardEmpty"));
					return;
				}
				global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter wildcardToRegexConverter = new global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter(wildcard);
				wildcardToRegexConverter.Parse();
				if (wildcardToRegexConverter._error == null && wildcardToRegexConverter._regex.Length > 0)
				{
					regex = "^" + wildcardToRegexConverter._regex.ToString() + "$";
					options = (global::System.Text.RegularExpressions.RegexOptions.ExplicitCapture | global::System.Text.RegularExpressions.RegexOptions.Singleline);
					error = null;
					return;
				}
				error = new global::System.Exception(wildcardToRegexConverter._error);
				options = global::System.Text.RegularExpressions.RegexOptions.None;
				regex = null;
			}

			// Token: 0x06000ABC RID: 2748 RVA: 0x000231D4 File Offset: 0x000213D4
			private void Parse()
			{
				global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState parseState = global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Initial;
				int num = -1;
				global::System.Text.StringBuilder regex = this._regex;
				string wildcard = this._wildcard;
				for (int i = 0; i < wildcard.Length; i++)
				{
					char c = wildcard[i];
					if (global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Bracket == parseState && ']' == c)
					{
						this.ParseSet(1 + num, i - 1);
						parseState = global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Initial;
					}
					else if (parseState == global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Initial && '[' == c)
					{
						num = i;
						parseState = global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Bracket;
					}
					else if (parseState == global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Initial && '#' == c)
					{
						regex.Append("\\d");
					}
					else if (parseState == global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Initial && '?' == c)
					{
						regex.Append('.');
					}
					else if (parseState == global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Initial && '*' == c)
					{
						regex.Append(".*");
					}
					else if (parseState == global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.ParseState.Initial)
					{
						if ("[]{}()\\.+*?^$".IndexOf(c) >= 0)
						{
							regex.Append('\\');
						}
						regex.Append(c);
					}
				}
			}

			// Token: 0x06000ABD RID: 2749 RVA: 0x000232AC File Offset: 0x000214AC
			private void ParseSet(int si, int ei)
			{
				global::System.Text.StringBuilder regex = this._regex;
				string wildcard = this._wildcard;
				int length = regex.Length;
				regex.Append('[');
				if ('!' == wildcard[si])
				{
					if (si == ei)
					{
						this._error = global::SR.GetString("Filter_WildCard_InvalidCharClass");
						return;
					}
					regex.Append('^');
					si++;
				}
				for (int i = si; i <= ei; i++)
				{
					char value = wildcard[i];
					if ("[]{}()\\.+*?^$".IndexOf(value) >= 0)
					{
						regex.Append('\\');
					}
					regex.Append(value);
				}
				regex.Append(']');
			}

			// Token: 0x040004D5 RID: 1237
			private const string REGEX_SPECIAL_CHARS = "[]{}()\\.+*?^$";

			// Token: 0x040004D6 RID: 1238
			private string _wildcard;

			// Token: 0x040004D7 RID: 1239
			private global::System.Text.StringBuilder _regex;

			// Token: 0x040004D8 RID: 1240
			private string _error;

			// Token: 0x0200013F RID: 319
			private enum ParseState
			{
				// Token: 0x040004DA RID: 1242
				Initial,
				// Token: 0x040004DB RID: 1243
				Bracket
			}
		}
	}
}
