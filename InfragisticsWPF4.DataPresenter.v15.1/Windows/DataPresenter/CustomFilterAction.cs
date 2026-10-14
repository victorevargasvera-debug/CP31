using System;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000130 RID: 304
	internal class CustomFilterAction : global::System.Windows.Input.ICommand
	{
		// Token: 0x060011F4 RID: 4596 RVA: 0x0004ED98 File Offset: 0x0004CF98
		internal CustomFilterAction(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo info)
		{
			this._info = info;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0004EDA7 File Offset: 0x0004CFA7
		public bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x060011F6 RID: 4598 RVA: 0x0004EDAC File Offset: 0x0004CFAC
		// (remove) Token: 0x060011F7 RID: 4599 RVA: 0x0004EDE4 File Offset: 0x0004CFE4
		public event global::System.EventHandler CanExecuteChanged;

		// Token: 0x060011F8 RID: 4600 RVA: 0x0004EE1C File Offset: 0x0004D01C
		public void Execute(object parameter)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._info.Field.Owner;
			if (owner != null)
			{
				owner.ShowCustomFilterSelectionControl(this._info.RecordFilter, this._info.RecordManager);
			}
		}

		// Token: 0x04000748 RID: 1864
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _info;
	}
}
