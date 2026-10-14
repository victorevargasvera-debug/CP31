using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002B7 RID: 695
	internal class FilterCellElementKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.FilterCellElementKey>
	{
		// Token: 0x06001FD1 RID: 8145 RVA: 0x00088668 File Offset: 0x00086868
		internal FilterCellElementKey(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			bool flag = owner != null && owner.UseCellPresenters;
			this._cellValuePresenterStyle = field.GetFieldSettingsStyleResolved(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterCellValuePresenterStyleProperty);
			if (flag)
			{
				this._cellPresenterStyle = field.CellPresenterStyleResolved;
			}
			this._editorStyle = field.GetFieldSettingsStyleResolved(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterCellEditorStyleProperty);
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

		// Token: 0x06001FD2 RID: 8146 RVA: 0x0008878C File Offset: 0x0008698C
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellElementKey key = obj as global::Infragistics.Windows.DataPresenter.FilterCellElementKey;
			return this.Equals(key);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x000887A7 File Offset: 0x000869A7
		public override int GetHashCode()
		{
			if (this._isPrinting)
			{
				return this._field.GetHashCode();
			}
			return this._hashCode;
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x000887C3 File Offset: 0x000869C3
		public override string ToString()
		{
			return this._field.ToString();
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x000887D0 File Offset: 0x000869D0
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

		// Token: 0x04000F94 RID: 3988
		private global::System.Windows.Style _cellPresenterStyle;

		// Token: 0x04000F95 RID: 3989
		private global::System.Windows.Style _cellValuePresenterStyle;

		// Token: 0x04000F96 RID: 3990
		private global::System.Windows.Style _editorStyle;

		// Token: 0x04000F97 RID: 3991
		private global::System.Type _editAsType;

		// Token: 0x04000F98 RID: 3992
		private global::System.Type _editorType;

		// Token: 0x04000F99 RID: 3993
		private global::Infragistics.Windows.DataPresenter.FilterOperandUIType _operandUIType;

		// Token: 0x04000F9A RID: 3994
		private global::System.Windows.Visibility _clearButtonVisibility;

		// Token: 0x04000F9B RID: 3995
		private global::System.Windows.Visibility _filterOperatorVisibility;

		// Token: 0x04000F9C RID: 3996
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment _cellContentAlignment;

		// Token: 0x04000F9D RID: 3997
		private bool _isPrinting;

		// Token: 0x04000F9E RID: 3998
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000F9F RID: 3999
		private int _hashCode;
	}
}
