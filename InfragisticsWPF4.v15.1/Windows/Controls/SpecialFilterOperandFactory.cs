using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Infragistics.Shared;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000167 RID: 359
	internal class SpecialFilterOperandFactory
	{
		// Token: 0x06000C42 RID: 3138 RVA: 0x00028940 File Offset: 0x00026B40
		internal static global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand> GetBuiltInOperands()
		{
			return new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand>(50)
			{
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand(false),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand(true),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand(true),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand(false),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand("Top10", 10.0, false, true),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand("Top10Percentage", 10.0, true, true),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand("Bottom10", 10.0, false, false),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand("Bottom10Percentage", 10.0, true, false),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("Tomorrow", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.Tomorrow),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("Today", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.Today),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("Yesterday", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.Yesterday),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("NextWeek", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextWeek),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("ThisWeek", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.ThisWeek),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("LastWeek", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastWeek),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("NextMonth", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextMonth),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("ThisMonth", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.ThisMonth),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("LastMonth", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastMonth),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("NextQuarter", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextQuarter),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("ThisQuarter", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.ThisQuarter),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("LastQuarter", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastQuarter),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("NextYear", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextYear),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("ThisYear", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.ThisYear),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("LastYear", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastYear),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand("YearToDate", global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.YearToDate),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand("Quarter1", 1),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand("Quarter2", 2),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand("Quarter3", 3),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand("Quarter4", 4),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("January", 1),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("February", 2),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("March", 3),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("April", 4),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("May", 5),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("June", 6),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("July", 7),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("August", 8),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("September", 9),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("October", 10),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("November", 11),
				new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand("December", 12)
			};
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00028C20 File Offset: 0x00026E20
		internal static void RegisterSerializationInfos(global::Infragistics.Windows.Internal.ObjectSerializerBase serializer)
		{
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.SerializationInfo());
		}

		// Token: 0x02000169 RID: 361
		internal abstract class IGOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandBase
		{
			// Token: 0x06000C52 RID: 3154 RVA: 0x00028D94 File Offset: 0x00026F94
			public IGOperand(string name, string resourceName)
			{
				this._name = name;
				this._sr_displayContent = "SpecialFilterOperand_" + resourceName + "_DisplayContent";
				this._sr_description = "SpecialFilterOperand_" + resourceName + "_Description";
			}

			// Token: 0x06000C53 RID: 3155 RVA: 0x00028DCF File Offset: 0x00026FCF
			public IGOperand(string name) : this(name, name)
			{
			}

			// Token: 0x06000C54 RID: 3156 RVA: 0x00028DDC File Offset: 0x00026FDC
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand igoperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand;
				return igoperand != null && this._name == igoperand.Name && this._sr_displayContent == igoperand._sr_displayContent && this._sr_description == igoperand._sr_description;
			}

			// Token: 0x06000C55 RID: 3157 RVA: 0x00028E2C File Offset: 0x0002702C
			public override int GetHashCode()
			{
				if (this._name == null)
				{
					return 0;
				}
				return this._name.GetHashCode();
			}

			// Token: 0x17000228 RID: 552
			// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00028E43 File Offset: 0x00027043
			public override object Description
			{
				get
				{
					if (this._drsDescription == null)
					{
						this._drsDescription = global::SR.GetDynamicResourceString(this._sr_description, this.ValueArgumentsForStrings, null);
					}
					return this._drsDescription.Value;
				}
			}

			// Token: 0x17000229 RID: 553
			// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00028E70 File Offset: 0x00027070
			public override object DisplayContent
			{
				get
				{
					if (this._fsrDisplayContent == null)
					{
						this._fsrDisplayContent = new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand.FormattedSRValue(this._sr_displayContent, this.ValueArgumentsForStrings, null);
					}
					return this._fsrDisplayContent;
				}
			}

			// Token: 0x1700022A RID: 554
			// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00028E98 File Offset: 0x00027098
			public override string Name
			{
				get
				{
					return this._name;
				}
			}

			// Token: 0x1700022B RID: 555
			// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00028EA0 File Offset: 0x000270A0
			public override bool UsesAllValues
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00028EA3 File Offset: 0x000270A3
			protected virtual object[] ValueArgumentsForStrings
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000C5B RID: 3163 RVA: 0x00028EA6 File Offset: 0x000270A6
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				return this.SupportsOperator(comparisonOperator) && (value == null || global::System.DBNull.Value == value || this.SupportsDataType(value.GetType()));
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x00028ECD File Offset: 0x000270CD
			internal static object ConvertValue(object value, global::System.Type targetType, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				return global::Infragistics.Windows.Controls.ComparisonCondition.ConvertDataTypeHelper(value, targetType, context);
			}

			// Token: 0x06000C5D RID: 3165 RVA: 0x00028ED8 File Offset: 0x000270D8
			internal static double GetCurrentValueAsDouble(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				object obj = global::Infragistics.Windows.Controls.ComparisonCondition.ConvertDataTypeHelper(value, typeof(double), context);
				if (!(obj is double))
				{
					return double.NaN;
				}
				return (double)obj;
			}

			// Token: 0x040005D9 RID: 1497
			private string _name;

			// Token: 0x040005DA RID: 1498
			private string _sr_displayContent;

			// Token: 0x040005DB RID: 1499
			private string _sr_description;

			// Token: 0x040005DC RID: 1500
			private global::Infragistics.Shared.DynamicResourceString _drsDescription;

			// Token: 0x040005DD RID: 1501
			private global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand.FormattedSRValue _fsrDisplayContent;

			// Token: 0x0200016A RID: 362
			internal class FormattedSRValue : global::System.IFormattable
			{
				// Token: 0x06000C5E RID: 3166 RVA: 0x00028F0F File Offset: 0x0002710F
				internal FormattedSRValue(string sr, object[] args, global::System.Globalization.CultureInfo defaultCultureInfo)
				{
					global::Infragistics.Windows.Utilities.ThrowIfNull(sr, "sr");
					this._sr = sr;
					this._args = args;
					this._defaultCultureInfo = defaultCultureInfo;
				}

				// Token: 0x06000C5F RID: 3167 RVA: 0x00028F37 File Offset: 0x00027137
				public override string ToString()
				{
					return this.ToString(null, null);
				}

				// Token: 0x06000C60 RID: 3168 RVA: 0x00028F44 File Offset: 0x00027144
				public string ToString(string format, global::System.IFormatProvider formatProvider)
				{
					global::System.Globalization.CultureInfo culture = this._defaultCultureInfo;
					if (formatProvider is global::System.Globalization.CultureInfo)
					{
						culture = (formatProvider as global::System.Globalization.CultureInfo);
					}
					global::Infragistics.Shared.DynamicResourceString dynamicResourceString = global::SR.GetDynamicResourceString(this._sr, this._args, culture);
					if (dynamicResourceString == null)
					{
						return string.Empty;
					}
					return dynamicResourceString.Value;
				}

				// Token: 0x040005DE RID: 1502
				private string _sr;

				// Token: 0x040005DF RID: 1503
				private object[] _args;

				// Token: 0x040005E0 RID: 1504
				private global::System.Globalization.CultureInfo _defaultCultureInfo;
			}
		}

		// Token: 0x0200016B RID: 363
		internal class BlanksOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000C61 RID: 3169 RVA: 0x00028F89 File Offset: 0x00027189
			public BlanksOperand(bool nonBlanks) : base((!nonBlanks) ? "Blanks" : "NonBlanks")
			{
				this._nonBlanks = nonBlanks;
			}

			// Token: 0x06000C62 RID: 3170 RVA: 0x00028FA8 File Offset: 0x000271A8
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand blanksOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand;
				return blanksOperand != null && base.EqualsOverride(blanksOperand) && this._nonBlanks == blanksOperand._nonBlanks;
			}

			// Token: 0x06000C63 RID: 3171 RVA: 0x00028FD8 File Offset: 0x000271D8
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this._nonBlanks.GetHashCode();
			}

			// Token: 0x06000C64 RID: 3172 RVA: 0x00028FEC File Offset: 0x000271EC
			public override bool SupportsDataType(global::System.Type type)
			{
				return true;
			}

			// Token: 0x06000C65 RID: 3173 RVA: 0x00028FEF File Offset: 0x000271EF
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				return comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals || global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator;
			}

			// Token: 0x06000C66 RID: 3174 RVA: 0x00028FFA File Offset: 0x000271FA
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
				{
					return this._nonBlanks != global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand.IsBlank(value, context);
				}
				return global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator && !this.IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, value, context);
			}

			// Token: 0x06000C67 RID: 3175 RVA: 0x00029024 File Offset: 0x00027224
			private static bool IsBlank(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (value == null || value is global::System.DBNull)
				{
					return true;
				}
				if (value is string)
				{
					return 0 == ((string)value).Length;
				}
				global::System.Type type = value.GetType();
				return !type.IsPrimitive && !(value is global::System.DateTime) && !(value is decimal) && !type.IsEnum && !(value is global::System.TimeSpan) && string.IsNullOrEmpty(value.ToString());
			}

			// Token: 0x040005E1 RID: 1505
			internal const string NAME_Blanks = "Blanks";

			// Token: 0x040005E2 RID: 1506
			internal const string NAME_NonBlanks = "NonBlanks";

			// Token: 0x040005E3 RID: 1507
			private bool _nonBlanks;

			// Token: 0x0200016C RID: 364
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x1700022D RID: 557
				// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00029094 File Offset: 0x00027294
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(bool), "MatchNonBlanks")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000C69 RID: 3177 RVA: 0x000290D4 File Offset: 0x000272D4
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand blanksOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["MatchNonBlanks"] = blanksOperand._nonBlanks;
					return dictionary;
				}

				// Token: 0x06000C6A RID: 3178 RVA: 0x00029108 File Offset: 0x00027308
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					bool nonBlanks = false;
					object obj;
					if (values.TryGetValue("MatchNonBlanks", out obj))
					{
						nonBlanks = (bool)obj;
					}
					return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand(nonBlanks);
				}

				// Token: 0x040005E4 RID: 1508
				private const string NonBlanksProp = "MatchNonBlanks";

				// Token: 0x040005E5 RID: 1509
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x0200016D RID: 365
		internal class AverageOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000C6C RID: 3180 RVA: 0x0002913B File Offset: 0x0002733B
			public AverageOperand(bool aboveAverage) : base(aboveAverage ? "AboveAverage" : "BelowAverage")
			{
				this._aboveAverage = aboveAverage;
			}

			// Token: 0x06000C6D RID: 3181 RVA: 0x00029159 File Offset: 0x00027359
			public override bool SupportsDataType(global::System.Type type)
			{
				return global::Infragistics.Windows.Utilities.IsNumericType(global::Infragistics.CoreUtilities.GetUnderlyingType(type));
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x00029166 File Offset: 0x00027366
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				return comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals || global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator;
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x00029174 File Offset: 0x00027374
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object valueObj, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
				{
					double currentValueAsDouble = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand.GetCurrentValueAsDouble(valueObj, context);
					if (!double.IsNaN(currentValueAsDouble))
					{
						double average = this.GetAverage(context);
						if (double.IsNaN(average))
						{
							return false;
						}
						if (!this._aboveAverage)
						{
							return currentValueAsDouble < average;
						}
						return currentValueAsDouble > average;
					}
				}
				else if (global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator)
				{
					return !this.IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, valueObj, context);
				}
				return false;
			}

			// Token: 0x1700022E RID: 558
			// (get) Token: 0x06000C70 RID: 3184 RVA: 0x000291CA File Offset: 0x000273CA
			public override bool UsesAllValues
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000C71 RID: 3185 RVA: 0x000291D0 File Offset: 0x000273D0
			private double GetAverage(global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				object type = base.GetType();
				object userCache = context.GetUserCache(type);
				if (userCache != null)
				{
					return (double)userCache;
				}
				int num = 0;
				double num2 = 0.0;
				foreach (global::Infragistics.Windows.Controls.ValueEntry valueEntry in context.AllValues)
				{
					double valueAsDouble = valueEntry.ValueAsDouble;
					if (!double.IsNaN(valueAsDouble) && !double.IsInfinity(valueAsDouble))
					{
						num2 += valueAsDouble;
						num++;
					}
				}
				double num3 = (num > 0) ? (num2 / (double)num) : double.NaN;
				context.SetUserCache(type, num3);
				return num3;
			}

			// Token: 0x040005E6 RID: 1510
			internal const string NAME_AboveAverage = "AboveAverage";

			// Token: 0x040005E7 RID: 1511
			internal const string NAME_BelowAverage = "BelowAverage";

			// Token: 0x040005E8 RID: 1512
			private bool _aboveAverage;

			// Token: 0x0200016E RID: 366
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x1700022F RID: 559
				// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0002928C File Offset: 0x0002748C
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(bool), "AboveAverage")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000C73 RID: 3187 RVA: 0x000292CC File Offset: 0x000274CC
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand averageOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["AboveAverage"] = averageOperand._aboveAverage;
					return dictionary;
				}

				// Token: 0x06000C74 RID: 3188 RVA: 0x00029300 File Offset: 0x00027500
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					bool aboveAverage = false;
					object obj;
					if (values.TryGetValue("AboveAverage", out obj))
					{
						aboveAverage = (bool)obj;
					}
					return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand(aboveAverage);
				}

				// Token: 0x040005E9 RID: 1513
				private const string AboveAverageProp = "AboveAverage";

				// Token: 0x040005EA RID: 1514
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x0200016F RID: 367
		internal class TopValuesOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000C76 RID: 3190 RVA: 0x00029334 File Offset: 0x00027534
			public TopValuesOperand(string name, double topNumber, bool percentage, bool ascendingOrder) : base(name, percentage ? (ascendingOrder ? "TopPercentile" : "BottomPercentile") : (ascendingOrder ? "Top" : "Bottom"))
			{
				global::System.Exception ex;
				if (!global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.ValidateParams(topNumber, percentage, ascendingOrder, out ex))
				{
					throw ex;
				}
				this._topNumber = topNumber;
				this._percentage = percentage;
				this._ascendingOrder = ascendingOrder;
			}

			// Token: 0x06000C77 RID: 3191 RVA: 0x00029394 File Offset: 0x00027594
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand topValuesOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand;
				return topValuesOperand != null && base.EqualsOverride(topValuesOperand) && this._ascendingOrder == topValuesOperand._ascendingOrder && this._percentage == topValuesOperand._percentage && this._topNumber == topValuesOperand._topNumber;
			}

			// Token: 0x06000C78 RID: 3192 RVA: 0x000293E0 File Offset: 0x000275E0
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this._ascendingOrder.GetHashCode() ^ this._percentage.GetHashCode() ^ this._topNumber.GetHashCode();
			}

			// Token: 0x06000C79 RID: 3193 RVA: 0x0002940C File Offset: 0x0002760C
			public override bool SupportsDataType(global::System.Type type)
			{
				type = global::Infragistics.CoreUtilities.GetUnderlyingType(type);
				return global::Infragistics.Windows.Utilities.IsNumericType(type) || typeof(global::System.DateTime) == type;
			}

			// Token: 0x06000C7A RID: 3194 RVA: 0x00029430 File Offset: 0x00027630
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				return comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals || global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator;
			}

			// Token: 0x06000C7B RID: 3195 RVA: 0x0002943C File Offset: 0x0002763C
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (comparisonOperator != global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
				{
					return global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator && !this.IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, value, context);
				}
				object maxValidValue = this.GetMaxValidValue(context);
				if (maxValidValue is double)
				{
					double num = (double)maxValidValue;
					double doubleHelper = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.GetDoubleHelper(value, context);
					if (double.IsNaN(num) || double.IsNaN(doubleHelper))
					{
						return false;
					}
					if (!this._ascendingOrder)
					{
						return doubleHelper <= num;
					}
					return doubleHelper >= num;
				}
				else
				{
					global::System.Collections.IComparer comparer = context.Comparer ?? global::System.Collections.Generic.Comparer<object>.Default;
					if (maxValidValue == null || value == null)
					{
						return false;
					}
					int num2 = comparer.Compare(value, maxValidValue);
					if (!this._ascendingOrder)
					{
						return num2 <= 0;
					}
					return num2 >= 0;
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06000C7C RID: 3196 RVA: 0x000294E6 File Offset: 0x000276E6
			public override bool UsesAllValues
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000294EC File Offset: 0x000276EC
			protected override object[] ValueArgumentsForStrings
			{
				get
				{
					return new object[]
					{
						this._topNumber
					};
				}
			}

			// Token: 0x06000C7E RID: 3198 RVA: 0x00029510 File Offset: 0x00027710
			internal static void ClearUserCacheHelper(global::Infragistics.Windows.Controls.SpecialFilterOperandBase topValuesOperand, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand topValuesOperand2 = topValuesOperand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand;
				if (topValuesOperand2 != null)
				{
					context.SetUserCache(topValuesOperand2, null);
				}
			}

			// Token: 0x06000C7F RID: 3199 RVA: 0x0002952F File Offset: 0x0002772F
			internal static global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand CreateHelper(string name, double topNumber, bool percentage, bool ascendingOrder, out global::System.Exception error)
			{
				if (!global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.ValidateParams(topNumber, percentage, ascendingOrder, out error))
				{
					return null;
				}
				return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand(name, topNumber, percentage, ascendingOrder);
			}

			// Token: 0x06000C80 RID: 3200 RVA: 0x00029548 File Offset: 0x00027748
			private static double DateTimeToDouble(global::System.DateTime value)
			{
				return (double)value.Ticks;
			}

			// Token: 0x06000C81 RID: 3201 RVA: 0x00029554 File Offset: 0x00027754
			private global::System.Collections.IList GetAllValues(global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				global::System.Type preferredComparisonDataType = context.PreferredComparisonDataType;
				bool flag = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.IsNumericOrDateTime(preferredComparisonDataType);
				global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
				foreach (global::Infragistics.Windows.Controls.ValueEntry valueEntry in context.AllValues)
				{
					double doubleHelper = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.GetDoubleHelper(valueEntry, context);
					if (!double.IsNaN(doubleHelper) && !double.IsInfinity(doubleHelper))
					{
						list.Add(doubleHelper);
					}
					else if (!flag && !global::Infragistics.CoreUtilities.IsValueEmpty(valueEntry.Value) && (null == preferredComparisonDataType || !global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.IsNumericOrDateTime(valueEntry.Value.GetType())))
					{
						list = null;
						break;
					}
				}
				global::System.Collections.Generic.List<object> list2 = null;
				if (list == null)
				{
					list2 = new global::System.Collections.Generic.List<object>();
					foreach (global::Infragistics.Windows.Controls.ValueEntry valueEntry2 in context.AllValues)
					{
						list2.Add(valueEntry2.Value);
					}
				}
				return list ?? list2;
			}

			// Token: 0x06000C82 RID: 3202 RVA: 0x00029664 File Offset: 0x00027864
			private static double GetDoubleHelper(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (value is global::System.DateTime)
				{
					return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.DateTimeToDouble((global::System.DateTime)value);
				}
				return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand.GetCurrentValueAsDouble(value, context);
			}

			// Token: 0x06000C83 RID: 3203 RVA: 0x00029684 File Offset: 0x00027884
			private static double GetDoubleHelper(global::Infragistics.Windows.Controls.ValueEntry ii, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				object value = ii.Value;
				double result;
				if (value is global::System.DateTime)
				{
					result = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.DateTimeToDouble((global::System.DateTime)value);
				}
				else
				{
					result = ii.GetValueAsDouble(context);
				}
				return result;
			}

			// Token: 0x06000C84 RID: 3204 RVA: 0x000296B8 File Offset: 0x000278B8
			private object GetMaxValidValue(global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				object obj = context.GetUserCache(this);
				if (obj == null)
				{
					global::System.Collections.IList allValues = this.GetAllValues(context);
					obj = double.NaN;
					if (allValues.Count > 0 && this._topNumber > 0.0)
					{
						if (allValues is global::System.Collections.Generic.List<double>)
						{
							global::Infragistics.CoreUtilities.SortMergeGeneric<double>((global::System.Collections.Generic.List<double>)allValues, global::System.Collections.Generic.Comparer<double>.Default);
						}
						else
						{
							global::Infragistics.CoreUtilities.SortMergeGeneric<object>((global::System.Collections.Generic.List<object>)allValues, global::Infragistics.CoreUtilities.CreateComparer<object>(context.Comparer ?? global::System.Collections.Generic.Comparer<object>.Default));
						}
						int num;
						if (this._percentage)
						{
							num = global::System.Math.Max(1, (int)(this._topNumber / 100.0 * (double)allValues.Count)) - 1;
						}
						else
						{
							num = (int)this._topNumber - 1;
						}
						if (num >= 0)
						{
							num = global::System.Math.Min(num, allValues.Count - 1);
							obj = ((!this._ascendingOrder) ? allValues[num] : allValues[allValues.Count - 1 - num]);
						}
					}
					context.SetUserCache(this, obj);
				}
				return obj;
			}

			// Token: 0x06000C85 RID: 3205 RVA: 0x000297B7 File Offset: 0x000279B7
			private static bool IsNumericOrDateTime(global::System.Type type)
			{
				return null != type && (global::Infragistics.Windows.Utilities.IsNumericType(type) || typeof(global::System.DateTime) == type);
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x000297E0 File Offset: 0x000279E0
			internal static bool ValidateParams(double topNumber, bool percentage, bool ascendingOrder, out global::System.Exception error)
			{
				error = null;
				if (double.IsNaN(topNumber))
				{
					error = new global::System.ArgumentOutOfRangeException("topNumber", global::SR.GetString("Filter_TopOperand_InvalidValue_NaN"));
				}
				else if (topNumber < 0.0)
				{
					error = new global::System.ArgumentOutOfRangeException("topNumber", global::SR.GetString("Filter_TopOperand_InvalidValue_LessThanZero"));
				}
				else if (percentage && topNumber > 100.0)
				{
					error = new global::System.ArgumentOutOfRangeException("topNumber", global::SR.GetString("Filter_TopOperand_InvalidValue_GreaterThan100Percent"));
				}
				return null == error;
			}

			// Token: 0x040005EB RID: 1515
			private double _topNumber;

			// Token: 0x040005EC RID: 1516
			private bool _percentage;

			// Token: 0x040005ED RID: 1517
			private bool _ascendingOrder;

			// Token: 0x02000170 RID: 368
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000232 RID: 562
				// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00029860 File Offset: 0x00027A60
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Name"),
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(double), "TopNumber"),
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(bool), "Percentage"),
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(bool), "AscendingOrder")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000C88 RID: 3208 RVA: 0x000298E8 File Offset: 0x00027AE8
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand topValuesOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = topValuesOperand.Name;
					dictionary["TopNumber"] = topValuesOperand._topNumber;
					dictionary["Percentage"] = topValuesOperand._percentage;
					dictionary["AscendingOrder"] = topValuesOperand._ascendingOrder;
					return dictionary;
				}

				// Token: 0x06000C89 RID: 3209 RVA: 0x00029958 File Offset: 0x00027B58
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					object obj;
					object obj2;
					object obj3;
					object obj4;
					if (values.TryGetValue("Name", out obj) && values.TryGetValue("TopNumber", out obj2) && values.TryGetValue("Percentage", out obj3) && values.TryGetValue("AscendingOrder", out obj4))
					{
						return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand((string)obj, (double)obj2, (bool)obj3, (bool)obj4);
					}
					return null;
				}

				// Token: 0x040005EE RID: 1518
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x02000171 RID: 369
		internal class DateOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000C8B RID: 3211 RVA: 0x000299C8 File Offset: 0x00027BC8
			public DateOperand(string name, string resourceName) : base(name, resourceName)
			{
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x000299D2 File Offset: 0x00027BD2
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				return base.IsMatch(comparisonOperator, value, context) && value != null && value != global::System.DBNull.Value && !(global::Infragistics.CoreUtilities.GetUnderlyingType(value.GetType()) != typeof(global::System.DateTime));
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x00029A0B File Offset: 0x00027C0B
			public override bool SupportsDataType(global::System.Type dataType)
			{
				return global::Infragistics.CoreUtilities.GetUnderlyingType(dataType) == typeof(global::System.DateTime);
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x00029A24 File Offset: 0x00027C24
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				switch (comparisonOperator)
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
		}

		// Token: 0x02000172 RID: 370
		internal class RelativeDateOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateOperand
		{
			// Token: 0x06000C8F RID: 3215 RVA: 0x00029A56 File Offset: 0x00027C56
			public RelativeDateOperand(string name, global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate relativeDate) : base(name, name)
			{
				this.relativeDate = relativeDate;
			}

			// Token: 0x06000C90 RID: 3216 RVA: 0x00029A68 File Offset: 0x00027C68
			private static void CalculateQuarterRange(global::System.DateTime dateInQuarter, ref global::System.DateTime cachedStart, ref global::System.DateTime cachedEnd)
			{
				if (dateInQuarter.Month < 4)
				{
					cachedStart = new global::System.DateTime(dateInQuarter.Year, 1, 1);
					cachedEnd = new global::System.DateTime(dateInQuarter.Year, 3, global::System.DateTime.DaysInMonth(dateInQuarter.Year, 3));
					return;
				}
				if (dateInQuarter.Month < 7)
				{
					cachedStart = new global::System.DateTime(dateInQuarter.Year, 4, 1);
					cachedEnd = new global::System.DateTime(dateInQuarter.Year, 6, global::System.DateTime.DaysInMonth(dateInQuarter.Year, 6));
					return;
				}
				if (dateInQuarter.Month < 10)
				{
					cachedStart = new global::System.DateTime(dateInQuarter.Year, 7, 1);
					cachedEnd = new global::System.DateTime(dateInQuarter.Year, 9, global::System.DateTime.DaysInMonth(dateInQuarter.Year, 9));
					return;
				}
				cachedStart = new global::System.DateTime(dateInQuarter.Year, 10, 1);
				cachedEnd = new global::System.DateTime(dateInQuarter.Year, 12, global::System.DateTime.DaysInMonth(dateInQuarter.Year, 12));
			}

			// Token: 0x06000C91 RID: 3217 RVA: 0x00029B6C File Offset: 0x00027D6C
			private static bool MatchHelper(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, global::System.DateTime rangeStart, global::System.DateTime rangeEnd, global::System.DateTime comparisonValue)
			{
				switch (comparisonOperator)
				{
				case global::Infragistics.Windows.Controls.ComparisonOperator.Equals:
					return rangeStart <= comparisonValue && rangeEnd >= comparisonValue;
				case global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals:
					return !global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.MatchHelper(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, rangeStart, rangeEnd, comparisonValue);
				case global::Infragistics.Windows.Controls.ComparisonOperator.LessThan:
					return comparisonValue < rangeStart;
				case global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo:
					return comparisonValue < rangeStart || global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.MatchHelper(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, rangeStart, rangeEnd, comparisonValue);
				case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThan:
					return comparisonValue > rangeEnd;
				case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo:
					return comparisonValue > rangeEnd || global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.MatchHelper(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, rangeStart, rangeEnd, comparisonValue);
				default:
					return false;
				}
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x00029BF6 File Offset: 0x00027DF6
			private void ResetCurrentDate()
			{
				this.useCustomCurrentDate = false;
				this.cachedCurrentDate = global::System.DateTime.MinValue;
			}

			// Token: 0x06000C93 RID: 3219 RVA: 0x00029C0A File Offset: 0x00027E0A
			private void SetCurrentDate(global::System.DateTime currentDate)
			{
				this.useCustomCurrentDate = true;
				this.customCurrentDate = currentDate;
			}

			// Token: 0x06000C94 RID: 3220 RVA: 0x00029C1C File Offset: 0x00027E1C
			private void VerifyCache(global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				global::System.Globalization.CultureInfo cultureInfo = ((context != null && context.CurrentValue != null) ? context.CurrentValue.Culture : null) ?? global::System.Globalization.CultureInfo.CurrentCulture;
				if (this.cachedCurrentDate == (this.useCustomCurrentDate ? this.customCurrentDate : global::System.DateTime.Today) && cultureInfo == this.cachedCurrentCulture)
				{
					return;
				}
				if (this.useCustomCurrentDate)
				{
					this.cachedCurrentDate = this.customCurrentDate;
				}
				else
				{
					this.cachedCurrentDate = global::System.DateTime.Today;
				}
				this.cachedCurrentCulture = cultureInfo;
				switch (this.relativeDate)
				{
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.Tomorrow:
					this.cachedStart = (this.cachedEnd = this.cachedCurrentDate.AddDays(1.0));
					return;
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.Today:
					this.cachedStart = (this.cachedEnd = this.cachedCurrentDate);
					return;
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.Yesterday:
					this.cachedStart = (this.cachedEnd = this.cachedCurrentDate.AddDays(-1.0));
					return;
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextWeek:
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.ThisWeek:
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastWeek:
				{
					global::System.DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
					int num = (this.cachedCurrentDate.DayOfWeek - firstDayOfWeek + 7) % 7;
					global::System.DateTime dateTime = this.cachedCurrentDate.AddDays((double)(-(double)num));
					if (this.relativeDate == global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastWeek)
					{
						this.cachedStart = dateTime.AddDays(-7.0);
					}
					else if (this.relativeDate == global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextWeek)
					{
						this.cachedStart = dateTime.AddDays(7.0);
					}
					else
					{
						this.cachedStart = dateTime;
					}
					this.cachedEnd = this.cachedStart.AddDays(6.0);
					return;
				}
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextMonth:
				{
					global::System.DateTime dateTime2 = this.cachedCurrentDate.AddMonths(1);
					this.cachedStart = new global::System.DateTime(dateTime2.Year, dateTime2.Month, 1);
					this.cachedEnd = new global::System.DateTime(dateTime2.Year, dateTime2.Month, global::System.DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month));
					return;
				}
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.ThisMonth:
				{
					global::System.DateTime dateTime3 = this.cachedCurrentDate;
					this.cachedStart = new global::System.DateTime(dateTime3.Year, dateTime3.Month, 1);
					this.cachedEnd = new global::System.DateTime(dateTime3.Year, dateTime3.Month, global::System.DateTime.DaysInMonth(dateTime3.Year, dateTime3.Month));
					return;
				}
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastMonth:
				{
					global::System.DateTime dateTime4 = this.cachedCurrentDate.AddMonths(-1);
					this.cachedStart = new global::System.DateTime(dateTime4.Year, dateTime4.Month, 1);
					this.cachedEnd = new global::System.DateTime(dateTime4.Year, dateTime4.Month, global::System.DateTime.DaysInMonth(dateTime4.Year, dateTime4.Month));
					return;
				}
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextQuarter:
				{
					global::System.DateTime dateInQuarter = this.cachedCurrentDate.AddMonths(3);
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.CalculateQuarterRange(dateInQuarter, ref this.cachedStart, ref this.cachedEnd);
					return;
				}
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.ThisQuarter:
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.CalculateQuarterRange(this.cachedCurrentDate, ref this.cachedStart, ref this.cachedEnd);
					return;
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastQuarter:
				{
					global::System.DateTime dateInQuarter2 = this.cachedCurrentDate.AddMonths(-3);
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.CalculateQuarterRange(dateInQuarter2, ref this.cachedStart, ref this.cachedEnd);
					return;
				}
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.NextYear:
				{
					global::System.DateTime dateTime5 = this.cachedCurrentDate.AddYears(1);
					this.cachedStart = new global::System.DateTime(dateTime5.Year, 1, 1);
					this.cachedEnd = new global::System.DateTime(dateTime5.Year, 12, global::System.DateTime.DaysInMonth(dateTime5.Year, 12));
					return;
				}
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.ThisYear:
					this.cachedStart = new global::System.DateTime(this.cachedCurrentDate.Year, 1, 1);
					this.cachedEnd = new global::System.DateTime(this.cachedCurrentDate.Year, 12, global::System.DateTime.DaysInMonth(this.cachedCurrentDate.Year, 12));
					return;
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.LastYear:
				{
					global::System.DateTime dateTime6 = this.cachedCurrentDate.AddYears(-1);
					this.cachedStart = new global::System.DateTime(dateTime6.Year, 1, 1);
					this.cachedEnd = new global::System.DateTime(dateTime6.Year, 12, global::System.DateTime.DaysInMonth(dateTime6.Year, 12));
					return;
				}
				case global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate.YearToDate:
					this.cachedStart = new global::System.DateTime(this.cachedCurrentDate.Year, 1, 1);
					this.cachedEnd = this.cachedCurrentDate;
					return;
				default:
					this.cachedStart = global::System.DateTime.MaxValue;
					this.cachedEnd = global::System.DateTime.MinValue;
					return;
				}
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x0002A048 File Offset: 0x00028248
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand relativeDateOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand;
				return relativeDateOperand != null && base.EqualsOverride(relativeDateOperand) && this.relativeDate == relativeDateOperand.relativeDate;
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x0002A078 File Offset: 0x00028278
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this.relativeDate.GetHashCode();
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x0002A094 File Offset: 0x00028294
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (!base.IsMatch(comparisonOperator, value, context))
				{
					return false;
				}
				this.VerifyCache(context);
				global::System.DateTime date = ((global::System.DateTime)value).Date;
				return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.MatchHelper(comparisonOperator, this.cachedStart, this.cachedEnd, date);
			}

			// Token: 0x040005EF RID: 1519
			private bool useCustomCurrentDate;

			// Token: 0x040005F0 RID: 1520
			private global::System.DateTime customCurrentDate;

			// Token: 0x040005F1 RID: 1521
			private global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate relativeDate;

			// Token: 0x040005F2 RID: 1522
			private global::System.DateTime cachedCurrentDate;

			// Token: 0x040005F3 RID: 1523
			private global::System.DateTime cachedStart;

			// Token: 0x040005F4 RID: 1524
			private global::System.DateTime cachedEnd;

			// Token: 0x040005F5 RID: 1525
			private global::System.Globalization.CultureInfo cachedCurrentCulture;

			// Token: 0x02000173 RID: 371
			internal enum RelativeDate
			{
				// Token: 0x040005F7 RID: 1527
				Tomorrow,
				// Token: 0x040005F8 RID: 1528
				Today,
				// Token: 0x040005F9 RID: 1529
				Yesterday,
				// Token: 0x040005FA RID: 1530
				NextWeek,
				// Token: 0x040005FB RID: 1531
				ThisWeek,
				// Token: 0x040005FC RID: 1532
				LastWeek,
				// Token: 0x040005FD RID: 1533
				NextMonth,
				// Token: 0x040005FE RID: 1534
				ThisMonth,
				// Token: 0x040005FF RID: 1535
				LastMonth,
				// Token: 0x04000600 RID: 1536
				NextQuarter,
				// Token: 0x04000601 RID: 1537
				ThisQuarter,
				// Token: 0x04000602 RID: 1538
				LastQuarter,
				// Token: 0x04000603 RID: 1539
				NextYear,
				// Token: 0x04000604 RID: 1540
				ThisYear,
				// Token: 0x04000605 RID: 1541
				LastYear,
				// Token: 0x04000606 RID: 1542
				YearToDate
			}

			// Token: 0x02000174 RID: 372
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000233 RID: 563
				// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0002A0D8 File Offset: 0x000282D8
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Name"),
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate), "RelativeDate")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000C99 RID: 3225 RVA: 0x0002A130 File Offset: 0x00028330
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand relativeDateOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = relativeDateOperand.Name;
					dictionary["RelativeDate"] = relativeDateOperand.relativeDate;
					return dictionary;
				}

				// Token: 0x06000C9A RID: 3226 RVA: 0x0002A174 File Offset: 0x00028374
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					object obj;
					object obj2;
					if (values.TryGetValue("Name", out obj) && values.TryGetValue("RelativeDate", out obj2))
					{
						return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand((string)obj, (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate)obj2);
					}
					return null;
				}

				// Token: 0x04000607 RID: 1543
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x02000175 RID: 373
		internal class MonthOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateOperand
		{
			// Token: 0x06000C9C RID: 3228 RVA: 0x0002A1BA File Offset: 0x000283BA
			public MonthOperand(string name, short month) : base(name, "Month")
			{
				if (month < 1 || month > 12)
				{
					throw new global::System.ArgumentOutOfRangeException();
				}
				this.month = month;
			}

			// Token: 0x06000C9D RID: 3229 RVA: 0x0002A1E0 File Offset: 0x000283E0
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand monthOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand;
				return monthOperand != null && base.EqualsOverride(monthOperand) && this.month == monthOperand.month;
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x0002A210 File Offset: 0x00028410
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this.month.GetHashCode();
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x0002A224 File Offset: 0x00028424
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (!base.IsMatch(comparisonOperator, value, context))
				{
					return false;
				}
				int num = ((global::System.DateTime)value).Month;
				switch (comparisonOperator)
				{
				case global::Infragistics.Windows.Controls.ComparisonOperator.Equals:
					return (int)this.month == num;
				case global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals:
					return (int)this.month != num;
				case global::Infragistics.Windows.Controls.ComparisonOperator.LessThan:
					return num < (int)this.month;
				case global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo:
					return num <= (int)this.month;
				case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThan:
					return num > (int)this.month;
				case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo:
					return num >= (int)this.month;
				default:
					return false;
				}
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0002A2B8 File Offset: 0x000284B8
			protected override object[] ValueArgumentsForStrings
			{
				get
				{
					return new object[]
					{
						new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand.FormattedMonthName(this)
					};
				}
			}

			// Token: 0x04000608 RID: 1544
			private short month;

			// Token: 0x02000176 RID: 374
			private class FormattedMonthName : global::System.IFormattable
			{
				// Token: 0x06000CA1 RID: 3233 RVA: 0x0002A2D6 File Offset: 0x000284D6
				internal FormattedMonthName(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand operand)
				{
					this._operand = operand;
				}

				// Token: 0x06000CA2 RID: 3234 RVA: 0x0002A2E8 File Offset: 0x000284E8
				public string ToString(string format, global::System.IFormatProvider formatProvider)
				{
					string result;
					try
					{
						global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::System.Globalization.DateTimeFormatInfo.GetInstance(formatProvider);
						if (dateTimeFormatInfo == null)
						{
							dateTimeFormatInfo = global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
						}
						result = dateTimeFormatInfo.GetMonthName((int)this._operand.month);
					}
					catch
					{
						result = this._operand.month.ToString();
					}
					return result;
				}

				// Token: 0x04000609 RID: 1545
				private global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand _operand;
			}

			// Token: 0x02000177 RID: 375
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000235 RID: 565
				// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0002A344 File Offset: 0x00028544
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Name"),
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(short), "Month")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000CA4 RID: 3236 RVA: 0x0002A39C File Offset: 0x0002859C
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand monthOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = monthOperand.Name;
					dictionary["Month"] = monthOperand.month;
					return dictionary;
				}

				// Token: 0x06000CA5 RID: 3237 RVA: 0x0002A3E0 File Offset: 0x000285E0
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					object obj;
					object obj2;
					if (values.TryGetValue("Name", out obj) && values.TryGetValue("Month", out obj2))
					{
						return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand((string)obj, (short)obj2);
					}
					return null;
				}

				// Token: 0x0400060A RID: 1546
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x02000178 RID: 376
		internal class QuarterOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateOperand
		{
			// Token: 0x06000CA7 RID: 3239 RVA: 0x0002A426 File Offset: 0x00028626
			public QuarterOperand(string name, short quarter) : base(name, "Quarter")
			{
				if (quarter < 1 || quarter > 4)
				{
					throw new global::System.ArgumentOutOfRangeException();
				}
				this.quarter = quarter;
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x0002A44C File Offset: 0x0002864C
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand quarterOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand;
				return quarterOperand != null && base.EqualsOverride(quarterOperand) && this.quarter == quarterOperand.quarter;
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x0002A47C File Offset: 0x0002867C
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this.quarter.GetHashCode();
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x0002A490 File Offset: 0x00028690
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (!base.IsMatch(comparisonOperator, value, context))
				{
					return false;
				}
				int num = (int)global::System.Math.Ceiling((double)((global::System.DateTime)value).Month / 3.0);
				switch (comparisonOperator)
				{
				case global::Infragistics.Windows.Controls.ComparisonOperator.Equals:
					return num == (int)this.quarter;
				case global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals:
					return num != (int)this.quarter;
				case global::Infragistics.Windows.Controls.ComparisonOperator.LessThan:
					return num < (int)this.quarter;
				case global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo:
					return num <= (int)this.quarter;
				case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThan:
					return num > (int)this.quarter;
				case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo:
					return num >= (int)this.quarter;
				default:
					return false;
				}
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0002A534 File Offset: 0x00028734
			protected override object[] ValueArgumentsForStrings
			{
				get
				{
					return new object[]
					{
						this.quarter
					};
				}
			}

			// Token: 0x0400060B RID: 1547
			private short quarter;

			// Token: 0x02000179 RID: 377
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000237 RID: 567
				// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0002A558 File Offset: 0x00028758
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Name"),
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(short), "Quarter")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000CAD RID: 3245 RVA: 0x0002A5B0 File Offset: 0x000287B0
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand quarterOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = quarterOperand.Name;
					dictionary["Quarter"] = quarterOperand.quarter;
					return dictionary;
				}

				// Token: 0x06000CAE RID: 3246 RVA: 0x0002A5F4 File Offset: 0x000287F4
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					object obj;
					object obj2;
					if (values.TryGetValue("Name", out obj) && values.TryGetValue("Quarter", out obj2))
					{
						return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand((string)obj, (short)obj2);
					}
					return null;
				}

				// Token: 0x0400060C RID: 1548
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x0200017A RID: 378
		internal class DateRangeOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateOperand
		{
			// Token: 0x06000CB0 RID: 3248 RVA: 0x0002A63A File Offset: 0x0002883A
			public DateRangeOperand(global::System.DateTime relativeDate, global::Infragistics.Windows.Controls.DateRangeScope scope) : base(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetName(relativeDate, scope), global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetResourceName(scope))
			{
				this._relativeDate = relativeDate;
				this._scope = scope;
				this._cachedDateRange = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.CalculateRange(relativeDate, scope);
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0002A66A File Offset: 0x0002886A
			private static global::System.Globalization.Calendar Calendar
			{
				get
				{
					return global::System.Globalization.CultureInfo.InvariantCulture.Calendar;
				}
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x0002A678 File Offset: 0x00028878
			private static global::Infragistics.DateRange CalculateRange(global::System.DateTime relativeDate, global::Infragistics.Windows.Controls.DateRangeScope scope)
			{
				int year = relativeDate.Year;
				int month = relativeDate.Month;
				int day = relativeDate.Day;
				int hour = relativeDate.Hour;
				int minute = relativeDate.Minute;
				int second = relativeDate.Second;
				switch (scope)
				{
				case global::Infragistics.Windows.Controls.DateRangeScope.Year:
					day = (month = 1);
					minute = (hour = (second = 0));
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Month:
					day = 1;
					minute = (hour = (second = 0));
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Day:
					minute = (hour = (second = 0));
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Hour:
					second = (minute = 0);
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Minute:
					second = 0;
					break;
				}
				global::System.DateTime date = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetDate(year, month, day, hour, minute, second, true);
				global::System.DateTime endDate = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetEndDate(scope, year, month, day, hour, minute, second);
				return new global::Infragistics.DateRange(date, endDate);
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x0002A730 File Offset: 0x00028930
			private static global::System.DateTime GetDate(int year, int month, int day, int hour, int minute, int second, bool isStart)
			{
				global::System.Globalization.Calendar calendar = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.Calendar;
				global::System.DateTime result;
				try
				{
					result = calendar.ToDateTime(year, month, day, hour, minute, second, 0);
				}
				catch (global::System.ArgumentOutOfRangeException)
				{
					result = (isStart ? calendar.MinSupportedDateTime : calendar.MaxSupportedDateTime);
				}
				return result;
			}

			// Token: 0x06000CB4 RID: 3252 RVA: 0x0002A77C File Offset: 0x0002897C
			private static global::System.DateTime GetEndDate(global::Infragistics.Windows.Controls.DateRangeScope scope, int year, int month, int day, int hour, int minute, int second)
			{
				switch (scope)
				{
				case global::Infragistics.Windows.Controls.DateRangeScope.Year:
					year++;
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Month:
					if (month == 12)
					{
						return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetEndDate(global::Infragistics.Windows.Controls.DateRangeScope.Year, year, 1, day, hour, minute, second);
					}
					month++;
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Day:
					if (day == global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.Calendar.GetDaysInMonth(year, month))
					{
						return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetEndDate(global::Infragistics.Windows.Controls.DateRangeScope.Month, year, month, 1, hour, minute, second);
					}
					day++;
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Hour:
					if (hour == 23)
					{
						return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetEndDate(global::Infragistics.Windows.Controls.DateRangeScope.Day, year, month, day, 0, minute, second);
					}
					hour++;
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Minute:
					if (minute == 59)
					{
						return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetEndDate(global::Infragistics.Windows.Controls.DateRangeScope.Hour, year, month, day, hour, 0, second);
					}
					minute++;
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Second:
					if (second == 59)
					{
						return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetEndDate(global::Infragistics.Windows.Controls.DateRangeScope.Minute, year, month, day, hour, minute, 0);
					}
					second++;
					break;
				}
				return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetDate(year, month, day, hour, minute, second, false);
			}

			// Token: 0x06000CB5 RID: 3253 RVA: 0x0002A860 File Offset: 0x00028A60
			private static string GetName(global::System.DateTime relativeDate, global::Infragistics.Windows.Controls.DateRangeScope scope)
			{
				global::System.Globalization.CultureInfo invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
				string format;
				switch (scope)
				{
				case global::Infragistics.Windows.Controls.DateRangeScope.Year:
					format = "DateRange {0:yyyy}";
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Month:
					format = "DateRange {0:yyyy}-{0:MM}";
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Day:
					format = "DateRange {0:yyyy}-{0:MM}-{0:dd}";
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Hour:
					format = "DateRange {0:yyyy}-{0:MM}-{0:dd} {0:HH}";
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Minute:
					format = "DateRange {0:yyyy}-{0:MM}-{0:dd} {0:HH}:{0:mm}";
					break;
				case global::Infragistics.Windows.Controls.DateRangeScope.Second:
					format = "DateRange {0:yyyy}-{0:MM}-{0:dd} {0:HH}:{0:mm}:{0:ss}";
					break;
				default:
					return "DateRange";
				}
				return string.Format(invariantCulture, format, new object[]
				{
					relativeDate
				});
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x0002A8E4 File Offset: 0x00028AE4
			private static string GetResourceName(global::Infragistics.Windows.Controls.DateRangeScope scope)
			{
				switch (scope)
				{
				case global::Infragistics.Windows.Controls.DateRangeScope.Year:
					return "DateRange_Year";
				case global::Infragistics.Windows.Controls.DateRangeScope.Month:
					return "DateRange_Month";
				case global::Infragistics.Windows.Controls.DateRangeScope.Day:
					return "DateRange_Day";
				case global::Infragistics.Windows.Controls.DateRangeScope.Hour:
					return "DateRange_Hour";
				case global::Infragistics.Windows.Controls.DateRangeScope.Minute:
					return "DateRange_Minute";
				case global::Infragistics.Windows.Controls.DateRangeScope.Second:
					return "DateRange_Second";
				default:
					return "DateRange";
				}
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x0002A93C File Offset: 0x00028B3C
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand dateRangeOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand;
				return dateRangeOperand != null && this._scope == dateRangeOperand._scope && base.EqualsOverride(dateRangeOperand);
			}

			// Token: 0x06000CB8 RID: 3256 RVA: 0x0002A96A File Offset: 0x00028B6A
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this._scope.GetHashCode();
			}

			// Token: 0x06000CB9 RID: 3257 RVA: 0x0002A984 File Offset: 0x00028B84
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (!base.IsMatch(comparisonOperator, value, context))
				{
					return false;
				}
				global::System.DateTime dateTime = (global::System.DateTime)value;
				switch (comparisonOperator)
				{
				case global::Infragistics.Windows.Controls.ComparisonOperator.Equals:
					return this._cachedDateRange.ContainsExclusive(dateTime);
				case global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals:
					return !this._cachedDateRange.ContainsExclusive(dateTime);
				case global::Infragistics.Windows.Controls.ComparisonOperator.LessThan:
					return dateTime < this._cachedDateRange.Start;
				case global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo:
					return dateTime < this._cachedDateRange.End;
				case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThan:
					return dateTime >= this._cachedDateRange.End;
				case global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo:
					return dateTime >= this._cachedDateRange.Start;
				default:
					return false;
				}
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0002AA30 File Offset: 0x00028C30
			protected override object[] ValueArgumentsForStrings
			{
				get
				{
					return new object[]
					{
						this._relativeDate
					};
				}
			}

			// Token: 0x0400060D RID: 1549
			private global::System.DateTime _relativeDate;

			// Token: 0x0400060E RID: 1550
			private global::Infragistics.Windows.Controls.DateRangeScope _scope;

			// Token: 0x0400060F RID: 1551
			private global::Infragistics.DateRange _cachedDateRange;

			// Token: 0x0200017B RID: 379
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x1700023A RID: 570
				// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0002AA54 File Offset: 0x00028C54
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(global::Infragistics.Windows.Controls.DateRangeScope), "Scope"),
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(global::System.DateTime), "RelativeDate")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000CBC RID: 3260 RVA: 0x0002AAAC File Offset: 0x00028CAC
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand dateRangeOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Scope"] = dateRangeOperand._scope;
					dictionary["RelativeDate"] = dateRangeOperand._relativeDate;
					return dictionary;
				}

				// Token: 0x06000CBD RID: 3261 RVA: 0x0002AAF4 File Offset: 0x00028CF4
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					object obj;
					object obj2;
					if (values.TryGetValue("Scope", out obj) && values.TryGetValue("RelativeDate", out obj2))
					{
						return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand((global::System.DateTime)obj2, (global::Infragistics.Windows.Controls.DateRangeScope)obj);
					}
					return null;
				}

				// Token: 0x04000610 RID: 1552
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x0200017C RID: 380
		internal class InOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000CBF RID: 3263 RVA: 0x0002AB3A File Offset: 0x00028D3A
			public InOperand(global::System.Collections.IEnumerable items) : base("In")
			{
				this._items = (items ?? new object[0]);
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x0002AB58 File Offset: 0x00028D58
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand inOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand;
				return inOperand != null && base.EqualsOverride(inOperand) && inOperand._items == this._items;
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x0002AB88 File Offset: 0x00028D88
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this._items.GetHashCode();
			}

			// Token: 0x06000CC2 RID: 3266 RVA: 0x0002AB9C File Offset: 0x00028D9C
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (!base.IsMatch(comparisonOperator, value, context))
				{
					return false;
				}
				global::System.Type type;
				global::System.Type type2;
				global::System.Type type3;
				global::Infragistics.Windows.Controls.ComparisonCondition.GetConvertType(comparisonOperator, context, value, value, out type, out type2, out type3);
				global::System.Globalization.CultureInfo culture = global::Infragistics.Windows.Controls.ComparisonCondition.GetCulture(context);
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.CacheKey cacheIdentifier = new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.CacheKey
				{
					Operand = this,
					PreferredComparisonDataType = context.PreferredComparisonDataType,
					ConvertToType = type,
					Culture = culture,
					IgnoreCase = context.IgnoreCase
				};
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.CacheInfo cacheInfo = context.GetUserCache(cacheIdentifier) as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.CacheInfo;
				if (cacheInfo == null)
				{
					global::System.Collections.IEqualityComparer equalityComparer = (type2 == typeof(string)) ? global::System.StringComparer.Create(culture, context.IgnoreCase) : null;
					global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet(10, 0.5f, equalityComparer);
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase blanksOperand = null;
					foreach (object obj in this._items)
					{
						if (obj is global::Infragistics.Windows.Controls.SpecialFilterOperandBase && ((global::Infragistics.Windows.Controls.SpecialFilterOperandBase)obj).Name == "Blanks")
						{
							blanksOperand = (obj as global::Infragistics.Windows.Controls.SpecialFilterOperandBase);
						}
						else if (type2 != null)
						{
							object obj2 = global::Infragistics.Windows.Controls.ComparisonCondition.ConvertDataTypeHelper(obj, type2, context);
							if (obj2 != null)
							{
								hashSet.Add(obj2);
							}
						}
					}
					cacheInfo = new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.CacheInfo(hashSet, blanksOperand);
					context.SetUserCache(cacheIdentifier, cacheInfo);
				}
				object obj3 = (type != null) ? global::Infragistics.Windows.Controls.ComparisonCondition.ConvertDataTypeHelper(value, type, context) : value;
				if (cacheInfo.BlanksOperand != null && cacheInfo.BlanksOperand.IsMatch(comparisonOperator, obj3, context))
				{
					return true;
				}
				if (obj3 == null || obj3 == global::System.DBNull.Value)
				{
					return comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals;
				}
				return cacheInfo.Items.Contains(obj3) == (comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals);
			}

			// Token: 0x06000CC3 RID: 3267 RVA: 0x0002AD58 File Offset: 0x00028F58
			public override bool SupportsDataType(global::System.Type type)
			{
				return true;
			}

			// Token: 0x06000CC4 RID: 3268 RVA: 0x0002AD5B File Offset: 0x00028F5B
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				return comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals || comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals;
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0002AD68 File Offset: 0x00028F68
			protected override object[] ValueArgumentsForStrings
			{
				get
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					foreach (object value in this._items)
					{
						stringBuilder.Append(value);
						stringBuilder.Append(", ");
					}
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Remove(stringBuilder.Length - 2, 2);
					}
					return new object[]
					{
						stringBuilder.ToString()
					};
				}
			}

			// Token: 0x04000611 RID: 1553
			private global::System.Collections.IEnumerable _items;

			// Token: 0x0200017D RID: 381
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x1700023C RID: 572
				// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0002ADFC File Offset: 0x00028FFC
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(object), "[]")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000CC7 RID: 3271 RVA: 0x0002AE3C File Offset: 0x0002903C
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand inOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.ObjectWrapper> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.ObjectWrapper>();
					foreach (object value in inOperand._items)
					{
						list.Add(new global::Infragistics.Windows.Internal.ObjectWrapper(value));
					}
					dictionary["[]"] = list;
					return dictionary;
				}

				// Token: 0x06000CC8 RID: 3272 RVA: 0x0002AEBC File Offset: 0x000290BC
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					object obj;
					if (values.TryGetValue("[]", out obj))
					{
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						foreach (object obj2 in ((global::System.Collections.IEnumerable)obj))
						{
							global::Infragistics.Windows.Internal.ObjectWrapper objectWrapper = (global::Infragistics.Windows.Internal.ObjectWrapper)obj2;
							arrayList.Add(objectWrapper.Value);
						}
						return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand(arrayList);
					}
					return null;
				}

				// Token: 0x04000612 RID: 1554
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}

			// Token: 0x0200017E RID: 382
			private class CacheKey
			{
				// Token: 0x06000CCA RID: 3274 RVA: 0x0002AF44 File Offset: 0x00029144
				public override int GetHashCode()
				{
					int num = this.Operand.GetHashCode() ^ this.Culture.GetHashCode() ^ this.IgnoreCase.GetHashCode();
					if (this.ConvertToType != null)
					{
						num ^= this.ConvertToType.GetHashCode();
					}
					if (this.PreferredComparisonDataType != null)
					{
						num ^= this.PreferredComparisonDataType.GetHashCode();
					}
					return num;
				}

				// Token: 0x06000CCB RID: 3275 RVA: 0x0002AFB0 File Offset: 0x000291B0
				public override bool Equals(object obj)
				{
					if (!(obj is global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.CacheKey))
					{
						return false;
					}
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.CacheKey cacheKey = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand.CacheKey)obj;
					return cacheKey.Operand == this.Operand && cacheKey.PreferredComparisonDataType == this.PreferredComparisonDataType && cacheKey.ConvertToType == this.ConvertToType && cacheKey.Culture == this.Culture && cacheKey.IgnoreCase == this.IgnoreCase;
				}

				// Token: 0x04000613 RID: 1555
				internal global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand Operand;

				// Token: 0x04000614 RID: 1556
				internal global::System.Type PreferredComparisonDataType;

				// Token: 0x04000615 RID: 1557
				internal global::System.Type ConvertToType;

				// Token: 0x04000616 RID: 1558
				internal global::System.Globalization.CultureInfo Culture;

				// Token: 0x04000617 RID: 1559
				internal bool IgnoreCase;
			}

			// Token: 0x0200017F RID: 383
			private class CacheInfo
			{
				// Token: 0x06000CCD RID: 3277 RVA: 0x0002B028 File Offset: 0x00029228
				internal CacheInfo(global::Infragistics.Windows.Helpers.HashSet items, global::Infragistics.Windows.Controls.SpecialFilterOperandBase blanksOperand)
				{
					global::Infragistics.CoreUtilities.ValidateNotNull(items);
					this.Items = items;
					this.BlanksOperand = blanksOperand;
				}

				// Token: 0x04000618 RID: 1560
				internal readonly global::Infragistics.Windows.Helpers.HashSet Items;

				// Token: 0x04000619 RID: 1561
				internal readonly global::Infragistics.Windows.Controls.SpecialFilterOperandBase BlanksOperand;
			}
		}
	}
}
