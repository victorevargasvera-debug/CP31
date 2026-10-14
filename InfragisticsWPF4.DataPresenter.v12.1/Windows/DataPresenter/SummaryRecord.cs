using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CD RID: 461
	public class SummaryRecord : global::Infragistics.Windows.DataPresenter.Record
	{
		// Token: 0x06001B00 RID: 6912 RVA: 0x000740BC File Offset: 0x000722BC
		internal SummaryRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecords, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext summaryDisplayAreaContext) : base(fieldLayout, parentRecords)
		{
			this._summaryDisplayAreaContext = summaryDisplayAreaContext;
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x000740CD File Offset: 0x000722CD
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000740D0 File Offset: 0x000722D0
		internal override void CloneAssociatedRecordSettings(global::Infragistics.Windows.DataPresenter.Record associatedRecord, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			base.CloneAssociatedRecordSettings(associatedRecord, options);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x000740DA File Offset: 0x000722DA
		internal override global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter()
		{
			return new global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter();
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x000740E4 File Offset: 0x000722E4
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x00074118 File Offset: 0x00072318
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

		// Token: 0x06001B06 RID: 6918 RVA: 0x00074124 File Offset: 0x00072324
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = base.ParentCollection.ViewableRecords;
			if (viewableRecords != null)
			{
				return viewableRecords.GetAssociatedSummaryRecord(this);
			}
			return null;
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00074149 File Offset: 0x00072349
		internal override bool HasChildrenInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0007414C File Offset: 0x0007234C
		protected internal override bool IsActivatable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0007414F File Offset: 0x0007234F
		protected internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00074152 File Offset: 0x00072352
		public override bool IsSpecialRecord
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x00074155 File Offset: 0x00072355
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord;
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00074158 File Offset: 0x00072358
		internal override void SortChildren()
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0007415A File Offset: 0x0007235A
		public override string ToString()
		{
			return "SummaryRecord: " + this.Description;
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0007416C File Offset: 0x0007236C
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

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x000741BB File Offset: 0x000723BB
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResults
		{
			get
			{
				this.VerifySummaryResults();
				return this._cachedSummaryResults;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x000741C9 File Offset: 0x000723C9
		internal global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext SummaryDisplayAreaContext
		{
			get
			{
				return this._summaryDisplayAreaContext;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x000741D1 File Offset: 0x000723D1
		private object SummaryRecordHeaderMaskResolved
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryRecord.GetHeaderMaskResolved(base.ParentCollection);
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x000741E0 File Offset: 0x000723E0
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

		// Token: 0x06001B13 RID: 6931 RVA: 0x00074218 File Offset: 0x00072418
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

		// Token: 0x06001B14 RID: 6932 RVA: 0x00074280 File Offset: 0x00072480
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> GetFreeFormSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryPosition pos)
		{
			return new global::Infragistics.Windows.DataPresenter.SummaryPositionContext(pos, null).Filter(this.SummaryResults);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00074294 File Offset: 0x00072494
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
			if (parentCollection.IsRootLevel)
			{
				return "Grand Summaries";
			}
			if (flag)
			{
				return "Summaries for [GROUP_BY_VALUE]";
			}
			return "Summaries for [PRIMARY_FIELD]";
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0007430C File Offset: 0x0007250C
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

		// Token: 0x06001B17 RID: 6935 RVA: 0x00074368 File Offset: 0x00072568
		internal bool HasFixedSummaryResults(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(this.GetFixedSummaryResults(field, false));
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00074377 File Offset: 0x00072577
		private object ResolveSummaryRecordHeaderValue(object headerTemplate)
		{
			return global::Infragistics.Windows.DataPresenter.SummaryRecord.ResolveSummaryRecordHeaderValue(base.ParentCollection, base.FieldLayout, headerTemplate);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0007438C File Offset: 0x0007258C
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

		// Token: 0x06001B1A RID: 6938 RVA: 0x00074468 File Offset: 0x00072668
		private static string GetParentDataRecordFieldValueHelper(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, string fieldName, bool primaryField, bool scrolltipField)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = records.ParentDataRecord;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (parentDataRecord != null) ? parentDataRecord.FieldLayout : null;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field;
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
				if (field != null)
				{
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

		// Token: 0x06001B1B RID: 6939 RVA: 0x000744C4 File Offset: 0x000726C4
		private static string GetSummaryRecordHeaderTokenValue(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, string token)
		{
			if (token != null)
			{
				if (!(token == "PRIMARY_FIELD"))
				{
					if (!(token == "SCROLLTIP_FIELD"))
					{
						if (!(token == "GROUP_BY_VALUE") && !(token == "GROUP_BY_VALUES"))
						{
							if (token == "PARENT_FIELD_NAME")
							{
								global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = records.ParentRecordManager;
								global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = (parentRecordManager != null) ? parentRecordManager.ParentRecord : null;
								if (expandableFieldRecord == null)
								{
									goto IL_142;
								}
								string description = expandableFieldRecord.Description;
								if (description == null)
								{
									return string.Empty;
								}
								return description;
							}
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = records.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
							if (groupByRecord == null)
							{
								goto IL_142;
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
							goto IL_142;
						}
					}
					else
					{
						string parentDataRecordFieldValueHelper = global::Infragistics.Windows.DataPresenter.SummaryRecord.GetParentDataRecordFieldValueHelper(records, null, false, true);
						if (parentDataRecordFieldValueHelper != null)
						{
							return parentDataRecordFieldValueHelper;
						}
						goto IL_142;
					}
				}
				else
				{
					string parentDataRecordFieldValueHelper2 = global::Infragistics.Windows.DataPresenter.SummaryRecord.GetParentDataRecordFieldValueHelper(records, null, true, false);
					if (parentDataRecordFieldValueHelper2 != null)
					{
						return parentDataRecordFieldValueHelper2;
					}
					goto IL_142;
				}
			}
			string parentDataRecordFieldValueHelper3 = global::Infragistics.Windows.DataPresenter.SummaryRecord.GetParentDataRecordFieldValueHelper(records, token, false, false);
			if (parentDataRecordFieldValueHelper3 != null)
			{
				return parentDataRecordFieldValueHelper3;
			}
			IL_142:
			return null;
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00074614 File Offset: 0x00072814
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

		// Token: 0x04000B28 RID: 2856
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext _summaryDisplayAreaContext;

		// Token: 0x04000B29 RID: 2857
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> _cachedSummaryResults;

		// Token: 0x04000B2A RID: 2858
		private object _cachedSummaryRecordHeaderResolved;

		// Token: 0x04000B2B RID: 2859
		private int _verifiedCachedSummaryResultsVersion;
	}
}
