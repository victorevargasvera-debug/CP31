using System;
using System.Collections.Generic;
using System.Globalization;
using NLog.Common;

namespace NLog.Conditions
{
	// Token: 0x02000185 RID: 389
	internal sealed class ConditionRelationalExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x06001099 RID: 4249 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
		public ConditionRelationalExpression(global::NLog.Conditions.ConditionExpression leftExpression, global::NLog.Conditions.ConditionExpression rightExpression, global::NLog.Conditions.ConditionRelationalOperator relationalOperator)
		{
			this.LeftExpression = leftExpression;
			this.RightExpression = rightExpression;
			this.RelationalOperator = relationalOperator;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0002BF05 File Offset: 0x0002A105
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x0002BF0D File Offset: 0x0002A10D
		public global::NLog.Conditions.ConditionExpression LeftExpression { get; private set; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x0002BF16 File Offset: 0x0002A116
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x0002BF1E File Offset: 0x0002A11E
		public global::NLog.Conditions.ConditionExpression RightExpression { get; private set; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x0002BF27 File Offset: 0x0002A127
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x0002BF2F File Offset: 0x0002A12F
		public global::NLog.Conditions.ConditionRelationalOperator RelationalOperator { get; private set; }

		// Token: 0x060010A0 RID: 4256 RVA: 0x0002BF38 File Offset: 0x0002A138
		public override string ToString()
		{
			return string.Format("({0} {1} {2})", this.LeftExpression, this.GetOperatorString(), this.RightExpression);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0002BF58 File Offset: 0x0002A158
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			object leftValue = this.LeftExpression.Evaluate(context);
			object rightValue = this.RightExpression.Evaluate(context);
			return global::NLog.Conditions.ConditionRelationalExpression.Compare(leftValue, rightValue, this.RelationalOperator);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0002BF8C File Offset: 0x0002A18C
		private static object Compare(object leftValue, object rightValue, global::NLog.Conditions.ConditionRelationalOperator relationalOperator)
		{
			global::System.StringComparer invariantCulture = global::System.StringComparer.InvariantCulture;
			global::NLog.Conditions.ConditionRelationalExpression.PromoteTypes(ref leftValue, ref rightValue);
			switch (relationalOperator)
			{
			case global::NLog.Conditions.ConditionRelationalOperator.Equal:
				return invariantCulture.Compare(leftValue, rightValue) == 0;
			case global::NLog.Conditions.ConditionRelationalOperator.NotEqual:
				return invariantCulture.Compare(leftValue, rightValue) != 0;
			case global::NLog.Conditions.ConditionRelationalOperator.Less:
				return invariantCulture.Compare(leftValue, rightValue) < 0;
			case global::NLog.Conditions.ConditionRelationalOperator.Greater:
				return invariantCulture.Compare(leftValue, rightValue) > 0;
			case global::NLog.Conditions.ConditionRelationalOperator.LessOrEqual:
				return invariantCulture.Compare(leftValue, rightValue) <= 0;
			case global::NLog.Conditions.ConditionRelationalOperator.GreaterOrEqual:
				return invariantCulture.Compare(leftValue, rightValue) >= 0;
			default:
				throw new global::System.NotSupportedException(string.Format("Relational operator {0} is not supported.", relationalOperator));
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0002C04C File Offset: 0x0002A24C
		private static void PromoteTypes(ref object leftValue, ref object rightValue)
		{
			if (leftValue == null || rightValue == null)
			{
				return;
			}
			global::System.Type type = leftValue.GetType();
			global::System.Type type2 = rightValue.GetType();
			if (type == type2)
			{
				return;
			}
			int order = global::NLog.Conditions.ConditionRelationalExpression.GetOrder(type);
			int order2 = global::NLog.Conditions.ConditionRelationalExpression.GetOrder(type2);
			if (order < order2)
			{
				if (global::NLog.Conditions.ConditionRelationalExpression.TryPromoteTypes(ref rightValue, type, ref leftValue, type2))
				{
					return;
				}
			}
			else if (global::NLog.Conditions.ConditionRelationalExpression.TryPromoteTypes(ref leftValue, type2, ref rightValue, type))
			{
				return;
			}
			throw new global::NLog.Conditions.ConditionEvaluationException(string.Format("Cannot find common type for '{0}' and '{1}'.", type.Name, type2.Name));
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0002C0C0 File Offset: 0x0002A2C0
		private static bool TryPromoteType(ref object val, global::System.Type type1)
		{
			try
			{
				if (type1 == typeof(global::System.DateTime))
				{
					val = global::System.Convert.ToDateTime(val, global::System.Globalization.CultureInfo.InvariantCulture);
					return true;
				}
				if (type1 == typeof(double))
				{
					val = global::System.Convert.ToDouble(val, global::System.Globalization.CultureInfo.InvariantCulture);
					return true;
				}
				if (type1 == typeof(float))
				{
					val = global::System.Convert.ToSingle(val, global::System.Globalization.CultureInfo.InvariantCulture);
					return true;
				}
				if (type1 == typeof(decimal))
				{
					val = global::System.Convert.ToDecimal(val, global::System.Globalization.CultureInfo.InvariantCulture);
					return true;
				}
				if (type1 == typeof(long))
				{
					val = global::System.Convert.ToInt64(val, global::System.Globalization.CultureInfo.InvariantCulture);
					return true;
				}
				if (type1 == typeof(int))
				{
					val = global::System.Convert.ToInt32(val, global::System.Globalization.CultureInfo.InvariantCulture);
					return true;
				}
				if (type1 == typeof(bool))
				{
					val = global::System.Convert.ToBoolean(val, global::System.Globalization.CultureInfo.InvariantCulture);
					return true;
				}
				if (type1 == typeof(string))
				{
					val = global::System.Convert.ToString(val, global::System.Globalization.CultureInfo.InvariantCulture);
					global::NLog.Common.InternalLogger.Debug("Using string comparision");
					return true;
				}
			}
			catch (global::System.Exception)
			{
				global::NLog.Common.InternalLogger.Debug<object, string>("conversion of {0} to {1} failed", val, type1.Name);
			}
			return false;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0002C260 File Offset: 0x0002A460
		private static bool TryPromoteTypes(ref object val1, global::System.Type type1, ref object val2, global::System.Type type2)
		{
			return global::NLog.Conditions.ConditionRelationalExpression.TryPromoteType(ref val1, type1) || global::NLog.Conditions.ConditionRelationalExpression.TryPromoteType(ref val2, type2);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0002C274 File Offset: 0x0002A474
		private static int GetOrder(global::System.Type type1)
		{
			int result;
			if (global::NLog.Conditions.ConditionRelationalExpression.TypePromoteOrder.TryGetValue(type1, out result))
			{
				return result;
			}
			return int.MaxValue;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0002C298 File Offset: 0x0002A498
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> BuildTypeOrderDictionary()
		{
			global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>
			{
				typeof(global::System.DateTime),
				typeof(double),
				typeof(float),
				typeof(decimal),
				typeof(long),
				typeof(int),
				typeof(bool),
				typeof(string)
			};
			global::System.Collections.Generic.Dictionary<global::System.Type, int> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				dictionary.Add(list[i], i);
			}
			return dictionary;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0002C358 File Offset: 0x0002A558
		private string GetOperatorString()
		{
			switch (this.RelationalOperator)
			{
			case global::NLog.Conditions.ConditionRelationalOperator.Equal:
				return "==";
			case global::NLog.Conditions.ConditionRelationalOperator.NotEqual:
				return "!=";
			case global::NLog.Conditions.ConditionRelationalOperator.Less:
				return "<";
			case global::NLog.Conditions.ConditionRelationalOperator.Greater:
				return ">";
			case global::NLog.Conditions.ConditionRelationalOperator.LessOrEqual:
				return "<=";
			case global::NLog.Conditions.ConditionRelationalOperator.GreaterOrEqual:
				return ">=";
			default:
				throw new global::System.NotSupportedException(string.Format("Relational operator {0} is not supported.", this.RelationalOperator));
			}
		}

		// Token: 0x04000490 RID: 1168
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> TypePromoteOrder = global::NLog.Conditions.ConditionRelationalExpression.BuildTypeOrderDictionary();
	}
}
