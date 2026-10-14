using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011D RID: 285
	internal class EditModeHelper
	{
		// Token: 0x060010FC RID: 4348 RVA: 0x0004B8DD File Offset: 0x00049ADD
		internal EditModeHelper(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner)
		{
			this._owner = owner;
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0004B8EC File Offset: 0x00049AEC
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				return this._cvp;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x0004B8F4 File Offset: 0x00049AF4
		internal global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo PreEditAutoSize
		{
			get
			{
				return this._autoSizeInfo;
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0004B8FC File Offset: 0x00049AFC
		internal void ClearCellValuePresenter()
		{
			this._cvp = null;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0004B908 File Offset: 0x00049B08
		internal global::Infragistics.Windows.DataPresenter.DataPresenterAction CreateCommitEditUndoAction(global::Infragistics.Windows.DataPresenter.DataPresenterAction editAction)
		{
			if (this._resizeUndoAction != null)
			{
				return new global::Infragistics.Windows.DataPresenter.DataPresenterCompositeAction(new global::Infragistics.Windows.DataPresenter.DataPresenterAction[]
				{
					editAction,
					this._resizeUndoAction
				});
			}
			return editAction;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0004B939 File Offset: 0x00049B39
		internal void EndEditMode(bool acceptChanges, bool force)
		{
			if (this._cvp != null)
			{
				this._cvp.EndEditMode(acceptChanges, force);
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0004B950 File Offset: 0x00049B50
		internal bool IsEditCell(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			return cvp == this._cvp;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0004B95B File Offset: 0x00049B5B
		internal void OnEditValueChanged(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			if (this._autoSizeInfo != null)
			{
				this.ProcessEditAutoSize(cvp);
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0004B96C File Offset: 0x00049B6C
		internal void OnEndEditMode(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp, bool changesAccepted)
		{
			if (cvp != this._cvp)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo autoSizeInfo = this._autoSizeInfo;
			this._autoSizeInfo = null;
			this._cvp = null;
			this._resizeUndoAction = null;
			if (!changesAccepted)
			{
				this.ProcessEditAutoSize(cvp, autoSizeInfo);
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0004B9AC File Offset: 0x00049BAC
		internal void OnEnterEditMode(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			if (this._cvp != null)
			{
				this.OnEndEditMode(this._cvp, true);
			}
			this._cvp = cvp;
			global::Infragistics.Windows.DataPresenter.Field field = cvp.Field;
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner.AutoSizeInfo.IsInAutoSizeMode(field, false))
			{
				this._autoSizeInfo = field.ExplicitResizeInfo.Clone();
				this._resizeUndoAction = global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction.Create(owner, !owner.IsHorizontal);
				return;
			}
			this._autoSizeInfo = null;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0004BA20 File Offset: 0x00049C20
		private void ProcessEditAutoSize(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			this.ProcessEditAutoSize(cvp, this._autoSizeInfo);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0004BA30 File Offset: 0x00049C30
		private void ProcessEditAutoSize(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo autoSizeInfo)
		{
			if (cvp != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field = cvp.Field;
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
				owner.AutoSizeInfo.OnEditCellValueChanged(cvp, autoSizeInfo);
			}
		}

		// Token: 0x040006DE RID: 1758
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _owner;

		// Token: 0x040006DF RID: 1759
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter _cvp;

		// Token: 0x040006E0 RID: 1760
		private global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo _autoSizeInfo;

		// Token: 0x040006E1 RID: 1761
		private global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction _resizeUndoAction;
	}
}
