using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008C RID: 140
	internal class DataPresenterHistory
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x0001B9DD File Offset: 0x00019BDD
		internal DataPresenterHistory(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner)
		{
			this._owner = owner;
			this._undoManager = new global::Infragistics.Windows.UndoManager(owner.UndoLimit);
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0001B9FD File Offset: 0x00019BFD
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x0001BA0A File Offset: 0x00019C0A
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

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0001BA20 File Offset: 0x00019C20
		private global::Infragistics.Windows.UndoManager UndoManager
		{
			get
			{
				return this._undoManager;
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001BA28 File Offset: 0x00019C28
		internal void AddUndoActionInternal(global::Infragistics.Windows.DataPresenter.DataPresenterAction action)
		{
			if (this._beginCompositeActionCount > 0)
			{
				if (this._compositeActions == null)
				{
					this._compositeActions = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataPresenterAction>();
				}
				this._compositeActions.Add(action);
				return;
			}
			if (this._owner.IsUndoEnabled)
			{
				this.UndoManager.AddToUndo(action);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001BA77 File Offset: 0x00019C77
		internal void BeginCompositeAction()
		{
			this._beginCompositeActionCount++;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0001BA87 File Offset: 0x00019C87
		internal bool CanRedo()
		{
			return this.UndoManager.CanRedo();
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001BA94 File Offset: 0x00019C94
		internal bool CanUndo()
		{
			return this.UndoManager.CanUndo();
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001BAA1 File Offset: 0x00019CA1
		internal void Clear()
		{
			this.UndoManager.Clear();
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001BAF0 File Offset: 0x00019CF0
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

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001BB38 File Offset: 0x00019D38
		internal void EndCompositeAction()
		{
			if (this._beginCompositeActionCount > 0)
			{
				this._beginCompositeActionCount--;
				if (this._beginCompositeActionCount == 0 && this._compositeActions != null)
				{
					this._compositeActions.Reverse();
					this.AddUndoActionInternal(new global::Infragistics.Windows.DataPresenter.DataPresenterCompositeAction(this._compositeActions.ToArray())
					{
						_mirrorUndoOrder = true
					});
					this._compositeActions = null;
				}
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001BBE8 File Offset: 0x00019DE8
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

		// Token: 0x060006EA RID: 1770 RVA: 0x0001BC78 File Offset: 0x00019E78
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

		// Token: 0x060006EB RID: 1771 RVA: 0x0001BCFC File Offset: 0x00019EFC
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

		// Token: 0x060006EC RID: 1772 RVA: 0x0001BD40 File Offset: 0x00019F40
		internal bool PerformAction(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action, object context)
		{
			bool result = this.UndoManager.PerformAction(action, context);
			if (!this._owner.IsUndoEnabled)
			{
				this.Clear();
			}
			return result;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001BD70 File Offset: 0x00019F70
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

		// Token: 0x0400022B RID: 555
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _owner;

		// Token: 0x0400022C RID: 556
		private global::Infragistics.Windows.UndoManager _undoManager;

		// Token: 0x0400022D RID: 557
		private int _beginCompositeActionCount;

		// Token: 0x0400022E RID: 558
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataPresenterAction> _compositeActions;
	}
}
