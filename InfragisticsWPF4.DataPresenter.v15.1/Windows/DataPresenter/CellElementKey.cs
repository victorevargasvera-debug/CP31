using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F3 RID: 755
	internal class CellElementKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.CellElementKey>
	{
		// Token: 0x06002303 RID: 8963 RVA: 0x000984F8 File Offset: 0x000966F8
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
			this._isTreeField = field.IsTreeField;
			this._isPlaceholderField = field.IsPlaceholderForTreeView;
			this._field = field;
			this._isPrinting = owner.DataPresenter.IsReportControl;
			if (this._isPrinting)
			{
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
			if (this._isTreeField)
			{
				this._hashCode += 153;
			}
			if (this._isPlaceholderField)
			{
				this._hashCode += 77;
			}
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x000986E4 File Offset: 0x000968E4
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.CellElementKey key = obj as global::Infragistics.Windows.DataPresenter.CellElementKey;
			return this.Equals(key);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x000986FF File Offset: 0x000968FF
		public override int GetHashCode()
		{
			if (this._isPrinting)
			{
				return this._field.GetHashCode();
			}
			return this._hashCode;
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0009871C File Offset: 0x0009691C
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
			return this._isVertical == key._isVertical && this._isExpandable == key._isExpandable && this._cellPresenterStyle == key._cellPresenterStyle && this._cellValuePresenterStyle == key._cellValuePresenterStyle && this._editorStyle == key._editorStyle && this._cellContentAlignment == key._cellContentAlignment && this._editAsType == key._editAsType && this._editorType == key._editorType && this._isTreeField == key._isTreeField && this._isPlaceholderField == key._isPlaceholderField && object.Equals(this._labelKey, key._labelKey) && this._field.IsFieldEquatable(key._field);
		}

		// Token: 0x0400116B RID: 4459
		private bool _isExpandable;

		// Token: 0x0400116C RID: 4460
		private bool _isVertical;

		// Token: 0x0400116D RID: 4461
		private global::System.Windows.Style _cellPresenterStyle;

		// Token: 0x0400116E RID: 4462
		private global::System.Windows.Style _cellValuePresenterStyle;

		// Token: 0x0400116F RID: 4463
		private global::System.Windows.Style _editorStyle;

		// Token: 0x04001170 RID: 4464
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment _cellContentAlignment;

		// Token: 0x04001171 RID: 4465
		private global::System.Type _editAsType;

		// Token: 0x04001172 RID: 4466
		private global::System.Type _editorType;

		// Token: 0x04001173 RID: 4467
		private bool _isPrinting;

		// Token: 0x04001174 RID: 4468
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001175 RID: 4469
		private bool _isTreeField;

		// Token: 0x04001176 RID: 4470
		private bool _isPlaceholderField;

		// Token: 0x04001177 RID: 4471
		private int _hashCode;

		// Token: 0x04001178 RID: 4472
		private global::Infragistics.Windows.DataPresenter.LabelElementKey _labelKey;
	}
}
