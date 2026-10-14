using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Infragistics.Shared;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000343 RID: 835
	public class GroupByRecord : global::Infragistics.Windows.DataPresenter.Record
	{
		// Token: 0x060027C1 RID: 10177 RVA: 0x000B1278 File Offset: 0x000AF478
		internal GroupByRecord(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, object commonValue) : base(field.Owner, parentCollection)
		{
			this._field = field;
			this._commonValue = commonValue;
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x000B1295 File Offset: 0x000AF495
		internal GroupByRecord(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : base(layout, parentCollection)
		{
			this._commonValue = layout;
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x000B12A6 File Offset: 0x000AF4A6
		internal override global::Infragistics.Windows.DataPresenter.Field AssociatedField
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000B12AE File Offset: 0x000AF4AE
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return this.ChildRecords;
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000B12B6 File Offset: 0x000AF4B6
		internal override global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter()
		{
			return new global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter();
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x000B12BD File Offset: 0x000AF4BD
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x000B12C5 File Offset: 0x000AF4C5
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

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000B12D4 File Offset: 0x000AF4D4
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

		// Token: 0x060027C9 RID: 10185 RVA: 0x000B131B File Offset: 0x000AF51B
		internal void DirtyDescriptionWithSummaries()
		{
			this._cachedDescriptionWithSummaries = null;
			base.RaisePropertyChangedEvent("DescriptionWithSummaries");
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x000B1330 File Offset: 0x000AF530
		internal override void EnsureFiltersEvaluated()
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = base.ParentCollection;
				if (parentCollection != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = parentCollection.ViewableRecords;
					if (viewableRecords != null && viewableRecords.EnsureFiltersEvaluated() && (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter & this._cachedFilterState) != 0)
					{
						this.ApplyFiltersHelper(true);
					}
				}
			}
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000B1374 File Offset: 0x000AF574
		internal void ApplyFiltersHelper(bool raiseNotifications)
		{
			global::Infragistics.Windows.DataPresenter.RecordCollection childRecords = this.ChildRecords;
			if (childRecords != null)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = childRecords.ViewableRecords;
				if (viewableRecords != null && viewableRecords.EnsureFiltersEvaluated())
				{
					global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = childRecords.ParentRecordManager;
					if (parentRecordManager != null && childRecords.SparseArray.Count == 0 && global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.UseCollectionView == parentRecordManager.GroupByEvaluationModeResolved && global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Auto == parentRecordManager.FilterEvaluationModeResolved)
					{
						base.LoadVirtualData();
					}
					bool allChildrenFilteredOut = 0 == viewableRecords.CountOfNonSpecialRecords;
					this.ApplyFiltersHelper(allChildrenFilteredOut, raiseNotifications);
				}
			}
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000B13E0 File Offset: 0x000AF5E0
		internal void ApplyFiltersHelper(bool allChildrenFilteredOut, bool raiseNotifications)
		{
			if (global::Infragistics.Windows.DataPresenter.RecordType.GroupByField == this.RecordType)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = base.FieldLayout;
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection resolvedRecordFilterCollection = (recordManager != null) ? recordManager.RecordFiltersResolved : null;
				bool flag = resolvedRecordFilterCollection != null && fieldLayout2 != null && resolvedRecordFilterCollection.HasActiveFilters(fieldLayout2);
				global::Infragistics.Windows.DataPresenter.FilterEvaluationMode filterEvaluationMode = (recordManager != null) ? recordManager.FilterEvaluationModeResolved : global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Auto;
				global::Infragistics.Windows.DataPresenter.Record.FilterState newState;
				if (!flag || global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Manual == filterEvaluationMode || global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.UseCollectionView == filterEvaluationMode)
				{
					newState = (global::Infragistics.Windows.DataPresenter.Record.FilterState)0;
				}
				else
				{
					newState = (allChildrenFilteredOut ? global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut : global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn);
				}
				base.InternalSetFilterState(newState, raiseNotifications);
			}
			this.OnGroupingChanged();
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x000B1460 File Offset: 0x000AF660
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			return base.ParentCollection.ParentRecordManager.GetAssociatedRecordInternal(this);
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000B1473 File Offset: 0x000AF673
		internal override bool HasChildrenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x000B1476 File Offset: 0x000AF676
		internal override bool IsStillValid
		{
			get
			{
				return this.AssociatedField != null && this.AssociatedField.IsGroupBy && base.IsStillValid;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x000B1495 File Offset: 0x000AF695
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

		// Token: 0x060027D1 RID: 10193 RVA: 0x000B14A2 File Offset: 0x000AF6A2
		internal override void SortChildren()
		{
			if (this._records == null)
			{
				return;
			}
			this._records.VerifySortOrder(true);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000B14BC File Offset: 0x000AF6BC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("GroupByRecord: ");
			stringBuilder.Append(this.Description);
			return stringBuilder.ToString();
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000B14EE File Offset: 0x000AF6EE
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

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x000B1511 File Offset: 0x000AF711
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

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x000B153E File Offset: 0x000AF73E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field GroupByField
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000B1546 File Offset: 0x000AF746
		public bool? IsFilteredOut
		{
			get
			{
				return base.InternalIsFilteredOutNullable_Verify;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x000B1550 File Offset: 0x000AF750
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

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x000B1579 File Offset: 0x000AF779
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x000B1581 File Offset: 0x000AF781
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

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x000B15A4 File Offset: 0x000AF7A4
		internal object CommonValueInternal
		{
			get
			{
				return this._commonValue;
			}
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000B15AC File Offset: 0x000AF7AC
		internal global::Infragistics.Windows.DataPresenter.SummaryRecord CreateSummaryRecord()
		{
			return new global::Infragistics.Windows.DataPresenter.SummaryRecord(base.FieldLayout, this.ChildRecords, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext.InGroupByRecordsSummariesContext);
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000B15C4 File Offset: 0x000AF7C4
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

		// Token: 0x060027DD RID: 10205 RVA: 0x000B165C File Offset: 0x000AF85C
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

		// Token: 0x060027DE RID: 10206 RVA: 0x000B1690 File Offset: 0x000AF890
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

		// Token: 0x060027DF RID: 10207 RVA: 0x000B16BC File Offset: 0x000AF8BC
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

		// Token: 0x060027E0 RID: 10208 RVA: 0x000B1700 File Offset: 0x000AF900
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
					obj = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("GroupByDescription_NullValue_Literal");
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
					@string = global::SR.GetString("GroupByDescription_Format_OneChild");
				}
				else
				{
					@string = global::SR.GetString("GroupByDescription_Format_NotOneChild");
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

		// Token: 0x060027E1 RID: 10209 RVA: 0x000B1874 File Offset: 0x000AFA74
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

		// Token: 0x060027E2 RID: 10210 RVA: 0x000B18C0 File Offset: 0x000AFAC0
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

		// Token: 0x060027E3 RID: 10211 RVA: 0x000B18F0 File Offset: 0x000AFAF0
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

		// Token: 0x060027E4 RID: 10212 RVA: 0x000B19F8 File Offset: 0x000AFBF8
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

		// Token: 0x060027E5 RID: 10213 RVA: 0x000B1A42 File Offset: 0x000AFC42
		internal bool HasSummaryResults()
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(this.GetSummaryResults());
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x000B1A4F File Offset: 0x000AFC4F
		internal void InitializeCommonValue(object commonValue)
		{
			this._commonValue = commonValue;
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000B1A58 File Offset: 0x000AFC58
		internal void OnGroupingChanged()
		{
			if (this._dynamicDesriptionString == null && base.HasListeners)
			{
				base.RaisePropertyChangedEvent("Description");
				this.DirtyDescriptionWithSummaries();
			}
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000B1A7C File Offset: 0x000AFC7C
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

		// Token: 0x0400139D RID: 5021
		private object _commonValue;

		// Token: 0x0400139E RID: 5022
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400139F RID: 5023
		private global::Infragistics.Windows.DataPresenter.RecordCollection _records;

		// Token: 0x040013A0 RID: 5024
		private global::Infragistics.Shared.DynamicResourceString _dynamicDesriptionString;

		// Token: 0x040013A1 RID: 5025
		private string _cachedDescriptionWithSummaries;
	}
}
