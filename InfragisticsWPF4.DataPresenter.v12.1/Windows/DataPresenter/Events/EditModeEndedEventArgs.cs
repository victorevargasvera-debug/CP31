using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000281 RID: 641
	public class EditModeEndedEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x06001DCE RID: 7630 RVA: 0x000812A3 File Offset: 0x0007F4A3
		public EditModeEndedEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor, bool changesAccepted) : base(cell, editor)
		{
			this._changesAccepted = changesAccepted;
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x000812B4 File Offset: 0x0007F4B4
		public bool ChangesAccepted
		{
			get
			{
				return this._changesAccepted;
			}
		}

		// Token: 0x04000EA7 RID: 3751
		private bool _changesAccepted;
	}
}
