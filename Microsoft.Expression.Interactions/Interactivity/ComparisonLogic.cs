using System;
using System.ComponentModel;
using System.Globalization;
using Microsoft.Expression.Interactivity.Core;

namespace Microsoft.Expression.Interactivity
{
	// Token: 0x02000008 RID: 8
	internal static class ComparisonLogic
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000030C0 File Offset: 0x000012C0
		internal static bool EvaluateImpl(object leftOperand, global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType operatorType, object rightOperand)
		{
			bool result = false;
			if (leftOperand != null)
			{
				global::System.Type type = leftOperand.GetType();
				if (rightOperand != null)
				{
					global::System.ComponentModel.TypeConverter typeConverter = global::Microsoft.Expression.Interactivity.TypeConverterHelper.GetTypeConverter(type);
					rightOperand = global::Microsoft.Expression.Interactivity.TypeConverterHelper.DoConversionFrom(typeConverter, rightOperand);
				}
			}
			global::System.IComparable comparable = leftOperand as global::System.IComparable;
			global::System.IComparable comparable2 = rightOperand as global::System.IComparable;
			if (comparable != null && comparable2 != null)
			{
				return global::Microsoft.Expression.Interactivity.ComparisonLogic.EvaluateComparable(comparable, operatorType, comparable2);
			}
			switch (operatorType)
			{
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.Equal:
				result = object.Equals(leftOperand, rightOperand);
				break;
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.NotEqual:
				result = !object.Equals(leftOperand, rightOperand);
				break;
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.LessThan:
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.LessThanOrEqual:
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.GreaterThan:
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.GreaterThanOrEqual:
				if (comparable == null && comparable2 == null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.InvalidOperands, new object[]
					{
						(leftOperand != null) ? leftOperand.GetType().Name : "null",
						(rightOperand != null) ? rightOperand.GetType().Name : "null",
						operatorType.ToString()
					}));
				}
				if (comparable == null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.InvalidLeftOperand, new object[]
					{
						(leftOperand != null) ? leftOperand.GetType().Name : "null",
						operatorType.ToString()
					}));
				}
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.InvalidRightOperand, new object[]
				{
					(rightOperand != null) ? rightOperand.GetType().Name : "null",
					operatorType.ToString()
				}));
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000324C File Offset: 0x0000144C
		private static bool EvaluateComparable(global::System.IComparable leftOperand, global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType operatorType, global::System.IComparable rightOperand)
		{
			object obj = null;
			try
			{
				obj = global::System.Convert.ChangeType(rightOperand, leftOperand.GetType(), global::System.Globalization.CultureInfo.CurrentCulture);
			}
			catch (global::System.FormatException)
			{
			}
			catch (global::System.InvalidCastException)
			{
			}
			if (obj == null)
			{
				return operatorType == global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.NotEqual;
			}
			int num = leftOperand.CompareTo((global::System.IComparable)obj);
			bool result = false;
			switch (operatorType)
			{
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.Equal:
				result = (num == 0);
				break;
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.NotEqual:
				result = (num != 0);
				break;
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.LessThan:
				result = (num < 0);
				break;
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.LessThanOrEqual:
				result = (num <= 0);
				break;
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.GreaterThan:
				result = (num > 0);
				break;
			case global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.GreaterThanOrEqual:
				result = (num >= 0);
				break;
			}
			return result;
		}
	}
}
