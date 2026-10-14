using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001B9 RID: 441
	public class RoutedEventWrapper
	{
		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x0006E990 File Offset: 0x0006CB90
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x0006E998 File Offset: 0x0006CB98
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

		// Token: 0x04000A23 RID: 2595
		private global::System.Windows.RoutedEvent _routedEvent;
	}
}
