using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200027F RID: 639
	public class EditModeStartedEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x06001DC7 RID: 7623 RVA: 0x0008123B File Offset: 0x0007F43B
		public EditModeStartedEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor) : base(cell, editor)
		{
		}
	}
}
