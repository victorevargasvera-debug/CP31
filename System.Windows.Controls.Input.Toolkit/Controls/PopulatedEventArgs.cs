using System;
using System.Collections;

namespace System.Windows.Controls
{
	// Token: 0x02000010 RID: 16
	public class PopulatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00005B4B File Offset: 0x00003D4B
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00005B53 File Offset: 0x00003D53
		public global::System.Collections.IEnumerable Data { get; private set; }

		// Token: 0x0600010F RID: 271 RVA: 0x00005B5C File Offset: 0x00003D5C
		public PopulatedEventArgs(global::System.Collections.IEnumerable data)
		{
			this.Data = data;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005B6B File Offset: 0x00003D6B
		public PopulatedEventArgs(global::System.Collections.IEnumerable data, global::System.Windows.RoutedEvent routedEvent) : base(routedEvent)
		{
			this.Data = data;
		}
	}
}
