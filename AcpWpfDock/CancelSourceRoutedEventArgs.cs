using System;
using System.Windows;

namespace DevComponents.WpfDock
{
	// Token: 0x02000035 RID: 53
	public class CancelSourceRoutedEventArgs : global::DevComponents.WpfDock.SourceRoutedEventArgs
	{
		// Token: 0x06000269 RID: 617 RVA: 0x00040808 File Offset: 0x0003EA08
		public CancelSourceRoutedEventArgs()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0004081C File Offset: 0x0003EA1C
		public CancelSourceRoutedEventArgs(global::System.Windows.RoutedEvent e) : base(e)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00040830 File Offset: 0x0003EA30
		public CancelSourceRoutedEventArgs(global::System.Windows.RoutedEvent e, object source) : base(e, source)
		{
		}

		// Token: 0x04000193 RID: 403
		public bool Cancel;
	}
}
