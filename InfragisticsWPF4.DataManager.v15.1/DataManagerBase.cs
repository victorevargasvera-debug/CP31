using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Infragistics
{
	// Token: 0x0200001C RID: 28
	public abstract class DataManagerBase : global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000088EF File Offset: 0x00006AEF
		public global::System.Collections.ObjectModel.Collection<global::Infragistics.SortContext> Sort
		{
			get
			{
				if (this._currentSort == null)
				{
					this._currentSort = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.SortContext>();
				}
				return this._currentSort;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000890A File Offset: 0x00006B0A
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00008912 File Offset: 0x00006B12
		public global::Infragistics.FormattingRuleCollection<global::Infragistics.IRule> ConditionalFormattingRules
		{
			get
			{
				return this._conditionalFormatRules;
			}
			set
			{
				this._conditionalFormatRules = value;
				this.ClearCachedDataSource(false);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00008922 File Offset: 0x00006B22
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000892C File Offset: 0x00006B2C
		public global::Infragistics.RecordFilterCollection Filters
		{
			get
			{
				return this._currentFilter;
			}
			set
			{
				this.DetachFilterEvents();
				this._currentFilter = value;
				bool flag = this.ICollectionViewData != null && this.ICollectionViewData.CanGroup;
				if (!flag || this.GroupByObject == null)
				{
					this.ClearCachedDataSource(false);
				}
				if (this._currentFilter != null)
				{
					this._currentFilter.CollectionChanged += this.CurrentFilter_CollectionChanged;
					this._currentFilter.CollectionItemChanged += this.CurrentFilter_CollectionItemChanged;
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000089A7 File Offset: 0x00006BA7
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000089AF File Offset: 0x00006BAF
		public global::Infragistics.SummaryDefinitionCollection Summaries
		{
			get
			{
				return this._currentSummaries;
			}
			protected internal set
			{
				this.SummariesDirty = true;
				this._currentSummaries = value;
				this.ClearCachedDataSource(false);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000089C6 File Offset: 0x00006BC6
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000089CE File Offset: 0x00006BCE
		public global::Infragistics.SummaryResultCollection SummaryResultCollection { get; protected internal set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000089D7 File Offset: 0x00006BD7
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000089DF File Offset: 0x00006BDF
		public global::Infragistics.SummaryExecution SummaryExecution
		{
			get
			{
				return this._summaryExecution;
			}
			set
			{
				if (this._summaryExecution != value)
				{
					this._summaryExecution = value;
					this.ClearCachedDataSource(true);
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000089F8 File Offset: 0x00006BF8
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00008A00 File Offset: 0x00006C00
		public global::Infragistics.GroupByContext GroupByObject { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00008A09 File Offset: 0x00006C09
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00008A11 File Offset: 0x00006C11
		public global::Infragistics.SortContext GroupBySortContext { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00008A1A File Offset: 0x00006C1A
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00008A22 File Offset: 0x00006C22
		public bool GroupBySortAscending { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00008A2B File Offset: 0x00006C2B
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00008A43 File Offset: 0x00006C43
		public int CurrentPage
		{
			get
			{
				if (this._currentPage <= this.PageCount)
				{
					return this._currentPage;
				}
				return 1;
			}
			set
			{
				if (value != this._currentPage)
				{
					this._currentPage = value;
					this._sortedFilterDataSource = null;
					this.IsSortedFilteredDataSourceCalculated = false;
					this.InvalidateSortedFilterdDataSource();
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00008A69 File Offset: 0x00006C69
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00008A74 File Offset: 0x00006C74
		public int PageSize
		{
			get
			{
				return this._pageSize;
			}
			set
			{
				if (this._pageSize != value)
				{
					this._pageSize = value;
					if (this.EnablePaging)
					{
						this.ClearCachedDataSource(false);
					}
					if (this.IPagedCollectionViewData != null && this.IPagedCollectionViewData.PageSize != this.PageSize)
					{
						this.IPagedCollectionViewData.PageSize = this.PageSize;
					}
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00008ACC File Offset: 0x00006CCC
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00008AD4 File Offset: 0x00006CD4
		public bool EnablePaging
		{
			get
			{
				return this._enablePaging;
			}
			set
			{
				if (this._enablePaging != value)
				{
					this._enablePaging = value;
					this.ClearCachedDataSource(false);
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00008AED File Offset: 0x00006CED
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00008AF5 File Offset: 0x00006CF5
		public global::System.Collections.IEnumerable DataSource
		{
			get
			{
				return this.GetDataSource();
			}
			set
			{
				this.SetDataSource(value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00008AFE File Offset: 0x00006CFE
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00008B08 File Offset: 0x00006D08
		public global::System.Collections.IEnumerable OriginalDataSource
		{
			get
			{
				return this._originalDataSource;
			}
			set
			{
				this._originalDataSource = value;
				this._pagedCollection = (value as global::Infragistics.IPagedCollectionView);
				this._collectionView = (value as global::System.ComponentModel.ICollectionView);
				this._list = (value as global::System.Collections.IList);
				this._editableCollectionView = (value as global::System.ComponentModel.IEditableCollectionView);
				this._filteredCollectionView = (value as global::Infragistics.IFilteredCollectionView);
				global::System.Collections.IEnumerable enumerable = value;
				if (this._collectionView != null && this._collectionView.SourceCollection != null)
				{
					enumerable = this._collectionView.SourceCollection;
				}
				this._bindingList = (enumerable as global::System.ComponentModel.IBindingList);
				this._typedList = (enumerable as global::System.ComponentModel.ITypedList);
				this._bindingListView = (enumerable as global::System.ComponentModel.IBindingListView);
				if (this._list == null && enumerable is global::System.ComponentModel.IListSource)
				{
					this._list = ((global::System.ComponentModel.IListSource)enumerable).GetList();
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00008BC0 File Offset: 0x00006DC0
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00008C0E File Offset: 0x00006E0E
		public int PageCount
		{
			get
			{
				if (this.IPagedCollectionViewData != null && this.IPagedCollectionViewData.TotalItemCount != -1)
				{
					this._pageCount = (int)global::System.Math.Ceiling((double)this.IPagedCollectionViewData.TotalItemCount / (double)this.IPagedCollectionViewData.PageSize);
				}
				return this._pageCount;
			}
			set
			{
				this._pageCount = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00008C18 File Offset: 0x00006E18
		protected global::System.Type CollectionType
		{
			get
			{
				global::System.Type result = null;
				if (this.DataSource != null)
				{
					result = global::Infragistics.DataManagerBase.ResolveCollectionType(this.OriginalDataSource);
				}
				return result;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00008C3C File Offset: 0x00006E3C
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00008C5E File Offset: 0x00006E5E
		public global::System.Type CachedCollectionType
		{
			get
			{
				if (this._cachedCollectionType == null)
				{
					this._cachedCollectionType = this.CollectionType;
				}
				return this._cachedCollectionType;
			}
			set
			{
				this._cachedCollectionType = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00008C68 File Offset: 0x00006E68
		protected global::System.Type DataType
		{
			get
			{
				global::System.Type result = null;
				if (this.DataSource != null)
				{
					result = global::Infragistics.DataManagerBase.ResolveItemType(this.DataSource, this._shouldUnwrapCollectionView, this._preferEnumerableItemType);
				}
				return result;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00008C98 File Offset: 0x00006E98
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00008CBA File Offset: 0x00006EBA
		public global::System.Type CachedType
		{
			get
			{
				if (this._cachedType == null)
				{
					this._cachedType = this.DataType;
				}
				return this._cachedType;
			}
			set
			{
				this._cachedType = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00008CC4 File Offset: 0x00006EC4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00008D0F File Offset: 0x00006F0F
		public global::Infragistics.CachedTypedInfo CachedTypedInfo
		{
			get
			{
				if (this._cachedTypedInfo != null)
				{
					return this._cachedTypedInfo;
				}
				global::Infragistics.CachedTypedInfo cachedTypedInfo = new global::Infragistics.CachedTypedInfo
				{
					CachedType = this.CachedType
				};
				if (this.ITypedListData != null)
				{
					cachedTypedInfo.PropertyDescriptors = this.ITypedListData.GetItemProperties(null);
				}
				return cachedTypedInfo;
			}
			internal set
			{
				this._cachedTypedInfo = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00008D18 File Offset: 0x00006F18
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00008D7E File Offset: 0x00006F7E
		public virtual int TotalRecordCount
		{
			get
			{
				if (this._totalRecordCount == -1)
				{
					int totalRecordCount;
					if (this.IPagedCollectionViewData != null && this.IPagedCollectionViewData.TotalItemCount != -1)
					{
						totalRecordCount = this.IPagedCollectionViewData.TotalItemCount;
					}
					else if (this.IListData != null)
					{
						totalRecordCount = this.IListData.Count;
					}
					else
					{
						totalRecordCount = this.ResolveCount();
					}
					this._totalRecordCount = totalRecordCount;
				}
				return this._totalRecordCount;
			}
			protected set
			{
				this._totalRecordCount = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00008D88 File Offset: 0x00006F88
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00008DE9 File Offset: 0x00006FE9
		public virtual int RecordCount
		{
			get
			{
				int result = 0;
				if (this._dataSource != null)
				{
					if (this.IPagedCollectionViewData != null && this.IPagedCollectionViewData.TotalItemCount != -1)
					{
						if (this._recordCount == -1)
						{
							this._recordCount = this.ResolveCount();
						}
					}
					else if (this._recordCount == -1)
					{
						this._recordCount = this.TotalRecordCount;
					}
					result = this._recordCount;
				}
				return result;
			}
			protected set
			{
				this._recordCount = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00008DF2 File Offset: 0x00006FF2
		protected global::System.ComponentModel.ICollectionView ICollectionViewData
		{
			get
			{
				return this._collectionView;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00008DFA File Offset: 0x00006FFA
		protected global::Infragistics.IFilteredCollectionView IFilteredCollectionViewData
		{
			get
			{
				return this._filteredCollectionView;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00008E02 File Offset: 0x00007002
		internal global::Infragistics.IPagedCollectionView IPagedCollectionViewData
		{
			get
			{
				return this._pagedCollection;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00008E0A File Offset: 0x0000700A
		protected global::System.Collections.IList IListData
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00008E12 File Offset: 0x00007012
		protected global::System.ComponentModel.IEditableCollectionView IEditableCollectionViewData
		{
			get
			{
				return this._editableCollectionView;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00008E1A File Offset: 0x0000701A
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00008E22 File Offset: 0x00007022
		public bool SupportsDataManipulations { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00008E2B File Offset: 0x0000702B
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00008E33 File Offset: 0x00007033
		public bool SuspendInvalidateDataSource
		{
			get
			{
				return this._suspendInvalidateDataSource;
			}
			set
			{
				if (this._suspendInvalidateDataSource != value)
				{
					this._suspendInvalidateDataSource = value;
					if (!value)
					{
						this.InvalidateSortedFilterdDataSource();
					}
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00008E4E File Offset: 0x0000704E
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00008E56 File Offset: 0x00007056
		public bool AllowCollectionViewOverrides
		{
			get
			{
				return this._allowCollectionViewOverrides;
			}
			set
			{
				this._allowCollectionViewOverrides = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00008E5F File Offset: 0x0000705F
		public global::System.Collections.Generic.List<global::Infragistics.MergedDataContext> MergeDataContexts
		{
			get
			{
				if (this._mergeDataContexts == null)
				{
					this._mergeDataContexts = new global::System.Collections.Generic.List<global::Infragistics.MergedDataContext>();
				}
				return this._mergeDataContexts;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00008E7A File Offset: 0x0000707A
		public bool SupportsEditing
		{
			get
			{
				return this.IBindingListData == null || this.IBindingListData.AllowEdit;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00008E91 File Offset: 0x00007091
		public global::System.Collections.IList SortedFilteredDataSource
		{
			get
			{
				this.InvalidateSortedFilterdDataSource();
				return this._sortedFilterDataSource;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00008E9F File Offset: 0x0000709F
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00008EA7 File Offset: 0x000070A7
		protected bool IsSortedFilteredDataSourceCalculated { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00008EB0 File Offset: 0x000070B0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00008EB8 File Offset: 0x000070B8
		protected internal bool Defer { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00008EC1 File Offset: 0x000070C1
		protected global::System.ComponentModel.IBindingList IBindingListData
		{
			get
			{
				return this._bindingList;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00008EC9 File Offset: 0x000070C9
		protected global::System.ComponentModel.IBindingListView IBindingLisViewtData
		{
			get
			{
				return this._bindingListView;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00008ED1 File Offset: 0x000070D1
		protected global::System.ComponentModel.ITypedList ITypedListData
		{
			get
			{
				return this._typedList;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00008ED9 File Offset: 0x000070D9
		internal virtual global::System.Collections.IList SortedFilteredList
		{
			get
			{
				return this.SortedFilteredDataSource;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00008EE1 File Offset: 0x000070E1
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00008EE9 File Offset: 0x000070E9
		internal bool SummariesDirty { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00008EF2 File Offset: 0x000070F2
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00008EFA File Offset: 0x000070FA
		internal bool IsSorted { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00008F04 File Offset: 0x00007104
		internal bool SupportsChangeNotification
		{
			get
			{
				bool flag = this.DataSource is global::System.Collections.Specialized.INotifyCollectionChanged;
				return flag | this.IBindingListData != null;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008F30 File Offset: 0x00007130
		public static global::Infragistics.DataManagerBase CreateDataManager(global::System.Collections.IEnumerable dataSource)
		{
			return global::Infragistics.DataManagerBase.CreateDataManager(dataSource, null);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008F39 File Offset: 0x00007139
		public static global::Infragistics.DataManagerBase CreateDataManager(global::System.Collections.IEnumerable dataSource, global::Infragistics.DataManagerProvider provider)
		{
			return global::Infragistics.DataManagerBase.CreateDataManager(dataSource, provider, true, false, false);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008F48 File Offset: 0x00007148
		internal static global::Infragistics.DataManagerBase CreateDataManager(global::System.Collections.IEnumerable dataSource, global::Infragistics.DataManagerProvider provider, bool unwrapCollectionView, bool preferEnumerableItemType, bool allowObjectItemType)
		{
			global::Infragistics.DataManagerBase result;
			try
			{
				global::Infragistics.DataManagerBase dataManagerBase = null;
				global::System.Type type = global::Infragistics.DataManagerBase.ResolveItemType(dataSource, unwrapCollectionView, preferEnumerableItemType);
				global::System.Type type2 = typeof(global::Infragistics.DataManager<>);
				if (provider != null)
				{
					type2 = provider.ResolveDataManagerType();
				}
				if (type != null && (type != typeof(object) || allowObjectItemType))
				{
					bool flag = true;
					if (type.FullName == "System.ServiceModel.DomainServices.Client.Entity")
					{
						global::System.ComponentModel.IEditableCollectionView editableCollectionView = dataSource as global::System.ComponentModel.IEditableCollectionView;
						if (editableCollectionView != null && editableCollectionView.CanAddNew)
						{
							global::System.ComponentModel.ICollectionView collectionView = dataSource as global::System.ComponentModel.ICollectionView;
							if (collectionView != null)
							{
								try
								{
									object obj = editableCollectionView.AddNew();
									if (obj != null)
									{
										type = obj.GetType();
									}
									editableCollectionView.CancelNew();
								}
								catch (global::System.ArgumentNullException)
								{
								}
								collectionView.Refresh();
							}
						}
						else
						{
							flag = false;
						}
					}
					if (flag)
					{
						global::System.Type type3 = type2.MakeGenericType(new global::System.Type[]
						{
							type
						});
						dataManagerBase = (global::System.Activator.CreateInstance(type3, new object[0]) as global::Infragistics.DataManagerBase);
						dataManagerBase.DataSource = dataSource;
						dataManagerBase.SupportsDataManipulations = true;
						dataManagerBase._shouldUnwrapCollectionView = unwrapCollectionView;
						dataManagerBase._preferEnumerableItemType = preferEnumerableItemType;
						if (dataManagerBase.GetDataProperties().Count<global::Infragistics.DataField>() == 0 && dataManagerBase.TotalRecordCount == 0)
						{
							dataManagerBase.DataSource = null;
							return null;
						}
					}
				}
				result = dataManagerBase;
			}
			catch (global::System.NotImplementedException)
			{
				result = null;
			}
			catch (global::System.MemberAccessException)
			{
				result = new global::Infragistics.TypelessDataManager
				{
					DataSource = dataSource,
					SupportsDataManipulations = true
				};
			}
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000090DC File Offset: 0x000072DC
		public static global::System.Type ResolveCollectionType(global::System.Collections.IEnumerable dataSource)
		{
			global::System.Type result = null;
			global::System.Collections.IEnumerator enumerator = dataSource.GetEnumerator();
			if (enumerator == null)
			{
				throw new global::Infragistics.InvalidEnumeratorException(global::SR.GetString("InvalidEnumeratorException"));
			}
			global::System.Type type = enumerator.GetType();
			if (type.IsGenericType)
			{
				global::System.Type[] genericArguments = type.GetGenericArguments();
				if (genericArguments.Length > 0)
				{
					result = genericArguments[0];
				}
			}
			return result;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009126 File Offset: 0x00007326
		public static global::System.Type ResolveItemType(global::System.Collections.IEnumerable dataSource)
		{
			return global::Infragistics.DataManagerBase.ResolveItemType(dataSource, false, false);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009154 File Offset: 0x00007354
		internal static global::System.Type ResolveItemType(global::System.Collections.IEnumerable dataSource, bool unwrapCollectionView, bool preferEnumerableItemType)
		{
			global::System.Type type = null;
			global::System.Type type2 = null;
			global::System.Collections.IEnumerator enumerator = dataSource.GetEnumerator();
			if (enumerator == null)
			{
				throw new global::Infragistics.InvalidEnumeratorException(global::SR.GetString("InvalidEnumeratorException"));
			}
			if (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				if (obj != null)
				{
					type = obj.GetType();
				}
			}
			bool flag = false;
			global::System.Type type3 = dataSource.GetType();
			if (typeof(global::System.Collections.IDictionary).IsAssignableFrom(type3))
			{
				flag = true;
			}
			else if (type3.IsGenericType && type3.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.IDictionary<, >))
			{
				flag = true;
			}
			else if (type3.GetInterfaces().Any((global::System.Type i) => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.IDictionary<, >)))
			{
				flag = true;
			}
			if (!flag)
			{
				bool flag2 = false;
				foreach (global::System.Type type4 in type3.GetInterfaces())
				{
					bool isGenericType = type4.IsGenericType;
					if (isGenericType && type4.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.IEnumerable<>))
					{
						type2 = type4.GetGenericArguments()[0];
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					global::System.Type type5 = enumerator.GetType();
					foreach (global::System.Type type6 in type5.GetInterfaces())
					{
						bool isGenericType2 = type6.IsGenericType;
						if (isGenericType2 && type6.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.IEnumerator<>))
						{
							type2 = type6.GetGenericArguments()[0];
							break;
						}
					}
				}
				if (!flag2 && unwrapCollectionView)
				{
					global::System.ComponentModel.ICollectionView collectionView = dataSource as global::System.ComponentModel.ICollectionView;
					if (collectionView != null && collectionView.SourceCollection != null)
					{
						return global::Infragistics.DataManagerBase.ResolveItemType(collectionView.SourceCollection, unwrapCollectionView, preferEnumerableItemType);
					}
				}
			}
			global::System.Type result;
			if (preferEnumerableItemType && type2 != null)
			{
				result = type2;
			}
			else if (type != null && type2 == null)
			{
				result = type;
			}
			else if (type == null && type2 != null)
			{
				result = type2;
			}
			else
			{
				global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> enumerable = global::Infragistics.DataManagerBase.ResolvePropertiesForItemType(type2, null, 0);
				global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> enumerable2 = global::Infragistics.DataManagerBase.ResolvePropertiesForItemType(type, null, 0);
				if (enumerable != null && !enumerable.Any<global::Infragistics.DataField>())
				{
					result = type;
				}
				else if (enumerable2 != null && !enumerable2.Any<global::Infragistics.DataField>())
				{
					result = type2;
				}
				else if (type2 != null && type2 != typeof(object) && type2.FullName != "System.Windows.Ria.Entity" && type2.FullName != "System.ServiceModel.DomainServices.Client.Entity")
				{
					result = type2;
				}
				else if (dataSource is global::System.Data.DataView)
				{
					result = typeof(global::System.Data.DataRowView);
				}
				else
				{
					result = type;
				}
			}
			return result;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000093D6 File Offset: 0x000075D6
		public static global::System.Linq.Expressions.Expression BuildPropertyExpressionFromPropertyName(string propertyName, global::System.Linq.Expressions.ParameterExpression paramExpression)
		{
			return global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(propertyName, paramExpression, null, null, null);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000093E4 File Offset: 0x000075E4
		public static global::System.Linq.Expressions.Expression BuildPropertyExpressionFromPropertyName(string propertyName, global::System.Linq.Expressions.ParameterExpression paramExpression, global::Infragistics.CachedTypedInfo cachedTypedInfo, global::System.Type propertyType, object defaultValue)
		{
			if (string.IsNullOrEmpty(propertyName))
			{
				return paramExpression;
			}
			if (propertyName.Contains(".") || propertyName.Contains("["))
			{
				global::System.Linq.Expressions.Expression expression = null;
				string text = "";
				int length = propertyName.Length;
				for (int i = 0; i < length; i++)
				{
					char c = propertyName[i];
					char c2 = c;
					if (c2 != '.')
					{
						if (c2 != '[')
						{
							text += c;
						}
						else
						{
							if (expression == null)
							{
								if (text.Length > 0)
								{
									expression = global::Infragistics.DataManagerBase.ResolvePropertyExpression(paramExpression, text);
								}
								else
								{
									expression = paramExpression;
								}
							}
							else
							{
								expression = global::Infragistics.DataManagerBase.AddNullRefCheckToExpression(global::Infragistics.DataManagerBase.ResolvePropertyExpression(expression, text), expression);
							}
							int startIndex = i + 1;
							i = propertyName.IndexOf(']', startIndex);
							global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
							global::System.Reflection.PropertyInfo propertyInfo = global::Infragistics.DataManagerBase.ResolveIndexerPropertyInfo(propertyName, startIndex, i, expression.Type, list);
							if (propertyInfo != null)
							{
								global::System.Linq.Expressions.Expression[] array = new global::System.Linq.Expressions.Expression[list.Count];
								for (int j = 0; j < list.Count; j++)
								{
									array[j] = global::System.Linq.Expressions.Expression.Constant(list[j]);
								}
								expression = global::System.Linq.Expressions.Expression.MakeIndex(expression, propertyInfo, array);
								if (propertyType != null && propertyType != propertyInfo.PropertyType && propertyInfo.PropertyType.IsAssignableFrom(propertyType))
								{
									expression = global::System.Linq.Expressions.Expression.Convert(expression, propertyType);
								}
							}
							else
							{
								global::System.Reflection.MethodInfo methodInfo = global::Infragistics.DataManagerBase.ResolveIndexerMethodInfo(expression.Type, list);
								if (!(methodInfo != null))
								{
									throw new global::System.Exception(string.Format(global::SR.GetString("InvalidPropertyPathException"), propertyName));
								}
								global::System.Linq.Expressions.Expression[] array2 = new global::System.Linq.Expressions.Expression[list.Count];
								for (int k = 0; k < list.Count; k++)
								{
									array2[k] = global::System.Linq.Expressions.Expression.Constant(list[k]);
								}
								expression = global::System.Linq.Expressions.Expression.Call(expression, methodInfo, array2);
							}
							text = "";
						}
					}
					else
					{
						if (text.Length > 0)
						{
							if (expression == null)
							{
								expression = global::Infragistics.DataManagerBase.ResolvePropertyExpression(paramExpression, text);
							}
							else
							{
								expression = global::Infragistics.DataManagerBase.AddNullRefCheckToExpression(global::Infragistics.DataManagerBase.ResolvePropertyExpression(expression, text), expression);
							}
						}
						text = "";
					}
				}
				if (text.Length > 0)
				{
					expression = global::Infragistics.DataManagerBase.AddNullRefCheckToExpression(global::Infragistics.DataManagerBase.ResolvePropertyExpression(expression, text), expression);
				}
				return expression;
			}
			if (cachedTypedInfo != null && cachedTypedInfo.PropertyDescriptors != null && cachedTypedInfo.PropertyDescriptors.Count > 0)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = cachedTypedInfo.PropertyDescriptors[propertyName];
				global::System.Reflection.MethodInfo method = propertyDescriptor.GetType().GetMethod("GetValue");
				global::System.Linq.Expressions.Expression expression2 = global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Constant(propertyDescriptor), method, new global::System.Linq.Expressions.Expression[]
				{
					paramExpression
				});
				global::System.Linq.Expressions.Expression ifFalse = global::System.Linq.Expressions.Expression.Convert(expression2, propertyType);
				global::System.Linq.Expressions.Expression left = global::System.Linq.Expressions.Expression.Equal(expression2, global::System.Linq.Expressions.Expression.Constant(null, typeof(object)));
				global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.Equal(expression2, global::System.Linq.Expressions.Expression.Constant(global::System.DBNull.Value, typeof(object)));
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Or(left, right);
				global::System.Linq.Expressions.Expression ifTrue;
				if (defaultValue != null)
				{
					ifTrue = global::System.Linq.Expressions.Expression.Constant(defaultValue, propertyType);
				}
				else
				{
					ifTrue = global::System.Linq.Expressions.Expression.Default(propertyType);
				}
				return global::System.Linq.Expressions.Expression.Condition(test, ifTrue, ifFalse);
			}
			global::System.Type type = paramExpression.Type;
			if (type.IsInterface)
			{
				global::System.Reflection.PropertyInfo property = type.GetProperty(propertyName);
				if (property == null)
				{
					foreach (global::System.Type type2 in cachedTypedInfo.CachedType.GetInterfaces())
					{
						property = type2.GetProperty(propertyName);
						if (property != null)
						{
							break;
						}
					}
				}
				if (property != null)
				{
					return global::System.Linq.Expressions.Expression.Property(paramExpression, property);
				}
			}
			return global::System.Linq.Expressions.Expression.Property(paramExpression, propertyName);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000974C File Offset: 0x0000794C
		private static global::System.Linq.Expressions.Expression AddNullRefCheckToExpression(global::System.Linq.Expressions.Expression newExpression, global::System.Linq.Expressions.Expression expression)
		{
			if (expression != null && !expression.Type.IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(expression, global::System.Linq.Expressions.Expression.Constant(null, expression.Type));
				global::System.Linq.Expressions.Expression ifTrue = global::Infragistics.DataManagerBase.ExpressionTypeGenerationBase.CreateGenericExpressionConstant(newExpression.Type);
				newExpression = global::System.Linq.Expressions.Expression.Condition(test, ifTrue, newExpression);
			}
			return newExpression;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00009794 File Offset: 0x00007994
		public static global::System.Type ResolvePropertyTypeFromPropertyName(string propertyName, global::Infragistics.CachedTypedInfo rootType)
		{
			if (propertyName.Contains("["))
			{
				global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(propertyName, global::System.Linq.Expressions.Expression.Parameter(rootType.CachedType, "param"));
				return expression.Type;
			}
			if (rootType.PropertyDescriptors != null)
			{
				global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = rootType.PropertyDescriptors;
				if (propertyDescriptors != null && propertyDescriptors.Count > 0)
				{
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor = propertyDescriptors[propertyName];
					if (propertyDescriptor != null)
					{
						if (!(rootType.CachedType == typeof(global::System.Data.DataRowView)) || !propertyDescriptor.PropertyType.IsValueType)
						{
							return propertyDescriptor.PropertyType;
						}
						if (propertyDescriptor.PropertyType.IsValueType)
						{
							return typeof(global::System.Nullable<>).MakeGenericType(new global::System.Type[]
							{
								propertyDescriptor.PropertyType
							});
						}
					}
				}
			}
			string[] array = propertyName.Split(new char[]
			{
				'.'
			});
			global::System.Type propertyType = global::Infragistics.DataManagerBase.ResolveProperty(rootType.CachedType, array[0]).PropertyType;
			for (int i = 1; i < array.Length; i++)
			{
				global::System.Reflection.PropertyInfo propertyInfo = global::Infragistics.DataManagerBase.ResolveProperty(propertyType, array[i]);
				propertyType = propertyInfo.PropertyType;
			}
			return propertyType;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000098A4 File Offset: 0x00007AA4
		public static object ResolveValueFromPropertyPath(string propertyPath, object data)
		{
			return global::Infragistics.DataManagerBase.ResolveFromPropertyPath(propertyPath, data, true);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000098AE File Offset: 0x00007AAE
		public static global::System.Reflection.PropertyInfo ResolvePropertyInfoFromPropertyPath(string propertyPath, object data)
		{
			return global::Infragistics.DataManagerBase.ResolveFromPropertyPath(propertyPath, data, false) as global::System.Reflection.PropertyInfo;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000098C0 File Offset: 0x00007AC0
		private static object ResolveFromPropertyPath(string propertyPath, object data, bool returnValue)
		{
			if (propertyPath.Contains(".") || propertyPath.Contains("["))
			{
				global::System.Type type = data.GetType();
				string text = "";
				object obj = data;
				int length = propertyPath.Length;
				global::System.Reflection.PropertyInfo propertyInfo = null;
				for (int i = 0; i < length; i++)
				{
					char c = propertyPath[i];
					char c2 = c;
					if (c2 != '.')
					{
						if (c2 != '[')
						{
							text += c;
						}
						else
						{
							if (text.Length > 0)
							{
								propertyInfo = global::Infragistics.DataManagerBase.ResolveProperty(type, text);
								if (propertyInfo == null)
								{
									return null;
								}
								type = propertyInfo.PropertyType;
								obj = propertyInfo.GetValue(obj, null);
								if (obj == null)
								{
									return null;
								}
							}
							int startIndex = i + 1;
							i = propertyPath.IndexOf(']', startIndex);
							global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
							propertyInfo = global::Infragistics.DataManagerBase.ResolveIndexerPropertyInfo(propertyPath, startIndex, i, type, list);
							if (propertyInfo == null)
							{
								global::System.Reflection.MethodInfo methodInfo = global::Infragistics.DataManagerBase.ResolveIndexerMethodInfo(type, list);
								if (methodInfo == null)
								{
									return null;
								}
								type = methodInfo.ReturnType;
								obj = methodInfo.Invoke(obj, list.ToArray());
							}
							else
							{
								type = propertyInfo.PropertyType;
								obj = propertyInfo.GetValue(obj, list.ToArray());
							}
							if (obj == null)
							{
								return null;
							}
							text = "";
						}
					}
					else if (text.Length > 0)
					{
						propertyInfo = global::Infragistics.DataManagerBase.ResolveProperty(type, text);
						if (propertyInfo == null)
						{
							return null;
						}
						type = propertyInfo.PropertyType;
						obj = propertyInfo.GetValue(obj, null);
						if (obj == null)
						{
							return null;
						}
						text = "";
					}
				}
				if (text.Length > 0)
				{
					propertyInfo = global::Infragistics.DataManagerBase.ResolveProperty(type, text);
					if (propertyInfo == null)
					{
						return null;
					}
					type = propertyInfo.PropertyType;
					obj = propertyInfo.GetValue(obj, null);
				}
				if (returnValue)
				{
					return obj;
				}
				return propertyInfo;
			}
			else
			{
				string[] array = propertyPath.Split(new char[]
				{
					'.'
				});
				object obj2 = data;
				global::System.Reflection.PropertyInfo propertyInfo2 = null;
				global::System.Type type2 = data.GetType();
				foreach (string strB in array)
				{
					data = obj2;
					global::System.Reflection.PropertyInfo[] properties = type2.GetProperties();
					foreach (global::System.Reflection.PropertyInfo propertyInfo3 in properties)
					{
						if (string.Compare(propertyInfo3.Name, strB, global::System.StringComparison.Ordinal) == 0 && propertyInfo3.GetIndexParameters().Length == 0)
						{
							propertyInfo2 = propertyInfo3;
							break;
						}
					}
					if (propertyInfo2 == null)
					{
						break;
					}
					obj2 = propertyInfo2.GetValue(obj2, null);
					if (obj2 == null)
					{
						break;
					}
					type2 = propertyInfo2.PropertyType;
				}
				if (obj2 == data)
				{
					global::System.ComponentModel.ICustomTypeDescriptor customTypeDescriptor = obj2 as global::System.ComponentModel.ICustomTypeDescriptor;
					if (customTypeDescriptor != null)
					{
						global::System.ComponentModel.PropertyDescriptorCollection properties2 = customTypeDescriptor.GetProperties();
						foreach (object obj3 in properties2)
						{
							global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj3;
							if (propertyPath == propertyDescriptor.Name)
							{
								obj2 = propertyDescriptor.GetValue(data);
								break;
							}
						}
					}
				}
				if (returnValue)
				{
					return obj2;
				}
				return propertyInfo2;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009BC4 File Offset: 0x00007DC4
		private static bool CopyValues(object newObj, object obj)
		{
			global::System.Type type = obj.GetType();
			if (!(newObj.GetType() == type))
			{
				return false;
			}
			global::System.ComponentModel.ICustomTypeDescriptor customTypeDescriptor = obj as global::System.ComponentModel.ICustomTypeDescriptor;
			if (customTypeDescriptor != null)
			{
				global::System.ComponentModel.ICustomTypeDescriptor component = (global::System.ComponentModel.ICustomTypeDescriptor)newObj;
				global::System.ComponentModel.PropertyDescriptorCollection properties = customTypeDescriptor.GetProperties();
				foreach (object obj2 in properties)
				{
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj2;
					propertyDescriptor.SetValue(component, propertyDescriptor.GetValue(customTypeDescriptor));
				}
				return true;
			}
			global::System.Reflection.PropertyInfo[] properties2 = type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.SetProperty);
			foreach (global::System.Reflection.PropertyInfo propertyInfo in properties2)
			{
				if (propertyInfo.GetSetMethod() != null && propertyInfo.GetIndexParameters().Length <= 0)
				{
					object value = propertyInfo.GetValue(newObj, null);
					object value2 = propertyInfo.GetValue(obj, null);
					if (value2 != value && (value == null || value2 == null || !value2.Equals(value)))
					{
						propertyInfo.SetValue(newObj, propertyInfo.GetValue(obj, null), null);
					}
				}
			}
			return true;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00009CE8 File Offset: 0x00007EE8
		private static global::System.Reflection.MethodInfo ResolveIndexerMethodInfo(global::System.Type type, global::System.Collections.Generic.List<object> indexerParams)
		{
			global::System.Reflection.MethodInfo result = null;
			global::System.Reflection.MethodInfo[] methods = type.GetMethods();
			if (methods.Length == 1)
			{
				result = type.GetMethod("Get");
			}
			else
			{
				foreach (global::System.Reflection.MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == "Get")
					{
						bool flag = false;
						global::System.Reflection.ParameterInfo[] parameters = methodInfo.GetParameters();
						if (parameters != null && parameters.Length == indexerParams.Count)
						{
							flag = true;
							for (int j = 0; j < indexerParams.Count; j++)
							{
								if (parameters[j].ParameterType != indexerParams[j].GetType())
								{
									flag = false;
									break;
								}
							}
						}
						if (flag)
						{
							result = methodInfo;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009DA0 File Offset: 0x00007FA0
		private static global::System.Reflection.PropertyInfo ResolveIndexerPropertyInfo(string propertyName, int startIndex, int endIndex, global::System.Type type, global::System.Collections.Generic.List<object> indexerParams)
		{
			if (endIndex != -1)
			{
				string text = propertyName.Substring(startIndex, endIndex - startIndex);
				string[] array = text.ToString().Split(new char[]
				{
					','
				});
				foreach (string text2 in array)
				{
					object item = text2;
					int num = -1;
					if (int.TryParse(text2, out num))
					{
						item = num;
					}
					indexerParams.Add(item);
				}
			}
			global::System.Reflection.PropertyInfo result = null;
			string b = "Item";
			object[] customAttributes = type.GetCustomAttributes(typeof(global::System.Reflection.DefaultMemberAttribute), true);
			if (customAttributes.Length > 0)
			{
				global::System.Reflection.DefaultMemberAttribute defaultMemberAttribute = customAttributes[0] as global::System.Reflection.DefaultMemberAttribute;
				if (defaultMemberAttribute != null)
				{
					b = defaultMemberAttribute.MemberName;
				}
			}
			global::System.Reflection.PropertyInfo[] properties = type.GetProperties();
			foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.Name == b)
				{
					bool flag = false;
					global::System.Reflection.ParameterInfo[] indexParameters = propertyInfo.GetIndexParameters();
					if (indexParameters != null && indexParameters.Length == indexerParams.Count)
					{
						flag = true;
						for (int k = 0; k < indexerParams.Count; k++)
						{
							if (indexParameters[k].ParameterType != indexerParams[k].GetType())
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						result = propertyInfo;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009EF4 File Offset: 0x000080F4
		private static global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> ResolvePropertiesForItemType(global::System.Type itemType, global::Infragistics.DataManagerBase manager, int indexShift = 0)
		{
			if (itemType != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.DataField> list = new global::System.Collections.Generic.List<global::Infragistics.DataField>();
				global::System.Reflection.PropertyInfo[] array = global::Infragistics.DataManagerBase.ResolveProperties(itemType);
				int num = array.Length;
				foreach (global::System.Reflection.PropertyInfo propertyInfo in array)
				{
					if (manager != null)
					{
						global::Infragistics.DataField dataField = manager.GenerateDataField(propertyInfo);
						if (dataField != null)
						{
							list.Add(dataField);
							if (dataField.Order == 2147483647)
							{
								dataField.Order -= num + indexShift;
							}
						}
					}
					else
					{
						global::Infragistics.DataField item = new global::Infragistics.DataField(propertyInfo.Name, propertyInfo.PropertyType);
						list.Add(item);
					}
					num--;
				}
				list.Sort(new global::Infragistics.DataFieldComparer());
				return list;
			}
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009FA0 File Offset: 0x000081A0
		private static global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> ResolvePropertiesForCachedType(global::Infragistics.CachedTypedInfo typeInfo, global::Infragistics.DataManagerBase manager)
		{
			if (typeInfo != null)
			{
				int indexShift = 0;
				global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> enumerable = global::Infragistics.DataManagerBase.ResolvePropertiesForItemType(typeInfo.CachedType, manager, indexShift);
				return (enumerable != null) ? enumerable.ToList<global::Infragistics.DataField>() : new global::System.Collections.Generic.List<global::Infragistics.DataField>();
			}
			return null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000A008 File Offset: 0x00008208
		internal static global::System.Reflection.PropertyInfo[] ResolveProperties(global::System.Type type)
		{
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> propInfo = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>();
			bool isInterface = type.IsInterface;
			if (isInterface)
			{
				global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>();
				global::System.Collections.Generic.Queue<global::System.Type> queue = new global::System.Collections.Generic.Queue<global::System.Type>();
				list.Add(type);
				queue.Enqueue(type);
				while (queue.Count > 0)
				{
					global::System.Type type2 = queue.Dequeue();
					foreach (global::System.Type item in type2.GetInterfaces())
					{
						if (!list.Contains(item))
						{
							list.Add(item);
							queue.Enqueue(item);
						}
					}
					global::System.Reflection.PropertyInfo[] properties = type2.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
					propInfo.InsertRange(0, from i in properties
					where !propInfo.Contains(i) && i.GetIndexParameters().Length == 0
					select i);
				}
			}
			else
			{
				global::System.Reflection.PropertyInfo[] properties2 = type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
				propInfo.AddRange(from i in properties2
				where i.GetIndexParameters().Length == 0
				select i);
			}
			return propInfo.ToArray();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000A11C File Offset: 0x0000831C
		internal static global::System.Reflection.PropertyInfo ResolveProperty(global::System.Type type, string propertyName)
		{
			bool isInterface = type.IsInterface;
			if (isInterface)
			{
				global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>();
				global::System.Collections.Generic.Queue<global::System.Type> queue = new global::System.Collections.Generic.Queue<global::System.Type>();
				list.Add(type);
				queue.Enqueue(type);
				while (queue.Count > 0)
				{
					global::System.Type type2 = queue.Dequeue();
					global::System.Reflection.PropertyInfo property = type2.GetProperty(propertyName, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
					if (property != null)
					{
						return property;
					}
					foreach (global::System.Type item in type2.GetInterfaces())
					{
						if (!list.Contains(item))
						{
							list.Add(item);
							queue.Enqueue(item);
						}
					}
				}
				return null;
			}
			return type.GetProperty(propertyName, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000A1C4 File Offset: 0x000083C4
		private static global::System.Type ResolveInterfaceForProperty(global::System.Type type, string propertyName)
		{
			bool isInterface = type.IsInterface;
			if (isInterface)
			{
				global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>();
				global::System.Collections.Generic.Queue<global::System.Type> queue = new global::System.Collections.Generic.Queue<global::System.Type>();
				list.Add(type);
				queue.Enqueue(type);
				while (queue.Count > 0)
				{
					global::System.Type type2 = queue.Dequeue();
					global::System.Reflection.PropertyInfo property = type2.GetProperty(propertyName, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
					if (property != null)
					{
						return type2;
					}
					foreach (global::System.Type item in type2.GetInterfaces())
					{
						if (!list.Contains(item))
						{
							list.Add(item);
							queue.Enqueue(item);
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000A25C File Offset: 0x0000845C
		private static global::System.Linq.Expressions.MemberExpression ResolvePropertyExpression(global::System.Linq.Expressions.Expression expression, string propertyName)
		{
			bool isInterface = expression.Type.IsInterface;
			if (isInterface)
			{
				global::System.Type type = global::Infragistics.DataManagerBase.ResolveInterfaceForProperty(expression.Type, propertyName);
				if (type != expression.Type)
				{
					return global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Convert(expression, type), propertyName);
				}
			}
			return global::System.Linq.Expressions.Expression.Property(expression, propertyName);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000A2A8 File Offset: 0x000084A8
		public static object GetDefaultValue(global::System.Type t)
		{
			if (t.IsValueType)
			{
				return global::System.Activator.CreateInstance(t);
			}
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000A2BA File Offset: 0x000084BA
		internal virtual global::System.Collections.IList FilterItems(global::System.Collections.IList items)
		{
			return null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000A2BD File Offset: 0x000084BD
		internal virtual global::System.Collections.IList FilterItems(global::System.Collections.IEnumerable items, global::Infragistics.RecordFilterCollection filtersToUse)
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000A2C0 File Offset: 0x000084C0
		internal virtual bool UpdateCachedDataManipulations(object item, bool isAdding)
		{
			return false;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000A2C3 File Offset: 0x000084C3
		internal virtual int? ResolveIndexForInsertOrDelete(object data, bool isAdding)
		{
			return new int?(this.ResolveIndexForRecord(data));
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000A2D1 File Offset: 0x000084D1
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000A2D9 File Offset: 0x000084D9
		internal bool UpdateDataSource
		{
			get
			{
				return this._updateDataSource;
			}
			set
			{
				this._updateDataSource = value;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000A2E4 File Offset: 0x000084E4
		public void DetachWeekReferences()
		{
			if (this._weakDataSourceCollectionChanged != null)
			{
				this._weakDataSourceCollectionChanged.Detach();
				this._weakDataSourceCollectionChanged = null;
			}
			if (this._weakBindingListChanged != null)
			{
				this._weakBindingListChanged.Detach();
				this._weakBindingListChanged = null;
			}
			if (this._weakCollectionViewCurrentChanged != null)
			{
				this._weakCollectionViewCurrentChanged.Detach();
				this._weakCollectionViewCurrentChanged = null;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000A340 File Offset: 0x00008540
		public object GenerateNewObject()
		{
			object obj = null;
			if (this.IEditableCollectionViewData != null && this.IEditableCollectionViewData.CanAddNew)
			{
				object item = null;
				if (this.ICollectionViewData != null)
				{
					item = this.ICollectionViewData.CurrentItem;
				}
				this._ignoreCurrentChanging = true;
				obj = this.IEditableCollectionViewData.AddNew();
				this.IEditableCollectionViewData.CancelNew();
				this._ignoreCurrentChanging = false;
				if (this.ICollectionViewData != null)
				{
					this.ICollectionViewData.MoveCurrentTo(item);
					if (this.ICollectionViewData.IsEmpty)
					{
						this.ICollectionViewData.Refresh();
					}
				}
				return obj;
			}
			obj = this.OnNewObjectGeneration();
			if (obj == null)
			{
				try
				{
					if (this.CachedType != null)
					{
						obj = global::System.Activator.CreateInstance(this.CachedType);
					}
				}
				catch (global::System.MissingMemberException innerException)
				{
					if (this.CachedType != null)
					{
						throw new global::Infragistics.RequireEmptyConstructorException(string.Format(global::SR.GetString("RequireEmptyConstructorExceptionWithType"), this.CachedType.FullName), innerException);
					}
					throw new global::Infragistics.RequireEmptyConstructorException(global::SR.GetString("RequireEmptyConstructorException"), innerException);
				}
				return obj;
			}
			if (this.CachedType.IsAssignableFrom(obj.GetType()))
			{
				return obj;
			}
			throw new global::Infragistics.DataObjectTypeMismatchException();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000A464 File Offset: 0x00008664
		public object GetRecord(int recordIndex)
		{
			global::System.Collections.IEnumerable dataSource = this.GetDataSource();
			if (dataSource == null)
			{
				return null;
			}
			this.UpdateDataSource = false;
			if (this.SortedFilteredDataSource != null)
			{
				this.UpdateDataSource = true;
				return this.SortedFilteredDataSource[recordIndex];
			}
			this.UpdateDataSource = true;
			if (this.IListData != null)
			{
				return this.IListData[recordIndex];
			}
			return this.ResolveRecord(recordIndex);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000A4C4 File Offset: 0x000086C4
		public int ResolveIndexForRecord(object data)
		{
			if (this._sortedFilterDataSource == null)
			{
				if (this.IListData != null)
				{
					return this.IListData.IndexOf(data);
				}
				int num = -1;
				using (global::System.Collections.IEnumerator enumerator = this.OriginalDataSource.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object objA = enumerator.Current;
						num++;
						if (object.Equals(objA, data))
						{
							return num;
						}
					}
					return -1;
				}
			}
			return this._sortedFilterDataSource.IndexOf(data);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000A554 File Offset: 0x00008754
		public void InsertRecord(int index, object value)
		{
			if (this.IListData != null)
			{
				this.IListData.Insert(index, value);
				this.ClearCachedDataSource(true);
				this.OnDataUpdated();
				return;
			}
			throw new global::Infragistics.DataSourceDoesNotSupportIListException();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000A580 File Offset: 0x00008780
		public void AddRecord(object value)
		{
			if (this.IEditableCollectionViewData != null && this.IEditableCollectionViewData.CanAddNew)
			{
				this._ignoreCurrentChanging = true;
				object newObj = this.IEditableCollectionViewData.AddNew();
				if (global::Infragistics.DataManagerBase.CopyValues(newObj, value))
				{
					this.IEditableCollectionViewData.CommitNew();
				}
				else
				{
					this.IEditableCollectionViewData.CancelNew();
				}
				this._ignoreCurrentChanging = false;
			}
			else
			{
				if (this.IListData == null)
				{
					throw new global::Infragistics.DataSourceDoesNotSupportIListException();
				}
				if (this.IBindingListData != null)
				{
					if (this.IBindingListData.AllowNew)
					{
						object obj = this.IBindingListData.AddNew();
						global::Infragistics.DataManagerBase.CopyValues(obj, value);
						global::System.ComponentModel.IEditableObject editableObject = obj as global::System.ComponentModel.IEditableObject;
						if (editableObject != null)
						{
							editableObject.EndEdit();
						}
						if (!this.IBindingListData.SupportsChangeNotification)
						{
							this.ClearCachedDataSource(true);
							global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, obj);
							this.OnCollectionChanged(e);
						}
					}
				}
				else
				{
					if (this.IListData.IsFixedSize)
					{
						throw new global::Infragistics.DataSourceDoesNotSupportIListException();
					}
					this.IListData.Add(value);
					this.ClearCachedDataSource(true);
				}
			}
			this.OnDataUpdated();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000A684 File Offset: 0x00008884
		public bool RemoveRecord(object value)
		{
			if (this.IEditableCollectionViewData != null)
			{
				if (this.IEditableCollectionViewData.CanRemove)
				{
					this.IEditableCollectionViewData.Remove(value);
				}
			}
			else
			{
				if (this.IListData == null)
				{
					throw new global::Infragistics.DataSourceDoesNotSupportIListException();
				}
				if (this.IBindingListData != null && !this.IBindingListData.AllowRemove)
				{
					return false;
				}
				this.IListData.Remove(value);
				this.ClearCachedDataSource(true);
			}
			this.OnDataUpdated();
			return true;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000A6F8 File Offset: 0x000088F8
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> GetDataProperties()
		{
			global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptorCollection = null;
			if (this.ITypedListData != null)
			{
				propertyDescriptorCollection = this.ITypedListData.GetItemProperties(null);
			}
			if (propertyDescriptorCollection != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.DataField> list = new global::System.Collections.Generic.List<global::Infragistics.DataField>();
				foreach (object obj in propertyDescriptorCollection)
				{
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
					list.Add(new global::Infragistics.DataField(propertyDescriptor.Name, propertyDescriptor.PropertyType)
					{
						DisplayName = propertyDescriptor.DisplayName
					});
				}
				return list;
			}
			return global::Infragistics.DataManagerBase.ResolvePropertiesForCachedType(this.CachedTypedInfo, this);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000A7A0 File Offset: 0x000089A0
		public virtual void Reset()
		{
			this.Sort.Clear();
			this.ClearCachedDataSource(true);
			this._cachedType = null;
			this._cachedCollectionType = null;
			this._cachedTypedInfo = null;
			if (this.SummaryResultCollection != null)
			{
				this.SummaryResultCollection.Clear();
			}
			this.DetachFilterEvents();
			this._currentFilter = null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000A7F4 File Offset: 0x000089F4
		public void UpdateData()
		{
			this.ClearCachedDataSource(false);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000A7FD File Offset: 0x000089FD
		public bool CancelEdit()
		{
			if (this.IEditableCollectionViewData != null && this.IEditableCollectionViewData.CanCancelEdit)
			{
				this.IEditableCollectionViewData.CancelEdit();
				return true;
			}
			return false;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000A822 File Offset: 0x00008A22
		public bool CommitEdit()
		{
			if (this.IEditableCollectionViewData != null)
			{
				this.IEditableCollectionViewData.CommitEdit();
				return true;
			}
			return false;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000A83A File Offset: 0x00008A3A
		public bool EditItem(object item)
		{
			if (this.IEditableCollectionViewData != null)
			{
				this.IEditableCollectionViewData.EditItem(item);
				return true;
			}
			return false;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000A853 File Offset: 0x00008A53
		public virtual void RefreshSummaries()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000A855 File Offset: 0x00008A55
		public void UpdateCurrentItem(object item)
		{
			if (this.ICollectionViewData != null)
			{
				this._ignoreCurrentChanging = true;
				this.ICollectionViewData.MoveCurrentTo(item);
				this._ignoreCurrentChanging = false;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000A87C File Offset: 0x00008A7C
		protected virtual global::Infragistics.DataField GenerateDataField(global::System.Reflection.PropertyInfo info)
		{
			return new global::Infragistics.DataField(info.Name, info.PropertyType)
			{
				AllowEdit = info.CanWrite
			};
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		protected virtual void SetDataSource(global::System.Collections.IEnumerable source)
		{
			if (source == this._dataSource)
			{
				return;
			}
			if (this._weakDataSourceCollectionChanged != null)
			{
				this._weakDataSourceCollectionChanged.Detach();
				this._weakDataSourceCollectionChanged = null;
			}
			if (this._weakBindingListChanged != null)
			{
				this._weakBindingListChanged.Detach();
				this._weakBindingListChanged = null;
			}
			if (this._weakCollectionViewCurrentChanged != null)
			{
				this._weakCollectionViewCurrentChanged.Detach();
				this._weakCollectionViewCurrentChanged = null;
			}
			global::System.Collections.IEnumerable dataSource = this._dataSource;
			this._dataSource = source;
			if (dataSource != null)
			{
				this.ClearCachedDataSource(true);
			}
			if (source == null)
			{
				this.Reset();
				return;
			}
			this.CachedType = this.DataType;
			this.CachedCollectionType = this.CollectionType;
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = this.OriginalDataSource as global::System.Collections.Specialized.INotifyCollectionChanged;
			if (notifyCollectionChanged != null)
			{
				this._weakDataSourceCollectionChanged = new global::Infragistics.WeakCollectionChangedHandler<global::Infragistics.DataManagerBase>(this, notifyCollectionChanged, delegate(global::Infragistics.DataManagerBase instance, object s, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
				{
					instance.DataSource_CollectionChanged(s, e);
				});
				notifyCollectionChanged.CollectionChanged += this._weakDataSourceCollectionChanged.OnEvent;
			}
			if (this.IBindingListData != null && this.IBindingListData.SupportsChangeNotification)
			{
				this._weakBindingListChanged = new global::Infragistics.WeakEventHandler<global::Infragistics.DataManagerBase, global::System.ComponentModel.IBindingList, global::System.ComponentModel.ListChangedEventArgs>(this, this.IBindingListData, delegate(global::Infragistics.DataManagerBase instance, object s, global::System.ComponentModel.ListChangedEventArgs e)
				{
					instance.IBindingListData_ListChanged(s, e);
				}, delegate(global::Infragistics.WeakEventHandler<global::Infragistics.DataManagerBase, global::System.ComponentModel.IBindingList, global::System.ComponentModel.ListChangedEventArgs> weakHandler, global::System.ComponentModel.IBindingList eventSource)
				{
					eventSource.ListChanged -= weakHandler.OnEvent;
				});
				this.IBindingListData.ListChanged += this._weakBindingListChanged.OnEvent;
			}
			if (this.ICollectionViewData != null)
			{
				this._weakCollectionViewCurrentChanged = new global::Infragistics.WeakEventHandler<global::Infragistics.DataManagerBase, global::System.ComponentModel.ICollectionView, global::System.EventArgs>(this, this.ICollectionViewData, delegate(global::Infragistics.DataManagerBase instance, object s, global::System.EventArgs e)
				{
					instance.ICollectionViewData_CurrentChanged(s, e);
				}, delegate(global::Infragistics.WeakEventHandler<global::Infragistics.DataManagerBase, global::System.ComponentModel.ICollectionView, global::System.EventArgs> weakHandler, global::System.ComponentModel.ICollectionView eventSource)
				{
					eventSource.CurrentChanged -= weakHandler.OnEvent;
				});
				this.ICollectionViewData.CurrentChanged += this._weakCollectionViewCurrentChanged.OnEvent;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000AACC File Offset: 0x00008CCC
		protected virtual global::System.Collections.IEnumerable GetDataSource()
		{
			return this._dataSource;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		protected virtual int ResolveCount()
		{
			int num = 0;
			global::System.Collections.IEnumerable dataSource = this.GetDataSource();
			foreach (object obj in dataSource)
			{
				num++;
			}
			return num;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000AB2C File Offset: 0x00008D2C
		protected virtual object ResolveRecord(int recordIndex)
		{
			int num = 0;
			global::System.Collections.IEnumerable dataSource = this.GetDataSource();
			foreach (object result in dataSource)
			{
				if (num == recordIndex)
				{
					return result;
				}
				num++;
			}
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000AB94 File Offset: 0x00008D94
		protected virtual void ResolveFilteredSortedPagedDataSource()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000AB96 File Offset: 0x00008D96
		protected virtual void ClearCachedDataSource(bool invalidateTotalRowCount)
		{
			this._recordCount = -1;
			this._sortedFilterDataSource = null;
			this.IsSortedFilteredDataSourceCalculated = false;
			if (invalidateTotalRowCount)
			{
				this._totalRecordCount = -1;
			}
			this.InvalidateSortedFilterdDataSource();
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		protected virtual void OnDataSourceCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			bool flag = true;
			bool flag2 = this.Summaries == null || !this.Summaries.Any<global::Infragistics.SummaryDefinition>();
			if (flag2 && this._sortedFilterDataSource != null)
			{
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
				{
					global::System.Collections.IList list = this.FilterItems(e.NewItems);
					if (list == null || list.Count == 0)
					{
						goto IL_1EF;
					}
					flag = false;
					using (global::System.Collections.IEnumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							int? num = this.ResolveIndexForInsertOrDelete(obj, true);
							if (num != null)
							{
								if (num < 0)
								{
									num = ~num;
								}
								if (this.IsSorted)
								{
									this._sortedFilterDataSource.Insert(num.Value, obj);
								}
								else
								{
									this._sortedFilterDataSource.Add(obj);
								}
								this.TotalRecordCount = -1;
								if (!this.UpdateCachedDataManipulations(obj, true))
								{
									this.SetSortedFilteredDataSource(this._sortedFilterDataSource);
								}
							}
							else
							{
								flag = true;
							}
						}
						goto IL_1EF;
					}
				}
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
				{
					foreach (object obj2 in e.OldItems)
					{
						int? num2 = this.ResolveIndexForInsertOrDelete(obj2, false);
						if (num2 != null)
						{
							if (num2 >= 0)
							{
								this._sortedFilterDataSource.RemoveAt(num2.Value);
								this.TotalRecordCount = -1;
								this.SetSortedFilteredDataSource(this._sortedFilterDataSource);
							}
							this.UpdateCachedDataManipulations(obj2, false);
							flag = false;
						}
						else
						{
							bool flag3 = this.UpdateCachedDataManipulations(obj2, false);
							flag = !flag3;
						}
					}
				}
			}
			IL_1EF:
			if (flag)
			{
				this.ClearCachedDataSource(true);
			}
			this.OnCollectionChanged(e);
			this.OnDataUpdated();
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000ADF0 File Offset: 0x00008FF0
		protected virtual void SetSortedFilteredDataSource(global::System.Collections.IList source)
		{
			this._sortedFilterDataSource = source;
			if (source != null)
			{
				this.RecordCount = source.Count;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000AE08 File Offset: 0x00009008
		private void DetachFilterEvents()
		{
			if (this._currentFilter != null)
			{
				this._currentFilter.CollectionChanged -= this.CurrentFilter_CollectionChanged;
				this._currentFilter.CollectionItemChanged -= this.CurrentFilter_CollectionItemChanged;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000AE40 File Offset: 0x00009040
		private void InvalidateSortedFilterdDataSource()
		{
			if (!this.SuspendInvalidateDataSource && !this.IsSortedFilteredDataSourceCalculated && this._dataSource != null)
			{
				this.ResolveFilteredSortedPagedDataSource();
				this.IsSortedFilteredDataSourceCalculated = true;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001CD RID: 461 RVA: 0x0000AE68 File Offset: 0x00009068
		// (remove) Token: 0x060001CE RID: 462 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x060001CF RID: 463 RVA: 0x0000AED5 File Offset: 0x000090D5
		protected virtual void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, e);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001D0 RID: 464 RVA: 0x0000AEEC File Offset: 0x000090EC
		// (remove) Token: 0x060001D1 RID: 465 RVA: 0x0000AF24 File Offset: 0x00009124
		public event global::System.EventHandler<global::Infragistics.DataAcquisitionEventArgs> ResolvingData;

		// Token: 0x060001D2 RID: 466 RVA: 0x0000AF59 File Offset: 0x00009159
		protected internal virtual void OnResolvingData(global::Infragistics.DataAcquisitionEventArgs args)
		{
			if (this.ResolvingData != null)
			{
				this.ResolvingData(this, args);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001D3 RID: 467 RVA: 0x0000AF70 File Offset: 0x00009170
		// (remove) Token: 0x060001D4 RID: 468 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public event global::System.EventHandler<global::Infragistics.HandleableObjectGenerationEventArgs> NewObjectGeneration;

		// Token: 0x060001D5 RID: 469 RVA: 0x0000AFE0 File Offset: 0x000091E0
		protected internal virtual object OnNewObjectGeneration()
		{
			global::Infragistics.HandleableObjectGenerationEventArgs handleableObjectGenerationEventArgs = new global::Infragistics.HandleableObjectGenerationEventArgs();
			handleableObjectGenerationEventArgs.CollectionType = this.CollectionType;
			handleableObjectGenerationEventArgs.ObjectType = this.CachedType;
			handleableObjectGenerationEventArgs.Handled = false;
			if (this.NewObjectGeneration != null)
			{
				this.NewObjectGeneration(this, handleableObjectGenerationEventArgs);
			}
			if (handleableObjectGenerationEventArgs.Handled)
			{
				return handleableObjectGenerationEventArgs.NewObject;
			}
			return null;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001D6 RID: 470 RVA: 0x0000B038 File Offset: 0x00009238
		// (remove) Token: 0x060001D7 RID: 471 RVA: 0x0000B070 File Offset: 0x00009270
		public event global::System.EventHandler<global::System.EventArgs> DataUpdated;

		// Token: 0x060001D8 RID: 472 RVA: 0x0000B0A5 File Offset: 0x000092A5
		protected virtual void OnDataUpdated()
		{
			if (this.DataUpdated != null)
			{
				this.DataUpdated(this, new global::System.EventArgs());
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001D9 RID: 473 RVA: 0x0000B0C0 File Offset: 0x000092C0
		// (remove) Token: 0x060001DA RID: 474 RVA: 0x0000B0F8 File Offset: 0x000092F8
		public event global::System.EventHandler<global::Infragistics.CurrentItemEventArgs> CurrentItemChanged;

		// Token: 0x060001DB RID: 475 RVA: 0x0000B130 File Offset: 0x00009330
		protected virtual void OnCurrentItemChanged(object item)
		{
			if (this.CurrentItemChanged != null)
			{
				this.CurrentItemChanged(this, new global::Infragistics.CurrentItemEventArgs
				{
					Item = item
				});
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000B15F File Offset: 0x0000935F
		private void DataSource_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnDataSourceCollectionChanged(e);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000B168 File Offset: 0x00009368
		private void CurrentFilter_CollectionItemChanged(object sender, global::System.EventArgs e)
		{
			this.ClearCachedDataSource(false);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000B171 File Offset: 0x00009371
		private void CurrentFilter_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.ClearCachedDataSource(false);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000B17A File Offset: 0x0000937A
		private void CurrentSummaries_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.ClearCachedDataSource(false);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000B183 File Offset: 0x00009383
		private void ICollectionViewData_CurrentChanged(object sender, global::System.EventArgs e)
		{
			if (!this._ignoreCurrentChanging)
			{
				this.OnCurrentItemChanged(this.ICollectionViewData.CurrentItem);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000B1A0 File Offset: 0x000093A0
		private void IBindingListData_ListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			if (e.ListChangedType == global::System.ComponentModel.ListChangedType.ItemAdded || e.ListChangedType == global::System.ComponentModel.ListChangedType.ItemDeleted || e.ListChangedType == global::System.ComponentModel.ListChangedType.ItemMoved || e.ListChangedType == global::System.ComponentModel.ListChangedType.Reset)
			{
				if (!this.SuspendInvalidateDataSource && !this.Defer)
				{
					this.ClearCachedDataSource(true);
				}
			}
			else if (e.ListChangedType == global::System.ComponentModel.ListChangedType.ItemChanged)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = e.PropertyDescriptor;
			}
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = null;
			if (e.ListChangedType == global::System.ComponentModel.ListChangedType.ItemAdded)
			{
				notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, new global::System.Collections.Generic.List<object>());
			}
			else if (e.ListChangedType == global::System.ComponentModel.ListChangedType.ItemDeleted)
			{
				notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, new global::System.Collections.Generic.List<object>());
			}
			else if (e.ListChangedType == global::System.ComponentModel.ListChangedType.Reset)
			{
				notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
			}
			else if (e.ListChangedType == global::System.ComponentModel.ListChangedType.ItemMoved)
			{
				notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, new global::System.Collections.Generic.List<object>());
			}
			if (notifyCollectionChangedEventArgs != null)
			{
				this.OnDataSourceCollectionChanged(notifyCollectionChangedEventArgs);
			}
		}

		// Token: 0x04000065 RID: 101
		private bool _enablePaging;

		// Token: 0x04000066 RID: 102
		private global::System.Collections.IEnumerable _dataSource;

		// Token: 0x04000067 RID: 103
		private global::System.Collections.IEnumerable _originalDataSource;

		// Token: 0x04000068 RID: 104
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.SortContext> _currentSort;

		// Token: 0x04000069 RID: 105
		private global::Infragistics.RecordFilterCollection _currentFilter;

		// Token: 0x0400006A RID: 106
		private int _pageSize = -1;

		// Token: 0x0400006B RID: 107
		private int _currentPage = 1;

		// Token: 0x0400006C RID: 108
		private int _recordCount = -1;

		// Token: 0x0400006D RID: 109
		private int _totalRecordCount = -1;

		// Token: 0x0400006E RID: 110
		private int _pageCount;

		// Token: 0x0400006F RID: 111
		private global::System.Collections.IList _sortedFilterDataSource;

		// Token: 0x04000070 RID: 112
		private global::Infragistics.SummaryExecution _summaryExecution;

		// Token: 0x04000071 RID: 113
		private global::System.Type _cachedType;

		// Token: 0x04000072 RID: 114
		private global::System.Type _cachedCollectionType;

		// Token: 0x04000073 RID: 115
		private global::Infragistics.IPagedCollectionView _pagedCollection;

		// Token: 0x04000074 RID: 116
		private global::System.ComponentModel.ICollectionView _collectionView;

		// Token: 0x04000075 RID: 117
		private global::System.Collections.IList _list;

		// Token: 0x04000076 RID: 118
		private global::System.ComponentModel.IEditableCollectionView _editableCollectionView;

		// Token: 0x04000077 RID: 119
		private global::Infragistics.IFilteredCollectionView _filteredCollectionView;

		// Token: 0x04000078 RID: 120
		private bool _suspendInvalidateDataSource;

		// Token: 0x04000079 RID: 121
		private global::Infragistics.SummaryDefinitionCollection _currentSummaries;

		// Token: 0x0400007A RID: 122
		private global::Infragistics.FormattingRuleCollection<global::Infragistics.IRule> _conditionalFormatRules;

		// Token: 0x0400007B RID: 123
		private bool _allowCollectionViewOverrides = true;

		// Token: 0x0400007C RID: 124
		private global::System.Collections.Generic.List<global::Infragistics.MergedDataContext> _mergeDataContexts;

		// Token: 0x0400007D RID: 125
		private bool _ignoreCurrentChanging;

		// Token: 0x0400007E RID: 126
		private global::Infragistics.WeakCollectionChangedHandler<global::Infragistics.DataManagerBase> _weakDataSourceCollectionChanged;

		// Token: 0x0400007F RID: 127
		private global::Infragistics.WeakEventHandler<global::Infragistics.DataManagerBase, global::System.ComponentModel.ICollectionView, global::System.EventArgs> _weakCollectionViewCurrentChanged;

		// Token: 0x04000080 RID: 128
		private bool _shouldUnwrapCollectionView;

		// Token: 0x04000081 RID: 129
		private bool _preferEnumerableItemType;

		// Token: 0x04000082 RID: 130
		private global::Infragistics.WeakEventHandler<global::Infragistics.DataManagerBase, global::System.ComponentModel.IBindingList, global::System.ComponentModel.ListChangedEventArgs> _weakBindingListChanged;

		// Token: 0x04000083 RID: 131
		private global::System.ComponentModel.IBindingList _bindingList;

		// Token: 0x04000084 RID: 132
		private global::System.ComponentModel.ITypedList _typedList;

		// Token: 0x04000085 RID: 133
		private global::System.ComponentModel.IBindingListView _bindingListView;

		// Token: 0x04000086 RID: 134
		private global::Infragistics.CachedTypedInfo _cachedTypedInfo;

		// Token: 0x04000087 RID: 135
		private bool _updateDataSource = true;

		// Token: 0x0200001D RID: 29
		private abstract class ExpressionTypeGenerationBase
		{
			// Token: 0x060001EA RID: 490
			protected abstract global::System.Linq.Expressions.Expression GenerateConstantExpression();

			// Token: 0x060001EB RID: 491 RVA: 0x0000B28C File Offset: 0x0000948C
			public static global::System.Linq.Expressions.Expression CreateGenericExpressionConstant(global::System.Type type)
			{
				global::System.Type type2 = typeof(global::Infragistics.DataManagerBase.ExpressionTypeGeneration<>).MakeGenericType(new global::System.Type[]
				{
					type
				});
				global::Infragistics.DataManagerBase.ExpressionTypeGenerationBase expressionTypeGenerationBase = (global::Infragistics.DataManagerBase.ExpressionTypeGenerationBase)global::System.Activator.CreateInstance(type2, new object[0]);
				return expressionTypeGenerationBase.GenerateConstantExpression();
			}
		}

		// Token: 0x0200001E RID: 30
		private class ExpressionTypeGeneration<T> : global::Infragistics.DataManagerBase.ExpressionTypeGenerationBase
		{
			// Token: 0x060001ED RID: 493 RVA: 0x0000B2D8 File Offset: 0x000094D8
			protected override global::System.Linq.Expressions.Expression GenerateConstantExpression()
			{
				return global::System.Linq.Expressions.Expression.Constant(default(T), typeof(T));
			}
		}
	}
}
