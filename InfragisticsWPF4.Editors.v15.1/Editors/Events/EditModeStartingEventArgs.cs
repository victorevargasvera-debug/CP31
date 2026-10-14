using System;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x020000BB RID: 187
	public class EditModeStartingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002F67F File Offset: 0x0002D87F
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0002F687 File Offset: 0x0002D887
		public bool Cancel
		{
			get
			{
				return this._cancel;
			}
			set
			{
				this._cancel = value;
			}
		}

		// Token: 0x040003B0 RID: 944
		private bool _cancel;
	}
}
