using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200014A RID: 330
	public class SummaryColumnSettings : global::Infragistics.Controls.Grids.ColumnSettings, global::System.IDisposable
	{
		// Token: 0x06000AA4 RID: 2724 RVA: 0x00028597 File Offset: 0x00026797
		public SummaryColumnSettings(global::Infragistics.Controls.Grids.Column column)
		{
			base.Column = column;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000285B1 File Offset: 0x000267B1
		public SummaryColumnSettings()
		{
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x000285C4 File Offset: 0x000267C4
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00028630 File Offset: 0x00026830
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.SummaryOperandCollection SummaryOperands
		{
			get
			{
				if (this._summaryOperands == null)
				{
					this._summaryOperands = new global::Infragistics.SummaryOperandCollection();
					this._summaryOperands.CollectionChanged += this.SummaryOperands_CollectionChanged;
					if (this.Column != null)
					{
						this.Column.FillAvailableSummaries(this._summaryOperands);
						this._autopopulatedSummaryOperands = (this._summaryOperands.Count > 0);
					}
				}
				return this._summaryOperands;
			}
			set
			{
				if (this._summaryOperands != value)
				{
					if (this._summaryOperands != null)
					{
						this._summaryOperands.CollectionChanged -= this.SummaryOperands_CollectionChanged;
						foreach (global::Infragistics.SummaryOperandBase sob in this._summaryOperands)
						{
							global::Infragistics.Controls.Grids.SummaryColumnSettings.RemoveSummaryDefinition(this.Column.ColumnLayout.SummaryRowSettings, sob);
						}
					}
					this._summaryOperands = value;
					if (value != null)
					{
						this.RepopulateSummaryDefinitionCollection();
						this._summaryOperands.CollectionChanged += this.SummaryOperands_CollectionChanged;
					}
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x000286E0 File Offset: 0x000268E0
		public global::Infragistics.SummaryDefinitionCollection GroupBySummaryDefinitions
		{
			get
			{
				if (this._groupBySummaryDefinitions == null)
				{
					this._groupBySummaryDefinitions = new global::Infragistics.SummaryDefinitionCollection();
					this._groupBySummaryDefinitions.CollectionChanged += this.GroupBySummaryDefinitions_CollectionChanged;
				}
				return this._groupBySummaryDefinitions;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00028712 File Offset: 0x00026912
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00028724 File Offset: 0x00026924
		public global::System.Windows.Style SummaryRowCellStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.SummaryColumnSettings.SummaryRowCellStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SummaryColumnSettings.SummaryRowCellStyleProperty, value);
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00028734 File Offset: 0x00026934
		private static void SummaryRowCellStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SummaryColumnSettings summaryColumnSettings = (global::Infragistics.Controls.Grids.SummaryColumnSettings)obj;
			if (summaryColumnSettings.Column != null)
			{
				summaryColumnSettings.Column.OnStyleChanged();
			}
			summaryColumnSettings.OnPropertyChanged("SummaryRowCellStyle");
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00028766 File Offset: 0x00026966
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00028775 File Offset: 0x00026975
		protected virtual void Dispose(bool disposing)
		{
			if (this._summaryOperands != null)
			{
				this._summaryOperands.Dispose();
				this._summaryOperands = null;
			}
			if (this._summaryOperandsFromXaml != null)
			{
				this._summaryOperandsFromXaml.Dispose();
				this._summaryOperandsFromXaml = null;
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000287AC File Offset: 0x000269AC
		protected internal override void OnLoadedCatchUp()
		{
			if (this._summaryOperandsFromXaml != null && this._summaryOperandsFromXaml.Count > 0)
			{
				foreach (global::Infragistics.SummaryOperandBase sob in this._summaryOperandsFromXaml)
				{
					this.ModifySummaryDefinitionCollectionFromOnApplied(sob);
				}
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00028810 File Offset: 0x00026A10
		protected internal void ValidateSummaryOperands()
		{
			if (this._autopopulatedSummaryOperands && this.Column != null)
			{
				this._autopopulatedSummaryOperands = true;
				this._summaryOperands.Clear();
				this.Column.FillAvailableSummaries(this._summaryOperands);
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00028848 File Offset: 0x00026A48
		private void AddSummaryDefinition(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride srso, global::Infragistics.SummaryOperandBase sob)
		{
			if (srso.ColumnLayout != null && srso.ColumnLayout.Grid != null && srso.SummaryScopeResolved == global::Infragistics.Controls.Grids.SummaryScope.ColumnLayout)
			{
				bool flag = false;
				foreach (global::Infragistics.SummaryDefinition summaryDefinition in srso.SummaryDefinitionCollection)
				{
					if (summaryDefinition.SummaryOperand == sob)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					if (srso.ColumnLayout.Grid.IsLoaded)
					{
						srso.SummaryDefinitionCollection.Add(new global::Infragistics.SummaryDefinition
						{
							SummaryOperand = sob,
							ColumnKey = this.Column.Key
						});
						return;
					}
					srso.SummaryDefinitionCollection.AddItemSilently(new global::Infragistics.SummaryDefinition
					{
						SummaryOperand = sob,
						ColumnKey = this.Column.Key
					});
				}
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00028934 File Offset: 0x00026B34
		private static void RemoveSummaryDefinition(global::Infragistics.Controls.Grids.SummaryRowSettingsOverride srso, global::Infragistics.SummaryOperandBase sob)
		{
			if (srso.ColumnLayout != null && srso.ColumnLayout.Grid != null && srso.SummaryScopeResolved == global::Infragistics.Controls.Grids.SummaryScope.ColumnLayout)
			{
				global::Infragistics.SummaryDefinition summaryDefinition = null;
				foreach (global::Infragistics.SummaryDefinition summaryDefinition2 in srso.SummaryDefinitionCollection)
				{
					if (summaryDefinition2.SummaryOperand == sob)
					{
						summaryDefinition = summaryDefinition2;
						break;
					}
				}
				if (summaryDefinition != null)
				{
					srso.SummaryDefinitionCollection.Remove(summaryDefinition);
				}
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000289B8 File Offset: 0x00026BB8
		private void ModifySummaryDefinitionCollectionFromOnApplied(global::Infragistics.SummaryOperandBase sob)
		{
			if (this.Column != null && this.Column.ColumnLayout != null)
			{
				global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettings = this.Column.ColumnLayout.SummaryRowSettings;
				if (sob.IsApplied)
				{
					this.AddSummaryDefinition(summaryRowSettings, sob);
					return;
				}
				global::Infragistics.Controls.Grids.SummaryColumnSettings.RemoveSummaryDefinition(summaryRowSettings, sob);
				return;
			}
			else
			{
				if (sob.IsApplied)
				{
					this._summaryOperandsFromXaml.Add(sob);
					return;
				}
				if (this._summaryOperandsFromXaml.Contains(sob))
				{
					this._summaryOperandsFromXaml.Remove(sob);
				}
				return;
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00028A3C File Offset: 0x00026C3C
		internal void RepopulateSummaryDefinitionCollection()
		{
			global::Infragistics.Controls.Grids.Column column = this.Column;
			if (column != null)
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
				if (columnLayout != null)
				{
					global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettings = columnLayout.SummaryRowSettings;
					foreach (global::Infragistics.SummaryOperandBase summaryOperandBase in this.SummaryOperands)
					{
						if (summaryOperandBase.IsApplied)
						{
							this.AddSummaryDefinition(summaryRowSettings, summaryOperandBase);
						}
					}
				}
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00028AC8 File Offset: 0x00026CC8
		private void SummaryOperands_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.SummaryOperandBase summaryOperandBase = (global::Infragistics.SummaryOperandBase)obj;
						this._weakPropertyChangedHandler = new global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.SummaryColumnSettings>(this, summaryOperandBase, delegate(global::Infragistics.Controls.Grids.SummaryColumnSettings instance, object s, global::System.ComponentModel.PropertyChangedEventArgs ev)
						{
							instance.SummaryOperandBase_PropertyChanged(s, ev);
						});
						summaryOperandBase.PropertyChanged += this._weakPropertyChangedHandler.OnEvent;
						this.ModifySummaryDefinitionCollectionFromOnApplied(summaryOperandBase);
					}
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				goto IL_149;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				return;
			default:
				return;
			}
			if (e.OldItems == null)
			{
				return;
			}
			using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					global::Infragistics.SummaryOperandBase sob = (global::Infragistics.SummaryOperandBase)obj2;
					if (this._weakPropertyChangedHandler != null)
					{
						this._weakPropertyChangedHandler.Detach();
					}
					if (this.Column != null && this.Column.ColumnLayout != null && this.Column.ColumnLayout.SummaryRowSettings != null)
					{
						global::Infragistics.Controls.Grids.SummaryColumnSettings.RemoveSummaryDefinition(this.Column.ColumnLayout.SummaryRowSettings, sob);
					}
				}
				return;
			}
			IL_149:
			foreach (object obj3 in e.OldItems)
			{
				global::Infragistics.SummaryOperandBase sob2 = (global::Infragistics.SummaryOperandBase)obj3;
				if (this._weakPropertyChangedHandler != null)
				{
					this._weakPropertyChangedHandler.Detach();
				}
				if (this.Column != null && this.Column.ColumnLayout != null && this.Column.ColumnLayout.SummaryRowSettings != null)
				{
					global::Infragistics.Controls.Grids.SummaryColumnSettings.RemoveSummaryDefinition(this.Column.ColumnLayout.SummaryRowSettings, sob2);
				}
			}
			foreach (object obj4 in e.NewItems)
			{
				global::Infragistics.SummaryOperandBase summaryOperandBase2 = (global::Infragistics.SummaryOperandBase)obj4;
				this._weakPropertyChangedHandler = new global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.SummaryColumnSettings>(this, summaryOperandBase2, delegate(global::Infragistics.Controls.Grids.SummaryColumnSettings instance, object s, global::System.ComponentModel.PropertyChangedEventArgs ev)
				{
					instance.SummaryOperandBase_PropertyChanged(s, ev);
				});
				summaryOperandBase2.PropertyChanged += this._weakPropertyChangedHandler.OnEvent;
				this.ModifySummaryDefinitionCollectionFromOnApplied(summaryOperandBase2);
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00028D70 File Offset: 0x00026F70
		private void SummaryOperandBase_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.SummaryOperandBase sob = (global::Infragistics.SummaryOperandBase)sender;
			if (e.PropertyName == "IsApplied")
			{
				this.ModifySummaryDefinitionCollectionFromOnApplied(sob);
				return;
			}
			base.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00028DAC File Offset: 0x00026FAC
		private void GroupBySummaryDefinitions_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.Column != null && this.Column.IsGroupBy && this.Column.ColumnLayout != null && this.Column.ColumnLayout.Grid != null && this.Column.ColumnLayout.Grid.IsLoaded)
			{
				this.Column.ColumnLayout.Grid.InvalidateData();
			}
		}

		// Token: 0x04000295 RID: 661
		private global::Infragistics.SummaryOperandCollection _summaryOperands;

		// Token: 0x04000296 RID: 662
		private global::Infragistics.SummaryDefinitionCollection _groupBySummaryDefinitions;

		// Token: 0x04000297 RID: 663
		private global::Infragistics.SummaryOperandCollection _summaryOperandsFromXaml = new global::Infragistics.SummaryOperandCollection();

		// Token: 0x04000298 RID: 664
		private bool _autopopulatedSummaryOperands;

		// Token: 0x04000299 RID: 665
		private global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.SummaryColumnSettings> _weakPropertyChangedHandler;

		// Token: 0x0400029A RID: 666
		public static readonly global::System.Windows.DependencyProperty SummaryRowCellStyleProperty = global::System.Windows.DependencyProperty.Register("SummaryRowCellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.SummaryColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SummaryColumnSettings.SummaryRowCellStyleChanged)));
	}
}
