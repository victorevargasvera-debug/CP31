using System;
using System.Diagnostics;

namespace CefSharp.Structs
{
	// Token: 0x020000AF RID: 175
	[global::System.Diagnostics.DebuggerDisplay("X = {X}, Y = {Y}, Width = {Width}, Height = {Height}")]
	public struct Rect
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00008484 File Offset: 0x00006684
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x0000848C File Offset: 0x0000668C
		public int X { get; private set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00008495 File Offset: 0x00006695
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x0000849D File Offset: 0x0000669D
		public int Y { get; private set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x000084A6 File Offset: 0x000066A6
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x000084AE File Offset: 0x000066AE
		public int Width { get; private set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x000084B7 File Offset: 0x000066B7
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x000084BF File Offset: 0x000066BF
		public int Height { get; private set; }

		// Token: 0x0600055A RID: 1370 RVA: 0x000084C8 File Offset: 0x000066C8
		public Rect(int x, int y, int width, int height)
		{
			this = default(global::CefSharp.Structs.Rect);
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000084F0 File Offset: 0x000066F0
		public global::CefSharp.Structs.Rect ScaleByDpi(float dpi)
		{
			int x = (int)global::System.Math.Ceiling((double)((float)this.X / dpi));
			int y = (int)global::System.Math.Ceiling((double)((float)this.Y / dpi));
			int width = (int)global::System.Math.Ceiling((double)((float)this.Width / dpi));
			int height = (int)global::System.Math.Ceiling((double)((float)this.Height / dpi));
			return new global::CefSharp.Structs.Rect(x, y, width, height);
		}
	}
}
