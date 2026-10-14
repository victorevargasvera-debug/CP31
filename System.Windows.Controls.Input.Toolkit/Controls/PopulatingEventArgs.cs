using System;

namespace System.Windows.Controls
{
	// Token: 0x0200000C RID: 12
	public class PopulatingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000039E4 File Offset: 0x00001BE4
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000039EC File Offset: 0x00001BEC
		public string Parameter { get; private set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000039F5 File Offset: 0x00001BF5
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000039FD File Offset: 0x00001BFD
		public bool Cancel { get; set; }

		// Token: 0x06000085 RID: 133 RVA: 0x00003A06 File Offset: 0x00001C06
		public PopulatingEventArgs(string parameter)
		{
			this.Parameter = parameter;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003A15 File Offset: 0x00001C15
		public PopulatingEventArgs(string parameter, global::System.Windows.RoutedEvent routedEvent) : base(routedEvent)
		{
			this.Parameter = parameter;
		}
	}
}
