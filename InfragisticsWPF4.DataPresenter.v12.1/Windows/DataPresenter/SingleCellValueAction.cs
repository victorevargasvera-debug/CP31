using System;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000066 RID: 102
	internal class SingleCellValueAction : global::Infragistics.Windows.DataPresenter.SingleCellAction
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x00014697 File Offset: 0x00012897
		internal SingleCellValueAction(object value, bool useConverter, global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, object preferredOriginalValue, bool isCommittingEdit) : base(record, field)
		{
			this._value = value;
			this._useConverter = useConverter;
			this._preferredOriginalValue = preferredOriginalValue;
			this._isCommittingEdit = isCommittingEdit;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x000146CB File Offset: 0x000128CB
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000146D4 File Offset: 0x000128D4
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = base.Record as global::Infragistics.Windows.DataPresenter.FilterRecord;
			if (filterRecord != null && filterRecord.FieldLayout == fieldLayout && filterRecord.Filters.GetRecordFilterScopeResolved(fieldLayout) == global::Infragistics.Windows.DataPresenter.RecordFilterScope.AllRecords)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00014714 File Offset: 0x00012914
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction = null;
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
			try
			{
				record.SuspendFiltering();
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				bool useConverter = false;
				object value = record.GetCellValue(field, useConverter);
				if (this._preferredOriginalValue != global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing)
				{
					value = this._preferredOriginalValue;
					record.CoerceNullEditValue(field, ref value);
					useConverter = true;
				}
				bool isAddRecordTemplate = record.IsAddRecordTemplate;
				if (!record.SetCellValue(field, this._value, this._useConverter, false))
				{
					return null;
				}
				if (!record.OnEditValueChanged(false))
				{
					return null;
				}
				bool flag = global::Infragistics.Windows.UndoManager.IsUndoRedoContext(context);
				if (!flag)
				{
					base.InitializeOriginalDataItem();
				}
				dataPresenterAction = (isAddRecordTemplate ? new global::Infragistics.Windows.DataPresenter.DeleteRecordsAction(dataPresenter, new global::Infragistics.Windows.DataPresenter.Record[]
				{
					record
				}, false) : new global::Infragistics.Windows.DataPresenter.SingleCellValueAction(value, useConverter, record, field, global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing, false));
				if (this._isCommittingEdit)
				{
					dataPresenterAction = base.DataPresenter.EditHelper.CreateCommitEditUndoAction(dataPresenterAction);
				}
				if (flag && dataPresenterAction != null && dataPresenter != null)
				{
					dataPresenter.SelectedItems.ClearAllSelected();
					dataPresenter.ActiveCell = record.Cells[field];
				}
			}
			finally
			{
				global::Infragistics.Windows.DataPresenter.SingleCellValueAction.ResumeRecordFiltering(record);
			}
			return dataPresenterAction;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00014850 File Offset: 0x00012A50
		public override string ToString()
		{
			return string.Format("SingleCellValue Field:'{0}' Record:'{1}'", base.Field, base.Record);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00014868 File Offset: 0x00012A68
		internal static void ResumeRecordFiltering(global::Infragistics.Windows.DataPresenter.Record record)
		{
			record.ResumeFiltering(!record.IsActive || record.InternalIsFilteredOut_NoVerify);
			record.SuspendActiveRecordFiltering();
		}

		// Token: 0x04000191 RID: 401
		private object _value;

		// Token: 0x04000192 RID: 402
		private bool _useConverter;

		// Token: 0x04000193 RID: 403
		private object _preferredOriginalValue = global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing;

		// Token: 0x04000194 RID: 404
		private bool _isCommittingEdit;
	}
}
