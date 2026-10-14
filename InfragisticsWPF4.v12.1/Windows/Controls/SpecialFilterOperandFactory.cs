using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Shared;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000149 RID: 329
	internal class SpecialFilterOperandFactory
	{
		// Token: 0x06000B3D RID: 2877 RVA: 0x00024CE0 File Offset: 0x00022EE0
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

		// Token: 0x06000B3E RID: 2878 RVA: 0x00024FC0 File Offset: 0x000231C0
		internal static void RegisterSerializationInfos(global::Infragistics.Windows.Internal.ObjectSerializerBase serializer)
		{
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand.SerializationInfo());
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand), new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.SerializationInfo());
		}

		// Token: 0x0200014B RID: 331
		internal abstract class IGOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandBase
		{
			// Token: 0x06000B4D RID: 2893 RVA: 0x0002511C File Offset: 0x0002331C
			public IGOperand(string name, string resourceName)
			{
				this._name = name;
				this._sr_displayContent = "SpecialFilterOperand_" + resourceName + "_DisplayContent";
				this._sr_description = "SpecialFilterOperand_" + resourceName + "_Description";
			}

			// Token: 0x06000B4E RID: 2894 RVA: 0x00025157 File Offset: 0x00023357
			public IGOperand(string name) : this(name, name)
			{
			}

			// Token: 0x06000B4F RID: 2895 RVA: 0x00025164 File Offset: 0x00023364
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand igoperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand;
				return igoperand != null && this._name == igoperand.Name && this._sr_displayContent == igoperand._sr_displayContent && this._sr_description == igoperand._sr_description;
			}

			// Token: 0x06000B50 RID: 2896 RVA: 0x000251B4 File Offset: 0x000233B4
			public override int GetHashCode()
			{
				if (this._name == null)
				{
					return 0;
				}
				return this._name.GetHashCode();
			}

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000251CB File Offset: 0x000233CB
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

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x06000B52 RID: 2898 RVA: 0x000251F8 File Offset: 0x000233F8
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

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00025220 File Offset: 0x00023420
			public override string Name
			{
				get
				{
					return this._name;
				}
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00025228 File Offset: 0x00023428
			public override bool UsesAllValues
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0002522B File Offset: 0x0002342B
			protected virtual object[] ValueArgumentsForStrings
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000B56 RID: 2902 RVA: 0x0002522E File Offset: 0x0002342E
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				return this.SupportsOperator(comparisonOperator) && (value == null || global::System.DBNull.Value == value || this.SupportsDataType(value.GetType()));
			}

			// Token: 0x06000B57 RID: 2903 RVA: 0x00025255 File Offset: 0x00023455
			internal static object ConvertValue(object value, global::System.Type targetType, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				return global::Infragistics.Windows.Controls.ComparisonCondition.ConvertDataTypeHelper(value, targetType, context);
			}

			// Token: 0x06000B58 RID: 2904 RVA: 0x00025260 File Offset: 0x00023460
			internal static double GetCurrentValueAsDouble(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				object obj = global::Infragistics.Windows.Controls.ComparisonCondition.ConvertDataTypeHelper(value, typeof(double), context);
				if (!(obj is double))
				{
					return double.NaN;
				}
				return (double)obj;
			}

			// Token: 0x04000521 RID: 1313
			private string _name;

			// Token: 0x04000522 RID: 1314
			private string _sr_displayContent;

			// Token: 0x04000523 RID: 1315
			private string _sr_description;

			// Token: 0x04000524 RID: 1316
			private global::Infragistics.Shared.DynamicResourceString _drsDescription;

			// Token: 0x04000525 RID: 1317
			private global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand.FormattedSRValue _fsrDisplayContent;

			// Token: 0x0200014C RID: 332
			internal class FormattedSRValue : global::System.IFormattable
			{
				// Token: 0x06000B59 RID: 2905 RVA: 0x00025297 File Offset: 0x00023497
				internal FormattedSRValue(string sr, object[] args, global::System.Globalization.CultureInfo defaultCultureInfo)
				{
					global::Infragistics.Windows.Utilities.ThrowIfNull(sr, "sr");
					this._sr = sr;
					this._args = args;
					this._defaultCultureInfo = defaultCultureInfo;
				}

				// Token: 0x06000B5A RID: 2906 RVA: 0x000252BF File Offset: 0x000234BF
				public override string ToString()
				{
					return this.ToString(null, null);
				}

				// Token: 0x06000B5B RID: 2907 RVA: 0x000252CC File Offset: 0x000234CC
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

				// Token: 0x04000526 RID: 1318
				private string _sr;

				// Token: 0x04000527 RID: 1319
				private object[] _args;

				// Token: 0x04000528 RID: 1320
				private global::System.Globalization.CultureInfo _defaultCultureInfo;
			}
		}

		// Token: 0x0200014D RID: 333
		internal class BlanksOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000B5C RID: 2908 RVA: 0x00025311 File Offset: 0x00023511
			public BlanksOperand(bool nonBlanks) : base((!nonBlanks) ? "Blanks" : "NonBlanks")
			{
				this._nonBlanks = nonBlanks;
			}

			// Token: 0x06000B5D RID: 2909 RVA: 0x00025330 File Offset: 0x00023530
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand blanksOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand;
				return blanksOperand != null && base.EqualsOverride(blanksOperand) && this._nonBlanks == blanksOperand._nonBlanks;
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x00025360 File Offset: 0x00023560
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this._nonBlanks.GetHashCode();
			}

			// Token: 0x06000B5F RID: 2911 RVA: 0x00025374 File Offset: 0x00023574
			public override bool SupportsDataType(global::System.Type type)
			{
				return true;
			}

			// Token: 0x06000B60 RID: 2912 RVA: 0x00025377 File Offset: 0x00023577
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				return comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals || global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator;
			}

			// Token: 0x06000B61 RID: 2913 RVA: 0x00025382 File Offset: 0x00023582
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
				{
					return this._nonBlanks != global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand.IsBlank(value, context);
				}
				return global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator && !this.IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, value, context);
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x000253AC File Offset: 0x000235AC
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

			// Token: 0x04000529 RID: 1321
			internal const string NAME_Blanks = "Blanks";

			// Token: 0x0400052A RID: 1322
			internal const string NAME_NonBlanks = "NonBlanks";

			// Token: 0x0400052B RID: 1323
			private bool _nonBlanks;

			// Token: 0x0200014E RID: 334
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000213 RID: 531
				// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0002541C File Offset: 0x0002361C
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

				// Token: 0x06000B64 RID: 2916 RVA: 0x0002545C File Offset: 0x0002365C
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand blanksOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.BlanksOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["MatchNonBlanks"] = blanksOperand._nonBlanks;
					return dictionary;
				}

				// Token: 0x06000B65 RID: 2917 RVA: 0x00025490 File Offset: 0x00023690
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

				// Token: 0x0400052C RID: 1324
				private const string NonBlanksProp = "MatchNonBlanks";

				// Token: 0x0400052D RID: 1325
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x0200014F RID: 335
		internal class AverageOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000B67 RID: 2919 RVA: 0x000254C3 File Offset: 0x000236C3
			public AverageOperand(bool aboveAverage) : base(aboveAverage ? "AboveAverage" : "BelowAverage")
			{
				this._aboveAverage = aboveAverage;
			}

			// Token: 0x06000B68 RID: 2920 RVA: 0x000254E1 File Offset: 0x000236E1
			public override bool SupportsDataType(global::System.Type type)
			{
				return global::Infragistics.Windows.Utilities.IsNumericType(global::Infragistics.CoreUtilities.GetUnderlyingType(type));
			}

			// Token: 0x06000B69 RID: 2921 RVA: 0x000254EE File Offset: 0x000236EE
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				return comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals || global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator;
			}

			// Token: 0x06000B6A RID: 2922 RVA: 0x000254FC File Offset: 0x000236FC
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

			// Token: 0x17000214 RID: 532
			// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00025552 File Offset: 0x00023752
			public override bool UsesAllValues
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000B6C RID: 2924 RVA: 0x00025558 File Offset: 0x00023758
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

			// Token: 0x0400052E RID: 1326
			internal const string NAME_AboveAverage = "AboveAverage";

			// Token: 0x0400052F RID: 1327
			internal const string NAME_BelowAverage = "BelowAverage";

			// Token: 0x04000530 RID: 1328
			private bool _aboveAverage;

			// Token: 0x02000150 RID: 336
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000215 RID: 533
				// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00025614 File Offset: 0x00023814
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

				// Token: 0x06000B6E RID: 2926 RVA: 0x00025654 File Offset: 0x00023854
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand averageOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.AverageOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["AboveAverage"] = averageOperand._aboveAverage;
					return dictionary;
				}

				// Token: 0x06000B6F RID: 2927 RVA: 0x00025688 File Offset: 0x00023888
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

				// Token: 0x04000531 RID: 1329
				private const string AboveAverageProp = "AboveAverage";

				// Token: 0x04000532 RID: 1330
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x02000151 RID: 337
		internal class TopValuesOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000B71 RID: 2929 RVA: 0x000256BC File Offset: 0x000238BC
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

			// Token: 0x06000B72 RID: 2930 RVA: 0x0002571C File Offset: 0x0002391C
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand topValuesOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand;
				return topValuesOperand != null && base.EqualsOverride(topValuesOperand) && this._ascendingOrder == topValuesOperand._ascendingOrder && this._percentage == topValuesOperand._percentage && this._topNumber == topValuesOperand._topNumber;
			}

			// Token: 0x06000B73 RID: 2931 RVA: 0x00025768 File Offset: 0x00023968
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this._ascendingOrder.GetHashCode() ^ this._percentage.GetHashCode() ^ this._topNumber.GetHashCode();
			}

			// Token: 0x06000B74 RID: 2932 RVA: 0x00025794 File Offset: 0x00023994
			public override bool SupportsDataType(global::System.Type type)
			{
				type = global::Infragistics.CoreUtilities.GetUnderlyingType(type);
				return global::Infragistics.Windows.Utilities.IsNumericType(type) || typeof(global::System.DateTime) == type;
			}

			// Token: 0x06000B75 RID: 2933 RVA: 0x000257B8 File Offset: 0x000239B8
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				return comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals || global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals == comparisonOperator;
			}

			// Token: 0x06000B76 RID: 2934 RVA: 0x000257C4 File Offset: 0x000239C4
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

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0002586E File Offset: 0x00023A6E
			public override bool UsesAllValues
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000217 RID: 535
			// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00025874 File Offset: 0x00023A74
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

			// Token: 0x06000B79 RID: 2937 RVA: 0x00025898 File Offset: 0x00023A98
			internal static void ClearUserCacheHelper(global::Infragistics.Windows.Controls.SpecialFilterOperandBase topValuesOperand, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand topValuesOperand2 = topValuesOperand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand;
				if (topValuesOperand2 != null)
				{
					context.SetUserCache(topValuesOperand2, null);
				}
			}

			// Token: 0x06000B7A RID: 2938 RVA: 0x000258B7 File Offset: 0x00023AB7
			internal static global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand CreateHelper(string name, double topNumber, bool percentage, bool ascendingOrder, out global::System.Exception error)
			{
				if (!global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.ValidateParams(topNumber, percentage, ascendingOrder, out error))
				{
					return null;
				}
				return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand(name, topNumber, percentage, ascendingOrder);
			}

			// Token: 0x06000B7B RID: 2939 RVA: 0x000258D0 File Offset: 0x00023AD0
			private static double DateTimeToDouble(global::System.DateTime value)
			{
				return (double)value.Ticks;
			}

			// Token: 0x06000B7C RID: 2940 RVA: 0x000258DC File Offset: 0x00023ADC
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

			// Token: 0x06000B7D RID: 2941 RVA: 0x000259EC File Offset: 0x00023BEC
			private static double GetDoubleHelper(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				if (value is global::System.DateTime)
				{
					return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.TopValuesOperand.DateTimeToDouble((global::System.DateTime)value);
				}
				return global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand.GetCurrentValueAsDouble(value, context);
			}

			// Token: 0x06000B7E RID: 2942 RVA: 0x00025A0C File Offset: 0x00023C0C
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
					result = ii.ValueAsDouble;
				}
				return result;
			}

			// Token: 0x06000B7F RID: 2943 RVA: 0x00025A40 File Offset: 0x00023C40
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

			// Token: 0x06000B80 RID: 2944 RVA: 0x00025B3F File Offset: 0x00023D3F
			private static bool IsNumericOrDateTime(global::System.Type type)
			{
				return null != type && (global::Infragistics.Windows.Utilities.IsNumericType(type) || typeof(global::System.DateTime) == type);
			}

			// Token: 0x06000B81 RID: 2945 RVA: 0x00025B68 File Offset: 0x00023D68
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

			// Token: 0x04000533 RID: 1331
			private double _topNumber;

			// Token: 0x04000534 RID: 1332
			private bool _percentage;

			// Token: 0x04000535 RID: 1333
			private bool _ascendingOrder;

			// Token: 0x02000152 RID: 338
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000218 RID: 536
				// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00025BE8 File Offset: 0x00023DE8
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

				// Token: 0x06000B83 RID: 2947 RVA: 0x00025C70 File Offset: 0x00023E70
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

				// Token: 0x06000B84 RID: 2948 RVA: 0x00025CE0 File Offset: 0x00023EE0
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

				// Token: 0x04000536 RID: 1334
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x02000153 RID: 339
		internal class DateOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand
		{
			// Token: 0x06000B86 RID: 2950 RVA: 0x00025D50 File Offset: 0x00023F50
			public DateOperand(string name, string resourceName) : base(name, resourceName)
			{
			}

			// Token: 0x06000B87 RID: 2951 RVA: 0x00025D5A File Offset: 0x00023F5A
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				return base.IsMatch(comparisonOperator, value, context) && value != null && value != global::System.DBNull.Value && !(global::Infragistics.CoreUtilities.GetUnderlyingType(value.GetType()) != typeof(global::System.DateTime));
			}

			// Token: 0x06000B88 RID: 2952 RVA: 0x00025D93 File Offset: 0x00023F93
			public override bool SupportsDataType(global::System.Type dataType)
			{
				return global::Infragistics.CoreUtilities.GetUnderlyingType(dataType) == typeof(global::System.DateTime);
			}

			// Token: 0x06000B89 RID: 2953 RVA: 0x00025DAC File Offset: 0x00023FAC
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

		// Token: 0x02000154 RID: 340
		internal class RelativeDateOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateOperand
		{
			// Token: 0x06000B8A RID: 2954 RVA: 0x00025DDE File Offset: 0x00023FDE
			public RelativeDateOperand(string name, global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate relativeDate) : base(name, name)
			{
				this.relativeDate = relativeDate;
			}

			// Token: 0x06000B8B RID: 2955 RVA: 0x00025DF0 File Offset: 0x00023FF0
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

			// Token: 0x06000B8C RID: 2956 RVA: 0x00025EF4 File Offset: 0x000240F4
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

			// Token: 0x06000B8D RID: 2957 RVA: 0x00025F7E File Offset: 0x0002417E
			private void ResetCurrentDate()
			{
				this.useCustomCurrentDate = false;
				this.cachedCurrentDate = global::System.DateTime.MinValue;
			}

			// Token: 0x06000B8E RID: 2958 RVA: 0x00025F92 File Offset: 0x00024192
			private void SetCurrentDate(global::System.DateTime currentDate)
			{
				this.useCustomCurrentDate = true;
				this.customCurrentDate = currentDate;
			}

			// Token: 0x06000B8F RID: 2959 RVA: 0x00025FA4 File Offset: 0x000241A4
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

			// Token: 0x06000B90 RID: 2960 RVA: 0x000263D0 File Offset: 0x000245D0
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand relativeDateOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand;
				return relativeDateOperand != null && base.EqualsOverride(relativeDateOperand) && this.relativeDate == relativeDateOperand.relativeDate;
			}

			// Token: 0x06000B91 RID: 2961 RVA: 0x00026400 File Offset: 0x00024600
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this.relativeDate.GetHashCode();
			}

			// Token: 0x06000B92 RID: 2962 RVA: 0x0002641C File Offset: 0x0002461C
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

			// Token: 0x04000537 RID: 1335
			private bool useCustomCurrentDate;

			// Token: 0x04000538 RID: 1336
			private global::System.DateTime customCurrentDate;

			// Token: 0x04000539 RID: 1337
			private global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand.RelativeDate relativeDate;

			// Token: 0x0400053A RID: 1338
			private global::System.DateTime cachedCurrentDate;

			// Token: 0x0400053B RID: 1339
			private global::System.DateTime cachedStart;

			// Token: 0x0400053C RID: 1340
			private global::System.DateTime cachedEnd;

			// Token: 0x0400053D RID: 1341
			private global::System.Globalization.CultureInfo cachedCurrentCulture;

			// Token: 0x02000155 RID: 341
			internal enum RelativeDate
			{
				// Token: 0x0400053F RID: 1343
				Tomorrow,
				// Token: 0x04000540 RID: 1344
				Today,
				// Token: 0x04000541 RID: 1345
				Yesterday,
				// Token: 0x04000542 RID: 1346
				NextWeek,
				// Token: 0x04000543 RID: 1347
				ThisWeek,
				// Token: 0x04000544 RID: 1348
				LastWeek,
				// Token: 0x04000545 RID: 1349
				NextMonth,
				// Token: 0x04000546 RID: 1350
				ThisMonth,
				// Token: 0x04000547 RID: 1351
				LastMonth,
				// Token: 0x04000548 RID: 1352
				NextQuarter,
				// Token: 0x04000549 RID: 1353
				ThisQuarter,
				// Token: 0x0400054A RID: 1354
				LastQuarter,
				// Token: 0x0400054B RID: 1355
				NextYear,
				// Token: 0x0400054C RID: 1356
				ThisYear,
				// Token: 0x0400054D RID: 1357
				LastYear,
				// Token: 0x0400054E RID: 1358
				YearToDate
			}

			// Token: 0x02000156 RID: 342
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000219 RID: 537
				// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00026460 File Offset: 0x00024660
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

				// Token: 0x06000B94 RID: 2964 RVA: 0x000264B8 File Offset: 0x000246B8
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand relativeDateOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RelativeDateOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = relativeDateOperand.Name;
					dictionary["RelativeDate"] = relativeDateOperand.relativeDate;
					return dictionary;
				}

				// Token: 0x06000B95 RID: 2965 RVA: 0x000264FC File Offset: 0x000246FC
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

				// Token: 0x0400054F RID: 1359
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x02000157 RID: 343
		internal class MonthOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateOperand
		{
			// Token: 0x06000B97 RID: 2967 RVA: 0x00026542 File Offset: 0x00024742
			public MonthOperand(string name, short month) : base(name, "Month")
			{
				if (month < 1 || month > 12)
				{
					throw new global::System.ArgumentOutOfRangeException();
				}
				this.month = month;
			}

			// Token: 0x06000B98 RID: 2968 RVA: 0x00026568 File Offset: 0x00024768
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand monthOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand;
				return monthOperand != null && base.EqualsOverride(monthOperand) && this.month == monthOperand.month;
			}

			// Token: 0x06000B99 RID: 2969 RVA: 0x00026598 File Offset: 0x00024798
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this.month.GetHashCode();
			}

			// Token: 0x06000B9A RID: 2970 RVA: 0x000265AC File Offset: 0x000247AC
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

			// Token: 0x1700021A RID: 538
			// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00026640 File Offset: 0x00024840
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

			// Token: 0x04000550 RID: 1360
			private short month;

			// Token: 0x02000158 RID: 344
			private class FormattedMonthName : global::System.IFormattable
			{
				// Token: 0x06000B9C RID: 2972 RVA: 0x0002665E File Offset: 0x0002485E
				internal FormattedMonthName(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand operand)
				{
					this._operand = operand;
				}

				// Token: 0x06000B9D RID: 2973 RVA: 0x00026670 File Offset: 0x00024870
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

				// Token: 0x04000551 RID: 1361
				private global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand _operand;
			}

			// Token: 0x02000159 RID: 345
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x1700021B RID: 539
				// (get) Token: 0x06000B9E RID: 2974 RVA: 0x000266CC File Offset: 0x000248CC
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

				// Token: 0x06000B9F RID: 2975 RVA: 0x00026724 File Offset: 0x00024924
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand monthOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.MonthOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = monthOperand.Name;
					dictionary["Month"] = monthOperand.month;
					return dictionary;
				}

				// Token: 0x06000BA0 RID: 2976 RVA: 0x00026768 File Offset: 0x00024968
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

				// Token: 0x04000552 RID: 1362
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x0200015A RID: 346
		internal class QuarterOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateOperand
		{
			// Token: 0x06000BA2 RID: 2978 RVA: 0x000267AE File Offset: 0x000249AE
			public QuarterOperand(string name, short quarter) : base(name, "Quarter")
			{
				if (quarter < 1 || quarter > 4)
				{
					throw new global::System.ArgumentOutOfRangeException();
				}
				this.quarter = quarter;
			}

			// Token: 0x06000BA3 RID: 2979 RVA: 0x000267D4 File Offset: 0x000249D4
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand quarterOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand;
				return quarterOperand != null && base.EqualsOverride(quarterOperand) && this.quarter == quarterOperand.quarter;
			}

			// Token: 0x06000BA4 RID: 2980 RVA: 0x00026804 File Offset: 0x00024A04
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this.quarter.GetHashCode();
			}

			// Token: 0x06000BA5 RID: 2981 RVA: 0x00026818 File Offset: 0x00024A18
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

			// Token: 0x1700021C RID: 540
			// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x000268BC File Offset: 0x00024ABC
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

			// Token: 0x04000553 RID: 1363
			private short quarter;

			// Token: 0x0200015B RID: 347
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x1700021D RID: 541
				// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x000268E0 File Offset: 0x00024AE0
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

				// Token: 0x06000BA8 RID: 2984 RVA: 0x00026938 File Offset: 0x00024B38
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand quarterOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.QuarterOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = quarterOperand.Name;
					dictionary["Quarter"] = quarterOperand.quarter;
					return dictionary;
				}

				// Token: 0x06000BA9 RID: 2985 RVA: 0x0002697C File Offset: 0x00024B7C
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

				// Token: 0x04000554 RID: 1364
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}

		// Token: 0x0200015C RID: 348
		internal class DateRangeOperand : global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateOperand
		{
			// Token: 0x06000BAB RID: 2987 RVA: 0x000269C2 File Offset: 0x00024BC2
			public DateRangeOperand(global::System.DateTime relativeDate, global::Infragistics.Windows.Controls.DateRangeScope scope) : base(global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetName(relativeDate, scope), global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.GetResourceName(scope))
			{
				this._relativeDate = relativeDate;
				this._scope = scope;
				this._cachedDateRange = global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand.CalculateRange(relativeDate, scope);
			}

			// Token: 0x1700021E RID: 542
			// (get) Token: 0x06000BAC RID: 2988 RVA: 0x000269F2 File Offset: 0x00024BF2
			private static global::System.Globalization.Calendar Calendar
			{
				get
				{
					return global::System.Globalization.CultureInfo.InvariantCulture.Calendar;
				}
			}

			// Token: 0x06000BAD RID: 2989 RVA: 0x00026A00 File Offset: 0x00024C00
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

			// Token: 0x06000BAE RID: 2990 RVA: 0x00026AB8 File Offset: 0x00024CB8
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

			// Token: 0x06000BAF RID: 2991 RVA: 0x00026B04 File Offset: 0x00024D04
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

			// Token: 0x06000BB0 RID: 2992 RVA: 0x00026BE8 File Offset: 0x00024DE8
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

			// Token: 0x06000BB1 RID: 2993 RVA: 0x00026C6C File Offset: 0x00024E6C
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

			// Token: 0x06000BB2 RID: 2994 RVA: 0x00026CC4 File Offset: 0x00024EC4
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand dateRangeOperand = operand as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand;
				return dateRangeOperand != null && this._scope == dateRangeOperand._scope && base.EqualsOverride(dateRangeOperand);
			}

			// Token: 0x06000BB3 RID: 2995 RVA: 0x00026CF2 File Offset: 0x00024EF2
			public override int GetHashCode()
			{
				return base.GetHashCode() ^ this._scope.GetHashCode();
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x00026D0C File Offset: 0x00024F0C
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

			// Token: 0x1700021F RID: 543
			// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00026DB8 File Offset: 0x00024FB8
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

			// Token: 0x04000555 RID: 1365
			private global::System.DateTime _relativeDate;

			// Token: 0x04000556 RID: 1366
			private global::Infragistics.Windows.Controls.DateRangeScope _scope;

			// Token: 0x04000557 RID: 1367
			private global::Infragistics.DateRange _cachedDateRange;

			// Token: 0x0200015D RID: 349
			internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x17000220 RID: 544
				// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00026DDC File Offset: 0x00024FDC
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

				// Token: 0x06000BB7 RID: 2999 RVA: 0x00026E34 File Offset: 0x00025034
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand dateRangeOperand = (global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Scope"] = dateRangeOperand._scope;
					dictionary["RelativeDate"] = dateRangeOperand._relativeDate;
					return dictionary;
				}

				// Token: 0x06000BB8 RID: 3000 RVA: 0x00026E7C File Offset: 0x0002507C
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

				// Token: 0x04000558 RID: 1368
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}
	}
}
