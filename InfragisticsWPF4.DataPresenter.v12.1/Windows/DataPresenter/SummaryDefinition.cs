using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows.DataPresenter.Calculations;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C6 RID: 454
	public class SummaryDefinition : global::System.Windows.DependencyObject
	{
		// Token: 0x06001A89 RID: 6793 RVA: 0x000731EC File Offset: 0x000713EC
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

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x00073293 File Offset: 0x00071493
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x000732A5 File Offset: 0x000714A5
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

		// Token: 0x06001A8C RID: 6796 RVA: 0x000732B3 File Offset: 0x000714B3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCalculator()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculatorProperty, this);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000732C0 File Offset: 0x000714C0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCalculator()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculatorProperty);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000732D0 File Offset: 0x000714D0
		private static void OnCalculationSettingsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = target as global::Infragistics.Windows.DataPresenter.SummaryDefinition;
			summaryDefinition._calculationSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings);
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000732F6 File Offset: 0x000714F6
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x000732FE File Offset: 0x000714FE
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

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0007330C File Offset: 0x0007150C
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x0007331E File Offset: 0x0007151E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas>))]
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

		// Token: 0x06001A93 RID: 6803 RVA: 0x00073331 File Offset: 0x00071531
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayArea()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty, this);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0007333E File Offset: 0x0007153E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayArea()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty);
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x0007334B File Offset: 0x0007154B
		// (set) Token: 0x06001A96 RID: 6806 RVA: 0x0007335D File Offset: 0x0007155D
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

		// Token: 0x06001A97 RID: 6807 RVA: 0x0007336B File Offset: 0x0007156B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeStringFormat()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty, this);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00073378 File Offset: 0x00071578
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetStringFormat()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty);
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00073385 File Offset: 0x00071585
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x00073397 File Offset: 0x00071597
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

		// Token: 0x06001A9B RID: 6811 RVA: 0x000733A5 File Offset: 0x000715A5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeStringFormatProvider()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty, this);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000733B2 File Offset: 0x000715B2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetStringFormatProvider()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty);
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x000733BF File Offset: 0x000715BF
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x000733D1 File Offset: 0x000715D1
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

		// Token: 0x06001A9F RID: 6815 RVA: 0x000733E0 File Offset: 0x000715E0
		private static object OnCoerceKey(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			return (string)valueAsObject;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x000733F5 File Offset: 0x000715F5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeKey()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.KeyProperty, this);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00073402 File Offset: 0x00071602
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetKey()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.KeyProperty);
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0007340F File Offset: 0x0007160F
		public global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x00073417 File Offset: 0x00071617
		// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x00073429 File Offset: 0x00071629
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

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0007343C File Offset: 0x0007163C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePosition()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty, this);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00073449 File Offset: 0x00071649
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPosition()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty);
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x00073456 File Offset: 0x00071656
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x00073468 File Offset: 0x00071668
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

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00073476 File Offset: 0x00071676
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePositionFieldName()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty, this);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00073483 File Offset: 0x00071683
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPositionFieldName()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty);
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00073490 File Offset: 0x00071690
		// (set) Token: 0x06001AAC RID: 6828 RVA: 0x000734A2 File Offset: 0x000716A2
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

		// Token: 0x06001AAD RID: 6829 RVA: 0x000734B0 File Offset: 0x000716B0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSourceFieldName()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty, this);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000734BD File Offset: 0x000716BD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSourceFieldName()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty);
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x000734CA File Offset: 0x000716CA
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x000734D7 File Offset: 0x000716D7
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

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000734E5 File Offset: 0x000716E5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeToolTip()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.SummaryDefinition.ToolTipProperty, this);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000734F2 File Offset: 0x000716F2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetToolTip()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryDefinition.ToolTipProperty);
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x000734FF File Offset: 0x000716FF
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x00073507 File Offset: 0x00071707
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

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0007351C File Offset: 0x0007171C
		private static void OnCalculationVersionChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int cachedCalculationVersion = (int)e.NewValue;
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = (global::Infragistics.Windows.DataPresenter.SummaryDefinition)dependencyObject;
			summaryDefinition._cachedCalculationVersion = cachedCalculationVersion;
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00073544 File Offset: 0x00071744
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

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0007355B File Offset: 0x0007175B
		internal bool HasFormula
		{
			get
			{
				return this._calculationSettings != null && !string.IsNullOrEmpty(this._calculationSettings.Formula);
			}
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0007357A File Offset: 0x0007177A
		public void Refresh()
		{
			this.BumpCalculationVersion();
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00073582 File Offset: 0x00071782
		internal void BumpCalculationVersion()
		{
			this.CalculationVersion++;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x00073592 File Offset: 0x00071792
		internal void InternalSetParentCollection(global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection parentCollection)
		{
			this._parentCollection = parentCollection;
		}

		// Token: 0x04000B07 RID: 2823
		private global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection _parentCollection;

		// Token: 0x04000B08 RID: 2824
		private int _cachedCalculationVersion;

		// Token: 0x04000B09 RID: 2825
		public static readonly global::System.Windows.DependencyProperty CalculatorProperty = global::System.Windows.DependencyProperty.Register("Calculator", typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculator), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000B0A RID: 2826
		public static readonly global::System.Windows.DependencyProperty CalculationSettingsProperty = global::System.Windows.DependencyProperty.Register("CalculationSettings", typeof(global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryDefinition.OnCalculationSettingsChanged)));

		// Token: 0x04000B0B RID: 2827
		private global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings _calculationSettings;

		// Token: 0x04000B0C RID: 2828
		public static readonly global::System.Windows.DependencyProperty DisplayAreaProperty = global::System.Windows.DependencyProperty.Register("DisplayArea", typeof(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas?), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000B0D RID: 2829
		public static readonly global::System.Windows.DependencyProperty StringFormatProperty = global::System.Windows.DependencyProperty.Register("StringFormat", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000B0E RID: 2830
		public static readonly global::System.Windows.DependencyProperty StringFormatProviderProperty = global::System.Windows.DependencyProperty.Register("StringFormatProvider", typeof(global::System.IFormatProvider), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000B0F RID: 2831
		public static readonly global::System.Windows.DependencyProperty KeyProperty = global::System.Windows.DependencyProperty.Register("Key", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.SummaryDefinition.OnCoerceKey)));

		// Token: 0x04000B10 RID: 2832
		public static readonly global::System.Windows.DependencyProperty PositionProperty = global::System.Windows.DependencyProperty.Register("Position", typeof(global::Infragistics.Windows.DataPresenter.SummaryPosition), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.SummaryPosition.Default));

		// Token: 0x04000B11 RID: 2833
		public static readonly global::System.Windows.DependencyProperty PositionFieldNameProperty = global::System.Windows.DependencyProperty.Register("PositionFieldName", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000B12 RID: 2834
		public static readonly global::System.Windows.DependencyProperty SourceFieldNameProperty = global::System.Windows.DependencyProperty.Register("SourceFieldName", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000B13 RID: 2835
		public static readonly global::System.Windows.DependencyProperty ToolTipProperty = global::System.Windows.DependencyProperty.Register("ToolTip", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000B14 RID: 2836
		internal static readonly global::System.Windows.DependencyProperty CalculationVersionProperty = global::System.Windows.DependencyProperty.Register("CalculationVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryDefinition.OnCalculationVersionChanged)));

		// Token: 0x020001C8 RID: 456
		internal class SerializationInfo : global::Infragistics.Windows.DataPresenter.DependencyObjectSerializationInfo
		{
			// Token: 0x06001AC2 RID: 6850 RVA: 0x000738D4 File Offset: 0x00071AD4
			internal SerializationInfo() : base(typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::System.Windows.DependencyProperty[]
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.KeyProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.DisplayAreaProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionFieldNameProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.PositionProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.SourceFieldNameProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.StringFormatProviderProperty,
				global::Infragistics.Windows.DataPresenter.SummaryDefinition.ToolTipProperty
			})
			{
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0007393C File Offset: 0x00071B3C
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

			// Token: 0x06001AC4 RID: 6852 RVA: 0x00073998 File Offset: 0x00071B98
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

			// Token: 0x06001AC5 RID: 6853 RVA: 0x000739E0 File Offset: 0x00071BE0
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

			// Token: 0x04000B19 RID: 2841
			private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> _props;
		}
	}
}
