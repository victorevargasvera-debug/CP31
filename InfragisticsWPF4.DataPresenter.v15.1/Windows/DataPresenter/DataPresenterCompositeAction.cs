using System;
using System.Collections.Generic;
using System.Text;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000070 RID: 112
	internal class DataPresenterCompositeAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x00018308 File Offset: 0x00016508
		internal DataPresenterCompositeAction(params global::Infragistics.Windows.DataPresenter.DataPresenterAction[] actions) : base(actions[0].DataPresenter)
		{
			this._actions = actions;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00018320 File Offset: 0x00016520
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			foreach (global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction in this._actions)
			{
				dataPresenterAction.AddUndeleteDescendantInfo(descendantInfo);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00018350 File Offset: 0x00016550
		protected internal override bool CanPerform(object context)
		{
			foreach (global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction in this._actions)
			{
				if (dataPresenterAction.CanPerformInternal(context))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00018388 File Offset: 0x00016588
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataPresenterAction> list = null;
			for (int i = 0; i < this._actions.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction = this._actions[i];
				global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction2 = dataPresenterAction.OnCustomizationsChanged(fieldLayout, customizationType);
				if (dataPresenterAction2 != dataPresenterAction || list != null)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataPresenterAction>();
						for (int j = 0; j < i; j++)
						{
							list.Add(this._actions[j]);
						}
					}
					if (dataPresenterAction2 != null)
					{
						list.Add(dataPresenterAction2);
					}
				}
			}
			if (list == null)
			{
				return this;
			}
			if (list.Count == 0)
			{
				return null;
			}
			return new global::Infragistics.Windows.DataPresenter.DataPresenterCompositeAction(list.ToArray());
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00018410 File Offset: 0x00016610
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			foreach (global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction in this._actions)
			{
				dataPresenterAction.OnRecordsUndeleted(oldDataTimeToRecords);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00018440 File Offset: 0x00016640
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataPresenterAction> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataPresenterAction>();
			bool flag = false;
			foreach (global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction in this._actions)
			{
				global::Infragistics.Windows.Helpers.ActionHistory.ActionBase actionBase = dataPresenterAction.PerformInternal(context);
				if (actionBase == global::Infragistics.Windows.Helpers.ActionHistory.NoUndoAction)
				{
					flag = true;
				}
				else if (actionBase != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction2 = actionBase as global::Infragistics.Windows.DataPresenter.DataPresenterAction;
					if (dataPresenterAction2 != null)
					{
						list.Add(dataPresenterAction2);
					}
				}
			}
			if (flag)
			{
				return global::Infragistics.Windows.Helpers.ActionHistory.NoUndoAction;
			}
			if (list.Count > 0)
			{
				if (this._mirrorUndoOrder)
				{
					list.Reverse();
				}
				return new global::Infragistics.Windows.DataPresenter.DataPresenterCompositeAction(list.ToArray())
				{
					_mirrorUndoOrder = this._mirrorUndoOrder
				};
			}
			return null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000184E0 File Offset: 0x000166E0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("CompositeAction:");
			foreach (global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction in this._actions)
			{
				stringBuilder.AppendLine("\t" + dataPresenterAction.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040001DC RID: 476
		private global::Infragistics.Windows.DataPresenter.DataPresenterAction[] _actions;

		// Token: 0x040001DD RID: 477
		internal bool _mirrorUndoOrder;
	}
}
