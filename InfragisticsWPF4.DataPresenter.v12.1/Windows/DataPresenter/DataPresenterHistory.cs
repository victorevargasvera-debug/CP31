using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000087 RID: 135
	internal class DataPresenterHistory
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x0001941D File Offset: 0x0001761D
		internal DataPresenterHistory(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner)
		{
			this._owner = owner;
			this._undoManager = new global::Infragistics.Windows.UndoManager(owner.UndoLimit);
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001943D File Offset: 0x0001763D
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0001944A File Offset: 0x0001764A
		public int UndoLimit
		{
			get
			{
				return this._undoManager.UndoLimit;
			}
			set
			{
				if (this._undoManager != null)
				{
					this._undoManager.UndoLimit = value;
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00019460 File Offset: 0x00017660
		private global::Infragistics.Windows.UndoManager UndoManager
		{
			get
			{
				return this._undoManager;
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00019468 File Offset: 0x00017668
		internal void AddUndoActionInternal(global::Infragistics.Windows.DataPresenter.DataPresenterAction action)
		{
			if (this._owner.IsUndoEnabled)
			{
				this.UndoManager.AddToUndo(action);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00019483 File Offset: 0x00017683
		internal bool CanRedo()
		{
			return this.UndoManager.CanRedo();
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00019490 File Offset: 0x00017690
		internal bool CanUndo()
		{
			return this.UndoManager.CanUndo();
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001949D File Offset: 0x0001769D
		internal void Clear()
		{
			this.UndoManager.Clear();
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x000194EC File Offset: 0x000176EC
		internal global::Infragistics.Windows.DataPresenter.DescendantRecordInfo CreateUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DataRecord[] oldRecords)
		{
			global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo = new global::Infragistics.Windows.DataPresenter.DescendantRecordInfo(oldRecords);
			global::System.Action<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> action2 = delegate(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction = action as global::Infragistics.Windows.DataPresenter.DataPresenterAction;
				if (dataPresenterAction != null && dataPresenterAction.DataPresenter == this._owner)
				{
					dataPresenterAction.AddUndeleteDescendantInfo(descendantInfo);
				}
			};
			this.UndoManager.ForEach(action2);
			return descendantInfo;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001957C File Offset: 0x0001777C
		internal void FixGroupExpansionHistory(object context)
		{
			bool includeUndo = global::Infragistics.Windows.UndoManager.IsUndoContext(context);
			bool includeRedo = global::Infragistics.Windows.UndoManager.IsRedoContext(context);
			global::Infragistics.Windows.Helpers.HashSet fixedRecords = new global::Infragistics.Windows.Helpers.HashSet();
			global::System.Action<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> action2 = delegate(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction = action as global::Infragistics.Windows.DataPresenter.DataPresenterAction;
				if (dataPresenterAction != null && dataPresenterAction.DataPresenter == this._owner)
				{
					global::Infragistics.Windows.DataPresenter.RecordExpansionAction recordExpansionAction = dataPresenterAction as global::Infragistics.Windows.DataPresenter.RecordExpansionAction;
					if (recordExpansionAction != null)
					{
						recordExpansionAction.FixGroupByRecords(fixedRecords);
					}
				}
			};
			this.UndoManager.ForEach(action2, includeUndo, includeRedo);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001960C File Offset: 0x0001780C
		internal void FixHistoryAfterUndelete(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataItemToNewRecord)
		{
			global::System.Action<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> action2 = delegate(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction = action as global::Infragistics.Windows.DataPresenter.DataPresenterAction;
				if (dataPresenterAction != null && dataPresenterAction.DataPresenter == this._owner)
				{
					dataPresenterAction.OnRecordsUndeleted(oldDataItemToNewRecord);
				}
			};
			this.UndoManager.ForEach(action2);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00019690 File Offset: 0x00017890
		internal void OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizations)
		{
			global::Infragistics.Windows.UndoManager.ActionFilter filter = delegate(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction = action as global::Infragistics.Windows.DataPresenter.DataPresenterAction;
				if (dataPresenterAction != null && dataPresenterAction.DataPresenter == this._owner)
				{
					action = dataPresenterAction.OnCustomizationsChanged(fieldLayout, customizations);
				}
				return action;
			};
			this.UndoManager.Filter(filter);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000196D4 File Offset: 0x000178D4
		internal bool PerformAction(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action, object context)
		{
			bool result = this.UndoManager.PerformAction(action, context);
			if (!this._owner.IsUndoEnabled)
			{
				this.Clear();
			}
			return result;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00019704 File Offset: 0x00017904
		internal bool PerformUndoRedo(bool isUndo)
		{
			bool result = false;
			if (this._owner.IsUndoEnabled)
			{
				if (!this._owner.VerifyOperationIsAllowed(global::Infragistics.Windows.DataPresenter.UIOperation.Undo))
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this._owner.ActiveCell;
				if (activeCell != null && activeCell.IsInEditMode)
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(activeCell);
					if (cellValuePresenter != null && cellValuePresenter.IsInEditMode)
					{
						cellValuePresenter.EndEditMode(true, false);
						if (activeCell.IsInEditMode)
						{
							return true;
						}
					}
				}
				global::Infragistics.Windows.UndoManager undoManager = this.UndoManager;
				if (isUndo && undoManager.CanUndo())
				{
					result = undoManager.Undo();
				}
				else if (!isUndo && undoManager.CanRedo())
				{
					result = undoManager.Redo();
				}
			}
			return result;
		}

		// Token: 0x040001EF RID: 495
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _owner;

		// Token: 0x040001F0 RID: 496
		private global::Infragistics.Windows.UndoManager _undoManager;
	}
}
