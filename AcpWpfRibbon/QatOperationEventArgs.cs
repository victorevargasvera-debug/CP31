using System;
using System.Windows;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200004D RID: 77
	public class QatOperationEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000393 RID: 915 RVA: 0x0004D5C8 File Offset: 0x0004B7C8
		public QatOperationEventArgs(object item)
		{
			this.Item = item;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0004D5E4 File Offset: 0x0004B7E4
		public QatOperationEventArgs(object item, global::System.Windows.RoutedEvent e) : base(e)
		{
			this.Item = item;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0004D600 File Offset: 0x0004B800
		public QatOperationEventArgs(object item, global::System.Windows.RoutedEvent e, object originalSource) : base(e, originalSource)
		{
			this.Item = item;
		}

		// Token: 0x040001A8 RID: 424
		public readonly object Item;

		// Token: 0x040001A9 RID: 425
		public bool Cancel;
	}
}
