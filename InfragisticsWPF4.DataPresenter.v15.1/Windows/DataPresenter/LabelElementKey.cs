using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F5 RID: 757
	internal class LabelElementKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.LabelElementKey>
	{
		// Token: 0x0600230E RID: 8974 RVA: 0x00098A78 File Offset: 0x00096C78
		internal LabelElementKey(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			this._labelPresenterStyle = field.GetFieldSettingsStyleResolved((global::Infragistics.Windows.DataPresenter.FieldSettings fs) => fs.LabelPresenterStyle, null);
			this._lineCount = field.LabelLineCount;
			this._cellContentAlignment = field.CellContentAlignmentResolved;
			this._useFieldAsKey = owner.DataPresenter.IsReportControl;
			if (owner.UseCellPresenters && field.LabelTextWrappingResolved != global::System.Windows.TextWrapping.NoWrap)
			{
				this._useFieldAsKey = true;
			}
			if (this._useFieldAsKey)
			{
				this._field = field;
				return;
			}
			this._hashCode = this._lineCount.GetHashCode();
			this._hashCode += ((this._labelPresenterStyle != null) ? this._labelPresenterStyle.GetHashCode() : 0);
			this._hashCode += this._cellContentAlignment.GetHashCode();
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00098B5E File Offset: 0x00096D5E
		public override int GetHashCode()
		{
			if (this._useFieldAsKey)
			{
				return this._field.GetHashCode();
			}
			return this._hashCode;
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00098B7A File Offset: 0x00096D7A
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.LabelElementKey && this.Equals((global::Infragistics.Windows.DataPresenter.LabelElementKey)obj);
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00098B94 File Offset: 0x00096D94
		public bool Equals(global::Infragistics.Windows.DataPresenter.LabelElementKey other)
		{
			if (other == null)
			{
				return false;
			}
			if (this._useFieldAsKey)
			{
				return this._field == other._field;
			}
			return other != null && other._labelPresenterStyle == this._labelPresenterStyle && other._lineCount == this._lineCount && other._cellContentAlignment == this._cellContentAlignment;
		}

		// Token: 0x04001187 RID: 4487
		private global::System.Windows.Style _labelPresenterStyle;

		// Token: 0x04001188 RID: 4488
		private bool _useFieldAsKey;

		// Token: 0x04001189 RID: 4489
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400118A RID: 4490
		private int _lineCount;

		// Token: 0x0400118B RID: 4491
		private int _hashCode;

		// Token: 0x0400118C RID: 4492
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment _cellContentAlignment;
	}
}
