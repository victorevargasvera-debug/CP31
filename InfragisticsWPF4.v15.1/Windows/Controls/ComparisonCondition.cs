using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200015A RID: 346
	public class ComparisonCondition : global::Infragistics.Windows.Controls.ICondition, global::System.ICloneable
	{
		// Token: 0x06000B86 RID: 2950 RVA: 0x00025D63 File Offset: 0x00023F63
		public ComparisonCondition()
		{
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00025D6B File Offset: 0x00023F6B
		public ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value) : this(comparisonOperator, value, null)
		{
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00025D76 File Offset: 0x00023F76
		public ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, string displayText)
		{
			global::Infragistics.Windows.Controls.ComparisonCondition.ValidateValueHelper(comparisonOperator, value);
			this.Operator = comparisonOperator;
			this._value = value;
			this._displayText = displayText;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00025D9C File Offset: 0x00023F9C
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = obj as global::Infragistics.Windows.Controls.ComparisonCondition;
			return comparisonCondition != null && comparisonCondition._comparisonOperator == this._comparisonOperator && object.Equals(comparisonCondition._value, this._value);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00025DD4 File Offset: 0x00023FD4
		public override int GetHashCode()
		{
			int num = this._comparisonOperator.GetHashCode();
			if (this._value != null)
			{
				num |= this._value.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00025E0C File Offset: 0x0002400C
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00025E5F File Offset: 0x0002405F
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x00025E67 File Offset: 0x00024067
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x00025E70 File Offset: 0x00024070
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x00025E78 File Offset: 0x00024078
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x00025EA0 File Offset: 0x000240A0
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x00025EA8 File Offset: 0x000240A8
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

		// Token: 0x06000B92 RID: 2962 RVA: 0x00025EC6 File Offset: 0x000240C6
		public static global::Infragistics.Windows.Controls.ComparisonCondition Create(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object operand, bool validateOperand, out global::System.Exception error)
		{
			return global::Infragistics.Windows.Controls.ComparisonCondition.Create(comparisonOperator, operand, null, validateOperand, out error);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00025ED4 File Offset: 0x000240D4
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

		// Token: 0x06000B94 RID: 2964 RVA: 0x00025F13 File Offset: 0x00024113
		object global::System.ICloneable.Clone()
		{
			return new global::Infragistics.Windows.Controls.ComparisonCondition(this._comparisonOperator, this._value, this._displayText);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00025F2C File Offset: 0x0002412C
		public static global::Infragistics.Windows.Controls.ComparisonOperatorFlags GetComparisonOperatorFlag(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
		{
			return (global::Infragistics.Windows.Controls.ComparisonOperatorFlags)(1 << (int)comparisonOperator);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00025F34 File Offset: 0x00024134
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

		// Token: 0x06000B97 RID: 2967 RVA: 0x00025F80 File Offset: 0x00024180
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

		// Token: 0x06000B98 RID: 2968 RVA: 0x00025FD0 File Offset: 0x000241D0
		public static global::Infragistics.Windows.Controls.ComparisonOperatorFlags GetCompatibleComparisonOperators(global::System.Type dataType, out global::Infragistics.Windows.Controls.ComparisonOperator defaultUIOperator)
		{
			global::Infragistics.Windows.Controls.ComparisonOperator[] array;
			return global::Infragistics.Windows.Controls.ComparisonCondition.GetCompatibleComparisonOperators(dataType, out defaultUIOperator, out array);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00025FE8 File Offset: 0x000241E8
		private static global::Infragistics.Windows.Controls.ComparisonOperatorFlags GetCompatibleComparisonOperators(global::System.Type dataType, out global::Infragistics.Windows.Controls.ComparisonOperator defaultUIOperator, out global::Infragistics.Windows.Controls.ComparisonOperator[] prioritizedDefaultUIOperators)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			bool flag = global::Infragistics.Windows.Utilities.IsNumericType(underlyingType);
			global::Infragistics.Windows.Controls.ComparisonOperatorFlags comparisonOperatorFlags = global::Infragistics.Windows.Controls.ComparisonOperatorFlags.None;
			if (flag || typeof(global::System.DateTime) == underlyingType)
			{
				defaultUIOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
				comparisonOperatorFlags |= (global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Equals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotEquals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.LessThan | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.LessThanOrEqualsTo | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.GreaterThan | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.GreaterThanOrEqualsTo | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Top | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Bottom | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.In | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotIn);
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
						global::Infragistics.Windows.Controls.ComparisonOperator.Match,
						global::Infragistics.Windows.Controls.ComparisonOperator.In
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
						global::Infragistics.Windows.Controls.ComparisonOperator.BottomPercentile,
						global::Infragistics.Windows.Controls.ComparisonOperator.In
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
				comparisonOperatorFlags = (global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Equals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotEquals | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.LessThan | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.LessThanOrEqualsTo | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.GreaterThan | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.GreaterThanOrEqualsTo | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Contains | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.DoesNotContain | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Like | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotLike | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.Match | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.DoesNotMatch | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.StartsWith | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.DoesNotStartWith | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.EndsWith | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.DoesNotEndWith | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.In | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotIn);
				prioritizedDefaultUIOperators = new global::Infragistics.Windows.Controls.ComparisonOperator[]
				{
					global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith,
					global::Infragistics.Windows.Controls.ComparisonOperator.Contains,
					global::Infragistics.Windows.Controls.ComparisonOperator.Like,
					global::Infragistics.Windows.Controls.ComparisonOperator.Match,
					global::Infragistics.Windows.Controls.ComparisonOperator.Equals,
					global::Infragistics.Windows.Controls.ComparisonOperator.In
				};
			}
			return comparisonOperatorFlags;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00026114 File Offset: 0x00024314
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

		// Token: 0x06000B9B RID: 2971 RVA: 0x0002616E File Offset: 0x0002436E
		public static bool IsCompareValueValid(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object compareValue, global::System.Globalization.CultureInfo convertCulture, string convertFormat, out global::System.Exception error)
		{
			return global::Infragistics.Windows.Controls.ComparisonCondition.ValidateValueHelper(comparisonOperator, compareValue, convertCulture, convertFormat, out error);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0002617C File Offset: 0x0002437C
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

		// Token: 0x06000B9D RID: 2973 RVA: 0x000261AC File Offset: 0x000243AC
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
			if (global::Infragistics.Windows.Controls.ComparisonOperator.In == this._comparisonOperator || global::Infragistics.Windows.Controls.ComparisonOperator.NotIn == this._comparisonOperator)
			{
				if (this._inOperatorCache == null || this._inOperatorCache._lastValue != this._value)
				{
					this._inOperatorCache = new global::Infragistics.Windows.Controls.ComparisonCondition.InOperatorCache
					{
						_lastValue = this._value
					};
					global::System.Collections.IEnumerable items = null;
					if (this._value is string)
					{
						char[] array = "\"'".ToCharArray();
						global::Infragistics.ListParser listParser = new global::Infragistics.ListParser(array, array, '\\', ',');
						items = listParser.ParseList(this._value.ToString(), false);
					}
					else if (this._value != null)
					{
						items = new object[]
						{
							this._value
						};
					}
					this._inOperatorCache._cachedInOperand = new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand(items);
				}
				return this._inOperatorCache._cachedInOperand.IsMatch((global::Infragistics.Windows.Controls.ComparisonOperator.In == this._comparisonOperator) ? global::Infragistics.Windows.Controls.ComparisonOperator.Equals : global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals, value, context);
			}
			global::System.Type targetType;
			global::System.Type targetType2;
			global::System.Type type;
			global::Infragistics.Windows.Controls.ComparisonCondition.GetConvertType(this._comparisonOperator, context, obj, value2, out targetType, out targetType2, out type);
			object lhs = obj;
			object rhs = value2;
			if (!this.ConvertHelper(ref lhs, targetType, context) || !this.ConvertHelper(ref rhs, targetType2, context))
			{
				if (!(null != type))
				{
					return false;
				}
				if (!this.ConvertHelper(ref lhs, type, context) || !this.ConvertHelper(ref rhs, type, context))
				{
					return false;
				}
			}
			return this.Evaluate(this._comparisonOperator, lhs, rhs, context);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00026374 File Offset: 0x00024574
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

		// Token: 0x06000B9F RID: 2975 RVA: 0x000263A8 File Offset: 0x000245A8
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

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000263EC File Offset: 0x000245EC
		private void ClearCache()
		{
			this._cachedRegex = null;
			this._cachedRegex_Pattern = null;
			this._topValuesOperand = null;
			this._topValuesOperand_Number = double.NaN;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00026414 File Offset: 0x00024614
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

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000264B4 File Offset: 0x000246B4
		internal static string ConstructInOperand(global::System.Collections.Generic.List<string> values)
		{
			global::Infragistics.ListParser inOperandListParser = global::Infragistics.Windows.Controls.ComparisonCondition.GetInOperandListParser();
			return inOperandListParser.ConstructList(values, true);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000264D0 File Offset: 0x000246D0
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

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0002656D File Offset: 0x0002476D
		internal static object ConvertDataTypeHelper(object x, global::System.Type targetType, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			return context.ConvertValue(x, targetType);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00026578 File Offset: 0x00024778
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

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000265A8 File Offset: 0x000247A8
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

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000265E4 File Offset: 0x000247E4
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

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00026654 File Offset: 0x00024854
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
			case global::Infragistics.Windows.Controls.ComparisonOperator.NotIn:
				return !this.Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator.In, lhs, rhs, context);
			}
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
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00026918 File Offset: 0x00024B18
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
						regex = global::Infragistics.CoreUtilities.WildcardToRegexConverter.Convert(pattern, ignoreCase, true);
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

		// Token: 0x06000BAA RID: 2986 RVA: 0x00026994 File Offset: 0x00024B94
		internal static void GetConvertType(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, global::Infragistics.Windows.Controls.ConditionEvaluationContext context, object lhs, object rhs, out global::System.Type lhsConvertType, out global::System.Type rhsConvertType, out global::System.Type fallbackConvertType)
		{
			lhsConvertType = null;
			rhsConvertType = null;
			fallbackConvertType = null;
			if (global::Infragistics.Windows.Controls.ComparisonCondition.IsStringComparison(comparisonOperator))
			{
				global::System.Type typeFromHandle;
				rhsConvertType = (typeFromHandle = typeof(string));
				lhsConvertType = typeFromHandle;
				return;
			}
			if (global::Infragistics.Windows.Controls.ComparisonCondition.IsCountingOperator(comparisonOperator))
			{
				lhsConvertType = null;
				rhsConvertType = typeof(double);
				return;
			}
			if (global::Infragistics.Windows.Controls.ComparisonCondition.IsQuantitativeComparison(comparisonOperator) && lhs != null && global::System.DBNull.Value != lhs && rhs != null && global::System.DBNull.Value != rhs)
			{
				global::System.Type preferredComparisonTypeHelper;
				rhsConvertType = (preferredComparisonTypeHelper = global::Infragistics.Windows.Controls.ComparisonCondition.GetPreferredComparisonTypeHelper(context, lhs, rhs));
				lhsConvertType = preferredComparisonTypeHelper;
				if (rhsConvertType != typeof(bool))
				{
					fallbackConvertType = typeof(string);
				}
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00026A34 File Offset: 0x00024C34
		internal static global::System.Globalization.CultureInfo GetCulture(global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
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

		// Token: 0x06000BAC RID: 2988 RVA: 0x00026A64 File Offset: 0x00024C64
		private static global::Infragistics.ListParser GetInOperandListParser()
		{
			char[] array = "\"'".ToCharArray();
			return new global::Infragistics.ListParser(array, array, '\\', ',');
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00026A88 File Offset: 0x00024C88
		private static global::System.Type GetPreferredComparisonTypeHelper(global::Infragistics.Windows.Controls.ConditionEvaluationContext context, object lhs, object rhs)
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

		// Token: 0x06000BAE RID: 2990 RVA: 0x00026B08 File Offset: 0x00024D08
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

		// Token: 0x06000BAF RID: 2991 RVA: 0x00026B60 File Offset: 0x00024D60
		private static bool IsValidWildcard(string wildcard, out global::System.Exception error)
		{
			string text;
			global::System.Text.RegularExpressions.RegexOptions regexOptions;
			global::Infragistics.CoreUtilities.WildcardToRegexConverter.Convert(wildcard, out text, out regexOptions, out error, true);
			return null == error;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00026B7E File Offset: 0x00024D7E
		private string ToLower(string str, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			return str.ToLower(global::Infragistics.Windows.Controls.ComparisonCondition.GetCulture(context));
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00026B8C File Offset: 0x00024D8C
		private static void ValidateValueHelper(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value)
		{
			global::System.Exception ex;
			if (!global::Infragistics.Windows.Controls.ComparisonCondition.ValidateValueHelper(comparisonOperator, value, null, null, out ex))
			{
				throw ex;
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00026BA8 File Offset: 0x00024DA8
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

		// Token: 0x0400057A RID: 1402
		private global::Infragistics.Windows.Controls.ComparisonOperator _comparisonOperator;

		// Token: 0x0400057B RID: 1403
		private object _value;

		// Token: 0x0400057C RID: 1404
		private string _displayText;

		// Token: 0x0400057D RID: 1405
		private global::System.Text.RegularExpressions.Regex _cachedRegex;

		// Token: 0x0400057E RID: 1406
		private string _cachedRegex_Pattern;

		// Token: 0x0400057F RID: 1407
		private bool _cachedRegex_IgnoreCase;

		// Token: 0x04000580 RID: 1408
		private global::Infragistics.Windows.Controls.SpecialFilterOperandBase _topValuesOperand;

		// Token: 0x04000581 RID: 1409
		private global::Infragistics.Windows.Controls.ComparisonOperator _topValuesOperand_Operator;

		// Token: 0x04000582 RID: 1410
		private double _topValuesOperand_Number;

		// Token: 0x04000583 RID: 1411
		private global::System.Type _lastConversionType;

		// Token: 0x04000584 RID: 1412
		private object _lastConversionSourceValue;

		// Token: 0x04000585 RID: 1413
		private object _lastConvertedValue;

		// Token: 0x04000586 RID: 1414
		private object _lastConversionToStringSourceValue;

		// Token: 0x04000587 RID: 1415
		private object _lastConvertedToStringValue;

		// Token: 0x04000588 RID: 1416
		private global::Infragistics.Windows.Controls.ComparisonCondition.InOperatorCache _inOperatorCache;

		// Token: 0x04000589 RID: 1417
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.Controls.ComparisonOperatorFlags, global::Infragistics.Windows.Controls.ComparisonOperator[]> _operatorTable;

		// Token: 0x0200015C RID: 348
		internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
		{
			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00026CBC File Offset: 0x00024EBC
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

			// Token: 0x06000BB8 RID: 3000 RVA: 0x00026D14 File Offset: 0x00024F14
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

			// Token: 0x06000BB9 RID: 3001 RVA: 0x00026D8C File Offset: 0x00024F8C
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

			// Token: 0x0400058B RID: 1419
			private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
		}

		// Token: 0x0200015D RID: 349
		private class InOperatorCache
		{
			// Token: 0x0400058C RID: 1420
			internal object _lastValue;

			// Token: 0x0400058D RID: 1421
			internal global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand _cachedInOperand;
		}
	}
}
