using System;
using System.Windows;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000131 RID: 305
	public abstract class CancelableRoutedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00021F12 File Offset: 0x00020112
		public CancelableRoutedEventArgs()
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00021F1A File Offset: 0x0002011A
		public CancelableRoutedEventArgs(global::System.Windows.RoutedEvent routedEvent) : base(routedEvent)
		{
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00021F23 File Offset: 0x00020123
		public CancelableRoutedEventArgs(global::System.Windows.RoutedEvent routedEvent, object source) : base(routedEvent, source)
		{
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00021F2D File Offset: 0x0002012D
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00021F35 File Offset: 0x00020135
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

		// Token: 0x040004B7 RID: 1207
		private bool _cancel;
	}
}
