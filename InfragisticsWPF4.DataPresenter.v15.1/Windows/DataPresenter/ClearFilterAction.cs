using System;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200012F RID: 303
	internal class ClearFilterAction : global::System.Windows.Input.ICommand
	{
		// Token: 0x060011EF RID: 4591 RVA: 0x0004ED03 File Offset: 0x0004CF03
		internal ClearFilterAction(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo info)
		{
			this._info = info;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0004ED12 File Offset: 0x0004CF12
		public bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x060011F1 RID: 4593 RVA: 0x0004ED18 File Offset: 0x0004CF18
		// (remove) Token: 0x060011F2 RID: 4594 RVA: 0x0004ED50 File Offset: 0x0004CF50
		public event global::System.EventHandler CanExecuteChanged;

		// Token: 0x060011F3 RID: 4595 RVA: 0x0004ED85 File Offset: 0x0004CF85
		public void Execute(object parameter)
		{
			this._info.RecordFilter.Clear(true);
		}

		// Token: 0x04000746 RID: 1862
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _info;
	}
}
