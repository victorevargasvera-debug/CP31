using System;

namespace CefSharp.Structs
{
	// Token: 0x020000AD RID: 173
	public struct Point
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00008419 File Offset: 0x00006619
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00008421 File Offset: 0x00006621
		public int X { get; private set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0000842A File Offset: 0x0000662A
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00008432 File Offset: 0x00006632
		public int Y { get; private set; }

		// Token: 0x0600054C RID: 1356 RVA: 0x0000843B File Offset: 0x0000663B
		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
	}
}
