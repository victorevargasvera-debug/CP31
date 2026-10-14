using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Threading;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D8 RID: 472
	public class SummaryResultCollection : global::Infragistics.PropertyChangeNotifier, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryResult>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.SummaryResult>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06001C1D RID: 7197 RVA: 0x0007F0DA File Offset: 0x0007D2DA
		internal SummaryResultCollection(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitions)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(summaryDefinitions);
			this._records = records;
			this._fieldLayout = fieldLayout;
			this._summaryDefinitions = summaryDefinitions;
			this._list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult>();
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0007F114 File Offset: 0x0007D314
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			if (base.HasListeners)
			{
				if (this._summaryCollectionVersionTracker == null)
				{
					this._summaryCollectionVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this.SummaryDefinitions, "SummariesVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifyCollection), true);
					return;
				}
			}
			else
			{
				this._summaryCollectionVersionTracker = null;
			}
		}

		// Token: 0x170007E5 RID: 2021
		public global::Infragistics.Windows.DataPresenter.SummaryResult this[string summaryKey]
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult = this.GetItem(summaryKey);
				int num;
				if (summaryResult == null && int.TryParse(summaryKey, out num) && num >= 0 && num < this.Count)
				{
					summaryResult = this[num];
				}
				if (summaryResult == null)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.RaiseKeyNotFound();
				}
				return summaryResult;
			}
		}

		// Token: 0x170007E6 RID: 2022
		public global::Infragistics.Windows.DataPresenter.SummaryResult this[int index]
		{
			get
			{
				this.VerifyCollection();
				return this._list[index];
			}
			set
			{
				this.VerifyCollection();
				this._list[index] = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		public global::Infragistics.Windows.DataPresenter.SummaryResult this[global::Infragistics.Windows.DataPresenter.SummaryDefinition summary]
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.SummaryResult item = this.GetItem(summary);
				if (item == null)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.RaiseKeyNotFound();
				}
				return item;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x0007F1EE File Offset: 0x0007D3EE
		public int Count
		{
			get
			{
				this.VerifyCollection();
				return this._list.Count;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0007F201 File Offset: 0x0007D401
		public global::Infragistics.Windows.DataPresenter.RecordCollectionBase Records
		{
			get
			{
				return this._records;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0007F209 File Offset: 0x0007D409
		public global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection SummaryDefinitions
		{
			get
			{
				return this._summaryDefinitions;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0007F211 File Offset: 0x0007D411
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x0007F219 File Offset: 0x0007D419
		public object SummaryRecordHeader
		{
			get
			{
				return this._summaryRecordHeader;
			}
			set
			{
				if (this._summaryRecordHeader != value)
				{
					this._summaryRecordHeader = value;
					base.RaisePropertyChangedEvent("SummaryRecordHeader");
				}
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x0007F236 File Offset: 0x0007D436
		internal int SummariesVersion
		{
			get
			{
				this.VerifyCollection();
				return this._summaryDefinitions.SummariesVersion;
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0007F249 File Offset: 0x0007D449
		public bool Contains(global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			this.VerifyCollection();
			return this._list.Contains(item);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0007F25D File Offset: 0x0007D45D
		public int IndexOf(global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			this.VerifyCollection();
			return this._list.IndexOf(item);
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0007F274 File Offset: 0x0007D474
		public void Refresh()
		{
			foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)this))
			{
				summaryResult.Refresh();
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0007F2BC File Offset: 0x0007D4BC
		internal void DirtyAffectedSummariesAsync(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayoutContext)
		{
			if (this._list.Count == 0)
			{
				return;
			}
			if (field == null && fieldLayoutContext != null && fieldLayoutContext != this._fieldLayout)
			{
				this.VerifySourceFieldMap();
				if (!this._cachedHasCalculationFieldFromDifferentFieldLayout)
				{
					return;
				}
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._records.DataPresenter;
			global::System.Windows.Threading.Dispatcher dispatcher = (dataPresenter != null) ? dataPresenter.Dispatcher : null;
			if (dispatcher != null)
			{
				bool flag = null == this._pendingDirtyAffectedSummaries;
				if (field == null)
				{
					this._pendingDirtyAffectedSummaries = global::System.DBNull.Value;
				}
				else if (this._pendingDirtyAffectedSummaries == null)
				{
					this._pendingDirtyAffectedSummaries = field;
				}
				else if (global::System.DBNull.Value != this._pendingDirtyAffectedSummaries)
				{
					global::Infragistics.Windows.Helpers.HashSet hashSet = this._pendingDirtyAffectedSummaries as global::Infragistics.Windows.Helpers.HashSet;
					if (hashSet == null)
					{
						global::Infragistics.Windows.DataPresenter.Field item = (global::Infragistics.Windows.DataPresenter.Field)this._pendingDirtyAffectedSummaries;
						hashSet = new global::Infragistics.Windows.Helpers.HashSet();
						hashSet.Add(item);
						this._pendingDirtyAffectedSummaries = hashSet;
					}
					hashSet.Add(field);
				}
				if (flag)
				{
					dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.DirtyAffectedSummariesAsyncHanlder));
					return;
				}
			}
			else
			{
				this.DirtyAffectedSummaries(field);
			}
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0007F3A3 File Offset: 0x0007D5A3
		internal void CleanPendingDirtyAffectedSummaries()
		{
			this.DirtyAffectedSummariesAsyncHanlder();
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0007F3AC File Offset: 0x0007D5AC
		private void DirtyAffectedSummariesAsyncHanlder()
		{
			object pendingDirtyAffectedSummaries = this._pendingDirtyAffectedSummaries;
			if (pendingDirtyAffectedSummaries != null)
			{
				this._pendingDirtyAffectedSummaries = null;
				global::Infragistics.Windows.Helpers.HashSet hashSet = pendingDirtyAffectedSummaries as global::Infragistics.Windows.Helpers.HashSet;
				if (hashSet == null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = (global::System.DBNull.Value == pendingDirtyAffectedSummaries) ? null : ((global::Infragistics.Windows.DataPresenter.Field)pendingDirtyAffectedSummaries);
					this.DirtyAffectedSummaries(field);
					return;
				}
				foreach (object obj in hashSet)
				{
					global::Infragistics.Windows.DataPresenter.Field field2 = (global::Infragistics.Windows.DataPresenter.Field)obj;
					this.DirtyAffectedSummaries(field2);
				}
			}
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0007F43C File Offset: 0x0007D63C
		internal void DirtyAffectedSummaries(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifySourceFieldMap();
			if (field != null)
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.GridUtilities.Range> cachedSourceFieldMap = this._cachedSourceFieldMap;
				global::Infragistics.Windows.DataPresenter.GridUtilities.Range range;
				if (cachedSourceFieldMap.TryGetValue(field, out range))
				{
					global::Infragistics.Windows.DataPresenter.SummaryResult[] cachedSortedResultsArr = this._cachedSortedResultsArr;
					for (int i = range.Start; i <= range.End; i++)
					{
						cachedSortedResultsArr[i].DirtyCalculation();
					}
					return;
				}
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.SummaryResult[] cachedSortedResultsArr2 = this._cachedSortedResultsArr;
				for (int j = 0; j < cachedSortedResultsArr2.Length; j++)
				{
					cachedSortedResultsArr2[j].DirtyCalculation();
				}
			}
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0007F4B1 File Offset: 0x0007D6B1
		internal void DirtySourceFieldMapCache()
		{
			this._cachedSourceFieldMap = null;
			this._cachedSortedResultsArr = null;
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0007F4C4 File Offset: 0x0007D6C4
		internal global::Infragistics.Windows.DataPresenter.SummaryResult GetItem(string summaryKey)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitions = this.SummaryDefinitions;
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = (summaryDefinitions != null) ? summaryDefinitions.GetItem(summaryKey) : null;
			if (summaryDefinition == null)
			{
				return null;
			}
			return this.GetItem(summaryDefinition);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0007F4F4 File Offset: 0x0007D6F4
		internal global::Infragistics.Windows.DataPresenter.SummaryResult GetItem(global::Infragistics.Windows.DataPresenter.SummaryDefinition summary)
		{
			this.VerifyCollection();
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitions = this.SummaryDefinitions;
			if (summaryDefinitions != null && summary != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in this._list)
				{
					if (summaryResult.SummaryDefinition == summary)
					{
						return summaryResult;
					}
				}
			}
			return null;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0007F564 File Offset: 0x0007D764
		internal global::Infragistics.Windows.DataPresenter.SummaryRecord GetSummaryRecord(bool top, bool isFixed, global::Infragistics.Windows.DataPresenter.Record[] recordsToRecycle, bool isRootLevel)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext context = global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext.GetContext(top, isFixed, this);
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = this.GetSummaryResults(context, null);
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(summaryResults))
			{
				global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = null;
				if (recordsToRecycle != null)
				{
					for (int i = 0; i < recordsToRecycle.Length; i++)
					{
						global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord2 = recordsToRecycle[i] as global::Infragistics.Windows.DataPresenter.SummaryRecord;
						if (summaryRecord2 != null && context.Equals(summaryRecord2.SummaryDisplayAreaContext) && summaryRecord2.FieldLayout == this._fieldLayout)
						{
							summaryRecord = summaryRecord2;
							recordsToRecycle[i] = null;
						}
					}
				}
				if (summaryRecord == null)
				{
					summaryRecord = new global::Infragistics.Windows.DataPresenter.SummaryRecord(this._records.FieldLayout, this._records, context);
				}
				summaryRecord.FixedRecordLocationOverride = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFixedRecordLocation(top, isFixed && (top || isRootLevel));
				return summaryRecord;
			}
			return null;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0007F60C File Offset: 0x0007D80C
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> GetSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext displayAreaContext, global::Infragistics.Windows.DataPresenter.SummaryPositionContext positionContext)
		{
			this.VerifyCollection();
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> enumerable = this._list;
			if (displayAreaContext != null)
			{
				enumerable = displayAreaContext.Filter(enumerable);
			}
			if (positionContext != null)
			{
				enumerable = displayAreaContext.Filter(enumerable);
			}
			return enumerable;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0007F63D File Offset: 0x0007D83D
		internal bool HasSummaryResultsFor(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifySourceFieldMap();
			return this._cachedSourceFieldMap != null && this._cachedSourceFieldMap.ContainsKey(field);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0007F65C File Offset: 0x0007D85C
		internal static bool HasSummaryDependentOn(global::Infragistics.Windows.DataPresenter.Cell cell, bool verify)
		{
			global::Infragistics.Windows.DataPresenter.Field field = cell.Field;
			global::Infragistics.Windows.DataPresenter.Record record = cell.Record;
			for (global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = (record != null) ? record.ParentCollection : null; recordCollectionBase != null; recordCollectionBase = ((record != null) ? record.ParentCollection : null))
			{
				global::Infragistics.Windows.DataPresenter.SummaryResultCollection summaryResultCollection = verify ? recordCollectionBase.SummaryResults : recordCollectionBase.SummaryResultsIfAllocated;
				if (summaryResultCollection != null && summaryResultCollection.HasSummaryResultsFor(field))
				{
					return true;
				}
				record = recordCollectionBase.ParentRecord;
			}
			return false;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0007F6C0 File Offset: 0x0007D8C0
		internal void RefreshSummariesAffectedBySort()
		{
			foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)this))
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator = summaryResult.SummaryDefinition.Calculator;
				if (calculator != null && calculator.IsCalculationAffectedBySort)
				{
					summaryResult.Refresh();
				}
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0007F720 File Offset: 0x0007D920
		internal void VerifyCollection()
		{
			if (this._inVerifyCollection)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitions = this.SummaryDefinitions;
			if (summaryDefinitions != null && this._verifiedSummariesCollectionVersion == summaryDefinitions.CollectionVersion)
			{
				return;
			}
			this._inVerifyCollection = true;
			try
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult> list = this._list;
				if (summaryDefinitions == null)
				{
					list.Clear();
				}
				else
				{
					global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.SummaryDefinition, global::Infragistics.Windows.DataPresenter.SummaryResult> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.SummaryDefinition, global::Infragistics.Windows.DataPresenter.SummaryResult>();
					foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in list)
					{
						dictionary[summaryResult.SummaryDefinition] = summaryResult;
					}
					list.Clear();
					foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition in summaryDefinitions)
					{
						global::Infragistics.Windows.DataPresenter.SummaryResult item;
						if (!dictionary.TryGetValue(summaryDefinition, out item))
						{
							item = new global::Infragistics.Windows.DataPresenter.SummaryResult(this, summaryDefinition);
						}
						list.Add(item);
					}
					this.DirtySourceFieldMapCache();
					this._verifiedSummariesCollectionVersion = summaryDefinitions.CollectionVersion;
				}
			}
			finally
			{
				this._inVerifyCollection = false;
				base.RaisePropertyChangedEvent("Count");
				base.RaisePropertyChangedEvent("Item[]");
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0007F854 File Offset: 0x0007DA54
		private void VerifySourceFieldMap()
		{
			this.VerifyCollection();
			if (this._cachedSourceFieldMap == null)
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult>> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult>>();
				int num = 0;
				foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in this._list)
				{
					global::Infragistics.Windows.DataPresenter.Field sourceField = summaryResult.SourceField;
					if (sourceField != null)
					{
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult> list;
						if (!dictionary.TryGetValue(sourceField, out list))
						{
							list = (dictionary[sourceField] = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult>());
						}
						list.Add(summaryResult);
						num++;
					}
				}
				global::Infragistics.Windows.DataPresenter.SummaryResult[] array = new global::Infragistics.Windows.DataPresenter.SummaryResult[num];
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.GridUtilities.Range> dictionary2 = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.GridUtilities.Range>();
				bool cachedHasCalculationFieldFromDifferentFieldLayout = false;
				int num2 = 0;
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult>> keyValuePair in dictionary)
				{
					int start = num2;
					foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult2 in keyValuePair.Value)
					{
						array[num2++] = summaryResult2;
					}
					int end = num2 - 1;
					dictionary2[keyValuePair.Key] = new global::Infragistics.Windows.DataPresenter.GridUtilities.Range(start, end);
					cachedHasCalculationFieldFromDifferentFieldLayout = (this._cachedHasCalculationFieldFromDifferentFieldLayout || keyValuePair.Key.Owner != this._fieldLayout);
				}
				this._cachedSortedResultsArr = array;
				this._cachedSourceFieldMap = dictionary2;
				this._cachedHasCalculationFieldFromDifferentFieldLayout = cachedHasCalculationFieldFromDifferentFieldLayout;
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0007F9E4 File Offset: 0x0007DBE4
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0007F9EB File Offset: 0x0007DBEB
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0007F9F2 File Offset: 0x0007DBF2
		bool global::System.Collections.IList.Contains(object item)
		{
			return this.Contains(item as global::Infragistics.Windows.DataPresenter.SummaryResult);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0007FA00 File Offset: 0x0007DC00
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this.IndexOf(value as global::Infragistics.Windows.DataPresenter.SummaryResult);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0007FA0E File Offset: 0x0007DC0E
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0007FA15 File Offset: 0x0007DC15
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0007FA18 File Offset: 0x0007DC18
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0007FA1B File Offset: 0x0007DC1B
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0007FA22 File Offset: 0x0007DC22
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170007EF RID: 2031
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0007FA39 File Offset: 0x0007DC39
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int arrayIndex)
		{
			this.VerifyCollection();
			((global::System.Collections.ICollection)this._list).CopyTo(array, arrayIndex);
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0007FA4E File Offset: 0x0007DC4E
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x0007FA51 File Offset: 0x0007DC51
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0007FA54 File Offset: 0x0007DC54
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)this).GetEnumerator();
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0007FA69 File Offset: 0x0007DC69
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryResult>.Insert(int index, global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0007FA70 File Offset: 0x0007DC70
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryResult>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0007FA77 File Offset: 0x0007DC77
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.SummaryResult>.Add(global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0007FA7E File Offset: 0x0007DC7E
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.SummaryResult>.Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0007FA85 File Offset: 0x0007DC85
		public void CopyTo(global::Infragistics.Windows.DataPresenter.SummaryResult[] array, int arrayIndex)
		{
			((global::System.Collections.ICollection)this).CopyTo((object[])array, arrayIndex);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0007FA94 File Offset: 0x0007DC94
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.SummaryResult>.Remove(global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0007FA9B File Offset: 0x0007DC9B
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.SummaryResult> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>.GetEnumerator()
		{
			this.VerifyCollection();
			return this._list.GetEnumerator();
		}

		// Token: 0x04000B95 RID: 2965
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;

		// Token: 0x04000B96 RID: 2966
		private global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection _summaryDefinitions;

		// Token: 0x04000B97 RID: 2967
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000B98 RID: 2968
		private int _verifiedSummariesCollectionVersion;

		// Token: 0x04000B99 RID: 2969
		private bool _inVerifyCollection;

		// Token: 0x04000B9A RID: 2970
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult> _list;

		// Token: 0x04000B9B RID: 2971
		private object _summaryRecordHeader;

		// Token: 0x04000B9C RID: 2972
		private object _pendingDirtyAffectedSummaries;

		// Token: 0x04000B9D RID: 2973
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.GridUtilities.Range> _cachedSourceFieldMap;

		// Token: 0x04000B9E RID: 2974
		private global::Infragistics.Windows.DataPresenter.SummaryResult[] _cachedSortedResultsArr;

		// Token: 0x04000B9F RID: 2975
		private bool _cachedHasCalculationFieldFromDifferentFieldLayout;

		// Token: 0x04000BA0 RID: 2976
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryCollectionVersionTracker;
	}
}
