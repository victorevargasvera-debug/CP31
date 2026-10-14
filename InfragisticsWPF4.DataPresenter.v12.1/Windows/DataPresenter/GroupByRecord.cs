using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Infragistics.Shared;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000302 RID: 770
	public class GroupByRecord : global::Infragistics.Windows.DataPresenter.Record
	{
		// Token: 0x06002411 RID: 9233 RVA: 0x0009D554 File Offset: 0x0009B754
		internal GroupByRecord(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, object commonValue) : base(field.Owner, parentCollection)
		{
			this._field = field;
			this._commonValue = commonValue;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0009D571 File Offset: 0x0009B771
		internal GroupByRecord(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : base(layout, parentCollection)
		{
			this._commonValue = layout;
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x0009D582 File Offset: 0x0009B782
		internal override global::Infragistics.Windows.DataPresenter.Field AssociatedField
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x0009D58A File Offset: 0x0009B78A
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return this.ChildRecords;
			}
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0009D592 File Offset: 0x0009B792
		internal override global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter()
		{
			return new global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter();
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x0009D599 File Offset: 0x0009B799
		// (set) Token: 0x06002417 RID: 9239 RVA: 0x0009D5A1 File Offset: 0x0009B7A1
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override string Description
		{
			get
			{
				return this.GetDescriptionWithoutSummariesHelper();
			}
			set
			{
				base.Description = value;
				this.DirtyDescriptionWithSummaries();
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x0009D5B0 File Offset: 0x0009B7B0
		public string DescriptionWithSummaries
		{
			get
			{
				string descriptionWithSummaries = this.GetDescriptionWithSummaries();
				if (descriptionWithSummaries != this._cachedDescriptionWithSummaries)
				{
					bool flag = null == this._cachedDescriptionWithSummaries;
					this._cachedDescriptionWithSummaries = descriptionWithSummaries;
					if (!flag)
					{
						base.RaisePropertyChangedEvent("DescriptionWithSummaries");
					}
				}
				return this._cachedDescriptionWithSummaries;
			}
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x0009D5F7 File Offset: 0x0009B7F7
		internal void DirtyDescriptionWithSummaries()
		{
			this._cachedDescriptionWithSummaries = null;
			base.RaisePropertyChangedEvent("DescriptionWithSummaries");
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0009D60C File Offset: 0x0009B80C
		internal override void EnsureFiltersEvaluated()
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = base.ParentCollection;
				if (parentCollection != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = parentCollection.ViewableRecords;
					if (viewableRecords != null && viewableRecords.EnsureFiltersEvaluated() && (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter & this._cachedFilterState) != 0)
					{
						this.ApplyFiltersHelper(true);
					}
				}
			}
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0009D650 File Offset: 0x0009B850
		internal void ApplyFiltersHelper(bool raiseNotifications)
		{
			global::Infragistics.Windows.DataPresenter.RecordCollection childRecords = this.ChildRecords;
			if (childRecords != null)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = childRecords.ViewableRecords;
				if (viewableRecords != null && viewableRecords.EnsureFiltersEvaluated())
				{
					bool allChildrenFilteredOut = 0 == viewableRecords.CountOfNonSpecialRecords;
					this.ApplyFiltersHelper(allChildrenFilteredOut, raiseNotifications);
				}
			}
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0009D68C File Offset: 0x0009B88C
		internal void ApplyFiltersHelper(bool allChildrenFilteredOut, bool raiseNotifications)
		{
			if (global::Infragistics.Windows.DataPresenter.RecordType.GroupByField == this.RecordType)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = base.FieldLayout;
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection resolvedRecordFilterCollection = (recordManager != null) ? recordManager.RecordFiltersResolved : null;
				global::Infragistics.Windows.DataPresenter.Record.FilterState newState;
				if (resolvedRecordFilterCollection == null || fieldLayout2 == null || !resolvedRecordFilterCollection.HasActiveFilters(fieldLayout2))
				{
					newState = ~(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn | global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter | global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended);
				}
				else
				{
					newState = (allChildrenFilteredOut ? global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut : global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn);
				}
				base.InternalSetFilterState(newState, raiseNotifications);
			}
			this.OnGroupingChanged();
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0009D6F4 File Offset: 0x0009B8F4
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			return base.ParentCollection.ParentRecordManager.GetAssociatedRecordInternal(this);
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x0009D707 File Offset: 0x0009B907
		internal override bool HasChildrenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x0009D70A File Offset: 0x0009B90A
		internal override bool IsStillValid
		{
			get
			{
				return this.AssociatedField != null && this.AssociatedField.IsGroupBy && base.IsStillValid;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x0009D729 File Offset: 0x0009B929
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				if (this._field == null)
				{
					return global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout;
				}
				return global::Infragistics.Windows.DataPresenter.RecordType.GroupByField;
			}
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0009D736 File Offset: 0x0009B936
		internal override void SortChildren()
		{
			if (this._records == null)
			{
				return;
			}
			this._records.VerifySortOrder(true);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0009D750 File Offset: 0x0009B950
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("GroupByRecord: ");
			stringBuilder.Append(this.Description);
			return stringBuilder.ToString();
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0009D782 File Offset: 0x0009B982
		internal override void VerifySortOrderOfChildren()
		{
			if (this._field == null && this.RecordType != global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
			{
				return;
			}
			if (!this.HasChildrenInternal)
			{
				return;
			}
			this.SortChildren();
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x0009D7A5 File Offset: 0x0009B9A5
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.RecordCollection ChildRecords
		{
			get
			{
				if (this._records == null)
				{
					this._records = new global::Infragistics.Windows.DataPresenter.RecordCollection(this, base.ParentCollection.ParentRecordManager, base.FieldLayout);
				}
				return this._records;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x0009D7D2 File Offset: 0x0009B9D2
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field GroupByField
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x0009D7DA File Offset: 0x0009B9DA
		public bool? IsFilteredOut
		{
			get
			{
				return base.InternalIsFilteredOutNullable_Verify;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x0009D7E4 File Offset: 0x0009B9E4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object Value
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GroupInfo groupInfo = this._commonValue as global::Infragistics.Windows.DataPresenter.GroupInfo;
				if (groupInfo == null)
				{
					return this._commonValue;
				}
				return groupInfo.Value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x0009D80D File Offset: 0x0009BA0D
		// (set) Token: 0x06002429 RID: 9257 RVA: 0x0009D815 File Offset: 0x0009BA15
		internal global::Infragistics.Shared.DynamicResourceString DynamicDesriptionString
		{
			get
			{
				return this._dynamicDesriptionString;
			}
			set
			{
				if (value != this._dynamicDesriptionString)
				{
					this._dynamicDesriptionString = value;
					base.RaisePropertyChangedEvent("Description");
					this.DirtyDescriptionWithSummaries();
				}
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600242A RID: 9258 RVA: 0x0009D838 File Offset: 0x0009BA38
		internal object CommonValueInternal
		{
			get
			{
				return this._commonValue;
			}
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0009D840 File Offset: 0x0009BA40
		internal global::Infragistics.Windows.DataPresenter.SummaryRecord CreateSummaryRecord()
		{
			return new global::Infragistics.Windows.DataPresenter.SummaryRecord(base.FieldLayout, this.ChildRecords, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext.InGroupByRecordsSummariesContext);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0009D858 File Offset: 0x0009BA58
		private bool DoesRecordMatchGroupHelper(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.IGroupByEvaluator evaluator)
		{
			if (base.FieldLayout != record.FieldLayout)
			{
				return false;
			}
			if (this.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Field field = this._field;
			if (evaluator != null)
			{
				return evaluator.DoesGroupContainRecord(this, record);
			}
			global::System.Collections.IComparer sortComparerResolved = field.SortComparerResolved;
			if (sortComparerResolved != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this.FindFirstDataRecord();
				if (dataRecord != null)
				{
					return sortComparerResolved.Compare(dataRecord.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType), record.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType)) == 0;
				}
			}
			object value = this.Value;
			object cellValue = record.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
			if (value == null)
			{
				return cellValue == null;
			}
			return cellValue != null && global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer.DefaultCompare(value, cellValue, false, field) == 0;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0009D8F0 File Offset: 0x0009BAF0
		internal bool DoesRecordMatchGroup(global::Infragistics.Windows.DataPresenter.DataRecord record, bool recursive, global::Infragistics.Windows.DataPresenter.IGroupByEvaluator evaluator)
		{
			if (!this.DoesRecordMatchGroupHelper(record, evaluator))
			{
				return false;
			}
			if (recursive)
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = base.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord != null)
				{
					return groupByRecord.DoesRecordMatchGroup(record);
				}
			}
			return true;
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0009D924 File Offset: 0x0009BB24
		internal bool DoesRecordMatchGroup(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			global::Infragistics.Windows.DataPresenter.Field field = this._field;
			global::Infragistics.Windows.DataPresenter.IGroupByEvaluator evaluator;
			if (field != null)
			{
				evaluator = field.GroupByEvaluatorResolved;
			}
			else
			{
				evaluator = null;
			}
			return this.DoesRecordMatchGroup(record, true, evaluator);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0009D950 File Offset: 0x0009BB50
		internal global::Infragistics.Windows.DataPresenter.DataRecord FindFirstDataRecord()
		{
			if (this.ChildRecords.Count < 1)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record record = this.ChildRecords[0];
			if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
			{
				return ((global::Infragistics.Windows.DataPresenter.GroupByRecord)record).FindFirstDataRecord();
			}
			return record as global::Infragistics.Windows.DataPresenter.DataRecord;
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0009D994 File Offset: 0x0009BB94
		private string GetDescriptionWithoutSummariesHelper()
		{
			string description = base.Description;
			if (description != null && description.Length > 0)
			{
				return description;
			}
			if (this._dynamicDesriptionString != null)
			{
				return this._dynamicDesriptionString.Value;
			}
			global::System.Globalization.CultureInfo defaultConverterCulture = base.DataPresenter.DefaultConverterCulture;
			object obj = null;
			global::Infragistics.Windows.DataPresenter.GroupInfo groupInfo = this._commonValue as global::Infragistics.Windows.DataPresenter.GroupInfo;
			switch (this.RecordType)
			{
			case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
			{
				object obj2 = this._commonValue;
				if (groupInfo != null)
				{
					if (!string.IsNullOrEmpty(groupInfo.Description))
					{
						return groupInfo.Description;
					}
					obj2 = groupInfo.Value;
				}
				obj = ((this._field != null) ? global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.ConvertCellValue(obj2, this._field) : obj2);
				if (obj2 == null && string.IsNullOrEmpty(obj as string))
				{
					obj = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(defaultConverterCulture, "GroupByDescription_NullValue_Literal");
				}
				break;
			}
			case global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout:
				obj = base.FieldLayout.Description;
				break;
			}
			if (obj != null)
			{
				int num;
				if (groupInfo != null)
				{
					num = groupInfo.ChildCount;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ChildRecords.ViewableRecords;
					num = ((viewableRecords != null) ? viewableRecords.CountOfNonSpecialRecords : this.ChildRecords.Count);
				}
				string @string;
				if (num == 1)
				{
					@string = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(defaultConverterCulture, "GroupByDescription_Format_OneChild");
				}
				else
				{
					@string = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(defaultConverterCulture, "GroupByDescription_Format_NotOneChild");
				}
				try
				{
					return string.Format(defaultConverterCulture, @string, new object[]
					{
						obj,
						num
					});
				}
				catch (global::System.FormatException)
				{
					return @string;
				}
			}
			return string.Empty;
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x0009DB0C File Offset: 0x0009BD0C
		internal string GetDescriptionWithSummaries()
		{
			string text = this.Description;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
			if (fieldLayout != null && global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.Text == fieldLayout.GroupBySummaryDisplayModeResolved)
			{
				string summariesText = this.GetSummariesText(", ");
				if (!string.IsNullOrEmpty(summariesText))
				{
					text = text + " " + summariesText;
				}
			}
			return text;
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0009DB58 File Offset: 0x0009BD58
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> GetSummaryResults()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollection childRecords = this.ChildRecords;
			if (childRecords != null)
			{
				global::Infragistics.Windows.DataPresenter.SummaryResultCollection summaryResults = childRecords.SummaryResults;
				if (summaryResults != null)
				{
					return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext.InGroupByRecordsSummariesContext.Filter(summaryResults);
				}
			}
			return null;
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0009DB88 File Offset: 0x0009BD88
		internal string GetSummariesText(string separator)
		{
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = this.GetSummaryResults();
			if (summaryResults != null)
			{
				global::System.Text.StringBuilder stringBuilder = null;
				foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in summaryResults)
				{
					string displayText = summaryResult.DisplayText;
					global::Infragistics.Windows.DataPresenter.Field sourceField = summaryResult.SourceField;
					string value = separator;
					if (stringBuilder == null)
					{
						stringBuilder = new global::System.Text.StringBuilder();
						value = string.Empty;
					}
					if (sourceField != null && !string.IsNullOrEmpty(displayText))
					{
						stringBuilder.Append(value);
						string value2 = global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(sourceField.Label, sourceField.Name);
						stringBuilder.Append(value2).Append(" ").Append(displayText);
					}
					else if (displayText != null)
					{
						stringBuilder.Append(value).Append(displayText);
					}
				}
				if (stringBuilder != null)
				{
					stringBuilder.Replace("\r\n", " ");
					stringBuilder.Replace('\n', ' ');
					stringBuilder.Replace('\r', ' ');
					return stringBuilder.ToString();
				}
			}
			return null;
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x0009DC90 File Offset: 0x0009BE90
		internal global::Infragistics.Windows.DataPresenter.DataRecord GetFirstDescendantDataRecord()
		{
			if (this.ChildRecords.Count == 0)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record record = this.ChildRecords[0];
			if (record is global::Infragistics.Windows.DataPresenter.DataRecord)
			{
				return (global::Infragistics.Windows.DataPresenter.DataRecord)record;
			}
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			if (groupByRecord != null)
			{
				return groupByRecord.GetFirstDescendantDataRecord();
			}
			return null;
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0009DCDA File Offset: 0x0009BEDA
		internal bool HasSummaryResults()
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(this.GetSummaryResults());
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0009DCE7 File Offset: 0x0009BEE7
		internal void InitializeCommonValue(object commonValue)
		{
			this._commonValue = commonValue;
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0009DCF0 File Offset: 0x0009BEF0
		internal void OnGroupingChanged()
		{
			if (this._dynamicDesriptionString == null && base.HasListeners)
			{
				base.RaisePropertyChangedEvent("Description");
				this.DirtyDescriptionWithSummaries();
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0009DD14 File Offset: 0x0009BF14
		internal static bool ShouldDisplaySummaries(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (groupByRecord != null) ? groupByRecord.FieldLayout : null;
			global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode groupBySummaryDisplayMode = (fieldLayout != null) ? fieldLayout.GroupBySummaryDisplayModeResolved : global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.Default;
			bool flag = global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.SummaryCellsAlwaysBelowDescription == groupBySummaryDisplayMode;
			if (flag)
			{
				flag = (groupByRecord != null && groupByRecord.HasSummaryResults());
			}
			return flag;
		}

		// Token: 0x0400117D RID: 4477
		private object _commonValue;

		// Token: 0x0400117E RID: 4478
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400117F RID: 4479
		private global::Infragistics.Windows.DataPresenter.RecordCollection _records;

		// Token: 0x04001180 RID: 4480
		private global::Infragistics.Shared.DynamicResourceString _dynamicDesriptionString;

		// Token: 0x04001181 RID: 4481
		private string _cachedDescriptionWithSummaries;
	}
}
