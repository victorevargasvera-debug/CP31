using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002B8 RID: 696
	internal class LabelElementKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.LabelElementKey>
	{
		// Token: 0x06001FD6 RID: 8150 RVA: 0x00088884 File Offset: 0x00086A84
		internal LabelElementKey(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			this._labelPresenterStyle = field.GetFieldSettingsStyleResolved(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelPresenterStyleProperty);
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

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00088951 File Offset: 0x00086B51
		public override int GetHashCode()
		{
			if (this._useFieldAsKey)
			{
				return this._field.GetHashCode();
			}
			return this._hashCode;
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x0008896D File Offset: 0x00086B6D
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.LabelElementKey && this.Equals((global::Infragistics.Windows.DataPresenter.LabelElementKey)obj);
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00088988 File Offset: 0x00086B88
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

		// Token: 0x04000FA0 RID: 4000
		private global::System.Windows.Style _labelPresenterStyle;

		// Token: 0x04000FA1 RID: 4001
		private bool _useFieldAsKey;

		// Token: 0x04000FA2 RID: 4002
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000FA3 RID: 4003
		private int _lineCount;

		// Token: 0x04000FA4 RID: 4004
		private int _hashCode;

		// Token: 0x04000FA5 RID: 4005
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment _cellContentAlignment;
	}
}
