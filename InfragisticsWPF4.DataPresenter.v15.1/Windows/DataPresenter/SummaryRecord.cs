using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001F4 RID: 500
	public class SummaryRecord : global::Infragistics.Windows.DataPresenter.Record
	{
		// Token: 0x06001F13 RID: 7955 RVA: 0x00087DF8 File Offset: 0x00085FF8
		internal SummaryRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecords, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext summaryDisplayAreaContext) : base(fieldLayout, parentRecords)
		{
			this._summaryDisplayAreaContext = summaryDisplayAreaContext;
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x00087E09 File Offset: 0x00086009
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00087E0C File Offset: 0x0008600C
		internal override void CloneAssociatedRecordSettings(global::Infragistics.Windows.DataPresenter.Record associatedRecord, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			base.CloneAssociatedRecordSettings(associatedRecord, options);
			if (options.ExcludeSummaries)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = associatedRecord as global::Infragistics.Windows.DataPresenter.SummaryRecord;
			if (summaryRecord == null)
			{
				return;
			}
			this.VerifySummaryResults();
			summaryRecord.VerifySummaryResults();
			if (this._cachedSummaryResults == null || summaryRecord._cachedSummaryResults == null)
			{
				return;
			}
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo, global::Infragistics.Windows.DataPresenter.SummaryResult> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo, global::Infragistics.Windows.DataPresenter.SummaryResult>();
			foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in summaryRecord._cachedSummaryResults)
			{
				global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo key = new global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo(summaryResult);
				dictionary[key] = summaryResult;
			}
			foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult2 in this._cachedSummaryResults)
			{
				global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo key2 = new global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo(summaryResult2);
				global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult3;
				if (dictionary.TryGetValue(key2, out summaryResult3))
				{
					summaryResult2.InternalSetNewValue(summaryResult3.Value);
				}
			}
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00087F04 File Offset: 0x00086104
		internal override global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter()
		{
			return new global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter();
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00087F0C File Offset: 0x0008610C
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x00087F40 File Offset: 0x00086140
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override string Description
		{
			get
			{
				string description = base.Description;
				if (!string.IsNullOrEmpty(description))
				{
					return description;
				}
				string text = this.SummaryRecordHeaderResolved as string;
				return text ?? string.Empty;
			}
			set
			{
				base.Description = value;
			}
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00087F4C File Offset: 0x0008614C
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = base.ParentCollection.ViewableRecords;
			if (viewableRecords != null)
			{
				return viewableRecords.GetAssociatedSummaryRecord(this);
			}
			return null;
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x00087F71 File Offset: 0x00086171
		internal override bool HasChildrenInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00087F74 File Offset: 0x00086174
		protected internal override bool IsActivatable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00087F77 File Offset: 0x00086177
		protected internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00087F7A File Offset: 0x0008617A
		public override bool IsSpecialRecord
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00087F7D File Offset: 0x0008617D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord;
			}
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00087F80 File Offset: 0x00086180
		internal override void SortChildren()
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00087F82 File Offset: 0x00086182
		public override string ToString()
		{
			return "SummaryRecord: " + this.Description;
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00087F94 File Offset: 0x00086194
		public object SummaryRecordHeaderResolved
		{
			get
			{
				if (this._cachedSummaryRecordHeaderResolved == null)
				{
					object summaryRecordHeaderMaskResolved = this.SummaryRecordHeaderMaskResolved;
					object obj = this.ResolveSummaryRecordHeaderValue(summaryRecordHeaderMaskResolved);
					bool flag = !object.Equals(obj, this._cachedSummaryRecordHeaderResolved);
					this._cachedSummaryRecordHeaderResolved = obj;
					if (flag)
					{
						base.RaisePropertyChangedEvent("SummaryRecordHeaderResolved");
					}
				}
				return this._cachedSummaryRecordHeaderResolved;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x00087FE3 File Offset: 0x000861E3
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResults
		{
			get
			{
				this.VerifySummaryResults();
				return this._cachedSummaryResults;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00087FF1 File Offset: 0x000861F1
		internal global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext SummaryDisplayAreaContext
		{
			get
			{
				return this._summaryDisplayAreaContext;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00087FF9 File Offset: 0x000861F9
		private object SummaryRecordHeaderMaskResolved
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryRecord.GetHeaderMaskResolved(base.ParentCollection);
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00088008 File Offset: 0x00086208
		internal global::System.Windows.Visibility SummaryRecordHeaderVisibilityResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				global::System.Windows.Visibility visibility = (fieldLayout != null) ? fieldLayout.SummaryDescriptionVisibilityResolved : global::System.Windows.Visibility.Collapsed;
				if (visibility == global::System.Windows.Visibility.Visible)
				{
					object summaryRecordHeaderResolved = this.SummaryRecordHeaderResolved;
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(summaryRecordHeaderResolved))
					{
						visibility = global::System.Windows.Visibility.Collapsed;
					}
				}
				return visibility;
			}
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00088040 File Offset: 0x00086240
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> GetFixedSummaryResults(global::Infragistics.Windows.DataPresenter.Field field, bool returnNotifyingCollection)
		{
			if (returnNotifyingCollection)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria filter = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaChain(this.SummaryDisplayAreaContext, new global::Infragistics.Windows.DataPresenter.SummaryPositionContext(global::Infragistics.Windows.DataPresenter.SummaryPosition.UseSummaryPositionField, field), false);
				global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCollectionEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> notifyCollectionEnumerable = new global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCollectionEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>(base.ParentCollection.SummaryResults, filter);
				notifyCollectionEnumerable.Tag = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "FieldLayout.SummaryDefinitions.SummariesVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(notifyCollectionEnumerable.RaiseCollectionChanged), true);
				return notifyCollectionEnumerable;
			}
			return new global::Infragistics.Windows.DataPresenter.SummaryPositionContext(global::Infragistics.Windows.DataPresenter.SummaryPosition.UseSummaryPositionField, field).Filter(this.SummaryResults);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000880A8 File Offset: 0x000862A8
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> GetFreeFormSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryPosition pos)
		{
			return new global::Infragistics.Windows.DataPresenter.SummaryPositionContext(pos, null).Filter(this.SummaryResults);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000880BC File Offset: 0x000862BC
		internal static object GetHeaderMaskResolved(global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultCollection summaryResults = parentCollection.SummaryResults;
			object obj = (summaryResults != null) ? summaryResults.SummaryRecordHeader : null;
			if (obj != null)
			{
				return obj;
			}
			bool flag = parentCollection.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = parentCollection.FieldLayout;
			if (fieldLayout != null)
			{
				obj = (flag ? fieldLayout.SummaryDescriptionMaskInGroupBy : fieldLayout.SummaryDescriptionMask);
				if (obj != null)
				{
					return obj;
				}
			}
			bool isTreeView = parentCollection.DataPresenter.IsTreeView;
			if (parentCollection.IsRootLevel)
			{
				if (isTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummaryHeaderMask_Root");
				}
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummaryHeaderMask_Grand");
			}
			else
			{
				if (flag)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummaryHeaderMask_GroupByValue");
				}
				if (isTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummaryHeaderMask_TreeField");
				}
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SummaryHeaderMask_PrimaryField");
			}
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00088170 File Offset: 0x00086370
		internal bool HasFixedSummaryResults()
		{
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = this.SummaryResults;
			if (summaryResults != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in summaryResults)
				{
					if (global::Infragistics.Windows.DataPresenter.SummaryPosition.UseSummaryPositionField == summaryResult.PositionResolved)
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000881CC File Offset: 0x000863CC
		internal bool HasFixedSummaryResults(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(this.GetFixedSummaryResults(field, false));
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000881DB File Offset: 0x000863DB
		private object ResolveSummaryRecordHeaderValue(object headerTemplate)
		{
			return global::Infragistics.Windows.DataPresenter.SummaryRecord.ResolveSummaryRecordHeaderValue(base.ParentCollection, base.FieldLayout, headerTemplate);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000881F0 File Offset: 0x000863F0
		internal static object ResolveSummaryRecordHeaderValue(global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, object headerTemplate)
		{
			string text = headerTemplate as string;
			if (!string.IsNullOrEmpty(text))
			{
				global::System.Text.StringBuilder stringBuilder = null;
				int i;
				int num2;
				for (i = 0; i < text.Length; i = 1 + num2)
				{
					string text2 = null;
					int num = text.IndexOf('[', i);
					num2 = -1;
					if (num >= 0)
					{
						num2 = text.IndexOf(']', 1 + num);
						if (num2 > 0)
						{
							string summaryRecordHeaderTokenValue = global::Infragistics.Windows.DataPresenter.SummaryRecord.GetSummaryRecordHeaderTokenValue(parentCollection, fieldLayout, text.Substring(1 + num, num2 - num - 1));
							text2 = ((summaryRecordHeaderTokenValue != null) ? summaryRecordHeaderTokenValue : string.Empty);
						}
					}
					if (text2 == null)
					{
						break;
					}
					if (stringBuilder == null)
					{
						stringBuilder = new global::System.Text.StringBuilder(text.Length + text2.Length);
					}
					stringBuilder.Append(text, i, num - i);
					stringBuilder.Append(text2);
				}
				if (stringBuilder != null)
				{
					if (i < text.Length)
					{
						stringBuilder.Append(text, i, text.Length - i);
					}
					return stringBuilder.ToString();
				}
			}
			return headerTemplate;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000882CC File Offset: 0x000864CC
		private static string GetParentDataRecordFieldValueHelper(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, string fieldName, bool primaryField, bool scrolltipField, bool treeField = false)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = records.ParentDataRecord;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (parentDataRecord != null) ? parentDataRecord.FieldLayout : null;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field = null;
				if (treeField)
				{
					primaryField = true;
					if (fieldLayout.IsTreeView)
					{
						field = fieldLayout.TreeField;
						if (field != null && !fieldLayout.IsDefault)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = fieldLayout.AlignmentFieldLayout;
							field = ((alignmentFieldLayout != null) ? field.GetMappedFieldInTree(alignmentFieldLayout) : null);
						}
					}
				}
				if (field == null)
				{
					if (primaryField)
					{
						field = fieldLayout.PrimaryField;
					}
					else if (scrolltipField)
					{
						field = fieldLayout.ScrollTipField;
					}
					else
					{
						field = global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(fieldLayout, fieldName, false);
					}
				}
				if (field != null)
				{
					if (fieldLayout.IsTreeView)
					{
						field = field.GetMappedFieldInTree(fieldLayout);
					}
					string cellText = parentDataRecord.GetCellText(field);
					if (cellText == null)
					{
						return string.Empty;
					}
					return cellText;
				}
			}
			return null;
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x0008837C File Offset: 0x0008657C
		private static string GetSummaryRecordHeaderTokenValue(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, string token)
		{
			switch (token)
			{
			case "TREE_FIELD":
			{
				string parentDataRecordFieldValueHelper = global::Infragistics.Windows.DataPresenter.SummaryRecord.GetParentDataRecordFieldValueHelper(records, null, false, false, true);
				if (parentDataRecordFieldValueHelper != null)
				{
					return parentDataRecordFieldValueHelper;
				}
				goto IL_1A3;
			}
			case "PRIMARY_FIELD":
			{
				string parentDataRecordFieldValueHelper2 = global::Infragistics.Windows.DataPresenter.SummaryRecord.GetParentDataRecordFieldValueHelper(records, null, true, false, false);
				if (parentDataRecordFieldValueHelper2 != null)
				{
					return parentDataRecordFieldValueHelper2;
				}
				goto IL_1A3;
			}
			case "SCROLLTIP_FIELD":
			{
				string parentDataRecordFieldValueHelper3 = global::Infragistics.Windows.DataPresenter.SummaryRecord.GetParentDataRecordFieldValueHelper(records, null, false, true, false);
				if (parentDataRecordFieldValueHelper3 != null)
				{
					return parentDataRecordFieldValueHelper3;
				}
				goto IL_1A3;
			}
			case "GROUP_BY_VALUE":
			case "GROUP_BY_VALUES":
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = records.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord == null)
				{
					goto IL_1A3;
				}
				bool flag = "GROUP_BY_VALUE" == token;
				global::System.Text.StringBuilder stringBuilder = null;
				while (groupByRecord != null)
				{
					object value = groupByRecord.Value;
					string text = (value != null) ? value.ToString() : string.Empty;
					if (flag)
					{
						return text;
					}
					if (stringBuilder == null)
					{
						stringBuilder = new global::System.Text.StringBuilder(text);
					}
					else
					{
						stringBuilder.Append(", ").Append(text);
					}
					groupByRecord = (groupByRecord.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord);
				}
				if (stringBuilder != null)
				{
					return stringBuilder.ToString();
				}
				goto IL_1A3;
			}
			case "PARENT_FIELD_NAME":
			{
				global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = records.ParentRecordManager;
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = (parentRecordManager != null) ? parentRecordManager.ParentRecord : null;
				if (expandableFieldRecord == null)
				{
					goto IL_1A3;
				}
				string description = expandableFieldRecord.Description;
				if (description == null)
				{
					return string.Empty;
				}
				return description;
			}
			}
			string parentDataRecordFieldValueHelper4 = global::Infragistics.Windows.DataPresenter.SummaryRecord.GetParentDataRecordFieldValueHelper(records, token, false, false, false);
			if (parentDataRecordFieldValueHelper4 != null)
			{
				return parentDataRecordFieldValueHelper4;
			}
			IL_1A3:
			return null;
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00088530 File Offset: 0x00086730
		internal void VerifySummaryResults()
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultCollection summaryResults = base.ParentCollection.SummaryResults;
			if (summaryResults != null && this._verifiedCachedSummaryResultsVersion != summaryResults.SummariesVersion)
			{
				this._verifiedCachedSummaryResultsVersion = summaryResults.SummariesVersion;
				this._cachedSummaryResults = summaryResults.GetSummaryResults(this._summaryDisplayAreaContext, null);
				base.RaisePropertyChangedEvent("SummaryResults");
			}
		}

		// Token: 0x04000D14 RID: 3348
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext _summaryDisplayAreaContext;

		// Token: 0x04000D15 RID: 3349
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> _cachedSummaryResults;

		// Token: 0x04000D16 RID: 3350
		private object _cachedSummaryRecordHeaderResolved;

		// Token: 0x04000D17 RID: 3351
		private int _verifiedCachedSummaryResultsVersion;

		// Token: 0x020001F5 RID: 501
		private class SummaryResultEqualityInfo
		{
			// Token: 0x06001F30 RID: 7984 RVA: 0x00088584 File Offset: 0x00086784
			public SummaryResultEqualityInfo(global::Infragistics.Windows.DataPresenter.SummaryResult result)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = result.SummaryDefinition;
				this._calculatorName = ((summaryDefinition.Calculator == null) ? null : summaryDefinition.Calculator.Name);
				this._formula = ((summaryDefinition.CalculationSettings == null) ? null : summaryDefinition.CalculationSettings.Formula);
				this._key = summaryDefinition.Key;
				this._sourceFieldName = summaryDefinition.SourceFieldName;
			}

			// Token: 0x06001F31 RID: 7985 RVA: 0x000885F0 File Offset: 0x000867F0
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo summaryResultEqualityInfo = obj as global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo;
				return summaryResultEqualityInfo != null && (this._calculatorName == summaryResultEqualityInfo._calculatorName && this._formula == summaryResultEqualityInfo._formula && this._key == summaryResultEqualityInfo._key) && this._sourceFieldName == summaryResultEqualityInfo._sourceFieldName;
			}

			// Token: 0x06001F32 RID: 7986 RVA: 0x00088655 File Offset: 0x00086855
			public override int GetHashCode()
			{
				return global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo.GetHashCode(this._calculatorName) ^ global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo.GetHashCode(this._formula) ^ global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo.GetHashCode(this._key) ^ global::Infragistics.Windows.DataPresenter.SummaryRecord.SummaryResultEqualityInfo.GetHashCode(this._sourceFieldName);
			}

			// Token: 0x06001F33 RID: 7987 RVA: 0x00088686 File Offset: 0x00086886
			public static int GetHashCode(string value)
			{
				if (value == null)
				{
					return 0;
				}
				return value.GetHashCode();
			}

			// Token: 0x04000D18 RID: 3352
			private readonly string _calculatorName;

			// Token: 0x04000D19 RID: 3353
			private readonly string _formula;

			// Token: 0x04000D1A RID: 3354
			private readonly string _key;

			// Token: 0x04000D1B RID: 3355
			private readonly string _sourceFieldName;
		}
	}
}
