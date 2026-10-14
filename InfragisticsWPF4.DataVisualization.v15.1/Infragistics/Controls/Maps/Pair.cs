using System;

namespace Infragistics.Controls.Maps
{
	// Token: 0x020000EE RID: 238
	internal class Pair<T1, T2>
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x0002C6B0 File Offset: 0x0002A8B0
		public Pair(T1 first, T2 second)
		{
			this.First = first;
			this.Second = second;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0002C6C6 File Offset: 0x0002A8C6
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0002C6CE File Offset: 0x0002A8CE
		public T1 First { get; set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0002C6D7 File Offset: 0x0002A8D7
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0002C6DF File Offset: 0x0002A8DF
		public T2 Second { get; set; }
	}
}
