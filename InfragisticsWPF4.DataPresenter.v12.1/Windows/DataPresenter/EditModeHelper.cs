using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000101 RID: 257
	internal class EditModeHelper
	{
		// Token: 0x06000D9B RID: 3483 RVA: 0x0003AE1D File Offset: 0x0003901D
		internal EditModeHelper(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner)
		{
			this._owner = owner;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0003AE2C File Offset: 0x0003902C
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				return this._cvp;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0003AE34 File Offset: 0x00039034
		internal global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo PreEditAutoSize
		{
			get
			{
				return this._autoSizeInfo;
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0003AE3C File Offset: 0x0003903C
		internal void ClearCellValuePresenter()
		{
			this._cvp = null;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0003AE48 File Offset: 0x00039048
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

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0003AE79 File Offset: 0x00039079
		internal void EndEditMode(bool acceptChanges, bool force)
		{
			if (this._cvp != null)
			{
				this._cvp.EndEditMode(acceptChanges, force);
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0003AE90 File Offset: 0x00039090
		internal bool IsEditCell(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			return cvp == this._cvp;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0003AE9B File Offset: 0x0003909B
		internal void OnEditValueChanged(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			if (this._autoSizeInfo != null)
			{
				this.ProcessEditAutoSize(cvp);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0003AEAC File Offset: 0x000390AC
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

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0003AEEC File Offset: 0x000390EC
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

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0003AF60 File Offset: 0x00039160
		private void ProcessEditAutoSize(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			this.ProcessEditAutoSize(cvp, this._autoSizeInfo);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0003AF70 File Offset: 0x00039170
		private void ProcessEditAutoSize(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo autoSizeInfo)
		{
			if (cvp != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field = cvp.Field;
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
				owner.AutoSizeInfo.OnEditCellValueChanged(cvp, autoSizeInfo);
			}
		}

		// Token: 0x0400053F RID: 1343
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _owner;

		// Token: 0x04000540 RID: 1344
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter _cvp;

		// Token: 0x04000541 RID: 1345
		private global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo _autoSizeInfo;

		// Token: 0x04000542 RID: 1346
		private global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction _resizeUndoAction;
	}
}
