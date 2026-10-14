using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using NLog.Common;
using NLog.Internal;

namespace NLog.Conditions
{
	// Token: 0x0200017E RID: 382
	internal sealed class ConditionMethodExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x0002B400 File Offset: 0x00029600
		public ConditionMethodExpression(string conditionMethodName, global::System.Reflection.MethodInfo methodInfo, global::System.Collections.Generic.IEnumerable<global::NLog.Conditions.ConditionExpression> methodParameters)
		{
			this.MethodInfo = methodInfo;
			this._conditionMethodName = conditionMethodName;
			this.MethodParameters = new global::System.Collections.Generic.List<global::NLog.Conditions.ConditionExpression>(methodParameters).AsReadOnly();
			global::System.Reflection.ParameterInfo[] parameters = this.MethodInfo.GetParameters();
			if (parameters.Length != 0 && parameters[0].ParameterType == typeof(global::NLog.LogEventInfo))
			{
				this._acceptsLogEvent = true;
			}
			int num = this.MethodParameters.Count;
			if (this._acceptsLogEvent)
			{
				num++;
			}
			int num2;
			int num3;
			global::NLog.Conditions.ConditionMethodExpression.CountParmameters(parameters, out num2, out num3);
			if (num < num2 || num > parameters.Length)
			{
				string message;
				if (num3 > 0)
				{
					message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Condition method '{0}' requires between {1} and {2} parameters, but passed {3}.", new object[]
					{
						conditionMethodName,
						num2,
						parameters.Length,
						num
					});
				}
				else
				{
					message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Condition method '{0}' requires {1} parameters, but passed {2}.", new object[]
					{
						conditionMethodName,
						num2,
						num
					});
				}
				global::NLog.Common.InternalLogger.Error(message);
				throw new global::NLog.Conditions.ConditionParseException(message);
			}
			this.CreateBoundMethod(parameters);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0002B510 File Offset: 0x00029710
		private void CreateBoundMethod(global::System.Reflection.ParameterInfo[] formalParameters)
		{
			this._lateBoundMethod = global::NLog.Internal.ReflectionHelpers.CreateLateBoundMethod(this.MethodInfo);
			if (formalParameters.Length > this.MethodParameters.Count)
			{
				this._lateBoundMethodDefaultParameters = new object[formalParameters.Length - this.MethodParameters.Count];
				for (int i = this.MethodParameters.Count; i < formalParameters.Length; i++)
				{
					global::System.Reflection.ParameterInfo parameterInfo = formalParameters[i];
					this._lateBoundMethodDefaultParameters[i - this.MethodParameters.Count] = parameterInfo.DefaultValue;
				}
				return;
			}
			this._lateBoundMethodDefaultParameters = null;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0002B598 File Offset: 0x00029798
		private static void CountParmameters(global::System.Reflection.ParameterInfo[] formalParameters, out int requiredParametersCount, out int optionalParametersCount)
		{
			requiredParametersCount = 0;
			optionalParametersCount = 0;
			for (int i = 0; i < formalParameters.Length; i++)
			{
				if (formalParameters[i].IsOptional)
				{
					optionalParametersCount++;
				}
				else
				{
					requiredParametersCount++;
				}
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0002B5D3 File Offset: 0x000297D3
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x0002B5DB File Offset: 0x000297DB
		public global::System.Reflection.MethodInfo MethodInfo { get; private set; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0002B5E4 File Offset: 0x000297E4
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x0002B5EC File Offset: 0x000297EC
		public global::System.Collections.Generic.IList<global::NLog.Conditions.ConditionExpression> MethodParameters { get; private set; }

		// Token: 0x0600106F RID: 4207 RVA: 0x0002B5F8 File Offset: 0x000297F8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this._conditionMethodName);
			stringBuilder.Append("(");
			string value = string.Empty;
			for (int i = 0; i < this.MethodParameters.Count; i++)
			{
				global::NLog.Conditions.ConditionExpression value2 = this.MethodParameters[i];
				stringBuilder.Append(value);
				stringBuilder.Append(value2);
				value = ", ";
			}
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0002B678 File Offset: 0x00029878
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			int num = this._acceptsLogEvent ? 1 : 0;
			int num2 = (this._lateBoundMethodDefaultParameters != null) ? this._lateBoundMethodDefaultParameters.Length : 0;
			object[] array = new object[this.MethodParameters.Count + num + num2];
			for (int i = 0; i < this.MethodParameters.Count; i++)
			{
				global::NLog.Conditions.ConditionExpression conditionExpression = this.MethodParameters[i];
				array[i + num] = conditionExpression.Evaluate(context);
			}
			if (this._acceptsLogEvent)
			{
				array[0] = context;
			}
			if (this._lateBoundMethodDefaultParameters != null)
			{
				for (int j = this._lateBoundMethodDefaultParameters.Length - 1; j >= 0; j--)
				{
					array[array.Length - j - 1] = this._lateBoundMethodDefaultParameters[j];
				}
			}
			return this._lateBoundMethod(null, array);
		}

		// Token: 0x04000480 RID: 1152
		private readonly bool _acceptsLogEvent;

		// Token: 0x04000481 RID: 1153
		private readonly string _conditionMethodName;

		// Token: 0x04000483 RID: 1155
		private global::NLog.Internal.ReflectionHelpers.LateBoundMethod _lateBoundMethod;

		// Token: 0x04000484 RID: 1156
		private object[] _lateBoundMethodDefaultParameters;
	}
}
