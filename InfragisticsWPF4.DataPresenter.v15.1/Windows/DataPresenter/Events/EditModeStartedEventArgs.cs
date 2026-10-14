using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C2 RID: 706
	public class EditModeStartedEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x0600224B RID: 8779 RVA: 0x0009799B File Offset: 0x00095B9B
		public EditModeStartedEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor) : base(cell, editor)
		{
		}
	}
}
