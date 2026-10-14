using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000153 RID: 339
	public class SummaryRowSettings : global::Infragistics.Controls.Grids.SettingsBase, global::System.IDisposable
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0002901F File Offset: 0x0002721F
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00029031 File Offset: 0x00027231
		public global::Infragistics.Controls.Grids.SummaryRowLocation AllowSummaryRow
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SummaryRowLocation)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.AllowSummaryRowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.AllowSummaryRowProperty, value);
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00029044 File Offset: 0x00027244
		private static void AllowSummaryRowChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettings summaryRowSettings = (global::Infragistics.Controls.Grids.SummaryRowSettings)obj;
			summaryRowSettings.OnPropertyChanged("AllowSummaryRow");
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00029063 File Offset: 0x00027263
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00029075 File Offset: 0x00027275
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.StyleProperty, value);
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00029084 File Offset: 0x00027284
		private static void StyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettings summaryRowSettings = (global::Infragistics.Controls.Grids.SummaryRowSettings)obj;
			summaryRowSettings.OnPropertyChanged("Style");
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000290A3 File Offset: 0x000272A3
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x000290B5 File Offset: 0x000272B5
		public global::System.Windows.Style ExpansionIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.ExpansionIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.ExpansionIndicatorStyleProperty, value);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000290C4 File Offset: 0x000272C4
		private static void ExpansionIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettings summaryRowSettings = (global::Infragistics.Controls.Grids.SummaryRowSettings)obj;
			if (summaryRowSettings.Grid != null)
			{
				summaryRowSettings.Grid.ResetPanelRows();
			}
			summaryRowSettings.OnPropertyChanged("ExpansionIndicatorStyle");
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x000290F6 File Offset: 0x000272F6
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00029108 File Offset: 0x00027308
		public global::System.Windows.Style RowSelectorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.RowSelectorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.RowSelectorStyleProperty, value);
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00029118 File Offset: 0x00027318
		private static void RowSelectorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettings summaryRowSettings = (global::Infragistics.Controls.Grids.SummaryRowSettings)obj;
			summaryRowSettings.OnPropertyChanged("RowSelectorStyle");
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00029137 File Offset: 0x00027337
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00029149 File Offset: 0x00027349
		public global::Infragistics.Controls.Grids.SummaryScope SummaryScope
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SummaryScope)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.SummaryScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.SummaryScopeProperty, value);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0002915C File Offset: 0x0002735C
		private static void SummaryScopeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettings summaryRowSettings = (global::Infragistics.Controls.Grids.SummaryRowSettings)obj;
			summaryRowSettings.OnPropertyChanged("SummaryScope");
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0002917B File Offset: 0x0002737B
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x0002918D File Offset: 0x0002738D
		public global::Infragistics.SummaryExecution SummaryExecution
		{
			get
			{
				return (global::Infragistics.SummaryExecution)base.GetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.SummaryExecutionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryRowSettings.SummaryExecutionProperty, value);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x000291A0 File Offset: 0x000273A0
		private static void SummaryExecutionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryRowSettings summaryRowSettings = (global::Infragistics.Controls.Grids.SummaryRowSettings)obj;
			summaryRowSettings.OnPropertyChanged("SummaryExecution");
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x000291BF File Offset: 0x000273BF
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.SummaryDefinitionCollection SummaryDefinitionCollection
		{
			get
			{
				if (base.Grid == null)
				{
					if (this._xamlParsingCollection == null)
					{
						this._xamlParsingCollection = new global::Infragistics.SummaryDefinitionCollection();
					}
					return this._xamlParsingCollection;
				}
				return base.Grid.RowsManager.SummaryDefinitionCollectionResolved;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x000291F3 File Offset: 0x000273F3
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryResult> SummaryResultCollection
		{
			get
			{
				if (base.Grid != null)
				{
					return base.Grid.RowsManager.SummaryResultCollection;
				}
				return null;
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00029210 File Offset: 0x00027410
		protected override void OnGridSet()
		{
			if (this._xamlParsingCollection != null)
			{
				global::Infragistics.SummaryDefinitionCollection summaryDefinitionCollection = this.SummaryDefinitionCollection;
				for (int i = this._xamlParsingCollection.Count - 1; i >= 0; i--)
				{
					global::Infragistics.SummaryDefinition item = this._xamlParsingCollection[i];
					this._xamlParsingCollection.Remove(item);
					summaryDefinitionCollection.Insert(0, item);
				}
				this._xamlParsingCollection.Clear();
			}
			base.OnGridSet();
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00029277 File Offset: 0x00027477
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00029286 File Offset: 0x00027486
		protected virtual void Dispose(bool disposing)
		{
			if (this._xamlParsingCollection != null)
			{
				this._xamlParsingCollection.Dispose();
				this._xamlParsingCollection = null;
			}
		}

		// Token: 0x040002A2 RID: 674
		private global::Infragistics.SummaryDefinitionCollection _xamlParsingCollection;

		// Token: 0x040002A3 RID: 675
		public static readonly global::System.Windows.DependencyProperty AllowSummaryRowProperty = global::System.Windows.DependencyProperty.Register("AllowSummaryRow", typeof(global::Infragistics.Controls.Grids.SummaryRowLocation), typeof(global::Infragistics.Controls.Grids.SummaryRowSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.SummaryRowLocation.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettings.AllowSummaryRowChanged)));

		// Token: 0x040002A4 RID: 676
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.SummaryRowSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettings.StyleChanged)));

		// Token: 0x040002A5 RID: 677
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.SummaryRowSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettings.ExpansionIndicatorStyleChanged)));

		// Token: 0x040002A6 RID: 678
		public static readonly global::System.Windows.DependencyProperty RowSelectorStyleProperty = global::System.Windows.DependencyProperty.Register("RowSelectorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.SummaryRowSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettings.RowSelectorStyleChanged)));

		// Token: 0x040002A7 RID: 679
		public static readonly global::System.Windows.DependencyProperty SummaryScopeProperty = global::System.Windows.DependencyProperty.Register("SummaryScope", typeof(global::Infragistics.Controls.Grids.SummaryScope), typeof(global::Infragistics.Controls.Grids.SummaryRowSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.SummaryScope.ColumnLayout, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettings.SummaryScopeChanged)));

		// Token: 0x040002A8 RID: 680
		public static readonly global::System.Windows.DependencyProperty SummaryExecutionProperty = global::System.Windows.DependencyProperty.Register("SummaryExecution", typeof(global::Infragistics.SummaryExecution), typeof(global::Infragistics.Controls.Grids.SummaryRowSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.SummaryExecution.PriorToFilteringAndPaging, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryRowSettings.SummaryExecutionChanged)));
	}
}
