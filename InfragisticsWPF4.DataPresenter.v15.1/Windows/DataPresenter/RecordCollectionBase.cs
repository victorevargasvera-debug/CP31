using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200034B RID: 843
	public abstract class RecordCollectionBase : global::System.ComponentModel.INotifyPropertyChanged, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600289C RID: 10396 RVA: 0x000B3BD4 File Offset: 0x000B1DD4
		protected RecordCollectionBase(global::Infragistics.Windows.DataPresenter.Record parentRecord, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool createUnsortedArray)
		{
			if (parentRecordManager == null)
			{
				throw new global::System.ArgumentNullException("parentRecordManager");
			}
			this._parentRecord = parentRecord;
			this._parentRecordManager = parentRecordManager;
			this._fieldLayout = fieldLayout;
			if (createUnsortedArray)
			{
				this._sparseArray = new global::Infragistics.Windows.DataPresenter.UnsortedRecordSparseArray(this);
			}
			else if (this is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection)
			{
				this._sparseArray = new global::Infragistics.Windows.DataPresenter.MainRecordSparseArray(this, true, 2);
			}
			else
			{
				this._sparseArray = new global::Infragistics.Windows.DataPresenter.MainRecordSparseArray(this);
			}
			if (this._sparseArray is global::Infragistics.Windows.DataPresenter.MainRecordSparseArray)
			{
				this._viewableRecordCollection = new global::Infragistics.Windows.DataPresenter.ViewableRecordCollection(this);
			}
			this.InitializeGroupByField();
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x000B3C5F File Offset: 0x000B1E5F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public int CollectionVersion
		{
			get
			{
				return this._collectionVersion;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000B3C67 File Offset: 0x000B1E67
		public int Count
		{
			get
			{
				return this.SparseArray.Count;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x000B3C74 File Offset: 0x000B1E74
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._parentRecordManager.DataPresenter;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000B3C81 File Offset: 0x000B1E81
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x000B3C8C File Offset: 0x000B1E8C
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x000B3CCC File Offset: 0x000B1ECC
		internal global::Infragistics.Windows.DataPresenter.RecordListControl LastRecordList
		{
			get
			{
				if (this._lastRecordList == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._lastRecordList) as global::Infragistics.Windows.DataPresenter.RecordListControl;
				if (recordListControl == null)
				{
					return null;
				}
				if (recordListControl.ItemsSource != this)
				{
					this._lastRecordList = null;
					return null;
				}
				return recordListControl;
			}
			set
			{
				if (value == null)
				{
					this._lastRecordList = null;
					return;
				}
				if (value != this.LastRecordList)
				{
					this._lastRecordList = new global::System.WeakReference(value);
				}
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x000B3CEE File Offset: 0x000B1EEE
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataRecord ParentDataRecord
		{
			get
			{
				if (this._parentRecord is global::Infragistics.Windows.DataPresenter.DataRecord)
				{
					return this._parentRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
				}
				return this.ParentRecordManager.ParentDataRecord;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000B3D14 File Offset: 0x000B1F14
		public global::Infragistics.Windows.DataPresenter.Record ParentRecord
		{
			get
			{
				return this._parentRecord;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000B3D1C File Offset: 0x000B1F1C
		public global::Infragistics.Windows.DataPresenter.RecordManager ParentRecordManager
		{
			get
			{
				return this._parentRecordManager;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000B3D24 File Offset: 0x000B1F24
		public global::Infragistics.Windows.DataPresenter.SummaryResultCollection SummaryResults
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
				global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionCollection = (fieldLayout != null) ? fieldLayout.SummaryDefinitions : null;
				if (this._summaryResults != null && this._summaryResults.SummaryDefinitions == summaryDefinitionCollection)
				{
					return this._summaryResults;
				}
				bool flag = false;
				if (summaryDefinitionCollection != null)
				{
					this._summaryResults = new global::Infragistics.Windows.DataPresenter.SummaryResultCollection(this, fieldLayout, summaryDefinitionCollection);
					flag = true;
				}
				else if (this._summaryResults != null)
				{
					this._summaryResults = null;
					flag = true;
				}
				if (flag)
				{
					this.OnPropertyChanged("SummaryResults");
				}
				return this._summaryResults;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000B3DA0 File Offset: 0x000B1FA0
		internal global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation BeginUpdateInfo
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this.ParentRecordManager;
				if (parentRecordManager == null)
				{
					return null;
				}
				return parentRecordManager._beginUpdateInfo;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000B3DBF File Offset: 0x000B1FBF
		internal global::Infragistics.Windows.DataPresenter.Field GroupByField
		{
			get
			{
				return this._groupByField;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000B3DC7 File Offset: 0x000B1FC7
		internal int GroupByVersion
		{
			get
			{
				return this._groupByVersion;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x000B3DD0 File Offset: 0x000B1FD0
		internal bool IsTopLevel
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				return parentRecord == null || parentRecord is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x000B3DF2 File Offset: 0x000B1FF2
		internal bool IsRootLevel
		{
			get
			{
				return null == this.ParentRecord;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x000B3E00 File Offset: 0x000B2000
		internal bool IsUpdating
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this.ParentRecordManager;
				return parentRecordManager != null && parentRecordManager.IsUpdating;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x000B3E1F File Offset: 0x000B201F
		internal bool IsViewableRecordsCollectionAllocated
		{
			get
			{
				return this._viewableRecordCollection != null;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060028AE RID: 10414
		internal abstract global::Infragistics.Windows.DataPresenter.RecordType RecordsType { get; }

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000B3E2D File Offset: 0x000B202D
		internal int SortVersion
		{
			get
			{
				return this._sortVersion;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x000B3E35 File Offset: 0x000B2035
		internal global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase SparseArray
		{
			get
			{
				return this._sparseArray;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000B3E3D File Offset: 0x000B203D
		internal global::Infragistics.Windows.DataPresenter.SummaryResultCollection SummaryResultsIfAllocated
		{
			get
			{
				return this._summaryResults;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x000B3E45 File Offset: 0x000B2045
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecords
		{
			get
			{
				return this._viewableRecordCollection;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000B3E4D File Offset: 0x000B204D
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecordsIfAllocated
		{
			get
			{
				return this._viewableRecordCollection;
			}
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000B3E55 File Offset: 0x000B2055
		public void CollapseAll(bool recursive)
		{
			this.ExpandCollapseAllHelper(false, recursive ? -1 : 0);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000B3E65 File Offset: 0x000B2065
		public void CollapseAll(int recursionDepth)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(recursionDepth);
			this.ExpandCollapseAllHelper(false, recursionDepth);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000B3E75 File Offset: 0x000B2075
		public bool Contains(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return this.SparseArray.Contains(item);
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000B3E83 File Offset: 0x000B2083
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int arrayIndex)
		{
			this.SparseArray.CopyTo(array, arrayIndex, this.SparseArray);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000B3E98 File Offset: 0x000B2098
		public void ExpandAll(bool recursive)
		{
			this.ExpandCollapseAllHelper(true, recursive ? -1 : 0);
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000B3EA8 File Offset: 0x000B20A8
		public void ExpandAll(int recursionDepth)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(recursionDepth);
			this.ExpandCollapseAllHelper(true, recursionDepth);
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x000B3EB8 File Offset: 0x000B20B8
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return this.SparseArray.IndexOf(item);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000B3EC8 File Offset: 0x000B20C8
		public void RefreshSort()
		{
			if (this._parentRecordManager == null || this._parentRecordManager.IsInReset)
			{
				return;
			}
			this._sortVersion--;
			this.VerifySortOrder(false);
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._parentRecordManager.ViewableRecords;
			if (viewableRecords != null)
			{
				viewableRecords.RefreshSortOrderOfFixedRecords();
			}
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000B3F15 File Offset: 0x000B2115
		internal void AddRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.InsertRecord(this.SparseArray.Count, record);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000B3F29 File Offset: 0x000B2129
		internal virtual global::Infragistics.Windows.DataPresenter.Record AllocateNewRecord(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_11"));
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000B3F3C File Offset: 0x000B213C
		internal void BeginUpdate()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this.ParentRecordManager;
			if (parentRecordManager != null)
			{
				parentRecordManager.BeginUpdate();
			}
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000B3F5C File Offset: 0x000B215C
		internal void BumpCollectionVersion()
		{
			if (this._bumpVersionOperation == null && this._parentRecordManager != null && this._parentRecordManager.DataPresenter != null)
			{
				this._bumpVersionOperation = this._parentRecordManager.DataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnBumpVersionNumber));
			}
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000B3FAE File Offset: 0x000B21AE
		internal void Clear()
		{
			if (this.SparseArray.Count > 0)
			{
				this.SparseArray.Clear();
				this.RaiseChangeEvents(true);
			}
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000B3FD0 File Offset: 0x000B21D0
		internal void CreateGroupByRecordsHelper(global::Infragistics.Windows.DataPresenter.DataRecord[] records)
		{
			this.InitializeGroupByField();
			int num = 0;
			this.CreateGroupByRecordsHelper(records, ref num);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000B3FF0 File Offset: 0x000B21F0
		internal void CreateGroupByRecordsHelper(global::Infragistics.Windows.DataPresenter.DataRecord[] records, ref int startIndex)
		{
			global::Infragistics.Windows.DataPresenter.Field groupByField = this.GroupByField;
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.GroupByRecord> dictionary = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.GroupByRecord>(this.Count);
			foreach (object obj in this.SparseArray.NonNullItems)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)obj;
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord2 = record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord2 != null)
				{
					if (groupByRecord2.GroupByField != groupByField)
					{
						break;
					}
					dictionary[global::Infragistics.Windows.DataPresenter.RecordCollectionBase.GetValueKey(groupByRecord2.Value)] = groupByRecord2;
				}
			}
			global::Infragistics.Windows.DataPresenter.IGroupByEvaluator groupByEvaluator = null;
			if (groupByField != null)
			{
				groupByEvaluator = groupByField.GroupByEvaluatorResolved;
			}
			this.BeginUpdate();
			try
			{
				global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray = this.SparseArray;
				sparseArray.Clear();
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord3 = null;
				while (startIndex < records.Length)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = records[startIndex];
					if (groupByRecord != null && sparseArray.Count > 0 && !groupByRecord.DoesRecordMatchGroup(dataRecord))
					{
						break;
					}
					if (groupByRecord3 == null || !groupByRecord3.DoesRecordMatchGroup(dataRecord, false, groupByEvaluator))
					{
						bool flag = false;
						global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord4 = null;
						if (groupByField == null || groupByField.Owner != dataRecord.FieldLayout)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dataRecord.FieldLayout;
							if (dictionary.TryGetValue(fieldLayout, out groupByRecord4))
							{
								dictionary.Remove(fieldLayout);
								groupByRecord3 = groupByRecord4;
							}
							else
							{
								groupByRecord3 = new global::Infragistics.Windows.DataPresenter.GroupByRecord(fieldLayout, this);
								flag = true;
							}
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = groupByField.Owner;
							groupByRecord3 = null;
							object cellValue = dataRecord.GetCellValue(groupByField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
							object valueKey = global::Infragistics.Windows.DataPresenter.RecordCollectionBase.GetValueKey(cellValue);
							if (dictionary.TryGetValue(valueKey, out groupByRecord4) && groupByRecord4 != null && groupByRecord4.DoesRecordMatchGroup(dataRecord, false, groupByEvaluator))
							{
								dictionary.Remove(valueKey);
								groupByRecord3 = groupByRecord4;
							}
							if (groupByRecord3 == null && groupByEvaluator != null && dictionary.Count > 0)
							{
								foreach (global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Windows.DataPresenter.GroupByRecord> keyValuePair in dictionary)
								{
									groupByRecord4 = keyValuePair.Value;
									if (groupByRecord4 != null && groupByRecord4.DoesRecordMatchGroup(dataRecord, false, groupByEvaluator))
									{
										groupByRecord3 = groupByRecord4;
										dictionary.Remove(keyValuePair.Key);
										break;
									}
								}
							}
							if (groupByRecord3 == null)
							{
								groupByRecord3 = new global::Infragistics.Windows.DataPresenter.GroupByRecord(groupByField, this, cellValue);
								flag = true;
							}
							else
							{
								global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecords = groupByRecord3.ViewableChildRecords;
								if (viewableChildRecords != null)
								{
									viewableChildRecords.DirtySpecialRecords(false);
								}
							}
						}
						sparseArray.Add(groupByRecord3);
						if (flag && groupByEvaluator != null && groupByRecord3.GroupByField != null)
						{
							groupByRecord3.InitializeCommonValue(groupByEvaluator.GetGroupByValue(groupByRecord3, dataRecord));
						}
						int num = startIndex;
						global::Infragistics.Windows.DataPresenter.RecordCollection childRecords = groupByRecord3.ChildRecords;
						childRecords.InitializeGroupByField();
						if (childRecords.GroupByField != null)
						{
							childRecords.CreateGroupByRecordsHelper(records, ref startIndex);
						}
						else
						{
							childRecords.CreateGroupByRecordRecords(records, ref startIndex, groupByEvaluator);
						}
						if (!flag)
						{
							childRecords.RaiseChangeEvents(true);
							groupByRecord3.OnGroupingChanged();
						}
						else
						{
							groupByRecord3.FireInitializeRecord();
						}
						if (startIndex <= num)
						{
							startIndex = 1 + num;
						}
					}
				}
				global::System.Collections.IComparer comparer = null;
				if (groupByField != null)
				{
					comparer = groupByField.GroupByComparerResolved;
				}
				if (comparer != null)
				{
					this.SortGroupByRecords(comparer, global::Infragistics.Windows.Controls.SortStatus.Ascending != groupByField.SortStatusGroupBy);
				}
				this.InitializeSortVersion();
				this.InitializeSortStatus();
			}
			finally
			{
				this.DirtyFixedRecordOrder();
				this.EndUpdate(false);
			}
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000B4338 File Offset: 0x000B2538
		internal void EndUpdate(bool dirtyScrollCount)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this.ParentRecordManager;
			if (parentRecordManager != null)
			{
				parentRecordManager.EndUpdate(dirtyScrollCount);
			}
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000B4356 File Offset: 0x000B2556
		internal virtual void EnsureNotDirty()
		{
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000B4358 File Offset: 0x000B2558
		private void ExpandCollapseAllHelper(bool expand, int recursionDepth)
		{
			this.BeginUpdate();
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = null;
			global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
			if (parentRecord == null || (parentRecord.IsExpanded && !parentRecord.HasCollapsedAncestor))
			{
				recordListControl = ((dataPresenter != null) ? dataPresenter.RootRecordListControl : null);
			}
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = (recordListControl != null) ? recordListControl.RecyclingItemContainerGenerator : null;
			if (recyclingItemContainerGenerator != null && (dataPresenter == null || !dataPresenter.IsFlatView))
			{
				recyclingItemContainerGenerator.RemoveAll();
			}
			global::System.Collections.IEnumerable enumerable = null;
			if (recordListControl != null)
			{
				enumerable = recordListControl.ItemsSource;
				if (enumerable != null)
				{
					recordListControl.BeginCoerceItemsSourceToNull();
					recordListControl.UpdateLayout();
				}
			}
			try
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this))
				{
					if (recursionDepth != 0 && record.HasChildren)
					{
						global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsInternal = record.ChildRecordsInternal;
						if (childRecordsInternal != null)
						{
							childRecordsInternal.ExpandCollapseAllHelper(expand, recursionDepth - 1);
						}
					}
					record.IsExpanded = expand;
				}
			}
			finally
			{
				this.EndUpdate(true);
				if (recordListControl != null && enumerable != null)
				{
					recordListControl.EndCoerceItemsSourceToNull();
				}
			}
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000B46AC File Offset: 0x000B28AC
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> GetAllRecords()
		{
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> specialRecords = this.ViewableRecords.GetSpecialRecords(true);
			if (specialRecords != null)
			{
				while (specialRecords.MoveNext())
				{
					global::Infragistics.Windows.DataPresenter.Record record2 = specialRecords.Current;
					yield return record2;
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this))
			{
				yield return record;
			}
			specialRecords = this.ViewableRecords.GetSpecialRecords(false);
			if (specialRecords != null)
			{
				while (specialRecords.MoveNext())
				{
					global::Infragistics.Windows.DataPresenter.Record record3 = specialRecords.Current;
					yield return record3;
				}
			}
			yield break;
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000B46CC File Offset: 0x000B28CC
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> GetRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordType recordType, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayoutToMatch, global::Infragistics.Windows.DataPresenter.FieldLayout lowestLevelFieldLayout, bool visibleRecordsOnly)
		{
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> e = new global::Infragistics.Windows.DataPresenter.RecursiveRecordsEnumerator.Enumerable(this, lowestLevelFieldLayout, visibleRecordsOnly);
			global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria meetsCriteria = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_RecordType(recordType);
			if (fieldLayoutToMatch != null)
			{
				meetsCriteria = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaChain(meetsCriteria, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_RecordFieldLayout(fieldLayoutToMatch), false);
			}
			return new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaEnumerator<global::Infragistics.Windows.DataPresenter.Record>.Enumerable(e, meetsCriteria);
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000B4830 File Offset: 0x000B2A30
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> GetSpecialRecords()
		{
			for (int i = 0; i < 2; i++)
			{
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> specialRecords = this.ViewableRecords.GetSpecialRecords(i == 0);
				if (specialRecords != null)
				{
					while (specialRecords.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.Record record = specialRecords.Current;
						yield return record;
					}
				}
			}
			yield break;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000B4850 File Offset: 0x000B2A50
		internal static bool HasAdditionalGroupByFields(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return layout != null && layout.HasGroupBySortFields;
			}
			int num = field.Owner.SortedFields.IndexOf(field, new bool?(true));
			return num < field.Owner.SortedFields.CountOfGroupByFields - 1;
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000B4899 File Offset: 0x000B2A99
		internal void InitializeSortVersion()
		{
			if (this._fieldLayout != null)
			{
				this._groupByVersion = this._fieldLayout.GroupByVersion;
				this._sortVersion = this._fieldLayout.SortVersion;
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x000B48C5 File Offset: 0x000B2AC5
		internal void InitializeSortStatus()
		{
			if (this._groupByField != null)
			{
				this._previousSortStatus = this._groupByField.SortStatusGroupBy;
			}
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000B48E0 File Offset: 0x000B2AE0
		internal void InitializeFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this.InternalSetFieldLayout(layout);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000B48E9 File Offset: 0x000B2AE9
		internal void InsertRecord(int index, global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.SparseArray.Insert(index, record);
			this.RaiseChangeEvents(false);
			this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, record, index);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000B4908 File Offset: 0x000B2B08
		internal void RaiseChangeEvents(bool fullReset)
		{
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			if (fullReset)
			{
				this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, null, -1);
			}
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000B492C File Offset: 0x000B2B2C
		internal void RemoveAt(int index)
		{
			global::Infragistics.Windows.DataPresenter.Record item = this.SparseArray.GetItem(index, null) as global::Infragistics.Windows.DataPresenter.Record;
			this.SparseArray.RemoveAt(index);
			this.RaiseChangeEvents(false);
			this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, item, index);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000B4968 File Offset: 0x000B2B68
		internal void RemoveRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			int num = this.SparseArray.IndexOf(record);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000B4990 File Offset: 0x000B2B90
		internal void VerifySortOrder(bool recursive)
		{
			if (this.FieldLayout != null && !(this is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection) && this.SparseArray.Count > 1 && this.SortVersion != this.FieldLayout.SortVersion)
			{
				this.InitializeSortVersion();
				global::Infragistics.Windows.DataPresenter.Record record = this[0];
				if (!(record is global::Infragistics.Windows.DataPresenter.GroupByRecord))
				{
					if (this._parentRecordManager == null || global::Infragistics.Windows.DataPresenter.SortEvaluationMode.Auto == this._parentRecordManager.SortEvaluationModeResolved)
					{
						this.SparseArray.EnsureAllItemsCreated();
						global::System.Collections.IComparer comparer;
						if (record.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
						{
							comparer = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer(record.FieldLayout, this.Count, false);
						}
						else
						{
							comparer = new global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer(false);
						}
						this.SparseArray.Sort(comparer);
					}
				}
				else if (this._parentRecordManager == null || global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.Auto == this._parentRecordManager.GroupByEvaluationModeResolved)
				{
					global::Infragistics.Windows.DataPresenter.Field groupByField = this.GroupByField;
					if (groupByField != null)
					{
						global::System.Collections.IComparer groupByComparerResolved = groupByField.GroupByComparerResolved;
						global::Infragistics.Windows.Controls.SortStatus sortStatusGroupBy = groupByField.SortStatusGroupBy;
						if (groupByComparerResolved == null)
						{
							if (this._previousSortStatus != sortStatusGroupBy)
							{
								this.SparseArray.Reverse();
							}
						}
						else
						{
							this.SortGroupByRecords(groupByComparerResolved, global::Infragistics.Windows.Controls.SortStatus.Ascending != sortStatusGroupBy);
						}
						this._previousSortStatus = sortStatusGroupBy;
					}
				}
				if (this._fieldLayout != null && this._fieldLayout.FixedRecordSortOrderResolved == global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Sorted)
				{
					this.DirtyFixedRecordOrder();
				}
				this.OnPropertyChanged("Item[]");
				this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, null, -1);
			}
			if (recursive && this.Count > 0)
			{
				foreach (object obj in this.SparseArray.NonNullItems)
				{
					global::Infragistics.Windows.DataPresenter.Record record2 = (global::Infragistics.Windows.DataPresenter.Record)obj;
					if (record2.IsExpanded)
					{
						record2.VerifySortOrderOfChildren();
					}
				}
			}
			if (this._summaryResults != null)
			{
				this._summaryResults.RefreshSummariesAffectedBySort();
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000B4B5C File Offset: 0x000B2D5C
		protected internal virtual void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction action, object item, int index)
		{
			if (this._collectionChangedHandler != null)
			{
				if (item is global::System.Collections.IList)
				{
					this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, (global::System.Collections.IList)item, index));
					return;
				}
				this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, item, index));
			}
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000B4B9C File Offset: 0x000B2D9C
		protected internal virtual void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction action, object item, int index, int oldIndex)
		{
			if (this._collectionChangedHandler != null)
			{
				if (item is global::System.Collections.IList)
				{
					this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, (global::System.Collections.IList)item, index, oldIndex));
					return;
				}
				this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, item, index, oldIndex));
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000B4BEB File Offset: 0x000B2DEB
		protected internal virtual void OnPropertyChanged(string propertyName)
		{
			if (this._propertyChangedHandler != null)
			{
				this._propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000B4C07 File Offset: 0x000B2E07
		protected virtual void SortGroupByRecords(global::System.Collections.IComparer comparer, bool reverse)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_12"));
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000B4C18 File Offset: 0x000B2E18
		private void CreateGroupByRecordRecords(global::Infragistics.Windows.DataPresenter.DataRecord[] records, ref int startIndex, global::Infragistics.Windows.DataPresenter.IGroupByEvaluator groupByEvaluator)
		{
			this.BeginUpdate();
			try
			{
				global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray = this.SparseArray;
				sparseArray.Clear();
				this.InternalSetFieldLayout(null);
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				while (startIndex < records.Length)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = records[startIndex];
					if (this._fieldLayout == null)
					{
						this.InternalSetFieldLayout(dataRecord.FieldLayout);
					}
					if (groupByRecord != null && sparseArray.Count > 0 && !groupByRecord.DoesRecordMatchGroup(dataRecord, true, groupByEvaluator))
					{
						break;
					}
					dataRecord.InitializeParentCollection(this);
					sparseArray.Add(dataRecord);
					startIndex++;
				}
				this.InitializeSortVersion();
			}
			finally
			{
				this.DirtyFixedRecordOrder();
				this.EndUpdate(false);
			}
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000B4CC0 File Offset: 0x000B2EC0
		protected internal void DirtyFixedRecordOrder()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordsIfAllocated = this.ViewableRecordsIfAllocated;
			if (viewableRecordsIfAllocated != null)
			{
				viewableRecordsIfAllocated.DirtyFixedRecordOrder();
			}
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000B4CDD File Offset: 0x000B2EDD
		internal static object GetValueKey(object key)
		{
			if (key != null)
			{
				return key;
			}
			return global::Infragistics.Windows.DataPresenter.RecordCollectionBase.NullKey;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000B4CEC File Offset: 0x000B2EEC
		internal void InitializeGroupByField()
		{
			this._groupByField = null;
			if (this._fieldLayout == null)
			{
				return;
			}
			if (this.ParentRecord == null)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this.ParentRecordManager;
				if (parentRecordManager != null && parentRecordManager.HasMultipleFieldLayouts)
				{
					return;
				}
				if (this._fieldLayout.HasGroupBySortFields)
				{
					this._groupByField = this._fieldLayout.SortedFields[0].Field;
					return;
				}
			}
			else if (this.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = (global::Infragistics.Windows.DataPresenter.GroupByRecord)this.ParentRecord;
				int num;
				if (groupByRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
				{
					num = 0;
				}
				else
				{
					num = groupByRecord.FieldLayout.SortedFields.IndexOf(groupByRecord.GroupByField, new bool?(true));
					if (num < 0)
					{
						return;
					}
					num++;
				}
				if (num >= 0 && num < groupByRecord.FieldLayout.SortedFields.Count)
				{
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = groupByRecord.FieldLayout.SortedFields[num];
					if (fieldSortDescription != null && fieldSortDescription.IsGroupBy)
					{
						this._groupByField = fieldSortDescription.Field;
					}
				}
			}
			else if (this.IsTopLevel && this._fieldLayout != null && this._fieldLayout.HasGroupBySortFields)
			{
				this._groupByField = this._fieldLayout.SortedFields[0].Field;
			}
			this.InitializeSortStatus();
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000B4E23 File Offset: 0x000B3023
		private void InternalSetFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
			if (this._viewableRecordCollection != null)
			{
				this._viewableRecordCollection.OnRecordCollectionFieldLayoutChanged();
			}
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000B4E3F File Offset: 0x000B303F
		private void OnBumpVersionNumber()
		{
			this._collectionVersion++;
			this._bumpVersionOperation = null;
			this.OnPropertyChanged("CollectionVersion");
		}

		// Token: 0x17000C16 RID: 3094
		public global::Infragistics.Windows.DataPresenter.Record this[int index]
		{
			get
			{
				return this.SparseArray.GetItem(index, true);
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x060028DE RID: 10462 RVA: 0x000B4E81 File Offset: 0x000B3081
		// (remove) Token: 0x060028DF RID: 10463 RVA: 0x000B4E9A File Offset: 0x000B309A
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			add
			{
				this._collectionChangedHandler = (global::System.Delegate.Combine(this._collectionChangedHandler, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			remove
			{
				this._collectionChangedHandler = (global::System.Delegate.Remove(this._collectionChangedHandler, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
			}
		}

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x060028E0 RID: 10464 RVA: 0x000B4EB3 File Offset: 0x000B30B3
		// (remove) Token: 0x060028E1 RID: 10465 RVA: 0x000B4ECC File Offset: 0x000B30CC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			add
			{
				this._propertyChangedHandler = (global::System.Delegate.Combine(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			remove
			{
				this._propertyChangedHandler = (global::System.Delegate.Remove(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000B4EE5 File Offset: 0x000B30E5
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000B4EF6 File Offset: 0x000B30F6
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000B4F07 File Offset: 0x000B3107
		bool global::System.Collections.IList.Contains(object value)
		{
			return this.SparseArray.Contains(value);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000B4F15 File Offset: 0x000B3115
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this.SparseArray.IndexOf(value);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000B4F23 File Offset: 0x000B3123
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000B4F34 File Offset: 0x000B3134
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000B4F37 File Offset: 0x000B3137
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000B4F3A File Offset: 0x000B313A
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000B4F4B File Offset: 0x000B314B
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000C19 RID: 3097
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this.SparseArray.GetItem(index, true);
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000B4F7C File Offset: 0x000B317C
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.SparseArray.CopyTo(array, index, this.SparseArray);
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x000B4F91 File Offset: 0x000B3191
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return this.SparseArray.IsSynchronized;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x000B4F9E File Offset: 0x000B319E
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this.SparseArray.SyncRoot;
			}
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000B4FAB File Offset: 0x000B31AB
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.SparseArray.GetEnumerator(this.SparseArray);
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000B4FBE File Offset: 0x000B31BE
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.Insert(int index, global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000B4FCF File Offset: 0x000B31CF
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000B4FE0 File Offset: 0x000B31E0
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Add(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000B4FF1 File Offset: 0x000B31F1
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x000B5002 File Offset: 0x000B3202
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000B5005 File Offset: 0x000B3205
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Remove(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000B5016 File Offset: 0x000B3216
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>.GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumerator(this.SparseArray);
		}

		// Token: 0x040013E2 RID: 5090
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;

		// Token: 0x040013E3 RID: 5091
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;

		// Token: 0x040013E4 RID: 5092
		private global::Infragistics.Windows.DataPresenter.Record _parentRecord;

		// Token: 0x040013E5 RID: 5093
		private global::Infragistics.Windows.DataPresenter.RecordManager _parentRecordManager;

		// Token: 0x040013E6 RID: 5094
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _viewableRecordCollection;

		// Token: 0x040013E7 RID: 5095
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040013E8 RID: 5096
		private global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase _sparseArray;

		// Token: 0x040013E9 RID: 5097
		private int _sortVersion;

		// Token: 0x040013EA RID: 5098
		private int _groupByVersion;

		// Token: 0x040013EB RID: 5099
		private global::Infragistics.Windows.DataPresenter.Field _groupByField;

		// Token: 0x040013EC RID: 5100
		private global::Infragistics.Windows.Controls.SortStatus _previousSortStatus;

		// Token: 0x040013ED RID: 5101
		private global::System.WeakReference _lastRecordList;

		// Token: 0x040013EE RID: 5102
		private global::Infragistics.Windows.DataPresenter.SummaryResultCollection _summaryResults;

		// Token: 0x040013EF RID: 5103
		private global::System.Windows.Threading.DispatcherOperation _bumpVersionOperation;

		// Token: 0x040013F0 RID: 5104
		private int _collectionVersion;

		// Token: 0x040013F1 RID: 5105
		internal global::Infragistics.Windows.DataPresenter.GroupsSynchronizer _groupsSynchronizer;

		// Token: 0x040013F2 RID: 5106
		internal global::Infragistics.Windows.DataPresenter.DataRecordsSynchronizer _recordsSynchronizer;

		// Token: 0x040013F3 RID: 5107
		private static object NullKey = new object();

		// Token: 0x0200034C RID: 844
		internal abstract class RecordEnumeratorBase : global::System.Collections.IEnumerator
		{
			// Token: 0x060028F9 RID: 10489 RVA: 0x000B502F File Offset: 0x000B322F
			internal RecordEnumeratorBase(global::System.Collections.IEnumerator enumerator)
			{
				this._enumerator = enumerator;
			}

			// Token: 0x17000C1D RID: 3101
			// (get) Token: 0x060028FA RID: 10490 RVA: 0x000B503E File Offset: 0x000B323E
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Record;
				}
			}

			// Token: 0x060028FB RID: 10491 RVA: 0x000B5050 File Offset: 0x000B3250
			public void Dispose()
			{
			}

			// Token: 0x17000C1E RID: 3102
			// (get) Token: 0x060028FC RID: 10492 RVA: 0x000B5052 File Offset: 0x000B3252
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._enumerator.Current;
				}
			}

			// Token: 0x060028FD RID: 10493 RVA: 0x000B505F File Offset: 0x000B325F
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x060028FE RID: 10494 RVA: 0x000B506C File Offset: 0x000B326C
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x040013F4 RID: 5108
			private global::System.Collections.IEnumerator _enumerator;
		}

		// Token: 0x0200034D RID: 845
		internal class RecordEnumerator : global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060028FF RID: 10495 RVA: 0x000B5079 File Offset: 0x000B3279
			internal RecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray) : base(sparseArray.GetEnumerator(sparseArray))
			{
			}

			// Token: 0x06002900 RID: 10496 RVA: 0x000B5088 File Offset: 0x000B3288
			internal RecordEnumerator(global::System.Collections.IEnumerator enumerator) : base(enumerator)
			{
			}

			// Token: 0x17000C1F RID: 3103
			// (get) Token: 0x06002901 RID: 10497 RVA: 0x000B5091 File Offset: 0x000B3291
			public new global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return base.Current;
				}
			}
		}

		// Token: 0x0200034E RID: 846
		internal class DataRecordEnumerator : global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002902 RID: 10498 RVA: 0x000B5099 File Offset: 0x000B3299
			internal DataRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray) : base(sparseArray.GetEnumerator(sparseArray))
			{
			}

			// Token: 0x17000C20 RID: 3104
			// (get) Token: 0x06002903 RID: 10499 RVA: 0x000B50A8 File Offset: 0x000B32A8
			public new global::Infragistics.Windows.DataPresenter.DataRecord Current
			{
				get
				{
					return base.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
				}
			}
		}

		// Token: 0x0200034F RID: 847
		internal class GroupByRecordEnumerator : global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.GroupByRecord>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002904 RID: 10500 RVA: 0x000B50B5 File Offset: 0x000B32B5
			internal GroupByRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray) : base(sparseArray.GetEnumerator(sparseArray))
			{
			}

			// Token: 0x17000C21 RID: 3105
			// (get) Token: 0x06002905 RID: 10501 RVA: 0x000B50C4 File Offset: 0x000B32C4
			public new global::Infragistics.Windows.DataPresenter.GroupByRecord Current
			{
				get
				{
					return base.Current as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				}
			}
		}

		// Token: 0x02000350 RID: 848
		internal class ExpandableFieldRecordEnumerator : global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002906 RID: 10502 RVA: 0x000B50D1 File Offset: 0x000B32D1
			internal ExpandableFieldRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray) : base(sparseArray.GetEnumerator(sparseArray))
			{
			}

			// Token: 0x17000C22 RID: 3106
			// (get) Token: 0x06002907 RID: 10503 RVA: 0x000B50E0 File Offset: 0x000B32E0
			public new global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord Current
			{
				get
				{
					return base.Current as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
				}
			}
		}
	}
}
