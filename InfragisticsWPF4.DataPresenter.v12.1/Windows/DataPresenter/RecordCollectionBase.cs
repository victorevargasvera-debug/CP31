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
	// Token: 0x0200030A RID: 778
	public abstract class RecordCollectionBase : global::System.ComponentModel.INotifyPropertyChanged, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable
	{
		// Token: 0x060024EB RID: 9451 RVA: 0x0009FE08 File Offset: 0x0009E008
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

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x0009FE93 File Offset: 0x0009E093
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public int CollectionVersion
		{
			get
			{
				return this._collectionVersion;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x0009FE9B File Offset: 0x0009E09B
		public int Count
		{
			get
			{
				return this.SparseArray.Count;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x0009FEA8 File Offset: 0x0009E0A8
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._parentRecordManager.DataPresenter;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x0009FEB5 File Offset: 0x0009E0B5
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x0009FEC0 File Offset: 0x0009E0C0
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x0009FF00 File Offset: 0x0009E100
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

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x0009FF22 File Offset: 0x0009E122
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x0009FF48 File Offset: 0x0009E148
		public global::Infragistics.Windows.DataPresenter.Record ParentRecord
		{
			get
			{
				return this._parentRecord;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x0009FF50 File Offset: 0x0009E150
		public global::Infragistics.Windows.DataPresenter.RecordManager ParentRecordManager
		{
			get
			{
				return this._parentRecordManager;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0009FF58 File Offset: 0x0009E158
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

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x0009FFD4 File Offset: 0x0009E1D4
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

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x0009FFF3 File Offset: 0x0009E1F3
		internal global::Infragistics.Windows.DataPresenter.Field GroupByField
		{
			get
			{
				return this._groupByField;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x0009FFFB File Offset: 0x0009E1FB
		internal int GroupByVersion
		{
			get
			{
				return this._groupByVersion;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000A0004 File Offset: 0x0009E204
		internal bool IsTopLevel
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				return parentRecord == null || parentRecord is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x000A0026 File Offset: 0x0009E226
		internal bool IsRootLevel
		{
			get
			{
				return null == this.ParentRecord;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000A0034 File Offset: 0x0009E234
		internal bool IsUpdating
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this.ParentRecordManager;
				return parentRecordManager != null && parentRecordManager.IsUpdating;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x000A0053 File Offset: 0x0009E253
		internal bool IsViewableRecordsCollectionAllocated
		{
			get
			{
				return this._viewableRecordCollection != null;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060024FD RID: 9469
		internal abstract global::Infragistics.Windows.DataPresenter.RecordType RecordsType { get; }

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x000A0061 File Offset: 0x0009E261
		internal int SortVersion
		{
			get
			{
				return this._sortVersion;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000A0069 File Offset: 0x0009E269
		internal global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase SparseArray
		{
			get
			{
				return this._sparseArray;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x000A0071 File Offset: 0x0009E271
		internal global::Infragistics.Windows.DataPresenter.SummaryResultCollection SummaryResultsIfAllocated
		{
			get
			{
				return this._summaryResults;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x000A0079 File Offset: 0x0009E279
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecords
		{
			get
			{
				return this._viewableRecordCollection;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x000A0081 File Offset: 0x0009E281
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecordsIfAllocated
		{
			get
			{
				return this._viewableRecordCollection;
			}
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000A0089 File Offset: 0x0009E289
		public void CollapseAll(bool recursive)
		{
			this.ExpandCollapseAllHelper(false, recursive ? -1 : 0);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000A0099 File Offset: 0x0009E299
		public void CollapseAll(int recursionDepth)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(recursionDepth);
			this.ExpandCollapseAllHelper(false, recursionDepth);
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000A00A9 File Offset: 0x0009E2A9
		public bool Contains(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return this.SparseArray.Contains(item);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000A00B7 File Offset: 0x0009E2B7
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int arrayIndex)
		{
			this.SparseArray.CopyTo(array, arrayIndex, this.SparseArray);
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000A00CC File Offset: 0x0009E2CC
		public void ExpandAll(bool recursive)
		{
			this.ExpandCollapseAllHelper(true, recursive ? -1 : 0);
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000A00DC File Offset: 0x0009E2DC
		public void ExpandAll(int recursionDepth)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(recursionDepth);
			this.ExpandCollapseAllHelper(true, recursionDepth);
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000A00EC File Offset: 0x0009E2EC
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return this.SparseArray.IndexOf(item);
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000A00FC File Offset: 0x0009E2FC
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

		// Token: 0x0600250B RID: 9483 RVA: 0x000A0149 File Offset: 0x0009E349
		internal void AddRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.InsertRecord(this.SparseArray.Count, record);
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000A015D File Offset: 0x0009E35D
		internal virtual global::Infragistics.Windows.DataPresenter.Record AllocateNewRecord(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_11"));
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000A0170 File Offset: 0x0009E370
		internal void BeginUpdate()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this.ParentRecordManager;
			if (parentRecordManager != null)
			{
				parentRecordManager.BeginUpdate();
			}
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000A0190 File Offset: 0x0009E390
		internal void BumpCollectionVersion()
		{
			if (this._bumpVersionOperation == null && this._parentRecordManager != null && this._parentRecordManager.DataPresenter != null)
			{
				this._bumpVersionOperation = this._parentRecordManager.DataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnBumpVersionNumber));
			}
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000A01E2 File Offset: 0x0009E3E2
		internal void Clear()
		{
			if (this.SparseArray.Count > 0)
			{
				this.SparseArray.Clear();
				this.RaiseChangeEvents(true);
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000A0204 File Offset: 0x0009E404
		internal void CreateGroupByRecordsHelper(global::Infragistics.Windows.DataPresenter.DataRecord[] records)
		{
			this.InitializeGroupByField();
			int num = 0;
			this.CreateGroupByRecordsHelper(records, ref num);
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000A0224 File Offset: 0x0009E424
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
					this.SortGroupByRecords(comparer, global::Infragistics.Windows.Controls.SortStatus.Ascending != groupByField.SortStatus);
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

		// Token: 0x06002512 RID: 9490 RVA: 0x000A056C File Offset: 0x0009E76C
		internal void EndUpdate(bool dirtyScrollCount)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this.ParentRecordManager;
			if (parentRecordManager != null)
			{
				parentRecordManager.EndUpdate(dirtyScrollCount);
			}
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x000A058A File Offset: 0x0009E78A
		internal virtual void EnsureNotDirty()
		{
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x000A058C File Offset: 0x0009E78C
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

		// Token: 0x06002515 RID: 9493 RVA: 0x000A08E0 File Offset: 0x0009EAE0
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

		// Token: 0x06002516 RID: 9494 RVA: 0x000A0900 File Offset: 0x0009EB00
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

		// Token: 0x06002517 RID: 9495 RVA: 0x000A0A64 File Offset: 0x0009EC64
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

		// Token: 0x06002518 RID: 9496 RVA: 0x000A0A84 File Offset: 0x0009EC84
		internal static bool HasAdditionalGroupByFields(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return layout != null && layout.HasGroupBySortFields;
			}
			int num = field.Owner.SortedFields.IndexOf(field);
			return num < field.Owner.SortedFields.CountOfGroupByFields - 1;
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000A0AC7 File Offset: 0x0009ECC7
		internal void InitializeSortVersion()
		{
			if (this._fieldLayout != null)
			{
				this._groupByVersion = this._fieldLayout.GroupByVersion;
				this._sortVersion = this._fieldLayout.SortVersion;
			}
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x000A0AF3 File Offset: 0x0009ECF3
		internal void InitializeSortStatus()
		{
			if (this._groupByField != null)
			{
				this._previousSortStatus = this._groupByField.SortStatus;
			}
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x000A0B0E File Offset: 0x0009ED0E
		internal void InitializeFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this.InternalSetFieldLayout(layout);
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000A0B17 File Offset: 0x0009ED17
		internal void InsertRecord(int index, global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.SparseArray.Insert(index, record);
			this.RaiseChangeEvents(false);
			this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, record, index);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000A0B36 File Offset: 0x0009ED36
		internal void RaiseChangeEvents(bool fullReset)
		{
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			if (fullReset)
			{
				this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, null, -1);
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000A0B5C File Offset: 0x0009ED5C
		internal void RemoveAt(int index)
		{
			global::Infragistics.Windows.DataPresenter.Record item = this.SparseArray.GetItem(index, null) as global::Infragistics.Windows.DataPresenter.Record;
			this.SparseArray.RemoveAt(index);
			this.RaiseChangeEvents(false);
			this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, item, index);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000A0B98 File Offset: 0x0009ED98
		internal void RemoveRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			int num = this.SparseArray.IndexOf(record);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000A0BC0 File Offset: 0x0009EDC0
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
						if (groupByComparerResolved == null)
						{
							if (this._previousSortStatus != groupByField.SortStatus)
							{
								this.SparseArray.Reverse();
							}
						}
						else
						{
							this.SortGroupByRecords(groupByComparerResolved, global::Infragistics.Windows.Controls.SortStatus.Ascending != groupByField.SortStatus);
						}
						this._previousSortStatus = groupByField.SortStatus;
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

		// Token: 0x06002521 RID: 9505 RVA: 0x000A0D90 File Offset: 0x0009EF90
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

		// Token: 0x06002522 RID: 9506 RVA: 0x000A0DD0 File Offset: 0x0009EFD0
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

		// Token: 0x06002523 RID: 9507 RVA: 0x000A0E1F File Offset: 0x0009F01F
		protected internal virtual void OnPropertyChanged(string propertyName)
		{
			if (this._propertyChangedHandler != null)
			{
				this._propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000A0E3B File Offset: 0x0009F03B
		protected virtual void SortGroupByRecords(global::System.Collections.IComparer comparer, bool reverse)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_12"));
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x000A0E4C File Offset: 0x0009F04C
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

		// Token: 0x06002526 RID: 9510 RVA: 0x000A0EF4 File Offset: 0x0009F0F4
		protected internal void DirtyFixedRecordOrder()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordsIfAllocated = this.ViewableRecordsIfAllocated;
			if (viewableRecordsIfAllocated != null)
			{
				viewableRecordsIfAllocated.DirtyFixedRecordOrder();
			}
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x000A0F11 File Offset: 0x0009F111
		internal static object GetValueKey(object key)
		{
			if (key != null)
			{
				return key;
			}
			return global::Infragistics.Windows.DataPresenter.RecordCollectionBase.NullKey;
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000A0F20 File Offset: 0x0009F120
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
					num = groupByRecord.FieldLayout.SortedFields.IndexOf(groupByRecord.GroupByField);
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

		// Token: 0x06002529 RID: 9513 RVA: 0x000A104E File Offset: 0x0009F24E
		private void InternalSetFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
			if (this._viewableRecordCollection != null)
			{
				this._viewableRecordCollection.OnRecordCollectionFieldLayoutChanged();
			}
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000A106A File Offset: 0x0009F26A
		private void OnBumpVersionNumber()
		{
			this._collectionVersion++;
			this._bumpVersionOperation = null;
			this.OnPropertyChanged("CollectionVersion");
		}

		// Token: 0x17000AE5 RID: 2789
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

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x0600252D RID: 9517 RVA: 0x000A10AC File Offset: 0x0009F2AC
		// (remove) Token: 0x0600252E RID: 9518 RVA: 0x000A10C5 File Offset: 0x0009F2C5
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

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x0600252F RID: 9519 RVA: 0x000A10DE File Offset: 0x0009F2DE
		// (remove) Token: 0x06002530 RID: 9520 RVA: 0x000A10F7 File Offset: 0x0009F2F7
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

		// Token: 0x06002531 RID: 9521 RVA: 0x000A1110 File Offset: 0x0009F310
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000A1121 File Offset: 0x0009F321
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000A1132 File Offset: 0x0009F332
		bool global::System.Collections.IList.Contains(object value)
		{
			return this.SparseArray.Contains(value);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000A1140 File Offset: 0x0009F340
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this.SparseArray.IndexOf(value);
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000A114E File Offset: 0x0009F34E
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x000A115F File Offset: 0x0009F35F
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x000A1162 File Offset: 0x0009F362
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000A1165 File Offset: 0x0009F365
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000A1176 File Offset: 0x0009F376
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000AE8 RID: 2792
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

		// Token: 0x0600253C RID: 9532 RVA: 0x000A11A7 File Offset: 0x0009F3A7
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.SparseArray.CopyTo(array, index, this.SparseArray);
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x000A11BC File Offset: 0x0009F3BC
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return this.SparseArray.IsSynchronized;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000A11C9 File Offset: 0x0009F3C9
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this.SparseArray.SyncRoot;
			}
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000A11D6 File Offset: 0x0009F3D6
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.SparseArray.GetEnumerator(this.SparseArray);
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000A11E9 File Offset: 0x0009F3E9
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.Insert(int index, global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000A11FA File Offset: 0x0009F3FA
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000A120B File Offset: 0x0009F40B
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Add(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000A121C File Offset: 0x0009F41C
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x000A122D File Offset: 0x0009F42D
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000A1230 File Offset: 0x0009F430
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Remove(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000A1241 File Offset: 0x0009F441
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>.GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumerator(this.SparseArray);
		}

		// Token: 0x040011C2 RID: 4546
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;

		// Token: 0x040011C3 RID: 4547
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;

		// Token: 0x040011C4 RID: 4548
		private global::Infragistics.Windows.DataPresenter.Record _parentRecord;

		// Token: 0x040011C5 RID: 4549
		private global::Infragistics.Windows.DataPresenter.RecordManager _parentRecordManager;

		// Token: 0x040011C6 RID: 4550
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _viewableRecordCollection;

		// Token: 0x040011C7 RID: 4551
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040011C8 RID: 4552
		private global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase _sparseArray;

		// Token: 0x040011C9 RID: 4553
		private int _sortVersion;

		// Token: 0x040011CA RID: 4554
		private int _groupByVersion;

		// Token: 0x040011CB RID: 4555
		private global::Infragistics.Windows.DataPresenter.Field _groupByField;

		// Token: 0x040011CC RID: 4556
		private global::Infragistics.Windows.Controls.SortStatus _previousSortStatus;

		// Token: 0x040011CD RID: 4557
		private global::System.WeakReference _lastRecordList;

		// Token: 0x040011CE RID: 4558
		private global::Infragistics.Windows.DataPresenter.SummaryResultCollection _summaryResults;

		// Token: 0x040011CF RID: 4559
		private global::System.Windows.Threading.DispatcherOperation _bumpVersionOperation;

		// Token: 0x040011D0 RID: 4560
		private int _collectionVersion;

		// Token: 0x040011D1 RID: 4561
		internal global::Infragistics.Windows.DataPresenter.GroupsSynchronizer _groupsSynchronizer;

		// Token: 0x040011D2 RID: 4562
		internal global::Infragistics.Windows.DataPresenter.DataRecordsSynchronizer _recordsSynchronizer;

		// Token: 0x040011D3 RID: 4563
		private static object NullKey = new object();

		// Token: 0x0200030B RID: 779
		internal abstract class RecordEnumeratorBase : global::System.Collections.IEnumerator
		{
			// Token: 0x06002548 RID: 9544 RVA: 0x000A125A File Offset: 0x0009F45A
			internal RecordEnumeratorBase(global::System.Collections.IEnumerator enumerator)
			{
				this._enumerator = enumerator;
			}

			// Token: 0x17000AEC RID: 2796
			// (get) Token: 0x06002549 RID: 9545 RVA: 0x000A1269 File Offset: 0x0009F469
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Record;
				}
			}

			// Token: 0x0600254A RID: 9546 RVA: 0x000A127B File Offset: 0x0009F47B
			public void Dispose()
			{
			}

			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x0600254B RID: 9547 RVA: 0x000A127D File Offset: 0x0009F47D
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._enumerator.Current;
				}
			}

			// Token: 0x0600254C RID: 9548 RVA: 0x000A128A File Offset: 0x0009F48A
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x0600254D RID: 9549 RVA: 0x000A1297 File Offset: 0x0009F497
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x040011D4 RID: 4564
			private global::System.Collections.IEnumerator _enumerator;
		}

		// Token: 0x0200030C RID: 780
		internal class RecordEnumerator : global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600254E RID: 9550 RVA: 0x000A12A4 File Offset: 0x0009F4A4
			internal RecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray) : base(sparseArray.GetEnumerator(sparseArray))
			{
			}

			// Token: 0x0600254F RID: 9551 RVA: 0x000A12B3 File Offset: 0x0009F4B3
			internal RecordEnumerator(global::System.Collections.IEnumerator enumerator) : base(enumerator)
			{
			}

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x06002550 RID: 9552 RVA: 0x000A12BC File Offset: 0x0009F4BC
			public new global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return base.Current;
				}
			}
		}

		// Token: 0x0200030D RID: 781
		internal class DataRecordEnumerator : global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002551 RID: 9553 RVA: 0x000A12C4 File Offset: 0x0009F4C4
			internal DataRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray) : base(sparseArray.GetEnumerator(sparseArray))
			{
			}

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x06002552 RID: 9554 RVA: 0x000A12D3 File Offset: 0x0009F4D3
			public new global::Infragistics.Windows.DataPresenter.DataRecord Current
			{
				get
				{
					return base.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
				}
			}
		}

		// Token: 0x0200030E RID: 782
		internal class GroupByRecordEnumerator : global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.GroupByRecord>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002553 RID: 9555 RVA: 0x000A12E0 File Offset: 0x0009F4E0
			internal GroupByRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray) : base(sparseArray.GetEnumerator(sparseArray))
			{
			}

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x06002554 RID: 9556 RVA: 0x000A12EF File Offset: 0x0009F4EF
			public new global::Infragistics.Windows.DataPresenter.GroupByRecord Current
			{
				get
				{
					return base.Current as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				}
			}
		}

		// Token: 0x0200030F RID: 783
		internal class ExpandableFieldRecordEnumerator : global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002555 RID: 9557 RVA: 0x000A12FC File Offset: 0x0009F4FC
			internal ExpandableFieldRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray) : base(sparseArray.GetEnumerator(sparseArray))
			{
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x06002556 RID: 9558 RVA: 0x000A130B File Offset: 0x0009F50B
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
