using System;
using System.Windows;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200003C RID: 60
	public class TabClosingRoutedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x00055D60 File Offset: 0x00053F60
		public TabClosingRoutedEventArgs()
		{
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00055D74 File Offset: 0x00053F74
		public TabClosingRoutedEventArgs(global::System.Windows.RoutedEvent e) : base(e)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00055D88 File Offset: 0x00053F88
		public TabClosingRoutedEventArgs(global::System.Windows.RoutedEvent e, object source) : base(e, source)
		{
		}

		// Token: 0x04000229 RID: 553
		public bool Cancel;
	}
}
