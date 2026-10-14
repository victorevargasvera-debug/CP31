using System;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000113 RID: 275
	internal class ClearFilterAction : global::System.Windows.Input.ICommand
	{
		// Token: 0x06000E8E RID: 3726 RVA: 0x0003E20B File Offset: 0x0003C40B
		internal ClearFilterAction(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo info)
		{
			this._info = info;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0003E21A File Offset: 0x0003C41A
		public bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000E90 RID: 3728 RVA: 0x0003E220 File Offset: 0x0003C420
		// (remove) Token: 0x06000E91 RID: 3729 RVA: 0x0003E258 File Offset: 0x0003C458
		public event global::System.EventHandler CanExecuteChanged;

		// Token: 0x06000E92 RID: 3730 RVA: 0x0003E28D File Offset: 0x0003C48D
		public void Execute(object parameter)
		{
			this._info.RecordFilter.Clear(true);
		}

		// Token: 0x040005A7 RID: 1447
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _info;
	}
}
