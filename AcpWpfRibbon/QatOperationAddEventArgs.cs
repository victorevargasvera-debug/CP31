using System;
using System.Windows;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200004C RID: 76
	public class QatOperationAddEventArgs : global::DevComponents.WpfRibbon.QatOperationEventArgs
	{
		// Token: 0x06000390 RID: 912 RVA: 0x0004D584 File Offset: 0x0004B784
		public QatOperationAddEventArgs(object item) : base(item)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0004D598 File Offset: 0x0004B798
		public QatOperationAddEventArgs(object item, global::System.Windows.RoutedEvent e) : base(item, e)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0004D5B0 File Offset: 0x0004B7B0
		public QatOperationAddEventArgs(object item, global::System.Windows.RoutedEvent e, object originalSource) : base(item, e, originalSource)
		{
		}

		// Token: 0x040001A7 RID: 423
		public object ItemCopy;
	}
}
