using System;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x020000BE RID: 190
	public class EditModeEndedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x0002F6F3 File Offset: 0x0002D8F3
		public EditModeEndedEventArgs(bool changesAccepted)
		{
			this._changesAccepted = changesAccepted;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0002F702 File Offset: 0x0002D902
		public bool ChangesAccepted
		{
			get
			{
				return this._changesAccepted;
			}
		}

		// Token: 0x040003B4 RID: 948
		private bool _changesAccepted;
	}
}
