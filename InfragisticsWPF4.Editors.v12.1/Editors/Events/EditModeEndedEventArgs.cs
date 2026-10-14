using System;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x020000B7 RID: 183
	public class EditModeEndedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060009F5 RID: 2549 RVA: 0x0002D691 File Offset: 0x0002B891
		public EditModeEndedEventArgs(bool changesAccepted)
		{
			this._changesAccepted = changesAccepted;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0002D6A0 File Offset: 0x0002B8A0
		public bool ChangesAccepted
		{
			get
			{
				return this._changesAccepted;
			}
		}

		// Token: 0x0400037D RID: 893
		private bool _changesAccepted;
	}
}
