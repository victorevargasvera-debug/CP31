using System;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000114 RID: 276
	internal class CustomFilterAction : global::System.Windows.Input.ICommand
	{
		// Token: 0x06000E93 RID: 3731 RVA: 0x0003E2A0 File Offset: 0x0003C4A0
		internal CustomFilterAction(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo info)
		{
			this._info = info;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0003E2AF File Offset: 0x0003C4AF
		public bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06000E95 RID: 3733 RVA: 0x0003E2B4 File Offset: 0x0003C4B4
		// (remove) Token: 0x06000E96 RID: 3734 RVA: 0x0003E2EC File Offset: 0x0003C4EC
		public event global::System.EventHandler CanExecuteChanged;

		// Token: 0x06000E97 RID: 3735 RVA: 0x0003E324 File Offset: 0x0003C524
		public void Execute(object parameter)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._info.Field.Owner;
			if (owner != null)
			{
				owner.ShowCustomFilterSelectionControl(this._info.RecordFilter, this._info.RecordManager);
			}
		}

		// Token: 0x040005A9 RID: 1449
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _info;
	}
}
