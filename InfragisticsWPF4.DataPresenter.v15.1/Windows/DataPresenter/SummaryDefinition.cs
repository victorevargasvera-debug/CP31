using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows.DataPresenter.Calculations;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001ED RID: 493
	public class SummaryDefinition : global::System.Windows.DependencyObject
	{
		// Token: 0x06001E97 RID: 7831 RVA: 0x00086E3C File Offset: 0x0008503C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection parentCollection = this.ParentCollection;
			if (parentCollection != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = parentCollection.FieldLayout;
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculatorProperty == property)
			{
				flag = true;
				this.IsCalculatorRegistered = false;
			}
			else if (global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty == property)
			{
				flag = true;
				flag2 = true;
			}
			else if (global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty == property)
			{
				flag2 = true;
			}
			else if (global::Infragistics.Windows.DataPresenter.SummaryDefinition.IsVisibleProperty == property)
			{
				if (this.IsCalculatorRegistered && (bool)e.NewValue)
				{
					global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator = this.Calculator;
					if (calculator != null)
					{
						global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator2 = global::Infragistics.Windows.DataPresenter.SummaryCalculator.GetCalculator(calculator.Name);
						if (calculator2 != null && calculator != calculator2)
						{
							this.Calculator = calculator2;
							this.IsCalculatorRegistered = true;
						}
					}
				}
				flag2 = true;
			}
			else if (global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty == property)
			{
				flag2 = true;
			}
			else if (global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty == property)
			{
				flag2 = true;
			}
			else if (global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty == property)
			{
				flag3 = true;
			}
			else if (global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty == property)
			{
				flag3 = true;
			}
			if (flag || flag3)
			{
				this.BumpCalculationVersion();
			}
			if (flag2 && parentCollection != null)
			{
				parentCollection.BumpSummariesVersion();
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00086F49 File Offset: 0x00085149
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x00086F5B File Offset: 0x0008515B
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryCalculator Calculator
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryCalculator)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculatorProperty, value);
			}
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00086F69 File Offset: 0x00085169
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCalculator()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculatorProperty, this);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00086F76 File Offset: 0x00085176
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCalculator()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculatorProperty);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00086F84 File Offset: 0x00085184
		private static void OnCalculationSettingsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = target as global::Infragistics.Windows.DataPresenter.SummaryDefinition;
			summaryDefinition._calculationSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings);
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x00086FAA File Offset: 0x000851AA
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x00086FB2 File Offset: 0x000851B2
		public global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings CalculationSettings
		{
			get
			{
				return this._calculationSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculationSettingsProperty, value);
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x00086FC0 File Offset: 0x000851C0
		// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x00086FD2 File Offset: 0x000851D2
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas? DisplayArea
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas?)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty, value);
			}
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00086FE5 File Offset: 0x000851E5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayArea()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty, this);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00086FF2 File Offset: 0x000851F2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayArea()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty);
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x00086FFF File Offset: 0x000851FF
		// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x00087011 File Offset: 0x00085211
		public bool IsVisible
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.IsVisibleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.IsVisibleProperty, value);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x00087024 File Offset: 0x00085224
		// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x00087036 File Offset: 0x00085236
		[global::System.ComponentModel.Bindable(true)]
		public string StringFormat
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty, value);
			}
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00087044 File Offset: 0x00085244
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeStringFormat()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty, this);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00087051 File Offset: 0x00085251
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetStringFormat()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty);
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x0008705E File Offset: 0x0008525E
		// (set) Token: 0x06001EAA RID: 7850 RVA: 0x00087070 File Offset: 0x00085270
		[global::System.ComponentModel.Bindable(true)]
		public global::System.IFormatProvider StringFormatProvider
		{
			get
			{
				return (global::System.IFormatProvider)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty, value);
			}
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0008707E File Offset: 0x0008527E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeStringFormatProvider()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty, this);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0008708B File Offset: 0x0008528B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetStringFormatProvider()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty);
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x00087098 File Offset: 0x00085298
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x000870AA File Offset: 0x000852AA
		[global::System.ComponentModel.Bindable(true)]
		public string Key
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.KeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.KeyProperty, value);
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x000870B8 File Offset: 0x000852B8
		private static object OnCoerceKey(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			return (string)valueAsObject;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x000870CD File Offset: 0x000852CD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeKey()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.KeyProperty, this);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x000870DA File Offset: 0x000852DA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetKey()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.KeyProperty);
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x000870E7 File Offset: 0x000852E7
		public global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000870EF File Offset: 0x000852EF
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x00087101 File Offset: 0x00085301
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryPosition Position
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryPosition)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty, value);
			}
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00087114 File Offset: 0x00085314
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePosition()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty, this);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00087121 File Offset: 0x00085321
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPosition()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty);
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x0008712E File Offset: 0x0008532E
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x00087140 File Offset: 0x00085340
		[global::System.ComponentModel.Bindable(true)]
		public string PositionFieldName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty, value);
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0008714E File Offset: 0x0008534E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePositionFieldName()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty, this);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0008715B File Offset: 0x0008535B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPositionFieldName()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty);
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00087168 File Offset: 0x00085368
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x0008717A File Offset: 0x0008537A
		[global::System.ComponentModel.Bindable(true)]
		public string SourceFieldName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty, value);
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00087188 File Offset: 0x00085388
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSourceFieldName()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty, this);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00087195 File Offset: 0x00085395
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSourceFieldName()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty);
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001EBF RID: 7871 RVA: 0x000871A2 File Offset: 0x000853A2
		// (set) Token: 0x06001EC0 RID: 7872 RVA: 0x000871AF File Offset: 0x000853AF
		[global::System.ComponentModel.Bindable(true)]
		public object ToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.ToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.ToolTipProperty, value);
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000871BD File Offset: 0x000853BD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeToolTip()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.ToolTipProperty, this);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000871CA File Offset: 0x000853CA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetToolTip()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.ToolTipProperty);
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x000871D7 File Offset: 0x000853D7
		// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x000871DF File Offset: 0x000853DF
		internal int CalculationVersion
		{
			get
			{
				return this._cachedCalculationVersion;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculationVersionProperty, value);
			}
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x000871F4 File Offset: 0x000853F4
		private static void OnCalculationVersionChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int cachedCalculationVersion = (int)e.NewValue;
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = (global::Infragistics.Windows.DataPresenter.SummaryDefinition)dependencyObject;
			summaryDefinition._cachedCalculationVersion = cachedCalculationVersion;
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x0008721C File Offset: 0x0008541C
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				if (this._parentCollection == null)
				{
					return null;
				}
				return this._parentCollection.FieldLayout;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00087233 File Offset: 0x00085433
		internal bool HasFormula
		{
			get
			{
				return this._calculationSettings != null && !string.IsNullOrEmpty(this._calculationSettings.Formula);
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00087252 File Offset: 0x00085452
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0008725A File Offset: 0x0008545A
		internal bool IsCalculatorRegistered
		{
			get
			{
				return this._isCalculatorRegistered;
			}
			set
			{
				this._isCalculatorRegistered = value;
			}
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00087263 File Offset: 0x00085463
		public void Refresh()
		{
			this.BumpCalculationVersion();
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0008726B File Offset: 0x0008546B
		internal void BumpCalculationVersion()
		{
			this.CalculationVersion++;
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0008727B File Offset: 0x0008547B
		internal void InternalSetParentCollection(global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection parentCollection)
		{
			this._parentCollection = parentCollection;
		}

		// Token: 0x04000CF1 RID: 3313
		private global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection _parentCollection;

		// Token: 0x04000CF2 RID: 3314
		private int _cachedCalculationVersion;

		// Token: 0x04000CF3 RID: 3315
		private bool _isCalculatorRegistered;

		// Token: 0x04000CF4 RID: 3316
		public static readonly global::System.Windows.DependencyProperty CalculatorProperty = global::System.Windows.DependencyProperty.Register("Calculator", typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculator), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000CF5 RID: 3317
		public static readonly global::System.Windows.DependencyProperty CalculationSettingsProperty = global::System.Windows.DependencyProperty.Register("CalculationSettings", typeof(global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryDefinition.OnCalculationSettingsChanged)));

		// Token: 0x04000CF6 RID: 3318
		private global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings _calculationSettings;

		// Token: 0x04000CF7 RID: 3319
		public static readonly global::System.Windows.DependencyProperty DisplayAreaProperty = global::System.Windows.DependencyProperty.Register("DisplayArea", typeof(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas?), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000CF8 RID: 3320
		public static readonly global::System.Windows.DependencyProperty IsVisibleProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsVisible", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000CF9 RID: 3321
		public static readonly global::System.Windows.DependencyProperty StringFormatProperty = global::System.Windows.DependencyProperty.Register("StringFormat", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000CFA RID: 3322
		public static readonly global::System.Windows.DependencyProperty StringFormatProviderProperty = global::System.Windows.DependencyProperty.Register("StringFormatProvider", typeof(global::System.IFormatProvider), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000CFB RID: 3323
		public static readonly global::System.Windows.DependencyProperty KeyProperty = global::System.Windows.DependencyProperty.Register("Key", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.SummaryDefinition.OnCoerceKey)));

		// Token: 0x04000CFC RID: 3324
		public static readonly global::System.Windows.DependencyProperty PositionProperty = global::System.Windows.DependencyProperty.Register("Position", typeof(global::Infragistics.Windows.DataPresenter.SummaryPosition), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.SummaryPosition.Default));

		// Token: 0x04000CFD RID: 3325
		public static readonly global::System.Windows.DependencyProperty PositionFieldNameProperty = global::System.Windows.DependencyProperty.Register("PositionFieldName", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000CFE RID: 3326
		public static readonly global::System.Windows.DependencyProperty SourceFieldNameProperty = global::System.Windows.DependencyProperty.Register("SourceFieldName", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000CFF RID: 3327
		public static readonly global::System.Windows.DependencyProperty ToolTipProperty = global::System.Windows.DependencyProperty.Register("ToolTip", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000D00 RID: 3328
		internal static readonly global::System.Windows.DependencyProperty CalculationVersionProperty = global::System.Windows.DependencyProperty.Register("CalculationVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryDefinition.OnCalculationVersionChanged)));

		// Token: 0x020001EF RID: 495
		internal class SerializationInfo : global::Infragistics.Windows.DataPresenter.DependencyObjectSerializationInfo
		{
			// Token: 0x06001ED4 RID: 7892 RVA: 0x000875EC File Offset: 0x000857EC
			internal SerializationInfo() : base(typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.DependencyProperty[]
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.KeyProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.ToolTipProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculationSettingsProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.IsVisibleProperty
			})
			{
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00087664 File Offset: 0x00085864
			public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
			{
				get
				{
					if (this._props == null)
					{
						this._props = global::Infragistics.Windows.DataPresenter.GridUtilities.Aggregate<global::Infragistics.Windows.Internal.PropertySerializationInfo>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo>[]
						{
							base.SerializedProperties,
							new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Calculator")
							}
						});
					}
					return this._props;
				}
			}

			// Token: 0x06001ED6 RID: 7894 RVA: 0x000876C0 File Offset: 0x000858C0
			public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = (global::Infragistics.Windows.DataPresenter.SummaryDefinition)obj;
				global::System.Collections.Generic.Dictionary<string, object> dictionary = base.Serialize(summaryDefinition);
				global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator = summaryDefinition.Calculator;
				string value = (calculator != null) ? calculator.Name : null;
				if (calculator != null && !string.IsNullOrEmpty(value))
				{
					dictionary["Calculator"] = value;
				}
				return dictionary;
			}

			// Token: 0x06001ED7 RID: 7895 RVA: 0x00087708 File Offset: 0x00085908
			public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = (global::Infragistics.Windows.DataPresenter.SummaryDefinition)base.Deserialize(values);
				object obj;
				if (values.TryGetValue("Calculator", out obj))
				{
					summaryDefinition.Calculator = global::Infragistics.Windows.DataPresenter.SummaryCalculator.GetCalculator((string)obj);
				}
				return summaryDefinition;
			}

			// Token: 0x04000D05 RID: 3333
			private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> _props;
		}
	}
}
