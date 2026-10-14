using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DC RID: 476
	public class RoutedEventWrapper
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x00081CFC File Offset: 0x0007FEFC
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x00081D04 File Offset: 0x0007FF04
		public global::System.Windows.RoutedEvent RoutedEvent
		{
			get
			{
				return this._routedEvent;
			}
			set
			{
				this._routedEvent = value;
			}
		}

		// Token: 0x04000BF6 RID: 3062
		private global::System.Windows.RoutedEvent _routedEvent;
	}
}
