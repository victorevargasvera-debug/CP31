using System;

namespace CefSharp
{
	// Token: 0x02000098 RID: 152
	public struct DraggableRegion
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00006B0E File Offset: 0x00004D0E
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00006B16 File Offset: 0x00004D16
		public int Width { get; private set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00006B1F File Offset: 0x00004D1F
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00006B27 File Offset: 0x00004D27
		public int Height { get; private set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00006B30 File Offset: 0x00004D30
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00006B38 File Offset: 0x00004D38
		public int X { get; private set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00006B41 File Offset: 0x00004D41
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00006B49 File Offset: 0x00004D49
		public int Y { get; private set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00006B52 File Offset: 0x00004D52
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00006B5A File Offset: 0x00004D5A
		public bool Draggable { get; private set; }

		// Token: 0x0600045C RID: 1116 RVA: 0x00006B63 File Offset: 0x00004D63
		public DraggableRegion(int width, int height, int x, int y, bool draggable)
		{
			this = default(global::CefSharp.DraggableRegion);
			this.Width = width;
			this.Height = height;
			this.X = x;
			this.Y = y;
			this.Draggable = draggable;
		}
	}
}
