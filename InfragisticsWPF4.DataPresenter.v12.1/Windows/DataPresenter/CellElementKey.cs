using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002B6 RID: 694
	internal class CellElementKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.CellElementKey>
	{
		// Token: 0x06001FCD RID: 8141 RVA: 0x000883D8 File Offset: 0x000865D8
		internal CellElementKey(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			bool flag = owner != null && owner.UseCellPresenters;
			this._isVertical = (owner == null || !owner.IsHorizontal);
			this._isExpandable = field.IsExpandableResolved;
			if (flag)
			{
				this._cellPresenterStyle = field.CellPresenterStyleResolved;
			}
			this._cellValuePresenterStyle = field.CellValuePresenterStyleResolved;
			this._editorStyle = field.EditorStyleResolved;
			this._cellContentAlignment = field.CellContentAlignmentResolved;
			this._editAsType = field.EditAsTypeResolved;
			this._editorType = field.EditorTypeResolved;
			if (flag)
			{
				this._labelKey = field.LabelElementKey;
			}
			this._isPrinting = owner.DataPresenter.IsReportControl;
			if (this._isPrinting)
			{
				this._field = field;
				return;
			}
			if (this._isExpandable)
			{
				this._hashCode = 1;
			}
			if (this._cellPresenterStyle != null)
			{
				this._hashCode += this._cellPresenterStyle.GetHashCode() / 20;
			}
			if (this._cellValuePresenterStyle != null)
			{
				this._hashCode += this._cellValuePresenterStyle.GetHashCode() / 20;
			}
			if (this._editorStyle != null)
			{
				this._hashCode += this._editorStyle.GetHashCode() / 20;
			}
			this._hashCode = (int)(this._hashCode + this._cellContentAlignment);
			if (this._editAsType != null)
			{
				this._hashCode += this._editAsType.GetHashCode() / 20;
			}
			if (this._editorType != null)
			{
				this._hashCode += this._editorType.GetHashCode() / 20;
			}
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00088578 File Offset: 0x00086778
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.CellElementKey key = obj as global::Infragistics.Windows.DataPresenter.CellElementKey;
			return this.Equals(key);
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00088593 File Offset: 0x00086793
		public override int GetHashCode()
		{
			if (this._isPrinting)
			{
				return this._field.GetHashCode();
			}
			return this._hashCode;
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x000885B0 File Offset: 0x000867B0
		public bool Equals(global::Infragistics.Windows.DataPresenter.CellElementKey key)
		{
			if (key == null)
			{
				return false;
			}
			if (this._isPrinting)
			{
				return this._field == key._field;
			}
			return this._isVertical == key._isVertical && this._isExpandable == key._isExpandable && this._cellPresenterStyle == key._cellPresenterStyle && this._cellValuePresenterStyle == key._cellValuePresenterStyle && this._editorStyle == key._editorStyle && this._cellContentAlignment == key._cellContentAlignment && this._editAsType == key._editAsType && this._editorType == key._editorType && object.Equals(this._labelKey, key._labelKey);
		}

		// Token: 0x04000F88 RID: 3976
		private bool _isExpandable;

		// Token: 0x04000F89 RID: 3977
		private bool _isVertical;

		// Token: 0x04000F8A RID: 3978
		private global::System.Windows.Style _cellPresenterStyle;

		// Token: 0x04000F8B RID: 3979
		private global::System.Windows.Style _cellValuePresenterStyle;

		// Token: 0x04000F8C RID: 3980
		private global::System.Windows.Style _editorStyle;

		// Token: 0x04000F8D RID: 3981
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment _cellContentAlignment;

		// Token: 0x04000F8E RID: 3982
		private global::System.Type _editAsType;

		// Token: 0x04000F8F RID: 3983
		private global::System.Type _editorType;

		// Token: 0x04000F90 RID: 3984
		private bool _isPrinting;

		// Token: 0x04000F91 RID: 3985
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000F92 RID: 3986
		private int _hashCode;

		// Token: 0x04000F93 RID: 3987
		private global::Infragistics.Windows.DataPresenter.LabelElementKey _labelKey;
	}
}
