using System;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002CA RID: 714
	public class FieldChooserOpeningEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x0600226B RID: 8811 RVA: 0x00097B3D File Offset: 0x00095D3D
		internal FieldChooserOpeningEventArgs(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
		{
			this._toolWindow = toolWindow;
			this._fieldChooser = fieldChooser;
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x00097B53 File Offset: 0x00095D53
		public global::Infragistics.Windows.DataPresenter.FieldChooser FieldChooser
		{
			get
			{
				return this._fieldChooser;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x00097B5B File Offset: 0x00095D5B
		public global::Infragistics.Windows.Controls.ToolWindow ToolWindow
		{
			get
			{
				return this._toolWindow;
			}
		}

		// Token: 0x0400111C RID: 4380
		private global::Infragistics.Windows.DataPresenter.FieldChooser _fieldChooser;

		// Token: 0x0400111D RID: 4381
		private global::Infragistics.Windows.Controls.ToolWindow _toolWindow;
	}
}
