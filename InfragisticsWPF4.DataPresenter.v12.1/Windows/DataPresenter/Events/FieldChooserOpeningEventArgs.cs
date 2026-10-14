using System;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000287 RID: 647
	public class FieldChooserOpeningEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001DE3 RID: 7651 RVA: 0x000813AC File Offset: 0x0007F5AC
		internal FieldChooserOpeningEventArgs(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
		{
			this._toolWindow = toolWindow;
			this._fieldChooser = fieldChooser;
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000813C2 File Offset: 0x0007F5C2
		public global::Infragistics.Windows.DataPresenter.FieldChooser FieldChooser
		{
			get
			{
				return this._fieldChooser;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x000813CA File Offset: 0x0007F5CA
		public global::Infragistics.Windows.Controls.ToolWindow ToolWindow
		{
			get
			{
				return this._toolWindow;
			}
		}

		// Token: 0x04000EB2 RID: 3762
		private global::Infragistics.Windows.DataPresenter.FieldChooser _fieldChooser;

		// Token: 0x04000EB3 RID: 3763
		private global::Infragistics.Windows.Controls.ToolWindow _toolWindow;
	}
}
