using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001F0 RID: 496
	public class SummaryDefinitionCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.SummaryDefinition>
	{
		// Token: 0x06001ED8 RID: 7896 RVA: 0x00087743 File Offset: 0x00085943
		internal SummaryDefinitionCollection(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			this._fieldLayout = fieldLayout;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00087758 File Offset: 0x00085958
		protected override void ClearItems()
		{
			foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition item in this)
			{
				this.OnItemBeingAddedOrRemoved(item, false);
			}
			base.ClearItems();
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000877A8 File Offset: 0x000859A8
		protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.SummaryDefinition item)
		{
			this.OnItemBeingAddedOrRemoved(item, true);
			base.InsertItem(index, item);
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000877BA File Offset: 0x000859BA
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.BumpCollectionVersion();
			base.OnCollectionChanged(e);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000877C9 File Offset: 0x000859C9
		protected override void RemoveItem(int index)
		{
			this.OnItemBeingAddedOrRemoved(base[index], false);
			base.RemoveItem(index);
		}

		// Token: 0x170008DE RID: 2270
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

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x000877FE File Offset: 0x000859FE
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00087806 File Offset: 0x00085A06
		internal int CollectionVersion
		{
			get
			{
				return this._collectionVersion;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x0008780E File Offset: 0x00085A0E
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int SummariesVersion
		{
			get
			{
				return this._summariesVersion;
			}
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00087816 File Offset: 0x00085A16
		public global::Infragistics.Windows.DataPresenter.SummaryDefinition Add(string summaryKey, global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator, string sourceFieldName)
		{
			return this.AddInternal(summaryKey, calculator, sourceFieldName, false);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00087824 File Offset: 0x00085A24
		internal global::Infragistics.Windows.DataPresenter.SummaryDefinition AddInternal(string summaryKey, global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator, string sourceFieldName, bool isCalculatorRegistered)
		{
			this.ValidateKeyDoesntExist(summaryKey);
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = new global::Infragistics.Windows.DataPresenter.SummaryDefinition();
			summaryDefinition.Key = summaryKey;
			summaryDefinition.Calculator = calculator;
			summaryDefinition.SourceFieldName = sourceFieldName;
			summaryDefinition.IsCalculatorRegistered = isCalculatorRegistered;
			base.Add(summaryDefinition);
			return summaryDefinition;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00087863 File Offset: 0x00085A63
		public global::Infragistics.Windows.DataPresenter.SummaryDefinition Add(global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator, string sourceFieldName)
		{
			return this.Add(null, calculator, sourceFieldName);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00087870 File Offset: 0x00085A70
		public bool Exists(string key)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDefinition item = this.GetItem(key);
			return null != item;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0008788C File Offset: 0x00085A8C
		public void Refresh()
		{
			this.BumpDataVersion();
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00087894 File Offset: 0x00085A94
		private void BumpCollectionVersion()
		{
			this._collectionVersion++;
			this.BumpSummariesVersion();
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000878AC File Offset: 0x00085AAC
		internal void BumpDataVersion()
		{
			for (int i = 0; i < base.Count; i++)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = base[i];
				summaryDefinition.BumpCalculationVersion();
			}
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000878D8 File Offset: 0x00085AD8
		internal void BumpSummariesVersion()
		{
			this._summariesVersion++;
			this.RaisePropertyChanged("SummariesVersion");
			this.FieldLayout.BumpSpecialRecordsVersion();
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00087900 File Offset: 0x00085B00
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

		// Token: 0x06001EEA RID: 7914 RVA: 0x000879D0 File Offset: 0x00085BD0
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

		// Token: 0x06001EEB RID: 7915 RVA: 0x00087A03 File Offset: 0x00085C03
		internal void InternalSetFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00087A0C File Offset: 0x00085C0C
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

		// Token: 0x06001EED RID: 7917 RVA: 0x00087A55 File Offset: 0x00085C55
		internal void RaisePropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00087A64 File Offset: 0x00085C64
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

		// Token: 0x06001EEF RID: 7919 RVA: 0x00087AC0 File Offset: 0x00085CC0
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

		// Token: 0x04000D06 RID: 3334
		private int _summariesVersion;

		// Token: 0x04000D07 RID: 3335
		private int _collectionVersion;

		// Token: 0x04000D08 RID: 3336
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;
	}
}
