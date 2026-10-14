using System;
using System.Windows;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000150 RID: 336
	public abstract class CancelableRoutedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000B63 RID: 2915 RVA: 0x00025ADA File Offset: 0x00023CDA
		public CancelableRoutedEventArgs()
		{
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00025AE2 File Offset: 0x00023CE2
		public CancelableRoutedEventArgs(global::System.Windows.RoutedEvent routedEvent) : base(routedEvent)
		{
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00025AEB File Offset: 0x00023CEB
		public CancelableRoutedEventArgs(global::System.Windows.RoutedEvent routedEvent, object source) : base(routedEvent, source)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00025AF5 File Offset: 0x00023CF5
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00025AFD File Offset: 0x00023CFD
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

		// Token: 0x0400056D RID: 1389
		private bool _cancel;
	}
}
