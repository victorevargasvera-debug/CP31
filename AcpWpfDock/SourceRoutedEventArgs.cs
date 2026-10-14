using System;
using System.Windows;

namespace DevComponents.WpfDock
{
	// Token: 0x02000036 RID: 54
	public class SourceRoutedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600026C RID: 620 RVA: 0x00040848 File Offset: 0x0003EA48
		public SourceRoutedEventArgs()
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00040864 File Offset: 0x0003EA64
		public SourceRoutedEventArgs(global::System.Windows.RoutedEvent e) : base(e)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00040880 File Offset: 0x0003EA80
		public SourceRoutedEventArgs(global::System.Windows.RoutedEvent e, object source) : base(e, source)
		{
		}

		// Token: 0x04000194 RID: 404
		public global::DevComponents.WpfDock.eEventActionSource EventActionSource = global::DevComponents.WpfDock.eEventActionSource.Code;
	}
}
