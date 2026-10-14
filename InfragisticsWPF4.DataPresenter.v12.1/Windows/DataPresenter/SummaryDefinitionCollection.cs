using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C9 RID: 457
	public class SummaryDefinitionCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.SummaryDefinition>
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x00073A1B File Offset: 0x00071C1B
		internal SummaryDefinitionCollection(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			this._fieldLayout = fieldLayout;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00073A30 File Offset: 0x00071C30
		protected override void ClearItems()
		{
			foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition item in this)
			{
				this.OnItemBeingAddedOrRemoved(item, false);
			}
			base.ClearItems();
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00073A80 File Offset: 0x00071C80
		protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.SummaryDefinition item)
		{
			this.OnItemBeingAddedOrRemoved(item, true);
			base.InsertItem(index, item);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00073A92 File Offset: 0x00071C92
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.BumpCollectionVersion();
			base.OnCollectionChanged(e);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00073AA1 File Offset: 0x00071CA1
		protected override void RemoveItem(int index)
		{
			this.OnItemBeingAddedOrRemoved(base[index], false);
			base.RemoveItem(index);
		}

		// Token: 0x17000757 RID: 1879
		public global::Infragistics.Windows.DataPresenter.SummaryDefinition this[string key]
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition item = this.GetItem(key);
				if (item == null)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.RaiseKeyNotFound();
				}
				return item;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x00073AD6 File Offset: 0x00071CD6
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00073ADE File Offset: 0x00071CDE
		internal int CollectionVersion
		{
			get
			{
				return this._collectionVersion;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x00073AE6 File Offset: 0x00071CE6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int SummariesVersion
		{
			get
			{
				return this._summariesVersion;
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00073AF0 File Offset: 0x00071CF0
		public global::Infragistics.Windows.DataPresenter.SummaryDefinition Add(string summaryKey, global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator, string sourceFieldName)
		{
			this.ValidateKeyDoesntExist(summaryKey);
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = new global::Infragistics.Windows.DataPresenter.SummaryDefinition();
			summaryDefinition.Key = summaryKey;
			summaryDefinition.Calculator = calculator;
			summaryDefinition.SourceFieldName = sourceFieldName;
			base.Add(summaryDefinition);
			return summaryDefinition;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00073B27 File Offset: 0x00071D27
		public global::Infragistics.Windows.DataPresenter.SummaryDefinition Add(global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator, string sourceFieldName)
		{
			return this.Add(null, calculator, sourceFieldName);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00073B34 File Offset: 0x00071D34
		public bool Exists(string key)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDefinition item = this.GetItem(key);
			return null != item;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00073B50 File Offset: 0x00071D50
		public void Refresh()
		{
			this.BumpDataVersion();
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00073B58 File Offset: 0x00071D58
		private void BumpCollectionVersion()
		{
			this._collectionVersion++;
			this.BumpSummariesVersion();
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00073B70 File Offset: 0x00071D70
		internal void BumpDataVersion()
		{
			for (int i = 0; i < base.Count; i++)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = base[i];
				summaryDefinition.BumpCalculationVersion();
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00073B9C File Offset: 0x00071D9C
		internal void BumpSummariesVersion()
		{
			this._summariesVersion++;
			this.RaisePropertyChanged("SummariesVersion");
			this.FieldLayout.BumpSpecialRecordsVersion();
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00073BC4 File Offset: 0x00071DC4
		internal global::Infragistics.Windows.DataPresenter.SummaryDefinition GetItem(string key)
		{
			if (!string.IsNullOrEmpty(key))
			{
				foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition in this)
				{
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreKeysEqual(summaryDefinition.Key, key))
					{
						return summaryDefinition;
					}
				}
			}
			return null;
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00073C94 File Offset: 0x00071E94
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryDefinition> GetMatchingSummaries(global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator, global::Infragistics.Windows.DataPresenter.Field sourceField)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(this, delegate(global::Infragistics.Windows.DataPresenter.SummaryDefinition def)
			{
				if (calculator != null && (def.Calculator == null || calculator.Name != def.Calculator.Name))
				{
					return false;
				}
				if (sourceField != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(sourceField.Owner, def.SourceFieldName, false);
					if (sourceField != field)
					{
						return false;
					}
				}
				return true;
			});
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00073CC7 File Offset: 0x00071EC7
		internal void InternalSetFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00073CD0 File Offset: 0x00071ED0
		private void OnItemBeingAddedOrRemoved(global::Infragistics.Windows.DataPresenter.SummaryDefinition item, bool added)
		{
			if (!added)
			{
				item.InternalSetParentCollection(null);
				return;
			}
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(item);
			if (item.ParentCollection != null)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_SummaryDefinitionAlreadyInCollection", new object[]
				{
					item
				}));
			}
			item.InternalSetParentCollection(this);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00073D19 File Offset: 0x00071F19
		internal void RaisePropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00073D28 File Offset: 0x00071F28
		internal void RefreshSummariesAffectedBySort()
		{
			foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition in this)
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator = summaryDefinition.Calculator;
				if (calculator != null && calculator.IsCalculationAffectedBySort)
				{
					summaryDefinition.Refresh();
				}
			}
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00073D84 File Offset: 0x00071F84
		private void ValidateKeyDoesntExist(string key)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDefinition item = this.GetItem(key);
			if (item != null)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_DuplicateSummaryDefinitionKey", new object[]
				{
					key
				}));
			}
		}

		// Token: 0x04000B1A RID: 2842
		private int _summariesVersion;

		// Token: 0x04000B1B RID: 2843
		private int _collectionVersion;

		// Token: 0x04000B1C RID: 2844
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;
	}
}
