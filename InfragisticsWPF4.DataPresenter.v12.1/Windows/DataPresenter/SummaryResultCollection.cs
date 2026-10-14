using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Threading;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001B5 RID: 437
	public class SummaryResultCollection : global::Infragistics.PropertyChangeNotifier, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryResult>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.SummaryResult>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x0006C138 File Offset: 0x0006A338
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

		// Token: 0x06001857 RID: 6231 RVA: 0x0006C174 File Offset: 0x0006A374
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			if (base.HasListeners)
			{
				if (this._summaryCollectionVersionTracker == null)
				{
					this._summaryCollectionVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this.SummaryDefinitions, "SummariesVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifyCollection));
					return;
				}
			}
			else
			{
				this._summaryCollectionVersionTracker = null;
			}
		}

		// Token: 0x1700067F RID: 1663
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

		// Token: 0x17000680 RID: 1664
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

		// Token: 0x17000681 RID: 1665
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

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x0006C24E File Offset: 0x0006A44E
		public int Count
		{
			get
			{
				this.VerifyCollection();
				return this._list.Count;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x0006C261 File Offset: 0x0006A461
		public global::Infragistics.Windows.DataPresenter.RecordCollectionBase Records
		{
			get
			{
				return this._records;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0006C269 File Offset: 0x0006A469
		public global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection SummaryDefinitions
		{
			get
			{
				return this._summaryDefinitions;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0006C271 File Offset: 0x0006A471
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x0006C279 File Offset: 0x0006A479
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

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0006C296 File Offset: 0x0006A496
		internal int SummariesVersion
		{
			get
			{
				this.VerifyCollection();
				return this._summaryDefinitions.SummariesVersion;
			}
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0006C2A9 File Offset: 0x0006A4A9
		public bool Contains(global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			this.VerifyCollection();
			return this._list.Contains(item);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0006C2BD File Offset: 0x0006A4BD
		public int IndexOf(global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			this.VerifyCollection();
			return this._list.IndexOf(item);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0006C2D4 File Offset: 0x0006A4D4
		public void Refresh()
		{
			foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)this))
			{
				summaryResult.Refresh();
			}
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0006C31C File Offset: 0x0006A51C
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

		// Token: 0x06001866 RID: 6246 RVA: 0x0006C403 File Offset: 0x0006A603
		internal void CleanPendingDirtyAffectedSummaries()
		{
			this.DirtyAffectedSummariesAsyncHanlder();
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0006C40C File Offset: 0x0006A60C
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

		// Token: 0x06001868 RID: 6248 RVA: 0x0006C49C File Offset: 0x0006A69C
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

		// Token: 0x06001869 RID: 6249 RVA: 0x0006C511 File Offset: 0x0006A711
		internal void DirtySourceFieldMapCache()
		{
			this._cachedSourceFieldMap = null;
			this._cachedSortedResultsArr = null;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0006C524 File Offset: 0x0006A724
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

		// Token: 0x0600186B RID: 6251 RVA: 0x0006C554 File Offset: 0x0006A754
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

		// Token: 0x0600186C RID: 6252 RVA: 0x0006C5C4 File Offset: 0x0006A7C4
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

		// Token: 0x0600186D RID: 6253 RVA: 0x0006C66C File Offset: 0x0006A86C
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

		// Token: 0x0600186E RID: 6254 RVA: 0x0006C69D File Offset: 0x0006A89D
		internal bool HasSummaryResultsFor(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifySourceFieldMap();
			return this._cachedSourceFieldMap != null && this._cachedSourceFieldMap.ContainsKey(field);
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0006C6BC File Offset: 0x0006A8BC
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

		// Token: 0x06001870 RID: 6256 RVA: 0x0006C720 File Offset: 0x0006A920
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

		// Token: 0x06001871 RID: 6257 RVA: 0x0006C780 File Offset: 0x0006A980
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

		// Token: 0x06001872 RID: 6258 RVA: 0x0006C8B4 File Offset: 0x0006AAB4
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

		// Token: 0x06001873 RID: 6259 RVA: 0x0006CA44 File Offset: 0x0006AC44
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0006CA4B File Offset: 0x0006AC4B
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0006CA52 File Offset: 0x0006AC52
		bool global::System.Collections.IList.Contains(object item)
		{
			return this.Contains(item as global::Infragistics.Windows.DataPresenter.SummaryResult);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0006CA60 File Offset: 0x0006AC60
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this.IndexOf(value as global::Infragistics.Windows.DataPresenter.SummaryResult);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0006CA6E File Offset: 0x0006AC6E
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0006CA75 File Offset: 0x0006AC75
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0006CA78 File Offset: 0x0006AC78
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0006CA7B File Offset: 0x0006AC7B
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0006CA82 File Offset: 0x0006AC82
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000689 RID: 1673
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

		// Token: 0x0600187E RID: 6270 RVA: 0x0006CA99 File Offset: 0x0006AC99
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int arrayIndex)
		{
			this.VerifyCollection();
			((global::System.Collections.ICollection)this._list).CopyTo(array, arrayIndex);
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0006CAAE File Offset: 0x0006ACAE
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0006CAB1 File Offset: 0x0006ACB1
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0006CAB4 File Offset: 0x0006ACB4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)this).GetEnumerator();
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0006CAC9 File Offset: 0x0006ACC9
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryResult>.Insert(int index, global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0006CAD0 File Offset: 0x0006ACD0
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryResult>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0006CAD7 File Offset: 0x0006ACD7
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.SummaryResult>.Add(global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0006CADE File Offset: 0x0006ACDE
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.SummaryResult>.Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0006CAE5 File Offset: 0x0006ACE5
		public void CopyTo(global::Infragistics.Windows.DataPresenter.SummaryResult[] array, int arrayIndex)
		{
			((global::System.Collections.ICollection)this).CopyTo((object[])array, arrayIndex);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0006CAF4 File Offset: 0x0006ACF4
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.SummaryResult>.Remove(global::Infragistics.Windows.DataPresenter.SummaryResult item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0006CAFB File Offset: 0x0006ACFB
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.SummaryResult> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>.GetEnumerator()
		{
			this.VerifyCollection();
			return this._list.GetEnumerator();
		}

		// Token: 0x040009C5 RID: 2501
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;

		// Token: 0x040009C6 RID: 2502
		private global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection _summaryDefinitions;

		// Token: 0x040009C7 RID: 2503
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040009C8 RID: 2504
		private int _verifiedSummariesCollectionVersion;

		// Token: 0x040009C9 RID: 2505
		private bool _inVerifyCollection;

		// Token: 0x040009CA RID: 2506
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryResult> _list;

		// Token: 0x040009CB RID: 2507
		private object _summaryRecordHeader;

		// Token: 0x040009CC RID: 2508
		private object _pendingDirtyAffectedSummaries;

		// Token: 0x040009CD RID: 2509
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.GridUtilities.Range> _cachedSourceFieldMap;

		// Token: 0x040009CE RID: 2510
		private global::Infragistics.Windows.DataPresenter.SummaryResult[] _cachedSortedResultsArr;

		// Token: 0x040009CF RID: 2511
		private bool _cachedHasCalculationFieldFromDifferentFieldLayout;

		// Token: 0x040009D0 RID: 2512
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryCollectionVersionTracker;
	}
}
