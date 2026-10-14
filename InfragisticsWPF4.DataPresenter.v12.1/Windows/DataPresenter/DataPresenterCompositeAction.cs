using System;
using System.Collections.Generic;
using System.Text;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006B RID: 107
	internal class DataPresenterCompositeAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x00015F2C File Offset: 0x0001412C
		internal DataPresenterCompositeAction(params global::Infragistics.Windows.DataPresenter.DataPresenterAction[] actions) : base(actions[0].DataPresenter)
		{
			this._actions = actions;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00015F44 File Offset: 0x00014144
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			foreach (global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction in this._actions)
			{
				dataPresenterAction.AddUndeleteDescendantInfo(descendantInfo);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00015F74 File Offset: 0x00014174
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

		// Token: 0x060005AE RID: 1454 RVA: 0x00015FAC File Offset: 0x000141AC
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

		// Token: 0x060005AF RID: 1455 RVA: 0x00016034 File Offset: 0x00014234
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			foreach (global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction in this._actions)
			{
				dataPresenterAction.OnRecordsUndeleted(oldDataTimeToRecords);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00016064 File Offset: 0x00014264
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
				return new global::Infragistics.Windows.DataPresenter.DataPresenterCompositeAction(list.ToArray());
			}
			return null;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000160E4 File Offset: 0x000142E4
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

		// Token: 0x040001A4 RID: 420
		private global::Infragistics.Windows.DataPresenter.DataPresenterAction[] _actions;
	}
}
