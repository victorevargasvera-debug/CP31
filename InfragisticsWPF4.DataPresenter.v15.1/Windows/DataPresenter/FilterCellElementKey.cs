using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F4 RID: 756
	internal class FilterCellElementKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.FilterCellElementKey>
	{
		// Token: 0x06002307 RID: 8967 RVA: 0x00098820 File Offset: 0x00096A20
		internal FilterCellElementKey(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			bool flag = owner != null && owner.UseCellPresenters;
			this._cellValuePresenterStyle = field.GetFieldSettingsStyleResolved((global::Infragistics.Windows.DataPresenter.FieldSettings fs) => fs.FilterCellValuePresenterStyle, null);
			if (flag)
			{
				this._cellPresenterStyle = field.CellPresenterStyleResolved;
			}
			this._editorStyle = field.GetFieldSettingsStyleResolved((global::Infragistics.Windows.DataPresenter.FieldSettings fs) => fs.FilterCellEditorStyle, null);
			this._clearButtonVisibility = field.FilterClearButtonVisibilityResolved;
			this._operandUIType = field.FilterOperandUITypeResolved;
			this._editorType = field.FilterEditorTypeResolved;
			this._editAsType = field.FilterEditAsTypeResolved;
			this._filterOperatorVisibility = field.FilterOperatorVisibilityResolved;
			this._cellContentAlignment = field.CellContentAlignmentResolved;
			this._isPrinting = owner.DataPresenter.IsReportControl;
			this._field = field;
			if (this._isPrinting)
			{
				return;
			}
			this._hashCode = this._operandUIType.GetHashCode();
			if (null != this._editorType)
			{
				this._hashCode += this._editorType.GetHashCode();
			}
			if (null != this._editAsType)
			{
				this._hashCode += this._editAsType.GetHashCode();
			}
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00098978 File Offset: 0x00096B78
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellElementKey key = obj as global::Infragistics.Windows.DataPresenter.FilterCellElementKey;
			return this.Equals(key);
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00098993 File Offset: 0x00096B93
		public override int GetHashCode()
		{
			if (this._isPrinting)
			{
				return this._field.GetHashCode();
			}
			return this._hashCode;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x000989AF File Offset: 0x00096BAF
		public override string ToString()
		{
			return this._field.ToString();
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x000989BC File Offset: 0x00096BBC
		public bool Equals(global::Infragistics.Windows.DataPresenter.FilterCellElementKey key)
		{
			if (key == null)
			{
				return false;
			}
			if (this._isPrinting)
			{
				return this._field == key._field;
			}
			return this._cellPresenterStyle == key._cellPresenterStyle && this._cellValuePresenterStyle == key._cellValuePresenterStyle && this._editorStyle == key._editorStyle && this._editAsType == key._editAsType && this._editorType == key._editorType && this._operandUIType == key._operandUIType && this._clearButtonVisibility == key._clearButtonVisibility && this._filterOperatorVisibility == key._filterOperatorVisibility && this._cellContentAlignment == key._cellContentAlignment;
		}

		// Token: 0x04001179 RID: 4473
		private global::System.Windows.Style _cellPresenterStyle;

		// Token: 0x0400117A RID: 4474
		private global::System.Windows.Style _cellValuePresenterStyle;

		// Token: 0x0400117B RID: 4475
		private global::System.Windows.Style _editorStyle;

		// Token: 0x0400117C RID: 4476
		private global::System.Type _editAsType;

		// Token: 0x0400117D RID: 4477
		private global::System.Type _editorType;

		// Token: 0x0400117E RID: 4478
		private global::Infragistics.Windows.DataPresenter.FilterOperandUIType _operandUIType;

		// Token: 0x0400117F RID: 4479
		private global::System.Windows.Visibility _clearButtonVisibility;

		// Token: 0x04001180 RID: 4480
		private global::System.Windows.Visibility _filterOperatorVisibility;

		// Token: 0x04001181 RID: 4481
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment _cellContentAlignment;

		// Token: 0x04001182 RID: 4482
		private bool _isPrinting;

		// Token: 0x04001183 RID: 4483
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001184 RID: 4484
		private int _hashCode;
	}
}
