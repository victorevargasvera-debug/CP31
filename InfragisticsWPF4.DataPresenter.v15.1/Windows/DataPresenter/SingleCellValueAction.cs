using System;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006B RID: 107
	internal class SingleCellValueAction : global::Infragistics.Windows.DataPresenter.SingleCellAction
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x00016A67 File Offset: 0x00014C67
		internal SingleCellValueAction(object value, bool useConverter, global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, object preferredOriginalValue, bool isCommittingEdit) : base(record, field)
		{
			this._value = value;
			this._useConverter = useConverter;
			this._preferredOriginalValue = preferredOriginalValue;
			this._isCommittingEdit = isCommittingEdit;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00016A9B File Offset: 0x00014C9B
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00016AA4 File Offset: 0x00014CA4
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = base.Record as global::Infragistics.Windows.DataPresenter.FilterRecord;
			if (filterRecord != null && filterRecord.FieldLayout == fieldLayout && filterRecord.Filters.GetRecordFilterScopeResolved(fieldLayout) == global::Infragistics.Windows.DataPresenter.RecordFilterScope.AllRecords)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00016AE4 File Offset: 0x00014CE4
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
				if (!record.OnEditValueChanged(false, false))
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

		// Token: 0x0600060B RID: 1547 RVA: 0x00016C20 File Offset: 0x00014E20
		public override string ToString()
		{
			return string.Format("SingleCellValue Field:'{0}' Record:'{1}'", base.Field, base.Record);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00016C38 File Offset: 0x00014E38
		internal static void ResumeRecordFiltering(global::Infragistics.Windows.DataPresenter.Record record)
		{
			record.ResumeFiltering(!record.IsActive || record.InternalIsFilteredOut_NoVerify);
			record.SuspendActiveRecordFiltering();
		}

		// Token: 0x040001C9 RID: 457
		private object _value;

		// Token: 0x040001CA RID: 458
		private bool _useConverter;

		// Token: 0x040001CB RID: 459
		private object _preferredOriginalValue = global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing;

		// Token: 0x040001CC RID: 460
		private bool _isCommittingEdit;
	}
}
