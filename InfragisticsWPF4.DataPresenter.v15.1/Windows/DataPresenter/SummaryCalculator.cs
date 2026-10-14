using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Media;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C6 RID: 454
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculator.SummaryCalculatorConverter))]
	public abstract class SummaryCalculator
	{
		// Token: 0x06001AE5 RID: 6885 RVA: 0x000793B3 File Offset: 0x000775B3
		static SummaryCalculator()
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Average);
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Count);
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Maximum);
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Minimum);
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Sum);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000793F1 File Offset: 0x000775F1
		public SummaryCalculator()
		{
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000793F9 File Offset: 0x000775F9
		public static global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator Average
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_avgCalculator == null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_avgCalculator = new global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator();
				}
				return global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_avgCalculator;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00079411 File Offset: 0x00077611
		public static global::Infragistics.Windows.DataPresenter.CountSummaryCalculator Count
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_countCalculator == null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_countCalculator = new global::Infragistics.Windows.DataPresenter.CountSummaryCalculator();
				}
				return global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_countCalculator;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001AE9 RID: 6889
		public abstract string Description { get; }

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00079429 File Offset: 0x00077629
		public virtual string DisplayName
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x00079431 File Offset: 0x00077631
		public virtual global::System.Windows.Media.ImageSource Image
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00079434 File Offset: 0x00077634
		public virtual bool IsCalculationAffectedBySort
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x00079437 File Offset: 0x00077637
		public static global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator Maximum
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_maxCalculator == null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_maxCalculator = new global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator();
				}
				return global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_maxCalculator;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0007944F File Offset: 0x0007764F
		public static global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator Minimum
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_minCalculator == null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_minCalculator = new global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator();
				}
				return global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_minCalculator;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001AEF RID: 6895
		public abstract string Name { get; }

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00079467 File Offset: 0x00077667
		public static global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculator> RegisteredCalculators
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0007946E File Offset: 0x0007766E
		public static global::Infragistics.Windows.DataPresenter.SumSummaryCalculator Sum
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_sumCalculator == null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_sumCalculator = new global::Infragistics.Windows.DataPresenter.SumSummaryCalculator();
				}
				return global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_sumCalculator;
			}
		}

		// Token: 0x06001AF2 RID: 6898
		public abstract void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00079488 File Offset: 0x00077688
		public virtual string ApplyDefaultFormat(object summaryResultValue, global::Infragistics.Windows.DataPresenter.SummaryResult context)
		{
			global::Infragistics.Windows.DataPresenter.Field sourceField = context.SourceField;
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = context.SummaryDefinition;
			string text = null;
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(sourceField.EditAsTypeResolved);
			global::System.Type right = (summaryResultValue != null) ? summaryResultValue.GetType() : null;
			if (this is global::Infragistics.Windows.DataPresenter.CountSummaryCalculator)
			{
				text = null;
			}
			else if (global::Infragistics.Windows.Utilities.IsNumericType(underlyingType))
			{
				global::System.Type[] e = new global::System.Type[]
				{
					typeof(decimal),
					typeof(double),
					typeof(float)
				};
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.Contains(e, underlyingType) || this is global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator)
				{
					text = "N";
				}
				else
				{
					text = "G";
				}
			}
			else if (typeof(global::System.DateTime) == right)
			{
				text = "d";
			}
			return string.Format(context.StringFormatProviderResolved, (text != null) ? ("{1} = {0:" + text + "}") : "{1} = {0}", new object[]
			{
				summaryResultValue,
				(summaryDefinition.Calculator != null) ? summaryDefinition.Calculator.DisplayName : string.Empty
			});
		}

		// Token: 0x06001AF4 RID: 6900
		public abstract void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult);

		// Token: 0x06001AF5 RID: 6901
		public abstract bool CanProcessDataType(global::System.Type dataType);

		// Token: 0x06001AF6 RID: 6902
		public abstract object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult);

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00079598 File Offset: 0x00077798
		public static void Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.UnRegister(calculator);
			lock (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators)
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators.Add(calculator);
			}
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000795E4 File Offset: 0x000777E4
		public static void UnRegister(string calculatorName)
		{
			lock (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators)
			{
				for (int i = 0; i < global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.SummaryCalculator summaryCalculator = global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators[i];
					if (summaryCalculator.Name == calculatorName)
					{
						global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators.RemoveAt(i);
						break;
					}
				}
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0007965C File Offset: 0x0007785C
		public static void UnRegister(global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.UnRegister(calculator.Name);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00079669 File Offset: 0x00077869
		internal static object ConvertDataValue(object val, global::System.Type toType, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(val, toType, null, null);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00079674 File Offset: 0x00077874
		internal static object ConvertToFieldEditAsType(object val, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.Field field = (summaryResult != null) ? summaryResult.SourceField : null;
			global::System.Type type = (field != null) ? field.EditAsTypeResolved : null;
			if (null == type)
			{
				type = typeof(string);
			}
			return global::Infragistics.Windows.DataPresenter.SummaryCalculator.ConvertDataValue(val, type, summaryResult, record);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000796B8 File Offset: 0x000778B8
		internal static global::Infragistics.Windows.DataPresenter.SummaryCalculator GetCalculator(string name)
		{
			lock (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators)
			{
				foreach (global::Infragistics.Windows.DataPresenter.SummaryCalculator summaryCalculator in global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators)
				{
					if (summaryCalculator.Name == name)
					{
						return summaryCalculator;
					}
				}
			}
			return null;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00079744 File Offset: 0x00077944
		internal static bool ToDecimal(object val, out decimal number, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			number = 0m;
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(val))
			{
				return false;
			}
			if (!(val is decimal) && (!(val is double) || !double.IsNaN((double)val)))
			{
				if (val is double)
				{
					if (double.IsNaN((double)val) || double.IsInfinity((double)val))
					{
						return false;
					}
				}
				else if (val is float && (float.IsNaN((float)val) || float.IsInfinity((float)val)))
				{
					return false;
				}
				val = global::Infragistics.Windows.DataPresenter.SummaryCalculator.ConvertDataValue(val, typeof(decimal), summaryResult, record);
			}
			if (val is decimal)
			{
				number = (decimal)val;
				return true;
			}
			return false;
		}

		// Token: 0x04000AD4 RID: 2772
		private static global::Infragistics.Windows.DataPresenter.SumSummaryCalculator g_sumCalculator;

		// Token: 0x04000AD5 RID: 2773
		private static global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator g_avgCalculator;

		// Token: 0x04000AD6 RID: 2774
		private static global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator g_minCalculator;

		// Token: 0x04000AD7 RID: 2775
		private static global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator g_maxCalculator;

		// Token: 0x04000AD8 RID: 2776
		private static global::Infragistics.Windows.DataPresenter.CountSummaryCalculator g_countCalculator;

		// Token: 0x04000AD9 RID: 2777
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryCalculator> g_registeredCalculators = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryCalculator>();

		// Token: 0x020001C7 RID: 455
		public class SummaryCalculatorConverter : global::System.ComponentModel.TypeConverter
		{
			// Token: 0x06001AFE RID: 6910 RVA: 0x000797F7 File Offset: 0x000779F7
			public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
			{
				return typeof(string) == sourceType || base.CanConvertFrom(context, sourceType);
			}

			// Token: 0x06001AFF RID: 6911 RVA: 0x00079815 File Offset: 0x00077A15
			public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
			{
				return typeof(string) == destinationType || base.CanConvertTo(context, destinationType);
			}

			// Token: 0x06001B00 RID: 6912 RVA: 0x00079834 File Offset: 0x00077A34
			public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
			{
				string text = value as string;
				if (text != null)
				{
					return global::Infragistics.Windows.DataPresenter.SummaryCalculator.GetCalculator(text);
				}
				return base.ConvertFrom(context, culture, value);
			}

			// Token: 0x06001B01 RID: 6913 RVA: 0x0007985C File Offset: 0x00077A5C
			public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculator summaryCalculator = value as global::Infragistics.Windows.DataPresenter.SummaryCalculator;
				if (summaryCalculator != null)
				{
					return summaryCalculator.Name;
				}
				return base.ConvertTo(context, culture, value, destinationType);
			}

			// Token: 0x06001B02 RID: 6914 RVA: 0x00079888 File Offset: 0x00077A88
			public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
			{
				if (context.Instance is global::Infragistics.Windows.DataPresenter.SummaryDefinition)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryCalculator> list = global::Infragistics.Windows.DataPresenter.GridUtilities.ToList<global::Infragistics.Windows.DataPresenter.SummaryCalculator>(global::Infragistics.Windows.DataPresenter.SummaryCalculator.RegisteredCalculators, true);
					if (list != null && list.Count > 0)
					{
						return new global::System.ComponentModel.TypeConverter.StandardValuesCollection(list);
					}
				}
				return base.GetStandardValues(context);
			}
		}
	}
}
