using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000154 RID: 340
	public class SummaryRowSettingsOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase, global::System.IDisposable
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00029408 File Offset: 0x00027608
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.SummaryRowSettings;
				}
				return result;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00029436 File Offset: 0x00027636
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00029448 File Offset: 0x00027648
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.SummaryRowLocation>))]
		public global::Infragistics.Controls.Grids.SummaryRowLocation? AllowSummaryRow
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SummaryRowLocation?)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.AllowSummaryRowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.AllowSummaryRowProperty, value);
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0002945C File Offset: 0x0002765C
		private static void AllowSummaryRowChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettingsOverride = (global::Infragistics.Controls.Grids.SummaryRowSettingsOverride)obj;
			summaryRowSettingsOverride.OnPropertyChanged("AllowSummaryRow");
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0002947C File Offset: 0x0002767C
		public global::Infragistics.Controls.Grids.SummaryRowLocation AllowSummaryRowResolved
		{
			get
			{
				if (this.AllowSummaryRow != null)
				{
					return this.AllowSummaryRow.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SummaryRowSettings)this.SettingsObject).AllowSummaryRow;
				}
				return (global::Infragistics.Controls.Grids.SummaryRowLocation)global::Infragistics.Controls.Grids.SummaryRowSettings.AllowSummaryRowProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.SummaryRowSettings)).DefaultValue;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x000294DF File Offset: 0x000276DF
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x000294F1 File Offset: 0x000276F1
		public global::System.Windows.Style ExpansionIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.ExpansionIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.ExpansionIndicatorStyleProperty, value);
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00029500 File Offset: 0x00027700
		private static void ExpansionIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettingsOverride = (global::Infragistics.Controls.Grids.SummaryRowSettingsOverride)obj;
			if (summaryRowSettingsOverride.ColumnLayout != null && summaryRowSettingsOverride.ColumnLayout.Grid != null)
			{
				summaryRowSettingsOverride.ColumnLayout.Grid.ResetPanelRows();
			}
			summaryRowSettingsOverride.OnPropertyChanged("ExpansionIndicatorStyle");
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00029544 File Offset: 0x00027744
		public global::System.Windows.Style ExpansionIndicatorStyleResolved
		{
			get
			{
				if (this.ExpansionIndicatorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SummaryRowSettings)this.SettingsObject).ExpansionIndicatorStyle;
				}
				return this.ExpansionIndicatorStyle;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0002956D File Offset: 0x0002776D
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x0002957F File Offset: 0x0002777F
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.StyleProperty, value);
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00029590 File Offset: 0x00027790
		private static void StyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettingsOverride = (global::Infragistics.Controls.Grids.SummaryRowSettingsOverride)obj;
			summaryRowSettingsOverride.OnPropertyChanged("Style");
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000295AF File Offset: 0x000277AF
		public global::System.Windows.Style StyleResolved
		{
			get
			{
				if (this.Style == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SummaryRowSettings)this.SettingsObject).Style;
				}
				return this.Style;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000295D8 File Offset: 0x000277D8
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x000295EA File Offset: 0x000277EA
		public global::System.Windows.Style RowSelectorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.RowSelectorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.RowSelectorStyleProperty, value);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000295F8 File Offset: 0x000277F8
		private static void RowSelectorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettingsOverride = (global::Infragistics.Controls.Grids.SummaryRowSettingsOverride)obj;
			summaryRowSettingsOverride.OnPropertyChanged("RowSelectorStyle");
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00029617 File Offset: 0x00027817
		public global::System.Windows.Style RowSelectorStyleResolved
		{
			get
			{
				if (this.RowSelectorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SummaryRowSettings)this.SettingsObject).RowSelectorStyle;
				}
				return this.RowSelectorStyle;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00029640 File Offset: 0x00027840
		public global::Infragistics.SummaryDefinitionCollection SummaryDefinitionCollection
		{
			get
			{
				if (this._summaryDefinitionCollection == null)
				{
					this._summaryDefinitionCollection = new global::Infragistics.SummaryDefinitionCollection();
					this._summaryDefinitionCollection.CollectionChanged += this.SummaryDefinitionCollection_CollectionChanged;
				}
				return this._summaryDefinitionCollection;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00029672 File Offset: 0x00027872
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00029684 File Offset: 0x00027884
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.SummaryScope>))]
		public global::Infragistics.Controls.Grids.SummaryScope? SummaryScope
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SummaryScope?)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.SummaryScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.SummaryScopeProperty, value);
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00029698 File Offset: 0x00027898
		private static void SummaryScopeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettingsOverride = (global::Infragistics.Controls.Grids.SummaryRowSettingsOverride)obj;
			summaryRowSettingsOverride.OnPropertyChanged("SummaryScope");
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000296B8 File Offset: 0x000278B8
		public global::Infragistics.Controls.Grids.SummaryScope SummaryScopeResolved
		{
			get
			{
				if (this.SummaryScope != null)
				{
					return this.SummaryScope.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SummaryRowSettings)this.SettingsObject).SummaryScope;
				}
				return (global::Infragistics.Controls.Grids.SummaryScope)global::Infragistics.Controls.Grids.SummaryRowSettings.SummaryScopeProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.SummaryRowSettings)).DefaultValue;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0002971B File Offset: 0x0002791B
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x0002972D File Offset: 0x0002792D
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.SummaryExecution>))]
		public global::Infragistics.SummaryExecution? SummaryExecution
		{
			get
			{
				return (global::Infragistics.SummaryExecution?)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.SummaryExecutionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.SummaryExecutionProperty, value);
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00029740 File Offset: 0x00027940
		private static void SummaryExecutionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettingsOverride = (global::Infragistics.Controls.Grids.SummaryRowSettingsOverride)obj;
			summaryRowSettingsOverride.OnPropertyChanged("SummaryExecution");
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00029760 File Offset: 0x00027960
		public global::Infragistics.SummaryExecution SummaryExecutionResolved
		{
			get
			{
				if (this.SummaryExecution != null)
				{
					return this.SummaryExecution.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SummaryRowSettings)this.SettingsObject).SummaryExecution;
				}
				return (global::Infragistics.SummaryExecution)global::Infragistics.Controls.Grids.SummaryRowSettings.SummaryExecutionProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.SummaryRowSettings)).DefaultValue;
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000297C3 File Offset: 0x000279C3
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x000297D2 File Offset: 0x000279D2
		protected virtual void Dispose(bool disposing)
		{
			if (this._summaryDefinitionCollection != null)
			{
				this._summaryDefinitionCollection.CollectionChanged -= this.SummaryDefinitionCollection_CollectionChanged;
				this._summaryDefinitionCollection.Dispose();
				this._summaryDefinitionCollection = null;
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00029805 File Offset: 0x00027A05
		private void SummaryDefinitionCollection_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnPropertyChanged("InvalidateSummaries");
		}

		// Token: 0x040002A9 RID: 681
		private global::Infragistics.SummaryDefinitionCollection _summaryDefinitionCollection;

		// Token: 0x040002AA RID: 682
		public static readonly global::System.Windows.DependencyProperty AllowSummaryRowProperty = global::System.Windows.DependencyProperty.Register("AllowSummaryRow", typeof(global::Infragistics.Controls.Grids.SummaryRowLocation?), typeof(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.AllowSummaryRowChanged)));

		// Token: 0x040002AB RID: 683
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.ExpansionIndicatorStyleChanged)));

		// Token: 0x040002AC RID: 684
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.StyleChanged)));

		// Token: 0x040002AD RID: 685
		public static readonly global::System.Windows.DependencyProperty RowSelectorStyleProperty = global::System.Windows.DependencyProperty.Register("RowSelectorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.RowSelectorStyleChanged)));

		// Token: 0x040002AE RID: 686
		public static readonly global::System.Windows.DependencyProperty SummaryScopeProperty = global::System.Windows.DependencyProperty.Register("SummaryScope", typeof(global::Infragistics.Controls.Grids.SummaryScope?), typeof(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.SummaryScopeChanged)));

		// Token: 0x040002AF RID: 687
		public static readonly global::System.Windows.DependencyProperty SummaryExecutionProperty = global::System.Windows.DependencyProperty.Register("SummaryExecution", typeof(global::Infragistics.SummaryExecution?), typeof(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride.SummaryExecutionChanged)));
	}
}
