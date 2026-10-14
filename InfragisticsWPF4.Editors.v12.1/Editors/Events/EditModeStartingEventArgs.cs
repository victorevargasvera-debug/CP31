using System;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x020000B4 RID: 180
	public class EditModeStartingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0002D61D File Offset: 0x0002B81D
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0002D625 File Offset: 0x0002B825
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

		// Token: 0x04000379 RID: 889
		private bool _cancel;
	}
}
