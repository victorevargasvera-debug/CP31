using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Media;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001A3 RID: 419
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculator.SummaryCalculatorConverter))]
	public abstract class SummaryCalculator
	{
		// Token: 0x06001727 RID: 5927 RVA: 0x00066787 File Offset: 0x00064987
		static SummaryCalculator()
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Average);
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Count);
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Maximum);
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Minimum);
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator.Sum);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000667C5 File Offset: 0x000649C5
		public SummaryCalculator()
		{
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x000667CD File Offset: 0x000649CD
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

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000667E5 File Offset: 0x000649E5
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

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600172B RID: 5931
		public abstract string Description { get; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x000667FD File Offset: 0x000649FD
		public virtual string DisplayName
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00066805 File Offset: 0x00064A05
		public virtual global::System.Windows.Media.ImageSource Image
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00066808 File Offset: 0x00064A08
		public virtual bool IsCalculationAffectedBySort
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x0006680B File Offset: 0x00064A0B
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

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00066823 File Offset: 0x00064A23
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001731 RID: 5937
		public abstract string Name { get; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0006683B File Offset: 0x00064A3B
		public static global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculator> RegisteredCalculators
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00066842 File Offset: 0x00064A42
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

		// Token: 0x06001734 RID: 5940
		public abstract void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x06001735 RID: 5941 RVA: 0x0006685C File Offset: 0x00064A5C
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

		// Token: 0x06001736 RID: 5942
		public abstract void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult);

		// Token: 0x06001737 RID: 5943
		public abstract bool CanProcessDataType(global::System.Type dataType);

		// Token: 0x06001738 RID: 5944
		public abstract object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult);

		// Token: 0x06001739 RID: 5945 RVA: 0x0006696C File Offset: 0x00064B6C
		public static void Register(global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.UnRegister(calculator);
			lock (global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators)
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculator.g_registeredCalculators.Add(calculator);
			}
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000669B8 File Offset: 0x00064BB8
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

		// Token: 0x0600173B RID: 5947 RVA: 0x00066A30 File Offset: 0x00064C30
		public static void UnRegister(global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculator.UnRegister(calculator.Name);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00066A3D File Offset: 0x00064C3D
		internal static object ConvertDataValue(object val, global::System.Type toType, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(val, toType, null, null);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00066A48 File Offset: 0x00064C48
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

		// Token: 0x0600173E RID: 5950 RVA: 0x00066A8C File Offset: 0x00064C8C
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

		// Token: 0x0600173F RID: 5951 RVA: 0x00066B18 File Offset: 0x00064D18
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

		// Token: 0x0400090A RID: 2314
		private static global::Infragistics.Windows.DataPresenter.SumSummaryCalculator g_sumCalculator;

		// Token: 0x0400090B RID: 2315
		private static global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator g_avgCalculator;

		// Token: 0x0400090C RID: 2316
		private static global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator g_minCalculator;

		// Token: 0x0400090D RID: 2317
		private static global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator g_maxCalculator;

		// Token: 0x0400090E RID: 2318
		private static global::Infragistics.Windows.DataPresenter.CountSummaryCalculator g_countCalculator;

		// Token: 0x0400090F RID: 2319
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryCalculator> g_registeredCalculators = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryCalculator>();

		// Token: 0x020001A4 RID: 420
		public class SummaryCalculatorConverter : global::System.ComponentModel.TypeConverter
		{
			// Token: 0x06001740 RID: 5952 RVA: 0x00066BCB File Offset: 0x00064DCB
			public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
			{
				return typeof(string) == sourceType || base.CanConvertFrom(context, sourceType);
			}

			// Token: 0x06001741 RID: 5953 RVA: 0x00066BE9 File Offset: 0x00064DE9
			public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
			{
				return typeof(string) == destinationType || base.CanConvertTo(context, destinationType);
			}

			// Token: 0x06001742 RID: 5954 RVA: 0x00066C08 File Offset: 0x00064E08
			public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
			{
				string text = value as string;
				if (text != null)
				{
					return global::Infragistics.Windows.DataPresenter.SummaryCalculator.GetCalculator(text);
				}
				return base.ConvertFrom(context, culture, value);
			}

			// Token: 0x06001743 RID: 5955 RVA: 0x00066C30 File Offset: 0x00064E30
			public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculator summaryCalculator = value as global::Infragistics.Windows.DataPresenter.SummaryCalculator;
				if (summaryCalculator != null)
				{
					return summaryCalculator.Name;
				}
				return base.ConvertTo(context, culture, value, destinationType);
			}

			// Token: 0x06001744 RID: 5956 RVA: 0x00066C5C File Offset: 0x00064E5C
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
